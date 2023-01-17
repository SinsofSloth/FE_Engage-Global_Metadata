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

