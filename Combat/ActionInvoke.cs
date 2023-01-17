// Namespace: Combat
internal sealed class ActionInvoke2<T> : State // TypeDefIndex: 8425
{
	// Fields
	private Action<T> m_Func; // 0x0
	private T m_Arg; // 0x0

	// Properties
	public override string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC34D0 Offset: 0x1FC35D1 VA: 0x1FC34D0
	|-ActionInvoke2<object>.get_Name
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T arg, Action<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC3520 Offset: 0x1FC3621 VA: 0x1FC3520
	|-ActionInvoke2<Character>..ctor
	|-ActionInvoke2<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void OnEnter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC3570 Offset: 0x1FC3671 VA: 0x1FC3570
	|-ActionInvoke2<object>.OnEnter
	*/
}

