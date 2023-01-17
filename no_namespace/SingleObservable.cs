// Namespace: 
private class SingleObservable.Single<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7059
{
	// Fields
	private readonly SingleObservable<T> parent; // 0x0
	private bool seenValue; // 0x0
	private T lastValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SingleObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3436790 Offset: 0x3436891 VA: 0x3436790
	|-SingleObservable.Single<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34367F0 Offset: 0x34368F1 VA: 0x34367F0
	|-SingleObservable.Single<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34369B0 Offset: 0x3436AB1 VA: 0x34369B0
	|-SingleObservable.Single<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3436AF0 Offset: 0x3436BF1 VA: 0x3436AF0
	|-SingleObservable.Single<object>.OnCompleted
	*/
}

