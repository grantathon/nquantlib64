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

public class PiecewiseLinearForward : YieldTermStructure {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PiecewiseLinearForward(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.PiecewiseLinearForward_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PiecewiseLinearForward obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PiecewiseLinearForward() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_PiecewiseLinearForward(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PiecewiseLinearForward(Date referenceDate, RateHelperVector instruments, DayCounter dayCounter, QuoteHandleVector jumps, DateVector jumpDates, double accuracy, Linear i) : this(NQuantLibcPINVOKE.new_PiecewiseLinearForward__SWIG_0(Date.getCPtr(referenceDate), RateHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter), QuoteHandleVector.getCPtr(jumps), DateVector.getCPtr(jumpDates), accuracy, Linear.getCPtr(i)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseLinearForward(Date referenceDate, RateHelperVector instruments, DayCounter dayCounter, QuoteHandleVector jumps, DateVector jumpDates, double accuracy) : this(NQuantLibcPINVOKE.new_PiecewiseLinearForward__SWIG_1(Date.getCPtr(referenceDate), RateHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter), QuoteHandleVector.getCPtr(jumps), DateVector.getCPtr(jumpDates), accuracy), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseLinearForward(Date referenceDate, RateHelperVector instruments, DayCounter dayCounter, QuoteHandleVector jumps, DateVector jumpDates) : this(NQuantLibcPINVOKE.new_PiecewiseLinearForward__SWIG_2(Date.getCPtr(referenceDate), RateHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter), QuoteHandleVector.getCPtr(jumps), DateVector.getCPtr(jumpDates)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseLinearForward(Date referenceDate, RateHelperVector instruments, DayCounter dayCounter, QuoteHandleVector jumps) : this(NQuantLibcPINVOKE.new_PiecewiseLinearForward__SWIG_3(Date.getCPtr(referenceDate), RateHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter), QuoteHandleVector.getCPtr(jumps)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseLinearForward(Date referenceDate, RateHelperVector instruments, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_PiecewiseLinearForward__SWIG_4(Date.getCPtr(referenceDate), RateHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseLinearForward(int settlementDays, Calendar calendar, RateHelperVector instruments, DayCounter dayCounter, QuoteHandleVector jumps, DateVector jumpDates, double accuracy, Linear i) : this(NQuantLibcPINVOKE.new_PiecewiseLinearForward__SWIG_5(settlementDays, Calendar.getCPtr(calendar), RateHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter), QuoteHandleVector.getCPtr(jumps), DateVector.getCPtr(jumpDates), accuracy, Linear.getCPtr(i)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseLinearForward(int settlementDays, Calendar calendar, RateHelperVector instruments, DayCounter dayCounter, QuoteHandleVector jumps, DateVector jumpDates, double accuracy) : this(NQuantLibcPINVOKE.new_PiecewiseLinearForward__SWIG_6(settlementDays, Calendar.getCPtr(calendar), RateHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter), QuoteHandleVector.getCPtr(jumps), DateVector.getCPtr(jumpDates), accuracy), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseLinearForward(int settlementDays, Calendar calendar, RateHelperVector instruments, DayCounter dayCounter, QuoteHandleVector jumps, DateVector jumpDates) : this(NQuantLibcPINVOKE.new_PiecewiseLinearForward__SWIG_7(settlementDays, Calendar.getCPtr(calendar), RateHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter), QuoteHandleVector.getCPtr(jumps), DateVector.getCPtr(jumpDates)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseLinearForward(int settlementDays, Calendar calendar, RateHelperVector instruments, DayCounter dayCounter, QuoteHandleVector jumps) : this(NQuantLibcPINVOKE.new_PiecewiseLinearForward__SWIG_8(settlementDays, Calendar.getCPtr(calendar), RateHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter), QuoteHandleVector.getCPtr(jumps)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseLinearForward(int settlementDays, Calendar calendar, RateHelperVector instruments, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_PiecewiseLinearForward__SWIG_9(settlementDays, Calendar.getCPtr(calendar), RateHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DateVector dates() {
    DateVector ret = new DateVector(NQuantLibcPINVOKE.PiecewiseLinearForward_dates(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DoubleVector times() {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.PiecewiseLinearForward_times(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NodeVector nodes() {
    NodeVector ret = new NodeVector(NQuantLibcPINVOKE.PiecewiseLinearForward_nodes(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
