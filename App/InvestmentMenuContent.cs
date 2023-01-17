// Namespace: App
public class InvestmentMenuContent : BasicMenuContent // TypeDefIndex: 11430
{
	// Fields
	private const string PrefabPath = "UI/Hub/CafeTerrace/NoticeBoard/Prefabs/InvestmenRoot";
	[HeaderAttribute] // RVA: 0x297F70 Offset: 0x298071 VA: 0x297F70
	public TextMeshProUGUI m_nextText; // 0xE8
	public TextMeshProUGUI m_totalText; // 0xF0
	public TextMeshProUGUI m_levelBeforeTitle; // 0xF8
	public TextMeshProUGUI m_levelAfterTitle; // 0x100
	public TextMeshProUGUI m_levelEffectTitle; // 0x108
	public TextMeshProUGUI m_levelBonusTitle; // 0x110
	public TextMeshProUGUI m_battleTitle; // 0x118
	public TextMeshProUGUI m_resultTitle; // 0x120
	public TextMeshProUGUI m_completeText; // 0x128
	public TextMeshProUGUI m_completeInfoText; // 0x130
	[HeaderAttribute] // RVA: 0x297FB0 Offset: 0x2980B1 VA: 0x297FB0
	public GameObject m_nextCostRoot; // 0x138
	public GameObject m_maxCostRoot; // 0x140
	public TextMeshProUGUI m_useCost; // 0x148
	public TextMeshProUGUI m_useCostUnit; // 0x150
	public TextMeshProUGUI m_maxCostUnit; // 0x158
	public TextMeshProUGUI m_nextCost; // 0x160
	public TextMeshProUGUI m_nextCostUnit; // 0x168
	[HeaderAttribute] // RVA: 0x297FF0 Offset: 0x2980F1 VA: 0x297FF0
	public Image m_bgSymbol; // 0x170
	public TextMeshProUGUI m_currentLevel; // 0x178
	public TextMeshProUGUI m_nextLevel; // 0x180
	public TextMeshProUGUI m_bonusItem; // 0x188
	[HeaderAttribute] // RVA: 0x298030 Offset: 0x298131 VA: 0x298030
	public Image m_mapRoot; // 0x190
	public List<GameObject> m_mapPoint; // 0x198
	public List<GameObject> m_mapFrm; // 0x1A0
	public Sprite m_mapBeforeTexture; // 0x1A8
	public Sprite m_mapAfterTexture; // 0x1B0
	[HeaderAttribute] // RVA: 0x298070 Offset: 0x298171 VA: 0x298070
	public InvestmentMenuContent.BattleEnemyInfo m_goldEnemyInfo; // 0x1B8
	public InvestmentMenuContent.BattleEnemyInfo m_expEnemyInfo; // 0x1C0
	[HeaderAttribute] // RVA: 0x2980B0 Offset: 0x2981B1 VA: 0x2980B0
	public List<InvestmentMenuContent.DropItemInfo> m_dropItemInfo; // 0x1C8
	[HeaderAttribute] // RVA: 0x2980F0 Offset: 0x2981F1 VA: 0x2980F0
	public List<InvestmentMenuContent.AnimalInfo> m_animalInfo; // 0x1D0
	[HeaderAttribute] // RVA: 0x298130 Offset: 0x298231 VA: 0x298130
	public List<GameObject> m_lvMaxShowObject; // 0x1D8
	public List<GameObject> m_lvMaxHideObject; // 0x1E0
	public Sprite m_lvMaxBgTexture; // 0x1E8
	public Sprite m_normalBgTexture; // 0x1F0
	public Image m_textureChangeImage; // 0x1F8
	private int m_dispTotalCost; // 0x200
	private HubNationData m_dispNationData; // 0x208

	// Methods

	// RVA: 0x2B5AFE0 Offset: 0x2B5B0E1 VA: 0x2B5AFE0
	public void Setup() { }

	// RVA: 0x2B5B910 Offset: 0x2B5BA11 VA: 0x2B5B910 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2B5B9E0 Offset: 0x2B5BAE1 VA: 0x2B5B9E0 Slot: 32
	protected override void Update() { }

	// RVA: 0x2B5C9F0 Offset: 0x2B5CAF1 VA: 0x2B5C9F0
	public static void LoadPrefabAsync() { }

	// RVA: 0x2B5CA90 Offset: 0x2B5CB91 VA: 0x2B5CA90
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2B5CB10 Offset: 0x2B5CC11 VA: 0x2B5CB10
	public static void UnloadPrefab() { }

	// RVA: 0x2B5AED0 Offset: 0x2B5AFD1 VA: 0x2B5AED0
	public static InvestmentMenuContent Create() { }

	// RVA: 0x2B5CB90 Offset: 0x2B5CC91 VA: 0x2B5CB90
	public static void Destroy(InvestmentMenuContent content) { }

	// RVA: 0x2B5CC10 Offset: 0x2B5CD11 VA: 0x2B5CC10 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2B5CC20 Offset: 0x2B5CD21 VA: 0x2B5CC20 Slot: 21
	public override float CalcW() { }

	// RVA: 0x2B5CC90 Offset: 0x2B5CD91 VA: 0x2B5CC90 Slot: 22
	public override float CalcH() { }

	// RVA: 0x2B5B7B0 Offset: 0x2B5B8B1 VA: 0x2B5B7B0
	public void SetNationData(HubNationData data) { }

	// RVA: 0x2B5CD00 Offset: 0x2B5CE01 VA: 0x2B5CD00
	public void UpdateNationData(HubNationData data) { }

	// RVA: 0x2B5BB40 Offset: 0x2B5BC41 VA: 0x2B5BB40
	private void UpdateNationDataDisp() { }

	// RVA: 0x2B5CD40 Offset: 0x2B5CE41 VA: 0x2B5CD40
	private void SetBgSymbol(Sprite sprite) { }

	// RVA: 0x2B5CDC0 Offset: 0x2B5CEC1 VA: 0x2B5CDC0
	public void .ctor() { }
}

