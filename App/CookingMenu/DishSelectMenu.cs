// Namespace: App.CookingMenu
public class DishSelectMenu : BasicMenu // TypeDefIndex: 14239
{
	// Fields
	private static DishSelectMenuContent s_Content; // 0x0
	private static List<Unit> s_SelectUnitList; // 0x8
	private static DishSelectMenu.DecideEventHandler s_DecideEventHandler; // 0x10
	private List<BasicMenuSelect> m_MenuSelectList; // 0xC8
	private DishSelectMenu.CancelEventHandler m_CancelEventHandler; // 0xD0
	private static List<CookData> s_SelectedUnitCookList; // 0x18
	private static bool s_IsFirstSelect; // 0x20

	// Methods

	// RVA: 0x237CCC0 Offset: 0x237CDC1 VA: 0x237CCC0
	protected void .ctor(List<BasicMenuItem> menuItemList, DishSelectMenu.CancelEventHandler cancelEventHandler) { }

	// RVA: 0x237CEF0 Offset: 0x237CFF1 VA: 0x237CEF0 Slot: 30
	public override string GetName() { }

	// RVA: 0x237CF40 Offset: 0x237D041 VA: 0x237CF40
	public static void CreateBind(ProcInst super, DishAllMenuContent allContent, List<Unit> selectedUnitList, DishSelectMenu.DecideEventHandler decideEventHandler, DishSelectMenu.CancelEventHandler cancelEventHandler) { }

	// RVA: 0x237D240 Offset: 0x237D341 VA: 0x237D240
	private static List<BasicMenuItem> CreateMenuItemList() { }

	// RVA: 0x237D690 Offset: 0x237D791 VA: 0x237D690
	private void SetupMenuSkill() { }

	// RVA: 0x237D7B0 Offset: 0x237D8B1 VA: 0x237D7B0
	public void UpdateDisplayIndex() { }

	// RVA: 0x237D7D0 Offset: 0x237D8D1 VA: 0x237D7D0 Slot: 50
	protected override BasicMenu.Result ACall() { }

	// RVA: 0x237D880 Offset: 0x237D981 VA: 0x237D880 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x237D8C0 Offset: 0x237D9C1 VA: 0x237D8C0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x237DBB0 Offset: 0x237DCB1 VA: 0x237DBB0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x237DEC0 Offset: 0x237DFC1 VA: 0x237DEC0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x237DF90 Offset: 0x237E091 VA: 0x237DF90
	private static void .cctor() { }
}

