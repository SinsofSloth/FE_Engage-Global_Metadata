// Namespace: UnityEngine.Rendering.Universal.Internal
public class CopyDepthPass : ScriptableRenderPass // TypeDefIndex: 5402
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x4831F0 Offset: 0x4832F1 VA: 0x4831F0
	private RenderTargetHandle <source>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x483200 Offset: 0x483301 VA: 0x483200
	private RenderTargetHandle <destination>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x483210 Offset: 0x483311 VA: 0x483210
	private bool <AllocateRT>k__BackingField; // 0xD0
	private Material m_CopyDepthMaterial; // 0xD8

	// Properties
	private RenderTargetHandle source { get; set; }
	private RenderTargetHandle destination { get; set; }
	internal bool AllocateRT { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x484CB0 Offset: 0x484DB1 VA: 0x484CB0
	// RVA: 0x2D2DA20 Offset: 0x2D2DB21 VA: 0x2D2DA20
	private RenderTargetHandle get_source() { }

	[CompilerGeneratedAttribute] // RVA: 0x484CC0 Offset: 0x484DC1 VA: 0x484CC0
	// RVA: 0x2D2DA40 Offset: 0x2D2DB41 VA: 0x2D2DA40
	private void set_source(RenderTargetHandle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484CD0 Offset: 0x484DD1 VA: 0x484CD0
	// RVA: 0x2D2DA60 Offset: 0x2D2DB61 VA: 0x2D2DA60
	private RenderTargetHandle get_destination() { }

	[CompilerGeneratedAttribute] // RVA: 0x484CE0 Offset: 0x484DE1 VA: 0x484CE0
	// RVA: 0x2D2DA80 Offset: 0x2D2DB81 VA: 0x2D2DA80
	private void set_destination(RenderTargetHandle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484CF0 Offset: 0x484DF1 VA: 0x484CF0
	// RVA: 0x2D2DAA0 Offset: 0x2D2DBA1 VA: 0x2D2DAA0
	internal bool get_AllocateRT() { }

	[CompilerGeneratedAttribute] // RVA: 0x484D00 Offset: 0x484E01 VA: 0x484D00
	// RVA: 0x2D2DAB0 Offset: 0x2D2DBB1 VA: 0x2D2DAB0
	internal void set_AllocateRT(bool value) { }

	// RVA: 0x2D2DAC0 Offset: 0x2D2DBC1 VA: 0x2D2DAC0
	public void .ctor(RenderPassEvent evt, Material copyDepthMaterial) { }

	// RVA: 0x2D2DB80 Offset: 0x2D2DC81 VA: 0x2D2DB80
	public void Setup(RenderTargetHandle source, RenderTargetHandle destination) { }

	// RVA: 0x2D2DBE0 Offset: 0x2D2DCE1 VA: 0x2D2DBE0 Slot: 5
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2D2DD70 Offset: 0x2D2DE71 VA: 0x2D2DD70 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D2E5D0 Offset: 0x2D2E6D1 VA: 0x2D2E5D0 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }
}

