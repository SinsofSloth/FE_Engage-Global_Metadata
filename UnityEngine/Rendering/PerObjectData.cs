// Namespace: UnityEngine.Rendering
[FlagsAttribute] // RVA: 0x440EF0 Offset: 0x440FF1 VA: 0x440EF0
public enum PerObjectData // TypeDefIndex: 3947
{
	// Fields
	public int value__; // 0x0
	public const PerObjectData None = 0;
	public const PerObjectData LightProbe = 1;
	public const PerObjectData ReflectionProbes = 2;
	public const PerObjectData LightProbeProxyVolume = 4;
	public const PerObjectData Lightmaps = 8;
	public const PerObjectData LightData = 16;
	public const PerObjectData MotionVectors = 32;
	public const PerObjectData LightIndices = 64;
	public const PerObjectData ReflectionProbeData = 128;
	public const PerObjectData OcclusionProbe = 256;
	public const PerObjectData OcclusionProbeProxyVolume = 512;
	public const PerObjectData ShadowMask = 1024;
}

