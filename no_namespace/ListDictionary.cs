// Namespace: 
private class ListDictionary.NodeEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 2392
{
	// Fields
	private ListDictionary list; // 0x10
	private ListDictionary.DictionaryNode current; // 0x18
	private int version; // 0x20
	private bool start; // 0x24

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x191B130 Offset: 0x191B231 VA: 0x191B130
	public void .ctor(ListDictionary list) { }

	// RVA: 0x191B190 Offset: 0x191B291 VA: 0x191B190 Slot: 8
	public object get_Current() { }

	// RVA: 0x191B200 Offset: 0x191B301 VA: 0x191B200 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x191B290 Offset: 0x191B391 VA: 0x191B290 Slot: 4
	public object get_Key() { }

	// RVA: 0x191B310 Offset: 0x191B411 VA: 0x191B310 Slot: 5
	public object get_Value() { }

	// RVA: 0x191B390 Offset: 0x191B491 VA: 0x191B390 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x191B460 Offset: 0x191B561 VA: 0x191B460 Slot: 9
	public void Reset() { }
}

// Namespace: 
private class ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator : IEnumerator // TypeDefIndex: 2393
{
	// Fields
	private ListDictionary list; // 0x10
	private ListDictionary.DictionaryNode current; // 0x18
	private int version; // 0x20
	private bool isKeys; // 0x24
	private bool start; // 0x25

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1C15290 Offset: 0x1C15391 VA: 0x1C15290
	public void .ctor(ListDictionary list, bool isKeys) { }

	// RVA: 0x1C15300 Offset: 0x1C15401 VA: 0x1C15300 Slot: 5
	public object get_Current() { }

	// RVA: 0x1C15390 Offset: 0x1C15491 VA: 0x1C15390 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1C15460 Offset: 0x1C15561 VA: 0x1C15460 Slot: 6
	public void Reset() { }
}

// Namespace: 
private class ListDictionary.NodeKeyValueCollection : ICollection, IEnumerable // TypeDefIndex: 2394
{
	// Fields
	private ListDictionary list; // 0x10
	private bool isKeys; // 0x18

	// Properties
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x191B4F0 Offset: 0x191B5F1 VA: 0x191B4F0
	public void .ctor(ListDictionary list, bool isKeys) { }

	// RVA: 0x191B540 Offset: 0x191B641 VA: 0x191B540 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x191B670 Offset: 0x191B771 VA: 0x191B670 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x191B6A0 Offset: 0x191B7A1 VA: 0x191B6A0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x191B6B0 Offset: 0x191B7B1 VA: 0x191B6B0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x191B6C0 Offset: 0x191B7C1 VA: 0x191B6C0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[Serializable]
private class ListDictionary.DictionaryNode // TypeDefIndex: 2395
{
	// Fields
	public object key; // 0x10
	public object value; // 0x18
	public ListDictionary.DictionaryNode next; // 0x20

	// Methods

	// RVA: 0x191B120 Offset: 0x191B221 VA: 0x191B120
	public void .ctor() { }
}

