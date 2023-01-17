// Namespace: System
[ComVisibleAttribute] // RVA: 0x471070 Offset: 0x471171 VA: 0x471070
[Serializable]
public abstract class MarshalByRefObject // TypeDefIndex: 373
{
	// Fields
	private object _identity; // 0x10

	// Properties
	internal ServerIdentity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x34E6090 Offset: 0x34E6191 VA: 0x34E6090
	protected void .ctor() { }

	// RVA: 0x34E60A0 Offset: 0x34E61A1 VA: 0x34E60A0
	internal ServerIdentity get_ObjectIdentity() { }

	// RVA: 0x34E60E0 Offset: 0x34E61E1 VA: 0x34E60E0
	internal void set_ObjectIdentity(ServerIdentity value) { }

	// RVA: 0x34E6120 Offset: 0x34E6221 VA: 0x34E6120 Slot: 4
	public virtual ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x34E6160 Offset: 0x34E6261 VA: 0x34E6160 Slot: 5
	public virtual object InitializeLifetimeService() { }
}

