// Namespace: UniRx.Operators
public abstract class OperatorObservableBase<T> : IObservable<T>, IOptimizedObservable<T> // TypeDefIndex: 7004
{
	// Fields
	private readonly bool isRequiredSubscribeOnCurrentThread; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(bool isRequiredSubscribeOnCurrentThread) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3716530 Offset: 0x3716631 VA: 0x3716530
	|-OperatorObservableBase<CollectionAddEvent<object>>..ctor
	|
	|-RVA: 0x37167B0 Offset: 0x37168B1 VA: 0x37167B0
	|-OperatorObservableBase<CollectionMoveEvent<object>>..ctor
	|
	|-RVA: 0x3716A30 Offset: 0x3716B31 VA: 0x3716A30
	|-OperatorObservableBase<CollectionRemoveEvent<object>>..ctor
	|
	|-RVA: 0x3716CB0 Offset: 0x3716DB1 VA: 0x3716CB0
	|-OperatorObservableBase<CollectionReplaceEvent<object>>..ctor
	|
	|-RVA: 0x3716F30 Offset: 0x3717031 VA: 0x3716F30
	|-OperatorObservableBase<DictionaryAddEvent<object, object>>..ctor
	|
	|-RVA: 0x37171B0 Offset: 0x37172B1 VA: 0x37171B0
	|-OperatorObservableBase<DictionaryRemoveEvent<object, object>>..ctor
	|
	|-RVA: 0x3717430 Offset: 0x3717531 VA: 0x3717430
	|-OperatorObservableBase<DictionaryReplaceEvent<object, object>>..ctor
	|
	|-RVA: 0x37176B0 Offset: 0x37177B1 VA: 0x37176B0
	|-OperatorObservableBase<FrameInterval<object>>..ctor
	|
	|-RVA: 0x3717930 Offset: 0x3717A31 VA: 0x3717930
	|-OperatorObservableBase<Pair<int>>..ctor
	|
	|-RVA: 0x3717BB0 Offset: 0x3717CB1 VA: 0x3717BB0
	|-OperatorObservableBase<Pair<object>>..ctor
	|
	|-RVA: 0x3717E30 Offset: 0x3717F31 VA: 0x3717E30
	|-OperatorObservableBase<TimeInterval<object>>..ctor
	|
	|-RVA: 0x37180B0 Offset: 0x37181B1 VA: 0x37180B0
	|-OperatorObservableBase<Timestamped<object>>..ctor
	|
	|-RVA: 0x3718330 Offset: 0x3718431 VA: 0x3718330
	|-OperatorObservableBase<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x37185B0 Offset: 0x37186B1 VA: 0x37185B0
	|-OperatorObservableBase<ValueTuple<float, int>>..ctor
	|
	|-RVA: 0x3718830 Offset: 0x3718931 VA: 0x3718830
	|-OperatorObservableBase<ValueTuple<float, Int32Enum>>..ctor
	|
	|-RVA: 0x3718AB0 Offset: 0x3718BB1 VA: 0x3718AB0
	|-OperatorObservableBase<bool>..ctor
	|
	|-RVA: 0x3718D30 Offset: 0x3718E31 VA: 0x3718D30
	|-OperatorObservableBase<int>..ctor
	|
	|-RVA: 0x3718FB0 Offset: 0x37190B1 VA: 0x3718FB0
	|-OperatorObservableBase<long>..ctor
	|
	|-RVA: 0x3719230 Offset: 0x3719331 VA: 0x3719230
	|-OperatorObservableBase<object>..ctor
	|
	|-RVA: 0x37194B0 Offset: 0x37195B1 VA: 0x37194B0
	|-OperatorObservableBase<float>..ctor
	|
	|-RVA: 0x3719730 Offset: 0x3719831 VA: 0x3719730
	|-OperatorObservableBase<Unit>..ctor
	|
	|-RVA: 0x37199B0 Offset: 0x3719AB1 VA: 0x37199B0
	|-OperatorObservableBase<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool IsRequiredSubscribeOnCurrentThread() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3716560 Offset: 0x3716661 VA: 0x3716560
	|-OperatorObservableBase<CollectionAddEvent<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x37167E0 Offset: 0x37168E1 VA: 0x37167E0
	|-OperatorObservableBase<CollectionMoveEvent<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3716A60 Offset: 0x3716B61 VA: 0x3716A60
	|-OperatorObservableBase<CollectionRemoveEvent<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3716CE0 Offset: 0x3716DE1 VA: 0x3716CE0
	|-OperatorObservableBase<CollectionReplaceEvent<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3716F60 Offset: 0x3717061 VA: 0x3716F60
	|-OperatorObservableBase<DictionaryAddEvent<object, object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x37171E0 Offset: 0x37172E1 VA: 0x37171E0
	|-OperatorObservableBase<DictionaryRemoveEvent<object, object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3717460 Offset: 0x3717561 VA: 0x3717460
	|-OperatorObservableBase<DictionaryReplaceEvent<object, object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x37176E0 Offset: 0x37177E1 VA: 0x37176E0
	|-OperatorObservableBase<FrameInterval<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3717960 Offset: 0x3717A61 VA: 0x3717960
	|-OperatorObservableBase<Pair<int>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3717BE0 Offset: 0x3717CE1 VA: 0x3717BE0
	|-OperatorObservableBase<Pair<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3717E60 Offset: 0x3717F61 VA: 0x3717E60
	|-OperatorObservableBase<TimeInterval<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x37180E0 Offset: 0x37181E1 VA: 0x37180E0
	|-OperatorObservableBase<Timestamped<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3718360 Offset: 0x3718461 VA: 0x3718360
	|-OperatorObservableBase<ValueTuple<object, object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x37185E0 Offset: 0x37186E1 VA: 0x37185E0
	|-OperatorObservableBase<ValueTuple<float, int>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3718860 Offset: 0x3718961 VA: 0x3718860
	|-OperatorObservableBase<ValueTuple<float, Int32Enum>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3718AE0 Offset: 0x3718BE1 VA: 0x3718AE0
	|-OperatorObservableBase<bool>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3718D60 Offset: 0x3718E61 VA: 0x3718D60
	|-OperatorObservableBase<int>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3718FE0 Offset: 0x37190E1 VA: 0x3718FE0
	|-OperatorObservableBase<long>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3719260 Offset: 0x3719361 VA: 0x3719260
	|-OperatorObservableBase<object>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x37194E0 Offset: 0x37195E1 VA: 0x37194E0
	|-OperatorObservableBase<float>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x3719760 Offset: 0x3719861 VA: 0x3719760
	|-OperatorObservableBase<Unit>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x37199E0 Offset: 0x3719AE1 VA: 0x37199E0
	|-OperatorObservableBase<Vector2>.IsRequiredSubscribeOnCurrentThread
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IDisposable Subscribe(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3716570 Offset: 0x3716671 VA: 0x3716570
	|-OperatorObservableBase<CollectionAddEvent<object>>.Subscribe
	|
	|-RVA: 0x37167F0 Offset: 0x37168F1 VA: 0x37167F0
	|-OperatorObservableBase<CollectionMoveEvent<object>>.Subscribe
	|
	|-RVA: 0x3716A70 Offset: 0x3716B71 VA: 0x3716A70
	|-OperatorObservableBase<CollectionRemoveEvent<object>>.Subscribe
	|
	|-RVA: 0x3716CF0 Offset: 0x3716DF1 VA: 0x3716CF0
	|-OperatorObservableBase<CollectionReplaceEvent<object>>.Subscribe
	|
	|-RVA: 0x3716F70 Offset: 0x3717071 VA: 0x3716F70
	|-OperatorObservableBase<DictionaryAddEvent<object, object>>.Subscribe
	|
	|-RVA: 0x37171F0 Offset: 0x37172F1 VA: 0x37171F0
	|-OperatorObservableBase<DictionaryRemoveEvent<object, object>>.Subscribe
	|
	|-RVA: 0x3717470 Offset: 0x3717571 VA: 0x3717470
	|-OperatorObservableBase<DictionaryReplaceEvent<object, object>>.Subscribe
	|
	|-RVA: 0x37176F0 Offset: 0x37177F1 VA: 0x37176F0
	|-OperatorObservableBase<FrameInterval<object>>.Subscribe
	|
	|-RVA: 0x3717970 Offset: 0x3717A71 VA: 0x3717970
	|-OperatorObservableBase<Pair<int>>.Subscribe
	|
	|-RVA: 0x3717BF0 Offset: 0x3717CF1 VA: 0x3717BF0
	|-OperatorObservableBase<Pair<object>>.Subscribe
	|
	|-RVA: 0x3717E70 Offset: 0x3717F71 VA: 0x3717E70
	|-OperatorObservableBase<TimeInterval<object>>.Subscribe
	|
	|-RVA: 0x37180F0 Offset: 0x37181F1 VA: 0x37180F0
	|-OperatorObservableBase<Timestamped<object>>.Subscribe
	|
	|-RVA: 0x3718370 Offset: 0x3718471 VA: 0x3718370
	|-OperatorObservableBase<ValueTuple<object, object>>.Subscribe
	|
	|-RVA: 0x37185F0 Offset: 0x37186F1 VA: 0x37185F0
	|-OperatorObservableBase<ValueTuple<float, int>>.Subscribe
	|
	|-RVA: 0x3718870 Offset: 0x3718971 VA: 0x3718870
	|-OperatorObservableBase<ValueTuple<float, Int32Enum>>.Subscribe
	|
	|-RVA: 0x3718AF0 Offset: 0x3718BF1 VA: 0x3718AF0
	|-OperatorObservableBase<bool>.Subscribe
	|
	|-RVA: 0x3718D70 Offset: 0x3718E71 VA: 0x3718D70
	|-OperatorObservableBase<int>.Subscribe
	|
	|-RVA: 0x3718FF0 Offset: 0x37190F1 VA: 0x3718FF0
	|-OperatorObservableBase<long>.Subscribe
	|
	|-RVA: 0x3719270 Offset: 0x3719371 VA: 0x3719270
	|-OperatorObservableBase<object>.Subscribe
	|
	|-RVA: 0x37194F0 Offset: 0x37195F1 VA: 0x37194F0
	|-OperatorObservableBase<float>.Subscribe
	|
	|-RVA: 0x3719770 Offset: 0x3719871 VA: 0x3719770
	|-OperatorObservableBase<Unit>.Subscribe
	|
	|-RVA: 0x37199F0 Offset: 0x3719AF1 VA: 0x37199F0
	|-OperatorObservableBase<Vector2>.Subscribe
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-OperatorObservableBase<object>.SubscribeCore
	*/
}

