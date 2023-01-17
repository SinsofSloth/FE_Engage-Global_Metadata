// Namespace: UniRx
[DefaultMemberAttribute] // RVA: 0x128E0 Offset: 0x129E1 VA: 0x128E0
public sealed class DictionaryDisposable<TKey, TValue> : IDisposable, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 6475
{
	// Fields
	private bool isDisposed; // 0x0
	private readonly Dictionary<TKey, TValue> inner; // 0x0

	// Properties
	public TValue Item { get; set; }
	public int Count { get; }
	public Dictionary.KeyCollection<TKey, TValue> Keys { get; }
	public Dictionary.ValueCollection<TKey, TValue> Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518F20 Offset: 0x2519021 VA: 0x2518F20
	|-DictionaryDisposable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518FA0 Offset: 0x25190A1 VA: 0x2518FA0
	|-DictionaryDisposable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519020 Offset: 0x2519121 VA: 0x2519020
	|-DictionaryDisposable<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519120 Offset: 0x2519221 VA: 0x2519120
	|-DictionaryDisposable<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519360 Offset: 0x2519461 VA: 0x2519360
	|-DictionaryDisposable<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public Dictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519450 Offset: 0x2519551 VA: 0x2519450
	|-DictionaryDisposable<object, object>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public Dictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25194B0 Offset: 0x25195B1 VA: 0x25194B0
	|-DictionaryDisposable<object, object>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519510 Offset: 0x2519611 VA: 0x2519510
	|-DictionaryDisposable<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25196A0 Offset: 0x25197A1 VA: 0x25196A0
	|-DictionaryDisposable<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25199F0 Offset: 0x2519AF1 VA: 0x25199F0
	|-DictionaryDisposable<object, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519BB0 Offset: 0x2519CB1 VA: 0x2519BB0
	|-DictionaryDisposable<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519CB0 Offset: 0x2519DB1 VA: 0x2519CB0
	|-DictionaryDisposable<object, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public Dictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519DC0 Offset: 0x2519EC1 VA: 0x2519DC0
	|-DictionaryDisposable<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519F40 Offset: 0x251A041 VA: 0x2519F40
	|-DictionaryDisposable<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2519FD0 Offset: 0x251A0D1 VA: 0x2519FD0
	|-DictionaryDisposable<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251A110 Offset: 0x251A211 VA: 0x251A110
	|-DictionaryDisposable<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251A250 Offset: 0x251A351 VA: 0x251A250
	|-DictionaryDisposable<object, object>.GetObjectData
	*/

	// RVA: -1 Offset: -1
	public void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251A3C0 Offset: 0x251A4C1 VA: 0x251A3C0
	|-DictionaryDisposable<object, object>.OnDeserialization
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251A520 Offset: 0x251A621 VA: 0x251A520
	|-DictionaryDisposable<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251A540 Offset: 0x251A641 VA: 0x251A540
	|-DictionaryDisposable<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251A6B0 Offset: 0x251A7B1 VA: 0x251A6B0
	|-DictionaryDisposable<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251A810 Offset: 0x251A911 VA: 0x251A810
	|-DictionaryDisposable<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251A990 Offset: 0x251AA91 VA: 0x251A990
	|-DictionaryDisposable<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251AA20 Offset: 0x251AB21 VA: 0x251AA20
	|-DictionaryDisposable<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251AA60 Offset: 0x251AB61 VA: 0x251AA60
	|-DictionaryDisposable<object, object>.Dispose
	*/
}

