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

