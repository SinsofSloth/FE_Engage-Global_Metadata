// Namespace: 
private class ListDictionaryInternal.NodeEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 1367
{
	// Fields
	private ListDictionaryInternal list; // 0x10
	private ListDictionaryInternal.DictionaryNode current; // 0x18
	private int version; // 0x20
	private bool start; // 0x24

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x35EDCA0 Offset: 0x35EDDA1 VA: 0x35EDCA0
	public void .ctor(ListDictionaryInternal list) { }

	// RVA: 0x35EDD00 Offset: 0x35EDE01 VA: 0x35EDD00 Slot: 8
	public object get_Current() { }

	// RVA: 0x35EDD70 Offset: 0x35EDE71 VA: 0x35EDD70 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x35EDE00 Offset: 0x35EDF01 VA: 0x35EDE00 Slot: 4
	public object get_Key() { }

	// RVA: 0x35EDE80 Offset: 0x35EDF81 VA: 0x35EDE80 Slot: 5
	public object get_Value() { }

	// RVA: 0x35EDF00 Offset: 0x35EE001 VA: 0x35EDF00 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x35EDFD0 Offset: 0x35EE0D1 VA: 0x35EDFD0 Slot: 9
	public void Reset() { }
}

// Namespace: 
private class ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator : IEnumerator // TypeDefIndex: 1368
{
	// Fields
	private ListDictionaryInternal list; // 0x10
	private ListDictionaryInternal.DictionaryNode current; // 0x18
	private int version; // 0x20
	private bool isKeys; // 0x24
	private bool start; // 0x25

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1C0F570 Offset: 0x1C0F671 VA: 0x1C0F570
	public void .ctor(ListDictionaryInternal list, bool isKeys) { }

	// RVA: 0x1C0F5E0 Offset: 0x1C0F6E1 VA: 0x1C0F5E0 Slot: 5
	public object get_Current() { }

	// RVA: 0x1C0F670 Offset: 0x1C0F771 VA: 0x1C0F670 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1C0F740 Offset: 0x1C0F841 VA: 0x1C0F740 Slot: 6
	public void Reset() { }
}

// Namespace: 
private class ListDictionaryInternal.NodeKeyValueCollection : ICollection, IEnumerable // TypeDefIndex: 1369
{
	// Fields
	private ListDictionaryInternal list; // 0x10
	private bool isKeys; // 0x18

	// Properties
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x35EE060 Offset: 0x35EE161 VA: 0x35EE060
	public void .ctor(ListDictionaryInternal list, bool isKeys) { }

	// RVA: 0x35EE0B0 Offset: 0x35EE1B1 VA: 0x35EE0B0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x35EE2A0 Offset: 0x35EE3A1 VA: 0x35EE2A0 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x35EE2D0 Offset: 0x35EE3D1 VA: 0x35EE2D0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x35EE2E0 Offset: 0x35EE3E1 VA: 0x35EE2E0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x35EE2F0 Offset: 0x35EE3F1 VA: 0x35EE2F0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[Serializable]
private class ListDictionaryInternal.DictionaryNode // TypeDefIndex: 1370
{
	// Fields
	public object key; // 0x10
	public object value; // 0x18
	public ListDictionaryInternal.DictionaryNode next; // 0x20

	// Methods

	// RVA: 0x35EDC90 Offset: 0x35EDD91 VA: 0x35EDC90
	public void .ctor() { }
}

