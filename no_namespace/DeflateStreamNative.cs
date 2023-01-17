// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x30730 Offset: 0x30831 VA: 0x30730
private sealed class DeflateStreamNative.UnmanagedReadOrWrite : MulticastDelegate // TypeDefIndex: 2387
{
	// Methods

	// RVA: 0x1917BF0 Offset: 0x1917CF1 VA: 0x1917BF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1917C10 Offset: 0x1917D11 VA: 0x1917C10 Slot: 13
	public virtual int Invoke(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1917E70 Offset: 0x1917F71 VA: 0x1917E70 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr buffer, int length, IntPtr data, AsyncCallback callback, object object) { }

	// RVA: 0x1917F40 Offset: 0x1918041 VA: 0x1917F40 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class DeflateStreamNative.SafeDeflateStreamHandle : SafeHandle // TypeDefIndex: 2388
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x1917B30 Offset: 0x1917C31 VA: 0x1917B30 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x1917B80 Offset: 0x1917C81 VA: 0x1917B80
	private void .ctor() { }

	// RVA: 0x1917BD0 Offset: 0x1917CD1 VA: 0x1917BD0 Slot: 7
	protected override bool ReleaseHandle() { }
}

