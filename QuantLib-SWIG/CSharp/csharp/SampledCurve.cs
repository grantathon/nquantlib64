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

public class SampledCurve : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SampledCurve(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SampledCurve obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SampledCurve() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_SampledCurve(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SampledCurve() : this(NQuantLibcPINVOKE.new_SampledCurve__SWIG_0(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SampledCurve(QlArray arg0) : this(NQuantLibcPINVOKE.new_SampledCurve__SWIG_1(QlArray.getCPtr(arg0)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public QlArray grid() {
    QlArray ret = new QlArray(NQuantLibcPINVOKE.SampledCurve_grid(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QlArray values() {
    QlArray ret = new QlArray(NQuantLibcPINVOKE.SampledCurve_values(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double gridValue(uint i) {
    double ret = NQuantLibcPINVOKE.SampledCurve_gridValue(swigCPtr, i);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double value(uint i) {
    double ret = NQuantLibcPINVOKE.SampledCurve_value(swigCPtr, i);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint size() {
    uint ret = NQuantLibcPINVOKE.SampledCurve_size(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool empty() {
    bool ret = NQuantLibcPINVOKE.SampledCurve_empty(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setGrid(QlArray arg0) {
    NQuantLibcPINVOKE.SampledCurve_setGrid(swigCPtr, QlArray.getCPtr(arg0));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setValues(QlArray arg0) {
    NQuantLibcPINVOKE.SampledCurve_setValues(swigCPtr, QlArray.getCPtr(arg0));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void swap(SampledCurve arg0) {
    NQuantLibcPINVOKE.SampledCurve_swap(swigCPtr, SampledCurve.getCPtr(arg0));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setLogGrid(double min, double max) {
    NQuantLibcPINVOKE.SampledCurve_setLogGrid(swigCPtr, min, max);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void regridLogGrid(double min, double max) {
    NQuantLibcPINVOKE.SampledCurve_regridLogGrid(swigCPtr, min, max);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void shiftGrid(double s) {
    NQuantLibcPINVOKE.SampledCurve_shiftGrid(swigCPtr, s);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void scaleGrid(double s) {
    NQuantLibcPINVOKE.SampledCurve_scaleGrid(swigCPtr, s);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void regrid(QlArray arg0) {
    NQuantLibcPINVOKE.SampledCurve_regrid(swigCPtr, QlArray.getCPtr(arg0));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
