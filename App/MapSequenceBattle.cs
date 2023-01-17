// Namespace: App
public class MapSequenceBattle : CommonBattleSequence<MapSequenceBattle> // TypeDefIndex: 12390
{
	// Fields
	private MapSequenceBattle.Kinds m_Kind; // 0xA0
	private int m_TargetIndex; // 0xA4
	private int m_BattleCount; // 0xA8
	private int m_GainExp; // 0xAC
	private BattleInfoSide.Status m_ExpStatus; // 0xB0
	private int m_ExpendCount; // 0xB4
	private int m_StartX; // 0xB8
	private int m_StartZ; // 0xBC
	private bool m_GrowTalk; // 0xC0
	private Unit m_Defender; // 0xC8
	private MapSequenceBattle.BitFieldStatus m_Status; // 0xD0
	private MapSequenceBattle.UnitList m_DeadUnits; // 0xD8
	private MapSequenceBattle.UnitList m_DieEvents; // 0xE0
	private MapSequenceBattle.UnitList m_FadeUnits; // 0xE8
	private MapSequenceBattle.UnitList m_DropUnits; // 0xF0

	// Properties
	protected override bool CanWaitSkip { get; }

	// Methods

	// RVA: 0x1D758E0 Offset: 0x1D759E1 VA: 0x1D758E0
	private void .ctor() { }

	// RVA: 0x1D75A70 Offset: 0x1D75B71 VA: 0x1D75A70
	private void MindStart() { }

	// RVA: 0x1D75C30 Offset: 0x1D75D31 VA: 0x1D75C30
	private void MindEnd() { }

	// RVA: 0x1D75CE0 Offset: 0x1D75DE1 VA: 0x1D75CE0
	private void CalcBattle() { }

	// RVA: 0x1D76280 Offset: 0x1D76381 VA: 0x1D76280
	private void EngageAttackTelop() { }

	// RVA: 0x1D765A0 Offset: 0x1D766A1 VA: 0x1D765A0
	private void StartBranch() { }

	// RVA: 0x1D760F0 Offset: 0x1D761F1 VA: 0x1D760F0
	private void CalcSimple(bool isWarmup) { }

	// RVA: 0x1D767E0 Offset: 0x1D768E1 VA: 0x1D767E0
	private void CalcSimple(BattleInfo info, bool isWarmup, bool isSimulation) { }

	// RVA: 0x1D76A90 Offset: 0x1D76B91 VA: 0x1D76A90
	private void MultiBattleWarmup() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C8370 Offset: 0x2C8471 VA: 0x2C8370
	// RVA: 0x1D76AD0 Offset: 0x1D76BD1 VA: 0x1D76AD0
	private IEnumerator MultiBattleTalk() { }

	// RVA: 0x1D76B50 Offset: 0x1D76C51 VA: 0x1D76B50
	private void MultiBattleCombat() { }

	// RVA: 0x1D76C40 Offset: 0x1D76D41 VA: 0x1D76C40
	private void MultiBattleBranch() { }

	// RVA: 0x1D76D70 Offset: 0x1D76E71 VA: 0x1D76D70
	private void MultiBattleEnd() { }

	// RVA: 0x1D76D80 Offset: 0x1D76E81 VA: 0x1D76D80
	private void MultiBattleNext() { }

	// RVA: 0x1D76D90 Offset: 0x1D76E91 VA: 0x1D76D90
	private void MultiBattleResult() { }

	// RVA: 0x1D76DD0 Offset: 0x1D76ED1 VA: 0x1D76DD0
	private void MultiBattleGrow() { }

	// RVA: 0x1D76F30 Offset: 0x1D77031 VA: 0x1D76F30
	private void MultBattleExpend() { }

	// RVA: 0x1D77200 Offset: 0x1D77301 VA: 0x1D77200
	private void BattleBranch() { }

	// RVA: 0x1D772D0 Offset: 0x1D773D1 VA: 0x1D772D0
	private void CombatRotation() { }

	// RVA: 0x1D76C00 Offset: 0x1D76D01 VA: 0x1D76C00
	private void CombatBattle() { }

	// RVA: 0x1D774E0 Offset: 0x1D775E1 VA: 0x1D774E0
	private void CombatBranch() { }

	// RVA: 0x1D775B0 Offset: 0x1D776B1 VA: 0x1D775B0
	private void SimpleBattle() { }

	// RVA: 0x1D78E70 Offset: 0x1D78F71 VA: 0x1D78E70
	private void MultiBattleOnce() { }

	// RVA: 0x1D78F60 Offset: 0x1D79061 VA: 0x1D78F60
	private void BattleUpdate() { }

	// RVA: 0x1D78FB0 Offset: 0x1D790B1 VA: 0x1D78FB0
	private void CommitBattle() { }

	// RVA: 0x1D79020 Offset: 0x1D79121 VA: 0x1D79020
	private static bool IsShowSkill(SkillData skill) { }

	// RVA: 0x1D79070 Offset: 0x1D79171 VA: 0x1D79070
	private SkillData.Frequencies GetFrequency() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C83E0 Offset: 0x2C84E1 VA: 0x2C83E0
	// RVA: 0x1D79180 Offset: 0x1D79281 VA: 0x1D79180
	private IEnumerator BattleSkillAfter() { }

	// RVA: 0x1D79200 Offset: 0x1D79301 VA: 0x1D79200
	private static void UpdateAging(BattleInfoSide side, SkillData.Cycles cycle) { }

	[IteratorStateMachineAttribute] // RVA: 0x2C8450 Offset: 0x2C8551 VA: 0x2C8450
	// RVA: 0x1D792F0 Offset: 0x1D793F1 VA: 0x1D792F0
	private IEnumerator BattleSkillAround() { }

	// RVA: 0x1D79370 Offset: 0x1D79471 VA: 0x1D79370 Slot: 4
	protected override bool get_CanWaitSkip() { }

	// RVA: 0x1D79380 Offset: 0x1D79481 VA: 0x1D79380
	private BattleScene GetRodScene() { }

	// RVA: 0x1D793A0 Offset: 0x1D794A1 VA: 0x1D793A0
	private ProcInst GetActionProc() { }

	// RVA: 0x1D79480 Offset: 0x1D79581 VA: 0x1D79480
	private bool TryWarpImpl(Unit rodUnit, Unit target, int x, int z) { }

	// RVA: 0x1D79600 Offset: 0x1D79701 VA: 0x1D79600
	private bool TryWarp(Unit rodUnit, Unit target, int x, int z) { }

	// RVA: 0x1D796A0 Offset: 0x1D797A1 VA: 0x1D796A0
	private void RangeWarp(Unit rodUnit, Unit unit, int range, int warpX, int warpZ, bool canSelf) { }

	// RVA: 0x1D799B0 Offset: 0x1D79AB1 VA: 0x1D799B0
	private void RangeRescue(Unit rodUnit, Unit unit, int range) { }

	// RVA: 0x1D79CF0 Offset: 0x1D79DF1 VA: 0x1D79CF0
	private void RangeTorch(Unit unit, int range, ItemData item) { }

	// RVA: 0x1D77390 Offset: 0x1D77491 VA: 0x1D77390
	private ProcVoidMethod GetActionCallback() { }

	// RVA: 0x1D7A6F0 Offset: 0x1D7A7F1 VA: 0x1D7A6F0
	private void UseRod() { }

	// RVA: 0x1D7B5A0 Offset: 0x1D7B6A1 VA: 0x1D7B5A0
	private void UseRest(BattleScene scene) { }

	// RVA: 0x1D7B8B0 Offset: 0x1D7B9B1 VA: 0x1D7B8B0
	private void UseMove() { }

	// RVA: 0x1D7B7D0 Offset: 0x1D7B8D1 VA: 0x1D7B7D0
	private void UseFocus() { }

	// RVA: 0x1D7BAA0 Offset: 0x1D7BBA1 VA: 0x1D7BAA0
	private static void PlayEngageTurnRecoveryEffect(Unit unit) { }

	// RVA: 0x1D7BB30 Offset: 0x1D7BC31 VA: 0x1D7BB30
	private static void EngageTurnRecoveryUnit(Unit unit) { }

	[IteratorStateMachineAttribute] // RVA: 0x2C84C0 Offset: 0x2C85C1 VA: 0x2C84C0
	// RVA: 0x1D7BBC0 Offset: 0x1D7BCC1 VA: 0x1D7BBC0
	private IEnumerator EngageTurnRecovery() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C8530 Offset: 0x2C8631 VA: 0x2C8530
	// RVA: 0x1D7BC40 Offset: 0x1D7BD41 VA: 0x1D7BC40
	private IEnumerator HpStockCreate() { }

	// RVA: 0x1D7BCC0 Offset: 0x1D7BDC1 VA: 0x1D7BCC0
	private void DestroyAction() { }

	// RVA: 0x1D7BCD0 Offset: 0x1D7BDD1 VA: 0x1D7BCD0
	private void DestroyAfter() { }

	// RVA: 0x1D7BD40 Offset: 0x1D7BE41 VA: 0x1D7BD40
	private void UpdateTerrain() { }

	// RVA: 0x1D7C0B0 Offset: 0x1D7C1B1 VA: 0x1D7C0B0
	private void TryUpdateInfo(BattleSide.Type side) { }

	// RVA: 0x1D7C190 Offset: 0x1D7C291 VA: 0x1D7C190
	private void TryUpdateInfo(Unit unit) { }

	// RVA: 0x1D7C220 Offset: 0x1D7C321 VA: 0x1D7C220
	private void UpdateMapInfoUnit() { }

	// RVA: 0x1D7BF90 Offset: 0x1D7C091 VA: 0x1D7BF90
	private bool TerrainSet(BattleInfoSide side) { }

	// RVA: 0x1D7C3D0 Offset: 0x1D7C4D1 VA: 0x1D7C3D0 Slot: 22
	protected override bool CanGainSituation() { }

	// RVA: 0x1D7C490 Offset: 0x1D7C591 VA: 0x1D7C490
	private Unit GetWinner(Unit dead) { }

	[IteratorStateMachineAttribute] // RVA: 0x2C85A0 Offset: 0x2C86A1 VA: 0x2C85A0
	// RVA: 0x1D7C6E0 Offset: 0x1D7C7E1 VA: 0x1D7C6E0
	private IEnumerator DropItem() { }

	// RVA: 0x1D7C760 Offset: 0x1D7C861 VA: 0x1D7C760
	private void PickupItem() { }

	// RVA: 0x1D7C980 Offset: 0x1D7CA81 VA: 0x1D7C980
	private void GainGold() { }

	// RVA: 0x1D7CB30 Offset: 0x1D7CC31 VA: 0x1D7CB30
	private void ItemPutOff(Unit unit, UnitItem unitItem, string mid = "MID_MSG_BREAK_ITEM") { }

	// RVA: 0x1D77040 Offset: 0x1D77141 VA: 0x1D77040
	private void ItemExpend() { }

	// RVA: 0x1D7D020 Offset: 0x1D7D121 VA: 0x1D7D020
	private void Blow() { }

	// RVA: 0x1D7D250 Offset: 0x1D7D351 VA: 0x1D7D250
	private void DecreaseShell() { }

	// RVA: 0x1D7D3A0 Offset: 0x1D7D4A1 VA: 0x1D7D3A0
	private void TryAddDead(Unit unit) { }

	[IteratorStateMachineAttribute] // RVA: 0x2C8610 Offset: 0x2C8711 VA: 0x2C8610
	// RVA: 0x1D7D3C0 Offset: 0x1D7D4C1 VA: 0x1D7D3C0
	private IEnumerator Die() { }

	// RVA: 0x1D7D440 Offset: 0x1D7D541 VA: 0x1D7D440
	private void Grow() { }

	// RVA: 0x1D7D460 Offset: 0x1D7D561 VA: 0x1D7D460
	private void BattleBeforeEvent() { }

	// RVA: 0x1D7D510 Offset: 0x1D7D611 VA: 0x1D7D510
	private void BattleAfterEvent() { }

	// RVA: 0x1D7D5C0 Offset: 0x1D7D6C1 VA: 0x1D7D5C0
	private bool IsCommandSkill(SkillData skill, bool before) { }

	// RVA: 0x1D7D5F0 Offset: 0x1D7D6F1 VA: 0x1D7D5F0
	private void CommandSkillCommit(BattleInfoSide side, MapSkill.Result result) { }

	// RVA: 0x1D7D610 Offset: 0x1D7D711 VA: 0x1D7D610
	private void CommandSkillBefore() { }

	// RVA: 0x1D7DD20 Offset: 0x1D7DE21 VA: 0x1D7DD20
	private void CommandSkillAfter() { }

	// RVA: 0x1D7E130 Offset: 0x1D7E231 VA: 0x1D7E130
	private void GainGuradUnit() { }

	// RVA: 0x1D7E330 Offset: 0x1D7E431 VA: 0x1D7E330
	private void ToPreBgm() { }

	// RVA: 0x1D7E3B0 Offset: 0x1D7E4B1 VA: 0x1D7E3B0
	private void ToMainBgm() { }

	// RVA: 0x1D7E430 Offset: 0x1D7E531 VA: 0x1D7E430
	private void ReturnBgm() { }

	// RVA: 0x1D7E4B0 Offset: 0x1D7E5B1 VA: 0x1D7E4B0
	private void SoundAfterBattle() { }

	// RVA: 0x1D7E680 Offset: 0x1D7E781 VA: 0x1D7E680
	private void TryCombatAfterDie() { }

	// RVA: 0x1D7E740 Offset: 0x1D7E841 VA: 0x1D7E740
	private void TryCombatAfterGrow() { }

	// RVA: 0x1D7E7E0 Offset: 0x1D7E8E1 VA: 0x1D7E7E0
	private void ProcessDeadUnit() { }

	// RVA: 0x1D7EDA0 Offset: 0x1D7EEA1 VA: 0x1D7EDA0
	private void FocusMind() { }

	// RVA: 0x1D7EF30 Offset: 0x1D7F031 VA: 0x1D7EF30
	public static void CreateBind(ProcInst super) { }
}

