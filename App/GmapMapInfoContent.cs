// Namespace: App
public class GmapMapInfoContent : MonoBehaviour // TypeDefIndex: 10273
{
	// Fields
	private const string PrefabPath = "UI/Gmap/Prefabs/GmapInfoRoot";
	private const string SpriteAtlasPath = "UI/Gmap/InfoThumb/InfoThumb";
	private SpriteAtlas m_SpriteAtlas; // 0x18
	public Animator m_MapInfoAnim; // 0x20
	public Image m_MapInfoImage; // 0x28
	public GameObject m_MapInfoChapterObj; // 0x30
	public TextMeshProUGUI m_MapInfoTitle; // 0x38
	public GameObject m_MapInfoIconExpObj; // 0x40
	public GameObject m_MapInfoIconCoinObj; // 0x48
	public GameObject m_MapInfoIconEncountObj; // 0x50
	public GameObject m_MapInfoMessageRootObj; // 0x58
	public GameObject m_MapInfoMessageStoryObj; // 0x60
	public GameObject m_MapInfoMessageEncountObj; // 0x68
	public GameObject m_MapInfoLvRootObj; // 0x70
	public GameObject m_MapInfoLvObj; // 0x78
	public TextMeshProUGUI m_MapInfoCountryName; // 0x80
	public TextMeshProUGUI m_MapInfoCountryLv; // 0x88
	public List<GameObject> m_ItemMaterialList; // 0x90
	public List<GameObject> m_ItemFoodList; // 0x98
	public List<GameObject> m_ItemAnimalList; // 0xA0
	private List<GmapMapInfoContent.ItemInfo> m_ItemInfoMaterialList; // 0xA8
	private List<GmapMapInfoContent.ItemInfo> m_ItemInfoFoodList; // 0xB0
	private List<GmapMapInfoContent.ItemInfo> m_ItemInfoAnimalList; // 0xB8
	private Sprite m_MapInfoSprite; // 0xC0
	public GameObject m_EncountInfo; // 0xC8
	public Animator m_EncountInfoAnim; // 0xD0
	public GameObject m_MainTitle; // 0xD8
	public GameObject m_GodTitle; // 0xE0
	public GameObject m_EvilTitle; // 0xE8
	public GameObject m_MainValue; // 0xF0
	public GameObject m_GodValue; // 0xF8
	public GameObject m_EvilValue; // 0x100
	public TextMeshProUGUI m_MainNormal; // 0x108
	public TextMeshProUGUI m_MainGoldRare; // 0x110
	public TextMeshProUGUI m_MainExpRare; // 0x118
	public TextMeshProUGUI m_GodNormal; // 0x120
	public TextMeshProUGUI m_GodGoldRare; // 0x128
	public TextMeshProUGUI m_GodExpRare; // 0x130
	public TextMeshProUGUI m_EvilNormal; // 0x138
	public TextMeshProUGUI m_EvilGoldRare; // 0x140
	public TextMeshProUGUI m_EvilExpRare; // 0x148

	// Methods

	// RVA: 0x28E8D70 Offset: 0x28E8E71 VA: 0x28E8D70
	public static void LoadPrefabAsync() { }

	// RVA: 0x28E8E50 Offset: 0x28E8F51 VA: 0x28E8E50
	public static bool IsLoadingPrefab() { }

	// RVA: 0x28E8F20 Offset: 0x28E9021 VA: 0x28E8F20
	public static void UnloadPrefab() { }

	// RVA: 0x28E8FC0 Offset: 0x28E90C1 VA: 0x28E8FC0
	public static GmapMapInfoContent Create() { }

	// RVA: 0x28E94F0 Offset: 0x28E95F1 VA: 0x28E94F0
	public static void Destroy(GmapMapInfoContent content) { }

	// RVA: 0x28E90E0 Offset: 0x28E91E1 VA: 0x28E90E0
	private void initialize() { }

	// RVA: 0x28E9580 Offset: 0x28E9681 VA: 0x28E9580
	public void OpenMapMini() { }

	// RVA: 0x28E97D0 Offset: 0x28E98D1 VA: 0x28E97D0
	public void OpenMapDetails() { }

	// RVA: 0x28E9A30 Offset: 0x28E9B31 VA: 0x28E9A30
	public void Close() { }

	// RVA: 0x28E9AA0 Offset: 0x28E9BA1 VA: 0x28E9AA0
	public void SetUpEncountInfo() { }

	// RVA: 0x28E9700 Offset: 0x28E9801 VA: 0x28E9700
	public void OpenEncountInfo() { }

	// RVA: 0x28E9960 Offset: 0x28E9A61 VA: 0x28E9960
	public void CloseEncountInfo() { }

	// RVA: 0x28EA240 Offset: 0x28EA341 VA: 0x28EA240
	public void SetMapInfo(GmapSpot gmapSpot) { }

	// RVA: 0x28EB170 Offset: 0x28EB271 VA: 0x28EB170
	private void SetItem(string prefixlessCid, HubNationData nationData, bool iscomplete, bool isUnknown) { }

	// RVA: 0x28EC5A0 Offset: 0x28EC6A1 VA: 0x28EC5A0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD8B0 Offset: 0x2BD9B1 VA: 0x2BD8B0
	// RVA: 0x28EC680 Offset: 0x28EC781 VA: 0x28EC680
	private void <SetMapInfo>b__53_0(int level) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD8C0 Offset: 0x2BD9C1 VA: 0x2BD8C0
	// RVA: 0x28EC930 Offset: 0x28ECA31 VA: 0x28EC930
	private void <SetMapInfo>b__53_1(int turn) { }
}

