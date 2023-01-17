// Namespace: 
private class TimeoutFrameObservable.TimeoutFrame.TimeoutFrameTick<T> : IObserver<long> // TypeDefIndex: 7230
{
	// Fields
	private readonly TimeoutFrameObservable.TimeoutFrame<T> parent; // 0x0
	private readonly ulong timerId; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TimeoutFrameObservable.TimeoutFrame<T> parent, ulong timerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399EDC0 Offset: 0x399EEC1 VA: 0x399EDC0
	|-TimeoutFrameObservable.TimeoutFrame.TimeoutFrameTick<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399EE10 Offset: 0x399EF11 VA: 0x399EE10
	|-TimeoutFrameObservable.TimeoutFrame.TimeoutFrameTick<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399EE20 Offset: 0x399EF21 VA: 0x399EE20
	|-TimeoutFrameObservable.TimeoutFrame.TimeoutFrameTick<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(long _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399EE30 Offset: 0x399EF31 VA: 0x399EE30
	|-TimeoutFrameObservable.TimeoutFrame.TimeoutFrameTick<object>.OnNext
	*/
}

