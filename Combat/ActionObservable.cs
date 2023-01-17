// Namespace: Combat
internal abstract class ActionObservable : ActionDisposerHolder // TypeDefIndex: 8440
{
	// Methods

	// RVA: 0x2EBF3F0 Offset: 0x2EBF4F1 VA: 0x2EBF3F0
	protected void .ctor(Character chr, Phase phase) { }

	// RVA: 0x2EC0D50 Offset: 0x2EC0E51 VA: 0x2EC0D50 Slot: 6
	public override void OnEnter() { }

	// RVA: 0x2EC0F50 Offset: 0x2EC1051 VA: 0x2EC0F50 Slot: 7
	public override void OnUpdate() { }

	// RVA: 0x2EC1380 Offset: 0x2EC1481 VA: 0x2EC1380 Slot: 9
	public override void OnExit() { }

	// RVA: 0x2EC3DB0 Offset: 0x2EC3EB1 VA: 0x2EC3DB0 Slot: 12
	protected virtual void OnEnterAttack() { }

	// RVA: 0x2EC8380 Offset: 0x2EC8481 VA: 0x2EC8380 Slot: 13
	protected virtual void OnHitPassed(AnimationEvent ev) { }
}

