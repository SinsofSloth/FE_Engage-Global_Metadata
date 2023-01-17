// Namespace: System
[Serializable]
public struct ArraySegment<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 170
{
	// Fields
	private T[] _array; // 0x0
	private int _offset; // 0x0
	private int _count; // 0x0

	// Properties
	public T[] Array { get; }
	public int Offset { get; }
	public int Count { get; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	private T System.Collections.Generic.IReadOnlyList<T>.Item { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T[] get_Array() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFB780 Offset: 0x1FFB881 VA: 0x1FFB780
	|-ArraySegment<byte>.get_Array
	|
	|-RVA: 0x1FFC270 Offset: 0x1FFC371 VA: 0x1FFC270
	|-ArraySegment<object>.get_Array
	*/

	// RVA: -1 Offset: -1
	public int get_Offset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFB790 Offset: 0x1FFB891 VA: 0x1FFB790
	|-ArraySegment<byte>.get_Offset
	|
	|-RVA: 0x1FFC280 Offset: 0x1FFC381 VA: 0x1FFC280
	|-ArraySegment<object>.get_Offset
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFB7A0 Offset: 0x1FFB8A1 VA: 0x1FFB7A0
	|-ArraySegment<byte>.get_Count
	|
	|-RVA: 0x1FFC290 Offset: 0x1FFC391 VA: 0x1FFC290
	|-ArraySegment<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFB7B0 Offset: 0x1FFB8B1 VA: 0x1FFB7B0
	|-ArraySegment<byte>.GetHashCode
	|
	|-RVA: 0x1FFC2A0 Offset: 0x1FFC3A1 VA: 0x1FFC2A0
	|-ArraySegment<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFB7F0 Offset: 0x1FFB8F1 VA: 0x1FFB7F0
	|-ArraySegment<byte>.Equals
	|
	|-RVA: 0x1FFC2E0 Offset: 0x1FFC3E1 VA: 0x1FFC2E0
	|-ArraySegment<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool Equals(ArraySegment<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFB950 Offset: 0x1FFBA51 VA: 0x1FFB950
	|-ArraySegment<byte>.Equals
	|
	|-RVA: 0x1FFC440 Offset: 0x1FFC541 VA: 0x1FFC440
	|-ArraySegment<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFB990 Offset: 0x1FFBA91 VA: 0x1FFB990
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x1FFC480 Offset: 0x1FFC581 VA: 0x1FFC480
	|-ArraySegment<object>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFBA80 Offset: 0x1FFBB81 VA: 0x1FFBA80
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x1FFC570 Offset: 0x1FFC671 VA: 0x1FFC570
	|-ArraySegment<object>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.Generic.IList<T>.IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFBB70 Offset: 0x1FFBC71 VA: 0x1FFBB70
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x1FFC670 Offset: 0x1FFC771 VA: 0x1FFC670
	|-ArraySegment<object>.System.Collections.Generic.IList<T>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IList<T>.Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFBC70 Offset: 0x1FFBD71 VA: 0x1FFBC70
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x1FFC770 Offset: 0x1FFC871 VA: 0x1FFC770
	|-ArraySegment<object>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFBCB0 Offset: 0x1FFBDB1 VA: 0x1FFBCB0
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x1FFC7B0 Offset: 0x1FFC8B1 VA: 0x1FFC7B0
	|-ArraySegment<object>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private T System.Collections.Generic.IReadOnlyList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFBCF0 Offset: 0x1FFBDF1 VA: 0x1FFBCF0
	|-ArraySegment<byte>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x1FFC7F0 Offset: 0x1FFC8F1 VA: 0x1FFC7F0
	|-ArraySegment<object>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFBDE0 Offset: 0x1FFBEE1 VA: 0x1FFBDE0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x1FFC8E0 Offset: 0x1FFC9E1 VA: 0x1FFC8E0
	|-ArraySegment<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFBDF0 Offset: 0x1FFBEF1 VA: 0x1FFBDF0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1FFC8F0 Offset: 0x1FFC9F1 VA: 0x1FFC8F0
	|-ArraySegment<object>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFBE30 Offset: 0x1FFBF31 VA: 0x1FFBE30
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x1FFC930 Offset: 0x1FFCA31 VA: 0x1FFC930
	|-ArraySegment<object>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<T>.Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFBE70 Offset: 0x1FFBF71 VA: 0x1FFBE70
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x1FFC970 Offset: 0x1FFCA71 VA: 0x1FFC970
	|-ArraySegment<object>.System.Collections.Generic.ICollection<T>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<T>.CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFBF60 Offset: 0x1FFC061 VA: 0x1FFBF60
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.CopyTo
	|
	|-RVA: 0x1FFCA60 Offset: 0x1FFCB61 VA: 0x1FFCA60
	|-ArraySegment<object>.System.Collections.Generic.ICollection<T>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<T>.Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFBFF0 Offset: 0x1FFC0F1 VA: 0x1FFBFF0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x1FFCAF0 Offset: 0x1FFCBF1 VA: 0x1FFCAF0
	|-ArraySegment<object>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFC030 Offset: 0x1FFC131 VA: 0x1FFC030
	|-ArraySegment<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1FFCB30 Offset: 0x1FFCC31 VA: 0x1FFCB30
	|-ArraySegment<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFC150 Offset: 0x1FFC251 VA: 0x1FFC150
	|-ArraySegment<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1FFCC50 Offset: 0x1FFCD51 VA: 0x1FFCC50
	|-ArraySegment<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

