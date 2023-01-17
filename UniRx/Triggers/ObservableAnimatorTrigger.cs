// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13670 Offset: 0x13771 VA: 0x13670
public class ObservableAnimatorTrigger : ObservableTriggerBase // TypeDefIndex: 6799
{
	// Fields
	private Subject<int> onAnimatorIK; // 0x48
	private Subject<Unit> onAnimatorMove; // 0x50

	// Methods

	// RVA: 0x19DA2B0 Offset: 0x19DA3B1 VA: 0x19DA2B0
	private void OnAnimatorIK(int layerIndex) { }

	// RVA: 0x19DA320 Offset: 0x19DA421 VA: 0x19DA320
	public IObservable<int> OnAnimatorIKAsObservable() { }

	// RVA: 0x19DA3C0 Offset: 0x19DA4C1 VA: 0x19DA3C0
	private void OnAnimatorMove() { }

	// RVA: 0x19DA4C0 Offset: 0x19DA5C1 VA: 0x19DA4C0
	public IObservable<Unit> OnAnimatorMoveAsObservable() { }

	// RVA: 0x19DA560 Offset: 0x19DA661 VA: 0x19DA560 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DA5E0 Offset: 0x19DA6E1 VA: 0x19DA5E0
	public void .ctor() { }
}

