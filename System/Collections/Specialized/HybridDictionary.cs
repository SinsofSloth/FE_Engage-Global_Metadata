// Namespace: System.Collections.Specialized
[DefaultMemberAttribute] // RVA: 0x30790 Offset: 0x30891 VA: 0x30790
[Serializable]
public class HybridDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 2391
{
	// Fields
	private ListDictionary list; // 0x10
	private Hashtable hashtable; // 0x18
	private bool caseInsensitive; // 0x20

	// Properties
	public object Item { get; set; }
	private ListDictionary List { get; }
	public int Count { get; }
	public ICollection Keys { get; }
	public bool IsReadOnly { get; }
	public bool IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x1AF1980 Offset: 0x1AF1A81 VA: 0x1AF1980
	public void .ctor() { }

	// RVA: 0x1AF1990 Offset: 0x1AF1A91 VA: 0x1AF1990 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x1AF1A50 Offset: 0x1AF1B51 VA: 0x1AF1A50 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x1AF1E90 Offset: 0x1AF1F91 VA: 0x1AF1E90
	private ListDictionary get_List() { }

	// RVA: 0x1AF1BC0 Offset: 0x1AF1CC1 VA: 0x1AF1BC0
	private void ChangeOver() { }

	// RVA: 0x1AF1FE0 Offset: 0x1AF20E1 VA: 0x1AF1FE0 Slot: 15
	public int get_Count() { }

	// RVA: 0x1AF2020 Offset: 0x1AF2121 VA: 0x1AF2020 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x1AF2060 Offset: 0x1AF2161 VA: 0x1AF2060 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x1AF2070 Offset: 0x1AF2171 VA: 0x1AF2070 Slot: 11
	public bool get_IsFixedSize() { }

	// RVA: 0x1AF2080 Offset: 0x1AF2181 VA: 0x1AF2080 Slot: 17
	public bool get_IsSynchronized() { }

	// RVA: 0x1AF2090 Offset: 0x1AF2191 VA: 0x1AF2090 Slot: 16
	public object get_SyncRoot() { }

	// RVA: 0x1AF20A0 Offset: 0x1AF21A1 VA: 0x1AF20A0 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x1AF20E0 Offset: 0x1AF21E1 VA: 0x1AF20E0 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x1AF2260 Offset: 0x1AF2361 VA: 0x1AF2260 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x1AF2320 Offset: 0x1AF2421 VA: 0x1AF2320 Slot: 14
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1AF2380 Offset: 0x1AF2481 VA: 0x1AF2380 Slot: 12
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1AF24B0 Offset: 0x1AF25B1 VA: 0x1AF24B0 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1AF25E0 Offset: 0x1AF26E1 VA: 0x1AF25E0 Slot: 13
	public void Remove(object key) { }
}

