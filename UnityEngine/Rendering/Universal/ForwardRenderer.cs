// Namespace: UnityEngine.Rendering.Universal
public sealed class ForwardRenderer : ScriptableRenderer // TypeDefIndex: 5281
{
	// Fields
	private const int k_DepthStencilBufferBits = 32;
	private ColorGradingLutPass m_ColorGradingLutPass; // 0x90
	private DepthOnlyPass m_DepthPrepass; // 0x98
	private DepthNormalOnlyPass m_DepthNormalPrepass; // 0xA0
	private MainLightShadowCasterPass m_MainLightShadowCasterPass; // 0xA8
	private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass; // 0xB0
	private GBufferPass m_GBufferPass; // 0xB8
	private CopyDepthPass m_GBufferCopyDepthPass; // 0xC0
	private TileDepthRangePass m_TileDepthRangePass; // 0xC8
	private TileDepthRangePass m_TileDepthRangeExtraPass; // 0xD0
	private DeferredPass m_DeferredPass; // 0xD8
	private DrawObjectsPass m_RenderOpaqueForwardOnlyPass; // 0xE0
	private DrawObjectsPass m_RenderOpaqueForwardPass; // 0xE8
	private DrawSkyboxPass m_DrawSkyboxPass; // 0xF0
	private CopyDepthPass m_CopyDepthPass; // 0xF8
	private CopyColorPass m_CopyColorPass; // 0x100
	private TransparentSettingsPass m_TransparentSettingsPass; // 0x108
	private DrawObjectsPass m_RenderTransparentForwardPass; // 0x110
	private InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass; // 0x118
	private PostProcessPass m_PostProcessPass; // 0x120
	private PostProcessPass m_FinalPostProcessPass; // 0x128
	private FinalBlitPass m_FinalBlitPass; // 0x130
	private CapturePass m_CapturePass; // 0x138
	private XROcclusionMeshPass m_XROcclusionMeshPass; // 0x140
	private CopyDepthPass m_XRCopyDepthPass; // 0x148
	private RenderTargetHandle m_ActiveCameraColorAttachment; // 0x150
	private RenderTargetHandle m_ActiveCameraDepthAttachment; // 0x180
	private RenderTargetHandle m_CameraColorAttachment; // 0x1B0
	private RenderTargetHandle m_CameraDepthAttachment; // 0x1E0
	private RenderTargetHandle m_DepthTexture; // 0x210
	private RenderTargetHandle m_NormalsTexture; // 0x240
	private RenderTargetHandle[] m_GBufferHandles; // 0x270
	private RenderTargetHandle m_OpaqueColor; // 0x278
	private RenderTargetHandle m_AfterPostProcessColor; // 0x2A8
	private RenderTargetHandle m_ColorGradingLut; // 0x2D8
	private RenderTargetHandle m_DepthInfoTexture; // 0x308
	private RenderTargetHandle m_TileDepthInfoTexture; // 0x338
	private ForwardLights m_ForwardLights; // 0x368
	private DeferredLights m_DeferredLights; // 0x370
	private RenderingMode m_RenderingMode; // 0x378
	private StencilState m_DefaultStencilState; // 0x37C
	private Material m_BlitMaterial; // 0x388
	private Material m_CopyDepthMaterial; // 0x390
	private Material m_SamplingMaterial; // 0x398
	private Material m_ScreenspaceShadowsMaterial; // 0x3A0
	private Material m_TileDepthInfoMaterial; // 0x3A8
	private Material m_TileDeferredMaterial; // 0x3B0
	private Material m_StencilDeferredMaterial; // 0x3B8

	// Properties
	internal RenderingMode renderingMode { get; }
	internal RenderingMode actualRenderingMode { get; }
	internal bool accurateGbufferNormals { get; }

	// Methods

	// RVA: 0x31442C0 Offset: 0x31443C1 VA: 0x31442C0
	internal RenderingMode get_renderingMode() { }

	// RVA: 0x31442D0 Offset: 0x31443D1 VA: 0x31442D0
	internal RenderingMode get_actualRenderingMode() { }

	// RVA: 0x3144310 Offset: 0x3144411 VA: 0x3144310
	internal bool get_accurateGbufferNormals() { }

	// RVA: 0x3144330 Offset: 0x3144431 VA: 0x3144330
	public void .ctor(ForwardRendererData data) { }

	// RVA: 0x3145AA0 Offset: 0x3145BA1 VA: 0x3145AA0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3145B80 Offset: 0x3145C81 VA: 0x3145B80 Slot: 6
	public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x3147C50 Offset: 0x3147D51 VA: 0x3147C50 Slot: 7
	public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x3147CA0 Offset: 0x3147DA1 VA: 0x3147CA0 Slot: 8
	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	// RVA: 0x3147E00 Offset: 0x3147F01 VA: 0x3147E00 Slot: 9
	public override void FinishRendering(CommandBuffer cmd) { }

	// RVA: 0x3147A40 Offset: 0x3147B41 VA: 0x3147A40
	private void EnqueueDeferred(ref RenderingData renderingData, bool hasDepthPrepass, bool applyMainShadow, bool applyAdditionalShadow) { }

	// RVA: 0x3146F30 Offset: 0x3147031 VA: 0x3146F30
	private ForwardRenderer.RenderPassInputSummary GetRenderPassInputs(ref RenderingData renderingData) { }

	// RVA: 0x31476C0 Offset: 0x31477C1 VA: 0x31476C0
	private void CreateCameraRenderTarget(ScriptableRenderContext context, ref RenderTextureDescriptor descriptor, bool createColor, bool createDepth) { }

	// RVA: 0x3148020 Offset: 0x3148121 VA: 0x3148020
	private bool PlatformRequiresExplicitMsaaResolve() { }

	// RVA: 0x31474A0 Offset: 0x31475A1 VA: 0x31474A0
	private bool RequiresIntermediateColorTexture(ref CameraData cameraData) { }

	// RVA: 0x3147400 Offset: 0x3147501 VA: 0x3147400
	private bool CanCopyDepth(ref CameraData cameraData) { }
}

