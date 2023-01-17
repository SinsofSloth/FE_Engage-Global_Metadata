// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x136B0 Offset: 0x137B1 VA: 0x136B0
public class ObservableCollision2DTrigger : ObservableTriggerBase // TypeDefIndex: 6803
{
	// Fields
	private Subject<Collision2D> onCollisionEnter2D; // 0x48
	private Subject<Collision2D> onCollisionExit2D; // 0x50
	private Subject<Collision2D> onCollisionStay2D; // 0x58

	// Methods

	// RVA: 0x19DAB10 Offset: 0x19DAC11 VA: 0x19DAB10
	private void OnCollisionEnter2D(Collision2D coll) { }

	// RVA: 0x19DAB80 Offset: 0x19DAC81 VA: 0x19DAB80
	public IObservable<Collision2D> OnCollisionEnter2DAsObservable() { }

	// RVA: 0x19DAC20 Offset: 0x19DAD21 VA: 0x19DAC20
	private void OnCollisionExit2D(Collision2D coll) { }

	// RVA: 0x19DAC90 Offset: 0x19DAD91 VA: 0x19DAC90
	public IObservable<Collision2D> OnCollisionExit2DAsObservable() { }

	// RVA: 0x19DAD30 Offset: 0x19DAE31 VA: 0x19DAD30
	private void OnCollisionStay2D(Collision2D coll) { }

	// RVA: 0x19DADA0 Offset: 0x19DAEA1 VA: 0x19DADA0
	public IObservable<Collision2D> OnCollisionStay2DAsObservable() { }

	// RVA: 0x19DAE40 Offset: 0x19DAF41 VA: 0x19DAE40 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19DAEC0 Offset: 0x19DAFC1 VA: 0x19DAEC0
	public void .ctor() { }
}

