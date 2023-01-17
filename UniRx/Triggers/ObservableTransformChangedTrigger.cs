// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13850 Offset: 0x13951 VA: 0x13850
public class ObservableTransformChangedTrigger : ObservableTriggerBase // TypeDefIndex: 6831
{
	// Fields
	private Subject<Unit> onBeforeTransformParentChanged; // 0x48
	private Subject<Unit> onTransformParentChanged; // 0x50
	private Subject<Unit> onTransformChildrenChanged; // 0x58

	// Methods

	// RVA: 0x19E07E0 Offset: 0x19E08E1 VA: 0x19E07E0
	private void OnBeforeTransformParentChanged() { }

	// RVA: 0x19E08E0 Offset: 0x19E09E1 VA: 0x19E08E0
	public IObservable<Unit> OnBeforeTransformParentChangedAsObservable() { }

	// RVA: 0x19E0980 Offset: 0x19E0A81 VA: 0x19E0980
	private void OnTransformParentChanged() { }

	// RVA: 0x19E0A80 Offset: 0x19E0B81 VA: 0x19E0A80
	public IObservable<Unit> OnTransformParentChangedAsObservable() { }

	// RVA: 0x19E0B20 Offset: 0x19E0C21 VA: 0x19E0B20
	private void OnTransformChildrenChanged() { }

	// RVA: 0x19E0C20 Offset: 0x19E0D21 VA: 0x19E0C20
	public IObservable<Unit> OnTransformChildrenChangedAsObservable() { }

	// RVA: 0x19E0CC0 Offset: 0x19E0DC1 VA: 0x19E0CC0 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19E0D40 Offset: 0x19E0E41 VA: 0x19E0D40
	public void .ctor() { }
}

