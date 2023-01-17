// Namespace: 
private class DoObservable.Do<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6944
{
	// Fields
	private readonly DoObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DoObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2632E80 Offset: 0x2632F81 VA: 0x2632E80
	|-DoObservable.Do<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2632ED0 Offset: 0x2632FD1 VA: 0x2632ED0
	|-DoObservable.Do<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2632F70 Offset: 0x2633071 VA: 0x2632F70
	|-DoObservable.Do<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26331D0 Offset: 0x26332D1 VA: 0x26331D0
	|-DoObservable.Do<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26334C0 Offset: 0x26335C1 VA: 0x26334C0
	|-DoObservable.Do<object>.OnCompleted
	*/
}

