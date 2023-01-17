// Namespace: System.Collections.ObjectModel
[ComVisibleAttribute] // RVA: 0x477250 Offset: 0x477351 VA: 0x477250
[DefaultMemberAttribute] // RVA: 0x477250 Offset: 0x477351 VA: 0x477250
[DebuggerTypeProxyAttribute] // RVA: 0x477250 Offset: 0x477351 VA: 0x477250
[DebuggerDisplayAttribute] // RVA: 0x477250 Offset: 0x477351 VA: 0x477250
[Serializable]
public class Collection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 1385
{
	// Fields
	private IList<T> items; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Count { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DA1E0 Offset: 0x30DA2E1 VA: 0x30DA1E0
	|-Collection<IEnumerable<Claim>>..ctor
	|-Collection<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DA260 Offset: 0x30DA361 VA: 0x30DA260
	|-Collection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DA2B0 Offset: 0x30DA3B1 VA: 0x30DA2B0
	|-Collection<IEnumerable<Claim>>.get_Count
	|-Collection<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DA340 Offset: 0x30DA441 VA: 0x30DA340
	|-Collection<IEnumerable<Claim>>.get_Item
	|-Collection<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DA3E0 Offset: 0x30DA4E1 VA: 0x30DA3E0
	|-Collection<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DA560 Offset: 0x30DA661 VA: 0x30DA560
	|-Collection<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DA6C0 Offset: 0x30DA7C1 VA: 0x30DA6C0
	|-Collection<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DA790 Offset: 0x30DA891 VA: 0x30DA790
	|-Collection<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DA840 Offset: 0x30DA941 VA: 0x30DA840
	|-Collection<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DA8E0 Offset: 0x30DA9E1 VA: 0x30DA8E0
	|-Collection<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DA970 Offset: 0x30DAA71 VA: 0x30DA970
	|-Collection<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DAA10 Offset: 0x30DAB11 VA: 0x30DAA10
	|-Collection<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DAB90 Offset: 0x30DAC91 VA: 0x30DAB90
	|-Collection<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DAD10 Offset: 0x30DAE11 VA: 0x30DAD10
	|-Collection<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 34
	protected virtual void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DAE80 Offset: 0x30DAF81 VA: 0x30DAE80
	|-Collection<object>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected virtual void InsertItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DAF10 Offset: 0x30DB011 VA: 0x30DAF10
	|-Collection<object>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected virtual void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DAFC0 Offset: 0x30DB0C1 VA: 0x30DAFC0
	|-Collection<object>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected virtual void SetItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DB060 Offset: 0x30DB161 VA: 0x30DB060
	|-Collection<object>.SetItem
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DB110 Offset: 0x30DB211 VA: 0x30DB110
	|-Collection<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DB1A0 Offset: 0x30DB2A1 VA: 0x30DB1A0
	|-Collection<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DB250 Offset: 0x30DB351 VA: 0x30DB250
	|-Collection<object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DB260 Offset: 0x30DB361 VA: 0x30DB260
	|-Collection<object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DB380 Offset: 0x30DB481 VA: 0x30DB380
	|-Collection<object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DB820 Offset: 0x30DB921 VA: 0x30DB820
	|-Collection<object>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DB8C0 Offset: 0x30DB9C1 VA: 0x30DB8C0
	|-Collection<object>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DBA60 Offset: 0x30DBB61 VA: 0x30DBA60
	|-Collection<object>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DBAF0 Offset: 0x30DBBF1 VA: 0x30DBAF0
	|-Collection<object>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DBD30 Offset: 0x30DBE31 VA: 0x30DBD30
	|-Collection<object>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DBE00 Offset: 0x30DBF01 VA: 0x30DBE00
	|-Collection<object>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DBED0 Offset: 0x30DBFD1 VA: 0x30DBED0
	|-Collection<object>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DC100 Offset: 0x30DC201 VA: 0x30DC100
	|-Collection<object>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30DC270 Offset: 0x30DC371 VA: 0x30DC270
	|-Collection<object>.IsCompatibleObject
	*/
}

