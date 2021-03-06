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

public class XsOutputConfigurationArray : XsOutputConfigurationArrayImpl {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal XsOutputConfigurationArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(xsensdeviceapiPINVOKE.XsOutputConfigurationArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsOutputConfigurationArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsOutputConfigurationArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsOutputConfigurationArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public XsOutputConfigurationArray(uint sz, XsOutputConfiguration src) : this(xsensdeviceapiPINVOKE.new_XsOutputConfigurationArray__SWIG_0(sz, XsOutputConfiguration.getCPtr(src)), true) {
  }

  public XsOutputConfigurationArray(uint sz) : this(xsensdeviceapiPINVOKE.new_XsOutputConfigurationArray__SWIG_1(sz), true) {
  }

  public XsOutputConfigurationArray() : this(xsensdeviceapiPINVOKE.new_XsOutputConfigurationArray__SWIG_2(), true) {
  }

  public XsOutputConfigurationArray(XsOutputConfigurationArray other) : this(xsensdeviceapiPINVOKE.new_XsOutputConfigurationArray__SWIG_3(XsOutputConfigurationArray.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsOutputConfigurationArray(XsOutputConfiguration arg0, uint sz, XsDataFlags flags) : this(xsensdeviceapiPINVOKE.new_XsOutputConfigurationArray__SWIG_4(XsOutputConfiguration.getCPtr(arg0), sz, (int)flags), true) {
  }

  public XsOutputConfigurationArray(XsOutputConfiguration arg0, uint sz) : this(xsensdeviceapiPINVOKE.new_XsOutputConfigurationArray__SWIG_5(XsOutputConfiguration.getCPtr(arg0), sz), true) {
  }

}

}
