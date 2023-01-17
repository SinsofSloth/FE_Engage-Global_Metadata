// Namespace: 
private class FirstObservable.First_<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6964
{
	// Fields
	private readonly FirstObservable<T> parent; // 0x0
	private bool notPublished; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FirstObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DA880 Offset: 0x33DA981 VA: 0x33DA880
	|-FirstObservable.First_<ValueTuple<float, int>>..ctor
	|
	|-RVA: 0x33DB1A0 Offset: 0x33DB2A1 VA: 0x33DB1A0
	|-FirstObservable.First_<ValueTuple<float, Int32Enum>>..ctor
	|
	|-RVA: 0x33DBAC0 Offset: 0x33DBBC1 VA: 0x33DBAC0
	|-FirstObservable.First_<long>..ctor
	|
	|-RVA: 0x33DC3E0 Offset: 0x33DC4E1 VA: 0x33DC3E0
	|-FirstObservable.First_<object>..ctor
	|
	|-RVA: 0x33DCD00 Offset: 0x33DCE01 VA: 0x33DCD00
	|-FirstObservable.First_<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DA8E0 Offset: 0x33DA9E1 VA: 0x33DA8E0
	|-FirstObservable.First_<ValueTuple<float, int>>.OnNext
	|
	|-RVA: 0x33DB200 Offset: 0x33DB301 VA: 0x33DB200
	|-FirstObservable.First_<ValueTuple<float, Int32Enum>>.OnNext
	|
	|-RVA: 0x33DBB20 Offset: 0x33DBC21 VA: 0x33DBB20
	|-FirstObservable.First_<long>.OnNext
	|
	|-RVA: 0x33DC440 Offset: 0x33DC541 VA: 0x33DC440
	|-FirstObservable.First_<object>.OnNext
	|
	|-RVA: 0x33DCD60 Offset: 0x33DCE61 VA: 0x33DCD60
	|-FirstObservable.First_<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DAC40 Offset: 0x33DAD41 VA: 0x33DAC40
	|-FirstObservable.First_<ValueTuple<float, int>>.OnError
	|
	|-RVA: 0x33DB560 Offset: 0x33DB661 VA: 0x33DB560
	|-FirstObservable.First_<ValueTuple<float, Int32Enum>>.OnError
	|
	|-RVA: 0x33DBE80 Offset: 0x33DBF81 VA: 0x33DBE80
	|-FirstObservable.First_<long>.OnError
	|
	|-RVA: 0x33DC7A0 Offset: 0x33DC8A1 VA: 0x33DC7A0
	|-FirstObservable.First_<object>.OnError
	|
	|-RVA: 0x33DD0C0 Offset: 0x33DD1C1 VA: 0x33DD0C0
	|-FirstObservable.First_<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DAD80 Offset: 0x33DAE81 VA: 0x33DAD80
	|-FirstObservable.First_<ValueTuple<float, int>>.OnCompleted
	|
	|-RVA: 0x33DB6A0 Offset: 0x33DB7A1 VA: 0x33DB6A0
	|-FirstObservable.First_<ValueTuple<float, Int32Enum>>.OnCompleted
	|
	|-RVA: 0x33DBFC0 Offset: 0x33DC0C1 VA: 0x33DBFC0
	|-FirstObservable.First_<long>.OnCompleted
	|
	|-RVA: 0x33DC8E0 Offset: 0x33DC9E1 VA: 0x33DC8E0
	|-FirstObservable.First_<object>.OnCompleted
	|
	|-RVA: 0x33DD200 Offset: 0x33DD301 VA: 0x33DD200
	|-FirstObservable.First_<Unit>.OnCompleted
	*/
}

