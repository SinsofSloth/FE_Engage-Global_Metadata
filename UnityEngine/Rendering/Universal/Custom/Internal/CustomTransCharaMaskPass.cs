// Namespace: UnityEngine.Rendering.Universal.Custom.Internal
public sealed class CustomTransCharaMaskPass : ScriptableRenderPass // TypeDefIndex: 5459
{
	// Fields
	private const string m_ProfilerTag = "Custom TransCharaMask Pass";
	private ProfilingSampler m_ProfilingSampler; // 0x70
	private FilteringSettings m_FilteringSettings; // 0x78
	private ShaderTagId m_ShaderTagId; // 0x90
	private RenderTargetHandle m_DepthDestination; // 0x98

	// Methods

	// RVA: 0x2D3B010 Offset: 0x2D3B111 VA: 0x2D3B010
	public void .ctor(RenderPassEvent evt, LayerMask layerMask) { }

	// RVA: 0x2D3B1A0 Offset: 0x2D3B2A1 VA: 0x2D3B1A0
	public void Setup(RenderTargetHandle depthDestination) { }

	// RVA: 0x2D3B1C0 Offset: 0x2D3B2C1 VA: 0x2D3B1C0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }
}

