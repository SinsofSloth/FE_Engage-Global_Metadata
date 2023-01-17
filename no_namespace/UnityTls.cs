// Namespace: 
public enum UnityTls.unitytls_error_code // TypeDefIndex: 2104
{
	// Fields
	public uint value__; // 0x0
	public const UnityTls.unitytls_error_code UNITYTLS_SUCCESS = 0;
	public const UnityTls.unitytls_error_code UNITYTLS_INVALID_ARGUMENT = 1;
	public const UnityTls.unitytls_error_code UNITYTLS_INVALID_FORMAT = 2;
	public const UnityTls.unitytls_error_code UNITYTLS_INVALID_PASSWORD = 3;
	public const UnityTls.unitytls_error_code UNITYTLS_INVALID_STATE = 4;
	public const UnityTls.unitytls_error_code UNITYTLS_BUFFER_OVERFLOW = 5;
	public const UnityTls.unitytls_error_code UNITYTLS_OUT_OF_MEMORY = 6;
	public const UnityTls.unitytls_error_code UNITYTLS_INTERNAL_ERROR = 7;
	public const UnityTls.unitytls_error_code UNITYTLS_NOT_SUPPORTED = 8;
	public const UnityTls.unitytls_error_code UNITYTLS_ENTROPY_SOURCE_FAILED = 9;
	public const UnityTls.unitytls_error_code UNITYTLS_STREAM_CLOSED = 10;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_CUSTOM_ERROR_START = 1048576;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_WOULD_BLOCK = 1048577;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_READ_FAILED = 1048578;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_WRITE_FAILED = 1048579;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_UNKNOWN_ERROR = 1048580;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_CUSTOM_ERROR_END = 2097152;
}

// Namespace: 
public struct UnityTls.unitytls_key // TypeDefIndex: 2106
{}

// Namespace: 
public struct UnityTls.unitytls_x509_ref // TypeDefIndex: 2108
{
	// Fields
	public ulong handle; // 0x0
}

// Namespace: 
public struct UnityTls.unitytls_x509list_ref // TypeDefIndex: 2110
{
	// Fields
	public ulong handle; // 0x0
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F5F0 Offset: 0x2F6F1 VA: 0x2F5F0
public sealed class UnityTls.unitytls_x509verify_callback : MulticastDelegate // TypeDefIndex: 2112
{
	// Methods

	// RVA: 0x1924770 Offset: 0x1924871 VA: 0x1924770
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1924790 Offset: 0x1924891 VA: 0x1924790 Slot: 13
	public virtual UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1924A10 Offset: 0x1924B11 VA: 0x1924A10 Slot: 14
	public virtual IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1924AE0 Offset: 0x1924BE1 VA: 0x1924AE0 Slot: 15
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public struct UnityTls.unitytls_x509name // TypeDefIndex: 2114
{}

// Namespace: 
public enum UnityTls.unitytls_protocol // TypeDefIndex: 2116
{
	// Fields
	public uint value__; // 0x0
	public const UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_0 = 0;
	public const UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_1 = 1;
	public const UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_2 = 2;
	public const UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_INVALID = 3;
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F610 Offset: 0x2F711 VA: 0x2F610
public sealed class UnityTls.unitytls_tlsctx_write_callback : MulticastDelegate // TypeDefIndex: 2118
{
	// Methods

	// RVA: 0x1924090 Offset: 0x1924191 VA: 0x1924090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19240B0 Offset: 0x19241B1 VA: 0x19240B0 Slot: 13
	public virtual IntPtr Invoke(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1924330 Offset: 0x1924431 VA: 0x1924330 Slot: 14
	public virtual IAsyncResult BeginInvoke(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x19243E0 Offset: 0x19244E1 VA: 0x19243E0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F650 Offset: 0x2F751 VA: 0x2F650
public sealed class UnityTls.unitytls_tlsctx_trace_callback : MulticastDelegate // TypeDefIndex: 2120
{
	// Methods

	// RVA: 0x1923D40 Offset: 0x1923E41 VA: 0x1923D40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1923D60 Offset: 0x1923E61 VA: 0x1923D60 Slot: 13
	public virtual void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen) { }

	// RVA: 0x1923FD0 Offset: 0x19240D1 VA: 0x1923FD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen, AsyncCallback callback, object object) { }

	// RVA: 0x1924080 Offset: 0x1924181 VA: 0x1924080 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x2F690 Offset: 0x2F791 VA: 0x2F690
public sealed class UnityTls.unitytls_tlsctx_x509verify_callback : MulticastDelegate // TypeDefIndex: 2122
{
	// Methods

	// RVA: 0x1924410 Offset: 0x1924511 VA: 0x1924410
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1924430 Offset: 0x1924531 VA: 0x1924430 Slot: 13
	public virtual UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1924690 Offset: 0x1924791 VA: 0x1924690 Slot: 14
	public virtual IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1924740 Offset: 0x1924841 VA: 0x1924740 Slot: 15
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }
}

