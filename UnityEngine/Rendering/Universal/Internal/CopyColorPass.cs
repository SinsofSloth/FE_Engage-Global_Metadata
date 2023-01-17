// Namespace: UnityEngine.Rendering.Universal.Internal
public class CopyColorPass : ScriptableRenderPass // TypeDefIndex: 5401
{
	// Fields
	private int m_SampleOffsetShaderHandle; // 0x70
	private Material m_SamplingMaterial; // 0x78
	private Downsampling m_DownsamplingMethod; // 0x80
	private Material m_CopyColorMaterial; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x4831D0 Offset: 0x4832D1 VA: 0x4831D0
	private RenderTargetIdentifier <source>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x4831E0 Offset: 0x4832E1 VA: 0x4831E0
	private RenderTargetHandle <destination>k__BackingField; // 0xB8

	// Properties
	private RenderTargetIdentifier source { get; set; }
	private RenderTargetHandle destination { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x484C70 Offset: 0x484D71 VA: 0x484C70
	// RVA: 0x2D2CDF0 Offset: 0x2D2CEF1 VA: 0x2D2CDF0
	private RenderTargetIdentifier get_source() { }

	[CompilerGeneratedAttribute] // RVA: 0x484C80 Offset: 0x484D81 VA: 0x484C80
	// RVA: 0x2D2CE10 Offset: 0x2D2CF11 VA: 0x2D2CE10
	private void set_source(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484C90 Offset: 0x484D91 VA: 0x484C90
	// RVA: 0x2D2CE30 Offset: 0x2D2CF31 VA: 0x2D2CE30
	private RenderTargetHandle get_destination() { }

	[CompilerGeneratedAttribute] // RVA: 0x484CA0 Offset: 0x484DA1 VA: 0x484CA0
	// RVA: 0x2D2CE50 Offset: 0x2D2CF51 VA: 0x2D2CE50
	private void set_destination(RenderTargetHandle value) { }

	// RVA: 0x2D2CE70 Offset: 0x2D2CF71 VA: 0x2D2CE70
	public void .ctor(RenderPassEvent evt, Material samplingMaterial, Material copyColorMaterial) { }

	// RVA: 0x2D2CF70 Offset: 0x2D2D071 VA: 0x2D2CF70
	public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination, Downsampling downsampling) { }

	// RVA: 0x2D2CFC0 Offset: 0x2D2D0C1 VA: 0x2D2CFC0 Slot: 5
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2D2D170 Offset: 0x2D2D271 VA: 0x2D2D170 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D2D8A0 Offset: 0x2D2D9A1 VA: 0x2D2D8A0 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }
}

