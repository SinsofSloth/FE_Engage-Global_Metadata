// Namespace: Combat
internal sealed class ActionDamage : ActionBase // TypeDefIndex: 8406
{
	// Fields
	private Character m_Attacker; // 0x28
	private Character m_Damager; // 0x30
	private AnimationEvent m_HitEv; // 0x38

	// Properties
	public override string Name { get; }
	public override bool AbortByInterrupt { get; }

	// Methods

	// RVA: 0x2EC4530 Offset: 0x2EC4631 VA: 0x2EC4530 Slot: 5
	public override string get_Name() { }

	// RVA: 0x2EC4580 Offset: 0x2EC4681 VA: 0x2EC4580 Slot: 11
	public override bool get_AbortByInterrupt() { }

	// RVA: 0x2EC1DA0 Offset: 0x2EC1EA1 VA: 0x2EC1DA0
	public void .ctor(Character attacker, Character damager, Phase phase, AnimationEvent ev) { }

	// RVA: 0x2EC3350 Offset: 0x2EC3451 VA: 0x2EC3350
	public void RunLyingWhenDie() { }

	// RVA: 0x2EC4590 Offset: 0x2EC4691 VA: 0x2EC4590
	private static int ResolveAll(Phase phase, AnimationEvent ev) { }

	// RVA: 0x2EC47C0 Offset: 0x2EC48C1 VA: 0x2EC47C0 Slot: 7
	public override void OnUpdate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8500 Offset: 0x2A8601 VA: 0x2A8500
	// RVA: 0x2EC4860 Offset: 0x2EC4961 VA: 0x2EC4860
	private void <.ctor>b__7_0(Unit _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8510 Offset: 0x2A8611 VA: 0x2A8510
	// RVA: 0x2EC4870 Offset: 0x2EC4971 VA: 0x2EC4870
	private void <.ctor>b__7_1(Unit _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8520 Offset: 0x2A8621 VA: 0x2A8520
	// RVA: 0x2EC4770 Offset: 0x2EC4871 VA: 0x2EC4770
	private bool <.ctor>g__IsNotDummy|7_2() { }
}

