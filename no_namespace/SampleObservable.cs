// Namespace: 
private class SampleObservable.Sample<T, T2> : OperatorObserverBase<T, T> // TypeDefIndex: 7033
{
	// Fields
	private readonly SampleObservable<T, T2> parent; // 0x0
	private readonly object gate; // 0x0
	private T latestValue; // 0x0
	private bool isUpdated; // 0x0
	private bool isCompleted; // 0x0
	private SingleAssignmentDisposable sourceSubscription; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SampleObservable<T, T2> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFD460 Offset: 0x2FFD561 VA: 0x2FFD460
	|-SampleObservable.Sample<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFD520 Offset: 0x2FFD621 VA: 0x2FFD520
	|-SampleObservable.Sample<object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFD700 Offset: 0x2FFD801 VA: 0x2FFD700
	|-SampleObservable.Sample<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFD7E0 Offset: 0x2FFD8E1 VA: 0x2FFD7E0
	|-SampleObservable.Sample<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFD9C0 Offset: 0x2FFDAC1 VA: 0x2FFD9C0
	|-SampleObservable.Sample<object, object>.OnCompleted
	*/
}

