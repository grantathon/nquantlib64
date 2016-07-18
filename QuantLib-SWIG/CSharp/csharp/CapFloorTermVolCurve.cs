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

public class CapFloorTermVolCurve : CapFloorTermVolatilityStructure {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CapFloorTermVolCurve(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.CapFloorTermVolCurve_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CapFloorTermVolCurve obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CapFloorTermVolCurve() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_CapFloorTermVolCurve(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CapFloorTermVolCurve(Date referenceDate, Calendar calendar, BusinessDayConvention bdc, PeriodVector lengths, DoubleVector vols, DayCounter dc) : this(NQuantLibcPINVOKE.new_CapFloorTermVolCurve__SWIG_0(Date.getCPtr(referenceDate), Calendar.getCPtr(calendar), (int)bdc, PeriodVector.getCPtr(lengths), DoubleVector.getCPtr(vols), DayCounter.getCPtr(dc)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CapFloorTermVolCurve(Date referenceDate, Calendar calendar, BusinessDayConvention bdc, PeriodVector lengths, DoubleVector vols) : this(NQuantLibcPINVOKE.new_CapFloorTermVolCurve__SWIG_1(Date.getCPtr(referenceDate), Calendar.getCPtr(calendar), (int)bdc, PeriodVector.getCPtr(lengths), DoubleVector.getCPtr(vols)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CapFloorTermVolCurve(uint settlementDays, Calendar calendar, BusinessDayConvention bdc, PeriodVector lengths, DoubleVector vols, DayCounter dc) : this(NQuantLibcPINVOKE.new_CapFloorTermVolCurve__SWIG_2(settlementDays, Calendar.getCPtr(calendar), (int)bdc, PeriodVector.getCPtr(lengths), DoubleVector.getCPtr(vols), DayCounter.getCPtr(dc)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CapFloorTermVolCurve(uint settlementDays, Calendar calendar, BusinessDayConvention bdc, PeriodVector lengths, DoubleVector vols) : this(NQuantLibcPINVOKE.new_CapFloorTermVolCurve__SWIG_3(settlementDays, Calendar.getCPtr(calendar), (int)bdc, PeriodVector.getCPtr(lengths), DoubleVector.getCPtr(vols)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
