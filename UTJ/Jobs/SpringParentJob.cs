// Namespace: UTJ.Jobs
[BurstCompileAttribute] // RVA: 0x5B550 Offset: 0x5B651 VA: 0x5B550
public struct SpringParentJob : IJobParallelForTransform // TypeDefIndex: 6458
{
	// Fields
	[ReadOnlyAttribute] // RVA: 0x5BFB0 Offset: 0x5C0B1 VA: 0x5BFB0
	public NativeArray<SpringBoneProperties> properties; // 0x0
	[WriteOnlyAttribute] // RVA: 0x5BFC0 Offset: 0x5C0C1 VA: 0x5BFC0
	public NativeArray<float4x4> components; // 0x10

	// Methods

	// RVA: 0x3A75AD0 Offset: 0x3A75BD1 VA: 0x3A75AD0 Slot: 4
	private void UnityEngine.Jobs.IJobParallelForTransform.Execute(int index, TransformAccess transform) { }
}

