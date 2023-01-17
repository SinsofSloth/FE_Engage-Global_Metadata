// Namespace: 
private class ThrottleObservable.Throttle<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7097
{
	// Fields
	private readonly ThrottleObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private T latestValue; // 0x0
	private bool hasValue; // 0x0
	private SerialDisposable cancelable; // 0x0
	private ulong id; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ThrottleObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3998C40 Offset: 0x3998D41 VA: 0x3998C40
	|-ThrottleObservable.Throttle<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3998D00 Offset: 0x3998E01 VA: 0x3998D00
	|-ThrottleObservable.Throttle<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void OnNext(ulong currentid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3998E10 Offset: 0x3998F11 VA: 0x3998E10
	|-ThrottleObservable.Throttle<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3998F90 Offset: 0x3999091 VA: 0x3998F90
	|-ThrottleObservable.Throttle<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3999200 Offset: 0x3999301 VA: 0x3999200
	|-ThrottleObservable.Throttle<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3999400 Offset: 0x3999501 VA: 0x3999400
	|-ThrottleObservable.Throttle<object>.OnCompleted
	*/
}

