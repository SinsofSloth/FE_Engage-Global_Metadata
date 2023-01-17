// Namespace: Cinemachine.Utility
public static class SplineHelpers // TypeDefIndex: 5907
{
	// Methods

	// RVA: 0x1A840D0 Offset: 0x1A841D1 VA: 0x1A840D0
	public static Vector3 Bezier3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) { }

	// RVA: 0x1A841E0 Offset: 0x1A842E1 VA: 0x1A841E0
	public static Vector3 BezierTangent3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) { }

	// RVA: 0x1A84350 Offset: 0x1A84451 VA: 0x1A84350
	public static float Bezier1(float t, float p0, float p1, float p2, float p3) { }

	// RVA: 0x1A843E0 Offset: 0x1A844E1 VA: 0x1A843E0
	public static float BezierTangent1(float t, float p0, float p1, float p2, float p3) { }

	// RVA: 0x1A84480 Offset: 0x1A84581 VA: 0x1A84480
	public static void ComputeSmoothControlPoints(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2) { }

	// RVA: 0x1A84C00 Offset: 0x1A84D01 VA: 0x1A84C00
	public static void ComputeSmoothControlPointsLooped(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2) { }
}

