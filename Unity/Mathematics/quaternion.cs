// Namespace: Unity.Mathematics
[Serializable]
public struct quaternion : IEquatable<quaternion>, IFormattable // TypeDefIndex: 4777
{
	// Fields
	public float4 value; // 0x0
	public static readonly quaternion identity; // 0x0

	// Methods

	// RVA: 0x1C3CE10 Offset: 0x1C3CF11 VA: 0x1C3CE10
	public static Quaternion op_Implicit(quaternion q) { }

	// RVA: 0x1C3CE40 Offset: 0x1C3CF41 VA: 0x1C3CE40
	public static quaternion op_Implicit(Quaternion q) { }

	// RVA: 0x1C3CE50 Offset: 0x1C3CF51 VA: 0x1C3CE50
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x1C3CE70 Offset: 0x1C3CF71 VA: 0x1C3CE70
	public void .ctor(float4 value) { }

	// RVA: 0x1C3CE90 Offset: 0x1C3CF91 VA: 0x1C3CE90
	public void .ctor(float4x4 m) { }

	// RVA: 0x1C3D080 Offset: 0x1C3D181 VA: 0x1C3D080
	public static quaternion AxisAngle(float3 axis, float angle) { }

	// RVA: 0x1C3D190 Offset: 0x1C3D291 VA: 0x1C3D190 Slot: 4
	public bool Equals(quaternion x) { }

	// RVA: 0x1C3D1D0 Offset: 0x1C3D2D1 VA: 0x1C3D1D0 Slot: 0
	public override bool Equals(object x) { }

	// RVA: 0x1C3D2A0 Offset: 0x1C3D3A1 VA: 0x1C3D2A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C3D300 Offset: 0x1C3D401 VA: 0x1C3D300 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C3D4E0 Offset: 0x1C3D5E1 VA: 0x1C3D4E0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1C3D6B0 Offset: 0x1C3D7B1 VA: 0x1C3D6B0
	private static void .cctor() { }
}

