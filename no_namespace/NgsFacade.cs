// Namespace: 
public sealed class NgsFacade.LoginCB : MulticastDelegate // TypeDefIndex: 14981
{
	// Methods

	// RVA: 0x1F1A8B0 Offset: 0x1F1A9B1 VA: 0x1F1A8B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F1A8D0 Offset: 0x1F1A9D1 VA: 0x1F1A8D0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, ulong principalId, IntPtr pNgsFacade) { }

	// RVA: 0x1F1AC70 Offset: 0x1F1AD71 VA: 0x1F1AC70 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, ulong principalId, IntPtr pNgsFacade, AsyncCallback callback, object object) { }

	// RVA: 0x1F1AD40 Offset: 0x1F1AE41 VA: 0x1F1AD40 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

