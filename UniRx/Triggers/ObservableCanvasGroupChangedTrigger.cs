// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x136A0 Offset: 0x137A1 VA: 0x136A0
public class ObservableCanvasGroupChangedTrigger : ObservableTriggerBase // TypeDefIndex: 6802
{
	// Fields
	private Subject<Unit> onCanvasGroupChanged; // 0x48

	// Methods

	// RVA: 0x19DA900 Offset: 0x19DAA01 VA: 0x19DA900
	private void OnCanvasGroupChanged() { }

	// RVA: 0x19DAA00 Offset: 0x19DAB01 VA: 0x19DAA00
	public IObservable<Unit> OnCanvasGroupChangedAsObservable() { }

	// RVA: 0x19DAAA0 Offset: 0x19DABA1 VA: 0x19DAAA0 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DAB00 Offset: 0x19DAC01 VA: 0x19DAB00
	public void .ctor() { }
}

