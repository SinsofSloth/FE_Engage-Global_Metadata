// Namespace: 
private class WhereSelectObservable.WhereSelect<T, TR> : OperatorObserverBase<T, TR> // TypeDefIndex: 7140
{
	// Fields
	private readonly WhereSelectObservable<T, TR> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(WhereSelectObservable<T, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CA040 Offset: 0x39CA141 VA: 0x39CA040
	|-WhereSelectObservable.WhereSelect<bool, bool>..ctor
	|
	|-RVA: 0x39CA6F0 Offset: 0x39CA7F1 VA: 0x39CA6F0
	|-WhereSelectObservable.WhereSelect<object, bool>..ctor
	|
	|-RVA: 0x39CADA0 Offset: 0x39CAEA1 VA: 0x39CADA0
	|-WhereSelectObservable.WhereSelect<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CA090 Offset: 0x39CA191 VA: 0x39CA090
	|-WhereSelectObservable.WhereSelect<bool, bool>.OnNext
	|
	|-RVA: 0x39CA740 Offset: 0x39CA841 VA: 0x39CA740
	|-WhereSelectObservable.WhereSelect<object, bool>.OnNext
	|
	|-RVA: 0x39CADF0 Offset: 0x39CAEF1 VA: 0x39CADF0
	|-WhereSelectObservable.WhereSelect<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CA480 Offset: 0x39CA581 VA: 0x39CA480
	|-WhereSelectObservable.WhereSelect<bool, bool>.OnError
	|
	|-RVA: 0x39CAB30 Offset: 0x39CAC31 VA: 0x39CAB30
	|-WhereSelectObservable.WhereSelect<object, bool>.OnError
	|
	|-RVA: 0x39CB1E0 Offset: 0x39CB2E1 VA: 0x39CB1E0
	|-WhereSelectObservable.WhereSelect<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CA5C0 Offset: 0x39CA6C1 VA: 0x39CA5C0
	|-WhereSelectObservable.WhereSelect<bool, bool>.OnCompleted
	|
	|-RVA: 0x39CAC70 Offset: 0x39CAD71 VA: 0x39CAC70
	|-WhereSelectObservable.WhereSelect<object, bool>.OnCompleted
	|
	|-RVA: 0x39CB320 Offset: 0x39CB421 VA: 0x39CB320
	|-WhereSelectObservable.WhereSelect<object, object>.OnCompleted
	*/
}

