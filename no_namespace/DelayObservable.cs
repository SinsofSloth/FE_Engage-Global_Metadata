// Namespace: 
private class DelayObservable.Delay<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6928
{
	// Fields
	private readonly DelayObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private bool hasFailed; // 0x0
	private bool running; // 0x0
	private bool active; // 0x0
	private Exception exception; // 0x0
	private Queue<Timestamped<T>> queue; // 0x0
	private bool onCompleted; // 0x0
	private DateTimeOffset completeAt; // 0x0
	private IDisposable sourceSubscription; // 0x0
	private TimeSpan delay; // 0x0
	private bool ready; // 0x0
	private SerialDisposable cancelable; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(DelayObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2511480 Offset: 0x2511581 VA: 0x2511480
	|-DelayObservable.Delay<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2511540 Offset: 0x2511641 VA: 0x2511540
	|-DelayObservable.Delay<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2511760 Offset: 0x2511861 VA: 0x2511760
	|-DelayObservable.Delay<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2511A20 Offset: 0x2511B21 VA: 0x2511A20
	|-DelayObservable.Delay<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2511CE0 Offset: 0x2511DE1 VA: 0x2511CE0
	|-DelayObservable.Delay<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1
	private void DrainQueue(Action<TimeSpan> recurse) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2511FB0 Offset: 0x25120B1 VA: 0x2511FB0
	|-DelayObservable.Delay<object>.DrainQueue
	*/
}

