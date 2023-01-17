// Namespace: App
public class RefineGodWeaponSelectMenuItem : BasicMenuItem // TypeDefIndex: 11071
{
	// Fields
	protected RefineGodWeaponSelectMenu.SelectEventHandler m_SelectEventHandler; // 0x68
	protected RefineGodWeaponSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x70
	protected RefineGodWeaponSelectMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x2965D0 Offset: 0x2966D1 VA: 0x2965D0
	private ItemData <m_ItemData>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x2965E0 Offset: 0x2966E1 VA: 0x2965E0
	private UnitItem <m_UnitItem>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x2965F0 Offset: 0x2966F1 VA: 0x2965F0
	private int <m_Capacity>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x296600 Offset: 0x296701 VA: 0x296600
	private int <m_CapacityMax>k__BackingField; // 0x94
	[CompilerGeneratedAttribute] // RVA: 0x296610 Offset: 0x296711 VA: 0x296610
	private bool <m_Empty>k__BackingField; // 0x98

	// Properties
	public ItemData m_ItemData { get; set; }
	public UnitItem m_UnitItem { get; set; }
	public int m_Capacity { get; set; }
	public int m_CapacityMax { get; set; }
	public bool m_Empty { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3380 Offset: 0x2C3481 VA: 0x2C3380
	// RVA: 0x277CE00 Offset: 0x277CF01 VA: 0x277CE00
	public ItemData get_m_ItemData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3390 Offset: 0x2C3491 VA: 0x2C3390
	// RVA: 0x277CE10 Offset: 0x277CF11 VA: 0x277CE10
	protected void set_m_ItemData(ItemData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C33A0 Offset: 0x2C34A1 VA: 0x2C33A0
	// RVA: 0x277CE20 Offset: 0x277CF21 VA: 0x277CE20
	public UnitItem get_m_UnitItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C33B0 Offset: 0x2C34B1 VA: 0x2C33B0
	// RVA: 0x277CE30 Offset: 0x277CF31 VA: 0x277CE30
	protected void set_m_UnitItem(UnitItem value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C33C0 Offset: 0x2C34C1 VA: 0x2C33C0
	// RVA: 0x277CE40 Offset: 0x277CF41 VA: 0x277CE40
	public int get_m_Capacity() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C33D0 Offset: 0x2C34D1 VA: 0x2C33D0
	// RVA: 0x277CE50 Offset: 0x277CF51 VA: 0x277CE50
	protected void set_m_Capacity(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C33E0 Offset: 0x2C34E1 VA: 0x2C33E0
	// RVA: 0x277CE60 Offset: 0x277CF61 VA: 0x277CE60
	public int get_m_CapacityMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C33F0 Offset: 0x2C34F1 VA: 0x2C33F0
	// RVA: 0x277CE70 Offset: 0x277CF71 VA: 0x277CE70
	protected void set_m_CapacityMax(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3400 Offset: 0x2C3501 VA: 0x2C3400
	// RVA: 0x277CE80 Offset: 0x277CF81 VA: 0x277CE80
	public bool get_m_Empty() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3410 Offset: 0x2C3511 VA: 0x2C3410
	// RVA: 0x277CE90 Offset: 0x277CF91 VA: 0x277CE90
	protected void set_m_Empty(bool value) { }

	// RVA: 0x277ACC0 Offset: 0x277ADC1 VA: 0x277ACC0
	public void .ctor(ItemData godWeaponData, int usingCapacity, int capacity, RefineGodWeaponSelectMenu.SelectEventHandler selectEventHandler, RefineGodWeaponSelectMenu.DecideEventHandler decideEventHandler, RefineGodWeaponSelectMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x277CEA0 Offset: 0x277CFA1 VA: 0x277CEA0 Slot: 4
	public override string GetName() { }

	// RVA: 0x277CF20 Offset: 0x277D021 VA: 0x277CF20 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x277CF40 Offset: 0x277D041 VA: 0x277CF40 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x277D050 Offset: 0x277D151 VA: 0x277D050 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x277CF50 Offset: 0x277D051 VA: 0x277CF50
	public void SetInitialColor() { }

	// RVA: 0x277AEA0 Offset: 0x277AFA1 VA: 0x277AEA0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x277D060 Offset: 0x277D161 VA: 0x277D060 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x277D120 Offset: 0x277D221 VA: 0x277D120 Slot: 19
	public override BasicMenu.Result BCall() { }
}

