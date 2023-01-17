// Namespace: MoonSharp.Interpreter.DataStructs
[DefaultMemberAttribute] // RVA: 0xDA70 Offset: 0xDB71 VA: 0xDA70
internal class Slice<T> : IEnumerable<T>, IEnumerable, IList<T>, ICollection<T> // TypeDefIndex: 6227
{
	// Fields
	private IList<T> m_SourceList; // 0x0
	private int m_From; // 0x0
	private int m_Length; // 0x0
	private bool m_Reversed; // 0x0

	// Properties
	public T Item { get; set; }
	public int From { get; }
	public int Count { get; }
	public bool Reversed { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list, int from, int length, bool reversed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444190 Offset: 0x3444291 VA: 0x3444190
	|-Slice<DynValue>..ctor
	|-Slice<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34441F0 Offset: 0x34442F1 VA: 0x34441F0
	|-Slice<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34442B0 Offset: 0x34443B1 VA: 0x34442B0
	|-Slice<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public int get_From() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444370 Offset: 0x3444471 VA: 0x3444370
	|-Slice<object>.get_From
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444380 Offset: 0x3444481 VA: 0x3444380
	|-Slice<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_Reversed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444390 Offset: 0x3444491 VA: 0x3444390
	|-Slice<object>.get_Reversed
	*/

	// RVA: -1 Offset: -1
	private int CalcRealIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34443A0 Offset: 0x34444A1 VA: 0x34443A0
	|-Slice<object>.CalcRealIndex
	*/

	[IteratorStateMachineAttribute] // RVA: 0x114F0 Offset: 0x115F1 VA: 0x114F0
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444430 Offset: 0x3444531 VA: 0x3444430
	|-Slice<object>.GetEnumerator
	*/

	[IteratorStateMachineAttribute] // RVA: 0x11560 Offset: 0x11661 VA: 0x11560
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34444B0 Offset: 0x34445B1 VA: 0x34444B0
	|-Slice<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444530 Offset: 0x3444631 VA: 0x3444530
	|-Slice<object>.ToArray
	*/

	// RVA: -1 Offset: -1
	public List<T> ToList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444680 Offset: 0x3444781 VA: 0x3444680
	|-Slice<object>.ToList
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34447E0 Offset: 0x34448E1 VA: 0x34447E0
	|-Slice<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34448A0 Offset: 0x34449A1 VA: 0x34448A0
	|-Slice<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444900 Offset: 0x3444A01 VA: 0x3444900
	|-Slice<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444960 Offset: 0x3444A61 VA: 0x3444960
	|-Slice<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34449C0 Offset: 0x3444AC1 VA: 0x34449C0
	|-Slice<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444A20 Offset: 0x3444B21 VA: 0x3444A20
	|-Slice<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444A50 Offset: 0x3444B51 VA: 0x3444A50
	|-Slice<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444B30 Offset: 0x3444C31 VA: 0x3444B30
	|-Slice<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444B40 Offset: 0x3444C41 VA: 0x3444B40
	|-Slice<object>.Remove
	*/
}

