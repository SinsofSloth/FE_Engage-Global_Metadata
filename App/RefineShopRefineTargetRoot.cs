// Namespace: App
public class RefineShopRefineTargetRoot : MonoBehaviour // TypeDefIndex: 11166
{
	// Fields
	private const string PrefabPath = "UI/Hub/Shop/Prefabs/ShopRefineAfterSelectRoot";
	public GameObject m_RefineShopRefineTargetMenuObject; // 0x18
	public RefineItemDetailWindow m_ItemDetailWindowBase; // 0x20
	public RefineItemDetailWindow m_ItemDetailWindowTarget; // 0x28
	public GameObject m_ArrowObject; // 0x30
	private RefineShopRefineTargetRoot.ReturnEventHandler m_ReturnEventHandler; // 0x38
	private RefineShopRefineTargetMenu m_RefineShopRefineTargetMenu; // 0x40
	private Unit m_Unit; // 0x48
	private int m_ItemIndex; // 0x50
	private UnitItem m_BaseUnitItem; // 0x58
	private int m_RefineLevel; // 0x60
	private int m_EvolveIndex; // 0x64

	// Methods

	// RVA: 0x2523C50 Offset: 0x2523D51 VA: 0x2523C50
	public static void LoadPrefabAsync() { }

	// RVA: 0x2523CF0 Offset: 0x2523DF1 VA: 0x2523CF0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2523D70 Offset: 0x2523E71 VA: 0x2523D70
	public static void UnloadPrefab() { }

	// RVA: 0x2523DF0 Offset: 0x2523EF1 VA: 0x2523DF0
	public static RefineShopRefineTargetRoot CreateBind(ProcInst super, ShopWeaponModelRenderer shopWeaponModelRenderer, Unit unit, int itemIndex, RefineShopRefineTargetRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x2523FA0 Offset: 0x25240A1 VA: 0x2523FA0
	private void Create(ProcInst super, ShopWeaponModelRenderer shopWeaponModelRenderer, Unit unit, int itemIndex, RefineShopRefineTargetRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x2524350 Offset: 0x2524451 VA: 0x2524350
	public static void Destroy(RefineShopRefineTargetRoot root) { }

	// RVA: 0x2524420 Offset: 0x2524521 VA: 0x2524420
	private void UpdateItemDetail(RefineItemDetailWindow itemDetailWindow, UnitItem unitItemBase, bool revealed) { }

	// RVA: 0x2524430 Offset: 0x2524531 VA: 0x2524430
	private void UpdateItemDetail(RefineItemDetailWindow itemDetailWindow, UnitItem unitItemBase, UnitItem unitItemTarget, bool revealed) { }

	// RVA: 0x2524590 Offset: 0x2524691 VA: 0x2524590
	public void OnSelectMenuItem(UnitItem unitItem, bool revealed) { }

	// RVA: 0x25245E0 Offset: 0x25246E1 VA: 0x25245E0
	public void OnDecideMenuItemToRefine(int refineLevel, UnitItem refinedUnitItem, int ironNum, int steelNum, int silverNum, int price) { }

	// RVA: 0x2524750 Offset: 0x2524851 VA: 0x2524750
	public void OnRefine() { }

	// RVA: 0x2524A90 Offset: 0x2524B91 VA: 0x2524A90
	public void OnDecideMenuItemToEvolve(UnitItem evolvedUnitItem, int evolveIndex) { }

	// RVA: 0x2524BE0 Offset: 0x2524CE1 VA: 0x2524BE0
	public void OnEvolve() { }

	// RVA: 0x2525390 Offset: 0x2525491 VA: 0x2525390
	public void OnRequestCloseMenu() { }

	// RVA: 0x25249A0 Offset: 0x2524AA1 VA: 0x25249A0
	public void Close() { }

	// RVA: 0x25253A0 Offset: 0x25254A1 VA: 0x25253A0
	public void .ctor() { }
}

