// Namespace: UnityEngine.Rendering.Universal.Internal
public class DepthNormalOnlyPass : ScriptableRenderPass // TypeDefIndex: 5404
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x483220 Offset: 0x483321 VA: 0x483220
	private RenderTextureDescriptor <normalDescriptor>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x483230 Offset: 0x483331 VA: 0x483230
	private RenderTextureDescriptor <depthDescriptor>k__BackingField; // 0xA4
	[CompilerGeneratedAttribute] // RVA: 0x483240 Offset: 0x483341 VA: 0x483240
	private RenderTargetHandle <depthHandle>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x483250 Offset: 0x483351 VA: 0x483250
	private RenderTargetHandle <normalHandle>k__BackingField; // 0x108
	private ShaderTagId m_ShaderTagId; // 0x138
	private FilteringSettings m_FilteringSettings; // 0x13C
	private const int k_DepthBufferBits = 32;

	// Properties
	internal RenderTextureDescriptor normalDescriptor { get; set; }
	internal RenderTextureDescriptor depthDescriptor { get; set; }
	private RenderTargetHandle depthHandle { get; set; }
	private RenderTargetHandle normalHandle { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x484D10 Offset: 0x484E11 VA: 0x484D10
	// RVA: 0x313EEA0 Offset: 0x313EFA1 VA: 0x313EEA0
	internal RenderTextureDescriptor get_normalDescriptor() { }

	[CompilerGeneratedAttribute] // RVA: 0x484D20 Offset: 0x484E21 VA: 0x484D20
	// RVA: 0x313EED0 Offset: 0x313EFD1 VA: 0x313EED0
	private void set_normalDescriptor(RenderTextureDescriptor value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484D30 Offset: 0x484E31 VA: 0x484D30
	// RVA: 0x313EEF0 Offset: 0x313EFF1 VA: 0x313EEF0
	internal RenderTextureDescriptor get_depthDescriptor() { }

	[CompilerGeneratedAttribute] // RVA: 0x484D40 Offset: 0x484E41 VA: 0x484D40
	// RVA: 0x313EF30 Offset: 0x313F031 VA: 0x313EF30
	private void set_depthDescriptor(RenderTextureDescriptor value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484D50 Offset: 0x484E51 VA: 0x484D50
	// RVA: 0x313EF50 Offset: 0x313F051 VA: 0x313EF50
	private RenderTargetHandle get_depthHandle() { }

	[CompilerGeneratedAttribute] // RVA: 0x484D60 Offset: 0x484E61 VA: 0x484D60
	// RVA: 0x313EF70 Offset: 0x313F071 VA: 0x313EF70
	private void set_depthHandle(RenderTargetHandle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484D70 Offset: 0x484E71 VA: 0x484D70
	// RVA: 0x313EF90 Offset: 0x313F091 VA: 0x313EF90
	private RenderTargetHandle get_normalHandle() { }

	[CompilerGeneratedAttribute] // RVA: 0x484D80 Offset: 0x484E81 VA: 0x484D80
	// RVA: 0x313EFB0 Offset: 0x313F0B1 VA: 0x313EFB0
	private void set_normalHandle(RenderTargetHandle value) { }

	// RVA: 0x313EFD0 Offset: 0x313F0D1 VA: 0x313EFD0
	public void .ctor(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask) { }

	// RVA: 0x313F140 Offset: 0x313F241 VA: 0x313F140
	public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle depthHandle, RenderTargetHandle normalHandle) { }

	// RVA: 0x313F210 Offset: 0x313F311 VA: 0x313F210 Slot: 5
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x313F420 Offset: 0x313F521 VA: 0x313F420 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x313F5F0 Offset: 0x313F6F1 VA: 0x313F5F0 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }
}

