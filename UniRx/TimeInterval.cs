// Namespace: UniRx
[Serializable]
public struct TimeInterval<T> : IEquatable<TimeInterval<T>> // TypeDefIndex: 6661
{
	// Fields
	private readonly TimeSpan _interval; // 0x0
	private readonly T _value; // 0x0

	// Properties
	public T Value { get; }
	public TimeSpan Interval { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value, TimeSpan interval) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399D350 Offset: 0x399D451 VA: 0x399D350
	|-TimeInterval<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399D360 Offset: 0x399D461 VA: 0x399D360
	|-TimeInterval<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public TimeSpan get_Interval() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399D370 Offset: 0x399D471 VA: 0x399D370
	|-TimeInterval<object>.get_Interval
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(TimeInterval<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399D380 Offset: 0x399D481 VA: 0x399D380
	|-TimeInterval<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(TimeInterval<T> first, TimeInterval<T> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399D490 Offset: 0x399D591 VA: 0x399D490
	|-TimeInterval<object>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(TimeInterval<T> first, TimeInterval<T> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399D500 Offset: 0x399D601 VA: 0x399D500
	|-TimeInterval<object>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399D570 Offset: 0x399D671 VA: 0x399D570
	|-TimeInterval<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399D6A0 Offset: 0x399D7A1 VA: 0x399D6A0
	|-TimeInterval<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399D750 Offset: 0x399D851 VA: 0x399D750
	|-TimeInterval<object>.ToString
	*/
}

