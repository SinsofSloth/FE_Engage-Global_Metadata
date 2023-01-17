// Namespace: UniRx
public struct DictionaryAddEvent<TKey, TValue> : IEquatable<DictionaryAddEvent<TKey, TValue>> // TypeDefIndex: 6757
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x13D00 Offset: 0x13E01 VA: 0x13D00
	private TKey <Key>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x13D10 Offset: 0x13E11 VA: 0x13D10
	private TValue <Value>k__BackingField; // 0x0

	// Properties
	public TKey Key { get; set; }
	public TValue Value { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x17330 Offset: 0x17431 VA: 0x17330
	[CompilerGeneratedAttribute] // RVA: 0x17330 Offset: 0x17431 VA: 0x17330
	// RVA: -1 Offset: -1
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518B50 Offset: 0x2518C51 VA: 0x2518B50
	|-DictionaryAddEvent<object, object>.get_Key
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17370 Offset: 0x17471 VA: 0x17370
	// RVA: -1 Offset: -1
	private void set_Key(TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518B60 Offset: 0x2518C61 VA: 0x2518B60
	|-DictionaryAddEvent<object, object>.set_Key
	*/

	[IsReadOnlyAttribute] // RVA: 0x17380 Offset: 0x17481 VA: 0x17380
	[CompilerGeneratedAttribute] // RVA: 0x17380 Offset: 0x17481 VA: 0x17380
	// RVA: -1 Offset: -1
	public TValue get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518B70 Offset: 0x2518C71 VA: 0x2518B70
	|-DictionaryAddEvent<object, object>.get_Value
	*/

	[CompilerGeneratedAttribute] // RVA: 0x173C0 Offset: 0x174C1 VA: 0x173C0
	// RVA: -1 Offset: -1
	private void set_Value(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518B80 Offset: 0x2518C81 VA: 0x2518B80
	|-DictionaryAddEvent<object, object>.set_Value
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518B90 Offset: 0x2518C91 VA: 0x2518B90
	|-DictionaryAddEvent<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518C00 Offset: 0x2518D01 VA: 0x2518C00
	|-DictionaryAddEvent<object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518CB0 Offset: 0x2518DB1 VA: 0x2518CB0
	|-DictionaryAddEvent<object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(DictionaryAddEvent<TKey, TValue> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518DC0 Offset: 0x2518EC1 VA: 0x2518DC0
	|-DictionaryAddEvent<object, object>.Equals
	*/
}

