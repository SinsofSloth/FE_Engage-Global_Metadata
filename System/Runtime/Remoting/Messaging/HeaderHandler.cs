// Namespace: System.Runtime.Remoting.Messaging
[ComVisibleAttribute] // RVA: 0x4751A0 Offset: 0x4752A1 VA: 0x4751A0
public sealed class HeaderHandler : MulticastDelegate // TypeDefIndex: 1200
{
	// Methods

	// RVA: 0x38C2AA0 Offset: 0x38C2BA1 VA: 0x38C2AA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x38C2AC0 Offset: 0x38C2BC1 VA: 0x38C2AC0 Slot: 13
	public virtual object Invoke(Header[] headers) { }

	// RVA: 0x38C2E20 Offset: 0x38C2F21 VA: 0x38C2E20 Slot: 14
	public virtual IAsyncResult BeginInvoke(Header[] headers, AsyncCallback callback, object object) { }

	// RVA: 0x38C2E50 Offset: 0x38C2F51 VA: 0x38C2E50 Slot: 15
	public virtual object EndInvoke(IAsyncResult result) { }
}

