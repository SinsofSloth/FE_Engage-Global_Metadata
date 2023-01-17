// Namespace: UnityEngine.Rendering.Universal.Custom
public sealed class StatusModelRenderer : ScriptableRenderer // TypeDefIndex: 5441
{
	// Fields
	private const int k_DepthStencilBufferBits = 32;
	private const string k_CreateCameraTextures = "Create Camera Texture";
	private const string k_SubLightTag = "StatusCharaLight";
	private const string k_SetupCustomRPConstants = "Setup CustomRP Constants";
	private static readonly int s_CustomExposurePropID; // 0x0
	private static readonly int s_CustomLodFadeBiasPropID; // 0x4
	private CopyDepthPass m_CopyDepthPass; // 0x90
	private CopyColorPass m_CopyColorPass; // 0x98
	private CustomBaseOpaquePass m_CustomBaseOpaquePass; // 0xA0
	private CustomCharaOpaquePass m_CustomCharaOpaquePass; // 0xA8
	private CustomBaseTransparentPass m_RenderTransparentForwardPass; // 0xB0
	private CustomTransCharaMaskPass m_CustomTransCharaMaskPass; // 0xB8
	private PostProcessPass m_PostProcessPass; // 0xC0
	private PostProcessPass m_FinalPostProcessPass; // 0xC8
	private FinalBlitPass m_FinalBlitPass; // 0xD0
	private CustomMixedResolutionPass m_CustomMixedResolutionPass; // 0xD8
	private RenderTargetHandle m_ActiveCameraColorAttachment; // 0xE0
	private RenderTargetHandle m_ActiveCameraDepthAttachment; // 0x110
	private RenderTargetHandle m_CameraColorAttachment; // 0x140
	private RenderTargetHandle m_CameraDepthAttachment; // 0x170
	private RenderTargetHandle m_DepthTexture; // 0x1A0
	private RenderTargetHandle m_OpaqueColor; // 0x1D0
	private RenderTargetHandle m_AfterPostProcessColor; // 0x200
	private RenderTargetHandle m_ColorGradingLut; // 0x230
	private ForwardLights m_ForwardLights; // 0x260
	private Material m_BlitMaterial; // 0x268
	private Material m_CopyDepthMaterial; // 0x270
	private Material m_SamplingMaterial; // 0x278
	private Material m_DownsampleDepthMaterial; // 0x280
	private Material m_HalfResoCompositeMaterial; // 0x288

	// Methods

	// RVA: 0x3135B00 Offset: 0x3135C01 VA: 0x3135B00
	public void .ctor(StatusModelRendererData data) { }

	// RVA: 0x3136120 Offset: 0x3136221 VA: 0x3136120 Slot: 10
	public override string GetSubLightTag() { }

	// RVA: 0x3136170 Offset: 0x3136271 VA: 0x3136170 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3136220 Offset: 0x3136321 VA: 0x3136220 Slot: 6
	public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x3137150 Offset: 0x3137251 VA: 0x3137150 Slot: 7
	public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x3137270 Offset: 0x3137371 VA: 0x3137270 Slot: 8
	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	// RVA: 0x31373E0 Offset: 0x31374E1 VA: 0x31373E0 Slot: 9
	public override void FinishRendering(CommandBuffer cmd) { }

	// RVA: 0x3136CF0 Offset: 0x3136DF1 VA: 0x3136CF0
	private void CreateCameraRenderTarget(ScriptableRenderContext context, ref CameraData cameraData) { }

	// RVA: 0x3136C80 Offset: 0x3136D81 VA: 0x3136C80
	private bool RequiresIntermediateColorTexture(ref RenderingData renderingData, RenderTextureDescriptor baseDescriptor) { }

	// RVA: 0x3137600 Offset: 0x3137701 VA: 0x3137600
	private static void .cctor() { }
}

