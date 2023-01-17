// Namespace: 
private class ThrottleFirstFrameObservable.ThrottleFirstFrame<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7225
{
	// Fields
	private readonly ThrottleFirstFrameObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private bool open; // 0x0
	private SerialDisposable cancelable; // 0x0
	private ThrottleFirstFrameObservable.ThrottleFirstFrame.ThrottleFirstFrameTick<T> tick; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ThrottleFirstFrameObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3999FC0 Offset: 0x399A0C1 VA: 0x3999FC0
	|-ThrottleFirstFrameObservable.ThrottleFirstFrame<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399A090 Offset: 0x399A191 VA: 0x399A090
	|-ThrottleFirstFrameObservable.ThrottleFirstFrame<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void OnNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399A1F0 Offset: 0x399A2F1 VA: 0x399A1F0
	|-ThrottleFirstFrameObservable.ThrottleFirstFrame<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399A2C0 Offset: 0x399A3C1 VA: 0x399A2C0
	|-ThrottleFirstFrameObservable.ThrottleFirstFrame<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399A560 Offset: 0x399A661 VA: 0x399A560
	|-ThrottleFirstFrameObservable.ThrottleFirstFrame<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399A750 Offset: 0x399A851 VA: 0x399A750
	|-ThrottleFirstFrameObservable.ThrottleFirstFrame<object>.OnCompleted
	*/
}

