// Namespace: UnityEngine.Experimental.Rendering.Universal
[ExtensionAttribute] // RVA: 0x480250 Offset: 0x480351 VA: 0x480250
internal static class RendererLighting // TypeDefIndex: 5484
{
	// Fields
	private static readonly ProfilingSampler m_ProfilingSampler; // 0x0
	private static readonly ShaderTagId k_NormalsRenderingPassName; // 0x8
	private static readonly Color k_NormalClearColor; // 0xC
	private static readonly string k_SpriteLightKeyword; // 0x20
	private static readonly string k_UsePointLightCookiesKeyword; // 0x28
	private static readonly string k_LightQualityFastKeyword; // 0x30
	private static readonly string k_UseNormalMap; // 0x38
	private static readonly string k_UseAdditiveBlendingKeyword; // 0x40
	private static readonly string[] k_UseBlendStyleKeywords; // 0x48
	private static readonly int[] k_BlendFactorsPropIDs; // 0x50
	private static readonly int[] k_MaskFilterPropIDs; // 0x58
	private static readonly int[] k_InvertedFilterPropIDs; // 0x60
	private static GraphicsFormat s_RenderTextureFormatToUse; // 0x68
	private static bool s_HasSetupRenderTextureFormatToUse; // 0x6C
	private static readonly int k_SrcBlendID; // 0x70
	private static readonly int k_DstBlendID; // 0x74
	private static readonly int k_FalloffIntensityID; // 0x78
	private static readonly int k_FalloffDistanceID; // 0x7C
	private static readonly int k_FalloffOffsetID; // 0x80
	private static readonly int k_LightColorID; // 0x84
	private static readonly int k_VolumeOpacityID; // 0x88
	private static readonly int k_CookieTexID; // 0x8C
	private static readonly int k_FalloffLookupID; // 0x90
	private static readonly int k_LightPositionID; // 0x94
	private static readonly int k_LightInvMatrixID; // 0x98
	private static readonly int k_LightNoRotInvMatrixID; // 0x9C
	private static readonly int k_InnerRadiusMultID; // 0xA0
	private static readonly int k_OuterAngleID; // 0xA4
	private static readonly int k_InnerAngleMultID; // 0xA8
	private static readonly int k_LightLookupID; // 0xAC
	private static readonly int k_IsFullSpotlightID; // 0xB0
	private static readonly int k_LightZDistanceID; // 0xB4
	private static readonly int k_PointLightCookieTexID; // 0xB8

	// Methods

	// RVA: 0x3378930 Offset: 0x3378A31 VA: 0x3378930
	private static GraphicsFormat GetRenderTextureFormat() { }

	[ExtensionAttribute] // RVA: 0x485260 Offset: 0x485361 VA: 0x485260
	// RVA: 0x3374150 Offset: 0x3374251 VA: 0x3374150
	public static void CreateNormalMapRenderTexture(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd) { }

	[ExtensionAttribute] // RVA: 0x485270 Offset: 0x485371 VA: 0x485270
	// RVA: 0x3374610 Offset: 0x3374711 VA: 0x3374610
	public static void CreateBlendStyleRenderTexture(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int blendStyleIndex) { }

	// RVA: 0x33748B0 Offset: 0x33749B1 VA: 0x33748B0
	public static void EnableBlendStyle(CommandBuffer cmd, int blendStyleIndex, bool enabled) { }

	[ExtensionAttribute] // RVA: 0x485280 Offset: 0x485381 VA: 0x485280
	// RVA: 0x3375840 Offset: 0x3375941 VA: 0x3375840
	public static void ReleaseRenderTextures(IRenderPass2D pass, CommandBuffer cmd) { }

	// RVA: 0x3378A70 Offset: 0x3378B71 VA: 0x3378A70
	private static bool RenderLightSet(IRenderPass2D pass, RenderingData renderingData, int blendStyleIndex, CommandBuffer cmd, int layerToRender, RenderTargetIdentifier renderTexture, bool rtNeedsClear, Color clearColor, List<Light2D> lights) { }

	// RVA: 0x3379930 Offset: 0x3379A31 VA: 0x3379930
	private static void RenderLightVolumeSet(IRenderPass2D pass, RenderingData renderingData, int blendStyleIndex, CommandBuffer cmd, int layerToRender, RenderTargetIdentifier renderTexture, RenderTargetIdentifier depthTexture, List<Light2D> lights) { }

	[ExtensionAttribute] // RVA: 0x485290 Offset: 0x485391 VA: 0x485290
	// RVA: 0x33742F0 Offset: 0x33743F1 VA: 0x33742F0
	public static void SetShapeLightShaderGlobals(IRenderPass2D pass, CommandBuffer cmd) { }

	// RVA: 0x337A050 Offset: 0x337A151 VA: 0x337A050
	private static float GetNormalizedInnerRadius(Light2D light) { }

	// RVA: 0x337A060 Offset: 0x337A161 VA: 0x337A060
	private static float GetNormalizedAngle(float angle) { }

	// RVA: 0x337A070 Offset: 0x337A171 VA: 0x337A070
	private static void GetScaledLightInvMatrix(Light2D light, out Matrix4x4 retMatrix, bool includeRotation) { }

	// RVA: 0x3379460 Offset: 0x3379561 VA: 0x3379460
	private static void SetPointLightShaderGlobals(CommandBuffer cmd, Light2D light) { }

	[ExtensionAttribute] // RVA: 0x4852A0 Offset: 0x4853A1 VA: 0x4852A0
	// RVA: 0x3375220 Offset: 0x3375321 VA: 0x3375220
	public static void ClearDirtyLighting(IRenderPass2D pass, CommandBuffer cmd, uint blendStylesUsed) { }

	[ExtensionAttribute] // RVA: 0x4852B0 Offset: 0x4853B1 VA: 0x4852B0
	// RVA: 0x3374970 Offset: 0x3374A71 VA: 0x3374970
	public static void RenderNormals(IRenderPass2D pass, ScriptableRenderContext context, CullingResults cullResults, DrawingSettings drawSettings, FilteringSettings filterSettings, RenderTargetIdentifier depthTarget) { }

	[ExtensionAttribute] // RVA: 0x4852C0 Offset: 0x4853C1 VA: 0x4852C0
	// RVA: 0x3374CA0 Offset: 0x3374DA1 VA: 0x3374CA0
	public static void RenderLights(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int layerToRender, uint blendStylesUsed) { }

	[ExtensionAttribute] // RVA: 0x4852D0 Offset: 0x4853D1 VA: 0x4852D0
	// RVA: 0x3375520 Offset: 0x3375621 VA: 0x3375520
	public static void RenderLightVolumes(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int layerToRender, RenderTargetIdentifier renderTarget, RenderTargetIdentifier depthTarget, uint blendStylesUsed) { }

	// RVA: 0x337A1E0 Offset: 0x337A2E1 VA: 0x337A1E0
	private static void SetBlendModes(Material material, BlendMode src, BlendMode dst) { }

	// RVA: 0x337A290 Offset: 0x337A391 VA: 0x337A290
	private static uint GetLightMaterialIndex(Light2D light, bool isVolume) { }

	// RVA: 0x337A3E0 Offset: 0x337A4E1 VA: 0x337A3E0
	private static Material CreateLightMaterial(Renderer2DData rendererData, Light2D light, bool isVolume) { }

	[ExtensionAttribute] // RVA: 0x4852E0 Offset: 0x4853E1 VA: 0x4852E0
	// RVA: 0x3379340 Offset: 0x3379441 VA: 0x3379340
	private static Material GetLightMaterial(Renderer2DData rendererData, Light2D light, bool isVolume) { }

	// RVA: 0x337A7A0 Offset: 0x337A8A1 VA: 0x337A7A0
	private static void .cctor() { }
}

