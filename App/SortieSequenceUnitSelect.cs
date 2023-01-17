// Namespace: App
public class SortieSequenceUnitSelect : SingletonProcInst<SortieSequenceUnitSelect> // TypeDefIndex: 13371
{
	// Fields
	private const string ResNameC = "UI/Sortie/UnitSelect/Prefabs/UnitSelectRoot";
	private const string SortieResNameC = "UI/Sortie/UnitSelect/Prefabs/SortieUnitSelectRoot";
	private GameObject m_GameObject; // 0x78
	private UnitSelectRoot m_Window; // 0x80
	private BasicMenu m_unitSelectMenu; // 0x88
	private Animator m_rootAnimator; // 0x90
	private BasicMenuSelect m_menuSelect; // 0x98

	// Methods

	// RVA: 0x216AE80 Offset: 0x216AF81 VA: 0x216AE80
	public static void CreateBindSortie(ProcInst super) { }

	// RVA: 0x216CAE0 Offset: 0x216CBE1 VA: 0x216CAE0
	public static void CreateBindInventory(ProcInst super) { }

	// RVA: 0x216CAF0 Offset: 0x216CBF1 VA: 0x216CAF0
	public static void CreateBindRingSelect(ProcInst super) { }

	// RVA: 0x216AE90 Offset: 0x216AF91 VA: 0x216AE90
	private static void CreateBindCommon(ProcInst super, SortieSelectionUnitManager.Modes mode) { }

	// RVA: 0x216CB00 Offset: 0x216CC01 VA: 0x216CB00
	public void .ctor(SortieSelectionUnitManager.Modes mode) { }

	// RVA: 0x216CC00 Offset: 0x216CD01 VA: 0x216CC00
	private void Tutorial() { }

	// RVA: 0x216CD70 Offset: 0x216CE71 VA: 0x216CD70
	private void CheckSkillOpenTutorial() { }

	// RVA: 0x216CE20 Offset: 0x216CF21 VA: 0x216CE20
	private string GetLoadResName() { }

	// RVA: 0x216CEE0 Offset: 0x216CFE1 VA: 0x216CEE0
	private void LoadRes() { }

	// RVA: 0x216CF70 Offset: 0x216D071 VA: 0x216CF70
	private bool IsLoadingRes() { }

	// RVA: 0x216CFE0 Offset: 0x216D0E1 VA: 0x216CFE0
	private void Open() { }

	// RVA: 0x216D2C0 Offset: 0x216D3C1 VA: 0x216D2C0
	private void AfterOpen() { }

	// RVA: 0x216D9A0 Offset: 0x216DAA1 VA: 0x216D9A0
	private void ResetSelect() { }

	// RVA: 0x216DB40 Offset: 0x216DC41 VA: 0x216DB40
	private void MenuTick() { }

	// RVA: 0x216DB50 Offset: 0x216DC51 VA: 0x216DB50
	public void CloseAll() { }

	// RVA: 0x216DBC0 Offset: 0x216DCC1 VA: 0x216DBC0
	public bool IsClosed() { }

	// RVA: 0x216DC70 Offset: 0x216DD71 VA: 0x216DC70
	public void PostClosed() { }

	// RVA: 0x216DC80 Offset: 0x216DD81 VA: 0x216DC80
	public void DispAll() { }

	// RVA: 0x216DDA0 Offset: 0x216DEA1 VA: 0x216DDA0
	public void HideHeaderKeyHelp() { }

	// RVA: 0x216DE70 Offset: 0x216DF71 VA: 0x216DE70
	private void Release() { }

	// RVA: 0x216D490 Offset: 0x216D591 VA: 0x216D490
	private void SettingTitle() { }

	// RVA: 0x216DFD0 Offset: 0x216E0D1 VA: 0x216DFD0
	private void CloseTitle() { }
}

