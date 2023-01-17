// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13700 Offset: 0x13801 VA: 0x13700
public class ObservableDropTrigger : ObservableTriggerBase, IEventSystemHandler, IDropHandler // TypeDefIndex: 6808
{
	// Fields
	private Subject<PointerEventData> onDrop; // 0x48

	// Methods

	// RVA: 0x19DBA40 Offset: 0x19DBB41 VA: 0x19DBA40 Slot: 5
	private void UnityEngine.EventSystems.IDropHandler.OnDrop(PointerEventData eventData) { }

	// RVA: 0x19DBAB0 Offset: 0x19DBBB1 VA: 0x19DBAB0
	public IObservable<PointerEventData> OnDropAsObservable() { }

	// RVA: 0x19DBB50 Offset: 0x19DBC51 VA: 0x19DBB50 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DBBB0 Offset: 0x19DBCB1 VA: 0x19DBBB0
	public void .ctor() { }
}

