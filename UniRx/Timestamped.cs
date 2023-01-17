// Namespace: UniRx
[Serializable]
public struct Timestamped<T> : IEquatable<Timestamped<T>> // TypeDefIndex: 6662
{
	// Fields
	private readonly DateTimeOffset _timestamp; // 0x0
	private readonly T _value; // 0x0

	// Properties
	public T Value { get; }
	public DateTimeOffset Timestamp { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value, DateTimeOffset timestamp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356D900 Offset: 0x356DA01 VA: 0x356D900
	|-Timestamped<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356D910 Offset: 0x356DA11 VA: 0x356D910
	|-Timestamped<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public DateTimeOffset get_Timestamp() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356D920 Offset: 0x356DA21 VA: 0x356D920
	|-Timestamped<object>.get_Timestamp
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(Timestamped<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356D930 Offset: 0x356DA31 VA: 0x356D930
	|-Timestamped<object>.Equals
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(Timestamped<T> first, Timestamped<T> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356DA40 Offset: 0x356DB41 VA: 0x356DA40
	|-Timestamped<object>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(Timestamped<T> first, Timestamped<T> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356DAB0 Offset: 0x356DBB1 VA: 0x356DAB0
	|-Timestamped<object>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356DB30 Offset: 0x356DC31 VA: 0x356DB30
	|-Timestamped<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356DC80 Offset: 0x356DD81 VA: 0x356DC80
	|-Timestamped<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356DD10 Offset: 0x356DE11 VA: 0x356DD10
	|-Timestamped<object>.ToString
	*/
}

