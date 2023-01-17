// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x137D0 Offset: 0x138D1 VA: 0x137D0
public class ObservablePointerEnterTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerEnterHandler // TypeDefIndex: 6821
{
	// Fields
	private Subject<PointerEventData> onPointerEnter; // 0x48

	// Methods

	// RVA: 0x19DF250 Offset: 0x19DF351 VA: 0x19DF250 Slot: 5
	private void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x19DF2C0 Offset: 0x19DF3C1 VA: 0x19DF2C0
	public IObservable<PointerEventData> OnPointerEnterAsObservable() { }

	// RVA: 0x19DF360 Offset: 0x19DF461 VA: 0x19DF360 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DF3C0 Offset: 0x19DF4C1 VA: 0x19DF3C0
	public void .ctor() { }
}

