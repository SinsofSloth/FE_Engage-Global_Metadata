// Namespace: 
private class TimestampObservable.Timestamp<T> : OperatorObserverBase<T, Timestamped<T>> // TypeDefIndex: 7116
{
	// Fields
	private readonly TimestampObservable<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TimestampObservable<T> parent, IObserver<Timestamped<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399FFA0 Offset: 0x39A00A1 VA: 0x399FFA0
	|-TimestampObservable.Timestamp<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399FFF0 Offset: 0x39A00F1 VA: 0x399FFF0
	|-TimestampObservable.Timestamp<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A0180 Offset: 0x39A0281 VA: 0x39A0180
	|-TimestampObservable.Timestamp<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A02C0 Offset: 0x39A03C1 VA: 0x39A02C0
	|-TimestampObservable.Timestamp<object>.OnCompleted
	*/
}

