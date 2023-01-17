// Namespace: System.Collections
[DefaultMemberAttribute] // RVA: 0x476BB0 Offset: 0x476CB1 VA: 0x476BB0
[Serializable]
internal sealed class EmptyReadOnlyDictionaryInternal : IDictionary, ICollection, IEnumerable // TypeDefIndex: 1347
{
	// Properties
	public int Count { get; }
	public object SyncRoot { get; }
	public bool IsSynchronized { get; }
	public object Item { get; set; }
	public ICollection Keys { get; }
	public ICollection Values { get; }
	public bool IsReadOnly { get; }
	public bool IsFixedSize { get; }

	// Methods

	// RVA: 0x372CB60 Offset: 0x372CC61 VA: 0x372CB60
	public void .ctor() { }

	// RVA: 0x372CB70 Offset: 0x372CC71 VA: 0x372CB70 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x372CBD0 Offset: 0x372CCD1 VA: 0x372CBD0 Slot: 14
	public void CopyTo(Array array, int index) { }

	// RVA: 0x372CD60 Offset: 0x372CE61 VA: 0x372CD60 Slot: 15
	public int get_Count() { }

	// RVA: 0x372CD70 Offset: 0x372CE71 VA: 0x372CD70 Slot: 16
	public object get_SyncRoot() { }

	// RVA: 0x372CD80 Offset: 0x372CE81 VA: 0x372CD80 Slot: 17
	public bool get_IsSynchronized() { }

	// RVA: 0x372CD90 Offset: 0x372CE91 VA: 0x372CD90 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x372CE10 Offset: 0x372CF11 VA: 0x372CE10 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x372CF90 Offset: 0x372D091 VA: 0x372CF90 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x372D000 Offset: 0x372D101 VA: 0x372D000 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x372D070 Offset: 0x372D171 VA: 0x372D070 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x372D080 Offset: 0x372D181 VA: 0x372D080 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x372D200 Offset: 0x372D301 VA: 0x372D200 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x372D210 Offset: 0x372D311 VA: 0x372D210 Slot: 11
	public bool get_IsFixedSize() { }

	// RVA: 0x372D220 Offset: 0x372D321 VA: 0x372D220 Slot: 12
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x372D280 Offset: 0x372D381 VA: 0x372D280 Slot: 13
	public void Remove(object key) { }
}

