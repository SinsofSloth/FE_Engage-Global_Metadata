// Namespace: App
public class WeaponShopBuyMenu : BasicMenu // TypeDefIndex: 11252
{
	// Fields
	private ShopContent[] m_ShopContentArray; // 0xC8
	private ItemData.Kinds m_Kind; // 0xD0
	private BasicMenuSelect[] m_Selects; // 0xD8
	private WeaponShopBuyMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0xE0
	private Unit m_Unit; // 0xE8
	private WeaponShopBuyMenu.SelectEventHandler m_SelectEventHandler; // 0xF0
	private WeaponShopBuyMenu.DecideEventHandler m_DecideEventHandler; // 0xF8
	private WeaponShopBuyMenu.ChangeUnitToPrevEventHandler m_ChangeUnitToPrevEventHandler; // 0x100
	private WeaponShopBuyMenu.ChangeUnitToNextEventHandler m_ChangeUnitToNextEventHandler; // 0x108
	private WeaponShopBuyMenu.SwitchDetailDisplaywayEventHandler m_SwitchDetailDisplaywayEventHandler; // 0x110

	// Methods

	// RVA: 0x26CDE70 Offset: 0x26CDF71 VA: 0x26CDE70
	public static WeaponShopBuyMenu CreateBind(ProcInst super, GameObject menuObject, Unit unit, WeaponShopBuyMenu.SelectEventHandler selectEventHandler, WeaponShopBuyMenu.DecideEventHandler decideEventHandler, WeaponShopBuyMenu.RequestCloseEventHandler requestCloseMenuEventHandler, WeaponShopBuyMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, WeaponShopBuyMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler, WeaponShopBuyMenu.SwitchDetailDisplaywayEventHandler switchDetailDisplayWayEventHandler) { }

	// RVA: 0x26CE3D0 Offset: 0x26CE4D1 VA: 0x26CE3D0
	protected void .ctor(List<BasicMenuItem> menuItemList, WeaponShopBuyMenuContent menuContent, ShopContent[] shopContentArray, Unit unit, WeaponShopBuyMenu.SelectEventHandler selectEventHandler, WeaponShopBuyMenu.DecideEventHandler decideEventHandler, WeaponShopBuyMenu.RequestCloseEventHandler requestCloseMenuEventHandler, WeaponShopBuyMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, WeaponShopBuyMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler, WeaponShopBuyMenu.SwitchDetailDisplaywayEventHandler switchDetailDisplaywayEventHandler) { }

	// RVA: 0x26CE910 Offset: 0x26CEA11 VA: 0x26CE910
	public void RebuildMenu(Unit unit, bool keepSelect, bool setupShopdata) { }

	// RVA: 0x26CE950 Offset: 0x26CEA51 VA: 0x26CE950
	private void RebuildMenu(bool keepSelect, bool setupShopdata) { }

	// RVA: 0x26CE120 Offset: 0x26CE221 VA: 0x26CE120
	public static List<BasicMenuItem> CreateMenuItem(ShopContent[] shopContentArray, ItemData.Kinds kind, Unit unit, WeaponShopBuyMenu.SelectEventHandler selectEventHandler, WeaponShopBuyMenu.DecideEventHandler decideEventHandler, WeaponShopBuyMenu.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, WeaponShopBuyMenu.ChangeUnitToNextEventHandler changeUnitToNextEventHandler) { }

	// RVA: 0x26CEB30 Offset: 0x26CEC31 VA: 0x26CEB30
	public static List<ShopContent> Filter(ShopContent[] shopContentArray, ItemData.Kinds kind) { }

	// RVA: 0x26CEFC0 Offset: 0x26CF0C1 VA: 0x26CEFC0 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x26CF130 Offset: 0x26CF231 VA: 0x26CF130 Slot: 30
	public override string GetName() { }

	// RVA: 0x26CEAC0 Offset: 0x26CEBC1 VA: 0x26CEAC0
	private BasicMenuSelect GetSelect() { }

	// RVA: 0x26CF180 Offset: 0x26CF281 VA: 0x26CF180 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x26CF540 Offset: 0x26CF641 VA: 0x26CF540 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x26CF920 Offset: 0x26CFA21 VA: 0x26CF920 Slot: 50
	protected override BasicMenu.Result ACall() { }

	// RVA: 0x26CF9A0 Offset: 0x26CFAA1 VA: 0x26CF9A0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x26CF9D0 Offset: 0x26CFAD1 VA: 0x26CF9D0 Slot: 52
	protected override BasicMenu.Result XCall() { }

	// RVA: 0x26CFA80 Offset: 0x26CFB81 VA: 0x26CFA80 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x26CFA90 Offset: 0x26CFB91 VA: 0x26CFA90
	public void OnDoneToBuy() { }
}

