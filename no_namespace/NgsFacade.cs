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

// Namespace: 
public sealed class NgsFacade.TestConnectivityCB : MulticastDelegate // TypeDefIndex: 14982
{
	// Methods

	// RVA: 0x1F1AD50 Offset: 0x1F1AE51 VA: 0x1F1AD50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F1AD70 Offset: 0x1F1AE71 VA: 0x1F1AD70 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, bool result) { }

	// RVA: 0x1F1B0E0 Offset: 0x1F1B1E1 VA: 0x1F1B0E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, bool result, AsyncCallback callback, object object) { }

	// RVA: 0x1F1B180 Offset: 0x1F1B281 VA: 0x1F1B180 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

