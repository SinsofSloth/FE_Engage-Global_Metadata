// Namespace: UniRx.InternalUtil
internal class PriorityQueue<T> // TypeDefIndex: 7242
{
	// Fields
	private static long _count; // 0x0
	private PriorityQueue.IndexedItem<T>[] _items; // 0x0
	private int _size; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A83BD0 Offset: 0x2A83CD1 VA: 0x2A83BD0
	|-PriorityQueue<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A83BF0 Offset: 0x2A83CF1 VA: 0x2A83BF0
	|-PriorityQueue<object>..ctor
	|-PriorityQueue<ScheduledItem>..ctor
	*/

	// RVA: -1 Offset: -1
	private bool IsHigherPriority(int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A83C60 Offset: 0x2A83D61 VA: 0x2A83C60
	|-PriorityQueue<object>.IsHigherPriority
	*/

	// RVA: -1 Offset: -1
	private void Percolate(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A83CC0 Offset: 0x2A83DC1 VA: 0x2A83CC0
	|-PriorityQueue<object>.Percolate
	*/

	// RVA: -1 Offset: -1
	private void Heapify() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A83DF0 Offset: 0x2A83EF1 VA: 0x2A83DF0
	|-PriorityQueue<object>.Heapify
	*/

	// RVA: -1 Offset: -1
	private void Heapify(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A83E10 Offset: 0x2A83F11 VA: 0x2A83E10
	|-PriorityQueue<object>.Heapify
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A83F90 Offset: 0x2A84091 VA: 0x2A83F90
	|-PriorityQueue<object>.get_Count
	|-PriorityQueue<ScheduledItem>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A83FA0 Offset: 0x2A840A1 VA: 0x2A83FA0
	|-PriorityQueue<object>.Peek
	|-PriorityQueue<ScheduledItem>.Peek
	*/

	// RVA: -1 Offset: -1
	private void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A84030 Offset: 0x2A84131 VA: 0x2A84030
	|-PriorityQueue<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A84170 Offset: 0x2A84271 VA: 0x2A84170
	|-PriorityQueue<object>.Dequeue
	|-PriorityQueue<ScheduledItem>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A841D0 Offset: 0x2A842D1 VA: 0x2A841D0
	|-PriorityQueue<object>.Enqueue
	|-PriorityQueue<ScheduledItem>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A84390 Offset: 0x2A84491 VA: 0x2A84390
	|-PriorityQueue<object>.Remove
	|-PriorityQueue<ScheduledItem>.Remove
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A84460 Offset: 0x2A84561 VA: 0x2A84460
	|-PriorityQueue<object>..cctor
	*/
}

