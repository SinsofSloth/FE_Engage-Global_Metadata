// Namespace: App
public class SortieTradeItemMenu : BasicMenu // TypeDefIndex: 13290
{
	// Fields
	private Unit m_unit; // 0xC8
	private Unit m_recieverUnit; // 0xD0
	private int m_firstSelect; // 0xD8
	private int m_secondSelect; // 0xDC
	[CompilerGeneratedAttribute] // RVA: 0x29BCE0 Offset: 0x29BDE1 VA: 0x29BCE0
	private int <m_CommonIndex>k__BackingField; // 0xE0

	// Properties
	public int m_CommonIndex { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB690 Offset: 0x2CB791 VA: 0x2CB690
	// RVA: 0x21723A0 Offset: 0x21724A1 VA: 0x21723A0
	public int get_m_CommonIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB6A0 Offset: 0x2CB7A1 VA: 0x2CB6A0
	// RVA: 0x21723B0 Offset: 0x21724B1 VA: 0x21723B0
	private void set_m_CommonIndex(int value) { }

	// RVA: 0x2166600 Offset: 0x2166701 VA: 0x2166600
	public static SortieTradeItemMenu Create(ProcInst super, Unit unit, Unit recieverUnit, int defaultSelect, SortieTradeItemMenuContent menuContent) { }

	// RVA: 0x21724C0 Offset: 0x21725C1 VA: 0x21724C0
	public static List<BasicMenuItem> CreateMenuItemList(Unit unit, Unit recieverUnit, int defaultSelect) { }

	// RVA: 0x2172710 Offset: 0x2172811 VA: 0x2172710
	protected void .ctor(List<BasicMenuItem> menuItemList, SortieTradeItemMenuContent menuContent) { }

	// RVA: 0x2168D60 Offset: 0x2168E61 VA: 0x2168D60
	public void RebuildMenu() { }

	// RVA: 0x21728D0 Offset: 0x21729D1 VA: 0x21728D0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2172920 Offset: 0x2172A21 VA: 0x2172920 Slot: 40
	protected override void KeyUp(bool isTrigger) { }

	// RVA: 0x2172950 Offset: 0x2172A51 VA: 0x2172950 Slot: 41
	protected override void KeyDown(bool isTrigger) { }

	// RVA: 0x2172980 Offset: 0x2172A81 VA: 0x2172980 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x2172AB0 Offset: 0x2172BB1 VA: 0x2172AB0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2172BE0 Offset: 0x2172CE1 VA: 0x2172BE0
	public Unit GetUnit() { }

	// RVA: 0x2172BF0 Offset: 0x2172CF1 VA: 0x2172BF0
	public void SetUnit(Unit unit) { }

	// RVA: 0x2172C00 Offset: 0x2172D01 VA: 0x2172C00
	public void SetRecieverUnit(Unit unit) { }

	// RVA: 0x2166970 Offset: 0x2166A71 VA: 0x2166970
	public UnitItem GetSelectItem() { }

	// RVA: 0x2169410 Offset: 0x2169511 VA: 0x2169410
	public void ClearSelect() { }

	// RVA: 0x2172DE0 Offset: 0x2172EE1 VA: 0x2172DE0
	public void SetSelect(int selectNo) { }

	// RVA: 0x21689C0 Offset: 0x2168AC1 VA: 0x21689C0
	public void SetFirstSelectAtSelectIndex() { }

	// RVA: 0x2172FC0 Offset: 0x21730C1 VA: 0x2172FC0
	public int GetFirstSelect() { }

	// RVA: 0x2172FD0 Offset: 0x21730D1 VA: 0x2172FD0
	public int GetSecondSelect() { }

	// RVA: 0x2172FE0 Offset: 0x21730E1 VA: 0x2172FE0
	public bool IsFirstSelect(SortieTradeItemMenuItem menuItem) { }

	// RVA: 0x21694F0 Offset: 0x21695F1 VA: 0x21694F0
	public SortieTradeItemMenuItem GetFirstSelectMenuItem() { }

	// RVA: 0x21688A0 Offset: 0x21689A1 VA: 0x21688A0
	public void ShowCursor(bool isShow) { }

	// RVA: 0x2168920 Offset: 0x2168A21 VA: 0x2168920
	public void SetInitialSelect() { }

	// RVA: 0x2168840 Offset: 0x2168941 VA: 0x2168840
	public void MoveFrontCursorFrom(BasicMenu anotherMenu) { }

	// RVA: 0x2168CC0 Offset: 0x2168DC1 VA: 0x2168CC0
	public void SetSelectIndexAtFirstSelect() { }

	// RVA: 0x21675B0 Offset: 0x21676B1 VA: 0x21675B0
	public void SetSelectIndexEx(int commonIndex) { }

	// RVA: 0x21671B0 Offset: 0x21672B1 VA: 0x21671B0
	public void SetSelectIndexForSecondSelect(int anotherIndex) { }

	// RVA: 0x21670A0 Offset: 0x21671A1 VA: 0x21670A0
	public void EnableToSelectBlank(bool enabled) { }

	// RVA: 0x21697A0 Offset: 0x21698A1 VA: 0x21697A0
	public void SetSelectableBlankToDisable(bool disabled) { }

	// RVA: 0x2169650 Offset: 0x2169751 VA: 0x2169650
	public bool IsEmpty() { }
}

