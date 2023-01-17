// Namespace: 
private class AmbObservable.AmbOuterObserver.Amb<T> : IObserver<T> // TypeDefIndex: 6860
{
	// Fields
	public IObserver<T> targetObserver; // 0x0
	public IDisposable targetDisposable; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6EF0 Offset: 0x1FF6FF1 VA: 0x1FF6EF0
	|-AmbObservable.AmbOuterObserver.Amb<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6F90 Offset: 0x1FF7091 VA: 0x1FF6F90
	|-AmbObservable.AmbOuterObserver.Amb<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF71E0 Offset: 0x1FF72E1 VA: 0x1FF71E0
	|-AmbObservable.AmbOuterObserver.Amb<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF7430 Offset: 0x1FF7531 VA: 0x1FF7430
	|-AmbObservable.AmbOuterObserver.Amb<object>..ctor
	*/
}

// Namespace: 
private class AmbObservable.AmbOuterObserver<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6862
{
	// Fields
	private readonly AmbObservable<T> parent; // 0x0
	private readonly object gate; // 0x0
	private SingleAssignmentDisposable leftSubscription; // 0x0
	private SingleAssignmentDisposable rightSubscription; // 0x0
	private AmbObservable.AmbOuterObserver.AmbState<T> choice; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(AmbObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF7CC0 Offset: 0x1FF7DC1 VA: 0x1FF7CC0
	|-AmbObservable.AmbOuterObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF7D90 Offset: 0x1FF7E91 VA: 0x1FF7D90
	|-AmbObservable.AmbOuterObserver<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF80E0 Offset: 0x1FF81E1 VA: 0x1FF80E0
	|-AmbObservable.AmbOuterObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF80F0 Offset: 0x1FF81F1 VA: 0x1FF80F0
	|-AmbObservable.AmbOuterObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8100 Offset: 0x1FF8201 VA: 0x1FF8100
	|-AmbObservable.AmbOuterObserver<object>.OnCompleted
	*/
}

