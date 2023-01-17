// Namespace: UnityEngine
[RequireComponent] // RVA: 0x5CB00 Offset: 0x5CC01 VA: 0x5CB00
[NativeHeaderAttribute] // RVA: 0x5CB00 Offset: 0x5CC01 VA: 0x5CB00
public class Joint2D : Behaviour // TypeDefIndex: 4056
{}

// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x485AD0 Offset: 0x485BD1 VA: 0x485AD0
[RequireComponent] // RVA: 0x485AD0 Offset: 0x485BD1 VA: 0x485AD0
[NativeClassAttribute] // RVA: 0x485AD0 Offset: 0x485BD1 VA: 0x485AD0
public class Joint : Component // TypeDefIndex: 4206
{
	// Properties
	public Rigidbody connectedBody { get; }
	public Vector3 connectedAnchor { set; }

	// Methods

	// RVA: 0x3EE3BE0 Offset: 0x3EE3CE1 VA: 0x3EE3BE0
	public Rigidbody get_connectedBody() { }

	// RVA: 0x3EE3C30 Offset: 0x3EE3D31 VA: 0x3EE3C30
	public void set_connectedAnchor(Vector3 value) { }

	// RVA: 0x3EE3BC0 Offset: 0x3EE3CC1 VA: 0x3EE3BC0
	public void .ctor() { }

	// RVA: 0x3EE3C90 Offset: 0x3EE3D91 VA: 0x3EE3C90
	private void set_connectedAnchor_Injected(ref Vector3 value) { }
}

