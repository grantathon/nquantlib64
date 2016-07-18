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

public class DividendVanillaOption : Instrument {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal DividendVanillaOption(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.DividendVanillaOption_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DividendVanillaOption obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DividendVanillaOption() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_DividendVanillaOption(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public DividendVanillaOption(Payoff payoff, Exercise exercise, DateVector dividendDates, DoubleVector dividends) : this(NQuantLibcPINVOKE.new_DividendVanillaOption(Payoff.getCPtr(payoff), Exercise.getCPtr(exercise), DateVector.getCPtr(dividendDates), DoubleVector.getCPtr(dividends)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SampledCurve priceCurve() {
    SampledCurve ret = new SampledCurve(NQuantLibcPINVOKE.DividendVanillaOption_priceCurve(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double impliedVolatility(double targetValue, GeneralizedBlackScholesProcess process, double accuracy, uint maxEvaluations, double minVol, double maxVol) {
    double ret = NQuantLibcPINVOKE.DividendVanillaOption_impliedVolatility__SWIG_0(swigCPtr, targetValue, GeneralizedBlackScholesProcess.getCPtr(process), accuracy, maxEvaluations, minVol, maxVol);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double impliedVolatility(double targetValue, GeneralizedBlackScholesProcess process, double accuracy, uint maxEvaluations, double minVol) {
    double ret = NQuantLibcPINVOKE.DividendVanillaOption_impliedVolatility__SWIG_1(swigCPtr, targetValue, GeneralizedBlackScholesProcess.getCPtr(process), accuracy, maxEvaluations, minVol);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double impliedVolatility(double targetValue, GeneralizedBlackScholesProcess process, double accuracy, uint maxEvaluations) {
    double ret = NQuantLibcPINVOKE.DividendVanillaOption_impliedVolatility__SWIG_2(swigCPtr, targetValue, GeneralizedBlackScholesProcess.getCPtr(process), accuracy, maxEvaluations);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double impliedVolatility(double targetValue, GeneralizedBlackScholesProcess process, double accuracy) {
    double ret = NQuantLibcPINVOKE.DividendVanillaOption_impliedVolatility__SWIG_3(swigCPtr, targetValue, GeneralizedBlackScholesProcess.getCPtr(process), accuracy);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double impliedVolatility(double targetValue, GeneralizedBlackScholesProcess process) {
    double ret = NQuantLibcPINVOKE.DividendVanillaOption_impliedVolatility__SWIG_4(swigCPtr, targetValue, GeneralizedBlackScholesProcess.getCPtr(process));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double delta() {
    double ret = NQuantLibcPINVOKE.DividendVanillaOption_delta(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double gamma() {
    double ret = NQuantLibcPINVOKE.DividendVanillaOption_gamma(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double theta() {
    double ret = NQuantLibcPINVOKE.DividendVanillaOption_theta(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double thetaPerDay() {
    double ret = NQuantLibcPINVOKE.DividendVanillaOption_thetaPerDay(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double vega() {
    double ret = NQuantLibcPINVOKE.DividendVanillaOption_vega(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double rho() {
    double ret = NQuantLibcPINVOKE.DividendVanillaOption_rho(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double dividendRho() {
    double ret = NQuantLibcPINVOKE.DividendVanillaOption_dividendRho(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double strikeSensitivity() {
    double ret = NQuantLibcPINVOKE.DividendVanillaOption_strikeSensitivity(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
