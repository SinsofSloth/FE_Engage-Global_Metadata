// Namespace: 
private class GroupByObservable.GroupBy<TSource, TKey, TElement> : OperatorObserverBase<TSource, IGroupedObservable<TKey, TElement>> // TypeDefIndex: 6980
{
	// Fields
	private readonly GroupByObservable<TSource, TKey, TElement> parent; // 0x0
	private readonly Dictionary<TKey, ISubject<TElement>> map; // 0x0
	private ISubject<TElement> nullKeySubject; // 0x0
	private CompositeDisposable groupDisposable; // 0x0
	private RefCountDisposable refCountDisposable; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(GroupByObservable<TSource, TKey, TElement> parent, IObserver<IGroupedObservable<TKey, TElement>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A12800 Offset: 0x3A12901 VA: 0x3A12800
	|-GroupByObservable.GroupBy<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A12960 Offset: 0x3A12A61 VA: 0x3A12960
	|-GroupByObservable.GroupBy<object, object, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A12AC0 Offset: 0x3A12BC1 VA: 0x3A12AC0
	|-GroupByObservable.GroupBy<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A12EE0 Offset: 0x3A12FE1 VA: 0x3A12EE0
	|-GroupByObservable.GroupBy<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A12F00 Offset: 0x3A13001 VA: 0x3A12F00
	|-GroupByObservable.GroupBy<object, object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1
	private void Error(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A13340 Offset: 0x3A13441 VA: 0x3A13340
	|-GroupByObservable.GroupBy<object, object, object>.Error
	*/
}

