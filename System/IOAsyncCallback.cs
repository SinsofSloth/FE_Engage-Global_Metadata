// Namespace: System
internal sealed class IOAsyncCallback : MulticastDelegate // TypeDefIndex: 2239
{
	// Methods

	// RVA: 0x1AF26A0 Offset: 0x1AF27A1 VA: 0x1AF26A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1AF26C0 Offset: 0x1AF27C1 VA: 0x1AF26C0 Slot: 13
	public virtual void Invoke(IOAsyncResult ioares) { }

	// RVA: 0x1AF2A20 Offset: 0x1AF2B21 VA: 0x1AF2A20 Slot: 14
	public virtual IAsyncResult BeginInvoke(IOAsyncResult ioares, AsyncCallback callback, object object) { }

	// RVA: 0x1AF2A50 Offset: 0x1AF2B51 VA: 0x1AF2A50 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

