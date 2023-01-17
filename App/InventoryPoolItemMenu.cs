// Namespace: App
public class InventoryPoolItemMenu : BasicMenu // TypeDefIndex: 13197
{
	// Fields
	private static int ShowRowNum; // 0x0
	private List<BasicMenuItem> m_SavedFullMenuItemList; // 0xC8
	private List<BasicMenuItem> m_SortMenuItemList; // 0xD0
	private ItemData.Kinds m_ItemKind; // 0xD8
	private BasicMenuSelect[] m_Selects; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x29BC20 Offset: 0x29BD21 VA: 0x29BC20
	private int <m_CommonDisplayIndex>k__BackingField; // 0xE8

	// Properties
	public int m_CommonDisplayIndex { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB600 Offset: 0x2CB701 VA: 0x2CB600
	// RVA: 0x2B4FA60 Offset: 0x2B4FB61 VA: 0x2B4FA60
	public int get_m_CommonDisplayIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB610 Offset: 0x2CB711 VA: 0x2CB610
	// RVA: 0x2B4FA70 Offset: 0x2B4FB71 VA: 0x2B4FA70
	private void set_m_CommonDisplayIndex(int value) { }

	// RVA: 0x2B4FA80 Offset: 0x2B4FB81 VA: 0x2B4FA80
	public static InventoryPoolItemMenu Create(ProcInst super, InventoryPoolItemMenuContent menuContent) { }

	// RVA: 0x2B50040 Offset: 0x2B50141 VA: 0x2B50040
	protected void .ctor(List<BasicMenuItem> menuItemList, InventoryPoolItemMenuContent menuContent) { }

	// RVA: 0x2B50680 Offset: 0x2B50781 VA: 0x2B50680
	public UnitItem GetSelectItem() { }

	// RVA: 0x2B50720 Offset: 0x2B50821 VA: 0x2B50720
	public void SaveSelectItem() { }

	// RVA: 0x2B50760 Offset: 0x2B50861 VA: 0x2B50760
	public Unit GetSelectUnit() { }

	// RVA: 0x2B50800 Offset: 0x2B50901 VA: 0x2B50800
	public void UpdateUnit(Unit unit) { }

	// RVA: 0x2B50880 Offset: 0x2B50981 VA: 0x2B50880
	public void UpdateUnit(Unit unit, bool isCharaOnlyOn) { }

	// RVA: 0x2B50910 Offset: 0x2B50A11 VA: 0x2B50910
	private void SetItemKind(ItemData.Kinds itemKind, bool isAutoSelect = True) { }

	// RVA: 0x2B50C70 Offset: 0x2B50D71 VA: 0x2B50C70
	public void SetFirstKind(bool isAutoSelect = True) { }

	// RVA: 0x2B50DE0 Offset: 0x2B50EE1 VA: 0x2B50DE0
	public void SetLastKind(bool isAutoSelect = True) { }

	// RVA: 0x2B50FD0 Offset: 0x2B510D1 VA: 0x2B50FD0
	private bool IncKind() { }

	// RVA: 0x2B51310 Offset: 0x2B51411 VA: 0x2B51310
	private bool DecKind() { }

	// RVA: 0x2B51610 Offset: 0x2B51711 VA: 0x2B51610
	public void ShowCursor(bool isShow) { }

	// RVA: 0x2B516A0 Offset: 0x2B517A1 VA: 0x2B516A0
	public bool IsShowCursor() { }

	// RVA: 0x2B516C0 Offset: 0x2B517C1 VA: 0x2B516C0
	public void EnableInput(bool isEnable) { }

	// RVA: 0x2B51720 Offset: 0x2B51821 VA: 0x2B51720
	public bool IsEnableInput() { }

	// RVA: 0x2B51740 Offset: 0x2B51841 VA: 0x2B51740
	public void SetSuspend(bool isActive) { }

	// RVA: 0x2B517A0 Offset: 0x2B518A1 VA: 0x2B517A0
	public void SetFirstSelection() { }

	// RVA: 0x2B51BF0 Offset: 0x2B51CF1 VA: 0x2B51BF0
	public void ResetFirstSelection() { }

	// RVA: 0x2B51EE0 Offset: 0x2B51FE1 VA: 0x2B51EE0
	public void SetSelectIndexOnChangeMenu(int commonDisplayIndex, InventoryPoolItemMenu.Kinds kind) { }

	// RVA: 0x2B52270 Offset: 0x2B52371 VA: 0x2B52270
	public void HoldSelection() { }

	// RVA: 0x2B50980 Offset: 0x2B50A81 VA: 0x2B50980
	public void UpdateMenu(bool isAutoSelect = True) { }

	// RVA: 0x2B51B60 Offset: 0x2B51C61 VA: 0x2B51B60
	protected int GetSelectableItemCount() { }

	// RVA: 0x2B52720 Offset: 0x2B52821 VA: 0x2B52720 Slot: 30
	public override string GetName() { }

	// RVA: 0x2B52770 Offset: 0x2B52871 VA: 0x2B52770 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x2B52810 Offset: 0x2B52911 VA: 0x2B52810 Slot: 31
	public override int ClampMenuItemIndex(int itemIndex) { }

	// RVA: 0x2B528E0 Offset: 0x2B529E1 VA: 0x2B528E0 Slot: 40
	protected override void KeyUp(bool isTrigger) { }

	// RVA: 0x2B52920 Offset: 0x2B52A21 VA: 0x2B52920 Slot: 41
	protected override void KeyDown(bool isTrigger) { }

	// RVA: 0x2B52960 Offset: 0x2B52A61 VA: 0x2B52960 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x2B52EA0 Offset: 0x2B52FA1 VA: 0x2B52EA0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2B531B0 Offset: 0x2B532B1 VA: 0x2B531B0 Slot: 52
	protected override BasicMenu.Result XCall() { }

	// RVA: 0x2B53330 Offset: 0x2B53431 VA: 0x2B53330 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x2B50180 Offset: 0x2B50281 VA: 0x2B50180
	public void Sort() { }

	// RVA: 0x2B53860 Offset: 0x2B53961 VA: 0x2B53860
	private static int ComparePoolMenuItem(BasicMenuItem x, BasicMenuItem y) { }

	// RVA: 0x2B539A0 Offset: 0x2B53AA1 VA: 0x2B539A0
	private static void .cctor() { }
}

