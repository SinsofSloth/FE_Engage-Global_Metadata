// Namespace: 
private class MergeObservable.MergeOuterObserver<T> : OperatorObserverBase<IObservable<T>, T> // TypeDefIndex: 6990
{
	// Fields
	private readonly MergeObservable<T> parent; // 0x0
	private CompositeDisposable collectionDisposable; // 0x0
	private SingleAssignmentDisposable sourceDisposable; // 0x0
	private object gate; // 0x0
	private bool isStopped; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MergeObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293BFE0 Offset: 0x293C0E1 VA: 0x293BFE0
	|-MergeObservable.MergeOuterObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293C0A0 Offset: 0x293C1A1 VA: 0x293C0A0
	|-MergeObservable.MergeOuterObserver<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(IObservable<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293C210 Offset: 0x293C311 VA: 0x293C210
	|-MergeObservable.MergeOuterObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293C360 Offset: 0x293C461 VA: 0x293C360
	|-MergeObservable.MergeOuterObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293C540 Offset: 0x293C641 VA: 0x293C540
	|-MergeObservable.MergeOuterObserver<object>.OnCompleted
	*/
}

// Namespace: 
private class MergeObservable.MergeConcurrentObserver<T> : OperatorObserverBase<IObservable<T>, T> // TypeDefIndex: 6992
{
	// Fields
	private readonly MergeObservable<T> parent; // 0x0
	private CompositeDisposable collectionDisposable; // 0x0
	private SingleAssignmentDisposable sourceDisposable; // 0x0
	private object gate; // 0x0
	private bool isStopped; // 0x0
	private Queue<IObservable<T>> q; // 0x0
	private int activeCount; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MergeObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293B530 Offset: 0x293B631 VA: 0x293B530
	|-MergeObservable.MergeConcurrentObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293B5F0 Offset: 0x293B6F1 VA: 0x293B5F0
	|-MergeObservable.MergeConcurrentObserver<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(IObservable<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293B7B0 Offset: 0x293B8B1 VA: 0x293B7B0
	|-MergeObservable.MergeConcurrentObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293B8E0 Offset: 0x293B9E1 VA: 0x293B8E0
	|-MergeObservable.MergeConcurrentObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293BAC0 Offset: 0x293BBC1 VA: 0x293BAC0
	|-MergeObservable.MergeConcurrentObserver<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1
	private void Subscribe(IObservable<T> innerSource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293BCF0 Offset: 0x293BDF1 VA: 0x293BCF0
	|-MergeObservable.MergeConcurrentObserver<object>.Subscribe
	*/
}

