// Namespace: UnityEngine.Rendering
[UsedByNativeCodeAttribute] // RVA: 0x440BD0 Offset: 0x440CD1 VA: 0x440BD0
[NativeHeaderAttribute] // RVA: 0x440BD0 Offset: 0x440CD1 VA: 0x440BD0
internal struct BatchRendererCullingOutput // TypeDefIndex: 3925
{
	// Fields
	public JobHandle cullingJobsFence; // 0x0
	public Matrix4x4 cullingMatrix; // 0x10
	public Plane* cullingPlanes; // 0x50
	public BatchVisibility* batchVisibility; // 0x58
	public int* visibleIndices; // 0x60
	public int* visibleIndicesY; // 0x68
	public int cullingPlanesCount; // 0x70
	public int batchVisibilityCount; // 0x74
	public int visibleIndicesCount; // 0x78
	public float nearPlane; // 0x7C
}

