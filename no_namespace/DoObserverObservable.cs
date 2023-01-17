// Namespace: 
private class DoObserverObservable.Do<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6946
{
	// Fields
	private readonly DoObserverObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DoObserverObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2633720 Offset: 0x2633821 VA: 0x2633720
	|-DoObserverObservable.Do<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2633770 Offset: 0x2633871 VA: 0x2633770
	|-DoObserverObservable.Do<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2633810 Offset: 0x2633911 VA: 0x2633810
	|-DoObserverObservable.Do<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2633AD0 Offset: 0x2633BD1 VA: 0x2633AD0
	|-DoObserverObservable.Do<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2633E10 Offset: 0x2633F11 VA: 0x2633E10
	|-DoObserverObservable.Do<object>.OnCompleted
	*/
}

