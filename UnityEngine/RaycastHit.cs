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

