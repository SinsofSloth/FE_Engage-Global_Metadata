// Namespace: UnityEngine.Rendering
[UsedByNativeCodeAttribute] // RVA: 0x4410B0 Offset: 0x4411B1 VA: 0x4410B0
public struct VisibleReflectionProbe : IEquatable<VisibleReflectionProbe> // TypeDefIndex: 3972
{
	// Fields
	private Bounds m_Bounds; // 0x0
	private Matrix4x4 m_LocalToWorldMatrix; // 0x18
	private Vector4 m_HdrData; // 0x58
	private Vector3 m_Center; // 0x68
	private float m_BlendDistance; // 0x74
	private int m_Importance; // 0x78
	private int m_BoxProjection; // 0x7C
	private int m_InstanceId; // 0x80
	private int m_TextureId; // 0x84

	// Methods

	// RVA: 0x3851E10 Offset: 0x3851F11 VA: 0x3851E10 Slot: 4
	public bool Equals(VisibleReflectionProbe other) { }

	// RVA: 0x3851F80 Offset: 0x3852081 VA: 0x3851F80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3852020 Offset: 0x3852121 VA: 0x3852020 Slot: 2
	public override int GetHashCode() { }
}

