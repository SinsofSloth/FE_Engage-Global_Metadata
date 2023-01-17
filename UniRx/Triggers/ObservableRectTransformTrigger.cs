// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13800 Offset: 0x13901 VA: 0x13800
public class ObservableRectTransformTrigger : ObservableTriggerBase // TypeDefIndex: 6824
{
	// Fields
	private Subject<Unit> onRectTransformDimensionsChange; // 0x48
	private Subject<Unit> onRectTransformRemoved; // 0x50

	// Methods

	// RVA: 0x19DF6D0 Offset: 0x19DF7D1 VA: 0x19DF6D0
	private void OnRectTransformDimensionsChange() { }

	// RVA: 0x19DF7D0 Offset: 0x19DF8D1 VA: 0x19DF7D0
	public IObservable<Unit> OnRectTransformDimensionsChangeAsObservable() { }

	// RVA: 0x19DF870 Offset: 0x19DF971 VA: 0x19DF870
	private void OnRectTransformRemoved() { }

	// RVA: 0x19DF970 Offset: 0x19DFA71 VA: 0x19DF970
	public IObservable<Unit> OnRectTransformRemovedAsObservable() { }

	// RVA: 0x19DFA10 Offset: 0x19DFB11 VA: 0x19DFA10 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DFA80 Offset: 0x19DFB81 VA: 0x19DFA80
	public void .ctor() { }
}

