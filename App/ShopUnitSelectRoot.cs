// Namespace: App
public class ShopUnitSelectRoot : MonoBehaviour // TypeDefIndex: 11217
{
	// Fields
	private const string PrefabPath = "UI/Hub/Shop/Prefabs/ShopUnitSelectRoot";
	public GameObject m_ShopUnitSelectMenuObject; // 0x18
	public GameObject m_UnitStatusObject; // 0x20
	private ShopUnitSelectStatus m_ShopUnitSelectStatus; // 0x28
	private ShopUnitSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x30

	// Methods

	// RVA: 0x233FEB0 Offset: 0x233FFB1 VA: 0x233FEB0
	public static void LoadPrefabAsync() { }

	// RVA: 0x233FF30 Offset: 0x2340031 VA: 0x233FF30
	public static bool IsLoadingPrefab() { }

	// RVA: 0x233FFB0 Offset: 0x23400B1 VA: 0x233FFB0
	public static void UnloadPrefab() { }

	// RVA: 0x2340030 Offset: 0x2340131 VA: 0x2340030
	public static ShopUnitSelectRoot CreateBind(ProcInst super, Unit defaultUnit, int defaultScrollIndex, bool addingTransporter, ShopUnitSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x23401C0 Offset: 0x23402C1 VA: 0x23401C0
	private void Create(ProcInst super, Unit defaultUnit, int defaultScrollIndex, bool addingTransporter, ShopUnitSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2340530 Offset: 0x2340631 VA: 0x2340530
	public static void Destroy(ShopUnitSelectRoot root) { }

	// RVA: 0x2340610 Offset: 0x2340711 VA: 0x2340610
	protected void .ctor() { }

	// RVA: 0x2340620 Offset: 0x2340721 VA: 0x2340620
	public void OnSelectMenuItem(Unit unit) { }

	// RVA: 0x23408D0 Offset: 0x23409D1 VA: 0x23408D0
	public void OnDecideMenuItem(BasicMenu.Result result, Unit unit, int scrollIndex) { }

	// RVA: 0x2340AB0 Offset: 0x2340BB1 VA: 0x2340AB0
	public void OnHelp(ProcInst parent) { }
}

