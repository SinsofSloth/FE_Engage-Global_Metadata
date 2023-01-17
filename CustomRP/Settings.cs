// Namespace: CustomRP
public class Settings // TypeDefIndex: 8899
{
	// Fields
	public static readonly Settings.ShadowPreset ShadowPreset_Default; // 0x0
	private static Settings.ShadowPreset s_CurrentShadowPreset; // 0x4
	private static float m_SkinQualityLOD1; // 0x8
	private static float m_SkinQualityLOD2; // 0xC
	private static bool m_SkinQualityLODEnabled; // 0x10

	// Methods

	// RVA: 0x232B4C0 Offset: 0x232B5C1 VA: 0x232B4C0
	public static void UpdateGpuPerformanceMode() { }

	// RVA: 0x232B5A0 Offset: 0x232B6A1 VA: 0x232B5A0
	public static bool IsGpuPerformanceModeBoost() { }

	// RVA: 0x232B670 Offset: 0x232B771 VA: 0x232B670
	public static void PauseShaderTime() { }

	// RVA: 0x232B6E0 Offset: 0x232B7E1 VA: 0x232B6E0
	public static void ResumeShaderTime() { }

	// RVA: 0x232B750 Offset: 0x232B851 VA: 0x232B750
	public static bool IsSRPBatchingEnabled() { }

	// RVA: 0x232B930 Offset: 0x232BA31 VA: 0x232B930
	public static void EnableSRPBatching() { }

	// RVA: 0x232BA70 Offset: 0x232BB71 VA: 0x232BA70
	public static void DisableSRPBatching() { }

	// RVA: 0x232BBA0 Offset: 0x232BCA1 VA: 0x232BBA0
	public static bool IsZPrepassEnabled() { }

	// RVA: 0x232BDC0 Offset: 0x232BEC1 VA: 0x232BDC0
	public static ZPrepassFeatureSet GetZPrepassFeature() { }

	// RVA: 0x232BF90 Offset: 0x232C091 VA: 0x232BF90
	public static void SetZPrepassFeature(ZPrepassFeatureSet feature) { }

	// RVA: 0x232C140 Offset: 0x232C241 VA: 0x232C140
	public static void ChangeShadowPreset(Settings.ShadowPreset preset) { }

	// RVA: 0x232C2C0 Offset: 0x232C3C1 VA: 0x232C2C0
	public static Settings.ShadowPreset GetCurrentShadowPreset() { }

	// RVA: 0x232C330 Offset: 0x232C431 VA: 0x232C330
	public static void SetShadowDistance(float distance) { }

	// RVA: 0x232C490 Offset: 0x232C591 VA: 0x232C490
	public static float GetShadowDistance() { }

	// RVA: 0x232C5D0 Offset: 0x232C6D1 VA: 0x232C5D0
	public static float GetDebugShadowDistance() { }

	// RVA: 0x232C690 Offset: 0x232C791 VA: 0x232C690
	public static void SetDebugShadowDistance(float distance) { }

	// RVA: 0x232C760 Offset: 0x232C861 VA: 0x232C760
	public static float GetActualShadowDistance() { }

	// RVA: 0x232C8F0 Offset: 0x232C9F1 VA: 0x232C8F0
	public static void SetLutMode(Settings.LutMode mode) { }

	// RVA: 0x232CA50 Offset: 0x232CB51 VA: 0x232CA50
	public static void SetSilhouetteVisibility(bool visibility) { }

	// RVA: 0x232CA60 Offset: 0x232CB61 VA: 0x232CA60
	public static int GetSilhouetteColorGroup(int index) { }

	// RVA: 0x232CA70 Offset: 0x232CB71 VA: 0x232CA70
	public static void SetOcclusionCastFlag(bool visibility) { }

	// RVA: 0x232CCA0 Offset: 0x232CDA1 VA: 0x232CCA0
	public static void SetRenderingFlag(bool enabled) { }

	// RVA: 0x232CDF0 Offset: 0x232CEF1 VA: 0x232CDF0
	public static bool IsRenderingFlagEnabled() { }

	// RVA: 0x232CF40 Offset: 0x232D041 VA: 0x232CF40
	public static void SetRenderScale(float scale) { }

	// RVA: 0x232D0A0 Offset: 0x232D1A1 VA: 0x232D0A0
	public static float GetRenderScale() { }

	// RVA: 0x232D1E0 Offset: 0x232D2E1 VA: 0x232D1E0
	public static float GetCustomAlpha(Settings.CustomAlphaType type) { }

	// RVA: 0x232D330 Offset: 0x232D431 VA: 0x232D330
	public static void SetCustomAlpha(Settings.CustomAlphaType type, float alpha) { }

	// RVA: 0x232D480 Offset: 0x232D581 VA: 0x232D480
	public static float GetCustomEV(Settings.CustomEVType type) { }

	// RVA: 0x232D530 Offset: 0x232D631 VA: 0x232D530
	public static void SetCustomEV(Settings.CustomEVType type, float ev) { }

	// RVA: 0x232D5E0 Offset: 0x232D6E1 VA: 0x232D5E0
	public static void SetCustomCaptureEnabled(bool enabled) { }

	// RVA: 0x232D670 Offset: 0x232D771 VA: 0x232D670
	public static void SetCustomBlur(bool enabled) { }

	// RVA: 0x232D760 Offset: 0x232D861 VA: 0x232D760
	public static void SetCustomBlur(bool enabled, int level) { }

	// RVA: 0x232D810 Offset: 0x232D911 VA: 0x232D810
	public static void SetSpecialFilterFlag(bool enabled) { }

	// RVA: 0x232D8A0 Offset: 0x232D9A1 VA: 0x232D8A0
	public static void SetSpecialFilterColor(Color color) { }

	// RVA: 0x232D940 Offset: 0x232DA41 VA: 0x232D940
	public static void SetSpecialFilterSaturation(float sat) { }

	// RVA: 0x232D9D0 Offset: 0x232DAD1 VA: 0x232D9D0
	public static void SpecialFilterRate(float rate) { }

	// RVA: 0x232DA60 Offset: 0x232DB61 VA: 0x232DA60
	public static void SpecialFilterWhiteRate(float rate) { }

	// RVA: 0x232DAF0 Offset: 0x232DBF1 VA: 0x232DAF0
	public static void SpecialFilterWhitePoint(float whitePoint) { }

	// RVA: 0x232DB80 Offset: 0x232DC81 VA: 0x232DB80
	public static void SetFinalMonoColor(Color color) { }

	// RVA: 0x232DC20 Offset: 0x232DD21 VA: 0x232DC20
	public static void SetFinalMonoColorRate(float rate) { }

	// RVA: 0x232DCB0 Offset: 0x232DDB1 VA: 0x232DCB0
	public static void SetWaterReflectionBaseY(float baseY) { }

	// RVA: 0x232DD80 Offset: 0x232DE81 VA: 0x232DD80
	public static void SetWaterReflectionBaseY(Settings.WaterReflectionType type, float baseY) { }

	// RVA: 0x232B8A0 Offset: 0x232B9A1 VA: 0x232B8A0
	public static UniversalRenderPipelineAsset GetSettings() { }

	// RVA: 0x232BD50 Offset: 0x232BE51 VA: 0x232BD50
	public static CustomForwardRenderer GetDefaultRenderer(UniversalRenderPipelineAsset settings) { }

	// RVA: 0x232CB00 Offset: 0x232CC01 VA: 0x232CB00
	public static CustomForwardRenderer GetDefaultRenderer() { }

	// RVA: 0x232DEF0 Offset: 0x232DFF1 VA: 0x232DEF0
	public static void SetSkinQualityLOD1(float dist) { }

	// RVA: 0x232DFF0 Offset: 0x232E0F1 VA: 0x232DFF0
	public static float GetSkinQualityLOD1() { }

	// RVA: 0x232E060 Offset: 0x232E161 VA: 0x232E060
	public static void SetSkinQualityLOD2(float dist) { }

	// RVA: 0x232E110 Offset: 0x232E211 VA: 0x232E110
	public static float GetSkinQualityLOD2() { }

	// RVA: 0x232E180 Offset: 0x232E281 VA: 0x232E180
	public static void SetSkinQualityLODEnabled(bool enabled) { }

	// RVA: 0x232E200 Offset: 0x232E301 VA: 0x232E200
	public static bool IsSkinQualityLODEnabled() { }

	// RVA: 0x232E270 Offset: 0x232E371 VA: 0x232E270
	public void .ctor() { }

	// RVA: 0x232E280 Offset: 0x232E381 VA: 0x232E280
	private static void .cctor() { }
}

