// Namespace: UnityEngine.Timeline
internal class IntervalTree<T> // TypeDefIndex: 5659
{
	// Fields
	private readonly List<IntervalTree.Entry<T>> m_Entries; // 0x0
	private readonly List<IntervalTreeNode> m_Nodes; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x57BF0 Offset: 0x57CF1 VA: 0x57BF0
	private bool <dirty>k__BackingField; // 0x0

	// Properties
	public bool dirty { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x581C0 Offset: 0x582C1 VA: 0x581C0
	// RVA: -1 Offset: -1
	public bool get_dirty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D88170 Offset: 0x2D88271 VA: 0x2D88170
	|-IntervalTree<object>.get_dirty
	*/

	[CompilerGeneratedAttribute] // RVA: 0x581D0 Offset: 0x582D1 VA: 0x581D0
	// RVA: -1 Offset: -1
	internal void set_dirty(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D88180 Offset: 0x2D88281 VA: 0x2D88180
	|-IntervalTree<object>.set_dirty
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D88190 Offset: 0x2D88291 VA: 0x2D88190
	|-IntervalTree<object>.Add
	|-IntervalTree<RuntimeElement>.Add
	*/

	// RVA: -1 Offset: -1
	public void IntersectsWith(long value, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D88330 Offset: 0x2D88431 VA: 0x2D88330
	|-IntervalTree<object>.IntersectsWith
	|-IntervalTree<RuntimeElement>.IntersectsWith
	*/

	// RVA: -1 Offset: -1
	private void Query(IntervalTreeNode intervalTreeNode, long value, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D88460 Offset: 0x2D88561 VA: 0x2D88460
	|-IntervalTree<object>.Query
	*/

	// RVA: -1 Offset: -1
	private void Rebuild() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D88650 Offset: 0x2D88751 VA: 0x2D88650
	|-IntervalTree<object>.Rebuild
	*/

	// RVA: -1 Offset: -1
	private int Rebuild(int start, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D88730 Offset: 0x2D88831 VA: 0x2D88730
	|-IntervalTree<object>.Rebuild
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D88C40 Offset: 0x2D88D41 VA: 0x2D88C40
	|-IntervalTree<object>..ctor
	|-IntervalTree<RuntimeElement>..ctor
	*/
}

