//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace XDA {

public class XsCalibratedData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsCalibratedData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsCalibratedData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsCalibratedData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsCalibratedData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public XsVector3 m_acc {
    set {
      xsensdeviceapiPINVOKE.XsCalibratedData_m_acc_set(swigCPtr, XsVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCalibratedData_m_acc_get(swigCPtr);
      XsVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new XsVector3(cPtr, false);
      return ret;
    } 
  }

  public XsVector3 m_gyr {
    set {
      xsensdeviceapiPINVOKE.XsCalibratedData_m_gyr_set(swigCPtr, XsVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCalibratedData_m_gyr_get(swigCPtr);
      XsVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new XsVector3(cPtr, false);
      return ret;
    } 
  }

  public XsVector3 m_mag {
    set {
      xsensdeviceapiPINVOKE.XsCalibratedData_m_mag_set(swigCPtr, XsVector3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCalibratedData_m_mag_get(swigCPtr);
      XsVector3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new XsVector3(cPtr, false);
      return ret;
    } 
  }

  public XsCalibratedData() : this(xsensdeviceapiPINVOKE.new_XsCalibratedData__SWIG_0(), true) {
  }

  public XsCalibratedData(XsCalibratedData other) : this(xsensdeviceapiPINVOKE.new_XsCalibratedData__SWIG_1(XsCalibratedData.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
