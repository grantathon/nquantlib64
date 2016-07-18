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

public class FloatingRateCoupon : Coupon {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FloatingRateCoupon(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.FloatingRateCoupon_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FloatingRateCoupon obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FloatingRateCoupon() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_FloatingRateCoupon(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Date fixingDate() {
    Date ret = new Date(NQuantLibcPINVOKE.FloatingRateCoupon_fixingDate(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int fixingDays() {
    int ret = NQuantLibcPINVOKE.FloatingRateCoupon_fixingDays(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isInArrears() {
    bool ret = NQuantLibcPINVOKE.FloatingRateCoupon_isInArrears(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double gearing() {
    double ret = NQuantLibcPINVOKE.FloatingRateCoupon_gearing(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double spread() {
    double ret = NQuantLibcPINVOKE.FloatingRateCoupon_spread(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double indexFixing() {
    double ret = NQuantLibcPINVOKE.FloatingRateCoupon_indexFixing(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double adjustedFixing() {
    double ret = NQuantLibcPINVOKE.FloatingRateCoupon_adjustedFixing(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double convexityAdjustment() {
    double ret = NQuantLibcPINVOKE.FloatingRateCoupon_convexityAdjustment(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double price(YieldTermStructureHandle discountCurve) {
    double ret = NQuantLibcPINVOKE.FloatingRateCoupon_price(swigCPtr, YieldTermStructureHandle.getCPtr(discountCurve));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public InterestRateIndex index() {
    InterestRateIndex ret = new InterestRateIndex(NQuantLibcPINVOKE.FloatingRateCoupon_index(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setPricer(FloatingRateCouponPricer p) {
    NQuantLibcPINVOKE.FloatingRateCoupon_setPricer(swigCPtr, FloatingRateCouponPricer.getCPtr(p));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
