// Namespace: App
public class ProcDescArgT<T> : ProcDescCallBase // TypeDefIndex: 13888
{
	// Fields
	private Action<ProcInst, T> m_Function; // 0x0
	private T m_Arg; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<ProcInst, T> function, T arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85380 Offset: 0x2A85481 VA: 0x2A85380
	|-ProcDescArgT<Int32Enum>..ctor
	|
	|-RVA: 0x2A85400 Offset: 0x2A85501 VA: 0x2A85400
	|-ProcDescArgT<float>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected override void ExecuteImpl(ProcInst inst) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A853D0 Offset: 0x2A854D1 VA: 0x2A853D0
	|-ProcDescArgT<Int32Enum>.ExecuteImpl
	|
	|-RVA: 0x2A85450 Offset: 0x2A85551 VA: 0x2A85450
	|-ProcDescArgT<float>.ExecuteImpl
	*/
}

