// Namespace: UniRx.Triggers
[DisallowMultipleComponent] // RVA: 0x13860 Offset: 0x13961 VA: 0x13860
public class ObservableTrigger2DTrigger : ObservableTriggerBase // TypeDefIndex: 6832
{
	// Fields
	private Subject<Collider2D> onTriggerEnter2D; // 0x48
	private Subject<Collider2D> onTriggerExit2D; // 0x50
	private Subject<Collider2D> onTriggerStay2D; // 0x58

	// Methods

	// RVA: 0x19E0D50 Offset: 0x19E0E51 VA: 0x19E0D50
	private void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x19E0DC0 Offset: 0x19E0EC1 VA: 0x19E0DC0
	public IObservable<Collider2D> OnTriggerEnter2DAsObservable() { }

	// RVA: 0x19E0E60 Offset: 0x19E0F61 VA: 0x19E0E60
	private void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x19E0ED0 Offset: 0x19E0FD1 VA: 0x19E0ED0
	public IObservable<Collider2D> OnTriggerExit2DAsObservable() { }

	// RVA: 0x19E0F70 Offset: 0x19E1071 VA: 0x19E0F70
	private void OnTriggerStay2D(Collider2D other) { }

	// RVA: 0x19E0FE0 Offset: 0x19E10E1 VA: 0x19E0FE0
	public IObservable<Collider2D> OnTriggerStay2DAsObservable() { }

	// RVA: 0x19E1080 Offset: 0x19E1181 VA: 0x19E1080 Slot: 4
	protected override void RaiseOnCompletedOnDestroy() { }

	// RVA: 0x19E1100 Offset: 0x19E1201 VA: 0x19E1100
	public void .ctor() { }
}

