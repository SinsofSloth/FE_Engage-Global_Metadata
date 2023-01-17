// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x136D0 Offset: 0x137D1 VA: 0x136D0
public class ObservableDeselectTrigger : ObservableTriggerBase, IEventSystemHandler, IDeselectHandler // TypeDefIndex: 6805
{
	// Fields
	private Subject<BaseEventData> onDeselect; // 0x48

	// Methods

	// RVA: 0x19DB290 Offset: 0x19DB391 VA: 0x19DB290 Slot: 5
	private void UnityEngine.EventSystems.IDeselectHandler.OnDeselect(BaseEventData eventData) { }

	// RVA: 0x19DB300 Offset: 0x19DB401 VA: 0x19DB300
	public IObservable<BaseEventData> OnDeselectAsObservable() { }

	// RVA: 0x19DB3A0 Offset: 0x19DB4A1 VA: 0x19DB3A0 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DB400 Offset: 0x19DB501 VA: 0x19DB400
	public void .ctor() { }
}

