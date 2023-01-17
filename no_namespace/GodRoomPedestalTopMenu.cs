// Namespace: 
public enum GodRoomPedestalTopMenu.Result2 // TypeDefIndex: 10986
{
	// Fields
	public int value__; // 0x0
	public const GodRoomPedestalTopMenu.Result2 SkillInheritance = 0;
	public const GodRoomPedestalTopMenu.Result2 RingGacha = 1;
	public const GodRoomPedestalTopMenu.Result2 RingMerge = 2;
	public const GodRoomPedestalTopMenu.Result2 RingCleaning = 3;
	public const GodRoomPedestalTopMenu.Result2 RefineGodWeapon = 4;
	public const GodRoomPedestalTopMenu.Result2 End = 5;
}

// Namespace: 
public sealed class GodRoomPedestalTopMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 10987
{
	// Methods

	// RVA: 0x1FA2FE0 Offset: 0x1FA30E1 VA: 0x1FA2FE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1FA3000 Offset: 0x1FA3101 VA: 0x1FA3000 Slot: 13
	public virtual void Invoke(GodRoomPedestalTopMenu.Result2 result) { }

	// RVA: 0x1FA3260 Offset: 0x1FA3361 VA: 0x1FA3260 Slot: 14
	public virtual IAsyncResult BeginInvoke(GodRoomPedestalTopMenu.Result2 result, AsyncCallback callback, object object) { }

	// RVA: 0x1FA32F0 Offset: 0x1FA33F1 VA: 0x1FA32F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class GodRoomPedestalTopMenu.SkillInheritanceItem : BasicMenuItem // TypeDefIndex: 10988
{
	// Fields
	private GodRoomPedestalTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1FA37C0 Offset: 0x1FA38C1 VA: 0x1FA37C0
	public void .ctor(GodRoomPedestalTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x1FA3800 Offset: 0x1FA3901 VA: 0x1FA3800 Slot: 4
	public override string GetName() { }

	// RVA: 0x1FA3880 Offset: 0x1FA3981 VA: 0x1FA3880 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1FA3890 Offset: 0x1FA3991 VA: 0x1FA3890 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class GodRoomPedestalTopMenu.RingGachaItem : BasicMenuItem // TypeDefIndex: 10989
{
	// Fields
	private GodRoomPedestalTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1FA35C0 Offset: 0x1FA36C1 VA: 0x1FA35C0
	public void .ctor(GodRoomPedestalTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x1FA3600 Offset: 0x1FA3701 VA: 0x1FA3600 Slot: 4
	public override string GetName() { }

	// RVA: 0x1FA3680 Offset: 0x1FA3781 VA: 0x1FA3680 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1FA3690 Offset: 0x1FA3791 VA: 0x1FA3690 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class GodRoomPedestalTopMenu.RingMergeItem : BasicMenuItem // TypeDefIndex: 10990
{
	// Fields
	private GodRoomPedestalTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1FA36C0 Offset: 0x1FA37C1 VA: 0x1FA36C0
	public void .ctor(GodRoomPedestalTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x1FA3700 Offset: 0x1FA3801 VA: 0x1FA3700 Slot: 4
	public override string GetName() { }

	// RVA: 0x1FA3780 Offset: 0x1FA3881 VA: 0x1FA3780 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1FA3790 Offset: 0x1FA3891 VA: 0x1FA3790 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class GodRoomPedestalTopMenu.RingCleaningItem : BasicMenuItem // TypeDefIndex: 10991
{
	// Fields
	private GodRoomPedestalTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1FA34C0 Offset: 0x1FA35C1 VA: 0x1FA34C0
	public void .ctor(GodRoomPedestalTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x1FA3500 Offset: 0x1FA3601 VA: 0x1FA3500 Slot: 4
	public override string GetName() { }

	// RVA: 0x1FA3580 Offset: 0x1FA3681 VA: 0x1FA3580 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1FA3590 Offset: 0x1FA3691 VA: 0x1FA3590 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class GodRoomPedestalTopMenu.RefineGodWeaponItem : BasicMenuItem // TypeDefIndex: 10992
{
	// Fields
	private GodRoomPedestalTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1FA3300 Offset: 0x1FA3401 VA: 0x1FA3300
	public void .ctor(GodRoomPedestalTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x1FA3340 Offset: 0x1FA3441 VA: 0x1FA3340 Slot: 4
	public override string GetName() { }

	// RVA: 0x1FA33C0 Offset: 0x1FA34C1 VA: 0x1FA33C0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1FA3490 Offset: 0x1FA3591 VA: 0x1FA3490 Slot: 18
	public override BasicMenu.Result ACall() { }
}

