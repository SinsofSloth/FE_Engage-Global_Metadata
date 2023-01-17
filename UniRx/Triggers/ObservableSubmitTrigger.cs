// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13840 Offset: 0x13941 VA: 0x13840
public class ObservableSubmitTrigger : ObservableTriggerBase, IEventSystemHandler, ISubmitHandler // TypeDefIndex: 6830
{
	// Fields
	private Subject<BaseEventData> onSubmit; // 0x48

	// Methods

	// RVA: 0x19E0660 Offset: 0x19E0761 VA: 0x19E0660 Slot: 5
	private void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(BaseEventData eventData) { }

	// RVA: 0x19E06D0 Offset: 0x19E07D1 VA: 0x19E06D0
	public IObservable<BaseEventData> OnSubmitAsObservable() { }

	// RVA: 0x19E0770 Offset: 0x19E0871 VA: 0x19E0770 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19E07D0 Offset: 0x19E08D1 VA: 0x19E07D0
	public void .ctor() { }
}

