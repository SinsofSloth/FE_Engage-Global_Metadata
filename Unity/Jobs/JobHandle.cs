// Namespace: Unity.Jobs
[NativeTypeAttribute] // RVA: 0x43AF10 Offset: 0x43B011 VA: 0x43AF10
public struct JobHandle // TypeDefIndex: 3343
{
	// Fields
	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x441970 Offset: 0x441A71 VA: 0x441970
	internal IntPtr jobGroup; // 0x0
	internal int version; // 0x8

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x2F264D0 Offset: 0x2F265D1 VA: 0x2F264D0
	public void Complete() { }

	// RVA: 0x2F265B0 Offset: 0x2F266B1 VA: 0x2F265B0
	public static void CompleteAll(NativeArray<JobHandle> jobs) { }

	// RVA: 0x2F26690 Offset: 0x2F26791 VA: 0x2F26690
	public bool get_IsCompleted() { }

	[NativeMethodAttribute] // RVA: 0x445800 Offset: 0x445901 VA: 0x445800
	// RVA: 0x2F0BA50 Offset: 0x2F0BB51 VA: 0x2F0BA50
	public static void ScheduleBatchedJobs() { }

	[NativeMethodAttribute] // RVA: 0x445840 Offset: 0x445941 VA: 0x445840
	// RVA: 0x2F26560 Offset: 0x2F26661 VA: 0x2F26560
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	[NativeMethodAttribute] // RVA: 0x445880 Offset: 0x445981 VA: 0x445880
	// RVA: 0x2F266E0 Offset: 0x2F267E1 VA: 0x2F266E0
	private static bool ScheduleBatchedJobsAndIsCompleted(ref JobHandle job) { }

	[NativeMethodAttribute] // RVA: 0x4458C0 Offset: 0x4459C1 VA: 0x4458C0
	// RVA: 0x2F26640 Offset: 0x2F26741 VA: 0x2F26640
	private static void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count) { }

	// RVA: 0x2F26730 Offset: 0x2F26831 VA: 0x2F26730
	public static JobHandle CombineDependencies(NativeArray<JobHandle> jobs) { }

	[NativeMethodAttribute] // RVA: 0x445900 Offset: 0x445A01 VA: 0x445900
	// RVA: 0x2F267E0 Offset: 0x2F268E1 VA: 0x2F267E0
	internal static JobHandle CombineDependenciesInternalPtr(void* jobs, int count) { }

	// RVA: 0x2F26850 Offset: 0x2F26951 VA: 0x2F26850
	private static void CombineDependenciesInternalPtr_Injected(void* jobs, int count, out JobHandle ret) { }
}

