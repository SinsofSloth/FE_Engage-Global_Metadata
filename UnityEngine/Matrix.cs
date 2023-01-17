// Namespace: UnityEngine
[NativeClassAttribute] // RVA: 0x43D900 Offset: 0x43DA01 VA: 0x43D900
[DefaultMemberAttribute] // RVA: 0x43D900 Offset: 0x43DA01 VA: 0x43D900
[RequiredByNativeCodeAttribute] // RVA: 0x43D900 Offset: 0x43DA01 VA: 0x43D900
[NativeTypeAttribute] // RVA: 0x43D900 Offset: 0x43DA01 VA: 0x43D900
[Il2CppEagerStaticClassConstructionAttribute] // RVA: 0x43D900 Offset: 0x43DA01 VA: 0x43D900
[NativeHeaderAttribute] // RVA: 0x43D900 Offset: 0x43DA01 VA: 0x43D900
public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable // TypeDefIndex: 3541
{
	// Fields
	[NativeNameAttribute] // RVA: 0x443310 Offset: 0x443411 VA: 0x443310
	public float m00; // 0x0
	[NativeNameAttribute] // RVA: 0x443350 Offset: 0x443451 VA: 0x443350
	public float m10; // 0x4
	[NativeNameAttribute] // RVA: 0x443390 Offset: 0x443491 VA: 0x443390
	public float m20; // 0x8
	[NativeNameAttribute] // RVA: 0x4433D0 Offset: 0x4434D1 VA: 0x4433D0
	public float m30; // 0xC
	[NativeNameAttribute] // RVA: 0x443410 Offset: 0x443511 VA: 0x443410
	public float m01; // 0x10
	[NativeNameAttribute] // RVA: 0x443450 Offset: 0x443551 VA: 0x443450
	public float m11; // 0x14
	[NativeNameAttribute] // RVA: 0x443490 Offset: 0x443591 VA: 0x443490
	public float m21; // 0x18
	[NativeNameAttribute] // RVA: 0x4434D0 Offset: 0x4435D1 VA: 0x4434D0
	public float m31; // 0x1C
	[NativeNameAttribute] // RVA: 0x443510 Offset: 0x443611 VA: 0x443510
	public float m02; // 0x20
	[NativeNameAttribute] // RVA: 0x443550 Offset: 0x443651 VA: 0x443550
	public float m12; // 0x24
	[NativeNameAttribute] // RVA: 0x443590 Offset: 0x443691 VA: 0x443590
	public float m22; // 0x28
	[NativeNameAttribute] // RVA: 0x4435D0 Offset: 0x4436D1 VA: 0x4435D0
	public float m32; // 0x2C
	[NativeNameAttribute] // RVA: 0x443610 Offset: 0x443711 VA: 0x443610
	public float m03; // 0x30
	[NativeNameAttribute] // RVA: 0x443650 Offset: 0x443751 VA: 0x443650
	public float m13; // 0x34
	[NativeNameAttribute] // RVA: 0x443690 Offset: 0x443791 VA: 0x443690
	public float m23; // 0x38
	[NativeNameAttribute] // RVA: 0x4436D0 Offset: 0x4437D1 VA: 0x4436D0
	public float m33; // 0x3C
	private static readonly Matrix4x4 zeroMatrix; // 0x0
	private static readonly Matrix4x4 identityMatrix; // 0x40

	// Properties
	public Quaternion rotation { get; }
	public Vector3 lossyScale { get; }
	public FrustumPlanes decomposeProjection { get; }
	public Matrix4x4 inverse { get; }
	public int Item { set; }
	public float Item { get; set; }
	public static Matrix4x4 zero { get; }
	public static Matrix4x4 identity { get; }

	// Methods

	[ThreadSafeAttribute] // RVA: 0x44E1F0 Offset: 0x44E2F1 VA: 0x44E1F0
	// RVA: 0x347EA70 Offset: 0x347EB71 VA: 0x347EA70
	private Quaternion GetRotation() { }

	[ThreadSafeAttribute] // RVA: 0x44E200 Offset: 0x44E301 VA: 0x44E200
	// RVA: 0x347EB20 Offset: 0x347EC21 VA: 0x347EB20
	private Vector3 GetLossyScale() { }

	[ThreadSafeAttribute] // RVA: 0x44E210 Offset: 0x44E311 VA: 0x44E210
	// RVA: 0x347EBD0 Offset: 0x347ECD1 VA: 0x347EBD0
	private FrustumPlanes DecomposeProjection() { }

	// RVA: 0x347ECA0 Offset: 0x347EDA1 VA: 0x347ECA0
	public Quaternion get_rotation() { }

	// RVA: 0x347ED00 Offset: 0x347EE01 VA: 0x347ED00
	public Vector3 get_lossyScale() { }

	// RVA: 0x347ED60 Offset: 0x347EE61 VA: 0x347ED60
	public FrustumPlanes get_decomposeProjection() { }

	[FreeFunctionAttribute] // RVA: 0x44E220 Offset: 0x44E321 VA: 0x44E220
	// RVA: 0x347EDF0 Offset: 0x347EEF1 VA: 0x347EDF0
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunctionAttribute] // RVA: 0x44E270 Offset: 0x44E371 VA: 0x44E270
	// RVA: 0x347EF10 Offset: 0x347F011 VA: 0x347EF10
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x347EFF0 Offset: 0x347F0F1 VA: 0x347EFF0
	public Matrix4x4 get_inverse() { }

	[FreeFunctionAttribute] // RVA: 0x44E2C0 Offset: 0x44E3C1 VA: 0x44E2C0
	// RVA: 0x347F0C0 Offset: 0x347F1C1 VA: 0x347F0C0
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	[FreeFunctionAttribute] // RVA: 0x44E310 Offset: 0x44E411 VA: 0x44E310
	// RVA: 0x347F1E0 Offset: 0x347F2E1 VA: 0x347F1E0
	public static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up) { }

	// RVA: 0x347F300 Offset: 0x347F401 VA: 0x347F300
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x347F350 Offset: 0x347F451 VA: 0x347F350
	public void set_Item(int row, int column, float value) { }

	// RVA: 0x347F4D0 Offset: 0x347F5D1 VA: 0x347F4D0
	public float get_Item(int index) { }

	// RVA: 0x347F360 Offset: 0x347F461 VA: 0x347F360
	public void set_Item(int index, float value) { }

	// RVA: 0x347F640 Offset: 0x347F741 VA: 0x347F640 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x347F830 Offset: 0x347F931 VA: 0x347F830 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x347F8E0 Offset: 0x347F9E1 VA: 0x347F8E0 Slot: 4
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x347FAD0 Offset: 0x347FBD1 VA: 0x347FAD0
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x347FD40 Offset: 0x347FE41 VA: 0x347FD40
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	// RVA: 0x347FDE0 Offset: 0x347FEE1 VA: 0x347FDE0
	public static bool op_Equality(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x3480020 Offset: 0x3480121 VA: 0x3480020
	public static bool op_Inequality(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x347F760 Offset: 0x347F861 VA: 0x347F760
	public Vector4 GetColumn(int index) { }

	// RVA: 0x3480090 Offset: 0x3480191 VA: 0x3480090
	public Vector4 GetRow(int index) { }

	// RVA: 0x3480180 Offset: 0x3480281 VA: 0x3480180
	public void SetColumn(int index, Vector4 column) { }

	// RVA: 0x3480200 Offset: 0x3480301 VA: 0x3480200
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x34802A0 Offset: 0x34803A1 VA: 0x34802A0
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x3480320 Offset: 0x3480421 VA: 0x3480320
	public Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0x3480380 Offset: 0x3480481 VA: 0x3480380
	public static Matrix4x4 Scale(Vector3 vector) { }

	// RVA: 0x34803B0 Offset: 0x34804B1 VA: 0x34803B0
	public static Matrix4x4 Translate(Vector3 vector) { }

	// RVA: 0x34803E0 Offset: 0x34804E1 VA: 0x34803E0
	public static Matrix4x4 Rotate(Quaternion q) { }

	// RVA: 0x3480490 Offset: 0x3480591 VA: 0x3480490
	public static Matrix4x4 get_zero() { }

	// RVA: 0x3480510 Offset: 0x3480611 VA: 0x3480510
	public static Matrix4x4 get_identity() { }

	// RVA: 0x3480590 Offset: 0x3480691 VA: 0x3480590 Slot: 3
	public override string ToString() { }

	// RVA: 0x3480620 Offset: 0x3480721 VA: 0x3480620 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x3480BB0 Offset: 0x3480CB1 VA: 0x3480BB0
	private static void .cctor() { }

	// RVA: 0x347EAD0 Offset: 0x347EBD1 VA: 0x347EAD0
	private static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret) { }

	// RVA: 0x347EB80 Offset: 0x347EC81 VA: 0x347EB80
	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	// RVA: 0x347EC50 Offset: 0x347ED51 VA: 0x347EC50
	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) { }

	// RVA: 0x347EEA0 Offset: 0x347EFA1 VA: 0x347EEA0
	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

	// RVA: 0x347EFA0 Offset: 0x347F0A1 VA: 0x347EFA0
	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x347F170 Offset: 0x347F271 VA: 0x347F170
	private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret) { }

	// RVA: 0x347F290 Offset: 0x347F391 VA: 0x347F290
	private static void LookAt_Injected(ref Vector3 from, ref Vector3 to, ref Vector3 up, out Matrix4x4 ret) { }
}

