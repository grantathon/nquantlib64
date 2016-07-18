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

public class FdBlackScholesVanillaEngine : PricingEngine {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FdBlackScholesVanillaEngine(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.FdBlackScholesVanillaEngine_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FdBlackScholesVanillaEngine obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FdBlackScholesVanillaEngine() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_FdBlackScholesVanillaEngine(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FdBlackScholesVanillaEngine(GeneralizedBlackScholesProcess process, uint tGrid, uint xGrid, uint dampingSteps) : this(NQuantLibcPINVOKE.new_FdBlackScholesVanillaEngine__SWIG_0(GeneralizedBlackScholesProcess.getCPtr(process), tGrid, xGrid, dampingSteps), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FdBlackScholesVanillaEngine(GeneralizedBlackScholesProcess process, uint tGrid, uint xGrid) : this(NQuantLibcPINVOKE.new_FdBlackScholesVanillaEngine__SWIG_1(GeneralizedBlackScholesProcess.getCPtr(process), tGrid, xGrid), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FdBlackScholesVanillaEngine(GeneralizedBlackScholesProcess process, uint tGrid) : this(NQuantLibcPINVOKE.new_FdBlackScholesVanillaEngine__SWIG_2(GeneralizedBlackScholesProcess.getCPtr(process), tGrid), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FdBlackScholesVanillaEngine(GeneralizedBlackScholesProcess process) : this(NQuantLibcPINVOKE.new_FdBlackScholesVanillaEngine__SWIG_3(GeneralizedBlackScholesProcess.getCPtr(process)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
