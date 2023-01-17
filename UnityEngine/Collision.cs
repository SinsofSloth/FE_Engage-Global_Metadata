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

