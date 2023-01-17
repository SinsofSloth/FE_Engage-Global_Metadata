// Namespace: App
public class BattleInfo : IDisposable // TypeDefIndex: 9508
{
	// Fields
	public const int CriticalFactor = 3;
	private BattleInfo.FlagField m_Flag; // 0x10
	private BattleInfo.BattleInfoSideArray m_Sides; // 0x18
	private BattleInfo.SupportList m_Supports; // 0x20
	private BattleInfoEnum m_MainUnitEnum; // 0x28
	private BattleInfoEnum m_WholeUnitEnum; // 0x40
	private BattleInfoEnum m_ChainOffenseEnum; // 0x58
	private BattleInfoEnum m_ChainDefenseEnum; // 0x70
	private BattleInfoEnum m_ChainUnitEnum; // 0x88
	private List<SkillData> m_TempSkills; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x287490 Offset: 0x287591 VA: 0x287490
	private int <Range>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x2874A0 Offset: 0x2875A1 VA: 0x2874A0
	private int <BattleCount>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x2874B0 Offset: 0x2875B1 VA: 0x2874B0
	private BattleScene.Result <SceneResult>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x2874C0 Offset: 0x2875C1 VA: 0x2874C0
	private BattleSide.Type <ChainAttackSide>k__BackingField; // 0xB4
	[CompilerGeneratedAttribute] // RVA: 0x2874D0 Offset: 0x2875D1 VA: 0x2874D0
	private int <ChainAttackCount>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x2874E0 Offset: 0x2875E1 VA: 0x2874E0
	private int <ChainGuardCount>k__BackingField; // 0xBC
	[CompilerGeneratedAttribute] // RVA: 0x2874F0 Offset: 0x2875F1 VA: 0x2874F0
	private int <ChainAttackDefeat>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x287500 Offset: 0x287601 VA: 0x287500
	private int <ChainAttackHit>k__BackingField; // 0xC4
	[CompilerGeneratedAttribute] // RVA: 0x287510 Offset: 0x287611 VA: 0x287510
	private int <ChainAttackCritical>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x287520 Offset: 0x287621 VA: 0x287520
	private int <ChainAttackDamage>k__BackingField; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x287530 Offset: 0x287631 VA: 0x287530
	private PersonData.Ranks <SummonRank>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x287540 Offset: 0x287641 VA: 0x287540
	private PersonData.Colors <SummonColor>k__BackingField; // 0xD4
	private BattleSide.Type m_GuardSide; // 0xD8
	private MapFor.RangeFunction m_GuardFunc; // 0xE0

	// Properties
	public int Range { get; set; }
	public int BattleCount { get; set; }
	public BattleScene.Result SceneResult { get; set; }
	public BattleSide.Type ChainAttackSide { get; set; }
	public int ChainAttackCount { get; set; }
	public int ChainGuardCount { get; set; }
	public int ChainAttackDefeat { get; set; }
	public int ChainAttackHit { get; set; }
	public int ChainAttackCritical { get; set; }
	public int ChainAttackDamage { get; set; }
	public List<SkillData> TempSkills { get; }
	public PersonData.Ranks SummonRank { get; set; }
	public PersonData.Colors SummonColor { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2B0910 Offset: 0x2B0A11 VA: 0x2B0910
	// RVA: 0x2245640 Offset: 0x2245741 VA: 0x2245640
	public int get_Range() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0920 Offset: 0x2B0A21 VA: 0x2B0920
	// RVA: 0x2245650 Offset: 0x2245751 VA: 0x2245650
	public void set_Range(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0930 Offset: 0x2B0A31 VA: 0x2B0930
	// RVA: 0x2245660 Offset: 0x2245761 VA: 0x2245660
	public int get_BattleCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0940 Offset: 0x2B0A41 VA: 0x2B0940
	// RVA: 0x2245670 Offset: 0x2245771 VA: 0x2245670
	public void set_BattleCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0950 Offset: 0x2B0A51 VA: 0x2B0950
	// RVA: 0x2245680 Offset: 0x2245781 VA: 0x2245680
	public BattleScene.Result get_SceneResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0960 Offset: 0x2B0A61 VA: 0x2B0960
	// RVA: 0x2245690 Offset: 0x2245791 VA: 0x2245690
	public void set_SceneResult(BattleScene.Result value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0970 Offset: 0x2B0A71 VA: 0x2B0970
	// RVA: 0x22456A0 Offset: 0x22457A1 VA: 0x22456A0
	public BattleSide.Type get_ChainAttackSide() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0980 Offset: 0x2B0A81 VA: 0x2B0980
	// RVA: 0x22456B0 Offset: 0x22457B1 VA: 0x22456B0
	public void set_ChainAttackSide(BattleSide.Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0990 Offset: 0x2B0A91 VA: 0x2B0990
	// RVA: 0x22456C0 Offset: 0x22457C1 VA: 0x22456C0
	public int get_ChainAttackCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B09A0 Offset: 0x2B0AA1 VA: 0x2B09A0
	// RVA: 0x22456D0 Offset: 0x22457D1 VA: 0x22456D0
	public void set_ChainAttackCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B09B0 Offset: 0x2B0AB1 VA: 0x2B09B0
	// RVA: 0x22456E0 Offset: 0x22457E1 VA: 0x22456E0
	public int get_ChainGuardCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B09C0 Offset: 0x2B0AC1 VA: 0x2B09C0
	// RVA: 0x22456F0 Offset: 0x22457F1 VA: 0x22456F0
	public void set_ChainGuardCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B09D0 Offset: 0x2B0AD1 VA: 0x2B09D0
	// RVA: 0x2245700 Offset: 0x2245801 VA: 0x2245700
	public int get_ChainAttackDefeat() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B09E0 Offset: 0x2B0AE1 VA: 0x2B09E0
	// RVA: 0x2245710 Offset: 0x2245811 VA: 0x2245710
	public void set_ChainAttackDefeat(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B09F0 Offset: 0x2B0AF1 VA: 0x2B09F0
	// RVA: 0x2245720 Offset: 0x2245821 VA: 0x2245720
	public int get_ChainAttackHit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0A00 Offset: 0x2B0B01 VA: 0x2B0A00
	// RVA: 0x2245730 Offset: 0x2245831 VA: 0x2245730
	public void set_ChainAttackHit(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0A10 Offset: 0x2B0B11 VA: 0x2B0A10
	// RVA: 0x2245740 Offset: 0x2245841 VA: 0x2245740
	public int get_ChainAttackCritical() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0A20 Offset: 0x2B0B21 VA: 0x2B0A20
	// RVA: 0x2245750 Offset: 0x2245851 VA: 0x2245750
	public void set_ChainAttackCritical(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0A30 Offset: 0x2B0B31 VA: 0x2B0A30
	// RVA: 0x2245760 Offset: 0x2245861 VA: 0x2245760
	public int get_ChainAttackDamage() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0A40 Offset: 0x2B0B41 VA: 0x2B0A40
	// RVA: 0x2245770 Offset: 0x2245871 VA: 0x2245770
	public void set_ChainAttackDamage(int value) { }

	// RVA: 0x2245780 Offset: 0x2245881 VA: 0x2245780
	public List<SkillData> get_TempSkills() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0A50 Offset: 0x2B0B51 VA: 0x2B0A50
	// RVA: 0x2245790 Offset: 0x2245891 VA: 0x2245790
	public PersonData.Ranks get_SummonRank() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0A60 Offset: 0x2B0B61 VA: 0x2B0A60
	// RVA: 0x22457A0 Offset: 0x22458A1 VA: 0x22457A0
	private void set_SummonRank(PersonData.Ranks value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0A70 Offset: 0x2B0B71 VA: 0x2B0A70
	// RVA: 0x22457B0 Offset: 0x22458B1 VA: 0x22457B0
	public PersonData.Colors get_SummonColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0A80 Offset: 0x2B0B81 VA: 0x2B0A80
	// RVA: 0x22457C0 Offset: 0x22458C1 VA: 0x22457C0
	private void set_SummonColor(PersonData.Colors value) { }

	// RVA: 0x22457D0 Offset: 0x22458D1 VA: 0x22457D0
	public void .ctor() { }

	// RVA: 0x22460D0 Offset: 0x22461D1 VA: 0x22460D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x22461D0 Offset: 0x22462D1 VA: 0x22461D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2246020 Offset: 0x2246121 VA: 0x2246020
	public void Reset(BattleInfo.Flags flags = 0) { }

	// RVA: 0x2246540 Offset: 0x2246641 VA: 0x2246540
	private static BattleInfo.Flags GetResetFlag(BattleInfo.Flags flags, Unit offense, SkillData commmandSkill) { }

	// RVA: 0x2246810 Offset: 0x2246911 VA: 0x2246810
	public BattleInfo CalcSimple(Unit offense, BattleInfo.Flags flag = 0) { }

	// RVA: 0x2246C70 Offset: 0x2246D71 VA: 0x2246C70
	public void CalcSimple(Unit offense, UnitItem unitItem, Unit defense, BattleInfo.Flags flag = 0) { }

	// RVA: 0x2246DC0 Offset: 0x2246EC1 VA: 0x2246DC0
	public void CalcSimple(Unit offense, UnitItem unitItem, Unit defense, SkillData commandSkill, BattleInfo.Flags flags = 1, int count = 0) { }

	// RVA: 0x22472E0 Offset: 0x22473E1 VA: 0x22472E0
	public void CalcSimple(Unit offense, UnitItem unitItem, int targetX, int targetZ, SkillData commandSkill, BattleInfo.Flags flags = 1, int count = 0) { }

	// RVA: 0x2247290 Offset: 0x2247391 VA: 0x2247290
	public void CalcSimple(Unit offense, UnitItem unitItem, int attackX, int attackZ, Unit defense, int targetX, int targetZ, SkillData commandSkill, BattleInfo.Flags flags = 1, int count = 0) { }

	// RVA: 0x2247330 Offset: 0x2247431 VA: 0x2247330
	public void CalcSimple(Unit offense, UnitItem unitItem, int attackX, int attackZ, Unit defense, UnitItem revengeItem, int targetX, int targetZ, SkillData commandSkill, BattleInfo.Flags flags = 1, int count = 0) { }

	// RVA: 0x2247500 Offset: 0x2247601 VA: 0x2247500
	public void CalcDestroy(Unit offense, UnitItem unitItem, int targetX, int targetZ, BattleInfo.Flags flags = 1, int count = 0) { }

	// RVA: 0x22476C0 Offset: 0x22477C1 VA: 0x22476C0
	public void CalcSummon(Unit offense, UnitItem unitItem, PersonData.Ranks rank, PersonData.Colors color, bool isSimulation) { }

	// RVA: 0x2247820 Offset: 0x2247921 VA: 0x2247820
	public void CalcDance(Unit offense, Unit defense, bool isSimulation) { }

	// RVA: 0x2247970 Offset: 0x2247A71 VA: 0x2247970
	public void CalcEnchant(Unit offense, UnitItem unitItem, Unit defense, bool isSimulation) { }

	// RVA: 0x2247AD0 Offset: 0x2247BD1 VA: 0x2247AD0
	private void CalcFlags() { }

	// RVA: 0x2247D60 Offset: 0x2247E61 VA: 0x2247D60
	private void CalcRange() { }

	// RVA: 0x2247ED0 Offset: 0x2247FD1 VA: 0x2247ED0
	private static Unit TryGetSupportUnit(BattleInfoSide current, int x, int z) { }

	// RVA: 0x2248210 Offset: 0x2248311 VA: 0x2248210
	private BattleInfoSide SetSupportOffense(BattleSide.Type support, Unit unit, BattleInfoSide.Status status) { }

	// RVA: 0x2248970 Offset: 0x2248A71 VA: 0x2248970
	private static SkillData GetChianSkill(Unit chain) { }

	// RVA: 0x2248C50 Offset: 0x2248D51 VA: 0x2248C50
	private bool CanChainGuard(Unit unit, Unit chain) { }

	// RVA: 0x2249120 Offset: 0x2249221 VA: 0x2249120
	private BattleSide.Type CalcSupportDefense(BattleSide.Type support, int x, int z, BattleInfoSide current) { }

	// RVA: 0x22492F0 Offset: 0x22493F1 VA: 0x22492F0
	private void CalcChain() { }

	// RVA: 0x224C320 Offset: 0x224C421 VA: 0x224C320
	private void SearchGuard(int x, int z, int range) { }

	// RVA: 0x22469D0 Offset: 0x2246AD1 VA: 0x22469D0
	public void CalcParam() { }

	// RVA: 0x224CBA0 Offset: 0x224CCA1 VA: 0x224CBA0
	private void CalcActiveSkill(SkillData.Timings timing) { }

	// RVA: 0x224D140 Offset: 0x224D241 VA: 0x224D140
	public BattleInfo.FlagField GetFlag() { }

	// RVA: 0x224D150 Offset: 0x224D251 VA: 0x224D150
	public bool IsFlag(BattleInfo.Flags flag) { }

	// RVA: 0x224D1C0 Offset: 0x224D2C1 VA: 0x224D1C0
	public BattleInfoSide GetSide(BattleSide.Type type) { }

	// RVA: 0x224D220 Offset: 0x224D321 VA: 0x224D220
	public BattleInfoSide GetSide(int index) { }

	// RVA: 0x224D280 Offset: 0x224D381 VA: 0x224D280
	public BattleInfoSide GetParentSide(BattleSide.Type type) { }

	// RVA: 0x224D3A0 Offset: 0x224D4A1 VA: 0x224D3A0
	public BattleInfoSide GetParentSide(int index) { }

	// RVA: 0x224D4C0 Offset: 0x224D5C1 VA: 0x224D4C0
	public BattleInfoSide GetReverseSide(BattleSide.Type type) { }

	// RVA: 0x224D5E0 Offset: 0x224D6E1 VA: 0x224D5E0
	public BattleInfoSide GetReverseSide(int index) { }

	// RVA: 0x224D700 Offset: 0x224D801 VA: 0x224D700
	public Unit GetUnit(BattleSide.Type type) { }

	// RVA: 0x224D770 Offset: 0x224D871 VA: 0x224D770
	public Unit GetUnit(int index) { }

	// RVA: 0x224D7E0 Offset: 0x224D8E1 VA: 0x224D7E0
	public void PushDetail() { }

	// RVA: 0x224D920 Offset: 0x224DA21 VA: 0x224D920
	public void PopDetail() { }

	// RVA: 0x224DA40 Offset: 0x224DB41 VA: 0x224DA40
	public BattleInfoEnum GetMainUnitEnum() { }

	// RVA: 0x224DA60 Offset: 0x224DB61 VA: 0x224DA60
	public BattleInfoEnum GetWholeUnitEnum() { }

	// RVA: 0x224DA80 Offset: 0x224DB81 VA: 0x224DA80
	public BattleInfoEnum GetChainOffenseEnum() { }

	// RVA: 0x224DAA0 Offset: 0x224DBA1 VA: 0x224DAA0
	public BattleInfoEnum GetChainDefenseEnum() { }

	// RVA: 0x224DAC0 Offset: 0x224DBC1 VA: 0x224DAC0
	public BattleInfoEnum GetChainUnitEnum() { }

	// RVA: 0x224DAE0 Offset: 0x224DBE1 VA: 0x224DAE0
	public BattleInfoSide FindDestroySide() { }

	// RVA: 0x224DB60 Offset: 0x224DC61 VA: 0x224DB60
	public bool HasChainOffense(Unit unit) { }

	// RVA: 0x224DBF0 Offset: 0x224DCF1 VA: 0x224DBF0
	public bool HasChainDefense(Unit unit) { }

	// RVA: 0x224C560 Offset: 0x224C661 VA: 0x224C560
	private void ComplementConditions() { }

	// RVA: 0x224C8C0 Offset: 0x224C9C1 VA: 0x224C8C0
	private void CalcDetail() { }

	// RVA: 0x224CEF0 Offset: 0x224CFF1 VA: 0x224CEF0
	private void CalcBattleTimes() { }

	// RVA: 0x224F7F0 Offset: 0x224F8F1 VA: 0x224F7F0
	public static void BattleStart(Unit unit, MapMind.Type mind, SkillData skill, bool isSimulation = True) { }

	// RVA: 0x224F8D0 Offset: 0x224F9D1 VA: 0x224F8D0
	public static void BattleEnd(Unit unit, MapMind.Type mind, SkillData skill, bool isSimulation = True) { }

	// RVA: 0x224F9D0 Offset: 0x224FAD1 VA: 0x224F9D0
	private static bool IsSkillCondtion(SkillData skill, Unit unit, Unit target) { }

	// RVA: 0x224FA10 Offset: 0x224FB11 VA: 0x224FA10
	private bool CanChainSkill(SkillData skill, SkillData.Flags flags) { }

	// RVA: 0x224FB40 Offset: 0x224FC41 VA: 0x224FB40
	private bool CanMoveAttack(Unit unit, Unit target) { }

	// RVA: 0x2250120 Offset: 0x2250221 VA: 0x2250120
	private bool CanForceChainAttack(Unit unit, Unit chain, Unit target) { }

	// RVA: 0x22511B0 Offset: 0x22512B1 VA: 0x22511B0
	private bool CanJoinChainAttack(Unit unit, Unit chain, Unit target) { }
}

