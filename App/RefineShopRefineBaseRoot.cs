// Namespace: App
public class RefineShopRefineBaseRoot : MonoBehaviour // TypeDefIndex: 11154
{
	// Fields
	protected const string PrefabPath = "UI/Hub/Shop/Prefabs/ShopRefineBeforeSelectRoot";
	public GameObject m_RefineShopRefineBaseMenuObject; // 0x18
	public GameObject m_WeaponModelObject; // 0x20
	public GameObject m_ItemDetailInfoWindowObject; // 0x28
	[HeaderAttribute] // RVA: 0x296C50 Offset: 0x296D51 VA: 0x296C50
	public float m_WeaponRotWaitTime; // 0x30
	[HeaderAttribute] // RVA: 0x296C90 Offset: 0x296D91 VA: 0x296C90
	public float m_WeaponRotSpeedAuto; // 0x34
	[HeaderAttribute] // RVA: 0x296CD0 Offset: 0x296DD1 VA: 0x296CD0
	public float m_WeaponRotSpeedMax; // 0x38
	[RangeAttribute] // RVA: 0x296D10 Offset: 0x296E11 VA: 0x296D10
	[HeaderAttribute] // RVA: 0x296D10 Offset: 0x296E11 VA: 0x296D10
	public float m_WeaponRotStickSense; // 0x3C
	private float m_WeaponRotWaitTimeCount; // 0x40
	protected RefineShopRefineBaseRoot.ReturnEventHandler m_ReturnEventHandler; // 0x48
	protected RefineShopRefineBaseMenu m_RefineShopRefineBaseMenu; // 0x50
	protected ItemMenuDetailSetter m_ItemMenuDetailSetter; // 0x58
	protected ShopWeaponModelRenderer m_ShopWeaponModelRenderer; // 0x60
	protected Unit m_Unit; // 0x68
	protected int m_OwnerItemIndex; // 0x70

	// Methods

	// RVA: 0x2C6F260 Offset: 0x2C6F361 VA: 0x2C6F260
	public static void LoadPrefabAsync() { }

	// RVA: 0x2C6F300 Offset: 0x2C6F401 VA: 0x2C6F300
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2C6F380 Offset: 0x2C6F481 VA: 0x2C6F380
	public static void UnloadPrefab() { }

	// RVA: 0x2C6F400 Offset: 0x2C6F501 VA: 0x2C6F400
	public static RefineShopRefineBaseRoot CreateBind(ProcInst super, ShopWeaponModelRenderer shopWeaponModelRenderer, Unit defaultUnit, int defaultItemIndex, ItemData.Kinds defaultItemKind, RefineShopRefineBaseRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x2C6F5D0 Offset: 0x2C6F6D1 VA: 0x2C6F5D0 Slot: 4
	protected virtual void Create(ProcInst super, ShopWeaponModelRenderer shopWeaponModelRenderer, Unit defaultUnit, int defaultItemIndex, ItemData.Kinds defaultItemKind, RefineShopRefineBaseRoot.ReturnEventHandler returnEventHandler) { }

	// RVA: 0x2C6FAC0 Offset: 0x2C6FBC1 VA: 0x2C6FAC0 Slot: 5
	public virtual void Destroy() { }

	// RVA: 0x2C65780 Offset: 0x2C65881 VA: 0x2C65780
	protected void .ctor() { }

	// RVA: 0x2C6FBC0 Offset: 0x2C6FCC1 VA: 0x2C6FBC0
	private void Update() { }

	// RVA: 0x2C6FE50 Offset: 0x2C6FF51 VA: 0x2C6FE50
	public void OnSelectMenuItem(Unit unit, UnitItem unitItem) { }

	// RVA: 0x2C70150 Offset: 0x2C70251 VA: 0x2C70150
	public void OnDecideMenuItem(Unit unit, int ownerItemIndex, ItemData.Kinds kind) { }

	// RVA: 0x2C701D0 Offset: 0x2C702D1 VA: 0x2C701D0
	public void OnRequestCloseMenu() { }

	// RVA: 0x2C70220 Offset: 0x2C70321 VA: 0x2C70220 Slot: 6
	public virtual void Close() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C39C0 Offset: 0x2C3AC1 VA: 0x2C39C0
	// RVA: 0x2C702D0 Offset: 0x2C703D1 VA: 0x2C702D0
	private void <Update>b__23_0(float value) { }
}

