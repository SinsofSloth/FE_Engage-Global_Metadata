// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43E1F0 Offset: 0x43E2F1 VA: 0x43E1F0
public static class Random // TypeDefIndex: 3565
{
	// Properties
	public static float value { get; }
	public static Vector3 insideUnitSphere { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x44EAF0 Offset: 0x44EBF1 VA: 0x44EAF0
	[StaticAccessorAttribute] // RVA: 0x44EAF0 Offset: 0x44EBF1 VA: 0x44EAF0
	// RVA: 0x31D1A90 Offset: 0x31D1B91 VA: 0x31D1A90
	public static void InitState(int seed) { }

	[FreeFunctionAttribute] // RVA: 0x44EB60 Offset: 0x44EC61 VA: 0x44EB60
	// RVA: 0x31D1AE0 Offset: 0x31D1BE1 VA: 0x31D1AE0
	public static float Range(float minInclusive, float maxInclusive) { }

	// RVA: 0x31D1B30 Offset: 0x31D1C31 VA: 0x31D1B30
	public static int Range(int minInclusive, int maxExclusive) { }

	[FreeFunctionAttribute] // RVA: 0x44EB70 Offset: 0x44EC71 VA: 0x44EB70
	// RVA: 0x31D1B80 Offset: 0x31D1C81 VA: 0x31D1B80
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }

	[FreeFunctionAttribute] // RVA: 0x44EB80 Offset: 0x44EC81 VA: 0x44EB80
	// RVA: 0x31D1BD0 Offset: 0x31D1CD1 VA: 0x31D1BD0
	public static float get_value() { }

	[FreeFunctionAttribute] // RVA: 0x44EB90 Offset: 0x44EC91 VA: 0x44EB90
	// RVA: 0x31D1C10 Offset: 0x31D1D11 VA: 0x31D1C10
	public static Vector3 get_insideUnitSphere() { }

	// RVA: 0x31D1C70 Offset: 0x31D1D71 VA: 0x31D1C70
	private static void get_insideUnitSphere_Injected(out Vector3 ret) { }
}

