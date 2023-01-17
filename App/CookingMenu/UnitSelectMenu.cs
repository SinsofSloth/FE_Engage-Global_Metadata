// Namespace: App.CookingMenu
public class UnitSelectMenu : BasicMenu // TypeDefIndex: 14259
{
	// Fields
	private static List<Unit> s_SelectUnitList; // 0x0
	private static UnitSelectMenuContent s_Content; // 0x8
	private static int s_SelectIndex; // 0x10
	private static int s_ScrollIndex; // 0x14
	private static bool s_IsFirstSelect; // 0x18
	private Action m_CloseCallback; // 0xC8

	// Methods

	// RVA: 0x208E6F0 Offset: 0x208E7F1 VA: 0x208E6F0
	protected void .ctor(List<BasicMenuItem> menuItemList, UnitSelectMenuContent menuContent, List<Unit> selectUnitList, Action closeCallback) { }

	// RVA: 0x208E800 Offset: 0x208E901 VA: 0x208E800 Slot: 30
	public override string GetName() { }

	// RVA: 0x208E850 Offset: 0x208E951 VA: 0x208E850
	public static void CreateBind(ProcInst super, List<Unit> selectUnitList, DishAllMenuContent allContent, Action closeCallback) { }

	// RVA: 0x208ED40 Offset: 0x208EE41 VA: 0x208ED40
	private static void OnSelectMenuItem(Unit unit) { }

	// RVA: 0x208EDD0 Offset: 0x208EED1 VA: 0x208EDD0 Slot: 50
	protected override BasicMenu.Result ACall() { }

	// RVA: 0x208F130 Offset: 0x208F231 VA: 0x208F130
	private void NextItem() { }

	// RVA: 0x208F220 Offset: 0x208F321 VA: 0x208F220 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x208F5B0 Offset: 0x208F6B1 VA: 0x208F5B0
	private UnitSelectMenu.UnitSelectMenuItem GetUnitMenuItemCurrent() { }

	// RVA: 0x208F080 Offset: 0x208F181 VA: 0x208F080
	private UnitSelectMenu.UnitSelectMenuItem GetUnitMenuItem(int index) { }

	// RVA: 0x208F3F0 Offset: 0x208F4F1 VA: 0x208F3F0
	private UnitSelectMenu.UnitSelectMenuItem GetUnitMenuItem(Unit unit) { }

	// RVA: 0x208F660 Offset: 0x208F761 VA: 0x208F660 Slot: 26
	public override void OnClose() { }

	// RVA: 0x208EB90 Offset: 0x208EC91 VA: 0x208EB90
	private static void RestoreMenu(List<UnitSelectMenu.UnitSelectMenuItem> menuItemList, List<Unit> selectedUnitList) { }

	// RVA: 0x208F810 Offset: 0x208F911 VA: 0x208F810 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x208F8E0 Offset: 0x208F9E1 VA: 0x208F8E0
	private static void .cctor() { }
}

