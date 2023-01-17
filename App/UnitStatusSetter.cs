// Namespace: App
public class UnitStatusSetter : MonoBehaviour // TypeDefIndex: 12700
{
	// Fields
	[HeaderAttribute] // RVA: 0x29B500 Offset: 0x29B601 VA: 0x29B500
	public Image m_frameImage; // 0x18
	public Image m_wdwImage; // 0x20
	public Image m_itemImage; // 0x28
	public Image m_skillImage; // 0x30
	public Sprite[] m_frameSprites; // 0x38
	public Sprite[] m_wdwSprites; // 0x40
	public Sprite[] m_contentSprites; // 0x48
	public Sprite[] m_hpSprites; // 0x50
	public Sprite[] m_godBufSprites; // 0x58
	public Sprite[] m_hpStockSprites; // 0x60
	public Sprite[] m_arrowSprites; // 0x68
	[HeaderAttribute] // RVA: 0x29B540 Offset: 0x29B641 VA: 0x29B540
	public GameObject m_unitIcon; // 0x70
	public GameObject m_godIcon; // 0x78
	[HeaderAttribute] // RVA: 0x29B580 Offset: 0x29B681 VA: 0x29B580
	public bool m_IsRingNameShow; // 0x80
	public GameObject m_unitNameRoot; // 0x88
	public TextMeshProUGUI m_unitName; // 0x90
	public GameObject m_godNameRoot; // 0x98
	public TextMeshProUGUI m_godName; // 0xA0
	public TextMeshProUGUI m_jobName; // 0xA8
	public TextMeshProUGUI m_styleName; // 0xB0
	[HeaderAttribute] // RVA: 0x29B5C0 Offset: 0x29B6C1 VA: 0x29B5C0
	public GameObject m_godInfoRoot; // 0xB8
	public TextMeshProUGUI m_bondLevelValue; // 0xC0
	public GameObject m_bondLevelGauge; // 0xC8
	[HeaderAttribute] // RVA: 0x29B600 Offset: 0x29B701 VA: 0x29B600
	public GameObject m_enchantIcon; // 0xD0
	[HeaderAttribute] // RVA: 0x29B640 Offset: 0x29B741 VA: 0x29B640
	public GameObject m_jobRoot; // 0xD8
	public List<Image> m_efficacyIcons; // 0xE0
	public List<UnitStatusSetter.WeaponLevelSetter> m_weaponLevel; // 0xE8
	[HeaderAttribute] // RVA: 0x29B680 Offset: 0x29B781 VA: 0x29B680
	public GameObject m_itemRoot; // 0xF0
	public float m_itemHeightMin; // 0xF8
	public float m_itemHeightElement; // 0xFC
	public UnitStatusSetter.ItemSetter[] m_item; // 0x100
	[HeaderAttribute] // RVA: 0x29B6C0 Offset: 0x29B7C1 VA: 0x29B6C0
	public GameObject m_skillRoot; // 0x108
	public float m_skillHeightMin; // 0x110
	public float m_skillHeightElement; // 0x114
	public List<UnitStatusSetter.SkillSetter> m_skill; // 0x118
	[HeaderAttribute] // RVA: 0x29B700 Offset: 0x29B801 VA: 0x29B700
	public GameObject m_paramRoot; // 0x120
	public List<UnitStatusSetter.CapabilityValueParam> m_capability; // 0x128
	[HeaderAttribute] // RVA: 0x29B740 Offset: 0x29B841 VA: 0x29B740
	public UnitStatusSetter.ValueParam m_rating; // 0x130
	public UnitStatusSetter.ValueParam m_attack; // 0x138
	public UnitStatusSetter.ValueParam m_hit; // 0x140
	public UnitStatusSetter.ValueParam m_avoid; // 0x148
	public UnitStatusSetter.ValueParam m_crit; // 0x150
	public UnitStatusSetter.ValueParam m_secure; // 0x158
	[HeaderAttribute] // RVA: 0x29B780 Offset: 0x29B881 VA: 0x29B780
	public TextMeshProUGUI m_maxHp; // 0x160
	public TextMeshProUGUI m_nowHp; // 0x168
	public GameObject m_hpGauge; // 0x170
	public Image m_hpGaugeImage; // 0x178
	public Image m_hpArrow; // 0x180
	public UnitStatusSetter.ValueParam m_lv; // 0x188
	public GameObject m_expGauge; // 0x190
	public GameObject m_spRoot; // 0x198
	public TextMeshProUGUI m_spValue; // 0x1A0
	public GameObject m_hpStockRoot; // 0x1A8
	public Image[] m_hpStock; // 0x1B0
	private bool m_isInit; // 0x1B8
	private bool m_isSimpleUI; // 0x1B9
	private Unit m_prevUnit; // 0x1C0

	// Methods

	// RVA: 0x2094EF0 Offset: 0x2094FF1 VA: 0x2094EF0
	private static Color GetRingColor(UnitStatusSetter.RingType type) { }

	// RVA: 0x2094FD0 Offset: 0x20950D1 VA: 0x2094FD0
	private static Sprite GetRingSprite(UnitStatusSetter setter, UnitStatusSetter.RingType type) { }

	// RVA: 0x2095020 Offset: 0x2095121 VA: 0x2095020
	private static void SetArrowSprite(UnitStatusSetter setter, Image image, int diff) { }

	// RVA: 0x20951D0 Offset: 0x20952D1 VA: 0x20951D0
	private static void SetTextColor(TextMeshProUGUI text, int diff, bool isLimit) { }

	// RVA: 0x2095370 Offset: 0x2095471 VA: 0x2095370
	private static UnitStatusSetter.RingType GetUnitRingType(Unit unit) { }

	// RVA: 0x20947C0 Offset: 0x20948C1 VA: 0x20947C0
	public void Init() { }

	// RVA: 0x2094BF0 Offset: 0x2094CF1 VA: 0x2094BF0
	public void SetData(Unit unit, BattleInfo.Flags flags = 0) { }

	// RVA: 0x20954B0 Offset: 0x20955B1 VA: 0x20954B0
	private void SetDataImpl(Unit unit) { }

	// RVA: 0x2099B60 Offset: 0x2099C61 VA: 0x2099B60
	public void SetDataTempRing(Unit unit, GodUnit god, UnitRing ring) { }

	// RVA: 0x209A270 Offset: 0x209A371 VA: 0x209A270
	public void SetDataNoEnhance(Unit unit) { }

	// RVA: 0x209A820 Offset: 0x209A921 VA: 0x209A820
	public void SetDataClassChange(Unit before, Unit after) { }

	// RVA: 0x2096500 Offset: 0x2096601 VA: 0x2096500
	public void SetGodName(Unit unit, GodUnit god, UnitRing ring) { }

	// RVA: 0x2095D70 Offset: 0x2095E71 VA: 0x2095D70
	private void SetImageColor(Unit unit, GodUnit god) { }

	// RVA: 0x2096600 Offset: 0x2096701 VA: 0x2096600
	private void SetGodInfo(Unit unit, GodUnit god) { }

	// RVA: 0x2098790 Offset: 0x2098891 VA: 0x2098790
	private void SetItemIcons(Unit unit) { }

	// RVA: 0x2099780 Offset: 0x2099881 VA: 0x2099780
	private void SetSkill(Unit unit) { }

	// RVA: 0x2096A90 Offset: 0x2096B91 VA: 0x2096A90
	private void SetLevel(Unit unit, Unit unitNoEnhance) { }

	// RVA: 0x20969D0 Offset: 0x2096AD1 VA: 0x20969D0
	private void SetSP(Unit unit) { }

	// RVA: 0x20985F0 Offset: 0x20986F1 VA: 0x20985F0
	private void SetEfficacy(Unit unit) { }

	// RVA: 0x2098470 Offset: 0x2098571 VA: 0x2098470
	private void SetWeaponLevel(Unit baseUnit, Unit tempUnit) { }

	// RVA: 0x2096C10 Offset: 0x2096D11 VA: 0x2096C10
	private void SetBattleStatus(Unit unit, bool isGodChange) { }

	// RVA: 0x2096F60 Offset: 0x2097061 VA: 0x2096F60
	private void SetCapability(Unit unit, Unit unitNoEnhance, bool isGodChange, bool isNoEnhance) { }

	// RVA: 0x2098360 Offset: 0x2098461 VA: 0x2098360
	private void SetAttackTitle(Unit unit) { }

	// RVA: 0x209C150 Offset: 0x209C251 VA: 0x209C150
	private SkillData GetEfficacySkill(Unit unit, int iconIndex) { }

	// RVA: 0x20A2EE0 Offset: 0x20A2FE1 VA: 0x20A2EE0
	public void .ctor() { }
}

