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

// Namespace: 
private class SelectObservable.Select_<T, TR> : OperatorObserverBase<T, TR> // TypeDefIndex: 7041
{
	// Fields
	private readonly SelectObservable<T, TR> parent; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SelectObservable<T, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3430910 Offset: 0x3430A11 VA: 0x3430910
	|-SelectObservable.Select_<bool, bool>..ctor
	|
	|-RVA: 0x3430E50 Offset: 0x3430F51 VA: 0x3430E50
	|-SelectObservable.Select_<object, bool>..ctor
	|
	|-RVA: 0x3431390 Offset: 0x3431491 VA: 0x3431390
	|-SelectObservable.Select_<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3430970 Offset: 0x3430A71 VA: 0x3430970
	|-SelectObservable.Select_<bool, bool>.OnNext
	|
	|-RVA: 0x3430EB0 Offset: 0x3430FB1 VA: 0x3430EB0
	|-SelectObservable.Select_<object, bool>.OnNext
	|
	|-RVA: 0x34313F0 Offset: 0x34314F1 VA: 0x34313F0
	|-SelectObservable.Select_<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3430BE0 Offset: 0x3430CE1 VA: 0x3430BE0
	|-SelectObservable.Select_<bool, bool>.OnError
	|
	|-RVA: 0x3431120 Offset: 0x3431221 VA: 0x3431120
	|-SelectObservable.Select_<object, bool>.OnError
	|
	|-RVA: 0x3431660 Offset: 0x3431761 VA: 0x3431660
	|-SelectObservable.Select_<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3430D20 Offset: 0x3430E21 VA: 0x3430D20
	|-SelectObservable.Select_<bool, bool>.OnCompleted
	|
	|-RVA: 0x3431260 Offset: 0x3431361 VA: 0x3431260
	|-SelectObservable.Select_<object, bool>.OnCompleted
	|
	|-RVA: 0x34317A0 Offset: 0x34318A1 VA: 0x34317A0
	|-SelectObservable.Select_<object, object>.OnCompleted
	*/
}

