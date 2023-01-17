// Namespace: System.Runtime.Remoting
internal class ClientIdentity : Identity // TypeDefIndex: 1096
{
	// Fields
	private WeakReference _proxyReference; // 0x48

	// Properties
	public MarshalByRefObject ClientProxy { get; set; }
	public string TargetUri { get; }

	// Methods

	// RVA: 0x33A65C0 Offset: 0x33A66C1 VA: 0x33A65C0
	public void .ctor(string objectUri, ObjRef objRef) { }

	// RVA: 0x33A66E0 Offset: 0x33A67E1 VA: 0x33A66E0
	public MarshalByRefObject get_ClientProxy() { }

	// RVA: 0x33A6770 Offset: 0x33A6871 VA: 0x33A6770
	public void set_ClientProxy(MarshalByRefObject value) { }

	// RVA: 0x33A67F0 Offset: 0x33A68F1 VA: 0x33A67F0 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x33A6800 Offset: 0x33A6901 VA: 0x33A6800
	public string get_TargetUri() { }
}

