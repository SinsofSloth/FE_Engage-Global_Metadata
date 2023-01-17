// Namespace: App
public class TroopListMenu : BasicMenu // TypeDefIndex: 13296
{
	// Fields
	private static SortieSequenceTroopList.Mode m_mode; // 0x0
	private static int m_page; // 0x4
	public static readonly int ListUnitNum; // 0x8
	private static int m_ListUnitNum; // 0xC
	private static Unit[] m_ListUnit; // 0x10
	private static Unit[] m_TmpListUnit; // 0x18
	private static TroopListSortMenu m_sortMenu; // 0x20
	private bool m_SelectSort; // 0xC4

	// Methods

	// RVA: 0x28734F0 Offset: 0x28735F1 VA: 0x28734F0
	public static TroopListMenu Create(ProcInst super, TroopListMenuContent menuContent, TroopListSortMenu sortMenu, SortieSequenceTroopList.Mode mode) { }

	// RVA: 0x2873D20 Offset: 0x2873E21 VA: 0x2873D20
	protected void .ctor(List<BasicMenuItem> menuItemList, TroopListMenuContent menuContent) { }

	// RVA: 0x2874370 Offset: 0x2874471 VA: 0x2874370 Slot: 30
	public override string GetName() { }

	// RVA: 0x28743C0 Offset: 0x28744C1 VA: 0x28743C0 Slot: 44
	protected override void MoveUp(bool isTrigger) { }

	// RVA: 0x2874930 Offset: 0x2874A31 VA: 0x2874930 Slot: 45
	protected override void MoveDown(bool isTrigger) { }

	// RVA: 0x2874D10 Offset: 0x2874E11 VA: 0x2874D10 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x2876160 Offset: 0x2876261 VA: 0x2876160 Slot: 50
	protected override BasicMenu.Result ACall() { }

	// RVA: 0x2876620 Offset: 0x2876721 VA: 0x2876620
	public int GetCurrentPage() { }

	// RVA: 0x2875E40 Offset: 0x2875F41 VA: 0x2875E40
	public void IncPage(bool isTrigger) { }

	// RVA: 0x28758A0 Offset: 0x28759A1 VA: 0x28758A0
	public void DecPage(bool isTrigger) { }

	// RVA: 0x2875BF0 Offset: 0x2875CF1 VA: 0x2875BF0
	private void IncSort(bool isTrigger) { }

	// RVA: 0x2875650 Offset: 0x2875751 VA: 0x2875650
	private void DecSort(bool isTrigger) { }

	// RVA: 0x28737A0 Offset: 0x28738A1 VA: 0x28737A0
	private static void InitUnitOrder() { }

	// RVA: 0x2876CE0 Offset: 0x2876DE1 VA: 0x2876CE0
	private static void AddListUnit(Unit unit) { }

	// RVA: 0x2876B00 Offset: 0x2876C01 VA: 0x2876B00
	private static void InitUnitOrderNormal() { }

	// RVA: 0x28768A0 Offset: 0x28769A1 VA: 0x28768A0
	private static void InitUnitOrderRelay() { }

	// RVA: 0x2873840 Offset: 0x2873941 VA: 0x2873840
	private static void SortUnitOrder() { }

	// RVA: 0x2876FE0 Offset: 0x28770E1 VA: 0x2876FE0
	private static int GetSortValue(Unit unit, TroopListSortMenu.SortType type) { }

	// RVA: 0x2878640 Offset: 0x2878741 VA: 0x2878640
	public Unit GetSortUnit(int index) { }

	// RVA: 0x2878720 Offset: 0x2878821 VA: 0x2878720
	public Unit GetSortTmpUnit(int index) { }

	// RVA: 0x2878800 Offset: 0x2878901 VA: 0x2878800
	public bool IsSelectSort() { }

	// RVA: 0x2878810 Offset: 0x2878911 VA: 0x2878810
	private static void .cctor() { }
}

