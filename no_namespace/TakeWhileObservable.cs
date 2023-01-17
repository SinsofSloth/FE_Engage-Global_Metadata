// Namespace: 
private class TakeWhileObservable.TakeWhile_<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7094
{
	// Fields
	private readonly TakeWhileObservable<T> parent; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TakeWhileObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C0070 Offset: 0x34C0171 VA: 0x34C0070
	|-TakeWhileObservable.TakeWhile_<long>..ctor
	|
	|-RVA: 0x34C0730 Offset: 0x34C0831 VA: 0x34C0730
	|-TakeWhileObservable.TakeWhile_<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C00C0 Offset: 0x34C01C1 VA: 0x34C00C0
	|-TakeWhileObservable.TakeWhile_<long>.Run
	|
	|-RVA: 0x34C0780 Offset: 0x34C0881 VA: 0x34C0780
	|-TakeWhileObservable.TakeWhile_<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C0160 Offset: 0x34C0261 VA: 0x34C0160
	|-TakeWhileObservable.TakeWhile_<long>.OnNext
	|
	|-RVA: 0x34C0820 Offset: 0x34C0921 VA: 0x34C0820
	|-TakeWhileObservable.TakeWhile_<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C04C0 Offset: 0x34C05C1 VA: 0x34C04C0
	|-TakeWhileObservable.TakeWhile_<long>.OnError
	|
	|-RVA: 0x34C0B80 Offset: 0x34C0C81 VA: 0x34C0B80
	|-TakeWhileObservable.TakeWhile_<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C0600 Offset: 0x34C0701 VA: 0x34C0600
	|-TakeWhileObservable.TakeWhile_<long>.OnCompleted
	|
	|-RVA: 0x34C0CC0 Offset: 0x34C0DC1 VA: 0x34C0CC0
	|-TakeWhileObservable.TakeWhile_<object>.OnCompleted
	*/
}

