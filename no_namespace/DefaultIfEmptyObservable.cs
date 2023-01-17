// Namespace: 
private class DefaultIfEmptyObservable.DefaultIfEmpty<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6924
{
	// Fields
	private readonly DefaultIfEmptyObservable<T> parent; // 0x0
	private bool hasValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DefaultIfEmptyObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25108D0 Offset: 0x25109D1 VA: 0x25108D0
	|-DefaultIfEmptyObservable.DefaultIfEmpty<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2510930 Offset: 0x2510A31 VA: 0x2510930
	|-DefaultIfEmptyObservable.DefaultIfEmpty<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25109E0 Offset: 0x2510AE1 VA: 0x25109E0
	|-DefaultIfEmptyObservable.DefaultIfEmpty<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2510B20 Offset: 0x2510C21 VA: 0x2510B20
	|-DefaultIfEmptyObservable.DefaultIfEmpty<object>.OnCompleted
	*/
}

