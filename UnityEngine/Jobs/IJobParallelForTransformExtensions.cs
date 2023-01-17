// Namespace: UnityEngine.Jobs
[ExtensionAttribute] // RVA: 0x43F800 Offset: 0x43F901 VA: 0x43F800
public static class IJobParallelForTransformExtensions // TypeDefIndex: 3677
{
	// Methods

	[ExtensionAttribute] // RVA: 0x452530 Offset: 0x452631 VA: 0x452530
	// RVA: -1 Offset: -1
	public static JobHandle Schedule<T>(T jobData, TransformAccessArray transforms, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2959930 Offset: 0x2959A31 VA: 0x2959930
	|-IJobParallelForTransformExtensions.Schedule<SpringBoneApplyJob>
	|
	|-RVA: 0x29599C0 Offset: 0x2959AC1 VA: 0x29599C0
	|-IJobParallelForTransformExtensions.Schedule<SpringColliderJob>
	|
	|-RVA: 0x2959A50 Offset: 0x2959B51 VA: 0x2959A50
	|-IJobParallelForTransformExtensions.Schedule<SpringLengthTargetJob>
	|
	|-RVA: 0x2959AE0 Offset: 0x2959BE1 VA: 0x2959AE0
	|-IJobParallelForTransformExtensions.Schedule<SpringParentJob>
	|
	|-RVA: 0x2959B70 Offset: 0x2959C71 VA: 0x2959B70
	|-IJobParallelForTransformExtensions.Schedule<SpringPivotJob>
	*/
}

