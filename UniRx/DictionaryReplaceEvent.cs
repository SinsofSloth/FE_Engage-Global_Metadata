// Namespace: UniRx
public struct DictionaryReplaceEvent<TKey, TValue> : IEquatable<DictionaryReplaceEvent<TKey, TValue>> // TypeDefIndex: 6759
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x13D40 Offset: 0x13E41 VA: 0x13D40
	private TKey <Key>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x13D50 Offset: 0x13E51 VA: 0x13D50
	private TValue <OldValue>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x13D60 Offset: 0x13E61 VA: 0x13D60
	private TValue <NewValue>k__BackingField; // 0x0

	// Properties
	public TKey Key { get; set; }
	public TValue OldValue { get; set; }
	public TValue NewValue { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x17470 Offset: 0x17571 VA: 0x17470
	[CompilerGeneratedAttribute] // RVA: 0x17470 Offset: 0x17571 VA: 0x17470
	// RVA: -1 Offset: -1
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BDC0 Offset: 0x251BEC1 VA: 0x251BDC0
	|-DictionaryReplaceEvent<object, object>.get_Key
	*/

	[CompilerGeneratedAttribute] // RVA: 0x174B0 Offset: 0x175B1 VA: 0x174B0
	// RVA: -1 Offset: -1
	private void set_Key(TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BDD0 Offset: 0x251BED1 VA: 0x251BDD0
	|-DictionaryReplaceEvent<object, object>.set_Key
	*/

	[IsReadOnlyAttribute] // RVA: 0x174C0 Offset: 0x175C1 VA: 0x174C0
	[CompilerGeneratedAttribute] // RVA: 0x174C0 Offset: 0x175C1 VA: 0x174C0
	// RVA: -1 Offset: -1
	public TValue get_OldValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BDE0 Offset: 0x251BEE1 VA: 0x251BDE0
	|-DictionaryReplaceEvent<object, object>.get_OldValue
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17500 Offset: 0x17601 VA: 0x17500
	// RVA: -1 Offset: -1
	private void set_OldValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BDF0 Offset: 0x251BEF1 VA: 0x251BDF0
	|-DictionaryReplaceEvent<object, object>.set_OldValue
	*/

	[IsReadOnlyAttribute] // RVA: 0x17510 Offset: 0x17611 VA: 0x17510
	[CompilerGeneratedAttribute] // RVA: 0x17510 Offset: 0x17611 VA: 0x17510
	// RVA: -1 Offset: -1
	public TValue get_NewValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BE00 Offset: 0x251BF01 VA: 0x251BE00
	|-DictionaryReplaceEvent<object, object>.get_NewValue
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17550 Offset: 0x17651 VA: 0x17550
	// RVA: -1 Offset: -1
	private void set_NewValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BE10 Offset: 0x251BF11 VA: 0x251BE10
	|-DictionaryReplaceEvent<object, object>.set_NewValue
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TKey key, TValue oldValue, TValue newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BE20 Offset: 0x251BF21 VA: 0x251BE20
	|-DictionaryReplaceEvent<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BEC0 Offset: 0x251BFC1 VA: 0x251BEC0
	|-DictionaryReplaceEvent<object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251BF90 Offset: 0x251C091 VA: 0x251BF90
	|-DictionaryReplaceEvent<object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(DictionaryReplaceEvent<TKey, TValue> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251C120 Offset: 0x251C221 VA: 0x251C120
	|-DictionaryReplaceEvent<object, object>.Equals
	*/
}

