// Namespace: 
private class TimeoutObservable.Timeout<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7107
{
	// Fields
	private readonly TimeoutObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private ulong objectId; // 0x0
	private bool isTimeout; // 0x0
	private SingleAssignmentDisposable sourceSubscription; // 0x0
	private SerialDisposable timerSubscription; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TimeoutObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399D850 Offset: 0x399D951 VA: 0x399D850
	|-TimeoutObservable.Timeout<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399D910 Offset: 0x399DA11 VA: 0x399D910
	|-TimeoutObservable.Timeout<object>.Run
	*/

	// RVA: -1 Offset: -1
	private IDisposable RunTimer(ulong timerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399DAA0 Offset: 0x399DBA1 VA: 0x399DAA0
	|-TimeoutObservable.Timeout<object>.RunTimer
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399DC20 Offset: 0x399DD21 VA: 0x399DC20
	|-TimeoutObservable.Timeout<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399DE40 Offset: 0x399DF41 VA: 0x399DE40
	|-TimeoutObservable.Timeout<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399E070 Offset: 0x399E171 VA: 0x399E070
	|-TimeoutObservable.Timeout<object>.OnCompleted
	*/
}

