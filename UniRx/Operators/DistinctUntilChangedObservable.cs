// Namespace: UniRx.Operators
internal class DistinctUntilChangedObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6941
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly IEqualityComparer<T> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26329E0 Offset: 0x2632AE1 VA: 0x26329E0
	|-DistinctUntilChangedObservable<bool>..ctor
	|
	|-RVA: 0x2632B60 Offset: 0x2632C61 VA: 0x2632B60
	|-DistinctUntilChangedObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2632A60 Offset: 0x2632B61 VA: 0x2632A60
	|-DistinctUntilChangedObservable<bool>.SubscribeCore
	|
	|-RVA: 0x2632BE0 Offset: 0x2632CE1 VA: 0x2632BE0
	|-DistinctUntilChangedObservable<object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class DistinctUntilChangedObservable<T, TKey> : OperatorObservableBase<T> // TypeDefIndex: 6943
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly IEqualityComparer<TKey> comparer; // 0x0
	private readonly Func<T, TKey> keySelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2632CE0 Offset: 0x2632DE1 VA: 0x2632CE0
	|-DistinctUntilChangedObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2632D80 Offset: 0x2632E81 VA: 0x2632D80
	|-DistinctUntilChangedObservable<object, object>.SubscribeCore
	*/
}

