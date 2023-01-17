// Namespace: App
public class ShopSellMenu : BasicMenu // TypeDefIndex: 11195
{
	// Fields
	private ItemData.Kinds m_Kind; // 0xC4
	private BasicMenuSelect[] m_Selects; // 0xC8
	private bool[] m_DecidedItemFlag; // 0xD0
	private List<UnitItem> m_DecidedItemList; // 0xD8
	private int m_TotalValue; // 0xE0
	private Unit m_Unit; // 0xE8
	private ShopSellMenu.SelectEventHandler m_SelectEventHandler; // 0xF0
	private ShopSellMenu.DecideItemEventHandler m_DecideItemEventHandler; // 0xF8
	private ShopSellMenu.CancelItemEventHandler m_CancelItemEventHandler; // 0x100
	private ShopSellMenu.DecideEventHandler m_DecideEventHandler; // 0x108
	private ShopSellMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0x110
	private ShopSellMenu.ChangeUnitToPrevEventHandler m_ChangeUnitToPrevEventHandler; // 0x118
	private ShopSellMenu.ChangeUnitToNextEventHandler m_ChangeUnitToNextEventHandler; // 0x120
	private ShopSellMenu.SwitchDetailDisplaywayEventHandler m_SwitchDetailDisplaywayEventHandler; // 0x128

	// Methods

	// RVA: 0x2336710 Offset: 0x2336811 VA: 0x2336710
	public static ShopSellMenu CreateBind(ProcInst super, GameObject menuObject, Unit unit, ShopSellMenu.SelectEventHandler selectEventHandler, ShopSellMenu.DecideItemEventHandler decideItemEventHandler, ShopSellMenu.CancelItemEventHandler cancelItemEventHandler, ShopSellMenu.DecideEventHandler decideEventHandler, ShopSellMenu.RequestCloseEventHandler requestCloseEventHandler, ShopSellMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, ShopSellMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler, ShopSellMenu.SwitchDetailDisplaywayEventHandler switchDetailDisplaywayEventHandler) { }

	// RVA: 0x2336870 Offset: 0x2336971 VA: 0x2336870
	public static List<BasicMenuItem> BuildMenuItem(Unit unit, int showRowNum, ItemData.Kinds kind, bool[] decidedItem, ShopSellMenu.SelectEventHandler selectEventHandler, ShopSellMenuItem.DecideItemEventHandler decideItemEventHandler, ShopSellMenuItem.CancelItemEventHandler cancelItemEventHandler, ShopSellMenu.DecideEventHandler decideEventHandler, ShopSellMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, ShopSellMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler) { }

	// RVA: 0x2336E00 Offset: 0x2336F01 VA: 0x2336E00
	protected void .ctor(List<BasicMenuItem> menuItemList, ShopSellMenuContent menuContent, Unit unit, ShopSellMenu.SelectEventHandler selectEventHandler, ShopSellMenu.DecideItemEventHandler decideItemEventHandler, ShopSellMenu.CancelItemEventHandler cancelItemEventHandler, ShopSellMenu.DecideEventHandler decideEventHandler, ShopSellMenu.RequestCloseEventHandler requestCloseEventHandler, ShopSellMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, ShopSellMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler, ShopSellMenu.SwitchDetailDisplaywayEventHandler switchDetailDisplaywayEventHandler) { }

	// RVA: 0x2337630 Offset: 0x2337731 VA: 0x2337630
	public void RebuildMenu(Unit unit) { }

	// RVA: 0x2337660 Offset: 0x2337761 VA: 0x2337660
	private void RebuildMenu() { }

	// RVA: 0x23376F0 Offset: 0x23377F1 VA: 0x23376F0
	private void RebuildMenuItem() { }

	// RVA: 0x23378C0 Offset: 0x23379C1 VA: 0x23378C0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2337850 Offset: 0x2337951 VA: 0x2337850
	private BasicMenuSelect GetSelect() { }

	// RVA: 0x2337910 Offset: 0x2337A11 VA: 0x2337910
	public void EnableMenu(ShopSellMenu.KindIndicator indicator = 0) { }

	// RVA: 0x2337B10 Offset: 0x2337C11 VA: 0x2337B10
	public void MoveFrontCursorFrom(BasicMenu fromMenu) { }

	// RVA: 0x2337C30 Offset: 0x2337D31 VA: 0x2337C30
	public void DisableMenu() { }

	// RVA: 0x2337CA0 Offset: 0x2337DA1 VA: 0x2337CA0
	public List<UnitItem> GetDecidedList(int max = 999) { }

	// RVA: 0x2337DE0 Offset: 0x2337EE1 VA: 0x2337DE0
	public int GetTotalValue() { }

	// RVA: 0x2336670 Offset: 0x2336771 VA: 0x2336670
	public void ClearDecided() { }

	// RVA: 0x2337EF0 Offset: 0x2337FF1 VA: 0x2337EF0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x23382A0 Offset: 0x23383A1 VA: 0x23382A0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2338660 Offset: 0x2338761 VA: 0x2338660 Slot: 50
	protected override BasicMenu.Result ACall() { }

	// RVA: 0x23386E0 Offset: 0x23387E1 VA: 0x23386E0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x2338710 Offset: 0x2338811 VA: 0x2338710 Slot: 52
	protected override BasicMenu.Result XCall() { }

	// RVA: 0x23387C0 Offset: 0x23388C1 VA: 0x23387C0
	public void OnDecideItem(int itemIndex) { }

	// RVA: 0x2338910 Offset: 0x2338A11 VA: 0x2338910
	public void OnCancelItem(int itemIndex) { }

	// RVA: 0x2338A50 Offset: 0x2338B51 VA: 0x2338A50
	public void SellMulti() { }

	// RVA: 0x2338CC0 Offset: 0x2338DC1 VA: 0x2338CC0
	private static int Compare(BasicMenuItem lhs, BasicMenuItem rhs) { }
}

