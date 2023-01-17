// Namespace: UniRx.Operators
internal class EmptyObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6959
{
	// Fields
	private readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D250F0 Offset: 0x1D251F1 VA: 0x1D250F0
	|-EmptyObservable<CollectionAddEvent<object>>..ctor
	|
	|-RVA: 0x1D25410 Offset: 0x1D25511 VA: 0x1D25410
	|-EmptyObservable<CollectionMoveEvent<object>>..ctor
	|
	|-RVA: 0x1D25730 Offset: 0x1D25831 VA: 0x1D25730
	|-EmptyObservable<CollectionRemoveEvent<object>>..ctor
	|
	|-RVA: 0x1D25A50 Offset: 0x1D25B51 VA: 0x1D25A50
	|-EmptyObservable<CollectionReplaceEvent<object>>..ctor
	|
	|-RVA: 0x1D25D70 Offset: 0x1D25E71 VA: 0x1D25D70
	|-EmptyObservable<DictionaryAddEvent<object, object>>..ctor
	|
	|-RVA: 0x1D26090 Offset: 0x1D26191 VA: 0x1D26090
	|-EmptyObservable<DictionaryRemoveEvent<object, object>>..ctor
	|
	|-RVA: 0x1D263B0 Offset: 0x1D264B1 VA: 0x1D263B0
	|-EmptyObservable<DictionaryReplaceEvent<object, object>>..ctor
	|
	|-RVA: 0x1D266D0 Offset: 0x1D267D1 VA: 0x1D266D0
	|-EmptyObservable<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x1D269F0 Offset: 0x1D26AF1 VA: 0x1D269F0
	|-EmptyObservable<int>..ctor
	|
	|-RVA: 0x1D26D10 Offset: 0x1D26E11 VA: 0x1D26D10
	|-EmptyObservable<long>..ctor
	|
	|-RVA: 0x1D27030 Offset: 0x1D27131 VA: 0x1D27030
	|-EmptyObservable<object>..ctor
	|
	|-RVA: 0x1D27350 Offset: 0x1D27451 VA: 0x1D27350
	|-EmptyObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D25140 Offset: 0x1D25241 VA: 0x1D25140
	|-EmptyObservable<CollectionAddEvent<object>>.SubscribeCore
	|
	|-RVA: 0x1D25460 Offset: 0x1D25561 VA: 0x1D25460
	|-EmptyObservable<CollectionMoveEvent<object>>.SubscribeCore
	|
	|-RVA: 0x1D25780 Offset: 0x1D25881 VA: 0x1D25780
	|-EmptyObservable<CollectionRemoveEvent<object>>.SubscribeCore
	|
	|-RVA: 0x1D25AA0 Offset: 0x1D25BA1 VA: 0x1D25AA0
	|-EmptyObservable<CollectionReplaceEvent<object>>.SubscribeCore
	|
	|-RVA: 0x1D25DC0 Offset: 0x1D25EC1 VA: 0x1D25DC0
	|-EmptyObservable<DictionaryAddEvent<object, object>>.SubscribeCore
	|
	|-RVA: 0x1D260E0 Offset: 0x1D261E1 VA: 0x1D260E0
	|-EmptyObservable<DictionaryRemoveEvent<object, object>>.SubscribeCore
	|
	|-RVA: 0x1D26400 Offset: 0x1D26501 VA: 0x1D26400
	|-EmptyObservable<DictionaryReplaceEvent<object, object>>.SubscribeCore
	|
	|-RVA: 0x1D26720 Offset: 0x1D26821 VA: 0x1D26720
	|-EmptyObservable<ValueTuple<object, object>>.SubscribeCore
	|
	|-RVA: 0x1D26A40 Offset: 0x1D26B41 VA: 0x1D26A40
	|-EmptyObservable<int>.SubscribeCore
	|
	|-RVA: 0x1D26D60 Offset: 0x1D26E61 VA: 0x1D26D60
	|-EmptyObservable<long>.SubscribeCore
	|
	|-RVA: 0x1D27080 Offset: 0x1D27181 VA: 0x1D27080
	|-EmptyObservable<object>.SubscribeCore
	|
	|-RVA: 0x1D273A0 Offset: 0x1D274A1 VA: 0x1D273A0
	|-EmptyObservable<Unit>.SubscribeCore
	*/
}

