// Namespace: System.Collections.Specialized
[DefaultMemberAttribute] // RVA: 0x307D0 Offset: 0x308D1 VA: 0x307D0
[Serializable]
public class ListDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 2396
{
	// Fields
	private ListDictionary.DictionaryNode head; // 0x10
	private int version; // 0x18
	private int count; // 0x1C
	private IComparer comparer; // 0x20
	private object _syncRoot; // 0x28

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

	// RVA: 0x1AC3C80 Offset: 0x1AC3D81 VA: 0x1AC3C80
	public void .ctor() { }

	// RVA: 0x1AC2AF0 Offset: 0x1AC2BF1 VA: 0x1AC2AF0
	public void .ctor(IComparer comparer) { }

	// RVA: 0x1AC2E20 Offset: 0x1AC2F21 VA: 0x1AC2E20 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x1AC2B30 Offset: 0x1AC2C31 VA: 0x1AC2B30 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x1AC3C90 Offset: 0x1AC3D91 VA: 0x1AC3C90 Slot: 15
	public int get_Count() { }

	// RVA: 0x1AC3CA0 Offset: 0x1AC3DA1 VA: 0x1AC3CA0 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x1AC3D10 Offset: 0x1AC3E11 VA: 0x1AC3D10 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x1AC3D20 Offset: 0x1AC3E21 VA: 0x1AC3D20 Slot: 11
	public bool get_IsFixedSize() { }

	// RVA: 0x1AC3D30 Offset: 0x1AC3E31 VA: 0x1AC3D30 Slot: 17
	public bool get_IsSynchronized() { }

	// RVA: 0x1AC3D40 Offset: 0x1AC3E41 VA: 0x1AC3D40 Slot: 16
	public object get_SyncRoot() { }

	// RVA: 0x1AC3DD0 Offset: 0x1AC3ED1 VA: 0x1AC3DD0 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x1AC3E40 Offset: 0x1AC3F41 VA: 0x1AC3E40 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x1AC4070 Offset: 0x1AC4171 VA: 0x1AC4070 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x1AC41E0 Offset: 0x1AC42E1 VA: 0x1AC41E0 Slot: 14
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1AC43A0 Offset: 0x1AC44A1 VA: 0x1AC43A0 Slot: 12
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1AC4410 Offset: 0x1AC4511 VA: 0x1AC4410 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1AC4480 Offset: 0x1AC4581 VA: 0x1AC4480 Slot: 13
	public void Remove(object key) { }
}

