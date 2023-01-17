// Namespace: 
private sealed class ConcurrentDictionary.Tables<TKey, TValue> // TypeDefIndex: 1388
{
	// Fields
	internal readonly ConcurrentDictionary.Node<TKey, TValue>[] _buckets; // 0x0
	internal readonly object[] _locks; // 0x0
	internal int[] _countPerLock; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ConcurrentDictionary.Node<TKey, TValue>[] buckets, object[] locks, int[] countPerLock) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B8620 Offset: 0x34B8721 VA: 0x34B8620
	|-ConcurrentDictionary.Tables<object, object>..ctor
	*/
}

// Namespace: 
[Serializable]
private sealed class ConcurrentDictionary.DictionaryEnumerator<TKey, TValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 1390
{
	// Fields
	private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator; // 0x0

	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ConcurrentDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251ADE0 Offset: 0x251AEE1 VA: 0x251ADE0
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251AE40 Offset: 0x251AF41 VA: 0x251AE40
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251AF80 Offset: 0x251B081 VA: 0x251AF80
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251B010 Offset: 0x251B111 VA: 0x251B010
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251B0B0 Offset: 0x251B1B1 VA: 0x251B0B0
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251B130 Offset: 0x251B231 VA: 0x251B130
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x251B1E0 Offset: 0x251B2E1 VA: 0x251B1E0
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.Reset
	*/
}

