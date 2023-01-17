// Namespace: UnityEngine.Experimental.Rendering.Universal
internal class Renderer2D : ScriptableRenderer // TypeDefIndex: 5488
{
	// Fields
	private ColorGradingLutPass m_ColorGradingLutPass; // 0x90
	private Render2DLightingPass m_Render2DLightingPass; // 0x98
	private PostProcessPass m_PostProcessPass; // 0xA0
	private FinalBlitPass m_FinalBlitPass; // 0xA8
	private PostProcessPass m_FinalPostProcessPass; // 0xB0
	private Light2DCullResult m_LightCullResult; // 0xB8
	private static readonly ProfilingSampler m_ProfilingSampler; // 0x0
	private bool m_UseDepthStencilBuffer; // 0xC0
	private bool m_CreateColorTexture; // 0xC1
	private bool m_CreateDepthTexture; // 0xC2
	private readonly RenderTargetHandle k_ColorTextureHandle; // 0xC8
	private readonly RenderTargetHandle k_DepthTextureHandle; // 0xF8
	private readonly RenderTargetHandle k_AfterPostProcessColorHandle; // 0x128
	private readonly RenderTargetHandle k_ColorGradingLutHandle; // 0x158
	private Material m_BlitMaterial; // 0x188
	private Renderer2DData m_Renderer2DData; // 0x190

	// Properties
	internal bool createColorTexture { get; }
	internal bool createDepthTexture { get; }

	// Methods

	// RVA: 0x3377240 Offset: 0x3377341 VA: 0x3377240
	internal bool get_createColorTexture() { }

	// RVA: 0x3377250 Offset: 0x3377351 VA: 0x3377250
	internal bool get_createDepthTexture() { }

	// RVA: 0x3377260 Offset: 0x3377361 VA: 0x3377260
	public void .ctor(Renderer2DData data) { }

	// RVA: 0x33775D0 Offset: 0x33776D1 VA: 0x33775D0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3377670 Offset: 0x3377771 VA: 0x3377670
	public Renderer2DData GetRenderer2DData() { }

	// RVA: 0x3377680 Offset: 0x3377781 VA: 0x3377680
	private void CreateRenderTextures(ref CameraData cameraData, bool forceCreateColorTexture, FilterMode colorTextureFilterMode, CommandBuffer cmd, out RenderTargetHandle colorTargetHandle, out RenderTargetHandle depthTargetHandle) { }

	// RVA: 0x33779E0 Offset: 0x3377AE1 VA: 0x33779E0 Slot: 6
	public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x3378390 Offset: 0x3378491 VA: 0x3378390 Slot: 8
	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	// RVA: 0x3378410 Offset: 0x3378511 VA: 0x3378410 Slot: 9
	public override void FinishRendering(CommandBuffer cmd) { }

	// RVA: 0x3378470 Offset: 0x3378571 VA: 0x3378470
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.Universal
[ReloadGroupAttribute] // RVA: 0x480350 Offset: 0x480451 VA: 0x480350
[ExcludeFromPresetAttribute] // RVA: 0x480350 Offset: 0x480451 VA: 0x480350
[MovedFromAttribute] // RVA: 0x480350 Offset: 0x480451 VA: 0x480350
[HelpURLAttribute] // RVA: 0x480350 Offset: 0x480451 VA: 0x480350
[Serializable]
public class Renderer2DData : ScriptableRendererData // TypeDefIndex: 5490
{
	// Fields
	[SerializeField] // RVA: 0x483FC0 Offset: 0x4840C1 VA: 0x483FC0
	private TransparencySortMode m_TransparencySortMode; // 0x30
	[SerializeField] // RVA: 0x483FD0 Offset: 0x4840D1 VA: 0x483FD0
	private Vector3 m_TransparencySortAxis; // 0x34
	[SerializeField] // RVA: 0x483FE0 Offset: 0x4840E1 VA: 0x483FE0
	private float m_HDREmulationScale; // 0x40
	[SerializeField] // RVA: 0x483FF0 Offset: 0x4840F1 VA: 0x483FF0
	[FormerlySerializedAsAttribute] // RVA: 0x483FF0 Offset: 0x4840F1 VA: 0x483FF0
	private Light2DBlendStyle[] m_LightBlendStyles; // 0x48
	[SerializeField] // RVA: 0x484040 Offset: 0x484141 VA: 0x484040
	private bool m_UseDepthStencilBuffer; // 0x50
	[ReloadAttribute] // RVA: 0x484050 Offset: 0x484151 VA: 0x484050
	[SerializeField] // RVA: 0x484050 Offset: 0x484151 VA: 0x484050
	private Shader m_ShapeLightShader; // 0x58
	[ReloadAttribute] // RVA: 0x4840A0 Offset: 0x4841A1 VA: 0x4840A0
	[SerializeField] // RVA: 0x4840A0 Offset: 0x4841A1 VA: 0x4840A0
	private Shader m_ShapeLightVolumeShader; // 0x60
	[SerializeField] // RVA: 0x4840F0 Offset: 0x4841F1 VA: 0x4840F0
	[ReloadAttribute] // RVA: 0x4840F0 Offset: 0x4841F1 VA: 0x4840F0
	private Shader m_PointLightShader; // 0x68
	[SerializeField] // RVA: 0x484140 Offset: 0x484241 VA: 0x484140
	[ReloadAttribute] // RVA: 0x484140 Offset: 0x484241 VA: 0x484140
	private Shader m_PointLightVolumeShader; // 0x70
	[SerializeField] // RVA: 0x484190 Offset: 0x484291 VA: 0x484190
	[ReloadAttribute] // RVA: 0x484190 Offset: 0x484291 VA: 0x484190
	private Shader m_BlitShader; // 0x78
	[SerializeField] // RVA: 0x4841E0 Offset: 0x4842E1 VA: 0x4841E0
	[ReloadAttribute] // RVA: 0x4841E0 Offset: 0x4842E1 VA: 0x4841E0
	private Shader m_ShadowGroupShader; // 0x80
	[ReloadAttribute] // RVA: 0x484230 Offset: 0x484331 VA: 0x484230
	[SerializeField] // RVA: 0x484230 Offset: 0x484331 VA: 0x484230
	private Shader m_RemoveSelfShadowShader; // 0x88
	[SerializeField] // RVA: 0x484280 Offset: 0x484381 VA: 0x484280
	[ReloadAttribute] // RVA: 0x484280 Offset: 0x484381 VA: 0x484280
	private PostProcessData m_PostProcessData; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x4842D0 Offset: 0x4843D1 VA: 0x4842D0
	private readonly Dictionary<uint, Material> <lightMaterials>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x4842E0 Offset: 0x4843E1 VA: 0x4842E0
	private Material[] <shadowMaterials>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x4842F0 Offset: 0x4843F1 VA: 0x4842F0
	private Material[] <removeSelfShadowMaterials>k__BackingField; // 0xA8
	internal RenderTargetHandle normalsRenderTarget; // 0xB0
	internal RenderTargetHandle shadowsRenderTarget; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x484300 Offset: 0x484401 VA: 0x484300
	private ILight2DCullResult <lightCullResult>k__BackingField; // 0x110

	// Properties
	public float hdrEmulationScale { get; }
	public Light2DBlendStyle[] lightBlendStyles { get; }
	internal bool useDepthStencilBuffer { get; }
	internal Shader shapeLightShader { get; }
	internal Shader shapeLightVolumeShader { get; }
	internal Shader pointLightShader { get; }
	internal Shader pointLightVolumeShader { get; }
	internal Shader blitShader { get; }
	internal Shader shadowGroupShader { get; }
	internal Shader removeSelfShadowShader { get; }
	internal PostProcessData postProcessData { get; }
	internal TransparencySortMode transparencySortMode { get; }
	internal Vector3 transparencySortAxis { get; }
	internal Dictionary<uint, Material> lightMaterials { get; }
	internal Material[] shadowMaterials { get; set; }
	internal Material[] removeSelfShadowMaterials { get; set; }
	internal ILight2DCullResult lightCullResult { get; set; }

	// Methods

	// RVA: 0x3378510 Offset: 0x3378611 VA: 0x3378510
	public float get_hdrEmulationScale() { }

	// RVA: 0x3378520 Offset: 0x3378621 VA: 0x3378520
	public Light2DBlendStyle[] get_lightBlendStyles() { }

	// RVA: 0x3378530 Offset: 0x3378631 VA: 0x3378530
	internal bool get_useDepthStencilBuffer() { }

	// RVA: 0x3378540 Offset: 0x3378641 VA: 0x3378540
	internal Shader get_shapeLightShader() { }

	// RVA: 0x3378550 Offset: 0x3378651 VA: 0x3378550
	internal Shader get_shapeLightVolumeShader() { }

	// RVA: 0x3378560 Offset: 0x3378661 VA: 0x3378560
	internal Shader get_pointLightShader() { }

	// RVA: 0x3378570 Offset: 0x3378671 VA: 0x3378570
	internal Shader get_pointLightVolumeShader() { }

	// RVA: 0x3378580 Offset: 0x3378681 VA: 0x3378580
	internal Shader get_blitShader() { }

	// RVA: 0x3378590 Offset: 0x3378691 VA: 0x3378590
	internal Shader get_shadowGroupShader() { }

	// RVA: 0x33785A0 Offset: 0x33786A1 VA: 0x33785A0
	internal Shader get_removeSelfShadowShader() { }

	// RVA: 0x33785B0 Offset: 0x33786B1 VA: 0x33785B0
	internal PostProcessData get_postProcessData() { }

	// RVA: 0x33785C0 Offset: 0x33786C1 VA: 0x33785C0
	internal TransparencySortMode get_transparencySortMode() { }

	// RVA: 0x33785D0 Offset: 0x33786D1 VA: 0x33785D0
	internal Vector3 get_transparencySortAxis() { }

	// RVA: 0x33785E0 Offset: 0x33786E1 VA: 0x33785E0 Slot: 4
	protected override ScriptableRenderer Create() { }

	// RVA: 0x3378650 Offset: 0x3378751 VA: 0x3378650 Slot: 6
	protected override void OnEnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x4852F0 Offset: 0x4853F1 VA: 0x4852F0
	// RVA: 0x3378810 Offset: 0x3378911 VA: 0x3378810
	internal Dictionary<uint, Material> get_lightMaterials() { }

	[CompilerGeneratedAttribute] // RVA: 0x485300 Offset: 0x485401 VA: 0x485300
	// RVA: 0x3378820 Offset: 0x3378921 VA: 0x3378820
	internal Material[] get_shadowMaterials() { }

	[CompilerGeneratedAttribute] // RVA: 0x485310 Offset: 0x485411 VA: 0x485310
	// RVA: 0x3378830 Offset: 0x3378931 VA: 0x3378830
	private void set_shadowMaterials(Material[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x485320 Offset: 0x485421 VA: 0x485320
	// RVA: 0x3378840 Offset: 0x3378941 VA: 0x3378840
	internal Material[] get_removeSelfShadowMaterials() { }

	[CompilerGeneratedAttribute] // RVA: 0x485330 Offset: 0x485431 VA: 0x485330
	// RVA: 0x3378850 Offset: 0x3378951 VA: 0x3378850
	private void set_removeSelfShadowMaterials(Material[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x485340 Offset: 0x485441 VA: 0x485340
	// RVA: 0x3378860 Offset: 0x3378961 VA: 0x3378860
	internal ILight2DCullResult get_lightCullResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x485350 Offset: 0x485451 VA: 0x485350
	// RVA: 0x3378870 Offset: 0x3378971 VA: 0x3378870
	internal void set_lightCullResult(ILight2DCullResult value) { }

	// RVA: 0x3378880 Offset: 0x3378981 VA: 0x3378880
	public void .ctor() { }
}

