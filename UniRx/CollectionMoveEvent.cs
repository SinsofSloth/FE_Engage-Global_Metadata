// Namespace: UniRx
public struct CollectionMoveEvent<T> : IEquatable<CollectionMoveEvent<T>> // TypeDefIndex: 6738
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x13C80 Offset: 0x13D81 VA: 0x13C80
	private int <OldIndex>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x13C90 Offset: 0x13D91 VA: 0x13C90
	private int <NewIndex>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x13CA0 Offset: 0x13DA1 VA: 0x13CA0
	private T <Value>k__BackingField; // 0x0

	// Properties
	public int OldIndex { get; set; }
	public int NewIndex { get; set; }
	public T Value { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x17000 Offset: 0x17101 VA: 0x17000
	[IsReadOnlyAttribute] // RVA: 0x17000 Offset: 0x17101 VA: 0x17000
	// RVA: -1 Offset: -1
	public int get_OldIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D9590 Offset: 0x30D9691 VA: 0x30D9590
	|-CollectionMoveEvent<object>.get_OldIndex
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17040 Offset: 0x17141 VA: 0x17040
	// RVA: -1 Offset: -1
	private void set_OldIndex(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D95A0 Offset: 0x30D96A1 VA: 0x30D95A0
	|-CollectionMoveEvent<object>.set_OldIndex
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17050 Offset: 0x17151 VA: 0x17050
	[IsReadOnlyAttribute] // RVA: 0x17050 Offset: 0x17151 VA: 0x17050
	// RVA: -1 Offset: -1
	public int get_NewIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D95B0 Offset: 0x30D96B1 VA: 0x30D95B0
	|-CollectionMoveEvent<object>.get_NewIndex
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17090 Offset: 0x17191 VA: 0x17090
	// RVA: -1 Offset: -1
	private void set_NewIndex(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D95C0 Offset: 0x30D96C1 VA: 0x30D95C0
	|-CollectionMoveEvent<object>.set_NewIndex
	*/

	[CompilerGeneratedAttribute] // RVA: 0x170A0 Offset: 0x171A1 VA: 0x170A0
	[IsReadOnlyAttribute] // RVA: 0x170A0 Offset: 0x171A1 VA: 0x170A0
	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D95D0 Offset: 0x30D96D1 VA: 0x30D95D0
	|-CollectionMoveEvent<object>.get_Value
	*/

	[CompilerGeneratedAttribute] // RVA: 0x170E0 Offset: 0x171E1 VA: 0x170E0
	// RVA: -1 Offset: -1
	private void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D95E0 Offset: 0x30D96E1 VA: 0x30D95E0
	|-CollectionMoveEvent<object>.set_Value
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int oldIndex, int newIndex, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D95F0 Offset: 0x30D96F1 VA: 0x30D95F0
	|-CollectionMoveEvent<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D96A0 Offset: 0x30D97A1 VA: 0x30D96A0
	|-CollectionMoveEvent<object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D9790 Offset: 0x30D9891 VA: 0x30D9790
	|-CollectionMoveEvent<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(CollectionMoveEvent<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D9890 Offset: 0x30D9991 VA: 0x30D9890
	|-CollectionMoveEvent<object>.Equals
	*/
}

