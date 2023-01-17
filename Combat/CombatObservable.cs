// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x274210 Offset: 0x274311 VA: 0x274210
public sealed class CombatObservable : MonoBehaviour // TypeDefIndex: 8688
{
	// Fields
	public Subject<Phase> OnPhaseAdvanced; // 0x18
	public Subject<PhaseArray> OnAttackRightChanged; // 0x20
	public Subject<AnimationEvent> OnHitPassed; // 0x28
	public Subject<Unit> OnHitstopEnd; // 0x30
	public Subject<Unit> OnSkipCombat; // 0x38

	// Methods

	// RVA: 0x2566740 Offset: 0x2566841 VA: 0x2566740
	private void OnDestroy() { }

	// RVA: 0x25668A0 Offset: 0x25669A1 VA: 0x25668A0
	public void .ctor() { }
}

