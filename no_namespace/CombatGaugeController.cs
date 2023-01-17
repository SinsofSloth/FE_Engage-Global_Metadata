// Namespace: 
[Serializable]
public class CombatGaugeController.Value // TypeDefIndex: 7660
{
	// Fields
	public GameObject root; // 0x10
	public TextMeshProUGUI text; // 0x18

	// Methods

	// RVA: 0x1E09120 Offset: 0x1E09221 VA: 0x1E09120
	public void .ctor() { }
}

// Namespace: 
public class CombatGaugeController : MonoBehaviour // TypeDefIndex: 7661
{
	// Fields
	private static readonly string AnimeNamehIn; // 0x0
	private static readonly string AnimeNameOut; // 0x8
	private static readonly int ParamClamp; // 0x10
	[HeaderAttribute] // RVA: 0x27C000 Offset: 0x27C101 VA: 0x27C000
	[SpaceAttribute] // RVA: 0x27C000 Offset: 0x27C101 VA: 0x27C000
	public bool m_IsLeft; // 0x18
	[HeaderAttribute] // RVA: 0x27C050 Offset: 0x27C151 VA: 0x27C050
	[SpaceAttribute] // RVA: 0x27C050 Offset: 0x27C151 VA: 0x27C050
	public TextMeshProUGUI m_CharaName; // 0x20
	[HeaderAttribute] // RVA: 0x27C0A0 Offset: 0x27C1A1 VA: 0x27C0A0
	public GameObject m_ItemRoot; // 0x28
	public TextMeshProUGUI m_ItemName; // 0x30
	public GameObject m_Item; // 0x38
	[HeaderAttribute] // RVA: 0x27C0E0 Offset: 0x27C1E1 VA: 0x27C0E0
	[SpaceAttribute] // RVA: 0x27C0E0 Offset: 0x27C1E1 VA: 0x27C0E0
	public GameObject m_HpRoot; // 0x40
	public TextMeshProUGUI m_Hp; // 0x48
	public GameObject m_GaueRoot; // 0x50
	public GameObject m_GaugeHpBase; // 0x58
	public GameObject m_GaugeHpMove; // 0x60
	public GameObject m_GaugeHpNow; // 0x68
	[SpaceAttribute] // RVA: 0x27C130 Offset: 0x27C231 VA: 0x27C130
	public Color m_DamageColor; // 0x70
	public Color m_HealColor; // 0x80
	[SpaceAttribute] // RVA: 0x27C150 Offset: 0x27C251 VA: 0x27C150
	public int m_MaxHpGaugeWidth; // 0x90
	public int m_MinHpGaugeWidth; // 0x94
	public int m_HpGaugeMax; // 0x98
	public float m_HpMoveWait; // 0x9C
	public float m_HpMoveSpeed; // 0xA0
	[SpaceAttribute] // RVA: 0x27C170 Offset: 0x27C271 VA: 0x27C170
	public GameObject m_HpStockRoot; // 0xA8
	public Image[] m_HpStock; // 0xB0
	public Sprite[] m_HpStockSprites; // 0xB8
	private float m_NowHpWidth; // 0xC0
	private float m_MovingHpWidth; // 0xC4
	private float m_HpMoveWaitTimer; // 0xC8
	private bool m_IsHpMove; // 0xCC
	private float m_HpMoveScale; // 0xD0
	[SpaceAttribute] // RVA: 0x27C190 Offset: 0x27C291 VA: 0x27C190
	[HeaderAttribute] // RVA: 0x27C190 Offset: 0x27C291 VA: 0x27C190
	public GameObject m_ParamRoot; // 0xD8
	[SpaceAttribute] // RVA: 0x27C1E0 Offset: 0x27C2E1 VA: 0x27C1E0
	[HeaderAttribute] // RVA: 0x27C1E0 Offset: 0x27C2E1 VA: 0x27C1E0
	public TextMeshProUGUI m_BtlHPTitle; // 0xE0
	public TextMeshProUGUI m_BtlAtkTitle; // 0xE8
	public TextMeshProUGUI m_BtlHitTitle; // 0xF0
	public TextMeshProUGUI m_BtlCritTitle; // 0xF8
	[SpaceAttribute] // RVA: 0x27C230 Offset: 0x27C331 VA: 0x27C230
	[HeaderAttribute] // RVA: 0x27C230 Offset: 0x27C331 VA: 0x27C230
	public List<CombatGaugeController.Value> m_BtlAtk; // 0x100
	public TextMeshProUGUI m_BtlHit; // 0x108
	public TextMeshProUGUI m_BtlCrit; // 0x110
	[SpaceAttribute] // RVA: 0x27C280 Offset: 0x27C381 VA: 0x27C280
	public GameObject m_ChainRoot; // 0x118
	public TextMeshProUGUI m_ChainBtlAtk; // 0x120
	public TextMeshProUGUI m_ChainBtlHit; // 0x128
	public TextMeshProUGUI m_ChainBtlCrit; // 0x130
	[SpaceAttribute] // RVA: 0x27C2A0 Offset: 0x27C3A1 VA: 0x27C2A0
	[HeaderAttribute] // RVA: 0x27C2A0 Offset: 0x27C3A1 VA: 0x27C2A0
	public GameObject m_GodInfoRoot; // 0x138
	public TextMeshProUGUI m_GodName; // 0x140
	public GameObject[] m_EngageCount; // 0x148
	[SpaceAttribute] // RVA: 0x27C2F0 Offset: 0x27C3F1 VA: 0x27C2F0
	[HeaderAttribute] // RVA: 0x27C2F0 Offset: 0x27C3F1 VA: 0x27C2F0
	public TriggeredSkillListSetter m_TriggeredSkillListSetter; // 0x150
	public List<Image> m_BattleStartSkillList; // 0x158
	private int m_BattleStartSkillIndex; // 0x160
	[HeaderAttribute] // RVA: 0x27C340 Offset: 0x27C441 VA: 0x27C340
	public List<ForceTextureSetter> m_forceTexture; // 0x168
	public Animator m_Animator; // 0x170

	// Methods

	// RVA: 0x22C8BE0 Offset: 0x22C8CE1 VA: 0x22C8BE0
	private void Start() { }

	// RVA: 0x22C8C20 Offset: 0x22C8D21 VA: 0x22C8C20
	private void Update() { }

	// RVA: 0x22C8FE0 Offset: 0x22C90E1 VA: 0x22C8FE0
	private void SetupCommon(Force.Type forceType) { }

	// RVA: 0x22C91F0 Offset: 0x22C92F1 VA: 0x22C91F0
	private void SetupItem(UnitItem item) { }

	// RVA: 0x22C96D0 Offset: 0x22C97D1 VA: 0x22C96D0
	private void SetupParam(List<string> atkList, int hit, int crit) { }

	// RVA: 0x22C9A50 Offset: 0x22C9B51 VA: 0x22C9A50
	private void SetupBattleAtk(BattleSide.Type sideType, BattleInfo info, BattleSceneList sceneList, BattleInfoSide side) { }

	// RVA: 0x22CA240 Offset: 0x22CA341 VA: 0x22CA240
	private void SetupInterference(BattleInfoSide side) { }

	// RVA: 0x22CA4A0 Offset: 0x22CA5A1 VA: 0x22CA4A0
	private void SetupHealAtk(BattleSide.Type sideType, BattleInfo info, BattleSceneList sceneList) { }

	// RVA: 0x22CA7B0 Offset: 0x22CA8B1 VA: 0x22CA7B0
	private void HideParam() { }

	// RVA: 0x22CA830 Offset: 0x22CA931 VA: 0x22CA830
	private void SetupParamBorder() { }

	// RVA: 0x22CA100 Offset: 0x22CA201 VA: 0x22CA100
	private void SetupChainParam(string atk, int hit, int crit) { }

	// RVA: 0x22CA1C0 Offset: 0x22CA2C1 VA: 0x22CA1C0
	private void HideChainParam() { }

	// RVA: 0x22CA910 Offset: 0x22CAA11 VA: 0x22CA910
	private void ShowHp(Unit unit, int hp, int maxHp, Force.Type forceType) { }

	// RVA: 0x22CAB50 Offset: 0x22CAC51 VA: 0x22CAB50
	private void HideHp() { }

	// RVA: 0x22CA9D0 Offset: 0x22CAAD1 VA: 0x22CA9D0
	private void SetupHpGauge(int now, int max) { }

	// RVA: 0x22C8DC0 Offset: 0x22C8EC1 VA: 0x22C8DC0
	private void TrySetGaugeColor(GameObject gauge, Color color) { }

	// RVA: 0x22CAC10 Offset: 0x22CAD11 VA: 0x22CAC10
	private void TrgSetGaugeLayout(GameObject obj, float width) { }

	// RVA: 0x22C8EE0 Offset: 0x22C8FE1 VA: 0x22C8EE0
	private void TrySetGaugeWidth(GameObject gauge, float width) { }

	// RVA: 0x22CABD0 Offset: 0x22CACD1 VA: 0x22CABD0
	private float CalcHpGaugeMaxWidth(int maxHp) { }

	// RVA: 0x22CACE0 Offset: 0x22CADE1 VA: 0x22CACE0
	public void Setup(BattleSide.Type sideType, BattleCalculator calculator) { }

	// RVA: 0x22CB950 Offset: 0x22CBA51 VA: 0x22CB950
	public void UpdateValues(int hp, int maxhp, int engageCount) { }

	// RVA: 0x22CB980 Offset: 0x22CBA81 VA: 0x22CB980
	private void UpdateHp(int hp, int maxhp) { }

	// RVA: 0x22CB870 Offset: 0x22CB971 VA: 0x22CB870
	private void UpdateEngageCount(int engageCount) { }

	// RVA: 0x22CBB50 Offset: 0x22CBC51 VA: 0x22CBB50
	public bool IsMoving() { }

	// RVA: 0x22C8DB0 Offset: 0x22C8EB1 VA: 0x22C8DB0
	public void SkipGaugeAnime() { }

	// RVA: 0x22C8C00 Offset: 0x22C8D01 VA: 0x22C8C00
	public void HideSkillDisplay() { }

	// RVA: 0x22CBBA0 Offset: 0x22CBCA1 VA: 0x22CBBA0
	public void PushShowSkill(SkillData skillData) { }

	// RVA: 0x22CBD00 Offset: 0x22CBE01 VA: 0x22CBD00
	public void In() { }

	// RVA: 0x22CBF70 Offset: 0x22CC071 VA: 0x22CBF70
	public void Out(float ntime = 0) { }

	// RVA: 0x22CC100 Offset: 0x22CC201 VA: 0x22CC100
	public bool IsPlayingAnim() { }

	// RVA: 0x22CC200 Offset: 0x22CC301 VA: 0x22CC200
	public void .ctor() { }

	// RVA: 0x22CC230 Offset: 0x22CC331 VA: 0x22CC230
	private static void .cctor() { }
}

