// Namespace: 
private class MergeObservable.MergeOuterObserver.Merge<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6989
{
	// Fields
	private readonly MergeObservable.MergeOuterObserver<T> parent; // 0x0
	private readonly IDisposable cancel; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MergeObservable.MergeOuterObserver<T> parent, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293AF70 Offset: 0x293B071 VA: 0x293AF70
	|-MergeObservable.MergeOuterObserver.Merge<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293AFF0 Offset: 0x293B0F1 VA: 0x293AFF0
	|-MergeObservable.MergeOuterObserver.Merge<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293B150 Offset: 0x293B251 VA: 0x293B150
	|-MergeObservable.MergeOuterObserver.Merge<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293B330 Offset: 0x293B431 VA: 0x293B330
	|-MergeObservable.MergeOuterObserver.Merge<object>.OnCompleted
	*/
}

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
private class MergeObservable.MergeConcurrentObserver.Merge<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6991
{
	// Fields
	private readonly MergeObservable.MergeConcurrentObserver<T> parent; // 0x0
	private readonly IDisposable cancel; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MergeObservable.MergeConcurrentObserver<T> parent, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A920 Offset: 0x293AA21 VA: 0x293A920
	|-MergeObservable.MergeConcurrentObserver.Merge<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A9A0 Offset: 0x293AAA1 VA: 0x293A9A0
	|-MergeObservable.MergeConcurrentObserver.Merge<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293AB00 Offset: 0x293AC01 VA: 0x293AB00
	|-MergeObservable.MergeConcurrentObserver.Merge<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293ACE0 Offset: 0x293ADE1 VA: 0x293ACE0
	|-MergeObservable.MergeConcurrentObserver.Merge<object>.OnCompleted
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

