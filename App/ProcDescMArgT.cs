// Namespace: App
public class ProcDescMArgT<T> : ProcDescCallBase // TypeDefIndex: 13889
{
	// Fields
	private Action<T> m_Method; // 0x0
	private T m_Arg; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<T> method, T arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85470 Offset: 0x2A85571 VA: 0x2A85470
	|-ProcDescMArgT<bool>..ctor
	|
	|-RVA: 0x2A854E0 Offset: 0x2A855E1 VA: 0x2A854E0
	|-ProcDescMArgT<int>..ctor
	|
	|-RVA: 0x2A85550 Offset: 0x2A85651 VA: 0x2A85550
	|-ProcDescMArgT<Int32Enum>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected override void ExecuteImpl(ProcInst inst) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A854C0 Offset: 0x2A855C1 VA: 0x2A854C0
	|-ProcDescMArgT<bool>.ExecuteImpl
	|
	|-RVA: 0x2A85530 Offset: 0x2A85631 VA: 0x2A85530
	|-ProcDescMArgT<int>.ExecuteImpl
	|
	|-RVA: 0x2A855A0 Offset: 0x2A856A1 VA: 0x2A855A0
	|-ProcDescMArgT<Int32Enum>.ExecuteImpl
	*/
}

