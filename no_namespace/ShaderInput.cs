// Namespace: 
[GenerateHLSL] // RVA: 0x8D490 Offset: 0x8D591 VA: 0x8D490
public struct ShaderInput.LightData // TypeDefIndex: 4785
{
	// Fields
	public Vector4 position; // 0x0
	public Vector4 color; // 0x10
	public Vector4 attenuation; // 0x20
	public Vector4 spotDirection; // 0x30
	public Vector4 occlusionProbeChannels; // 0x40
}

// Namespace: 
[GenerateHLSL] // RVA: 0x8D4E0 Offset: 0x8D5E1 VA: 0x8D4E0
public struct ShaderInput.ShadowData // TypeDefIndex: 4786
{
	// Fields
	public Matrix4x4 worldToShadowMatrix; // 0x0
	public Vector4 shadowParams; // 0x40
}

