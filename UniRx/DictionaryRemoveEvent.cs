// Namespace: UniRx
public struct DictionaryRemoveEvent<TKey, TValue> : IEquatable<DictionaryRemoveEvent<TKey, TValue>> // TypeDefIndex: 6758
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x13D20 Offset: 0x13E21 VA: 0x13D20
	private TKey <Key>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x13D30 Offset: 0x13E31 VA: 0x13D30
	private TValue <Value>k__BackingField; // 0x0

	// Properties
	public TKey Key { get; set; }
	public TValue Value { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x173D0 Offset: 0x174D1 VA: 0x173D0
	[CompilerGeneratedAttribute] // RVA: 0x173D0 Offset: 0x174D1 VA: 0x173D0
	// RVA: -1 Offset: -1
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251B9F0 Offset: 0x251BAF1 VA: 0x251B9F0
	|-DictionaryRemoveEvent<object, object>.get_Key
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17410 Offset: 0x17511 VA: 0x17410
	// RVA: -1 Offset: -1
	private void set_Key(TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BA00 Offset: 0x251BB01 VA: 0x251BA00
	|-DictionaryRemoveEvent<object, object>.set_Key
	*/

	[IsReadOnlyAttribute] // RVA: 0x17420 Offset: 0x17521 VA: 0x17420
	[CompilerGeneratedAttribute] // RVA: 0x17420 Offset: 0x17521 VA: 0x17420
	// RVA: -1 Offset: -1
	public TValue get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BA10 Offset: 0x251BB11 VA: 0x251BA10
	|-DictionaryRemoveEvent<object, object>.get_Value
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17460 Offset: 0x17561 VA: 0x17460
	// RVA: -1 Offset: -1
	private void set_Value(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BA20 Offset: 0x251BB21 VA: 0x251BA20
	|-DictionaryRemoveEvent<object, object>.set_Value
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BA30 Offset: 0x251BB31 VA: 0x251BA30
	|-DictionaryRemoveEvent<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BAA0 Offset: 0x251BBA1 VA: 0x251BAA0
	|-DictionaryRemoveEvent<object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BB50 Offset: 0x251BC51 VA: 0x251BB50
	|-DictionaryRemoveEvent<object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(DictionaryRemoveEvent<TKey, TValue> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BC60 Offset: 0x251BD61 VA: 0x251BC60
	|-DictionaryRemoveEvent<object, object>.Equals
	*/
}

