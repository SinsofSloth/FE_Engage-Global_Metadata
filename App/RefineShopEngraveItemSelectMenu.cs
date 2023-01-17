// Namespace: App
public class RefineShopEngraveItemSelectMenu : RefineShopRefineBaseMenu // TypeDefIndex: 11119
{
	// Methods

	// RVA: 0x2C63D80 Offset: 0x2C63E81 VA: 0x2C63D80
	public static RefineShopEngraveItemSelectMenu CreateBind(ProcInst super, GameObject menuObject, Unit defaultUnit, int defaultItemIndex, ItemData.Kinds defaultItemKind, RefineShopRefineBaseMenu.SelectEventHandler selectEventHandler, RefineShopRefineBaseMenu.DecideEventHandler decideEventHandler, RefineShopRefineBaseMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x2C63F10 Offset: 0x2C64011 VA: 0x2C63F10
	public static List<BasicMenuItem> CreateMenuItemList(int showRowNum, ItemData.Kinds kind, RefineShopRefineBaseMenu.SelectEventHandler selectEventHandler, RefineShopRefineBaseMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2C64620 Offset: 0x2C64721 VA: 0x2C64620
	private static bool IsValidUnitItemToMenuItem(UnitItem unitItem, ItemData.Kinds kind) { }

	// RVA: 0x2C64550 Offset: 0x2C64651 VA: 0x2C64550
	protected void .ctor(List<BasicMenuItem> menuItemList, RefineShopRefineBaseMenuContent menuContent, Unit defaultUnit, int defaultItemIndex, ItemData.Kinds kind, RefineShopRefineBaseMenu.SelectEventHandler selectEventHandler, RefineShopRefineBaseMenu.DecideEventHandler decideEventHandler, RefineShopRefineBaseMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x2C64C20 Offset: 0x2C64D21 VA: 0x2C64C20 Slot: 64
	protected override void RebuildMenuItem() { }
}

