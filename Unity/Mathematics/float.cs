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
[DefaultMemberAttribute] // RVA: 0x875B0 Offset: 0x876B1 VA: 0x875B0
[Serializable]
public struct float3x3 : IEquatable<float3x3>, IFormattable // TypeDefIndex: 4773
{
	// Fields
	public float3 c0; // 0x0
	public float3 c1; // 0xC
	public float3 c2; // 0x18
	public static readonly float3x3 identity; // 0x0

	// Methods

	// RVA: 0x1C384A0 Offset: 0x1C385A1 VA: 0x1C384A0
	public void .ctor(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22) { }

	// RVA: 0x1C384D0 Offset: 0x1C385D1 VA: 0x1C384D0 Slot: 4
	public bool Equals(float3x3 rhs) { }

	// RVA: 0x1C38570 Offset: 0x1C38671 VA: 0x1C38570 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1C38690 Offset: 0x1C38791 VA: 0x1C38690 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C38750 Offset: 0x1C38851 VA: 0x1C38750 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C38AB0 Offset: 0x1C38BB1 VA: 0x1C38AB0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1C38E00 Offset: 0x1C38F01 VA: 0x1C38E00
	public void .ctor(quaternion q) { }

	// RVA: 0x1C38EE0 Offset: 0x1C38FE1 VA: 0x1C38EE0
	private static void .cctor() { }
}

// Namespace: Unity.Mathematics
[DefaultMemberAttribute] // RVA: 0x875F0 Offset: 0x876F1 VA: 0x875F0
[DebuggerTypeProxyAttribute] // RVA: 0x875F0 Offset: 0x876F1 VA: 0x875F0
[Serializable]
public struct float4 : IEquatable<float4>, IFormattable // TypeDefIndex: 4775
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	public static readonly float4 zero; // 0x0

	// Properties
	[EditorBrowsableAttribute] // RVA: 0x878D0 Offset: 0x879D1 VA: 0x878D0
	public float4 xxzz { get; }
	[EditorBrowsableAttribute] // RVA: 0x878F0 Offset: 0x879F1 VA: 0x878F0
	public float4 xyzx { get; }
	[EditorBrowsableAttribute] // RVA: 0x87910 Offset: 0x87A11 VA: 0x87910
	public float4 yzxy { get; }
	[EditorBrowsableAttribute] // RVA: 0x87930 Offset: 0x87A31 VA: 0x87930
	public float4 yzxz { get; }
	[EditorBrowsableAttribute] // RVA: 0x87950 Offset: 0x87A51 VA: 0x87950
	public float4 zxyy { get; }
	[EditorBrowsableAttribute] // RVA: 0x87970 Offset: 0x87A71 VA: 0x87970
	public float4 zxyz { get; }
	[EditorBrowsableAttribute] // RVA: 0x87990 Offset: 0x87A91 VA: 0x87990
	public float4 zwxy { get; }
	[EditorBrowsableAttribute] // RVA: 0x879B0 Offset: 0x87AB1 VA: 0x879B0
	public float4 wzyx { get; }
	[EditorBrowsableAttribute] // RVA: 0x879D0 Offset: 0x87AD1 VA: 0x879D0
	public float4 wwwx { get; }
	[EditorBrowsableAttribute] // RVA: 0x879F0 Offset: 0x87AF1 VA: 0x879F0
	public float4 wwww { get; }
	[EditorBrowsableAttribute] // RVA: 0x87A10 Offset: 0x87B11 VA: 0x87A10
	public float3 xyz { get; }
	[EditorBrowsableAttribute] // RVA: 0x87A30 Offset: 0x87B31 VA: 0x87A30
	public float3 yxw { get; }
	[EditorBrowsableAttribute] // RVA: 0x87A50 Offset: 0x87B51 VA: 0x87A50
	public float3 zwx { get; }
	[EditorBrowsableAttribute] // RVA: 0x87A70 Offset: 0x87B71 VA: 0x87A70
	public float3 wzy { get; }
	[EditorBrowsableAttribute] // RVA: 0x87A90 Offset: 0x87B91 VA: 0x87A90
	public float3 www { get; }
	[EditorBrowsableAttribute] // RVA: 0x87AB0 Offset: 0x87BB1 VA: 0x87AB0
	public float2 xx { get; }
	[EditorBrowsableAttribute] // RVA: 0x87AD0 Offset: 0x87BD1 VA: 0x87AD0
	public float2 xy { get; set; }
	[EditorBrowsableAttribute] // RVA: 0x87AF0 Offset: 0x87BF1 VA: 0x87AF0
	public float2 xz { get; }
	[EditorBrowsableAttribute] // RVA: 0x87B10 Offset: 0x87C11 VA: 0x87B10
	public float2 yy { get; }
	[EditorBrowsableAttribute] // RVA: 0x87B30 Offset: 0x87C31 VA: 0x87B30
	public float2 yw { get; }
	[EditorBrowsableAttribute] // RVA: 0x87B50 Offset: 0x87C51 VA: 0x87B50
	public float2 zw { get; }

	// Methods

	// RVA: 0x1C38F40 Offset: 0x1C39041 VA: 0x1C38F40
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x1C38F60 Offset: 0x1C39061 VA: 0x1C38F60
	public void .ctor(float3 xyz, float w) { }

	// RVA: 0x1C38F80 Offset: 0x1C39081 VA: 0x1C38F80
	public static float4 op_Multiply(float4 lhs, float4 rhs) { }

	// RVA: 0x1C38FA0 Offset: 0x1C390A1 VA: 0x1C38FA0
	public static float4 op_Multiply(float4 lhs, float rhs) { }

	// RVA: 0x1C38FC0 Offset: 0x1C390C1 VA: 0x1C38FC0
	public static float4 op_Multiply(float lhs, float4 rhs) { }

	// RVA: 0x1C38FE0 Offset: 0x1C390E1 VA: 0x1C38FE0
	public static float4 op_Addition(float4 lhs, float4 rhs) { }

	// RVA: 0x1C39000 Offset: 0x1C39101 VA: 0x1C39000
	public static float4 op_Subtraction(float4 lhs, float4 rhs) { }

	// RVA: 0x1C39020 Offset: 0x1C39121 VA: 0x1C39020
	public static float4 op_UnaryNegation(float4 val) { }

	// RVA: 0x1C39040 Offset: 0x1C39141 VA: 0x1C39040
	public float4 get_xxzz() { }

	// RVA: 0x1C39060 Offset: 0x1C39161 VA: 0x1C39060
	public float4 get_xyzx() { }

	// RVA: 0x1C39070 Offset: 0x1C39171 VA: 0x1C39070
	public float4 get_yzxy() { }

	// RVA: 0x1C39080 Offset: 0x1C39181 VA: 0x1C39080
	public float4 get_yzxz() { }

	// RVA: 0x1C39090 Offset: 0x1C39191 VA: 0x1C39090
	public float4 get_zxyy() { }

	// RVA: 0x1C390A0 Offset: 0x1C391A1 VA: 0x1C390A0
	public float4 get_zxyz() { }

	// RVA: 0x1C390B0 Offset: 0x1C391B1 VA: 0x1C390B0
	public float4 get_zwxy() { }

	// RVA: 0x1C390C0 Offset: 0x1C391C1 VA: 0x1C390C0
	public float4 get_wzyx() { }

	// RVA: 0x1C390D0 Offset: 0x1C391D1 VA: 0x1C390D0
	public float4 get_wwwx() { }

	// RVA: 0x1C390F0 Offset: 0x1C391F1 VA: 0x1C390F0
	public float4 get_wwww() { }

	// RVA: 0x1C39110 Offset: 0x1C39211 VA: 0x1C39110
	public float3 get_xyz() { }

	// RVA: 0x1C39120 Offset: 0x1C39221 VA: 0x1C39120
	public float3 get_yxw() { }

	// RVA: 0x1C39130 Offset: 0x1C39231 VA: 0x1C39130
	public float3 get_zwx() { }

	// RVA: 0x1C39140 Offset: 0x1C39241 VA: 0x1C39140
	public float3 get_wzy() { }

	// RVA: 0x1C39150 Offset: 0x1C39251 VA: 0x1C39150
	public float3 get_www() { }

	// RVA: 0x1C39160 Offset: 0x1C39261 VA: 0x1C39160
	public float2 get_xx() { }

	// RVA: 0x1C39170 Offset: 0x1C39271 VA: 0x1C39170
	public float2 get_xy() { }

	// RVA: 0x1C39180 Offset: 0x1C39281 VA: 0x1C39180
	public void set_xy(float2 value) { }

	// RVA: 0x1C39190 Offset: 0x1C39291 VA: 0x1C39190
	public float2 get_xz() { }

	// RVA: 0x1C391A0 Offset: 0x1C392A1 VA: 0x1C391A0
	public float2 get_yy() { }

	// RVA: 0x1C391B0 Offset: 0x1C392B1 VA: 0x1C391B0
	public float2 get_yw() { }

	// RVA: 0x1C391C0 Offset: 0x1C392C1 VA: 0x1C391C0
	public float2 get_zw() { }

	// RVA: 0x1C391D0 Offset: 0x1C392D1 VA: 0x1C391D0 Slot: 4
	public bool Equals(float4 rhs) { }

	// RVA: 0x1C39210 Offset: 0x1C39311 VA: 0x1C39210 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1C392E0 Offset: 0x1C393E1 VA: 0x1C392E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C39340 Offset: 0x1C39441 VA: 0x1C39340 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C39520 Offset: 0x1C39621 VA: 0x1C39520 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1C396F0 Offset: 0x1C397F1 VA: 0x1C396F0
	public static float4 op_Implicit(Vector4 v) { }
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

