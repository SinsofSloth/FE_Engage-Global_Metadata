// Namespace: UnityEngine.ResourceManagement.Util
public class LinkedListNodeCache<T> // TypeDefIndex: 5568
{
	// Fields
	private int m_NodesCreated; // 0x0
	private LinkedList<T> m_NodeCache; // 0x0

	// Properties
	internal int CreatedNodeCount { get; }
	internal int CachedNodeCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public LinkedListNode<T> Acquire(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD6760 Offset: 0x2AD6861 VA: 0x2AD6760
	|-LinkedListNodeCache<object>.Acquire
	*/

	// RVA: -1 Offset: -1
	public void Release(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD6830 Offset: 0x2AD6931 VA: 0x2AD6830
	|-LinkedListNodeCache<object>.Release
	*/

	// RVA: -1 Offset: -1
	internal int get_CreatedNodeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD68F0 Offset: 0x2AD69F1 VA: 0x2AD68F0
	|-LinkedListNodeCache<object>.get_CreatedNodeCount
	*/

	// RVA: -1 Offset: -1
	internal int get_CachedNodeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD6900 Offset: 0x2AD6A01 VA: 0x2AD6900
	|-LinkedListNodeCache<object>.get_CachedNodeCount
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD6920 Offset: 0x2AD6A21 VA: 0x2AD6920
	|-LinkedListNodeCache<object>..ctor
	*/
}

