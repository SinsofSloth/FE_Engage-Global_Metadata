// Namespace: 
private class ForEachAsyncObservable.ForEachAsync_<T> : OperatorObserverBase<T, Unit> // TypeDefIndex: 6967
{
	// Fields
	private readonly ForEachAsyncObservable<T> parent; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ForEachAsyncObservable<T> parent, IObserver<Unit> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DE0F0 Offset: 0x33DE1F1 VA: 0x33DE0F0
	|-ForEachAsyncObservable.ForEachAsync_<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DE140 Offset: 0x33DE241 VA: 0x33DE140
	|-ForEachAsyncObservable.ForEachAsync_<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DE310 Offset: 0x33DE411 VA: 0x33DE310
	|-ForEachAsyncObservable.ForEachAsync_<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DE460 Offset: 0x33DE561 VA: 0x33DE460
	|-ForEachAsyncObservable.ForEachAsync_<object>.OnCompleted
	*/
}

