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

