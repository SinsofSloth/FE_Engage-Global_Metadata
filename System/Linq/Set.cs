// Namespace: System.Linq
internal class Set<TElement> // TypeDefIndex: 2747
{
	// Fields
	private int[] buckets; // 0x0
	private Set.Slot<TElement>[] slots; // 0x0
	private int count; // 0x0
	private int freeList; // 0x0
	private IEqualityComparer<TElement> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TElement> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3431D00 Offset: 0x3431E01 VA: 0x3431D00
	|-Set<Int32Enum>..ctor
	|
	|-RVA: 0x34322E0 Offset: 0x34323E1 VA: 0x34322E0
	|-Set<object>..ctor
	|
	|-RVA: 0x34328E0 Offset: 0x34329E1 VA: 0x34328E0
	|-Set<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Add(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3431DF0 Offset: 0x3431EF1 VA: 0x3431DF0
	|-Set<Int32Enum>.Add
	|
	|-RVA: 0x34323D0 Offset: 0x34324D1 VA: 0x34323D0
	|-Set<object>.Add
	|
	|-RVA: 0x34329D0 Offset: 0x3432AD1 VA: 0x34329D0
	|-Set<Vector3>.Add
	*/

	// RVA: -1 Offset: -1
	private bool Find(TElement value, bool add) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3431E20 Offset: 0x3431F21 VA: 0x3431E20
	|-Set<Int32Enum>.Find
	|
	|-RVA: 0x3432400 Offset: 0x3432501 VA: 0x3432400
	|-Set<object>.Find
	|
	|-RVA: 0x3432A00 Offset: 0x3432B01 VA: 0x3432A00
	|-Set<Vector3>.Find
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34320B0 Offset: 0x34321B1 VA: 0x34320B0
	|-Set<Int32Enum>.Resize
	|
	|-RVA: 0x34326A0 Offset: 0x34327A1 VA: 0x34326A0
	|-Set<object>.Resize
	|
	|-RVA: 0x3432CC0 Offset: 0x3432DC1 VA: 0x3432CC0
	|-Set<Vector3>.Resize
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3432230 Offset: 0x3432331 VA: 0x3432230
	|-Set<Int32Enum>.InternalGetHashCode
	|
	|-RVA: 0x3432820 Offset: 0x3432921 VA: 0x3432820
	|-Set<object>.InternalGetHashCode
	|
	|-RVA: 0x3432E40 Offset: 0x3432F41 VA: 0x3432E40
	|-Set<Vector3>.InternalGetHashCode
	*/
}

