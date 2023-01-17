// Namespace: Combat
public sealed class CombatRecord // TypeDefIndex: 8695
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x283C90 Offset: 0x283D91 VA: 0x283C90
	private bool <IsEnemyAttack>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x283CA0 Offset: 0x283DA1 VA: 0x283CA0
	private CombatStyle <CombatStyle>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x283CB0 Offset: 0x283DB1 VA: 0x283CB0
	private BattleCalculator <Calculator>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x283CC0 Offset: 0x283DC1 VA: 0x283CC0
	private BattleCalculator <SimCalculator>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x283CD0 Offset: 0x283DD1 VA: 0x283CD0
	private CharacterGameStatus[] <GameStatus>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x283CE0 Offset: 0x283DE1 VA: 0x283CE0
	private CharacterGameStatus[] <GameStatusChainAtk>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x283CF0 Offset: 0x283DF1 VA: 0x283CF0
	private CharacterGameStatus[] <GameStatusDragonize>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x283D00 Offset: 0x283E01 VA: 0x283D00
	private BaseCombatLocation <Location>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x283D10 Offset: 0x283E11 VA: 0x283D10
	private SkillStack <PassiveSkills>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x283D20 Offset: 0x283E21 VA: 0x283D20
	private PhaseArray <PhaseArray>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x283D30 Offset: 0x283E31 VA: 0x283D30
	private int <MapDistance>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x283D40 Offset: 0x283E41 VA: 0x283D40
	private int <ChainAttackCount>k__BackingField; // 0x5C
	private FinishStyle finishStyle; // 0x60

	// Properties
	public bool IsEnemyAttack { get; set; }
	public CombatStyle CombatStyle { get; set; }
	public BattleCalculator Calculator { get; set; }
	public BattleCalculator SimCalculator { get; set; }
	public CharacterGameStatus[] GameStatus { get; set; }
	public CharacterGameStatus[] GameStatusChainAtk { get; set; }
	public CharacterGameStatus[] GameStatusDragonize { get; set; }
	public BaseCombatLocation Location { get; set; }
	public SkillStack PassiveSkills { get; set; }
	public PhaseArray PhaseArray { get; set; }
	public Phase CurrentPhase { get; }
	public Phase LastPhase { get; }
	public int AttackRight { get; }
	public bool HasCounter { get; }
	public int MapDistance { get; set; }
	public int MapDistance1or2 { get; }
	public int ChainAttackCount { get; set; }
	public FinishStyle FinishStyle { get; }
	public bool IsChainAttack { get; }

	// Methods

	// RVA: 0x2566A50 Offset: 0x2566B51 VA: 0x2566A50
	public static bool op_Implicit(CombatRecord a) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ABF90 Offset: 0x2AC091 VA: 0x2ABF90
	// RVA: 0x2566A60 Offset: 0x2566B61 VA: 0x2566A60
	public bool get_IsEnemyAttack() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ABFA0 Offset: 0x2AC0A1 VA: 0x2ABFA0
	// RVA: 0x2566A70 Offset: 0x2566B71 VA: 0x2566A70
	private void set_IsEnemyAttack(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ABFB0 Offset: 0x2AC0B1 VA: 0x2ABFB0
	// RVA: 0x2566A80 Offset: 0x2566B81 VA: 0x2566A80
	public CombatStyle get_CombatStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ABFC0 Offset: 0x2AC0C1 VA: 0x2ABFC0
	// RVA: 0x2566A90 Offset: 0x2566B91 VA: 0x2566A90
	public void set_CombatStyle(CombatStyle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ABFD0 Offset: 0x2AC0D1 VA: 0x2ABFD0
	// RVA: 0x2566AA0 Offset: 0x2566BA1 VA: 0x2566AA0
	public BattleCalculator get_Calculator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ABFE0 Offset: 0x2AC0E1 VA: 0x2ABFE0
	// RVA: 0x2566AB0 Offset: 0x2566BB1 VA: 0x2566AB0
	private void set_Calculator(BattleCalculator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ABFF0 Offset: 0x2AC0F1 VA: 0x2ABFF0
	// RVA: 0x2566AC0 Offset: 0x2566BC1 VA: 0x2566AC0
	public BattleCalculator get_SimCalculator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC000 Offset: 0x2AC101 VA: 0x2AC000
	// RVA: 0x2566AD0 Offset: 0x2566BD1 VA: 0x2566AD0
	private void set_SimCalculator(BattleCalculator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC010 Offset: 0x2AC111 VA: 0x2AC010
	// RVA: 0x2566AE0 Offset: 0x2566BE1 VA: 0x2566AE0
	public CharacterGameStatus[] get_GameStatus() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC020 Offset: 0x2AC121 VA: 0x2AC020
	// RVA: 0x2566AF0 Offset: 0x2566BF1 VA: 0x2566AF0
	private void set_GameStatus(CharacterGameStatus[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC030 Offset: 0x2AC131 VA: 0x2AC030
	// RVA: 0x2566B00 Offset: 0x2566C01 VA: 0x2566B00
	public CharacterGameStatus[] get_GameStatusChainAtk() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC040 Offset: 0x2AC141 VA: 0x2AC040
	// RVA: 0x2566B10 Offset: 0x2566C11 VA: 0x2566B10
	private void set_GameStatusChainAtk(CharacterGameStatus[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC050 Offset: 0x2AC151 VA: 0x2AC050
	// RVA: 0x2566B20 Offset: 0x2566C21 VA: 0x2566B20
	public CharacterGameStatus[] get_GameStatusDragonize() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC060 Offset: 0x2AC161 VA: 0x2AC060
	// RVA: 0x2566B30 Offset: 0x2566C31 VA: 0x2566B30
	private void set_GameStatusDragonize(CharacterGameStatus[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC070 Offset: 0x2AC171 VA: 0x2AC070
	// RVA: 0x2566B40 Offset: 0x2566C41 VA: 0x2566B40
	public BaseCombatLocation get_Location() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC080 Offset: 0x2AC181 VA: 0x2AC080
	// RVA: 0x2566B50 Offset: 0x2566C51 VA: 0x2566B50
	private void set_Location(BaseCombatLocation value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC090 Offset: 0x2AC191 VA: 0x2AC090
	// RVA: 0x2566B60 Offset: 0x2566C61 VA: 0x2566B60
	public SkillStack get_PassiveSkills() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC0A0 Offset: 0x2AC1A1 VA: 0x2AC0A0
	// RVA: 0x2566B70 Offset: 0x2566C71 VA: 0x2566B70
	private void set_PassiveSkills(SkillStack value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC0B0 Offset: 0x2AC1B1 VA: 0x2AC0B0
	// RVA: 0x2566B80 Offset: 0x2566C81 VA: 0x2566B80
	public PhaseArray get_PhaseArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC0C0 Offset: 0x2AC1C1 VA: 0x2AC0C0
	// RVA: 0x2566B90 Offset: 0x2566C91 VA: 0x2566B90
	private void set_PhaseArray(PhaseArray value) { }

	// RVA: 0x2566BA0 Offset: 0x2566CA1 VA: 0x2566BA0
	public Phase get_CurrentPhase() { }

	// RVA: 0x2566BB0 Offset: 0x2566CB1 VA: 0x2566BB0
	public Phase get_LastPhase() { }

	// RVA: 0x2566BC0 Offset: 0x2566CC1 VA: 0x2566BC0
	public int get_AttackRight() { }

	// RVA: 0x2566BD0 Offset: 0x2566CD1 VA: 0x2566BD0
	public bool get_HasCounter() { }

	// RVA: 0x2566BE0 Offset: 0x2566CE1 VA: 0x2566BE0
	public void UpdateAttackRight() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC0D0 Offset: 0x2AC1D1 VA: 0x2AC0D0
	// RVA: 0x2566BF0 Offset: 0x2566CF1 VA: 0x2566BF0
	public int get_MapDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC0E0 Offset: 0x2AC1E1 VA: 0x2AC0E0
	// RVA: 0x2566C00 Offset: 0x2566D01 VA: 0x2566C00
	private void set_MapDistance(int value) { }

	// RVA: 0x2566C10 Offset: 0x2566D11 VA: 0x2566C10
	public int get_MapDistance1or2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC0F0 Offset: 0x2AC1F1 VA: 0x2AC0F0
	// RVA: 0x2566C30 Offset: 0x2566D31 VA: 0x2566C30
	public int get_ChainAttackCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC100 Offset: 0x2AC201 VA: 0x2AC100
	// RVA: 0x2566C40 Offset: 0x2566D41 VA: 0x2566C40
	private void set_ChainAttackCount(int value) { }

	// RVA: 0x2566C50 Offset: 0x2566D51 VA: 0x2566C50
	public FinishStyle get_FinishStyle() { }

	// RVA: 0x2566DB0 Offset: 0x2566EB1 VA: 0x2566DB0
	public bool get_IsChainAttack() { }

	// RVA: 0x2566F10 Offset: 0x2567011 VA: 0x2566F10
	public void .ctor() { }

	// RVA: 0x2566D10 Offset: 0x2566E11 VA: 0x2566D10
	private FinishStyle CalcFinishStyle() { }

	// RVA: 0x2567230 Offset: 0x2567331 VA: 0x2567230
	private void PostProcess() { }

	// RVA: 0x25686D0 Offset: 0x25687D1 VA: 0x25686D0
	public void PreloadPassiveSkillsEffects() { }

	// RVA: 0x25686F0 Offset: 0x25687F1 VA: 0x25686F0
	public void MakeDecorators() { }

	// RVA: 0x2567EC0 Offset: 0x2567FC1 VA: 0x2567EC0
	private void FixForSelfHeal() { }

	// RVA: 0x2568040 Offset: 0x2568141 VA: 0x2568040
	private void FixForDance() { }

	// RVA: 0x2567630 Offset: 0x2567731 VA: 0x2567630
	private void スターラッシュ() { }

	// RVA: 0x25673B0 Offset: 0x25674B1 VA: 0x25673B0
	private void 絆神竜破() { }

	// RVA: 0x2567800 Offset: 0x2567901 VA: 0x2567800
	private void 神竜破() { }

	// RVA: 0x2567940 Offset: 0x2567A41 VA: 0x2567940
	private void 流星群() { }

	// RVA: 0x2567A80 Offset: 0x2567B81 VA: 0x2567A80
	private void ツインストライク() { }

	// RVA: 0x2567CA0 Offset: 0x2567DA1 VA: 0x2567CA0
	private void テトラトリック() { }

	// RVA: 0x2567E10 Offset: 0x2567F11 VA: 0x2567E10
	private void オールフォーワン() { }

	// RVA: 0x2568980 Offset: 0x2568A81 VA: 0x2568980
	public void ImportFromGame(BattleCalculator calc, BattleCalculator simCalc) { }

	// RVA: 0x256AF70 Offset: 0x256B071 VA: 0x256AF70
	private static void ImportOnestepParameters(BattleCalculator calc, BattleScene src, Phase phase, int s0, int s1) { }

	// RVA: 0x256A110 Offset: 0x256A211 VA: 0x256A110
	private static int GetDistance(BattleCalculator calc) { }

	// RVA: 0x256AA70 Offset: 0x256AB71 VA: 0x256AA70
	private void ImportMasterUnitsFromGame(BattleCalculator calc) { }

	// RVA: 0x256ABC0 Offset: 0x256ACC1 VA: 0x256ABC0
	private void ImportGrandewFromGame(BattleCalculator calc) { }

	// RVA: 0x256ABF0 Offset: 0x256ACF1 VA: 0x256ABF0
	private void ImportChainUnitsFromGame(BattleCalculator calc) { }

	// RVA: 0x256B960 Offset: 0x256BA61 VA: 0x256B960
	public void CreateForJobIntro(JobIntroData data) { }

	// RVA: 0x256BDB0 Offset: 0x256BEB1 VA: 0x256BDB0
	private void CreatePhaseArrayForJobIntro(JobIntroData data, bool isRod) { }

	// RVA: 0x256C1E0 Offset: 0x256C2E1 VA: 0x256C1E0
	public void ImportFromViewer(CombatViewer viewer) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC110 Offset: 0x2AC211 VA: 0x2AC110
	// RVA: 0x256B490 Offset: 0x256B591 VA: 0x256B490
	private bool <ImportFromGame>g__isStandingDie|79_0(BattleSide.Type gameSide, ref CombatRecord.<>c__DisplayClass79_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC120 Offset: 0x2AC221 VA: 0x2AC120
	// RVA: 0x256B540 Offset: 0x256B641 VA: 0x256B540
	private void <ImportMasterUnitsFromGame>g___|82_0(BattleSide.Type calcSide, ref CombatRecord.<>c__DisplayClass82_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC130 Offset: 0x2AC231 VA: 0x2AC130
	// RVA: 0x256B5E0 Offset: 0x256B6E1 VA: 0x256B5E0
	private void <ImportGrandewFromGame>g___|83_0(int side) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC140 Offset: 0x2AC241 VA: 0x2AC140
	// RVA: 0x256B720 Offset: 0x256B821 VA: 0x256B720
	private void <ImportChainUnitsFromGame>g___Atk|84_0(BattleSide.Type calcSide, ref CombatRecord.<>c__DisplayClass84_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC150 Offset: 0x2AC251 VA: 0x2AC150
	// RVA: 0x256B8D0 Offset: 0x256B9D1 VA: 0x256B8D0
	private void <ImportChainUnitsFromGame>g___Grd|84_1(BattleSide.Type calcSide, ref CombatRecord.<>c__DisplayClass84_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC160 Offset: 0x2AC261 VA: 0x2AC160
	// RVA: 0x256BB20 Offset: 0x256BC21 VA: 0x256BB20
	private void <CreateForJobIntro>g__Import|85_0(int side, string[] pidArray, string[] jidArray, string[] iidArray, ref CombatRecord.<>c__DisplayClass85_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC170 Offset: 0x2AC271 VA: 0x2AC170
	// RVA: 0x256BEF0 Offset: 0x256BFF1 VA: 0x256BEF0
	private Phase <CreatePhaseArrayForJobIntro>g__CreatePhase|86_0(JobIntroData.BattleType type, int dmgHash) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC180 Offset: 0x2AC281 VA: 0x2AC180
	// RVA: 0x256E170 Offset: 0x256E271 VA: 0x256E170
	private void <ImportFromViewer>g__mywarn|87_1(ref CombatRecord.<>c__DisplayClass87_0 , ref CombatRecord.<>c__DisplayClass87_1 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC190 Offset: 0x2AC291 VA: 0x2AC190
	// RVA: 0x256E1F0 Offset: 0x256E2F1 VA: 0x256E1F0
	private void <ImportFromViewer>g__enwarn|87_2(ref CombatRecord.<>c__DisplayClass87_0 , ref CombatRecord.<>c__DisplayClass87_1 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC1A0 Offset: 0x2AC2A1 VA: 0x2AC1A0
	// RVA: 0x256D970 Offset: 0x256DA71 VA: 0x256D970
	private void <ImportFromViewer>g____makechr|87_0(int side, string objName, int chainId, EngageStyle engageStyle, ref CombatRecord.<>c__DisplayClass87_0 ) { }
}

