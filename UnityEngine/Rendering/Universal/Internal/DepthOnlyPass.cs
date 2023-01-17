// Namespace: UnityEngine.Rendering.Universal.Internal
public class DepthOnlyPass : ScriptableRenderPass // TypeDefIndex: 5405
{
	// Fields
	private int kDepthBufferBits; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x483260 Offset: 0x483361 VA: 0x483260
	private RenderTargetHandle <depthAttachmentHandle>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x483270 Offset: 0x483371 VA: 0x483270
	private RenderTextureDescriptor <descriptor>k__BackingField; // 0xA8
	private FilteringSettings m_FilteringSettings; // 0xDC
	private ShaderTagId m_ShaderTagId; // 0xF4
	private List<ShaderTagId> m_ShaderTagIdList; // 0xF8

	// Properties
	private RenderTargetHandle depthAttachmentHandle { get; set; }
	internal RenderTextureDescriptor descriptor { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x484D90 Offset: 0x484E91 VA: 0x484D90
	// RVA: 0x313FBE0 Offset: 0x313FCE1 VA: 0x313FBE0
	private RenderTargetHandle get_depthAttachmentHandle() { }

	[CompilerGeneratedAttribute] // RVA: 0x484DA0 Offset: 0x484EA1 VA: 0x484DA0
	// RVA: 0x313FC00 Offset: 0x313FD01 VA: 0x313FC00
	private void set_depthAttachmentHandle(RenderTargetHandle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484DB0 Offset: 0x484EB1 VA: 0x484DB0
	// RVA: 0x313FC20 Offset: 0x313FD21 VA: 0x313FC20
	internal RenderTextureDescriptor get_descriptor() { }

	[CompilerGeneratedAttribute] // RVA: 0x484DC0 Offset: 0x484EC1 VA: 0x484DC0
	// RVA: 0x313FC50 Offset: 0x313FD51 VA: 0x313FC50
	private void set_descriptor(RenderTextureDescriptor value) { }

	// RVA: 0x313FC70 Offset: 0x313FD71 VA: 0x313FC70
	public void .ctor(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask) { }

	// RVA: 0x313FF70 Offset: 0x3140071 VA: 0x313FF70
	public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle depthAttachmentHandle) { }

	// RVA: 0x313FFE0 Offset: 0x31400E1 VA: 0x313FFE0 Slot: 5
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x3140100 Offset: 0x3140201 VA: 0x3140100 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x3140340 Offset: 0x3140441 VA: 0x3140340 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }
}

