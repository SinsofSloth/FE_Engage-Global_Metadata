// Namespace: App
public class MapSequenceMind : ProcInst // TypeDefIndex: 12433
{
	// Fields
	private Unit m_Unit; // 0x70
	private Unit m_Target; // 0x78
	private bool m_IsMoveOnly; // 0x80

	// Properties
	protected override bool CanWaitSkip { get; }

	// Methods

	// RVA: 0x26F9920 Offset: 0x26F9A21 VA: 0x26F9920
	private void .ctor(Unit unit, Unit target) { }

	// RVA: 0x26F9980 Offset: 0x26F9A81 VA: 0x26F9980
	private Unit GetUnit() { }

	// RVA: 0x26F9A10 Offset: 0x26F9B11 VA: 0x26F9A10
	private Unit GetTarget() { }

	// RVA: 0x26F9AA0 Offset: 0x26F9BA1 VA: 0x26F9AA0
	private void UnitMove() { }

	// RVA: 0x26F9C70 Offset: 0x26F9D71 VA: 0x26F9C70
	private void UnitMoveWait() { }

	// RVA: 0x26F9D90 Offset: 0x26F9E91 VA: 0x26F9D90
	private void SetMoveOnly() { }

	// RVA: 0x26F9DA0 Offset: 0x26F9EA1 VA: 0x26F9DA0
	private bool IsMoveOnly() { }

	// RVA: 0x26F9DB0 Offset: 0x26F9EB1 VA: 0x26F9DB0
	private bool IsSkipAIEngageRewarp() { }

	// RVA: 0x26F9E40 Offset: 0x26F9F41 VA: 0x26F9E40
	private void AIEngageRewarp() { }

	// RVA: 0x26FA000 Offset: 0x26FA101 VA: 0x26FA000
	private void MultiTarget() { }

	// RVA: 0x26FB170 Offset: 0x26FB271 VA: 0x26FB170
	private void TryAddTargetOfFireCannon(int x, int z) { }

	// RVA: 0x26FB500 Offset: 0x26FB601 VA: 0x26FB500
	private void Branch() { }

	// RVA: 0x26FB8B0 Offset: 0x26FB9B1 VA: 0x26FB8B0
	private void Breakdown() { }

	// RVA: 0x26FB9D0 Offset: 0x26FBAD1 VA: 0x26FB9D0
	private void BreakdownEnemy() { }

	// RVA: 0x26FBAF0 Offset: 0x26FBBF1 VA: 0x26FBAF0
	private void DestroyVillage() { }

	// RVA: 0x26FBCA0 Offset: 0x26FBDA1 VA: 0x26FBCA0
	private void EscapeEvent() { }

	// RVA: 0x26FBE20 Offset: 0x26FBF21 VA: 0x26FBE20
	private void Escape() { }

	// RVA: 0x26FBEF0 Offset: 0x26FBFF1 VA: 0x26FBEF0
	private void Visit() { }

	// RVA: 0x26FC010 Offset: 0x26FC111 VA: 0x26FC010
	private void Poke(MapInspector.Kind kind) { }

	// RVA: 0x26FC110 Offset: 0x26FC211 VA: 0x26FC110
	private void Unlock() { }

	// RVA: 0x26FC2C0 Offset: 0x26FC3C1 VA: 0x26FC2C0
	private void TreasureBox() { }

	// RVA: 0x26FC2D0 Offset: 0x26FC3D1 VA: 0x26FC2D0
	private void Door() { }

	// RVA: 0x26FC300 Offset: 0x26FC401 VA: 0x26FC300
	private void Torch() { }

	// RVA: 0x26FC310 Offset: 0x26FC411 VA: 0x26FC310
	private void Guard() { }

	// RVA: 0x26FC6B0 Offset: 0x26FC7B1 VA: 0x26FC6B0
	private void Lockon() { }

	// RVA: 0x26FC7D0 Offset: 0x26FC8D1 VA: 0x26FC7D0
	private void Talk() { }

	// RVA: 0x26FC9C0 Offset: 0x26FCAC1 VA: 0x26FC9C0
	private void DoneAction() { }

	// RVA: 0x26FCA40 Offset: 0x26FCB41 VA: 0x26FCA40
	private void OverlapSkill() { }

	// RVA: 0x26FCDA0 Offset: 0x26FCEA1 VA: 0x26FCDA0
	private void CommandSkill() { }

	// RVA: 0x26FCF60 Offset: 0x26FD061 VA: 0x26FCF60
	private void EngageCharge() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C8D30 Offset: 0x2C8E31 VA: 0x2C8D30
	// RVA: 0x26FD080 Offset: 0x26FD181 VA: 0x26FD080
	private IEnumerator EngageWait() { }

	// RVA: 0x26FD100 Offset: 0x26FD201 VA: 0x26FD100
	private void UpdateImage() { }

	// RVA: 0x26FD180 Offset: 0x26FD281 VA: 0x26FD180
	private bool TryTransfer(Unit unit) { }

	// RVA: 0x26FD320 Offset: 0x26FD421 VA: 0x26FD320
	private void Fixed() { }

	// RVA: 0x26FF740 Offset: 0x26FF841 VA: 0x26FF740
	private void GodExp() { }

	// RVA: 0x26FF7E0 Offset: 0x26FF8E1 VA: 0x26FF7E0
	private SkillEnum GetFixedSkillEnum(Unit unit) { }

	// RVA: 0x26FF9A0 Offset: 0x26FFAA1 VA: 0x26FF9A0 Slot: 4
	protected override bool get_CanWaitSkip() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C8DA0 Offset: 0x2C8EA1 VA: 0x2C8DA0
	// RVA: 0x26FF9B0 Offset: 0x26FFAB1 VA: 0x26FF9B0
	private IEnumerator FixedSkill() { }

	// RVA: 0x26FFA30 Offset: 0x26FFB31 VA: 0x26FFA30
	private bool CanFixedBonus(Unit unit) { }

	// RVA: 0x26FFBA0 Offset: 0x26FFCA1 VA: 0x26FFBA0
	private void EngageHeal() { }

	// RVA: 0x26FFEB0 Offset: 0x26FFFB1 VA: 0x26FFEB0
	private void KillBonus() { }

	// RVA: 0x26F9C60 Offset: 0x26F9D61 VA: 0x26F9C60
	private bool IsMoveSkip() { }

	// RVA: 0x26FFB20 Offset: 0x26FFC21 VA: 0x26FFB20
	private bool IsAlive(Unit unit) { }

	// RVA: 0x26FFFF0 Offset: 0x27000F1 VA: 0x26FFFF0
	private bool IsFixedEvent(Unit unit) { }

	// RVA: 0x27000C0 Offset: 0x27001C1 VA: 0x27000C0
	private bool IsFixedEvent(Unit unit, Force.Type forceType) { }

	// RVA: 0x27001B0 Offset: 0x27002B1 VA: 0x27001B0
	private void HelpEvent() { }

	// RVA: 0x2700410 Offset: 0x2700511 VA: 0x2700410
	private void FixedEvent() { }

	// RVA: 0x27005D0 Offset: 0x27006D1 VA: 0x27005D0
	private void AreaEvent() { }

	// RVA: 0x2700870 Offset: 0x2700971 VA: 0x2700870
	private void AddUnitImage() { }

	// RVA: 0x2700990 Offset: 0x2700A91 VA: 0x2700990
	private void DeleteUnitImage() { }

	// RVA: 0x2700AB0 Offset: 0x2700BB1 VA: 0x2700AB0
	private void UnitDeadEvent() { }

	// RVA: 0x2700E30 Offset: 0x2700F31 VA: 0x2700E30
	private void UnitDeadFade() { }

	// RVA: 0x2700ED0 Offset: 0x2700FD1 VA: 0x2700ED0
	private void UnitDead() { }

	// RVA: 0x2701560 Offset: 0x2701661 VA: 0x2701560
	private void UnitDeadKillBonus() { }

	// RVA: 0x2701660 Offset: 0x2701761 VA: 0x2701660
	private void Revive() { }

	// RVA: 0x27017E0 Offset: 0x27018E1 VA: 0x27017E0
	private void LooselyFocus() { }

	// RVA: 0x27018F0 Offset: 0x27019F1 VA: 0x27018F0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2704E70 Offset: 0x2704F71 VA: 0x2704E70
	public static void CreateBindTalk(ProcInst super) { }

	// RVA: 0x2704F00 Offset: 0x2705001 VA: 0x2704F00
	public static void CreateBindDie(ProcInst super, Unit unit) { }

	// RVA: 0x2704F90 Offset: 0x2705091 VA: 0x2704F90
	public static void CreateBindDieWithoutEvent(ProcInst super, Unit unit) { }

	// RVA: 0x2705020 Offset: 0x2705121 VA: 0x2705020
	public static void CreateBindEventBattle(ProcInst super) { }

	// RVA: 0x2705140 Offset: 0x2705241 VA: 0x2705140
	public static void CreateBindMoveOnly(ProcInst super) { }

	// RVA: 0x2701900 Offset: 0x2701A01 VA: 0x2701900
	private static MapSequenceMind CreateBindImpl(ProcInst super, Unit unit, Unit target) { }
}

