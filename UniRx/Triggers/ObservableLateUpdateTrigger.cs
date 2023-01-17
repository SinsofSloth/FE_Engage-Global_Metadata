// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13770 Offset: 0x13871 VA: 0x13770
public class ObservableLateUpdateTrigger : ObservableTriggerBase // TypeDefIndex: 6815
{
	// Fields
	private Subject<Unit> lateUpdate; // 0x48

	// Methods

	// RVA: 0x19DDAF0 Offset: 0x19DDBF1 VA: 0x19DDAF0
	private void LateUpdate() { }

	// RVA: 0x19DDBF0 Offset: 0x19DDCF1 VA: 0x19DDBF0
	public IObservable<Unit> LateUpdateAsObservable() { }

	// RVA: 0x19DDC90 Offset: 0x19DDD91 VA: 0x19DDC90 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DDCF0 Offset: 0x19DDDF1 VA: 0x19DDCF0
	public void .ctor() { }
}

