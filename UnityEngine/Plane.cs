// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x43C0E0 Offset: 0x43C1E1 VA: 0x43C0E0
public struct Plane : IFormattable // TypeDefIndex: 3428
{
	// Fields
	private Vector3 m_Normal; // 0x0
	private float m_Distance; // 0xC

	// Properties
	public Vector3 normal { get; }
	public float distance { get; }

	// Methods

	// RVA: 0x348F810 Offset: 0x348F911 VA: 0x348F810
	public Vector3 get_normal() { }

	// RVA: 0x348F820 Offset: 0x348F921 VA: 0x348F820
	public float get_distance() { }

	// RVA: 0x348F830 Offset: 0x348F931 VA: 0x348F830
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x348F8A0 Offset: 0x348F9A1 VA: 0x348F8A0
	public bool Raycast(Ray ray, out float enter) { }

	// RVA: 0x348F9E0 Offset: 0x348FAE1 VA: 0x348F9E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x348FA70 Offset: 0x348FB71 VA: 0x348FA70 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}

