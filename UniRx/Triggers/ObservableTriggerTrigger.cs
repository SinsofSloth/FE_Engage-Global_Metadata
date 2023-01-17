// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13880 Offset: 0x13981 VA: 0x13880
public class ObservableTriggerTrigger : ObservableTriggerBase // TypeDefIndex: 6835
{
	// Fields
	private Subject<Collider> onTriggerEnter; // 0x48
	private Subject<Collider> onTriggerExit; // 0x50
	private Subject<Collider> onTriggerStay; // 0x58

	// Methods

	// RVA: 0x19EA9D0 Offset: 0x19EAAD1 VA: 0x19EA9D0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x19E4170 Offset: 0x19E4271 VA: 0x19E4170
	public IObservable<Collider> OnTriggerEnterAsObservable() { }

	// RVA: 0x19EAA40 Offset: 0x19EAB41 VA: 0x19EAA40
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x19E43B0 Offset: 0x19E44B1 VA: 0x19E43B0
	public IObservable<Collider> OnTriggerExitAsObservable() { }

	// RVA: 0x19EAAB0 Offset: 0x19EABB1 VA: 0x19EAAB0
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x19E45F0 Offset: 0x19E46F1 VA: 0x19E45F0
	public IObservable<Collider> OnTriggerStayAsObservable() { }

	// RVA: 0x19EAB20 Offset: 0x19EAC21 VA: 0x19EAB20 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19EABA0 Offset: 0x19EACA1 VA: 0x19EABA0
	public void .ctor() { }
}

