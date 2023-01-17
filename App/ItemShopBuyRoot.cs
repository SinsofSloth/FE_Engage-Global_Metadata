// Namespace: App
public class ItemShopBuyRoot : MonoBehaviour // TypeDefIndex: 11026
{
	// Fields
	public const string PrefabPath = "UI/Hub/Shop/Prefabs/ShopItemBuyRoot";
	public GameObject m_MenuObject; // 0x18
	public UnitItemMenuContent m_UnitItemMenuContent; // 0x20
	public GameObject m_HoldingInfoWindowObject; // 0x28
	public GameObject m_DetailInfoWindowObject; // 0x30
	public GameObject m_UnitImageObject; // 0x38
	public GameObject m_PriceDownObject; // 0x40
	public TextMeshProUGUI m_PriceDownText; // 0x48
	private Unit m_Unit; // 0x50
	private ItemShopBuyMenu m_ItemShopBuyMenu; // 0x58
	private UnitItemMenu m_UnitItemMenu; // 0x60
	private ItemHoldingInfoWindow m_ItemHoldingInfoWindow; // 0x68
	private ItemMenuDetailSetter m_ItemMenuDetailSetter; // 0x70
	private ItemShopBuyRoot.ReturnEventHandler m_ReturnEventHandler; // 0x78
	private ExchangeYesNoDialog m_YesNoDialog; // 0x80
	private ProcInst m_SendItemMenu; // 0x88
	private ProcInst m_DiscardItemMenu; // 0x90
	private ItemData m_ItemData; // 0x98
	private UnitItem m_UnitItem; // 0xA0
	private bool m_IsSendingItemToTransporter; // 0xA8
	private bool m_IsSendingUnitItem; // 0xA9
	private int m_SendingUnitItemIndex; // 0xAC
	private bool m_IsDiscardingTransporterItem; // 0xB0
	private int m_DiscardingTransporterItemIndex; // 0xB4
	private bool m_ExistingOwner; // 0xB8
	private bool m_ItemDetailDisplayWithUnit; // 0xB9

	// Methods

	// RVA: 0x245A4D0 Offset: 0x245A5D1 VA: 0x245A4D0
	public static void LoadPrefabAsync() { }

	// RVA: 0x245A570 Offset: 0x245A671 VA: 0x245A570
	public static bool IsLoadingPrefab() { }

	// RVA: 0x245A5F0 Offset: 0x245A6F1 VA: 0x245A5F0
	public static void UnloadPrefab() { }

	// RVA: 0x245A670 Offset: 0x245A771 VA: 0x245A670
	public static ItemShopBuyRoot CreateBind(ProcInst super, Unit unit, bool existingOwner, ItemShopBuyRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x245A820 Offset: 0x245A921 VA: 0x245A820
	private void Create(ProcInst super, Unit unit, bool existingOwner, ItemShopBuyRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x245ADF0 Offset: 0x245AEF1 VA: 0x245ADF0
	public static void Destroy(ItemShopBuyRoot root) { }

	// RVA: 0x245AED0 Offset: 0x245AFD1 VA: 0x245AED0
	protected void .ctor() { }

	// RVA: 0x245AEE0 Offset: 0x245AFE1 VA: 0x245AEE0
	private void Start() { }

	// RVA: 0x245ADA0 Offset: 0x245AEA1 VA: 0x245ADA0
	public void SetUnitImageActive(bool isActive) { }

	// RVA: 0x245AEF0 Offset: 0x245AFF1 VA: 0x245AEF0
	private void UpdateItemDetail() { }

	// RVA: 0x245B020 Offset: 0x245B121 VA: 0x245B020
	public void OnChangeUnitToPrev(UnitItem unitItem) { }

	// RVA: 0x245B1E0 Offset: 0x245B2E1 VA: 0x245B1E0
	public void OnChangeUnitToNext(UnitItem unitItem) { }

	// RVA: 0x245B3B0 Offset: 0x245B4B1 VA: 0x245B3B0
	public void OnSwitchDetailDisplayWay() { }

	// RVA: 0x245B3C0 Offset: 0x245B4C1 VA: 0x245B3C0
	public void OnSelectMenuItem(UnitItem unitItem) { }

	// RVA: 0x245B510 Offset: 0x245B611 VA: 0x245B510
	public bool OnDecideMenuItem(ItemData itemData) { }

	// RVA: 0x245B670 Offset: 0x245B771 VA: 0x245B670
	public void OnYesToBuy() { }

	// RVA: 0x245BD10 Offset: 0x245BE11 VA: 0x245BD10
	public void OnDecideToSendItem(bool isSelectingUnitItem, int unitItemIndex) { }

	// RVA: 0x245BF40 Offset: 0x245C041 VA: 0x245BF40
	public void OnCancelToSendItem() { }

	// RVA: 0x245C030 Offset: 0x245C131 VA: 0x245C030
	public void OnDecidelToDiscardItem(bool transporterIsSelected, int transporterItemIndex) { }

	// RVA: 0x245C150 Offset: 0x245C251 VA: 0x245C150
	public void OnCancelToDiscardItem() { }

	// RVA: 0x245BA80 Offset: 0x245BB81 VA: 0x245BA80
	public void OnBuy() { }

	// RVA: 0x245C350 Offset: 0x245C451 VA: 0x245C350
	public void OnRequestClose() { }

	// RVA: 0x245C360 Offset: 0x245C461 VA: 0x245C360
	public void Close() { }
}

