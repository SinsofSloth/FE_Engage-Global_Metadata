// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x137E0 Offset: 0x138E1 VA: 0x137E0
public class ObservablePointerExitTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 6822
{
	// Fields
	private Subject<PointerEventData> onPointerExit; // 0x48

	// Methods

	// RVA: 0x19DF3D0 Offset: 0x19DF4D1 VA: 0x19DF3D0 Slot: 5
	private void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x19DF440 Offset: 0x19DF541 VA: 0x19DF440
	public IObservable<PointerEventData> OnPointerExitAsObservable() { }

	// RVA: 0x19DF4E0 Offset: 0x19DF5E1 VA: 0x19DF4E0 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DF540 Offset: 0x19DF641 VA: 0x19DF540
	public void .ctor() { }
}

