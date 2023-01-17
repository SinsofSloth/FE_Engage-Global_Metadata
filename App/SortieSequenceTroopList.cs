// Namespace: App
public class SortieSequenceTroopList : SingletonProcInst<SortieSequenceTroopList> // TypeDefIndex: 13369
{
	// Fields
	private const string ResNameC = "UI/Sortie/TroopList/Prefabs/TroopListRoot";
	private GameObject m_GameObject; // 0x78
	private static SortieSequenceTroopList.Mode m_mode; // 0x0
	private TroopListRoot m_Window; // 0x80
	private TroopListMenu m_troopListMenu; // 0x88
	private TroopListSortMenu m_sortMenu; // 0x90

	// Methods

	// RVA: 0x2169980 Offset: 0x2169A81 VA: 0x2169980
	public static void CreateBindSortie(ProcInst super) { }

	// RVA: 0x216A0F0 Offset: 0x216A1F1 VA: 0x216A0F0
	public static void CreateBindMap(ProcInst super) { }

	// RVA: 0x2169990 Offset: 0x2169A91 VA: 0x2169990
	private static void CreateBindCommon(ProcInst super, SortieSequenceTroopList.Mode mode) { }

	// RVA: 0x216A180 Offset: 0x216A281 VA: 0x216A180
	private void LoadRes() { }

	// RVA: 0x216A220 Offset: 0x216A321 VA: 0x216A220
	private bool IsLoadingRes() { }

	// RVA: 0x216A2A0 Offset: 0x216A3A1 VA: 0x216A2A0
	private void Open() { }

	// RVA: 0x216ABB0 Offset: 0x216ACB1 VA: 0x216ABB0
	private void ReturnMain() { }

	// RVA: 0x216ABC0 Offset: 0x216ACC1 VA: 0x216ABC0
	private void MenuTick() { }

	// RVA: 0x216ABD0 Offset: 0x216ACD1 VA: 0x216ABD0
	private void TitleBarClose() { }

	// RVA: 0x216AD90 Offset: 0x216AE91 VA: 0x216AD90
	public bool IsMenuClosed() { }

	// RVA: 0x216ADB0 Offset: 0x216AEB1 VA: 0x216ADB0
	private void MenuClose() { }

	// RVA: 0x216A100 Offset: 0x216A201 VA: 0x216A100
	public void .ctor() { }
}

