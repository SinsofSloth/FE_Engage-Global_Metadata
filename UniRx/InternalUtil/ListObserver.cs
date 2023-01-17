// Namespace: UniRx.InternalUtil
public class ListObserver<T> : IObserver<T> // TypeDefIndex: 7236
{
	// Fields
	private readonly ImmutableList<IObserver<T>> _observers; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ImmutableList<IObserver<T>> observers) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B010B0 Offset: 0x3B011B1 VA: 0x3B010B0
	|-ListObserver<CollectionAddEvent<object>>..ctor
	|
	|-RVA: 0x3B015F0 Offset: 0x3B016F1 VA: 0x3B015F0
	|-ListObserver<CollectionMoveEvent<object>>..ctor
	|
	|-RVA: 0x3B01B30 Offset: 0x3B01C31 VA: 0x3B01B30
	|-ListObserver<CollectionRemoveEvent<object>>..ctor
	|
	|-RVA: 0x3B02070 Offset: 0x3B02171 VA: 0x3B02070
	|-ListObserver<CollectionReplaceEvent<object>>..ctor
	|
	|-RVA: 0x3B025E0 Offset: 0x3B026E1 VA: 0x3B025E0
	|-ListObserver<DictionaryAddEvent<object, object>>..ctor
	|
	|-RVA: 0x3B02B20 Offset: 0x3B02C21 VA: 0x3B02B20
	|-ListObserver<DictionaryRemoveEvent<object, object>>..ctor
	|
	|-RVA: 0x3B03060 Offset: 0x3B03161 VA: 0x3B03060
	|-ListObserver<DictionaryReplaceEvent<object, object>>..ctor
	|
	|-RVA: 0x3B035D0 Offset: 0x3B036D1 VA: 0x3B035D0
	|-ListObserver<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x3B03B10 Offset: 0x3B03C11 VA: 0x3B03B10
	|-ListObserver<ValueTuple<float, int>>..ctor
	|
	|-RVA: 0x3B04040 Offset: 0x3B04141 VA: 0x3B04040
	|-ListObserver<ValueTuple<float, Int32Enum>>..ctor
	|
	|-RVA: 0x3B04570 Offset: 0x3B04671 VA: 0x3B04570
	|-ListObserver<bool>..ctor
	|
	|-RVA: 0x3B04AA0 Offset: 0x3B04BA1 VA: 0x3B04AA0
	|-ListObserver<int>..ctor
	|
	|-RVA: 0x3B04FD0 Offset: 0x3B050D1 VA: 0x3B04FD0
	|-ListObserver<Int32Enum>..ctor
	|
	|-RVA: 0x3B05500 Offset: 0x3B05601 VA: 0x3B05500
	|-ListObserver<LogEntry>..ctor
	|
	|-RVA: 0x3B05AA0 Offset: 0x3B05BA1 VA: 0x3B05AA0
	|-ListObserver<object>..ctor
	|
	|-RVA: 0x3B05FD0 Offset: 0x3B060D1 VA: 0x3B05FD0
	|-ListObserver<float>..ctor
	|
	|-RVA: 0x3B06510 Offset: 0x3B06611 VA: 0x3B06510
	|-ListObserver<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B010F0 Offset: 0x3B011F1 VA: 0x3B010F0
	|-ListObserver<CollectionAddEvent<object>>.OnCompleted
	|
	|-RVA: 0x3B01630 Offset: 0x3B01731 VA: 0x3B01630
	|-ListObserver<CollectionMoveEvent<object>>.OnCompleted
	|
	|-RVA: 0x3B01B70 Offset: 0x3B01C71 VA: 0x3B01B70
	|-ListObserver<CollectionRemoveEvent<object>>.OnCompleted
	|
	|-RVA: 0x3B020B0 Offset: 0x3B021B1 VA: 0x3B020B0
	|-ListObserver<CollectionReplaceEvent<object>>.OnCompleted
	|
	|-RVA: 0x3B02620 Offset: 0x3B02721 VA: 0x3B02620
	|-ListObserver<DictionaryAddEvent<object, object>>.OnCompleted
	|
	|-RVA: 0x3B02B60 Offset: 0x3B02C61 VA: 0x3B02B60
	|-ListObserver<DictionaryRemoveEvent<object, object>>.OnCompleted
	|
	|-RVA: 0x3B030A0 Offset: 0x3B031A1 VA: 0x3B030A0
	|-ListObserver<DictionaryReplaceEvent<object, object>>.OnCompleted
	|
	|-RVA: 0x3B03610 Offset: 0x3B03711 VA: 0x3B03610
	|-ListObserver<ValueTuple<object, object>>.OnCompleted
	|
	|-RVA: 0x3B03B50 Offset: 0x3B03C51 VA: 0x3B03B50
	|-ListObserver<ValueTuple<float, int>>.OnCompleted
	|
	|-RVA: 0x3B04080 Offset: 0x3B04181 VA: 0x3B04080
	|-ListObserver<ValueTuple<float, Int32Enum>>.OnCompleted
	|
	|-RVA: 0x3B045B0 Offset: 0x3B046B1 VA: 0x3B045B0
	|-ListObserver<bool>.OnCompleted
	|
	|-RVA: 0x3B04AE0 Offset: 0x3B04BE1 VA: 0x3B04AE0
	|-ListObserver<int>.OnCompleted
	|
	|-RVA: 0x3B05010 Offset: 0x3B05111 VA: 0x3B05010
	|-ListObserver<Int32Enum>.OnCompleted
	|
	|-RVA: 0x3B05540 Offset: 0x3B05641 VA: 0x3B05540
	|-ListObserver<LogEntry>.OnCompleted
	|
	|-RVA: 0x3B05AE0 Offset: 0x3B05BE1 VA: 0x3B05AE0
	|-ListObserver<object>.OnCompleted
	|
	|-RVA: 0x3B06010 Offset: 0x3B06111 VA: 0x3B06010
	|-ListObserver<float>.OnCompleted
	|
	|-RVA: 0x3B06550 Offset: 0x3B06651 VA: 0x3B06550
	|-ListObserver<Unit>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B01200 Offset: 0x3B01301 VA: 0x3B01200
	|-ListObserver<CollectionAddEvent<object>>.OnError
	|
	|-RVA: 0x3B01740 Offset: 0x3B01841 VA: 0x3B01740
	|-ListObserver<CollectionMoveEvent<object>>.OnError
	|
	|-RVA: 0x3B01C80 Offset: 0x3B01D81 VA: 0x3B01C80
	|-ListObserver<CollectionRemoveEvent<object>>.OnError
	|
	|-RVA: 0x3B021C0 Offset: 0x3B022C1 VA: 0x3B021C0
	|-ListObserver<CollectionReplaceEvent<object>>.OnError
	|
	|-RVA: 0x3B02730 Offset: 0x3B02831 VA: 0x3B02730
	|-ListObserver<DictionaryAddEvent<object, object>>.OnError
	|
	|-RVA: 0x3B02C70 Offset: 0x3B02D71 VA: 0x3B02C70
	|-ListObserver<DictionaryRemoveEvent<object, object>>.OnError
	|
	|-RVA: 0x3B031B0 Offset: 0x3B032B1 VA: 0x3B031B0
	|-ListObserver<DictionaryReplaceEvent<object, object>>.OnError
	|
	|-RVA: 0x3B03720 Offset: 0x3B03821 VA: 0x3B03720
	|-ListObserver<ValueTuple<object, object>>.OnError
	|
	|-RVA: 0x3B03C60 Offset: 0x3B03D61 VA: 0x3B03C60
	|-ListObserver<ValueTuple<float, int>>.OnError
	|
	|-RVA: 0x3B04190 Offset: 0x3B04291 VA: 0x3B04190
	|-ListObserver<ValueTuple<float, Int32Enum>>.OnError
	|
	|-RVA: 0x3B046C0 Offset: 0x3B047C1 VA: 0x3B046C0
	|-ListObserver<bool>.OnError
	|
	|-RVA: 0x3B04BF0 Offset: 0x3B04CF1 VA: 0x3B04BF0
	|-ListObserver<int>.OnError
	|
	|-RVA: 0x3B05120 Offset: 0x3B05221 VA: 0x3B05120
	|-ListObserver<Int32Enum>.OnError
	|
	|-RVA: 0x3B05650 Offset: 0x3B05751 VA: 0x3B05650
	|-ListObserver<LogEntry>.OnError
	|
	|-RVA: 0x3B05BF0 Offset: 0x3B05CF1 VA: 0x3B05BF0
	|-ListObserver<object>.OnError
	|
	|-RVA: 0x3B06120 Offset: 0x3B06221 VA: 0x3B06120
	|-ListObserver<float>.OnError
	|
	|-RVA: 0x3B06660 Offset: 0x3B06761 VA: 0x3B06660
	|-ListObserver<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B01310 Offset: 0x3B01411 VA: 0x3B01310
	|-ListObserver<CollectionAddEvent<object>>.OnNext
	|
	|-RVA: 0x3B01850 Offset: 0x3B01951 VA: 0x3B01850
	|-ListObserver<CollectionMoveEvent<object>>.OnNext
	|
	|-RVA: 0x3B01D90 Offset: 0x3B01E91 VA: 0x3B01D90
	|-ListObserver<CollectionRemoveEvent<object>>.OnNext
	|
	|-RVA: 0x3B022D0 Offset: 0x3B023D1 VA: 0x3B022D0
	|-ListObserver<CollectionReplaceEvent<object>>.OnNext
	|
	|-RVA: 0x3B02840 Offset: 0x3B02941 VA: 0x3B02840
	|-ListObserver<DictionaryAddEvent<object, object>>.OnNext
	|
	|-RVA: 0x3B02D80 Offset: 0x3B02E81 VA: 0x3B02D80
	|-ListObserver<DictionaryRemoveEvent<object, object>>.OnNext
	|
	|-RVA: 0x3B032C0 Offset: 0x3B033C1 VA: 0x3B032C0
	|-ListObserver<DictionaryReplaceEvent<object, object>>.OnNext
	|
	|-RVA: 0x3B03830 Offset: 0x3B03931 VA: 0x3B03830
	|-ListObserver<ValueTuple<object, object>>.OnNext
	|
	|-RVA: 0x3B03D70 Offset: 0x3B03E71 VA: 0x3B03D70
	|-ListObserver<ValueTuple<float, int>>.OnNext
	|
	|-RVA: 0x3B042A0 Offset: 0x3B043A1 VA: 0x3B042A0
	|-ListObserver<ValueTuple<float, Int32Enum>>.OnNext
	|
	|-RVA: 0x3B047D0 Offset: 0x3B048D1 VA: 0x3B047D0
	|-ListObserver<bool>.OnNext
	|
	|-RVA: 0x3B04D00 Offset: 0x3B04E01 VA: 0x3B04D00
	|-ListObserver<int>.OnNext
	|
	|-RVA: 0x3B05230 Offset: 0x3B05331 VA: 0x3B05230
	|-ListObserver<Int32Enum>.OnNext
	|
	|-RVA: 0x3B05760 Offset: 0x3B05861 VA: 0x3B05760
	|-ListObserver<LogEntry>.OnNext
	|
	|-RVA: 0x3B05D00 Offset: 0x3B05E01 VA: 0x3B05D00
	|-ListObserver<object>.OnNext
	|
	|-RVA: 0x3B06230 Offset: 0x3B06331 VA: 0x3B06230
	|-ListObserver<float>.OnNext
	|
	|-RVA: 0x3B06770 Offset: 0x3B06871 VA: 0x3B06770
	|-ListObserver<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1
	internal IObserver<T> Add(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B01430 Offset: 0x3B01531 VA: 0x3B01430
	|-ListObserver<CollectionAddEvent<object>>.Add
	|
	|-RVA: 0x3B01970 Offset: 0x3B01A71 VA: 0x3B01970
	|-ListObserver<CollectionMoveEvent<object>>.Add
	|
	|-RVA: 0x3B01EB0 Offset: 0x3B01FB1 VA: 0x3B01EB0
	|-ListObserver<CollectionRemoveEvent<object>>.Add
	|
	|-RVA: 0x3B02420 Offset: 0x3B02521 VA: 0x3B02420
	|-ListObserver<CollectionReplaceEvent<object>>.Add
	|
	|-RVA: 0x3B02960 Offset: 0x3B02A61 VA: 0x3B02960
	|-ListObserver<DictionaryAddEvent<object, object>>.Add
	|
	|-RVA: 0x3B02EA0 Offset: 0x3B02FA1 VA: 0x3B02EA0
	|-ListObserver<DictionaryRemoveEvent<object, object>>.Add
	|
	|-RVA: 0x3B03410 Offset: 0x3B03511 VA: 0x3B03410
	|-ListObserver<DictionaryReplaceEvent<object, object>>.Add
	|
	|-RVA: 0x3B03950 Offset: 0x3B03A51 VA: 0x3B03950
	|-ListObserver<ValueTuple<object, object>>.Add
	|
	|-RVA: 0x3B03E80 Offset: 0x3B03F81 VA: 0x3B03E80
	|-ListObserver<ValueTuple<float, int>>.Add
	|
	|-RVA: 0x3B043B0 Offset: 0x3B044B1 VA: 0x3B043B0
	|-ListObserver<ValueTuple<float, Int32Enum>>.Add
	|
	|-RVA: 0x3B048E0 Offset: 0x3B049E1 VA: 0x3B048E0
	|-ListObserver<bool>.Add
	|
	|-RVA: 0x3B04E10 Offset: 0x3B04F11 VA: 0x3B04E10
	|-ListObserver<int>.Add
	|
	|-RVA: 0x3B05340 Offset: 0x3B05441 VA: 0x3B05340
	|-ListObserver<Int32Enum>.Add
	|
	|-RVA: 0x3B058E0 Offset: 0x3B059E1 VA: 0x3B058E0
	|-ListObserver<LogEntry>.Add
	|
	|-RVA: 0x3B05E10 Offset: 0x3B05F11 VA: 0x3B05E10
	|-ListObserver<object>.Add
	|
	|-RVA: 0x3B06350 Offset: 0x3B06451 VA: 0x3B06350
	|-ListObserver<float>.Add
	|
	|-RVA: 0x3B06880 Offset: 0x3B06981 VA: 0x3B06880
	|-ListObserver<Unit>.Add
	*/

	// RVA: -1 Offset: -1
	internal IObserver<T> Remove(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B014C0 Offset: 0x3B015C1 VA: 0x3B014C0
	|-ListObserver<CollectionAddEvent<object>>.Remove
	|
	|-RVA: 0x3B01A00 Offset: 0x3B01B01 VA: 0x3B01A00
	|-ListObserver<CollectionMoveEvent<object>>.Remove
	|
	|-RVA: 0x3B01F40 Offset: 0x3B02041 VA: 0x3B01F40
	|-ListObserver<CollectionRemoveEvent<object>>.Remove
	|
	|-RVA: 0x3B024B0 Offset: 0x3B025B1 VA: 0x3B024B0
	|-ListObserver<CollectionReplaceEvent<object>>.Remove
	|
	|-RVA: 0x3B029F0 Offset: 0x3B02AF1 VA: 0x3B029F0
	|-ListObserver<DictionaryAddEvent<object, object>>.Remove
	|
	|-RVA: 0x3B02F30 Offset: 0x3B03031 VA: 0x3B02F30
	|-ListObserver<DictionaryRemoveEvent<object, object>>.Remove
	|
	|-RVA: 0x3B034A0 Offset: 0x3B035A1 VA: 0x3B034A0
	|-ListObserver<DictionaryReplaceEvent<object, object>>.Remove
	|
	|-RVA: 0x3B039E0 Offset: 0x3B03AE1 VA: 0x3B039E0
	|-ListObserver<ValueTuple<object, object>>.Remove
	|
	|-RVA: 0x3B03F10 Offset: 0x3B04011 VA: 0x3B03F10
	|-ListObserver<ValueTuple<float, int>>.Remove
	|
	|-RVA: 0x3B04440 Offset: 0x3B04541 VA: 0x3B04440
	|-ListObserver<ValueTuple<float, Int32Enum>>.Remove
	|
	|-RVA: 0x3B04970 Offset: 0x3B04A71 VA: 0x3B04970
	|-ListObserver<bool>.Remove
	|
	|-RVA: 0x3B04EA0 Offset: 0x3B04FA1 VA: 0x3B04EA0
	|-ListObserver<int>.Remove
	|
	|-RVA: 0x3B053D0 Offset: 0x3B054D1 VA: 0x3B053D0
	|-ListObserver<Int32Enum>.Remove
	|
	|-RVA: 0x3B05970 Offset: 0x3B05A71 VA: 0x3B05970
	|-ListObserver<LogEntry>.Remove
	|
	|-RVA: 0x3B05EA0 Offset: 0x3B05FA1 VA: 0x3B05EA0
	|-ListObserver<object>.Remove
	|
	|-RVA: 0x3B063E0 Offset: 0x3B064E1 VA: 0x3B063E0
	|-ListObserver<float>.Remove
	|
	|-RVA: 0x3B06910 Offset: 0x3B06A11 VA: 0x3B06910
	|-ListObserver<Unit>.Remove
	*/
}

