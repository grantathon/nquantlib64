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

public class InterestRate : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal InterestRate(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(InterestRate obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~InterestRate() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_InterestRate(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public InterestRate() : this(NQuantLibcPINVOKE.new_InterestRate__SWIG_0(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public InterestRate(double r, DayCounter dc, Compounding comp, Frequency freq) : this(NQuantLibcPINVOKE.new_InterestRate__SWIG_1(r, DayCounter.getCPtr(dc), (int)comp, (int)freq), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double rate() {
    double ret = NQuantLibcPINVOKE.InterestRate_rate(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DayCounter dayCounter() {
    DayCounter ret = new DayCounter(NQuantLibcPINVOKE.InterestRate_dayCounter(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Compounding compounding() {
    Compounding ret = (Compounding)NQuantLibcPINVOKE.InterestRate_compounding(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Frequency frequency() {
    Frequency ret = (Frequency)NQuantLibcPINVOKE.InterestRate_frequency(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double discountFactor(double t) {
    double ret = NQuantLibcPINVOKE.InterestRate_discountFactor__SWIG_0(swigCPtr, t);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double discountFactor(Date d1, Date d2, Date refStart, Date refEnd) {
    double ret = NQuantLibcPINVOKE.InterestRate_discountFactor__SWIG_1(swigCPtr, Date.getCPtr(d1), Date.getCPtr(d2), Date.getCPtr(refStart), Date.getCPtr(refEnd));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double discountFactor(Date d1, Date d2, Date refStart) {
    double ret = NQuantLibcPINVOKE.InterestRate_discountFactor__SWIG_2(swigCPtr, Date.getCPtr(d1), Date.getCPtr(d2), Date.getCPtr(refStart));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double discountFactor(Date d1, Date d2) {
    double ret = NQuantLibcPINVOKE.InterestRate_discountFactor__SWIG_3(swigCPtr, Date.getCPtr(d1), Date.getCPtr(d2));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double compoundFactor(double t) {
    double ret = NQuantLibcPINVOKE.InterestRate_compoundFactor__SWIG_0(swigCPtr, t);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double compoundFactor(Date d1, Date d2, Date refStart, Date refEnd) {
    double ret = NQuantLibcPINVOKE.InterestRate_compoundFactor__SWIG_1(swigCPtr, Date.getCPtr(d1), Date.getCPtr(d2), Date.getCPtr(refStart), Date.getCPtr(refEnd));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double compoundFactor(Date d1, Date d2, Date refStart) {
    double ret = NQuantLibcPINVOKE.InterestRate_compoundFactor__SWIG_2(swigCPtr, Date.getCPtr(d1), Date.getCPtr(d2), Date.getCPtr(refStart));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double compoundFactor(Date d1, Date d2) {
    double ret = NQuantLibcPINVOKE.InterestRate_compoundFactor__SWIG_3(swigCPtr, Date.getCPtr(d1), Date.getCPtr(d2));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static InterestRate impliedRate(double compound, DayCounter resultDC, Compounding comp, Frequency freq, double t) {
    InterestRate ret = new InterestRate(NQuantLibcPINVOKE.InterestRate_impliedRate__SWIG_0(compound, DayCounter.getCPtr(resultDC), (int)comp, (int)freq, t), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static InterestRate impliedRate(double compound, DayCounter resultDC, Compounding comp, Frequency freq, Date d1, Date d2, Date refStart, Date refEnd) {
    InterestRate ret = new InterestRate(NQuantLibcPINVOKE.InterestRate_impliedRate__SWIG_1(compound, DayCounter.getCPtr(resultDC), (int)comp, (int)freq, Date.getCPtr(d1), Date.getCPtr(d2), Date.getCPtr(refStart), Date.getCPtr(refEnd)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static InterestRate impliedRate(double compound, DayCounter resultDC, Compounding comp, Frequency freq, Date d1, Date d2, Date refStart) {
    InterestRate ret = new InterestRate(NQuantLibcPINVOKE.InterestRate_impliedRate__SWIG_2(compound, DayCounter.getCPtr(resultDC), (int)comp, (int)freq, Date.getCPtr(d1), Date.getCPtr(d2), Date.getCPtr(refStart)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static InterestRate impliedRate(double compound, DayCounter resultDC, Compounding comp, Frequency freq, Date d1, Date d2) {
    InterestRate ret = new InterestRate(NQuantLibcPINVOKE.InterestRate_impliedRate__SWIG_3(compound, DayCounter.getCPtr(resultDC), (int)comp, (int)freq, Date.getCPtr(d1), Date.getCPtr(d2)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public InterestRate equivalentRate(Compounding comp, Frequency freq, double t) {
    InterestRate ret = new InterestRate(NQuantLibcPINVOKE.InterestRate_equivalentRate__SWIG_0(swigCPtr, (int)comp, (int)freq, t), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public InterestRate equivalentRate(DayCounter resultDayCounter, Compounding comp, Frequency freq, Date d1, Date d2, Date refStart, Date refEnd) {
    InterestRate ret = new InterestRate(NQuantLibcPINVOKE.InterestRate_equivalentRate__SWIG_1(swigCPtr, DayCounter.getCPtr(resultDayCounter), (int)comp, (int)freq, Date.getCPtr(d1), Date.getCPtr(d2), Date.getCPtr(refStart), Date.getCPtr(refEnd)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public InterestRate equivalentRate(DayCounter resultDayCounter, Compounding comp, Frequency freq, Date d1, Date d2, Date refStart) {
    InterestRate ret = new InterestRate(NQuantLibcPINVOKE.InterestRate_equivalentRate__SWIG_2(swigCPtr, DayCounter.getCPtr(resultDayCounter), (int)comp, (int)freq, Date.getCPtr(d1), Date.getCPtr(d2), Date.getCPtr(refStart)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public InterestRate equivalentRate(DayCounter resultDayCounter, Compounding comp, Frequency freq, Date d1, Date d2) {
    InterestRate ret = new InterestRate(NQuantLibcPINVOKE.InterestRate_equivalentRate__SWIG_3(swigCPtr, DayCounter.getCPtr(resultDayCounter), (int)comp, (int)freq, Date.getCPtr(d1), Date.getCPtr(d2)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string __str__() {
    string ret = NQuantLibcPINVOKE.InterestRate___str__(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
