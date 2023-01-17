// Namespace: UniRx.Operators
internal class GroupByObservable<TSource, TKey, TElement> : OperatorObservableBase<IGroupedObservable<TKey, TElement>> // TypeDefIndex: 6981
{
	// Fields
	private readonly IObservable<TSource> source; // 0x0
	private readonly Func<TSource, TKey> keySelector; // 0x0
	private readonly Func<TSource, TElement> elementSelector; // 0x0
	private readonly Nullable<int> capacity; // 0x0
	private readonly IEqualityComparer<TKey> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Nullable<int> capacity, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A137A0 Offset: 0x3A138A1 VA: 0x3A137A0
	|-GroupByObservable<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<IGroupedObservable<TKey, TElement>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A13860 Offset: 0x3A13961 VA: 0x3A13860
	|-GroupByObservable<object, object, object>.SubscribeCore
	*/
}

