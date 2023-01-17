// Namespace: UnityEngine.Experimental.Rendering.Universal.LibTessDotNet
internal class PriorityQueue<TValue> // TypeDefIndex: 5522
{
	// Fields
	private PriorityHeap.LessOrEqual<TValue> _leq; // 0x0
	private PriorityHeap<TValue> _heap; // 0x0
	private TValue[] _keys; // 0x0
	private int[] _order; // 0x0
	private int _size; // 0x0
	private int _max; // 0x0
	private bool _initialized; // 0x0

	// Properties
	public bool Empty { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A844B0 Offset: 0x2A845B1 VA: 0x2A844B0
	|-PriorityQueue<object>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int initialSize, PriorityHeap.LessOrEqual<TValue> leq) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A844E0 Offset: 0x2A845E1 VA: 0x2A844E0
	|-PriorityQueue<object>..ctor
	|-PriorityQueue<MeshUtils.Vertex>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void Swap(ref int a, ref int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A845D0 Offset: 0x2A846D1 VA: 0x2A845D0
	|-PriorityQueue<object>.Swap
	*/

	// RVA: -1 Offset: -1
	public void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A845F0 Offset: 0x2A846F1 VA: 0x2A845F0
	|-PriorityQueue<object>.Init
	|-PriorityQueue<MeshUtils.Vertex>.Init
	*/

	// RVA: -1 Offset: -1
	public PQHandle Insert(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A84BF0 Offset: 0x2A84CF1 VA: 0x2A84BF0
	|-PriorityQueue<object>.Insert
	|-PriorityQueue<MeshUtils.Vertex>.Insert
	*/

	// RVA: -1 Offset: -1
	public TValue ExtractMin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A84CB0 Offset: 0x2A84DB1 VA: 0x2A84CB0
	|-PriorityQueue<object>.ExtractMin
	|-PriorityQueue<MeshUtils.Vertex>.ExtractMin
	*/

	// RVA: -1 Offset: -1
	public TValue Minimum() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A84DF0 Offset: 0x2A84EF1 VA: 0x2A84DF0
	|-PriorityQueue<object>.Minimum
	|-PriorityQueue<MeshUtils.Vertex>.Minimum
	*/

	// RVA: -1 Offset: -1
	public void Remove(PQHandle handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A84EF0 Offset: 0x2A84FF1 VA: 0x2A84EF0
	|-PriorityQueue<object>.Remove
	|-PriorityQueue<MeshUtils.Vertex>.Remove
	*/
}

