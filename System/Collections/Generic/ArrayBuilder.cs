// Namespace: System.Collections.Generic
[DefaultMemberAttribute] // RVA: 0x406E0 Offset: 0x407E1 VA: 0x406E0
internal struct ArrayBuilder<T> // TypeDefIndex: 3282
{
	// Fields
	private T[] _array; // 0x0
	private int _count; // 0x0

	// Properties
	public int Capacity { get; }
	public int Count { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8770 Offset: 0x1FF8871 VA: 0x1FF8770
	|-ArrayBuilder<Expression>..ctor
	|-ArrayBuilder<object>..ctor
	|-ArrayBuilder<ParameterExpression>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8800 Offset: 0x1FF8901 VA: 0x1FF8800
	|-ArrayBuilder<object>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8820 Offset: 0x1FF8921 VA: 0x1FF8820
	|-ArrayBuilder<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8830 Offset: 0x1FF8931 VA: 0x1FF8830
	|-ArrayBuilder<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8870 Offset: 0x1FF8971 VA: 0x1FF8870
	|-ArrayBuilder<object>.Add
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8940 Offset: 0x1FF8A41 VA: 0x1FF8940
	|-ArrayBuilder<object>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void UncheckedAdd(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8A40 Offset: 0x1FF8B41 VA: 0x1FF8A40
	|-ArrayBuilder<Expression>.UncheckedAdd
	|-ArrayBuilder<object>.UncheckedAdd
	|-ArrayBuilder<ParameterExpression>.UncheckedAdd
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int minimum) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8A80 Offset: 0x1FF8B81 VA: 0x1FF8A80
	|-ArrayBuilder<object>.EnsureCapacity
	*/
}

