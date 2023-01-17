// Namespace: UnityEngine.Rendering.Universal
[MovedFromAttribute] // RVA: 0x47FDE0 Offset: 0x47FEE1 VA: 0x47FDE0
public struct LightData // TypeDefIndex: 5363
{
	// Fields
	public int mainLightIndex; // 0x0
	public int additionalLightsCount; // 0x4
	public int maxPerObjectAdditionalLightsCount; // 0x8
	public NativeArray<VisibleLight> visibleLights; // 0x10
	public bool shadeAdditionalLightsPerVertex; // 0x20
	public bool supportsMixedLighting; // 0x21
	public int subLightIndex; // 0x24
	public int customShadowLightIndex; // 0x28
}

