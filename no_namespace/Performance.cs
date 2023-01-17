// Namespace: 
public enum Performance.PerformanceMode // TypeDefIndex: 7532
{
	// Fields
	public int value__; // 0x0
	public const Performance.PerformanceMode Invalid = -1;
	public const Performance.PerformanceMode Normal = 0;
	public const Performance.PerformanceMode Boost = 1;
}

// Namespace: 
public enum Performance.CpuBoostMode // TypeDefIndex: 7533
{
	// Fields
	public int value__; // 0x0
	public const Performance.CpuBoostMode Normal = 0;
	public const Performance.CpuBoostMode FastLoad = 1;
}

// Namespace: 
public enum Performance.Debug.HudMode // TypeDefIndex: 7534
{
	// Fields
	public int value__; // 0x0
	public const Performance.Debug.HudMode None = 0;
	public const Performance.Debug.HudMode Basic = 1;
	public const Performance.Debug.HudMode Memory = 2;
	public const Performance.Debug.HudMode GPUCounters = 3;
}

// Namespace: 
public static class Performance.Debug // TypeDefIndex: 7535
{
	// Methods

	[NativeConditionalAttribute] // RVA: 0x48B0D0 Offset: 0x48B1D1 VA: 0x48B0D0
	[FreeFunctionAttribute] // RVA: 0x48B0D0 Offset: 0x48B1D1 VA: 0x48B0D0
	// RVA: 0x3F0CA90 Offset: 0x3F0CB91 VA: 0x3F0CA90
	public static void SetHUDMode(Performance.Debug.HudMode mode) { }
}

