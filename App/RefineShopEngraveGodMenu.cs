// Namespace: App
public class RefineShopEngraveGodMenu : BasicMenu // TypeDefIndex: 11105
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x296830 Offset: 0x296931 VA: 0x296830
	private Unit <m_Unit>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x296840 Offset: 0x296941 VA: 0x296840
	private UnitItem <m_BaseUnitItem>k__BackingField; // 0xD0
	private RefineShopEngraveGodMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0xD8

	// Properties
	public Unit m_Unit { get; set; }
	public UnitItem m_BaseUnitItem { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C35D0 Offset: 0x2C36D1 VA: 0x2C35D0
	// RVA: 0x2C61190 Offset: 0x2C61291 VA: 0x2C61190
	public Unit get_m_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C35E0 Offset: 0x2C36E1 VA: 0x2C35E0
	// RVA: 0x2C611A0 Offset: 0x2C612A1 VA: 0x2C611A0
	private void set_m_Unit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C35F0 Offset: 0x2C36F1 VA: 0x2C35F0
	// RVA: 0x2C611B0 Offset: 0x2C612B1 VA: 0x2C611B0
	public UnitItem get_m_BaseUnitItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3600 Offset: 0x2C3701 VA: 0x2C3600
	// RVA: 0x2C611C0 Offset: 0x2C612C1 VA: 0x2C611C0
	private void set_m_BaseUnitItem(UnitItem value) { }

	// RVA: 0x2C611D0 Offset: 0x2C612D1 VA: 0x2C611D0
	public static RefineShopEngraveGodMenu CreateBind(ProcInst super, GameObject menuObject, Unit unit, int itemIndex, RefineShopEngraveGodMenu.SelectEventHandler selectEventHandler, RefineShopEngraveGodMenu.DecideEventHandler decideEventHandler, RefineShopEngraveGodMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x2C619C0 Offset: 0x2C61AC1 VA: 0x2C619C0
	protected void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, Unit unit, UnitItem baseUnitItem, RefineShopEngraveGodMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x2C61A30 Offset: 0x2C61B31 VA: 0x2C61A30 Slot: 30
	public override string GetName() { }

	// RVA: 0x2C61A80 Offset: 0x2C61B81 VA: 0x2C61A80 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

