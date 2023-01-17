// Namespace: System.Collections.Generic
internal struct LargeArrayBuilder<T> // TypeDefIndex: 3281
{
	// Fields
	private readonly int _maxCapacity; // 0x0
	private T[] _first; // 0x0
	private ArrayBuilder<T[]> _buffers; // 0x0
	private T[] _current; // 0x0
	private int _index; // 0x0
	private int _count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(bool initialize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289DBF0 Offset: 0x289DCF1 VA: 0x289DBF0
	|-LargeArrayBuilder<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int maxCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289DCB0 Offset: 0x289DDB1 VA: 0x289DCB0
	|-LargeArrayBuilder<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289DD60 Offset: 0x289DE61 VA: 0x289DD60
	|-LargeArrayBuilder<object>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int arrayIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289E0F0 Offset: 0x289E1F1 VA: 0x289E0F0
	|-LargeArrayBuilder<object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public T[] GetBuffer(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289E270 Offset: 0x289E371 VA: 0x289E270
	|-LargeArrayBuilder<object>.GetBuffer
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289E310 Offset: 0x289E411 VA: 0x289E310
	|-LargeArrayBuilder<object>.ToArray
	*/

	// RVA: -1 Offset: -1
	public bool TryMove(out T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289E3F0 Offset: 0x289E4F1 VA: 0x289E3F0
	|-LargeArrayBuilder<object>.TryMove
	*/

	// RVA: -1 Offset: -1
	private void AllocateBuffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x289E440 Offset: 0x289E541 VA: 0x289E440
	|-LargeArrayBuilder<object>.AllocateBuffer
	*/
}

