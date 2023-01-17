// Namespace: 
private class FirstObservable.First<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6963
{
	// Fields
	private readonly FirstObservable<T> parent; // 0x0
	private bool notPublished; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FirstObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D6F00 Offset: 0x33D7001 VA: 0x33D6F00
	|-FirstObservable.First<ValueTuple<float, int>>..ctor
	|
	|-RVA: 0x33D7680 Offset: 0x33D7781 VA: 0x33D7680
	|-FirstObservable.First<ValueTuple<float, Int32Enum>>..ctor
	|
	|-RVA: 0x33D7E00 Offset: 0x33D7F01 VA: 0x33D7E00
	|-FirstObservable.First<long>..ctor
	|
	|-RVA: 0x33D8580 Offset: 0x33D8681 VA: 0x33D8580
	|-FirstObservable.First<object>..ctor
	|
	|-RVA: 0x33D8D00 Offset: 0x33D8E01 VA: 0x33D8D00
	|-FirstObservable.First<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D6F60 Offset: 0x33D7061 VA: 0x33D6F60
	|-FirstObservable.First<ValueTuple<float, int>>.OnNext
	|
	|-RVA: 0x33D76E0 Offset: 0x33D77E1 VA: 0x33D76E0
	|-FirstObservable.First<ValueTuple<float, Int32Enum>>.OnNext
	|
	|-RVA: 0x33D7E60 Offset: 0x33D7F61 VA: 0x33D7E60
	|-FirstObservable.First<long>.OnNext
	|
	|-RVA: 0x33D85E0 Offset: 0x33D86E1 VA: 0x33D85E0
	|-FirstObservable.First<object>.OnNext
	|
	|-RVA: 0x33D8D60 Offset: 0x33D8E61 VA: 0x33D8D60
	|-FirstObservable.First<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D7120 Offset: 0x33D7221 VA: 0x33D7120
	|-FirstObservable.First<ValueTuple<float, int>>.OnError
	|
	|-RVA: 0x33D78A0 Offset: 0x33D79A1 VA: 0x33D78A0
	|-FirstObservable.First<ValueTuple<float, Int32Enum>>.OnError
	|
	|-RVA: 0x33D8020 Offset: 0x33D8121 VA: 0x33D8020
	|-FirstObservable.First<long>.OnError
	|
	|-RVA: 0x33D87A0 Offset: 0x33D88A1 VA: 0x33D87A0
	|-FirstObservable.First<object>.OnError
	|
	|-RVA: 0x33D8F20 Offset: 0x33D9021 VA: 0x33D8F20
	|-FirstObservable.First<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D7260 Offset: 0x33D7361 VA: 0x33D7260
	|-FirstObservable.First<ValueTuple<float, int>>.OnCompleted
	|
	|-RVA: 0x33D79E0 Offset: 0x33D7AE1 VA: 0x33D79E0
	|-FirstObservable.First<ValueTuple<float, Int32Enum>>.OnCompleted
	|
	|-RVA: 0x33D8160 Offset: 0x33D8261 VA: 0x33D8160
	|-FirstObservable.First<long>.OnCompleted
	|
	|-RVA: 0x33D88E0 Offset: 0x33D89E1 VA: 0x33D88E0
	|-FirstObservable.First<object>.OnCompleted
	|
	|-RVA: 0x33D9060 Offset: 0x33D9161 VA: 0x33D9060
	|-FirstObservable.First<Unit>.OnCompleted
	*/
}

