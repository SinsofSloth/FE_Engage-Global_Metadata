// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13750 Offset: 0x13851 VA: 0x13750
public class ObservableInitializePotentialDragTrigger : ObservableTriggerBase, IEventSystemHandler, IInitializePotentialDragHandler // TypeDefIndex: 6813
{
	// Fields
	private Subject<PointerEventData> onInitializePotentialDrag; // 0x48

	// Methods

	// RVA: 0x19DD6C0 Offset: 0x19DD7C1 VA: 0x19DD6C0 Slot: 5
	private void UnityEngine.EventSystems.IInitializePotentialDragHandler.OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x19DD730 Offset: 0x19DD831 VA: 0x19DD730
	public IObservable<PointerEventData> OnInitializePotentialDragAsObservable() { }

	// RVA: 0x19DD7D0 Offset: 0x19DD8D1 VA: 0x19DD7D0 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DD830 Offset: 0x19DD931 VA: 0x19DD830
	public void .ctor() { }
}

