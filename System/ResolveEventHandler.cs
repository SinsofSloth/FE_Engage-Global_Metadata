// Namespace: System
[ComVisibleAttribute] // RVA: 0x471180 Offset: 0x471281 VA: 0x471180
[Serializable]
public sealed class ResolveEventHandler : MulticastDelegate // TypeDefIndex: 389
{
	// Methods

	// RVA: 0x3222350 Offset: 0x3222451 VA: 0x3222350
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3222370 Offset: 0x3222471 VA: 0x3222370 Slot: 13
	public virtual Assembly Invoke(object sender, ResolveEventArgs args) { }

	// RVA: 0x32226F0 Offset: 0x32227F1 VA: 0x32226F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ResolveEventArgs args, AsyncCallback callback, object object) { }

	// RVA: 0x3222720 Offset: 0x3222821 VA: 0x3222720 Slot: 15
	public virtual Assembly EndInvoke(IAsyncResult result) { }
}

