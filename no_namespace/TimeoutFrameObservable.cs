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

// Namespace: 
private class TimeoutFrameObservable.TimeoutFrame<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7231
{
	// Fields
	private readonly TimeoutFrameObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private ulong objectId; // 0x0
	private bool isTimeout; // 0x0
	private SingleAssignmentDisposable sourceSubscription; // 0x0
	private SerialDisposable timerSubscription; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TimeoutFrameObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399E290 Offset: 0x399E391 VA: 0x399E290
	|-TimeoutFrameObservable.TimeoutFrame<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399E350 Offset: 0x399E451 VA: 0x399E350
	|-TimeoutFrameObservable.TimeoutFrame<object>.Run
	*/

	// RVA: -1 Offset: -1
	private IDisposable RunTimer(ulong timerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399E4E0 Offset: 0x399E5E1 VA: 0x399E4E0
	|-TimeoutFrameObservable.TimeoutFrame<object>.RunTimer
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399E620 Offset: 0x399E721 VA: 0x399E620
	|-TimeoutFrameObservable.TimeoutFrame<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399E840 Offset: 0x399E941 VA: 0x399E840
	|-TimeoutFrameObservable.TimeoutFrame<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399EA70 Offset: 0x399EB71 VA: 0x399EA70
	|-TimeoutFrameObservable.TimeoutFrame<object>.OnCompleted
	*/
}

