// Namespace: 
private class SelectObservable.Select<T, TR> : OperatorObserverBase<T, TR> // TypeDefIndex: 7040
{
	// Fields
	private readonly SelectObservable<T, TR> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SelectObservable<T, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3002550 Offset: 0x3002651 VA: 0x3002550
	|-SelectObservable.Select<bool, bool>..ctor
	|
	|-RVA: 0x3002A70 Offset: 0x3002B71 VA: 0x3002A70
	|-SelectObservable.Select<object, bool>..ctor
	|
	|-RVA: 0x3002F90 Offset: 0x3003091 VA: 0x3002F90
	|-SelectObservable.Select<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30025A0 Offset: 0x30026A1 VA: 0x30025A0
	|-SelectObservable.Select<bool, bool>.OnNext
	|
	|-RVA: 0x3002AC0 Offset: 0x3002BC1 VA: 0x3002AC0
	|-SelectObservable.Select<object, bool>.OnNext
	|
	|-RVA: 0x3002FE0 Offset: 0x30030E1 VA: 0x3002FE0
	|-SelectObservable.Select<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3002800 Offset: 0x3002901 VA: 0x3002800
	|-SelectObservable.Select<bool, bool>.OnError
	|
	|-RVA: 0x3002D20 Offset: 0x3002E21 VA: 0x3002D20
	|-SelectObservable.Select<object, bool>.OnError
	|
	|-RVA: 0x3003240 Offset: 0x3003341 VA: 0x3003240
	|-SelectObservable.Select<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3002940 Offset: 0x3002A41 VA: 0x3002940
	|-SelectObservable.Select<bool, bool>.OnCompleted
	|
	|-RVA: 0x3002E60 Offset: 0x3002F61 VA: 0x3002E60
	|-SelectObservable.Select<object, bool>.OnCompleted
	|
	|-RVA: 0x3003380 Offset: 0x3003481 VA: 0x3003380
	|-SelectObservable.Select<object, object>.OnCompleted
	*/
}

