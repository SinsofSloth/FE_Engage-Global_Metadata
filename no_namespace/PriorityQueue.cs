// Namespace: 
private class PriorityQueue.StackItem<TValue> // TypeDefIndex: 5521
{
	// Fields
	internal int p; // 0x0
	internal int r; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BAF70 Offset: 0x36BB071 VA: 0x36BAF70
	|-PriorityQueue.StackItem<object>..ctor
	*/
}

// Namespace: 
private struct PriorityQueue.IndexedItem<T> : IComparable<PriorityQueue.IndexedItem<T>> // TypeDefIndex: 7241
{
	// Fields
	public T Value; // 0x0
	public long Id; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public int CompareTo(PriorityQueue.IndexedItem<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2980 Offset: 0x1EB2A81 VA: 0x1EB2980
	|-PriorityQueue.IndexedItem<object>.CompareTo
	*/
}

