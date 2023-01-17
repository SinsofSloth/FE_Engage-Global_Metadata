// Namespace: App
public class RingSelectMenu : BasicMenu // TypeDefIndex: 13234
{
	// Fields
	private const int GidMax = 64;
	private Unit m_unit; // 0xC8
	private UnitStatusSetter m_statusSetter; // 0xD0
	private RingSelectRoot m_ringSelectRoot; // 0xD8
	private List<BasicMenuSelect> m_menuSelect; // 0xE0
	private int m_selectPage; // 0xE8
	private static List<string> m_gidPageName; // 0x0
	private static bool m_isUnitChangeAnim; // 0x8
	private static bool m_isUnitChangeEquip; // 0x9
	public static Dictionary<Unit, string> m_ringUnitList; // 0x10

	// Methods

	// RVA: 0x2693E20 Offset: 0x2693F21 VA: 0x2693E20
	public static int GetPoolGodNum() { }

	// RVA: 0x2694070 Offset: 0x2694171 VA: 0x2694070
	public static GodUnit GetPoolGod(int index) { }

	// RVA: 0x2694010 Offset: 0x2694111 VA: 0x2694010
	private static bool IsIgnoreForRelay(GodUnit god) { }

	// RVA: 0x26942B0 Offset: 0x26943B1 VA: 0x26942B0
	public static bool IsIgnoreForRelay(UnitRing unitRing) { }

	// RVA: 0x2694310 Offset: 0x2694411 VA: 0x2694310
	public static RingSelectMenu Create(ProcInst super, Unit unit, RingSelectMenuContent menuContent, UnitStatusSetter statusSetter, RingSelectRoot ringSelectRoot) { }

	// RVA: 0x2694570 Offset: 0x2694671 VA: 0x2694570
	private static int CreateRingCategory(Unit unit) { }

	// RVA: 0x2694D20 Offset: 0x2694E21 VA: 0x2694D20
	public static List<BasicMenuItem> CreateMenuItemList(Unit unit, int page, RingSelectRoot ringSelectRoot, out int defaultMenuItemIndex) { }

	// RVA: 0x2695930 Offset: 0x2695A31 VA: 0x2695930
	private static List<BasicMenuItem> CreateMenuItemListForVersus(Unit unit, out int defaultIndex) { }

	// RVA: 0x2695C50 Offset: 0x2695D51 VA: 0x2695C50
	public void RebuildMenu(int displayIndex, Unit equipUnit) { }

	// RVA: 0x2695FF0 Offset: 0x26960F1 VA: 0x2695FF0
	public void SaveSelect() { }

	// RVA: 0x2696070 Offset: 0x2696171 VA: 0x2696070
	public bool IsEmptyCommon() { }

	// RVA: 0x2696110 Offset: 0x2696211 VA: 0x2696110
	public int GetDisplayIndex() { }

	// RVA: 0x26956B0 Offset: 0x26957B1 VA: 0x26956B0
	protected void .ctor(List<BasicMenuItem> menuItemList, RingSelectMenuContent menuContent, Unit unit, UnitStatusSetter statusSetter, RingSelectRoot ringSelectRoot, int page) { }

	// RVA: 0x2696120 Offset: 0x2696221 VA: 0x2696120 Slot: 30
	public override string GetName() { }

	// RVA: 0x2696170 Offset: 0x2696271 VA: 0x2696170 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x2696290 Offset: 0x2696391 VA: 0x2696290 Slot: 52
	protected override BasicMenu.Result XCall() { }

	// RVA: 0x26965E0 Offset: 0x26966E1 VA: 0x26965E0 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x2698380 Offset: 0x2698481 VA: 0x2698380
	public Unit GetUnit() { }

	// RVA: 0x2698130 Offset: 0x2698231 VA: 0x2698130
	public void UpdateStatus() { }

	// RVA: 0x2698300 Offset: 0x2698401 VA: 0x2698300
	public int GetPageNum() { }

	// RVA: 0x2698390 Offset: 0x2698491 VA: 0x2698390
	public string GetPageGodGid(int index) { }

	// RVA: 0x2698430 Offset: 0x2698531 VA: 0x2698430
	public int GetSelectPage() { }

	// RVA: 0x2696530 Offset: 0x2696631 VA: 0x2696530
	public UnitRing GetSelectRing() { }

	// RVA: 0x2696480 Offset: 0x2696581 VA: 0x2696480
	public GodUnit GetSelectGod() { }

	// RVA: 0x2698440 Offset: 0x2698541 VA: 0x2698440
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB660 Offset: 0x2CB761 VA: 0x2CB660
	// RVA: 0x2698540 Offset: 0x2698641 VA: 0x2698540
	private void <CustomCall>b__26_0() { }
}

