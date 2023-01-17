// Namespace: System.Threading
public sealed class SendOrPostCallback : MulticastDelegate // TypeDefIndex: 769
{
	// Methods

	// RVA: 0x36173D0 Offset: 0x36174D1 VA: 0x36173D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x36173F0 Offset: 0x36174F1 VA: 0x36173F0 Slot: 13
	public virtual void Invoke(object state) { }

	// RVA: 0x3617750 Offset: 0x3617851 VA: 0x3617750 Slot: 14
	public virtual IAsyncResult BeginInvoke(object state, AsyncCallback callback, object object) { }

	// RVA: 0x3617780 Offset: 0x3617881 VA: 0x3617780 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

