// Namespace: 
private class ZipLatestObservable.ZipLatest.LeftObserver<TLeft, TRight, TResult> : IObserver<TLeft> // TypeDefIndex: 7176
{
	// Fields
	private readonly ZipLatestObservable.ZipLatest<TLeft, TRight, TResult> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipLatestObservable.ZipLatest<TLeft, TRight, TResult> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD4E70 Offset: 0x2AD4F71 VA: 0x2AD4E70
	|-ZipLatestObservable.ZipLatest.LeftObserver<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TLeft value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD4EB0 Offset: 0x2AD4FB1 VA: 0x2AD4EB0
	|-ZipLatestObservable.ZipLatest.LeftObserver<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD4FC0 Offset: 0x2AD50C1 VA: 0x2AD4FC0
	|-ZipLatestObservable.ZipLatest.LeftObserver<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD50B0 Offset: 0x2AD51B1 VA: 0x2AD50B0
	|-ZipLatestObservable.ZipLatest.LeftObserver<object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class ZipLatestObservable.ZipLatest<TLeft, TRight, TResult> : OperatorObserverBase<TResult, TResult> // TypeDefIndex: 7178
{
	// Fields
	private readonly ZipLatestObservable<TLeft, TRight, TResult> parent; // 0x0
	private readonly object gate; // 0x0
	private TLeft leftValue; // 0x0
	private bool leftStarted; // 0x0
	private bool leftCompleted; // 0x0
	private TRight rightValue; // 0x0
	private bool rightStarted; // 0x0
	private bool rightCompleted; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipLatestObservable<TLeft, TRight, TResult> parent, IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF18B0 Offset: 0x3EF19B1 VA: 0x3EF18B0
	|-ZipLatestObservable.ZipLatest<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF1970 Offset: 0x3EF1A71 VA: 0x3EF1970
	|-ZipLatestObservable.ZipLatest<object, object, object>.Run
	*/

	// RVA: -1 Offset: -1
	public void Publish() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF1B30 Offset: 0x3EF1C31 VA: 0x3EF1B30
	|-ZipLatestObservable.ZipLatest<object, object, object>.Publish
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TResult value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF1F50 Offset: 0x3EF2051 VA: 0x3EF1F50
	|-ZipLatestObservable.ZipLatest<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF2000 Offset: 0x3EF2101 VA: 0x3EF2000
	|-ZipLatestObservable.ZipLatest<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF2140 Offset: 0x3EF2241 VA: 0x3EF2140
	|-ZipLatestObservable.ZipLatest<object, object, object>.OnCompleted
	*/
}

// Namespace: 
private class ZipLatestObservable.ZipLatest.ZipLatestObserver<T> : IObserver<T> // TypeDefIndex: 7180
{
	// Fields
	private readonly ZipLatestObservable.ZipLatest<T> parent; // 0x0
	private readonly int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipLatestObservable.ZipLatest<T> parent, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7920 Offset: 0x3EF7A21 VA: 0x3EF7920
	|-ZipLatestObservable.ZipLatest.ZipLatestObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7970 Offset: 0x3EF7A71 VA: 0x3EF7970
	|-ZipLatestObservable.ZipLatest.ZipLatestObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception ex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7AA0 Offset: 0x3EF7BA1 VA: 0x3EF7AA0
	|-ZipLatestObservable.ZipLatest.ZipLatestObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7B90 Offset: 0x3EF7C91 VA: 0x3EF7B90
	|-ZipLatestObservable.ZipLatest.ZipLatestObserver<object>.OnCompleted
	*/
}

