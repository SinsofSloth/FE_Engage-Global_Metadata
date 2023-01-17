// Namespace: UniRx.Operators
internal class FirstObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6965
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly bool useDefault; // 0x0
	private readonly Func<T, bool> predicate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, bool useDefault) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D9480 Offset: 0x33D9581 VA: 0x33D9480
	|-FirstObservable<ValueTuple<float, int>>..ctor
	|
	|-RVA: 0x33D9730 Offset: 0x33D9831 VA: 0x33D9730
	|-FirstObservable<ValueTuple<float, Int32Enum>>..ctor
	|
	|-RVA: 0x33D99E0 Offset: 0x33D9AE1 VA: 0x33D99E0
	|-FirstObservable<long>..ctor
	|
	|-RVA: 0x33D9C90 Offset: 0x33D9D91 VA: 0x33D9C90
	|-FirstObservable<object>..ctor
	|
	|-RVA: 0x33D9F40 Offset: 0x33DA041 VA: 0x33D9F40
	|-FirstObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<T, bool> predicate, bool useDefault) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D9500 Offset: 0x33D9601 VA: 0x33D9500
	|-FirstObservable<ValueTuple<float, int>>..ctor
	|
	|-RVA: 0x33D97B0 Offset: 0x33D98B1 VA: 0x33D97B0
	|-FirstObservable<ValueTuple<float, Int32Enum>>..ctor
	|
	|-RVA: 0x33D9A60 Offset: 0x33D9B61 VA: 0x33D9A60
	|-FirstObservable<long>..ctor
	|
	|-RVA: 0x33D9D10 Offset: 0x33D9E11 VA: 0x33D9D10
	|-FirstObservable<object>..ctor
	|
	|-RVA: 0x33D9FC0 Offset: 0x33DA0C1 VA: 0x33D9FC0
	|-FirstObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D95A0 Offset: 0x33D96A1 VA: 0x33D95A0
	|-FirstObservable<ValueTuple<float, int>>.SubscribeCore
	|
	|-RVA: 0x33D9850 Offset: 0x33D9951 VA: 0x33D9850
	|-FirstObservable<ValueTuple<float, Int32Enum>>.SubscribeCore
	|
	|-RVA: 0x33D9B00 Offset: 0x33D9C01 VA: 0x33D9B00
	|-FirstObservable<long>.SubscribeCore
	|
	|-RVA: 0x33D9DB0 Offset: 0x33D9EB1 VA: 0x33D9DB0
	|-FirstObservable<object>.SubscribeCore
	|
	|-RVA: 0x33DA060 Offset: 0x33DA161 VA: 0x33DA060
	|-FirstObservable<Unit>.SubscribeCore
	*/
}

