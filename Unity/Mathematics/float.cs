// Namespace: Unity.Mathematics
[DefaultMemberAttribute] // RVA: 0x87490 Offset: 0x87591 VA: 0x87490
[DebuggerTypeProxyAttribute] // RVA: 0x87490 Offset: 0x87591 VA: 0x87490
[Serializable]
public struct float2 : IEquatable<float2>, IFormattable // TypeDefIndex: 4770
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x87870 Offset: 0x87971 VA: 0x87870
	public float4 xyxy { get; }

	// Methods

	// RVA: 0x1C37D60 Offset: 0x1C37E61 VA: 0x1C37D60
	public void .ctor(float x, float y) { }

	// RVA: 0x1C37D70 Offset: 0x1C37E71 VA: 0x1C37D70
	public static float2 op_Multiply(float2 lhs, float2 rhs) { }

	// RVA: 0x1C37D80 Offset: 0x1C37E81 VA: 0x1C37D80
	public static float2 op_Multiply(float2 lhs, float rhs) { }

	// RVA: 0x1C37D90 Offset: 0x1C37E91 VA: 0x1C37D90
	public static float2 op_Multiply(float lhs, float2 rhs) { }

	// RVA: 0x1C37DA0 Offset: 0x1C37EA1 VA: 0x1C37DA0
	public static float2 op_Addition(float2 lhs, float2 rhs) { }

	// RVA: 0x1C37DB0 Offset: 0x1C37EB1 VA: 0x1C37DB0
	public static float2 op_Addition(float2 lhs, float rhs) { }

	// RVA: 0x1C37DC0 Offset: 0x1C37EC1 VA: 0x1C37DC0
	public static float2 op_Subtraction(float2 lhs, float2 rhs) { }

	// RVA: 0x1C37DD0 Offset: 0x1C37ED1 VA: 0x1C37DD0
	public float4 get_xyxy() { }

	// RVA: 0x1C37DE0 Offset: 0x1C37EE1 VA: 0x1C37DE0 Slot: 4
	public bool Equals(float2 rhs) { }

	// RVA: 0x1C37E10 Offset: 0x1C37F11 VA: 0x1C37E10 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1C37EC0 Offset: 0x1C37FC1 VA: 0x1C37EC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C37EF0 Offset: 0x1C37FF1 VA: 0x1C37EF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C37FA0 Offset: 0x1C380A1 VA: 0x1C37FA0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1C38040 Offset: 0x1C38141 VA: 0x1C38040
	public static float2 op_Implicit(Vector2 v) { }
}

// Namespace: Unity.Mathematics
[DefaultMemberAttribute] // RVA: 0x87520 Offset: 0x87621 VA: 0x87520
[DebuggerTypeProxyAttribute] // RVA: 0x87520 Offset: 0x87621 VA: 0x87520
[Serializable]
public struct float3 : IEquatable<float3>, IFormattable // TypeDefIndex: 4772
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public static readonly float3 zero; // 0x0

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x87890 Offset: 0x87991 VA: 0x87890
	public float3 yzx { get; }
	[EditorBrowsableAttribute] // RVA: 0x878B0 Offset: 0x879B1 VA: 0x878B0
	public float2 yz { get; }
	public float Item { get; set; }

	// Methods

	// RVA: 0x1C38050 Offset: 0x1C38151 VA: 0x1C38050
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x1C38060 Offset: 0x1C38161 VA: 0x1C38060
	public void .ctor(float x, float2 yz) { }

	// RVA: 0x1C38070 Offset: 0x1C38171 VA: 0x1C38070
	public void .ctor(float v) { }

	// RVA: 0x1C38080 Offset: 0x1C38181 VA: 0x1C38080
	public static float3 op_Implicit(float v) { }

	// RVA: 0x1C38090 Offset: 0x1C38191 VA: 0x1C38090
	public static float3 op_Multiply(float3 lhs, float3 rhs) { }

	// RVA: 0x1C380A0 Offset: 0x1C381A1 VA: 0x1C380A0
	public static float3 op_Multiply(float3 lhs, float rhs) { }

	// RVA: 0x1C380B0 Offset: 0x1C381B1 VA: 0x1C380B0
	public static float3 op_Multiply(float lhs, float3 rhs) { }

	// RVA: 0x1C380D0 Offset: 0x1C381D1 VA: 0x1C380D0
	public static float3 op_Addition(float3 lhs, float3 rhs) { }

	// RVA: 0x1C380E0 Offset: 0x1C381E1 VA: 0x1C380E0
	public static float3 op_Addition(float3 lhs, float rhs) { }

	// RVA: 0x1C380F0 Offset: 0x1C381F1 VA: 0x1C380F0
	public static float3 op_Addition(float lhs, float3 rhs) { }

	// RVA: 0x1C38110 Offset: 0x1C38211 VA: 0x1C38110
	public static float3 op_Subtraction(float3 lhs, float3 rhs) { }

	// RVA: 0x1C38120 Offset: 0x1C38221 VA: 0x1C38120
	public static float3 op_Subtraction(float3 lhs, float rhs) { }

	// RVA: 0x1C38130 Offset: 0x1C38231 VA: 0x1C38130
	public static float3 op_Subtraction(float lhs, float3 rhs) { }

	// RVA: 0x1C38150 Offset: 0x1C38251 VA: 0x1C38150
	public static float3 op_Division(float3 lhs, float rhs) { }

	// RVA: 0x1C38160 Offset: 0x1C38261 VA: 0x1C38160
	public static float3 op_UnaryNegation(float3 val) { }

	// RVA: 0x1C38170 Offset: 0x1C38271 VA: 0x1C38170
	public float3 get_yzx() { }

	// RVA: 0x1C38180 Offset: 0x1C38281 VA: 0x1C38180
	public float2 get_yz() { }

	// RVA: 0x1C38190 Offset: 0x1C38291 VA: 0x1C38190
	public float get_Item(int index) { }

	// RVA: 0x1C381A0 Offset: 0x1C382A1 VA: 0x1C381A0
	public void set_Item(int index, float value) { }

	// RVA: 0x1C381B0 Offset: 0x1C382B1 VA: 0x1C381B0 Slot: 4
	public bool Equals(float3 rhs) { }

	// RVA: 0x1C381E0 Offset: 0x1C382E1 VA: 0x1C381E0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1C382A0 Offset: 0x1C383A1 VA: 0x1C382A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C382F0 Offset: 0x1C383F1 VA: 0x1C382F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C383C0 Offset: 0x1C384C1 VA: 0x1C383C0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1C38480 Offset: 0x1C38581 VA: 0x1C38480
	public static Vector3 op_Implicit(float3 v) { }

	// RVA: 0x1C38490 Offset: 0x1C38591 VA: 0x1C38490
	public static float3 op_Implicit(Vector3 v) { }
}

// Namespace: Unity.Mathematics
[DefaultMemberAttribute] // RVA: 0x87680 Offset: 0x87781 VA: 0x87680
[Serializable]
public struct float4x4 : IEquatable<float4x4>, IFormattable // TypeDefIndex: 4776
{
	// Fields
	public float4 c0; // 0x0
	public float4 c1; // 0x10
	public float4 c2; // 0x20
	public float4 c3; // 0x30
	public static readonly float4x4 identity; // 0x0
	public static readonly float4x4 zero; // 0x40

	// Methods

	// RVA: 0x1C39700 Offset: 0x1C39801 VA: 0x1C39700
	public void .ctor(float4 c0, float4 c1, float4 c2, float4 c3) { }

	// RVA: 0x1C39750 Offset: 0x1C39851 VA: 0x1C39750
	public void .ctor(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33) { }

	// RVA: 0x1C397C0 Offset: 0x1C398C1 VA: 0x1C397C0 Slot: 4
	public bool Equals(float4x4 rhs) { }

	// RVA: 0x1C398D0 Offset: 0x1C399D1 VA: 0x1C398D0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1C39A60 Offset: 0x1C39B61 VA: 0x1C39A60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C39BD0 Offset: 0x1C39CD1 VA: 0x1C39BD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C3A140 Offset: 0x1C3A241 VA: 0x1C3A140 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1C3A6A0 Offset: 0x1C3A7A1 VA: 0x1C3A6A0
	public static float4x4 op_Implicit(Matrix4x4 m) { }

	// RVA: 0x1C3A7A0 Offset: 0x1C3A8A1 VA: 0x1C3A7A0
	public void .ctor(quaternion rotation, float3 translation) { }

	// RVA: 0x1C3A8A0 Offset: 0x1C3A9A1 VA: 0x1C3A8A0
	public static float4x4 Translate(float3 vector) { }

	// RVA: 0x1C3A8D0 Offset: 0x1C3A9D1 VA: 0x1C3A8D0
	private static void .cctor() { }
}

