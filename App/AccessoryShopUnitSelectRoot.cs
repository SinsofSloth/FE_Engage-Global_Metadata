// Namespace: App
public class AccessoryShopUnitSelectRoot : MonoBehaviour // TypeDefIndex: 10922
{
	// Fields
	private const string PrefabPath = "UI/Hub/Shop/Prefabs/ShopAccUnitSelectRoot";
	public GameObject m_ShopUnitSelectMenuObject; // 0x18
	public GameObject m_AccessoryEquipmentInfoObject; // 0x20
	public TextMeshProUGUI m_UnitName; // 0x28
	private AccessoryEquipmentInfo m_AccessoryEquipmentInfoWindow; // 0x30
	private ShopUnitSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x38

	// Methods

	// RVA: 0x2B23020 Offset: 0x2B23121 VA: 0x2B23020
	public static void LoadPrefabAsync() { }

	// RVA: 0x2B23180 Offset: 0x2B23281 VA: 0x2B23180
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2B23200 Offset: 0x2B23301 VA: 0x2B23200
	public static void UnloadPrefab() { }

	// RVA: 0x2B23280 Offset: 0x2B23381 VA: 0x2B23280
	public static AccessoryShopUnitSelectRoot CreateBind(ProcInst super, Unit defaultUnit, int defaultScrollIndex, ShopUnitSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2B23430 Offset: 0x2B23531 VA: 0x2B23430
	private void Create(ProcInst super, Unit defaultUnit, int defaultScrollIndex, ShopUnitSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2B23700 Offset: 0x2B23801 VA: 0x2B23700
	public static void Destroy(AccessoryShopUnitSelectRoot root) { }

	// RVA: 0x2B23780 Offset: 0x2B23881 VA: 0x2B23780
	protected void .ctor() { }

	// RVA: 0x2B23790 Offset: 0x2B23891 VA: 0x2B23790
	public void OnSelectMenuItem(Unit unit) { }

	// RVA: 0x2B23870 Offset: 0x2B23971 VA: 0x2B23870
	public void OnDecideMenuItem(BasicMenu.Result result, Unit unit, int scrollIndex) { }

	// RVA: 0x2B23920 Offset: 0x2B23A21 VA: 0x2B23920
	public void Close() { }
}

