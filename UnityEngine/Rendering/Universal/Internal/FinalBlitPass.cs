// Namespace: UnityEngine.Rendering.Universal.Internal
public class FinalBlitPass : ScriptableRenderPass // TypeDefIndex: 5407
{
	// Fields
	private RenderTargetHandle m_Source; // 0x70
	private Material m_BlitMaterial; // 0xA0
	private Vector4 m_CustomFinalMonoColor; // 0xA8
	private static readonly int s_CustomFinalMonoColorProp; // 0x0

	// Methods

	// RVA: 0x31417A0 Offset: 0x31418A1 VA: 0x31417A0
	public void SetCustomFinalMonoColorToResult(Color color, float ratio) { }

	// RVA: 0x3141800 Offset: 0x3141901 VA: 0x3141800
	public void .ctor(RenderPassEvent evt, Material blitMaterial) { }

	// RVA: 0x31418D0 Offset: 0x31419D1 VA: 0x31418D0
	public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle) { }

	// RVA: 0x31418F0 Offset: 0x31419F1 VA: 0x31418F0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x3142460 Offset: 0x3142561 VA: 0x3142460
	private static void .cctor() { }
}

