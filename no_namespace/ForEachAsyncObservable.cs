// Namespace: 
private class ForEachAsyncObservable.ForEachAsync<T> : OperatorObserverBase<T, Unit> // TypeDefIndex: 6966
{
	// Fields
	private readonly ForEachAsyncObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ForEachAsyncObservable<T> parent, IObserver<Unit> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DD860 Offset: 0x33DD961 VA: 0x33DD860
	|-ForEachAsyncObservable.ForEachAsync<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DD8B0 Offset: 0x33DD9B1 VA: 0x33DD8B0
	|-ForEachAsyncObservable.ForEachAsync<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DDA80 Offset: 0x33DDB81 VA: 0x33DDA80
	|-ForEachAsyncObservable.ForEachAsync<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DDBD0 Offset: 0x33DDCD1 VA: 0x33DDBD0
	|-ForEachAsyncObservable.ForEachAsync<object>.OnCompleted
	*/
}

