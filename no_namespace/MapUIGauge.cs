// Namespace: 
public enum MapUIGauge.SuppressType // TypeDefIndex: 7646
{
	// Fields
	public int value__; // 0x0
	public const MapUIGauge.SuppressType BreakIconFlashing = 1;
}

// Namespace: 
public class MapUIGauge : SingletonMonoBehaviour<MapUIGauge> // TypeDefIndex: 7648
{
	// Fields
	private static readonly string[] IconNames; // 0x0
	[SpaceAttribute] // RVA: 0x27BBE0 Offset: 0x27BCE1 VA: 0x27BBE0
	[HeaderAttribute] // RVA: 0x27BBE0 Offset: 0x27BCE1 VA: 0x27BBE0
	[SerializeField] // RVA: 0x27BBE0 Offset: 0x27BCE1 VA: 0x27BBE0
	private AnimationCurve m_AlphaCurve; // 0x20
	[SerializeField] // RVA: 0x27BC40 Offset: 0x27BD41 VA: 0x27BC40
	private AnimationCurve m_ShineCurve; // 0x28
	[SpaceAttribute] // RVA: 0x27BC50 Offset: 0x27BD51 VA: 0x27BC50
	[SerializeField] // RVA: 0x27BC50 Offset: 0x27BD51 VA: 0x27BC50
	private AnimationCurve m_CanBreakCurve; // 0x30
	[SerializeField] // RVA: 0x27BC90 Offset: 0x27BD91 VA: 0x27BC90
	[SpaceAttribute] // RVA: 0x27BC90 Offset: 0x27BD91 VA: 0x27BC90
	private AnimationCurve m_CountMaxScaleCurve; // 0x38
	[SerializeField] // RVA: 0x27BCD0 Offset: 0x27BDD1 VA: 0x27BCD0
	private AnimationCurve m_CountMaxAlphaCurve; // 0x40
	[SpaceAttribute] // RVA: 0x27BCE0 Offset: 0x27BDE1 VA: 0x27BCE0
	[HeaderAttribute] // RVA: 0x27BCE0 Offset: 0x27BDE1 VA: 0x27BCE0
	[SerializeField] // RVA: 0x27BCE0 Offset: 0x27BDE1 VA: 0x27BCE0
	private SpriteAtlas m_SpriteAtlas; // 0x48
	[SpaceAttribute] // RVA: 0x27BD40 Offset: 0x27BE41 VA: 0x27BD40
	[HeaderAttribute] // RVA: 0x27BD40 Offset: 0x27BE41 VA: 0x27BD40
	[SerializeField] // RVA: 0x27BD40 Offset: 0x27BE41 VA: 0x27BD40
	private int m_WaitFrameForAfterEvent; // 0x50
	private Sprite[] m_Sprites; // 0x58
	private Dictionary<string, Sprite> m_Dictionary; // 0x60
	private float m_Time; // 0x68
	private float m_WaitFrame; // 0x6C
	private bool m_IsVisible; // 0x70
	private MapUIGauge.SuppressType m_SuppressFlag; // 0x74
	private bool m_IsExec; // 0x78
	private bool m_IsCalc; // 0x79
	private bool m_IsForceQuit; // 0x7A
	private bool m_NeedsForecastOneself; // 0x7B
	private BattleInfo m_BattleInfo; // 0x80
	private BattleCalculator m_BattleCalc; // 0x88
	private Unit m_Performer; // 0x90
	private Unit m_ReserveUnit; // 0x98
	private int m_PerformerHpDiff; // 0xA0
	private bool m_IsDoomed; // 0xA4
	private MapMind.Type m_Mind; // 0xA8
	private SkillData m_CommandSkill; // 0xB0
	private int m_HpAfterBattle; // 0xB8
	private List<Unit> m_TargetList; // 0xC0
	private List<Unit> m_InfluencerList; // 0xC8
	private List<Unit> m_TempList; // 0xD0
	private List<Unit> m_InitList; // 0xD8
	private int m_TargetIndex; // 0xE0
	private bool m_IsPriorWeaponRange; // 0xE4
	private MapImageCoreSbyte m_MoveImage; // 0xE8
	private MapImageCoreBit m_AttackImage; // 0xF0
	private MapImageCoreBit m_HealImage; // 0xF8
	private MapImageCoreBit m_RangeImage; // 0x100
	private MapImageCoreBit m_CannonImage; // 0x108

	// Properties
	public Sprite[] Sprites { get; }
	public float Time { get; }
	public float WaitFrame { get; }
	public float WaitFrameForAfterEvent { get; }
	public bool IsVisible { get; }
	public MapUIGauge.SuppressType SuppressFlag { get; set; }
	public AnimationCurve AlphaCurve { get; }
	public AnimationCurve ShineCurve { get; }
	public AnimationCurve CanBreakCurve { get; }
	public AnimationCurve CountMaxScaleCurve { get; }
	public AnimationCurve CountMaxAlphaCurve { get; }

	// Methods

	// RVA: 0x27557F0 Offset: 0x27558F1 VA: 0x27557F0
	private void Start() { }

	// RVA: 0x27559C0 Offset: 0x2755AC1 VA: 0x27559C0
	private void Update() { }

	// RVA: 0x2755BE0 Offset: 0x2755CE1 VA: 0x2755BE0
	private void OnEnable() { }

	// RVA: 0x2755D80 Offset: 0x2755E81 VA: 0x2755D80
	private void OnDisable() { }

	// RVA: 0x2755E80 Offset: 0x2755F81 VA: 0x2755E80
	private void RegisterSprites(SpriteAtlas spriteAtlas) { }

	// RVA: 0x2755FE0 Offset: 0x27560E1 VA: 0x2755FE0
	public Sprite GetSprite(int index) { }

	// RVA: 0x2756040 Offset: 0x2756141 VA: 0x2756040
	public Sprite GetSprite(string name) { }

	// RVA: 0x27560E0 Offset: 0x27561E1 VA: 0x27560E0
	public MapUIGauge.IconIndex GetIconIndex(string name) { }

	// RVA: 0x2755B00 Offset: 0x2755C01 VA: 0x2755B00
	private void UpdateVisible() { }

	// RVA: 0x2756180 Offset: 0x2756281 VA: 0x2756180
	public bool IsEnableSuppressFlag(MapUIGauge.SuppressType suppressFlag) { }

	// RVA: 0x2756190 Offset: 0x2756291 VA: 0x2756190
	public void InitHpForecast(bool isAll = False) { }

	// RVA: 0x2756540 Offset: 0x2756641 VA: 0x2756540
	public void SetHpForecast(Unit unit, bool needsForecastOneself = False, bool isPriorWeaponRange = False) { }

	// RVA: 0x2755BC0 Offset: 0x2755CC1 VA: 0x2755BC0
	public void UpdateHpForecast() { }

	// RVA: 0x2756590 Offset: 0x2756691 VA: 0x2756590
	public void PrepareHpForecastTarget() { }

	// RVA: 0x2757DB0 Offset: 0x2757EB1 VA: 0x2757DB0
	private bool CanUseItemForHealForecast(ItemData itemData) { }

	// RVA: 0x2756D10 Offset: 0x2756E11 VA: 0x2756D10
	private void GetImage(Unit performer) { }

	// RVA: 0x2757190 Offset: 0x2757291 VA: 0x2757190
	private bool IsUnitTargetForDamageForecast(Unit target) { }

	// RVA: 0x2759210 Offset: 0x2759311 VA: 0x2759210
	private bool CanAttack(Unit attacker, Unit target) { }

	// RVA: 0x27589F0 Offset: 0x2758AF1 VA: 0x27589F0
	private bool IsUnitTargetForHealForecast(Unit target) { }

	// RVA: 0x2757BB0 Offset: 0x2757CB1 VA: 0x2757BB0
	private bool IsUnitInfluencerForDamageForecast(Unit unit) { }

	// RVA: 0x2758CF0 Offset: 0x2758DF1 VA: 0x2758CF0
	private bool IsUnitInfluencerForHealForecast(Unit unit) { }

	[IteratorStateMachineAttribute] // RVA: 0x2A6610 Offset: 0x2A6711 VA: 0x2A6610
	// RVA: 0x275A460 Offset: 0x275A561 VA: 0x275A460
	public IEnumerator CalcHpForecast() { }

	// RVA: 0x275A450 Offset: 0x275A551 VA: 0x275A450
	private SkillData GetBreathSkill(Unit target, UnitItem unitItem) { }

	// RVA: 0x275A4E0 Offset: 0x275A5E1 VA: 0x275A4E0
	private void CalcBattleInfoForBreath(Unit target, UnitItem unitItem, SkillData breathSkill) { }

	// RVA: 0x275B330 Offset: 0x275B431 VA: 0x275B330
	private void CalcBattleInfoForEngageWait(Unit target) { }

	// RVA: 0x275B940 Offset: 0x275BA41 VA: 0x275B940
	private void CalcBattleInfoForHealItem(Unit target, UnitItem unitItem) { }

	// RVA: 0x275BD30 Offset: 0x275BE31 VA: 0x275BD30
	private void CalcBattleInfoForNormal(Unit target, UnitItem unitItem) { }

	// RVA: 0x275C640 Offset: 0x275C741 VA: 0x275C640
	private bool IsHealItemUsed(Unit unit, UnitItem unitItem) { }

	// RVA: 0x275B980 Offset: 0x275BA81 VA: 0x275B980
	private void CalcHpHealItem(Unit unit, UnitItem unitItem, out int beforeHp, out int afterHp) { }

	// RVA: 0x275AAD0 Offset: 0x275ABD1 VA: 0x275AAD0
	private BattleInfo.Flags GetBattleInfoFlag(Unit performer, Unit target) { }

	// RVA: 0x275C510 Offset: 0x275C611 VA: 0x275C510
	private void StackHpDiff(int hpBeforeBattle, int hpAfterBattle) { }

	// RVA: 0x2756EE0 Offset: 0x2756FE1 VA: 0x2756EE0
	private UnitItem GetItem(Unit target) { }

	// RVA: 0x275C6E0 Offset: 0x275C7E1 VA: 0x275C6E0
	public Sprite[] get_Sprites() { }

	// RVA: 0x275C6F0 Offset: 0x275C7F1 VA: 0x275C6F0
	public float get_Time() { }

	// RVA: 0x275C700 Offset: 0x275C801 VA: 0x275C700
	public float get_WaitFrame() { }

	// RVA: 0x275C710 Offset: 0x275C811 VA: 0x275C710
	public float get_WaitFrameForAfterEvent() { }

	// RVA: 0x275C720 Offset: 0x275C821 VA: 0x275C720
	public bool get_IsVisible() { }

	// RVA: 0x275C730 Offset: 0x275C831 VA: 0x275C730
	public MapUIGauge.SuppressType get_SuppressFlag() { }

	// RVA: 0x275C740 Offset: 0x275C841 VA: 0x275C740
	public void set_SuppressFlag(MapUIGauge.SuppressType value) { }

	// RVA: 0x275C750 Offset: 0x275C851 VA: 0x275C750
	public AnimationCurve get_AlphaCurve() { }

	// RVA: 0x275C760 Offset: 0x275C861 VA: 0x275C760
	public AnimationCurve get_ShineCurve() { }

	// RVA: 0x275C770 Offset: 0x275C871 VA: 0x275C770
	public AnimationCurve get_CanBreakCurve() { }

	// RVA: 0x275C780 Offset: 0x275C881 VA: 0x275C780
	public AnimationCurve get_CountMaxScaleCurve() { }

	// RVA: 0x275C790 Offset: 0x275C891 VA: 0x275C790
	public AnimationCurve get_CountMaxAlphaCurve() { }

	// RVA: 0x275C7A0 Offset: 0x275C8A1 VA: 0x275C7A0
	public void .ctor() { }

	// RVA: 0x275CA40 Offset: 0x275CB41 VA: 0x275CA40
	private static void .cctor() { }
}

