// Namespace: 
private class TakeObservable.Take<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7084
{
	// Fields
	private int rest; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TakeObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B8690 Offset: 0x34B8791 VA: 0x34B8690
	|-TakeObservable.Take<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x34B8B30 Offset: 0x34B8C31 VA: 0x34B8B30
	|-TakeObservable.Take<long>..ctor
	|
	|-RVA: 0x34B8FC0 Offset: 0x34B90C1 VA: 0x34B8FC0
	|-TakeObservable.Take<object>..ctor
	|
	|-RVA: 0x34B9450 Offset: 0x34B9551 VA: 0x34B9450
	|-TakeObservable.Take<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B86E0 Offset: 0x34B87E1 VA: 0x34B86E0
	|-TakeObservable.Take<ValueTuple<object, object>>.OnNext
	|
	|-RVA: 0x34B8B80 Offset: 0x34B8C81 VA: 0x34B8B80
	|-TakeObservable.Take<long>.OnNext
	|
	|-RVA: 0x34B9010 Offset: 0x34B9111 VA: 0x34B9010
	|-TakeObservable.Take<object>.OnNext
	|
	|-RVA: 0x34B94A0 Offset: 0x34B95A1 VA: 0x34B94A0
	|-TakeObservable.Take<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B88C0 Offset: 0x34B89C1 VA: 0x34B88C0
	|-TakeObservable.Take<ValueTuple<object, object>>.OnError
	|
	|-RVA: 0x34B8D50 Offset: 0x34B8E51 VA: 0x34B8D50
	|-TakeObservable.Take<long>.OnError
	|
	|-RVA: 0x34B91E0 Offset: 0x34B92E1 VA: 0x34B91E0
	|-TakeObservable.Take<object>.OnError
	|
	|-RVA: 0x34B9670 Offset: 0x34B9771 VA: 0x34B9670
	|-TakeObservable.Take<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B8A00 Offset: 0x34B8B01 VA: 0x34B8A00
	|-TakeObservable.Take<ValueTuple<object, object>>.OnCompleted
	|
	|-RVA: 0x34B8E90 Offset: 0x34B8F91 VA: 0x34B8E90
	|-TakeObservable.Take<long>.OnCompleted
	|
	|-RVA: 0x34B9320 Offset: 0x34B9421 VA: 0x34B9320
	|-TakeObservable.Take<object>.OnCompleted
	|
	|-RVA: 0x34B97B0 Offset: 0x34B98B1 VA: 0x34B97B0
	|-TakeObservable.Take<Unit>.OnCompleted
	*/
}

