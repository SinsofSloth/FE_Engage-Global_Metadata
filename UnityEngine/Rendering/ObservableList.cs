// Namespace: UnityEngine.Rendering
[DefaultMemberAttribute] // RVA: 0x3B590 Offset: 0x3B691 VA: 0x3B590
public class ObservableList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 4543
{
	// Fields
	private IList<T> m_List; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x3CA40 Offset: 0x3CB41 VA: 0x3CA40
	private ListChangedEventHandler<T> ItemAdded; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x3CA50 Offset: 0x3CB51 VA: 0x3CA50
	private ListChangedEventHandler<T> ItemRemoved; // 0x0

	// Properties
	public T Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D6B0 Offset: 0x3D7B1 VA: 0x3D6B0
	// RVA: -1 Offset: -1
	public void add_ItemAdded(ListChangedEventHandler<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D740 Offset: 0x370D841 VA: 0x370D740
	|-ObservableList<object>.add_ItemAdded
	|-ObservableList<DebugUI.Widget>.add_ItemAdded
	*/

	[CompilerGeneratedAttribute] // RVA: 0x3D6C0 Offset: 0x3D7C1 VA: 0x3D6C0
	// RVA: -1 Offset: -1
	public void remove_ItemAdded(ListChangedEventHandler<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D7F0 Offset: 0x370D8F1 VA: 0x370D7F0
	|-ObservableList<object>.remove_ItemAdded
	*/

	[CompilerGeneratedAttribute] // RVA: 0x3D6D0 Offset: 0x3D7D1 VA: 0x3D6D0
	// RVA: -1 Offset: -1
	public void add_ItemRemoved(ListChangedEventHandler<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D8A0 Offset: 0x370D9A1 VA: 0x370D8A0
	|-ObservableList<object>.add_ItemRemoved
	|-ObservableList<DebugUI.Widget>.add_ItemRemoved
	*/

	[CompilerGeneratedAttribute] // RVA: 0x3D6E0 Offset: 0x3D7E1 VA: 0x3D6E0
	// RVA: -1 Offset: -1
	public void remove_ItemRemoved(ListChangedEventHandler<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370D950 Offset: 0x370DA51 VA: 0x370D950
	|-ObservableList<object>.remove_ItemRemoved
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370DA00 Offset: 0x370DB01 VA: 0x370DA00
	|-ObservableList<object>.get_Item
	|-ObservableList<DebugUI.Widget>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370DAA0 Offset: 0x370DBA1 VA: 0x370DAA0
	|-ObservableList<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370DC30 Offset: 0x370DD31 VA: 0x370DC30
	|-ObservableList<object>.get_Count
	|-ObservableList<DebugUI.Widget>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370DCC0 Offset: 0x370DDC1 VA: 0x370DCC0
	|-ObservableList<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370DCD0 Offset: 0x370DDD1 VA: 0x370DCD0
	|-ObservableList<object>..ctor
	|-ObservableList<DebugUI.Widget>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370DCF0 Offset: 0x370DDF1 VA: 0x370DCF0
	|-ObservableList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370DD70 Offset: 0x370DE71 VA: 0x370DD70
	|-ObservableList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void OnEvent(ListChangedEventHandler<T> e, int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370DDF0 Offset: 0x370DEF1 VA: 0x370DDF0
	|-ObservableList<object>.OnEvent
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370DEA0 Offset: 0x370DFA1 VA: 0x370DEA0
	|-ObservableList<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370DF40 Offset: 0x370E041 VA: 0x370DF40
	|-ObservableList<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370DFE0 Offset: 0x370E0E1 VA: 0x370DFE0
	|-ObservableList<object>.Add
	|-ObservableList<DebugUI.Widget>.Add
	*/

	// RVA: -1 Offset: -1
	public void Add(T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370E140 Offset: 0x370E241 VA: 0x370E140
	|-ObservableList<object>.Add
	|-ObservableList<DebugUI.Widget>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370E1D0 Offset: 0x370E2D1 VA: 0x370E1D0
	|-ObservableList<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370E2B0 Offset: 0x370E3B1 VA: 0x370E2B0
	|-ObservableList<object>.Remove
	|-ObservableList<DebugUI.Widget>.Remove
	*/

	// RVA: -1 Offset: -1
	public int Remove(T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370E420 Offset: 0x370E521 VA: 0x370E420
	|-ObservableList<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370E4D0 Offset: 0x370E5D1 VA: 0x370E4D0
	|-ObservableList<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370E630 Offset: 0x370E731 VA: 0x370E630
	|-ObservableList<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370E6C0 Offset: 0x370E7C1 VA: 0x370E6C0
	|-ObservableList<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370E770 Offset: 0x370E871 VA: 0x370E770
	|-ObservableList<object>.GetEnumerator
	|-ObservableList<DebugUI.Widget>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x370E800 Offset: 0x370E901 VA: 0x370E800
	|-ObservableList<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

