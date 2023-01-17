// Namespace: App
public class UnitInfoParamSetter : MonoBehaviour // TypeDefIndex: 11859
{
	// Fields
	public GameObject m_SubInfo; // 0x18
	private bool m_IsSimpleUI; // 0x20
	[SpaceAttribute] // RVA: 0x2996E0 Offset: 0x2997E1 VA: 0x2996E0
	public Image m_FrameImage; // 0x28
	public Image m_WdwImage; // 0x30
	public Sprite[] m_ForceSprites; // 0x38
	public Sprite[] m_WdwSprites; // 0x40
	public Sprite[] m_GodBuffSprites; // 0x48
	public Sprite[] m_HpStockSprites; // 0x50
	[SpaceAttribute] // RVA: 0x299700 Offset: 0x299801 VA: 0x299700
	public GameObject m_UnitIcon; // 0x58
	public GameObject m_GodIcon; // 0x60
	public TextMeshProUGUI m_CharaName; // 0x68
	public TextMeshProUGUI m_JobName; // 0x70
	public TextMeshProUGUI m_BattleStyleName; // 0x78
	[SpaceAttribute] // RVA: 0x299720 Offset: 0x299821 VA: 0x299720
	public GameObject m_GodNameRoot; // 0x80
	public TextMeshProUGUI m_GodName; // 0x88
	public GameObject m_BondInfoRoot; // 0x90
	public TextMeshProUGUI m_BondLevelValue; // 0x98
	public GameObject m_BondLevelGauge; // 0xA0
	[SpaceAttribute] // RVA: 0x299740 Offset: 0x299841 VA: 0x299740
	public GameObject m_Enchant; // 0xA8
	[SpaceAttribute] // RVA: 0x299760 Offset: 0x299861 VA: 0x299760
	public TextMeshProUGUI m_Level; // 0xB0
	public Image m_GodBuffLevel; // 0xB8
	[SpaceAttribute] // RVA: 0x299780 Offset: 0x299881 VA: 0x299780
	public GameObject m_GaugeExp; // 0xC0
	[SpaceAttribute] // RVA: 0x2997A0 Offset: 0x2998A1 VA: 0x2997A0
	public TextMeshProUGUI m_MaxHp; // 0xC8
	public TextMeshProUGUI m_Hp; // 0xD0
	public Image m_GodBuffHp; // 0xD8
	public GameObject m_HpStockRoot; // 0xE0
	public Image[] m_HpStock; // 0xE8
	[SpaceAttribute] // RVA: 0x2997C0 Offset: 0x2998C1 VA: 0x2997C0
	public TextMeshProUGUI m_Move; // 0xF0
	public Image m_GodBuffMove; // 0xF8
	[HeaderAttribute] // RVA: 0x2997E0 Offset: 0x2998E1 VA: 0x2997E0
	public TextMeshProUGUI m_TitleBtlAtk; // 0x100
	public TextMeshProUGUI m_BtlAtk; // 0x108
	public Image m_GodBuffAtk; // 0x110
	[SpaceAttribute] // RVA: 0x299820 Offset: 0x299921 VA: 0x299820
	public TextMeshProUGUI m_BtlHit; // 0x118
	public Image m_GodBuffHit; // 0x120
	[SpaceAttribute] // RVA: 0x299840 Offset: 0x299941 VA: 0x299840
	public TextMeshProUGUI m_BtlSpd; // 0x128
	public Image m_GodBuffSpd; // 0x130
	[SpaceAttribute] // RVA: 0x299860 Offset: 0x299961 VA: 0x299860
	public TextMeshProUGUI m_BtlAvo; // 0x138
	public Image m_GodBuffAvo; // 0x140
	[SpaceAttribute] // RVA: 0x299880 Offset: 0x299981 VA: 0x299880
	public TextMeshProUGUI m_BtlDef; // 0x148
	public Image m_GodBuffDef; // 0x150
	[SpaceAttribute] // RVA: 0x2998A0 Offset: 0x2999A1 VA: 0x2998A0
	public TextMeshProUGUI m_BtlRes; // 0x158
	public Image m_GodBuffRes; // 0x160
	[HeaderAttribute] // RVA: 0x2998C0 Offset: 0x2999C1 VA: 0x2998C0
	public TextMeshProUGUI m_ItemName; // 0x168
	public GameObject[] m_Items; // 0x170
	public GameObject[] m_Frames; // 0x178
	[HeaderAttribute] // RVA: 0x299900 Offset: 0x299A01 VA: 0x299900
	private const int EfficacyMax = 5;
	public Image[] m_EfficacyIcons; // 0x180
	[HeaderAttribute] // RVA: 0x299940 Offset: 0x299A41 VA: 0x299940
	private const int SkillMax = 11;
	public Image[] m_SkillIcons; // 0x188
	[HeaderAttribute] // RVA: 0x299980 Offset: 0x299A81 VA: 0x299980
	public GameObject m_RelayNameRoot; // 0x190
	public TextMeshProUGUI m_RelayName; // 0x198

	// Methods

	// RVA: 0x241C800 Offset: 0x241C901 VA: 0x241C800
	private void SetTextColor(TextMeshProUGUI text, int dir, bool isLimit) { }

	// RVA: 0x241C9A0 Offset: 0x241CAA1 VA: 0x241C9A0
	private void SetGodBuff(Unit unit, Image image, int dir) { }

	// RVA: 0x241CB80 Offset: 0x241CC81 VA: 0x241CB80
	private void SetParamText(TextMeshProUGUI text, Image godBuffImage, UnitInfoParamManager.ValueType type, string exString) { }

	// RVA: 0x241CD10 Offset: 0x241CE11 VA: 0x241CD10
	private void SetParamText(TextMeshProUGUI text, Image godBuffImage, CapabilityDefinition.Type type) { }

	// RVA: 0x241DEF0 Offset: 0x241DFF1 VA: 0x241DEF0
	private void SetItemIcons(Unit unit) { }

	// RVA: 0x241F650 Offset: 0x241F751 VA: 0x241F650
	private void SetEfficacyIcons(Unit unit) { }

	// RVA: 0x2426540 Offset: 0x2426641 VA: 0x2426540
	private void SetSkillIcon(int iconNo, SkillData skill, bool isActive) { }

	// RVA: 0x24266D0 Offset: 0x24267D1 VA: 0x24266D0
	private void SetSkillIcons(Unit unit) { }

	// RVA: 0x2426810 Offset: 0x2426911 VA: 0x2426810
	private void SetUnit_Core(Unit unit, int x, int z, bool bSelectGod, GodUnit god) { }

	// RVA: 0x2427A90 Offset: 0x2427B91 VA: 0x2427A90
	public void SetUnit(Unit unit, int x, int z) { }

	// RVA: 0x2427AA0 Offset: 0x2427BA1 VA: 0x2427AA0
	public void SetUnitSelectGod(Unit unit, int x, int z, GodUnit god) { }

	// RVA: 0x241F7B0 Offset: 0x241F8B1 VA: 0x241F7B0
	public static SkillData GetEfficacySkill(Unit unit, int iconIndex) { }

	// RVA: 0x2427AB0 Offset: 0x2427BB1 VA: 0x2427AB0
	public static SkillData GetJobCategory(Unit unit, int iconIndex) { }

	// RVA: 0x2427F90 Offset: 0x2428091 VA: 0x2427F90
	public void .ctor() { }
}

