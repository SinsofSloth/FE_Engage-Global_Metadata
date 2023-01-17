// Namespace: 
[DefaultMemberAttribute] // RVA: 0x477170 Offset: 0x477271 VA: 0x477170
[Serializable]
private class SortedList.ValueList : IList, ICollection, IEnumerable // TypeDefIndex: 1379
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

	// RVA: 0x1C04470 Offset: 0x1C04571 VA: 0x1C04470
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0x1C044B0 Offset: 0x1C045B1 VA: 0x1C044B0 Slot: 19
	public virtual int get_Count() { }

	// RVA: 0x1C044C0 Offset: 0x1C045C1 VA: 0x1C044C0 Slot: 20
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x1C044D0 Offset: 0x1C045D1 VA: 0x1C044D0 Slot: 21
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x1C044F0 Offset: 0x1C045F1 VA: 0x1C044F0 Slot: 22
	public virtual object get_SyncRoot() { }

	// RVA: 0x1C04510 Offset: 0x1C04611 VA: 0x1C04510 Slot: 23
	public virtual int Add(object key) { }

	// RVA: 0x1C04570 Offset: 0x1C04671 VA: 0x1C04570 Slot: 24
	public virtual void Clear() { }

	// RVA: 0x1C045D0 Offset: 0x1C046D1 VA: 0x1C045D0 Slot: 25
	public virtual bool Contains(object value) { }

	// RVA: 0x1C045F0 Offset: 0x1C046F1 VA: 0x1C045F0 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1C046C0 Offset: 0x1C047C1 VA: 0x1C046C0 Slot: 27
	public virtual void Insert(int index, object value) { }

	// RVA: 0x1C04720 Offset: 0x1C04821 VA: 0x1C04720 Slot: 28
	public virtual object get_Item(int index) { }

	// RVA: 0x1C04740 Offset: 0x1C04841 VA: 0x1C04740 Slot: 29
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x1C047A0 Offset: 0x1C048A1 VA: 0x1C047A0 Slot: 30
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1C04850 Offset: 0x1C04951 VA: 0x1C04850 Slot: 31
	public virtual int IndexOf(object value) { }

	// RVA: 0x1C048D0 Offset: 0x1C049D1 VA: 0x1C048D0 Slot: 32
	public virtual void Remove(object value) { }

	// RVA: 0x1C04930 Offset: 0x1C04A31 VA: 0x1C04930 Slot: 33
	public virtual void RemoveAt(int index) { }
}

