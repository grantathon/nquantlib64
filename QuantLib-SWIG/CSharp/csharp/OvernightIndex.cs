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

public class OvernightIndex : IborIndex {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal OvernightIndex(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.OvernightIndex_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OvernightIndex obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OvernightIndex() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_OvernightIndex(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public OvernightIndex(string familyName, int settlementDays, Currency currency, Calendar calendar, DayCounter dayCounter, YieldTermStructureHandle h) : this(NQuantLibcPINVOKE.new_OvernightIndex__SWIG_0(familyName, settlementDays, Currency.getCPtr(currency), Calendar.getCPtr(calendar), DayCounter.getCPtr(dayCounter), YieldTermStructureHandle.getCPtr(h)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public OvernightIndex(string familyName, int settlementDays, Currency currency, Calendar calendar, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_OvernightIndex__SWIG_1(familyName, settlementDays, Currency.getCPtr(currency), Calendar.getCPtr(calendar), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
