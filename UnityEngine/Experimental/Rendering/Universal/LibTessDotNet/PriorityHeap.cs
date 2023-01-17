// Namespace: UnityEngine.Experimental.Rendering.Universal.LibTessDotNet
internal class PriorityHeap<TValue> // TypeDefIndex: 5520
{
	// Fields
	private PriorityHeap.LessOrEqual<TValue> _leq; // 0x0
	private int[] _nodes; // 0x0
	private PriorityHeap.HandleElem<TValue>[] _handles; // 0x0
	private int _size; // 0x0
	private int _max; // 0x0
	private int _freeList; // 0x0
	private bool _initialized; // 0x0

	// Properties
	public bool Empty { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A83160 Offset: 0x2A83261 VA: 0x2A83160
	|-PriorityHeap<object>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int initialSize, PriorityHeap.LessOrEqual<TValue> leq) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A83170 Offset: 0x2A83271 VA: 0x2A83170
	|-PriorityHeap<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void FloatDown(int curr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A83300 Offset: 0x2A83401 VA: 0x2A83300
	|-PriorityHeap<object>.FloatDown
	*/

	// RVA: -1 Offset: -1
	private void FloatUp(int curr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A834E0 Offset: 0x2A835E1 VA: 0x2A834E0
	|-PriorityHeap<object>.FloatUp
	*/

	// RVA: -1 Offset: -1
	public void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A83630 Offset: 0x2A83731 VA: 0x2A83630
	|-PriorityHeap<object>.Init
	*/

	// RVA: -1 Offset: -1
	public PQHandle Insert(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A83690 Offset: 0x2A83791 VA: 0x2A83690
	|-PriorityHeap<object>.Insert
	*/

	// RVA: -1 Offset: -1
	public TValue ExtractMin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A838A0 Offset: 0x2A839A1 VA: 0x2A838A0
	|-PriorityHeap<object>.ExtractMin
	*/

	// RVA: -1 Offset: -1
	public TValue Minimum() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A839C0 Offset: 0x2A83AC1 VA: 0x2A839C0
	|-PriorityHeap<object>.Minimum
	*/

	// RVA: -1 Offset: -1
	public void Remove(PQHandle handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A83A10 Offset: 0x2A83B11 VA: 0x2A83A10
	|-PriorityHeap<object>.Remove
	*/
}

