// Namespace: App
public class RefineShopRefineBaseMenu : BasicMenu // TypeDefIndex: 11147
{
	// Fields
	public static int s_MenuScrollIndex; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x296C00 Offset: 0x296D01 VA: 0x296C00
	private ItemData.Kinds <m_Kind>k__BackingField; // 0xC4
	protected RefineShopRefineBaseMenu.SelectEventHandler m_SelectEventHandler; // 0xC8
	protected RefineShopRefineBaseMenu.DecideEventHandler m_DecideEventHandler; // 0xD0
	protected RefineShopRefineBaseMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0xD8
	private List<BasicMenuSelect> m_MenuSelectList; // 0xE0

	// Properties
	public ItemData.Kinds m_Kind { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3920 Offset: 0x2C3A21 VA: 0x2C3920
	// RVA: 0x2C6CFE0 Offset: 0x2C6D0E1 VA: 0x2C6CFE0
	public ItemData.Kinds get_m_Kind() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3930 Offset: 0x2C3A31 VA: 0x2C3930
	// RVA: 0x2C6CFF0 Offset: 0x2C6D0F1 VA: 0x2C6CFF0
	protected void set_m_Kind(ItemData.Kinds value) { }

	// RVA: 0x2C6D000 Offset: 0x2C6D101 VA: 0x2C6D000
	public static RefineShopRefineBaseMenu CreateBind(ProcInst super, GameObject menuObject, Unit defaultUnit, int defaultItemIndex, ItemData.Kinds defaultItemKind, RefineShopRefineBaseMenu.SelectEventHandler selectEventHandler, RefineShopRefineBaseMenu.DecideEventHandler decideEventHandler, RefineShopRefineBaseMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x2C6D160 Offset: 0x2C6D261 VA: 0x2C6D160
	public static List<BasicMenuItem> CreateMenuItemList(int showRowNum, ItemData.Kinds kind, RefineShopRefineBaseMenu.SelectEventHandler selectEventHandler, RefineShopRefineBaseMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2C6D540 Offset: 0x2C6D641 VA: 0x2C6D540
	private static bool IsValidUnitItemToMenuItem(UnitItem unitItem, ItemData.Kinds kind) { }

	// RVA: 0x2C6D700 Offset: 0x2C6D801 VA: 0x2C6D700
	private static bool ExistTarget(UnitItem unitItem) { }

	// RVA: 0x2C6D7B0 Offset: 0x2C6D8B1 VA: 0x2C6D7B0
	protected static int Compare(BasicMenuItem lhs, BasicMenuItem rhs) { }

	// RVA: 0x2C64940 Offset: 0x2C64A41 VA: 0x2C64940
	protected void .ctor(List<BasicMenuItem> menuItemList, RefineShopRefineBaseMenuContent menuContent, Unit defaultUnit, int defaultItemIndex, ItemData.Kinds kind, RefineShopRefineBaseMenu.SelectEventHandler selectEventHandler, RefineShopRefineBaseMenu.DecideEventHandler decideEventHandler, RefineShopRefineBaseMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x2C6DB40 Offset: 0x2C6DC41 VA: 0x2C6DB40
	private void RebuildMenu() { }

	// RVA: 0x2C6DD40 Offset: 0x2C6DE41 VA: 0x2C6DD40 Slot: 64
	protected virtual void RebuildMenuItem() { }

	// RVA: 0x2C6DE10 Offset: 0x2C6DF11 VA: 0x2C6DE10 Slot: 30
	public override string GetName() { }

	// RVA: 0x2C6DE60 Offset: 0x2C6DF61 VA: 0x2C6DE60 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x2C6E250 Offset: 0x2C6E351 VA: 0x2C6E250 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2C6E650 Offset: 0x2C6E751 VA: 0x2C6E650 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x2C6E6D0 Offset: 0x2C6E7D1 VA: 0x2C6E6D0
	private static void .cctor() { }
}

