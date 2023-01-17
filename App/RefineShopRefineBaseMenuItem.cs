// Namespace: App
public class RefineShopRefineBaseMenuItem : BasicItemMenuItem // TypeDefIndex: 11148
{
	// Fields
	protected RefineShopRefineBaseMenu.SelectEventHandler m_SelectEventHandler; // 0x68
	protected RefineShopRefineBaseMenu.DecideEventHandler m_DecideEventHandler; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x296C10 Offset: 0x296D11 VA: 0x296C10
	private Unit <m_Unit>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x296C20 Offset: 0x296D21 VA: 0x296C20
	private int <m_ItemIndex>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x296C30 Offset: 0x296D31 VA: 0x296C30
	private UnitItem <m_UnitItem>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x296C40 Offset: 0x296D41 VA: 0x296C40
	private long <m_SortValue>k__BackingField; // 0x90

	// Properties
	public Unit m_Unit { get; set; }
	public int m_ItemIndex { get; set; }
	public UnitItem m_UnitItem { get; set; }
	public long m_SortValue { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3940 Offset: 0x2C3A41 VA: 0x2C3940
	// RVA: 0x2C6EAD0 Offset: 0x2C6EBD1 VA: 0x2C6EAD0
	public Unit get_m_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3950 Offset: 0x2C3A51 VA: 0x2C3950
	// RVA: 0x2C6EAE0 Offset: 0x2C6EBE1 VA: 0x2C6EAE0
	protected void set_m_Unit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3960 Offset: 0x2C3A61 VA: 0x2C3960
	// RVA: 0x2C6EAF0 Offset: 0x2C6EBF1 VA: 0x2C6EAF0
	public int get_m_ItemIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3970 Offset: 0x2C3A71 VA: 0x2C3970
	// RVA: 0x2C6EB00 Offset: 0x2C6EC01 VA: 0x2C6EB00
	protected void set_m_ItemIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3980 Offset: 0x2C3A81 VA: 0x2C3980
	// RVA: 0x2C6EB10 Offset: 0x2C6EC11 VA: 0x2C6EB10
	public UnitItem get_m_UnitItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3990 Offset: 0x2C3A91 VA: 0x2C3990
	// RVA: 0x2C6EB20 Offset: 0x2C6EC21 VA: 0x2C6EB20
	protected void set_m_UnitItem(UnitItem value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C39A0 Offset: 0x2C3AA1 VA: 0x2C39A0
	// RVA: 0x2C6EB30 Offset: 0x2C6EC31 VA: 0x2C6EB30
	public long get_m_SortValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C39B0 Offset: 0x2C3AB1 VA: 0x2C39B0
	// RVA: 0x2C6EB40 Offset: 0x2C6EC41 VA: 0x2C6EB40
	private void set_m_SortValue(long value) { }

	// RVA: 0x2C64710 Offset: 0x2C64811 VA: 0x2C64710
	public void .ctor(Unit unit, int itemIndex, RefineShopRefineBaseMenu.SelectEventHandler selectEventHandler, RefineShopRefineBaseMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2C6EB50 Offset: 0x2C6EC51 VA: 0x2C6EB50 Slot: 4
	public override string GetName() { }

	// RVA: 0x2C6EE20 Offset: 0x2C6EF21 VA: 0x2C6EE20 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2C6EEE0 Offset: 0x2C6EFE1 VA: 0x2C6EEE0 Slot: 27
	public override UnitItem GetUnitItem() { }

	// RVA: 0x2C6EEF0 Offset: 0x2C6EFF1 VA: 0x2C6EEF0 Slot: 28
	public override Unit GetUnit() { }

	// RVA: 0x2C6EF00 Offset: 0x2C6F001 VA: 0x2C6EF00 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2C6EF50 Offset: 0x2C6F051 VA: 0x2C6EF50 Slot: 18
	public override BasicMenu.Result ACall() { }
}

