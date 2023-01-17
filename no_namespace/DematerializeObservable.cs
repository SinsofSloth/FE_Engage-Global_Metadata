// Namespace: 
private class DematerializeObservable.Dematerialize<T> : OperatorObserverBase<Notification<T>, T> // TypeDefIndex: 6934
{
	// Fields
	private readonly DematerializeObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DematerializeObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518170 Offset: 0x2518271 VA: 0x2518170
	|-DematerializeObservable.Dematerialize<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25181C0 Offset: 0x25182C1 VA: 0x25181C0
	|-DematerializeObservable.Dematerialize<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(Notification<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518260 Offset: 0x2518361 VA: 0x2518260
	|-DematerializeObservable.Dematerialize<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518570 Offset: 0x2518671 VA: 0x2518570
	|-DematerializeObservable.Dematerialize<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25186B0 Offset: 0x25187B1 VA: 0x25186B0
	|-DematerializeObservable.Dematerialize<object>.OnCompleted
	*/
}

