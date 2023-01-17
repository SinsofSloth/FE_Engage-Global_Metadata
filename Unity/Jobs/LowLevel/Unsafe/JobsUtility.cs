// Namespace: Unity.Jobs.LowLevel.Unsafe
[NativeHeaderAttribute] // RVA: 0x43AF80 Offset: 0x43B081 VA: 0x43AF80
[NativeTypeAttribute] // RVA: 0x43AF80 Offset: 0x43B081 VA: 0x43AF80
public static class JobsUtility // TypeDefIndex: 3348
{
	// Methods

	// RVA: 0x2F268F0 Offset: 0x2F269F1 VA: 0x2F268F0
	public static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[NativeMethodAttribute] // RVA: 0x445940 Offset: 0x445A41 VA: 0x445940
	// RVA: 0x2F26950 Offset: 0x2F26A51 VA: 0x2F26950
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[FreeFunctionAttribute] // RVA: 0x445980 Offset: 0x445A81 VA: 0x445980
	// RVA: 0x2F269C0 Offset: 0x2F26AC1 VA: 0x2F269C0
	public static JobHandle Schedule(ref JobsUtility.JobScheduleParameters parameters) { }

	[FreeFunctionAttribute] // RVA: 0x4459D0 Offset: 0x445AD1 VA: 0x4459D0
	// RVA: 0x2F26A70 Offset: 0x2F26B71 VA: 0x2F26A70
	public static JobHandle ScheduleParallelFor(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	[FreeFunctionAttribute] // RVA: 0x445A20 Offset: 0x445B21 VA: 0x445A20
	// RVA: 0x2F26B50 Offset: 0x2F26C51 VA: 0x2F26B50
	public static JobHandle ScheduleParallelForTransform(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray) { }

	[FreeFunctionAttribute] // RVA: 0x445A70 Offset: 0x445B71 VA: 0x445A70
	// RVA: 0x2F26C20 Offset: 0x2F26D21 VA: 0x2F26C20
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x2F26C90 Offset: 0x2F26D91 VA: 0x2F26C90
	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x2F26A20 Offset: 0x2F26B21 VA: 0x2F26A20
	private static void Schedule_Injected(ref JobsUtility.JobScheduleParameters parameters, out JobHandle ret) { }

	// RVA: 0x2F26AE0 Offset: 0x2F26BE1 VA: 0x2F26AE0
	private static void ScheduleParallelFor_Injected(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }

	// RVA: 0x2F26BC0 Offset: 0x2F26CC1 VA: 0x2F26BC0
	private static void ScheduleParallelForTransform_Injected(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret) { }
}

