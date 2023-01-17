// Namespace: App
public class AccessoryShopChangeRoot : MonoBehaviour // TypeDefIndex: 10909
{
	// Fields
	private const string PrefabPath = "UI/Hub/Shop/Prefabs/ShopAccChangeRoot";
	public GameObject m_MenuObject; // 0x18
	public GameObject m_UnitNameObject; // 0x20
	public TextMeshProUGUI m_UnitName; // 0x28
	public GameObject m_EquipmentInfoWindowObject; // 0x30
	public GameObject m_DetailInfoWindowObject; // 0x38
	public GameObject m_KeyHelpAllObject; // 0x40
	public Animator m_KeyHelpAllAnimator; // 0x48
	public KeyHelpController m_WatchingModeKeyHelpController; // 0x50
	private AccessoryShopChangeRootProc m_AccessoryShopChangeRootProc; // 0x58
	private Unit m_Unit; // 0x60
	private AccessoryShopChangeMenu m_AccessoryShopChangeMenu; // 0x68
	private AccessoryEquipmentInfo m_AccessoryEquipmentInfoWindow; // 0x70
	private AccessoryDetailInfoWindow m_AccessoryDetailInfoWindow; // 0x78
	private AccessoryShopChangeRoot.ReturnEventHandler m_ReturnEventHandler; // 0x80
	private AccessoryData m_AccessoryData; // 0x88
	private bool m_Changed; // 0x90

	// Methods

	// RVA: 0x2B1F4E0 Offset: 0x2B1F5E1 VA: 0x2B1F4E0
	public static void LoadPrefabAsync() { }

	// RVA: 0x2B1F580 Offset: 0x2B1F681 VA: 0x2B1F580
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2B1F600 Offset: 0x2B1F701 VA: 0x2B1F600
	public static void UnloadPrefab() { }

	// RVA: 0x2B1F680 Offset: 0x2B1F781 VA: 0x2B1F680
	public static AccessoryShopChangeRoot CreateBind(ProcInst super, Unit unit, AccessoryShopChangeRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x2B1F820 Offset: 0x2B1F921 VA: 0x2B1F820
	private void Create(ProcInst super, Unit unit, AccessoryShopChangeRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x2B200A0 Offset: 0x2B201A1 VA: 0x2B200A0
	public static void Destroy(AccessoryShopChangeRoot root) { }

	// RVA: 0x2B20120 Offset: 0x2B20221 VA: 0x2B20120
	protected void .ctor() { }

	// RVA: 0x2B20130 Offset: 0x2B20231 VA: 0x2B20130
	public void OnSelectMenuItem(AccessoryData accessoryData) { }

	// RVA: 0x2B204E0 Offset: 0x2B205E1 VA: 0x2B204E0
	public void OnDecideMenuItem(AccessoryData accessoryData) { }

	// RVA: 0x2B20720 Offset: 0x2B20821 VA: 0x2B20720
	public void OnChangeUnitToPrev(bool watching) { }

	// RVA: 0x2B20C80 Offset: 0x2B20D81 VA: 0x2B20C80
	public void OnChangeUnitToNext(bool watching) { }

	// RVA: 0x2B211E0 Offset: 0x2B212E1 VA: 0x2B211E0
	public void OnChangeKind(AccessoryData accessoryData) { }

	// RVA: 0x2B21280 Offset: 0x2B21381 VA: 0x2B21280
	public bool OnStartWatching() { }

	// RVA: 0x2B214A0 Offset: 0x2B215A1 VA: 0x2B214A0
	public void OnEndWatching() { }

	// RVA: 0x2B217E0 Offset: 0x2B218E1 VA: 0x2B217E0
	public void OnShowUI() { }

	// RVA: 0x2B21950 Offset: 0x2B21A51 VA: 0x2B21950
	public void OnHideUI() { }

	// RVA: 0x2B21AC0 Offset: 0x2B21BC1 VA: 0x2B21AC0
	public void OnRequestCloseMenu() { }
}

