// Namespace: Unity.Profiling.LowLevel
[FlagsAttribute] // RVA: 0x43ADB0 Offset: 0x43AEB1 VA: 0x43ADB0
public enum MarkerFlags // TypeDefIndex: 3333
{
	// Fields
	public ushort value__; // 0x0
	public const MarkerFlags Default = 0;
	public const MarkerFlags Script = 2;
	public const MarkerFlags ScriptInvoke = 32;
	public const MarkerFlags ScriptDeepProfiler = 64;
	public const MarkerFlags AvailabilityEditor = 4;
	public const MarkerFlags Warning = 16;
	public const MarkerFlags Counter = 128;
}

