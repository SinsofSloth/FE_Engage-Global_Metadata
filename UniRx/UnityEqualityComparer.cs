// Namespace: UniRx
public static class UnityEqualityComparer // TypeDefIndex: 4906
{
	// Fields
	public static readonly IEqualityComparer<Vector2> Vector2; // 0x0
	public static readonly IEqualityComparer<Vector3> Vector3; // 0x8
	public static readonly IEqualityComparer<Vector4> Vector4; // 0x10
	public static readonly IEqualityComparer<Color> Color; // 0x18
	public static readonly IEqualityComparer<Color32> Color32; // 0x20
	public static readonly IEqualityComparer<Rect> Rect; // 0x28
	public static readonly IEqualityComparer<Bounds> Bounds; // 0x30
	public static readonly IEqualityComparer<Quaternion> Quaternion; // 0x38
	private static readonly RuntimeTypeHandle vector2Type; // 0x40
	private static readonly RuntimeTypeHandle vector3Type; // 0x48
	private static readonly RuntimeTypeHandle vector4Type; // 0x50
	private static readonly RuntimeTypeHandle colorType; // 0x58
	private static readonly RuntimeTypeHandle color32Type; // 0x60
	private static readonly RuntimeTypeHandle rectType; // 0x68
	private static readonly RuntimeTypeHandle boundsType; // 0x70
	private static readonly RuntimeTypeHandle quaternionType; // 0x78
	public static readonly IEqualityComparer<Vector2Int> Vector2Int; // 0x80
	public static readonly IEqualityComparer<Vector3Int> Vector3Int; // 0x88
	public static readonly IEqualityComparer<RangeInt> RangeInt; // 0x90
	public static readonly IEqualityComparer<RectInt> RectInt; // 0x98
	public static readonly IEqualityComparer<BoundsInt> BoundsInt; // 0xA0
	private static readonly RuntimeTypeHandle vector2IntType; // 0xA8
	private static readonly RuntimeTypeHandle vector3IntType; // 0xB0
	private static readonly RuntimeTypeHandle rangeIntType; // 0xB8
	private static readonly RuntimeTypeHandle rectIntType; // 0xC0
	private static readonly RuntimeTypeHandle boundsIntType; // 0xC8

	// Methods

	// RVA: -1 Offset: -1
	public static IEqualityComparer<T> GetDefault<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202DBC0 Offset: 0x202DCC1 VA: 0x202DBC0
	|-UnityEqualityComparer.GetDefault<bool>
	|
	|-RVA: 0x202DC70 Offset: 0x202DD71 VA: 0x202DC70
	|-UnityEqualityComparer.GetDefault<Bounds>
	|
	|-RVA: 0x202DD20 Offset: 0x202DE21 VA: 0x202DD20
	|-UnityEqualityComparer.GetDefault<byte>
	|
	|-RVA: 0x202DDD0 Offset: 0x202DED1 VA: 0x202DDD0
	|-UnityEqualityComparer.GetDefault<Color>
	|
	|-RVA: 0x202DE80 Offset: 0x202DF81 VA: 0x202DE80
	|-UnityEqualityComparer.GetDefault<double>
	|
	|-RVA: 0x202DF30 Offset: 0x202E031 VA: 0x202DF30
	|-UnityEqualityComparer.GetDefault<int>
	|
	|-RVA: 0x202DFE0 Offset: 0x202E0E1 VA: 0x202DFE0
	|-UnityEqualityComparer.GetDefault<long>
	|
	|-RVA: 0x202E090 Offset: 0x202E191 VA: 0x202E090
	|-UnityEqualityComparer.GetDefault<object>
	|
	|-RVA: 0x202E140 Offset: 0x202E241 VA: 0x202E140
	|-UnityEqualityComparer.GetDefault<Quaternion>
	|
	|-RVA: 0x202E1F0 Offset: 0x202E2F1 VA: 0x202E1F0
	|-UnityEqualityComparer.GetDefault<Rect>
	|
	|-RVA: 0x202E2A0 Offset: 0x202E3A1 VA: 0x202E2A0
	|-UnityEqualityComparer.GetDefault<float>
	|
	|-RVA: 0x202E350 Offset: 0x202E451 VA: 0x202E350
	|-UnityEqualityComparer.GetDefault<Vector2>
	|
	|-RVA: 0x202E400 Offset: 0x202E501 VA: 0x202E400
	|-UnityEqualityComparer.GetDefault<Vector3>
	|
	|-RVA: 0x202E4B0 Offset: 0x202E5B1 VA: 0x202E4B0
	|-UnityEqualityComparer.GetDefault<Vector4>
	*/

	// RVA: 0x2E8B0B0 Offset: 0x2E8B1B1 VA: 0x2E8B0B0
	private static object GetDefaultHelper(Type type) { }

	// RVA: 0x2E8B5A0 Offset: 0x2E8B6A1 VA: 0x2E8B5A0
	private static void .cctor() { }
}

