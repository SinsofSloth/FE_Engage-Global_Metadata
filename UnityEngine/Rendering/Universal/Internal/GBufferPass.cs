// Namespace: UnityEngine.Rendering.Universal.Internal
internal class GBufferPass : ScriptableRenderPass // TypeDefIndex: 5408
{
	// Fields
	private static ShaderTagId s_ShaderTagLit; // 0x0
	private static ShaderTagId s_ShaderTagSimpleLit; // 0x4
	private static ShaderTagId s_ShaderTagUnlit; // 0x8
	private static ShaderTagId s_ShaderTagUniversalGBuffer; // 0xC
	private static ShaderTagId s_ShaderTagUniversalMaterialType; // 0x10
	private ProfilingSampler m_ProfilingSampler; // 0x70
	private DeferredLights m_DeferredLights; // 0x78
	private ShaderTagId[] m_ShaderTagValues; // 0x80
	private RenderStateBlock[] m_RenderStateBlocks; // 0x88
	private FilteringSettings m_FilteringSettings; // 0x90
	private RenderStateBlock m_RenderStateBlock; // 0xA8

	// Methods

	// RVA: 0x3145200 Offset: 0x3145301 VA: 0x3145200
	public void .ctor(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference, DeferredLights deferredLights) { }

	// RVA: 0x3148380 Offset: 0x3148481 VA: 0x3148380 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x3148510 Offset: 0x3148611 VA: 0x3148510 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x31487C0 Offset: 0x31488C1 VA: 0x31487C0 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x3148870 Offset: 0x3148971 VA: 0x3148870
	private static void .cctor() { }
}

