// Namespace: App
public class AccessoryShopChangeMenu : BasicMenu // TypeDefIndex: 10905
{
	// Fields
	private AccessoryData.Kinds m_Kind; // 0xC4
	private Unit m_Unit; // 0xC8
	private BasicMenuSelect[] m_Selects; // 0xD0
	private AccessoryMenuItem.SelectEventHandler m_SelectEventHandler; // 0xD8
	private AccessoryMenuItem.DecideEventHandler m_DecideEventHandler; // 0xE0
	private AccessoryShopChangeMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0xE8
	private AccessoryShopChangeMenu.ChangeKindEventHandler m_ChangeKindEventHandler; // 0xF0

	// Methods

	// RVA: 0x2B1D510 Offset: 0x2B1D611 VA: 0x2B1D510
	public static AccessoryShopChangeMenu CreateBind(ProcInst super, GameObject menuObject, Unit unit, AccessoryMenuItem.SelectEventHandler selectEventHandler, AccessoryMenuItem.DecideEventHandler decideEventHandler, AccessoryShopChangeMenu.RequestCloseEventHandler requestCloseEventHandler, AccessoryShopChangeMenu.ChangeKindEventHandler changeKindEventHandler) { }

	// RVA: 0x2B1D650 Offset: 0x2B1D751 VA: 0x2B1D650
	public static List<BasicMenuItem> CreateMenuItem(int showRowNum, AccessoryData.Kinds kind, Unit unit, AccessoryMenuItem.SelectEventHandler selectEventHandler, AccessoryMenuItem.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2B1DB30 Offset: 0x2B1DC31 VA: 0x2B1DB30
	protected void .ctor(List<BasicMenuItem> menuItemList, AccessoryShopChangeMenuContent menuContent, Unit unit, AccessoryMenuItem.SelectEventHandler selectEventHandler, AccessoryMenuItem.DecideEventHandler decideEventHandler, AccessoryShopChangeMenu.RequestCloseEventHandler requestCloseEventHandler, AccessoryShopChangeMenu.ChangeKindEventHandler changeKindEventHandler) { }

	// RVA: 0x2B1E140 Offset: 0x2B1E241 VA: 0x2B1E140
	public void RebuildMenu(Unit unit) { }

	// RVA: 0x2B1E170 Offset: 0x2B1E271 VA: 0x2B1E170
	public void RebuildMenu() { }

	// RVA: 0x2B1E270 Offset: 0x2B1E371 VA: 0x2B1E270
	private void RebuildMenuItem() { }

	// RVA: 0x2B1DD40 Offset: 0x2B1DE41 VA: 0x2B1DD40
	public static List<AccessoryData> Filter(AccessoryData.Kinds kind, Unit unit) { }

	// RVA: 0x2B1E370 Offset: 0x2B1E471 VA: 0x2B1E370 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x2B1E490 Offset: 0x2B1E591 VA: 0x2B1E490 Slot: 30
	public override string GetName() { }

	// RVA: 0x2B1E4E0 Offset: 0x2B1E5E1 VA: 0x2B1E4E0
	public void EnableMenu() { }

	// RVA: 0x2B1E550 Offset: 0x2B1E651 VA: 0x2B1E550
	public void DisableMenu() { }

	// RVA: 0x2B1E5C0 Offset: 0x2B1E6C1 VA: 0x2B1E5C0
	public void Show() { }

	// RVA: 0x2B1E670 Offset: 0x2B1E771 VA: 0x2B1E670
	public void Hide() { }

	// RVA: 0x2B1E300 Offset: 0x2B1E401 VA: 0x2B1E300
	private BasicMenuSelect GetSelect() { }

	// RVA: 0x2B1E720 Offset: 0x2B1E821 VA: 0x2B1E720
	public AccessoryData GetSelectedAccessoryData() { }

	// RVA: 0x2B1E7E0 Offset: 0x2B1E8E1 VA: 0x2B1E7E0
	public AccessoryData.Kinds GetCurrentAccessoryKind() { }

	// RVA: 0x2B1E7F0 Offset: 0x2B1E8F1 VA: 0x2B1E7F0
	public void UpdateDecision(UnitAccessoryList unitAccessoryList) { }

	// RVA: 0x2B1E3A0 Offset: 0x2B1E4A1 VA: 0x2B1E3A0
	private void UpdateCursorZOrder() { }

	// RVA: 0x2B1EA00 Offset: 0x2B1EB01 VA: 0x2B1EA00
	public void PrepareToChangeUnit() { }

	// RVA: 0x2B1EA70 Offset: 0x2B1EB71 VA: 0x2B1EA70 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x2B1EE80 Offset: 0x2B1EF81 VA: 0x2B1EE80 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2B1F2B0 Offset: 0x2B1F3B1 VA: 0x2B1F2B0 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

