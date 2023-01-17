// Namespace: App
public class AccessoryShopBuyRoot : MonoBehaviour // TypeDefIndex: 10895
{
	// Fields
	private const string PrefabPath = "UI/Hub/Shop/Prefabs/ShopAccBuyRoot";
	public GameObject m_MenuObject; // 0x18
	public GameObject m_UnitNameObject; // 0x20
	public TextMeshProUGUI m_UnitName; // 0x28
	public GameObject m_EquipmentInfoWindowObject; // 0x30
	public GameObject m_DetailInfoWindowObject; // 0x38
	public GameObject m_KeyHelpAllObject; // 0x40
	public Animator m_KeyHelpAllAnimator; // 0x48
	public KeyHelpController m_WatchingModeKeyHelpController; // 0x50
	private AccessoryShopBuyRootProc m_AccessoryShopBuyRootProc; // 0x58
	private Unit m_Unit; // 0x60
	private AccessoryShopBuyMenu m_AccessoryShopBuyMenu; // 0x68
	private AccessoryEquipmentInfo m_AccessoryEquipmentInfoWindow; // 0x70
	private AccessoryDetailInfoWindow m_AccessoryDetailInfoWindow; // 0x78
	private AccessoryShopBuyRoot.ReturnEventHandler m_ReturnEventHandler; // 0x80
	private AccessoryData m_AccessoryData; // 0x88

	// Methods

	// RVA: 0x2B1AB50 Offset: 0x2B1AC51 VA: 0x2B1AB50
	public static void LoadPrefabAsync() { }

	// RVA: 0x2B1ABF0 Offset: 0x2B1ACF1 VA: 0x2B1ABF0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2B1AC70 Offset: 0x2B1AD71 VA: 0x2B1AC70
	public static void UnloadPrefab() { }

	// RVA: 0x2B1ACF0 Offset: 0x2B1ADF1 VA: 0x2B1ACF0
	public static AccessoryShopBuyRoot CreateBind(ProcInst super, Unit unit, AccessoryShopBuyRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x2B1AE90 Offset: 0x2B1AF91 VA: 0x2B1AE90
	private void Create(ProcInst super, Unit unit, AccessoryShopBuyRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x2B1B700 Offset: 0x2B1B801 VA: 0x2B1B700
	public static void Destroy(AccessoryShopBuyRoot root) { }

	// RVA: 0x2B1B780 Offset: 0x2B1B881 VA: 0x2B1B780
	protected void .ctor() { }

	// RVA: 0x2B1B790 Offset: 0x2B1B891 VA: 0x2B1B790
	public void OnSelectMenuItem(AccessoryData accessoryData) { }

	// RVA: 0x2B1B8D0 Offset: 0x2B1B9D1 VA: 0x2B1B8D0
	public void OnDecideMenuItem(AccessoryData accessoryData) { }

	// RVA: 0x2B1B9F0 Offset: 0x2B1BAF1 VA: 0x2B1B9F0
	public void OnDisposeConfirmDialog() { }

	// RVA: 0x2B1BA10 Offset: 0x2B1BB11 VA: 0x2B1BA10
	public void OnBuy() { }

	// RVA: 0x2B1BBA0 Offset: 0x2B1BCA1 VA: 0x2B1BBA0
	public void OnChangeUnitToPrev() { }

	// RVA: 0x2B1BD40 Offset: 0x2B1BE41 VA: 0x2B1BD40
	public void OnChangeUnitToNext() { }

	// RVA: 0x2B1BEE0 Offset: 0x2B1BFE1 VA: 0x2B1BEE0
	public void OnChangeKind(AccessoryData accessoryData) { }

	// RVA: 0x2B1BF80 Offset: 0x2B1C081 VA: 0x2B1BF80
	public bool OnStartWatching() { }

	// RVA: 0x2B1C200 Offset: 0x2B1C301 VA: 0x2B1C200
	public void OnEndWatching() { }

	// RVA: 0x2B1C590 Offset: 0x2B1C691 VA: 0x2B1C590
	public void OnShowUI() { }

	// RVA: 0x2B1C700 Offset: 0x2B1C801 VA: 0x2B1C700
	public void OnHideUI() { }

	// RVA: 0x2B1C870 Offset: 0x2B1C971 VA: 0x2B1C870
	public void OnRequestCloseMenu() { }
}

