// Namespace: UniRx
[Serializable]
public struct Pair<T> : IEquatable<Pair<T>> // TypeDefIndex: 6594
{
	// Fields
	private readonly T previous; // 0x0
	private readonly T current; // 0x0

	// Properties
	public T Previous { get; }
	public T Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Previous() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5F110 Offset: 0x2A5F211 VA: 0x2A5F110
	|-Pair<int>.get_Previous
	|
	|-RVA: 0x2A5F4F0 Offset: 0x2A5F5F1 VA: 0x2A5F4F0
	|-Pair<object>.get_Previous
	*/

	// RVA: -1 Offset: -1
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5F120 Offset: 0x2A5F221 VA: 0x2A5F120
	|-Pair<int>.get_Current
	|
	|-RVA: 0x2A5F500 Offset: 0x2A5F601 VA: 0x2A5F500
	|-Pair<object>.get_Current
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T previous, T current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5F130 Offset: 0x2A5F231 VA: 0x2A5F130
	|-Pair<int>..ctor
	|
	|-RVA: 0x2A5F510 Offset: 0x2A5F611 VA: 0x2A5F510
	|-Pair<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5F140 Offset: 0x2A5F241 VA: 0x2A5F140
	|-Pair<int>.GetHashCode
	|
	|-RVA: 0x2A5F550 Offset: 0x2A5F651 VA: 0x2A5F550
	|-Pair<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5F1E0 Offset: 0x2A5F2E1 VA: 0x2A5F1E0
	|-Pair<int>.Equals
	|
	|-RVA: 0x2A5F5F0 Offset: 0x2A5F6F1 VA: 0x2A5F5F0
	|-Pair<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(Pair<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5F310 Offset: 0x2A5F411 VA: 0x2A5F310
	|-Pair<int>.Equals
	|
	|-RVA: 0x2A5F720 Offset: 0x2A5F821 VA: 0x2A5F720
	|-Pair<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5F400 Offset: 0x2A5F501 VA: 0x2A5F400
	|-Pair<int>.ToString
	|
	|-RVA: 0x2A5F810 Offset: 0x2A5F911 VA: 0x2A5F810
	|-Pair<object>.ToString
	*/
}

