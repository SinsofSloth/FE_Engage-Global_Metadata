// Namespace: UnityEngine.Rendering
[FlagsAttribute] // RVA: 0x440D70 Offset: 0x440E71 VA: 0x440D70
public enum CullingOptions // TypeDefIndex: 3934
{
	// Fields
	public int value__; // 0x0
	public const CullingOptions None = 0;
	public const CullingOptions ForceEvenIfCameraIsNotActive = 1;
	public const CullingOptions OcclusionCull = 2;
	public const CullingOptions NeedsLighting = 4;
	public const CullingOptions NeedsReflectionProbes = 8;
	public const CullingOptions Stereo = 16;
	public const CullingOptions DisablePerObjectCulling = 32;
	public const CullingOptions ShadowCasters = 64;
}

