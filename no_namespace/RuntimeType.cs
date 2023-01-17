// Namespace: 
[DefaultMemberAttribute] // RVA: 0x4708E0 Offset: 0x4709E1 VA: 0x4708E0
private struct RuntimeType.ListBuilder<T> // TypeDefIndex: 296
{
	// Fields
	private T[] _items; // 0x0
	private T _item; // 0x0
	private int _count; // 0x0
	private int _capacity; // 0x0

	// Properties
	public T Item { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B00760 Offset: 0x3B00861 VA: 0x3B00760
	|-RuntimeType.ListBuilder<ConstructorInfo>..ctor
	|-RuntimeType.ListBuilder<EventInfo>..ctor
	|-RuntimeType.ListBuilder<FieldInfo>..ctor
	|-RuntimeType.ListBuilder<MethodInfo>..ctor
	|-RuntimeType.ListBuilder<object>..ctor
	|-RuntimeType.ListBuilder<PropertyInfo>..ctor
	|-RuntimeType.ListBuilder<Type>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B007A0 Offset: 0x3B008A1 VA: 0x3B007A0
	|-RuntimeType.ListBuilder<ConstructorInfo>.get_Item
	|-RuntimeType.ListBuilder<MethodInfo>.get_Item
	|-RuntimeType.ListBuilder<object>.get_Item
	|-RuntimeType.ListBuilder<PropertyInfo>.get_Item
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B007F0 Offset: 0x3B008F1 VA: 0x3B007F0
	|-RuntimeType.ListBuilder<ConstructorInfo>.ToArray
	|-RuntimeType.ListBuilder<EventInfo>.ToArray
	|-RuntimeType.ListBuilder<FieldInfo>.ToArray
	|-RuntimeType.ListBuilder<MethodInfo>.ToArray
	|-RuntimeType.ListBuilder<object>.ToArray
	|-RuntimeType.ListBuilder<PropertyInfo>.ToArray
	|-RuntimeType.ListBuilder<Type>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(object[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B00A00 Offset: 0x3B00B01 VA: 0x3B00A00
	|-RuntimeType.ListBuilder<ConstructorInfo>.CopyTo
	|-RuntimeType.ListBuilder<EventInfo>.CopyTo
	|-RuntimeType.ListBuilder<FieldInfo>.CopyTo
	|-RuntimeType.ListBuilder<MethodInfo>.CopyTo
	|-RuntimeType.ListBuilder<object>.CopyTo
	|-RuntimeType.ListBuilder<PropertyInfo>.CopyTo
	|-RuntimeType.ListBuilder<Type>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B00AC0 Offset: 0x3B00BC1 VA: 0x3B00AC0
	|-RuntimeType.ListBuilder<ConstructorInfo>.get_Count
	|-RuntimeType.ListBuilder<EventInfo>.get_Count
	|-RuntimeType.ListBuilder<FieldInfo>.get_Count
	|-RuntimeType.ListBuilder<MethodInfo>.get_Count
	|-RuntimeType.ListBuilder<object>.get_Count
	|-RuntimeType.ListBuilder<PropertyInfo>.get_Count
	|-RuntimeType.ListBuilder<Type>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B00AD0 Offset: 0x3B00BD1 VA: 0x3B00AD0
	|-RuntimeType.ListBuilder<ConstructorInfo>.Add
	|-RuntimeType.ListBuilder<EventInfo>.Add
	|-RuntimeType.ListBuilder<FieldInfo>.Add
	|-RuntimeType.ListBuilder<MethodInfo>.Add
	|-RuntimeType.ListBuilder<object>.Add
	|-RuntimeType.ListBuilder<PropertyInfo>.Add
	|-RuntimeType.ListBuilder<Type>.Add
	*/
}

