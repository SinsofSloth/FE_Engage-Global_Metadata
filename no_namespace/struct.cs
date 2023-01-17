// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F6B0 Offset: 0x2F7B1 VA: 0x2F6B0
public sealed class UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t : MulticastDelegate // TypeDefIndex: 2124
{
	// Methods

	// RVA: 0x1C159C0 Offset: 0x1C15AC1 VA: 0x1C159C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C159E0 Offset: 0x1C15AE1 VA: 0x1C159E0 Slot: 13
	public virtual UnityTls.unitytls_errorstate Invoke() { }

	// RVA: 0x1C15C00 Offset: 0x1C15D01 VA: 0x1C15C00 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1C15C30 Offset: 0x1C15D31 VA: 0x1C15C30 Slot: 15
	public virtual UnityTls.unitytls_errorstate EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F6D0 Offset: 0x2F7D1 VA: 0x2F6D0
public sealed class UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t : MulticastDelegate // TypeDefIndex: 2125
{
	// Methods

	// RVA: 0x1C15C60 Offset: 0x1C15D61 VA: 0x1C15C60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C15C80 Offset: 0x1C15D81 VA: 0x1C15C80 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode) { }

	// RVA: 0x1C15EC0 Offset: 0x1C15FC1 VA: 0x1C15EC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode, AsyncCallback callback, object object) { }

	// RVA: 0x1C15F60 Offset: 0x1C16061 VA: 0x1C15F60 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F6F0 Offset: 0x2F7F1 VA: 0x2F6F0
public sealed class UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t : MulticastDelegate // TypeDefIndex: 2126
{
	// Methods

	// RVA: 0x1C16200 Offset: 0x1C16301 VA: 0x1C16200
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C16220 Offset: 0x1C16321 VA: 0x1C16220 Slot: 13
	public virtual UnityTls.unitytls_key_ref Invoke(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C16470 Offset: 0x1C16571 VA: 0x1C16470 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C164A0 Offset: 0x1C165A1 VA: 0x1C164A0 Slot: 15
	public virtual UnityTls.unitytls_key_ref EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F710 Offset: 0x2F811 VA: 0x2F710
public sealed class UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t : MulticastDelegate // TypeDefIndex: 2127
{
	// Methods

	// RVA: 0x1C164D0 Offset: 0x1C165D1 VA: 0x1C164D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C164F0 Offset: 0x1C165F1 VA: 0x1C164F0 Slot: 13
	public virtual UnityTls.unitytls_key* Invoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C16780 Offset: 0x1C16881 VA: 0x1C16780 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C16840 Offset: 0x1C16941 VA: 0x1C16840 Slot: 15
	public virtual UnityTls.unitytls_key* EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F730 Offset: 0x2F831 VA: 0x2F730
public sealed class UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t : MulticastDelegate // TypeDefIndex: 2128
{
	// Methods

	// RVA: 0x1C16850 Offset: 0x1C16951 VA: 0x1C16850
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C16870 Offset: 0x1C16971 VA: 0x1C16870 Slot: 13
	public virtual UnityTls.unitytls_key* Invoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C16B00 Offset: 0x1C16C01 VA: 0x1C16B00 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C16BC0 Offset: 0x1C16CC1 VA: 0x1C16BC0 Slot: 15
	public virtual UnityTls.unitytls_key* EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F750 Offset: 0x2F851 VA: 0x2F750
public sealed class UnityTls.unitytls_interface_struct.unitytls_key_free_t : MulticastDelegate // TypeDefIndex: 2129
{
	// Methods

	// RVA: 0x1C15F70 Offset: 0x1C16071 VA: 0x1C15F70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C15F90 Offset: 0x1C16091 VA: 0x1C15F90 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_key* key) { }

	// RVA: 0x1C161C0 Offset: 0x1C162C1 VA: 0x1C161C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_key* key, AsyncCallback callback, object object) { }

	// RVA: 0x1C161F0 Offset: 0x1C162F1 VA: 0x1C161F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F770 Offset: 0x2F871 VA: 0x2F770
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t : MulticastDelegate // TypeDefIndex: 2130
{
	// Methods

	// RVA: 0x1C19C90 Offset: 0x1C19D91 VA: 0x1C19C90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C19CB0 Offset: 0x1C19DB1 VA: 0x1C19CB0 Slot: 13
	public virtual IntPtr Invoke(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C19F40 Offset: 0x1C1A041 VA: 0x1C19F40 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C1A010 Offset: 0x1C1A111 VA: 0x1C1A010 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F790 Offset: 0x2F891 VA: 0x2F790
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t : MulticastDelegate // TypeDefIndex: 2131
{
	// Methods

	// RVA: 0x1C1ABF0 Offset: 0x1C1ACF1 VA: 0x1C1ABF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C1AC10 Offset: 0x1C1AD11 VA: 0x1C1AC10 Slot: 13
	public virtual UnityTls.unitytls_x509list_ref Invoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C1AE60 Offset: 0x1C1AF61 VA: 0x1C1AE60 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C1AE90 Offset: 0x1C1AF91 VA: 0x1C1AE90 Slot: 15
	public virtual UnityTls.unitytls_x509list_ref EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F7B0 Offset: 0x2F8B1 VA: 0x2F7B0
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t : MulticastDelegate // TypeDefIndex: 2132
{
	// Methods

	// RVA: 0x1C1AEC0 Offset: 0x1C1AFC1 VA: 0x1C1AEC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C1AEE0 Offset: 0x1C1AFE1 VA: 0x1C1AEE0 Slot: 13
	public virtual UnityTls.unitytls_x509_ref Invoke(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C1B160 Offset: 0x1C1B261 VA: 0x1C1B160 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C1B230 Offset: 0x1C1B331 VA: 0x1C1B230 Slot: 15
	public virtual UnityTls.unitytls_x509_ref EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F7D0 Offset: 0x2F8D1 VA: 0x2F7D0
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_create_t : MulticastDelegate // TypeDefIndex: 2133
{
	// Methods

	// RVA: 0x1C1A6D0 Offset: 0x1C1A7D1 VA: 0x1C1A6D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C1A6F0 Offset: 0x1C1A7F1 VA: 0x1C1A6F0 Slot: 13
	public virtual UnityTls.unitytls_x509list* Invoke(UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C1A920 Offset: 0x1C1AA21 VA: 0x1C1A920 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C1A950 Offset: 0x1C1AA51 VA: 0x1C1A950 Slot: 15
	public virtual UnityTls.unitytls_x509list* EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F7F0 Offset: 0x2F8F1 VA: 0x2F7F0
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_append_t : MulticastDelegate // TypeDefIndex: 2134
{
	// Methods

	// RVA: 0x1C1A390 Offset: 0x1C1A491 VA: 0x1C1A390
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C1A3B0 Offset: 0x1C1A4B1 VA: 0x1C1A3B0 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C1A610 Offset: 0x1C1A711 VA: 0x1C1A610 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C1A6C0 Offset: 0x1C1A7C1 VA: 0x1C1A6C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F810 Offset: 0x2F911 VA: 0x2F810
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t : MulticastDelegate // TypeDefIndex: 2135
{
	// Methods

	// RVA: 0x1C1A040 Offset: 0x1C1A141 VA: 0x1C1A040
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C1A060 Offset: 0x1C1A161 VA: 0x1C1A060 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C1A2D0 Offset: 0x1C1A3D1 VA: 0x1C1A2D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C1A380 Offset: 0x1C1A481 VA: 0x1C1A380 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F830 Offset: 0x2F931 VA: 0x2F830
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_free_t : MulticastDelegate // TypeDefIndex: 2136
{
	// Methods

	// RVA: 0x1C1A960 Offset: 0x1C1AA61 VA: 0x1C1A960
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C1A980 Offset: 0x1C1AA81 VA: 0x1C1A980 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_x509list* list) { }

	// RVA: 0x1C1ABB0 Offset: 0x1C1ACB1 VA: 0x1C1ABB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, AsyncCallback callback, object object) { }

	// RVA: 0x1C1ABE0 Offset: 0x1C1ACE1 VA: 0x1C1ABE0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F850 Offset: 0x2F951 VA: 0x2F850
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t : MulticastDelegate // TypeDefIndex: 2137
{
	// Methods

	// RVA: 0x1C1B260 Offset: 0x1C1B361 VA: 0x1C1B260
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C1B280 Offset: 0x1C1B381 VA: 0x1C1B280 Slot: 13
	public virtual UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C1B540 Offset: 0x1C1B641 VA: 0x1C1B540 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C1B620 Offset: 0x1C1B721 VA: 0x1C1B620 Slot: 15
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F870 Offset: 0x2F971 VA: 0x2F870
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t : MulticastDelegate // TypeDefIndex: 2138
{
	// Methods

	// RVA: 0x1C1B650 Offset: 0x1C1B751 VA: 0x1C1B650
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C1B670 Offset: 0x1C1B771 VA: 0x1C1B670 Slot: 13
	public virtual UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C1B950 Offset: 0x1C1BA51 VA: 0x1C1B950 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C1BA40 Offset: 0x1C1BB41 VA: 0x1C1BA40 Slot: 15
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F890 Offset: 0x2F991 VA: 0x2F890
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t : MulticastDelegate // TypeDefIndex: 2139
{
	// Methods

	// RVA: 0x1C173E0 Offset: 0x1C174E1 VA: 0x1C173E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C17400 Offset: 0x1C17501 VA: 0x1C17400 Slot: 13
	public virtual UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C177A0 Offset: 0x1C178A1 VA: 0x1C177A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C178B0 Offset: 0x1C179B1 VA: 0x1C178B0 Slot: 15
	public virtual UnityTls.unitytls_tlsctx* EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F8B0 Offset: 0x2F9B1 VA: 0x2F8B0
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t : MulticastDelegate // TypeDefIndex: 2140
{
	// Methods

	// RVA: 0x1C16F10 Offset: 0x1C17011 VA: 0x1C16F10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C16F30 Offset: 0x1C17031 VA: 0x1C16F30 Slot: 13
	public virtual UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C172D0 Offset: 0x1C173D1 VA: 0x1C172D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C173D0 Offset: 0x1C174D1 VA: 0x1C173D0 Slot: 15
	public virtual UnityTls.unitytls_tlsctx* EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F8D0 Offset: 0x2F9D1 VA: 0x2F8D0
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t : MulticastDelegate // TypeDefIndex: 2141
{
	// Methods

	// RVA: 0x1C189E0 Offset: 0x1C18AE1 VA: 0x1C189E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C18A00 Offset: 0x1C18B01 VA: 0x1C18A00 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C18C60 Offset: 0x1C18D61 VA: 0x1C18C60 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C18D10 Offset: 0x1C18E11 VA: 0x1C18D10 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F8F0 Offset: 0x2F9F1 VA: 0x2F8F0
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t : MulticastDelegate // TypeDefIndex: 2142
{
	// Methods

	// RVA: 0x1C18D20 Offset: 0x1C18E21 VA: 0x1C18D20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C18D40 Offset: 0x1C18E41 VA: 0x1C18D40 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C18FB0 Offset: 0x1C190B1 VA: 0x1C18FB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C18FF0 Offset: 0x1C190F1 VA: 0x1C18FF0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F910 Offset: 0x2FA11 VA: 0x2F910
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t : MulticastDelegate // TypeDefIndex: 2143
{
	// Methods

	// RVA: 0x1C19350 Offset: 0x1C19451 VA: 0x1C19350
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C19370 Offset: 0x1C19471 VA: 0x1C19370 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C195E0 Offset: 0x1C196E1 VA: 0x1C195E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C19620 Offset: 0x1C19721 VA: 0x1C19620 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F930 Offset: 0x2FA31 VA: 0x2F930
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t : MulticastDelegate // TypeDefIndex: 2144
{
	// Methods

	// RVA: 0x1C19630 Offset: 0x1C19731 VA: 0x1C19630
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C19650 Offset: 0x1C19751 VA: 0x1C19650 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C198C0 Offset: 0x1C199C1 VA: 0x1C198C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C19900 Offset: 0x1C19A01 VA: 0x1C19900 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F950 Offset: 0x2FA51 VA: 0x2F950
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t : MulticastDelegate // TypeDefIndex: 2145
{
	// Methods

	// RVA: 0x1C19000 Offset: 0x1C19101 VA: 0x1C19000
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C19020 Offset: 0x1C19121 VA: 0x1C19020 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C19290 Offset: 0x1C19391 VA: 0x1C19290 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C19340 Offset: 0x1C19441 VA: 0x1C19340 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F970 Offset: 0x2FA71 VA: 0x2F970
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t : MulticastDelegate // TypeDefIndex: 2146
{
	// Methods

	// RVA: 0x1C17B50 Offset: 0x1C17C51 VA: 0x1C17B50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C17B70 Offset: 0x1C17C71 VA: 0x1C17B70 Slot: 13
	public virtual UnityTls.unitytls_ciphersuite Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C17DC0 Offset: 0x1C17EC1 VA: 0x1C17DC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C17DF0 Offset: 0x1C17EF1 VA: 0x1C17DF0 Slot: 15
	public virtual UnityTls.unitytls_ciphersuite EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F990 Offset: 0x2FA91 VA: 0x2F990
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t : MulticastDelegate // TypeDefIndex: 2147
{
	// Methods

	// RVA: 0x1C17E20 Offset: 0x1C17F21 VA: 0x1C17E20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C17E40 Offset: 0x1C17F41 VA: 0x1C17E40 Slot: 13
	public virtual UnityTls.unitytls_protocol Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C18090 Offset: 0x1C18191 VA: 0x1C18090 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C180C0 Offset: 0x1C181C1 VA: 0x1C180C0 Slot: 15
	public virtual UnityTls.unitytls_protocol EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F9B0 Offset: 0x2FAB1 VA: 0x2F9B0
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t : MulticastDelegate // TypeDefIndex: 2148
{
	// Methods

	// RVA: 0x1C18390 Offset: 0x1C18491 VA: 0x1C18390
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C183B0 Offset: 0x1C184B1 VA: 0x1C183B0 Slot: 13
	public virtual UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C18600 Offset: 0x1C18701 VA: 0x1C18600 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C18630 Offset: 0x1C18731 VA: 0x1C18630 Slot: 15
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F9D0 Offset: 0x2FAD1 VA: 0x2F9D0
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t : MulticastDelegate // TypeDefIndex: 2149
{
	// Methods

	// RVA: 0x1C18660 Offset: 0x1C18761 VA: 0x1C18660
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C18680 Offset: 0x1C18781 VA: 0x1C18680 Slot: 13
	public virtual IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C18900 Offset: 0x1C18A01 VA: 0x1C18900 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C189B0 Offset: 0x1C18AB1 VA: 0x1C189B0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F9F0 Offset: 0x2FAF1 VA: 0x2F9F0
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t : MulticastDelegate // TypeDefIndex: 2150
{
	// Methods

	// RVA: 0x1C19910 Offset: 0x1C19A11 VA: 0x1C19910
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C19930 Offset: 0x1C19A31 VA: 0x1C19930 Slot: 13
	public virtual IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C19BB0 Offset: 0x1C19CB1 VA: 0x1C19BB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C19C60 Offset: 0x1C19D61 VA: 0x1C19C60 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2FA10 Offset: 0x2FB11 VA: 0x2FA10
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t : MulticastDelegate // TypeDefIndex: 2151
{
	// Methods

	// RVA: 0x1C180F0 Offset: 0x1C181F1 VA: 0x1C180F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C18110 Offset: 0x1C18211 VA: 0x1C18110 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C18350 Offset: 0x1C18451 VA: 0x1C18350 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C18380 Offset: 0x1C18481 VA: 0x1C18380 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2FA30 Offset: 0x2FB31 VA: 0x2FA30
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t : MulticastDelegate // TypeDefIndex: 2152
{
	// Methods

	// RVA: 0x1C178C0 Offset: 0x1C179C1 VA: 0x1C178C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C178E0 Offset: 0x1C179E1 VA: 0x1C178E0 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx) { }

	// RVA: 0x1C17B10 Offset: 0x1C17C11 VA: 0x1C17B10 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, AsyncCallback callback, object object) { }

	// RVA: 0x1C17B40 Offset: 0x1C17C41 VA: 0x1C17B40 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2FA50 Offset: 0x2FB51 VA: 0x2FA50
public sealed class UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t : MulticastDelegate // TypeDefIndex: 2153
{
	// Methods

	// RVA: 0x1C16BD0 Offset: 0x1C16CD1 VA: 0x1C16BD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C16BF0 Offset: 0x1C16CF1 VA: 0x1C16BF0 Slot: 13
	public virtual void Invoke(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1C16E50 Offset: 0x1C16F51 VA: 0x1C16E50 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1C16F00 Offset: 0x1C17001 VA: 0x1C16F00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class UnityTls.unitytls_interface_struct // TypeDefIndex: 2154
{
	// Fields
	public readonly ulong UNITYTLS_INVALID_HANDLE; // 0x10
	public readonly UnityTls.unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT; // 0x18
	public UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create; // 0x20
	public UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error; // 0x28
	public UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t unitytls_key_get_ref; // 0x30
	public UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t unitytls_key_parse_der; // 0x38
	public UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t unitytls_key_parse_pem; // 0x40
	public UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free; // 0x48
	public UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der; // 0x50
	public UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref; // 0x58
	public UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x509; // 0x60
	public UnityTls.unitytls_interface_struct.unitytls_x509list_create_t unitytls_x509list_create; // 0x68
	public UnityTls.unitytls_interface_struct.unitytls_x509list_append_t unitytls_x509list_append; // 0x70
	public UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_der; // 0x78
	public UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_pem; // 0x80
	public UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free; // 0x88
	public UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca; // 0x90
	public UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca; // 0x98
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server; // 0xA0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client; // 0xA8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication; // 0xB0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback; // 0xB8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback; // 0xC0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback; // 0xC8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites; // 0xD0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite; // 0xD8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol; // 0xE0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake; // 0xE8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t unitytls_tlsctx_read; // 0xF0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t unitytls_tlsctx_write; // 0xF8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close; // 0x100
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t unitytls_tlsctx_free; // 0x108
	public UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t unitytls_random_generate_bytes; // 0x110

	// Methods

	// RVA: 0x1923600 Offset: 0x1923701 VA: 0x1923600
	public void .ctor() { }
}

