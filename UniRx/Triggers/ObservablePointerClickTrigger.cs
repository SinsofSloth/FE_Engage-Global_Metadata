// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x137B0 Offset: 0x138B1 VA: 0x137B0
public class ObservablePointerClickTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerClickHandler // TypeDefIndex: 6819
{
	// Fields
	private Subject<PointerEventData> onPointerClick; // 0x48

	// Methods

	// RVA: 0x19DEF50 Offset: 0x19DF051 VA: 0x19DEF50 Slot: 5
	private void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x19DEFC0 Offset: 0x19DF0C1 VA: 0x19DEFC0
	public IObservable<PointerEventData> OnPointerClickAsObservable() { }

	// RVA: 0x19DF060 Offset: 0x19DF161 VA: 0x19DF060 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DF0C0 Offset: 0x19DF1C1 VA: 0x19DF0C0
	public void .ctor() { }
}

