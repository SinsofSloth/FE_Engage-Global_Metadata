// Namespace: UnityEngine.Rendering.Universal.Internal
public class ColorGradingLutPass : ScriptableRenderPass // TypeDefIndex: 5400
{
	// Fields
	private readonly Material m_LutBuilderLdr; // 0x70
	private readonly Material m_LutBuilderHdr; // 0x78
	private readonly GraphicsFormat m_HdrLutFormat; // 0x80
	private readonly GraphicsFormat m_LdrLutFormat; // 0x84
	private RenderTargetHandle m_InternalLut; // 0x88
	private readonly HableCurve m_HableCurve; // 0xB8

	// Methods

	// RVA: 0x2D2AE50 Offset: 0x2D2AF51 VA: 0x2D2AE50
	public void .ctor(RenderPassEvent evt, PostProcessData data) { }

	// RVA: 0x2D2B130 Offset: 0x2D2B231 VA: 0x2D2B130
	public void Setup(in RenderTargetHandle internalLut) { }

	// RVA: 0x2D2B150 Offset: 0x2D2B251 VA: 0x2D2B150 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D2C380 Offset: 0x2D2C481 VA: 0x2D2C380 Slot: 8
	public override void OnFinishCameraStackRendering(CommandBuffer cmd) { }

	// RVA: 0x2D2C3A0 Offset: 0x2D2C4A1 VA: 0x2D2C3A0
	public void Cleanup() { }

	[CompilerGeneratedAttribute] // RVA: 0x484C60 Offset: 0x484D61 VA: 0x484C60
	// RVA: 0x2D2AFD0 Offset: 0x2D2B0D1 VA: 0x2D2AFD0
	private Material <.ctor>g__Load|6_0(Shader shader) { }
}

