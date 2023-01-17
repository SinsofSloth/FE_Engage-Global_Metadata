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

