// Namespace: 
private class DeferObservable.Defer<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6926
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2510E70 Offset: 0x2510F71 VA: 0x2510E70
	|-DeferObservable.Defer<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2510E90 Offset: 0x2510F91 VA: 0x2510E90
	|-DeferObservable.Defer<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2510FF0 Offset: 0x25110F1 VA: 0x2510FF0
	|-DeferObservable.Defer<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2511130 Offset: 0x2511231 VA: 0x2511130
	|-DeferObservable.Defer<object>.OnCompleted
	*/
}

