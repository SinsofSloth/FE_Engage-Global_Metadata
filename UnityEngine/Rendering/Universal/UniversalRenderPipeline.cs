// Namespace: UnityEngine.Rendering.Universal
public sealed class UniversalRenderPipeline : RenderPipeline // TypeDefIndex: 5360
{
	// Fields
	public const string k_ShaderTagName = "UniversalPipeline";
	public const string k_ProfilingUnknownSamplerName = "UniversalRenderPipeline.RenderSingleCamera: Unknown";
	internal static XRSystem m_XRSystem; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x482EA0 Offset: 0x482FA1 VA: 0x482EA0
	private static Action<ScriptableRenderContext, Camera[]> customBeginFrameRendering; // 0x8
	private const int k_MaxVisibleAdditionalLightsMobileShaderLevelLessThan45 = 16;
	private const int k_MaxVisibleAdditionalLightsMobile = 32;
	private const int k_MaxVisibleAdditionalLightsNonMobile = 256;
	[CompilerGeneratedAttribute] // RVA: 0x482EB0 Offset: 0x482FB1 VA: 0x482EB0
	private static float <overwriteShadowDistance>k__BackingField; // 0x10
	private static Vector4 k_DefaultLightPosition; // 0x14
	private static Vector4 k_DefaultLightColor; // 0x24
	private static Vector4 k_DefaultLightAttenuation; // 0x34
	private static Vector4 k_DefaultLightSpotDirection; // 0x44
	private static Vector4 k_DefaultLightsProbeChannel; // 0x54
	private static List<Vector4> m_ShadowBiasData; // 0x68
	private Comparison<Camera> cameraComparison; // 0x18
	private static Lightmapping.RequestLightsDelegate lightsDelegate; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x482EC0 Offset: 0x482FC1 VA: 0x482EC0
	private static bool <gpuIsSaveMode>k__BackingField; // 0x78
	public static readonly float ResolutionRateScreenOnGpuSaveMode; // 0x7C
	public static readonly float ResolutionRateRTOnGpuSaveMode; // 0x80

	// Properties
	public static float maxShadowBias { get; }
	public static float minRenderScale { get; }
	public static float maxRenderScale { get; }
	public static int maxPerObjectLights { get; }
	public static int maxVisibleAdditionalLights { get; }
	public static float overwriteShadowDistance { get; set; }
	public static UniversalRenderPipelineAsset asset { get; }
	public static bool gpuIsSaveMode { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x4847D0 Offset: 0x4848D1 VA: 0x4847D0
	// RVA: 0x2F91C20 Offset: 0x2F91D21 VA: 0x2F91C20
	public static void add_customBeginFrameRendering(Action<ScriptableRenderContext, Camera[]> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4847E0 Offset: 0x4848E1 VA: 0x4847E0
	// RVA: 0x2F91D20 Offset: 0x2F91E21 VA: 0x2F91D20
	public static void remove_customBeginFrameRendering(Action<ScriptableRenderContext, Camera[]> value) { }

	// RVA: 0x2F91E20 Offset: 0x2F91F21 VA: 0x2F91E20
	public static float get_maxShadowBias() { }

	// RVA: 0x2F91E30 Offset: 0x2F91F31 VA: 0x2F91E30
	public static float get_minRenderScale() { }

	// RVA: 0x2F91E40 Offset: 0x2F91F41 VA: 0x2F91E40
	public static float get_maxRenderScale() { }

	// RVA: 0x2F91E50 Offset: 0x2F91F51 VA: 0x2F91E50
	public static int get_maxPerObjectLights() { }

	// RVA: 0x2F91E80 Offset: 0x2F91F81 VA: 0x2F91E80
	public static int get_maxVisibleAdditionalLights() { }

	[CompilerGeneratedAttribute] // RVA: 0x4847F0 Offset: 0x4848F1 VA: 0x4847F0
	// RVA: 0x2F91F70 Offset: 0x2F92071 VA: 0x2F91F70
	public static float get_overwriteShadowDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x484800 Offset: 0x484901 VA: 0x484800
	// RVA: 0x2F91FE0 Offset: 0x2F920E1 VA: 0x2F91FE0
	public static void set_overwriteShadowDistance(float value) { }

	// RVA: 0x2F92050 Offset: 0x2F92151 VA: 0x2F92050
	public void .ctor(UniversalRenderPipelineAsset asset) { }

	// RVA: 0x2F92720 Offset: 0x2F92821 VA: 0x2F92720 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2F92A40 Offset: 0x2F92B41 VA: 0x2F92A40 Slot: 4
	protected override void Render(ScriptableRenderContext renderContext, Camera[] cameras) { }

	// RVA: 0x2F94BE0 Offset: 0x2F94CE1 VA: 0x2F94BE0
	public static void RenderSingleCamera(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x2F95620 Offset: 0x2F95721 VA: 0x2F95620
	private static bool TryGetCullingParameters(CameraData cameraData, out ScriptableCullingParameters cullingParams) { }

	// RVA: 0x2F94F00 Offset: 0x2F95001 VA: 0x2F94F00
	private static void RenderSingleCamera(ScriptableRenderContext context, CameraData cameraData, bool anyPostProcessingEnabled) { }

	// RVA: 0x2F93830 Offset: 0x2F93931 VA: 0x2F93830
	private static void RenderCameraStack(ScriptableRenderContext context, Camera baseCamera) { }

	// RVA: 0x2F94900 Offset: 0x2F94A01 VA: 0x2F94900
	private static void UpdateVolumeFramework(Camera camera, UniversalAdditionalCameraData additionalCameraData) { }

	// RVA: 0x2F98000 Offset: 0x2F98101 VA: 0x2F98000
	private static bool CheckPostProcessForDepth(in CameraData cameraData) { }

	// RVA: 0x2F92440 Offset: 0x2F92541 VA: 0x2F92440
	private static void SetSupportedRenderingFeatures() { }

	// RVA: 0x2F94DB0 Offset: 0x2F94EB1 VA: 0x2F94DB0
	private static void InitializeCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, out CameraData cameraData) { }

	// RVA: 0x2F980F0 Offset: 0x2F981F1 VA: 0x2F980F0
	private static void InitializeStackedCameraData(Camera baseCamera, UniversalAdditionalCameraData baseAdditionalCameraData, ref CameraData cameraData) { }

	// RVA: 0x2F96600 Offset: 0x2F96701 VA: 0x2F96600
	private static void InitializeAdditionalCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, ref CameraData cameraData) { }

	// RVA: 0x2F95770 Offset: 0x2F95871 VA: 0x2F95770
	private static void InitializeRenderingData(UniversalRenderPipelineAsset settings, ref CameraData cameraData, ref CullingResults cullResults, bool anyPostProcessingEnabled, out RenderingData renderingData) { }

	// RVA: 0x2F99C70 Offset: 0x2F99D71 VA: 0x2F99C70
	private static void InitializeShadowData(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, bool mainLightCastShadows, bool additionalLightsCastShadows, out ShadowData shadowData) { }

	// RVA: 0x2F9A270 Offset: 0x2F9A371 VA: 0x2F9A270
	private static void InitializePostProcessingData(UniversalRenderPipelineAsset settings, out PostProcessingData postProcessingData) { }

	// RVA: 0x2F99A60 Offset: 0x2F99B61 VA: 0x2F99A60
	private static void InitializeLightData(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, int mainLightIndex, int subLightIndex, int customShadowLightIndex, out LightData lightData) { }

	// RVA: 0x2F9A290 Offset: 0x2F9A391 VA: 0x2F9A290
	private static PerObjectData GetPerObjectLightFlags(int additionalLightsCount) { }

	// RVA: 0x2F9A490 Offset: 0x2F9A591 VA: 0x2F9A490
	private static int GetMainLightIndex(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights) { }

	// RVA: 0x2F93240 Offset: 0x2F93341 VA: 0x2F93240
	private static void SetupPerFrameShaderConstants() { }

	// RVA: 0x2F996D0 Offset: 0x2F997D1 VA: 0x2F996D0
	private static int GetCustomMainLightIndex(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, string subLightTag, int customShadowLightIndex) { }

	// RVA: 0x2F99910 Offset: 0x2F99A11 VA: 0x2F99910
	private static int GetCustomSubLightIndex(NativeArray<VisibleLight> visibleLights, string subLightTag) { }

	// RVA: 0x2F99570 Offset: 0x2F99671 VA: 0x2F99570
	private static int GetCustomShadowLightIndex(NativeArray<VisibleLight> visibleLights) { }

	// RVA: 0x2F93740 Offset: 0x2F93841 VA: 0x2F93740
	public static bool IsGameCamera(Camera camera) { }

	[ObsoleteAttribute] // RVA: 0x484810 Offset: 0x484911 VA: 0x484810
	// RVA: 0x2F9A730 Offset: 0x2F9A831 VA: 0x2F9A730
	public static bool IsStereoEnabled(Camera camera) { }

	// RVA: 0x2F91300 Offset: 0x2F91401 VA: 0x2F91300
	public static UniversalRenderPipelineAsset get_asset() { }

	[ObsoleteAttribute] // RVA: 0x484850 Offset: 0x484951 VA: 0x484850
	// RVA: 0x2F9A860 Offset: 0x2F9A961 VA: 0x2F9A860
	private static bool IsMultiPassStereoEnabled(Camera camera) { }

	// RVA: 0x2F936C0 Offset: 0x2F937C1 VA: 0x2F936C0
	private void SortCameras(Camera[] cameras) { }

	// RVA: 0x2F98FD0 Offset: 0x2F990D1 VA: 0x2F98FD0
	private static RenderTextureDescriptor CreateRenderTextureDescriptor(Camera camera, float renderScale, bool isHdrEnabled, int msaaSamples, bool needsAlpha) { }

	// RVA: 0x2F9A930 Offset: 0x2F9AA31 VA: 0x2F9A930
	public static void GetLightAttenuationAndSpotDirection(LightType lightType, float lightRange, Matrix4x4 lightLocalToWorldMatrix, float spotAngle, Nullable<float> innerSpotAngle, out Vector4 lightAttenuation, out Vector4 lightSpotDir) { }

	// RVA: 0x2F9AB70 Offset: 0x2F9AC71 VA: 0x2F9AB70
	public static void InitializeLightConstants_Common(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel) { }

	[CompilerGeneratedAttribute] // RVA: 0x484890 Offset: 0x484991 VA: 0x484890
	// RVA: 0x2F9B050 Offset: 0x2F9B151 VA: 0x2F9B050
	public static bool get_gpuIsSaveMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x4848A0 Offset: 0x4849A1 VA: 0x4848A0
	// RVA: 0x2F9B0C0 Offset: 0x2F9B1C1 VA: 0x2F9B0C0
	public static void set_gpuIsSaveMode(bool value) { }

	// RVA: 0x2F98FB0 Offset: 0x2F990B1 VA: 0x2F98FB0
	private static int CalcResolutionOnGpuSaveMode(int resolution) { }

	// RVA: 0x2F9A3B0 Offset: 0x2F9A4B1 VA: 0x2F9A3B0
	private static int CalcMainLightShadowmapResolution(UniversalRenderPipelineAsset settings) { }

	// RVA: 0x2F9B140 Offset: 0x2F9B241 VA: 0x2F9B140
	private static void .cctor() { }
}

