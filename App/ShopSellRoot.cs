// Namespace: App
public class ShopSellRoot : MonoBehaviour // TypeDefIndex: 11204
{
	// Fields
	private const string PrefabPath = "UI/Hub/Shop/Prefabs/ShopItemSellRoot";
	public TextMeshProUGUI m_UnitNameText; // 0x18
	public GameObject m_MenuObject; // 0x20
	public GameObject m_DetailInfoWindowObject; // 0x28
	public GameObject m_AccountWindowObject; // 0x30
	public GameObject m_UnitImageObject; // 0x38
	private Unit m_Unit; // 0x40
	private ShopSellMenu m_ShopSellMenu; // 0x48
	private ItemMenuDetailSetter m_ItemMenuDetailSetter; // 0x50
	private ShopSellAccountWindow m_AccountWindow; // 0x58
	private ShopSellRoot.ReturnEventHandler m_ReturnEventHandler; // 0x60
	private UnitItem m_UnitItem; // 0x68
	private bool m_ItemDetailDisplayWithUnit; // 0x70

	// Methods

	// RVA: 0x233C350 Offset: 0x233C451 VA: 0x233C350
	public static void LoadPrefabAsync() { }

	// RVA: 0x233C3F0 Offset: 0x233C4F1 VA: 0x233C3F0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x233C470 Offset: 0x233C571 VA: 0x233C470
	public static void UnloadPrefab() { }

	// RVA: 0x233C4F0 Offset: 0x233C5F1 VA: 0x233C4F0
	public static ShopSellRoot CreateBind(ProcInst super, Unit unit, ShopSellRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x233C690 Offset: 0x233C791 VA: 0x233C690
	private void Create(ProcInst super, Unit unit, ShopSellRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x233CD10 Offset: 0x233CE11 VA: 0x233CD10
	public static void Destroy(ShopSellRoot root) { }

	// RVA: 0x233CE30 Offset: 0x233CF31 VA: 0x233CE30
	private void Destroy() { }

	// RVA: 0x233CE90 Offset: 0x233CF91 VA: 0x233CE90
	protected void .ctor() { }

	// RVA: 0x233CEA0 Offset: 0x233CFA1 VA: 0x233CEA0
	private void UpdateItemDetail() { }

	// RVA: 0x233CCC0 Offset: 0x233CDC1 VA: 0x233CCC0
	public void SetUnitImageActive(bool isActive) { }

	// RVA: 0x233CFE0 Offset: 0x233D0E1 VA: 0x233CFE0
	public void OnChangeUnitToPrev() { }

	// RVA: 0x233D2C0 Offset: 0x233D3C1 VA: 0x233D2C0
	public void OnChangeUnitToNext() { }

	// RVA: 0x233D5A0 Offset: 0x233D6A1 VA: 0x233D5A0
	public void OnSwitchDetailDisplayWay() { }

	// RVA: 0x233D5B0 Offset: 0x233D6B1 VA: 0x233D5B0
	public void OnSelectMenuItem(UnitItem unitItem) { }

	// RVA: 0x233D5E0 Offset: 0x233D6E1 VA: 0x233D5E0
	public void OnDecideItem(int itemCount, int totalValue) { }

	// RVA: 0x233D690 Offset: 0x233D791 VA: 0x233D690
	public void OnCancelItem(int itemCount, int totalValue) { }

	// RVA: 0x233D740 Offset: 0x233D841 VA: 0x233D740
	public void OnDecideToSell() { }

	// RVA: 0x233DFF0 Offset: 0x233E0F1 VA: 0x233DFF0
	public void Sell() { }

	// RVA: 0x233E180 Offset: 0x233E281 VA: 0x233E180
	public void OnRequestCloseMenu() { }
}

