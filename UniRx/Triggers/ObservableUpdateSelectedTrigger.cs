// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13890 Offset: 0x13991 VA: 0x13890
public class ObservableUpdateSelectedTrigger : ObservableTriggerBase, IEventSystemHandler, IUpdateSelectedHandler // TypeDefIndex: 6836
{
	// Fields
	private Subject<BaseEventData> onUpdateSelected; // 0x48

	// Methods

	// RVA: 0x19EABB0 Offset: 0x19EACB1 VA: 0x19EABB0 Slot: 5
	private void UnityEngine.EventSystems.IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x19E6DD0 Offset: 0x19E6ED1 VA: 0x19E6DD0
	public IObservable<BaseEventData> OnUpdateSelectedAsObservable() { }

	// RVA: 0x19EAC20 Offset: 0x19EAD21 VA: 0x19EAC20 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19EAC80 Offset: 0x19EAD81 VA: 0x19EAC80
	public void .ctor() { }
}

