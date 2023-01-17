// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13820 Offset: 0x13921 VA: 0x13820
public class ObservableSelectTrigger : ObservableTriggerBase, IEventSystemHandler, ISelectHandler // TypeDefIndex: 6826
{
	// Fields
	private Subject<BaseEventData> onSelect; // 0x48

	// Methods

	// RVA: 0x19DFC10 Offset: 0x19DFD11 VA: 0x19DFC10 Slot: 5
	private void UnityEngine.EventSystems.ISelectHandler.OnSelect(BaseEventData eventData) { }

	// RVA: 0x19DFC80 Offset: 0x19DFD81 VA: 0x19DFC80
	public IObservable<BaseEventData> OnSelectAsObservable() { }

	// RVA: 0x19DFD20 Offset: 0x19DFE21 VA: 0x19DFD20 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DFD80 Offset: 0x19DFE81 VA: 0x19DFD80
	public void .ctor() { }
}

