// Namespace: 
[DefaultMemberAttribute] // RVA: 0x722E0 Offset: 0x723E1 VA: 0x722E0
internal class ListWithEvents<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 5536
{
	// Fields
	private List<T> m_List; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x72520 Offset: 0x72621 VA: 0x72520
	private Action<T> OnElementAdded; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x72530 Offset: 0x72631 VA: 0x72530
	private Action<T> OnElementRemoved; // 0x0

	// Properties
	public T Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x72B10 Offset: 0x72C11 VA: 0x72B10
	// RVA: -1 Offset: -1
	public void add_OnElementAdded(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09120 Offset: 0x3B09221 VA: 0x3B09120
	|-ListWithEvents<IResourceProvider>.add_OnElementAdded
	|-ListWithEvents<IUpdateReceiver>.add_OnElementAdded
	|-ListWithEvents<object>.add_OnElementAdded
	*/

	[CompilerGeneratedAttribute] // RVA: 0x72B20 Offset: 0x72C21 VA: 0x72B20
	// RVA: -1 Offset: -1
	public void remove_OnElementAdded(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B091D0 Offset: 0x3B092D1 VA: 0x3B091D0
	|-ListWithEvents<object>.remove_OnElementAdded
	*/

	[CompilerGeneratedAttribute] // RVA: 0x72B30 Offset: 0x72C31 VA: 0x72B30
	// RVA: -1 Offset: -1
	public void add_OnElementRemoved(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09280 Offset: 0x3B09381 VA: 0x3B09280
	|-ListWithEvents<IResourceProvider>.add_OnElementRemoved
	|-ListWithEvents<object>.add_OnElementRemoved
	*/

	[CompilerGeneratedAttribute] // RVA: 0x72B40 Offset: 0x72C41 VA: 0x72B40
	// RVA: -1 Offset: -1
	public void remove_OnElementRemoved(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09330 Offset: 0x3B09431 VA: 0x3B09330
	|-ListWithEvents<object>.remove_OnElementRemoved
	*/

	// RVA: -1 Offset: -1
	private void InvokeAdded(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B093E0 Offset: 0x3B094E1 VA: 0x3B093E0
	|-ListWithEvents<object>.InvokeAdded
	*/

	// RVA: -1 Offset: -1
	private void InvokeRemoved(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09400 Offset: 0x3B09501 VA: 0x3B09400
	|-ListWithEvents<object>.InvokeRemoved
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09420 Offset: 0x3B09521 VA: 0x3B09420
	|-ListWithEvents<IUpdateReceiver>.get_Item
	|-ListWithEvents<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09440 Offset: 0x3B09541 VA: 0x3B09440
	|-ListWithEvents<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B094F0 Offset: 0x3B095F1 VA: 0x3B094F0
	|-ListWithEvents<IUpdateReceiver>.get_Count
	|-ListWithEvents<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09510 Offset: 0x3B09611 VA: 0x3B09510
	|-ListWithEvents<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B095A0 Offset: 0x3B096A1 VA: 0x3B095A0
	|-ListWithEvents<IUpdateReceiver>.Add
	|-ListWithEvents<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09600 Offset: 0x3B09701 VA: 0x3B09600
	|-ListWithEvents<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09800 Offset: 0x3B09901 VA: 0x3B09800
	|-ListWithEvents<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09820 Offset: 0x3B09921 VA: 0x3B09820
	|-ListWithEvents<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09840 Offset: 0x3B09941 VA: 0x3B09840
	|-ListWithEvents<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B098C0 Offset: 0x3B099C1 VA: 0x3B098C0
	|-ListWithEvents<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B098E0 Offset: 0x3B099E1 VA: 0x3B098E0
	|-ListWithEvents<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09940 Offset: 0x3B09A41 VA: 0x3B09940
	|-ListWithEvents<IUpdateReceiver>.Remove
	|-ListWithEvents<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B099C0 Offset: 0x3B09AC1 VA: 0x3B099C0
	|-ListWithEvents<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09A40 Offset: 0x3B09B41 VA: 0x3B09A40
	|-ListWithEvents<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09AF0 Offset: 0x3B09BF1 VA: 0x3B09AF0
	|-ListWithEvents<IResourceProvider>..ctor
	|-ListWithEvents<IUpdateReceiver>..ctor
	|-ListWithEvents<object>..ctor
	*/
}

