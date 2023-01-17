// Namespace: App
public class WeaponShopBuyRoot : MonoBehaviour // TypeDefIndex: 11260
{
	// Fields
	private const string PrefabPath = "UI/Hub/Shop/Prefabs/ShopWeaponBuyRoot";
	public CanvasGroup m_RootCanvasGroup; // 0x18
	public GameObject m_MenuObject; // 0x20
	public UnitItemMenuContent m_UnitItemMenuContent; // 0x28
	public GameObject m_HoldingInfoWindowObject; // 0x30
	public GameObject m_ItemHelpObject; // 0x38
	public GameObject m_UnitImageObject; // 0x40
	public GameObject m_PriceDownObject; // 0x48
	public TextMeshProUGUI m_PriceDownText; // 0x50
	[HeaderAttribute] // RVA: 0x297300 Offset: 0x297401 VA: 0x297300
	public TextMeshProUGUI m_EquipableWeaponsCaptionText; // 0x58
	public WeaponShopBuyRoot.EquipableWeaponInfo[] m_EquipableWeaponInfo; // 0x60
	private Unit m_Unit; // 0x68
	private WeaponShopBuyMenu m_WeaponShopBuyMenu; // 0x70
	private UnitItemMenu m_UnitItemMenu; // 0x78
	private WeaponHoldingInfoWindow m_WeaponHoldingInfoWindow; // 0x80
	private ItemMenuDetailSetter m_ItemMenuDetailSetter; // 0x88
	private WeaponShopBuyRoot.ReturnEventHandler m_ReturnEventHandler; // 0x90
	private ExchangeYesNoDialog m_YesNoDialog; // 0x98
	private ProcInst m_SendItemMenu; // 0xA0
	private ProcInst m_DiscardItemMenu; // 0xA8
	private UnitItem m_UnitItem; // 0xB0
	private ItemData m_ItemData; // 0xB8
	private bool m_IsSendingItemToTransporter; // 0xC0
	private bool m_IsSendingUnitItem; // 0xC1
	private int m_SendingUnitItemIndex; // 0xC4
	private bool m_IsDiscardingTransporterItem; // 0xC8
	private int m_DiscardingTransporterItemIndex; // 0xCC
	private bool m_ExistingOwner; // 0xD0
	private bool m_ItemDetailDisplayWithUnit; // 0xD1

	// Methods

	// RVA: 0x26D2DD0 Offset: 0x26D2ED1 VA: 0x26D2DD0
	public static void LoadPrefabAsync() { }

	// RVA: 0x26D2E70 Offset: 0x26D2F71 VA: 0x26D2E70
	public static bool IsLoadingPrefab() { }

	// RVA: 0x26D2EF0 Offset: 0x26D2FF1 VA: 0x26D2EF0
	public static void UnloadPrefab() { }

	// RVA: 0x26D2F70 Offset: 0x26D3071 VA: 0x26D2F70
	public static WeaponShopBuyRoot CreateBind(ProcInst super, Unit unit, bool existingOwner, WeaponShopBuyRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x26D3120 Offset: 0x26D3221 VA: 0x26D3120
	private void Create(ProcInst super, Unit unit, bool existingOwner, WeaponShopBuyRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x26D3750 Offset: 0x26D3851 VA: 0x26D3750
	public static void Destroy(WeaponShopBuyRoot root) { }

	// RVA: 0x26D3870 Offset: 0x26D3971 VA: 0x26D3870
	protected void .ctor() { }

	// RVA: 0x26D3880 Offset: 0x26D3981 VA: 0x26D3880
	private void Start() { }

	// RVA: 0x26D3980 Offset: 0x26D3A81 VA: 0x26D3980
	private void UpdateItemDetail() { }

	// RVA: 0x26D3640 Offset: 0x26D3741 VA: 0x26D3640
	private void UpdateEquipableWeaponInfo() { }

	// RVA: 0x26D3AB0 Offset: 0x26D3BB1 VA: 0x26D3AB0
	public void OnChangeUnitToPrev(UnitItem unitItem) { }

	// RVA: 0x26D3D10 Offset: 0x26D3E11 VA: 0x26D3D10
	public void OnChangeUnitToNext(UnitItem unitItem) { }

	// RVA: 0x26D3F30 Offset: 0x26D4031 VA: 0x26D3F30
	public void OnSwitchDetailDisplayWay() { }

	// RVA: 0x26D3F40 Offset: 0x26D4041 VA: 0x26D3F40
	public void OnSelectMenuItem(UnitItem unitItem) { }

	// RVA: 0x26D40C0 Offset: 0x26D41C1 VA: 0x26D40C0
	public bool OnDecideMenuItem(ItemData itemData) { }

	// RVA: 0x26D4220 Offset: 0x26D4321 VA: 0x26D4220
	public void OnYesToBuy() { }

	// RVA: 0x26D4940 Offset: 0x26D4A41 VA: 0x26D4940
	public void OnDecideToSendItem(bool isSelectingUnitItem, int unitItemIndex) { }

	// RVA: 0x26D4BD0 Offset: 0x26D4CD1 VA: 0x26D4BD0
	public void OnCancelToSendItem() { }

	// RVA: 0x26D4CC0 Offset: 0x26D4DC1 VA: 0x26D4CC0
	public void OnDecidelToDiscardItem(bool transporterIsSelected, int transporterItemIndex) { }

	// RVA: 0x26D4DE0 Offset: 0x26D4EE1 VA: 0x26D4DE0
	public void OnCancelToDiscardItem() { }

	// RVA: 0x26D46B0 Offset: 0x26D47B1 VA: 0x26D46B0
	public void OnBuy() { }

	// RVA: 0x26D5030 Offset: 0x26D5131 VA: 0x26D5030
	public void OnRequestClose() { }

	// RVA: 0x26D5040 Offset: 0x26D5141 VA: 0x26D5040
	public void Close() { }

	// RVA: 0x26D3CC0 Offset: 0x26D3DC1 VA: 0x26D3CC0
	public void SetUnitImageActive(bool isActive) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3FA0 Offset: 0x2C40A1 VA: 0x2C3FA0
	// RVA: 0x26D5180 Offset: 0x26D5281 VA: 0x26D5180
	private void <OnChangeUnitToPrev>b__41_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3FB0 Offset: 0x2C40B1 VA: 0x2C3FB0
	// RVA: 0x26D5200 Offset: 0x26D5301 VA: 0x26D5200
	private void <OnChangeUnitToNext>b__42_0() { }
}

