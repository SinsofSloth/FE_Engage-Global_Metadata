// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13790 Offset: 0x13891 VA: 0x13790
public class ObservableMoveTrigger : ObservableTriggerBase, IEventSystemHandler, IMoveHandler // TypeDefIndex: 6817
{
	// Fields
	private Subject<AxisEventData> onMove; // 0x48

	// Methods

	// RVA: 0x19DEA90 Offset: 0x19DEB91 VA: 0x19DEA90 Slot: 5
	private void UnityEngine.EventSystems.IMoveHandler.OnMove(AxisEventData eventData) { }

	// RVA: 0x19DEB00 Offset: 0x19DEC01 VA: 0x19DEB00
	public IObservable<AxisEventData> OnMoveAsObservable() { }

	// RVA: 0x19DEBA0 Offset: 0x19DECA1 VA: 0x19DEBA0 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DEC00 Offset: 0x19DED01 VA: 0x19DEC00
	public void .ctor() { }
}

