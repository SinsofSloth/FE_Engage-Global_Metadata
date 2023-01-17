// Namespace: App
internal class TurnEffect : ProcInst // TypeDefIndex: 12457
{
	// Fields
	protected Unit m_Unit; // 0x70

	// Properties
	protected override bool CanWaitSkip { get; }

	// Methods

	// RVA: 0x287CCC0 Offset: 0x287CDC1 VA: 0x287CCC0
	protected void .ctor() { }

	// RVA: 0x287CD70 Offset: 0x287CE71 VA: 0x287CD70 Slot: 4
	protected override bool get_CanWaitSkip() { }

	// RVA: 0x287CD80 Offset: 0x287CE81 VA: 0x287CD80
	protected void Search() { }

	// RVA: 0x287CE40 Offset: 0x287CF41 VA: 0x287CE40
	protected void NextUnit() { }

	// RVA: 0x287CED0 Offset: 0x287CFD1 VA: 0x287CED0
	protected void Damage(int damage) { }

	// RVA: 0x287CFD0 Offset: 0x287D0D1 VA: 0x287CFD0
	protected void Heal(int heal) { }

	[IteratorStateMachineAttribute] // RVA: 0x2C8EB0 Offset: 0x2C8FB1 VA: 0x2C8EB0
	// RVA: 0x287CFF0 Offset: 0x287D0F1 VA: 0x287CFF0 Slot: 18
	protected virtual IEnumerator Execute() { }

	// RVA: 0x287D070 Offset: 0x287D171 VA: 0x287D070
	protected void TryWaitTime(float time) { }

	// RVA: -1 Offset: -1
	public static void CreateBind<T>(ProcInst super) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20283F0 Offset: 0x20284F1 VA: 0x20283F0
	|-TurnEffect.CreateBind<object>
	|-TurnEffect.CreateBind<MapSequenceTurnBeginEffect.ProcEngageSkill>
	|-TurnEffect.CreateBind<MapSequenceTurnBeginEffect.ProcFullBulletAttack>
	|-TurnEffect.CreateBind<MapSequenceTurnBeginEffect.ProcSkillHeal>
	|-TurnEffect.CreateBind<MapSequenceTurnBeginEffect.ProcSkillTurn>
	|-TurnEffect.CreateBind<MapSequenceTurnBeginEffect.ProcTerrainDamage>
	|-TurnEffect.CreateBind<MapSequenceTurnBeginEffect.ProcTerrainHeal>
	*/
}

