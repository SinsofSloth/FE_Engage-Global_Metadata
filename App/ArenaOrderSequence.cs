// Namespace: App
public class ArenaOrderSequence : SingletonProcInst<ArenaOrderSequence> // TypeDefIndex: 10463
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28E230 Offset: 0x28E331 VA: 0x28E230
	private List<Unit> <SelectableUnit>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x28E240 Offset: 0x28E341 VA: 0x28E240
	private List<ArenaOrderSequence.GodInfo> <SelectableGod>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x28E250 Offset: 0x28E351 VA: 0x28E250
	private bool <IsEmblemBattle>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x28E260 Offset: 0x28E361 VA: 0x28E260
	private bool <IsSpecialBattle>k__BackingField; // 0x89
	[CompilerGeneratedAttribute] // RVA: 0x28E270 Offset: 0x28E371 VA: 0x28E270
	private ArenaOrderSequence.TrainType <TrainingType>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x28E280 Offset: 0x28E381 VA: 0x28E280
	private Unit <TrainingUnit>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x28E290 Offset: 0x28E391 VA: 0x28E290
	private Unit <BattleUnit>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x28E2A0 Offset: 0x28E3A1 VA: 0x28E2A0
	private GodUnit <BattleEmblem>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x28E2B0 Offset: 0x28E3B1 VA: 0x28E2B0
	private RingCleaningSequence.GodType <EmblemType>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x28E2C0 Offset: 0x28E3C1 VA: 0x28E2C0
	private int <BondExp>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x28E2D0 Offset: 0x28E3D1 VA: 0x28E2D0
	private BattleCalculator <Calculator>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x28E2E0 Offset: 0x28E3E1 VA: 0x28E2E0
	private BattleCalculator <SimCalculator>k__BackingField; // 0xB8
	private ArenaExpUnitSelectRoot m_ExpUnitSelectRoot; // 0xC0
	private ArenaBondUnitSelectRoot m_BondUnitSelectRoot; // 0xC8
	private ArenaBondGodSelectRoot m_BondEmblemSelectRoot; // 0xD0
	private ArenaBondLevelSelectRoot m_BondLevelSelectRoot; // 0xD8
	private ArenaOrderSequence.Label m_NextLabel; // 0xE0
	private bool m_IsBackBondSelectEmblem; // 0xE4
	private List<GameObject> m_ArenaObjects; // 0xE8
	private GodUnit m_GodUnit; // 0xF0
	private UnitRing m_Ring; // 0xF8

	// Properties
	public List<Unit> SelectableUnit { get; set; }
	public List<ArenaOrderSequence.GodInfo> SelectableGod { get; set; }
	private bool IsEmblemBattle { get; set; }
	private bool IsSpecialBattle { get; set; }
	private ArenaOrderSequence.TrainType TrainingType { get; set; }
	private Unit TrainingUnit { get; set; }
	private Unit BattleUnit { get; set; }
	private GodUnit BattleEmblem { get; set; }
	private RingCleaningSequence.GodType EmblemType { get; set; }
	private int BondExp { get; set; }
	private BattleCalculator Calculator { get; set; }
	private BattleCalculator SimCalculator { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BE480 Offset: 0x2BE581 VA: 0x2BE480
	// RVA: 0x2109320 Offset: 0x2109421 VA: 0x2109320
	public List<Unit> get_SelectableUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE490 Offset: 0x2BE591 VA: 0x2BE490
	// RVA: 0x2109330 Offset: 0x2109431 VA: 0x2109330
	public void set_SelectableUnit(List<Unit> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE4A0 Offset: 0x2BE5A1 VA: 0x2BE4A0
	// RVA: 0x2109340 Offset: 0x2109441 VA: 0x2109340
	public List<ArenaOrderSequence.GodInfo> get_SelectableGod() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE4B0 Offset: 0x2BE5B1 VA: 0x2BE4B0
	// RVA: 0x2109350 Offset: 0x2109451 VA: 0x2109350
	public void set_SelectableGod(List<ArenaOrderSequence.GodInfo> value) { }

	// RVA: 0x21025E0 Offset: 0x21026E1 VA: 0x21025E0
	public void SetupSelectableGodList(Unit unit) { }

	// RVA: 0x2102910 Offset: 0x2102A11 VA: 0x2102910
	public static bool IsSelectableGod(GodUnit god, Unit unit) { }

	// RVA: 0x2109360 Offset: 0x2109461 VA: 0x2109360
	private static bool IsSelectableGodImpl(GodUnit god) { }

	// RVA: 0x2104450 Offset: 0x2104551 VA: 0x2104450
	public static int GetNextLevelCap(Unit unit, GodUnit god, bool isCapOver, out bool isLevelCapCount) { }

	// RVA: 0x21044F0 Offset: 0x21045F1 VA: 0x21044F0
	public static bool IsLevelCapTalk(Unit unit, GodUnit god) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE4C0 Offset: 0x2BE5C1 VA: 0x2BE4C0
	// RVA: 0x21093E0 Offset: 0x21094E1 VA: 0x21093E0
	private bool get_IsEmblemBattle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE4D0 Offset: 0x2BE5D1 VA: 0x2BE4D0
	// RVA: 0x21093F0 Offset: 0x21094F1 VA: 0x21093F0
	private void set_IsEmblemBattle(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE4E0 Offset: 0x2BE5E1 VA: 0x2BE4E0
	// RVA: 0x2109400 Offset: 0x2109501 VA: 0x2109400
	private bool get_IsSpecialBattle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE4F0 Offset: 0x2BE5F1 VA: 0x2BE4F0
	// RVA: 0x2109410 Offset: 0x2109511 VA: 0x2109410
	private void set_IsSpecialBattle(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE500 Offset: 0x2BE601 VA: 0x2BE500
	// RVA: 0x2109420 Offset: 0x2109521 VA: 0x2109420
	private ArenaOrderSequence.TrainType get_TrainingType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE510 Offset: 0x2BE611 VA: 0x2BE510
	// RVA: 0x2109430 Offset: 0x2109531 VA: 0x2109430
	private void set_TrainingType(ArenaOrderSequence.TrainType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE520 Offset: 0x2BE621 VA: 0x2BE520
	// RVA: 0x2109440 Offset: 0x2109541 VA: 0x2109440
	private Unit get_TrainingUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE530 Offset: 0x2BE631 VA: 0x2BE530
	// RVA: 0x2109450 Offset: 0x2109551 VA: 0x2109450
	private void set_TrainingUnit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE540 Offset: 0x2BE641 VA: 0x2BE540
	// RVA: 0x2109460 Offset: 0x2109561 VA: 0x2109460
	private Unit get_BattleUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE550 Offset: 0x2BE651 VA: 0x2BE550
	// RVA: 0x2109470 Offset: 0x2109571 VA: 0x2109470
	private void set_BattleUnit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE560 Offset: 0x2BE661 VA: 0x2BE560
	// RVA: 0x2109480 Offset: 0x2109581 VA: 0x2109480
	private GodUnit get_BattleEmblem() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE570 Offset: 0x2BE671 VA: 0x2BE570
	// RVA: 0x2109490 Offset: 0x2109591 VA: 0x2109490
	private void set_BattleEmblem(GodUnit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE580 Offset: 0x2BE681 VA: 0x2BE580
	// RVA: 0x21094A0 Offset: 0x21095A1 VA: 0x21094A0
	private RingCleaningSequence.GodType get_EmblemType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE590 Offset: 0x2BE691 VA: 0x2BE590
	// RVA: 0x21094B0 Offset: 0x21095B1 VA: 0x21094B0
	private void set_EmblemType(RingCleaningSequence.GodType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE5A0 Offset: 0x2BE6A1 VA: 0x2BE5A0
	// RVA: 0x21094C0 Offset: 0x21095C1 VA: 0x21094C0
	private int get_BondExp() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE5B0 Offset: 0x2BE6B1 VA: 0x2BE5B0
	// RVA: 0x21094D0 Offset: 0x21095D1 VA: 0x21094D0
	private void set_BondExp(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE5C0 Offset: 0x2BE6C1 VA: 0x2BE5C0
	// RVA: 0x21094E0 Offset: 0x21095E1 VA: 0x21094E0
	private BattleCalculator get_Calculator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE5D0 Offset: 0x2BE6D1 VA: 0x2BE5D0
	// RVA: 0x21094F0 Offset: 0x21095F1 VA: 0x21094F0
	private void set_Calculator(BattleCalculator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE5E0 Offset: 0x2BE6E1 VA: 0x2BE5E0
	// RVA: 0x2109500 Offset: 0x2109601 VA: 0x2109500
	private BattleCalculator get_SimCalculator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE5F0 Offset: 0x2BE6F1 VA: 0x2BE5F0
	// RVA: 0x2109510 Offset: 0x2109611 VA: 0x2109510
	private void set_SimCalculator(BattleCalculator value) { }

	// RVA: 0x2109520 Offset: 0x2109621 VA: 0x2109520
	public static void CreateBind(ProcInst super) { }

	[IteratorStateMachineAttribute] // RVA: 0x2BE600 Offset: 0x2BE701 VA: 0x2BE600
	// RVA: 0x210A920 Offset: 0x210AA21 VA: 0x210A920
	private IEnumerator Load() { }

	// RVA: 0x210A980 Offset: 0x210AA81 VA: 0x210A980
	private void Unload() { }

	// RVA: 0x210ACB0 Offset: 0x210ADB1 VA: 0x210ACB0
	private void BackgroundIn() { }

	// RVA: 0x210AD60 Offset: 0x210AE61 VA: 0x210AD60
	private void BackgroundOut() { }

	// RVA: 0x210AE10 Offset: 0x210AF11 VA: 0x210AE10
	private void DispTitleBar() { }

	// RVA: 0x210AF70 Offset: 0x210B071 VA: 0x210AF70
	private void CreateTopMenu() { }

	// RVA: 0x210B1A0 Offset: 0x210B2A1 VA: 0x210B1A0
	private void CreateExpUnitSelectMenu() { }

	// RVA: 0x210B490 Offset: 0x210B591 VA: 0x210B490
	private void DestroyExpUnitSelectMenu() { }

	// RVA: 0x210B520 Offset: 0x210B621 VA: 0x210B520
	private void CreateBondUnitSelectMenu() { }

	// RVA: 0x210B9E0 Offset: 0x210BAE1 VA: 0x210B9E0
	private void DestroyBondUnitSelectMenu() { }

	// RVA: 0x210BA70 Offset: 0x210BB71 VA: 0x210BA70
	private void CreateBondEmblemSelectMenu() { }

	// RVA: 0x210BDD0 Offset: 0x210BED1 VA: 0x210BDD0
	private void DestroyBondEmblemSelectMenu() { }

	// RVA: 0x210BE80 Offset: 0x210BF81 VA: 0x210BE80
	private void CreateBondLevelSelectMenu() { }

	// RVA: 0x210C220 Offset: 0x210C321 VA: 0x210C220
	private void DestroyBondLevelSelectMenu() { }

	// RVA: 0x210C2B0 Offset: 0x210C3B1 VA: 0x210C2B0
	private void SetupRandomUnit() { }

	// RVA: 0x210CE20 Offset: 0x210CF21 VA: 0x210CE20
	private void SetupEmblem(GodUnit emblem, RingCleaningSequence.GodType type) { }

	// RVA: 0x210D200 Offset: 0x210D301 VA: 0x210D200
	private void Culculate() { }

	// RVA: 0x210D470 Offset: 0x210D571 VA: 0x210D470
	private void SetupTraining() { }

	// RVA: 0x210D990 Offset: 0x210DA91 VA: 0x210D990
	private void StartTraining() { }

	// RVA: 0x210DAA0 Offset: 0x210DBA1 VA: 0x210DAA0
	private void FinishTraining() { }

	// RVA: 0x210C830 Offset: 0x210C931 VA: 0x210C830
	private void SetBattleUnitWeapon(Unit unit) { }

	// RVA: 0x210CF00 Offset: 0x210D001 VA: 0x210CF00
	private void SetEmblemWeapon(Unit unit, GodUnit emblem, int bondLevel) { }

	// RVA: 0x210DF20 Offset: 0x210E021 VA: 0x210DF20
	private void Exit() { }

	// RVA: 0x210A7F0 Offset: 0x210A8F1 VA: 0x210A7F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE670 Offset: 0x2BE771 VA: 0x2BE670
	// RVA: 0x210DF30 Offset: 0x210E031 VA: 0x210DF30
	private void <CreateTopMenu>b__71_0(bool goNext, int index) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE680 Offset: 0x2BE781 VA: 0x2BE680
	// RVA: 0x210DF60 Offset: 0x210E061 VA: 0x210DF60
	private void <CreateExpUnitSelectMenu>b__72_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE690 Offset: 0x2BE791 VA: 0x2BE690
	// RVA: 0x210DFD0 Offset: 0x210E0D1 VA: 0x210DFD0
	private void <CreateBondUnitSelectMenu>b__74_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE6A0 Offset: 0x2BE7A1 VA: 0x2BE6A0
	// RVA: 0x210E040 Offset: 0x210E141 VA: 0x210E040
	private void <CreateBondEmblemSelectMenu>b__76_0(Unit unit, GodUnit emblem, RingCleaningSequence.GodType type) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE6B0 Offset: 0x2BE7B1 VA: 0x2BE6B0
	// RVA: 0x210E140 Offset: 0x210E241 VA: 0x210E140
	private void <CreateBondEmblemSelectMenu>b__76_1(string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE6C0 Offset: 0x2BE7C1 VA: 0x2BE6C0
	// RVA: 0x210E2A0 Offset: 0x210E3A1 VA: 0x210E2A0
	private void <CreateBondLevelSelectMenu>b__78_0(GodUnit emblem, RingCleaningSequence.GodType type, bool start, int getExp, int useCount) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE6D0 Offset: 0x2BE7D1 VA: 0x2BE6D0
	// RVA: 0x210E4C0 Offset: 0x210E5C1 VA: 0x210E4C0
	private void <CreateBondLevelSelectMenu>b__78_1(string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE6E0 Offset: 0x2BE7E1 VA: 0x2BE6E0
	// RVA: 0x210D3A0 Offset: 0x210D4A1 VA: 0x210D3A0
	private void <Culculate>g___|82_0(BattleInfo info, bool isSimulation) { }
}

