// Namespace: UnityEngine.Rendering.Universal.Internal
public class DrawObjectsPass : ScriptableRenderPass // TypeDefIndex: 5406
{
	// Fields
	private FilteringSettings m_FilteringSettings; // 0x70
	private RenderStateBlock m_RenderStateBlock; // 0x88
	private List<ShaderTagId> m_ShaderTagIdList; // 0xF8
	private string m_ProfilerTag; // 0x100
	private ProfilingSampler m_ProfilingSampler; // 0x108
	private bool m_IsOpaque; // 0x110
	private static readonly int s_DrawObjectPassDataPropID; // 0x0

	// Methods

	// RVA: 0x3140750 Offset: 0x3140851 VA: 0x3140750
	public void .ctor(string profilerTag, ShaderTagId[] shaderTagIds, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	// RVA: 0x3140A50 Offset: 0x3140B51 VA: 0x3140A50
	public void .ctor(string profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	// RVA: 0x3140C10 Offset: 0x3140D11 VA: 0x3140C10
	internal void .ctor(URPProfileId profileId, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	// RVA: 0x3140D20 Offset: 0x3140E21 VA: 0x3140D20 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x3141040 Offset: 0x3141141 VA: 0x3141040
	private static void .cctor() { }
}

