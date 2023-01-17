// Namespace: TMPro
public class FastAction // TypeDefIndex: 7327
{
	// Fields
	private LinkedList<Action> delegates; // 0x10
	private Dictionary<Action, LinkedListNode<Action>> lookup; // 0x18

	// Methods

	// RVA: 0x192D3F0 Offset: 0x192D4F1 VA: 0x192D3F0
	public void Add(Action rhs) { }

	// RVA: 0x192D4B0 Offset: 0x192D5B1 VA: 0x192D4B0
	public void Remove(Action rhs) { }

	// RVA: 0x192D570 Offset: 0x192D671 VA: 0x192D570
	public void Call() { }

	// RVA: 0x192D600 Offset: 0x192D701 VA: 0x192D600
	public void .ctor() { }
}

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
public class FastAction<A, B> // TypeDefIndex: 7329
{
	// Fields
	private LinkedList<Action<A, B>> delegates; // 0x0
	private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D04F0 Offset: 0x33D05F1 VA: 0x33D04F0
	|-FastAction<bool, object>.Add
	|
	|-RVA: 0x33D0790 Offset: 0x33D0891 VA: 0x33D0790
	|-FastAction<object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D0580 Offset: 0x33D0681 VA: 0x33D0580
	|-FastAction<bool, object>.Remove
	|
	|-RVA: 0x33D0820 Offset: 0x33D0921 VA: 0x33D0820
	|-FastAction<object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D0610 Offset: 0x33D0711 VA: 0x33D0610
	|-FastAction<bool, Material>.Call
	|-FastAction<bool, object>.Call
	|-FastAction<bool, Object>.Call
	|
	|-RVA: 0x33D08B0 Offset: 0x33D09B1 VA: 0x33D08B0
	|-FastAction<object, Compute_DT_EventArgs>.Call
	|-FastAction<object, object>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D06C0 Offset: 0x33D07C1 VA: 0x33D06C0
	|-FastAction<bool, Material>..ctor
	|-FastAction<bool, object>..ctor
	|-FastAction<bool, Object>..ctor
	|
	|-RVA: 0x33D0950 Offset: 0x33D0A51 VA: 0x33D0950
	|-FastAction<object, Compute_DT_EventArgs>..ctor
	|-FastAction<object, object>..ctor
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

