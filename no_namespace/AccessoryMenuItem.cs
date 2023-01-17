// Namespace: 
public sealed class AccessoryMenuItem.DecideEventHandler : MulticastDelegate // TypeDefIndex: 10878
{
	// Methods

	// RVA: 0x24A77C0 Offset: 0x24A78C1 VA: 0x24A77C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24A77E0 Offset: 0x24A78E1 VA: 0x24A77E0 Slot: 13
	public virtual void Invoke(AccessoryData accessoryData) { }

	// RVA: 0x24A7B40 Offset: 0x24A7C41 VA: 0x24A7B40 Slot: 14
	public virtual IAsyncResult BeginInvoke(AccessoryData accessoryData, AsyncCallback callback, object object) { }

	// RVA: 0x24A7B70 Offset: 0x24A7C71 VA: 0x24A7B70 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

