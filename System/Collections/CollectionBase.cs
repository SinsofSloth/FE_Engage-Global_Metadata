// Namespace: System.Collections
[ComVisibleAttribute] // RVA: 0x476B70 Offset: 0x476C71 VA: 0x476B70
[Serializable]
public abstract class CollectionBase : IList, ICollection, IEnumerable // TypeDefIndex: 1343
{
	// Fields
	private ArrayList list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	protected IList List { get; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x33A6E80 Offset: 0x33A6F81 VA: 0x33A6E80
	protected void .ctor() { }

	// RVA: 0x33A6F00 Offset: 0x33A7001 VA: 0x33A6F00
	protected ArrayList get_InnerList() { }

	// RVA: 0x33A6F90 Offset: 0x33A7091 VA: 0x33A6F90
	protected IList get_List() { }

	// RVA: 0x33A6FA0 Offset: 0x33A70A1 VA: 0x33A6FA0 Slot: 15
	public int get_Count() { }

	// RVA: 0x33A6FC0 Offset: 0x33A70C1 VA: 0x33A6FC0 Slot: 8
	public void Clear() { }

	// RVA: 0x33A7070 Offset: 0x33A7171 VA: 0x33A7070 Slot: 13
	public void RemoveAt(int index) { }

	// RVA: 0x33A7300 Offset: 0x33A7401 VA: 0x33A7300 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x33A7380 Offset: 0x33A7481 VA: 0x33A7380 Slot: 17
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x33A7400 Offset: 0x33A7501 VA: 0x33A7400 Slot: 16
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x33A7480 Offset: 0x33A7581 VA: 0x33A7480 Slot: 14
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x33A7520 Offset: 0x33A7621 VA: 0x33A7520 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x33A7640 Offset: 0x33A7741 VA: 0x33A7640 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x33A78E0 Offset: 0x33A79E1 VA: 0x33A78E0 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x33A7970 Offset: 0x33A7A71 VA: 0x33A7970 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x33A7B70 Offset: 0x33A7C71 VA: 0x33A7B70 Slot: 12
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x33A7DC0 Offset: 0x33A7EC1 VA: 0x33A7DC0 Slot: 10
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x33A7E50 Offset: 0x33A7F51 VA: 0x33A7E50 Slot: 11
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x33A8080 Offset: 0x33A8181 VA: 0x33A8080 Slot: 18
	public IEnumerator GetEnumerator() { }

	// RVA: 0x33A8100 Offset: 0x33A8201 VA: 0x33A8100 Slot: 19
	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x33A8110 Offset: 0x33A8211 VA: 0x33A8110 Slot: 20
	protected virtual void OnInsert(int index, object value) { }

	// RVA: 0x33A8120 Offset: 0x33A8221 VA: 0x33A8120 Slot: 21
	protected virtual void OnClear() { }

	// RVA: 0x33A8130 Offset: 0x33A8231 VA: 0x33A8130 Slot: 22
	protected virtual void OnRemove(int index, object value) { }

	// RVA: 0x33A8140 Offset: 0x33A8241 VA: 0x33A8140 Slot: 23
	protected virtual void OnValidate(object value) { }

	// RVA: 0x33A81A0 Offset: 0x33A82A1 VA: 0x33A81A0 Slot: 24
	protected virtual void OnSetComplete(int index, object oldValue, object newValue) { }

	// RVA: 0x33A81B0 Offset: 0x33A82B1 VA: 0x33A81B0 Slot: 25
	protected virtual void OnInsertComplete(int index, object value) { }

	// RVA: 0x33A81C0 Offset: 0x33A82C1 VA: 0x33A81C0 Slot: 26
	protected virtual void OnClearComplete() { }

	// RVA: 0x33A81D0 Offset: 0x33A82D1 VA: 0x33A81D0 Slot: 27
	protected virtual void OnRemoveComplete(int index, object value) { }
}

