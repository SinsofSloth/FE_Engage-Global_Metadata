// Namespace: 
public enum MyRoomRecallMenu.MenuResult // TypeDefIndex: 11361
{
	// Fields
	public int value__; // 0x0
	public const MyRoomRecallMenu.MenuResult Reliance = 0;
	public const MyRoomRecallMenu.MenuResult GodReliance = 1;
	public const MyRoomRecallMenu.MenuResult Wakeup = 2;
	public const MyRoomRecallMenu.MenuResult Movie = 3;
	public const MyRoomRecallMenu.MenuResult Music = 4;
	public const MyRoomRecallMenu.MenuResult End = 5;
}

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
private class MyRoomRecallMenu.RelianceMenuItem : BasicMenuItem // TypeDefIndex: 11363
{
	// Fields
	private MyRoomRecallMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x26DE910 Offset: 0x26DEA11 VA: 0x26DE910
	public void .ctor(MyRoomRecallMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x26DE950 Offset: 0x26DEA51 VA: 0x26DE950 Slot: 4
	public override string GetName() { }

	// RVA: 0x26DE9D0 Offset: 0x26DEAD1 VA: 0x26DE9D0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x26DE9E0 Offset: 0x26DEAE1 VA: 0x26DE9E0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x26DEB30 Offset: 0x26DEC31 VA: 0x26DEB30 Slot: 19
	public override BasicMenu.Result BCall() { }
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
private class MyRoomRecallMenu.WakeupMenuItem : BasicMenuItem // TypeDefIndex: 11365
{
	// Fields
	private MyRoomRecallMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x26DEC90 Offset: 0x26DED91 VA: 0x26DEC90
	public void .ctor(MyRoomRecallMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x26DECD0 Offset: 0x26DEDD1 VA: 0x26DECD0 Slot: 4
	public override string GetName() { }

	// RVA: 0x26DED50 Offset: 0x26DEE51 VA: 0x26DED50 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x26DED60 Offset: 0x26DEE61 VA: 0x26DED60 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x26DED90 Offset: 0x26DEE91 VA: 0x26DED90 Slot: 19
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

// Namespace: 
private class MyRoomRecallMenu.MusicMenuItem : BasicMenuItem // TypeDefIndex: 11367
{
	// Fields
	private MyRoomRecallMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x26DE800 Offset: 0x26DE901 VA: 0x26DE800
	public void .ctor(MyRoomRecallMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x26DE840 Offset: 0x26DE941 VA: 0x26DE840 Slot: 4
	public override string GetName() { }

	// RVA: 0x26DE8C0 Offset: 0x26DE9C1 VA: 0x26DE8C0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x26DE8D0 Offset: 0x26DE9D1 VA: 0x26DE8D0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x26DE900 Offset: 0x26DEA01 VA: 0x26DE900 Slot: 19
	public override BasicMenu.Result BCall() { }
}

