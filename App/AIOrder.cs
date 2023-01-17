// Namespace: App
public class AIOrder // TypeDefIndex: 9269
{
	// Fields
	private static readonly ReadOnlyCollection<AIOrder.Func> aFunc; // 0x0
	private static readonly ReadOnlyCollection<AIOrder.Func> aFuncEntrust; // 0x8
	private static readonly ReadOnlyCollection<AIOrder.Func> aFuncUncontroll; // 0x10
	private const int UnitMax = 96;
	private AIOrder.UnitPriority[] m_aUnitPriority; // 0x10
	private int m_Num; // 0x18
	private int m_Seq; // 0x1C
	private int m_Current; // 0x20
	private int m_EngageOrGodChange; // 0x24
	private int m_Remove; // 0x28
	private int m_Remagic; // 0x2C
	private int m_Rerewarp; // 0x30
	private int m_MoveOver; // 0x34
	private bool m_IsAllowIdle; // 0x38

	// Methods

	// RVA: 0x1C9EBB0 Offset: 0x1C9ECB1 VA: 0x1C9EBB0
	public void .ctor() { }

	// RVA: 0x1CAFE30 Offset: 0x1CAFF31 VA: 0x1CAFE30
	public void SetEngageOrGodChange(int unitIndex) { }

	// RVA: 0x1CA00B0 Offset: 0x1CA01B1 VA: 0x1CA00B0
	public bool IsEngageOrGodChange() { }

	// RVA: 0x1CAFE40 Offset: 0x1CAFF41 VA: 0x1CAFE40
	public void SetRemove(int unitIndex) { }

	// RVA: 0x1CA00F0 Offset: 0x1CA01F1 VA: 0x1CA00F0
	public bool IsRemove() { }

	// RVA: 0x1CAFE50 Offset: 0x1CAFF51 VA: 0x1CAFE50
	public void SetRemagic(int unitIndex) { }

	// RVA: 0x1CA0130 Offset: 0x1CA0231 VA: 0x1CA0130
	public bool IsRemagic() { }

	// RVA: 0x1CAFE60 Offset: 0x1CAFF61 VA: 0x1CAFE60
	public void SetRerewarp(int unitIndex) { }

	// RVA: 0x1CA0170 Offset: 0x1CA0271 VA: 0x1CA0170
	public bool IsRerewarp() { }

	// RVA: 0x1CAFE70 Offset: 0x1CAFF71 VA: 0x1CAFE70
	public void SetMoveOver(int unitIndex) { }

	// RVA: 0x1CA1BF0 Offset: 0x1CA1CF1 VA: 0x1CA1BF0
	public bool IsMoveOver() { }

	// RVA: 0x1CAFE80 Offset: 0x1CAFF81 VA: 0x1CAFE80
	public bool IsAllowIdle() { }

	// RVA: 0x1C9F610 Offset: 0x1C9F711 VA: 0x1C9F610
	public void Processing() { }

	// RVA: 0x1CA0A10 Offset: 0x1CA0B11 VA: 0x1CA0A10
	public Unit GetUnit() { }

	// RVA: 0x1CA0AA0 Offset: 0x1CA0BA1 VA: 0x1CA0AA0
	public void Next() { }

	// RVA: 0x1CAFE90 Offset: 0x1CAFF91 VA: 0x1CAFE90
	private static void StaticUpdateTarget(AIOrder order) { }

	// RVA: 0x1CAFF30 Offset: 0x1CB0031 VA: 0x1CAFF30
	private static void StaticAllowIdle(AIOrder order) { }

	// RVA: 0x1CAFF50 Offset: 0x1CB0051 VA: 0x1CAFF50
	private static void StaticPriority(AIOrder order) { }

	// RVA: 0x1CB0090 Offset: 0x1CB0191 VA: 0x1CB0090
	private static void StaticCause(AIOrder order) { }

	// RVA: 0x1CB01D0 Offset: 0x1CB02D1 VA: 0x1CB01D0
	private static void StaticMind(AIOrder order) { }

	// RVA: 0x1CB0310 Offset: 0x1CB0411 VA: 0x1CB0310
	private static void StaticAttackCrossfire(AIOrder order) { }

	// RVA: 0x1CB0330 Offset: 0x1CB0431 VA: 0x1CB0330
	private static void StaticAttackLongRange(AIOrder order) { }

	// RVA: 0x1CB0470 Offset: 0x1CB0571 VA: 0x1CB0470
	private static void StaticAttackHigh(AIOrder order) { }

	// RVA: 0x1CB0520 Offset: 0x1CB0621 VA: 0x1CB0520
	private static void StaticAttackMiddle(AIOrder order) { }

	// RVA: 0x1CB05D0 Offset: 0x1CB06D1 VA: 0x1CB05D0
	private static void StaticAttackLow(AIOrder order) { }

	// RVA: 0x1CB0680 Offset: 0x1CB0781 VA: 0x1CB0680
	private static void StaticMove(AIOrder order) { }

	// RVA: 0x1CB0730 Offset: 0x1CB0831 VA: 0x1CB0730
	private static void StaticTurnEnd(AIOrder order) { }

	// RVA: 0x1CB0830 Offset: 0x1CB0931 VA: 0x1CB0830
	private static void StaticEntrustUpdateIdle(AIOrder order) { }

	// RVA: 0x1CB0970 Offset: 0x1CB0A71 VA: 0x1CB0970
	private static void StaticEntrustHeal(AIOrder order) { }

	// RVA: 0x1CB0A20 Offset: 0x1CB0B21 VA: 0x1CB0A20
	private static void StaticEntrustUpdateCannon(AIOrder order) { }

	// RVA: 0x1CB0B20 Offset: 0x1CB0C21 VA: 0x1CB0B20
	private static void StaticEntrustAttack(AIOrder order) { }

	// RVA: 0x1CB0BD0 Offset: 0x1CB0CD1 VA: 0x1CB0BD0
	private static void StaticEntrustHeroRushMove(AIOrder order) { }

	// RVA: 0x1CB0D50 Offset: 0x1CB0E51 VA: 0x1CB0D50
	private static void StaticEntrustMove(AIOrder order) { }

	// RVA: 0x1CB0E00 Offset: 0x1CB0F01 VA: 0x1CB0E00
	private static void StaticEntrustFixed(AIOrder order) { }

	// RVA: 0x1CB0EB0 Offset: 0x1CB0FB1 VA: 0x1CB0EB0
	private static void StaticUncontrollUpdateIdle(AIOrder order) { }

	// RVA: 0x1CB0FF0 Offset: 0x1CB10F1 VA: 0x1CB0FF0
	private static void StaticUncontrollHeal(AIOrder order) { }

	// RVA: 0x1CB10A0 Offset: 0x1CB11A1 VA: 0x1CB10A0
	private static void StaticUncontrollAttack(AIOrder order) { }

	// RVA: 0x1CB11E0 Offset: 0x1CB12E1 VA: 0x1CB11E0
	private static void StaticUncontrollMove(AIOrder order) { }

	// RVA: 0x1CB1320 Offset: 0x1CB1421 VA: 0x1CB1320
	private static void StaticUncontrollFixed(AIOrder order) { }

	// RVA: 0x1CB1460 Offset: 0x1CB1561 VA: 0x1CB1460
	private int GetDistanceFromEnemy(Unit actor) { }

	// RVA: 0x1CB16A0 Offset: 0x1CB17A1 VA: 0x1CB16A0
	private bool HasLongRangeWeapon(Unit unit) { }

	// RVA: 0x1CB1CC0 Offset: 0x1CB1DC1 VA: 0x1CB1CC0
	private int GetEnchantPriority(Unit unit, bool isEntrust = False) { }

	// RVA: 0x1CAFF40 Offset: 0x1CB0041 VA: 0x1CAFF40
	private void AllowIdle() { }

	// RVA: 0x1CB1FA0 Offset: 0x1CB20A1 VA: 0x1CB1FA0
	private void SortDescend() { }

	// RVA: 0x1CB2100 Offset: 0x1CB2201 VA: 0x1CB2100
	private void SortAscend() { }

	// RVA: 0x1CB2260 Offset: 0x1CB2361 VA: 0x1CB2260
	private void EnumerateAll() { }

	// RVA: 0x1CB2320 Offset: 0x1CB2421 VA: 0x1CB2320
	private void EnumeratePriority() { }

	// RVA: 0x1CB23E0 Offset: 0x1CB24E1 VA: 0x1CB23E0
	private void EnumerateAttackLongRange() { }

	// RVA: 0x1CB24A0 Offset: 0x1CB25A1 VA: 0x1CB24A0
	private void EnumerateAttack() { }

	// RVA: 0x1CB2560 Offset: 0x1CB2661 VA: 0x1CB2560
	private void EnumerateMove() { }

	// RVA: 0x1CB2620 Offset: 0x1CB2721 VA: 0x1CB2620
	private void EnumerateEntrust() { }

	// RVA: 0x1CB26E0 Offset: 0x1CB27E1 VA: 0x1CB26E0
	private void EnumerateUncontroll() { }

	// RVA: 0x1CB27A0 Offset: 0x1CB28A1 VA: 0x1CB27A0
	private void UpdateAskHeal() { }

	// RVA: 0x1CAFEA0 Offset: 0x1CAFFA1 VA: 0x1CAFEA0
	private void UpdateTarget() { }

	// RVA: 0x1CAFFF0 Offset: 0x1CB00F1 VA: 0x1CAFFF0
	private void Priority() { }

	// RVA: 0x1CB0130 Offset: 0x1CB0231 VA: 0x1CB0130
	private void Cause() { }

	// RVA: 0x1CB0270 Offset: 0x1CB0371 VA: 0x1CB0270
	public void Mind() { }

	// RVA: 0x1CB0320 Offset: 0x1CB0421 VA: 0x1CB0320
	private void AttackCrossfire() { }

	// RVA: 0x1CB03D0 Offset: 0x1CB04D1 VA: 0x1CB03D0
	private void AttackLongRange() { }

	// RVA: 0x1CB0480 Offset: 0x1CB0581 VA: 0x1CB0480
	private void AttackHigh() { }

	// RVA: 0x1CB0530 Offset: 0x1CB0631 VA: 0x1CB0530
	private void AttackMiddle() { }

	// RVA: 0x1CB05E0 Offset: 0x1CB06E1 VA: 0x1CB05E0
	private void AttackLow() { }

	// RVA: 0x1CB0690 Offset: 0x1CB0791 VA: 0x1CB0690
	public void Move() { }

	// RVA: 0x1CB07B0 Offset: 0x1CB08B1 VA: 0x1CB07B0
	private void TurnEnd() { }

	// RVA: 0x1CB0840 Offset: 0x1CB0941 VA: 0x1CB0840
	private void EntrustUpdateIdle() { }

	// RVA: 0x1CB0980 Offset: 0x1CB0A81 VA: 0x1CB0980
	private void EntrustHeal() { }

	// RVA: 0x1CB0AA0 Offset: 0x1CB0BA1 VA: 0x1CB0AA0
	private void EntrustUpdateCannon() { }

	// RVA: 0x1CB0B30 Offset: 0x1CB0C31 VA: 0x1CB0B30
	private void EntrustAttack() { }

	// RVA: 0x1CB0D60 Offset: 0x1CB0E61 VA: 0x1CB0D60
	private void EntrustMove() { }

	// RVA: 0x1CB0BE0 Offset: 0x1CB0CE1 VA: 0x1CB0BE0
	private void EntrustHeroRushMove() { }

	// RVA: 0x1CB0E10 Offset: 0x1CB0F11 VA: 0x1CB0E10
	private void EntrustFixed() { }

	// RVA: 0x1CB0EC0 Offset: 0x1CB0FC1 VA: 0x1CB0EC0
	private void UncontrollUpdateIdle() { }

	// RVA: 0x1CB1000 Offset: 0x1CB1101 VA: 0x1CB1000
	private void UncontrollHeal() { }

	// RVA: 0x1CB1140 Offset: 0x1CB1241 VA: 0x1CB1140
	private void UncontrollAttack() { }

	// RVA: 0x1CB1280 Offset: 0x1CB1381 VA: 0x1CB1280
	private void UncontrollMove() { }

	// RVA: 0x1CB13C0 Offset: 0x1CB14C1 VA: 0x1CB13C0
	private void UncontrollFixed() { }

	// RVA: 0x1CB2A50 Offset: 0x1CB2B51 VA: 0x1CB2A50
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEEB0 Offset: 0x2AEFB1 VA: 0x2AEEB0
	// RVA: 0x1CB3860 Offset: 0x1CB3961 VA: 0x1CB3860
	private void <EnumerateAll>b__61_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEEC0 Offset: 0x2AEFC1 VA: 0x2AEEC0
	// RVA: 0x1CB3930 Offset: 0x1CB3A31 VA: 0x1CB3930
	private void <EnumeratePriority>b__62_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEED0 Offset: 0x2AEFD1 VA: 0x2AEED0
	// RVA: 0x1CB3D60 Offset: 0x1CB3E61 VA: 0x1CB3D60
	private void <EnumerateAttackLongRange>b__63_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEEE0 Offset: 0x2AEFE1 VA: 0x2AEEE0
	// RVA: 0x1CB4230 Offset: 0x1CB4331 VA: 0x1CB4230
	private void <EnumerateAttack>b__64_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEEF0 Offset: 0x2AEFF1 VA: 0x2AEEF0
	// RVA: 0x1CB4E40 Offset: 0x1CB4F41 VA: 0x1CB4E40
	private void <EnumerateMove>b__65_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEF00 Offset: 0x2AF001 VA: 0x2AEF00
	// RVA: 0x1CB4F40 Offset: 0x1CB5041 VA: 0x1CB4F40
	private void <EnumerateEntrust>b__66_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEF10 Offset: 0x2AF011 VA: 0x2AEF10
	// RVA: 0x1CB5990 Offset: 0x1CB5A91 VA: 0x1CB5990
	private void <EnumerateUncontroll>b__67_0(Unit unit) { }
}

