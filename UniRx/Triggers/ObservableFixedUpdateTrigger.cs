// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13740 Offset: 0x13841 VA: 0x13740
public class ObservableFixedUpdateTrigger : ObservableTriggerBase // TypeDefIndex: 6812
{
	// Fields
	private Subject<Unit> fixedUpdate; // 0x48

	// Methods

	// RVA: 0x19DD4B0 Offset: 0x19DD5B1 VA: 0x19DD4B0
	private void FixedUpdate() { }

	// RVA: 0x19DD5B0 Offset: 0x19DD6B1 VA: 0x19DD5B0
	public IObservable<Unit> FixedUpdateAsObservable() { }

	// RVA: 0x19DD650 Offset: 0x19DD751 VA: 0x19DD650 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DD6B0 Offset: 0x19DD7B1 VA: 0x19DD6B0
	public void .ctor() { }
}

