// Namespace: 
private struct IJobParallelForTransformExtensions.TransformParallelForLoopStruct.TransformJobData<T> // TypeDefIndex: 3674
{
	// Fields
	public IntPtr TransformAccessArray; // 0x0
	public int IsReadOnly; // 0x0
}

// Namespace: 
public sealed class IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 3675
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CCEB0 Offset: 0x33CCFB1 VA: 0x33CCEB0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringBoneApplyJob>..ctor
	|
	|-RVA: 0x33CD2D0 Offset: 0x33CD3D1 VA: 0x33CD2D0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringColliderJob>..ctor
	|
	|-RVA: 0x33CDB10 Offset: 0x33CDC11 VA: 0x33CDB10
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringLengthTargetJob>..ctor
	|
	|-RVA: 0x33CDF30 Offset: 0x33CE031 VA: 0x33CDF30
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringParentJob>..ctor
	|
	|-RVA: 0x33CE350 Offset: 0x33CE451 VA: 0x33CE350
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringPivotJob>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CCED0 Offset: 0x33CCFD1 VA: 0x33CCED0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringBoneApplyJob>.Invoke
	|
	|-RVA: 0x33CD2F0 Offset: 0x33CD3F1 VA: 0x33CD2F0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringColliderJob>.Invoke
	|
	|-RVA: 0x33CDB30 Offset: 0x33CDC31 VA: 0x33CDB30
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringLengthTargetJob>.Invoke
	|
	|-RVA: 0x33CDF50 Offset: 0x33CE051 VA: 0x33CDF50
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringParentJob>.Invoke
	|
	|-RVA: 0x33CE370 Offset: 0x33CE471 VA: 0x33CE370
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringPivotJob>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CD170 Offset: 0x33CD271 VA: 0x33CD170
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringBoneApplyJob>.BeginInvoke
	|
	|-RVA: 0x33CD590 Offset: 0x33CD691 VA: 0x33CD590
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringColliderJob>.BeginInvoke
	|
	|-RVA: 0x33CDDD0 Offset: 0x33CDED1 VA: 0x33CDDD0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringLengthTargetJob>.BeginInvoke
	|
	|-RVA: 0x33CE1F0 Offset: 0x33CE2F1 VA: 0x33CE1F0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringParentJob>.BeginInvoke
	|
	|-RVA: 0x33CE610 Offset: 0x33CE711 VA: 0x33CE610
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringPivotJob>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref T jobData, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CD2A0 Offset: 0x33CD3A1 VA: 0x33CD2A0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringBoneApplyJob>.EndInvoke
	|
	|-RVA: 0x33CD6C0 Offset: 0x33CD7C1 VA: 0x33CD6C0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringColliderJob>.EndInvoke
	|
	|-RVA: 0x33CDF00 Offset: 0x33CE001 VA: 0x33CDF00
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringLengthTargetJob>.EndInvoke
	|
	|-RVA: 0x33CE320 Offset: 0x33CE421 VA: 0x33CE320
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringParentJob>.EndInvoke
	|
	|-RVA: 0x33CE740 Offset: 0x33CE841 VA: 0x33CE740
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct.ExecuteJobFunction<SpringPivotJob>.EndInvoke
	*/
}

// Namespace: 
internal struct IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T> // TypeDefIndex: 3676
{
	// Fields
	public static IntPtr jobReflectionData; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static IntPtr Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35702E0 Offset: 0x35703E1 VA: 0x35702E0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<SpringBoneApplyJob>.Initialize
	|
	|-RVA: 0x35706D0 Offset: 0x35707D1 VA: 0x35706D0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<SpringColliderJob>.Initialize
	|
	|-RVA: 0x3570AC0 Offset: 0x3570BC1 VA: 0x3570AC0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<SpringLengthTargetJob>.Initialize
	|
	|-RVA: 0x3570EB0 Offset: 0x3570FB1 VA: 0x3570EB0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<SpringParentJob>.Initialize
	|
	|-RVA: 0x35712A0 Offset: 0x35713A1 VA: 0x35712A0
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<SpringPivotJob>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static void Execute(ref T jobData, IntPtr jobData2, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3570540 Offset: 0x3570641 VA: 0x3570540
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<SpringBoneApplyJob>.Execute
	|
	|-RVA: 0x3570930 Offset: 0x3570A31 VA: 0x3570930
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<SpringColliderJob>.Execute
	|
	|-RVA: 0x3570D20 Offset: 0x3570E21 VA: 0x3570D20
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<SpringLengthTargetJob>.Execute
	|
	|-RVA: 0x3571110 Offset: 0x3571211 VA: 0x3571110
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<SpringParentJob>.Execute
	|
	|-RVA: 0x3571500 Offset: 0x3571601 VA: 0x3571500
	|-IJobParallelForTransformExtensions.TransformParallelForLoopStruct<SpringPivotJob>.Execute
	*/
}

