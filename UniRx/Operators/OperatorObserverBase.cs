// Namespace: UniRx.Operators
public abstract class OperatorObserverBase<TSource, TResult> : IDisposable, IObserver<TSource> // TypeDefIndex: 7005
{
	// Fields
	protected internal IObserver<TResult> observer; // 0x0
	private IDisposable cancel; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3719C30 Offset: 0x3719D31 VA: 0x3719C30
	|-OperatorObserverBase<CollectionAddEvent<object>, CollectionAddEvent<object>>..ctor
	|
	|-RVA: 0x3719E00 Offset: 0x3719F01 VA: 0x3719E00
	|-OperatorObserverBase<CollectionMoveEvent<object>, CollectionMoveEvent<object>>..ctor
	|
	|-RVA: 0x2A5AE20 Offset: 0x2A5AF21 VA: 0x2A5AE20
	|-OperatorObserverBase<CollectionRemoveEvent<object>, CollectionRemoveEvent<object>>..ctor
	|
	|-RVA: 0x2A5AFF0 Offset: 0x2A5B0F1 VA: 0x2A5AFF0
	|-OperatorObserverBase<CollectionReplaceEvent<object>, CollectionReplaceEvent<object>>..ctor
	|
	|-RVA: 0x2A5B1C0 Offset: 0x2A5B2C1 VA: 0x2A5B1C0
	|-OperatorObserverBase<DictionaryAddEvent<object, object>, DictionaryAddEvent<object, object>>..ctor
	|
	|-RVA: 0x2A5B390 Offset: 0x2A5B491 VA: 0x2A5B390
	|-OperatorObserverBase<DictionaryRemoveEvent<object, object>, DictionaryRemoveEvent<object, object>>..ctor
	|
	|-RVA: 0x2A5B560 Offset: 0x2A5B661 VA: 0x2A5B560
	|-OperatorObserverBase<DictionaryReplaceEvent<object, object>, DictionaryReplaceEvent<object, object>>..ctor
	|
	|-RVA: 0x2A5B730 Offset: 0x2A5B831 VA: 0x2A5B730
	|-OperatorObserverBase<ValueTuple<object, object>, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2A5B900 Offset: 0x2A5BA01 VA: 0x2A5B900
	|-OperatorObserverBase<ValueTuple<float, int>, ValueTuple<float, int>>..ctor
	|
	|-RVA: 0x2A5BAD0 Offset: 0x2A5BBD1 VA: 0x2A5BAD0
	|-OperatorObserverBase<ValueTuple<float, Int32Enum>, ValueTuple<float, Int32Enum>>..ctor
	|
	|-RVA: 0x2A5BCA0 Offset: 0x2A5BDA1 VA: 0x2A5BCA0
	|-OperatorObserverBase<bool, bool>..ctor
	|
	|-RVA: 0x2A5BE70 Offset: 0x2A5BF71 VA: 0x2A5BE70
	|-OperatorObserverBase<int, Pair<int>>..ctor
	|
	|-RVA: 0x2A5C040 Offset: 0x2A5C141 VA: 0x2A5C040
	|-OperatorObserverBase<int, int>..ctor
	|
	|-RVA: 0x2A5C210 Offset: 0x2A5C311 VA: 0x2A5C210
	|-OperatorObserverBase<long, long>..ctor
	|
	|-RVA: 0x2A5C3E0 Offset: 0x2A5C4E1 VA: 0x2A5C3E0
	|-OperatorObserverBase<long, object>..ctor
	|
	|-RVA: 0x2A5C5B0 Offset: 0x2A5C6B1 VA: 0x2A5C5B0
	|-OperatorObserverBase<object, FrameInterval<object>>..ctor
	|
	|-RVA: 0x2A5C780 Offset: 0x2A5C881 VA: 0x2A5C780
	|-OperatorObserverBase<object, Pair<object>>..ctor
	|
	|-RVA: 0x2A5C950 Offset: 0x2A5CA51 VA: 0x2A5C950
	|-OperatorObserverBase<object, TimeInterval<object>>..ctor
	|
	|-RVA: 0x2A5CB20 Offset: 0x2A5CC21 VA: 0x2A5CB20
	|-OperatorObserverBase<object, Timestamped<object>>..ctor
	|
	|-RVA: 0x2A5CCF0 Offset: 0x2A5CDF1 VA: 0x2A5CCF0
	|-OperatorObserverBase<object, bool>..ctor
	|
	|-RVA: 0x2A5CEC0 Offset: 0x2A5CFC1 VA: 0x2A5CEC0
	|-OperatorObserverBase<object, object>..ctor
	|
	|-RVA: 0x2A5D090 Offset: 0x2A5D191 VA: 0x2A5D090
	|-OperatorObserverBase<object, Unit>..ctor
	|
	|-RVA: 0x2A5D260 Offset: 0x2A5D361 VA: 0x2A5D260
	|-OperatorObserverBase<float, float>..ctor
	|
	|-RVA: 0x2A5D430 Offset: 0x2A5D531 VA: 0x2A5D430
	|-OperatorObserverBase<Unit, long>..ctor
	|
	|-RVA: 0x2A5D600 Offset: 0x2A5D701 VA: 0x2A5D600
	|-OperatorObserverBase<Unit, object>..ctor
	|
	|-RVA: 0x2A5D7D0 Offset: 0x2A5D8D1 VA: 0x2A5D7D0
	|-OperatorObserverBase<Unit, Unit>..ctor
	|
	|-RVA: 0x2A5D9A0 Offset: 0x2A5DAA1 VA: 0x2A5D9A0
	|-OperatorObserverBase<Vector2, Vector2>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OnNext(TSource value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-OperatorObserverBase<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OnError(Exception error);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-OperatorObserverBase<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnCompleted();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-OperatorObserverBase<object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3719C90 Offset: 0x3719D91 VA: 0x3719C90
	|-OperatorObserverBase<CollectionAddEvent<object>, CollectionAddEvent<object>>.Dispose
	|
	|-RVA: 0x3719E60 Offset: 0x3719F61 VA: 0x3719E60
	|-OperatorObserverBase<CollectionMoveEvent<object>, CollectionMoveEvent<object>>.Dispose
	|
	|-RVA: 0x2A5AE80 Offset: 0x2A5AF81 VA: 0x2A5AE80
	|-OperatorObserverBase<CollectionRemoveEvent<object>, CollectionRemoveEvent<object>>.Dispose
	|
	|-RVA: 0x2A5B050 Offset: 0x2A5B151 VA: 0x2A5B050
	|-OperatorObserverBase<CollectionReplaceEvent<object>, CollectionReplaceEvent<object>>.Dispose
	|
	|-RVA: 0x2A5B220 Offset: 0x2A5B321 VA: 0x2A5B220
	|-OperatorObserverBase<DictionaryAddEvent<object, object>, DictionaryAddEvent<object, object>>.Dispose
	|
	|-RVA: 0x2A5B3F0 Offset: 0x2A5B4F1 VA: 0x2A5B3F0
	|-OperatorObserverBase<DictionaryRemoveEvent<object, object>, DictionaryRemoveEvent<object, object>>.Dispose
	|
	|-RVA: 0x2A5B5C0 Offset: 0x2A5B6C1 VA: 0x2A5B5C0
	|-OperatorObserverBase<DictionaryReplaceEvent<object, object>, DictionaryReplaceEvent<object, object>>.Dispose
	|
	|-RVA: 0x2A5B790 Offset: 0x2A5B891 VA: 0x2A5B790
	|-OperatorObserverBase<ValueTuple<object, object>, ValueTuple<object, object>>.Dispose
	|
	|-RVA: 0x2A5B960 Offset: 0x2A5BA61 VA: 0x2A5B960
	|-OperatorObserverBase<ValueTuple<float, int>, ValueTuple<float, int>>.Dispose
	|
	|-RVA: 0x2A5BB30 Offset: 0x2A5BC31 VA: 0x2A5BB30
	|-OperatorObserverBase<ValueTuple<float, Int32Enum>, ValueTuple<float, Int32Enum>>.Dispose
	|
	|-RVA: 0x2A5BD00 Offset: 0x2A5BE01 VA: 0x2A5BD00
	|-OperatorObserverBase<bool, bool>.Dispose
	|
	|-RVA: 0x2A5BED0 Offset: 0x2A5BFD1 VA: 0x2A5BED0
	|-OperatorObserverBase<int, Pair<int>>.Dispose
	|
	|-RVA: 0x2A5C0A0 Offset: 0x2A5C1A1 VA: 0x2A5C0A0
	|-OperatorObserverBase<int, int>.Dispose
	|
	|-RVA: 0x2A5C270 Offset: 0x2A5C371 VA: 0x2A5C270
	|-OperatorObserverBase<long, long>.Dispose
	|
	|-RVA: 0x2A5C440 Offset: 0x2A5C541 VA: 0x2A5C440
	|-OperatorObserverBase<long, object>.Dispose
	|
	|-RVA: 0x2A5C610 Offset: 0x2A5C711 VA: 0x2A5C610
	|-OperatorObserverBase<object, FrameInterval<object>>.Dispose
	|
	|-RVA: 0x2A5C7E0 Offset: 0x2A5C8E1 VA: 0x2A5C7E0
	|-OperatorObserverBase<object, Pair<object>>.Dispose
	|
	|-RVA: 0x2A5C9B0 Offset: 0x2A5CAB1 VA: 0x2A5C9B0
	|-OperatorObserverBase<object, TimeInterval<object>>.Dispose
	|
	|-RVA: 0x2A5CB80 Offset: 0x2A5CC81 VA: 0x2A5CB80
	|-OperatorObserverBase<object, Timestamped<object>>.Dispose
	|
	|-RVA: 0x2A5CD50 Offset: 0x2A5CE51 VA: 0x2A5CD50
	|-OperatorObserverBase<object, bool>.Dispose
	|
	|-RVA: 0x2A5CF20 Offset: 0x2A5D021 VA: 0x2A5CF20
	|-OperatorObserverBase<object, object>.Dispose
	|
	|-RVA: 0x2A5D0F0 Offset: 0x2A5D1F1 VA: 0x2A5D0F0
	|-OperatorObserverBase<object, Unit>.Dispose
	|
	|-RVA: 0x2A5D2C0 Offset: 0x2A5D3C1 VA: 0x2A5D2C0
	|-OperatorObserverBase<float, float>.Dispose
	|
	|-RVA: 0x2A5D490 Offset: 0x2A5D591 VA: 0x2A5D490
	|-OperatorObserverBase<Unit, long>.Dispose
	|
	|-RVA: 0x2A5D660 Offset: 0x2A5D761 VA: 0x2A5D660
	|-OperatorObserverBase<Unit, object>.Dispose
	|
	|-RVA: 0x2A5D830 Offset: 0x2A5D931 VA: 0x2A5D830
	|-OperatorObserverBase<Unit, Unit>.Dispose
	|
	|-RVA: 0x2A5DA00 Offset: 0x2A5DB01 VA: 0x2A5DA00
	|-OperatorObserverBase<Vector2, Vector2>.Dispose
	*/
}

