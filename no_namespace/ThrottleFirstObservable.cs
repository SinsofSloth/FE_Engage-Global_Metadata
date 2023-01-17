// Namespace: 
private class ThrottleFirstObservable.ThrottleFirst<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7099
{
	// Fields
	private readonly ThrottleFirstObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private bool open; // 0x0
	private SerialDisposable cancelable; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ThrottleFirstObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39996A0 Offset: 0x39997A1 VA: 0x39996A0
	|-ThrottleFirstObservable.ThrottleFirst<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3999770 Offset: 0x3999871 VA: 0x3999770
	|-ThrottleFirstObservable.ThrottleFirst<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void OnNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3999880 Offset: 0x3999981 VA: 0x3999880
	|-ThrottleFirstObservable.ThrottleFirst<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3999950 Offset: 0x3999A51 VA: 0x3999950
	|-ThrottleFirstObservable.ThrottleFirst<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3999BF0 Offset: 0x3999CF1 VA: 0x3999BF0
	|-ThrottleFirstObservable.ThrottleFirst<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3999DE0 Offset: 0x3999EE1 VA: 0x3999DE0
	|-ThrottleFirstObservable.ThrottleFirst<object>.OnCompleted
	*/
}

