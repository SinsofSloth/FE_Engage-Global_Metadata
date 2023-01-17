// Namespace: System.Runtime.CompilerServices
[DefaultMemberAttribute] // RVA: 0x40630 Offset: 0x40731 VA: 0x40630
[Serializable]
public sealed class ReadOnlyCollectionBuilder<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection // TypeDefIndex: 3268
{
	// Fields
	private T[] _items; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0

	// Properties
	public int Capacity { set; }
	public int Count { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3465FD0 Offset: 0x34660D1 VA: 0x3465FD0
	|-ReadOnlyCollectionBuilder<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466020 Offset: 0x3466121 VA: 0x3466020
	|-ReadOnlyCollectionBuilder<object>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466150 Offset: 0x3466251 VA: 0x3466150
	|-ReadOnlyCollectionBuilder<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466160 Offset: 0x3466261 VA: 0x3466160
	|-ReadOnlyCollectionBuilder<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466190 Offset: 0x3466291 VA: 0x3466190
	|-ReadOnlyCollectionBuilder<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34662C0 Offset: 0x34663C1 VA: 0x34662C0
	|-ReadOnlyCollectionBuilder<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34663A0 Offset: 0x34664A1 VA: 0x34663A0
	|-ReadOnlyCollectionBuilder<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466430 Offset: 0x3466531 VA: 0x3466430
	|-ReadOnlyCollectionBuilder<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34664E0 Offset: 0x34665E1 VA: 0x34664E0
	|-ReadOnlyCollectionBuilder<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466580 Offset: 0x3466681 VA: 0x3466580
	|-ReadOnlyCollectionBuilder<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34665D0 Offset: 0x34666D1 VA: 0x34665D0
	|-ReadOnlyCollectionBuilder<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34666D0 Offset: 0x34667D1 VA: 0x34666D0
	|-ReadOnlyCollectionBuilder<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34666F0 Offset: 0x34667F1 VA: 0x34666F0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466700 Offset: 0x3466801 VA: 0x3466700
	|-ReadOnlyCollectionBuilder<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466770 Offset: 0x3466871 VA: 0x3466770
	|-ReadOnlyCollectionBuilder<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34667E0 Offset: 0x34668E1 VA: 0x34667E0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466800 Offset: 0x3466901 VA: 0x3466800
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466810 Offset: 0x3466911 VA: 0x3466810
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466A00 Offset: 0x3466B01 VA: 0x3466A00
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466AD0 Offset: 0x3466BD1 VA: 0x3466AD0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466BA0 Offset: 0x3466CA1 VA: 0x3466BA0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466D80 Offset: 0x3466E81 VA: 0x3466D80
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466E50 Offset: 0x3466F51 VA: 0x3466E50
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3466E70 Offset: 0x3466F71 VA: 0x3466E70
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467050 Offset: 0x3467151 VA: 0x3467050
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467130 Offset: 0x3467231 VA: 0x3467130
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467140 Offset: 0x3467241 VA: 0x3467140
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467150 Offset: 0x3467251 VA: 0x3467150
	|-ReadOnlyCollectionBuilder<object>.ToArray
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> ToReadOnlyCollection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34671D0 Offset: 0x34672D1 VA: 0x34671D0
	|-ReadOnlyCollectionBuilder<object>.ToReadOnlyCollection
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34672A0 Offset: 0x34673A1 VA: 0x34672A0
	|-ReadOnlyCollectionBuilder<object>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34672E0 Offset: 0x34673E1 VA: 0x34672E0
	|-ReadOnlyCollectionBuilder<object>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1
	private static void ValidateNullValue(object value, string argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3467370 Offset: 0x3467471 VA: 0x3467370
	|-ReadOnlyCollectionBuilder<object>.ValidateNullValue
	*/
}

