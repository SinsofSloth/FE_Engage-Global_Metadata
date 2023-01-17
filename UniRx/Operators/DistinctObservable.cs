// Namespace: UniRx.Operators
internal class DistinctObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6937
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly IEqualityComparer<T> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26313F0 Offset: 0x26314F1 VA: 0x26313F0
	|-DistinctObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2631470 Offset: 0x2631571 VA: 0x2631470
	|-DistinctObservable<object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class DistinctObservable<T, TKey> : OperatorObservableBase<T> // TypeDefIndex: 6939
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
	|-RVA: 0x2631570 Offset: 0x2631671 VA: 0x2631570
	|-DistinctObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2631610 Offset: 0x2631711 VA: 0x2631610
	|-DistinctObservable<object, object>.SubscribeCore
	*/
}

