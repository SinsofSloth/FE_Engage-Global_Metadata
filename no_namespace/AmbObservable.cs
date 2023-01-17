// Namespace: 
private class AmbObservable.AmbOuterObserver.AmbDecisionObserver<T> : IObserver<T> // TypeDefIndex: 6861
{
	// Fields
	private readonly AmbObservable.AmbOuterObserver<T> parent; // 0x0
	private readonly AmbObservable.AmbOuterObserver.AmbState<T> me; // 0x0
	private readonly IDisposable otherSubscription; // 0x0
	private readonly AmbObservable.AmbOuterObserver.Amb<T> self; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(AmbObservable.AmbOuterObserver<T> parent, AmbObservable.AmbOuterObserver.AmbState<T> me, IDisposable otherSubscription, AmbObservable.AmbOuterObserver.Amb<T> self) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF7440 Offset: 0x1FF7541 VA: 0x1FF7440
	|-AmbObservable.AmbOuterObserver.AmbDecisionObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF74C0 Offset: 0x1FF75C1 VA: 0x1FF74C0
	|-AmbObservable.AmbOuterObserver.AmbDecisionObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF7700 Offset: 0x1FF7801 VA: 0x1FF7700
	|-AmbObservable.AmbOuterObserver.AmbDecisionObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF7940 Offset: 0x1FF7A41 VA: 0x1FF7940
	|-AmbObservable.AmbOuterObserver.AmbDecisionObserver<object>.OnCompleted
	*/
}

