// Namespace: NexPlugin
public sealed class AsyncResultCB : MulticastDelegate // TypeDefIndex: 14862
{
	// Methods

	// RVA: 0x260F440 Offset: 0x260F541 VA: 0x260F440
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x260F460 Offset: 0x260F561 VA: 0x260F460 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult) { }

	// RVA: 0x260F7C0 Offset: 0x260F8C1 VA: 0x260F7C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, AsyncCallback callback, object object) { }

	// RVA: 0x260F7F0 Offset: 0x260F8F1 VA: 0x260F7F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

