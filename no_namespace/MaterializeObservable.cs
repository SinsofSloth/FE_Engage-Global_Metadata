// Namespace: 
private class MaterializeObservable.Materialize<T> : OperatorObserverBase<T, Notification<T>> // TypeDefIndex: 6987
{
	// Fields
	private readonly MaterializeObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MaterializeObservable<T> parent, IObserver<Notification<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2939C20 Offset: 0x2939D21 VA: 0x2939C20
	|-MaterializeObservable.Materialize<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2939C70 Offset: 0x2939D71 VA: 0x2939C70
	|-MaterializeObservable.Materialize<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2939D10 Offset: 0x2939E11 VA: 0x2939D10
	|-MaterializeObservable.Materialize<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2939DD0 Offset: 0x2939ED1 VA: 0x2939DD0
	|-MaterializeObservable.Materialize<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2939FA0 Offset: 0x293A0A1 VA: 0x2939FA0
	|-MaterializeObservable.Materialize<object>.OnCompleted
	*/
}

