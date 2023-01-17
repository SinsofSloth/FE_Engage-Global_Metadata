// Namespace: App
public class SortieSelectionUnitManager : SingletonClass<SortieSelectionUnitManager> // TypeDefIndex: 13179
{
	// Fields
	private SortieSelectionUnitManager.Modes m_Mode; // 0x1C
	private SortieSelectionUnitManager.InventoryModes m_InventoryMode; // 0x20
	private Unit m_Unit; // 0x28
	private BasicMenuSelect m_MenuSelect; // 0x30
	private bool m_statusUpdate; // 0x38
	private SortieSelectionUnitManager.UnitSelectSubMenu m_openItemSubMenu; // 0x3C
	private GameObject m_menuBg; // 0x40

	// Properties
	public SortieSelectionUnitManager.Modes Mode { get; set; }
	public SortieSelectionUnitManager.InventoryModes InventoryMode { get; set; }
	public Unit Unit { get; set; }
	public BasicMenuSelect MenuSelect { get; }
	public bool StatusForceUpdate { get; set; }
	public SortieSelectionUnitManager.UnitSelectSubMenu OpenSubMenu { get; set; }
	public GameObject MenuBg { get; set; }

	// Methods

	// RVA: 0x2159C80 Offset: 0x2159D81 VA: 0x2159C80
	public void .ctor() { }

	// RVA: 0x2159D70 Offset: 0x2159E71 VA: 0x2159D70
	public void Reset() { }

	// RVA: 0x2159DB0 Offset: 0x2159EB1 VA: 0x2159DB0
	public bool IsModeSortie() { }

	// RVA: 0x2159DC0 Offset: 0x2159EC1 VA: 0x2159DC0
	public bool IsModeInventory() { }

	// RVA: 0x2159DD0 Offset: 0x2159ED1 VA: 0x2159DD0
	public bool IsModeRingSelect() { }

	// RVA: 0x2159DE0 Offset: 0x2159EE1 VA: 0x2159DE0
	public bool IsInventoryModeNone() { }

	// RVA: 0x2159DF0 Offset: 0x2159EF1 VA: 0x2159DF0
	public bool IsInventoryModeInventory() { }

	// RVA: 0x2159E00 Offset: 0x2159F01 VA: 0x2159E00
	public bool IsInventoryModeTrade() { }

	// RVA: 0x2159E10 Offset: 0x2159F11 VA: 0x2159E10
	public void ResetInventoryMode() { }

	// RVA: 0x2159E20 Offset: 0x2159F21 VA: 0x2159E20
	public void BgOn() { }

	// RVA: 0x2159EA0 Offset: 0x2159FA1 VA: 0x2159EA0
	public void BgOff() { }

	// RVA: 0x2159F20 Offset: 0x215A021 VA: 0x2159F20
	public SortieSelectionUnitManager.Modes get_Mode() { }

	// RVA: 0x2159F30 Offset: 0x215A031 VA: 0x2159F30
	public void set_Mode(SortieSelectionUnitManager.Modes value) { }

	// RVA: 0x2159F40 Offset: 0x215A041 VA: 0x2159F40
	public SortieSelectionUnitManager.InventoryModes get_InventoryMode() { }

	// RVA: 0x2159F50 Offset: 0x215A051 VA: 0x2159F50
	public void set_InventoryMode(SortieSelectionUnitManager.InventoryModes value) { }

	// RVA: 0x2159F60 Offset: 0x215A061 VA: 0x2159F60
	public Unit get_Unit() { }

	// RVA: 0x2159F70 Offset: 0x215A071 VA: 0x2159F70
	public void set_Unit(Unit value) { }

	// RVA: 0x2159F80 Offset: 0x215A081 VA: 0x2159F80
	public BasicMenuSelect get_MenuSelect() { }

	// RVA: 0x2159F90 Offset: 0x215A091 VA: 0x2159F90
	public bool get_StatusForceUpdate() { }

	// RVA: 0x2159FA0 Offset: 0x215A0A1 VA: 0x2159FA0
	public void set_StatusForceUpdate(bool value) { }

	// RVA: 0x2159FB0 Offset: 0x215A0B1 VA: 0x2159FB0
	public SortieSelectionUnitManager.UnitSelectSubMenu get_OpenSubMenu() { }

	// RVA: 0x2159FC0 Offset: 0x215A0C1 VA: 0x2159FC0
	public void set_OpenSubMenu(SortieSelectionUnitManager.UnitSelectSubMenu value) { }

	// RVA: 0x2159FD0 Offset: 0x215A0D1 VA: 0x2159FD0
	public GameObject get_MenuBg() { }

	// RVA: 0x2159FE0 Offset: 0x215A0E1 VA: 0x2159FE0
	public void set_MenuBg(GameObject value) { }
}

