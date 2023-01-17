// Namespace: UTJ.Jobs
[BurstCompileAttribute] // RVA: 0x5B560 Offset: 0x5B661 VA: 0x5B560
public struct SpringPivotJob : IJobParallelForTransform // TypeDefIndex: 6459
{
	// Fields
	[ReadOnlyAttribute] // RVA: 0x5BFD0 Offset: 0x5C0D1 VA: 0x5BFD0
	public NativeArray<SpringBoneProperties> properties; // 0x0
	[WriteOnlyAttribute] // RVA: 0x5BFE0 Offset: 0x5C0E1 VA: 0x5BFE0
	public NativeArray<float4x4> components; // 0x10

	// Methods

	// RVA: 0x3A75C30 Offset: 0x3A75D31 VA: 0x3A75C30 Slot: 4
	private void UnityEngine.Jobs.IJobParallelForTransform.Execute(int index, TransformAccess transform) { }
}

