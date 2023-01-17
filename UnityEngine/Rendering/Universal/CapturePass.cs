// Namespace: UnityEngine.Rendering.Universal
internal class CapturePass : ScriptableRenderPass // TypeDefIndex: 5312
{
	// Fields
	private RenderTargetHandle m_CameraColorHandle; // 0x70
	private const string m_ProfilerTag = "Capture Pass";
	private static readonly ProfilingSampler m_ProfilingSampler; // 0x0

	// Methods

	// RVA: 0x2D29AD0 Offset: 0x2D29BD1 VA: 0x2D29AD0
	public void .ctor(RenderPassEvent evt) { }

	// RVA: 0x2D29B80 Offset: 0x2D29C81 VA: 0x2D29B80
	public void Setup(RenderTargetHandle colorHandle) { }

	// RVA: 0x2D29BA0 Offset: 0x2D29CA1 VA: 0x2D29BA0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D29EB0 Offset: 0x2D29FB1 VA: 0x2D29EB0
	private static void .cctor() { }
}

