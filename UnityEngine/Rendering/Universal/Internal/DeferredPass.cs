// Namespace: UnityEngine.Rendering.Universal.Internal
internal class DeferredPass : ScriptableRenderPass // TypeDefIndex: 5403
{
	// Fields
	private DeferredLights m_DeferredLights; // 0x70

	// Methods

	// RVA: 0x313BA30 Offset: 0x313BB31 VA: 0x313BA30
	public void .ctor(RenderPassEvent evt, DeferredLights deferredLights) { }

	// RVA: 0x313BAF0 Offset: 0x313BBF1 VA: 0x313BAF0 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescripor) { }

	// RVA: 0x313BBB0 Offset: 0x313BCB1 VA: 0x313BBB0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x313BBC0 Offset: 0x313BCC1 VA: 0x313BBC0 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }
}

