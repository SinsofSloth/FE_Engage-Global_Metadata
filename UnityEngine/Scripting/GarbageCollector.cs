// Namespace: UnityEngine.Scripting
[NativeHeaderAttribute] // RVA: 0x43F930 Offset: 0x43FA31 VA: 0x43F930
public static class GarbageCollector // TypeDefIndex: 3707
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x444420 Offset: 0x444521 VA: 0x444420
	[CompilerGeneratedAttribute] // RVA: 0x444420 Offset: 0x444521 VA: 0x444420
	private static Action<GarbageCollector.Mode> GCModeChanged; // 0x0

	// Properties
	public static GarbageCollector.Mode GCMode { get; set; }
	public static bool isIncremental { get; }
	public static ulong incrementalTimeSliceNanoseconds { get; set; }

	// Methods

	// RVA: 0x2F23820 Offset: 0x2F23921 VA: 0x2F23820
	public static GarbageCollector.Mode get_GCMode() { }

	// RVA: 0x2F238A0 Offset: 0x2F239A1 VA: 0x2F238A0
	public static void set_GCMode(GarbageCollector.Mode value) { }

	[NativeThrowsAttribute] // RVA: 0x452950 Offset: 0x452A51 VA: 0x452950
	// RVA: 0x2F239A0 Offset: 0x2F23AA1 VA: 0x2F239A0
	private static void SetMode(GarbageCollector.Mode mode) { }

	// RVA: 0x2F23860 Offset: 0x2F23961 VA: 0x2F23860
	private static GarbageCollector.Mode GetMode() { }

	[NativeMethodAttribute] // RVA: 0x452960 Offset: 0x452A61 VA: 0x452960
	// RVA: 0x2F239F0 Offset: 0x2F23AF1 VA: 0x2F239F0
	public static bool get_isIncremental() { }

	// RVA: 0x2F23A30 Offset: 0x2F23B31 VA: 0x2F23A30
	public static ulong get_incrementalTimeSliceNanoseconds() { }

	// RVA: 0x2F23A70 Offset: 0x2F23B71 VA: 0x2F23A70
	public static void set_incrementalTimeSliceNanoseconds(ulong value) { }
}

