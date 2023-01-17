// Namespace: 
private class TakeLastObservable.TakeLast<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7087
{
	// Fields
	private readonly TakeLastObservable<T> parent; // 0x0
	private readonly Queue<T> q; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TakeLastObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B98E0 Offset: 0x34B99E1 VA: 0x34B98E0
	|-TakeLastObservable.TakeLast<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B9990 Offset: 0x34B9A91 VA: 0x34B9990
	|-TakeLastObservable.TakeLast<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B9A30 Offset: 0x34B9B31 VA: 0x34B9A30
	|-TakeLastObservable.TakeLast<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B9AB0 Offset: 0x34B9BB1 VA: 0x34B9AB0
	|-TakeLastObservable.TakeLast<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B9BF0 Offset: 0x34B9CF1 VA: 0x34B9BF0
	|-TakeLastObservable.TakeLast<object>.OnCompleted
	*/
}

