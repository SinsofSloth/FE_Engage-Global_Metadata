// Namespace: 
public sealed class EventScript.ActionArgs : MulticastDelegate // TypeDefIndex: 10230
{
	// Methods

	// RVA: 0x1F07F70 Offset: 0x1F08071 VA: 0x1F07F70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F07F90 Offset: 0x1F08091 VA: 0x1F07F90 Slot: 13
	public virtual void Invoke(DynValue[] args) { }

	// RVA: 0x1F082F0 Offset: 0x1F083F1 VA: 0x1F082F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(DynValue[] args, AsyncCallback callback, object object) { }

	// RVA: 0x1F08320 Offset: 0x1F08421 VA: 0x1F08320 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

