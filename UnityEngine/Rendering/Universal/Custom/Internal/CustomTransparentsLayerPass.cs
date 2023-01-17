// Namespace: UnityEngine.Rendering.Universal.Custom.Internal
public sealed class CustomTransparentsLayerPass : ScriptableRenderPass // TypeDefIndex: 5460
{
	// Fields
	private FilteringSettings m_FilteringSettings; // 0x70
	private ShaderTagId m_ShaderTagId; // 0x88
	private string m_ProfilerTag; // 0x90
	private ProfilingSampler m_ProfilingSampler; // 0x98
	private static readonly int s_DrawObjectPassDataPropID; // 0x0
	private Vector4 m_DrawObjectPassData; // 0xA0

	// Methods

	// RVA: 0x2D34100 Offset: 0x2D34201 VA: 0x2D34100
	public void .ctor(string profilerTag, string shaderTag, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask) { }

	// RVA: 0x2D3B3D0 Offset: 0x2D3B4D1 VA: 0x2D3B3D0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D3B5D0 Offset: 0x2D3B6D1 VA: 0x2D3B5D0
	private static void .cctor() { }
}

