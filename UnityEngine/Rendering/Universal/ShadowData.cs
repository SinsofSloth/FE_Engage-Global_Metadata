// Namespace: UnityEngine.Rendering.Universal
[MovedFromAttribute] // RVA: 0x47FE60 Offset: 0x47FF61 VA: 0x47FE60
public struct ShadowData // TypeDefIndex: 5365
{
	// Fields
	public bool supportsMainLightShadows; // 0x0
	public bool requiresScreenSpaceShadowResolve; // 0x1
	public int mainLightShadowmapWidth; // 0x4
	public int mainLightShadowmapHeight; // 0x8
	public int mainLightShadowCascadesCount; // 0xC
	public Vector3 mainLightShadowCascadesSplit; // 0x10
	public bool supportsAdditionalLightShadows; // 0x1C
	public int additionalLightsShadowmapWidth; // 0x20
	public int additionalLightsShadowmapHeight; // 0x24
	public bool supportsSoftShadows; // 0x28
	public int shadowmapDepthBufferBits; // 0x2C
	public List<Vector4> bias; // 0x30
}

