// Namespace: 
[DefaultMemberAttribute] // RVA: 0x4770F0 Offset: 0x4771F1 VA: 0x4770F0
[Serializable]
private class SortedList.SyncSortedList : SortedList // TypeDefIndex: 1376
{
	// Fields
	private SortedList _list; // 0x48
	private object _root; // 0x50

	// Properties
	public override int Count { get; }
	public override object SyncRoot { get; }
	public override bool IsReadOnly { get; }
	public override bool IsFixedSize { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }
	public override int Capacity { get; }

	// Methods

	// RVA: 0x1C03120 Offset: 0x1C03221 VA: 0x1C03120
	internal void .ctor(SortedList list) { }

	// RVA: 0x1C031D0 Offset: 0x1C032D1 VA: 0x1C031D0 Slot: 23
	public override int get_Count() { }

	// RVA: 0x1C032C0 Offset: 0x1C033C1 VA: 0x1C032C0 Slot: 29
	public override object get_SyncRoot() { }

	// RVA: 0x1C032D0 Offset: 0x1C033D1 VA: 0x1C032D0 Slot: 26
	public override bool get_IsReadOnly() { }

	// RVA: 0x1C032F0 Offset: 0x1C033F1 VA: 0x1C032F0 Slot: 27
	public override bool get_IsFixedSize() { }

	// RVA: 0x1C03310 Offset: 0x1C03411 VA: 0x1C03310 Slot: 28
	public override bool get_IsSynchronized() { }

	// RVA: 0x1C03320 Offset: 0x1C03421 VA: 0x1C03320 Slot: 40
	public override object get_Item(object key) { }

	// RVA: 0x1C03410 Offset: 0x1C03511 VA: 0x1C03410 Slot: 41
	public override void set_Item(object key, object value) { }

	// RVA: 0x1C03500 Offset: 0x1C03601 VA: 0x1C03500 Slot: 20
	public override void Add(object key, object value) { }

	// RVA: 0x1C035F0 Offset: 0x1C036F1 VA: 0x1C035F0 Slot: 21
	public override int get_Capacity() { }

	// RVA: 0x1C036E0 Offset: 0x1C037E1 VA: 0x1C036E0 Slot: 30
	public override object Clone() { }

	// RVA: 0x1C037D0 Offset: 0x1C038D1 VA: 0x1C037D0 Slot: 31
	public override bool Contains(object key) { }

	// RVA: 0x1C038C0 Offset: 0x1C039C1 VA: 0x1C038C0 Slot: 32
	public override bool ContainsKey(object key) { }

	// RVA: 0x1C039B0 Offset: 0x1C03AB1 VA: 0x1C039B0 Slot: 33
	public override bool ContainsValue(object key) { }

	// RVA: 0x1C03AA0 Offset: 0x1C03BA1 VA: 0x1C03AA0 Slot: 34
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x1C03B90 Offset: 0x1C03C91 VA: 0x1C03B90 Slot: 35
	public override object GetByIndex(int index) { }

	// RVA: 0x1C03C80 Offset: 0x1C03D81 VA: 0x1C03C80 Slot: 36
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1C03D70 Offset: 0x1C03E71 VA: 0x1C03D70 Slot: 37
	public override object GetKey(int index) { }

	// RVA: 0x1C03E60 Offset: 0x1C03F61 VA: 0x1C03E60 Slot: 38
	public override IList GetKeyList() { }

	// RVA: 0x1C03F50 Offset: 0x1C04051 VA: 0x1C03F50 Slot: 39
	public override IList GetValueList() { }

	// RVA: 0x1C04040 Offset: 0x1C04141 VA: 0x1C04040 Slot: 42
	public override int IndexOfKey(object key) { }

	// RVA: 0x1C041A0 Offset: 0x1C042A1 VA: 0x1C041A0 Slot: 43
	public override int IndexOfValue(object value) { }

	// RVA: 0x1C04290 Offset: 0x1C04391 VA: 0x1C04290 Slot: 44
	public override void RemoveAt(int index) { }

	// RVA: 0x1C04380 Offset: 0x1C04481 VA: 0x1C04380 Slot: 45
	public override void Remove(object key) { }
}

// Namespace: 
[DefaultMemberAttribute] // RVA: 0x477130 Offset: 0x477231 VA: 0x477130
[Serializable]
private class SortedList.KeyList : IList, ICollection, IEnumerable // TypeDefIndex: 1378
{
	// Fields
	private SortedList sortedList; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x1C02640 Offset: 0x1C02741 VA: 0x1C02640
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0x1C02680 Offset: 0x1C02781 VA: 0x1C02680 Slot: 19
	public virtual int get_Count() { }

	// RVA: 0x1C02690 Offset: 0x1C02791 VA: 0x1C02690 Slot: 20
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x1C026A0 Offset: 0x1C027A1 VA: 0x1C026A0 Slot: 21
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x1C026C0 Offset: 0x1C027C1 VA: 0x1C026C0 Slot: 22
	public virtual object get_SyncRoot() { }

	// RVA: 0x1C026E0 Offset: 0x1C027E1 VA: 0x1C026E0 Slot: 23
	public virtual int Add(object key) { }

	// RVA: 0x1C02740 Offset: 0x1C02841 VA: 0x1C02740 Slot: 24
	public virtual void Clear() { }

	// RVA: 0x1C027A0 Offset: 0x1C028A1 VA: 0x1C027A0 Slot: 25
	public virtual bool Contains(object key) { }

	// RVA: 0x1C027C0 Offset: 0x1C028C1 VA: 0x1C027C0 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1C02890 Offset: 0x1C02991 VA: 0x1C02890 Slot: 27
	public virtual void Insert(int index, object value) { }

	// RVA: 0x1C028F0 Offset: 0x1C029F1 VA: 0x1C028F0 Slot: 28
	public virtual object get_Item(int index) { }

	// RVA: 0x1C02910 Offset: 0x1C02A11 VA: 0x1C02910 Slot: 29
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x1C02970 Offset: 0x1C02A71 VA: 0x1C02970 Slot: 30
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1C02A90 Offset: 0x1C02B91 VA: 0x1C02A90 Slot: 31
	public virtual int IndexOf(object key) { }

	// RVA: 0x1C02B60 Offset: 0x1C02C61 VA: 0x1C02B60 Slot: 32
	public virtual void Remove(object key) { }

	// RVA: 0x1C02BC0 Offset: 0x1C02CC1 VA: 0x1C02BC0 Slot: 33
	public virtual void RemoveAt(int index) { }
}

// Namespace: 
internal class SortedList.SortedListDebugView // TypeDefIndex: 1380
{}

