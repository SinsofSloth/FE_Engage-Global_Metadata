// Namespace: UnityEngine.Rendering
[NativeHeaderAttribute] // RVA: 0x440B80 Offset: 0x440C81 VA: 0x440B80
[UsedByNativeCodeAttribute] // RVA: 0x440B80 Offset: 0x440C81 VA: 0x440B80
public struct BatchCullingContext // TypeDefIndex: 3924
{
	// Fields
	public readonly NativeArray<Plane> cullingPlanes; // 0x0
	public NativeArray<BatchVisibility> batchVisibility; // 0x10
	public NativeArray<int> visibleIndices; // 0x20
	public NativeArray<int> visibleIndicesY; // 0x30
	public readonly LODParameters lodParameters; // 0x40
	public readonly Matrix4x4 cullingMatrix; // 0x5C
	public readonly float nearPlane; // 0x9C

	// Methods

	// RVA: 0x2F0B7B0 Offset: 0x2F0B8B1 VA: 0x2F0B7B0
	internal void .ctor(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, NativeArray<int> outVisibleIndicesY, LODParameters inLodParameters, Matrix4x4 inCullingMatrix, float inNearPlane) { }
}

