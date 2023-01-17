// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13810 Offset: 0x13911 VA: 0x13810
public class ObservableScrollTrigger : ObservableTriggerBase, IEventSystemHandler, IScrollHandler // TypeDefIndex: 6825
{
	// Fields
	private Subject<PointerEventData> onScroll; // 0x48

	// Methods

	// RVA: 0x19DFA90 Offset: 0x19DFB91 VA: 0x19DFA90 Slot: 5
	private void UnityEngine.EventSystems.IScrollHandler.OnScroll(PointerEventData eventData) { }

	// RVA: 0x19DFB00 Offset: 0x19DFC01 VA: 0x19DFB00
	public IObservable<PointerEventData> OnScrollAsObservable() { }

	// RVA: 0x19DFBA0 Offset: 0x19DFCA1 VA: 0x19DFBA0 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DFC00 Offset: 0x19DFD01 VA: 0x19DFC00
	public void .ctor() { }
}

