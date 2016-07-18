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

public class SwaptionVolCube2 : SwaptionVolatilityStructure {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SwaptionVolCube2(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.SwaptionVolCube2_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SwaptionVolCube2 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SwaptionVolCube2() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_SwaptionVolCube2(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SwaptionVolCube2(SwaptionVolatilityStructureHandle atmVolStructure, PeriodVector optionTenors, PeriodVector swapTenors, DoubleVector strikeSpreads, QuoteHandleVectorVector volSpreads, SwapIndex swapIndexBase, SwapIndex shortSwapIndexBase, bool vegaWeightedSmileFit) : this(NQuantLibcPINVOKE.new_SwaptionVolCube2(SwaptionVolatilityStructureHandle.getCPtr(atmVolStructure), PeriodVector.getCPtr(optionTenors), PeriodVector.getCPtr(swapTenors), DoubleVector.getCPtr(strikeSpreads), QuoteHandleVectorVector.getCPtr(volSpreads), SwapIndex.getCPtr(swapIndexBase), SwapIndex.getCPtr(shortSwapIndexBase), vegaWeightedSmileFit), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
