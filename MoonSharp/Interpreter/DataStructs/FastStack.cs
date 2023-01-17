// Namespace: MoonSharp.Interpreter.DataStructs
[DefaultMemberAttribute] // RVA: 0xDA30 Offset: 0xDB31 VA: 0xDA30
internal class FastStack<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 6220
{
	// Fields
	private T[] m_Storage; // 0x0
	private int m_HeadIdx; // 0x0

	// Properties
	public T Item { get; set; }
	public int Count { get; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	private int System.Collections.Generic.ICollection<T>.Count { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int maxCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1090 Offset: 0x33D1191 VA: 0x33D1090
	|-FastStack<CallStackItem>..ctor
	|-FastStack<DynValue>..ctor
	|-FastStack<ILoop>..ctor
	|-FastStack<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1100 Offset: 0x33D1201 VA: 0x33D1100
	|-FastStack<DynValue>.get_Item
	|-FastStack<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1140 Offset: 0x33D1241 VA: 0x33D1140
	|-FastStack<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public T Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1180 Offset: 0x33D1281 VA: 0x33D1180
	|-FastStack<CallStackItem>.Push
	|-FastStack<DynValue>.Push
	|-FastStack<ILoop>.Push
	|-FastStack<object>.Push
	*/

	// RVA: -1 Offset: -1
	public void Expand(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D11E0 Offset: 0x33D12E1 VA: 0x33D11E0
	|-FastStack<object>.Expand
	*/

	// RVA: -1 Offset: -1
	private void Zero(int from, int to) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D11F0 Offset: 0x33D12F1 VA: 0x33D11F0
	|-FastStack<object>.Zero
	*/

	// RVA: -1 Offset: -1
	private void Zero(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1210 Offset: 0x33D1311 VA: 0x33D1210
	|-FastStack<object>.Zero
	*/

	// RVA: -1 Offset: -1
	public T Peek(int idxofs = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1250 Offset: 0x33D1351 VA: 0x33D1250
	|-FastStack<CallStackItem>.Peek
	|-FastStack<DynValue>.Peek
	|-FastStack<ILoop>.Peek
	|-FastStack<object>.Peek
	*/

	// RVA: -1 Offset: -1
	public void Set(int idxofs, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1290 Offset: 0x33D1391 VA: 0x33D1290
	|-FastStack<DynValue>.Set
	|-FastStack<object>.Set
	*/

	// RVA: -1 Offset: -1
	public void CropAtCount(int p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D12E0 Offset: 0x33D13E1 VA: 0x33D12E0
	|-FastStack<DynValue>.CropAtCount
	|-FastStack<object>.CropAtCount
	*/

	// RVA: -1 Offset: -1
	public void RemoveLast(int cnt = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1340 Offset: 0x33D1441 VA: 0x33D1340
	|-FastStack<DynValue>.RemoveLast
	|-FastStack<object>.RemoveLast
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D13B0 Offset: 0x33D14B1 VA: 0x33D13B0
	|-FastStack<CallStackItem>.Pop
	|-FastStack<DynValue>.Pop
	|-FastStack<ILoop>.Pop
	|-FastStack<object>.Pop
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1410 Offset: 0x33D1511 VA: 0x33D1410
	|-FastStack<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1450 Offset: 0x33D1551 VA: 0x33D1450
	|-FastStack<CallStackItem>.get_Count
	|-FastStack<DynValue>.get_Count
	|-FastStack<ILoop>.get_Count
	|-FastStack<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.Generic.IList<T>.IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1460 Offset: 0x33D1561 VA: 0x33D1460
	|-FastStack<object>.System.Collections.Generic.IList<T>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IList<T>.Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D14A0 Offset: 0x33D15A1 VA: 0x33D14A0
	|-FastStack<object>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D14E0 Offset: 0x33D15E1 VA: 0x33D14E0
	|-FastStack<object>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1520 Offset: 0x33D1621 VA: 0x33D1520
	|-FastStack<object>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1540 Offset: 0x33D1641 VA: 0x33D1540
	|-FastStack<object>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1560 Offset: 0x33D1661 VA: 0x33D1560
	|-FastStack<object>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1580 Offset: 0x33D1681 VA: 0x33D1580
	|-FastStack<object>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<T>.Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D15A0 Offset: 0x33D16A1 VA: 0x33D15A0
	|-FastStack<object>.System.Collections.Generic.ICollection<T>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<T>.CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D15E0 Offset: 0x33D16E1 VA: 0x33D15E0
	|-FastStack<object>.System.Collections.Generic.ICollection<T>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Collections.Generic.ICollection<T>.get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1620 Offset: 0x33D1721 VA: 0x33D1620
	|-FastStack<object>.System.Collections.Generic.ICollection<T>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1640 Offset: 0x33D1741 VA: 0x33D1640
	|-FastStack<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<T>.Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1650 Offset: 0x33D1751 VA: 0x33D1650
	|-FastStack<object>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D1690 Offset: 0x33D1791 VA: 0x33D1690
	|-FastStack<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D16D0 Offset: 0x33D17D1 VA: 0x33D16D0
	|-FastStack<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

