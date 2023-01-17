// Namespace: 
private class ZipLatestObservable.ZipLatest<T1, T2, T3, T4, T5, T6, T7, TR> : NthZipLatestObserverBase<TR> // TypeDefIndex: 7191
{
	// Fields
	private readonly ZipLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> parent; // 0x0
	private readonly object gate; // 0x0
	private ZipLatestObserver<T1> c1; // 0x0
	private ZipLatestObserver<T2> c2; // 0x0
	private ZipLatestObserver<T3> c3; // 0x0
	private ZipLatestObserver<T4> c4; // 0x0
	private ZipLatestObserver<T5> c5; // 0x0
	private ZipLatestObserver<T6> c6; // 0x0
	private ZipLatestObserver<T7> c7; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, ZipLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF4A00 Offset: 0x3EF4B01 VA: 0x3EF4A00
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF4AD0 Offset: 0x3EF4BD1 VA: 0x3EF4AD0
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TR GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF5330 Offset: 0x3EF5431 VA: 0x3EF5330
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TR value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF5480 Offset: 0x3EF5581 VA: 0x3EF5480
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF5530 Offset: 0x3EF5631 VA: 0x3EF5530
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF5670 Offset: 0x3EF5771 VA: 0x3EF5670
	|-ZipLatestObservable.ZipLatest<object, object, object, object, object, object, object, object>.OnCompleted
	*/
}

