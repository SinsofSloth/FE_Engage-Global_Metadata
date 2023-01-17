// Namespace: UnityEngine.Rendering.Universal.Internal
public class ScreenSpaceShadowResolvePass : ScriptableRenderPass // TypeDefIndex: 5417
{
	// Fields
	private Material m_ScreenSpaceShadowsMaterial; // 0x70
	private RenderTargetHandle m_ScreenSpaceShadowmap; // 0x78
	private RenderTextureDescriptor m_RenderTextureDescriptor; // 0xA8

	// Methods

	// RVA: 0x3126AB0 Offset: 0x3126BB1 VA: 0x3126AB0
	public void .ctor(RenderPassEvent evt, Material screenspaceShadowsMaterial) { }

	// RVA: 0x3126B90 Offset: 0x3126C91 VA: 0x3126B90
	public void Setup(RenderTextureDescriptor baseDescriptor) { }

	// RVA: 0x3126C50 Offset: 0x3126D51 VA: 0x3126C50 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x3126E50 Offset: 0x3126F51 VA: 0x3126E50 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x3127500 Offset: 0x3127601 VA: 0x3127500 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }
}

