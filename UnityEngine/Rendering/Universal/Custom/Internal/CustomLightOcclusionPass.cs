// Namespace: UnityEngine.Rendering.Universal.Custom.Internal
public sealed class CustomLightOcclusionPass : ScriptableRenderPass // TypeDefIndex: 5450
{
	// Fields
	private const string k_ProfilerTag = "Custom Light Occlusion";
	private readonly Material m_Material; // 0x70
	private RenderTargetHandle m_Result; // 0x78
	private bool m_DepthTextureEnabled; // 0xA8

	// Methods

	// RVA: 0x2D34070 Offset: 0x2D34171 VA: 0x2D34070
	public void .ctor(RenderPassEvent evt, Material material) { }

	// RVA: 0x2D37830 Offset: 0x2D37931 VA: 0x2D37830 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D37FB0 Offset: 0x2D380B1 VA: 0x2D37FB0 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x2D37FD0 Offset: 0x2D380D1 VA: 0x2D37FD0
	public void SetDepthTextureEnabled(bool flag) { }
}

