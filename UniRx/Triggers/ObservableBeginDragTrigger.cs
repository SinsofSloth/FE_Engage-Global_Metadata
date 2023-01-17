// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13680 Offset: 0x13781 VA: 0x13680
public class ObservableBeginDragTrigger : ObservableTriggerBase, IEventSystemHandler, IBeginDragHandler // TypeDefIndex: 6800
{
	// Fields
	private Subject<PointerEventData> onBeginDrag; // 0x48

	// Methods

	// RVA: 0x19DA600 Offset: 0x19DA701 VA: 0x19DA600 Slot: 5
	private void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x19DA670 Offset: 0x19DA771 VA: 0x19DA670
	public IObservable<PointerEventData> OnBeginDragAsObservable() { }

	// RVA: 0x19DA710 Offset: 0x19DA811 VA: 0x19DA710 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DA770 Offset: 0x19DA871 VA: 0x19DA770
	public void .ctor() { }
}

