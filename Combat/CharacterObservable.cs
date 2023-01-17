// Namespace: Combat
public sealed class CharacterObservable : IDisposable // TypeDefIndex: 8624
{
	// Fields
	private Character CP; // 0x10
	public Subject<Character> OnSetupDone; // 0x18
	public Subject<int> OnAnimChanged; // 0x20
	[TupleElementNamesAttribute] // RVA: 0x282A10 Offset: 0x282B11 VA: 0x282A10
	public Subject<ValueTuple<float, int>> OnArrivalTimePredicted; // 0x28
	[TupleElementNamesAttribute] // RVA: 0x282AC0 Offset: 0x282BC1 VA: 0x282AC0
	public Subject<ValueTuple<float, WeaponStyle>> OnHitTimePredicted; // 0x30
	[TupleElementNamesAttribute] // RVA: 0x282B70 Offset: 0x282C71 VA: 0x282B70
	public Subject<ValueTuple<Character, GameObject>> OnWeaponDropped; // 0x38
	public Subject<Unit> OnFocusPlayer; // 0x40
	public Subject<Unit> OnFocusEnemy; // 0x48
	public Subject<AnimationEvent> OnActionDamage; // 0x50
	public Subject<Character> OnImpactAdjusted; // 0x58
	public Subject<Character> OnPostAttackBackstep; // 0x60

	// Methods

	// RVA: 0x29B4620 Offset: 0x29B4721 VA: 0x29B4620
	public void .ctor(Character owner) { }

	// RVA: 0x29B49C0 Offset: 0x29B4AC1 VA: 0x29B49C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x29B4A30 Offset: 0x29B4B31 VA: 0x29B4A30 Slot: 4
	public void Dispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAF20 Offset: 0x2AB021 VA: 0x2AAF20
	// RVA: 0x29B4C60 Offset: 0x29B4D61 VA: 0x29B4C60
	private void <.ctor>b__1_0(Unit _) { }
}

