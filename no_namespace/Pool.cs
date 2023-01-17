// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275270 Offset: 0x275371 VA: 0x275270
[Serializable]
private sealed class Pool.List.<>c<T> // TypeDefIndex: 9204
{
	// Fields
	public static readonly Pool.List.<>c<T> <>9; // 0x0
	public static Comparison<T> <>9__10_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33D00 Offset: 0x2B33E01 VA: 0x2B33D00
	|-Pool.List.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33DE0 Offset: 0x2B33EE1 VA: 0x2B33DE0
	|-Pool.List.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int <Sort>b__10_0(T a, T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33DF0 Offset: 0x2B33EF1 VA: 0x2B33DF0
	|-Pool.List.<>c<object>.<Sort>b__10_0
	*/
}

// Namespace: 
public class Pool.Stack<T> // TypeDefIndex: 9206
{
	// Fields
	private Stack<T> m_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB470 Offset: 0x36BB571 VA: 0x36BB470
	|-Pool.Stack<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB540 Offset: 0x36BB641 VA: 0x36BB540
	|-Pool.Stack<object>.Pop
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual void Push(T p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB590 Offset: 0x36BB691 VA: 0x36BB590
	|-Pool.Stack<object>.Push
	*/
}

// Namespace: 
public class Pool.Hierarchy<T> // TypeDefIndex: 9208
{
	// Fields
	private Stack<T> m_Pool; // 0x0
	private Stack<T> m_Used; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAEAD0 Offset: 0x1EAEBD1 VA: 0x1EAEAD0
	|-Pool.Hierarchy<BattleDetail>..ctor
	|-Pool.Hierarchy<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual T Push() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAEC00 Offset: 0x1EAED01 VA: 0x1EAEC00
	|-Pool.Hierarchy<object>.Push
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAEC80 Offset: 0x1EAED81 VA: 0x1EAEC80
	|-Pool.Hierarchy<object>.Pop
	*/
}

