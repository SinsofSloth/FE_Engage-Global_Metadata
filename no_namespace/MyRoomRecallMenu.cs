// Namespace: 
public sealed class MyRoomRecallMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11362
{
	// Methods

	// RVA: 0x26DE1A0 Offset: 0x26DE2A1 VA: 0x26DE1A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26DE1C0 Offset: 0x26DE2C1 VA: 0x26DE1C0 Slot: 13
	public virtual void Invoke(MyRoomRecallMenu.MenuResult result) { }

	// RVA: 0x26DE420 Offset: 0x26DE521 VA: 0x26DE420 Slot: 14
	public virtual IAsyncResult BeginInvoke(MyRoomRecallMenu.MenuResult result, AsyncCallback callback, object object) { }

	// RVA: 0x26DE4B0 Offset: 0x26DE5B1 VA: 0x26DE4B0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class MyRoomRecallMenu.GodRelianceMenuItem : BasicMenuItem // TypeDefIndex: 11364
{
	// Fields
	private MyRoomRecallMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x26DE4C0 Offset: 0x26DE5C1 VA: 0x26DE4C0
	public void .ctor(MyRoomRecallMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x26DE500 Offset: 0x26DE601 VA: 0x26DE500 Slot: 4
	public override string GetName() { }

	// RVA: 0x26DE580 Offset: 0x26DE681 VA: 0x26DE580 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x26DE590 Offset: 0x26DE691 VA: 0x26DE590 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x26DE6E0 Offset: 0x26DE7E1 VA: 0x26DE6E0 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
private class MyRoomRecallMenu.MovieMenuItem : BasicMenuItem // TypeDefIndex: 11366
{
	// Fields
	private MyRoomRecallMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x26DE6F0 Offset: 0x26DE7F1 VA: 0x26DE6F0
	public void .ctor(MyRoomRecallMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x26DE730 Offset: 0x26DE831 VA: 0x26DE730 Slot: 4
	public override string GetName() { }

	// RVA: 0x26DE7B0 Offset: 0x26DE8B1 VA: 0x26DE7B0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x26DE7C0 Offset: 0x26DE8C1 VA: 0x26DE7C0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x26DE7F0 Offset: 0x26DE8F1 VA: 0x26DE7F0 Slot: 19
	public override BasicMenu.Result BCall() { }
}

