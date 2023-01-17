// Namespace: Combat
[DebuggerDisplayAttribute] // RVA: 0x274980 Offset: 0x274A81 VA: 0x274980
public struct TR // TypeDefIndex: 8818
{
	// Fields
	public Vector3 position; // 0x0
	public Quaternion rotation; // 0xC

	// Properties
	public static TR identity { get; }
	public Vector3 forward { get; set; }

	// Methods

	// RVA: 0x2932340 Offset: 0x2932441 VA: 0x2932340
	public static TR get_identity() { }

	// RVA: 0x29323E0 Offset: 0x29324E1 VA: 0x29323E0
	public Vector3 get_forward() { }

	// RVA: 0x2932430 Offset: 0x2932531 VA: 0x2932430
	public void set_forward(Vector3 value) { }

	// RVA: 0x29323B0 Offset: 0x29324B1 VA: 0x29323B0
	public void .ctor(in Vector3 pos, in Quaternion rot) { }

	// RVA: 0x2932470 Offset: 0x2932571 VA: 0x2932470
	public void .ctor(in Vector3 pos, in Vector3 forward) { }

	// RVA: 0x29324C0 Offset: 0x29325C1 VA: 0x29324C0
	public void .ctor(Transform t) { }

	// RVA: 0x2932520 Offset: 0x2932621 VA: 0x2932520
	public void .ctor(TR rhs) { }

	// RVA: 0x2932550 Offset: 0x2932651 VA: 0x2932550
	public static void Lerp(in TR A, in TR B, float t, out TR C) { }

	// RVA: 0x29325E0 Offset: 0x29326E1 VA: 0x29325E0
	public Vector3 TransformPoint(Vector3 in_pos) { }

	// RVA: 0x2932690 Offset: 0x2932791 VA: 0x2932690
	public static void LerpAndMakeMatrix(TR A, TR B, float scale, float t, out Matrix4x4 mtx) { }
}

