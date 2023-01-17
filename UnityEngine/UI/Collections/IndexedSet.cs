// Namespace: UnityEngine.UI.Collections
[DefaultMemberAttribute] // RVA: 0x43740 Offset: 0x43841 VA: 0x43740
internal class IndexedSet<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 4375
{
	// Fields
	private readonly List<T> m_List; // 0x0
	private Dictionary<T, int> m_Dictionary; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2A90 Offset: 0x1EB2B91 VA: 0x1EB2A90
	|-IndexedSet<Graphic>.Add
	|-IndexedSet<object>.Add
	*/

	// RVA: -1 Offset: -1
	public bool AddUnique(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2B10 Offset: 0x1EB2C11 VA: 0x1EB2B10
	|-IndexedSet<Graphic>.AddUnique
	|-IndexedSet<ICanvasElement>.AddUnique
	|-IndexedSet<IClipper>.AddUnique
	|-IndexedSet<object>.AddUnique
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2BD0 Offset: 0x1EB2CD1 VA: 0x1EB2BD0
	|-IndexedSet<Graphic>.Remove
	|-IndexedSet<ICanvasElement>.Remove
	|-IndexedSet<IClipper>.Remove
	|-IndexedSet<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2C60 Offset: 0x1EB2D61 VA: 0x1EB2C60
	|-IndexedSet<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2CA0 Offset: 0x1EB2DA1 VA: 0x1EB2CA0
	|-IndexedSet<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2CC0 Offset: 0x1EB2DC1 VA: 0x1EB2CC0
	|-IndexedSet<ICanvasElement>.Clear
	|-IndexedSet<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2D10 Offset: 0x1EB2E11 VA: 0x1EB2D10
	|-IndexedSet<ICanvasElement>.Contains
	|-IndexedSet<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2D30 Offset: 0x1EB2E31 VA: 0x1EB2D30
	|-IndexedSet<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2D50 Offset: 0x1EB2E51 VA: 0x1EB2D50
	|-IndexedSet<Graphic>.get_Count
	|-IndexedSet<ICanvasElement>.get_Count
	|-IndexedSet<IClipper>.get_Count
	|-IndexedSet<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2D70 Offset: 0x1EB2E71 VA: 0x1EB2D70
	|-IndexedSet<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2D80 Offset: 0x1EB2E81 VA: 0x1EB2D80
	|-IndexedSet<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2DD0 Offset: 0x1EB2ED1 VA: 0x1EB2DD0
	|-IndexedSet<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2E30 Offset: 0x1EB2F31 VA: 0x1EB2E30
	|-IndexedSet<ICanvasElement>.RemoveAt
	|-IndexedSet<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2F60 Offset: 0x1EB3061 VA: 0x1EB2F60
	|-IndexedSet<ICanvasElement>.get_Item
	|-IndexedSet<IClipper>.get_Item
	|-IndexedSet<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2F80 Offset: 0x1EB3081 VA: 0x1EB2F80
	|-IndexedSet<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB3020 Offset: 0x1EB3121 VA: 0x1EB3020
	|-IndexedSet<object>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> sortLayoutFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB3100 Offset: 0x1EB3201 VA: 0x1EB3100
	|-IndexedSet<ICanvasElement>.Sort
	|-IndexedSet<object>.Sort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB31D0 Offset: 0x1EB32D1 VA: 0x1EB31D0
	|-IndexedSet<Graphic>..ctor
	|-IndexedSet<ICanvasElement>..ctor
	|-IndexedSet<IClipper>..ctor
	|-IndexedSet<object>..ctor
	*/
}

