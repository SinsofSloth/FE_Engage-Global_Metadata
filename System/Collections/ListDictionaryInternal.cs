// Namespace: System.Collections
[DefaultMemberAttribute] // RVA: 0x476F20 Offset: 0x477021 VA: 0x476F20
[Serializable]
internal class ListDictionaryInternal : IDictionary, ICollection, IEnumerable // TypeDefIndex: 1371
{
	// Fields
	private ListDictionaryInternal.DictionaryNode head; // 0x10
	private int version; // 0x18
	private int count; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public object Item { get; set; }
	public int Count { get; }
	public ICollection Keys { get; }
	public bool IsReadOnly { get; }
	public bool IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x341E2B0 Offset: 0x341E3B1 VA: 0x341E2B0
	public void .ctor() { }

	// RVA: 0x341E2C0 Offset: 0x341E3C1 VA: 0x341E2C0 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x341E380 Offset: 0x341E481 VA: 0x341E380 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x341E5D0 Offset: 0x341E6D1 VA: 0x341E5D0 Slot: 15
	public int get_Count() { }

	// RVA: 0x341E5E0 Offset: 0x341E6E1 VA: 0x341E5E0 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x341E650 Offset: 0x341E751 VA: 0x341E650 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x341E660 Offset: 0x341E761 VA: 0x341E660 Slot: 11
	public bool get_IsFixedSize() { }

	// RVA: 0x341E670 Offset: 0x341E771 VA: 0x341E670 Slot: 17
	public bool get_IsSynchronized() { }

	// RVA: 0x341E680 Offset: 0x341E781 VA: 0x341E680 Slot: 16
	public object get_SyncRoot() { }

	// RVA: 0x341E710 Offset: 0x341E811 VA: 0x341E710 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x341E780 Offset: 0x341E881 VA: 0x341E780 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x341EA40 Offset: 0x341EB41 VA: 0x341EA40 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x341EB00 Offset: 0x341EC01 VA: 0x341EB00 Slot: 14
	public void CopyTo(Array array, int index) { }

	// RVA: 0x341ED20 Offset: 0x341EE21 VA: 0x341ED20 Slot: 12
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x341ED90 Offset: 0x341EE91 VA: 0x341ED90 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x341EE00 Offset: 0x341EF01 VA: 0x341EE00 Slot: 13
	public void Remove(object key) { }
}

