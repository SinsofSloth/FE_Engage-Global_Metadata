// Namespace: App
public static class MapHistory // TypeDefIndex: 12096
{
	// Fields
	public const byte InvalidIndex = 255;
	private const byte Version = 1;
	private static bool s_IsSerializeDisabled; // 0x0
	private const int UnitStreamBufferSize = 5120;

	// Methods

	// RVA: 0x21D43E0 Offset: 0x21D44E1 VA: 0x21D43E0
	public static void RewindCreate() { }

	// RVA: 0x21D4500 Offset: 0x21D4601 VA: 0x21D4500
	public static void ReplayCreate() { }

	// RVA: 0x21D45D0 Offset: 0x21D46D1 VA: 0x21D45D0
	public static bool RewindIsCreated() { }

	// RVA: 0x21D4680 Offset: 0x21D4781 VA: 0x21D4680
	public static bool ReplayIsCreated() { }

	// RVA: 0x21D4730 Offset: 0x21D4831 VA: 0x21D4730
	public static void Delete() { }

	// RVA: 0x21D4830 Offset: 0x21D4931 VA: 0x21D4830
	public static void Serialize(Stream stream) { }

	// RVA: 0x21D4B90 Offset: 0x21D4C91 VA: 0x21D4B90
	private static void Overwrite(Stream stream, int pos, int val) { }

	// RVA: 0x21D4C00 Offset: 0x21D4D01 VA: 0x21D4C00
	public static void Deserialize(Stream stream) { }

	// RVA: 0x21D4FC0 Offset: 0x21D50C1 VA: 0x21D4FC0
	public static void Begin(ProcInst super) { }

	// RVA: 0x21D5100 Offset: 0x21D5201 VA: 0x21D5100
	public static void End() { }

	// RVA: 0x21D5230 Offset: 0x21D5331 VA: 0x21D5230
	public static void PhaseBegin() { }

	// RVA: 0x21D5360 Offset: 0x21D5461 VA: 0x21D5360
	public static void PhaseNext() { }

	// RVA: 0x21D5490 Offset: 0x21D5591 VA: 0x21D5490
	public static void PickUp(Unit unit) { }

	// RVA: 0x21D5560 Offset: 0x21D5661 VA: 0x21D5560
	public static void CancelPickUp() { }

	// RVA: 0x21D5620 Offset: 0x21D5721 VA: 0x21D5620
	public static void CancelUnitCommand() { }

	// RVA: 0x21D56E0 Offset: 0x21D57E1 VA: 0x21D56E0
	public static void Mind() { }

	// RVA: 0x21D5810 Offset: 0x21D5911 VA: 0x21D5810
	public static void Talk(Unit fromUnit, Unit toUnit) { }

	// RVA: 0x21D58F0 Offset: 0x21D59F1 VA: 0x21D58F0
	public static void Pretrade(Unit fromUnit, Unit toUnit) { }

	// RVA: 0x21D59D0 Offset: 0x21D5AD1 VA: 0x21D59D0
	public static void PretradeUndone(Unit unit) { }

	// RVA: 0x21D5AA0 Offset: 0x21D5BA1 VA: 0x21D5AA0
	public static void Posttrade(Unit fromUnit, Unit toUnit) { }

	// RVA: 0x21D5B80 Offset: 0x21D5C81 VA: 0x21D5B80
	public static void PosttradeUndone(Unit unit) { }

	// RVA: 0x21D5C50 Offset: 0x21D5D51 VA: 0x21D5C50
	public static void Transporter(Unit unit) { }

	// RVA: 0x21D5D20 Offset: 0x21D5E21 VA: 0x21D5D20
	public static void BattleCalc(BattleInfo info) { }

	// RVA: 0x21D5DF0 Offset: 0x21D5EF1 VA: 0x21D5DF0
	public static void GainItem(Unit unit, UnitItem unitItem) { }

	// RVA: 0x21D5ED0 Offset: 0x21D5FD1 VA: 0x21D5ED0
	public static void PreequipItem(Unit unit) { }

	// RVA: 0x21D5FA0 Offset: 0x21D60A1 VA: 0x21D5FA0
	public static void PostequipItem(Unit unit) { }

	// RVA: 0x21D6070 Offset: 0x21D6171 VA: 0x21D6070
	public static void PretakeOffItem(Unit unit) { }

	// RVA: 0x21D6140 Offset: 0x21D6241 VA: 0x21D6140
	public static void PosttakeOffItem(Unit unit) { }

	// RVA: 0x21D6210 Offset: 0x21D6311 VA: 0x21D6210
	public static void PresortItem(Unit unit) { }

	// RVA: 0x21D62E0 Offset: 0x21D63E1 VA: 0x21D62E0
	public static void PostsortItem(Unit unit) { }

	// RVA: 0x21D63B0 Offset: 0x21D64B1 VA: 0x21D63B0
	public static void PreputOffItem(Unit unit, bool fromMenu = False) { }

	// RVA: 0x21D6490 Offset: 0x21D6591 VA: 0x21D6490
	public static void PostputOffItem(Unit unit, bool fromMenu = False) { }

	// RVA: 0x21D6570 Offset: 0x21D6671 VA: 0x21D6570
	public static void EventBattle() { }

	// RVA: 0x21D6630 Offset: 0x21D6731 VA: 0x21D6630
	public static void MindDone() { }

	// RVA: 0x21D66F0 Offset: 0x21D67F1 VA: 0x21D66F0
	public static void EngageCancel(Unit unit) { }

	// RVA: 0x21D6830 Offset: 0x21D6931 VA: 0x21D6830
	public static void GodChangeCancel(Unit unit) { }

	// RVA: 0x21D6970 Offset: 0x21D6A71 VA: 0x21D6970
	public static void AfterCommandStackCancel(Unit unit) { }

	// RVA: 0x21D6A40 Offset: 0x21D6B41 VA: 0x21D6A40
	public static void Status(Unit unit) { }

	// RVA: 0x21D6B10 Offset: 0x21D6C11 VA: 0x21D6B10
	public static void Status(Unit unit, long status) { }

	// RVA: 0x21D6BF0 Offset: 0x21D6CF1 VA: 0x21D6BF0
	public static void Hp(Unit unit) { }

	// RVA: 0x21D6CC0 Offset: 0x21D6DC1 VA: 0x21D6CC0
	public static void Hp(Unit unit, int hp) { }

	// RVA: 0x21D6DA0 Offset: 0x21D6EA1 VA: 0x21D6DA0
	public static void BaseCapability(Unit unit, int index) { }

	// RVA: 0x21D6E80 Offset: 0x21D6F81 VA: 0x21D6E80
	public static void EngageCount(Unit unit) { }

	// RVA: 0x21D6F50 Offset: 0x21D7051 VA: 0x21D6F50
	public static void EngageCount(Unit unit, int engageCount) { }

	// RVA: 0x21D7030 Offset: 0x21D7131 VA: 0x21D7030
	public static void ExtraSight(Unit unit) { }

	// RVA: 0x21D7100 Offset: 0x21D7201 VA: 0x21D7100
	public static void Exp(Unit unit) { }

	// RVA: 0x21D71D0 Offset: 0x21D72D1 VA: 0x21D71D0
	public static void LevelUp(Unit unit) { }

	// RVA: 0x21D72A0 Offset: 0x21D73A1 VA: 0x21D72A0
	public static void ClassChange(Unit unit) { }

	// RVA: 0x21D7370 Offset: 0x21D7471 VA: 0x21D7370
	public static void Position(Unit unit) { }

	// RVA: 0x21D7440 Offset: 0x21D7541 VA: 0x21D7440
	public static void Position(Unit unit, int newX, int newZ) { }

	// RVA: 0x21D7530 Offset: 0x21D7631 VA: 0x21D7530
	public static void AngleOnce(Unit unit) { }

	// RVA: 0x21D7600 Offset: 0x21D7701 VA: 0x21D7600
	public static void PrivateSkill(Unit unit) { }

	// RVA: 0x21D76D0 Offset: 0x21D77D1 VA: 0x21D76D0
	public static void EnhanceFactorItem(Unit unit) { }

	// RVA: 0x21D77A0 Offset: 0x21D78A1 VA: 0x21D77A0
	public static void AIActive(Unit unit) { }

	// RVA: 0x21D7870 Offset: 0x21D7971 VA: 0x21D7870
	public static void AIBand(Unit unit) { }

	// RVA: 0x21D7940 Offset: 0x21D7A41 VA: 0x21D7940
	public static void AIPriority(Unit unit) { }

	// RVA: 0x21D7A10 Offset: 0x21D7B11 VA: 0x21D7A10
	public static void AISequence(Unit unit, AIValue.Order order) { }

	// RVA: 0x21D7AF0 Offset: 0x21D7BF1 VA: 0x21D7AF0
	public static void AIValue(Unit unit, AIValue.Order order, int index) { }

	// RVA: 0x21D7BE0 Offset: 0x21D7CE1 VA: 0x21D7BE0
	public static void AIProhibitEngageAttack(Unit unit) { }

	// RVA: 0x21D7CB0 Offset: 0x21D7DB1 VA: 0x21D7CB0
	public static void AIProhibitRod(Unit unit) { }

	// RVA: 0x21D7D80 Offset: 0x21D7E81 VA: 0x21D7D80
	public static void AIProhibitOverlap(Unit unit) { }

	// RVA: 0x21D7E50 Offset: 0x21D7F51 VA: 0x21D7E50
	public static void AIEngageAttackOnceDone(Unit unit) { }

	// RVA: 0x21D7F20 Offset: 0x21D8021 VA: 0x21D7F20
	public static void AIRerewarp(Unit unit) { }

	// RVA: 0x21D7FF0 Offset: 0x21D80F1 VA: 0x21D7FF0
	public static void AIRerewarpCount(Unit unit) { }

	// RVA: 0x21D80C0 Offset: 0x21D81C1 VA: 0x21D80C0
	public static void Engage(Unit unit, Unit linkUnit, bool isEvent = False) { }

	// RVA: 0x21D8230 Offset: 0x21D8331 VA: 0x21D8230
	public static void EngageForDecideTargetSelect(Unit unit, bool isEngaging) { }

	// RVA: 0x21D8370 Offset: 0x21D8471 VA: 0x21D8370
	public static void EngageOffForCommandSkillAfter(Unit unit) { }

	// RVA: 0x21D8450 Offset: 0x21D8551 VA: 0x21D8450
	public static void Dead(Unit unit) { }

	// RVA: 0x21D8590 Offset: 0x21D8691 VA: 0x21D8590
	public static void Transfer(Unit unit, Force.Type nextForceType) { }

	// RVA: 0x21D8670 Offset: 0x21D8771 VA: 0x21D8670
	public static void Revive(Unit unit) { }

	// RVA: 0x21D8740 Offset: 0x21D8841 VA: 0x21D8740
	public static void UnitPhaseBeginAllBegin() { }

	// RVA: 0x21D8800 Offset: 0x21D8901 VA: 0x21D8800
	public static void UnitPhaseBeginOneBegin(Unit unit) { }

	// RVA: 0x21D88D0 Offset: 0x21D89D1 VA: 0x21D88D0
	public static void UnitPhaseBeginStatus(Unit unit) { }

	// RVA: 0x21D89A0 Offset: 0x21D8AA1 VA: 0x21D89A0
	public static void UnitPhaseBeginPrivateSkill(Unit unit) { }

	// RVA: 0x21D8A70 Offset: 0x21D8B71 VA: 0x21D8A70
	public static void UnitPhaseBeginExtraSight(Unit unit) { }

	// RVA: 0x21D8B40 Offset: 0x21D8C41 VA: 0x21D8B40
	public static void UnitPhaseBeginEngageTurn(Unit unit) { }

	// RVA: 0x21D8C10 Offset: 0x21D8D11 VA: 0x21D8C10
	public static void UnitPhaseBeginEngage(Unit unit) { }

	// RVA: 0x21D8CE0 Offset: 0x21D8DE1 VA: 0x21D8CE0
	public static void UnitPhaseBeginEngageCount(Unit unit) { }

	// RVA: 0x21D8DB0 Offset: 0x21D8EB1 VA: 0x21D8DB0
	public static void UnitPhaseBeginAIProhibitEngageAttack(Unit unit) { }

	// RVA: 0x21D8E80 Offset: 0x21D8F81 VA: 0x21D8E80
	public static void UnitPhaseBeginAIProhibitRod(Unit unit) { }

	// RVA: 0x21D8F50 Offset: 0x21D9051 VA: 0x21D8F50
	public static void UnitPhaseBeginAIProhibitOverlap(Unit unit) { }

	// RVA: 0x21D9020 Offset: 0x21D9121 VA: 0x21D9020
	public static void UnitPhaseBeginMultiChangeGod(Unit unit, GodData godData) { }

	// RVA: 0x21D9100 Offset: 0x21D9201 VA: 0x21D9100
	public static void UnitPhaseBeginPosition(Unit unit) { }

	// RVA: 0x21D91D0 Offset: 0x21D92D1 VA: 0x21D91D0
	public static void UnitPhaseBeginOneEnd(Unit unit) { }

	// RVA: 0x21D92A0 Offset: 0x21D93A1 VA: 0x21D92A0
	public static void UnitPhaseBeginAllEnd() { }

	// RVA: 0x21D9360 Offset: 0x21D9461 VA: 0x21D9360
	public static void UnitPhaseEndAllBegin() { }

	// RVA: 0x21D9420 Offset: 0x21D9521 VA: 0x21D9420
	public static void UnitPhaseEndOne(Unit unit) { }

	// RVA: 0x21D94F0 Offset: 0x21D95F1 VA: 0x21D94F0
	public static void UnitPhaseEndAllEnd() { }

	// RVA: 0x21D95B0 Offset: 0x21D96B1 VA: 0x21D95B0
	public static void UnitItem(Unit unit, int index) { }

	// RVA: 0x21D9690 Offset: 0x21D9791 VA: 0x21D9690
	public static void UnitItemList(Unit unit) { }

	// RVA: 0x21D9760 Offset: 0x21D9861 VA: 0x21D9760
	public static void Dispos(Unit unit) { }

	// RVA: 0x21D98A0 Offset: 0x21D99A1 VA: 0x21D98A0
	public static void GodCreate(GodData godData) { }

	// RVA: 0x21D9970 Offset: 0x21D9A71 VA: 0x21D9970
	public static void GodDelete(GodUnit godUnit) { }

	// RVA: 0x21D9A40 Offset: 0x21D9B41 VA: 0x21D9A40
	public static void GodConnect(Unit unit) { }

	// RVA: 0x21D9B10 Offset: 0x21D9C11 VA: 0x21D9B10
	public static void GodDisconnect(Unit unit) { }

	// RVA: 0x21D9BE0 Offset: 0x21D9CE1 VA: 0x21D9BE0
	public static void GodChange(Unit unit) { }

	// RVA: 0x21D9D20 Offset: 0x21D9E21 VA: 0x21D9D20
	public static void GodExp(GodUnit godUnit, Unit unit) { }

	// RVA: 0x21D9E00 Offset: 0x21D9F01 VA: 0x21D9E00
	public static void GodLevelUp(GodUnit godUnit, Unit unit) { }

	// RVA: 0x21D9EE0 Offset: 0x21D9FE1 VA: 0x21D9EE0
	public static void GodDarkness(GodUnit godUnit) { }

	// RVA: 0x21D9FB0 Offset: 0x21DA0B1 VA: 0x21D9FB0
	public static void GodNotifyLevelCapTalk(GodUnit godUnit, Unit unit) { }

	// RVA: 0x21DA090 Offset: 0x21DA191 VA: 0x21DA090
	public static void GodState(Unit unit, int index) { }

	// RVA: 0x21DA170 Offset: 0x21DA271 VA: 0x21DA170
	public static void RelianceScore(Unit unitA, Unit unitB) { }

	// RVA: 0x21DA250 Offset: 0x21DA351 VA: 0x21DA250
	public static void TransporterData(int index, Transporter.Data data) { }

	// RVA: 0x21DA330 Offset: 0x21DA431 VA: 0x21DA330
	public static void CannonShells(CannonInspector cannonInspector) { }

	// RVA: 0x21DA400 Offset: 0x21DA501 VA: 0x21DA400
	public static void TerrainOpen(int x, int z) { }

	// RVA: 0x21DA4E0 Offset: 0x21DA5E1 VA: 0x21DA4E0
	public static void TerrainBroken(int x, int z) { }

	// RVA: 0x21DA5C0 Offset: 0x21DA6C1 VA: 0x21DA5C0
	public static void TerrainAction(int x, int z, MapObject.Actions action) { }

	// RVA: 0x21DA6B0 Offset: 0x21DA7B1 VA: 0x21DA6B0
	public static void TerrainSetBegin() { }

	// RVA: 0x21DA770 Offset: 0x21DA871 VA: 0x21DA770
	public static void TerrainSet(int x, int z) { }

	// RVA: 0x21DA850 Offset: 0x21DA951 VA: 0x21DA850
	public static void TerrainSetEnd() { }

	// RVA: 0x21DA910 Offset: 0x21DAA11 VA: 0x21DA910
	public static void TerrainSetOne(int x, int z) { }

	// RVA: 0x21DAAA0 Offset: 0x21DABA1 VA: 0x21DAAA0
	public static void OverlapBegin() { }

	// RVA: 0x21DAB60 Offset: 0x21DAC61 VA: 0x21DAB60
	public static void Overlap(int x, int z, string tid) { }

	// RVA: 0x21DAC50 Offset: 0x21DAD51 VA: 0x21DAC50
	public static void OverlapEnd() { }

	// RVA: 0x21DAD10 Offset: 0x21DAE11 VA: 0x21DAD10
	public static void OverlapOne(int x, int z, string tid) { }

	// RVA: 0x21DAEB0 Offset: 0x21DAFB1 VA: 0x21DAEB0
	public static void Gold(int gold) { }

	// RVA: 0x21DAF80 Offset: 0x21DB081 VA: 0x21DAF80
	public static void Material(ItemData.Kinds kind) { }

	// RVA: 0x21DB050 Offset: 0x21DB151 VA: 0x21DB050
	public static void PieceOfBond() { }

	// RVA: 0x21DB110 Offset: 0x21DB211 VA: 0x21DB110
	public static void Variable(string key) { }

	// RVA: 0x21DB1E0 Offset: 0x21DB2E1 VA: 0x21DB1E0
	public static void WinRule() { }

	// RVA: 0x21DB2A0 Offset: 0x21DB3A1 VA: 0x21DB2A0
	public static void WinRuleEnemyNum() { }

	// RVA: 0x21DB360 Offset: 0x21DB461 VA: 0x21DB360
	public static void WinRuleLimitTurn() { }

	// RVA: 0x21DB420 Offset: 0x21DB521 VA: 0x21DB420
	public static void WinRuleMID() { }

	// RVA: 0x21DB4E0 Offset: 0x21DB5E1 VA: 0x21DB4E0
	public static void FieldBgmPhaseBgm(string playerPhaseBgm, string enemyPhaseBgm, string allyPhaseBgm) { }

	// RVA: 0x21DB5D0 Offset: 0x21DB6D1 VA: 0x21DB5D0
	public static void FieldBgmWarSituation(string warSituationStateName) { }

	// RVA: 0x21DB6A0 Offset: 0x21DB7A1 VA: 0x21DB6A0
	public static void EngageBreak(Unit unit) { }

	// RVA: 0x21DB770 Offset: 0x21DB871 VA: 0x21DB770
	public static void RangeBegin() { }

	// RVA: 0x21DB830 Offset: 0x21DB931 VA: 0x21DB830
	public static void Range(int x, int z) { }

	// RVA: 0x21DB910 Offset: 0x21DBA11 VA: 0x21DB910
	public static void RangeEnd() { }

	// RVA: 0x21DB9D0 Offset: 0x21DBAD1 VA: 0x21DB9D0
	public static void RangeClear() { }

	// RVA: 0x21DBA90 Offset: 0x21DBB91 VA: 0x21DBA90
	public static void GodEscaping(GodUnit godUnit) { }

	// RVA: 0x21DBB60 Offset: 0x21DBC61 VA: 0x21DBB60
	public static void RewindDangerShowing(Unit unit) { }

	// RVA: 0x21DBC30 Offset: 0x21DBD31 VA: 0x21DBC30
	public static void MapKillBonus(int x, int z, MapKillBonus.Kinds kind) { }

	// RVA: 0x21DBD20 Offset: 0x21DBE21 VA: 0x21DBD20
	public static void GodDirty(GodUnit godUnit) { }

	// RVA: 0x21BC2F0 Offset: 0x21BC3F1 VA: 0x21BC2F0
	public static void EffectCreate(string name, Vector3 position, Quaternion rotation) { }

	// RVA: 0x21BC430 Offset: 0x21BC531 VA: 0x21BC430
	public static void EffectDeleteBegin() { }

	// RVA: 0x21BC4F0 Offset: 0x21BC5F1 VA: 0x21BC4F0
	public static void EffectDelete(string name, Vector3 position, Quaternion rotation) { }

	// RVA: 0x21BC630 Offset: 0x21BC731 VA: 0x21BC630
	public static void EffectDeleteEnd() { }

	// RVA: 0x21DBDF0 Offset: 0x21DBEF1 VA: 0x21DBDF0
	public static void MaterialFloatBegin(string name, string material, string property) { }

	// RVA: 0x21DBEE0 Offset: 0x21DBFE1 VA: 0x21DBEE0
	public static void MaterialFloat(float val) { }

	// RVA: 0x21DBFB0 Offset: 0x21DC0B1 VA: 0x21DBFB0
	public static void MaterialFloatEnd() { }

	// RVA: 0x21DC070 Offset: 0x21DC171 VA: 0x21DC070
	public static void MaterialColorBegin(string name, string material, string property) { }

	// RVA: 0x21DC160 Offset: 0x21DC261 VA: 0x21DC160
	public static void MaterialColor(Color color) { }

	// RVA: 0x21DC250 Offset: 0x21DC351 VA: 0x21DC250
	public static void MaterialColorEnd() { }

	// RVA: 0x21DC310 Offset: 0x21DC411 VA: 0x21DC310
	public static void FieldBgmSpecialTurn(int turn) { }

	// RVA: 0x21DC3E0 Offset: 0x21DC4E1 VA: 0x21DC3E0
	public static void PostChangeBgmEvent(string eventName) { }

	// RVA: 0x21DC4B0 Offset: 0x21DC5B1 VA: 0x21DC4B0
	public static void TerrainEndurance(int x, int z, int hp, int maxHp) { }

	// RVA: 0x21DC5A0 Offset: 0x21DC6A1 VA: 0x21DC5A0
	public static void TerrainState(int x, int z, int state) { }

	// RVA: 0x21DC690 Offset: 0x21DC791 VA: 0x21DC690
	public static void LoseRuleMID() { }

	// RVA: 0x21DC750 Offset: 0x21DC851 VA: 0x21DC750
	public static void BattleStart(Unit unit, MapMind.Type mind) { }

	// RVA: 0x21DC830 Offset: 0x21DC931 VA: 0x21DC830
	public static void PhaseBeginAfter() { }

	// RVA: 0x21DC8F0 Offset: 0x21DC9F1 VA: 0x21DC8F0
	public static void ClearRing(Unit unit) { }

	// RVA: 0x21DC9C0 Offset: 0x21DCAC1 VA: 0x21DC9C0
	public static void VisionDelete(Unit unit) { }

	// RVA: 0x21DCA90 Offset: 0x21DCB91 VA: 0x21DCA90
	public static void MapKillBonusCount(int x, int z, MapKillBonus.Kinds kind) { }

	// RVA: 0x21DCB80 Offset: 0x21DCC81 VA: 0x21DCB80
	public static void UnitRecord(Unit unit, UnitRecord.Kinds kind) { }

	// RVA: 0x21DCC60 Offset: 0x21DCD61 VA: 0x21DCC60
	public static void SkillCharge() { }

	// RVA: 0x21DCD20 Offset: 0x21DCE21 VA: 0x21DCD20
	public static void Surrender() { }

	// RVA: 0x21DCDE0 Offset: 0x21DCEE1 VA: 0x21DCDE0
	public static void SetExtraHpStock(Unit unit) { }

	// RVA: 0x21DCEB0 Offset: 0x21DCFB1 VA: 0x21DCEB0
	public static void ClearExtraHpStock(Unit unit) { }

	// RVA: 0x21DCF80 Offset: 0x21DD081 VA: 0x21DCF80
	public static void EngageTurn(Unit unit) { }

	// RVA: 0x21DD050 Offset: 0x21DD151 VA: 0x21DD050
	public static void SummonDelete(Unit unit) { }

	// RVA: 0x21DD120 Offset: 0x21DD221 VA: 0x21DD120
	public static void MapSightUsable() { }

	// RVA: 0x21DD1E0 Offset: 0x21DD2E1 VA: 0x21DD1E0
	public static void PlainHpStock(Unit unit) { }

	// RVA: 0x21DD2B0 Offset: 0x21DD3B1 VA: 0x21DD2B0
	public static void ResetLockTarget(Unit unit) { }

	// RVA: 0x21DD380 Offset: 0x21DD481 VA: 0x21DD380
	public static void EnchantWeapon() { }

	// RVA: 0x21DD440 Offset: 0x21DD541 VA: 0x21DD440
	public static void AIBulletPattern(Unit unit) { }

	// RVA: 0x21DD510 Offset: 0x21DD611 VA: 0x21DD510
	public static void PositionListBegin() { }

	// RVA: 0x21DD5D0 Offset: 0x21DD6D1 VA: 0x21DD5D0
	public static void PositionList(Unit unit) { }

	// RVA: 0x21DD6A0 Offset: 0x21DD7A1 VA: 0x21DD6A0
	public static void PositionListEnd() { }

	// RVA: 0x21DD760 Offset: 0x21DD861 VA: 0x21DD760
	public static void AIMoveLimit(Unit unit) { }

	// RVA: 0x21DD830 Offset: 0x21DD931 VA: 0x21DD830
	public static void TerrainActionMove(int x, int z, int movedX, int movedZ, MapObject.Actions action, int state) { }

	// RVA: 0x21DD940 Offset: 0x21DDA41 VA: 0x21DD940
	public static void AIMagicShieldOnceDone(Unit unit) { }

	// RVA: 0x21DDA10 Offset: 0x21DDB11 VA: 0x21DDA10
	public static void RandomGame() { }

	// RVA: 0x21DDAD0 Offset: 0x21DDBD1 VA: 0x21DDAD0
	public static void FullBulletAttack() { }

	// RVA: 0x21DDB90 Offset: 0x21DDC91 VA: 0x21DDB90
	public static void LockTarget(Unit unit) { }

	// RVA: 0x21DDC60 Offset: 0x21DDD61 VA: 0x21DDC60
	public static void AIEnchantWeaponDone(Unit unit) { }

	// RVA: 0x21DDD30 Offset: 0x21DDE31 VA: 0x21DDD30
	public static bool RewindIsEnable() { }

	// RVA: 0x21DDE30 Offset: 0x21DDF31 VA: 0x21DDE30
	public static void RewindEnable() { }

	// RVA: 0x21DDEF0 Offset: 0x21DDFF1 VA: 0x21DDEF0
	public static void RewindDisable() { }

	[ConditionalAttribute] // RVA: 0x2C7380 Offset: 0x2C7481 VA: 0x2C7380
	// RVA: 0x21DDFB0 Offset: 0x21DE0B1 VA: 0x21DDFB0
	public static void RewindDbgSetUseCount(int count) { }

	// RVA: 0x21DDFC0 Offset: 0x21DE0C1 VA: 0x21DDFC0
	public static int RewindGetUseCount() { }

	// RVA: 0x21DE0C0 Offset: 0x21DE1C1 VA: 0x21DE0C0
	public static int RewindGetMaxUseCount() { }

	// RVA: 0x21DE1C0 Offset: 0x21DE2C1 VA: 0x21DE1C0
	public static void RewindReset() { }

	// RVA: 0x21DE280 Offset: 0x21DE381 VA: 0x21DE280
	public static int RewindGetLastSplitIndex() { }

	// RVA: 0x21DE390 Offset: 0x21DE491 VA: 0x21DE390
	public static int RewindGetNextSplitIndex(int index) { }

	// RVA: 0x21DE4B0 Offset: 0x21DE5B1 VA: 0x21DE4B0
	public static int RewindGetPrevSplitIndex(int index) { }

	// RVA: 0x21DE5D0 Offset: 0x21DE6D1 VA: 0x21DE5D0
	public static bool RewindCreateLog(int index, MapHistory.RewindLog result) { }

	// RVA: 0x21DE6E0 Offset: 0x21DE7E1 VA: 0x21DE6E0
	public static bool RewindCheckLogExists() { }

	// RVA: 0x21DE7E0 Offset: 0x21DE8E1 VA: 0x21DE7E0
	public static bool RewindGetCursorPos(int index, out int x, out int z) { }

	// RVA: 0x21DE910 Offset: 0x21DEA11 VA: 0x21DE910
	public static bool RewindIsPhaseBegin(int index) { }

	// RVA: 0x21DEA20 Offset: 0x21DEB21 VA: 0x21DEA20
	public static void RewindPreviewSetup() { }

	// RVA: 0x21DEAE0 Offset: 0x21DEBE1 VA: 0x21DEAE0
	public static bool RewindPreviewApply(int index) { }

	// RVA: 0x21DEBF0 Offset: 0x21DECF1 VA: 0x21DEBF0
	public static void RewindPreviewDecide() { }

	// RVA: 0x21DECB0 Offset: 0x21DEDB1 VA: 0x21DECB0
	public static void RewindPreviewCancel() { }

	// RVA: 0x21BB310 Offset: 0x21BB411 VA: 0x21BB310
	public static bool RewindIsPreviewing() { }

	// RVA: 0x21DED70 Offset: 0x21DEE71 VA: 0x21DED70
	public static Unit RewindPreviewGetUnit(int mapHistoryIndex) { }

	[ConditionalAttribute] // RVA: 0x2C73C0 Offset: 0x2C74C1 VA: 0x2C73C0
	// RVA: 0x21DEE80 Offset: 0x21DEF81 VA: 0x21DEE80
	public static void RewindDbgDump() { }

	[ConditionalAttribute] // RVA: 0x2C7400 Offset: 0x2C7501 VA: 0x2C7400
	// RVA: 0x21DEE90 Offset: 0x21DEF91 VA: 0x21DEE90
	public static void RewindDbgCreateSnapshot() { }

	// RVA: 0x21DEEA0 Offset: 0x21DEFA1 VA: 0x21DEEA0
	public static bool RewindDbgHasSnapshot(int index) { }

	[ConditionalAttribute] // RVA: 0x2C7440 Offset: 0x2C7541 VA: 0x2C7440
	// RVA: 0x21DEEB0 Offset: 0x21DEFB1 VA: 0x21DEEB0
	public static void RewindDbgDeleteSnapshot(int index) { }

	// RVA: 0x21DEEC0 Offset: 0x21DEFC1 VA: 0x21DEEC0
	public static bool ReplayIsEnable() { }

	// RVA: 0x21DEF70 Offset: 0x21DF071 VA: 0x21DEF70
	public static void ReplaySetReadMode() { }

	// RVA: 0x21DF030 Offset: 0x21DF131 VA: 0x21DF030
	public static bool ReplayIsReadMode() { }

	// RVA: 0x21DF130 Offset: 0x21DF231 VA: 0x21DF130
	public static bool ReplayRead() { }

	// RVA: 0x21DF230 Offset: 0x21DF331 VA: 0x21DF230
	public static bool ReplayHasReadData() { }

	// RVA: 0x21DF330 Offset: 0x21DF431 VA: 0x21DF330
	public static bool ReplayIsReadDataLastTurn() { }

	// RVA: 0x21DF430 Offset: 0x21DF531 VA: 0x21DF430
	public static void ReplaySkipReadDataToLastTurn() { }

	// RVA: 0x21DF520 Offset: 0x21DF621 VA: 0x21DF520
	public static void ReplayChangeReadModeToWriteMode() { }

	// RVA: 0x21DF610 Offset: 0x21DF711 VA: 0x21DF610
	public static void ReplayRegisterAllUnits() { }

	// RVA: 0x21DF6D0 Offset: 0x21DF7D1 VA: 0x21DF6D0
	public static void ReplayRegisterAppearanceUnit(Unit unit) { }

	// RVA: 0x21DF7A0 Offset: 0x21DF8A1 VA: 0x21DF7A0
	public static void ReplayRegisterLeavingUnit(Unit unit) { }

	// RVA: 0x21DF870 Offset: 0x21DF971 VA: 0x21DF870
	public static void ReplayLeaving(Unit unit) { }

	// RVA: 0x21DF940 Offset: 0x21DFA41 VA: 0x21DF940
	public static bool ReplayGetAeppearanceAndLeavingIndexes(out int[] appearanceIndexes, out int[] leavingIndexes) { }

	// RVA: 0x21DFA70 Offset: 0x21DFB71 VA: 0x21DFA70
	public static Unit ReplayCreateAppearanceUnit(int index) { }

	// RVA: 0x21DFB80 Offset: 0x21DFC81 VA: 0x21DFB80
	public static Unit ReplayGetLeavingUnit(int index) { }

	// RVA: 0x21DFC90 Offset: 0x21DFD91 VA: 0x21DFC90
	public static void ReplayRegisterRelayTakeOverTiming() { }

	// RVA: 0x21DFD50 Offset: 0x21DFE51 VA: 0x21DFD50
	public static bool ReplayIsRelayTakeOverTiming() { }

	// RVA: 0x21DFE50 Offset: 0x21DFF51 VA: 0x21DFE50
	public static void ReplayTurnSave(ProcInst super) { }

	// RVA: 0x21DFF60 Offset: 0x21E0061 VA: 0x21DFF60
	public static int ReplayDbgGetReadIndex() { }

	// RVA: 0x21DFF70 Offset: 0x21E0071 VA: 0x21DFF70
	public static int ReplayDbgGetCommandCount() { }

	[ConditionalAttribute] // RVA: 0x2C7480 Offset: 0x2C7581 VA: 0x2C7480
	// RVA: 0x21DFF80 Offset: 0x21E0081 VA: 0x21DFF80
	public static void ReplayDbgDump() { }

	// RVA: 0x21DFF90 Offset: 0x21E0091 VA: 0x21DFF90
	private static void .cctor() { }
}

