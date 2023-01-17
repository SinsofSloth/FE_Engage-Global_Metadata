// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13710 Offset: 0x13811 VA: 0x13710
public class ObservableEnableTrigger : ObservableTriggerBase // TypeDefIndex: 6809
{
	// Fields
	private Subject<Unit> onEnable; // 0x48
	private Subject<Unit> onDisable; // 0x50

	// Methods

	// RVA: 0x19DBBC0 Offset: 0x19DBCC1 VA: 0x19DBBC0
	private void OnEnable() { }

	// RVA: 0x19DBCC0 Offset: 0x19DBDC1 VA: 0x19DBCC0
	public IObservable<Unit> OnEnableAsObservable() { }

	// RVA: 0x19DBD60 Offset: 0x19DBE61 VA: 0x19DBD60
	private void OnDisable() { }

	// RVA: 0x19DBE60 Offset: 0x19DBF61 VA: 0x19DBE60
	public IObservable<Unit> OnDisableAsObservable() { }

	// RVA: 0x19DBF00 Offset: 0x19DC001 VA: 0x19DBF00 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DBF70 Offset: 0x19DC071 VA: 0x19DBF70
	public void .ctor() { }
}

