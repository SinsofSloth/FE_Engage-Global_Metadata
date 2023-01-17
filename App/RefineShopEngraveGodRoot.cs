// Namespace: App
public class RefineShopEngraveGodRoot : MonoBehaviour // TypeDefIndex: 11118
{
	// Fields
	private const string PrefabPath = "UI/Hub/Shop/Prefabs/ShopRefineEmblemRoot";
	public GameObject m_RefineShopEngraveGodMenuObject; // 0x18
	public RefineItemDetailWindow m_ItemDetailWindowBase; // 0x20
	public RefineItemDetailWindow m_ItemDetailWindowTarget; // 0x28
	private RefineShopEngraveGodMenu m_RefineShopEngraveGodMenu; // 0x30
	private RefineShopEngraveGodRoot.ReturnEventHandler m_ReturnEventHandler; // 0x38
	private Unit m_Unit; // 0x40
	private int m_OwnerItemIndex; // 0x48
	private GodData m_GodData; // 0x50

	// Methods

	// RVA: 0x2C629B0 Offset: 0x2C62AB1 VA: 0x2C629B0
	public static void LoadPrefabAsync() { }

	// RVA: 0x2C62A50 Offset: 0x2C62B51 VA: 0x2C62A50
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2C62AD0 Offset: 0x2C62BD1 VA: 0x2C62AD0
	public static void UnloadPrefab() { }

	// RVA: 0x2C62B50 Offset: 0x2C62C51 VA: 0x2C62B50
	public static RefineShopEngraveGodRoot CreateBind(ProcInst super, ShopWeaponModelRenderer shopWeaponModelRenderer, Unit unit, int itemIndex, RefineShopEngraveGodRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x2C62D00 Offset: 0x2C62E01 VA: 0x2C62D00
	private void Create(ProcInst super, ShopWeaponModelRenderer shopWeaponModelRenderer, Unit unit, int itemIndex, RefineShopEngraveGodRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x2C63120 Offset: 0x2C63221 VA: 0x2C63120
	public static void Destroy(RefineShopEngraveGodRoot root) { }

	// RVA: 0x2C631F0 Offset: 0x2C632F1 VA: 0x2C631F0
	private void .ctor() { }

	// RVA: 0x2C63200 Offset: 0x2C63301 VA: 0x2C63200
	private void UpdateItemDetail(RefineItemDetailWindow itemDetailWindow, UnitItem unitItem) { }

	// RVA: 0x2C63210 Offset: 0x2C63311 VA: 0x2C63210
	private void UpdateItemDetail(RefineItemDetailWindow itemDetailWindow, UnitItem unitItemBase, UnitItem unitItemTarget) { }

	// RVA: 0x2C63340 Offset: 0x2C63441 VA: 0x2C63340
	public void OnSelectMenuItem(GodData godData, UnitItem unitItem) { }

	// RVA: 0x2C633A0 Offset: 0x2C634A1 VA: 0x2C633A0
	public void OnDecideMenuItem(GodData godData) { }

	// RVA: 0x2C63490 Offset: 0x2C63591 VA: 0x2C63490
	public void OnConfirmYes() { }

	// RVA: 0x2C63A60 Offset: 0x2C63B61 VA: 0x2C63A60
	public void Engrave(UnitItem resetUnitItem) { }

	// RVA: 0x2C63D40 Offset: 0x2C63E41 VA: 0x2C63D40
	public void OnRequestCloseMenu() { }

	// RVA: 0x2C63C60 Offset: 0x2C63D61 VA: 0x2C63C60
	public void Close() { }
}

