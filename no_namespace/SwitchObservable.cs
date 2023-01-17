// Namespace: 
private class SwitchObservable.SwitchObserver.Switch<T> : IObserver<T> // TypeDefIndex: 7078
{
	// Fields
	private readonly SwitchObservable.SwitchObserver<T> parent; // 0x0
	private readonly ulong id; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SwitchObservable.SwitchObserver<T> observer, ulong id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B1B70 Offset: 0x34B1C71 VA: 0x34B1B70
	|-SwitchObservable.SwitchObserver.Switch<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B1BC0 Offset: 0x34B1CC1 VA: 0x34B1BC0
	|-SwitchObservable.SwitchObserver.Switch<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B1D30 Offset: 0x34B1E31 VA: 0x34B1D30
	|-SwitchObservable.SwitchObserver.Switch<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B1EA0 Offset: 0x34B1FA1 VA: 0x34B1EA0
	|-SwitchObservable.SwitchObserver.Switch<object>.OnCompleted
	*/
}

// Namespace: 
private class SwitchObservable.SwitchObserver<T> : OperatorObserverBase<IObservable<T>, T> // TypeDefIndex: 7079
{
	// Fields
	private readonly SwitchObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private readonly SerialDisposable innerSubscription; // 0x0
	private bool isStopped; // 0x0
	private ulong latest; // 0x0
	private bool hasLatest; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SwitchObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B2100 Offset: 0x34B2201 VA: 0x34B2100
	|-SwitchObservable.SwitchObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B2200 Offset: 0x34B2301 VA: 0x34B2200
	|-SwitchObservable.SwitchObserver<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(IObservable<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B22B0 Offset: 0x34B23B1 VA: 0x34B22B0
	|-SwitchObservable.SwitchObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B24C0 Offset: 0x34B25C1 VA: 0x34B24C0
	|-SwitchObservable.SwitchObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B26A0 Offset: 0x34B27A1 VA: 0x34B26A0
	|-SwitchObservable.SwitchObserver<object>.OnCompleted
	*/
}

