// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x5C7B0 Offset: 0x5C8B1 VA: 0x5C7B0
public class Collision2D // TypeDefIndex: 4049
{
	// Fields
	internal int m_Collider; // 0x10
	internal int m_OtherCollider; // 0x14
	internal int m_Rigidbody; // 0x18
	internal int m_OtherRigidbody; // 0x1C
	internal Vector2 m_RelativeVelocity; // 0x20
	internal int m_Enabled; // 0x28
	internal int m_ContactCount; // 0x2C
	internal ContactPoint2D[] m_ReusedContacts; // 0x30
	internal ContactPoint2D[] m_LegacyContacts; // 0x38

	// Properties
	public Collider2D collider { get; }
	public Rigidbody2D rigidbody { get; }
	public GameObject gameObject { get; }
	public Vector2 relativeVelocity { get; }

	// Methods

	// RVA: 0x1C5AD40 Offset: 0x1C5AE41 VA: 0x1C5AD40
	public Collider2D get_collider() { }

	// RVA: 0x1C5AE20 Offset: 0x1C5AF21 VA: 0x1C5AE20
	public Rigidbody2D get_rigidbody() { }

	// RVA: 0x1C5AED0 Offset: 0x1C5AFD1 VA: 0x1C5AED0
	public GameObject get_gameObject() { }

	// RVA: 0x1C5B0D0 Offset: 0x1C5B1D1 VA: 0x1C5B0D0
	public Vector2 get_relativeVelocity() { }
}

// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x485710 Offset: 0x485811 VA: 0x485710
public class Collision // TypeDefIndex: 4192
{
	// Fields
	internal Vector3 m_Impulse; // 0x10
	internal Vector3 m_RelativeVelocity; // 0x1C
	internal Component m_Body; // 0x28
	internal Collider m_Collider; // 0x30
	internal int m_ContactCount; // 0x38
	internal ContactPoint[] m_ReusedContacts; // 0x40
	internal ContactPoint[] m_LegacyContacts; // 0x48

	// Properties
	public Vector3 relativeVelocity { get; }
	public Collider collider { get; }
	public GameObject gameObject { get; }

	// Methods

	// RVA: 0x3EE1960 Offset: 0x3EE1A61 VA: 0x3EE1960
	public Vector3 get_relativeVelocity() { }

	// RVA: 0x3EE1970 Offset: 0x3EE1A71 VA: 0x3EE1970
	public Collider get_collider() { }

	// RVA: 0x3EE1980 Offset: 0x3EE1A81 VA: 0x3EE1980
	public GameObject get_gameObject() { }
}

