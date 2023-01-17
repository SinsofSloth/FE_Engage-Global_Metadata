// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13720 Offset: 0x13821 VA: 0x13720
public class ObservableEndDragTrigger : ObservableTriggerBase, IEventSystemHandler, IEndDragHandler // TypeDefIndex: 6810
{
	// Fields
	private Subject<PointerEventData> onEndDrag; // 0x48

	// Methods

	// RVA: 0x19DBF80 Offset: 0x19DC081 VA: 0x19DBF80 Slot: 5
	private void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x19DBFF0 Offset: 0x19DC0F1 VA: 0x19DBFF0
	public IObservable<PointerEventData> OnEndDragAsObservable() { }

	// RVA: 0x19DC090 Offset: 0x19DC191 VA: 0x19DC090 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DC0F0 Offset: 0x19DC1F1 VA: 0x19DC0F0
	public void .ctor() { }
}

