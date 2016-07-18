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

public class Schedule : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Schedule(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Schedule obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Schedule() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_Schedule(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Schedule(DateVector arg0, Calendar calendar, BusinessDayConvention rollingConvention) : this(NQuantLibcPINVOKE.new_Schedule__SWIG_0(DateVector.getCPtr(arg0), Calendar.getCPtr(calendar), (int)rollingConvention), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Schedule(Date effectiveDate, Date terminationDate, Period tenor, Calendar calendar, BusinessDayConvention convention, BusinessDayConvention terminationDateConvention, DateGeneration.Rule rule, bool endOfMonth, Date firstDate, Date nextToLastDate) : this(NQuantLibcPINVOKE.new_Schedule__SWIG_1(Date.getCPtr(effectiveDate), Date.getCPtr(terminationDate), Period.getCPtr(tenor), Calendar.getCPtr(calendar), (int)convention, (int)terminationDateConvention, (int)rule, endOfMonth, Date.getCPtr(firstDate), Date.getCPtr(nextToLastDate)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Schedule(Date effectiveDate, Date terminationDate, Period tenor, Calendar calendar, BusinessDayConvention convention, BusinessDayConvention terminationDateConvention, DateGeneration.Rule rule, bool endOfMonth, Date firstDate) : this(NQuantLibcPINVOKE.new_Schedule__SWIG_2(Date.getCPtr(effectiveDate), Date.getCPtr(terminationDate), Period.getCPtr(tenor), Calendar.getCPtr(calendar), (int)convention, (int)terminationDateConvention, (int)rule, endOfMonth, Date.getCPtr(firstDate)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Schedule(Date effectiveDate, Date terminationDate, Period tenor, Calendar calendar, BusinessDayConvention convention, BusinessDayConvention terminationDateConvention, DateGeneration.Rule rule, bool endOfMonth) : this(NQuantLibcPINVOKE.new_Schedule__SWIG_3(Date.getCPtr(effectiveDate), Date.getCPtr(terminationDate), Period.getCPtr(tenor), Calendar.getCPtr(calendar), (int)convention, (int)terminationDateConvention, (int)rule, endOfMonth), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Schedule() : this(NQuantLibcPINVOKE.new_Schedule__SWIG_4(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint size() {
    uint ret = NQuantLibcPINVOKE.Schedule_size(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Date date(uint i) {
    Date ret = new Date(NQuantLibcPINVOKE.Schedule_date(swigCPtr, i), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isRegular(uint i) {
    bool ret = NQuantLibcPINVOKE.Schedule_isRegular(swigCPtr, i);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Schedule until(Date truncationDate) {
    Schedule ret = new Schedule(NQuantLibcPINVOKE.Schedule_until(swigCPtr, Date.getCPtr(truncationDate)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
