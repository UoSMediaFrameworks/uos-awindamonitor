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

public class XsCallbackPlainC : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsCallbackPlainC(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsCallbackPlainC obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsCallbackPlainC() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsCallbackPlainC(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsDeviceState_enum_XsDeviceState__void m_onDeviceStateChanged {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onDeviceStateChanged_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsDeviceState_enum_XsDeviceState__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onDeviceStateChanged_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsDeviceState_enum_XsDeviceState__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsDeviceState_enum_XsDeviceState__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsDataPacket__void m_onLiveDataAvailable {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onLiveDataAvailable_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsDataPacket__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onLiveDataAvailable_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsDataPacket__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsDataPacket__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_int_int_int__void m_onMissedPackets {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onMissedPackets_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_int_int_int__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onMissedPackets_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_int_int_int__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_int_int_int__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice__void m_onWakeupReceived {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onWakeupReceived_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onWakeupReceived_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_int_int_p_q_const__XsString__void m_onProgressUpdated {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onProgressUpdated_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_int_int_p_q_const__XsString__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onProgressUpdated_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_int_int_p_q_const__XsString__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_int_int_p_q_const__XsString__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__int m_onWriteMessageToLogFile {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onWriteMessageToLogFile_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onWriteMessageToLogFile_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsDataPacket__void m_onRecordingDataAvailable {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onRecordingDataAvailable_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsDataPacket__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onRecordingDataAvailable_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsDataPacket__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsDataPacket__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsConnectivityState__void m_onConnectivityChanged {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onConnectivityChanged_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsConnectivityState__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onConnectivityChanged_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsConnectivityState__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsConnectivityState__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsInfoRequest__void m_onInfoResponse {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onInfoResponse_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsInfoRequest__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onInfoResponse_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsInfoRequest__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsInfoRequest__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsResultValue__void m_onError {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onError_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsResultValue__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onError_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsResultValue__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_enum_XsResultValue__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__void m_onNonDataMessage {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onNonDataMessage_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onNonDataMessage_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__void m_onMessageReceivedFromDevice {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onMessageReceivedFromDevice_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onMessageReceivedFromDevice_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__void m_onMessageSentToDevice {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onMessageSentToDevice_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onMessageSentToDevice_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_p_q_const__XsMessage__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevicePtrArray_p_p_q_const__XsDataPacket__void m_onAllLiveDataAvailable {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onAllLiveDataAvailable_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevicePtrArray_p_p_q_const__XsDataPacket__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onAllLiveDataAvailable_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevicePtrArray_p_p_q_const__XsDataPacket__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevicePtrArray_p_p_q_const__XsDataPacket__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevicePtrArray_p_p_q_const__XsDataPacket__void m_onAllRecordingDataAvailable {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onAllRecordingDataAvailable_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevicePtrArray_p_p_q_const__XsDataPacket__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onAllRecordingDataAvailable_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevicePtrArray_p_p_q_const__XsDataPacket__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevicePtrArray_p_p_q_const__XsDataPacket__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_long_long__void m_onDataUnavailable {
    set {
      xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onDataUnavailable_set(swigCPtr, SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_long_long__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsCallbackPlainC_m_onDataUnavailable_get(swigCPtr);
      SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_long_long__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_XsCallbackPlainC_p_XsDevice_long_long__void(cPtr, false);
      return ret;
    } 
  }

  public XsCallbackPlainC() : this(xsensdeviceapiPINVOKE.new_XsCallbackPlainC(), true) {
  }

}

}
