// Namespace: App
public class RefineGodWeaponRoot : MonoBehaviour // TypeDefIndex: 11064
{
	// Fields
	private const string PrefabPath = "UI/Hub/GodRoom/Prefabs/RefineGodWeaponRoot";
	public RefineGodWeaponSelectMenuContent m_RefineGodWeaponSelectMenuContent; // 0x18
	public RefineGodWeaponParamMenuContent m_RefineGodWeaponParamMenuContent; // 0x20
	public GameObject m_ItemHelpObject; // 0x28
	public ItemMenuDetailSetter m_ItemMenuDetailSetter; // 0x30
	[HeaderAttribute] // RVA: 0x296400 Offset: 0x296501 VA: 0x296400
	public Image m_WeaponImage; // 0x38
	public RefineGodWeaponRoot.WeaponInfoLabel m_WeaponInfoLabel; // 0x40
	[HeaderAttribute] // RVA: 0x296440 Offset: 0x296541 VA: 0x296440
	public TextMeshProUGUI m_RefineStatusTitleText; // 0x48
	public RefineGodWeaponRoot.RefineStatus[] m_RefineStatus; // 0x50
	public GameObject m_RefineStatusEfficacyParent; // 0x58
	public RefineGodWeaponRoot.RefineStatusEfficacy[] m_RefineStatusEfficacy; // 0x60
	[HeaderAttribute] // RVA: 0x296480 Offset: 0x296581 VA: 0x296480
	public float m_WeaponRotWaitTime; // 0x68
	[HeaderAttribute] // RVA: 0x2964C0 Offset: 0x2965C1 VA: 0x2964C0
	public float m_WeaponRotSpeedAuto; // 0x6C
	[HeaderAttribute] // RVA: 0x296500 Offset: 0x296601 VA: 0x296500
	public float m_WeaponRotSpeedMax; // 0x70
	[RangeAttribute] // RVA: 0x296540 Offset: 0x296641 VA: 0x296540
	[HeaderAttribute] // RVA: 0x296540 Offset: 0x296641 VA: 0x296540
	public float m_WeaponRotStickSense; // 0x74
	private float m_WeaponRotWaitTimeCount; // 0x78
	private static readonly string[] m_RefineStatusEfficacyCaptionMid; // 0x0
	private ShopWeaponModelRenderer m_WeaponModelRenderer; // 0x80
	private UnitItem m_UnitItemBase; // 0x88

	// Methods

	// RVA: 0x27786D0 Offset: 0x27787D1 VA: 0x27786D0
	public static void LoadPrefabAsync() { }

	// RVA: 0x2778770 Offset: 0x2778871 VA: 0x2778770
	public static bool IsLoadingPrefab() { }

	// RVA: 0x27787F0 Offset: 0x27788F1 VA: 0x27787F0
	public static void UnloadPrefab() { }

	// RVA: 0x2778870 Offset: 0x2778971 VA: 0x2778870
	public static RefineGodWeaponRoot CreateRoot(ShopWeaponModelRenderer weaponModelRenderer) { }

	// RVA: 0x2778A00 Offset: 0x2778B01 VA: 0x2778A00
	private void Create(ShopWeaponModelRenderer weaponModelRenderer) { }

	// RVA: 0x2778FA0 Offset: 0x27790A1 VA: 0x2778FA0
	public void Destroy() { }

	// RVA: 0x2779040 Offset: 0x2779141 VA: 0x2779040
	private void .ctor() { }

	// RVA: 0x27790C0 Offset: 0x27791C1 VA: 0x27790C0
	private void Update() { }

	// RVA: 0x2779350 Offset: 0x2779451 VA: 0x2779350
	public RefineGodWeaponSelectMenuContent GetRefineGodWeaponSelectMenuContent() { }

	// RVA: 0x2774940 Offset: 0x2774A41 VA: 0x2774940
	public RefineGodWeaponParamMenuContent GetRefineGodWeaponParamMenuContent() { }

	// RVA: 0x2779360 Offset: 0x2779461 VA: 0x2779360
	public void OnSelect(GodUnit godUnit, ItemData itemData) { }

	// RVA: 0x2774E20 Offset: 0x2774F21 VA: 0x2774E20
	public void OnSelectForParamMenu(GodUnit godUnit, ItemData itemData, GodWeaponRefineData.Kind kind, bool refineOrReset) { }

	// RVA: 0x2774CE0 Offset: 0x2774DE1 VA: 0x2774CE0
	public void SetNaviHelp(string mid) { }

	// RVA: 0x27793D0 Offset: 0x27794D1 VA: 0x27793D0
	public void UpdateItemDetail(GodUnit godUnit, ItemData itemData) { }

	// RVA: 0x277A6A0 Offset: 0x277A7A1 VA: 0x277A6A0
	public void UpdateItemDetail(GodUnit godUnit, ItemData itemData, GodWeaponRefineData.Kind refineDataKind, bool refineOrReset) { }

	// RVA: 0x2779580 Offset: 0x2779681 VA: 0x2779580
	public void UpdateWeaponModel(GodUnit godUnit, ItemData itemData) { }

	// RVA: 0x27796D0 Offset: 0x27797D1 VA: 0x27796D0
	public void UpdateWeaponLabel(GodUnit godUnit, ItemData itemData) { }

	// RVA: 0x2779AC0 Offset: 0x2779BC1 VA: 0x2779AC0
	public void UpdateRefineStatus(GodUnit godUnit, ItemData itemData, GodWeaponRefineData.Kind kind, bool showAfter, bool refineOrReset) { }

	// RVA: 0x277A990 Offset: 0x277AA91 VA: 0x277A990
	public void Close() { }

	// RVA: 0x277AA30 Offset: 0x277AB31 VA: 0x277AA30
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3310 Offset: 0x2C3411 VA: 0x2C3310
	// RVA: 0x277AB70 Offset: 0x277AC71 VA: 0x277AB70
	private void <Update>b__29_0(float value) { }
}

