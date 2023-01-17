// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x137C0 Offset: 0x138C1 VA: 0x137C0
public class ObservablePointerDownTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerDownHandler // TypeDefIndex: 6820
{
	// Fields
	private Subject<PointerEventData> onPointerDown; // 0x48

	// Methods

	// RVA: 0x19DF0D0 Offset: 0x19DF1D1 VA: 0x19DF0D0 Slot: 5
	private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x19DF140 Offset: 0x19DF241 VA: 0x19DF140
	public IObservable<PointerEventData> OnPointerDownAsObservable() { }

	// RVA: 0x19DF1E0 Offset: 0x19DF2E1 VA: 0x19DF1E0 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DF240 Offset: 0x19DF341 VA: 0x19DF240
	public void .ctor() { }
}

