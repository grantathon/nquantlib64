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

public class DefaultProbabilityTermStructure : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DefaultProbabilityTermStructure(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DefaultProbabilityTermStructure obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DefaultProbabilityTermStructure() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_DefaultProbabilityTermStructure(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_DefaultProbabilityTermStructure __deref__() {
    global::System.IntPtr cPtr = NQuantLibcPINVOKE.DefaultProbabilityTermStructure___deref__(swigCPtr);
    SWIGTYPE_p_DefaultProbabilityTermStructure ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_DefaultProbabilityTermStructure(cPtr, false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isNull() {
    bool ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_isNull(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Observable asObservable() {
    Observable ret = new Observable(NQuantLibcPINVOKE.DefaultProbabilityTermStructure_asObservable(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DefaultProbabilityTermStructure() : this(NQuantLibcPINVOKE.new_DefaultProbabilityTermStructure(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DayCounter dayCounter() {
    DayCounter ret = new DayCounter(NQuantLibcPINVOKE.DefaultProbabilityTermStructure_dayCounter(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Calendar calendar() {
    Calendar ret = new Calendar(NQuantLibcPINVOKE.DefaultProbabilityTermStructure_calendar(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Date referenceDate() {
    Date ret = new Date(NQuantLibcPINVOKE.DefaultProbabilityTermStructure_referenceDate(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Date maxDate() {
    Date ret = new Date(NQuantLibcPINVOKE.DefaultProbabilityTermStructure_maxDate(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double maxTime() {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_maxTime(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double defaultProbability(Date arg0, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_defaultProbability__SWIG_0(swigCPtr, Date.getCPtr(arg0), extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double defaultProbability(Date arg0) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_defaultProbability__SWIG_1(swigCPtr, Date.getCPtr(arg0));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double defaultProbability(double arg0, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_defaultProbability__SWIG_2(swigCPtr, arg0, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double defaultProbability(double arg0) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_defaultProbability__SWIG_3(swigCPtr, arg0);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double defaultProbability(Date arg0, Date arg1, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_defaultProbability__SWIG_4(swigCPtr, Date.getCPtr(arg0), Date.getCPtr(arg1), extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double defaultProbability(Date arg0, Date arg1) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_defaultProbability__SWIG_5(swigCPtr, Date.getCPtr(arg0), Date.getCPtr(arg1));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double defaultProbability(double arg0, double arg1, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_defaultProbability__SWIG_6(swigCPtr, arg0, arg1, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double defaultProbability(double arg0, double arg1) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_defaultProbability__SWIG_7(swigCPtr, arg0, arg1);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double survivalProbability(Date arg0, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_survivalProbability__SWIG_0(swigCPtr, Date.getCPtr(arg0), extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double survivalProbability(Date arg0) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_survivalProbability__SWIG_1(swigCPtr, Date.getCPtr(arg0));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double survivalProbability(double arg0, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_survivalProbability__SWIG_2(swigCPtr, arg0, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double survivalProbability(double arg0) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_survivalProbability__SWIG_3(swigCPtr, arg0);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double defaultDensity(Date arg0, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_defaultDensity__SWIG_0(swigCPtr, Date.getCPtr(arg0), extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double defaultDensity(Date arg0) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_defaultDensity__SWIG_1(swigCPtr, Date.getCPtr(arg0));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double defaultDensity(double arg0, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_defaultDensity__SWIG_2(swigCPtr, arg0, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double defaultDensity(double arg0) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_defaultDensity__SWIG_3(swigCPtr, arg0);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double hazardRate(Date arg0, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_hazardRate__SWIG_0(swigCPtr, Date.getCPtr(arg0), extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double hazardRate(Date arg0) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_hazardRate__SWIG_1(swigCPtr, Date.getCPtr(arg0));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double hazardRate(double arg0, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_hazardRate__SWIG_2(swigCPtr, arg0, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double hazardRate(double arg0) {
    double ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_hazardRate__SWIG_3(swigCPtr, arg0);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void enableExtrapolation() {
    NQuantLibcPINVOKE.DefaultProbabilityTermStructure_enableExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void disableExtrapolation() {
    NQuantLibcPINVOKE.DefaultProbabilityTermStructure_disableExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool allowsExtrapolation() {
    bool ret = NQuantLibcPINVOKE.DefaultProbabilityTermStructure_allowsExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
