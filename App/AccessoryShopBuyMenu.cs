// Namespace: App
public class AccessoryShopBuyMenu : BasicMenu // TypeDefIndex: 10888
{
	// Fields
	private AccessoryShopContent[] m_AccessoryShopContentArray; // 0xC8
	private AccessoryData.Kinds m_Kind; // 0xD0
	private BasicMenuSelect[] m_Selects; // 0xD8
	private AccessoryShopBuyMenu.SelectEventHandler m_SelectEventHandler; // 0xE0
	private AccessoryShopBuyMenu.DecideEventHandler m_DecideEventHandler; // 0xE8
	private AccessoryShopBuyMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0xF0
	private AccessoryShopBuyMenu.ChangeKindEventHandler m_ChangeKindEventHandler; // 0xF8

	// Methods

	// RVA: 0x2B16D10 Offset: 0x2B16E11 VA: 0x2B16D10
	public static AccessoryShopBuyMenu CreateBind(ProcInst super, GameObject menuObject, AccessoryShopBuyMenu.SelectEventHandler selectEventHandler, AccessoryShopBuyMenu.DecideEventHandler decideEventHandler, AccessoryShopBuyMenu.RequestCloseEventHandler requestCloseEventHandler, AccessoryShopBuyMenu.ChangeKindEventHandler changeKindEventHandler) { }

	// RVA: 0x2B177F0 Offset: 0x2B178F1 VA: 0x2B177F0
	public static List<BasicMenuItem> CreateMenuItem(AccessoryShopContent[] shopContentArray, int showRowNum, AccessoryData.Kinds kind, AccessoryShopBuyMenu.SelectEventHandler selectEventHandler, AccessoryShopBuyMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2B179A0 Offset: 0x2B17AA1 VA: 0x2B179A0
	protected void .ctor(List<BasicMenuItem> menuItemList, AccessoryShopBuyMenuContent menuContent, AccessoryShopContent[] accessoryShopContentArray, AccessoryShopBuyMenu.SelectEventHandler selectEventHandler, AccessoryShopBuyMenu.DecideEventHandler decideEventHandler, AccessoryShopBuyMenu.RequestCloseEventHandler requestCloseEventHandler, AccessoryShopBuyMenu.ChangeKindEventHandler changeKindEventHandler) { }

	// RVA: 0x2B18010 Offset: 0x2B18111 VA: 0x2B18010
	public void RebuildMenu(bool setupShopdata) { }

	// RVA: 0x2B18120 Offset: 0x2B18221 VA: 0x2B18120
	private void RebuildMenuItem() { }

	// RVA: 0x2B17BB0 Offset: 0x2B17CB1 VA: 0x2B17BB0
	public static List<AccessoryShopContent> Filter(AccessoryShopContent[] shopContentArray, AccessoryData.Kinds kind) { }

	// RVA: 0x2B18220 Offset: 0x2B18321 VA: 0x2B18220 Slot: 30
	public override string GetName() { }

	// RVA: 0x2B18270 Offset: 0x2B18371 VA: 0x2B18270
	public void EnableMenu() { }

	// RVA: 0x2B182E0 Offset: 0x2B183E1 VA: 0x2B182E0
	public void DisableMenu() { }

	// RVA: 0x2B18350 Offset: 0x2B18451 VA: 0x2B18350
	public void Show() { }

	// RVA: 0x2B18400 Offset: 0x2B18501 VA: 0x2B18400
	public void Hide() { }

	// RVA: 0x2B181B0 Offset: 0x2B182B1 VA: 0x2B181B0
	private BasicMenuSelect GetSelect() { }

	// RVA: 0x2B184B0 Offset: 0x2B185B1 VA: 0x2B184B0
	public AccessoryData.Kinds GetCurrentAccessoryKind() { }

	// RVA: 0x2B184C0 Offset: 0x2B185C1 VA: 0x2B184C0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x2B188E0 Offset: 0x2B189E1 VA: 0x2B188E0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2B18D10 Offset: 0x2B18E11 VA: 0x2B18D10
	public void OnDoneToBuy() { }

	// RVA: 0x2B18D20 Offset: 0x2B18E21 VA: 0x2B18D20 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

