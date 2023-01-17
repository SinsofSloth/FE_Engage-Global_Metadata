// Namespace: 
private class OrderedDictionary.OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 2402
{
	// Fields
	private int _objectReturnType; // 0x10
	private IEnumerator arrayEnumerator; // 0x18

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x191DE00 Offset: 0x191DF01 VA: 0x191DE00
	internal void .ctor(ArrayList array, int objectReturnType) { }

	// RVA: 0x191DE60 Offset: 0x191DF61 VA: 0x191DE60 Slot: 8
	public object get_Current() { }

	// RVA: 0x191E060 Offset: 0x191E161 VA: 0x191E060 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x191E210 Offset: 0x191E311 VA: 0x191E210 Slot: 4
	public object get_Key() { }

	// RVA: 0x191E310 Offset: 0x191E411 VA: 0x191E310 Slot: 5
	public object get_Value() { }

	// RVA: 0x191E410 Offset: 0x191E511 VA: 0x191E410 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x191E4C0 Offset: 0x191E5C1 VA: 0x191E4C0 Slot: 9
	public void Reset() { }
}

// Namespace: 
private class OrderedDictionary.OrderedDictionaryKeyValueCollection : ICollection, IEnumerable // TypeDefIndex: 2403
{
	// Fields
	private ArrayList _objects; // 0x10
	private bool isKeys; // 0x18

	// Properties
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x191E570 Offset: 0x191E671 VA: 0x191E570
	public void .ctor(ArrayList array, bool isKeys) { }

	// RVA: 0x191E5C0 Offset: 0x191E6C1 VA: 0x191E5C0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x191E920 Offset: 0x191EA21 VA: 0x191E920 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x191E940 Offset: 0x191EA41 VA: 0x191E940 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x191E950 Offset: 0x191EA51 VA: 0x191E950 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x191E970 Offset: 0x191EA71 VA: 0x191E970 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

