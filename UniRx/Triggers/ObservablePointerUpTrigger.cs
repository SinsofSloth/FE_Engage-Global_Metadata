// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x137F0 Offset: 0x138F1 VA: 0x137F0
public class ObservablePointerUpTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerUpHandler // TypeDefIndex: 6823
{
	// Fields
	private Subject<PointerEventData> onPointerUp; // 0x48

	// Methods

	// RVA: 0x19DF550 Offset: 0x19DF651 VA: 0x19DF550 Slot: 5
	private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x19DF5C0 Offset: 0x19DF6C1 VA: 0x19DF5C0
	public IObservable<PointerEventData> OnPointerUpAsObservable() { }

	// RVA: 0x19DF660 Offset: 0x19DF761 VA: 0x19DF660 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DF6C0 Offset: 0x19DF7C1 VA: 0x19DF6C0
	public void .ctor() { }
}

