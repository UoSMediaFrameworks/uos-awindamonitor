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

public class XsDeviceModeR : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsDeviceModeR(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsDeviceModeR obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsDeviceModeR() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsDeviceModeR(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public XsOutputMode m_outputMode {
    set {
      xsensdeviceapiPINVOKE.XsDeviceModeR_m_outputMode_set(swigCPtr, (int)value);
    } 
    get {
      XsOutputMode ret = (XsOutputMode)xsensdeviceapiPINVOKE.XsDeviceModeR_m_outputMode_get(swigCPtr);
      return ret;
    } 
  }

  public XsOutputSettings m_outputSettings {
    set {
      xsensdeviceapiPINVOKE.XsDeviceModeR_m_outputSettings_set(swigCPtr, (int)value);
    } 
    get {
      XsOutputSettings ret = (XsOutputSettings)xsensdeviceapiPINVOKE.XsDeviceModeR_m_outputSettings_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_updateRate {
    set {
      xsensdeviceapiPINVOKE.XsDeviceModeR_m_updateRate_set(swigCPtr, value);
    } 
    get {
      ushort ret = xsensdeviceapiPINVOKE.XsDeviceModeR_m_updateRate_get(swigCPtr);
      return ret;
    } 
  }

  public XsDeviceModeR(XsOutputMode mode, XsOutputSettings settings, ushort rate) : this(xsensdeviceapiPINVOKE.new_XsDeviceModeR__SWIG_0((int)mode, (int)settings, rate), true) {
  }

  public XsDeviceModeR(XsOutputMode mode, XsOutputSettings settings) : this(xsensdeviceapiPINVOKE.new_XsDeviceModeR__SWIG_1((int)mode, (int)settings), true) {
  }

  public XsDeviceModeR(XsOutputMode mode) : this(xsensdeviceapiPINVOKE.new_XsDeviceModeR__SWIG_2((int)mode), true) {
  }

  public XsDeviceModeR() : this(xsensdeviceapiPINVOKE.new_XsDeviceModeR__SWIG_3(), true) {
  }

  public int updateRate() {
    int ret = xsensdeviceapiPINVOKE.XsDeviceModeR_updateRate(swigCPtr);
    return ret;
  }

  public void getPeriodAndSkipFactor(SWIGTYPE_p_unsigned_short period, SWIGTYPE_p_unsigned_short skip) {
    xsensdeviceapiPINVOKE.XsDeviceModeR_getPeriodAndSkipFactor(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(period), SWIGTYPE_p_unsigned_short.getCPtr(skip));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setPeriodAndSkipFactor(ushort period, ushort skip) {
    xsensdeviceapiPINVOKE.XsDeviceModeR_setPeriodAndSkipFactor(swigCPtr, period, skip);
  }

}

}
