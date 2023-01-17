// Namespace: 
private class Subject.Subscription<T> : IDisposable // TypeDefIndex: 6643
{
	// Fields
	private readonly object gate; // 0x0
	private Subject<T> parent; // 0x0
	private IObserver<T> unsubscribeTarget; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Subject<T> parent, IObserver<T> unsubscribeTarget) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AC9D0 Offset: 0x34ACAD1 VA: 0x34AC9D0
	|-Subject.Subscription<CollectionAddEvent<object>>..ctor
	|
	|-RVA: 0x34ACD60 Offset: 0x34ACE61 VA: 0x34ACD60
	|-Subject.Subscription<CollectionMoveEvent<object>>..ctor
	|
	|-RVA: 0x34AD0F0 Offset: 0x34AD1F1 VA: 0x34AD0F0
	|-Subject.Subscription<CollectionRemoveEvent<object>>..ctor
	|
	|-RVA: 0x34AD480 Offset: 0x34AD581 VA: 0x34AD480
	|-Subject.Subscription<CollectionReplaceEvent<object>>..ctor
	|
	|-RVA: 0x34AD810 Offset: 0x34AD911 VA: 0x34AD810
	|-Subject.Subscription<DictionaryAddEvent<object, object>>..ctor
	|
	|-RVA: 0x34ADBA0 Offset: 0x34ADCA1 VA: 0x34ADBA0
	|-Subject.Subscription<DictionaryRemoveEvent<object, object>>..ctor
	|
	|-RVA: 0x34ADF30 Offset: 0x34AE031 VA: 0x34ADF30
	|-Subject.Subscription<DictionaryReplaceEvent<object, object>>..ctor
	|
	|-RVA: 0x34AE2C0 Offset: 0x34AE3C1 VA: 0x34AE2C0
	|-Subject.Subscription<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x34AE650 Offset: 0x34AE751 VA: 0x34AE650
	|-Subject.Subscription<ValueTuple<float, int>>..ctor
	|
	|-RVA: 0x34AE9E0 Offset: 0x34AEAE1 VA: 0x34AE9E0
	|-Subject.Subscription<ValueTuple<float, Int32Enum>>..ctor
	|
	|-RVA: 0x34AED70 Offset: 0x34AEE71 VA: 0x34AED70
	|-Subject.Subscription<bool>..ctor
	|
	|-RVA: 0x34AF100 Offset: 0x34AF201 VA: 0x34AF100
	|-Subject.Subscription<int>..ctor
	|
	|-RVA: 0x34AF490 Offset: 0x34AF591 VA: 0x34AF490
	|-Subject.Subscription<Int32Enum>..ctor
	|
	|-RVA: 0x34AF820 Offset: 0x34AF921 VA: 0x34AF820
	|-Subject.Subscription<LogEntry>..ctor
	|
	|-RVA: 0x34B07B0 Offset: 0x34B08B1 VA: 0x34B07B0
	|-Subject.Subscription<object>..ctor
	|
	|-RVA: 0x34B0B40 Offset: 0x34B0C41 VA: 0x34B0B40
	|-Subject.Subscription<float>..ctor
	|
	|-RVA: 0x34B13B0 Offset: 0x34B14B1 VA: 0x34B13B0
	|-Subject.Subscription<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34ACA80 Offset: 0x34ACB81 VA: 0x34ACA80
	|-Subject.Subscription<CollectionAddEvent<object>>.Dispose
	|
	|-RVA: 0x34ACE10 Offset: 0x34ACF11 VA: 0x34ACE10
	|-Subject.Subscription<CollectionMoveEvent<object>>.Dispose
	|
	|-RVA: 0x34AD1A0 Offset: 0x34AD2A1 VA: 0x34AD1A0
	|-Subject.Subscription<CollectionRemoveEvent<object>>.Dispose
	|
	|-RVA: 0x34AD530 Offset: 0x34AD631 VA: 0x34AD530
	|-Subject.Subscription<CollectionReplaceEvent<object>>.Dispose
	|
	|-RVA: 0x34AD8C0 Offset: 0x34AD9C1 VA: 0x34AD8C0
	|-Subject.Subscription<DictionaryAddEvent<object, object>>.Dispose
	|
	|-RVA: 0x34ADC50 Offset: 0x34ADD51 VA: 0x34ADC50
	|-Subject.Subscription<DictionaryRemoveEvent<object, object>>.Dispose
	|
	|-RVA: 0x34ADFE0 Offset: 0x34AE0E1 VA: 0x34ADFE0
	|-Subject.Subscription<DictionaryReplaceEvent<object, object>>.Dispose
	|
	|-RVA: 0x34AE370 Offset: 0x34AE471 VA: 0x34AE370
	|-Subject.Subscription<ValueTuple<object, object>>.Dispose
	|
	|-RVA: 0x34AE700 Offset: 0x34AE801 VA: 0x34AE700
	|-Subject.Subscription<ValueTuple<float, int>>.Dispose
	|
	|-RVA: 0x34AEA90 Offset: 0x34AEB91 VA: 0x34AEA90
	|-Subject.Subscription<ValueTuple<float, Int32Enum>>.Dispose
	|
	|-RVA: 0x34AEE20 Offset: 0x34AEF21 VA: 0x34AEE20
	|-Subject.Subscription<bool>.Dispose
	|
	|-RVA: 0x34AF1B0 Offset: 0x34AF2B1 VA: 0x34AF1B0
	|-Subject.Subscription<int>.Dispose
	|
	|-RVA: 0x34AF540 Offset: 0x34AF641 VA: 0x34AF540
	|-Subject.Subscription<Int32Enum>.Dispose
	|
	|-RVA: 0x34AF8D0 Offset: 0x34AF9D1 VA: 0x34AF8D0
	|-Subject.Subscription<LogEntry>.Dispose
	|
	|-RVA: 0x34B0860 Offset: 0x34B0961 VA: 0x34B0860
	|-Subject.Subscription<object>.Dispose
	|
	|-RVA: 0x34B0BF0 Offset: 0x34B0CF1 VA: 0x34B0BF0
	|-Subject.Subscription<float>.Dispose
	|
	|-RVA: 0x34B1460 Offset: 0x34B1561 VA: 0x34B1460
	|-Subject.Subscription<Unit>.Dispose
	*/
}

