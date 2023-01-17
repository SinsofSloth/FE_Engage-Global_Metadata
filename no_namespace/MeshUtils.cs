// Namespace: 
public class MeshUtils.Vertex : MeshUtils.Pooled<MeshUtils.Vertex> // TypeDefIndex: 5512
{
	// Fields
	internal MeshUtils.Vertex _prev; // 0x10
	internal MeshUtils.Vertex _next; // 0x18
	internal MeshUtils.Edge _anEdge; // 0x20
	internal Vec3 _coords; // 0x28
	internal float _s; // 0x34
	internal float _t; // 0x38
	internal PQHandle _pqHandle; // 0x3C
	internal int _n; // 0x40
	internal object _data; // 0x48

	// Methods

	// RVA: 0x2FA3C30 Offset: 0x2FA3D31 VA: 0x2FA3C30 Slot: 4
	public override void Reset() { }

	// RVA: 0x2FA3CF0 Offset: 0x2FA3DF1 VA: 0x2FA3CF0
	public void .ctor() { }
}

// Namespace: 
public struct MeshUtils.EdgePair // TypeDefIndex: 5514
{
	// Fields
	internal MeshUtils.Edge _e; // 0x0
	internal MeshUtils.Edge _eSym; // 0x8

	// Methods

	// RVA: 0x2FA3A80 Offset: 0x2FA3B81 VA: 0x2FA3A80
	public static MeshUtils.EdgePair Create() { }

	// RVA: 0x2FA39E0 Offset: 0x2FA3AE1 VA: 0x2FA39E0
	public void Reset() { }
}

