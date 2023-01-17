// Namespace: Combat
[DebuggerDisplayAttribute] // RVA: 0x2748F0 Offset: 0x2749F1 VA: 0x2748F0
public struct FXZ // TypeDefIndex: 8815
{
	// Fields
	public float x; // 0x0
	public float z; // 0x4
	public static readonly FXZ Zero; // 0x0

	// Properties
	public bool isZero { get; }
	public bool isNotZero { get; }
	public bool isNaN { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static FXZ insideUnitCircle { get; }
	public FXZ normalized { get; }

	// Methods

	// RVA: 0x2A14FB0 Offset: 0x2A150B1 VA: 0x2A14FB0
	public void .ctor(float x, float z) { }

	// RVA: 0x2A14FC0 Offset: 0x2A150C1 VA: 0x2A14FC0
	public void .ctor(FXZ rhs) { }

	// RVA: 0x2A14FD0 Offset: 0x2A150D1 VA: 0x2A14FD0
	public void .ctor(Vector2 v) { }

	// RVA: 0x2A14FE0 Offset: 0x2A150E1 VA: 0x2A14FE0
	public void .ctor(in Vector3 v) { }

	// RVA: 0x2A15000 Offset: 0x2A15101 VA: 0x2A15000
	public static bool op_Equality(FXZ A, FXZ B) { }

	// RVA: 0x2A15030 Offset: 0x2A15131 VA: 0x2A15030
	public static bool op_Inequality(FXZ A, FXZ B) { }

	// RVA: 0x2A150D0 Offset: 0x2A151D1 VA: 0x2A150D0
	public static FXZ op_Addition(FXZ A, FXZ B) { }

	// RVA: 0x2A150E0 Offset: 0x2A151E1 VA: 0x2A150E0
	public static FXZ op_UnaryNegation(FXZ A) { }

	// RVA: 0x2A150F0 Offset: 0x2A151F1 VA: 0x2A150F0
	public static FXZ op_Subtraction(FXZ A, FXZ B) { }

	// RVA: 0x2A15100 Offset: 0x2A15201 VA: 0x2A15100
	public static FXZ op_Multiply(FXZ A, float scale) { }

	// RVA: 0x2A15110 Offset: 0x2A15211 VA: 0x2A15110
	public static FXZ op_Multiply(float scale, FXZ A) { }

	// RVA: 0x2A15120 Offset: 0x2A15221 VA: 0x2A15120
	public static FXZ op_Division(FXZ A, float scale) { }

	// RVA: 0x2A15140 Offset: 0x2A15241 VA: 0x2A15140
	public static Vector3 op_Addition(in Vector3 xyz, FXZ xz) { }

	// RVA: 0x2A15160 Offset: 0x2A15261 VA: 0x2A15160
	public static Vector3 op_Subtraction(in Vector3 xyz, FXZ xz) { }

	// RVA: 0x2A15180 Offset: 0x2A15281 VA: 0x2A15180
	public static Vector3 op_Implicit(FXZ v) { }

	// RVA: 0x2A15190 Offset: 0x2A15291 VA: 0x2A15190
	public static Vector2 op_Implicit(FXZ v) { }

	// RVA: 0x2A151A0 Offset: 0x2A152A1 VA: 0x2A151A0
	public static FXZ op_Implicit(in Vector3 v) { }

	// RVA: 0x2A151B0 Offset: 0x2A152B1 VA: 0x2A151B0
	public static FXZ op_Implicit(Vector2 v) { }

	// RVA: 0x2A151C0 Offset: 0x2A152C1 VA: 0x2A151C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2A152B0 Offset: 0x2A153B1 VA: 0x2A152B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2A152F0 Offset: 0x2A153F1 VA: 0x2A152F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2A153A0 Offset: 0x2A154A1 VA: 0x2A153A0
	public bool get_isZero() { }

	// RVA: 0x2A15430 Offset: 0x2A15531 VA: 0x2A15430
	public bool get_isNotZero() { }

	// RVA: 0x2A154C0 Offset: 0x2A155C1 VA: 0x2A154C0
	public bool get_isNaN() { }

	// RVA: 0x2A15530 Offset: 0x2A15631 VA: 0x2A15530
	public float get_magnitude() { }

	// RVA: 0x2A15560 Offset: 0x2A15661 VA: 0x2A15560
	public float get_sqrMagnitude() { }

	// RVA: 0x2A15580 Offset: 0x2A15681 VA: 0x2A15580
	public static float Distance(FXZ A, FXZ B) { }

	// RVA: 0x2A15630 Offset: 0x2A15731 VA: 0x2A15630
	public static float SqrDistance(FXZ A, FXZ B) { }

	// RVA: 0x2A156C0 Offset: 0x2A157C1 VA: 0x2A156C0
	public static FXZ AtoB(FXZ A, FXZ B) { }

	// RVA: 0x2A15830 Offset: 0x2A15931 VA: 0x2A15830
	public static FXZ ToRight(FXZ A) { }

	// RVA: 0x2A15840 Offset: 0x2A15941 VA: 0x2A15840
	public static FXZ get_insideUnitCircle() { }

	// RVA: 0x2A158C0 Offset: 0x2A159C1 VA: 0x2A158C0
	public static float Dot(FXZ A, FXZ B) { }

	// RVA: 0x2A158D0 Offset: 0x2A159D1 VA: 0x2A158D0
	public static float Cross(FXZ A, FXZ B) { }

	// RVA: 0x2A158E0 Offset: 0x2A159E1 VA: 0x2A158E0
	public static FXZ Rotate(FXZ A, float rad) { }

	// RVA: 0x2A15940 Offset: 0x2A15A41 VA: 0x2A15940
	public static float PerpendicularDot(FXZ A, FXZ B) { }

	// RVA: 0x2A159D0 Offset: 0x2A15AD1 VA: 0x2A159D0
	public static float RadAB(FXZ A, FXZ B) { }

	// RVA: 0x2A15C10 Offset: 0x2A15D11 VA: 0x2A15C10
	public static float Angle360(FXZ A, FXZ B) { }

	// RVA: 0x2A15D00 Offset: 0x2A15E01 VA: 0x2A15D00
	public static FXZ Slerp(FXZ A, FXZ B, float t) { }

	// RVA: 0x2A15E80 Offset: 0x2A15F81 VA: 0x2A15E80
	public static FXZ Lerp(FXZ A, FXZ B, float t) { }

	// RVA: 0x2A15B80 Offset: 0x2A15C81 VA: 0x2A15B80
	public void Normalize() { }

	// RVA: 0x2A157A0 Offset: 0x2A158A1 VA: 0x2A157A0
	public FXZ get_normalized() { }

	// RVA: 0x2A15EA0 Offset: 0x2A15FA1 VA: 0x2A15EA0
	private static void .cctor() { }
}

