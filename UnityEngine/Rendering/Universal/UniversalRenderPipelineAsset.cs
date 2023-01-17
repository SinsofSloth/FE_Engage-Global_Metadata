// Namespace: UnityEngine.Rendering.Universal
[ExcludeFromPresetAttribute] // RVA: 0x47F260 Offset: 0x47F361 VA: 0x47F260
public class UniversalRenderPipelineAsset : RenderPipelineAsset, ISerializationCallbackReceiver // TypeDefIndex: 5259
{
	// Fields
	private Shader m_DefaultShader; // 0x18
	private ScriptableRenderer[] m_Renderers; // 0x20
	[SerializeField] // RVA: 0x480BA0 Offset: 0x480CA1 VA: 0x480BA0
	private int k_AssetVersion; // 0x28
	[SerializeField] // RVA: 0x480BB0 Offset: 0x480CB1 VA: 0x480BB0
	private int k_AssetPreviousVersion; // 0x2C
	[SerializeField] // RVA: 0x480BC0 Offset: 0x480CC1 VA: 0x480BC0
	private RendererType m_RendererType; // 0x30
	[EditorBrowsableAttribute] // RVA: 0x480BD0 Offset: 0x480CD1 VA: 0x480BD0
	[SerializeField] // RVA: 0x480BD0 Offset: 0x480CD1 VA: 0x480BD0
	internal ScriptableRendererData m_RendererData; // 0x38
	[SerializeField] // RVA: 0x480C10 Offset: 0x480D11 VA: 0x480C10
	internal ScriptableRendererData[] m_RendererDataList; // 0x40
	[SerializeField] // RVA: 0x480C20 Offset: 0x480D21 VA: 0x480C20
	internal int m_DefaultRendererIndex; // 0x48
	[SerializeField] // RVA: 0x480C30 Offset: 0x480D31 VA: 0x480C30
	private bool m_RequireDepthTexture; // 0x4C
	[SerializeField] // RVA: 0x480C40 Offset: 0x480D41 VA: 0x480C40
	private bool m_RequireOpaqueTexture; // 0x4D
	[SerializeField] // RVA: 0x480C50 Offset: 0x480D51 VA: 0x480C50
	private Downsampling m_OpaqueDownsampling; // 0x50
	[SerializeField] // RVA: 0x480C60 Offset: 0x480D61 VA: 0x480C60
	private bool m_SupportsTerrainHoles; // 0x54
	[SerializeField] // RVA: 0x480C70 Offset: 0x480D71 VA: 0x480C70
	private bool m_SupportsHDR; // 0x55
	[SerializeField] // RVA: 0x480C80 Offset: 0x480D81 VA: 0x480C80
	private MsaaQuality m_MSAA; // 0x58
	[SerializeField] // RVA: 0x480C90 Offset: 0x480D91 VA: 0x480C90
	private float m_RenderScale; // 0x5C
	[SerializeField] // RVA: 0x480CA0 Offset: 0x480DA1 VA: 0x480CA0
	private LightRenderingMode m_MainLightRenderingMode; // 0x60
	[SerializeField] // RVA: 0x480CB0 Offset: 0x480DB1 VA: 0x480CB0
	private bool m_MainLightShadowsSupported; // 0x64
	[SerializeField] // RVA: 0x480CC0 Offset: 0x480DC1 VA: 0x480CC0
	private ShadowResolution m_MainLightShadowmapResolution; // 0x68
	[SerializeField] // RVA: 0x480CD0 Offset: 0x480DD1 VA: 0x480CD0
	private LightRenderingMode m_AdditionalLightsRenderingMode; // 0x6C
	[SerializeField] // RVA: 0x480CE0 Offset: 0x480DE1 VA: 0x480CE0
	private int m_AdditionalLightsPerObjectLimit; // 0x70
	[SerializeField] // RVA: 0x480CF0 Offset: 0x480DF1 VA: 0x480CF0
	private bool m_AdditionalLightShadowsSupported; // 0x74
	[SerializeField] // RVA: 0x480D00 Offset: 0x480E01 VA: 0x480D00
	private ShadowResolution m_AdditionalLightsShadowmapResolution; // 0x78
	[SerializeField] // RVA: 0x480D10 Offset: 0x480E11 VA: 0x480D10
	private float m_ShadowDistance; // 0x7C
	[SerializeField] // RVA: 0x480D20 Offset: 0x480E21 VA: 0x480D20
	private int m_ShadowCascadeCount; // 0x80
	[SerializeField] // RVA: 0x480D30 Offset: 0x480E31 VA: 0x480D30
	private float m_Cascade2Split; // 0x84
	[SerializeField] // RVA: 0x480D40 Offset: 0x480E41 VA: 0x480D40
	private Vector2 m_Cascade3Split; // 0x88
	[SerializeField] // RVA: 0x480D50 Offset: 0x480E51 VA: 0x480D50
	private Vector3 m_Cascade4Split; // 0x90
	[SerializeField] // RVA: 0x480D60 Offset: 0x480E61 VA: 0x480D60
	private float m_ShadowDepthBias; // 0x9C
	[SerializeField] // RVA: 0x480D70 Offset: 0x480E71 VA: 0x480D70
	private float m_ShadowNormalBias; // 0xA0
	[SerializeField] // RVA: 0x480D80 Offset: 0x480E81 VA: 0x480D80
	private bool m_SoftShadowsSupported; // 0xA4
	[SerializeField] // RVA: 0x480D90 Offset: 0x480E91 VA: 0x480D90
	private bool m_UseSRPBatcher; // 0xA5
	[SerializeField] // RVA: 0x480DA0 Offset: 0x480EA1 VA: 0x480DA0
	private bool m_SupportsDynamicBatching; // 0xA6
	[SerializeField] // RVA: 0x480DB0 Offset: 0x480EB1 VA: 0x480DB0
	private bool m_MixedLightingSupported; // 0xA7
	[ObsoleteAttribute] // RVA: 0x480DC0 Offset: 0x480EC1 VA: 0x480DC0
	[SerializeField] // RVA: 0x480DC0 Offset: 0x480EC1 VA: 0x480DC0
	private PipelineDebugLevel m_DebugLevel; // 0xA8
	[SerializeField] // RVA: 0x480E00 Offset: 0x480F01 VA: 0x480E00
	private bool m_UseAdaptivePerformance; // 0xAC
	[SerializeField] // RVA: 0x480E10 Offset: 0x480F11 VA: 0x480E10
	private ColorGradingMode m_ColorGradingMode; // 0xB0
	[SerializeField] // RVA: 0x480E20 Offset: 0x480F21 VA: 0x480E20
	private int m_ColorGradingLutSize; // 0xB4
	[SerializeField] // RVA: 0x480E30 Offset: 0x480F31 VA: 0x480E30
	private ShadowQuality m_ShadowType; // 0xB8
	[SerializeField] // RVA: 0x480E40 Offset: 0x480F41 VA: 0x480E40
	private bool m_LocalShadowsSupported; // 0xBC
	[SerializeField] // RVA: 0x480E50 Offset: 0x480F51 VA: 0x480E50
	private ShadowResolution m_LocalShadowsAtlasResolution; // 0xC0
	[SerializeField] // RVA: 0x480E60 Offset: 0x480F61 VA: 0x480E60
	private int m_MaxPixelLights; // 0xC4
	[SerializeField] // RVA: 0x480E70 Offset: 0x480F71 VA: 0x480E70
	private ShadowResolution m_ShadowAtlasResolution; // 0xC8
	[SerializeField] // RVA: 0x480E80 Offset: 0x480F81 VA: 0x480E80
	private ShaderVariantLogLevel m_ShaderVariantLogLevel; // 0xCC
	[SerializeField] // RVA: 0x480E90 Offset: 0x480F91 VA: 0x480E90
	private CustomShadowData[] m_CustomShadowDataList; // 0xD0
	[SerializeField] // RVA: 0x480EA0 Offset: 0x480FA1 VA: 0x480EA0
	private bool m_SharpenFilter; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x480EB0 Offset: 0x480FB1 VA: 0x480EB0
	private float <lutPatternV>k__BackingField; // 0xDC
	[CompilerGeneratedAttribute] // RVA: 0x480EC0 Offset: 0x480FC1 VA: 0x480EC0
	private float <customAlphaMapUI>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x480ED0 Offset: 0x480FD1 VA: 0x480ED0
	private CustomRenderingFlag <customRenderingFlag>k__BackingField; // 0xE4
	public const int k_MinLutSize = 16;
	public const int k_MaxLutSize = 65;
	internal const int k_ShadowCascadeMinCount = 1;
	internal const int k_ShadowCascadeMaxCount = 4;
	[ObsoleteAttribute] // RVA: 0x480EE0 Offset: 0x480FE1 VA: 0x480EE0
	[SerializeField] // RVA: 0x480EE0 Offset: 0x480FE1 VA: 0x480EE0
	private ShadowCascadesOption m_ShadowCascades; // 0xE8

	// Properties
	public bool sharpenFilter { get; set; }
	internal float lutPatternV { get; set; }
	public float customAlphaMapUI { get; set; }
	public CustomRenderingFlag customRenderingFlag { get; set; }
	public ScriptableRenderer scriptableRenderer { get; }
	internal ScriptableRendererData scriptableRendererData { get; }
	internal int[] rendererIndexList { get; }
	public bool supportsCameraDepthTexture { get; set; }
	public bool supportsCameraOpaqueTexture { get; set; }
	public Downsampling opaqueDownsampling { get; }
	public bool supportsTerrainHoles { get; }
	public bool supportsHDR { get; set; }
	public int msaaSampleCount { get; set; }
	public float renderScale { get; set; }
	public LightRenderingMode mainLightRenderingMode { get; }
	public bool supportsMainLightShadows { get; }
	public int mainLightShadowmapResolution { get; }
	public LightRenderingMode additionalLightsRenderingMode { get; }
	public int maxAdditionalLightsCount { get; set; }
	public bool supportsAdditionalLightShadows { get; }
	public int additionalLightsShadowmapResolution { get; }
	public float shadowDistance { get; set; }
	public int shadowCascadeCount { get; set; }
	public float cascade2Split { get; }
	public Vector2 cascade3Split { get; }
	public Vector3 cascade4Split { get; }
	public float shadowDepthBias { get; set; }
	public float shadowNormalBias { get; set; }
	public bool supportsSoftShadows { get; }
	public bool supportsDynamicBatching { get; set; }
	public bool supportsMixedLighting { get; }
	public ShaderVariantLogLevel shaderVariantLogLevel { get; set; }
	[ObsoleteAttribute] // RVA: 0x485510 Offset: 0x485611 VA: 0x485510
	public PipelineDebugLevel debugLevel { get; set; }
	public bool useSRPBatcher { get; set; }
	public ColorGradingMode colorGradingMode { get; set; }
	public int colorGradingLutSize { get; set; }
	public bool useAdaptivePerformance { get; set; }
	public override Material defaultMaterial { get; }
	public override Material defaultParticleMaterial { get; }
	public override Material defaultLineMaterial { get; }
	public override Material defaultTerrainMaterial { get; }
	public override Material defaultUIMaterial { get; }
	public override Material defaultUIOverdrawMaterial { get; }
	public override Material defaultUIETC1SupportedMaterial { get; }
	public override Material default2DMaterial { get; }
	public override Shader defaultShader { get; }
	[ObsoleteAttribute] // RVA: 0x485550 Offset: 0x485651 VA: 0x485550
	public ShadowCascadesOption shadowCascadeOption { get; set; }

	// Methods

	// RVA: 0x2F9B660 Offset: 0x2F9B761 VA: 0x2F9B660
	public bool get_sharpenFilter() { }

	// RVA: 0x2F9B670 Offset: 0x2F9B771 VA: 0x2F9B670
	public void set_sharpenFilter(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4843D0 Offset: 0x4844D1 VA: 0x4843D0
	// RVA: 0x2F9B680 Offset: 0x2F9B781 VA: 0x2F9B680
	internal float get_lutPatternV() { }

	[CompilerGeneratedAttribute] // RVA: 0x4843E0 Offset: 0x4844E1 VA: 0x4843E0
	// RVA: 0x2F9B690 Offset: 0x2F9B791 VA: 0x2F9B690
	private void set_lutPatternV(float value) { }

	// RVA: 0x2F9B6A0 Offset: 0x2F9B7A1 VA: 0x2F9B6A0
	public void CalcLutPatternParams(int patternIndex, int patternCount) { }

	[CompilerGeneratedAttribute] // RVA: 0x4843F0 Offset: 0x4844F1 VA: 0x4843F0
	// RVA: 0x2F9B6D0 Offset: 0x2F9B7D1 VA: 0x2F9B6D0
	public float get_customAlphaMapUI() { }

	[CompilerGeneratedAttribute] // RVA: 0x484400 Offset: 0x484501 VA: 0x484400
	// RVA: 0x2F9B6E0 Offset: 0x2F9B7E1 VA: 0x2F9B6E0
	public void set_customAlphaMapUI(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484410 Offset: 0x484511 VA: 0x484410
	// RVA: 0x2F9B6F0 Offset: 0x2F9B7F1 VA: 0x2F9B6F0
	public CustomRenderingFlag get_customRenderingFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x484420 Offset: 0x484521 VA: 0x484420
	// RVA: 0x2F9B700 Offset: 0x2F9B801 VA: 0x2F9B700
	public void set_customRenderingFlag(CustomRenderingFlag value) { }

	// RVA: 0x2F9B710 Offset: 0x2F9B811 VA: 0x2F9B710
	public ScriptableRendererData LoadBuiltinRendererData(RendererType type = 1) { }

	// RVA: 0x2F9B760 Offset: 0x2F9B861 VA: 0x2F9B760 Slot: 22
	protected override RenderPipeline CreatePipeline() { }

	// RVA: 0x2F9BB80 Offset: 0x2F9BC81 VA: 0x2F9BB80
	private void DestroyRenderers() { }

	// RVA: 0x2F9BC20 Offset: 0x2F9BD21 VA: 0x2F9BC20
	private void DestroyRenderer(ref ScriptableRenderer renderer) { }

	// RVA: 0x2F9BC70 Offset: 0x2F9BD71 VA: 0x2F9BC70 Slot: 23
	protected override void OnValidate() { }

	// RVA: 0x2F9BD10 Offset: 0x2F9BE11 VA: 0x2F9BD10 Slot: 24
	protected override void OnDisable() { }

	// RVA: 0x2F9B990 Offset: 0x2F9BA91 VA: 0x2F9B990
	private void CreateRenderers() { }

	// RVA: 0x2F9BDB0 Offset: 0x2F9BEB1 VA: 0x2F9BDB0
	private Material GetMaterial(DefaultMaterialType materialType) { }

	// RVA: 0x2F99320 Offset: 0x2F99421 VA: 0x2F99320
	public ScriptableRenderer get_scriptableRenderer() { }

	// RVA: 0x2F91490 Offset: 0x2F91591 VA: 0x2F91490
	public ScriptableRenderer GetRenderer(int index) { }

	// RVA: 0x2F9BDC0 Offset: 0x2F9BEC1 VA: 0x2F9BDC0
	internal ScriptableRendererData get_scriptableRendererData() { }

	// RVA: 0x2F9BE90 Offset: 0x2F9BF91 VA: 0x2F9BE90
	internal int[] get_rendererIndexList() { }

	// RVA: 0x2F9BF40 Offset: 0x2F9C041 VA: 0x2F9BF40
	public bool get_supportsCameraDepthTexture() { }

	// RVA: 0x2F9BF50 Offset: 0x2F9C051 VA: 0x2F9BF50
	public void set_supportsCameraDepthTexture(bool value) { }

	// RVA: 0x2F9BF60 Offset: 0x2F9C061 VA: 0x2F9BF60
	public bool get_supportsCameraOpaqueTexture() { }

	// RVA: 0x2F9BF70 Offset: 0x2F9C071 VA: 0x2F9BF70
	public void set_supportsCameraOpaqueTexture(bool value) { }

	// RVA: 0x2F9BF80 Offset: 0x2F9C081 VA: 0x2F9BF80
	public Downsampling get_opaqueDownsampling() { }

	// RVA: 0x2F9BF90 Offset: 0x2F9C091 VA: 0x2F9BF90
	public bool get_supportsTerrainHoles() { }

	// RVA: 0x2F9BFA0 Offset: 0x2F9C0A1 VA: 0x2F9BFA0
	public bool get_supportsHDR() { }

	// RVA: 0x2F9BFB0 Offset: 0x2F9C0B1 VA: 0x2F9BFB0
	public void set_supportsHDR(bool value) { }

	// RVA: 0x2F9BFC0 Offset: 0x2F9C0C1 VA: 0x2F9BFC0
	public int get_msaaSampleCount() { }

	// RVA: 0x2F9BFD0 Offset: 0x2F9C0D1 VA: 0x2F9BFD0
	public void set_msaaSampleCount(int value) { }

	// RVA: 0x2F9BFE0 Offset: 0x2F9C0E1 VA: 0x2F9BFE0
	public float get_renderScale() { }

	// RVA: 0x2F9BFF0 Offset: 0x2F9C0F1 VA: 0x2F9BFF0
	public void set_renderScale(float value) { }

	// RVA: 0x2F9C120 Offset: 0x2F9C221 VA: 0x2F9C120
	public LightRenderingMode get_mainLightRenderingMode() { }

	// RVA: 0x2F9C130 Offset: 0x2F9C231 VA: 0x2F9C130
	public bool get_supportsMainLightShadows() { }

	// RVA: 0x2F9C140 Offset: 0x2F9C241 VA: 0x2F9C140
	public int get_mainLightShadowmapResolution() { }

	// RVA: 0x2F9C150 Offset: 0x2F9C251 VA: 0x2F9C150
	public LightRenderingMode get_additionalLightsRenderingMode() { }

	// RVA: 0x2F9C160 Offset: 0x2F9C261 VA: 0x2F9C160
	public int get_maxAdditionalLightsCount() { }

	// RVA: 0x2F9C170 Offset: 0x2F9C271 VA: 0x2F9C170
	public void set_maxAdditionalLightsCount(int value) { }

	// RVA: 0x2F9C270 Offset: 0x2F9C371 VA: 0x2F9C270
	public bool get_supportsAdditionalLightShadows() { }

	// RVA: 0x2F9C280 Offset: 0x2F9C381 VA: 0x2F9C280
	public int get_additionalLightsShadowmapResolution() { }

	// RVA: 0x2F9C290 Offset: 0x2F9C391 VA: 0x2F9C290
	public float get_shadowDistance() { }

	// RVA: 0x2F9C2A0 Offset: 0x2F9C3A1 VA: 0x2F9C2A0
	public void set_shadowDistance(float value) { }

	// RVA: 0x2F9C2D0 Offset: 0x2F9C3D1 VA: 0x2F9C2D0
	public int get_shadowCascadeCount() { }

	// RVA: 0x2F9C2E0 Offset: 0x2F9C3E1 VA: 0x2F9C2E0
	public void set_shadowCascadeCount(int value) { }

	// RVA: 0x2F9C3D0 Offset: 0x2F9C4D1 VA: 0x2F9C3D0
	public float get_cascade2Split() { }

	// RVA: 0x2F9C3E0 Offset: 0x2F9C4E1 VA: 0x2F9C3E0
	public Vector2 get_cascade3Split() { }

	// RVA: 0x2F9C3F0 Offset: 0x2F9C4F1 VA: 0x2F9C3F0
	public Vector3 get_cascade4Split() { }

	// RVA: 0x2F9C400 Offset: 0x2F9C501 VA: 0x2F9C400
	public float get_shadowDepthBias() { }

	// RVA: 0x2F9C410 Offset: 0x2F9C511 VA: 0x2F9C410
	public void set_shadowDepthBias(float value) { }

	// RVA: 0x2F9C530 Offset: 0x2F9C631 VA: 0x2F9C530
	public float get_shadowNormalBias() { }

	// RVA: 0x2F9C540 Offset: 0x2F9C641 VA: 0x2F9C540
	public void set_shadowNormalBias(float value) { }

	// RVA: 0x2F9C5E0 Offset: 0x2F9C6E1 VA: 0x2F9C5E0
	public bool get_supportsSoftShadows() { }

	// RVA: 0x2F9C5F0 Offset: 0x2F9C6F1 VA: 0x2F9C5F0
	public bool get_supportsDynamicBatching() { }

	// RVA: 0x2F9C600 Offset: 0x2F9C701 VA: 0x2F9C600
	public void set_supportsDynamicBatching(bool value) { }

	// RVA: 0x2F9C610 Offset: 0x2F9C711 VA: 0x2F9C610
	public bool get_supportsMixedLighting() { }

	// RVA: 0x2F9C620 Offset: 0x2F9C721 VA: 0x2F9C620
	public ShaderVariantLogLevel get_shaderVariantLogLevel() { }

	// RVA: 0x2F9C630 Offset: 0x2F9C731 VA: 0x2F9C630
	public void set_shaderVariantLogLevel(ShaderVariantLogLevel value) { }

	// RVA: 0x2F9C640 Offset: 0x2F9C741 VA: 0x2F9C640
	public PipelineDebugLevel get_debugLevel() { }

	// RVA: 0x2F9C650 Offset: 0x2F9C751 VA: 0x2F9C650
	public void set_debugLevel(PipelineDebugLevel value) { }

	// RVA: 0x2F9C660 Offset: 0x2F9C761 VA: 0x2F9C660
	public bool get_useSRPBatcher() { }

	// RVA: 0x2F9C670 Offset: 0x2F9C771 VA: 0x2F9C670
	public void set_useSRPBatcher(bool value) { }

	// RVA: 0x2F9C680 Offset: 0x2F9C781 VA: 0x2F9C680
	public ColorGradingMode get_colorGradingMode() { }

	// RVA: 0x2F9C690 Offset: 0x2F9C791 VA: 0x2F9C690
	public void set_colorGradingMode(ColorGradingMode value) { }

	// RVA: 0x2F9C6A0 Offset: 0x2F9C7A1 VA: 0x2F9C6A0
	public int get_colorGradingLutSize() { }

	// RVA: 0x2F9C6B0 Offset: 0x2F9C7B1 VA: 0x2F9C6B0
	public void set_colorGradingLutSize(int value) { }

	// RVA: 0x2F9C6F0 Offset: 0x2F9C7F1 VA: 0x2F9C6F0
	public bool get_useAdaptivePerformance() { }

	// RVA: 0x2F9C700 Offset: 0x2F9C801 VA: 0x2F9C700
	public void set_useAdaptivePerformance(bool value) { }

	// RVA: 0x2F9C710 Offset: 0x2F9C811 VA: 0x2F9C710 Slot: 5
	public override Material get_defaultMaterial() { }

	// RVA: 0x2F9C720 Offset: 0x2F9C821 VA: 0x2F9C720 Slot: 12
	public override Material get_defaultParticleMaterial() { }

	// RVA: 0x2F9C730 Offset: 0x2F9C831 VA: 0x2F9C730 Slot: 13
	public override Material get_defaultLineMaterial() { }

	// RVA: 0x2F9C740 Offset: 0x2F9C841 VA: 0x2F9C740 Slot: 14
	public override Material get_defaultTerrainMaterial() { }

	// RVA: 0x2F9C750 Offset: 0x2F9C851 VA: 0x2F9C750 Slot: 15
	public override Material get_defaultUIMaterial() { }

	// RVA: 0x2F9C760 Offset: 0x2F9C861 VA: 0x2F9C760 Slot: 16
	public override Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x2F9C770 Offset: 0x2F9C871 VA: 0x2F9C770 Slot: 17
	public override Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x2F9C780 Offset: 0x2F9C881 VA: 0x2F9C780 Slot: 18
	public override Material get_default2DMaterial() { }

	// RVA: 0x2F9C790 Offset: 0x2F9C891 VA: 0x2F9C790 Slot: 19
	public override Shader get_defaultShader() { }

	// RVA: 0x2F9C860 Offset: 0x2F9C961 VA: 0x2F9C860 Slot: 25
	public void OnBeforeSerialize() { }

	// RVA: 0x2F9C870 Offset: 0x2F9C971 VA: 0x2F9C870 Slot: 26
	public void OnAfterDeserialize() { }

	// RVA: 0x2F9C4B0 Offset: 0x2F9C5B1 VA: 0x2F9C4B0
	private float ValidateShadowBias(float value) { }

	// RVA: 0x2F9C1A0 Offset: 0x2F9C2A1 VA: 0x2F9C1A0
	private int ValidatePerObjectLights(int value) { }

	// RVA: 0x2F9C090 Offset: 0x2F9C191 VA: 0x2F9C090
	private float ValidateRenderScale(float value) { }

	// RVA: 0x2F9C990 Offset: 0x2F9CA91 VA: 0x2F9C990
	internal bool ValidateRendererDataList(bool partial = False) { }

	// RVA: 0x2F9CA20 Offset: 0x2F9CB21 VA: 0x2F9CA20
	internal bool ValidateRendererData(int index) { }

	// RVA: 0x2F9CB00 Offset: 0x2F9CC01 VA: 0x2F9CB00
	public CustomShadowData GetCustomShadowData(int index) { }

	// RVA: 0x2F9CB50 Offset: 0x2F9CC51 VA: 0x2F9CB50
	public void ApplyCustomShadowData(CustomShadowData data) { }

	// RVA: 0x2F9CCE0 Offset: 0x2F9CDE1 VA: 0x2F9CCE0
	public void ApplyCustomShadowData(CustomShadowData dataA, CustomShadowData dataB, float t) { }

	// RVA: 0x2F9CC90 Offset: 0x2F9CD91 VA: 0x2F9CC90
	public void UpdateShadowCascade2Split(float split1) { }

	// RVA: 0x2F9CE90 Offset: 0x2F9CF91 VA: 0x2F9CE90
	public ShadowCascadesOption get_shadowCascadeOption() { }

	// RVA: 0x2F9CF30 Offset: 0x2F9D031 VA: 0x2F9CF30
	public void set_shadowCascadeOption(ShadowCascadesOption value) { }

	// RVA: 0x2F9CFB0 Offset: 0x2F9D0B1 VA: 0x2F9CFB0
	public void .ctor() { }
}

