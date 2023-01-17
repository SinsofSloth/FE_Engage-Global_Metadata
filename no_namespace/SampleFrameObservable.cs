// Namespace: 
private class SampleFrameObservable.SampleFrame.SampleFrameTick<T> : IObserver<long> // TypeDefIndex: 7219
{
	// Fields
	private readonly SampleFrameObservable.SampleFrame<T> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SampleFrameObservable.SampleFrame<T> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFE520 Offset: 0x2FFE621 VA: 0x2FFE520
	|-SampleFrameObservable.SampleFrame.SampleFrameTick<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFE560 Offset: 0x2FFE661 VA: 0x2FFE560
	|-SampleFrameObservable.SampleFrame.SampleFrameTick<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFE570 Offset: 0x2FFE671 VA: 0x2FFE570
	|-SampleFrameObservable.SampleFrame.SampleFrameTick<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(long _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFE580 Offset: 0x2FFE681 VA: 0x2FFE580
	|-SampleFrameObservable.SampleFrame.SampleFrameTick<object>.OnNext
	*/
}

// Namespace: 
private class SampleFrameObservable.SampleFrame<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7220
{
	// Fields
	private readonly SampleFrameObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private T latestValue; // 0x0
	private bool isUpdated; // 0x0
	private bool isCompleted; // 0x0
	private SingleAssignmentDisposable sourceSubscription; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SampleFrameObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFDAA0 Offset: 0x2FFDBA1 VA: 0x2FFDAA0
	|-SampleFrameObservable.SampleFrame<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFDB60 Offset: 0x2FFDC61 VA: 0x2FFDB60
	|-SampleFrameObservable.SampleFrame<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void OnNextTick(long _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFDD80 Offset: 0x2FFDE81 VA: 0x2FFDD80
	|-SampleFrameObservable.SampleFrame<object>.OnNextTick
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFE050 Offset: 0x2FFE151 VA: 0x2FFE050
	|-SampleFrameObservable.SampleFrame<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFE130 Offset: 0x2FFE231 VA: 0x2FFE130
	|-SampleFrameObservable.SampleFrame<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFE310 Offset: 0x2FFE411 VA: 0x2FFE310
	|-SampleFrameObservable.SampleFrame<object>.OnCompleted
	*/
}

