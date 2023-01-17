// Namespace: App
public class WellItemSelectMenuContent : BasicMenuContent // TypeDefIndex: 11786
{
	// Fields
	private const string PrefabPath = "UI/Hub/Well/Prefabs/WellItemSelectRoot";
	public GameObject m_RootObject; // 0xE8
	public MenuAccessoryContent m_ItemListContent; // 0xF0
	public MenuAccessoryContent m_ItemHelpContent; // 0xF8
	public MenuAccessoryContent m_ExpectedContent; // 0x100
	public BasicItemMenuItemContent[] m_SelectedItemContentList; // 0x108
	public GameObject[] m_StarList; // 0x110
	public TextMeshProUGUI m_StockValueText; // 0x118
	public TextMeshProUGUI m_StockValueMaxText; // 0x120
	public Image[] m_KindIconBgImageList; // 0x128
	protected int m_SelectedKindIndex; // 0x130

	// Methods

	// RVA: 0x26D6C20 Offset: 0x26D6D21 VA: 0x26D6C20
	public static void LoadPrefabAsync() { }

	// RVA: 0x26D6CC0 Offset: 0x26D6DC1 VA: 0x26D6CC0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x26D6D40 Offset: 0x26D6E41 VA: 0x26D6D40
	public static void UnloadPrefab() { }

	// RVA: 0x26D6DC0 Offset: 0x26D6EC1 VA: 0x26D6DC0
	public static WellItemSelectMenuContent Create() { }

	// RVA: 0x26D6EC0 Offset: 0x26D6FC1 VA: 0x26D6EC0
	public static void Destroy(WellItemSelectMenuContent content) { }

	// RVA: 0x26D6F40 Offset: 0x26D7041 VA: 0x26D6F40 Slot: 30
	protected override void Awake() { }

	// RVA: 0x26D6F50 Offset: 0x26D7051 VA: 0x26D6F50 Slot: 33
	protected override void OnDestroy() { }

	// RVA: 0x26D6FD0 Offset: 0x26D70D1 VA: 0x26D6FD0
	public void InitMenuAccessoryContent(BasicMenu menu) { }

	// RVA: 0x26D7020 Offset: 0x26D7121 VA: 0x26D7020 Slot: 25
	public override void OpenAnime() { }

	// RVA: 0x26D70D0 Offset: 0x26D71D1 VA: 0x26D70D0 Slot: 26
	public override void CloseAnime() { }

	// RVA: 0x26D71E0 Offset: 0x26D72E1 VA: 0x26D71E0 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x26D7200 Offset: 0x26D7301 VA: 0x26D7200 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x26D72F0 Offset: 0x26D73F1 VA: 0x26D72F0
	public void UpdateSelectedItemList(List<BasicItemMenuItem> list) { }

	// RVA: 0x26D7300 Offset: 0x26D7401 VA: 0x26D7300
	private void UpdateExpectedStar(int expected) { }

	// RVA: 0x26D74F0 Offset: 0x26D75F1 VA: 0x26D74F0
	public void UpdateItemHelp(Unit unit, UnitItem item) { }

	// RVA: 0x26D75B0 Offset: 0x26D76B1 VA: 0x26D75B0
	public void SetSelectedItemKindIndex(int index) { }

	// RVA: 0x26D7710 Offset: 0x26D7811 VA: 0x26D7710
	public void SetStockValue(int value) { }

	// RVA: 0x26D7790 Offset: 0x26D7891 VA: 0x26D7790
	public void SetStockValueMax(int value) { }

	// RVA: 0x26D7810 Offset: 0x26D7911 VA: 0x26D7810
	public void .ctor() { }
}

