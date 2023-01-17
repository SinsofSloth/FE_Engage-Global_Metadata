// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x43DAF0 Offset: 0x43DBF1 VA: 0x43DAF0
[Il2CppEagerStaticClassConstructionAttribute] // RVA: 0x43DAF0 Offset: 0x43DBF1 VA: 0x43DAF0
[NativeHeaderAttribute] // RVA: 0x43DAF0 Offset: 0x43DBF1 VA: 0x43DAF0
[DefaultMemberAttribute] // RVA: 0x43DAF0 Offset: 0x43DBF1 VA: 0x43DAF0
[NativeTypeAttribute] // RVA: 0x43DAF0 Offset: 0x43DBF1 VA: 0x43DAF0
public struct Quaternion : IEquatable<Quaternion>, IFormattable // TypeDefIndex: 3543
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Quaternion identityQuaternion; // 0x0
	public const float kEpsilon = 1E-06;

	// Properties
	public static Quaternion identity { get; }
	public Vector3 eulerAngles { get; }
	public Quaternion normalized { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x44E450 Offset: 0x44E551 VA: 0x44E450
	// RVA: 0x3497B20 Offset: 0x3497C21 VA: 0x3497B20
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[FreeFunctionAttribute] // RVA: 0x44E4A0 Offset: 0x44E5A1 VA: 0x44E4A0
	// RVA: 0x3497BF0 Offset: 0x3497CF1 VA: 0x3497BF0
	public static Quaternion Inverse(Quaternion rotation) { }

	[FreeFunctionAttribute] // RVA: 0x44E4E0 Offset: 0x44E5E1 VA: 0x44E4E0
	// RVA: 0x3497CA0 Offset: 0x3497DA1 VA: 0x3497CA0
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0x44E530 Offset: 0x44E631 VA: 0x44E530
	// RVA: 0x3497D90 Offset: 0x3497E91 VA: 0x3497D90
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0x44E580 Offset: 0x44E681 VA: 0x44E580
	// RVA: 0x3497E80 Offset: 0x3497F81 VA: 0x3497E80
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0x44E5D0 Offset: 0x44E6D1 VA: 0x44E5D0
	// RVA: 0x3497F70 Offset: 0x3498071 VA: 0x3497F70
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	[FreeFunctionAttribute] // RVA: 0x44E620 Offset: 0x44E721 VA: 0x44E620
	// RVA: 0x3498020 Offset: 0x3498121 VA: 0x3498020
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	[FreeFunctionAttribute] // RVA: 0x44E670 Offset: 0x44E771 VA: 0x44E670
	// RVA: 0x34980E0 Offset: 0x34981E1 VA: 0x34980E0
	private static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle) { }

	[FreeFunctionAttribute] // RVA: 0x44E6C0 Offset: 0x44E7C1 VA: 0x44E6C0
	// RVA: 0x34981B0 Offset: 0x34982B1 VA: 0x34981B0
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[FreeFunctionAttribute] // RVA: 0x44E710 Offset: 0x44E811 VA: 0x44E710
	// RVA: 0x3498280 Offset: 0x3498381 VA: 0x3498280
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44E760 Offset: 0x44E861 VA: 0x44E760
	// RVA: 0x3498350 Offset: 0x3498451 VA: 0x3498350
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0x34983E0 Offset: 0x34984E1 VA: 0x34983E0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x3498400 Offset: 0x3498501 VA: 0x3498400
	public static Quaternion get_identity() { }

	// RVA: 0x3498450 Offset: 0x3498551 VA: 0x3498450
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x34984D0 Offset: 0x34985D1 VA: 0x34984D0
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x3498580 Offset: 0x3498681 VA: 0x3498580
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x34985A0 Offset: 0x34986A1 VA: 0x34985A0
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x3498600 Offset: 0x3498701 VA: 0x3498600
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x34985E0 Offset: 0x34986E1 VA: 0x34985E0
	public static float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x3498640 Offset: 0x3498741 VA: 0x3498640
	public static float Angle(Quaternion a, Quaternion b) { }

	// RVA: 0x34986B0 Offset: 0x34987B1 VA: 0x34986B0
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x3498770 Offset: 0x3498871 VA: 0x3498770
	public Vector3 get_eulerAngles() { }

	// RVA: 0x34988B0 Offset: 0x34989B1 VA: 0x34988B0
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x3498930 Offset: 0x3498A31 VA: 0x3498930
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x34989B0 Offset: 0x3498AB1 VA: 0x34989B0
	public void ToAngleAxis(out float angle, out Vector3 axis) { }

	// RVA: 0x3498A40 Offset: 0x3498B41 VA: 0x3498A40
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	// RVA: 0x3498B70 Offset: 0x3498C71 VA: 0x3498B70
	public static Quaternion Normalize(Quaternion q) { }

	// RVA: 0x3498C70 Offset: 0x3498D71 VA: 0x3498C70
	public Quaternion get_normalized() { }

	// RVA: 0x3498D70 Offset: 0x3498E71 VA: 0x3498D70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3498DE0 Offset: 0x3498EE1 VA: 0x3498DE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x3498ED0 Offset: 0x3498FD1 VA: 0x3498ED0 Slot: 4
	public bool Equals(Quaternion other) { }

	// RVA: 0x3498F60 Offset: 0x3499061 VA: 0x3498F60 Slot: 3
	public override string ToString() { }

	// RVA: 0x3498FF0 Offset: 0x34990F1 VA: 0x3498FF0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x34991F0 Offset: 0x34992F1 VA: 0x34991F0
	private static void .cctor() { }

	// RVA: 0x3497B90 Offset: 0x3497C91 VA: 0x3497B90
	private static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) { }

	// RVA: 0x3497C50 Offset: 0x3497D51 VA: 0x3497C50
	private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	// RVA: 0x3497D20 Offset: 0x3497E21 VA: 0x3497D20
	private static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x3497E10 Offset: 0x3497F11 VA: 0x3497E10
	private static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x3497F00 Offset: 0x3498001 VA: 0x3497F00
	private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x3497FD0 Offset: 0x34980D1 VA: 0x3497FD0
	private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	// RVA: 0x3498090 Offset: 0x3498191 VA: 0x3498090
	private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) { }

	// RVA: 0x3498150 Offset: 0x3498251 VA: 0x3498150
	private static void Internal_ToAxisAngleRad_Injected(ref Quaternion q, out Vector3 axis, out float angle) { }

	// RVA: 0x3498220 Offset: 0x3498321 VA: 0x3498220
	private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) { }

	// RVA: 0x34982F0 Offset: 0x34983F1 VA: 0x34982F0
	private static void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret) { }
}

