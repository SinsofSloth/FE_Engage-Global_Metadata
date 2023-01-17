// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x278DF0 Offset: 0x278EF1 VA: 0x278DF0
public class Unit // TypeDefIndex: 13496
{
	// Fields
	public const int ItemMax = 8;
	public const int ExpMax = 100;
	public const int EnhanceMoveMax = 2;
	public const int StunMax = 100;
	public const int EquipSkillMax = 2;
	public const int InternalLevelMin = -100;
	public const int InternalLevelMax = 100;
	public const int SkillPointMax = 9999;
	public const int CellCountMax = 25;
	private const int LevelUpRetryMax = 4;
	private static readonly GodState[] DefaultGodStates; // 0x0
	private const int Version = 40;
	private Unit.StatusField m_Status; // 0x10
	private Unit m_Prev; // 0x18
	private Unit m_Next; // 0x20
	private UnitAI m_Ai; // 0x28
	private UnitEdit m_Edit; // 0x30
	private int m_Ident; // 0x38
	private PersonData m_Person; // 0x40
	private JobData m_Job; // 0x48
	private Force m_Force; // 0x50
	private UnitBaseCapability m_BaseCapability; // 0x58
	private Capability m_GrowCapability; // 0x60
	private UnitBaseCapability m_LevelCapability; // 0x68
	private uint m_GrowSeed; // 0x70
	private uint m_DropSeed; // 0x74
	private UnitActor m_Actor; // 0x78
	private MapInfoRoot m_Info; // 0x80
	private byte m_Index; // 0x88
	private byte m_Level; // 0x89
	private byte m_Exp; // 0x8A
	private Unit.ChangeValue m_Hp; // 0x8B
	private byte m_HpStockCount; // 0x8D
	private byte m_HpStockCountMax; // 0x8E
	private byte m_ExtraHpStockCount; // 0x8F
	private byte m_ExtraHpStockCountMax; // 0x90
	private byte m_EngageCount; // 0x91
	private byte m_EngageTurn; // 0x92
	private byte m_EngageCountView; // 0x93
	private GodState[] m_GodStates; // 0x98
	private sbyte m_X; // 0xA0
	private sbyte m_Z; // 0xA1
	private sbyte m_DisposX; // 0xA2
	private sbyte m_DisposZ; // 0xA3
	private float m_Angle; // 0xA4
	private PersonData m_DontAttackPerson; // 0xA8
	private uint m_DontAttackForceMask; // 0xB0
	private UnitItemList m_ItemList; // 0xB8
	private UnitItem m_ItemSelected; // 0xC0
	private UnitAccessoryList m_AccessoryList; // 0xC8
	private GodUnit m_GodUnit; // 0xD0
	private GodUnit m_GodLink; // 0xD8
	private UnitRing m_Ring; // 0xE0
	private int m_ExtraSight; // 0xE8
	private int m_MoveDistance; // 0xEC
	private SkillArray m_MaskSkill; // 0xF0
	private SkillArray m_EquipSkill; // 0xF8
	private SkillArray m_PrivateSkill; // 0x100
	private SkillArray m_ReceiveSkill; // 0x108
	private SkillArray m_SupportedSkill; // 0x110
	private SkillArray m_EquipSkillPool; // 0x118
	private SkillData m_LearnedJobSkill; // 0x120
	private WeaponMask m_OriginalAptitude; // 0x128
	private WeaponMask m_Aptitude; // 0x130
	private WeaponMask m_WeaponMask; // 0x138
	private WeaponMask m_SelectedWeaponMask; // 0x140
	private UnitEnhanceFactors m_EnhanceFactors; // 0x148
	private UnitEnhanceCalculator m_EnhanceCalculator; // 0x150
	private sbyte m_InternalLevel; // 0x158
	private sbyte m_LastPickVoice; // 0x159
	private MapDeployAttackImage m_AttackImage; // 0x160
	private MapDeployRodImage m_RodImage; // 0x168
	private MapDeployHealImage m_HealImage; // 0x170
	private MapDeploySupportImage m_SupportImage; // 0x178
	private MapDeployInterferenceImage m_InterferenceImage; // 0x180
	private MapDeployEngageImage m_EngageImage; // 0x188
	private MapDeployMoveImage m_MoveImage; // 0x190
	private UnitRecord m_Record; // 0x198
	private byte m_MapHistoryIndex; // 0x1A0
	private readonly object m_MaskSkillLock; // 0x1A8
	private PersonData m_FortuneTarget; // 0x1B0
	private uint m_FortuneSeed; // 0x1B8
	private byte m_RelayPlayerIndex; // 0x1BC
	private short m_SkillPoint; // 0x1BE
	private int m_OwnerUnit; // 0x1C0
	private sbyte m_LockTargetX; // 0x1C4
	private sbyte m_LockTargetZ; // 0x1C5
	private static MapDeployAttackImage s_AttackImage; // 0x8
	private static MapDeployRodImage s_RodImage; // 0x10
	private static MapDeployHealImage s_HealImage; // 0x18
	private static MapDeploySupportImage s_SupportImage; // 0x20
	private static MapDeployInterferenceImage s_InterferenceImage; // 0x28
	private static MapDeployEngageImage s_EngageImage; // 0x30
	private static MapDeployMoveImage s_MoveImage; // 0x38
	public static int LeaderAddLevel; // 0x40
	private static bool s_Engaging; // 0x44
	private static MapMind.Type s_Mind; // 0x48
	private static bool s_CanEngageStart; // 0x4C
	private static UnitItemList s_UnitList; // 0x50
	private static UnitItemList s_TempList; // 0x58
	private static MapTarget.DataSet s_TempTarget; // 0x60
	private const SkillData.States Disorder = 10231;
	public const int GrowAbortCount = 2;
	private const byte InvalidEngageCount = 255;
	[CompilerGeneratedAttribute] // RVA: 0x29C350 Offset: 0x29C451 VA: 0x29C350
	private int <TotalOrder>k__BackingField; // 0x1C8
	[CompilerGeneratedAttribute] // RVA: 0x29C360 Offset: 0x29C461 VA: 0x29C360
	private int <TotalAction>k__BackingField; // 0x1CC
	[CompilerGeneratedAttribute] // RVA: 0x29C370 Offset: 0x29C471 VA: 0x29C370
	private int <TotalAttack>k__BackingField; // 0x1D0
	[CompilerGeneratedAttribute] // RVA: 0x29C380 Offset: 0x29C481 VA: 0x29C380
	private int <TotalDamage>k__BackingField; // 0x1D4
	[CompilerGeneratedAttribute] // RVA: 0x29C390 Offset: 0x29C491 VA: 0x29C390
	private BattleScene.Result <TotalResult>k__BackingField; // 0x1D8
	[CompilerGeneratedAttribute] // RVA: 0x29C3A0 Offset: 0x29C4A1 VA: 0x29C3A0
	private BattleSide.Type <SideType>k__BackingField; // 0x1DC
	private const MapDeployTemplate.Flag<MapDnagerDeploy> EnemyEngageMask = 412316860418;
	[CompilerGeneratedAttribute] // RVA: 0x29C3B0 Offset: 0x29C4B1 VA: 0x29C3B0
	private int <BattleTemporary>k__BackingField; // 0x1E0
	private Unit.CalcInfo m_CalcInfo; // 0x1E8

	// Properties
	private int FirstX { get; }
	private int FirstZ { get; }
	public UnitAccessoryList AccessoryList { get; }
	public UnitRing Ring { get; }
	public Unit Prev { get; set; }
	public Unit Next { get; set; }
	public UnitAI Ai { get; }
	public UnitEdit Edit { get; }
	public PersonData Person { get; set; }
	public string Pid { get; }
	public string PrefixlessPid { get; }
	public JobData Job { get; set; }
	public string Jid { get; }
	public string PrefixlessJid { get; }
	public Force Force { get; set; }
	public Force.Type ForceType { get; }
	public uint ForceMask { get; }
	public UnitBaseCapability BaseCapability { get; }
	public Capability GrowCapability { get; }
	public UnitBaseCapability LevelCapability { get; }
	public uint GrowSeed { get; set; }
	public uint DropSeed { get; set; }
	public UnitActor Actor { get; set; }
	public MapInfoRoot Info { get; set; }
	public UnitModel UnitModel { get; }
	public UnitModel GodModel { get; }
	public Vector3 Position { get; }
	public Vector3 CellCenterPosition { get; }
	public Vector3 Direction { get; }
	public int Index { get; set; }
	public int BmapSize { get; }
	public BattleStyle.Types Style { get; }
	public int X { get; set; }
	public int Z { get; set; }
	public int DisposX { get; set; }
	public int DisposZ { get; set; }
	public int CenterX { get; }
	public int CenterZ { get; }
	public float Angle { get; set; }
	public int DisposSound { get; }
	public JobData.MoveTypes MoveType { get; }
	public int Level { get; set; }
	public int LimitLevel { get; }
	public int Exp { get; set; }
	public int SkillPoint { get; set; }
	public int Hp { get; set; }
	public int DisplayHp { get; }
	public int HpStockCount { get; }
	public int HpStockCountMax { get; }
	public int PlainHpStockCount { get; set; }
	public int PlainHpStockCountMax { get; }
	public int ExtraHpStockCount { get; }
	public int ExtraHpStockCountMax { get; }
	public int BaseMovePower { get; }
	public UnitItemList ItemList { get; }
	public GodUnit GodUnit { get; }
	public GodUnit ActualGodUnit { get; }
	public int ExtraSight { get; set; }
	public int MoveDistance { get; }
	public object MaskSkillLock { get; }
	public SkillArray MaskSkill { get; }
	public SkillArray EquipSkill { get; }
	public SkillArray PrivateSkill { get; }
	public SkillArray SupportedSkill { get; }
	public SkillArray ReceiveSkill { get; }
	public SkillArray EquipSkillPool { get; }
	public SkillData LearnedJobSkill { get; set; }
	public WeaponMask OriginalAptitude { get; }
	public WeaponMask Aptitude { get; }
	public WeaponMask WeaponMask { get; }
	public WeaponMask SelectedWeaponMask { get; }
	public UnitEnhanceFactors EnhanceFactors { get; }
	public int InternalLevel { get; set; }
	public sbyte LastPickVoice { get; set; }
	public int EngageCount { get; set; }
	public int EngageTurn { get; set; }
	public int Ident { get; set; }
	public UnitRecord Record { get; }
	public int MapHistoryIndex { get; set; }
	public int RelayPlayerIndex { get; set; }
	public MapDeployAttackImage AttackImage { get; }
	public MapDeployRodImage RodImage { get; }
	public MapDeployHealImage HealImage { get; }
	public MapDeploySupportImage SupportImage { get; }
	public MapDeployInterferenceImage InterferenceImage { get; }
	public int TotalOrder { get; set; }
	public int TotalAction { get; set; }
	public int TotalAttack { get; set; }
	public int TotalDamage { get; set; }
	public BattleScene.Result TotalResult { get; set; }
	public BattleSide.Type SideType { get; set; }
	public int BattleTemporary { get; set; }
	public uint FortuneSeed { get; set; }
	public PersonData FortuneTarget { get; set; }

	// Methods

	// RVA: 0x257E9C0 Offset: 0x257EAC1 VA: 0x257E9C0
	public void .ctor(bool useImage = True) { }

	// RVA: 0x257F110 Offset: 0x257F211 VA: 0x257F110
	public void Initialize(int index) { }

	// RVA: 0x257F180 Offset: 0x257F281 VA: 0x257F180
	public void Create(PersonData person, JobData job, int level = 0, Random random) { }

	// RVA: 0x257F880 Offset: 0x257F981 VA: 0x257F880
	public void CreateFromDispos(DisposData data) { }

	// RVA: 0x257FC30 Offset: 0x257FD31 VA: 0x257FC30
	public static int CalcEncountLevel(DisposData dispos, int level) { }

	// RVA: 0x257FCE0 Offset: 0x257FDE1 VA: 0x257FCE0
	public static JobData CalcEncountJob(DisposData dispos, Random random, int level, JobData job) { }

	// RVA: 0x257FDC0 Offset: 0x257FEC1 VA: 0x257FDC0
	public void CreateChallengeEnemy(DisposData dispos, Random random, int level, string ejid) { }

	// RVA: 0x2581100 Offset: 0x2581201 VA: 0x2581100
	public void CreateEncountEnemy(DisposData dispos, EncountUnitData.RareType unitRareType, JobData job) { }

	// RVA: 0x2581490 Offset: 0x2581591 VA: 0x2581490
	private void SetEncountHpStock(DisposData dispos, Difficulty difficulty) { }

	// RVA: 0x2581550 Offset: 0x2581651 VA: 0x2581550
	private void SetHpStockCount(int count) { }

	// RVA: 0x257FFC0 Offset: 0x25800C1 VA: 0x257FFC0
	private void CreateEncountPost(DisposData dispos, int level, bool offset, EncountUnitData.RareType rareType) { }

	// RVA: 0x2582B30 Offset: 0x2582C31 VA: 0x2582B30
	public void CreateEncountMob(string pid, string jid, string equipWeaponIid) { }

	// RVA: 0x2582E30 Offset: 0x2582F31 VA: 0x2582E30
	public void CreateDlcGodEnemy(DisposData data, bool isClearAll = True) { }

	// RVA: 0x2582F60 Offset: 0x2583061 VA: 0x2582F60
	private void CreateDlcGodEnemyImpl1(DisposData dispos, int level, Random random) { }

	// RVA: 0x25836F0 Offset: 0x25837F1 VA: 0x25836F0
	public void CreateForVision(Unit original, PersonData person) { }

	// RVA: 0x2583890 Offset: 0x2583991 VA: 0x2583890
	public void CreateForArena(GodUnit emblem, int level, RingCleaningSequence.GodType type) { }

	// RVA: 0x2583A70 Offset: 0x2583B71 VA: 0x2583A70
	public void CreateForVersus(DisposData data) { }

	// RVA: 0x2581560 Offset: 0x2581661 VA: 0x2581560
	public void AutoGrowCapability(int level, int targetLevel = 0) { }

	// RVA: 0x2583A80 Offset: 0x2583B81 VA: 0x2583A80
	public void AutoGrowCapability(int level, CapabilityInt percents) { }

	// RVA: 0x257F170 Offset: 0x257F271 VA: 0x257F170
	public void Clear() { }

	// RVA: 0x2582F50 Offset: 0x2583051 VA: 0x2582F50
	public void ClearExceptMapHistoryIndex() { }

	// RVA: 0x2583DA0 Offset: 0x2583EA1 VA: 0x2583DA0
	private void ClearImpl(bool isClearMapHistoryIndex = True) { }

	// RVA: 0x25847E0 Offset: 0x25848E1 VA: 0x25847E0
	public void ClearForRewindPreview(out string changedGid) { }

	// RVA: 0x2584BA0 Offset: 0x2584CA1 VA: 0x2584BA0
	public void CopyFrom(Unit from) { }

	// RVA: 0x2585C20 Offset: 0x2585D21 VA: 0x2585C20
	public void CopyFromForLevelUp(Unit from) { }

	// RVA: 0x2585D30 Offset: 0x2585E31 VA: 0x2585D30
	public void CopyFromForArenaResult(Unit from) { }

	// RVA: 0x25867C0 Offset: 0x25868C1 VA: 0x25867C0
	public void CopyFromForVersus(Unit from) { }

	// RVA: 0x2587820 Offset: 0x2587921 VA: 0x2587820
	public void ResetPhaseBegin(Force.Type phase) { }

	// RVA: 0x258F350 Offset: 0x258F451 VA: 0x258F350
	private bool IsEngageOwner() { }

	// RVA: 0x258F3C0 Offset: 0x258F4C1 VA: 0x258F3C0
	public void ResetPhaseBeginAfter(Force.Type phase) { }

	// RVA: 0x258FAA0 Offset: 0x258FBA1 VA: 0x258FAA0
	public void ResetPhaseEnd(Force.Type phase) { }

	// RVA: 0x258FF40 Offset: 0x2590041 VA: 0x258FF40
	public void ResetSubPhaseCharmConfusionBegin() { }

	// RVA: 0x258FFC0 Offset: 0x25900C1 VA: 0x258FFC0
	public void ResetDead() { }

	// RVA: 0x2590230 Offset: 0x2590331 VA: 0x2590230
	public void ResetMapBegin() { }

	// RVA: 0x2590400 Offset: 0x2590501 VA: 0x2590400
	public void ResetMapEnd(bool isResetPosition) { }

	// RVA: 0x2590640 Offset: 0x2590741 VA: 0x2590640
	public void MapCompleted() { }

	// RVA: 0x2594370 Offset: 0x2594471 VA: 0x2594370
	public void Fixed() { }

	// RVA: 0x2594470 Offset: 0x2594571 VA: 0x2594470
	public void Transfer(Force.Type force, bool isLast = True) { }

	// RVA: 0x25950C0 Offset: 0x25951C1 VA: 0x25950C0
	public void TransferForSortie(Force.Type force, bool isLast = True) { }

	// RVA: 0x25950D0 Offset: 0x25951D1 VA: 0x25950D0
	public void TransferForRewind(Force.Type force, Unit prevUnit) { }

	// RVA: 0x25950E0 Offset: 0x25951E1 VA: 0x25950E0
	public void TransferForRewindLatest(Force.Type force) { }

	// RVA: 0x2594480 Offset: 0x2594581 VA: 0x2594480
	private void TransferImpl(Force.Type force, bool isLast, Unit prevUnit, bool isDeleteActor) { }

	// RVA: 0x2582AE0 Offset: 0x2582BE1 VA: 0x2582AE0
	public void UpdateState() { }

	// RVA: 0x2582E20 Offset: 0x2582F21 VA: 0x2582E20
	public void UpdateStateWithAutoEquip() { }

	// RVA: 0x2595100 Offset: 0x2595201 VA: 0x2595100
	public void UpdateStateWithEquipped(UnitItem equipped) { }

	// RVA: 0x2595110 Offset: 0x2595211 VA: 0x2595110
	public bool TryUpdateStateWithEquipped(UnitItem equipped) { }

	// RVA: 0x25951D0 Offset: 0x25952D1 VA: 0x25951D0
	private void AddSkill(SkillArray array) { }

	// RVA: 0x2595AF0 Offset: 0x2595BF1 VA: 0x2595AF0
	private void AddSkill(SkillArray array, SkillData.Categorys category) { }

	// RVA: 0x25963D0 Offset: 0x25964D1 VA: 0x25963D0
	private void AddSkill(SkillData skill, SkillData.Categorys category, int age = 0) { }

	// RVA: 0x2596A70 Offset: 0x2596B71 VA: 0x2596A70
	private bool AddSkillWithoutUpdate(SkillData skill, SkillData.Categorys category, int age = 0) { }

	// RVA: 0x2596F50 Offset: 0x2597051 VA: 0x2596F50
	private bool IsEngaging(GodUnit godUnit) { }

	// RVA: 0x2587BD0 Offset: 0x2587CD1 VA: 0x2587BD0
	private void UpdateStateImpl(bool isAutoEquip = False, UnitItem equipped) { }

	// RVA: 0x2590690 Offset: 0x2590791 VA: 0x2590690
	private void CommitEnhance(UnitItem equipped) { }

	// RVA: 0x2597730 Offset: 0x2597831 VA: 0x2597730
	public void UpdatePlace() { }

	// RVA: 0x2597BB0 Offset: 0x2597CB1 VA: 0x2597BB0
	public void CreateActor() { }

	// RVA: 0x2597BC0 Offset: 0x2597CC1 VA: 0x2597BC0
	public bool TryCreateActor() { }

	// RVA: 0x258FA80 Offset: 0x258FB81 VA: 0x258FA80
	public void ReloadActor() { }

	// RVA: 0x2584620 Offset: 0x2584721 VA: 0x2584620
	public void DeleteActor() { }

	// RVA: 0x2597C60 Offset: 0x2597D61 VA: 0x2597C60
	public void UpdateActor() { }

	// RVA: 0x2597D00 Offset: 0x2597E01 VA: 0x2597D00
	public void TickActor() { }

	// RVA: 0x2597E50 Offset: 0x2597F51 VA: 0x2597E50
	public bool CheckStatus(Unit.Status status) { }

	// RVA: 0x2597EC0 Offset: 0x2597FC1 VA: 0x2597EC0
	public bool NotStatus(Unit.Status status) { }

	// RVA: 0x2582A70 Offset: 0x2582B71 VA: 0x2582A70
	public void SetStatus(Unit.Status status) { }

	// RVA: 0x2587B60 Offset: 0x2587C61 VA: 0x2587B60
	public void ClearStatus(Unit.Status status) { }

	// RVA: 0x2597F30 Offset: 0x2598031 VA: 0x2597F30
	public void ChangeStatus(Unit.Status status) { }

	// RVA: 0x2597FA0 Offset: 0x25980A1 VA: 0x2597FA0
	public Unit.StatusField GetStatus() { }

	// RVA: 0x2597FB0 Offset: 0x25980B1 VA: 0x2597FB0
	public void SetDead() { }

	// RVA: 0x2598320 Offset: 0x2598421 VA: 0x2598320
	public string GetName() { }

	// RVA: 0x2598540 Offset: 0x2598641 VA: 0x2598540
	public string GetTalkName() { }

	// RVA: 0x2598430 Offset: 0x2598531 VA: 0x2598430
	private string GetNameImpl(bool isMorph) { }

	// RVA: 0x2598820 Offset: 0x2598921 VA: 0x2598820
	public static string GetNameForRelayData(UnitEdit edit, PersonData person, JobData job, bool isMorph, int relayPlayerIndex) { }

	// RVA: 0x2598550 Offset: 0x2598651 VA: 0x2598550
	private static string GetNameImpl(UnitEdit edit, PersonData person, JobData job, bool isMorph, bool isGuest, int relayPlayerIndex, Force.Type forceType) { }

	// RVA: 0x25988C0 Offset: 0x25989C1 VA: 0x25988C0
	private static bool IsDefaultNameForNet(bool isGuest, int relayPlayerIndex, Force.Type forceType) { }

	// RVA: 0x2598A20 Offset: 0x2598B21 VA: 0x2598A20
	public string GetAsciiName() { }

	// RVA: 0x2598A30 Offset: 0x2598B31 VA: 0x2598A30
	public string GetJobName() { }

	// RVA: 0x2598A40 Offset: 0x2598B41 VA: 0x2598A40
	public void SetPosition(Vector3 pos, bool update = True) { }

	// RVA: 0x2598B30 Offset: 0x2598C31 VA: 0x2598B30
	public void SetPosition(int x, int z, bool update = True) { }

	// RVA: 0x2598B70 Offset: 0x2598C71 VA: 0x2598B70
	public void SetRotation(float angle) { }

	// RVA: 0x2598BA0 Offset: 0x2598CA1 VA: 0x2598BA0
	public void SetForceForStandAlone(Force force) { }

	// RVA: 0x2598BB0 Offset: 0x2598CB1 VA: 0x2598BB0
	public bool IsHero() { }

	// RVA: 0x2598BC0 Offset: 0x2598CC1 VA: 0x2598BC0
	public bool IsDead() { }

	// RVA: 0x2598C20 Offset: 0x2598D21 VA: 0x2598C20
	public Gender GetGender() { }

	// RVA: 0x2598E50 Offset: 0x2598F51 VA: 0x2598E50
	public Gender GetDressGender() { }

	// RVA: 0x25990D0 Offset: 0x25991D1 VA: 0x25990D0
	public static Gender GetGender(UnitEdit edit, PersonData person) { }

	// RVA: 0x2599110 Offset: 0x2599211 VA: 0x2599110
	public static Gender GetDressGender(UnitEdit edit, PersonData person) { }

	// RVA: 0x2599160 Offset: 0x2599261 VA: 0x2599160
	public bool IsFemale() { }

	// RVA: 0x25992B0 Offset: 0x25993B1 VA: 0x25992B0
	public bool IsLeader() { }

	// RVA: 0x25993B0 Offset: 0x25994B1 VA: 0x25993B0
	public bool IsMorph() { }

	// RVA: 0x25994B0 Offset: 0x25995B1 VA: 0x25994B0
	public bool HasFangCurse() { }

	// RVA: 0x25995B0 Offset: 0x25996B1 VA: 0x25995B0
	public bool IsEnchantment() { }

	// RVA: 0x25996B0 Offset: 0x25997B1 VA: 0x25996B0
	public bool IsMoveNotAllow() { }

	// RVA: 0x2599720 Offset: 0x2599821 VA: 0x2599720
	public bool IsUnique() { }

	// RVA: 0x2599790 Offset: 0x2599891 VA: 0x2599790
	public bool IsShow() { }

	// RVA: 0x25997F0 Offset: 0x25998F1 VA: 0x25997F0
	public bool CanSortie() { }

	// RVA: 0x2599860 Offset: 0x2599961 VA: 0x2599860
	public bool IsPlayArea() { }

	// RVA: 0x2599960 Offset: 0x2599A61 VA: 0x2599960
	public bool IsPlayArea(int x, int z) { }

	// RVA: 0x2599A50 Offset: 0x2599B51 VA: 0x2599A50
	public bool IsAllied(Unit unit) { }

	// RVA: 0x2599B20 Offset: 0x2599C21 VA: 0x2599B20
	public bool IsOperate() { }

	// RVA: 0x2599BB0 Offset: 0x2599CB1 VA: 0x2599BB0
	public bool IsEfficacy(Unit target) { }

	// RVA: 0x2599C00 Offset: 0x2599D01 VA: 0x2599C00
	public SkillData.Attrs GetAttrs() { }

	// RVA: 0x2599C30 Offset: 0x2599D31 VA: 0x2599C30
	public bool CanTransporter() { }

	// RVA: 0x2599D60 Offset: 0x2599E61 VA: 0x2599D60
	public bool CanBreakable(Unit target) { }

	// RVA: 0x259B450 Offset: 0x259B551 VA: 0x259B450
	public bool CanSkyBattle() { }

	// RVA: 0x259B480 Offset: 0x259B581 VA: 0x259B480
	public Force.Type GetForceAbsentType() { }

	// RVA: 0x259B540 Offset: 0x259B641 VA: 0x259B540
	public Force.Type GetForceDeadType() { }

	// RVA: 0x259B690 Offset: 0x259B791 VA: 0x259B690
	public bool IsSameForceType(Force.Type forceType) { }

	// RVA: 0x259B6F0 Offset: 0x259B7F1 VA: 0x259B6F0
	private void SetEngageImpl(bool enable, bool link = False) { }

	// RVA: 0x259BBC0 Offset: 0x259BCC1 VA: 0x259BBC0
	private void SetEngageLinkSimulation(bool enable, Unit link) { }

	// RVA: 0x259BC60 Offset: 0x259BD61 VA: 0x259BC60
	public void SetEngageSimulation(bool enable, Unit link) { }

	// RVA: 0x2584990 Offset: 0x2584A91 VA: 0x2584990
	private void SetGodLinkImpl(GodUnit godLink) { }

	// RVA: 0x259BF00 Offset: 0x259C001 VA: 0x259BF00
	public void PlayEngage(bool enable) { }

	// RVA: 0x259BFC0 Offset: 0x259C0C1 VA: 0x259BFC0
	public bool IsEngaging() { }

	// RVA: 0x259C020 Offset: 0x259C121 VA: 0x259C020
	public bool IsHeroEngaging() { }

	// RVA: 0x259C0D0 Offset: 0x259C1D1 VA: 0x259C0D0
	public bool CanEngageHeal() { }

	// RVA: 0x259C210 Offset: 0x259C311 VA: 0x259C210
	private void SetEngageLink(bool enable, GodUnit godLink, Unit parent, Unit child) { }

	// RVA: 0x258F750 Offset: 0x258F851 VA: 0x258F750
	public void SetEngage(bool enable, Unit link) { }

	// RVA: 0x259C290 Offset: 0x259C391 VA: 0x259C290
	public bool TryRelocation() { }

	// RVA: 0x259C660 Offset: 0x259C761 VA: 0x259C660
	private bool IsActiveRoute() { }

	// RVA: 0x259C520 Offset: 0x259C621 VA: 0x259C520
	private int get_FirstX() { }

	// RVA: 0x259C5C0 Offset: 0x259C6C1 VA: 0x259C5C0
	private int get_FirstZ() { }

	// RVA: 0x259C790 Offset: 0x259C891 VA: 0x259C790
	public void ForceSetEngageLinkForRewind(Unit linkUnit) { }

	// RVA: 0x259C820 Offset: 0x259C921 VA: 0x259C820
	public void SetEngageAttack(bool enable) { }

	// RVA: 0x259C950 Offset: 0x259CA51 VA: 0x259C950
	private bool CanEngageImpl(GodUnit godUnit) { }

	// RVA: 0x259CB90 Offset: 0x259CC91 VA: 0x259CB90
	public bool CanEngageCancel(bool pickup = False) { }

	// RVA: 0x259CDC0 Offset: 0x259CEC1 VA: 0x259CDC0
	public bool CanEngageStart() { }

	// RVA: 0x259CDD0 Offset: 0x259CED1 VA: 0x259CDD0
	public bool CanEngageLink() { }

	// RVA: 0x259CE90 Offset: 0x259CF91 VA: 0x259CE90
	public GodUnit GetLinkableGodUnit() { }

	// RVA: 0x259CEB0 Offset: 0x259CFB1 VA: 0x259CEB0
	public Unit GetEngageLinkUnit() { }

	// RVA: 0x259CEE0 Offset: 0x259CFE1 VA: 0x259CEE0
	public void PreStartTargetSelect() { }

	// RVA: 0x259D010 Offset: 0x259D111 VA: 0x259D010
	public void PostStartTargetSelect() { }

	// RVA: 0x259D0F0 Offset: 0x259D1F1 VA: 0x259D0F0
	public void TryAddAchieveEngage() { }

	// RVA: 0x259D1D0 Offset: 0x259D2D1 VA: 0x259D1D0
	public void DecideTargetSelect() { }

	// RVA: 0x259D410 Offset: 0x259D511 VA: 0x259D410
	public void CancelTargetSelect() { }

	// RVA: 0x259D630 Offset: 0x259D731 VA: 0x259D630
	public bool CanChangeEngage(Unit targetUnit) { }

	// RVA: 0x259D930 Offset: 0x259DA31 VA: 0x259D930
	public bool TryChangeEngage(Unit targetUnit, int itemIndex) { }

	// RVA: 0x259D990 Offset: 0x259DA91 VA: 0x259D990
	public void ChangeEngage(Unit targetUnit, int itemIndex) { }

	// RVA: 0x259E290 Offset: 0x259E391 VA: 0x259E290
	public bool CanEngageAttack() { }

	// RVA: 0x259EB40 Offset: 0x259EC41 VA: 0x259EB40
	public bool CanEngageTarget(Unit target) { }

	// RVA: 0x259EB70 Offset: 0x259EC71 VA: 0x259EB70
	public bool EngageTargetExists(Unit target, SkillData skill) { }

	// RVA: 0x259E380 Offset: 0x259E481 VA: 0x259E380
	private bool CanEnemyEngageAttack() { }

	// RVA: 0x259F450 Offset: 0x259F551 VA: 0x259F450
	public bool CanExecuteEngageAttack() { }

	// RVA: 0x259F4B0 Offset: 0x259F5B1 VA: 0x259F4B0
	public bool CanAct(bool isFixed = True, bool isCharged = True) { }

	// RVA: 0x259F5B0 Offset: 0x259F6B1 VA: 0x259F5B0
	public bool CanActWithoutEngageCharge() { }

	// RVA: 0x259F690 Offset: 0x259F791 VA: 0x259F690
	public bool CanBeTarget() { }

	// RVA: 0x259F8B0 Offset: 0x259F9B1 VA: 0x259F8B0
	public bool CanExternalMove() { }

	// RVA: 0x259F950 Offset: 0x259FA51 VA: 0x259F950
	public bool IsSight(int x, int z) { }

	// RVA: 0x259FA80 Offset: 0x259FB81 VA: 0x259FA80
	public bool CanWarp(Unit rodUnit, int x, int z) { }

	// RVA: 0x259FDC0 Offset: 0x259FEC1 VA: 0x259FDC0
	public bool CanSkill(SkillData skill) { }

	// RVA: 0x259FF30 Offset: 0x25A0031 VA: 0x259FF30
	public bool CanChangeGod() { }

	// RVA: 0x25A0030 Offset: 0x25A0131 VA: 0x25A0030
	public bool ChangeGod() { }

	// RVA: 0x25A0090 Offset: 0x25A0191 VA: 0x25A0090
	public int GetCells(MapPos[] cells) { }

	// RVA: 0x25A00A0 Offset: 0x25A01A1 VA: 0x25A00A0
	public int GetCells(MapPos[] cells, int baseX, int baseZ) { }

	// RVA: 0x25A0140 Offset: 0x25A0241 VA: 0x25A0140
	public void SetBaseCapability(int index, int value) { }

	// RVA: 0x25A01A0 Offset: 0x25A02A1 VA: 0x25A01A0
	public void AddBaseCapability(int index, int value) { }

	// RVA: 0x25A0250 Offset: 0x25A0351 VA: 0x25A0250
	public void SetCapabilityJust(int index, int value) { }

	// RVA: 0x25A1050 Offset: 0x25A1151 VA: 0x25A1050
	public int GetGodEnhanceRating(GodUnit god) { }

	// RVA: 0x25A1110 Offset: 0x25A1211 VA: 0x25A1110
	public void ChangeHp(int hp) { }

	// RVA: 0x25A12C0 Offset: 0x25A13C1 VA: 0x25A12C0
	public void PlaySetHp(int hp) { }

	// RVA: 0x25A1640 Offset: 0x25A1741 VA: 0x25A1640
	public void PlaySetHeal(int heal) { }

	// RVA: 0x25A12E0 Offset: 0x25A13E1 VA: 0x25A12E0
	public void PlaySetDamage(int damage, bool canDie = False, bool isMulti = False) { }

	// RVA: 0x25A1650 Offset: 0x25A1751 VA: 0x25A1650
	public bool IsChangingHp() { }

	// RVA: 0x25A1670 Offset: 0x25A1771 VA: 0x25A1670
	public int GetMaxHp() { }

	// RVA: 0x25A17F0 Offset: 0x25A18F1 VA: 0x25A17F0
	public int GetStr() { }

	// RVA: 0x25A1970 Offset: 0x25A1A71 VA: 0x25A1970
	public int GetTech() { }

	// RVA: 0x25A1AF0 Offset: 0x25A1BF1 VA: 0x25A1AF0
	public int GetQuick() { }

	// RVA: 0x25A1C70 Offset: 0x25A1D71 VA: 0x25A1C70
	public int GetLuck() { }

	// RVA: 0x25A1DF0 Offset: 0x25A1EF1 VA: 0x25A1DF0
	public int GetDef() { }

	// RVA: 0x25A1F70 Offset: 0x25A2071 VA: 0x25A1F70
	public int GetMagic() { }

	// RVA: 0x25A2100 Offset: 0x25A2201 VA: 0x25A2100
	public int GetMdef() { }

	// RVA: 0x25A2290 Offset: 0x25A2391 VA: 0x25A2290
	public int GetPhys() { }

	// RVA: 0x25A2420 Offset: 0x25A2521 VA: 0x25A2420
	public int GetSight() { }

	// RVA: 0x25A2660 Offset: 0x25A2761 VA: 0x25A2660
	public int GetMovePower() { }

	// RVA: 0x25A29E0 Offset: 0x25A2AE1 VA: 0x25A29E0
	public int GetMovePowerWithoutRemoving() { }

	// RVA: 0x25A3160 Offset: 0x25A3261 VA: 0x25A3160
	public SkillData FindSkill(SkillData.Flags flags) { }

	// RVA: 0x25A32B0 Offset: 0x25A33B1 VA: 0x25A32B0
	public SkillData FindSkill(SkillData.States states) { }

	// RVA: 0x25A3400 Offset: 0x25A3501 VA: 0x25A3400
	public SkillData GetRemovableSkill() { }

	// RVA: 0x25A3580 Offset: 0x25A3681 VA: 0x25A3580
	public int GetRemovablePower() { }

	// RVA: 0x25A3720 Offset: 0x25A3821 VA: 0x25A3720
	public int GetCapability(int index, bool calcEnhance = True) { }

	// RVA: 0x25A47F0 Offset: 0x25A48F1 VA: 0x25A47F0
	public int GetCapability(CapabilityDefinition.Type type, bool calcEnhance = True) { }

	// RVA: 0x25A58C0 Offset: 0x25A59C1 VA: 0x25A58C0
	public int GetCapabilityGrow(int index, bool isAutoGrow = False) { }

	// RVA: 0x25A5E80 Offset: 0x25A5F81 VA: 0x25A5E80
	public int GetCapabilityGrow(CapabilityDefinition.Type type, bool isAutoGrow = False) { }

	// RVA: 0x25A6430 Offset: 0x25A6531 VA: 0x25A6430
	public int GetCapabilityLimit(CapabilityDefinition.Type type) { }

	// RVA: 0x25A6500 Offset: 0x25A6601 VA: 0x25A6500
	public int GetCapabilityLimit(int index) { }

	// RVA: 0x25A65D0 Offset: 0x25A66D1 VA: 0x25A65D0
	public bool CanCapabilityGrow(CapabilityDefinition.Type type) { }

	// RVA: 0x25A7440 Offset: 0x25A7541 VA: 0x25A7440
	public bool CanCapabilityGrow(int index) { }

	// RVA: 0x25A7520 Offset: 0x25A7621 VA: 0x25A7520
	public CapabilityDefinition.Type GetStrengthCapabilityIndex(Random rand) { }

	// RVA: 0x25A83E0 Offset: 0x25A84E1 VA: 0x25A83E0
	public int GetNoEnhanceMaxHp() { }

	// RVA: 0x25A8540 Offset: 0x25A8641 VA: 0x25A8540
	public int GetNoEnhanceStr() { }

	// RVA: 0x25A86A0 Offset: 0x25A87A1 VA: 0x25A86A0
	public int GetNoEnhanceTech() { }

	// RVA: 0x25A8800 Offset: 0x25A8901 VA: 0x25A8800
	public int GetNoEnhanceQuick() { }

	// RVA: 0x25A8960 Offset: 0x25A8A61 VA: 0x25A8960
	public int GetNoEnhanceLuck() { }

	// RVA: 0x25A8AC0 Offset: 0x25A8BC1 VA: 0x25A8AC0
	public int GetNoEnhanceDef() { }

	// RVA: 0x25A8C20 Offset: 0x25A8D21 VA: 0x25A8C20
	public int GetNoEnhanceMagic() { }

	// RVA: 0x25A8D90 Offset: 0x25A8E91 VA: 0x25A8D90
	public int GetNoEnhanceMdef() { }

	// RVA: 0x25A8F00 Offset: 0x25A9001 VA: 0x25A8F00
	public int GetNoEnhancePhys() { }

	// RVA: 0x25A9070 Offset: 0x25A9171 VA: 0x25A9070
	public int GetNoEnhanceSight() { }

	// RVA: 0x25A9290 Offset: 0x25A9391 VA: 0x25A9290
	public int GetNoEnhanceMovePower() { }

	// RVA: 0x25A02C0 Offset: 0x25A03C1 VA: 0x25A02C0
	public int GetNoEnhanceCapability(int index) { }

	// RVA: 0x25A66B0 Offset: 0x25A67B1 VA: 0x25A66B0
	public int GetNoEnhanceCapability(CapabilityDefinition.Type type) { }

	// RVA: 0x25A9440 Offset: 0x25A9541 VA: 0x25A9440
	public int GetEnhancedLevel() { }

	// RVA: 0x25A9660 Offset: 0x25A9761 VA: 0x25A9660
	public void AddHp(int v) { }

	// RVA: 0x25A9820 Offset: 0x25A9921 VA: 0x25A9820
	public bool IsDontAttack(Unit unit) { }

	// RVA: 0x25A9870 Offset: 0x25A9971 VA: 0x25A9870
	public void SetDontAttack(PersonData person) { }

	// RVA: 0x25A9880 Offset: 0x25A9981 VA: 0x25A9880
	public void SetDontAttackForceMask(uint forceMask) { }

	// RVA: 0x25A9890 Offset: 0x25A9991 VA: 0x25A9890
	public UnitEntrust.Type GetEntrustForAI() { }

	// RVA: 0x25A9B10 Offset: 0x25A9C11 VA: 0x25A9B10
	public bool CanTalk() { }

	// RVA: 0x25A9D90 Offset: 0x25A9E91 VA: 0x25A9D90
	public bool CanDance(Unit target) { }

	// RVA: 0x25AA030 Offset: 0x25AA131 VA: 0x25AA030
	public bool CanContract(Unit target) { }

	// RVA: 0x25AA220 Offset: 0x25AA321 VA: 0x25AA220
	public bool CanAgain() { }

	// RVA: 0x25AA380 Offset: 0x25AA481 VA: 0x25AA380
	public bool CanChain(Unit parent) { }

	// RVA: 0x25AA600 Offset: 0x25AA701 VA: 0x25AA600
	public bool CanChainAttack() { }

	// RVA: 0x25AA630 Offset: 0x25AA731 VA: 0x25AA630
	public bool IsTerrainInvalid(TerrainData terrain) { }

	// RVA: 0x25AA6B0 Offset: 0x25AA7B1 VA: 0x25AA6B0
	public bool CanChainGuard() { }

	// RVA: 0x25AA8F0 Offset: 0x25AA9F1 VA: 0x25AA8F0
	public Unit.GuardType GetGuardType() { }

	// RVA: 0x25AAB40 Offset: 0x25AAC41 VA: 0x25AAB40
	public bool CanCcogitation() { }

	// RVA: 0x25AAB60 Offset: 0x25AAC61 VA: 0x25AAB60
	public bool CanTrade() { }

	// RVA: 0x25AAE20 Offset: 0x25AAF21 VA: 0x25AAE20
	public bool CanGainReliance() { }

	// RVA: 0x25AAEC0 Offset: 0x25AAFC1 VA: 0x25AAEC0
	public bool HasSkill(SkillData skill) { }

	// RVA: 0x25AAEE0 Offset: 0x25AAFE1 VA: 0x25AAEE0
	public bool HasSkill(string sid) { }

	// RVA: 0x25AAF90 Offset: 0x25AB091 VA: 0x25AAF90
	public bool HasSkill(SkillData.Flags flags) { }

	// RVA: 0x25AAFB0 Offset: 0x25AB0B1 VA: 0x25AAFB0
	public bool HasSkill(SkillData.States states) { }

	// RVA: 0x25AAFD0 Offset: 0x25AB0D1 VA: 0x25AAFD0
	public bool HasDanceSkill() { }

	// RVA: 0x25AB0D0 Offset: 0x25AB1D1 VA: 0x25AB0D0
	public bool HasContractSkill() { }

	// RVA: 0x25AB0E0 Offset: 0x25AB1E1 VA: 0x25AB0E0
	public bool IsStandingDie() { }

	// RVA: 0x25AB2D0 Offset: 0x25AB3D1 VA: 0x25AB2D0
	public bool IsImmortal() { }

	// RVA: 0x25AB3F0 Offset: 0x25AB4F1 VA: 0x25AB3F0
	public bool IsLastBoss() { }

	// RVA: 0x25AB580 Offset: 0x25AB681 VA: 0x25AB580
	public SkillData GetEquipSkill(int index) { }

	// RVA: 0x25AB6D0 Offset: 0x25AB7D1 VA: 0x25AB6D0
	public bool HasEquipSkill(string sid) { }

	// RVA: 0x25AB7A0 Offset: 0x25AB8A1 VA: 0x25AB7A0
	public bool HasEquipSkill(SkillData skill) { }

	// RVA: 0x25AB7D0 Offset: 0x25AB8D1 VA: 0x25AB7D0
	public bool AddEquipSkill(string sid) { }

	// RVA: 0x25AB860 Offset: 0x25AB961 VA: 0x25AB860
	public bool AddEquipSkill(SkillData skill) { }

	// RVA: 0x25AC760 Offset: 0x25AC861 VA: 0x25AC760
	public void RemoveEquipSkill(string sid) { }

	// RVA: 0x25AC7F0 Offset: 0x25AC8F1 VA: 0x25AC7F0
	public void RemoveEquipSkill(SkillData skill) { }

	// RVA: 0x25ACB10 Offset: 0x25ACC11 VA: 0x25ACB10
	public void ReplaceEquipSkill(int index, string sid) { }

	// RVA: 0x25ACBB0 Offset: 0x25ACCB1 VA: 0x25ACBB0
	public void ReplaceEquipSkill(int index, SkillData skill) { }

	// RVA: 0x25ACEF0 Offset: 0x25ACFF1 VA: 0x25ACEF0
	public void MoveEquipSkill(int oldIndex, int newIndex) { }

	// RVA: 0x25AD190 Offset: 0x25AD291 VA: 0x25AD190
	public bool HasPrivateSkill(string sid) { }

	// RVA: 0x25AD250 Offset: 0x25AD351 VA: 0x25AD250
	public bool HasPrivateSkill(SkillData skill) { }

	// RVA: 0x25829E0 Offset: 0x2582AE1 VA: 0x25829E0
	public bool AddPrivateSkill(string sid) { }

	// RVA: 0x25AD270 Offset: 0x25AD371 VA: 0x25AD270
	public bool AddPrivateSkill(SkillData skill) { }

	// RVA: 0x25AD800 Offset: 0x25AD901 VA: 0x25AD800
	public bool AddPrivateSkill(SkillArray skills) { }

	// RVA: 0x25AD970 Offset: 0x25ADA71 VA: 0x25AD970
	public bool RemovePrivateSkill(string sid) { }

	// RVA: 0x25ADA00 Offset: 0x25ADB01 VA: 0x25ADA00
	public bool RemovePrivateSkill(SkillData skill) { }

	// RVA: 0x25ADD30 Offset: 0x25ADE31 VA: 0x25ADD30
	public bool RemovePrivateSkill(SkillArray skills) { }

	// RVA: 0x25ADEA0 Offset: 0x25ADFA1 VA: 0x25ADEA0
	public int GetRecord(UnitRecord.Kinds kind) { }

	// RVA: 0x25ADEB0 Offset: 0x25ADFB1 VA: 0x25ADEB0
	public void SetRecord(UnitRecord.Kinds kind, int value) { }

	// RVA: 0x25ADF10 Offset: 0x25AE011 VA: 0x25ADF10
	public void AddRecord(UnitRecord.Kinds kind, int value) { }

	// RVA: 0x25ADFA0 Offset: 0x25AE0A1 VA: 0x25ADFA0
	public void IncRecord(UnitRecord.Kinds kind) { }

	// RVA: 0x25AE030 Offset: 0x25AE131 VA: 0x25AE030
	public void DecRecord(UnitRecord.Kinds kind) { }

	// RVA: 0x25AE0C0 Offset: 0x25AE1C1 VA: 0x25AE0C0
	public void AddRecordWithHistory(UnitRecord.Kinds kind, int value = 1) { }

	// RVA: 0x25AE1B0 Offset: 0x25AE2B1 VA: 0x25AE1B0
	public SkillData GetFromEquipSkillPool(int index) { }

	// RVA: 0x25AE300 Offset: 0x25AE401 VA: 0x25AE300
	public void AddToEquipSkillPool(string sid) { }

	// RVA: 0x25ABE40 Offset: 0x25ABF41 VA: 0x25ABE40
	public void AddToEquipSkillPool(SkillData skill) { }

	// RVA: 0x25AE390 Offset: 0x25AE491 VA: 0x25AE390
	public void RemoveFromEquipSkillPool(string sid) { }

	// RVA: 0x25AE420 Offset: 0x25AE521 VA: 0x25AE420
	public void RemoveFromEquipSkillPool(SkillData skill) { }

	// RVA: 0x25AE9F0 Offset: 0x25AEAF1 VA: 0x25AE9F0
	public bool IsExistInEquipSkillPool(string sid) { }

	// RVA: 0x25AEAC0 Offset: 0x25AEBC1 VA: 0x25AEAC0
	public bool IsExistInEquipSkillPool(SkillData skill) { }

	// RVA: 0x25AEAF0 Offset: 0x25AEBF1 VA: 0x25AEAF0
	public bool IsInheritanceEnable(SkillData skill) { }

	// RVA: 0x25AEC70 Offset: 0x25AED71 VA: 0x25AEC70
	public bool IsPoison() { }

	// RVA: 0x25AEC90 Offset: 0x25AED91 VA: 0x25AEC90
	public bool IsStun() { }

	// RVA: 0x25AECA0 Offset: 0x25AEDA1 VA: 0x25AECA0
	public bool IsSleep() { }

	// RVA: 0x25AECB0 Offset: 0x25AEDB1 VA: 0x25AECB0
	public bool IsSilence() { }

	// RVA: 0x25AECC0 Offset: 0x25AEDC1 VA: 0x25AECC0
	public bool IsCharm() { }

	// RVA: 0x25AECD0 Offset: 0x25AEDD1 VA: 0x25AECD0
	public bool IsConfusion() { }

	// RVA: 0x25AECE0 Offset: 0x25AEDE1 VA: 0x25AECE0
	public bool IsCharmOrConfusion() { }

	// RVA: 0x25AED00 Offset: 0x25AEE01 VA: 0x25AED00
	public bool IsFreeze() { }

	// RVA: 0x25AED10 Offset: 0x25AEE11 VA: 0x25AED10
	public bool IsWeakness() { }

	// RVA: 0x25AED20 Offset: 0x25AEE21 VA: 0x25AED20
	public bool IsNotEnhance() { }

	// RVA: 0x25AED30 Offset: 0x25AEE31 VA: 0x25AED30
	public bool IsDisorder() { }

	// RVA: 0x25AED50 Offset: 0x25AEE51 VA: 0x25AED50
	public bool ClearDisorder(SkillData.States state = 10231) { }

	// RVA: 0x25AEF00 Offset: 0x25AF001 VA: 0x25AEF00
	public bool IsVision() { }

	// RVA: 0x25AEF60 Offset: 0x25AF061 VA: 0x25AEF60
	public bool IsVision(Unit owner) { }

	// RVA: 0x25AF000 Offset: 0x25AF101 VA: 0x25AF000
	public bool CanGainItem() { }

	// RVA: 0x25AF070 Offset: 0x25AF171 VA: 0x25AF070
	public Unit GetVisionOwner() { }

	// RVA: 0x25AF130 Offset: 0x25AF231 VA: 0x25AF130
	public bool IsSummon() { }

	// RVA: 0x25AF190 Offset: 0x25AF291 VA: 0x25AF190
	public bool IsSummon(Unit owner) { }

	// RVA: 0x25AF230 Offset: 0x25AF331 VA: 0x25AF230
	public bool IsSummonGod() { }

	// RVA: 0x25AF2C0 Offset: 0x25AF3C1 VA: 0x25AF2C0
	public Unit GetSummonOwner() { }

	// RVA: 0x25AF3F0 Offset: 0x25AF4F1 VA: 0x25AF3F0
	public bool IsLockon() { }

	// RVA: 0x25AF450 Offset: 0x25AF551 VA: 0x25AF450
	public bool TryGetLockTarget(out int x, out int z) { }

	// RVA: 0x25AF4F0 Offset: 0x25AF5F1 VA: 0x25AF4F0
	public void SetLockTarget(int x, int z) { }

	// RVA: 0x25AF570 Offset: 0x25AF671 VA: 0x25AF570
	public void ResetLockTarget() { }

	// RVA: 0x25AF5E0 Offset: 0x25AF6E1 VA: 0x25AF5E0
	public bool IsOnMap() { }

	// RVA: 0x25AF610 Offset: 0x25AF711 VA: 0x25AF610
	public bool IsDecoy() { }

	// RVA: 0x25AF620 Offset: 0x25AF721 VA: 0x25AF620
	public void AddExp(int exp) { }

	// RVA: 0x25AF690 Offset: 0x25AF791 VA: 0x25AF690
	public void AddSkillPoint(int skillPoint) { }

	// RVA: 0x25AF6D0 Offset: 0x25AF7D1 VA: 0x25AF6D0
	public bool CanGrow() { }

	// RVA: 0x25AF840 Offset: 0x25AF941 VA: 0x25AF840
	public int NormalizeExp(int exp) { }

	// RVA: 0x25AF8C0 Offset: 0x25AF9C1 VA: 0x25AF8C0
	public int ExpToSkillPoint(int exp) { }

	// RVA: 0x25AF8F0 Offset: 0x25AF9F1 VA: 0x25AF8F0
	public int NomralizeSkillPoint(int skillPoint) { }

	// RVA: 0x25AF920 Offset: 0x25AFA21 VA: 0x25AF920
	public void LevelUp(int abort = 2) { }

	[ConditionalAttribute] // RVA: 0x2CBBC0 Offset: 0x2CBCC1 VA: 0x2CBBC0
	// RVA: 0x25B0420 Offset: 0x25B0521 VA: 0x25B0420
	public void DbgLevelDown() { }

	// RVA: 0x25B1B10 Offset: 0x25B1C11 VA: 0x25B1B10
	public SkillData LearnJobSkill() { }

	// RVA: 0x25B1BD0 Offset: 0x25B1CD1 VA: 0x25B1BD0
	public SkillData LearnJobSkillForChart(int level) { }

	// RVA: 0x25B1B70 Offset: 0x25B1C71 VA: 0x25B1B70
	private SkillData LearnJobSkill(int level, JobData job) { }

	// RVA: 0x25B1C30 Offset: 0x25B1D31 VA: 0x25B1C30
	private SkillData LearnJobSkill(JobData job) { }

	// RVA: 0x25B1E70 Offset: 0x25B1F71 VA: 0x25B1E70
	public bool CCCheckAptitude(JobData job) { }

	// RVA: 0x25B2030 Offset: 0x25B2131 VA: 0x25B2030
	public void ClassChange(JobData job, ItemData item) { }

	// RVA: 0x25B24B0 Offset: 0x25B25B1 VA: 0x25B24B0
	public void ClassChangeForChart(JobData job, ItemData item, int level) { }

	// RVA: 0x25B24E0 Offset: 0x25B25E1 VA: 0x25B24E0
	public void UpdateDifficulty() { }

	// RVA: 0x2581D60 Offset: 0x2581E61 VA: 0x2581D60
	public void ResetWeaponMask() { }

	// RVA: 0x25B25D0 Offset: 0x25B26D1 VA: 0x25B25D0
	public void SetSelectedWeapon(WeaponMask selectedWeaponMask) { }

	// RVA: 0x2581DB0 Offset: 0x2581EB1 VA: 0x2581DB0
	private void SetSelectedWeaponFromOriginalAptitude(WeaponMask aptitude) { }

	// RVA: 0x25B25F0 Offset: 0x25B26F1 VA: 0x25B25F0
	public void SetWeaponMaskFromParson() { }

	// RVA: 0x25B2670 Offset: 0x25B2771 VA: 0x25B2670
	public UnitItem SetOptimalWeaponForClassChange(WeaponMask weaponMask, bool isBullet) { }

	// RVA: 0x25B3260 Offset: 0x25B3361 VA: 0x25B3260
	private void SetSelectedWeaponFromItems(Unit.ItemsForSelectedWeapon items) { }

	// RVA: 0x25B3530 Offset: 0x25B3631 VA: 0x25B3530
	public void SetSelectedWeaponForChart(ChartData.Item[] chartItems) { }

	// RVA: 0x25B35A0 Offset: 0x25B36A1 VA: 0x25B35A0
	private void SetSelectedWeaponFromDispos(DisposData data) { }

	// RVA: 0x25B3610 Offset: 0x25B3711 VA: 0x25B3610
	public void InheritAptitude(GodUnit godUnit) { }

	// RVA: 0x25B3670 Offset: 0x25B3771 VA: 0x25B3670
	public void InheritAptitude(GodBond godBond) { }

	// RVA: 0x25B36C0 Offset: 0x25B37C1 VA: 0x25B36C0
	public void AddAptitudeForChart() { }

	// RVA: 0x25B36D0 Offset: 0x25B37D1 VA: 0x25B36D0
	private void SetAptitudeFromDispos(DisposData data) { }

	// RVA: 0x25822C0 Offset: 0x25823C1 VA: 0x25822C0
	private void AddAptitudeFromWeaponMask() { }

	// RVA: 0x2582140 Offset: 0x2582241 VA: 0x2582140
	private void UpdateWeaponMask() { }

	// RVA: 0x25B3C80 Offset: 0x25B3D81 VA: 0x25B3C80
	public void AIActivate(bool attacked = False) { }

	// RVA: 0x25B3CF0 Offset: 0x25B3DF1 VA: 0x25B3CF0
	public void AIActivate_CauseAttacked(bool longrange = False) { }

	// RVA: 0x25B3D70 Offset: 0x25B3E71 VA: 0x25B3D70
	public void AISetEngageAttack() { }

	// RVA: 0x25B3E00 Offset: 0x25B3F01 VA: 0x25B3E00
	public void AIClearEngageAttack() { }

	// RVA: 0x25B3E90 Offset: 0x25B3F91 VA: 0x25B3E90
	public bool HasItem(bool isExcludeEngage = False) { }

	// RVA: 0x25B4280 Offset: 0x25B4381 VA: 0x25B4280
	public bool HasRod() { }

	// RVA: 0x25B42A0 Offset: 0x25B43A1 VA: 0x25B42A0
	public bool HasHealRod() { }

	// RVA: 0x25B42C0 Offset: 0x25B43C1 VA: 0x25B42C0
	public bool HasHealRodForOneself(ItemData.RodTypes rodType = 1) { }

	// RVA: 0x25B42E0 Offset: 0x25B43E1 VA: 0x25B42E0
	public bool HasSupportRod() { }

	// RVA: 0x25B4300 Offset: 0x25B4401 VA: 0x25B4300
	public bool HasSupportRodForOneself(ItemData.RodTypes rodType = 1) { }

	// RVA: 0x25B4320 Offset: 0x25B4421 VA: 0x25B4320
	public bool HasInterferenceRod() { }

	// RVA: 0x25B4340 Offset: 0x25B4441 VA: 0x25B4340
	public bool HasCriticaleWeapon() { }

	// RVA: 0x25B4360 Offset: 0x25B4461 VA: 0x25B4360
	public bool HasEfficacyWeapon(Unit target) { }

	// RVA: 0x25B4380 Offset: 0x25B4481 VA: 0x25B4380
	public bool HasDropItem() { }

	// RVA: 0x25B4390 Offset: 0x25B4491 VA: 0x25B4390
	public bool HasMaxItem() { }

	// RVA: 0x25B43C0 Offset: 0x25B44C1 VA: 0x25B43C0
	public UnitItem GetItem(int index) { }

	// RVA: 0x25B43D0 Offset: 0x25B44D1 VA: 0x25B43D0
	public int GetItemIndex(string iid) { }

	// RVA: 0x25B4570 Offset: 0x25B4671 VA: 0x25B4570
	public int GetItemIndex(ItemData item) { }

	// RVA: 0x25B46B0 Offset: 0x25B47B1 VA: 0x25B46B0
	public void ForEachUnitItem(Unit.FuncUnitItem func) { }

	// RVA: 0x25B48A0 Offset: 0x25B49A1 VA: 0x25B48A0
	public void ForEachCanEquipItem(Unit.FuncUnitItem func) { }

	// RVA: 0x25B4980 Offset: 0x25B4A81 VA: 0x25B4980
	public UnitItem GetActualItem(UnitItem unitItem) { }

	// RVA: 0x25B4C30 Offset: 0x25B4D31 VA: 0x25B4C30
	public bool IsItemEquipped() { }

	// RVA: 0x25B4C40 Offset: 0x25B4D41 VA: 0x25B4C40
	public UnitItem GetItemEquipped() { }

	// RVA: 0x25B4C50 Offset: 0x25B4D51 VA: 0x25B4C50
	public int GetItemIndexEquipped() { }

	// RVA: 0x25B4C60 Offset: 0x25B4D61 VA: 0x25B4C60
	public UnitItem GetItemHold() { }

	// RVA: 0x25B4C70 Offset: 0x25B4D71 VA: 0x25B4C70
	public int GetItemIndexHold() { }

	// RVA: 0x2582D40 Offset: 0x2582E41 VA: 0x2582D40
	public int ItemAdd(string iid) { }

	// RVA: 0x25B4D00 Offset: 0x25B4E01 VA: 0x25B4D00
	public bool ItemAdd(string[] iids) { }

	// RVA: 0x25B4C80 Offset: 0x25B4D81 VA: 0x25B4C80
	public int ItemAdd(ItemData item) { }

	// RVA: 0x2582470 Offset: 0x2582571 VA: 0x2582470
	public int ItemAdd(UnitItem unitItem) { }

	// RVA: 0x25B4DA0 Offset: 0x25B4EA1 VA: 0x25B4DA0
	public void ItemAddOnDlcEvil(string[] iids, ChapterData chapter, int level) { }

	// RVA: 0x25B6160 Offset: 0x25B6261 VA: 0x25B6160
	public bool EquipableItemAdd(string[] iids) { }

	// RVA: 0x25B6840 Offset: 0x25B6941 VA: 0x25B6840
	public void ItemMove(int from, int to) { }

	// RVA: 0x25950F0 Offset: 0x25951F1 VA: 0x25950F0
	public void ItemCloseUp() { }

	// RVA: 0x25970E0 Offset: 0x25971E1 VA: 0x25970E0
	public bool ItemEquip() { }

	// RVA: 0x259DC70 Offset: 0x259DD71 VA: 0x259DC70
	public bool ItemEquip(int index, bool reoder = True) { }

	// RVA: 0x259D3C0 Offset: 0x259D4C1 VA: 0x259D3C0
	private void ItemReorder() { }

	// RVA: 0x25B6850 Offset: 0x25B6951 VA: 0x25B6850
	public bool ItemEquip(UnitItem unitItem) { }

	// RVA: 0x25B6B30 Offset: 0x25B6C31 VA: 0x25B6B30
	public bool ItemEquip(ItemData itemData) { }

	// RVA: 0x25B6C80 Offset: 0x25B6D81 VA: 0x25B6C80
	public void ItemTakeOff(int index) { }

	// RVA: 0x25B2E00 Offset: 0x25B2F01 VA: 0x25B2E00
	public void ItemTakeOff(UnitItem unitItem) { }

	// RVA: 0x25B6CD0 Offset: 0x25B6DD1 VA: 0x25B6CD0
	public void ItemPutOff(int index, bool closeup = True) { }

	// RVA: 0x25B6D20 Offset: 0x25B6E21 VA: 0x25B6D20
	public void ItemPutOff(UnitItem unitItem, bool closeup = True) { }

	// RVA: 0x25B6FF0 Offset: 0x25B70F1 VA: 0x25B6FF0
	public void ItemPutOffAll() { }

	// RVA: 0x25B7030 Offset: 0x25B7131 VA: 0x25B7030
	public bool HasItem(ItemData item) { }

	// RVA: 0x25B7040 Offset: 0x25B7141 VA: 0x25B7040
	public int GetItemCount() { }

	// RVA: 0x25B7050 Offset: 0x25B7151 VA: 0x25B7050
	public UnitItem GetItemSelected() { }

	// RVA: 0x25B7060 Offset: 0x25B7161 VA: 0x25B7060
	public void SetItemSelected(UnitItem unitItem) { }

	// RVA: 0x25B7070 Offset: 0x25B7171 VA: 0x25B7070
	public bool HasEquipableItem() { }

	// RVA: 0x25B76B0 Offset: 0x25B77B1 VA: 0x25B76B0
	public bool HasEquipableItem(int range) { }

	// RVA: 0x25B7D90 Offset: 0x25B7E91 VA: 0x25B7D90
	public bool HasEquipableItem(ItemData.Kinds kind) { }

	// RVA: 0x25B83D0 Offset: 0x25B84D1 VA: 0x25B83D0
	public bool CanItemEquip(UnitItem unitItem, bool rod = True, bool exp = True) { }

	// RVA: 0x25B89A0 Offset: 0x25B8AA1 VA: 0x25B89A0
	public bool CanItemEquip(ItemData item, bool rod = True, bool weaponLevel = True) { }

	// RVA: 0x25B8F30 Offset: 0x25B9031 VA: 0x25B8F30
	public bool CanItemEquip(int index, bool rod = True, bool exp = True) { }

	// RVA: 0x25B9510 Offset: 0x25B9611 VA: 0x25B9510
	public bool CanItemKindEquip(ItemData.Kinds kind, bool rod = True, bool weaponMask = True) { }

	// RVA: 0x25B9560 Offset: 0x25B9661 VA: 0x25B9560
	public bool CanUseCannon(int x, int z) { }

	// RVA: 0x25BA2C0 Offset: 0x25BA3C1 VA: 0x25BA2C0
	public bool CanUseCannon(TerrainData terrain) { }

	// RVA: 0x25BAF20 Offset: 0x25BB021 VA: 0x25BAF20
	public bool NextItemEquip(bool reverse = False) { }

	// RVA: 0x25BB6D0 Offset: 0x25BB7D1 VA: 0x25BB6D0
	public bool IsItemSealed(UnitItem unitItem) { }

	// RVA: 0x25B8F20 Offset: 0x25B9021 VA: 0x25B8F20
	public bool IsItemSealed(ItemData item) { }

	// RVA: 0x25BB750 Offset: 0x25BB851 VA: 0x25BB750
	public bool IsItemSealed(int index) { }

	// RVA: 0x25BB7E0 Offset: 0x25BB8E1 VA: 0x25BB7E0
	public int GetItemIndexKeyDoor() { }

	// RVA: 0x25BBA20 Offset: 0x25BBB21 VA: 0x25BBA20
	public bool CanUnlockDoor(bool enableItem = True) { }

	// RVA: 0x25BBB20 Offset: 0x25BBC21 VA: 0x25BBB20
	public bool CanUnlockTreasureBox(bool enableItem = True) { }

	// RVA: 0x25BBB30 Offset: 0x25BBC31 VA: 0x25BBB30
	public int GetRangeI(int index, SkillData skill) { }

	// RVA: 0x25BBBF0 Offset: 0x25BBCF1 VA: 0x25BBBF0
	public int GetRangeI(ItemData item, SkillData skill) { }

	// RVA: 0x25BBCE0 Offset: 0x25BBDE1 VA: 0x25BBCE0
	public int GetRangeI(UnitItem unitItem, SkillData skill) { }

	// RVA: 0x25BC260 Offset: 0x25BC361 VA: 0x25BC260
	public int GetRangeO(int index, SkillData skill) { }

	// RVA: 0x25BC3B0 Offset: 0x25BC4B1 VA: 0x25BC3B0
	public int GetRangeO(ItemData item, SkillData skill) { }

	// RVA: 0x25BC310 Offset: 0x25BC411 VA: 0x25BC310
	public int GetRangeO(UnitItem unitItem, SkillData skill) { }

	// RVA: 0x25BC490 Offset: 0x25BC591 VA: 0x25BC490
	public bool GetRangeIO(int index, out int rangeI, out int rangeO, SkillData skill) { }

	// RVA: 0x25BC540 Offset: 0x25BC641 VA: 0x25BC540
	public bool GetRangeIO(ItemData item, out int rangeI, out int rangeO, SkillData skill) { }

	// RVA: 0x25BC630 Offset: 0x25BC731 VA: 0x25BC630
	public bool GetRangeIO(UnitItem unitItem, out int rangeI, out int rangeO, SkillData skill) { }

	// RVA: 0x25BC6E0 Offset: 0x25BC7E1 VA: 0x25BC6E0
	public int GetItemDistance(ItemData item) { }

	// RVA: 0x25BC8C0 Offset: 0x25BC9C1 VA: 0x25BC8C0
	public int GetRodRangeExtend(ItemData item) { }

	// RVA: 0x25BCA90 Offset: 0x25BCB91 VA: 0x25BCA90
	private bool GetItemRange(out int minRange, out int maxRange, ItemData item, SkillData skill) { }

	// RVA: 0x25BCBF0 Offset: 0x25BCCF1 VA: 0x25BCBF0
	private bool GetSkillRange(ref int minRange, ref int maxRange, SkillData skill) { }

	// RVA: 0x25BCC70 Offset: 0x25BCD71 VA: 0x25BCC70
	public bool GetItemRange(out int minRange, out int maxRange, UnitItem equipItem, SkillData skill) { }

	// RVA: 0x25BCDE0 Offset: 0x25BCEE1 VA: 0x25BCDE0
	public bool GetItemRange(out int minRange, out int maxRange, uint itemMask, SkillData skill) { }

	// RVA: 0x25BCF70 Offset: 0x25BD071 VA: 0x25BCF70
	public bool GetEngageRange(out int minRange, out int maxRange) { }

	// RVA: 0x25BDB00 Offset: 0x25BDC01 VA: 0x25BDB00
	public bool GetAttackRange(out int minRange, out int maxRange, SkillData skill) { }

	// RVA: 0x25BE2F0 Offset: 0x25BE3F1 VA: 0x25BE2F0
	public bool GetRodRange(out int minRange, out int maxRange, SkillData skill) { }

	// RVA: 0x25BEAE0 Offset: 0x25BEBE1 VA: 0x25BEAE0
	public bool GetAttackRange(out int minRange, out int maxRange, UnitItem equipItem, SkillData skill) { }

	// RVA: 0x25BF410 Offset: 0x25BF511 VA: 0x25BF410
	public bool GetRodRange(out int minRange, out int maxRange, UnitItem equipItem, SkillData skill) { }

	// RVA: 0x25BFD40 Offset: 0x25BFE41 VA: 0x25BFD40
	public UnitItem GetRevengeWeapon(Unit target, UnitItem targetItem, int range = -1) { }

	// RVA: 0x25C1040 Offset: 0x25C1141 VA: 0x25C1040
	public int GetRodHealPower(UnitItem unitItem) { }

	// RVA: 0x25C12A0 Offset: 0x25C13A1 VA: 0x25C12A0
	public bool CanItemUse(ItemData item) { }

	// RVA: 0x25C18E0 Offset: 0x25C19E1 VA: 0x25C18E0
	public bool CanItemUse(ItemData item, Unit targetUnit) { }

	// RVA: 0x25C1F10 Offset: 0x25C2011 VA: 0x25C1F10
	private void ItemUseImpl(ItemData item, ItemData.UseTypes useType, int power, SkillArray giveSkills) { }

	// RVA: 0x25C3210 Offset: 0x25C3311 VA: 0x25C3210
	public void ItemUse(ItemData item) { }

	// RVA: 0x25C3220 Offset: 0x25C3321 VA: 0x25C3220
	public void ItemEnchant(Unit unit, ItemData item) { }

	// RVA: 0x25C3290 Offset: 0x25C3391 VA: 0x25C3290
	public bool IsItemEnhanceHaving(ItemData itemData) { }

	// RVA: 0x25C32A0 Offset: 0x25C33A1 VA: 0x25C32A0
	public bool IsDrawActiveColor(UnitItem unitItem) { }

	// RVA: 0x25C3870 Offset: 0x25C3971 VA: 0x25C3870
	public UnitAccessoryList get_AccessoryList() { }

	// RVA: 0x25C3880 Offset: 0x25C3981 VA: 0x25C3880
	public void SetRing(UnitRing ring) { }

	// RVA: 0x25C3940 Offset: 0x25C3A41 VA: 0x25C3940
	private void SetRingImpl(UnitRing ring) { }

	// RVA: 0x25C39E0 Offset: 0x25C3AE1 VA: 0x25C39E0
	public void ClearRing() { }

	// RVA: 0x2584B90 Offset: 0x2584C91 VA: 0x2584B90
	private void ClearRingImpl() { }

	// RVA: 0x25C3A40 Offset: 0x25C3B41 VA: 0x25C3A40
	public UnitRing get_Ring() { }

	// RVA: 0x25C3A50 Offset: 0x25C3B51 VA: 0x25C3A50
	public int GetPower() { }

	// RVA: 0x25C4A00 Offset: 0x25C4B01 VA: 0x25C4A00
	public void SetGodUnit(GodUnit godUnit) { }

	// RVA: 0x25C4C00 Offset: 0x25C4D01 VA: 0x25C4C00
	public void SetGodUnitToCopy(GodUnit godUnit) { }

	// RVA: 0x25C4D40 Offset: 0x25C4E41 VA: 0x25C4D40
	public void ClearGodUnit() { }

	// RVA: 0x25C4E60 Offset: 0x25C4F61 VA: 0x25C4E60
	public void ClearGodUnitFromCopy() { }

	// RVA: 0x25A1080 Offset: 0x25A1181 VA: 0x25A1080
	public bool CanGodEquip(GodUnit godUnit) { }

	// RVA: 0x25902F0 Offset: 0x25903F1 VA: 0x25902F0
	public void ResetEngageCount() { }

	// RVA: 0x258F8B0 Offset: 0x258F9B1 VA: 0x258F8B0
	private void PlayEngageCancel() { }

	// RVA: 0x2590140 Offset: 0x2590241 VA: 0x2590140
	private void ResetEngaing() { }

	// RVA: 0x25C4AC0 Offset: 0x25C4BC1 VA: 0x25C4AC0
	private GodUnit TryConnectGodUnit(GodUnit godUnit) { }

	// RVA: 0x25C4C60 Offset: 0x25C4D61 VA: 0x25C4C60
	private GodUnit TryConnectGodUnitToCopy(GodUnit godUnit) { }

	// RVA: 0x2584630 Offset: 0x2584731 VA: 0x2584630
	private GodUnit TryDisconnectGodUnit() { }

	// RVA: 0x25901F0 Offset: 0x25902F1 VA: 0x25901F0
	private UnitRing TryDisconnectRing() { }

	// RVA: 0x25C4FA0 Offset: 0x25C50A1 VA: 0x25C4FA0
	private GodUnit TryDisconnectGodUnitFromCopy() { }

	// RVA: 0x25C5040 Offset: 0x25C5141 VA: 0x25C5040
	private GodUnit TryDisconnectGodLinkFromCopy() { }

	// RVA: 0x25C2FB0 Offset: 0x25C30B1 VA: 0x25C2FB0
	public bool SightUp(Unit unit, ItemData item) { }

	// RVA: 0x25C50E0 Offset: 0x25C51E1 VA: 0x25C50E0
	public bool CanRevive() { }

	// RVA: 0x25C5100 Offset: 0x25C5201 VA: 0x25C5100
	public bool IsAsphyxiation() { }

	// RVA: 0x25C5130 Offset: 0x25C5231 VA: 0x25C5130
	public void Revive() { }

	// RVA: 0x25C5320 Offset: 0x25C5421 VA: 0x25C5320
	public void ReviveForRewindV0(byte hpStockCount) { }

	// RVA: 0x25C5410 Offset: 0x25C5511 VA: 0x25C5410
	public void ReviveForRewindV1(byte plainHpStockCount, byte extraHpStockCount, byte extraHpStockCountMax) { }

	// RVA: 0x25C5510 Offset: 0x25C5611 VA: 0x25C5510
	public void SetGodState(int index, GodState state) { }

	// RVA: 0x25C56F0 Offset: 0x25C57F1 VA: 0x25C56F0
	public GodState GetGodState(int index) { }

	// RVA: 0x25C5750 Offset: 0x25C5851 VA: 0x25C5750
	public int GetGodStateCount() { }

	// RVA: 0x25C5650 Offset: 0x25C5751 VA: 0x25C5650
	public bool IsDefaultGodStates() { }

	// RVA: 0x25C56D0 Offset: 0x25C57D1 VA: 0x25C56D0
	public int GetCurrentGodStateIndex() { }

	// RVA: 0x259BE90 Offset: 0x259BF91 VA: 0x259BE90
	public GodState GetCurrentGodState() { }

	// RVA: 0x25C5770 Offset: 0x25C5871 VA: 0x25C5770
	public bool CanSetExtraHpStock() { }

	// RVA: 0x25C57C0 Offset: 0x25C58C1 VA: 0x25C57C0
	public bool HasExtraHpStock() { }

	// RVA: 0x25C57D0 Offset: 0x25C58D1 VA: 0x25C57D0
	public void SetExtraHpStock() { }

	// RVA: 0x2590220 Offset: 0x2590321 VA: 0x2590220
	public void ClearExtraHpStock() { }

	// RVA: 0x25C5820 Offset: 0x25C5921 VA: 0x25C5820
	public void ExtraHpStockForRewind(bool isSet, byte extraHpStockCount, byte extraHpStockCountMax) { }

	[ConditionalAttribute] // RVA: 0x2CBC00 Offset: 0x2CBD01 VA: 0x2CBC00
	// RVA: 0x25C5840 Offset: 0x25C5941 VA: 0x25C5840
	public void DbgSetHpStockCount(int count) { }

	// RVA: 0x25C52D0 Offset: 0x25C53D1 VA: 0x25C52D0
	private void UpdateGodUnitForGodState(GodState newGodState, GodState oldGodState) { }

	// RVA: 0x25C5960 Offset: 0x25C5A61 VA: 0x25C5960
	public void Serialize(Stream stream) { }

	// RVA: 0x25C5F30 Offset: 0x25C6031 VA: 0x25C5F30
	public void Deserialize(Stream stream) { }

	// RVA: 0x25C7AE0 Offset: 0x25C7BE1 VA: 0x25C7AE0
	public Unit get_Prev() { }

	// RVA: 0x25C7AF0 Offset: 0x25C7BF1 VA: 0x25C7AF0
	public void set_Prev(Unit value) { }

	// RVA: 0x25C7B00 Offset: 0x25C7C01 VA: 0x25C7B00
	public Unit get_Next() { }

	// RVA: 0x25C7B10 Offset: 0x25C7C11 VA: 0x25C7B10
	public void set_Next(Unit value) { }

	// RVA: 0x25C7B20 Offset: 0x25C7C21 VA: 0x25C7B20
	public UnitAI get_Ai() { }

	// RVA: 0x25C7B30 Offset: 0x25C7C31 VA: 0x25C7B30
	public UnitEdit get_Edit() { }

	// RVA: 0x25C7B40 Offset: 0x25C7C41 VA: 0x25C7B40
	public PersonData get_Person() { }

	// RVA: 0x25C7B50 Offset: 0x25C7C51 VA: 0x25C7B50
	public void set_Person(PersonData value) { }

	// RVA: 0x25AB4D0 Offset: 0x25AB5D1 VA: 0x25AB4D0
	public string get_Pid() { }

	// RVA: 0x25C7B60 Offset: 0x25C7C61 VA: 0x25C7B60
	public string get_PrefixlessPid() { }

	// RVA: 0x25C7C10 Offset: 0x25C7D11 VA: 0x25C7C10
	public JobData get_Job() { }

	// RVA: 0x25C7C20 Offset: 0x25C7D21 VA: 0x25C7C20
	public void set_Job(JobData value) { }

	// RVA: 0x25C7C30 Offset: 0x25C7D31 VA: 0x25C7C30
	public string get_Jid() { }

	// RVA: 0x25C7CE0 Offset: 0x25C7DE1 VA: 0x25C7CE0
	public string get_PrefixlessJid() { }

	// RVA: 0x25C7D90 Offset: 0x25C7E91 VA: 0x25C7D90
	public Force get_Force() { }

	// RVA: 0x25C7DA0 Offset: 0x25C7EA1 VA: 0x25C7DA0
	public void set_Force(Force value) { }

	// RVA: 0x25C7DB0 Offset: 0x25C7EB1 VA: 0x25C7DB0
	public Force.Type get_ForceType() { }

	// RVA: 0x25C7DD0 Offset: 0x25C7ED1 VA: 0x25C7DD0
	public uint get_ForceMask() { }

	// RVA: 0x25C7DF0 Offset: 0x25C7EF1 VA: 0x25C7DF0
	public UnitBaseCapability get_BaseCapability() { }

	// RVA: 0x25C7E00 Offset: 0x25C7F01 VA: 0x25C7E00
	public Capability get_GrowCapability() { }

	// RVA: 0x25C7E10 Offset: 0x25C7F11 VA: 0x25C7E10
	public UnitBaseCapability get_LevelCapability() { }

	// RVA: 0x25C7E20 Offset: 0x25C7F21 VA: 0x25C7E20
	public uint get_GrowSeed() { }

	// RVA: 0x25C7E30 Offset: 0x25C7F31 VA: 0x25C7E30
	public void set_GrowSeed(uint value) { }

	// RVA: 0x25C7E40 Offset: 0x25C7F41 VA: 0x25C7E40
	public uint get_DropSeed() { }

	// RVA: 0x25C7E50 Offset: 0x25C7F51 VA: 0x25C7E50
	public void set_DropSeed(uint value) { }

	// RVA: 0x25C7E60 Offset: 0x25C7F61 VA: 0x25C7E60
	public UnitActor get_Actor() { }

	// RVA: 0x25C7E70 Offset: 0x25C7F71 VA: 0x25C7E70
	public void set_Actor(UnitActor value) { }

	// RVA: 0x25C7E80 Offset: 0x25C7F81 VA: 0x25C7E80
	public MapInfoRoot get_Info() { }

	// RVA: 0x25C7E90 Offset: 0x25C7F91 VA: 0x25C7E90
	public void set_Info(MapInfoRoot value) { }

	// RVA: 0x25C7EA0 Offset: 0x25C7FA1 VA: 0x25C7EA0
	public UnitModel get_UnitModel() { }

	// RVA: 0x25C7EC0 Offset: 0x25C7FC1 VA: 0x25C7EC0
	public UnitModel get_GodModel() { }

	// RVA: 0x25C7EE0 Offset: 0x25C7FE1 VA: 0x25C7EE0
	public Vector3 get_Position() { }

	// RVA: 0x25C8BE0 Offset: 0x25C8CE1 VA: 0x25C8BE0
	public Vector3 get_CellCenterPosition() { }

	// RVA: 0x25CA350 Offset: 0x25CA451 VA: 0x25CA350
	public Vector3 get_Direction() { }

	// RVA: 0x25CA450 Offset: 0x25CA551 VA: 0x25CA450
	public int get_Index() { }

	// RVA: 0x25CA460 Offset: 0x25CA561 VA: 0x25CA460
	public void set_Index(int value) { }

	// RVA: 0x25CA470 Offset: 0x25CA571 VA: 0x25CA470
	public int get_BmapSize() { }

	// RVA: 0x25CA490 Offset: 0x25CA591 VA: 0x25CA490
	public BattleStyle.Types get_Style() { }

	// RVA: 0x25CA4A0 Offset: 0x25CA5A1 VA: 0x25CA4A0
	public int get_X() { }

	// RVA: 0x2598B50 Offset: 0x2598C51 VA: 0x2598B50
	public void set_X(int value) { }

	// RVA: 0x25CA4B0 Offset: 0x25CA5B1 VA: 0x25CA4B0
	public int get_Z() { }

	// RVA: 0x2598B60 Offset: 0x2598C61 VA: 0x2598B60
	public void set_Z(int value) { }

	// RVA: 0x25CA4C0 Offset: 0x25CA5C1 VA: 0x25CA4C0
	public int get_DisposX() { }

	// RVA: 0x25CA4D0 Offset: 0x25CA5D1 VA: 0x25CA4D0
	public void set_DisposX(int value) { }

	// RVA: 0x25CA4E0 Offset: 0x25CA5E1 VA: 0x25CA4E0
	public int get_DisposZ() { }

	// RVA: 0x25CA4F0 Offset: 0x25CA5F1 VA: 0x25CA4F0
	public void set_DisposZ(int value) { }

	// RVA: 0x25CA500 Offset: 0x25CA601 VA: 0x25CA500
	public int get_CenterX() { }

	// RVA: 0x25CA520 Offset: 0x25CA621 VA: 0x25CA520
	public int get_CenterZ() { }

	// RVA: 0x25CA540 Offset: 0x25CA641 VA: 0x25CA540
	public float get_Angle() { }

	// RVA: 0x25CA550 Offset: 0x25CA651 VA: 0x25CA550
	public void set_Angle(float value) { }

	// RVA: 0x25CA560 Offset: 0x25CA661 VA: 0x25CA560
	public int get_DisposSound() { }

	// RVA: 0x25CA580 Offset: 0x25CA681 VA: 0x25CA580
	public JobData.MoveTypes get_MoveType() { }

	// RVA: 0x25CA5A0 Offset: 0x25CA6A1 VA: 0x25CA5A0
	public int get_Level() { }

	// RVA: 0x2583D80 Offset: 0x2583E81 VA: 0x2583D80
	public void set_Level(int value) { }

	// RVA: 0x25CA5B0 Offset: 0x25CA6B1 VA: 0x25CA5B0
	public int get_LimitLevel() { }

	// RVA: 0x25CA5C0 Offset: 0x25CA6C1 VA: 0x25CA5C0
	public int get_Exp() { }

	// RVA: 0x25AF680 Offset: 0x25AF781 VA: 0x25AF680
	public void set_Exp(int value) { }

	// RVA: 0x25CA5D0 Offset: 0x25CA6D1 VA: 0x25CA5D0
	public int get_SkillPoint() { }

	// RVA: 0x2583C40 Offset: 0x2583D41 VA: 0x2583C40
	public void set_SkillPoint(int value) { }

	// RVA: 0x25CA5E0 Offset: 0x25CA6E1 VA: 0x25CA5E0
	public int get_Hp() { }

	// RVA: 0x2583D90 Offset: 0x2583E91 VA: 0x2583D90
	public void set_Hp(int value) { }

	// RVA: 0x25CA5F0 Offset: 0x25CA6F1 VA: 0x25CA5F0
	public int get_DisplayHp() { }

	// RVA: 0x25CA600 Offset: 0x25CA701 VA: 0x25CA600
	public int get_HpStockCount() { }

	// RVA: 0x25CA610 Offset: 0x25CA711 VA: 0x25CA610
	public int get_HpStockCountMax() { }

	// RVA: 0x25CA620 Offset: 0x25CA721 VA: 0x25CA620
	public int get_PlainHpStockCount() { }

	// RVA: 0x25CA630 Offset: 0x25CA731 VA: 0x25CA630
	public void set_PlainHpStockCount(int value) { }

	// RVA: 0x25CA640 Offset: 0x25CA741 VA: 0x25CA640
	public int get_PlainHpStockCountMax() { }

	// RVA: 0x25CA650 Offset: 0x25CA751 VA: 0x25CA650
	public int get_ExtraHpStockCount() { }

	// RVA: 0x25CA660 Offset: 0x25CA761 VA: 0x25CA660
	public int get_ExtraHpStockCountMax() { }

	// RVA: 0x25CA670 Offset: 0x25CA771 VA: 0x25CA670
	public int get_BaseMovePower() { }

	// RVA: 0x25CA6D0 Offset: 0x25CA7D1 VA: 0x25CA6D0
	public UnitItemList get_ItemList() { }

	// RVA: 0x25CA6E0 Offset: 0x25CA7E1 VA: 0x25CA6E0
	public GodUnit get_GodUnit() { }

	// RVA: 0x25CA700 Offset: 0x25CA801 VA: 0x25CA700
	public GodUnit get_ActualGodUnit() { }

	// RVA: 0x25CA710 Offset: 0x25CA811 VA: 0x25CA710
	public int get_ExtraSight() { }

	// RVA: 0x25CA720 Offset: 0x25CA821 VA: 0x25CA720
	public void set_ExtraSight(int value) { }

	// RVA: 0x25CA730 Offset: 0x25CA831 VA: 0x25CA730
	public int get_MoveDistance() { }

	// RVA: 0x25CA740 Offset: 0x25CA841 VA: 0x25CA740
	public object get_MaskSkillLock() { }

	// RVA: 0x25CA750 Offset: 0x25CA851 VA: 0x25CA750
	public SkillArray get_MaskSkill() { }

	// RVA: 0x25CA760 Offset: 0x25CA861 VA: 0x25CA760
	public SkillArray get_EquipSkill() { }

	// RVA: 0x25CA770 Offset: 0x25CA871 VA: 0x25CA770
	public SkillArray get_PrivateSkill() { }

	// RVA: 0x25CA780 Offset: 0x25CA881 VA: 0x25CA780
	public SkillArray get_SupportedSkill() { }

	// RVA: 0x25CA790 Offset: 0x25CA891 VA: 0x25CA790
	public SkillArray get_ReceiveSkill() { }

	// RVA: 0x25CA7A0 Offset: 0x25CA8A1 VA: 0x25CA7A0
	public SkillArray get_EquipSkillPool() { }

	// RVA: 0x25CA7B0 Offset: 0x25CA8B1 VA: 0x25CA7B0
	public SkillData get_LearnedJobSkill() { }

	// RVA: 0x25CA7C0 Offset: 0x25CA8C1 VA: 0x25CA7C0
	public void set_LearnedJobSkill(SkillData value) { }

	// RVA: 0x25CA7D0 Offset: 0x25CA8D1 VA: 0x25CA7D0
	public WeaponMask get_OriginalAptitude() { }

	// RVA: 0x25CA7E0 Offset: 0x25CA8E1 VA: 0x25CA7E0
	public WeaponMask get_Aptitude() { }

	// RVA: 0x25CA7F0 Offset: 0x25CA8F1 VA: 0x25CA7F0
	public WeaponMask get_WeaponMask() { }

	// RVA: 0x25CA800 Offset: 0x25CA901 VA: 0x25CA800
	public WeaponMask get_SelectedWeaponMask() { }

	// RVA: 0x25CA810 Offset: 0x25CA911 VA: 0x25CA810
	public UnitEnhanceFactors get_EnhanceFactors() { }

	// RVA: 0x25CA820 Offset: 0x25CA921 VA: 0x25CA820
	public int get_InternalLevel() { }

	// RVA: 0x2582AF0 Offset: 0x2582BF1 VA: 0x2582AF0
	public void set_InternalLevel(int value) { }

	// RVA: 0x25CA830 Offset: 0x25CA931 VA: 0x25CA830
	public sbyte get_LastPickVoice() { }

	// RVA: 0x25CA840 Offset: 0x25CA941 VA: 0x25CA840
	public void set_LastPickVoice(sbyte value) { }

	// RVA: 0x25CA850 Offset: 0x25CA951 VA: 0x25CA850
	public int GetMaxStun() { }

	// RVA: 0x25CA860 Offset: 0x25CA961 VA: 0x25CA860
	public int GetStun() { }

	// RVA: 0x25CA970 Offset: 0x25CAA71 VA: 0x25CA970
	public int get_EngageCount() { }

	// RVA: 0x259BE80 Offset: 0x259BF81 VA: 0x259BE80
	public void set_EngageCount(int value) { }

	// RVA: 0x25CA980 Offset: 0x25CAA81 VA: 0x25CA980
	public void PlaySetEngageCount(int engageCount, Unit targetUnit) { }

	// RVA: 0x25CD180 Offset: 0x25CD281 VA: 0x25CD180
	public void PlaySetEngageCount(Vector3 start, Vector3 goal, int count) { }

	// RVA: 0x25CD350 Offset: 0x25CD451 VA: 0x25CD350
	public int GetEngageCountView() { }

	// RVA: 0x25CD3F0 Offset: 0x25CD4F1 VA: 0x25CD3F0
	public void SetEngageCountView(int count) { }

	// RVA: 0x25CD410 Offset: 0x25CD511 VA: 0x25CD410
	public int GetEngageCountLimit() { }

	// RVA: 0x25CD4B0 Offset: 0x25CD5B1 VA: 0x25CD4B0
	public int get_EngageTurn() { }

	// RVA: 0x25C50D0 Offset: 0x25C51D1 VA: 0x25C50D0
	public void set_EngageTurn(int value) { }

	// RVA: 0x25CD4C0 Offset: 0x25CD5C1 VA: 0x25CD4C0
	public int GetRemainingEngageTurn() { }

	// RVA: 0x25CD5E0 Offset: 0x25CD6E1 VA: 0x25CD5E0
	public int GetEngageTurnLimit() { }

	// RVA: 0x25CD700 Offset: 0x25CD801 VA: 0x25CD700
	public float GetAlpha() { }

	// RVA: 0x25CD810 Offset: 0x25CD911 VA: 0x25CD810
	public int get_Ident() { }

	// RVA: 0x25CD820 Offset: 0x25CD921 VA: 0x25CD820
	public void set_Ident(int value) { }

	// RVA: 0x25CD830 Offset: 0x25CD931 VA: 0x25CD830
	public UnitRecord get_Record() { }

	// RVA: 0x25CD840 Offset: 0x25CD941 VA: 0x25CD840
	public int get_MapHistoryIndex() { }

	// RVA: 0x25CD850 Offset: 0x25CD951 VA: 0x25CD850
	public void set_MapHistoryIndex(int value) { }

	// RVA: 0x25CD860 Offset: 0x25CD961 VA: 0x25CD860
	public int get_RelayPlayerIndex() { }

	// RVA: 0x25CD870 Offset: 0x25CD971 VA: 0x25CD870
	public void set_RelayPlayerIndex(int value) { }

	// RVA: 0x257F1E0 Offset: 0x257F2E1 VA: 0x257F1E0
	private void CreateImpl1(PersonData person, JobData job, int level, Random random) { }

	// RVA: 0x25CD880 Offset: 0x25CD981 VA: 0x25CD880
	private void TryCopyEdit() { }

	// RVA: 0x257F600 Offset: 0x257F701 VA: 0x257F600
	private void CreateImpl2() { }

	// RVA: 0x257F960 Offset: 0x257FA61 VA: 0x257F960
	private void SetDispos(DisposData data) { }

	// RVA: 0x25CD8E0 Offset: 0x25CD9E1 VA: 0x25CD8E0
	private void SetDisposWeaponMask(DisposData data) { }

	// RVA: 0x25CD9B0 Offset: 0x25CDAB1 VA: 0x25CD9B0
	private void SetDisposSkill(DisposData data) { }

	// RVA: 0x25CDA60 Offset: 0x25CDB61 VA: 0x25CDA60
	private void SetDisposGod(DisposData data) { }

	// RVA: 0x2581CA0 Offset: 0x2581DA1 VA: 0x2581CA0
	private bool AddPersonItem(PersonData person) { }

	// RVA: 0x2581D40 Offset: 0x2581E41 VA: 0x2581D40
	private bool AddDisposItem(DisposData data) { }

	// RVA: 0x2582480 Offset: 0x2582581 VA: 0x2582480
	private void SetDisposBelong(DisposData data) { }

	// RVA: 0x2582490 Offset: 0x2582591 VA: 0x2582490
	private void SetDisposAi(DisposData data) { }

	// RVA: 0x25CDB50 Offset: 0x25CDC51 VA: 0x25CDB50
	private GodState[] CreateGodStates(DisposData data) { }

	// RVA: 0x25CDCD0 Offset: 0x25CDDD1 VA: 0x25CDCD0
	private GodState GetGodState(DisposData data, int index, GodState prevState) { }

	// RVA: 0x25CDCC0 Offset: 0x25CDDC1 VA: 0x25CDCC0
	private GodState DisposState2GodState(DisposData.State disposState) { }

	// RVA: 0x2583800 Offset: 0x2583901 VA: 0x2583800
	private void SetupForVision(Unit original) { }

	// RVA: 0x25834A0 Offset: 0x25835A1 VA: 0x25834A0
	private void CreateImpl2ExcludeInternalLevel() { }

	// RVA: 0x25CDD40 Offset: 0x25CDE41 VA: 0x25CDD40
	private void SetupCapabilityForVision(Unit original) { }

	// RVA: 0x25CFDC0 Offset: 0x25CFEC1 VA: 0x25CFDC0
	private PersonData GetSafePerson() { }

	// RVA: 0x25CFE50 Offset: 0x25CFF51 VA: 0x25CFE50
	private JobData GetSafeJob() { }

	// RVA: 0x2583C50 Offset: 0x2583D51 VA: 0x2583C50
	private void CalculateAutoGrowCapability(CapabilityInt percents) { }

	// RVA: 0x25CFEE0 Offset: 0x25CFFE1 VA: 0x25CFEE0
	private int GetMaxHpImpl(bool calcEnhance) { }

	// RVA: 0x25D0070 Offset: 0x25D0171 VA: 0x25D0070
	private int GetStrImpl(bool calcEnhance) { }

	// RVA: 0x25D01F0 Offset: 0x25D02F1 VA: 0x25D01F0
	private int GetTechImpl(bool calcEnhance) { }

	// RVA: 0x25D0370 Offset: 0x25D0471 VA: 0x25D0370
	private int GetQuickImpl(bool calcEnhance) { }

	// RVA: 0x25D04F0 Offset: 0x25D05F1 VA: 0x25D04F0
	private int GetLuckImpl(bool calcEnhance) { }

	// RVA: 0x25D0670 Offset: 0x25D0771 VA: 0x25D0670
	private int GetDefImpl(bool calcEnhance) { }

	// RVA: 0x25D0800 Offset: 0x25D0901 VA: 0x25D0800
	private int GetMagicImpl(bool calcEnhance) { }

	// RVA: 0x25D0990 Offset: 0x25D0A91 VA: 0x25D0990
	private int GetMdefImpl(bool calcEnhance) { }

	// RVA: 0x25D0B20 Offset: 0x25D0C21 VA: 0x25D0B20
	private int GetPhysImpl(bool calcEnhance) { }

	// RVA: 0x25D0CB0 Offset: 0x25D0DB1 VA: 0x25D0CB0
	private int GetSightImpl(bool calcEnhance) { }

	// RVA: 0x25D0F10 Offset: 0x25D1011 VA: 0x25D0F10
	private int GetMovePowerImpl(bool calcEnhance) { }

	// RVA: 0x25D12A0 Offset: 0x25D13A1 VA: 0x25D12A0
	private int GetCapabilityImpl(CapabilityDefinition.Type type, bool calcEnhance) { }

	// RVA: 0x25D1440 Offset: 0x25D1541 VA: 0x25D1440
	public int GetTotalLevel() { }

	// RVA: 0x25D1450 Offset: 0x25D1551 VA: 0x25D1450
	public int GetOrder() { }

	// RVA: 0x25BBD80 Offset: 0x25BBE81 VA: 0x25BBD80
	private bool CalcItemRange(ItemData item, out int rangeI, out int rangeO, SkillData skill) { }

	// RVA: 0x25C2F50 Offset: 0x25C3051 VA: 0x25C2F50
	private CapabilitySbyte GetItemGrowCapability(ItemData item) { }

	// RVA: 0x25D1490 Offset: 0x25D1591 VA: 0x25D1490
	public MapDeployAttackImage get_AttackImage() { }

	// RVA: 0x25D14A0 Offset: 0x25D15A1 VA: 0x25D14A0
	public MapDeployRodImage get_RodImage() { }

	// RVA: 0x25D14B0 Offset: 0x25D15B1 VA: 0x25D14B0
	public MapDeployHealImage get_HealImage() { }

	// RVA: 0x25D14C0 Offset: 0x25D15C1 VA: 0x25D14C0
	public MapDeploySupportImage get_SupportImage() { }

	// RVA: 0x25D14D0 Offset: 0x25D15D1 VA: 0x25D14D0
	public MapDeployInterferenceImage get_InterferenceImage() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBC40 Offset: 0x2CBD41 VA: 0x2CBC40
	// RVA: 0x25D14E0 Offset: 0x25D15E1 VA: 0x25D14E0
	public int get_TotalOrder() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBC50 Offset: 0x2CBD51 VA: 0x2CBC50
	// RVA: 0x25D14F0 Offset: 0x25D15F1 VA: 0x25D14F0
	public void set_TotalOrder(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBC60 Offset: 0x2CBD61 VA: 0x2CBC60
	// RVA: 0x25D1500 Offset: 0x25D1601 VA: 0x25D1500
	public int get_TotalAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBC70 Offset: 0x2CBD71 VA: 0x2CBC70
	// RVA: 0x25D1510 Offset: 0x25D1611 VA: 0x25D1510
	public void set_TotalAction(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBC80 Offset: 0x2CBD81 VA: 0x2CBC80
	// RVA: 0x25D1520 Offset: 0x25D1621 VA: 0x25D1520
	public int get_TotalAttack() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBC90 Offset: 0x2CBD91 VA: 0x2CBC90
	// RVA: 0x25D1530 Offset: 0x25D1631 VA: 0x25D1530
	public void set_TotalAttack(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBCA0 Offset: 0x2CBDA1 VA: 0x2CBCA0
	// RVA: 0x25D1540 Offset: 0x25D1641 VA: 0x25D1540
	public int get_TotalDamage() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBCB0 Offset: 0x2CBDB1 VA: 0x2CBCB0
	// RVA: 0x25D1550 Offset: 0x25D1651 VA: 0x25D1550
	public void set_TotalDamage(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBCC0 Offset: 0x2CBDC1 VA: 0x2CBCC0
	// RVA: 0x25D1560 Offset: 0x25D1661 VA: 0x25D1560
	public BattleScene.Result get_TotalResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBCD0 Offset: 0x2CBDD1 VA: 0x2CBCD0
	// RVA: 0x25D1570 Offset: 0x25D1671 VA: 0x25D1570
	public void set_TotalResult(BattleScene.Result value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBCE0 Offset: 0x2CBDE1 VA: 0x2CBCE0
	// RVA: 0x25D1580 Offset: 0x25D1681 VA: 0x25D1580
	public BattleSide.Type get_SideType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBCF0 Offset: 0x2CBDF1 VA: 0x2CBCF0
	// RVA: 0x25D1590 Offset: 0x25D1691 VA: 0x25D1590
	public void set_SideType(BattleSide.Type value) { }

	// RVA: 0x25D15A0 Offset: 0x25D16A1 VA: 0x25D15A0
	public void UpdateImage(MapDnagerDeploy deploy) { }

	// RVA: 0x25846D0 Offset: 0x25847D1 VA: 0x25846D0
	private void ClearImage() { }

	// RVA: 0x25D1850 Offset: 0x25D1951 VA: 0x25D1850
	private bool TryGetEngageMind(out MapMind.Type mind) { }

	// RVA: 0x2597010 Offset: 0x2597111 VA: 0x2597010
	public SkillData GetEngageAttack() { }

	// RVA: 0x2596FF0 Offset: 0x25970F1 VA: 0x2596FF0
	public SkillArray GetEngageSkills() { }

	// RVA: 0x25D19A0 Offset: 0x25D1AA1 VA: 0x25D19A0
	public SkillData GetEngageSkill(int index) { }

	// RVA: 0x25D19D0 Offset: 0x25D1AD1 VA: 0x25D19D0
	public SkillData GetSupportSkill() { }

	// RVA: 0x25D1C00 Offset: 0x25D1D01 VA: 0x25D1C00
	public void AddCannonSkill(CannonInspector inspector) { }

	// RVA: 0x25D1D40 Offset: 0x25D1E41 VA: 0x25D1D40
	public void RemoveCannonSkill(CannonInspector inspector) { }

	// RVA: 0x25D1DE0 Offset: 0x25D1EE1 VA: 0x25D1DE0
	private static SkillArray GetCommandGiveSkills(SkillData skill) { }

	// RVA: 0x25D1E80 Offset: 0x25D1F81 VA: 0x25D1E80
	public void AddCommandSkill(SkillData skill) { }

	// RVA: 0x25D2700 Offset: 0x25D2801 VA: 0x25D2700
	public void RemoveCommandSkill(SkillData skill) { }

	// RVA: 0x25D2CB0 Offset: 0x25D2DB1 VA: 0x25D2CB0
	public void AddGiveSkill(SkillData give) { }

	// RVA: 0x25D2D60 Offset: 0x25D2E61 VA: 0x25D2D60
	public void AddGiveSkill(SkillArray gives) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBD00 Offset: 0x2CBE01 VA: 0x2CBD00
	// RVA: 0x25D2F50 Offset: 0x25D3051 VA: 0x25D2F50
	public int get_BattleTemporary() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBD10 Offset: 0x2CBE11 VA: 0x2CBD10
	// RVA: 0x25D2F60 Offset: 0x25D3061 VA: 0x25D2F60
	public void set_BattleTemporary(int value) { }

	// RVA: 0x25980F0 Offset: 0x25981F1 VA: 0x25980F0
	public bool IsExistDie() { }

	// RVA: 0x25D2F70 Offset: 0x25D3071 VA: 0x25D2F70
	public void UpdateMoveDistance() { }

	// RVA: 0x25D2F80 Offset: 0x25D3081 VA: 0x25D2F80
	public void UpdateMoveDistance(int x, int z) { }

	// RVA: 0x25D30C0 Offset: 0x25D31C1 VA: 0x25D30C0
	public void UpdateMoveDistance(MapRoute route, int x, int z) { }

	// RVA: 0x2594460 Offset: 0x2594561 VA: 0x2594460
	public void ClearMoveDistance() { }

	// RVA: 0x25D3200 Offset: 0x25D3301 VA: 0x25D3200
	public bool CanGrowUp(CapabilityDefinition.Type type) { }

	// RVA: 0x25D3360 Offset: 0x25D3461 VA: 0x25D3360
	public int GetSimplePower() { }

	// RVA: 0x25D3390 Offset: 0x25D3491 VA: 0x25D3390
	public int GetSimplePhysicalPower() { }

	// RVA: 0x25D33C0 Offset: 0x25D34C1 VA: 0x25D33C0
	public int GetSimpleMagicPower() { }

	// RVA: 0x25D33F0 Offset: 0x25D34F1 VA: 0x25D33F0
	public int GetSimplePhysicalDefense() { }

	// RVA: 0x25D3420 Offset: 0x25D3521 VA: 0x25D3420
	public int GetSimpleMagicDefense() { }

	// RVA: 0x25D3450 Offset: 0x25D3551 VA: 0x25D3450
	public int GetSimpleHit() { }

	// RVA: 0x25D3480 Offset: 0x25D3581 VA: 0x25D3480
	public int GetSimpleAvoid() { }

	// RVA: 0x25D34B0 Offset: 0x25D35B1 VA: 0x25D34B0
	public int GetSimpleCritical() { }

	// RVA: 0x25D34E0 Offset: 0x25D35E1 VA: 0x25D34E0
	public int GetSimpleSecure() { }

	// RVA: 0x25D3510 Offset: 0x25D3611 VA: 0x25D3510
	public int GetSimpleContinuous() { }

	// RVA: 0x25D3540 Offset: 0x25D3641 VA: 0x25D3540
	public void ResetParam() { }

	// RVA: 0x25D3770 Offset: 0x25D3871 VA: 0x25D3770
	public uint get_FortuneSeed() { }

	// RVA: 0x25D3780 Offset: 0x25D3881 VA: 0x25D3780
	public void set_FortuneSeed(uint value) { }

	// RVA: 0x25D3790 Offset: 0x25D3891 VA: 0x25D3790
	public PersonData get_FortuneTarget() { }

	// RVA: 0x25D37A0 Offset: 0x25D38A1 VA: 0x25D37A0
	public void set_FortuneTarget(PersonData value) { }

	// RVA: 0x25D37B0 Offset: 0x25D38B1 VA: 0x25D37B0
	public int GetFortuneRandomValue(bool update) { }

	// RVA: 0x25823F0 Offset: 0x25824F1 VA: 0x25823F0
	public WeaponLevel.Kind GetWeaponLevel(ItemData.Kinds kind, bool calcEnhance = True) { }

	// RVA: 0x259F1D0 Offset: 0x259F2D1 VA: 0x259F1D0
	public UnitItem GetSkillEquip(SkillData skill, int index = -1) { }

	// RVA: 0x25BD140 Offset: 0x25BD241 VA: 0x25BD140
	public UnitItem GetEngageEquip(SkillData skill, Unit target) { }

	// RVA: 0x25CC500 Offset: 0x25CC601 VA: 0x25CC500
	public Vector3 GetEffectPosition() { }

	// RVA: 0x25D3850 Offset: 0x25D3951 VA: 0x25D3850
	public bool CanStayWithoutGod() { }

	// RVA: 0x25D3AE0 Offset: 0x25D3BE1 VA: 0x25D3AE0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBD20 Offset: 0x2CBE21 VA: 0x2CBD20
	// RVA: 0x25B30C0 Offset: 0x25B31C1 VA: 0x25B30C0
	private bool <SetOptimalWeaponForClassChange>g__SetWeaponInArray|416_0(HashSet<ItemData.Kinds> kinds, ref Unit.<>c__DisplayClass416_0 ) { }
}

