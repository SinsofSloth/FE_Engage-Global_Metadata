// Namespace: UnityEngine.Rendering.Universal.Internal
public class PostProcessPass : ScriptableRenderPass // TypeDefIndex: 5416
{
	// Fields
	private RenderTextureDescriptor m_Descriptor; // 0x70
	private RenderTargetHandle m_Source; // 0xA8
	private RenderTargetHandle m_Destination; // 0xD8
	private RenderTargetHandle m_Depth; // 0x108
	private RenderTargetHandle m_InternalLut; // 0x138
	private const string k_RenderPostProcessingTag = "Render PostProcessing Effects";
	private const string k_RenderFinalPostProcessingTag = "Render Final PostProcessing Pass";
	private static readonly ProfilingSampler m_ProfilingRenderPostProcessing; // 0x0
	private static readonly ProfilingSampler m_ProfilingRenderFinalPostProcessing; // 0x8
	private PostProcessPass.MaterialLibrary m_Materials; // 0x168
	private PostProcessData m_Data; // 0x170
	private DepthOfField m_DepthOfField; // 0x178
	private MotionBlur m_MotionBlur; // 0x180
	private PaniniProjection m_PaniniProjection; // 0x188
	private Bloom m_Bloom; // 0x190
	private LensDistortion m_LensDistortion; // 0x198
	private ChromaticAberration m_ChromaticAberration; // 0x1A0
	private Vignette m_Vignette; // 0x1A8
	private ColorLookup m_ColorLookup; // 0x1B0
	private ColorAdjustments m_ColorAdjustments; // 0x1B8
	private Tonemapping m_Tonemapping; // 0x1C0
	private FilmGrain m_FilmGrain; // 0x1C8
	private CustomColorGrading m_CustomColorGrading; // 0x1D0
	private CustomRadialBlur m_CustomRadialBlur; // 0x1D8
	private CustomHeatHaze m_CustomHeatHaze; // 0x1E0
	private CustomGradationFilter m_CustomGradationFilter; // 0x1E8
	private bool m_Sharpen; // 0x1F0
	private bool m_CustomBlur; // 0x1F1
	private int m_CustomBlurTimes; // 0x1F4
	private Vector4 m_CustomFinalMonoColor; // 0x1F8
	private bool m_CustomFilterEnabled; // 0x208
	private Vector4 m_CustomFilterParam0; // 0x20C
	private Vector4 m_CustomFilterParam1; // 0x21C
	private RenderTexture m_CaptureTexture; // 0x230
	private Rect m_CaptureTextureRect; // 0x238
	private PostProcessPass.CaptureMode m_CaptureMode; // 0x248
	private bool m_CaptureTextureHasBeenRendered; // 0x24C
	[CompilerGeneratedAttribute] // RVA: 0x483280 Offset: 0x483381 VA: 0x483280
	private bool <simplePassFlag>k__BackingField; // 0x24D
	private const int k_MaxPyramidSize = 16;
	private readonly GraphicsFormat m_DefaultHDRFormat; // 0x250
	private bool m_UseRGBM; // 0x254
	private readonly GraphicsFormat m_SMAAEdgeFormat; // 0x258
	private readonly GraphicsFormat m_GaussianCoCFormat; // 0x25C
	private Matrix4x4[] m_PrevViewProjM; // 0x260
	private bool m_ResetHistory; // 0x268
	private int m_DitheringTextureIndex; // 0x26C
	private RenderTargetIdentifier[] m_MRT2; // 0x270
	private Vector4[] m_BokehKernel; // 0x278
	private int m_BokehHash; // 0x280
	private bool m_IsFinalPass; // 0x284
	private bool m_HasFinalPass; // 0x285
	private bool m_EnableSRGBConversionIfNeeded; // 0x286
	private bool m_UseDrawProcedural; // 0x287
	private Material m_BlitMaterial; // 0x288
	private readonly HableCurve m_HableCurve; // 0x290
	internal static readonly Matrix4x4[] viewProjMatrixStereo; // 0x10

	// Properties
	public bool simplePassFlag { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x484DD0 Offset: 0x484ED1 VA: 0x484DD0
	// RVA: 0x3363ED0 Offset: 0x3363FD1 VA: 0x3363ED0
	public bool get_simplePassFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x484DE0 Offset: 0x484EE1 VA: 0x484DE0
	// RVA: 0x3363EE0 Offset: 0x3363FE1 VA: 0x3363EE0
	public void set_simplePassFlag(bool value) { }

	// RVA: 0x3363EF0 Offset: 0x3363FF1 VA: 0x3363EF0
	public void .ctor(RenderPassEvent evt, PostProcessData data, Material blitMaterial) { }

	// RVA: 0x3364360 Offset: 0x3364461 VA: 0x3364360
	public void Cleanup() { }

	// RVA: 0x3364370 Offset: 0x3364471 VA: 0x3364370
	public void Setup(in RenderTextureDescriptor baseDescriptor, in RenderTargetHandle source, in RenderTargetHandle destination, in RenderTargetHandle depth, in RenderTargetHandle internalLut, bool hasFinalPass, bool enableSRGBConversion) { }

	// RVA: 0x3364420 Offset: 0x3364521 VA: 0x3364420
	public void SetupWithExtra(in RenderTextureDescriptor baseDescriptor, in RenderTargetHandle source, in RenderTargetHandle destination, in RenderTargetHandle depth, in RenderTargetHandle internalLut, bool hasFinalPass, bool enableSRGBConversion, bool sharpen, bool customBlurEnabled, int customBlurTimes, Color customFinalMonoColor, float customFinalMonoColorRate) { }

	// RVA: 0x3364570 Offset: 0x3364671 VA: 0x3364570
	public void SetupCustomFilterParams(Color color, float sat, float ratio, float whiteRatio, float whitePoint) { }

	// RVA: 0x3364600 Offset: 0x3364701 VA: 0x3364600
	public void CreateCaptureTexture(int width, int height) { }

	// RVA: 0x3364680 Offset: 0x3364781 VA: 0x3364680
	public void DestroyCaptureTexture() { }

	// RVA: 0x3364730 Offset: 0x3364831 VA: 0x3364730
	public void SetupFinalPass(in RenderTargetHandle source, bool needCapture = False) { }

	// RVA: 0x33647E0 Offset: 0x33648E1 VA: 0x33647E0
	public void SetupFinalPassAsCopyCapture() { }

	// RVA: 0x3364870 Offset: 0x3364971 VA: 0x3364870 Slot: 5
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x3364B70 Offset: 0x3364C71 VA: 0x3364B70 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x3364C70 Offset: 0x3364D71 VA: 0x3364C70
	public void ResetHistory() { }

	// RVA: 0x3364C80 Offset: 0x3364D81 VA: 0x3364C80
	public bool CanRunOnTile() { }

	// RVA: 0x3364C90 Offset: 0x3364D91 VA: 0x3364C90 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x3364AA0 Offset: 0x3364BA1 VA: 0x3364AA0
	private RenderTextureDescriptor GetCompatibleDescriptor() { }

	// RVA: 0x336A360 Offset: 0x336A461 VA: 0x336A360
	private RenderTextureDescriptor GetCompatibleDescriptor(int width, int height, GraphicsFormat format, int depthBufferBits = 0) { }

	// RVA: 0x336A410 Offset: 0x336A511 VA: 0x336A410
	private bool RequireSRGBConversionBlitToBackBuffer(CameraData cameraData) { }

	// RVA: 0x336A460 Offset: 0x336A561 VA: 0x336A460
	private void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int passIndex = 0) { }

	// RVA: 0x336A6B0 Offset: 0x336A7B1 VA: 0x336A6B0
	private void DrawFullscreenMesh(CommandBuffer cmd, Material material, int passIndex) { }

	// RVA: 0x33675C0 Offset: 0x33676C1 VA: 0x33675C0
	private void Render(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x3366340 Offset: 0x3366441 VA: 0x3366340
	private void RenderSimplePass(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x336F3E0 Offset: 0x336F4E1 VA: 0x336F3E0
	private BuiltinRenderTextureType BlitDstDiscardContent(CommandBuffer cmd, RenderTargetIdentifier rt) { }

	// RVA: 0x336AC20 Offset: 0x336AD21 VA: 0x336AC20
	private void DoSubpixelMorphologicalAntialiasing(ref CameraData cameraData, CommandBuffer cmd, int source, int destination) { }

	// RVA: 0x336B780 Offset: 0x336B881 VA: 0x336B780
	private void DoDepthOfField(Camera camera, CommandBuffer cmd, int source, int destination, Rect pixelRect) { }

	// RVA: 0x336F510 Offset: 0x336F611 VA: 0x336F510
	private void DoGaussianDepthOfField(Camera camera, CommandBuffer cmd, int source, int destination, Rect pixelRect) { }

	// RVA: 0x3370DD0 Offset: 0x3370ED1 VA: 0x3370DD0
	private void PrepareBokehKernel() { }

	// RVA: 0x3371180 Offset: 0x3371281 VA: 0x3371180
	private static float GetMaxBokehRadiusInPixels(float viewportHeight) { }

	// RVA: 0x33703B0 Offset: 0x33704B1 VA: 0x33703B0
	private void DoBokehDepthOfField(CommandBuffer cmd, int source, int destination, Rect pixelRect) { }

	// RVA: 0x336B880 Offset: 0x336B981 VA: 0x336B880
	private void DoMotionBlur(CameraData cameraData, CommandBuffer cmd, int source, int destination) { }

	// RVA: 0x336C320 Offset: 0x336C421 VA: 0x336C320
	private void DoPaniniProjection(Camera camera, CommandBuffer cmd, int source, int destination) { }

	// RVA: 0x33711A0 Offset: 0x33712A1 VA: 0x33711A0
	private Vector2 CalcViewExtents(Camera camera) { }

	// RVA: 0x3371210 Offset: 0x3371311 VA: 0x3371210
	private Vector2 CalcCropExtents(Camera camera, float d) { }

	// RVA: 0x336CE00 Offset: 0x336CF01 VA: 0x336CE00
	private void SetupBloom(CommandBuffer cmd, int source, Material uberMaterial) { }

	// RVA: 0x336E0D0 Offset: 0x336E1D1 VA: 0x336E0D0
	private void SetupLensDistortion(Material material, bool isSceneView) { }

	// RVA: 0x336E380 Offset: 0x336E481 VA: 0x336E380
	private void SetupChromaticAberration(Material material) { }

	// RVA: 0x336E490 Offset: 0x336E591 VA: 0x336E490
	private void SetupVignette(Material material) { }

	// RVA: 0x336E7F0 Offset: 0x336E8F1 VA: 0x336E7F0
	private void SetupColorGrading(CommandBuffer cmd, ref RenderingData renderingData, Material material) { }

	// RVA: 0x336EF10 Offset: 0x336F011 VA: 0x336EF10
	private void SetupGrain(in CameraData cameraData, Material material) { }

	// RVA: 0x336EFD0 Offset: 0x336F0D1 VA: 0x336EFD0
	private void SetupDithering(in CameraData cameraData, Material material) { }

	// RVA: 0x336C6C0 Offset: 0x336C7C1 VA: 0x336C6C0
	private void SetupCustomHeatHaze(CommandBuffer cmd, int source, Material uberMaterial) { }

	// RVA: 0x336CA60 Offset: 0x336CB61 VA: 0x336CA60
	private void SetupCustomRadialBlur(CommandBuffer cmd, int source, Material uberMaterial) { }

	// RVA: 0x336DC20 Offset: 0x336DD21 VA: 0x336DC20
	private void SetupCustomSystemBlur(CommandBuffer cmd, int source, Material uberMaterial, bool bloomActive) { }

	// RVA: 0x336E640 Offset: 0x336E741 VA: 0x336E640
	private void SetupCustomGradationFilter(Material material) { }

	// RVA: 0x33652D0 Offset: 0x33653D1 VA: 0x33652D0
	private void RenderFinalPass(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x3365F80 Offset: 0x3366081 VA: 0x3365F80
	private void RenderFinalPassAsCopyCapture(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x33716F0 Offset: 0x33717F1 VA: 0x33716F0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x484DF0 Offset: 0x484EF1 VA: 0x484DF0
	// RVA: 0x336A860 Offset: 0x336A961 VA: 0x336A860
	private int <Render>g__GetSource|78_0(ref PostProcessPass.<>c__DisplayClass78_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x484E00 Offset: 0x484F01 VA: 0x484E00
	// RVA: 0x336A870 Offset: 0x336A971 VA: 0x336A870
	private int <Render>g__GetDestination|78_1(ref PostProcessPass.<>c__DisplayClass78_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x484E10 Offset: 0x484F11 VA: 0x484E10
	// RVA: 0x336AAE0 Offset: 0x336ABE1 VA: 0x336AAE0
	private void <Render>g__Swap|78_2(ref PostProcessPass.<>c__DisplayClass78_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x484E20 Offset: 0x484F21 VA: 0x484E20
	// RVA: 0x336F160 Offset: 0x336F261 VA: 0x336F160
	private int <RenderSimplePass>g__GetSource|79_0(ref PostProcessPass.<>c__DisplayClass79_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x484E30 Offset: 0x484F31 VA: 0x484E30
	// RVA: 0x336F170 Offset: 0x336F271 VA: 0x336F170
	private int <RenderSimplePass>g__GetDestination|79_1(ref PostProcessPass.<>c__DisplayClass79_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x484E40 Offset: 0x484F41 VA: 0x484E40
	// RVA: 0x336F480 Offset: 0x336F581 VA: 0x336F480
	private void <RenderSimplePass>g__Swap|79_2(ref PostProcessPass.<>c__DisplayClass79_0 ) { }
}

