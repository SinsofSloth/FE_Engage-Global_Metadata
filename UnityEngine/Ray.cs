// Namespace: UnityEngine
public struct Ray : IFormattable // TypeDefIndex: 3429
{
	// Fields
	private Vector3 m_Origin; // 0x0
	private Vector3 m_Direction; // 0xC

	// Properties
	public Vector3 origin { get; set; }
	public Vector3 direction { get; set; }

	// Methods

	// RVA: 0x31D2060 Offset: 0x31D2161 VA: 0x31D2060
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x31D20B0 Offset: 0x31D21B1 VA: 0x31D20B0
	public Vector3 get_origin() { }

	// RVA: 0x31D20C0 Offset: 0x31D21C1 VA: 0x31D20C0
	public void set_origin(Vector3 value) { }

	// RVA: 0x31D20D0 Offset: 0x31D21D1 VA: 0x31D20D0
	public Vector3 get_direction() { }

	// RVA: 0x31D20E0 Offset: 0x31D21E1 VA: 0x31D20E0
	public void set_direction(Vector3 value) { }

	// RVA: 0x31D2130 Offset: 0x31D2231 VA: 0x31D2130
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x31D2160 Offset: 0x31D2261 VA: 0x31D2160 Slot: 3
	public override string ToString() { }

	// RVA: 0x31D21F0 Offset: 0x31D22F1 VA: 0x31D21F0 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}

