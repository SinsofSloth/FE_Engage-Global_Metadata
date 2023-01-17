// Namespace: 
private class SynchronizeObservable.Synchronize<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7081
{
	// Fields
	private readonly SynchronizeObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SynchronizeObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B28C0 Offset: 0x34B29C1 VA: 0x34B28C0
	|-SynchronizeObservable.Synchronize<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B2910 Offset: 0x34B2A11 VA: 0x34B2910
	|-SynchronizeObservable.Synchronize<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B2A70 Offset: 0x34B2B71 VA: 0x34B2A70
	|-SynchronizeObservable.Synchronize<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B2C50 Offset: 0x34B2D51 VA: 0x34B2C50
	|-SynchronizeObservable.Synchronize<object>.OnCompleted
	*/
}

