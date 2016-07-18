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

public class SwapRateHelper : RateHelper {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SwapRateHelper(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.SwapRateHelper_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SwapRateHelper obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SwapRateHelper() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_SwapRateHelper(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SwapRateHelper(QuoteHandle rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_0(QuoteHandle.getCPtr(rate), Period.getCPtr(tenor), Calendar.getCPtr(calendar), (int)fixedFrequency, (int)fixedConvention, DayCounter.getCPtr(fixedDayCount), IborIndex.getCPtr(index), QuoteHandle.getCPtr(spread), Period.getCPtr(fwdStart), YieldTermStructureHandle.getCPtr(discountingCurve)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(QuoteHandle rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread, Period fwdStart) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_1(QuoteHandle.getCPtr(rate), Period.getCPtr(tenor), Calendar.getCPtr(calendar), (int)fixedFrequency, (int)fixedConvention, DayCounter.getCPtr(fixedDayCount), IborIndex.getCPtr(index), QuoteHandle.getCPtr(spread), Period.getCPtr(fwdStart)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(QuoteHandle rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_2(QuoteHandle.getCPtr(rate), Period.getCPtr(tenor), Calendar.getCPtr(calendar), (int)fixedFrequency, (int)fixedConvention, DayCounter.getCPtr(fixedDayCount), IborIndex.getCPtr(index), QuoteHandle.getCPtr(spread)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(QuoteHandle rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_3(QuoteHandle.getCPtr(rate), Period.getCPtr(tenor), Calendar.getCPtr(calendar), (int)fixedFrequency, (int)fixedConvention, DayCounter.getCPtr(fixedDayCount), IborIndex.getCPtr(index)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(double rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_4(rate, Period.getCPtr(tenor), Calendar.getCPtr(calendar), (int)fixedFrequency, (int)fixedConvention, DayCounter.getCPtr(fixedDayCount), IborIndex.getCPtr(index), QuoteHandle.getCPtr(spread), Period.getCPtr(fwdStart), YieldTermStructureHandle.getCPtr(discountingCurve)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(double rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread, Period fwdStart) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_5(rate, Period.getCPtr(tenor), Calendar.getCPtr(calendar), (int)fixedFrequency, (int)fixedConvention, DayCounter.getCPtr(fixedDayCount), IborIndex.getCPtr(index), QuoteHandle.getCPtr(spread), Period.getCPtr(fwdStart)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(double rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index, QuoteHandle spread) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_6(rate, Period.getCPtr(tenor), Calendar.getCPtr(calendar), (int)fixedFrequency, (int)fixedConvention, DayCounter.getCPtr(fixedDayCount), IborIndex.getCPtr(index), QuoteHandle.getCPtr(spread)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(double rate, Period tenor, Calendar calendar, Frequency fixedFrequency, BusinessDayConvention fixedConvention, DayCounter fixedDayCount, IborIndex index) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_7(rate, Period.getCPtr(tenor), Calendar.getCPtr(calendar), (int)fixedFrequency, (int)fixedConvention, DayCounter.getCPtr(fixedDayCount), IborIndex.getCPtr(index)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(QuoteHandle rate, SwapIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_8(QuoteHandle.getCPtr(rate), SwapIndex.getCPtr(index), QuoteHandle.getCPtr(spread), Period.getCPtr(fwdStart), YieldTermStructureHandle.getCPtr(discountingCurve)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(QuoteHandle rate, SwapIndex index, QuoteHandle spread, Period fwdStart) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_9(QuoteHandle.getCPtr(rate), SwapIndex.getCPtr(index), QuoteHandle.getCPtr(spread), Period.getCPtr(fwdStart)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(QuoteHandle rate, SwapIndex index, QuoteHandle spread) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_10(QuoteHandle.getCPtr(rate), SwapIndex.getCPtr(index), QuoteHandle.getCPtr(spread)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(QuoteHandle rate, SwapIndex index) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_11(QuoteHandle.getCPtr(rate), SwapIndex.getCPtr(index)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(double rate, SwapIndex index, QuoteHandle spread, Period fwdStart, YieldTermStructureHandle discountingCurve) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_12(rate, SwapIndex.getCPtr(index), QuoteHandle.getCPtr(spread), Period.getCPtr(fwdStart), YieldTermStructureHandle.getCPtr(discountingCurve)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(double rate, SwapIndex index, QuoteHandle spread, Period fwdStart) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_13(rate, SwapIndex.getCPtr(index), QuoteHandle.getCPtr(spread), Period.getCPtr(fwdStart)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(double rate, SwapIndex index, QuoteHandle spread) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_14(rate, SwapIndex.getCPtr(index), QuoteHandle.getCPtr(spread)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapRateHelper(double rate, SwapIndex index) : this(NQuantLibcPINVOKE.new_SwapRateHelper__SWIG_15(rate, SwapIndex.getCPtr(index)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public VanillaSwap swap() {
    VanillaSwap ret = new VanillaSwap(NQuantLibcPINVOKE.SwapRateHelper_swap(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
