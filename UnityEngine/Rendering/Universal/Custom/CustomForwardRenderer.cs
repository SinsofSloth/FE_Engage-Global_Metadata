// Namespace: UnityEngine.Rendering.Universal.Custom
public sealed class CustomForwardRenderer : ScriptableRenderer // TypeDefIndex: 5430
{
	// Fields
	private const int k_DepthStencilBufferBits = 32;
	private const string k_SubLightTag = "CharaLight";
	private const string k_SetupCustomRPConstants = "Setup CustomRP Constants";
	private static readonly int s_CustomExposurePropID; // 0x0
	private static readonly int s_CustomLodFadeBiasPropID; // 0x4
	private ColorGradingLutPass m_ColorGradingLutPass; // 0x90
	private DepthOnlyPass m_DepthPrepass; // 0x98
	private MainLightShadowCasterPass m_MainLightShadowCasterPass; // 0xA0
	private CustomShadowCasterPass m_CustomShadowCasterPass; // 0xA8
	private CustomShadowNoCasterPass m_CustomShadowNoCasterPass; // 0xB0
	private CustomDecalsPass m_CustomDecalsPass; // 0xB8
	private CustomZPrePass m_CustomZPrePass; // 0xC0
	private CustomBaseOpaquePass m_CustomBaseOpaquePass; // 0xC8
	private CustomCharaOpaquePass m_CustomCharaOpaquePass; // 0xD0
	private DrawSkyboxPass m_DrawSkyboxPass; // 0xD8
	private CopyDepthPass m_CopyDepthPass; // 0xE0
	private CopyColorPass m_CopyColorPass; // 0xE8
	private CustomLightOcclusionPass m_CustomLightOcclusionPass; // 0xF0
	private TransparentSettingsPass m_TransparentSettingsPass; // 0xF8
	private CustomBaseTransparentPass m_RenderFormerTransparentForwardPass; // 0x100
	private CustomBaseTransparentPass m_RenderLatterTransparentForwardPass; // 0x108
	private CustomTransparentsLayerPass m_TransparentsLayerPass0; // 0x110
	private CustomTransparentsLayerPass m_TransparentsLayerPass1; // 0x118
	private CustomMixedResolutionPass m_CustomMixedResolutionPass; // 0x120
	private CustomEffectPass m_CustomFullEffectPass; // 0x128
	private PostProcessPass m_PostProcessPass; // 0x130
	private PostProcessPass m_FinalPostProcessPass; // 0x138
	private FinalBlitPass m_FinalBlitPass; // 0x140
	private CapturePass m_CapturePass; // 0x148
	private ZPrepassFeatureSet m_ZPrepassFeature; // 0x150
	public ZPrepassSortingCriteria zprepassSortingCriteria; // 0x154
	[CompilerGeneratedAttribute] // RVA: 0x483390 Offset: 0x483491 VA: 0x483390
	private DecalOcclusionParams <decalOcclusionParams>k__BackingField; // 0x158
	[CompilerGeneratedAttribute] // RVA: 0x4833A0 Offset: 0x4834A1 VA: 0x4833A0
	private CustomRPParams <customRPParams>k__BackingField; // 0x160
	private ForwardRendererData.MixedResolutionFlag m_MixedResolutionFlag; // 0x168
	private RenderTargetHandle m_ActiveCameraColorAttachment; // 0x170
	private RenderTargetHandle m_ActiveCameraDepthAttachment; // 0x1A0
	private RenderTargetHandle m_CameraColorAttachment; // 0x1D0
	private RenderTargetHandle m_CameraDepthAttachment; // 0x200
	private RenderTargetHandle m_DepthTexture; // 0x230
	private RenderTargetHandle m_OpaqueColor; // 0x260
	private RenderTargetHandle m_AfterPostProcessColor; // 0x290
	private RenderTargetHandle m_ColorGradingLut; // 0x2C0
	private ForwardLights m_ForwardLights; // 0x2F0
	private Material m_BlitMaterial; // 0x2F8
	private Material m_CopyDepthMaterial; // 0x300
	private Material m_SamplingMaterial; // 0x308
	private Material m_ScreenspaceShadowsMaterial; // 0x310
	private Material m_ZPrepassMaterial; // 0x318
	private Material m_DownsampleDepthMaterial; // 0x320
	private Material m_HalfResoCompositeMaterial; // 0x328
	private Material m_LightOcclusionMaterial; // 0x330

	// Properties
	public bool isZPrepassEnabled { get; }
	public ZPrepassFeatureSet zprepassFeature { get; set; }
	public DecalOcclusionParams decalOcclusionParams { get; set; }
	public CustomRPParams customRPParams { get; set; }

	// Methods

	// RVA: 0x2D32C70 Offset: 0x2D32D71 VA: 0x2D32C70
	public bool get_isZPrepassEnabled() { }

	// RVA: 0x2D32C80 Offset: 0x2D32D81 VA: 0x2D32C80
	public ZPrepassFeatureSet get_zprepassFeature() { }

	// RVA: 0x2D32C90 Offset: 0x2D32D91 VA: 0x2D32C90
	public void set_zprepassFeature(ZPrepassFeatureSet value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484E50 Offset: 0x484F51 VA: 0x484E50
	// RVA: 0x2D32CA0 Offset: 0x2D32DA1 VA: 0x2D32CA0
	public DecalOcclusionParams get_decalOcclusionParams() { }

	[CompilerGeneratedAttribute] // RVA: 0x484E60 Offset: 0x484F61 VA: 0x484E60
	// RVA: 0x2D32CB0 Offset: 0x2D32DB1 VA: 0x2D32CB0
	private void set_decalOcclusionParams(DecalOcclusionParams value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484E70 Offset: 0x484F71 VA: 0x484E70
	// RVA: 0x2D32CC0 Offset: 0x2D32DC1 VA: 0x2D32CC0
	public CustomRPParams get_customRPParams() { }

	[CompilerGeneratedAttribute] // RVA: 0x484E80 Offset: 0x484F81 VA: 0x484E80
	// RVA: 0x2D32CD0 Offset: 0x2D32DD1 VA: 0x2D32CD0
	private void set_customRPParams(CustomRPParams value) { }

	// RVA: 0x2D32CE0 Offset: 0x2D32DE1 VA: 0x2D32CE0
	public void .ctor(ForwardRendererData data) { }

	// RVA: 0x2D34AC0 Offset: 0x2D34BC1 VA: 0x2D34AC0 Slot: 10
	public override string GetSubLightTag() { }

	// RVA: 0x2D34B10 Offset: 0x2D34C11 VA: 0x2D34B10 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2D34C50 Offset: 0x2D34D51 VA: 0x2D34C50 Slot: 6
	public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D36D50 Offset: 0x2D36E51 VA: 0x2D36D50 Slot: 7
	public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D36ED0 Offset: 0x2D36FD1 VA: 0x2D36ED0 Slot: 8
	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	// RVA: 0x2D370C0 Offset: 0x2D371C1 VA: 0x2D370C0 Slot: 9
	public override void FinishRendering(CommandBuffer cmd) { }

	// RVA: 0x2D36AE0 Offset: 0x2D36BE1 VA: 0x2D36AE0
	private bool IsEnabledSharpenFilter(ref CameraData cameraData) { }

	// RVA: 0x2D36A20 Offset: 0x2D36B21 VA: 0x2D36A20
	private void AcquireCustomBlurParams(ref CameraData cameraData, out bool customBlurEnabled, out int customBlurTimes) { }

	// RVA: 0x2D36BD0 Offset: 0x2D36CD1 VA: 0x2D36BD0
	private void AcquireFinalMonoColorToResult(ref CameraData cameraData, out Color color, out float ratio) { }

	// RVA: 0x2D36C90 Offset: 0x2D36D91 VA: 0x2D36C90
	private bool IsSpecialFilterEnabled(ref CameraData cameraData) { }

	// RVA: 0x2D366E0 Offset: 0x2D367E1 VA: 0x2D366E0
	private void CreateCameraRenderTarget(ScriptableRenderContext context, ref RenderTextureDescriptor descriptor, bool createColor, bool createDepth) { }

	// RVA: 0x2D372E0 Offset: 0x2D373E1 VA: 0x2D372E0
	private bool PlatformRequiresExplicitMsaaResolve() { }

	// RVA: 0x2D36500 Offset: 0x2D36601 VA: 0x2D36500
	private bool RequiresIntermediateColorTexture(ref CameraData cameraData) { }

	// RVA: 0x2D36460 Offset: 0x2D36561 VA: 0x2D36460
	private bool CanCopyDepth(ref CameraData cameraData) { }

	// RVA: 0x2D37340 Offset: 0x2D37441 VA: 0x2D37340
	private static void .cctor() { }
}

