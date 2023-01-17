// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13A40 Offset: 0x13B41 VA: 0x13A40
private sealed class TimeoutObservable.Timeout.<>c__DisplayClass8_0<T> // TypeDefIndex: 7106
{
	// Fields
	public TimeoutObservable.Timeout<T> <>4__this; // 0x0
	public ulong timerId; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B41DE0 Offset: 0x2B41EE1 VA: 0x2B41DE0
	|-TimeoutObservable.Timeout.<>c__DisplayClass8_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <RunTimer>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B41DF0 Offset: 0x2B41EF1 VA: 0x2B41DF0
	|-TimeoutObservable.Timeout.<>c__DisplayClass8_0<object>.<RunTimer>b__0
	*/
}

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

// Namespace: 
private class TimeoutObservable.Timeout_<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7108
{
	// Fields
	private readonly TimeoutObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private bool isFinished; // 0x0
	private SingleAssignmentDisposable sourceSubscription; // 0x0
	private IDisposable timerSubscription; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TimeoutObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399F420 Offset: 0x399F521 VA: 0x399F420
	|-TimeoutObservable.Timeout_<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399F4E0 Offset: 0x399F5E1 VA: 0x399F4E0
	|-TimeoutObservable.Timeout_<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void OnNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399F6C0 Offset: 0x399F7C1 VA: 0x399F6C0
	|-TimeoutObservable.Timeout_<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399F930 Offset: 0x399FA31 VA: 0x399F930
	|-TimeoutObservable.Timeout_<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399FA90 Offset: 0x399FB91 VA: 0x399FA90
	|-TimeoutObservable.Timeout_<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399FD30 Offset: 0x399FE31 VA: 0x399FD30
	|-TimeoutObservable.Timeout_<object>.OnCompleted
	*/
}

