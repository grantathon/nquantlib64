/* -*- mode: c++; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*- */

/*
 Copyright (C) 2008 Andreas Gaida
 Copyright (C) 2008, 2009 Ralph Schreyer
 Copyright (C) 2008, 2009 Klaus Spanderen

 This file is part of QuantLib, a free-software/open-source library
 for financial quantitative analysts and developers - http://quantlib.org/

 QuantLib is free software: you can redistribute it and/or modify it
 under the terms of the QuantLib license.  You should have received a
 copy of the license along with this program; if not, please email
 <quantlib-dev@lists.sf.net>. The license is also available online at
 <http://quantlib.org/license.shtml>.

 This program is distributed in the hope that it will be useful, but WITHOUT
 ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 FOR A PARTICULAR PURPOSE.  See the license for more details.
*/

#include <ql/pricingengines/barrier/fdhestonbarrierengine.hpp>
#include <ql/methods/finitedifferences/stepconditions/fdmstepconditioncomposite.hpp>
#include <ql/methods/finitedifferences/utilities/fdmdividendhandler.hpp>
#include <ql/methods/finitedifferences/meshers/fdmhestonvariancemesher.hpp>
#include <ql/methods/finitedifferences/utilities/fdmdirichletboundary.hpp>
#include <ql/methods/finitedifferences/utilities/fdminnervaluecalculator.hpp>
#include <ql/methods/finitedifferences/operators/fdmlinearoplayout.hpp>
#include <ql/methods/finitedifferences/meshers/fdmmeshercomposite.hpp>
#include <ql/methods/finitedifferences/meshers/fdmblackscholesmesher.hpp>
#include <ql/pricingengines/barrier/fdhestonrebateengine.hpp>
#include <ql/pricingengines/vanilla/fdhestonvanillaengine.hpp>

namespace QuantLib {

    FdHestonBarrierEngine::FdHestonBarrierEngine(
            const boost::shared_ptr<HestonModel>& model,
            Size tGrid, Size xGrid, Size vGrid, Size dampingSteps,
            const FdmSchemeDesc& schemeDesc,
            const boost::shared_ptr<LocalVolTermStructure>& leverageFct)
    : GenericModelEngine<HestonModel,
                        DividendBarrierOption::arguments,
                        DividendBarrierOption::results>(model),
      tGrid_(tGrid), xGrid_(xGrid), 
      vGrid_(vGrid), dampingSteps_(dampingSteps),
      schemeDesc_(schemeDesc),
      leverageFct_(leverageFct) {
    }

    void FdHestonBarrierEngine::calculate() const {

        // 1. Mesher
        const boost::shared_ptr<HestonProcess>& process = model_->process();
        const Time maturity = process->time(arguments_.exercise->lastDate());

        // 1.1 The variance mesher
        const Size tGridMin = 5;
        const boost::shared_ptr<FdmHestonVarianceMesher> varianceMesher(
            new FdmHestonVarianceMesher(vGrid_, process, maturity,
                                        std::max(tGridMin, tGrid_/50)));

        // 1.2 The equity mesher
        const boost::shared_ptr<StrikedTypePayoff> payoff =
            boost::dynamic_pointer_cast<StrikedTypePayoff>(arguments_.payoff);

        Real xMin=Null<Real>();
        Real xMax=Null<Real>();
        if (   arguments_.barrierType == Barrier::DownIn
            || arguments_.barrierType == Barrier::DownOut) {
            xMin = std::log(arguments_.barrier);
        }
        if (   arguments_.barrierType == Barrier::UpIn
            || arguments_.barrierType == Barrier::UpOut) {
            xMax = std::log(arguments_.barrier);
        }

        const boost::shared_ptr<Fdm1dMesher> equityMesher(
            new FdmBlackScholesMesher(
                xGrid_,
                FdmBlackScholesMesher::processHelper(
                    process->s0(), process->dividendYield(), 
                    process->riskFreeRate(), varianceMesher->volaEstimate()),
                maturity, payoff->strike(), xMin, xMax));
        
        const boost::shared_ptr<FdmMesher> mesher (
            new FdmMesherComposite(equityMesher, varianceMesher));

        // 2. Calculator
        boost::shared_ptr<FdmInnerValueCalculator> calculator(
                                new FdmLogInnerValue(payoff, mesher, 0));

        // 3. Step conditions
        std::list<boost::shared_ptr<StepCondition<Array> > > stepConditions;
        std::list<std::vector<Time> > stoppingTimes;

        // 3.1 Step condition if discrete dividends
        boost::shared_ptr<FdmDividendHandler> dividendCondition(
            new FdmDividendHandler(arguments_.cashFlow, mesher,
                                   process->riskFreeRate()->referenceDate(),
                                   process->riskFreeRate()->dayCounter(), 0));

        if(!arguments_.cashFlow.empty()) {
            stepConditions.push_back(dividendCondition);
            stoppingTimes.push_back(dividendCondition->dividendTimes());
        }

        QL_REQUIRE(arguments_.exercise->type() == Exercise::European,
                   "only european style option are supported");

        boost::shared_ptr<FdmStepConditionComposite> conditions(
                new FdmStepConditionComposite(stoppingTimes, stepConditions));

        // 4. Boundary conditions
        FdmBoundaryConditionSet boundaries;
        if (   arguments_.barrierType == Barrier::DownIn
            || arguments_.barrierType == Barrier::DownOut) {
            boundaries.push_back(FdmBoundaryConditionSet::value_type(
                new FdmDirichletBoundary(mesher, arguments_.rebate, 0,
                                         FdmDirichletBoundary::Lower)));

        }
        if (   arguments_.barrierType == Barrier::UpIn
            || arguments_.barrierType == Barrier::UpOut) {
            boundaries.push_back(FdmBoundaryConditionSet::value_type(
                new FdmDirichletBoundary(mesher, arguments_.rebate, 0,
                                         FdmDirichletBoundary::Upper)));
        }

        // 5. Solver
        FdmSolverDesc solverDesc = { mesher, boundaries, conditions,
                                     calculator, maturity,
                                     tGrid_, dampingSteps_ };

        boost::shared_ptr<FdmHestonSolver> solver(new FdmHestonSolver(
                    Handle<HestonProcess>(process), solverDesc, schemeDesc_,
                    Handle<FdmQuantoHelper>(), leverageFct_));

        const Real spot = process->s0()->value();
        results_.value = solver->valueAt(spot, process->v0());
        results_.delta = solver->deltaAt(spot, process->v0());
        results_.gamma = solver->gammaAt(spot, process->v0());
        results_.theta = solver->thetaAt(spot, process->v0());

        // 6. Calculate vanilla option and rebate for in-barriers
        if (   arguments_.barrierType == Barrier::DownIn
            || arguments_.barrierType == Barrier::UpIn) {
            // Cast the payoff
            boost::shared_ptr<StrikedTypePayoff> payoff =
                    boost::dynamic_pointer_cast<StrikedTypePayoff>(
                                                            arguments_.payoff);
            // Calculate the vanilla option
            boost::shared_ptr<DividendVanillaOption> vanillaOption(
                new DividendVanillaOption(payoff,arguments_.exercise,
                                          dividendCondition->dividendDates(), 
                                          dividendCondition->dividends()));
            vanillaOption->setPricingEngine(boost::shared_ptr<PricingEngine>(
                    new FdHestonVanillaEngine(*model_, tGrid_, xGrid_, 
                                              vGrid_, dampingSteps_,
                                              schemeDesc_)));
            // Calculate the rebate value
            boost::shared_ptr<DividendBarrierOption> rebateOption(
                new DividendBarrierOption(arguments_.barrierType,
                                          arguments_.barrier,
                                          arguments_.rebate,
                                          payoff, arguments_.exercise,
                                          dividendCondition->dividendDates(), 
                                          dividendCondition->dividends()));
            const Size xGridMin = 20;
            const Size vGridMin = 10;
            const Size rebateDampingSteps 
                = (dampingSteps_ > 0) ? std::min(Size(1), dampingSteps_/2) : 0; 
            rebateOption->setPricingEngine(boost::shared_ptr<PricingEngine>(
                    new FdHestonRebateEngine(*model_, tGrid_, 
                                             std::max(xGridMin, xGrid_/4), 
                                             std::max(vGridMin, vGrid_/4),
                                             rebateDampingSteps,
                                             schemeDesc_)));

            results_.value = vanillaOption->NPV()   + rebateOption->NPV()
                                                    - results_.value;
            results_.delta = vanillaOption->delta() + rebateOption->delta()
                                                    - results_.delta;
            results_.gamma = vanillaOption->gamma() + rebateOption->gamma()
                                                    - results_.gamma;
            results_.theta = vanillaOption->theta() + rebateOption->theta()
                                                    - results_.theta;
        }
    }
}
