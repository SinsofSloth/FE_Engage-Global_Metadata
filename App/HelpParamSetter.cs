// Namespace: App
public class HelpParamSetter : MonoBehaviour // TypeDefIndex: 11818
{
	// Fields
	public GameObject m_CursorObj; // 0x18
	public GameObject m_WindowObj; // 0x20
	[HeaderAttribute] // RVA: 0x2992D0 Offset: 0x2993D1 VA: 0x2992D0
	[SpaceAttribute] // RVA: 0x2992D0 Offset: 0x2993D1 VA: 0x2992D0
	public GameObject m_TitleRoot; // 0x28
	public GameObject m_WeaponRoot; // 0x30
	public GameObject m_MessageRoot; // 0x38
	[HeaderAttribute] // RVA: 0x299320 Offset: 0x299421 VA: 0x299320
	public GameObject m_ItemIcon; // 0x40
	public Image m_SkillIcon; // 0x48
	[HeaderAttribute] // RVA: 0x299360 Offset: 0x299461 VA: 0x299360
	public TextMeshProUGUI m_ContentName; // 0x50
	public TextMeshProUGUI m_Endurance; // 0x58
	[HeaderAttribute] // RVA: 0x2993A0 Offset: 0x2994A1 VA: 0x2993A0
	public TextMeshProUGUI m_TitleAtk; // 0x60
	public TextMeshProUGUI m_ValueAtk; // 0x68
	public Image m_IconAtk; // 0x70
	[SpaceAttribute] // RVA: 0x2993E0 Offset: 0x2994E1 VA: 0x2993E0
	public TextMeshProUGUI m_ValueHit; // 0x78
	public Image m_IconHit; // 0x80
	[SpaceAttribute] // RVA: 0x299400 Offset: 0x299501 VA: 0x299400
	public TextMeshProUGUI m_ValueCrit; // 0x88
	public Image m_IconCrit; // 0x90
	[SpaceAttribute] // RVA: 0x299420 Offset: 0x299521 VA: 0x299420
	public TextMeshProUGUI m_ValueSpd; // 0x98
	public Image m_IconSpd; // 0xA0
	[SpaceAttribute] // RVA: 0x299440 Offset: 0x299541 VA: 0x299440
	public TextMeshProUGUI m_ValueAvo; // 0xA8
	public Image m_IconAvo; // 0xB0
	[SpaceAttribute] // RVA: 0x299460 Offset: 0x299561 VA: 0x299460
	public TextMeshProUGUI m_ValueCritAvo; // 0xB8
	public Image m_IconCritAvo; // 0xC0
	[SpaceAttribute] // RVA: 0x299480 Offset: 0x299581 VA: 0x299480
	public TextMeshProUGUI m_TitleRange; // 0xC8
	public TextMeshProUGUI m_ValueRange; // 0xD0
	[SpaceAttribute] // RVA: 0x2994A0 Offset: 0x2995A1 VA: 0x2994A0
	public TextMeshProUGUI m_EfficacyNothing; // 0xD8
	public Image[] m_EfficacyIcons; // 0xE0
	[SpaceAttribute] // RVA: 0x2994C0 Offset: 0x2995C1 VA: 0x2994C0
	public TextMeshProUGUI m_TitleWeaponLevel; // 0xE8
	public TextMeshProUGUI m_ValueWeaponLevel; // 0xF0
	public Image m_IconWeaponLevel; // 0xF8
	[HeaderAttribute] // RVA: 0x2994E0 Offset: 0x2995E1 VA: 0x2994E0
	public TextMeshProUGUI m_ContentsText; // 0x100
	public TextMeshProUGUI m_ContentsEngWep; // 0x108
	public TextMeshProUGUI m_ContentsEnchant; // 0x110
	public TextMeshProUGUI m_ContentsSubText; // 0x118
	private Vector2 m_PrevPosition; // 0x120
	private Vector2 m_PrevSize; // 0x128
	private Vector2 m_NextPosition; // 0x130
	private Vector2 m_NextSize; // 0x138
	private float m_CursorMoveTimer; // 0x140
	private Vector2 m_DefaultWindowPos; // 0x144
	private Vector2 m_PrevWindowPos; // 0x14C
	private Vector2 m_NextWindowPos; // 0x154
	private Vector2 m_PrevWindowPivot; // 0x15C
	private Vector2 m_NextWindowPivot; // 0x164
	private Vector2 m_PrevWindowAnchor; // 0x16C
	private Vector2 m_NextWindowAnchor; // 0x174
	[HeaderAttribute] // RVA: 0x299520 Offset: 0x299621 VA: 0x299520
	public float m_CursorMoveTime; // 0x17C
	private BattleInfo m_BattleInfo; // 0x180
	private BattleInfo m_TmpBattleInfo; // 0x188
	private Unit m_TmpCalcUnit; // 0x190
	private int[] m_enhancedValue; // 0x198
	private string[] m_enhancedTitle; // 0x1A0
	private bool m_isGodChange; // 0x1A8
	private bool m_isRingChange; // 0x1A9
	private GodUnit m_ringSelectGod; // 0x1B0
	private UnitRing m_ringSelectCommon; // 0x1B8
	private static readonly string[] WeaponKindMidTable; // 0x0
	private static readonly string WeaponKindMidBullet; // 0x8

	// Methods

	// RVA: 0x265A680 Offset: 0x265A781 VA: 0x265A680
	public void SetRingSelectGod(bool isTempGod, GodUnit god) { }

	// RVA: 0x265A6A0 Offset: 0x265A7A1 VA: 0x265A6A0
	public void SetRingSelectCommon(bool isTempRing, UnitRing ring) { }

	// RVA: 0x265A6C0 Offset: 0x265A7C1 VA: 0x265A6C0
	public void MoveImmediate() { }

	// RVA: 0x265A9D0 Offset: 0x265AAD1 VA: 0x265A9D0
	private void UpdateLangage() { }

	// RVA: 0x265ADD0 Offset: 0x265AED1 VA: 0x265ADD0
	private void Awake() { }

	// RVA: 0x265AE90 Offset: 0x265AF91 VA: 0x265AE90
	private void OnDestroy() { }

	// RVA: 0x265AF50 Offset: 0x265B051 VA: 0x265AF50
	private void Start() { }

	// RVA: 0x265AFE0 Offset: 0x265B0E1 VA: 0x265AFE0
	private void Update() { }

	// RVA: 0x265ACD0 Offset: 0x265ADD1 VA: 0x265ACD0
	private void SetItemFixedText() { }

	// RVA: 0x265B030 Offset: 0x265B131 VA: 0x265B030
	private void TrySetUpDownIcon(Image icon, TextMeshProUGUI text, int before, int now) { }

	// RVA: 0x265B2A0 Offset: 0x265B3A1 VA: 0x265B2A0
	private void MoveCursor(GameObject frame) { }

	// RVA: 0x265A6D0 Offset: 0x265A7D1 VA: 0x265A6D0
	private void UpdateCursorPosition() { }

	// RVA: 0x265B750 Offset: 0x265B851 VA: 0x265B750
	private Vector2 CurveDecel(Vector2 prev, Vector2 next, float now, float term = 1, int num = 3) { }

	// RVA: 0x265B790 Offset: 0x265B891 VA: 0x265B790
	private string GetHelpText(string help) { }

	// RVA: 0x265B830 Offset: 0x265B931 VA: 0x265B830
	public void SetPerson(GameObject frame, Unit unit) { }

	// RVA: 0x265BB70 Offset: 0x265BC71 VA: 0x265BB70
	private bool IsVeyreForNetwork(Unit unit) { }

	// RVA: 0x265BC50 Offset: 0x265BD51 VA: 0x265BC50
	public void SetJob(GameObject frame, JobData job) { }

	// RVA: 0x265BD00 Offset: 0x265BE01 VA: 0x265BD00
	public void SetBattleStyle(GameObject frame, BattleStyle.Types style) { }

	// RVA: 0x265BE10 Offset: 0x265BF11 VA: 0x265BE10
	public void SetEfficacy(GameObject frame, SkillData skill) { }

	// RVA: 0x265BEC0 Offset: 0x265BFC1 VA: 0x265BEC0
	public void SetItemData(GameObject frame, ItemData data, Unit unit, GodUnit god, UnitRing ring, int endurance = -1, UnitItem item, bool isUseEnchant = False) { }

	// RVA: 0x26610D0 Offset: 0x26611D1 VA: 0x26610D0
	private void SetRangeText(int rI, int rO) { }

	// RVA: 0x2661360 Offset: 0x2661461 VA: 0x2661360
	public void SetUnitItem(GameObject frame, UnitItem item, Unit unit, GodUnit god, UnitRing ring, bool isUseEnchant = False) { }

	// RVA: 0x2661400 Offset: 0x2661501 VA: 0x2661400
	public void SetSkill(GameObject frame, SkillData skill, bool bEngage, GodUnit god) { }

	// RVA: 0x2661930 Offset: 0x2661A31 VA: 0x2661930
	public void SetCapability(GameObject frame, Unit unit, CapabilityDefinition.Type type) { }

	// RVA: 0x2661A00 Offset: 0x2661B01 VA: 0x2661A00
	public void SetBattleInfo(GameObject frame, Unit unit, UnitInfoParamManager.ValueType type, string text) { }

	// RVA: 0x2662DA0 Offset: 0x2662EA1 VA: 0x2662DA0
	private string AddEnhancedString(string infoText, string title, int value) { }

	// RVA: 0x2663000 Offset: 0x2663101 VA: 0x2663000
	public void SetGod(GameObject frame, Unit unit, GodUnit tempGod) { }

	// RVA: 0x26630E0 Offset: 0x26631E1 VA: 0x26630E0
	public void SetGod(GameObject frame, GodData godData) { }

	// RVA: 0x26632B0 Offset: 0x26633B1 VA: 0x26632B0
	public void SetWeaponLevel(GameObject frame, ItemData.Kinds itemKind, JobData jobData) { }

	// RVA: 0x2663500 Offset: 0x2663601 VA: 0x2663500
	public void SetEnchantment(GameObject frame, Unit unit) { }

	// RVA: 0x265BA80 Offset: 0x265BB81 VA: 0x265BA80
	public void SetFixedText(GameObject frame, string text) { }

	// RVA: 0x2663510 Offset: 0x2663611 VA: 0x2663510
	public void .ctor() { }

	// RVA: 0x26635C0 Offset: 0x26636C1 VA: 0x26635C0
	private static void .cctor() { }
}

