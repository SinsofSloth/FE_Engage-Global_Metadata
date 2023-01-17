// Namespace: 
private class ThrottleFrameObservable.ThrottleFrame.ThrottleFrameTick<T> : IObserver<long> // TypeDefIndex: 7227
{
	// Fields
	private readonly ThrottleFrameObservable.ThrottleFrame<T> parent; // 0x0
	private readonly ulong currentid; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ThrottleFrameObservable.ThrottleFrame<T> parent, ulong currentid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399B740 Offset: 0x399B841 VA: 0x399B740
	|-ThrottleFrameObservable.ThrottleFrame.ThrottleFrameTick<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399B790 Offset: 0x399B891 VA: 0x399B790
	|-ThrottleFrameObservable.ThrottleFrame.ThrottleFrameTick<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399B7A0 Offset: 0x399B8A1 VA: 0x399B7A0
	|-ThrottleFrameObservable.ThrottleFrame.ThrottleFrameTick<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(long _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399B7B0 Offset: 0x399B8B1 VA: 0x399B7B0
	|-ThrottleFrameObservable.ThrottleFrame.ThrottleFrameTick<object>.OnNext
	*/
}

// Namespace: 
private class ThrottleFrameObservable.ThrottleFrame<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7228
{
	// Fields
	private readonly ThrottleFrameObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private T latestValue; // 0x0
	private bool hasValue; // 0x0
	private SerialDisposable cancelable; // 0x0
	private ulong id; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ThrottleFrameObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399AD40 Offset: 0x399AE41 VA: 0x399AD40
	|-ThrottleFrameObservable.ThrottleFrame<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399AE00 Offset: 0x399AF01 VA: 0x399AE00
	|-ThrottleFrameObservable.ThrottleFrame<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399AF10 Offset: 0x399B011 VA: 0x399AF10
	|-ThrottleFrameObservable.ThrottleFrame<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399B170 Offset: 0x399B271 VA: 0x399B170
	|-ThrottleFrameObservable.ThrottleFrame<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399B370 Offset: 0x399B471 VA: 0x399B370
	|-ThrottleFrameObservable.ThrottleFrame<object>.OnCompleted
	*/
}

