// Namespace: 
public sealed class IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 3340
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CD6F0 Offset: 0x33CD7F1 VA: 0x33CD6F0
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<SpringJob>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CD710 Offset: 0x33CD811 VA: 0x33CD710
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<SpringJob>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CD9B0 Offset: 0x33CDAB1 VA: 0x33CD9B0
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<SpringJob>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CDAE0 Offset: 0x33CDBE1 VA: 0x33CDAE0
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<SpringJob>.EndInvoke
	*/
}

// Namespace: 
internal struct IJobParallelForExtensions.ParallelForJobStruct<T> // TypeDefIndex: 3341
{
	// Fields
	public static IntPtr jobReflectionData; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static IntPtr Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A60930 Offset: 0x2A60A31 VA: 0x2A60930
	|-IJobParallelForExtensions.ParallelForJobStruct<SpringJob>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A60B90 Offset: 0x2A60C91 VA: 0x2A60B90
	|-IJobParallelForExtensions.ParallelForJobStruct<SpringJob>.Execute
	*/
}

