// Namespace: App
public class SortieSequenceInventory : SingletonProcInst<SortieSequenceInventory> // TypeDefIndex: 13355
{
	// Fields
	private const string ResNameC = "UI/Sortie/Item/Prefabs/ItemTransporterRoot";
	private GameObject m_GameObject; // 0x78
	private InventoryRoot m_Window; // 0x80
	private bool m_VisibilytyOfUnitInfo; // 0x88
	private GameObject m_CharaImage; // 0x90
	private GameObject m_CharaImageRight; // 0x98

	// Methods

	// RVA: 0x215E4D0 Offset: 0x215E5D1 VA: 0x215E4D0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x215F320 Offset: 0x215F421 VA: 0x215F320
	public static void CreateBindTransporter(ProcInst super) { }

	// RVA: 0x215E530 Offset: 0x215E631 VA: 0x215E530
	private static void CreateBindCommon(ProcInst super, SortieInventoryManager.Modes mode, string name) { }

	// RVA: 0x215F380 Offset: 0x215F481 VA: 0x215F380
	private void .ctor(SortieInventoryManager.Modes mode) { }

	// RVA: 0x215F480 Offset: 0x215F581 VA: 0x215F480
	private void LoadRes() { }

	// RVA: 0x215F520 Offset: 0x215F621 VA: 0x215F520
	private bool IsLoadingRes() { }

	// RVA: 0x215F5A0 Offset: 0x215F6A1 VA: 0x215F5A0
	private void Open() { }

	// RVA: 0x215FCB0 Offset: 0x215FDB1 VA: 0x215FCB0
	private void OpenTitleBar() { }

	// RVA: 0x215FF30 Offset: 0x2160031 VA: 0x215FF30
	private bool HasDoneAfterBuild() { }

	// RVA: 0x2160000 Offset: 0x2160101 VA: 0x2160000
	private void StartMenu() { }

	// RVA: 0x2160210 Offset: 0x2160311 VA: 0x2160210
	private BasicMenu GetCurrentMenu() { }

	// RVA: 0x21602A0 Offset: 0x21603A1 VA: 0x21602A0
	private void Tutorial() { }

	// RVA: 0x2160390 Offset: 0x2160491 VA: 0x2160390
	private void MenuTick() { }

	// RVA: 0x21603A0 Offset: 0x21604A1 VA: 0x21603A0
	private void MainMenuOnlyActivateUnitMenu() { }

	// RVA: 0x2160480 Offset: 0x2160581 VA: 0x2160480
	private void MainMenuOnlyActivatePoolMenu() { }

	// RVA: 0x2160560 Offset: 0x2160661 VA: 0x2160560
	private void CreateSubMenu() { }

	// RVA: 0x21606C0 Offset: 0x21607C1 VA: 0x21606C0
	private void MenuOpenOtherThanCharaImage() { }

	// RVA: 0x21606D0 Offset: 0x21607D1 VA: 0x21606D0
	private void MenuCloseOtherThanCharaImage() { }

	// RVA: 0x21606E0 Offset: 0x21607E1 VA: 0x21606E0
	private bool IsMenuCloseOtherThanCharaImage() { }

	// RVA: 0x21606F0 Offset: 0x21607F1 VA: 0x21606F0
	private void ToTrade() { }

	// RVA: 0x2160750 Offset: 0x2160851 VA: 0x2160750
	private void EndTrade() { }

	// RVA: 0x2160840 Offset: 0x2160941 VA: 0x2160840
	private void MenuClose() { }

	// RVA: 0x2160900 Offset: 0x2160A01 VA: 0x2160900
	public bool IsClosed() { }

	// RVA: 0x21609C0 Offset: 0x2160AC1 VA: 0x21609C0
	private void MenuCloseEnd() { }

	// RVA: 0x2160CC0 Offset: 0x2160DC1 VA: 0x2160CC0
	private void SetMenuActive(BasicMenu menu, bool bActive) { }
}

