// Namespace: App
public class DamageInfo : SingletonProcInst<DamageInfo> // TypeDefIndex: 11792
{
	// Fields
	private const int InfoWindowMax = 3;
	private bool m_IsShow; // 0x72
	private GameObject m_LayoutPrefab; // 0x78
	private List<DamageInfo.Info> m_InfoList; // 0x80
	private DamageInfo.InfoWindow[] m_InfoWindowArray; // 0x88
	private BattleInfo m_BattleInfo; // 0x90
	private BattleCalculator m_BattleCalculator; // 0x98
	private Unit m_PreDefenceUnit; // 0xA0

	// Properties
	protected override string GlobalAssetPath { get; }

	// Methods

	// RVA: 0x23C5100 Offset: 0x23C5201 VA: 0x23C5100 Slot: 19
	protected override string get_GlobalAssetPath() { }

	// RVA: 0x23C5150 Offset: 0x23C5251 VA: 0x23C5150
	private void LoadLayoutPrefab() { }

	// RVA: 0x23C51B0 Offset: 0x23C52B1 VA: 0x23C51B0
	private bool IsLoadingLayoutPrefab() { }

	// RVA: 0x23C5210 Offset: 0x23C5311 VA: 0x23C5210
	public bool IsShow() { }

	// RVA: 0x23C52B0 Offset: 0x23C53B1 VA: 0x23C52B0
	private void Init() { }

	// RVA: 0x23C5620 Offset: 0x23C5721 VA: 0x23C5620 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x23C56E0 Offset: 0x23C57E1 VA: 0x23C56E0
	private void Tick() { }

	// RVA: 0x23C5760 Offset: 0x23C5861 VA: 0x23C5760
	public void CalcInfoList(Unit defenceUnit) { }

	// RVA: 0x23C5EC0 Offset: 0x23C5FC1 VA: 0x23C5EC0
	public void CalcInfoList() { }

	// RVA: 0x23C5D10 Offset: 0x23C5E11 VA: 0x23C5D10
	private int CalcDamage(Unit offenceUnit, Unit defenceUnit, SkillData engageSkill) { }

	// RVA: 0x23C5ED0 Offset: 0x23C5FD1 VA: 0x23C5ED0
	private ProcDesc[] GetProcDesc() { }

	// RVA: 0x23C61B0 Offset: 0x23C62B1 VA: 0x23C61B0
	public static void SetUnit(Unit unit) { }

	// RVA: 0x23C6280 Offset: 0x23C6381 VA: 0x23C6280
	public static void UpdateInfo() { }

	// RVA: 0x23C6340 Offset: 0x23C6441 VA: 0x23C6340
	public static void SetVisible(bool isVisible) { }

	// RVA: 0x23C63F0 Offset: 0x23C64F1 VA: 0x23C63F0
	public static void Create(ProcInst super) { }

	// RVA: 0x23C6470 Offset: 0x23C6571 VA: 0x23C6470
	public void .ctor() { }
}

