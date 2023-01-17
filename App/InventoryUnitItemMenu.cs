// Namespace: App
public class InventoryUnitItemMenu : BasicMenu // TypeDefIndex: 13222
{
	// Fields
	private static Unit m_unit; // 0x0
	private int m_firstSelect; // 0xC4
	private int m_secondSelect; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x29BCB0 Offset: 0x29BDB1 VA: 0x29BCB0
	private int <m_CommonDisplayIndex>k__BackingField; // 0xCC

	// Properties
	public int m_CommonDisplayIndex { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB620 Offset: 0x2CB721 VA: 0x2CB620
	// RVA: 0x2B56E80 Offset: 0x2B56F81 VA: 0x2B56E80
	public int get_m_CommonDisplayIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB630 Offset: 0x2CB731 VA: 0x2CB630
	// RVA: 0x2B56E90 Offset: 0x2B56F91 VA: 0x2B56E90
	private void set_m_CommonDisplayIndex(int value) { }

	// RVA: 0x2B56EA0 Offset: 0x2B56FA1 VA: 0x2B56EA0
	public static InventoryUnitItemMenu Create(ProcInst super, Unit unit, int defaultSelect, InventoryUnitItemMenuContent menuContent) { }

	// RVA: 0x2B56FC0 Offset: 0x2B570C1 VA: 0x2B56FC0
	public static List<BasicMenuItem> CreateMenuItemList(Unit unit) { }

	// RVA: 0x2B571C0 Offset: 0x2B572C1 VA: 0x2B571C0
	protected void .ctor(List<BasicMenuItem> menuItemList, InventoryUnitItemMenuContent menuContent) { }

	// RVA: 0x2B57260 Offset: 0x2B57361 VA: 0x2B57260
	public Unit GetUnit() { }

	// RVA: 0x2B559C0 Offset: 0x2B55AC1 VA: 0x2B559C0
	public void UpdateUnit(Unit unit) { }

	// RVA: 0x2B573D0 Offset: 0x2B574D1 VA: 0x2B573D0
	public UnitItem GetSelectItem() { }

	// RVA: 0x2B574D0 Offset: 0x2B575D1 VA: 0x2B574D0
	public int GetMenuItemIndexEquipped() { }

	// RVA: 0x2B57200 Offset: 0x2B57301 VA: 0x2B57200
	public void ClearSelect() { }

	// RVA: 0x2B57650 Offset: 0x2B57751 VA: 0x2B57650
	public void SetSelect(int selectNo) { }

	// RVA: 0x2B57670 Offset: 0x2B57771 VA: 0x2B57670
	public int GetFirstSelect() { }

	// RVA: 0x2B57680 Offset: 0x2B57781 VA: 0x2B57680
	public int GetSecondSelect() { }

	// RVA: 0x2B52DB0 Offset: 0x2B52EB1 VA: 0x2B52DB0
	public void ShowCursor(bool isShow) { }

	// RVA: 0x2B57690 Offset: 0x2B57791 VA: 0x2B57690
	public bool IsShowCursor() { }

	// RVA: 0x2B52E40 Offset: 0x2B52F41 VA: 0x2B52E40
	public void EnableInput(bool isEnable) { }

	// RVA: 0x2B576B0 Offset: 0x2B577B1 VA: 0x2B576B0
	public bool IsEnableInput() { }

	// RVA: 0x2B562A0 Offset: 0x2B563A1 VA: 0x2B562A0
	public void SetSuspend(bool isActive) { }

	// RVA: 0x2B55B30 Offset: 0x2B55C31 VA: 0x2B55B30
	public void SetFirstSelection(bool updateCommonDisplayIndex = False) { }

	// RVA: 0x2B57760 Offset: 0x2B57861 VA: 0x2B57760
	public void ResetFirstSelection() { }

	// RVA: 0x2B52C70 Offset: 0x2B52D71 VA: 0x2B52C70
	public void SetSelectIndexOnChangeMenu(int commonDisplayIndex) { }

	// RVA: 0x2B57900 Offset: 0x2B57A01 VA: 0x2B57900
	public void HoldSelection() { }

	// RVA: 0x2B55DC0 Offset: 0x2B55EC1 VA: 0x2B55DC0
	public void UpdateMenu(bool isRebuild = True) { }

	// RVA: 0x2B576D0 Offset: 0x2B577D1 VA: 0x2B576D0
	protected int GetSelectableItemCount() { }

	// RVA: 0x2B57A40 Offset: 0x2B57B41 VA: 0x2B57A40 Slot: 30
	public override string GetName() { }

	// RVA: 0x2B57A90 Offset: 0x2B57B91 VA: 0x2B57A90 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x2B57B90 Offset: 0x2B57C91 VA: 0x2B57B90 Slot: 31
	public override int ClampMenuItemIndex(int itemIndex) { }

	// RVA: 0x2B57C70 Offset: 0x2B57D71 VA: 0x2B57C70 Slot: 40
	protected override void KeyUp(bool isTrigger) { }

	// RVA: 0x2B57CB0 Offset: 0x2B57DB1 VA: 0x2B57CB0 Slot: 41
	protected override void KeyDown(bool isTrigger) { }

	// RVA: 0x2B57CF0 Offset: 0x2B57DF1 VA: 0x2B57CF0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x2B57FC0 Offset: 0x2B580C1 VA: 0x2B57FC0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2B58290 Offset: 0x2B58391 VA: 0x2B58290 Slot: 52
	protected override BasicMenu.Result XCall() { }

	// RVA: 0x2B583A0 Offset: 0x2B584A1 VA: 0x2B583A0 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x2B58890 Offset: 0x2B58991 VA: 0x2B58890
	private static void .cctor() { }
}

