// Namespace: 
private class TakeObservable.Take_<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7085
{
	// Fields
	private readonly TakeObservable<T> parent; // 0x0
	private readonly object gate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TakeObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C0DF0 Offset: 0x34C0EF1 VA: 0x34C0DF0
	|-TakeObservable.Take_<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x34C1730 Offset: 0x34C1831 VA: 0x34C1730
	|-TakeObservable.Take_<long>..ctor
	|
	|-RVA: 0x34C2060 Offset: 0x34C2161 VA: 0x34C2060
	|-TakeObservable.Take_<object>..ctor
	|
	|-RVA: 0x34C2990 Offset: 0x34C2A91 VA: 0x34C2990
	|-TakeObservable.Take_<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C0EB0 Offset: 0x34C0FB1 VA: 0x34C0EB0
	|-TakeObservable.Take_<ValueTuple<object, object>>.Run
	|
	|-RVA: 0x34C17F0 Offset: 0x34C18F1 VA: 0x34C17F0
	|-TakeObservable.Take_<long>.Run
	|
	|-RVA: 0x34C2120 Offset: 0x34C2221 VA: 0x34C2120
	|-TakeObservable.Take_<object>.Run
	|
	|-RVA: 0x34C2A50 Offset: 0x34C2B51 VA: 0x34C2A50
	|-TakeObservable.Take_<Unit>.Run
	*/

	// RVA: -1 Offset: -1
	private void Tick() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C1040 Offset: 0x34C1141 VA: 0x34C1040
	|-TakeObservable.Take_<ValueTuple<object, object>>.Tick
	|
	|-RVA: 0x34C1980 Offset: 0x34C1A81 VA: 0x34C1980
	|-TakeObservable.Take_<long>.Tick
	|
	|-RVA: 0x34C22B0 Offset: 0x34C23B1 VA: 0x34C22B0
	|-TakeObservable.Take_<object>.Tick
	|
	|-RVA: 0x34C2BE0 Offset: 0x34C2CE1 VA: 0x34C2BE0
	|-TakeObservable.Take_<Unit>.Tick
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C1210 Offset: 0x34C1311 VA: 0x34C1210
	|-TakeObservable.Take_<ValueTuple<object, object>>.OnNext
	|
	|-RVA: 0x34C1B50 Offset: 0x34C1C51 VA: 0x34C1B50
	|-TakeObservable.Take_<long>.OnNext
	|
	|-RVA: 0x34C2480 Offset: 0x34C2581 VA: 0x34C2480
	|-TakeObservable.Take_<object>.OnNext
	|
	|-RVA: 0x34C2DB0 Offset: 0x34C2EB1 VA: 0x34C2DB0
	|-TakeObservable.Take_<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C1380 Offset: 0x34C1481 VA: 0x34C1380
	|-TakeObservable.Take_<ValueTuple<object, object>>.OnError
	|
	|-RVA: 0x34C1CB0 Offset: 0x34C1DB1 VA: 0x34C1CB0
	|-TakeObservable.Take_<long>.OnError
	|
	|-RVA: 0x34C25E0 Offset: 0x34C26E1 VA: 0x34C25E0
	|-TakeObservable.Take_<object>.OnError
	|
	|-RVA: 0x34C2F10 Offset: 0x34C3011 VA: 0x34C2F10
	|-TakeObservable.Take_<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C1560 Offset: 0x34C1661 VA: 0x34C1560
	|-TakeObservable.Take_<ValueTuple<object, object>>.OnCompleted
	|
	|-RVA: 0x34C1E90 Offset: 0x34C1F91 VA: 0x34C1E90
	|-TakeObservable.Take_<long>.OnCompleted
	|
	|-RVA: 0x34C27C0 Offset: 0x34C28C1 VA: 0x34C27C0
	|-TakeObservable.Take_<object>.OnCompleted
	|
	|-RVA: 0x34C30F0 Offset: 0x34C31F1 VA: 0x34C30F0
	|-TakeObservable.Take_<Unit>.OnCompleted
	*/
}

