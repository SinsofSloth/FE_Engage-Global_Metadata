// Namespace: TMPro
public class FastAction<A> // TypeDefIndex: 7328
{
	// Fields
	private LinkedList<Action<A>> delegates; // 0x0
	private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CFFD0 Offset: 0x33D00D1 VA: 0x33CFFD0
	|-FastAction<bool>.Add
	|
	|-RVA: 0x33D0260 Offset: 0x33D0361 VA: 0x33D0260
	|-FastAction<object>.Add
	|-FastAction<Object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D0060 Offset: 0x33D0161 VA: 0x33D0060
	|-FastAction<bool>.Remove
	|
	|-RVA: 0x33D02F0 Offset: 0x33D03F1 VA: 0x33D02F0
	|-FastAction<object>.Remove
	|-FastAction<Object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D00F0 Offset: 0x33D01F1 VA: 0x33D00F0
	|-FastAction<bool>.Call
	|
	|-RVA: 0x33D0380 Offset: 0x33D0481 VA: 0x33D0380
	|-FastAction<object>.Call
	|-FastAction<Object>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D0190 Offset: 0x33D0291 VA: 0x33D0190
	|-FastAction<bool>..ctor
	|
	|-RVA: 0x33D0420 Offset: 0x33D0521 VA: 0x33D0420
	|-FastAction<object>..ctor
	|-FastAction<Object>..ctor
	*/
}

// Namespace: TMPro
public class FastAction<A, B, C> // TypeDefIndex: 7330
{
	// Fields
	private LinkedList<Action<A, B, C>> delegates; // 0x0
	private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D0A20 Offset: 0x33D0B21 VA: 0x33D0A20
	|-FastAction<object, object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D0AB0 Offset: 0x33D0BB1 VA: 0x33D0AB0
	|-FastAction<object, object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b, C c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D0B40 Offset: 0x33D0C41 VA: 0x33D0B40
	|-FastAction<GameObject, Material, Material>.Call
	|-FastAction<object, object, object>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D0BF0 Offset: 0x33D0CF1 VA: 0x33D0BF0
	|-FastAction<GameObject, Material, Material>..ctor
	|-FastAction<object, object, object>..ctor
	*/
}

