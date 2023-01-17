// Namespace: UniRx
[Serializable]
public struct FrameInterval<T> : IEquatable<FrameInterval<T>> // TypeDefIndex: 6673
{
	// Fields
	private readonly int _interval; // 0x0
	private readonly T _value; // 0x0

	// Properties
	public T Value { get; }
	public int Interval { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value, int interval) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DEB90 Offset: 0x33DEC91 VA: 0x33DEB90
	|-FrameInterval<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DEBA0 Offset: 0x33DECA1 VA: 0x33DEBA0
	|-FrameInterval<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public int get_Interval() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DEBB0 Offset: 0x33DECB1 VA: 0x33DEBB0
	|-FrameInterval<object>.get_Interval
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(FrameInterval<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DEBC0 Offset: 0x33DECC1 VA: 0x33DEBC0
	|-FrameInterval<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(FrameInterval<T> first, FrameInterval<T> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DECD0 Offset: 0x33DEDD1 VA: 0x33DECD0
	|-FrameInterval<object>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(FrameInterval<T> first, FrameInterval<T> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DED40 Offset: 0x33DEE41 VA: 0x33DED40
	|-FrameInterval<object>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DEDB0 Offset: 0x33DEEB1 VA: 0x33DEDB0
	|-FrameInterval<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DEEE0 Offset: 0x33DEFE1 VA: 0x33DEEE0
	|-FrameInterval<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DEF90 Offset: 0x33DF091 VA: 0x33DEF90
	|-FrameInterval<object>.ToString
	*/
}

