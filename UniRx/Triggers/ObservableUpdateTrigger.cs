// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x138A0 Offset: 0x139A1 VA: 0x138A0
public class ObservableUpdateTrigger : ObservableTriggerBase // TypeDefIndex: 6837
{
	// Fields
	private Subject<Unit> update; // 0x48

	// Methods

	// RVA: 0x19EAC90 Offset: 0x19EAD91 VA: 0x19EAC90
	private void Update() { }

	// RVA: 0x19E4830 Offset: 0x19E4931 VA: 0x19E4830
	public IObservable<Unit> UpdateAsObservable() { }

	// RVA: 0x19EAD90 Offset: 0x19EAE91 VA: 0x19EAD90 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19EADF0 Offset: 0x19EAEF1 VA: 0x19EADF0
	public void .ctor() { }
}

