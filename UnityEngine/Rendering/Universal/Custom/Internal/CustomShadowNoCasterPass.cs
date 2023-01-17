// Namespace: UnityEngine.Rendering.Universal.Custom.Internal
public sealed class CustomShadowNoCasterPass : ScriptableRenderPass // TypeDefIndex: 5457
{
	// Fields
	private const int k_MaxCascades = 1;
	private const int k_ShadowmapBufferBits = 16;
	private const int k_ShadowmapWidth = 8;
	private const int k_ShadowmapHeight = 8;
	private RenderTargetHandle m_CustomShadowmap; // 0x70
	private RenderTexture m_CustomShadowmapTexture; // 0xA0
	private Matrix4x4[] m_CustomShadowMatrices; // 0xA8
	private const string m_ProfilerTag = "Render Custom Shadowmap";
	private ProfilingSampler m_ProfilingSampler; // 0xB0

	// Methods

	// RVA: 0x2D33E20 Offset: 0x2D33F21 VA: 0x2D33E20
	public void .ctor(RenderPassEvent evt) { }

	// RVA: 0x2D3A380 Offset: 0x2D3A481 VA: 0x2D3A380 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x2D3A470 Offset: 0x2D3A571 VA: 0x2D3A470 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D3A8B0 Offset: 0x2D3A9B1 VA: 0x2D3A8B0 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x2D3A9B0 Offset: 0x2D3AAB1 VA: 0x2D3A9B0
	private void Clear() { }
}

