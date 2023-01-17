// Namespace: RootMotion
public static class QuaTools // TypeDefIndex: 14307
{
	// Methods

	// RVA: 0x2EF1410 Offset: 0x2EF1511 VA: 0x2EF1410
	public static float GetYaw(Quaternion space, Vector3 forward) { }

	// RVA: 0x2EF1470 Offset: 0x2EF1571 VA: 0x2EF1470
	public static float GetPitch(Quaternion space, Vector3 forward) { }

	// RVA: 0x2EF1510 Offset: 0x2EF1611 VA: 0x2EF1510
	public static float GetBank(Quaternion space, Vector3 forward, Vector3 up) { }

	// RVA: 0x2EF1680 Offset: 0x2EF1781 VA: 0x2EF1680
	public static float GetYaw(Quaternion space, Quaternion rotation) { }

	// RVA: 0x2EF1740 Offset: 0x2EF1841 VA: 0x2EF1740
	public static float GetPitch(Quaternion space, Quaternion rotation) { }

	// RVA: 0x2EF1800 Offset: 0x2EF1901 VA: 0x2EF1800
	public static float GetBank(Quaternion space, Quaternion rotation) { }

	// RVA: 0x2EF19B0 Offset: 0x2EF1AB1 VA: 0x2EF19B0
	public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight) { }

	// RVA: 0x2EF1A10 Offset: 0x2EF1B11 VA: 0x2EF1A10
	public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight) { }

	// RVA: 0x2EF1A70 Offset: 0x2EF1B71 VA: 0x2EF1A70
	public static Quaternion LinearBlend(Quaternion q, float weight) { }

	// RVA: 0x2EF1B20 Offset: 0x2EF1C21 VA: 0x2EF1B20
	public static Quaternion SphericalBlend(Quaternion q, float weight) { }

	// RVA: 0x2EF1BD0 Offset: 0x2EF1CD1 VA: 0x2EF1BD0
	public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis) { }

	// RVA: 0x2EF1CC0 Offset: 0x2EF1DC1 VA: 0x2EF1CC0
	public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation) { }

	// RVA: 0x2EF1D20 Offset: 0x2EF1E21 VA: 0x2EF1D20
	public static Quaternion FromToRotation(Quaternion from, Quaternion to) { }

	// RVA: 0x2EF1E00 Offset: 0x2EF1F01 VA: 0x2EF1E00
	public static Vector3 GetAxis(Vector3 v) { }

	// RVA: 0x2EF1F10 Offset: 0x2EF2011 VA: 0x2EF1F10
	public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing) { }

	// RVA: 0x2EF2100 Offset: 0x2EF2201 VA: 0x2EF2100
	public static float ClampAngle(float angle, float clampWeight, int clampSmoothing) { }

	// RVA: 0x2EF2240 Offset: 0x2EF2341 VA: 0x2EF2240
	public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis) { }

	// RVA: 0x2EF2340 Offset: 0x2EF2441 VA: 0x2EF2340
	public static Vector3 ToBiPolar(Vector3 euler) { }

	// RVA: 0x2EF2410 Offset: 0x2EF2511 VA: 0x2EF2410
	public static float ToBiPolar(float angle) { }
}

