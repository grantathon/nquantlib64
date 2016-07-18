//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QuantLib {

public class FittedBondDiscountCurve : YieldTermStructure {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FittedBondDiscountCurve(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.FittedBondDiscountCurve_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FittedBondDiscountCurve obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FittedBondDiscountCurve() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_FittedBondDiscountCurve(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FittedBondDiscountCurve(uint settlementDays, Calendar calendar, RateHelperVector helpers, DayCounter dayCounter, FittingMethod fittingMethod, double accuracy, uint maxEvaluations, QlArray guess, double simplexLambda) : this(NQuantLibcPINVOKE.new_FittedBondDiscountCurve__SWIG_0(settlementDays, Calendar.getCPtr(calendar), RateHelperVector.getCPtr(helpers), DayCounter.getCPtr(dayCounter), FittingMethod.getCPtr(fittingMethod), accuracy, maxEvaluations, QlArray.getCPtr(guess), simplexLambda), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FittedBondDiscountCurve(uint settlementDays, Calendar calendar, RateHelperVector helpers, DayCounter dayCounter, FittingMethod fittingMethod, double accuracy, uint maxEvaluations, QlArray guess) : this(NQuantLibcPINVOKE.new_FittedBondDiscountCurve__SWIG_1(settlementDays, Calendar.getCPtr(calendar), RateHelperVector.getCPtr(helpers), DayCounter.getCPtr(dayCounter), FittingMethod.getCPtr(fittingMethod), accuracy, maxEvaluations, QlArray.getCPtr(guess)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FittedBondDiscountCurve(uint settlementDays, Calendar calendar, RateHelperVector helpers, DayCounter dayCounter, FittingMethod fittingMethod, double accuracy, uint maxEvaluations) : this(NQuantLibcPINVOKE.new_FittedBondDiscountCurve__SWIG_2(settlementDays, Calendar.getCPtr(calendar), RateHelperVector.getCPtr(helpers), DayCounter.getCPtr(dayCounter), FittingMethod.getCPtr(fittingMethod), accuracy, maxEvaluations), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FittedBondDiscountCurve(uint settlementDays, Calendar calendar, RateHelperVector helpers, DayCounter dayCounter, FittingMethod fittingMethod, double accuracy) : this(NQuantLibcPINVOKE.new_FittedBondDiscountCurve__SWIG_3(settlementDays, Calendar.getCPtr(calendar), RateHelperVector.getCPtr(helpers), DayCounter.getCPtr(dayCounter), FittingMethod.getCPtr(fittingMethod), accuracy), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FittedBondDiscountCurve(uint settlementDays, Calendar calendar, RateHelperVector helpers, DayCounter dayCounter, FittingMethod fittingMethod) : this(NQuantLibcPINVOKE.new_FittedBondDiscountCurve__SWIG_4(settlementDays, Calendar.getCPtr(calendar), RateHelperVector.getCPtr(helpers), DayCounter.getCPtr(dayCounter), FittingMethod.getCPtr(fittingMethod)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FittedBondDiscountCurve(Date referenceDate, RateHelperVector helpers, DayCounter dayCounter, FittingMethod fittingMethod, double accuracy, uint maxEvaluations, QlArray guess, double simplexLambda) : this(NQuantLibcPINVOKE.new_FittedBondDiscountCurve__SWIG_5(Date.getCPtr(referenceDate), RateHelperVector.getCPtr(helpers), DayCounter.getCPtr(dayCounter), FittingMethod.getCPtr(fittingMethod), accuracy, maxEvaluations, QlArray.getCPtr(guess), simplexLambda), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FittedBondDiscountCurve(Date referenceDate, RateHelperVector helpers, DayCounter dayCounter, FittingMethod fittingMethod, double accuracy, uint maxEvaluations, QlArray guess) : this(NQuantLibcPINVOKE.new_FittedBondDiscountCurve__SWIG_6(Date.getCPtr(referenceDate), RateHelperVector.getCPtr(helpers), DayCounter.getCPtr(dayCounter), FittingMethod.getCPtr(fittingMethod), accuracy, maxEvaluations, QlArray.getCPtr(guess)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FittedBondDiscountCurve(Date referenceDate, RateHelperVector helpers, DayCounter dayCounter, FittingMethod fittingMethod, double accuracy, uint maxEvaluations) : this(NQuantLibcPINVOKE.new_FittedBondDiscountCurve__SWIG_7(Date.getCPtr(referenceDate), RateHelperVector.getCPtr(helpers), DayCounter.getCPtr(dayCounter), FittingMethod.getCPtr(fittingMethod), accuracy, maxEvaluations), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FittedBondDiscountCurve(Date referenceDate, RateHelperVector helpers, DayCounter dayCounter, FittingMethod fittingMethod, double accuracy) : this(NQuantLibcPINVOKE.new_FittedBondDiscountCurve__SWIG_8(Date.getCPtr(referenceDate), RateHelperVector.getCPtr(helpers), DayCounter.getCPtr(dayCounter), FittingMethod.getCPtr(fittingMethod), accuracy), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FittedBondDiscountCurve(Date referenceDate, RateHelperVector helpers, DayCounter dayCounter, FittingMethod fittingMethod) : this(NQuantLibcPINVOKE.new_FittedBondDiscountCurve__SWIG_9(Date.getCPtr(referenceDate), RateHelperVector.getCPtr(helpers), DayCounter.getCPtr(dayCounter), FittingMethod.getCPtr(fittingMethod)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FittingMethod fitResults() {
    FittingMethod ret = new FittingMethod(NQuantLibcPINVOKE.FittedBondDiscountCurve_fitResults(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
