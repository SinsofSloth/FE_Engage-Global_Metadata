// Namespace: Combat
[DefaultMemberAttribute] // RVA: 0x274640 Offset: 0x274741 VA: 0x274640
public abstract class BaseCombatLocation // TypeDefIndex: 8754
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x284130 Offset: 0x284231 VA: 0x284130
	private bool <IsCalculated>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x284140 Offset: 0x284241 VA: 0x284140
	private bool <IsLocated>k__BackingField; // 0x11
	[CompilerGeneratedAttribute] // RVA: 0x284150 Offset: 0x284251 VA: 0x284150
	private int <TryCount>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x284160 Offset: 0x284261 VA: 0x284160
	private int <Pattern>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x284170 Offset: 0x284271 VA: 0x284170
	private bool <UseOpenStyle>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x284180 Offset: 0x284281 VA: 0x284180
	private readonly CombatRecord <Record>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x284190 Offset: 0x284291 VA: 0x284190
	private FXZ[] <WorldPos>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x2841A0 Offset: 0x2842A1 VA: 0x2841A0
	private int[] <DamageCount>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x2841B0 Offset: 0x2842B1 VA: 0x2841B0
	private float[] <CharaTall>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x2841C0 Offset: 0x2842C1 VA: 0x2841C0
	private float[] <CharaBodySize>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x2841D0 Offset: 0x2842D1 VA: 0x2841D0
	private bool[] <IsRiding>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x2841E0 Offset: 0x2842E1 VA: 0x2841E0
	private bool[] <IsFlying>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x2841F0 Offset: 0x2842F1 VA: 0x2841F0
	private bool[] <CanFly>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x284200 Offset: 0x284301 VA: 0x284200
	private bool[] <IsBigDragon>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x284210 Offset: 0x284311 VA: 0x284210
	private FXZ[] <RoughPos>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x284220 Offset: 0x284321 VA: 0x284220
	private Vector3[] <OutPos>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x284230 Offset: 0x284331 VA: 0x284230
	private FXZ[] <OutDir>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x284240 Offset: 0x284341 VA: 0x284240
	private bool[] <SetFlying>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x284250 Offset: 0x284351 VA: 0x284250
	private bool <SkipCheckOverWall>k__BackingField; // 0x88
	private static GameParam.Holder m_PlayerDirHolder; // 0x0
	private static GameParam.Holder m_EnemyDirHolder; // 0x8

	// Properties
	public Vector3 Item { get; }
	public bool IsCalculated { get; set; }
	public bool IsLocated { get; set; }
	protected float StandardFlyingHight { get; }
	protected float ShootFlyingHight { get; }
	protected float HeightOverFlyingHight { get; }
	public int TryCount { get; set; }
	public int Pattern { get; set; }
	public bool UseOpenStyle { get; set; }
	protected CombatRecord Record { get; }
	protected FXZ[] WorldPos { get; set; }
	protected int[] DamageCount { get; set; }
	protected float[] CharaTall { get; set; }
	protected float[] CharaBodySize { get; set; }
	protected bool[] IsRiding { get; set; }
	protected bool[] IsFlying { get; set; }
	protected bool[] CanFly { get; set; }
	protected bool[] IsBigDragon { get; set; }
	protected FXZ[] RoughPos { get; set; }
	protected Vector3[] OutPos { get; set; }
	public FXZ[] OutDir { get; set; }
	protected bool[] SetFlying { get; set; }
	protected bool SkipCheckOverWall { get; set; }
	protected float StartDistance { get; }
	protected abstract int RoughPosCount { get; }
	protected abstract int PatternCount { get; }
	protected int SideAtk { get; }
	protected int SideDmg { get; }

	// Methods

	// RVA: 0x2619E00 Offset: 0x2619F01 VA: 0x2619E00
	public Vector3 get_Item(int i) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC810 Offset: 0x2AC911 VA: 0x2AC810
	// RVA: 0x2619E80 Offset: 0x2619F81 VA: 0x2619E80
	public bool get_IsCalculated() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC820 Offset: 0x2AC921 VA: 0x2AC820
	// RVA: 0x2619E90 Offset: 0x2619F91 VA: 0x2619E90
	protected void set_IsCalculated(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC830 Offset: 0x2AC931 VA: 0x2AC830
	// RVA: 0x2619EA0 Offset: 0x2619FA1 VA: 0x2619EA0
	public bool get_IsLocated() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC840 Offset: 0x2AC941 VA: 0x2AC840
	// RVA: 0x2619EB0 Offset: 0x2619FB1 VA: 0x2619EB0
	protected void set_IsLocated(bool value) { }

	// RVA: 0x2619EC0 Offset: 0x2619FC1 VA: 0x2619EC0
	protected float get_StandardFlyingHight() { }

	// RVA: 0x2619FD0 Offset: 0x261A0D1 VA: 0x2619FD0
	protected float get_ShootFlyingHight() { }

	// RVA: 0x2619FE0 Offset: 0x261A0E1 VA: 0x2619FE0
	protected float get_HeightOverFlyingHight() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC850 Offset: 0x2AC951 VA: 0x2AC850
	// RVA: 0x261A110 Offset: 0x261A211 VA: 0x261A110
	public int get_TryCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC860 Offset: 0x2AC961 VA: 0x2AC860
	// RVA: 0x261A120 Offset: 0x261A221 VA: 0x261A120
	protected void set_TryCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC870 Offset: 0x2AC971 VA: 0x2AC870
	// RVA: 0x261A130 Offset: 0x261A231 VA: 0x261A130
	public int get_Pattern() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC880 Offset: 0x2AC981 VA: 0x2AC880
	// RVA: 0x261A140 Offset: 0x261A241 VA: 0x261A140
	protected void set_Pattern(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC890 Offset: 0x2AC991 VA: 0x2AC890
	// RVA: 0x261A150 Offset: 0x261A251 VA: 0x261A150
	public bool get_UseOpenStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC8A0 Offset: 0x2AC9A1 VA: 0x2AC8A0
	// RVA: 0x261A160 Offset: 0x261A261 VA: 0x261A160
	protected void set_UseOpenStyle(bool value) { }

	// RVA: 0x261A170 Offset: 0x261A271 VA: 0x261A170
	public static BaseCombatLocation CreateLocator(CombatRecord record) { }

	// RVA: 0x261A600 Offset: 0x261A701 VA: 0x261A600
	public void Calculate(CharacterGameStatus[] gs) { }

	// RVA: 0x261D520 Offset: 0x261D621 VA: 0x261D520
	public void Locate(Character[] charaArray, LocationParams.LocateStyle locateStyle) { }

	// RVA: 0x261DB30 Offset: 0x261DC31 VA: 0x261DB30 Slot: 4
	protected virtual void LocateEmblem(int masterSide, Character master, Character emblem, LocationParams.LocateStyle locateStyle) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC8B0 Offset: 0x2AC9B1 VA: 0x2AC8B0
	// RVA: 0x261DD00 Offset: 0x261DE01 VA: 0x261DD00
	protected CombatRecord get_Record() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC8C0 Offset: 0x2AC9C1 VA: 0x2AC8C0
	// RVA: 0x261DD10 Offset: 0x261DE11 VA: 0x261DD10
	protected FXZ[] get_WorldPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC8D0 Offset: 0x2AC9D1 VA: 0x2AC8D0
	// RVA: 0x261DD20 Offset: 0x261DE21 VA: 0x261DD20
	protected void set_WorldPos(FXZ[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC8E0 Offset: 0x2AC9E1 VA: 0x2AC8E0
	// RVA: 0x261DD30 Offset: 0x261DE31 VA: 0x261DD30
	protected int[] get_DamageCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC8F0 Offset: 0x2AC9F1 VA: 0x2AC8F0
	// RVA: 0x261DD40 Offset: 0x261DE41 VA: 0x261DD40
	protected void set_DamageCount(int[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC900 Offset: 0x2ACA01 VA: 0x2AC900
	// RVA: 0x261DD50 Offset: 0x261DE51 VA: 0x261DD50
	protected float[] get_CharaTall() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC910 Offset: 0x2ACA11 VA: 0x2AC910
	// RVA: 0x261DD60 Offset: 0x261DE61 VA: 0x261DD60
	protected void set_CharaTall(float[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC920 Offset: 0x2ACA21 VA: 0x2AC920
	// RVA: 0x261DD70 Offset: 0x261DE71 VA: 0x261DD70
	protected float[] get_CharaBodySize() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC930 Offset: 0x2ACA31 VA: 0x2AC930
	// RVA: 0x261DD80 Offset: 0x261DE81 VA: 0x261DD80
	protected void set_CharaBodySize(float[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC940 Offset: 0x2ACA41 VA: 0x2AC940
	// RVA: 0x261DD90 Offset: 0x261DE91 VA: 0x261DD90
	protected bool[] get_IsRiding() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC950 Offset: 0x2ACA51 VA: 0x2AC950
	// RVA: 0x261DDA0 Offset: 0x261DEA1 VA: 0x261DDA0
	protected void set_IsRiding(bool[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC960 Offset: 0x2ACA61 VA: 0x2AC960
	// RVA: 0x261DDB0 Offset: 0x261DEB1 VA: 0x261DDB0
	protected bool[] get_IsFlying() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC970 Offset: 0x2ACA71 VA: 0x2AC970
	// RVA: 0x261DDC0 Offset: 0x261DEC1 VA: 0x261DDC0
	protected void set_IsFlying(bool[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC980 Offset: 0x2ACA81 VA: 0x2AC980
	// RVA: 0x261DDD0 Offset: 0x261DED1 VA: 0x261DDD0
	protected bool[] get_CanFly() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC990 Offset: 0x2ACA91 VA: 0x2AC990
	// RVA: 0x261DDE0 Offset: 0x261DEE1 VA: 0x261DDE0
	protected void set_CanFly(bool[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC9A0 Offset: 0x2ACAA1 VA: 0x2AC9A0
	// RVA: 0x261DDF0 Offset: 0x261DEF1 VA: 0x261DDF0
	protected bool[] get_IsBigDragon() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC9B0 Offset: 0x2ACAB1 VA: 0x2AC9B0
	// RVA: 0x261DE00 Offset: 0x261DF01 VA: 0x261DE00
	protected void set_IsBigDragon(bool[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC9C0 Offset: 0x2ACAC1 VA: 0x2AC9C0
	// RVA: 0x261DE10 Offset: 0x261DF11 VA: 0x261DE10
	protected FXZ[] get_RoughPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC9D0 Offset: 0x2ACAD1 VA: 0x2AC9D0
	// RVA: 0x261DE20 Offset: 0x261DF21 VA: 0x261DE20
	protected void set_RoughPos(FXZ[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC9E0 Offset: 0x2ACAE1 VA: 0x2AC9E0
	// RVA: 0x261DE30 Offset: 0x261DF31 VA: 0x261DE30
	protected Vector3[] get_OutPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC9F0 Offset: 0x2ACAF1 VA: 0x2AC9F0
	// RVA: 0x261DE40 Offset: 0x261DF41 VA: 0x261DE40
	protected void set_OutPos(Vector3[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACA00 Offset: 0x2ACB01 VA: 0x2ACA00
	// RVA: 0x261DE50 Offset: 0x261DF51 VA: 0x261DE50
	public FXZ[] get_OutDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACA10 Offset: 0x2ACB11 VA: 0x2ACA10
	// RVA: 0x261DE60 Offset: 0x261DF61 VA: 0x261DE60
	protected void set_OutDir(FXZ[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACA20 Offset: 0x2ACB21 VA: 0x2ACA20
	// RVA: 0x261DE70 Offset: 0x261DF71 VA: 0x261DE70
	protected bool[] get_SetFlying() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACA30 Offset: 0x2ACB31 VA: 0x2ACA30
	// RVA: 0x261DE80 Offset: 0x261DF81 VA: 0x261DE80
	protected void set_SetFlying(bool[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACA40 Offset: 0x2ACB41 VA: 0x2ACA40
	// RVA: 0x261DE90 Offset: 0x261DF91 VA: 0x261DE90
	protected bool get_SkipCheckOverWall() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACA50 Offset: 0x2ACB51 VA: 0x2ACA50
	// RVA: 0x261DEA0 Offset: 0x261DFA1 VA: 0x261DEA0
	protected void set_SkipCheckOverWall(bool value) { }

	// RVA: 0x261DEB0 Offset: 0x261DFB1 VA: 0x261DEB0
	protected float get_StartDistance() { }

	// RVA: 0x261DF70 Offset: 0x261E071 VA: 0x261DF70
	protected void .ctor(CombatRecord record) { }

	// RVA: 0x261AAE0 Offset: 0x261ABE1 VA: 0x261AAE0
	private void BaseSetup(CharacterGameStatus[] gs) { }

	// RVA: 0x261E190 Offset: 0x261E291 VA: 0x261E190 Slot: 5
	protected virtual void Setup(CharacterGameStatus[] gs) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract int get_RoughPosCount();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void SetRoughPos(int tryCount);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract int get_PatternCount();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void SetBattlePatern(int pattern);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void CalcLocation();

	// RVA: 0x261E1A0 Offset: 0x261E2A1 VA: 0x261E1A0
	protected int get_SideAtk() { }

	// RVA: 0x261E1B0 Offset: 0x261E2B1 VA: 0x261E1B0
	protected int get_SideDmg() { }

	// RVA: 0x261E1C0 Offset: 0x261E2C1 VA: 0x261E1C0
	protected ValueTuple<int, int> GetTileXY(int dist, int tile) { }

	// RVA: 0x261E450 Offset: 0x261E551 VA: 0x261E450
	protected ValueTuple<int, int> GetTileXY(int id) { }

	// RVA: 0x261E530 Offset: 0x261E631 VA: 0x261E530
	protected bool IsMoveOverWall() { }

	// RVA: 0x261E610 Offset: 0x261E711 VA: 0x261E610
	protected bool IsMoveOverWall(int side) { }

	// RVA: 0x261E7F0 Offset: 0x261E8F1 VA: 0x261E7F0
	private bool IsOverWall(int sX, int sZ, int gX, int gZ, bool isFly) { }

	// RVA: 0x261EBB0 Offset: 0x261ECB1 VA: 0x261EBB0
	private bool IsWall(int side, bool isBrawl) { }

	// RVA: 0x261E9C0 Offset: 0x261EAC1 VA: 0x261E9C0
	private bool IsWall(int x, int z, bool isBrawl, bool isFly) { }

	// RVA: 0x261ED00 Offset: 0x261EE01 VA: 0x261ED00
	protected bool IsOverBorder(bool isDebug = False) { }

	// RVA: 0x261F130 Offset: 0x261F231 VA: 0x261F130
	protected bool IsOverHeadBorder(bool isDebug = False) { }

	// RVA: 0x261F600 Offset: 0x261F701 VA: 0x261F600
	protected bool IsOverHeadBorder(int side, bool isDebug = False) { }

	// RVA: 0x261F740 Offset: 0x261F841 VA: 0x261F740
	protected bool IsRotateTooMuch() { }

	// RVA: 0x261F960 Offset: 0x261FA61 VA: 0x261F960
	protected bool IsStandable(bool isDebug = False) { }

	// RVA: 0x261FA20 Offset: 0x261FB21 VA: 0x261FA20
	protected bool IsStandable(int side, bool isDebug = False) { }

	// RVA: 0x261FA80 Offset: 0x261FB81 VA: 0x261FA80
	protected bool IsStandable(int side, float size, bool isDebug = False) { }

	// RVA: 0x261FD10 Offset: 0x261FE11 VA: 0x261FD10
	protected bool IsStandable(Vector3 center, float size, int mask, bool isDebug = False) { }

	// RVA: 0x261B3B0 Offset: 0x261B4B1 VA: 0x261B3B0
	protected bool IsOutOfMap() { }

	// RVA: 0x261FDB0 Offset: 0x261FEB1 VA: 0x261FDB0
	protected void AboidStep() { }

	// RVA: 0x261FE00 Offset: 0x261FF01 VA: 0x261FE00
	protected void AboidStep(int side, float dist = 0.2) { }

	// RVA: 0x2620220 Offset: 0x2620321 VA: 0x2620220
	protected float GetHeightForFly(FXZ pos, float fly, bool isDebug = False) { }

	// RVA: 0x2621020 Offset: 0x2621121 VA: 0x2621020
	protected float GetDist2CliffOrWall(int side, FXZ dir, float checkDist, bool isDebug = False) { }

	// RVA: 0x2621260 Offset: 0x2621361 VA: 0x2621260
	protected float GetDist2Cliff(int side, FXZ dir, float checkDist, bool isDebug = False) { }

	// RVA: 0x26210B0 Offset: 0x26211B1 VA: 0x26210B0
	protected float GetDist2Wall(int side, FXZ dir, float checkDist, bool isDebug = False) { }

	// RVA: 0x26215F0 Offset: 0x26216F1 VA: 0x26215F0
	protected bool IsShootable(bool isDebug = False) { }

	// RVA: 0x26217C0 Offset: 0x26218C1 VA: 0x26217C0
	protected bool CheckCameraSpace(int side, float forwardDist, float sideDist, bool isDebug = False) { }

	// RVA: 0x2621AD0 Offset: 0x2621BD1 VA: 0x2621AD0
	protected bool LocateForSolo(int side, int tryCount) { }

	// RVA: 0x261B8B0 Offset: 0x261B9B1 VA: 0x261B8B0
	protected bool LocateToOpenSpace(bool isDebug = False) { }

	// RVA: 0x2623260 Offset: 0x2623361 VA: 0x2623260
	public void RelocateToSpace(bool isStart) { }

	// RVA: 0x2623830 Offset: 0x2623931 VA: 0x2623830
	public void LocateForWin(Character[] charaArray) { }

	// RVA: 0x2623F10 Offset: 0x2624011 VA: 0x2623F10
	private int LocateSoloForWin(int side, bool checkEnPos, FXZ forward, float checkRadius) { }

	// RVA: 0x2624B80 Offset: 0x2624C81 VA: 0x2624B80
	public void LocateForSkip(Character[] charaArray) { }

	// RVA: 0x2623CD0 Offset: 0x2623DD1 VA: 0x2623CD0
	private void LocateForEndTraining(Character[] charaArray) { }

	// RVA: 0x2625050 Offset: 0x2625151 VA: 0x2625050
	public void LocateForChainAttack(Character chain, Character[] chars, int attackHash, float chainAttackTime) { }

	// RVA: 0x26257D0 Offset: 0x26258D1 VA: 0x26257D0
	public void RelocateAfterChainGuard(Character[] charaArray, Character guard) { }

	// RVA: 0x2625E40 Offset: 0x2625F41 VA: 0x2625E40
	public void LocateEmblemAfterCombat(Character emblem) { }

	// RVA: 0x2623CE0 Offset: 0x2623DE1 VA: 0x2623CE0
	public void LoadCurrentPos(Character[] charaArray) { }

	// RVA: 0x261B620 Offset: 0x261B721 VA: 0x261B620
	public static FXZ GetSoloCharacterForward(bool isEnemy) { }

	// RVA: 0x2625F80 Offset: 0x2626081 VA: 0x2625F80
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACA60 Offset: 0x2ACB61 VA: 0x2ACA60
	// RVA: 0x261DA90 Offset: 0x261DB91 VA: 0x261DA90
	internal static bool <Locate>g__isStandingDie|30_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACA70 Offset: 0x2ACB71 VA: 0x2ACA70
	// RVA: 0x2621400 Offset: 0x2621501 VA: 0x2621400
	private float <GetDist2Cliff>g__CheckImpl|123_0(Vector3 norm, ref BaseCombatLocation.<>c__DisplayClass123_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACA80 Offset: 0x2ACB81 VA: 0x2ACA80
	// RVA: 0x2623020 Offset: 0x2623121 VA: 0x2623020
	private bool <LocateToOpenSpace>g__CheckOpenSpace|128_0(int[] degreeType, int minDist, int maxDist, ref BaseCombatLocation.<>c__DisplayClass128_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACA90 Offset: 0x2ACB91 VA: 0x2ACA90
	// RVA: 0x2626060 Offset: 0x2626161 VA: 0x2626060
	private bool <LocateToOpenSpace>g__CheckOpenSpaceCore|128_1(int x, int z, int degree, int tryCnt, ref BaseCombatLocation.<>c__DisplayClass128_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACAA0 Offset: 0x2ACBA1 VA: 0x2ACAA0
	// RVA: 0x26245E0 Offset: 0x26246E1 VA: 0x26245E0
	private bool <LocateSoloForWin>g__isOK|131_0(ref BaseCombatLocation.<>c__DisplayClass131_0 ) { }
}

