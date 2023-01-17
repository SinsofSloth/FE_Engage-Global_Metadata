// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13690 Offset: 0x13791 VA: 0x13690
public class ObservableCancelTrigger : ObservableTriggerBase, IEventSystemHandler, ICancelHandler // TypeDefIndex: 6801
{
	// Fields
	private Subject<BaseEventData> onCancel; // 0x48

	// Methods

	// RVA: 0x19DA780 Offset: 0x19DA881 VA: 0x19DA780 Slot: 5
	private void UnityEngine.EventSystems.ICancelHandler.OnCancel(BaseEventData eventData) { }

	// RVA: 0x19DA7F0 Offset: 0x19DA8F1 VA: 0x19DA7F0
	public IObservable<BaseEventData> OnCancelAsObservable() { }

	// RVA: 0x19DA890 Offset: 0x19DA991 VA: 0x19DA890 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DA8F0 Offset: 0x19DA9F1 VA: 0x19DA8F0
	public void .ctor() { }
}

