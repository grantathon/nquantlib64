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

public class BlackVolTermStructureHandle : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BlackVolTermStructureHandle(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BlackVolTermStructureHandle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BlackVolTermStructureHandle() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_BlackVolTermStructureHandle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public BlackVolTermStructureHandle(BlackVolTermStructure arg0) : this(NQuantLibcPINVOKE.new_BlackVolTermStructureHandle__SWIG_0(BlackVolTermStructure.getCPtr(arg0)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public BlackVolTermStructureHandle() : this(NQuantLibcPINVOKE.new_BlackVolTermStructureHandle__SWIG_1(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public BlackVolTermStructure __deref__() {
    BlackVolTermStructure ret = new BlackVolTermStructure(NQuantLibcPINVOKE.BlackVolTermStructureHandle___deref__(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool empty() {
    bool ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_empty(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Observable asObservable() {
    Observable ret = new Observable(NQuantLibcPINVOKE.BlackVolTermStructureHandle_asObservable(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Date referenceDate() {
    Date ret = new Date(NQuantLibcPINVOKE.BlackVolTermStructureHandle_referenceDate(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DayCounter dayCounter() {
    DayCounter ret = new DayCounter(NQuantLibcPINVOKE.BlackVolTermStructureHandle_dayCounter(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Calendar calendar() {
    Calendar ret = new Calendar(NQuantLibcPINVOKE.BlackVolTermStructureHandle_calendar(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Date maxDate() {
    Date ret = new Date(NQuantLibcPINVOKE.BlackVolTermStructureHandle_maxDate(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double maxTime() {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_maxTime(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double minStrike() {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_minStrike(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double maxStrike() {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_maxStrike(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVol(Date arg0, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackVol__SWIG_0(swigCPtr, Date.getCPtr(arg0), strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVol(Date arg0, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackVol__SWIG_1(swigCPtr, Date.getCPtr(arg0), strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVol(double arg0, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackVol__SWIG_2(swigCPtr, arg0, strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVol(double arg0, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackVol__SWIG_3(swigCPtr, arg0, strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVariance(Date arg0, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackVariance__SWIG_0(swigCPtr, Date.getCPtr(arg0), strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVariance(Date arg0, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackVariance__SWIG_1(swigCPtr, Date.getCPtr(arg0), strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVariance(double arg0, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackVariance__SWIG_2(swigCPtr, arg0, strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackVariance(double arg0, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackVariance__SWIG_3(swigCPtr, arg0, strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVol(Date arg0, Date arg1, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackForwardVol__SWIG_0(swigCPtr, Date.getCPtr(arg0), Date.getCPtr(arg1), strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVol(Date arg0, Date arg1, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackForwardVol__SWIG_1(swigCPtr, Date.getCPtr(arg0), Date.getCPtr(arg1), strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVol(double arg0, double arg1, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackForwardVol__SWIG_2(swigCPtr, arg0, arg1, strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVol(double arg0, double arg1, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackForwardVol__SWIG_3(swigCPtr, arg0, arg1, strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVariance(Date arg0, Date arg1, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackForwardVariance__SWIG_0(swigCPtr, Date.getCPtr(arg0), Date.getCPtr(arg1), strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVariance(Date arg0, Date arg1, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackForwardVariance__SWIG_1(swigCPtr, Date.getCPtr(arg0), Date.getCPtr(arg1), strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVariance(double arg0, double arg1, double strike, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackForwardVariance__SWIG_2(swigCPtr, arg0, arg1, strike, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackForwardVariance(double arg0, double arg1, double strike) {
    double ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_blackForwardVariance__SWIG_3(swigCPtr, arg0, arg1, strike);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void enableExtrapolation() {
    NQuantLibcPINVOKE.BlackVolTermStructureHandle_enableExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void disableExtrapolation() {
    NQuantLibcPINVOKE.BlackVolTermStructureHandle_disableExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool allowsExtrapolation() {
    bool ret = NQuantLibcPINVOKE.BlackVolTermStructureHandle_allowsExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
