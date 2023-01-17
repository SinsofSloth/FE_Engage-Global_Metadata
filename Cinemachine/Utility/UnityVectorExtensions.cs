// Namespace: Cinemachine.Utility
[ExtensionAttribute] // RVA: 0x1BEE0 Offset: 0x1BFE1 VA: 0x1BEE0
public static class UnityVectorExtensions // TypeDefIndex: 5908
{
	// Fields
	public const float Epsilon = 0.0001;

	// Methods

	[ExtensionAttribute] // RVA: 0x24110 Offset: 0x24211 VA: 0x24110
	// RVA: 0x1A86FD0 Offset: 0x1A870D1 VA: 0x1A86FD0
	public static float ClosestPointOnSegment(Vector3 p, Vector3 s0, Vector3 s1) { }

	[ExtensionAttribute] // RVA: 0x24120 Offset: 0x24221 VA: 0x24120
	// RVA: 0x1A87040 Offset: 0x1A87141 VA: 0x1A87040
	public static float ClosestPointOnSegment(Vector2 p, Vector2 s0, Vector2 s1) { }

	[ExtensionAttribute] // RVA: 0x24130 Offset: 0x24231 VA: 0x24130
	// RVA: 0x1A79AC0 Offset: 0x1A79BC1 VA: 0x1A79AC0
	public static Vector3 ProjectOntoPlane(Vector3 vector, Vector3 planeNormal) { }

	[ExtensionAttribute] // RVA: 0x24140 Offset: 0x24241 VA: 0x24140
	// RVA: 0x1A870E0 Offset: 0x1A871E1 VA: 0x1A870E0
	public static Vector3 Abs(Vector3 v) { }

	[ExtensionAttribute] // RVA: 0x24150 Offset: 0x24251 VA: 0x24150
	// RVA: 0x1A79C70 Offset: 0x1A79D71 VA: 0x1A79C70
	public static bool AlmostZero(Vector3 v) { }

	// RVA: 0x1A870F0 Offset: 0x1A871F1 VA: 0x1A870F0
	public static float Angle(Vector3 v1, Vector3 v2) { }

	// RVA: 0x1A86CF0 Offset: 0x1A86DF1 VA: 0x1A86CF0
	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 up) { }

	// RVA: 0x1A79AF0 Offset: 0x1A79BF1 VA: 0x1A79AF0
	public static Quaternion SafeFromToRotation(Vector3 v1, Vector3 v2, Vector3 up) { }

	// RVA: 0x1A871C0 Offset: 0x1A872C1 VA: 0x1A871C0
	public static Vector3 SlerpWithReferenceUp(Vector3 vA, Vector3 vB, float t, Vector3 up) { }
}

