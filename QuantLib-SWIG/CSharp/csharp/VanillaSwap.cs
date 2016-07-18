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

public class VanillaSwap : Swap {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VanillaSwap(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.VanillaSwap_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VanillaSwap obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VanillaSwap() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_VanillaSwap(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public VanillaSwap(_VanillaSwap.Type type, double nominal, Schedule fixedSchedule, double fixedRate, DayCounter fixedDayCount, Schedule floatSchedule, IborIndex index, double spread, DayCounter floatingDayCount) : this(NQuantLibcPINVOKE.new_VanillaSwap((int)type, nominal, Schedule.getCPtr(fixedSchedule), fixedRate, DayCounter.getCPtr(fixedDayCount), Schedule.getCPtr(floatSchedule), IborIndex.getCPtr(index), spread, DayCounter.getCPtr(floatingDayCount)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double fairRate() {
    double ret = NQuantLibcPINVOKE.VanillaSwap_fairRate(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double fairSpread() {
    double ret = NQuantLibcPINVOKE.VanillaSwap_fairSpread(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double fixedLegBPS() {
    double ret = NQuantLibcPINVOKE.VanillaSwap_fixedLegBPS(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double floatingLegBPS() {
    double ret = NQuantLibcPINVOKE.VanillaSwap_floatingLegBPS(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double fixedLegNPV() {
    double ret = NQuantLibcPINVOKE.VanillaSwap_fixedLegNPV(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double floatingLegNPV() {
    double ret = NQuantLibcPINVOKE.VanillaSwap_floatingLegNPV(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Leg fixedLeg() {
    Leg ret = new Leg(NQuantLibcPINVOKE.VanillaSwap_fixedLeg(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Leg floatingLeg() {
    Leg ret = new Leg(NQuantLibcPINVOKE.VanillaSwap_floatingLeg(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double nominal() {
    double ret = NQuantLibcPINVOKE.VanillaSwap_nominal(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Schedule fixedSchedule() {
    Schedule ret = new Schedule(NQuantLibcPINVOKE.VanillaSwap_fixedSchedule(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Schedule floatingSchedule() {
    Schedule ret = new Schedule(NQuantLibcPINVOKE.VanillaSwap_floatingSchedule(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double fixedRate() {
    double ret = NQuantLibcPINVOKE.VanillaSwap_fixedRate(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double spread() {
    double ret = NQuantLibcPINVOKE.VanillaSwap_spread(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DayCounter floatingDayCount() {
    DayCounter ret = new DayCounter(NQuantLibcPINVOKE.VanillaSwap_floatingDayCount(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DayCounter fixedDayCount() {
    DayCounter ret = new DayCounter(NQuantLibcPINVOKE.VanillaSwap_fixedDayCount(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static readonly _VanillaSwap.Type Receiver = (_VanillaSwap.Type)NQuantLibcPINVOKE.VanillaSwap_Receiver_get();
  public static readonly _VanillaSwap.Type Payer = (_VanillaSwap.Type)NQuantLibcPINVOKE.VanillaSwap_Payer_get();
}

}
