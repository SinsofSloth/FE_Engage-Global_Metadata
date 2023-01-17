// Namespace: 
private class FrameTimeIntervalObservable.FrameTimeInterval<T> : OperatorObserverBase<T, TimeInterval<T>> // TypeDefIndex: 7210
{
	// Fields
	private readonly FrameTimeIntervalObservable<T> parent; // 0x0
	private float lastTime; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FrameTimeIntervalObservable<T> parent, IObserver<TimeInterval<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DF090 Offset: 0x33DF191 VA: 0x33DF090
	|-FrameTimeIntervalObservable.FrameTimeInterval<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DF110 Offset: 0x33DF211 VA: 0x33DF110
	|-FrameTimeIntervalObservable.FrameTimeInterval<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DF270 Offset: 0x33DF371 VA: 0x33DF270
	|-FrameTimeIntervalObservable.FrameTimeInterval<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DF3B0 Offset: 0x33DF4B1 VA: 0x33DF3B0
	|-FrameTimeIntervalObservable.FrameTimeInterval<object>.OnCompleted
	*/
}

