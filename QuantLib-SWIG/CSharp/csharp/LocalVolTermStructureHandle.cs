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

public class LocalVolTermStructureHandle : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal LocalVolTermStructureHandle(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LocalVolTermStructureHandle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~LocalVolTermStructureHandle() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_LocalVolTermStructureHandle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public LocalVolTermStructureHandle(LocalVolTermStructure arg0) : this(NQuantLibcPINVOKE.new_LocalVolTermStructureHandle__SWIG_0(LocalVolTermStructure.getCPtr(arg0)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public LocalVolTermStructureHandle() : this(NQuantLibcPINVOKE.new_LocalVolTermStructureHandle__SWIG_1(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public LocalVolTermStructure __deref__() {
    LocalVolTermStructure ret = new LocalVolTermStructure(NQuantLibcPINVOKE.LocalVolTermStructureHandle___deref__(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool empty() {
    bool ret = NQuantLibcPINVOKE.LocalVolTermStructureHandle_empty(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Observable asObservable() {
    Observable ret = new Observable(NQuantLibcPINVOKE.LocalVolTermStructureHandle_asObservable(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Date referenceDate() {
    Date ret = new Date(NQuantLibcPINVOKE.LocalVolTermStructureHandle_referenceDate(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DayCounter dayCounter() {
    DayCounter ret = new DayCounter(NQuantLibcPINVOKE.LocalVolTermStructureHandle_dayCounter(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Calendar calendar() {
    Calendar ret = new Calendar(NQuantLibcPINVOKE.LocalVolTermStructureHandle_calendar(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Date maxDate() {
    Date ret = new Date(NQuantLibcPINVOKE.LocalVolTermStructureHandle_maxDate(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double maxTime() {
    double ret = NQuantLibcPINVOKE.LocalVolTermStructureHandle_maxTime(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double minStrike() {
    double ret = NQuantLibcPINVOKE.LocalVolTermStructureHandle_minStrike(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double maxStrike() {
    double ret = NQuantLibcPINVOKE.LocalVolTermStructureHandle_maxStrike(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double localVol(Date arg0, double u, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.LocalVolTermStructureHandle_localVol__SWIG_0(swigCPtr, Date.getCPtr(arg0), u, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double localVol(Date arg0, double u) {
    double ret = NQuantLibcPINVOKE.LocalVolTermStructureHandle_localVol__SWIG_1(swigCPtr, Date.getCPtr(arg0), u);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double localVol(double arg0, double u, bool extrapolate) {
    double ret = NQuantLibcPINVOKE.LocalVolTermStructureHandle_localVol__SWIG_2(swigCPtr, arg0, u, extrapolate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double localVol(double arg0, double u) {
    double ret = NQuantLibcPINVOKE.LocalVolTermStructureHandle_localVol__SWIG_3(swigCPtr, arg0, u);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void enableExtrapolation() {
    NQuantLibcPINVOKE.LocalVolTermStructureHandle_enableExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void disableExtrapolation() {
    NQuantLibcPINVOKE.LocalVolTermStructureHandle_disableExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool allowsExtrapolation() {
    bool ret = NQuantLibcPINVOKE.LocalVolTermStructureHandle_allowsExtrapolation(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
