// Namespace: App
public class ItemShopBuyMenu : BasicMenu // TypeDefIndex: 11018
{
	// Fields
	private ShopContent[] m_ShopContentArray; // 0xC8
	private ItemShopBuyMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0xD0
	private ItemShopBuyMenu.SwitchDetailDisplaywayEventHandler m_SwitchDetailDisplaywayEventHandler; // 0xD8
	private Unit m_Unit; // 0xE0
	private ItemShopBuyMenu.SelectEventHandler m_SelectEventHandler; // 0xE8
	private ItemShopBuyMenu.DecideEventHandler m_DecideEventHandler; // 0xF0
	private ItemShopBuyMenu.ChangeUnitToPrevEventHandler m_ChangeUnitToPrevEventHandler; // 0xF8
	private ItemShopBuyMenu.ChangeUnitToNextEventHandler m_ChangeUnitToNextEventHandler; // 0x100

	// Methods

	// RVA: 0x2456010 Offset: 0x2456111 VA: 0x2456010
	public static ItemShopBuyMenu CreateBind(ProcInst super, GameObject menuObject, Unit unit, ItemShopBuyMenu.SelectEventHandler selectEventHandler, ItemShopBuyMenu.DecideEventHandler decideEventHandler, ItemShopBuyMenu.RequestCloseEventHandler requestCloseMenuEventHandler, ItemShopBuyMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, ItemShopBuyMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler, ItemShopBuyMenu.SwitchDetailDisplaywayEventHandler switchDetailDisplayWayEventHandler) { }

	// RVA: 0x24563C0 Offset: 0x24564C1 VA: 0x24563C0
	public static ItemShopBuyMenu CreateBindForFleaMarket(ProcInst super, GameObject menuObject, Unit unit, ItemShopBuyMenu.SelectEventHandler selectEventHandler, ItemShopBuyMenu.DecideEventHandler decideEventHandler, ItemShopBuyMenu.RequestCloseEventHandler requestCloseMenuEventHandler, ItemShopBuyMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, ItemShopBuyMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler) { }

	// RVA: 0x24561F0 Offset: 0x24562F1 VA: 0x24561F0
	public static ItemShopBuyMenu CreateBindCommon(ProcInst super, GameObject menuObject, Unit unit, ShopContent[] shopContentArray, ItemShopBuyMenu.SelectEventHandler selectEventHandler, ItemShopBuyMenu.DecideEventHandler decideEventHandler, ItemShopBuyMenu.RequestCloseEventHandler requestCloseMenuEventHandler, ItemShopBuyMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, ItemShopBuyMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler, ItemShopBuyMenu.SwitchDetailDisplaywayEventHandler switchDetailDisplayWayEventHandler, bool forFleaMarket) { }

	// RVA: 0x2456450 Offset: 0x2456551 VA: 0x2456450
	public static List<BasicMenuItem> CreateMenuItem(ShopContent[] shopContentArray, Unit unit, ItemShopBuyMenu.SelectEventHandler selectEventHandler, ItemShopBuyMenu.DecideEventHandler decideEventHandler, ItemShopBuyMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, ItemShopBuyMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler, bool forFleaMarket) { }

	// RVA: 0x2456710 Offset: 0x2456811 VA: 0x2456710
	protected void .ctor(List<BasicMenuItem> menuItemList, ItemShopBuyMenuContent menuContent, ShopContent[] shopContentArray, Unit unit, ItemShopBuyMenu.SelectEventHandler selectEventHandler, ItemShopBuyMenu.DecideEventHandler decideEventHandler, ItemShopBuyMenu.RequestCloseEventHandler requestCloseMenuEventHandler, ItemShopBuyMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, ItemShopBuyMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler, ItemShopBuyMenu.SwitchDetailDisplaywayEventHandler switchDetailDisplayWayEventHandler) { }

	// RVA: 0x2456A10 Offset: 0x2456B11 VA: 0x2456A10
	public void RebuildMenu(Unit unit, bool keepSelect, bool setupShopdata) { }

	// RVA: 0x2456A50 Offset: 0x2456B51 VA: 0x2456A50
	private void RebuildMenu(bool keepSelect, bool setupShopdata) { }

	// RVA: 0x2456B60 Offset: 0x2456C61 VA: 0x2456B60
	public void RebuildMenuForFleaMarket(Unit unit, bool keepSelect, bool setupShopdata) { }

	// RVA: 0x2456BA0 Offset: 0x2456CA1 VA: 0x2456BA0
	private void RebuildMenuForFleaMarket(bool keepSelect, bool setupShopdata) { }

	// RVA: 0x2456CB0 Offset: 0x2456DB1 VA: 0x2456CB0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2456D00 Offset: 0x2456E01 VA: 0x2456D00 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x2456D30 Offset: 0x2456E31 VA: 0x2456D30 Slot: 52
	protected override BasicMenu.Result XCall() { }

	// RVA: 0x2456DE0 Offset: 0x2456EE1 VA: 0x2456DE0
	public void OnDoneToBuy() { }

	// RVA: 0x2456E60 Offset: 0x2456F61 VA: 0x2456E60
	public void OnDoneToBuyForFleaMarket() { }

	// RVA: 0x2455F10 Offset: 0x2456011 VA: 0x2455F10
	public void UpdateItemDetailMessages(ItemData itemData) { }
}

