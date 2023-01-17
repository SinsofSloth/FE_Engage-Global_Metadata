// Namespace: RootMotion
public static class V2Tools // TypeDefIndex: 14311
{
	// Methods

	// RVA: 0x2A3ED50 Offset: 0x2A3EE51 VA: 0x2A3ED50
	public static Vector2 XZ(Vector3 v) { }

	// RVA: 0x2A3ED60 Offset: 0x2A3EE61 VA: 0x2A3ED60
	public static float DeltaAngle(Vector2 dir1, Vector2 dir2) { }

	// RVA: 0x2A3EDC0 Offset: 0x2A3EEC1 VA: 0x2A3EDC0
	public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2) { }

	// RVA: 0x2A3EE20 Offset: 0x2A3EF21 VA: 0x2A3EE20
	public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r) { }

	// RVA: 0x2A3EF10 Offset: 0x2A3F011 VA: 0x2A3EF10
	public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r) { }
}

// Namespace: RootMotion
public static class V3Tools // TypeDefIndex: 14312
{
	// Methods

	// RVA: 0x2A3EFC0 Offset: 0x2A3F0C1 VA: 0x2A3EFC0
	public static float GetYaw(Vector3 forward) { }

	// RVA: 0x2A3EFF0 Offset: 0x2A3F0F1 VA: 0x2A3EFF0
	public static float GetPitch(Vector3 forward) { }

	// RVA: 0x2A3F040 Offset: 0x2A3F141 VA: 0x2A3F040
	public static float GetBank(Vector3 forward, Vector3 up) { }

	// RVA: 0x2A3F0D0 Offset: 0x2A3F1D1 VA: 0x2A3F0D0
	public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward) { }

	// RVA: 0x2A3F140 Offset: 0x2A3F241 VA: 0x2A3F140
	public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward) { }

	// RVA: 0x2A3F1B0 Offset: 0x2A3F2B1 VA: 0x2A3F1B0
	public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up) { }

	// RVA: 0x2A3F2D0 Offset: 0x2A3F3D1 VA: 0x2A3F2D0
	public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight) { }

	// RVA: 0x2A3F370 Offset: 0x2A3F471 VA: 0x2A3F370
	public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight) { }

	// RVA: 0x2A3F3B0 Offset: 0x2A3F4B1 VA: 0x2A3F3B0
	public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight) { }

	// RVA: 0x2A3F400 Offset: 0x2A3F501 VA: 0x2A3F400
	public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight) { }

	// RVA: 0x2A3F4A0 Offset: 0x2A3F5A1 VA: 0x2A3F4A0
	public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing) { }

	// RVA: 0x2A3F660 Offset: 0x2A3F761 VA: 0x2A3F660
	public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed) { }

	// RVA: 0x2A3F830 Offset: 0x2A3F931 VA: 0x2A3F830
	public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue) { }

	// RVA: 0x2A3FA10 Offset: 0x2A3FB11 VA: 0x2A3FA10
	public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint) { }

	// RVA: 0x2A3FAD0 Offset: 0x2A3FBD1 VA: 0x2A3FAD0
	public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal) { }

	// RVA: 0x2A3FBD0 Offset: 0x2A3FCD1 VA: 0x2A3FBD0
	public static Vector3 TransformPointUnscaled(Transform t, Vector3 point) { }

	// RVA: 0x2A3FC50 Offset: 0x2A3FD51 VA: 0x2A3FC50
	public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point) { }

	// RVA: 0x2A3FCF0 Offset: 0x2A3FDF1 VA: 0x2A3FCF0
	public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point) { }

	// RVA: 0x2A3FDA0 Offset: 0x2A3FEA1 VA: 0x2A3FDA0
	public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point) { }

	// RVA: 0x2A3FD90 Offset: 0x2A3FE91 VA: 0x2A3FD90
	public static Vector3 Div(Vector3 v1, Vector3 v2) { }
}

