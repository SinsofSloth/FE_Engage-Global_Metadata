// Namespace: App
public class DiscardItemMenu : BasicMenu // TypeDefIndex: 12543
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29AA10 Offset: 0x29AB11 VA: 0x29AA10
	private int <m_AllMenuItemNum>k__BackingField; // 0xC4
	private Unit m_Unit; // 0xC8
	private UnitItem m_AddedUnitItem; // 0xD0
	private DiscardItemRoot m_Root; // 0xD8
	private ItemData.Kinds m_Kind; // 0xE0
	private BasicMenuSelect[] m_Selects; // 0xE8
	private bool m_Uncancellable; // 0xF0
	private DiscardItemMenu.DecideCallback m_DecideCallback; // 0xF8
	private DiscardItemMenu.CancelCallback m_CancelCallback; // 0x100

	// Properties
	public int m_AllMenuItemNum { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C9720 Offset: 0x2C9821 VA: 0x2C9720
	// RVA: 0x23742A0 Offset: 0x23743A1 VA: 0x23742A0
	public int get_m_AllMenuItemNum() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9730 Offset: 0x2C9831 VA: 0x2C9730
	// RVA: 0x23742B0 Offset: 0x23743B1 VA: 0x23742B0
	private void set_m_AllMenuItemNum(int value) { }

	// RVA: 0x23742C0 Offset: 0x23743C1 VA: 0x23742C0
	public static ProcInst CreateBind(ProcInst super, Unit unit, UnitItem addedUnitItem, bool uncancellable = False, DiscardItemMenu.DecideCallback decideCallback, DiscardItemMenu.CancelCallback cancelCallback) { }

	// RVA: 0x2374420 Offset: 0x2374521 VA: 0x2374420
	public static List<BasicMenuItem> CreateMenuItem(ItemData.Kinds kind, UnitItem addedUnitItem) { }

	// RVA: 0x2374D60 Offset: 0x2374E61 VA: 0x2374D60
	private static int Compare(BasicMenuItem lhs, BasicMenuItem rhs) { }

	// RVA: 0x2374A40 Offset: 0x2374B41 VA: 0x2374A40
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, DiscardItemRoot root, Unit unit, UnitItem addedUnitItem, bool uncancellable, DiscardItemMenu.DecideCallback decideCallback, DiscardItemMenu.CancelCallback cancelCallback) { }

	// RVA: 0x2374FA0 Offset: 0x23750A1 VA: 0x2374FA0 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x2375130 Offset: 0x2375231 VA: 0x2375130
	private void RebuildMenu() { }

	// RVA: 0x23752A0 Offset: 0x23753A1 VA: 0x23752A0
	public Unit GetUnit() { }

	// RVA: 0x23752B0 Offset: 0x23753B1 VA: 0x23752B0
	private UnitItem GetAddedUnitItem() { }

	// RVA: 0x2375230 Offset: 0x2375331 VA: 0x2375230
	private BasicMenuSelect GetSelect() { }

	// RVA: 0x23752C0 Offset: 0x23753C1 VA: 0x23752C0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x2375670 Offset: 0x2375771 VA: 0x2375670 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2375A30 Offset: 0x2375B31 VA: 0x2375A30 Slot: 52
	protected override BasicMenu.Result XCall() { }

	// RVA: 0x2375AF0 Offset: 0x2375BF1 VA: 0x2375AF0 Slot: 26
	public override void OnClose() { }

	// RVA: 0x2375C80 Offset: 0x2375D81 VA: 0x2375C80 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2375E40 Offset: 0x2375F41 VA: 0x2375E40
	public void DiscardItem(bool transporterIsSelected, int transporterItemIndex) { }
}

