// Namespace: 
private class DoOnCompletedObservable.DoOnCompleted<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6950
{
	// Fields
	private readonly DoOnCompletedObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DoOnCompletedObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26349C0 Offset: 0x2634AC1 VA: 0x26349C0
	|-DoOnCompletedObservable.DoOnCompleted<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634A10 Offset: 0x2634B11 VA: 0x2634A10
	|-DoOnCompletedObservable.DoOnCompleted<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634AB0 Offset: 0x2634BB1 VA: 0x2634AB0
	|-DoOnCompletedObservable.DoOnCompleted<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634B60 Offset: 0x2634C61 VA: 0x2634B60
	|-DoOnCompletedObservable.DoOnCompleted<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2634CA0 Offset: 0x2634DA1 VA: 0x2634CA0
	|-DoOnCompletedObservable.DoOnCompleted<object>.OnCompleted
	*/
}

