// Namespace: System.Runtime.Remoting.Contexts
[ComVisibleAttribute] // RVA: 0x474C70 Offset: 0x474D71 VA: 0x474C70
public sealed class CrossContextDelegate : MulticastDelegate // TypeDefIndex: 1139
{
	// Methods

	// RVA: 0x37D7520 Offset: 0x37D7621 VA: 0x37D7520
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x37D7540 Offset: 0x37D7641 VA: 0x37D7540 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x37D7750 Offset: 0x37D7851 VA: 0x37D7750 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x37D7780 Offset: 0x37D7881 VA: 0x37D7780 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

