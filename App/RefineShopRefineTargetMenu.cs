// Namespace: App
public class RefineShopRefineTargetMenu : BasicMenu // TypeDefIndex: 11159
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x296D70 Offset: 0x296E71 VA: 0x296D70
	private Unit <m_Unit>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x296D80 Offset: 0x296E81 VA: 0x296D80
	private UnitItem <m_UnitItem>k__BackingField; // 0xD0
	private RefineShopRefineTargetMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0xD8

	// Properties
	public Unit m_Unit { get; set; }
	public UnitItem m_UnitItem { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C39D0 Offset: 0x2C3AD1 VA: 0x2C39D0
	// RVA: 0x2C71060 Offset: 0x2C71161 VA: 0x2C71060
	public Unit get_m_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C39E0 Offset: 0x2C3AE1 VA: 0x2C39E0
	// RVA: 0x2C71070 Offset: 0x2C71171 VA: 0x2C71070
	private void set_m_Unit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C39F0 Offset: 0x2C3AF1 VA: 0x2C39F0
	// RVA: 0x2C71080 Offset: 0x2C71181 VA: 0x2C71080
	public UnitItem get_m_UnitItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3A00 Offset: 0x2C3B01 VA: 0x2C3A00
	// RVA: 0x2C71090 Offset: 0x2C71191 VA: 0x2C71090
	private void set_m_UnitItem(UnitItem value) { }

	// RVA: 0x2C710A0 Offset: 0x2C711A1 VA: 0x2C710A0
	public static RefineShopRefineTargetMenu CreateBind(ProcInst super, GameObject menuObject, Unit unit, int itemIndex, RefineShopRefineTargetMenu.SelectEventHandler selectEventHandler, RefineShopRefineTargetMenu.DecideToRefineEventHandler decideToRefineEventHandler, RefineShopRefineTargetMenu.DecideToEvolveEventHandler decideToEvolveEventHandler, RefineShopRefineTargetMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x2C71400 Offset: 0x2C71501 VA: 0x2C71400
	public static List<BasicMenuItem> CreateMenuItemList(int showRowNum, UnitItem unitItem, RefineShopRefineTargetMenu.SelectEventHandler selectEventHandler, RefineShopRefineTargetMenu.DecideToRefineEventHandler decideToRefineEventHandler, RefineShopRefineTargetMenu.DecideToEvolveEventHandler decideToEvolveEventHandler) { }

	// RVA: 0x2C71640 Offset: 0x2C71741 VA: 0x2C71640
	protected void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, Unit ownerUnit, UnitItem baseUnitItem, RefineShopRefineTargetMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x2C716B0 Offset: 0x2C717B1 VA: 0x2C716B0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2C71700 Offset: 0x2C71801 VA: 0x2C71700 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

