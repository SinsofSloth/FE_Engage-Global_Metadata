// Namespace: App
public class SortieInventoryManager : SingletonClass<SortieInventoryManager> // TypeDefIndex: 13174
{
	// Fields
	private SortieInventoryManager.Modes m_Mode; // 0x1C
	private SortieInventoryManager.SelectionInfo m_Selection; // 0x20
	private int m_MenuItemDisplayIndex; // 0x28
	private InventoryUnitItemMenu m_UnitItemMenu; // 0x30
	private InventoryPoolItemMenu m_PoolItemMenu; // 0x38
	private SortieInventoryManager.ActiveWindow m_ActiveWindow; // 0x40
	private GameObject m_ItemInfo; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x29BAE0 Offset: 0x29BBE1 VA: 0x29BAE0
	private bool <ItemDetailDisplayWithUnit>k__BackingField; // 0x50

	// Properties
	public SortieInventoryManager.Modes Mode { get; set; }
	public SortieInventoryManager.SelectionInfo Selection { get; }
	public InventoryUnitItemMenu UnitItemMenu { get; set; }
	public InventoryPoolItemMenu PoolItemMenu { get; set; }
	public SortieInventoryManager.ActiveWindow Active { get; set; }
	public GameObject ItemInfo { get; set; }
	public int MenuItemDisplayIndex { get; set; }
	public bool ItemDetailDisplayWithUnit { get; set; }

	// Methods

	// RVA: 0x2158E10 Offset: 0x2158F11 VA: 0x2158E10
	public void .ctor() { }

	// RVA: 0x2158F20 Offset: 0x2159021 VA: 0x2158F20
	public void Reset() { }

	// RVA: 0x2158F60 Offset: 0x2159061 VA: 0x2158F60
	public bool IsModeSortie() { }

	// RVA: 0x2158F70 Offset: 0x2159071 VA: 0x2158F70
	public bool IsModeTransporter() { }

	// RVA: 0x2158F50 Offset: 0x2159051 VA: 0x2158F50
	public void ResetMode() { }

	// RVA: 0x2158F80 Offset: 0x2159081 VA: 0x2158F80
	public void UpdateUnitMenu(bool isRebuild = True) { }

	// RVA: 0x2158FA0 Offset: 0x21590A1 VA: 0x2158FA0
	public void UpdatePoolMenu(bool isAutoSelect = True) { }

	// RVA: 0x2158FC0 Offset: 0x21590C1 VA: 0x2158FC0
	public void SetMenuItemDisplayIndex(BasicMenu menu) { }

	// RVA: 0x2158FE0 Offset: 0x21590E1 VA: 0x2158FE0
	public int GetMenuItemDisplayIndexFromUnitItemListIndex(Unit unit, int unitItemListIndex) { }

	// RVA: 0x2159110 Offset: 0x2159211 VA: 0x2159110
	public void SetItemInfo(Unit unit, UnitItem item) { }

	// RVA: 0x2159240 Offset: 0x2159341 VA: 0x2159240
	public SortieInventoryManager.Modes get_Mode() { }

	// RVA: 0x2159250 Offset: 0x2159351 VA: 0x2159250
	public void set_Mode(SortieInventoryManager.Modes value) { }

	// RVA: 0x2159260 Offset: 0x2159361 VA: 0x2159260
	public SortieInventoryManager.SelectionInfo get_Selection() { }

	// RVA: 0x2159270 Offset: 0x2159371 VA: 0x2159270
	public InventoryUnitItemMenu get_UnitItemMenu() { }

	// RVA: 0x2159280 Offset: 0x2159381 VA: 0x2159280
	public void set_UnitItemMenu(InventoryUnitItemMenu value) { }

	// RVA: 0x2159290 Offset: 0x2159391 VA: 0x2159290
	public InventoryPoolItemMenu get_PoolItemMenu() { }

	// RVA: 0x21592A0 Offset: 0x21593A1 VA: 0x21592A0
	public void set_PoolItemMenu(InventoryPoolItemMenu value) { }

	// RVA: 0x21592B0 Offset: 0x21593B1 VA: 0x21592B0
	public SortieInventoryManager.ActiveWindow get_Active() { }

	// RVA: 0x21592C0 Offset: 0x21593C1 VA: 0x21592C0
	public void set_Active(SortieInventoryManager.ActiveWindow value) { }

	// RVA: 0x21592D0 Offset: 0x21593D1 VA: 0x21592D0
	public GameObject get_ItemInfo() { }

	// RVA: 0x21592E0 Offset: 0x21593E1 VA: 0x21592E0
	public void set_ItemInfo(GameObject value) { }

	// RVA: 0x21592F0 Offset: 0x21593F1 VA: 0x21592F0
	public int get_MenuItemDisplayIndex() { }

	// RVA: 0x2159300 Offset: 0x2159401 VA: 0x2159300
	public void set_MenuItemDisplayIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB500 Offset: 0x2CB601 VA: 0x2CB500
	// RVA: 0x2159310 Offset: 0x2159411 VA: 0x2159310
	public bool get_ItemDetailDisplayWithUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB510 Offset: 0x2CB611 VA: 0x2CB510
	// RVA: 0x2159320 Offset: 0x2159421 VA: 0x2159320
	public void set_ItemDetailDisplayWithUnit(bool value) { }
}

