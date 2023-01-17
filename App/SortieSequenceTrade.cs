// Namespace: App
public class SortieSequenceTrade : SingletonProcInst<SortieSequenceTrade> // TypeDefIndex: 13366
{
	// Fields
	private const string ResNameC = "UI/Sortie/Item/Prefabs/ItemTradeRoot";
	private GameObject m_GameObject; // 0x78
	private SortieTradeItemMenu m_menuL; // 0x80
	private SortieTradeItemMenu m_menuR; // 0x88
	private bool m_bSelectLeft; // 0x90
	private TradeRoot m_Window; // 0x98
	private static bool m_bSortieTrade; // 0x0
	private static bool m_bInvalidCharaImage; // 0x1
	private static Unit m_TradeFromUnit; // 0x8
	private static Unit m_TradeToUnit; // 0x10
	private static int m_DefaultSelectFrom; // 0x18
	private static int m_DefaultSelectTo; // 0x1C
	private static SortieTradeManager.SideId m_InitialSelectSide; // 0x20
	private static bool m_IsFirstSelectedOnInit; // 0x24
	private GameObject m_CharaImage; // 0xA0
	private GameObject m_CharaImageRight; // 0xA8

	// Methods

	// RVA: 0x2164AA0 Offset: 0x2164BA1 VA: 0x2164AA0
	public static void CreateBindSortie(ProcInst super) { }

	// RVA: 0x2165A60 Offset: 0x2165B61 VA: 0x2165A60
	public static void CreateBindSortieHideCharaImage(ProcInst super) { }

	// RVA: 0x2165BA0 Offset: 0x2165CA1 VA: 0x2165BA0
	public static void CreateBindMap(ProcInst super, Unit from, Unit to, int defaultSelect) { }

	// RVA: 0x2164BE0 Offset: 0x2164CE1 VA: 0x2164BE0
	private static void CreateBindCommon(ProcInst super, Unit from, Unit to, int selectFrom, int selectTo, SortieTradeManager.SideId selectSide, bool isFirstSelected) { }

	// RVA: 0x2165D00 Offset: 0x2165E01 VA: 0x2165D00
	private void LoadRes() { }

	// RVA: 0x2165DA0 Offset: 0x2165EA1 VA: 0x2165DA0
	private bool IsLoadingRes() { }

	// RVA: 0x2165E20 Offset: 0x2165F21 VA: 0x2165E20
	private void Open() { }

	// RVA: 0x2166820 Offset: 0x2166921 VA: 0x2166820
	private bool HasDoneAfterBuild() { }

	// RVA: 0x2166890 Offset: 0x2166991 VA: 0x2166890
	private void MenuTick() { }

	// RVA: 0x2166A20 Offset: 0x2166B21 VA: 0x2166A20
	private void SetActiveOnInitialize() { }

	// RVA: 0x2166D70 Offset: 0x2166E71 VA: 0x2166D70
	private void SetActiveLeft() { }

	// RVA: 0x2166E00 Offset: 0x2166F01 VA: 0x2166E00
	private void SetActiveRight() { }

	// RVA: 0x2166E80 Offset: 0x2166F81 VA: 0x2166E80
	private void SetActiveLeftForSecondSelect() { }

	// RVA: 0x21673E0 Offset: 0x21674E1 VA: 0x21673E0
	private void SetActiveRightForSecondSelect() { }

	// RVA: 0x2167490 Offset: 0x2167591 VA: 0x2167490
	private void ChangeActiveByKey() { }

	// RVA: 0x2167770 Offset: 0x2167871 VA: 0x2167770
	private void ChangeActive() { }

	// RVA: 0x2167870 Offset: 0x2167971 VA: 0x2167870
	private void ItemSelect() { }

	// RVA: 0x2166B50 Offset: 0x2166C51 VA: 0x2166B50
	private void SetMenuActive(SortieTradeItemMenu menu, bool bActive, bool bOnInitialize = False, bool bFirstSelect = False) { }

	// RVA: 0x2168A50 Offset: 0x2168B51 VA: 0x2168A50
	private void Cancel() { }

	// RVA: 0x2168CE0 Offset: 0x2168DE1 VA: 0x2168CE0
	private void MenuRebuild() { }

	// RVA: 0x2168EF0 Offset: 0x2168FF1 VA: 0x2168EF0
	private void End() { }

	// RVA: 0x21690D0 Offset: 0x21691D1 VA: 0x21690D0
	private void MenuClose() { }

	// RVA: 0x2169120 Offset: 0x2169221 VA: 0x2169120
	public bool IsClosed() { }

	// RVA: 0x2169170 Offset: 0x2169271 VA: 0x2169170
	private void MenuCloseEnd() { }

	// RVA: 0x21680C0 Offset: 0x21681C1 VA: 0x21680C0
	private void ItemTrade() { }

	// RVA: 0x2167A90 Offset: 0x2167B91 VA: 0x2167A90
	private void ItemSwap(SortieTradeItemMenu menu, Unit unit, bool bDone) { }

	// RVA: 0x21694B0 Offset: 0x21695B1 VA: 0x21694B0
	private SortieTradeItemMenu GetAnotherMenu(SortieTradeItemMenu menu) { }

	// RVA: 0x2168820 Offset: 0x2168921 VA: 0x2168820
	private SortieTradeItemMenu GetSelectedMenu() { }

	// RVA: 0x21693F0 Offset: 0x21694F1 VA: 0x21693F0
	private SortieTradeItemMenu GetUnselectedMenu() { }

	// RVA: 0x21694C0 Offset: 0x21695C1 VA: 0x21694C0
	private SortieTradeItemMenu GetFirstSelectMenu() { }

	// RVA: 0x2166F40 Offset: 0x2167041 VA: 0x2166F40
	private bool IsFirstSelectBlank() { }

	// RVA: 0x21667C0 Offset: 0x21668C1 VA: 0x21667C0
	private void UpdateSelectableBlankToDisable() { }

	// RVA: 0x2165C80 Offset: 0x2165D81 VA: 0x2165C80
	public void .ctor() { }

	// RVA: 0x21698D0 Offset: 0x21699D1 VA: 0x21698D0
	private static void .cctor() { }
}

