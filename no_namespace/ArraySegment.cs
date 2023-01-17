// Namespace: 
[Serializable]
private sealed class ArraySegment.ArraySegmentEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 169
{
	// Fields
	private T[] _array; // 0x0
	private int _start; // 0x0
	private int _end; // 0x0
	private int _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ArraySegment<T> arraySegment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFB420 Offset: 0x1FFB521 VA: 0x1FFB420
	|-ArraySegment.ArraySegmentEnumerator<byte>..ctor
	|
	|-RVA: 0x1FFB5F0 Offset: 0x1FFB6F1 VA: 0x1FFB5F0
	|-ArraySegment.ArraySegmentEnumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFB480 Offset: 0x1FFB581 VA: 0x1FFB480
	|-ArraySegment.ArraySegmentEnumerator<byte>.MoveNext
	|
	|-RVA: 0x1FFB650 Offset: 0x1FFB751 VA: 0x1FFB650
	|-ArraySegment.ArraySegmentEnumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFB4B0 Offset: 0x1FFB5B1 VA: 0x1FFB4B0
	|-ArraySegment.ArraySegmentEnumerator<byte>.get_Current
	|
	|-RVA: 0x1FFB680 Offset: 0x1FFB781 VA: 0x1FFB680
	|-ArraySegment.ArraySegmentEnumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFB570 Offset: 0x1FFB671 VA: 0x1FFB570
	|-ArraySegment.ArraySegmentEnumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1FFB740 Offset: 0x1FFB841 VA: 0x1FFB740
	|-ArraySegment.ArraySegmentEnumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFB5D0 Offset: 0x1FFB6D1 VA: 0x1FFB5D0
	|-ArraySegment.ArraySegmentEnumerator<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1FFB760 Offset: 0x1FFB861 VA: 0x1FFB760
	|-ArraySegment.ArraySegmentEnumerator<object>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FFB5E0 Offset: 0x1FFB6E1 VA: 0x1FFB5E0
	|-ArraySegment.ArraySegmentEnumerator<byte>.Dispose
	|
	|-RVA: 0x1FFB770 Offset: 0x1FFB871 VA: 0x1FFB770
	|-ArraySegment.ArraySegmentEnumerator<object>.Dispose
	*/
}

