// Namespace: App
public class RefineShopEngraveDemoRoot : MonoBehaviour // TypeDefIndex: 11101
{
	// Fields
	private const string PrefabPath = "UI/Hub/Telop/RefineEmblem/Prefabs/RefineEmblemRoot";
	public GameObject m_WeaponModelObject; // 0x18
	public GameObject m_GodSymbolFront; // 0x20
	public GameObject m_GodSymbolBack; // 0x28
	public GameObject m_GodSymbolEff; // 0x30
	public GameObject m_EffLight; // 0x38
	[HeaderAttribute] // RVA: 0x2967B0 Offset: 0x2968B1 VA: 0x2967B0
	public GameObject m_WeaponIconFrameBefore; // 0x40
	public TextMeshProUGUI m_WeaponNameTextBefore; // 0x48
	[HeaderAttribute] // RVA: 0x2967F0 Offset: 0x2968F1 VA: 0x2967F0
	public GameObject m_WeaponIconFrameAfter; // 0x50
	public TextMeshProUGUI m_WeaponNameTextAfter; // 0x58
	private RefineShopEngraveDemo m_RefineShopEngraveDemo; // 0x60
	private ShopWeaponModelRenderer m_ShopWeaponModelRenderer; // 0x68
	private Animator m_Animator; // 0x70
	private UnitItem m_UnitItem; // 0x78
	private Material m_Material; // 0x80

	// Methods

	// RVA: 0x2C5F440 Offset: 0x2C5F541 VA: 0x2C5F440
	public static void LoadPrefabAsync() { }

	// RVA: 0x2C5F560 Offset: 0x2C5F661 VA: 0x2C5F560
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2C60DD0 Offset: 0x2C60ED1 VA: 0x2C60DD0
	public static void UnloadPrefab() { }

	// RVA: 0x2C5F690 Offset: 0x2C5F791 VA: 0x2C5F690
	public static RefineShopEngraveDemoRoot Create(RefineShopEngraveDemo refineShopEngraveDemo, ShopWeaponModelRenderer shopWeaponModelRenderer, UnitItem baseUnitItem) { }

	// RVA: 0x2C60E50 Offset: 0x2C60F51 VA: 0x2C60E50
	private void CreateInside(RefineShopEngraveDemo refineShopEngraveDemo, ShopWeaponModelRenderer shopWeaponModelRenderer, UnitItem baseUnitItem) { }

	// RVA: 0x2C5F810 Offset: 0x2C5F911 VA: 0x2C5F810
	public void Build() { }

	// RVA: 0x2C60A00 Offset: 0x2C60B01 VA: 0x2C60A00
	public bool IsPlaying() { }

	// RVA: 0x2C61010 Offset: 0x2C61111 VA: 0x2C61010
	public bool IsDestroyed() { }

	// RVA: 0x2C60BB0 Offset: 0x2C60CB1 VA: 0x2C60BB0
	public void Destroy() { }

	// RVA: 0x2C61090 Offset: 0x2C61191 VA: 0x2C61090
	public void .ctor() { }
}

