// Namespace: 
private class DoOnErrorObservable.DoOnError<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6948
{
	// Fields
	private readonly DoOnErrorObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DoOnErrorObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2635020 Offset: 0x2635121 VA: 0x2635020
	|-DoOnErrorObservable.DoOnError<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2635070 Offset: 0x2635171 VA: 0x2635070
	|-DoOnErrorObservable.DoOnError<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2635110 Offset: 0x2635211 VA: 0x2635110
	|-DoOnErrorObservable.DoOnError<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26351C0 Offset: 0x26352C1 VA: 0x26351C0
	|-DoOnErrorObservable.DoOnError<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26354B0 Offset: 0x26355B1 VA: 0x26354B0
	|-DoOnErrorObservable.DoOnError<object>.OnCompleted
	*/
}

