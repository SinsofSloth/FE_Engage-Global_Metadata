// Namespace: 
private class DoOnTerminateObservable.DoOnTerminate<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6952
{
	// Fields
	private readonly DoOnTerminateObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DoOnTerminateObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2635E30 Offset: 0x2635F31 VA: 0x2635E30
	|-DoOnTerminateObservable.DoOnTerminate<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2635E80 Offset: 0x2635F81 VA: 0x2635E80
	|-DoOnTerminateObservable.DoOnTerminate<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2635F20 Offset: 0x2636021 VA: 0x2635F20
	|-DoOnTerminateObservable.DoOnTerminate<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2635FD0 Offset: 0x26360D1 VA: 0x2635FD0
	|-DoOnTerminateObservable.DoOnTerminate<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2636290 Offset: 0x2636391 VA: 0x2636290
	|-DoOnTerminateObservable.DoOnTerminate<object>.OnCompleted
	*/
}

