// Namespace: UnityEngine
[NativeClassAttribute] // RVA: 0x5C850 Offset: 0x5C951 VA: 0x5C850
[NativeHeaderAttribute] // RVA: 0x5C850 Offset: 0x5C951 VA: 0x5C850
[RequiredByNativeCodeAttribute] // RVA: 0x5C850 Offset: 0x5C951 VA: 0x5C850
public struct RaycastHit2D // TypeDefIndex: 4051
{
	// Fields
	[NativeNameAttribute] // RVA: 0x5D130 Offset: 0x5D231 VA: 0x5D130
	private Vector2 m_Centroid; // 0x0
	[NativeNameAttribute] // RVA: 0x5D170 Offset: 0x5D271 VA: 0x5D170
	private Vector2 m_Point; // 0x8
	[NativeNameAttribute] // RVA: 0x5D1B0 Offset: 0x5D2B1 VA: 0x5D1B0
	private Vector2 m_Normal; // 0x10
	[NativeNameAttribute] // RVA: 0x5D1F0 Offset: 0x5D2F1 VA: 0x5D1F0
	private float m_Distance; // 0x18
	[NativeNameAttribute] // RVA: 0x5D230 Offset: 0x5D331 VA: 0x5D230
	private float m_Fraction; // 0x1C
	[NativeNameAttribute] // RVA: 0x5D270 Offset: 0x5D371 VA: 0x5D270
	private int m_Collider; // 0x20

	// Properties
	public Vector2 point { get; }
	public Vector2 normal { get; }
	public float distance { get; }
	public Collider2D collider { get; }

	// Methods

	// RVA: 0x1C5D5B0 Offset: 0x1C5D6B1 VA: 0x1C5D5B0
	public Vector2 get_point() { }

	// RVA: 0x1C5D5C0 Offset: 0x1C5D6C1 VA: 0x1C5D5C0
	public Vector2 get_normal() { }

	// RVA: 0x1C5D5D0 Offset: 0x1C5D6D1 VA: 0x1C5D5D0
	public float get_distance() { }

	// RVA: 0x1C5D5E0 Offset: 0x1C5D6E1 VA: 0x1C5D5E0
	public Collider2D get_collider() { }
}

// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x485760 Offset: 0x485861 VA: 0x485760
[NativeHeaderAttribute] // RVA: 0x485760 Offset: 0x485861 VA: 0x485760
[NativeHeaderAttribute] // RVA: 0x485760 Offset: 0x485861 VA: 0x485760
[UsedByNativeCodeAttribute] // RVA: 0x485760 Offset: 0x485861 VA: 0x485760
public struct RaycastHit // TypeDefIndex: 4198
{
	// Fields
	[NativeNameAttribute] // RVA: 0x485DE0 Offset: 0x485EE1 VA: 0x485DE0
	internal Vector3 m_Point; // 0x0
	[NativeNameAttribute] // RVA: 0x485E20 Offset: 0x485F21 VA: 0x485E20
	internal Vector3 m_Normal; // 0xC
	[NativeNameAttribute] // RVA: 0x485E60 Offset: 0x485F61 VA: 0x485E60
	internal uint m_FaceID; // 0x18
	[NativeNameAttribute] // RVA: 0x485EA0 Offset: 0x485FA1 VA: 0x485EA0
	internal float m_Distance; // 0x1C
	[NativeNameAttribute] // RVA: 0x485EE0 Offset: 0x485FE1 VA: 0x485EE0
	internal Vector2 m_UV; // 0x20
	[NativeNameAttribute] // RVA: 0x485F20 Offset: 0x486021 VA: 0x485F20
	internal int m_Collider; // 0x28

	// Properties
	public Collider collider { get; }
	public Vector3 point { get; set; }
	public Vector3 normal { get; set; }
	public float distance { get; set; }
	public int triangleIndex { get; }
	public Transform transform { get; }
	public Rigidbody rigidbody { get; }

	// Methods

	// RVA: 0x3EE9E70 Offset: 0x3EE9F71 VA: 0x3EE9E70
	public Collider get_collider() { }

	// RVA: 0x3EE9F50 Offset: 0x3EEA051 VA: 0x3EE9F50
	public Vector3 get_point() { }

	// RVA: 0x3EE9F60 Offset: 0x3EEA061 VA: 0x3EE9F60
	public void set_point(Vector3 value) { }

	// RVA: 0x3EE9F70 Offset: 0x3EEA071 VA: 0x3EE9F70
	public Vector3 get_normal() { }

	// RVA: 0x3EE9F80 Offset: 0x3EEA081 VA: 0x3EE9F80
	public void set_normal(Vector3 value) { }

	// RVA: 0x3EE9F90 Offset: 0x3EEA091 VA: 0x3EE9F90
	public float get_distance() { }

	// RVA: 0x3EE9FA0 Offset: 0x3EEA0A1 VA: 0x3EE9FA0
	public void set_distance(float value) { }

	// RVA: 0x3EE9FB0 Offset: 0x3EEA0B1 VA: 0x3EE9FB0
	public int get_triangleIndex() { }

	// RVA: 0x3EE9FC0 Offset: 0x3EEA0C1 VA: 0x3EE9FC0
	public Transform get_transform() { }

	// RVA: 0x3EEA1E0 Offset: 0x3EEA2E1 VA: 0x3EEA1E0
	public Rigidbody get_rigidbody() { }
}

