// Namespace: UnityEngine.Rendering.Universal.Internal
internal class TileDepthRangePass : ScriptableRenderPass // TypeDefIndex: 5418
{
	// Fields
	private DeferredLights m_DeferredLights; // 0x70
	private int m_PassIndex; // 0x78

	// Methods

	// RVA: 0x2F8FFB0 Offset: 0x2F900B1 VA: 0x2F8FFB0
	public void .ctor(RenderPassEvent evt, DeferredLights deferredLights, int passIndex) { }

	// RVA: 0x2F90080 Offset: 0x2F90181 VA: 0x2F90080 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x2F901F0 Offset: 0x2F902F1 VA: 0x2F901F0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2F90210 Offset: 0x2F90311 VA: 0x2F90210 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }
}

