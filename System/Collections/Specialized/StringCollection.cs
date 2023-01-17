// Namespace: System.Collections.Specialized
[DefaultMemberAttribute] // RVA: 0x30890 Offset: 0x30991 VA: 0x30890
[Serializable]
public class StringCollection : IList, ICollection, IEnumerable // TypeDefIndex: 2405
{
	// Fields
	private ArrayList data; // 0x10

	// Properties
	public string Item { get; set; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x2D12ED0 Offset: 0x2D12FD1 VA: 0x2D12ED0
	public string get_Item(int index) { }

	// RVA: 0x2D12F50 Offset: 0x2D13051 VA: 0x2D12F50
	public void set_Item(int index, string value) { }

	// RVA: 0x2D12F70 Offset: 0x2D13071 VA: 0x2D12F70 Slot: 15
	public int get_Count() { }

	// RVA: 0x2D12F90 Offset: 0x2D13091 VA: 0x2D12F90 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x2D12FA0 Offset: 0x2D130A1 VA: 0x2D12FA0
	public int Add(string value) { }

	// RVA: 0x2D12FC0 Offset: 0x2D130C1 VA: 0x2D12FC0 Slot: 8
	public void Clear() { }

	// RVA: 0x2D12FE0 Offset: 0x2D130E1 VA: 0x2D12FE0
	public bool Contains(string value) { }

	// RVA: 0x2D13000 Offset: 0x2D13101 VA: 0x2D13000
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x2D13020 Offset: 0x2D13121 VA: 0x2D13020
	public int IndexOf(string value) { }

	// RVA: 0x2D13040 Offset: 0x2D13141 VA: 0x2D13040
	public void Insert(int index, string value) { }

	// RVA: 0x2D13060 Offset: 0x2D13161 VA: 0x2D13060 Slot: 17
	public bool get_IsSynchronized() { }

	// RVA: 0x2D13070 Offset: 0x2D13171 VA: 0x2D13070
	public void Remove(string value) { }

	// RVA: 0x2D13090 Offset: 0x2D13191 VA: 0x2D13090 Slot: 13
	public void RemoveAt(int index) { }

	// RVA: 0x2D130B0 Offset: 0x2D131B1 VA: 0x2D130B0 Slot: 16
	public object get_SyncRoot() { }

	// RVA: 0x2D130D0 Offset: 0x2D131D1 VA: 0x2D130D0 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x2D13150 Offset: 0x2D13251 VA: 0x2D13150 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x2D131E0 Offset: 0x2D132E1 VA: 0x2D131E0 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x2D13260 Offset: 0x2D13361 VA: 0x2D13260 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x2D132E0 Offset: 0x2D133E1 VA: 0x2D132E0 Slot: 10
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x2D13360 Offset: 0x2D13461 VA: 0x2D13360 Slot: 11
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x2D133F0 Offset: 0x2D134F1 VA: 0x2D133F0 Slot: 12
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x2D13470 Offset: 0x2D13571 VA: 0x2D13470 Slot: 14
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2D13490 Offset: 0x2D13591 VA: 0x2D13490 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2D134B0 Offset: 0x2D135B1 VA: 0x2D134B0
	public void .ctor() { }
}

