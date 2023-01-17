// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x136C0 Offset: 0x137C1 VA: 0x136C0
public class ObservableCollisionTrigger : ObservableTriggerBase // TypeDefIndex: 6804
{
	// Fields
	private Subject<Collision> onCollisionEnter; // 0x48
	private Subject<Collision> onCollisionExit; // 0x50
	private Subject<Collision> onCollisionStay; // 0x58

	// Methods

	// RVA: 0x19DAED0 Offset: 0x19DAFD1 VA: 0x19DAED0
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x19DAF40 Offset: 0x19DB041 VA: 0x19DAF40
	public IObservable<Collision> OnCollisionEnterAsObservable() { }

	// RVA: 0x19DAFE0 Offset: 0x19DB0E1 VA: 0x19DAFE0
	private void OnCollisionExit(Collision collisionInfo) { }

	// RVA: 0x19DB050 Offset: 0x19DB151 VA: 0x19DB050
	public IObservable<Collision> OnCollisionExitAsObservable() { }

	// RVA: 0x19DB0F0 Offset: 0x19DB1F1 VA: 0x19DB0F0
	private void OnCollisionStay(Collision collisionInfo) { }

	// RVA: 0x19DB160 Offset: 0x19DB261 VA: 0x19DB160
	public IObservable<Collision> OnCollisionStayAsObservable() { }

	// RVA: 0x19DB200 Offset: 0x19DB301 VA: 0x19DB200 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DB280 Offset: 0x19DB381 VA: 0x19DB280
	public void .ctor() { }
}

