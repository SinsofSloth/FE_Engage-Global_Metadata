// Namespace: UniRx.Operators
internal class ImmutableEmptyObservable<T> : IObservable<T>, IOptimizedObservable<T> // TypeDefIndex: 6960
{
	// Fields
	internal static ImmutableEmptyObservable<T> Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB0C00 Offset: 0x1EB0D01 VA: 0x1EB0C00
	|-ImmutableEmptyObservable<CollectionAddEvent<object>>..ctor
	|
	|-RVA: 0x1EB0DF0 Offset: 0x1EB0EF1 VA: 0x1EB0DF0
	|-ImmutableEmptyObservable<CollectionMoveEvent<object>>..ctor
	|
	|-RVA: 0x1EB0FE0 Offset: 0x1EB10E1 VA: 0x1EB0FE0
	|-ImmutableEmptyObservable<CollectionRemoveEvent<object>>..ctor
	|
	|-RVA: 0x1EB11D0 Offset: 0x1EB12D1 VA: 0x1EB11D0
	|-ImmutableEmptyObservable<CollectionReplaceEvent<object>>..ctor
	|
	|-RVA: 0x1EB13C0 Offset: 0x1EB14C1 VA: 0x1EB13C0
	|-ImmutableEmptyObservable<DictionaryAddEvent<object, object>>..ctor
	|
	|-RVA: 0x1EB15B0 Offset: 0x1EB16B1 VA: 0x1EB15B0
	|-ImmutableEmptyObservable<DictionaryRemoveEvent<object, object>>..ctor
	|
	|-RVA: 0x1EB17A0 Offset: 0x1EB18A1 VA: 0x1EB17A0
	|-ImmutableEmptyObservable<DictionaryReplaceEvent<object, object>>..ctor
	|
	|-RVA: 0x1EB1990 Offset: 0x1EB1A91 VA: 0x1EB1990
	|-ImmutableEmptyObservable<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x1EB1B80 Offset: 0x1EB1C81 VA: 0x1EB1B80
	|-ImmutableEmptyObservable<int>..ctor
	|
	|-RVA: 0x1EB1D70 Offset: 0x1EB1E71 VA: 0x1EB1D70
	|-ImmutableEmptyObservable<long>..ctor
	|
	|-RVA: 0x1EB1F60 Offset: 0x1EB2061 VA: 0x1EB1F60
	|-ImmutableEmptyObservable<object>..ctor
	|
	|-RVA: 0x1EB2150 Offset: 0x1EB2251 VA: 0x1EB2150
	|-ImmutableEmptyObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool IsRequiredSubscribeOnCurrentThread() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB0C10 Offset: 0x1EB0D11 VA: 0x1EB0C10
	|-ImmutableEmptyObservable<CollectionAddEvent<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x1EB0E00 Offset: 0x1EB0F01 VA: 0x1EB0E00
	|-ImmutableEmptyObservable<CollectionMoveEvent<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x1EB0FF0 Offset: 0x1EB10F1 VA: 0x1EB0FF0
	|-ImmutableEmptyObservable<CollectionRemoveEvent<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x1EB11E0 Offset: 0x1EB12E1 VA: 0x1EB11E0
	|-ImmutableEmptyObservable<CollectionReplaceEvent<object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x1EB13D0 Offset: 0x1EB14D1 VA: 0x1EB13D0
	|-ImmutableEmptyObservable<DictionaryAddEvent<object, object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x1EB15C0 Offset: 0x1EB16C1 VA: 0x1EB15C0
	|-ImmutableEmptyObservable<DictionaryRemoveEvent<object, object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x1EB17B0 Offset: 0x1EB18B1 VA: 0x1EB17B0
	|-ImmutableEmptyObservable<DictionaryReplaceEvent<object, object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x1EB19A0 Offset: 0x1EB1AA1 VA: 0x1EB19A0
	|-ImmutableEmptyObservable<ValueTuple<object, object>>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x1EB1B90 Offset: 0x1EB1C91 VA: 0x1EB1B90
	|-ImmutableEmptyObservable<int>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x1EB1D80 Offset: 0x1EB1E81 VA: 0x1EB1D80
	|-ImmutableEmptyObservable<long>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x1EB1F70 Offset: 0x1EB2071 VA: 0x1EB1F70
	|-ImmutableEmptyObservable<object>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x1EB2160 Offset: 0x1EB2261 VA: 0x1EB2160
	|-ImmutableEmptyObservable<Unit>.IsRequiredSubscribeOnCurrentThread
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IDisposable Subscribe(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB0C20 Offset: 0x1EB0D21 VA: 0x1EB0C20
	|-ImmutableEmptyObservable<CollectionAddEvent<object>>.Subscribe
	|
	|-RVA: 0x1EB0E10 Offset: 0x1EB0F11 VA: 0x1EB0E10
	|-ImmutableEmptyObservable<CollectionMoveEvent<object>>.Subscribe
	|
	|-RVA: 0x1EB1000 Offset: 0x1EB1101 VA: 0x1EB1000
	|-ImmutableEmptyObservable<CollectionRemoveEvent<object>>.Subscribe
	|
	|-RVA: 0x1EB11F0 Offset: 0x1EB12F1 VA: 0x1EB11F0
	|-ImmutableEmptyObservable<CollectionReplaceEvent<object>>.Subscribe
	|
	|-RVA: 0x1EB13E0 Offset: 0x1EB14E1 VA: 0x1EB13E0
	|-ImmutableEmptyObservable<DictionaryAddEvent<object, object>>.Subscribe
	|
	|-RVA: 0x1EB15D0 Offset: 0x1EB16D1 VA: 0x1EB15D0
	|-ImmutableEmptyObservable<DictionaryRemoveEvent<object, object>>.Subscribe
	|
	|-RVA: 0x1EB17C0 Offset: 0x1EB18C1 VA: 0x1EB17C0
	|-ImmutableEmptyObservable<DictionaryReplaceEvent<object, object>>.Subscribe
	|
	|-RVA: 0x1EB19B0 Offset: 0x1EB1AB1 VA: 0x1EB19B0
	|-ImmutableEmptyObservable<ValueTuple<object, object>>.Subscribe
	|
	|-RVA: 0x1EB1BA0 Offset: 0x1EB1CA1 VA: 0x1EB1BA0
	|-ImmutableEmptyObservable<int>.Subscribe
	|
	|-RVA: 0x1EB1D90 Offset: 0x1EB1E91 VA: 0x1EB1D90
	|-ImmutableEmptyObservable<long>.Subscribe
	|
	|-RVA: 0x1EB1F80 Offset: 0x1EB2081 VA: 0x1EB1F80
	|-ImmutableEmptyObservable<object>.Subscribe
	|
	|-RVA: 0x1EB2170 Offset: 0x1EB2271 VA: 0x1EB2170
	|-ImmutableEmptyObservable<Unit>.Subscribe
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB0D10 Offset: 0x1EB0E11 VA: 0x1EB0D10
	|-ImmutableEmptyObservable<CollectionAddEvent<object>>..cctor
	|
	|-RVA: 0x1EB0F00 Offset: 0x1EB1001 VA: 0x1EB0F00
	|-ImmutableEmptyObservable<CollectionMoveEvent<object>>..cctor
	|
	|-RVA: 0x1EB10F0 Offset: 0x1EB11F1 VA: 0x1EB10F0
	|-ImmutableEmptyObservable<CollectionRemoveEvent<object>>..cctor
	|
	|-RVA: 0x1EB12E0 Offset: 0x1EB13E1 VA: 0x1EB12E0
	|-ImmutableEmptyObservable<CollectionReplaceEvent<object>>..cctor
	|
	|-RVA: 0x1EB14D0 Offset: 0x1EB15D1 VA: 0x1EB14D0
	|-ImmutableEmptyObservable<DictionaryAddEvent<object, object>>..cctor
	|
	|-RVA: 0x1EB16C0 Offset: 0x1EB17C1 VA: 0x1EB16C0
	|-ImmutableEmptyObservable<DictionaryRemoveEvent<object, object>>..cctor
	|
	|-RVA: 0x1EB18B0 Offset: 0x1EB19B1 VA: 0x1EB18B0
	|-ImmutableEmptyObservable<DictionaryReplaceEvent<object, object>>..cctor
	|
	|-RVA: 0x1EB1AA0 Offset: 0x1EB1BA1 VA: 0x1EB1AA0
	|-ImmutableEmptyObservable<ValueTuple<object, object>>..cctor
	|
	|-RVA: 0x1EB1C90 Offset: 0x1EB1D91 VA: 0x1EB1C90
	|-ImmutableEmptyObservable<int>..cctor
	|
	|-RVA: 0x1EB1E80 Offset: 0x1EB1F81 VA: 0x1EB1E80
	|-ImmutableEmptyObservable<long>..cctor
	|
	|-RVA: 0x1EB2070 Offset: 0x1EB2171 VA: 0x1EB2070
	|-ImmutableEmptyObservable<object>..cctor
	|
	|-RVA: 0x1EB2260 Offset: 0x1EB2361 VA: 0x1EB2260
	|-ImmutableEmptyObservable<Unit>..cctor
	*/
}

