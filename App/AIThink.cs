// Namespace: App
public class AIThink // TypeDefIndex: 9461
{
	// Fields
	private const uint BlowScoreNone = 0;
	private const uint BlowScoreWall = 1;
	private const uint BlowScoreBlew = 2;
	private const uint BlowScoreHole = 3;
	private const int BlowScoreBit = 2;
	public const int TerrainScoreBit = 4;
	public const int IceTileMoveMax = 4;
	private const int EscortDistance = 5;
	private const int EntrustAskHealA = 75;
	private const int EntrustAskHealB = 30;
	private const uint AttackTargetMax = 252;
	private const int EngageHealTargetCountThreshold = 2;
	private Unit m_Unit; // 0x10
	private AIThink.Think m_Think; // 0x18
	private AIValue.Order m_Order; // 0x1C
	private AIThink.UpdateFlag m_UpdateFlag; // 0x20
	private int m_UpdateActive; // 0x28
	private AIValue[] m_aUpdateValue; // 0x30
	private MapImageCoreByte m_Caution; // 0x38
	private MapImageCoreByte m_Rerewarp; // 0x40
	private byte[] m_aAttackTargetForCandidate; // 0x48
	private byte[] m_aAttackTargetForMind; // 0x50
	private int m_ProhibitEngageAttack; // 0x58
	private int m_ProhibitRod; // 0x5C
	private int m_ProhibitOverlap; // 0x60
	private bool m_IsEngageAttackOnceDone; // 0x64
	private bool m_IsMagicShieldOnceDone; // 0x65
	private bool m_IsEnchantWeaponDone; // 0x66
	private int m_BulletPattern; // 0x68
	private bool m_IsChangeATAttack; // 0x6C
	private MapPos[] m_Cells; // 0x70
	private AIThink.OverlapSkills m_OverlapSkills; // 0x78
	private AIThink.TrimasteriesSkills m_TrimasteriesSkills; // 0x88
	private AIBattleSimulator m_BattleSimulator; // 0x98
	private AIBattleSimulator m_BattleSimulatorForScore; // 0xA0
	private AIInterferenceSimulator m_InterferenceSimulator; // 0xA8
	private Unit[] m_NearTargetsCSO; // 0xB0
	private int[] m_TargetDistsCSO; // 0xB8
	private Dictionary<int, uint> m_UnitScores; // 0xC0
	private static MapPos[] s_CellsGAP; // 0x0
	private static BattleInfo s_BattleInfoGAP; // 0x8
	private static UnitItem s_UnitItemGAR; // 0x10
	private AIThink.EngageWaitAdditionalAttackImage m_EngageWaitAdditionalAttackImage; // 0xC8
	private MapImageCoreByte m_HolyShield; // 0xD0
	private AIThink.EnchantThink m_EnchantThink; // 0xD8

	// Methods

	// RVA: 0x1C9EC30 Offset: 0x1C9ED31 VA: 0x1C9EC30
	public void .ctor() { }

	// RVA: 0x1CB6810 Offset: 0x1CB6911 VA: 0x1CB6810
	public void SetUnit(Unit unit) { }

	// RVA: 0x1CB6820 Offset: 0x1CB6921 VA: 0x1CB6820
	public void SetThink(AIThink.Think think) { }

	// RVA: 0x1CB6830 Offset: 0x1CB6931 VA: 0x1CB6830
	public int GetAttackTargetForCandidateCount(int idx) { }

	// RVA: 0x1CB6870 Offset: 0x1CB6971 VA: 0x1CB6870
	public int GetAttackTargetForMind(int idx) { }

	// RVA: 0x1CA91D0 Offset: 0x1CA92D1 VA: 0x1CA91D0
	public void AddAttackTargetForMind(int idx, byte value = 1) { }

	// RVA: 0x1CA1200 Offset: 0x1CA1301 VA: 0x1CA1200
	public void Processing() { }

	// RVA: 0x1CA1E60 Offset: 0x1CA1F61 VA: 0x1CA1E60
	public void ProcessingRemove() { }

	// RVA: 0x1CA2020 Offset: 0x1CA2121 VA: 0x1CA2020
	public void ProcessingRemagic() { }

	// RVA: 0x1CA20F0 Offset: 0x1CA21F1 VA: 0x1CA20F0
	public void ProcessingRerewarp() { }

	// RVA: 0x1CA0C10 Offset: 0x1CA0D11 VA: 0x1CA0C10
	public void UpdateTarget() { }

	// RVA: 0x1CB8580 Offset: 0x1CB8681 VA: 0x1CB8580
	public static bool IsActiveCommand(Unit unit, AIData command) { }

	// RVA: 0x1CAAB30 Offset: 0x1CAAC31 VA: 0x1CAAB30
	public static bool IsAttackPermission(Unit actor, Unit target) { }

	[ConditionalAttribute] // RVA: 0x2AEF40 Offset: 0x2AF041 VA: 0x2AEF40
	// RVA: 0x1CB8600 Offset: 0x1CB8701 VA: 0x1CB8600
	private static void Warning(bool condition, string messge) { }

	// RVA: 0x1CB8610 Offset: 0x1CB8711 VA: 0x1CB8610
	public static bool IsAttackPermissionOnlyCommand(int command, AIValue v0, AIValue v1, Unit target) { }

	// RVA: 0x1CA9030 Offset: 0x1CA9131 VA: 0x1CA9030
	public static bool GetAttackPosition(Unit actor, Unit target, int itemIndex, int flag, ref AIThink.AttackPositionResult result) { }

	// RVA: 0x1CB87F0 Offset: 0x1CB88F1 VA: 0x1CB87F0
	public static bool GetAttackPosition(Unit actor, Unit target, int itemIndex, int targetX, int targetZ, int flag, ref AIThink.AttackPositionResult result) { }

	// RVA: 0x1CAE3B0 Offset: 0x1CAE4B1 VA: 0x1CAE3B0
	public static bool GetAttackPosition(Unit actor, Unit chained, Unit target, int itemIndex, SkillData skill, int targetX, int targetZ, int flag, ref AIThink.AttackPositionResult result) { }

	// RVA: 0x1CB8910 Offset: 0x1CB8A11 VA: 0x1CB8910
	public static bool GetAttackPosition(Unit actor, Unit chained, Unit target, int itemIndex, SkillData skill, int reqTargetCountInRange, int targetX, int targetZ, int flag, ref AIThink.AttackPositionResult result) { }

	// RVA: 0x1CBAF50 Offset: 0x1CBB051 VA: 0x1CBAF50
	private static bool GetMovePosition(Unit unit, int attackX, int attackZ, bool isAheadIgnore, out int move, out int moveX, out int moveZ) { }

	// RVA: 0x1CBB080 Offset: 0x1CBB181 VA: 0x1CBB080
	private static bool GetMovePosition(Unit unit, int finalAttackX, int finalAttackZ, bool isAheadIgnore, bool isPierceMultiple, Unit target, int targetX, int targetZ, SkillData commandSkill, out int move, out int moveX, out int moveZ, out int attackX, out int attackZ) { }

	// RVA: 0x1CBB1A0 Offset: 0x1CBB2A1 VA: 0x1CBB1A0
	private static bool GetMovePosition(Unit unit, int finalAttackX, int finalAttackZ, bool isAheadIgnore, bool isPierceMultiple, int reqTargetCountInRange, Unit target, int targetX, int targetZ, SkillData commandSkill, SkillArray equipSkillsOfItem, out int move, out int moveX, out int moveZ, out int attackX, out int attackZ) { }

	// RVA: 0x1CBC5B0 Offset: 0x1CBC6B1 VA: 0x1CBC5B0
	private static int CountPierceTargets(Unit unit, int moveX, int moveZ, SkillData skill, Unit target) { }

	// RVA: 0x1CBC700 Offset: 0x1CBC801 VA: 0x1CBC700
	private static int CountTargetsInRange(Unit unit, int moveX, int moveZ, SkillData skill, Unit target) { }

	// RVA: 0x1CBCE30 Offset: 0x1CBCF31 VA: 0x1CBCE30
	private static int CountTargetsInRangeForEquipSkillsOfItem(Unit unit, int moveX, int moveZ, SkillArray skills, Unit target) { }

	// RVA: 0x1CBD070 Offset: 0x1CBD171 VA: 0x1CBD070
	public static bool GetEventPosition(MapInspector.Kind kind, ref int refX, ref int refZ, ref uint refScore, bool isIn, bool isArrival, uint priority = 0) { }

	// RVA: 0x1CBD140 Offset: 0x1CBD241 VA: 0x1CBD140
	public static bool GetEventPosition(MapInspector.Kind kind, ref int refX, ref int refZ, ref int refTargetX, ref int refTargetZ, ref uint refScore, bool isIn, bool isArrival, uint priority = 0) { }

	// RVA: 0x1CA84B0 Offset: 0x1CA85B1 VA: 0x1CA84B0
	public static void LimitMoveImage(Unit actor, int limitX, int limitZ, int limitDistance) { }

	// RVA: 0x1CA5DE0 Offset: 0x1CA5EE1 VA: 0x1CA5DE0
	public static bool IsClever() { }

	// RVA: 0x1CB1670 Offset: 0x1CB1771 VA: 0x1CB1670
	public static MapDeployTemplate.Flag<AIDeploy> GetDeployFreeMoveFlag(Unit unit) { }

	// RVA: 0x1CB6C90 Offset: 0x1CB6D91 VA: 0x1CB6C90
	public static bool IsMoveOver() { }

	// RVA: 0x1CBC4F0 Offset: 0x1CBC5F1 VA: 0x1CBC4F0
	public static bool IsMoveOver(Unit actor, int x, int z) { }

	// RVA: 0x1CBD2D0 Offset: 0x1CBD3D1 VA: 0x1CBD2D0
	public static bool IsAllowIdleMutation() { }

	// RVA: 0x1CBD350 Offset: 0x1CBD451 VA: 0x1CBD350
	public static void UpdateHealCondition(Unit unit, int healPower = 0) { }

	// RVA: 0x1CBD7F0 Offset: 0x1CBD8F1 VA: 0x1CBD7F0
	public static bool IsHealConditionForEntrust(Unit unit) { }

	// RVA: 0x1CBD9D0 Offset: 0x1CBDAD1 VA: 0x1CBD9D0
	public static int GetItemIndexHeal(Unit unit) { }

	// RVA: 0x1CBE090 Offset: 0x1CBE191 VA: 0x1CBE090
	public static uint GetTerrainScore(Unit unit, int x, int z) { }

	// RVA: 0x1CBE410 Offset: 0x1CBE511 VA: 0x1CBE410
	private static int GetTerrainHeal(Unit unit, TerrainData terrain) { }

	// RVA: 0x1CBE520 Offset: 0x1CBE621 VA: 0x1CBE520
	private static int GetBoundaryIceTileMove(Unit unit, int x, int z, int move, int flag = 0) { }

	// RVA: 0x1CBE960 Offset: 0x1CBEA61 VA: 0x1CBE960
	private static int GetBoundaryIceTileMove(Unit unit, int x, int z, int move, int goalX, int goalZ, int flag = 0) { }

	// RVA: 0x1CBEA40 Offset: 0x1CBEB41 VA: 0x1CBEA40
	public static bool GetActiveAttackCommand(Unit unit, Unit target, out int resultCommand, out AIValue resultV0, out AIValue resultV1) { }

	// RVA: 0x1CAB5B0 Offset: 0x1CAB6B1 VA: 0x1CAB5B0
	public static bool HasActiveAttackCommandForCrossfire(Unit unit, Unit target) { }

	// RVA: 0x1CBED60 Offset: 0x1CBEE61 VA: 0x1CBED60
	public static bool HasActiveAttackCommandForInterruptAttack(Unit unit, Unit target) { }

	// RVA: 0x1CA9A00 Offset: 0x1CA9B01 VA: 0x1CA9A00
	public static bool HasActiveCommand(AIValue.Order order, Unit unit) { }

	// RVA: 0x1CBEE40 Offset: 0x1CBEF41 VA: 0x1CBEE40
	public static bool GetEngageAttackCommand(Unit unit, out int resultCommand, out AIValue resultV0, out AIValue resultV1) { }

	// RVA: 0x1CA5C50 Offset: 0x1CA5D51 VA: 0x1CA5C50
	public static bool IsThinkBreak(Unit unit) { }

	// RVA: 0x1CA5A30 Offset: 0x1CA5B31 VA: 0x1CA5A30
	public static bool IsThinkChain(Unit unit) { }

	// RVA: 0x1CB68B0 Offset: 0x1CB69B1 VA: 0x1CB68B0
	private AIThink.Result ProcessingActive(AIValue.Order order) { }

	// RVA: 0x1CB7430 Offset: 0x1CB7531 VA: 0x1CB7430
	private void ProcessingResult(AIValue.Order order) { }

	// RVA: 0x1CB6E10 Offset: 0x1CB6F11 VA: 0x1CB6E10
	private AIThink.Result ProcessingMutation() { }

	// RVA: 0x1CBF0A0 Offset: 0x1CBF1A1 VA: 0x1CBF0A0
	private void ActiveCause(AIData command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CBFB10 Offset: 0x1CBFC11 VA: 0x1CBFB10
	private void ResultCause(AIData command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CBF260 Offset: 0x1CBF361 VA: 0x1CBF260
	private AIThink.Result Action(AIData command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CB7290 Offset: 0x1CB7391 VA: 0x1CB7290
	private void Update(AIValue.Order order) { }

	// RVA: 0x1CBF9C0 Offset: 0x1CBFAC1 VA: 0x1CBF9C0
	private void ChangeSeq(AIValue.Order order, AIData command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CBFA20 Offset: 0x1CBFB21 VA: 0x1CBFA20
	private void ChangeValue(AIValue.Order order, AIData command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CBFC20 Offset: 0x1CBFD21 VA: 0x1CBFC20
	private bool ActiveCauseEverytime(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CBFC30 Offset: 0x1CBFD31 VA: 0x1CBFC30
	private bool ActiveCauseAttackRange(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC0500 Offset: 0x1CC0601 VA: 0x1CC0500
	private bool ActiveCauseBandRange(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC0810 Offset: 0x1CC0911 VA: 0x1CC0810
	private bool ActiveCauseHealRange(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC1170 Offset: 0x1CC1271 VA: 0x1CC1170
	private bool ActiveCauseAreaEnemy(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC1320 Offset: 0x1CC1421 VA: 0x1CC1320
	private bool ActiveCauseTurn(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC13C0 Offset: 0x1CC14C1 VA: 0x1CC13C0
	private bool ActiveCauseFlagTrue(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC1410 Offset: 0x1CC1511 VA: 0x1CC1410
	private bool ActiveCauseFlagFalse(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC1460 Offset: 0x1CC1561 VA: 0x1CC1460
	private bool ActiveCauseDoneHeal(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC1480 Offset: 0x1CC1581 VA: 0x1CC1480
	private bool ActiveCauseInterferenceRange(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC17D0 Offset: 0x1CC18D1 VA: 0x1CC17D0
	private bool ResultCauseAttack(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC1850 Offset: 0x1CC1951 VA: 0x1CC1850
	private bool ResultCauseTalk(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC1960 Offset: 0x1CC1A61 VA: 0x1CC1960
	private bool ResultCauseArrive(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC1B80 Offset: 0x1CC1C81 VA: 0x1CC1B80
	private AIThink.Result ActionAttackDefault(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC2780 Offset: 0x1CC2881 VA: 0x1CC2780
	private AIThink.Result ActionAttackMiddleLow(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC27A0 Offset: 0x1CC28A1 VA: 0x1CC27A0
	private AIThink.Result ActionAttackLow(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC27C0 Offset: 0x1CC28C1 VA: 0x1CC27C0
	private AIThink.Result ActionRodHeal(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC2C00 Offset: 0x1CC2D01 VA: 0x1CC2C00
	private AIThink.Result ActionRodWarp(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC36B0 Offset: 0x1CC37B1 VA: 0x1CC36B0
	private AIThink.Result ActionRodRescue(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC4120 Offset: 0x1CC4221 VA: 0x1CC4120
	private AIThink.Result ActionRodInterference(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC4730 Offset: 0x1CC4831 VA: 0x1CC4730
	private AIThink.Result ActionHealDefault(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC4830 Offset: 0x1CC4931 VA: 0x1CC4830
	private AIThink.Result ActionHealMiddleLow(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC48D0 Offset: 0x1CC49D1 VA: 0x1CC48D0
	private AIThink.Result ActionHealNearingHero(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC53F0 Offset: 0x1CC54F1 VA: 0x1CC53F0
	private AIThink.Result ActionEngageAttack(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC5BA0 Offset: 0x1CC5CA1 VA: 0x1CC5BA0
	private AIThink.Result ActionEngageDance(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC5F10 Offset: 0x1CC6011 VA: 0x1CC5F10
	private AIThink.Result ActionEngageVision(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC6330 Offset: 0x1CC6431 VA: 0x1CC6330
	private AIThink.Result ActionEngagePierce(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC6760 Offset: 0x1CC6861 VA: 0x1CC6760
	private AIThink.Result ActionMindTalk(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC6A40 Offset: 0x1CC6B41 VA: 0x1CC6A40
	private AIThink.Result ActionMindTreasure(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC6E10 Offset: 0x1CC6F11 VA: 0x1CC6E10
	private AIThink.Result ActionMindVillage(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC7160 Offset: 0x1CC7261 VA: 0x1CC7160
	private AIThink.Result ActionMindEscape(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC8060 Offset: 0x1CC8161 VA: 0x1CC8060
	private AIThink.Result ActionMindBreakDown(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC8280 Offset: 0x1CC8381 VA: 0x1CC8280
	private AIThink.Result ActionMindDance(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC85D0 Offset: 0x1CC86D1 VA: 0x1CC85D0
	private AIThink.Result ActionMindTerrainDestroy(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC88C0 Offset: 0x1CC89C1 VA: 0x1CC88C0
	private AIThink.Result ActionMindTorch(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC8D20 Offset: 0x1CC8E21 VA: 0x1CC8D20
	private AIThink.Result ActionMindGuard(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC9660 Offset: 0x1CC9761 VA: 0x1CC9660
	private AIThink.Result ActionMoveIdle(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC98D0 Offset: 0x1CC99D1 VA: 0x1CC98D0
	private AIThink.Result ActionMoveNearestEnemy(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC9BC0 Offset: 0x1CC9CC1 VA: 0x1CC9BC0
	private AIThink.Result ActionMoveNearestFriend(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC9EA0 Offset: 0x1CC9FA1 VA: 0x1CC9EA0
	private AIThink.Result ActionMoveAttackRange(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC9F30 Offset: 0x1CCA031 VA: 0x1CC9F30
	private AIThink.Result ActionMoveAttackRangeImpl(int command, AIValue v0, AIValue v1, bool retry) { }

	// RVA: 0x1CCA780 Offset: 0x1CCA881 VA: 0x1CCA780
	private AIThink.Result ActionMoveHealRange(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CCAE70 Offset: 0x1CCAF71 VA: 0x1CCAE70
	private AIThink.Result ActionMoveHero(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CCB0B0 Offset: 0x1CCB1B1 VA: 0x1CCB0B0
	private AIThink.Result ActionMovePerson(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CCB370 Offset: 0x1CCB471 VA: 0x1CCB370
	private AIThink.Result ActionMovePosition(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CCB5A0 Offset: 0x1CCB6A1 VA: 0x1CCB5A0
	private AIThink.Result ActionMoveTerrain(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CCB7E0 Offset: 0x1CCB8E1 VA: 0x1CCB7E0
	private AIThink.Result ActionMoveForce(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CB6D20 Offset: 0x1CB6E21 VA: 0x1CB6D20
	private AIThink.Result ActionMoveReturn(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CCBAE0 Offset: 0x1CCBBE1 VA: 0x1CCBAE0
	private AIThink.Result ActionMoveTreasure(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CCC280 Offset: 0x1CCC381 VA: 0x1CCC280
	private AIThink.Result ActionMoveVillage(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CCCA10 Offset: 0x1CCCB11 VA: 0x1CCCA10
	private AIThink.Result ActionMoveEscape(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CCD1B0 Offset: 0x1CCD2B1 VA: 0x1CCD1B0
	private AIThink.Result ActionMoveTerrainDestroy(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CCD400 Offset: 0x1CCD501 VA: 0x1CCD400
	private AIThink.Result ActionMoveRetreat(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CCDBF0 Offset: 0x1CCDCF1 VA: 0x1CCDBF0
	private AIThink.Result ActionMoveBreakDown(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CCDE20 Offset: 0x1CCDF21 VA: 0x1CCDE20
	private AIThink.Result ActionMoveRewarp(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CCE740 Offset: 0x1CCE841 VA: 0x1CCE740
	private int GetRewarpItemIndex(Unit unit) { }

	// RVA: 0x1CCED70 Offset: 0x1CCEE71 VA: 0x1CCED70
	private bool GetRewarpPosition(Unit unit, UnitItem unitItem, int targetX, int targetZ, out int resultX, out int resultZ, bool useMoveImageB = False) { }

	// RVA: 0x1CCF170 Offset: 0x1CCF271 VA: 0x1CCF170
	private AIThink.Result ActionCommandSkillBattle(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CCF480 Offset: 0x1CCF581 VA: 0x1CCF480
	private AIThink.Result ActionCommandSkillOverlap(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CB7770 Offset: 0x1CB7871 VA: 0x1CB7770
	private AIThink.Result ActionRemove() { }

	// RVA: 0x1CB7F50 Offset: 0x1CB8051 VA: 0x1CB7F50
	private AIThink.Result ActionRemagic() { }

	// RVA: 0x1CB81B0 Offset: 0x1CB82B1 VA: 0x1CB81B0
	private AIThink.Result ActionRerewarp() { }

	// RVA: 0x1CCF960 Offset: 0x1CCFA61 VA: 0x1CCF960
	public static bool GetRerewarpPosition(out int dstX, out int dstZ, Unit actor, MapImageCoreByte workingImage, bool isRough = False) { }

	// RVA: 0x1CC0110 Offset: 0x1CC0211 VA: 0x1CC0110
	private bool IsEnemyInsideAttackAreaForAC(int command, AIValue v0, AIValue v1, Unit actor, int x, int z, int movePower, int bandThreshold = 0, bool isExcludeSelf = False) { }

	// RVA: 0x1CC8AE0 Offset: 0x1CC8BE1 VA: 0x1CC8AE0
	private bool IsAttackableEnemy(int command, AIValue v0, AIValue v1, Unit actor) { }

	// RVA: 0x1CD03C0 Offset: 0x1CD04C1 VA: 0x1CD03C0
	private bool IsAttackableEnemyForEntrust(Unit actor) { }

	// RVA: 0x1CC1B90 Offset: 0x1CC1C91 VA: 0x1CC1B90
	private AIThink.Result AttackTo(int command, AIValue v0, AIValue v1, SkillData commandSkill) { }

	// RVA: 0x1CCF730 Offset: 0x1CCF831 VA: 0x1CCF730
	private void SetAttackTargetToMind(ref AIThink.AttackTarget target, SkillData commandSkill) { }

	// RVA: 0x1CD05F0 Offset: 0x1CD06F1 VA: 0x1CD05F0
	private bool IsAttackPermission(Unit target) { }

	// RVA: 0x1CD0670 Offset: 0x1CD0771 VA: 0x1CD0670
	private bool IsAttackPermissionWithCommand(int command, AIValue v0, AIValue v1, Unit target) { }

	// RVA: 0x1CD0780 Offset: 0x1CD0881 VA: 0x1CD0780
	private bool IsAttackPermissionWithCommand(int command, AIValue v0, AIValue v1, Unit actor, Unit target) { }

	// RVA: 0x1CD0870 Offset: 0x1CD0971 VA: 0x1CD0870
	private int CompareAttackPriorityWithCommand(int command, AIValue v0, AIValue v1, Unit unit0, Unit unit1) { }

	// RVA: 0x1CD0980 Offset: 0x1CD0A81 VA: 0x1CD0980
	private int CompareAttackPriorityWithBlow(uint blowScore0, float killRate0, uint blowScore1, float killRate1) { }

	// RVA: 0x1CD09F0 Offset: 0x1CD0AF1 VA: 0x1CD09F0
	private int CompareAttackPriorityWithChainAttackCount(int chainAttackCount0, int chainAttackCount1) { }

	// RVA: 0x1CD0A10 Offset: 0x1CD0B11 VA: 0x1CD0A10
	internal static int CompareAttackPriorityWithDecoy(Unit unit0, Unit unit1) { }

	// RVA: 0x1CD0A50 Offset: 0x1CD0B51 VA: 0x1CD0A50
	private int CompareAttackPriorityWithBullet(Unit actor, int itemIndex0, Unit target0, int itemIndex1, Unit target1) { }

	// RVA: 0x1CD1540 Offset: 0x1CD1641 VA: 0x1CD1540
	private bool CheckAttackPriority(int command, AIValue v0, AIValue v1, Unit unit, ref AIThink.AttackScoreResult asResult, ref AIThink.AttackTarget target) { }

	// RVA: 0x1CD17D0 Offset: 0x1CD18D1 VA: 0x1CD17D0
	private bool CheckAttackPriority(Unit unit, ref AIThink.AttackScoreResult asResult, ref AIThink.AttackTarget target) { }

	// RVA: 0x1CD1810 Offset: 0x1CD1911 VA: 0x1CD1810
	private bool CheckAttackPriority(int command, AIValue v0, AIValue v1, Unit actor, Unit unit, ref AIThink.AttackScoreResult asResult, ref AIThink.AttackTarget target) { }

	// RVA: 0x1CD1580 Offset: 0x1CD1681 VA: 0x1CD1580
	private bool CheckAttackPriorityImpl(int command, AIValue v0, AIValue v1, Unit actor, Unit unit, ref AIThink.AttackScoreResult asResult, ref AIThink.AttackTarget target, bool isIgnoreCommand) { }

	// RVA: 0x1CD1840 Offset: 0x1CD1941 VA: 0x1CD1840
	private bool GetAttackScore(Unit target, int flag, ref AIThink.AttackScoreResult result) { }

	// RVA: 0x1CD1EE0 Offset: 0x1CD1FE1 VA: 0x1CD1EE0
	private bool GetAttackScore(Unit target, int targetX, int targetZ, int flag, ref AIThink.AttackScoreResult result) { }

	// RVA: 0x1CD1F30 Offset: 0x1CD2031 VA: 0x1CD1F30
	private bool GetAttackScore(Unit target, int targetX, int targetZ, int flag, int priorItemIndex, SkillData skill, int bulletPattern, ref AIThink.AttackScoreResult result) { }

	// RVA: 0x1CD1890 Offset: 0x1CD1991 VA: 0x1CD1890
	private bool GetAttackScore(Unit current, Unit target, int targetX, int targetZ, int flag, int priorItemIndex, SkillData skill, int bulletPattern, ref AIThink.AttackScoreResult result) { }

	// RVA: 0x1CD2050 Offset: 0x1CD2151 VA: 0x1CD2050
	private bool GetEntrustAttackScore(Unit target, int itemIndex, int targetX, int targetZ, ref AIThink.EntrustAttackScoreResult easResult) { }

	// RVA: 0x1CD2340 Offset: 0x1CD2441 VA: 0x1CD2340
	private bool GetEntrustAttackScore(Unit target, int itemIndex, int targetX, int targetZ, int flag, SkillData skill, ref AIThink.EntrustAttackScoreResult easResult) { }

	// RVA: 0x1CD20A0 Offset: 0x1CD21A1 VA: 0x1CD20A0
	private bool GetEntrustAttackScore(Unit current, Unit target, int itemIndex, int targetX, int targetZ, int flag, SkillData skill, ref AIThink.EntrustAttackScoreResult easResult) { }

	// RVA: 0x1CBA4E0 Offset: 0x1CBA5E1 VA: 0x1CBA4E0
	private static int GetAttackRange(Unit unit, int itemIndex, SkillData skill, int flag, ref ulong bit, bool isEnemy = False) { }

	// RVA: 0x1CD1F80 Offset: 0x1CD2081 VA: 0x1CD1F80
	private static bool IsWeaponProhibit(Unit unit, int itemIndex, SkillData skill) { }

	// RVA: 0x1CCF230 Offset: 0x1CCF331 VA: 0x1CCF230
	private static SkillData GetCommandSkill(Unit unit) { }

	// RVA: 0x1CD2390 Offset: 0x1CD2491 VA: 0x1CD2390
	private AIThink.GodSkillTypes GetGodSkill(Unit unit, out SkillData godSkill, int kind) { }

	// RVA: 0x1CD23E0 Offset: 0x1CD24E1 VA: 0x1CD23E0
	private AIThink.GodSkillTypes GetGodSkillImpl(Unit unit, out SkillData godSkill, int kind) { }

	// RVA: 0x1CD2890 Offset: 0x1CD2991 VA: 0x1CD2890
	private bool IsGodSkillDecoy(SkillArray.Entity entity) { }

	// RVA: 0x1CD2780 Offset: 0x1CD2881 VA: 0x1CD2780
	private bool IsGodSkillTrimasteries(SkillArray.Entity entity) { }

	// RVA: 0x1CD2870 Offset: 0x1CD2971 VA: 0x1CD2870
	private bool IsGodSkillStrategyHolyShield(SkillArray.Entity entity) { }

	// RVA: 0x1CD2880 Offset: 0x1CD2981 VA: 0x1CD2880
	private bool IsGodSkillGaze(SkillArray.Entity entity) { }

	// RVA: 0x1CD0B20 Offset: 0x1CD0C21 VA: 0x1CD0B20
	private AIThink.CGBSResult CanGiveBadStatesForBullet(ItemData item, Unit target) { }

	// RVA: 0x1CD2A80 Offset: 0x1CD2B81 VA: 0x1CD2A80
	private static SkillData.States GetGiveBadStatesForBullet(ItemData item) { }

	[ConditionalAttribute] // RVA: 0x2AEF80 Offset: 0x2AF081 VA: 0x2AEF80
	// RVA: 0x1CD2D20 Offset: 0x1CD2E21 VA: 0x1CD2D20
	private static void DbgCheckGetGiveBadStatesForBullet() { }

	// RVA: 0x1CD2D30 Offset: 0x1CD2E31 VA: 0x1CD2D30
	private void GetRodProhibitMinMax(AIValue v0, AIValue v1, out int min, out int max) { }

	// RVA: 0x1CD2E90 Offset: 0x1CD2F91 VA: 0x1CD2E90
	private bool IsRodPermission(int prohibitMin, int prohibitMax) { }

	// RVA: 0x1CD2F60 Offset: 0x1CD3061 VA: 0x1CD2F60
	private void DecideToProhibitRod(int min, int max) { }

	// RVA: 0x1CC2C10 Offset: 0x1CC2D11 VA: 0x1CC2C10
	private AIThink.Result RodWarpTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CD3020 Offset: 0x1CD3121 VA: 0x1CD3020
	private bool GetWarpRodEvalution(Unit target, ItemData warpRodItem, int warpRodItemIndex, int attackFlag, ref AIThink.WarpRodEvaluationResult result) { }

	// RVA: 0x1CD3780 Offset: 0x1CD3881 VA: 0x1CD3780
	private bool GetWarpRodFarZEvalution(Unit target, ItemData warpRodItem, int warpRodItemIndex, int attackFlag, ref AIThink.WarpRodEvaluationResult result) { }

	// RVA: 0x1CC36C0 Offset: 0x1CC37C1 VA: 0x1CC36C0
	private AIThink.Result RodRescueTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CD3B80 Offset: 0x1CD3C81 VA: 0x1CD3B80
	private bool GetRescueRodScore(Unit target, int targetX, int targetZ, ItemData rescueRodItem, int rescueRodItemIndex, int attackFlag, ref AIThink.RescueRodScoreResult result) { }

	// RVA: 0x1CC15A0 Offset: 0x1CC16A1 VA: 0x1CC15A0
	private bool IsEnemyInsideInterferenceArea(int command, AIValue v0, AIValue v1, Unit actor, int x, int z, int movePower, int bandThreshold = 0) { }

	// RVA: 0x1CC4130 Offset: 0x1CC4231 VA: 0x1CC4130
	private AIThink.Result InterferenceTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CD3C40 Offset: 0x1CD3D41 VA: 0x1CD3C40
	private bool GetInterferenceScore(Unit target, int targetX, int targetZ, int flag, ref AIThink.InterferenceScoreResult result) { }

	// RVA: 0x1CC27D0 Offset: 0x1CC28D1 VA: 0x1CC27D0
	private AIThink.Result RodHealTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CD48D0 Offset: 0x1CD49D1 VA: 0x1CD48D0
	private bool IsHealRodPermission(Unit target) { }

	// RVA: 0x1CD4CA0 Offset: 0x1CD4DA1 VA: 0x1CD4CA0
	private uint CalcHealRodScore(int heal, int damage, int x, int z, int itemIndex) { }

	// RVA: 0x1CD4DE0 Offset: 0x1CD4EE1 VA: 0x1CD4DE0
	private bool GetHealRodScoreImpl(Unit target, int targetX, int targetZ, int itemIndex, ref AIThink.HealRodScoreImplResult result) { }

	// RVA: 0x1CD5270 Offset: 0x1CD5371 VA: 0x1CD5270
	private bool GetHealRodScore(Unit target, int targetX, int targetZ, ref AIThink.HealRodScoreResult result) { }

	// RVA: 0x1CD3F50 Offset: 0x1CD4051 VA: 0x1CD3F50
	private bool GetRangeHealRodScore(ref uint score, ref int itemIndex) { }

	// RVA: 0x1CD3510 Offset: 0x1CD3611 VA: 0x1CD3510
	private bool GetHealRodPosition(Unit actor, Unit target, int itemIndex, int targetX, int targetZ, int flag, ref AIThink.HealRodPositionResult result, SkillData skill) { }

	// RVA: 0x1CD5390 Offset: 0x1CD5491 VA: 0x1CD5390
	private static int GetHealRodRange(Unit unit, int itemIndex, ref uint bit, SkillData skill) { }

	// RVA: 0x1CD42C0 Offset: 0x1CD43C1 VA: 0x1CD42C0
	private void UpdateHealConditionByRod(Unit actor, UnitItem rod, int moveX, int moveZ) { }

	// RVA: 0x1CD4560 Offset: 0x1CD4661 VA: 0x1CD4560
	private void UpdateHealConditionByRod(Unit actor, UnitItem rod, Unit target) { }

	// RVA: 0x1CC47B0 Offset: 0x1CC48B1 VA: 0x1CC47B0
	private AIThink.Result HealMindTo() { }

	// RVA: 0x1CD5CC0 Offset: 0x1CD5DC1 VA: 0x1CD5CC0
	private AIThink.Result HealMindToVulnerary() { }

	// RVA: 0x1CD5E80 Offset: 0x1CD5F81 VA: 0x1CD5E80
	private AIThink.Result HealMindToTerrain() { }

	// RVA: 0x1CC0AE0 Offset: 0x1CC0BE1 VA: 0x1CC0AE0
	private static bool HasHealRod(Unit unit, bool excludeInfinity = False) { }

	// RVA: 0x1CD5F90 Offset: 0x1CD6091 VA: 0x1CD5F90
	private bool GetTerrainHealPosition(out int x, out int z) { }

	// RVA: 0x1CD6500 Offset: 0x1CD6601 VA: 0x1CD6500
	private static int GetTerrainHeal(int x, int z) { }

	// RVA: 0x1CC8290 Offset: 0x1CC8391 VA: 0x1CC8290
	private AIThink.Result DanceTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CC8D30 Offset: 0x1CC8E31 VA: 0x1CC8D30
	private AIThink.Result GuardTo(int command, AIValue v0, AIValue v1, SkillData skill) { }

	// RVA: 0x1CC85E0 Offset: 0x1CC86E1 VA: 0x1CC85E0
	private AIThink.Result TerrainDestroyTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CD6660 Offset: 0x1CD6761 VA: 0x1CD6660
	private bool IsDestroyTarget(int targetX, int targetZ) { }

	// RVA: 0x1CC5400 Offset: 0x1CC5501 VA: 0x1CC5400
	private AIThink.Result EngageAttackTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CD6B50 Offset: 0x1CD6C51 VA: 0x1CD6B50
	private void DeployForEngageAttackTo(SkillData engageAttack, bool isRewarp, MapDeployTemplate.Flag<AIDeploy> moveFlag, MapDeployTemplate.Flag<AIDeploy> weaponFlag, int limitX = -1, int limitZ = -1, int limitDistance = -1) { }

	// RVA: 0x1CD6E20 Offset: 0x1CD6F21 VA: 0x1CD6E20
	private void GetEngageRewarpPos(SkillData engageAttack, int origMoveX, int origMoveZ, out int moveX, out int moveZ, out int rewarpX, out int rewarpZ) { }

	// RVA: 0x1CC5BB0 Offset: 0x1CC5CB1 VA: 0x1CC5BB0
	private AIThink.Result EngageDanceTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CD7160 Offset: 0x1CD7261 VA: 0x1CD7160
	private AIThink.Result EngageDanceToCommon(out int moveX, out int moveZ, int limitX = -1, int limitZ = -1, int limitDistance = -1) { }

	// RVA: 0x1CC6340 Offset: 0x1CC6441 VA: 0x1CC6340
	private AIThink.Result EngagePierceTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CD75A0 Offset: 0x1CD76A1 VA: 0x1CD75A0
	private AIThink.Result EngageChargeTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CD7960 Offset: 0x1CD7A61 VA: 0x1CD7960
	private AIThink.Result EngageChargeToCommon(out int moveX, out int moveZ, int limitX = -1, int limitZ = -1, int limitDistance = -1) { }

	// RVA: 0x1CD7FA0 Offset: 0x1CD80A1 VA: 0x1CD7FA0
	private AIThink.Result EngageHealTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CD8340 Offset: 0x1CD8441 VA: 0x1CD8340
	private AIThink.Result EngageHealToCommon(out int moveX, out int moveZ, int limitX = -1, int limitZ = -1, int limitDistance = -1) { }

	// RVA: 0x1CD86D0 Offset: 0x1CD87D1 VA: 0x1CD86D0
	private int EngageHealToCountTarget(Unit actor, SkillData engageAttack) { }

	// RVA: 0x1CC5F30 Offset: 0x1CC6031 VA: 0x1CC5F30
	private AIThink.Result EngageVisionTo(bool isEntrust = False) { }

	// RVA: 0x1CD88C0 Offset: 0x1CD89C1 VA: 0x1CD88C0
	private AIThink.Result EngageSupportTo(int command, AIValue v0, AIValue v1, SkillData commandSkill) { }

	// RVA: 0x1CD8910 Offset: 0x1CD8A11 VA: 0x1CD8910
	private AIThink.Result EngageSupportToCommon(SkillData commandSkill) { }

	// RVA: 0x1CD8C30 Offset: 0x1CD8D31 VA: 0x1CD8C30
	private AIThink.Result EngagePullBackTo(int command, AIValue v0, AIValue v1, SkillData commandSkill) { }

	// RVA: 0x1CD8C40 Offset: 0x1CD8D41 VA: 0x1CD8C40
	private AIThink.Result EngagePullBackToCommon(SkillData commandSkill) { }

	// RVA: 0x1CD8F70 Offset: 0x1CD9071 VA: 0x1CD8F70
	private AIThink.Result EngageTo(bool isEntrust) { }

	// RVA: 0x1CD92D0 Offset: 0x1CD93D1 VA: 0x1CD92D0
	private AIThink.Result GodChangeTo() { }

	// RVA: 0x1CD6990 Offset: 0x1CD6A91 VA: 0x1CD6990
	private static void GetEngageProhibitMinMax(AIValue v0, AIValue v1, out int min, out int max) { }

	// RVA: 0x1CD6A50 Offset: 0x1CD6B51 VA: 0x1CD6A50
	private bool IsEngagePermission(int prohibitMin, int prohibitMax) { }

	// RVA: 0x1CD9620 Offset: 0x1CD9721 VA: 0x1CD9620
	private static bool IsEngagePermission(Unit unit, int prohibitMin, int prohibitMax) { }

	// RVA: 0x1CD7100 Offset: 0x1CD7201 VA: 0x1CD7100
	private void DecideToProhibitEngage(int min, int max) { }

	// RVA: 0x1CD0020 Offset: 0x1CD0121 VA: 0x1CD0020
	public static bool CanUseEngageAttack(Unit unit) { }

	// RVA: 0x1CD0330 Offset: 0x1CD0431 VA: 0x1CD0330
	private static bool IsEngageRewarp(SkillData engageAttack) { }

	// RVA: 0x1CD7D90 Offset: 0x1CD7E91 VA: 0x1CD7D90
	private static bool EngageCheckAndEquipItem(Unit actor) { }

	// RVA: 0x1CD7080 Offset: 0x1CD7181 VA: 0x1CD7080
	private static SkillData GetRealEngageAttack(Unit unit, int moveX, int moveZ) { }

	// RVA: 0x1CC4BF0 Offset: 0x1CC4CF1 VA: 0x1CC4BF0
	private AIThink.Result MoveTo(int xx, int zz, int flag = 0) { }

	// RVA: 0x1CD9C70 Offset: 0x1CD9D71 VA: 0x1CD9C70
	private bool ToBreak(int x, int z) { }

	// RVA: 0x1CDA030 Offset: 0x1CDA131 VA: 0x1CDA030
	private bool ToDoor(int x, int z) { }

	// RVA: 0x1CD9950 Offset: 0x1CD9A51 VA: 0x1CD9950
	private bool ToBlock(int x, int z, bool isEntrust = False) { }

	// RVA: 0x1CDA550 Offset: 0x1CDA651 VA: 0x1CDA550
	private void EachBlock(Unit unit, MapFor.DestroyFunction func) { }

	// RVA: 0x1CDA2F0 Offset: 0x1CDA3F1 VA: 0x1CDA2F0
	private void EachBlockForEntrust(Unit unit, MapFor.DestroyFunction func) { }

	// RVA: 0x1CD9740 Offset: 0x1CD9841 VA: 0x1CD9740
	private bool IsMoveNear(int xx, int zz) { }

	// RVA: 0x1CDAE80 Offset: 0x1CDAF81 VA: 0x1CDAE80
	private bool CheckMoveTargetWithAttack(Unit target) { }

	// RVA: 0x1CDB070 Offset: 0x1CDB171 VA: 0x1CDB070
	private bool GetSidePosition(int targetX, int targetZ, ref int refX, ref int refZ) { }

	// RVA: 0x1CDB1E0 Offset: 0x1CDB2E1 VA: 0x1CDB1E0
	private bool IsEscapePosition(int x, int z) { }

	// RVA: 0x1CC74E0 Offset: 0x1CC75E1 VA: 0x1CC74E0
	private int GetMovePowerSlow() { }

	// RVA: 0x1CBFD50 Offset: 0x1CBFE51 VA: 0x1CBFD50
	private int GetMovePower(Unit unit, int factor = 100) { }

	// RVA: 0x1CB7690 Offset: 0x1CB7791 VA: 0x1CB7690
	private bool IsNotMove() { }

	// RVA: 0x1CDB360 Offset: 0x1CDB461 VA: 0x1CDB360
	private static uint GetBlowScore(int actorX, int actorZ, Unit target, int targetX, int targetZ) { }

	// RVA: 0x1CCF580 Offset: 0x1CCF681 VA: 0x1CCF580
	private AIThink.Result CommandSkillOverlapTo(int command, AIValue v0, AIValue v1, SkillData commandSkill) { }

	// RVA: 0x1CDB580 Offset: 0x1CDB681 VA: 0x1CDB580
	private AIThink.Result CommandSkillOverlapToCommon(SkillData commandSkill) { }

	// RVA: 0x1CDBE60 Offset: 0x1CDBF61 VA: 0x1CDBE60
	private bool CheckDirForOverlap(int x0, int z0, int x1, int z1, Unit[] units) { }

	// RVA: 0x1CDBC90 Offset: 0x1CDBD91 VA: 0x1CDBC90
	private bool IsPositiveOverlap(SkillData skill) { }

	// RVA: 0x1CDBDB0 Offset: 0x1CDBEB1 VA: 0x1CDBDB0
	private bool IsHealOverlap(SkillData skill) { }

	// RVA: 0x1CDBEE0 Offset: 0x1CDBFE1 VA: 0x1CDBEE0
	private void UpdateTargetOne(Unit actor) { }

	// RVA: 0x1CCDA00 Offset: 0x1CCDB01 VA: 0x1CCDA00
	private void Caution(bool isMoreCaution = False, bool isRemove = False, bool isChainGuard = False, bool isIgnoreEngageAttack = False) { }

	// RVA: 0x1CDC3F0 Offset: 0x1CDC4F1 VA: 0x1CDC3F0
	private void GetCautionInfo(Unit unit, int itemIndex, UnitItem unitItem, SkillData skill, AIBattleSimulator simulator, bool isRemove, ref int maxRange, ref int maxLongRange, ref int maxExpectation, ref int maxExpectationLongRange) { }

	// RVA: 0x1CD2DF0 Offset: 0x1CD2EF1 VA: 0x1CD2DF0
	private static void GetProhibitedTurnMinMax(AIValue v0, AIValue v1, out int min, out int max) { }

	// RVA: 0x1CD2F30 Offset: 0x1CD3031 VA: 0x1CD2F30
	private static bool IsProhibitedTurn(int prohibitMin, int prohibitMax, int currentProhibit) { }

	// RVA: 0x1CD2FC0 Offset: 0x1CD30C1 VA: 0x1CD2FC0
	private void DecideToProhibitedTurn(int min, int max, out int result) { }

	[ConditionalAttribute] // RVA: 0x2AEFC0 Offset: 0x2AF0C1 VA: 0x2AEFC0
	// RVA: 0x1CDC690 Offset: 0x1CDC791 VA: 0x1CDC690
	public void DbgPatchVersionCheck() { }

	[ConditionalAttribute] // RVA: 0x2AF000 Offset: 0x2AF101 VA: 0x2AF000
	// RVA: 0x1CDC6A0 Offset: 0x1CDC7A1 VA: 0x1CDC6A0
	private static void DbgPatchVersionCheckLog(string s) { }

	// RVA: 0x1CDC6B0 Offset: 0x1CDC7B1 VA: 0x1CDC6B0
	private AIThink.Result ActionEngageBless(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CDC6C0 Offset: 0x1CDC7C1 VA: 0x1CDC6C0
	private AIThink.Result EngageBlessTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CDC9C0 Offset: 0x1CDCAC1 VA: 0x1CDC9C0
	private AIThink.Result EngageBlessToCommon(int limitX = -1, int limitZ = -1, int limitDistance = -1, PersonData person) { }

	// RVA: 0x1CDCFD0 Offset: 0x1CDD0D1 VA: 0x1CDCFD0
	private uint EngageBlessGetScore(int moveX, int moveZ, ItemData engageItem, Unit target, out bool isHeal) { }

	// RVA: 0x1CDD130 Offset: 0x1CDD231 VA: 0x1CDD130
	private AIThink.Result ActionEngageWait(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CDD140 Offset: 0x1CDD241 VA: 0x1CDD140
	private AIThink.Result EngageWaitTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CDD5B0 Offset: 0x1CDD6B1 VA: 0x1CDD5B0
	private AIThink.Result EngageWaitToCommon(out int moveX, out int moveZ, out int itemIndex, int limitX = -1, int limitZ = -1, int limitDistance = -1) { }

	// RVA: 0x1CDE270 Offset: 0x1CDE371 VA: 0x1CDE270
	private void EngageWaitCalcAdditionalAttackImage() { }

	// RVA: 0x1CDE490 Offset: 0x1CDE591 VA: 0x1CDE490
	private uint EngageWaitGetScore(int x, int z, int hp, bool isRange1) { }

	// RVA: 0x1CDE470 Offset: 0x1CDE571 VA: 0x1CDE470
	private static bool EngageWaitCheckRange(int range, int minRange, int maxRange) { }

	// RVA: 0x1CDE5C0 Offset: 0x1CDE6C1 VA: 0x1CDE5C0
	private AIThink.Result ActionEngageSummon(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CDE5D0 Offset: 0x1CDE6D1 VA: 0x1CDE5D0
	private AIThink.Result EngageSummonTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CDE940 Offset: 0x1CDEA41 VA: 0x1CDE940
	private AIThink.Result EngageSummonToCommon(out int moveX, out int moveZ, out PersonData.Colors color, int limitX = -1, int limitZ = -1, int limitDistance = -1) { }

	// RVA: 0x1CDED40 Offset: 0x1CDEE41 VA: 0x1CDED40
	private PersonData.Colors EngageSummonDecideColor() { }

	// RVA: 0x1CDEEC0 Offset: 0x1CDEFC1 VA: 0x1CDEEC0
	private bool EngageSummonWeapon2Color(Unit unit, int itemIndex, out PersonData.Colors color) { }

	// RVA: 0x1CDF480 Offset: 0x1CDF581 VA: 0x1CDF480
	private AIThink.Result ActionEngageOverlap(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CDF490 Offset: 0x1CDF591 VA: 0x1CDF490
	private AIThink.Result EngageOverlapTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CDF900 Offset: 0x1CDFA01 VA: 0x1CDF900
	private AIThink.Result EngageOverlapToCommon(out int moveX, out int moveZ, int limitX = -1, int limitZ = -1, int limitDistance = -1) { }

	// RVA: 0x1CDFD20 Offset: 0x1CDFE21 VA: 0x1CDFD20
	private AIThink.Result ActionAttackBreath(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CDFD40 Offset: 0x1CDFE41 VA: 0x1CDFD40
	private AIThink.Result ActionAttackBreathMiddleLow(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CDFD30 Offset: 0x1CDFE31 VA: 0x1CDFD30
	private AIThink.Result AttackBreathTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CDFD50 Offset: 0x1CDFE51 VA: 0x1CDFD50
	private AIThink.Result ActionRodMagicShield(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CDFE40 Offset: 0x1CDFF41 VA: 0x1CDFE40
	private int MagicShieldFindIndex() { }

	// RVA: 0x1CDFE50 Offset: 0x1CDFF51 VA: 0x1CDFE50
	private void MagicShieldCalcUnitScore() { }

	// RVA: 0x1CDFFE0 Offset: 0x1CE00E1 VA: 0x1CDFFE0
	private void MagicShieldCalcUnitScore(Unit target) { }

	// RVA: 0x1CE0E80 Offset: 0x1CE0F81 VA: 0x1CE0E80
	private AIThink.Result ActionCommandSkillDecoy(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CE0E90 Offset: 0x1CE0F91 VA: 0x1CE0E90
	private AIThink.Result CommandSkillDecoyTo(SkillData commandSkill, bool isEntrust = False) { }

	// RVA: 0x1CE1590 Offset: 0x1CE1691 VA: 0x1CE1590
	private uint DecoyGetScore(Unit unit, bool isEntrust) { }

	// RVA: 0x1CE2330 Offset: 0x1CE2431 VA: 0x1CE2330
	private AIThink.Result ActionCommandSkillStrategy(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CE2520 Offset: 0x1CE2621 VA: 0x1CE2520
	private AIThink.Result CommandSkillStrategyHolyShield(SkillData commandSkill, bool isEntrust) { }

	// RVA: 0x1CE31D0 Offset: 0x1CE32D1 VA: 0x1CE31D0
	private AIThink.Result ActionCommandSkillTrimasteries(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CE33B0 Offset: 0x1CE34B1 VA: 0x1CE33B0
	private AIThink.Result CommandSkillTrimasteries(bool isEntrust) { }

	// RVA: 0x1CE3D90 Offset: 0x1CE3E91 VA: 0x1CE3D90
	private bool TrimasteriesCanKill(float killRate, float deadRate) { }

	// RVA: 0x1CE3610 Offset: 0x1CE3711 VA: 0x1CE3610
	private int TrimasteriesCountKillEnemies() { }

	// RVA: 0x1CE3970 Offset: 0x1CE3A71 VA: 0x1CE3970
	private AIThink.Result TrimasteriesThink(SkillData commandSkill) { }

	// RVA: 0x1CE37F0 Offset: 0x1CE38F1 VA: 0x1CE37F0
	private int EntrustTrimasteriesCountKillEnemies() { }

	// RVA: 0x1CE3BD0 Offset: 0x1CE3CD1 VA: 0x1CE3BD0
	private AIThink.Result EntrustTrimasteriesThink(SkillData commandSkill) { }

	// RVA: 0x1CE3DC0 Offset: 0x1CE3EC1 VA: 0x1CE3DC0
	private void EntrustTrimasteriesDeploy(SkillData commandSkill) { }

	// RVA: 0x1CE41A0 Offset: 0x1CE42A1 VA: 0x1CE41A0
	private AIThink.Result ActionCommandSkillContract(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CE4310 Offset: 0x1CE4411 VA: 0x1CE4310
	private AIThink.Result CommandSkillContractTo(SkillData commandSkill, bool isEntrust) { }

	// RVA: 0x1CE4640 Offset: 0x1CE4741 VA: 0x1CE4640
	private uint ContractGetBattleScore(Unit unit) { }

	// RVA: 0x1CE4A00 Offset: 0x1CE4B01 VA: 0x1CE4A00
	private uint ContractGetEntrustBattleScore(Unit unit) { }

	// RVA: 0x1CE4DB0 Offset: 0x1CE4EB1 VA: 0x1CE4DB0
	private AIThink.Result ActionCommandSkillYell(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CE4DC0 Offset: 0x1CE4EC1 VA: 0x1CE4DC0
	private AIThink.Result ActionCommandSkillGaze(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CD05E0 Offset: 0x1CD06E1 VA: 0x1CD05E0
	public static int GetBulletPattern(Unit unit) { }

	// RVA: 0x1CAE980 Offset: 0x1CAEA81 VA: 0x1CAE980
	public static int GetNextBulletPattern(int pattern) { }

	// RVA: 0x1CAE290 Offset: 0x1CAE391 VA: 0x1CAE290
	public static bool IsBulletPatternMatched(int pattern, ItemData item) { }

	// RVA: 0x1CE4F70 Offset: 0x1CE5071 VA: 0x1CE4F70
	private static bool IsBulletPatternA(ItemData item) { }

	// RVA: 0x1CE5070 Offset: 0x1CE5171 VA: 0x1CE5070
	private static bool IsBulletPatternB(ItemData item) { }

	// RVA: 0x1CE5100 Offset: 0x1CE5201 VA: 0x1CE5100
	private AIThink.Result ActionCommandSkillFullBullet(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CE6060 Offset: 0x1CE6161 VA: 0x1CE6060
	private AIThink.Result CommandSkillFullBulletTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CE6AD0 Offset: 0x1CE6BD1 VA: 0x1CE6AD0
	private bool FullBulletCanUse(Unit unit, UnitItem unitItem, bool isExcludeFreeze) { }

	// RVA: 0x1CE55A0 Offset: 0x1CE56A1 VA: 0x1CE55A0
	private int FullBulletGetRangeBit(int priorItemIndex, bool isExcludeFreeze, out uint itemBit, out uint rangeBit) { }

	// RVA: 0x1CE70D0 Offset: 0x1CE71D1 VA: 0x1CE70D0
	private int FullBulletGetItemRangeBit(int itemIndex, bool isExcludeFreeze, out uint itemRangeBit) { }

	// RVA: 0x1CE59C0 Offset: 0x1CE5AC1 VA: 0x1CE59C0
	private void FullBulletDeploy(uint itemBit) { }

	// RVA: 0x1CE5EC0 Offset: 0x1CE5FC1 VA: 0x1CE5EC0
	private uint FullBulletGetMovePos(int targetX, int targetZ, uint itemBit, uint rangeBit, int maxRange, bool isExcludeFreeze, out int moveX, out int moveZ, out int itemIndex) { }

	// RVA: 0x1CE7280 Offset: 0x1CE7381 VA: 0x1CE7280
	private uint FullBulletGetMovePosVersus(int targetX, int targetZ, int itemIndex, uint rangeBit, int maxRange, bool isExcludeFreeze, out int moveX, out int moveZ) { }

	// RVA: 0x1CE7430 Offset: 0x1CE7531 VA: 0x1CE7430
	private bool FullBulletCanBeTarget(Unit unit) { }

	// RVA: 0x1CE76D0 Offset: 0x1CE77D1 VA: 0x1CE76D0
	private AIThink.Result ActionCommandSkillEnchant(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CE7810 Offset: 0x1CE7911 VA: 0x1CE7810
	private AIThink.Result ActionCommandSkillEnchantHeal(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CE7770 Offset: 0x1CE7871 VA: 0x1CE7770
	private AIThink.Result CommandSkillEnchantTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CE7870 Offset: 0x1CE7971 VA: 0x1CE7870
	private AIThink.Result CommandSkillEnchantHealTo(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CE7BB0 Offset: 0x1CE7CB1 VA: 0x1CE7BB0
	private AIThink.Result EntrustEnchant() { }

	// RVA: 0x1CE7D50 Offset: 0x1CE7E51 VA: 0x1CE7D50
	private AIThink.Result EntrustEnchantHeal() { }

	// RVA: 0x1CE78D0 Offset: 0x1CE79D1 VA: 0x1CE78D0
	private AIThink.Result CommandSkillEnchantToCommon(bool isEntrust) { }

	// RVA: 0x1CE7970 Offset: 0x1CE7A71 VA: 0x1CE7970
	private AIThink.Result CommandSkillEnchantHealToCommon(bool isEntrust) { }

	// RVA: 0x1CE80C0 Offset: 0x1CE81C1 VA: 0x1CE80C0
	private static void EnchantDeploy(Unit actor, bool isEntrust, bool withAttack = False) { }

	// RVA: 0x1CE7E80 Offset: 0x1CE7F81 VA: 0x1CE7E80
	private uint EnchantHealGetItemBit() { }

	// RVA: 0x1CE8460 Offset: 0x1CE8561 VA: 0x1CE8460
	private uint EnchantHealGetScore(int moveX, int moveZ, int move, uint itemBit, out int itemIndex) { }

	// RVA: 0x1CE8290 Offset: 0x1CE8391 VA: 0x1CE8290
	private void EnchantHealUpdateHealCondition(int moveX, int moveZ, int itemIndex) { }

	// RVA: 0x1CA0CE0 Offset: 0x1CA0DE1 VA: 0x1CA0CE0
	public void ProcessingEntrust() { }

	// RVA: 0x1CA1D90 Offset: 0x1CA1E91 VA: 0x1CA1D90
	public void ProcessingEntrustRemove() { }

	// RVA: 0x1CA1F30 Offset: 0x1CA2031 VA: 0x1CA1F30
	public void ProcessingEntrustRemagic() { }

	// RVA: 0x1CEA500 Offset: 0x1CEA601 VA: 0x1CEA500
	private Unit GetEntrustHero() { }

	// RVA: 0x1CEA570 Offset: 0x1CEA671 VA: 0x1CEA570
	private static Unit GetEntrustHero(Unit unit) { }

	// RVA: 0x1CEA580 Offset: 0x1CEA681 VA: 0x1CEA580
	private static Unit GetEntrustHeroExcluding(Unit excludedUnit) { }

	// RVA: 0x1CEA600 Offset: 0x1CEA701 VA: 0x1CEA600
	public static MapDeployTemplate.Flag<AIDeploy> EntrustGetDeployFreeMoveFlag(Unit unit) { }

	// RVA: 0x1CE88C0 Offset: 0x1CE89C1 VA: 0x1CE88C0
	private AIThink.Result EntrustHeal() { }

	// RVA: 0x1CEA610 Offset: 0x1CEA711 VA: 0x1CEA610
	private AIThink.Result EntrustHealMindTo() { }

	// RVA: 0x1CEAC10 Offset: 0x1CEAD11 VA: 0x1CEAC10
	private AIThink.Result EntrustHealMindToTerrain() { }

	// RVA: 0x1CEA7B0 Offset: 0x1CEA8B1 VA: 0x1CEA7B0
	private AIThink.Result EntrustHealRod() { }

	// RVA: 0x1CE8940 Offset: 0x1CE8A41 VA: 0x1CE8940
	private AIThink.Result EntrustEngage() { }

	// RVA: 0x1CE89A0 Offset: 0x1CE8AA1 VA: 0x1CE89A0
	private AIThink.Result EntrustEngageAttack() { }

	// RVA: 0x1CE87D0 Offset: 0x1CE88D1 VA: 0x1CE87D0
	private AIThink.Result EntrustEngageHeal() { }

	// RVA: 0x1CEB1E0 Offset: 0x1CEB2E1 VA: 0x1CEB1E0
	private bool EntrustEngageAttackCheck() { }

	// RVA: 0x1CEB2F0 Offset: 0x1CEB3F1 VA: 0x1CEB2F0
	private AIThink.Result EntrustEngageAttackTo() { }

	// RVA: 0x1CEB760 Offset: 0x1CEB861 VA: 0x1CEB760
	private AIThink.Result EntrustEngagePierceTo() { }

	// RVA: 0x1CEBB00 Offset: 0x1CEBC01 VA: 0x1CEBB00
	private AIThink.Result EntrustEngageChargeTo() { }

	// RVA: 0x1CEBC70 Offset: 0x1CEBD71 VA: 0x1CEBC70
	private AIThink.Result EntrustEngageDanceTo() { }

	// RVA: 0x1CEC3D0 Offset: 0x1CEC4D1 VA: 0x1CEC3D0
	private AIThink.Result EntrustEngageHealTo() { }

	// RVA: 0x1CEBDC0 Offset: 0x1CEBEC1 VA: 0x1CEBDC0
	private AIThink.Result EntrustEngageBlessTo() { }

	// RVA: 0x1CEBE60 Offset: 0x1CEBF61 VA: 0x1CEBE60
	private AIThink.Result EntrustEngageWaitTo() { }

	// RVA: 0x1CEC270 Offset: 0x1CEC371 VA: 0x1CEC270
	private AIThink.Result EntrustEngageSummonTo() { }

	// RVA: 0x1CEC060 Offset: 0x1CEC161 VA: 0x1CEC060
	private AIThink.Result EntrustEngageOverlapTo() { }

	// RVA: 0x1CE8BD0 Offset: 0x1CE8CD1 VA: 0x1CE8BD0
	private AIThink.Result EntrustGodSkill(int kind) { }

	// RVA: 0x1CECBC0 Offset: 0x1CECCC1 VA: 0x1CECBC0
	private AIThink.Result EntrustCommandSkillOverlapTo(SkillData commandSkill) { }

	// RVA: 0x1CECC10 Offset: 0x1CECD11 VA: 0x1CECC10
	private AIThink.Result EntrustEngageSupportTo(SkillData commandSkill) { }

	// RVA: 0x1CED180 Offset: 0x1CED281 VA: 0x1CED180
	private AIThink.Result EntrustEngagePullBackTo(SkillData commandSkill) { }

	// RVA: 0x1CE8DF0 Offset: 0x1CE8EF1 VA: 0x1CE8DF0
	private AIThink.Result EntrustAttack() { }

	// RVA: 0x1CEC560 Offset: 0x1CEC661 VA: 0x1CEC560
	private AIThink.Result EntrustAttackTo(SkillData commandSkill) { }

	// RVA: 0x1CE3FC0 Offset: 0x1CE40C1 VA: 0x1CE3FC0
	private void EntrustSetAttackTargetToMind(ref AIThink.EntrustAttackTarget target, int itemIndex, SkillData commandSkill) { }

	// RVA: 0x1CA8390 Offset: 0x1CA8491 VA: 0x1CA8390
	public static void EntrustGetEscortAreaIfNeeded(Unit actor, out int x, out int z, out int distance) { }

	// RVA: 0x1CE8E50 Offset: 0x1CE8F51 VA: 0x1CE8E50
	private AIThink.Result EntrustMindFireCannon() { }

	// RVA: 0x1CE9490 Offset: 0x1CE9591 VA: 0x1CE9490
	private AIThink.Result EntrustMindDestination() { }

	// RVA: 0x1CE99B0 Offset: 0x1CE9AB1 VA: 0x1CE99B0
	private AIThink.Result EntrustMindTreasure() { }

	// RVA: 0x1CE8F60 Offset: 0x1CE9061 VA: 0x1CE8F60
	private AIThink.Result EntrustMindDoorAndDestroy() { }

	// RVA: 0x1CE8F10 Offset: 0x1CE9011 VA: 0x1CE8F10
	private AIThink.Result EntrustMindGuard() { }

	// RVA: 0x1CECC60 Offset: 0x1CECD61 VA: 0x1CECC60
	private AIThink.Result EntrustGuardTo(SkillData skill) { }

	// RVA: 0x1CE9400 Offset: 0x1CE9501 VA: 0x1CE9400
	private AIThink.Result EntrustMove() { }

	// RVA: 0x1CEA400 Offset: 0x1CEA501 VA: 0x1CEA400
	private AIThink.Result EntrustRemove() { }

	// RVA: 0x1CED190 Offset: 0x1CED291 VA: 0x1CED190
	private AIThink.Result EntrustMoveRush() { }

	// RVA: 0x1CED2E0 Offset: 0x1CED3E1 VA: 0x1CED2E0
	private AIThink.Result EntrustMoveEscort() { }

	// RVA: 0x1CED470 Offset: 0x1CED571 VA: 0x1CED470
	private AIThink.Result EntrustMoveTracking() { }

	// RVA: 0x1CED5C0 Offset: 0x1CED6C1 VA: 0x1CED5C0
	private AIThink.Result EntrustMoveRetreat() { }

	// RVA: 0x1CEE160 Offset: 0x1CEE261 VA: 0x1CEE160
	private AIThink.Result EntrustMoveEnemy(bool isIn) { }

	// RVA: 0x1CE96F0 Offset: 0x1CE97F1 VA: 0x1CE96F0
	private AIThink.Result EntrustMoveDestination(bool isIn) { }

	// RVA: 0x1CE9BB0 Offset: 0x1CE9CB1 VA: 0x1CE9BB0
	private AIThink.Result EntrustMoveTreasure(bool isIn) { }

	// RVA: 0x1CE9DB0 Offset: 0x1CE9EB1 VA: 0x1CE9DB0
	private AIThink.Result EntrustMoveDoorAndDestroy(bool isIn) { }

	// RVA: 0x1CEDBE0 Offset: 0x1CEDCE1 VA: 0x1CEDBE0
	private AIThink.Result EntrustMoveEngageCount(bool isIn) { }

	// RVA: 0x1CEA0A0 Offset: 0x1CEA1A1 VA: 0x1CEA0A0
	private AIThink.Result EntrustMoveHero(bool isCaution) { }

	// RVA: 0x1CEA150 Offset: 0x1CEA251 VA: 0x1CEA150
	private AIThink.Result EntrustMoveSelfForce(bool isCaution) { }

	// RVA: 0x1CEAD00 Offset: 0x1CEAE01 VA: 0x1CEAD00
	private AIThink.Result EntrustMoveTo(int xx, int zz, bool isCaution = False) { }

	// RVA: 0x1CEEBC0 Offset: 0x1CEECC1 VA: 0x1CEEBC0
	private int EntrustGetRangeDistance(int x, int z, int rangeI) { }

	// RVA: 0x1CEE4C0 Offset: 0x1CEE5C1 VA: 0x1CEE4C0
	private int EntrustGetRangeDistance(int x, int z, out int dstX, out int dstZ, int rangeI) { }

	// RVA: 0x1CEA340 Offset: 0x1CEA441 VA: 0x1CEA340
	private AIThink.Result EntrustFixed() { }

	// RVA: 0x1CA1A30 Offset: 0x1CA1B31 VA: 0x1CA1A30
	public void ProcessingUncontroll() { }

	// RVA: 0x1CEEC00 Offset: 0x1CEED01 VA: 0x1CEEC00
	private AIThink.Result UncontrollHeal() { }

	// RVA: 0x1CEEC40 Offset: 0x1CEED41 VA: 0x1CEEC40
	private AIThink.Result UncontrollAttack() { }

	// RVA: 0x1CEECB0 Offset: 0x1CEEDB1 VA: 0x1CEECB0
	private AIThink.Result UncontrollMove() { }

	// RVA: 0x1CEED20 Offset: 0x1CEEE21 VA: 0x1CEED20
	private AIThink.Result UncontrollFixed() { }

	// RVA: 0x1CEEDE0 Offset: 0x1CEEEE1 VA: 0x1CEEDE0
	private AIThink.Result CharmHeal() { }

	// RVA: 0x1CEF110 Offset: 0x1CEF211 VA: 0x1CEF110
	private AIThink.Result ConfusionAttack() { }

	// RVA: 0x1CEF480 Offset: 0x1CEF581 VA: 0x1CEF480
	private AIThink.Result CharmAttack() { }

	// RVA: 0x1CEF850 Offset: 0x1CEF951 VA: 0x1CEF850
	private AIThink.Result ConfusionMove() { }

	// RVA: 0x1CEFA50 Offset: 0x1CEFB51 VA: 0x1CEFA50
	private AIThink.Result CharmMove() { }

	// RVA: 0x1CEFCA0 Offset: 0x1CEFDA1 VA: 0x1CEFCA0
	private bool GetUncontrollAttackScore(Unit target, int targetX, int targetZ, int itemIndex, ref AIThink.UncontrollAttackScoreResult result) { }

	// RVA: 0x1CEFF80 Offset: 0x1CF0081 VA: 0x1CEFF80
	private bool GetUncontrollMoveScore(int targetX, int targetZ, out uint score) { }

	// RVA: 0x1CF0180 Offset: 0x1CF0281 VA: 0x1CF0180
	private AIThink.Result ActionVsPlan(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CF02F0 Offset: 0x1CF03F1 VA: 0x1CF02F0
	private AIThink.Result ActionVsEngage(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CF0300 Offset: 0x1CF0401 VA: 0x1CF0300
	private AIThink.Result ActionVsEngageAttack(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CF0560 Offset: 0x1CF0661 VA: 0x1CF0560
	private AIThink.Result ActionVsAttackMiddleLow(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CF05D0 Offset: 0x1CF06D1 VA: 0x1CF05D0
	private AIThink.Result ActionVsGodSkill(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CF0790 Offset: 0x1CF0891 VA: 0x1CF0790
	private AIThink.Result ActionVsMindDance(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CF07C0 Offset: 0x1CF08C1 VA: 0x1CF07C0
	private AIThink.Result ActionVsMindGuard(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CF07F0 Offset: 0x1CF08F1 VA: 0x1CF07F0
	private AIThink.Result ActionVsMindFireCannon(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CF08B0 Offset: 0x1CF09B1 VA: 0x1CF08B0
	private AIThink.Result ActionVsMindTerrainDestroy(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CF08F0 Offset: 0x1CF09F1 VA: 0x1CF08F0
	private AIThink.Result ActionVsCommandSkillEnchant(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CF0A90 Offset: 0x1CF0B91 VA: 0x1CF0A90
	private AIThink.Result ActionVsCommandSkillEnchantHeal(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CF0BF0 Offset: 0x1CF0CF1 VA: 0x1CF0BF0
	private AIThink.Result ActionVsCommandSkillFullBullet(int command, AIValue v0, AIValue v1) { }

	// RVA: 0x1CD68A0 Offset: 0x1CD69A1 VA: 0x1CD68A0
	private bool CanVsEngageAttack() { }

	// RVA: 0x1CD96D0 Offset: 0x1CD97D1 VA: 0x1CD96D0
	private static bool CanVsEngageAttack(Unit unit) { }

	// RVA: 0x1CF05A0 Offset: 0x1CF06A1 VA: 0x1CF05A0
	private bool IsVsThinkTiming() { }

	// RVA: 0x1CF0C20 Offset: 0x1CF0D21 VA: 0x1CF0C20
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF040 Offset: 0x2AF141 VA: 0x2AF040
	// RVA: 0x1CF0D20 Offset: 0x1CF0E21 VA: 0x1CF0D20
	private void <UpdateTarget>b__62_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AF050 Offset: 0x2AF151 VA: 0x2AF050
	// RVA: 0x1CF0D30 Offset: 0x1CF0E31 VA: 0x1CF0D30
	private void <MagicShieldCalcUnitScore>b__319_0(Unit unit) { }
}

