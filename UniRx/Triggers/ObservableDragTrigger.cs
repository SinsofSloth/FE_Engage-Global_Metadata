// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x136F0 Offset: 0x137F1 VA: 0x136F0
public class ObservableDragTrigger : ObservableTriggerBase, IEventSystemHandler, IDragHandler // TypeDefIndex: 6807
{
	// Fields
	private Subject<PointerEventData> onDrag; // 0x48

	// Methods

	// RVA: 0x19DB8C0 Offset: 0x19DB9C1 VA: 0x19DB8C0 Slot: 5
	private void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

	// RVA: 0x19DB930 Offset: 0x19DBA31 VA: 0x19DB930
	public IObservable<PointerEventData> OnDragAsObservable() { }

	// RVA: 0x19DB9D0 Offset: 0x19DBAD1 VA: 0x19DB9D0 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DBA30 Offset: 0x19DBB31 VA: 0x19DBA30
	public void .ctor() { }
}

