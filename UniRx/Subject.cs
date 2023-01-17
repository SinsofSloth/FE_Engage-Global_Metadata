// Namespace: UniRx
public sealed class Subject<T> : ISubject<T>, ISubject<T, T>, IObserver<T>, IObservable<T>, IDisposable, IOptimizedObservable<T> // TypeDefIndex: 6644
{
	// Fields
	private object observerLock; // 0x0
	private bool isStopped; // 0x0
	private bool isDisposed; // 0x0
	private Exception lastError; // 0x0
	private IObserver<T> outObserver; // 0x0

	// Properties
	public bool HasObservers { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_HasObservers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36D4940 Offset: 0x36D4A41 VA: 0x36D4940
	|-Subject<CollectionAddEvent<object>>.get_HasObservers
	|
	|-RVA: 0x36D57B0 Offset: 0x36D58B1 VA: 0x36D57B0
	|-Subject<CollectionMoveEvent<object>>.get_HasObservers
	|
	|-RVA: 0x36D6620 Offset: 0x36D6721 VA: 0x36D6620
	|-Subject<CollectionRemoveEvent<object>>.get_HasObservers
	|
	|-RVA: 0x36D7490 Offset: 0x36D7591 VA: 0x36D7490
	|-Subject<CollectionReplaceEvent<object>>.get_HasObservers
	|
	|-RVA: 0x36D8320 Offset: 0x36D8421 VA: 0x36D8320
	|-Subject<DictionaryAddEvent<object, object>>.get_HasObservers
	|
	|-RVA: 0x36D9190 Offset: 0x36D9291 VA: 0x36D9190
	|-Subject<DictionaryRemoveEvent<object, object>>.get_HasObservers
	|
	|-RVA: 0x36DA000 Offset: 0x36DA101 VA: 0x36DA000
	|-Subject<DictionaryReplaceEvent<object, object>>.get_HasObservers
	|
	|-RVA: 0x36DAE90 Offset: 0x36DAF91 VA: 0x36DAE90
	|-Subject<ValueTuple<object, object>>.get_HasObservers
	|
	|-RVA: 0x36DBD00 Offset: 0x36DBE01 VA: 0x36DBD00
	|-Subject<ValueTuple<float, int>>.get_HasObservers
	|
	|-RVA: 0x36DCB60 Offset: 0x36DCC61 VA: 0x36DCB60
	|-Subject<ValueTuple<float, Int32Enum>>.get_HasObservers
	|
	|-RVA: 0x36DD9C0 Offset: 0x36DDAC1 VA: 0x36DD9C0
	|-Subject<bool>.get_HasObservers
	|
	|-RVA: 0x36DE820 Offset: 0x36DE921 VA: 0x36DE820
	|-Subject<int>.get_HasObservers
	|
	|-RVA: 0x36DF680 Offset: 0x36DF781 VA: 0x36DF680
	|-Subject<Int32Enum>.get_HasObservers
	|
	|-RVA: 0x36E04E0 Offset: 0x36E05E1 VA: 0x36E04E0
	|-Subject<LogEntry>.get_HasObservers
	|
	|-RVA: 0x36E13A0 Offset: 0x36E14A1 VA: 0x36E13A0
	|-Subject<object>.get_HasObservers
	|
	|-RVA: 0x36E2200 Offset: 0x36E2301 VA: 0x36E2200
	|-Subject<float>.get_HasObservers
	|
	|-RVA: 0x36E3060 Offset: 0x36E3161 VA: 0x36E3060
	|-Subject<Unit>.get_HasObservers
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36D49C0 Offset: 0x36D4AC1 VA: 0x36D49C0
	|-Subject<CollectionAddEvent<object>>.OnCompleted
	|
	|-RVA: 0x36D5830 Offset: 0x36D5931 VA: 0x36D5830
	|-Subject<CollectionMoveEvent<object>>.OnCompleted
	|
	|-RVA: 0x36D66A0 Offset: 0x36D67A1 VA: 0x36D66A0
	|-Subject<CollectionRemoveEvent<object>>.OnCompleted
	|
	|-RVA: 0x36D7510 Offset: 0x36D7611 VA: 0x36D7510
	|-Subject<CollectionReplaceEvent<object>>.OnCompleted
	|
	|-RVA: 0x36D83A0 Offset: 0x36D84A1 VA: 0x36D83A0
	|-Subject<DictionaryAddEvent<object, object>>.OnCompleted
	|
	|-RVA: 0x36D9210 Offset: 0x36D9311 VA: 0x36D9210
	|-Subject<DictionaryRemoveEvent<object, object>>.OnCompleted
	|
	|-RVA: 0x36DA080 Offset: 0x36DA181 VA: 0x36DA080
	|-Subject<DictionaryReplaceEvent<object, object>>.OnCompleted
	|
	|-RVA: 0x36DAF10 Offset: 0x36DB011 VA: 0x36DAF10
	|-Subject<ValueTuple<object, object>>.OnCompleted
	|
	|-RVA: 0x36DBD80 Offset: 0x36DBE81 VA: 0x36DBD80
	|-Subject<ValueTuple<float, int>>.OnCompleted
	|
	|-RVA: 0x36DCBE0 Offset: 0x36DCCE1 VA: 0x36DCBE0
	|-Subject<ValueTuple<float, Int32Enum>>.OnCompleted
	|
	|-RVA: 0x36E1420 Offset: 0x36E1521 VA: 0x36E1420
	|-Subject<AxisEventData>.OnCompleted
	|-Subject<BaseEventData>.OnCompleted
	|-Subject<Character>.OnCompleted
	|-Subject<Collider>.OnCompleted
	|-Subject<Collider2D>.OnCompleted
	|-Subject<Collision>.OnCompleted
	|-Subject<Collision2D>.OnCompleted
	|-Subject<GameObject>.OnCompleted
	|-Subject<Joint2D>.OnCompleted
	|-Subject<object>.OnCompleted
	|-Subject<PointerEventData>.OnCompleted
	|
	|-RVA: 0x36DDA40 Offset: 0x36DDB41 VA: 0x36DDA40
	|-Subject<bool>.OnCompleted
	|
	|-RVA: 0x36DE8A0 Offset: 0x36DE9A1 VA: 0x36DE8A0
	|-Subject<int>.OnCompleted
	|
	|-RVA: 0x36DF700 Offset: 0x36DF801 VA: 0x36DF700
	|-Subject<Int32Enum>.OnCompleted
	|
	|-RVA: 0x36E0560 Offset: 0x36E0661 VA: 0x36E0560
	|-Subject<LogEntry>.OnCompleted
	|
	|-RVA: 0x36E2280 Offset: 0x36E2381 VA: 0x36E2280
	|-Subject<float>.OnCompleted
	|
	|-RVA: 0x36E30E0 Offset: 0x36E31E1 VA: 0x36E30E0
	|-Subject<Unit>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36D4C10 Offset: 0x36D4D11 VA: 0x36D4C10
	|-Subject<CollectionAddEvent<object>>.OnError
	|
	|-RVA: 0x36D5A80 Offset: 0x36D5B81 VA: 0x36D5A80
	|-Subject<CollectionMoveEvent<object>>.OnError
	|
	|-RVA: 0x36D68F0 Offset: 0x36D69F1 VA: 0x36D68F0
	|-Subject<CollectionRemoveEvent<object>>.OnError
	|
	|-RVA: 0x36D7760 Offset: 0x36D7861 VA: 0x36D7760
	|-Subject<CollectionReplaceEvent<object>>.OnError
	|
	|-RVA: 0x36D85F0 Offset: 0x36D86F1 VA: 0x36D85F0
	|-Subject<DictionaryAddEvent<object, object>>.OnError
	|
	|-RVA: 0x36D9460 Offset: 0x36D9561 VA: 0x36D9460
	|-Subject<DictionaryRemoveEvent<object, object>>.OnError
	|
	|-RVA: 0x36DA2D0 Offset: 0x36DA3D1 VA: 0x36DA2D0
	|-Subject<DictionaryReplaceEvent<object, object>>.OnError
	|
	|-RVA: 0x36DB160 Offset: 0x36DB261 VA: 0x36DB160
	|-Subject<ValueTuple<object, object>>.OnError
	|
	|-RVA: 0x36DBFD0 Offset: 0x36DC0D1 VA: 0x36DBFD0
	|-Subject<ValueTuple<float, int>>.OnError
	|
	|-RVA: 0x36DCE30 Offset: 0x36DCF31 VA: 0x36DCE30
	|-Subject<ValueTuple<float, Int32Enum>>.OnError
	|
	|-RVA: 0x36DDC90 Offset: 0x36DDD91 VA: 0x36DDC90
	|-Subject<bool>.OnError
	|
	|-RVA: 0x36DEAF0 Offset: 0x36DEBF1 VA: 0x36DEAF0
	|-Subject<int>.OnError
	|
	|-RVA: 0x36DF950 Offset: 0x36DFA51 VA: 0x36DF950
	|-Subject<Int32Enum>.OnError
	|
	|-RVA: 0x36E07B0 Offset: 0x36E08B1 VA: 0x36E07B0
	|-Subject<LogEntry>.OnError
	|
	|-RVA: 0x36E1670 Offset: 0x36E1771 VA: 0x36E1670
	|-Subject<object>.OnError
	|
	|-RVA: 0x36E24D0 Offset: 0x36E25D1 VA: 0x36E24D0
	|-Subject<float>.OnError
	|
	|-RVA: 0x36E3330 Offset: 0x36E3431 VA: 0x36E3330
	|-Subject<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36D4EE0 Offset: 0x36D4FE1 VA: 0x36D4EE0
	|-Subject<CollectionAddEvent<object>>.OnNext
	|
	|-RVA: 0x36D5D50 Offset: 0x36D5E51 VA: 0x36D5D50
	|-Subject<CollectionMoveEvent<object>>.OnNext
	|
	|-RVA: 0x36D6BC0 Offset: 0x36D6CC1 VA: 0x36D6BC0
	|-Subject<CollectionRemoveEvent<object>>.OnNext
	|
	|-RVA: 0x36D7A30 Offset: 0x36D7B31 VA: 0x36D7A30
	|-Subject<CollectionReplaceEvent<object>>.OnNext
	|
	|-RVA: 0x36D88C0 Offset: 0x36D89C1 VA: 0x36D88C0
	|-Subject<DictionaryAddEvent<object, object>>.OnNext
	|
	|-RVA: 0x36D9730 Offset: 0x36D9831 VA: 0x36D9730
	|-Subject<DictionaryRemoveEvent<object, object>>.OnNext
	|
	|-RVA: 0x36DA5A0 Offset: 0x36DA6A1 VA: 0x36DA5A0
	|-Subject<DictionaryReplaceEvent<object, object>>.OnNext
	|
	|-RVA: 0x36DB430 Offset: 0x36DB531 VA: 0x36DB430
	|-Subject<ValueTuple<Character, GameObject>>.OnNext
	|-Subject<ValueTuple<object, object>>.OnNext
	|
	|-RVA: 0x36DC2A0 Offset: 0x36DC3A1 VA: 0x36DC2A0
	|-Subject<ValueTuple<float, int>>.OnNext
	|
	|-RVA: 0x36DD100 Offset: 0x36DD201 VA: 0x36DD100
	|-Subject<ValueTuple<float, Int32Enum>>.OnNext
	|-Subject<ValueTuple<float, WeaponStyle>>.OnNext
	|
	|-RVA: 0x36E1940 Offset: 0x36E1A41 VA: 0x36E1940
	|-Subject<AnimationEvent>.OnNext
	|-Subject<AxisEventData>.OnNext
	|-Subject<BaseEventData>.OnNext
	|-Subject<Character>.OnNext
	|-Subject<Collider>.OnNext
	|-Subject<Collider2D>.OnNext
	|-Subject<Collision>.OnNext
	|-Subject<Collision2D>.OnNext
	|-Subject<GameObject>.OnNext
	|-Subject<Joint2D>.OnNext
	|-Subject<object>.OnNext
	|-Subject<Phase>.OnNext
	|-Subject<PhaseArray>.OnNext
	|-Subject<PointerEventData>.OnNext
	|-Subject<ObservableStateMachineTrigger.OnStateInfo>.OnNext
	|-Subject<ObservableStateMachineTrigger.OnStateMachineInfo>.OnNext
	|
	|-RVA: 0x36DDF60 Offset: 0x36DE061 VA: 0x36DDF60
	|-Subject<bool>.OnNext
	|
	|-RVA: 0x36DFC20 Offset: 0x36DFD21 VA: 0x36DFC20
	|-Subject<CountChangedStatus>.OnNext
	|-Subject<Int32Enum>.OnNext
	|
	|-RVA: 0x36DEDC0 Offset: 0x36DEEC1 VA: 0x36DEDC0
	|-Subject<int>.OnNext
	|
	|-RVA: 0x36E0A80 Offset: 0x36E0B81 VA: 0x36E0A80
	|-Subject<LogEntry>.OnNext
	|
	|-RVA: 0x36E27A0 Offset: 0x36E28A1 VA: 0x36E27A0
	|-Subject<float>.OnNext
	|
	|-RVA: 0x36E3600 Offset: 0x36E3701 VA: 0x36E3600
	|-Subject<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IDisposable Subscribe(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36D4F90 Offset: 0x36D5091 VA: 0x36D4F90
	|-Subject<CollectionAddEvent<object>>.Subscribe
	|
	|-RVA: 0x36D5E00 Offset: 0x36D5F01 VA: 0x36D5E00
	|-Subject<CollectionMoveEvent<object>>.Subscribe
	|
	|-RVA: 0x36D6C70 Offset: 0x36D6D71 VA: 0x36D6C70
	|-Subject<CollectionRemoveEvent<object>>.Subscribe
	|
	|-RVA: 0x36D7B00 Offset: 0x36D7C01 VA: 0x36D7B00
	|-Subject<CollectionReplaceEvent<object>>.Subscribe
	|
	|-RVA: 0x36D8970 Offset: 0x36D8A71 VA: 0x36D8970
	|-Subject<DictionaryAddEvent<object, object>>.Subscribe
	|
	|-RVA: 0x36D97E0 Offset: 0x36D98E1 VA: 0x36D97E0
	|-Subject<DictionaryRemoveEvent<object, object>>.Subscribe
	|
	|-RVA: 0x36DA670 Offset: 0x36DA771 VA: 0x36DA670
	|-Subject<DictionaryReplaceEvent<object, object>>.Subscribe
	|
	|-RVA: 0x36DB4E0 Offset: 0x36DB5E1 VA: 0x36DB4E0
	|-Subject<ValueTuple<object, object>>.Subscribe
	|
	|-RVA: 0x36DC340 Offset: 0x36DC441 VA: 0x36DC340
	|-Subject<ValueTuple<float, int>>.Subscribe
	|
	|-RVA: 0x36DD1A0 Offset: 0x36DD2A1 VA: 0x36DD1A0
	|-Subject<ValueTuple<float, Int32Enum>>.Subscribe
	|
	|-RVA: 0x36DE000 Offset: 0x36DE101 VA: 0x36DE000
	|-Subject<bool>.Subscribe
	|
	|-RVA: 0x36DFCC0 Offset: 0x36DFDC1 VA: 0x36DFCC0
	|-Subject<CountChangedStatus>.Subscribe
	|-Subject<Int32Enum>.Subscribe
	|
	|-RVA: 0x36DEE60 Offset: 0x36DEF61 VA: 0x36DEE60
	|-Subject<int>.Subscribe
	|
	|-RVA: 0x36E0B80 Offset: 0x36E0C81 VA: 0x36E0B80
	|-Subject<LogEntry>.Subscribe
	|
	|-RVA: 0x36E19E0 Offset: 0x36E1AE1 VA: 0x36E19E0
	|-Subject<object>.Subscribe
	|
	|-RVA: 0x36E2840 Offset: 0x36E2941 VA: 0x36E2840
	|-Subject<float>.Subscribe
	|
	|-RVA: 0x36E36A0 Offset: 0x36E37A1 VA: 0x36E36A0
	|-Subject<Unit>.Subscribe
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36D54A0 Offset: 0x36D55A1 VA: 0x36D54A0
	|-Subject<CollectionAddEvent<object>>.Dispose
	|
	|-RVA: 0x36D6310 Offset: 0x36D6411 VA: 0x36D6310
	|-Subject<CollectionMoveEvent<object>>.Dispose
	|
	|-RVA: 0x36D7180 Offset: 0x36D7281 VA: 0x36D7180
	|-Subject<CollectionRemoveEvent<object>>.Dispose
	|
	|-RVA: 0x36D8010 Offset: 0x36D8111 VA: 0x36D8010
	|-Subject<CollectionReplaceEvent<object>>.Dispose
	|
	|-RVA: 0x36D8E80 Offset: 0x36D8F81 VA: 0x36D8E80
	|-Subject<DictionaryAddEvent<object, object>>.Dispose
	|
	|-RVA: 0x36D9CF0 Offset: 0x36D9DF1 VA: 0x36D9CF0
	|-Subject<DictionaryRemoveEvent<object, object>>.Dispose
	|
	|-RVA: 0x36DAB80 Offset: 0x36DAC81 VA: 0x36DAB80
	|-Subject<DictionaryReplaceEvent<object, object>>.Dispose
	|
	|-RVA: 0x36DB9F0 Offset: 0x36DBAF1 VA: 0x36DB9F0
	|-Subject<ValueTuple<object, object>>.Dispose
	|
	|-RVA: 0x36DC850 Offset: 0x36DC951 VA: 0x36DC850
	|-Subject<ValueTuple<float, int>>.Dispose
	|
	|-RVA: 0x36DD6B0 Offset: 0x36DD7B1 VA: 0x36DD6B0
	|-Subject<ValueTuple<float, Int32Enum>>.Dispose
	|
	|-RVA: 0x36DE510 Offset: 0x36DE611 VA: 0x36DE510
	|-Subject<bool>.Dispose
	|
	|-RVA: 0x36DF370 Offset: 0x36DF471 VA: 0x36DF370
	|-Subject<int>.Dispose
	|
	|-RVA: 0x36E01D0 Offset: 0x36E02D1 VA: 0x36E01D0
	|-Subject<Int32Enum>.Dispose
	|
	|-RVA: 0x36E1090 Offset: 0x36E1191 VA: 0x36E1090
	|-Subject<LogEntry>.Dispose
	|
	|-RVA: 0x36E1EF0 Offset: 0x36E1FF1 VA: 0x36E1EF0
	|-Subject<object>.Dispose
	|
	|-RVA: 0x36E2D50 Offset: 0x36E2E51 VA: 0x36E2D50
	|-Subject<float>.Dispose
	|
	|-RVA: 0x36E3BB0 Offset: 0x36E3CB1 VA: 0x36E3BB0
	|-Subject<Unit>.Dispose
	*/

	// RVA: -1 Offset: -1
	private void ThrowIfDisposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36D5610 Offset: 0x36D5711 VA: 0x36D5610
	|-Subject<CollectionAddEvent<object>>.ThrowIfDisposed
	|
	|-RVA: 0x36D6480 Offset: 0x36D6581 VA: 0x36D6480
	|-Subject<CollectionMoveEvent<object>>.ThrowIfDisposed
	|
	|-RVA: 0x36D72F0 Offset: 0x36D73F1 VA: 0x36D72F0
	|-Subject<CollectionRemoveEvent<object>>.ThrowIfDisposed
	|
	|-RVA: 0x36D8180 Offset: 0x36D8281 VA: 0x36D8180
	|-Subject<CollectionReplaceEvent<object>>.ThrowIfDisposed
	|
	|-RVA: 0x36D8FF0 Offset: 0x36D90F1 VA: 0x36D8FF0
	|-Subject<DictionaryAddEvent<object, object>>.ThrowIfDisposed
	|
	|-RVA: 0x36D9E60 Offset: 0x36D9F61 VA: 0x36D9E60
	|-Subject<DictionaryRemoveEvent<object, object>>.ThrowIfDisposed
	|
	|-RVA: 0x36DACF0 Offset: 0x36DADF1 VA: 0x36DACF0
	|-Subject<DictionaryReplaceEvent<object, object>>.ThrowIfDisposed
	|
	|-RVA: 0x36DBB60 Offset: 0x36DBC61 VA: 0x36DBB60
	|-Subject<ValueTuple<object, object>>.ThrowIfDisposed
	|
	|-RVA: 0x36DC9C0 Offset: 0x36DCAC1 VA: 0x36DC9C0
	|-Subject<ValueTuple<float, int>>.ThrowIfDisposed
	|
	|-RVA: 0x36DD820 Offset: 0x36DD921 VA: 0x36DD820
	|-Subject<ValueTuple<float, Int32Enum>>.ThrowIfDisposed
	|
	|-RVA: 0x36DE680 Offset: 0x36DE781 VA: 0x36DE680
	|-Subject<bool>.ThrowIfDisposed
	|
	|-RVA: 0x36DF4E0 Offset: 0x36DF5E1 VA: 0x36DF4E0
	|-Subject<int>.ThrowIfDisposed
	|
	|-RVA: 0x36E0340 Offset: 0x36E0441 VA: 0x36E0340
	|-Subject<Int32Enum>.ThrowIfDisposed
	|
	|-RVA: 0x36E1200 Offset: 0x36E1301 VA: 0x36E1200
	|-Subject<LogEntry>.ThrowIfDisposed
	|
	|-RVA: 0x36E2060 Offset: 0x36E2161 VA: 0x36E2060
	|-Subject<object>.ThrowIfDisposed
	|
	|-RVA: 0x36E2EC0 Offset: 0x36E2FC1 VA: 0x36E2EC0
	|-Subject<float>.ThrowIfDisposed
	|
	|-RVA: 0x36E3D20 Offset: 0x36E3E21 VA: 0x36E3D20
	|-Subject<Unit>.ThrowIfDisposed
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool IsRequiredSubscribeOnCurrentThread() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36D5680 Offset: 0x36D5781 VA: 0x36D5680
	|-Subject<CollectionAddEvent<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36D64F0 Offset: 0x36D65F1 VA: 0x36D64F0
	|-Subject<CollectionMoveEvent<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36D7360 Offset: 0x36D7461 VA: 0x36D7360
	|-Subject<CollectionRemoveEvent<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36D81F0 Offset: 0x36D82F1 VA: 0x36D81F0
	|-Subject<CollectionReplaceEvent<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36D9060 Offset: 0x36D9161 VA: 0x36D9060
	|-Subject<DictionaryAddEvent<object, object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36D9ED0 Offset: 0x36D9FD1 VA: 0x36D9ED0
	|-Subject<DictionaryRemoveEvent<object, object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36DAD60 Offset: 0x36DAE61 VA: 0x36DAD60
	|-Subject<DictionaryReplaceEvent<object, object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36DBBD0 Offset: 0x36DBCD1 VA: 0x36DBBD0
	|-Subject<ValueTuple<object, object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36DCA30 Offset: 0x36DCB31 VA: 0x36DCA30
	|-Subject<ValueTuple<float, int>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36DD890 Offset: 0x36DD991 VA: 0x36DD890
	|-Subject<ValueTuple<float, Int32Enum>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36DE6F0 Offset: 0x36DE7F1 VA: 0x36DE6F0
	|-Subject<bool>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36DF550 Offset: 0x36DF651 VA: 0x36DF550
	|-Subject<int>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36E03B0 Offset: 0x36E04B1 VA: 0x36E03B0
	|-Subject<Int32Enum>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36E1270 Offset: 0x36E1371 VA: 0x36E1270
	|-Subject<LogEntry>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36E20D0 Offset: 0x36E21D1 VA: 0x36E20D0
	|-Subject<object>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36E2F30 Offset: 0x36E3031 VA: 0x36E2F30
	|-Subject<float>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x36E3D90 Offset: 0x36E3E91 VA: 0x36E3D90
	|-Subject<Unit>.IsRequiredSubscribeOnCurrentThread
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36D5690 Offset: 0x36D5791 VA: 0x36D5690
	|-Subject<CollectionAddEvent<object>>..ctor
	|
	|-RVA: 0x36D6500 Offset: 0x36D6601 VA: 0x36D6500
	|-Subject<CollectionMoveEvent<object>>..ctor
	|
	|-RVA: 0x36D7370 Offset: 0x36D7471 VA: 0x36D7370
	|-Subject<CollectionRemoveEvent<object>>..ctor
	|
	|-RVA: 0x36D8200 Offset: 0x36D8301 VA: 0x36D8200
	|-Subject<CollectionReplaceEvent<object>>..ctor
	|
	|-RVA: 0x36D9070 Offset: 0x36D9171 VA: 0x36D9070
	|-Subject<DictionaryAddEvent<object, object>>..ctor
	|
	|-RVA: 0x36D9EE0 Offset: 0x36D9FE1 VA: 0x36D9EE0
	|-Subject<DictionaryRemoveEvent<object, object>>..ctor
	|
	|-RVA: 0x36DAD70 Offset: 0x36DAE71 VA: 0x36DAD70
	|-Subject<DictionaryReplaceEvent<object, object>>..ctor
	|
	|-RVA: 0x36DBBE0 Offset: 0x36DBCE1 VA: 0x36DBBE0
	|-Subject<ValueTuple<Character, GameObject>>..ctor
	|-Subject<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x36DCA40 Offset: 0x36DCB41 VA: 0x36DCA40
	|-Subject<ValueTuple<float, int>>..ctor
	|
	|-RVA: 0x36DD8A0 Offset: 0x36DD9A1 VA: 0x36DD8A0
	|-Subject<ValueTuple<float, Int32Enum>>..ctor
	|-Subject<ValueTuple<float, WeaponStyle>>..ctor
	|
	|-RVA: 0x36E20E0 Offset: 0x36E21E1 VA: 0x36E20E0
	|-Subject<AnimationEvent>..ctor
	|-Subject<AxisEventData>..ctor
	|-Subject<BaseEventData>..ctor
	|-Subject<Character>..ctor
	|-Subject<Collider>..ctor
	|-Subject<Collider2D>..ctor
	|-Subject<Collision>..ctor
	|-Subject<Collision2D>..ctor
	|-Subject<GameObject>..ctor
	|-Subject<Joint2D>..ctor
	|-Subject<object>..ctor
	|-Subject<Phase>..ctor
	|-Subject<PhaseArray>..ctor
	|-Subject<PointerEventData>..ctor
	|-Subject<ObservableStateMachineTrigger.OnStateInfo>..ctor
	|-Subject<ObservableStateMachineTrigger.OnStateMachineInfo>..ctor
	|
	|-RVA: 0x36DE700 Offset: 0x36DE801 VA: 0x36DE700
	|-Subject<bool>..ctor
	|
	|-RVA: 0x36E03C0 Offset: 0x36E04C1 VA: 0x36E03C0
	|-Subject<CountChangedStatus>..ctor
	|-Subject<Int32Enum>..ctor
	|
	|-RVA: 0x36DF560 Offset: 0x36DF661 VA: 0x36DF560
	|-Subject<int>..ctor
	|
	|-RVA: 0x36E1280 Offset: 0x36E1381 VA: 0x36E1280
	|-Subject<LogEntry>..ctor
	|
	|-RVA: 0x36E2F40 Offset: 0x36E3041 VA: 0x36E2F40
	|-Subject<float>..ctor
	|
	|-RVA: 0x36E3DA0 Offset: 0x36E3EA1 VA: 0x36E3DA0
	|-Subject<Unit>..ctor
	*/
}

