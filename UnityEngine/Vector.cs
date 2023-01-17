// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43D9E0 Offset: 0x43DAE1 VA: 0x43D9E0
[NativeClassAttribute] // RVA: 0x43D9E0 Offset: 0x43DAE1 VA: 0x43D9E0
[RequiredByNativeCodeAttribute] // RVA: 0x43D9E0 Offset: 0x43DAE1 VA: 0x43D9E0
[DefaultMemberAttribute] // RVA: 0x43D9E0 Offset: 0x43DAE1 VA: 0x43D9E0
[NativeHeaderAttribute] // RVA: 0x43D9E0 Offset: 0x43DAE1 VA: 0x43D9E0
[Il2CppEagerStaticClassConstructionAttribute] // RVA: 0x43D9E0 Offset: 0x43DAE1 VA: 0x43D9E0
[NativeTypeAttribute] // RVA: 0x43D9E0 Offset: 0x43DAE1 VA: 0x43D9E0
public struct Vector3 : IEquatable<Vector3>, IFormattable // TypeDefIndex: 3542
{
	// Fields
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	private static readonly Vector3 zeroVector; // 0x0
	private static readonly Vector3 oneVector; // 0xC
	private static readonly Vector3 upVector; // 0x18
	private static readonly Vector3 downVector; // 0x24
	private static readonly Vector3 leftVector; // 0x30
	private static readonly Vector3 rightVector; // 0x3C
	private static readonly Vector3 forwardVector; // 0x48
	private static readonly Vector3 backVector; // 0x54
	private static readonly Vector3 positiveInfinityVector; // 0x60
	private static readonly Vector3 negativeInfinityVector; // 0x6C

	// Properties
	public float Item { get; set; }
	public Vector3 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector3 zero { get; }
	public static Vector3 one { get; }
	public static Vector3 forward { get; }
	public static Vector3 back { get; }
	public static Vector3 up { get; }
	public static Vector3 down { get; }
	public static Vector3 left { get; }
	public static Vector3 right { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x44E360 Offset: 0x44E461 VA: 0x44E360
	// RVA: 0x384EAB0 Offset: 0x384EBB1 VA: 0x384EAB0
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[FreeFunctionAttribute] // RVA: 0x44E3B0 Offset: 0x44E4B1 VA: 0x44E3B0
	// RVA: 0x384EBA0 Offset: 0x384ECA1 VA: 0x384EBA0
	private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) { }

	// RVA: 0x384EBF0 Offset: 0x384ECF1 VA: 0x384EBF0
	public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) { }

	[FreeFunctionAttribute] // RVA: 0x44E400 Offset: 0x44E501 VA: 0x44E400
	// RVA: 0x384EC40 Offset: 0x384ED41 VA: 0x384EC40
	public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

	// RVA: 0x384ED40 Offset: 0x384EE41 VA: 0x384ED40
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x384EDC0 Offset: 0x384EEC1 VA: 0x384EDC0
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x384EDF0 Offset: 0x384EEF1 VA: 0x384EDF0
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44E440 Offset: 0x44E541 VA: 0x44E440
	// RVA: 0x384EF50 Offset: 0x384F051 VA: 0x384EF50
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime) { }

	// RVA: 0x384F000 Offset: 0x384F101 VA: 0x384F000
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x384F280 Offset: 0x384F381 VA: 0x384F280
	public float get_Item(int index) { }

	// RVA: 0x384F320 Offset: 0x384F421 VA: 0x384F320
	public void set_Item(int index, float value) { }

	// RVA: 0x384F3C0 Offset: 0x384F4C1 VA: 0x384F3C0
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x384F3D0 Offset: 0x384F4D1 VA: 0x384F3D0
	public void .ctor(float x, float y) { }

	// RVA: 0x384F3E0 Offset: 0x384F4E1 VA: 0x384F3E0
	public void Set(float newX, float newY, float newZ) { }

	// RVA: 0x384F3F0 Offset: 0x384F4F1 VA: 0x384F3F0
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x384F400 Offset: 0x384F501 VA: 0x384F400
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x384F430 Offset: 0x384F531 VA: 0x384F430 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x384F490 Offset: 0x384F591 VA: 0x384F490 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x384F540 Offset: 0x384F641 VA: 0x384F540 Slot: 4
	public bool Equals(Vector3 other) { }

	// RVA: 0x384F570 Offset: 0x384F671 VA: 0x384F570
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	// RVA: 0x384F5B0 Offset: 0x384F6B1 VA: 0x384F5B0
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x384F710 Offset: 0x384F811 VA: 0x384F710
	public void Normalize() { }

	// RVA: 0x384F830 Offset: 0x384F931 VA: 0x384F830
	public Vector3 get_normalized() { }

	// RVA: 0x384F840 Offset: 0x384F941 VA: 0x384F840
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x384F860 Offset: 0x384F961 VA: 0x384F860
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0x384F960 Offset: 0x384FA61 VA: 0x384F960
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	// RVA: 0x384FA40 Offset: 0x384FB41 VA: 0x384FA40
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x384FBB0 Offset: 0x384FCB1 VA: 0x384FBB0
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	// RVA: 0x384FC70 Offset: 0x384FD71 VA: 0x384FC70
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x384FD40 Offset: 0x384FE41 VA: 0x384FD40
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	// RVA: 0x384FE20 Offset: 0x384FF21 VA: 0x384FE20
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x384FED0 Offset: 0x384FFD1 VA: 0x384FED0
	public float get_magnitude() { }

	// RVA: 0x384FF90 Offset: 0x3850091 VA: 0x384FF90
	public static float SqrMagnitude(Vector3 vector) { }

	// RVA: 0x384FB90 Offset: 0x384FC91 VA: 0x384FB90
	public float get_sqrMagnitude() { }

	// RVA: 0x384FFB0 Offset: 0x38500B1 VA: 0x384FFB0
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x3850030 Offset: 0x3850131 VA: 0x3850030
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x384F6C0 Offset: 0x384F7C1 VA: 0x384F6C0
	public static Vector3 get_zero() { }

	// RVA: 0x38500B0 Offset: 0x38501B1 VA: 0x38500B0
	public static Vector3 get_one() { }

	// RVA: 0x3847B80 Offset: 0x3847C81 VA: 0x3847B80
	public static Vector3 get_forward() { }

	// RVA: 0x3850100 Offset: 0x3850201 VA: 0x3850100
	public static Vector3 get_back() { }

	// RVA: 0x38479A0 Offset: 0x3847AA1 VA: 0x38479A0
	public static Vector3 get_up() { }

	// RVA: 0x3850150 Offset: 0x3850251 VA: 0x3850150
	public static Vector3 get_down() { }

	// RVA: 0x38501A0 Offset: 0x38502A1 VA: 0x38501A0
	public static Vector3 get_left() { }

	// RVA: 0x38477C0 Offset: 0x38478C1 VA: 0x38477C0
	public static Vector3 get_right() { }

	// RVA: 0x38501F0 Offset: 0x38502F1 VA: 0x38501F0
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x3850200 Offset: 0x3850301 VA: 0x3850200
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x3850210 Offset: 0x3850311 VA: 0x3850210
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x3850220 Offset: 0x3850321 VA: 0x3850220
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x3850230 Offset: 0x3850331 VA: 0x3850230
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x3850250 Offset: 0x3850351 VA: 0x3850250
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x3850260 Offset: 0x3850361 VA: 0x3850260
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x38502A0 Offset: 0x38503A1 VA: 0x38502A0
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x38502E0 Offset: 0x38503E1 VA: 0x38502E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3850370 Offset: 0x3850471 VA: 0x3850370 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x3850520 Offset: 0x3850621 VA: 0x3850520
	private static void .cctor() { }

	// RVA: 0x384EB30 Offset: 0x384EC31 VA: 0x384EB30
	private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }

	// RVA: 0x384ECD0 Offset: 0x384EDD1 VA: 0x384ECD0
	private static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret) { }
}

// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x43DC60 Offset: 0x43DD61 VA: 0x43DC60
[NativeClassAttribute] // RVA: 0x43DC60 Offset: 0x43DD61 VA: 0x43DC60
[Il2CppEagerStaticClassConstructionAttribute] // RVA: 0x43DC60 Offset: 0x43DD61 VA: 0x43DC60
[DefaultMemberAttribute] // RVA: 0x43DC60 Offset: 0x43DD61 VA: 0x43DC60
public struct Vector2 : IEquatable<Vector2>, IFormattable // TypeDefIndex: 3545
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	private static readonly Vector2 zeroVector; // 0x0
	private static readonly Vector2 oneVector; // 0x8
	private static readonly Vector2 upVector; // 0x10
	private static readonly Vector2 downVector; // 0x18
	private static readonly Vector2 leftVector; // 0x20
	private static readonly Vector2 rightVector; // 0x28
	private static readonly Vector2 positiveInfinityVector; // 0x30
	private static readonly Vector2 negativeInfinityVector; // 0x38
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;

	// Properties
	public float Item { get; set; }
	public Vector2 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector2 zero { get; }
	public static Vector2 one { get; }
	public static Vector2 up { get; }
	public static Vector2 down { get; }
	public static Vector2 right { get; }

	// Methods

	// RVA: 0x384D620 Offset: 0x384D721 VA: 0x384D620
	public float get_Item(int index) { }

	// RVA: 0x384D6A0 Offset: 0x384D7A1 VA: 0x384D6A0
	public void set_Item(int index, float value) { }

	// RVA: 0x384D720 Offset: 0x384D821 VA: 0x384D720
	public void .ctor(float x, float y) { }

	// RVA: 0x384D730 Offset: 0x384D831 VA: 0x384D730
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x384D790 Offset: 0x384D891 VA: 0x384D790
	public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta) { }

	// RVA: 0x384D890 Offset: 0x384D991 VA: 0x384D890
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0x384D8A0 Offset: 0x384D9A1 VA: 0x384D8A0
	public void Normalize() { }

	// RVA: 0x384DA90 Offset: 0x384DB91 VA: 0x384DA90
	public Vector2 get_normalized() { }

	// RVA: 0x384DB70 Offset: 0x384DC71 VA: 0x384DB70 Slot: 3
	public override string ToString() { }

	// RVA: 0x384DC00 Offset: 0x384DD01 VA: 0x384DC00 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x384DD70 Offset: 0x384DE71 VA: 0x384DD70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x384DDB0 Offset: 0x384DEB1 VA: 0x384DDB0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x384DE50 Offset: 0x384DF51 VA: 0x384DE50 Slot: 4
	public bool Equals(Vector2 other) { }

	// RVA: 0x384DE80 Offset: 0x384DF81 VA: 0x384DE80
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x384D9A0 Offset: 0x384DAA1 VA: 0x384D9A0
	public float get_magnitude() { }

	// RVA: 0x384DE90 Offset: 0x384DF91 VA: 0x384DE90
	public float get_sqrMagnitude() { }

	// RVA: 0x384DEB0 Offset: 0x384DFB1 VA: 0x384DEB0
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x384DFE0 Offset: 0x384E0E1 VA: 0x384DFE0
	public static float SignedAngle(Vector2 from, Vector2 to) { }

	// RVA: 0x384E130 Offset: 0x384E231 VA: 0x384E130
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x384E1E0 Offset: 0x384E2E1 VA: 0x384E1E0
	public static float SqrMagnitude(Vector2 a) { }

	// RVA: 0x384E1F0 Offset: 0x384E2F1 VA: 0x384E1F0
	public static Vector2 Min(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x384E240 Offset: 0x384E341 VA: 0x384E240
	public static Vector2 Max(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x384E290 Offset: 0x384E391 VA: 0x384E290
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x384E2A0 Offset: 0x384E3A1 VA: 0x384E2A0
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x384E2B0 Offset: 0x384E3B1 VA: 0x384E2B0
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x384E2C0 Offset: 0x384E3C1 VA: 0x384E2C0
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x384E2D0 Offset: 0x384E3D1 VA: 0x384E2D0
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x384E2E0 Offset: 0x384E3E1 VA: 0x384E2E0
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x384E2F0 Offset: 0x384E3F1 VA: 0x384E2F0
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x384E300 Offset: 0x384E401 VA: 0x384E300
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x384E310 Offset: 0x384E411 VA: 0x384E310
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x384E340 Offset: 0x384E441 VA: 0x384E340
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x384E370 Offset: 0x384E471 VA: 0x384E370
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x384E380 Offset: 0x384E481 VA: 0x384E380
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x384DA40 Offset: 0x384DB41 VA: 0x384DA40
	public static Vector2 get_zero() { }

	// RVA: 0x384E390 Offset: 0x384E491 VA: 0x384E390
	public static Vector2 get_one() { }

	// RVA: 0x384E3E0 Offset: 0x384E4E1 VA: 0x384E3E0
	public static Vector2 get_up() { }

	// RVA: 0x384E430 Offset: 0x384E531 VA: 0x384E430
	public static Vector2 get_down() { }

	// RVA: 0x384E480 Offset: 0x384E581 VA: 0x384E480
	public static Vector2 get_right() { }

	// RVA: 0x384E4D0 Offset: 0x384E5D1 VA: 0x384E4D0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[Il2CppEagerStaticClassConstructionAttribute] // RVA: 0x43DCF0 Offset: 0x43DDF1 VA: 0x43DCF0
[DefaultMemberAttribute] // RVA: 0x43DCF0 Offset: 0x43DDF1 VA: 0x43DCF0
[UsedByNativeCodeAttribute] // RVA: 0x43DCF0 Offset: 0x43DDF1 VA: 0x43DCF0
public struct Vector2Int : IEquatable<Vector2Int>, IFormattable // TypeDefIndex: 3546
{
	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private static readonly Vector2Int s_Zero; // 0x0
	private static readonly Vector2Int s_One; // 0x8
	private static readonly Vector2Int s_Up; // 0x10
	private static readonly Vector2Int s_Down; // 0x18
	private static readonly Vector2Int s_Left; // 0x20
	private static readonly Vector2Int s_Right; // 0x28

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public static Vector2Int zero { get; }
	public static Vector2Int one { get; }

	// Methods

	// RVA: 0x384E580 Offset: 0x384E681 VA: 0x384E580
	public int get_x() { }

	// RVA: 0x384E590 Offset: 0x384E691 VA: 0x384E590
	public void set_x(int value) { }

	// RVA: 0x384E5A0 Offset: 0x384E6A1 VA: 0x384E5A0
	public int get_y() { }

	// RVA: 0x384E5B0 Offset: 0x384E6B1 VA: 0x384E5B0
	public void set_y(int value) { }

	// RVA: 0x384E5C0 Offset: 0x384E6C1 VA: 0x384E5C0
	public void .ctor(int x, int y) { }

	// RVA: 0x384E5D0 Offset: 0x384E6D1 VA: 0x384E5D0
	public static Vector2Int Max(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x384E620 Offset: 0x384E721 VA: 0x384E620
	public static Vector2 op_Implicit(Vector2Int v) { }

	// RVA: 0x384E630 Offset: 0x384E731 VA: 0x384E630
	public static bool op_Equality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x384E650 Offset: 0x384E751 VA: 0x384E650
	public static bool op_Inequality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x384E670 Offset: 0x384E771 VA: 0x384E670 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x384E710 Offset: 0x384E811 VA: 0x384E710 Slot: 4
	public bool Equals(Vector2Int other) { }

	// RVA: 0x384E740 Offset: 0x384E841 VA: 0x384E740 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x384E7A0 Offset: 0x384E8A1 VA: 0x384E7A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x384E830 Offset: 0x384E931 VA: 0x384E830 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x384E980 Offset: 0x384EA81 VA: 0x384E980
	public static Vector2Int get_zero() { }

	// RVA: 0x384E9D0 Offset: 0x384EAD1 VA: 0x384E9D0
	public static Vector2Int get_one() { }

	// RVA: 0x384EA20 Offset: 0x384EB21 VA: 0x384EA20
	private static void .cctor() { }
}

// Namespace: UnityEngine
[Il2CppEagerStaticClassConstructionAttribute] // RVA: 0x43DD50 Offset: 0x43DE51 VA: 0x43DD50
[UsedByNativeCodeAttribute] // RVA: 0x43DD50 Offset: 0x43DE51 VA: 0x43DD50
[DefaultMemberAttribute] // RVA: 0x43DD50 Offset: 0x43DE51 VA: 0x43DD50
public struct Vector3Int : IEquatable<Vector3Int>, IFormattable // TypeDefIndex: 3547
{
	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private int m_Z; // 0x8
	private static readonly Vector3Int s_Zero; // 0x0
	private static readonly Vector3Int s_One; // 0xC
	private static readonly Vector3Int s_Up; // 0x18
	private static readonly Vector3Int s_Down; // 0x24
	private static readonly Vector3Int s_Left; // 0x30
	private static readonly Vector3Int s_Right; // 0x3C
	private static readonly Vector3Int s_Forward; // 0x48
	private static readonly Vector3Int s_Back; // 0x54

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public int z { get; set; }

	// Methods

	// RVA: 0x3850610 Offset: 0x3850711 VA: 0x3850610
	public int get_x() { }

	// RVA: 0x3850620 Offset: 0x3850721 VA: 0x3850620
	public void set_x(int value) { }

	// RVA: 0x3850630 Offset: 0x3850731 VA: 0x3850630
	public int get_y() { }

	// RVA: 0x3850640 Offset: 0x3850741 VA: 0x3850640
	public void set_y(int value) { }

	// RVA: 0x3850650 Offset: 0x3850751 VA: 0x3850650
	public int get_z() { }

	// RVA: 0x3850660 Offset: 0x3850761 VA: 0x3850660
	public void set_z(int value) { }

	// RVA: 0x3850670 Offset: 0x3850771 VA: 0x3850670
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x3850680 Offset: 0x3850781 VA: 0x3850680
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x38506B0 Offset: 0x38507B1 VA: 0x38506B0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x3850770 Offset: 0x3850871 VA: 0x3850770 Slot: 4
	public bool Equals(Vector3Int other) { }

	// RVA: 0x38507B0 Offset: 0x38508B1 VA: 0x38507B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3850830 Offset: 0x3850931 VA: 0x3850830 Slot: 3
	public override string ToString() { }

	// RVA: 0x38508C0 Offset: 0x38509C1 VA: 0x38508C0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x3850A60 Offset: 0x3850B61 VA: 0x3850A60
	private static void .cctor() { }
}

// Namespace: UnityEngine
[DefaultMemberAttribute] // RVA: 0x43DDB0 Offset: 0x43DEB1 VA: 0x43DDB0
[Il2CppEagerStaticClassConstructionAttribute] // RVA: 0x43DDB0 Offset: 0x43DEB1 VA: 0x43DDB0
[NativeHeaderAttribute] // RVA: 0x43DDB0 Offset: 0x43DEB1 VA: 0x43DDB0
[RequiredByNativeCodeAttribute] // RVA: 0x43DDB0 Offset: 0x43DEB1 VA: 0x43DDB0
[NativeClassAttribute] // RVA: 0x43DDB0 Offset: 0x43DEB1 VA: 0x43DDB0
public struct Vector4 : IEquatable<Vector4>, IFormattable // TypeDefIndex: 3548
{
	// Fields
	public const float kEpsilon = 1E-05;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Vector4 zeroVector; // 0x0
	private static readonly Vector4 oneVector; // 0x10
	private static readonly Vector4 positiveInfinityVector; // 0x20
	private static readonly Vector4 negativeInfinityVector; // 0x30

	// Properties
	public float Item { get; set; }
	public Vector4 normalized { get; }
	public float sqrMagnitude { get; }
	public static Vector4 zero { get; }
	public static Vector4 one { get; }

	// Methods

	// RVA: 0x3850B20 Offset: 0x3850C21 VA: 0x3850B20
	public float get_Item(int index) { }

	// RVA: 0x3850BD0 Offset: 0x3850CD1 VA: 0x3850BD0
	public void set_Item(int index, float value) { }

	// RVA: 0x3850C80 Offset: 0x3850D81 VA: 0x3850C80
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x3850CA0 Offset: 0x3850DA1 VA: 0x3850CA0
	public void .ctor(float x, float y) { }

	// RVA: 0x3850CB0 Offset: 0x3850DB1 VA: 0x3850CB0
	public static Vector4 Lerp(Vector4 a, Vector4 b, float t) { }

	// RVA: 0x3850D40 Offset: 0x3850E41 VA: 0x3850D40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3850DB0 Offset: 0x3850EB1 VA: 0x3850DB0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x3850E70 Offset: 0x3850F71 VA: 0x3850E70 Slot: 4
	public bool Equals(Vector4 other) { }

	// RVA: 0x3850EB0 Offset: 0x3850FB1 VA: 0x3850EB0
	public static Vector4 Normalize(Vector4 a) { }

	// RVA: 0x38510E0 Offset: 0x38511E1 VA: 0x38510E0
	public Vector4 get_normalized() { }

	// RVA: 0x38510F0 Offset: 0x38511F1 VA: 0x38510F0
	public static float Dot(Vector4 a, Vector4 b) { }

	// RVA: 0x3850FD0 Offset: 0x38510D1 VA: 0x3850FD0
	public static float Magnitude(Vector4 a) { }

	// RVA: 0x3851110 Offset: 0x3851211 VA: 0x3851110
	public float get_sqrMagnitude() { }

	// RVA: 0x3851090 Offset: 0x3851191 VA: 0x3851090
	public static Vector4 get_zero() { }

	// RVA: 0x3851140 Offset: 0x3851241 VA: 0x3851140
	public static Vector4 get_one() { }

	// RVA: 0x3851190 Offset: 0x3851291 VA: 0x3851190
	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	// RVA: 0x38511B0 Offset: 0x38512B1 VA: 0x38511B0
	public static Vector4 op_UnaryNegation(Vector4 a) { }

	// RVA: 0x38511D0 Offset: 0x38512D1 VA: 0x38511D0
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	// RVA: 0x38511F0 Offset: 0x38512F1 VA: 0x38511F0
	public static Vector4 op_Multiply(float d, Vector4 a) { }

	// RVA: 0x3851210 Offset: 0x3851311 VA: 0x3851210
	public static Vector4 op_Division(Vector4 a, float d) { }

	// RVA: 0x3851230 Offset: 0x3851331 VA: 0x3851230
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x3851280 Offset: 0x3851381 VA: 0x3851280
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x38512D0 Offset: 0x38513D1 VA: 0x38512D0
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x38512E0 Offset: 0x38513E1 VA: 0x38512E0
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x38512F0 Offset: 0x38513F1 VA: 0x38512F0
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x3851300 Offset: 0x3851401 VA: 0x3851300 Slot: 3
	public override string ToString() { }

	// RVA: 0x3851390 Offset: 0x3851491 VA: 0x3851390 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x3851590 Offset: 0x3851691 VA: 0x3851590
	private static void .cctor() { }
}

