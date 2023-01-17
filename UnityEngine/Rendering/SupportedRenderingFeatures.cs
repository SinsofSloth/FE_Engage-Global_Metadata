// Namespace: UnityEngine.Rendering
public class SupportedRenderingFeatures // TypeDefIndex: 3969
{
	// Fields
	private static SupportedRenderingFeatures s_Active; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x444FB0 Offset: 0x4450B1 VA: 0x444FB0
	[DebuggerBrowsableAttribute] // RVA: 0x444FB0 Offset: 0x4450B1 VA: 0x444FB0
	private SupportedRenderingFeatures.ReflectionProbeModes <reflectionProbeModes>k__BackingField; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x444FF0 Offset: 0x4450F1 VA: 0x444FF0
	[CompilerGeneratedAttribute] // RVA: 0x444FF0 Offset: 0x4450F1 VA: 0x444FF0
	private SupportedRenderingFeatures.LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; // 0x14
	[DebuggerBrowsableAttribute] // RVA: 0x445030 Offset: 0x445131 VA: 0x445030
	[CompilerGeneratedAttribute] // RVA: 0x445030 Offset: 0x445131 VA: 0x445030
	private SupportedRenderingFeatures.LightmapMixedBakeModes <mixedLightingModes>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x445070 Offset: 0x445171 VA: 0x445070
	[CompilerGeneratedAttribute] // RVA: 0x445070 Offset: 0x445171 VA: 0x445070
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; // 0x1C
	[DebuggerBrowsableAttribute] // RVA: 0x4450B0 Offset: 0x4451B1 VA: 0x4450B0
	[CompilerGeneratedAttribute] // RVA: 0x4450B0 Offset: 0x4451B1 VA: 0x4450B0
	private LightmapsMode <lightmapsModes>k__BackingField; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0x4450F0 Offset: 0x4451F1 VA: 0x4450F0
	[CompilerGeneratedAttribute] // RVA: 0x4450F0 Offset: 0x4451F1 VA: 0x4450F0
	private bool <enlighten>k__BackingField; // 0x24
	[DebuggerBrowsableAttribute] // RVA: 0x445130 Offset: 0x445231 VA: 0x445130
	[CompilerGeneratedAttribute] // RVA: 0x445130 Offset: 0x445231 VA: 0x445130
	private bool <lightProbeProxyVolumes>k__BackingField; // 0x25
	[CompilerGeneratedAttribute] // RVA: 0x445170 Offset: 0x445271 VA: 0x445170
	[DebuggerBrowsableAttribute] // RVA: 0x445170 Offset: 0x445271 VA: 0x445170
	private bool <motionVectors>k__BackingField; // 0x26
	[CompilerGeneratedAttribute] // RVA: 0x4451B0 Offset: 0x4452B1 VA: 0x4451B0
	[DebuggerBrowsableAttribute] // RVA: 0x4451B0 Offset: 0x4452B1 VA: 0x4451B0
	private bool <receiveShadows>k__BackingField; // 0x27
	[CompilerGeneratedAttribute] // RVA: 0x4451F0 Offset: 0x4452F1 VA: 0x4451F0
	[DebuggerBrowsableAttribute] // RVA: 0x4451F0 Offset: 0x4452F1 VA: 0x4451F0
	private bool <reflectionProbes>k__BackingField; // 0x28
	[DebuggerBrowsableAttribute] // RVA: 0x445230 Offset: 0x445331 VA: 0x445230
	[CompilerGeneratedAttribute] // RVA: 0x445230 Offset: 0x445331 VA: 0x445230
	private bool <rendererPriority>k__BackingField; // 0x29
	[DebuggerBrowsableAttribute] // RVA: 0x445270 Offset: 0x445371 VA: 0x445270
	[CompilerGeneratedAttribute] // RVA: 0x445270 Offset: 0x445371 VA: 0x445270
	private bool <terrainDetailUnsupported>k__BackingField; // 0x2A
	[DebuggerBrowsableAttribute] // RVA: 0x4452B0 Offset: 0x4453B1 VA: 0x4452B0
	[CompilerGeneratedAttribute] // RVA: 0x4452B0 Offset: 0x4453B1 VA: 0x4452B0
	private bool <rendersUIOverlay>k__BackingField; // 0x2B
	[CompilerGeneratedAttribute] // RVA: 0x4452F0 Offset: 0x4453F1 VA: 0x4452F0
	[DebuggerBrowsableAttribute] // RVA: 0x4452F0 Offset: 0x4453F1 VA: 0x4452F0
	private bool <overridesEnvironmentLighting>k__BackingField; // 0x2C
	[DebuggerBrowsableAttribute] // RVA: 0x445330 Offset: 0x445431 VA: 0x445330
	[CompilerGeneratedAttribute] // RVA: 0x445330 Offset: 0x445431 VA: 0x445330
	private bool <overridesFog>k__BackingField; // 0x2D
	[DebuggerBrowsableAttribute] // RVA: 0x445370 Offset: 0x445471 VA: 0x445370
	[CompilerGeneratedAttribute] // RVA: 0x445370 Offset: 0x445471 VA: 0x445370
	private bool <overridesRealtimeReflectionProbes>k__BackingField; // 0x2E
	[DebuggerBrowsableAttribute] // RVA: 0x4453B0 Offset: 0x4454B1 VA: 0x4453B0
	[CompilerGeneratedAttribute] // RVA: 0x4453B0 Offset: 0x4454B1 VA: 0x4453B0
	private bool <overridesOtherLightingSettings>k__BackingField; // 0x2F
	[CompilerGeneratedAttribute] // RVA: 0x4453F0 Offset: 0x4454F1 VA: 0x4453F0
	[DebuggerBrowsableAttribute] // RVA: 0x4453F0 Offset: 0x4454F1 VA: 0x4453F0
	private bool <editableMaterialRenderQueue>k__BackingField; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x445430 Offset: 0x445531 VA: 0x445430
	[CompilerGeneratedAttribute] // RVA: 0x445430 Offset: 0x445531 VA: 0x445430
	private bool <overridesLODBias>k__BackingField; // 0x31
	[CompilerGeneratedAttribute] // RVA: 0x445470 Offset: 0x445571 VA: 0x445470
	[DebuggerBrowsableAttribute] // RVA: 0x445470 Offset: 0x445571 VA: 0x445470
	private bool <overridesMaximumLODLevel>k__BackingField; // 0x32
	[DebuggerBrowsableAttribute] // RVA: 0x4454B0 Offset: 0x4455B1 VA: 0x4454B0
	[CompilerGeneratedAttribute] // RVA: 0x4454B0 Offset: 0x4455B1 VA: 0x4454B0
	private bool <rendererProbes>k__BackingField; // 0x33
	[DebuggerBrowsableAttribute] // RVA: 0x4454F0 Offset: 0x4455F1 VA: 0x4454F0
	[CompilerGeneratedAttribute] // RVA: 0x4454F0 Offset: 0x4455F1 VA: 0x4454F0
	private bool <particleSystemInstancing>k__BackingField; // 0x34
	[DebuggerBrowsableAttribute] // RVA: 0x445530 Offset: 0x445631 VA: 0x445530
	[CompilerGeneratedAttribute] // RVA: 0x445530 Offset: 0x445631 VA: 0x445530
	private bool <autoAmbientProbeBaking>k__BackingField; // 0x35
	[DebuggerBrowsableAttribute] // RVA: 0x445570 Offset: 0x445671 VA: 0x445570
	[CompilerGeneratedAttribute] // RVA: 0x445570 Offset: 0x445671 VA: 0x445570
	private bool <autoDefaultReflectionProbeBaking>k__BackingField; // 0x36
	[CompilerGeneratedAttribute] // RVA: 0x4455B0 Offset: 0x4456B1 VA: 0x4455B0
	[DebuggerBrowsableAttribute] // RVA: 0x4455B0 Offset: 0x4456B1 VA: 0x4455B0
	private bool <overridesShadowmask>k__BackingField; // 0x37
	[CompilerGeneratedAttribute] // RVA: 0x4455F0 Offset: 0x4456F1 VA: 0x4455F0
	[DebuggerBrowsableAttribute] // RVA: 0x4455F0 Offset: 0x4456F1 VA: 0x4455F0
	private string <overrideShadowmaskMessage>k__BackingField; // 0x38

	// Properties
	public static SupportedRenderingFeatures active { get; set; }
	public SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes { get; }
	public SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes { get; }
	public LightmapBakeType lightmapBakeTypes { get; }
	public LightmapsMode lightmapsModes { get; }
	public bool enlighten { get; }
	public bool rendersUIOverlay { get; }
	public bool autoAmbientProbeBaking { get; }
	public bool autoDefaultReflectionProbeBaking { get; }

	// Methods

	// RVA: 0x31F2BB0 Offset: 0x31F2CB1 VA: 0x31F2BB0
	public static SupportedRenderingFeatures get_active() { }

	// RVA: 0x31D9440 Offset: 0x31D9541 VA: 0x31D9440
	public static void set_active(SupportedRenderingFeatures value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4543D0 Offset: 0x4544D1 VA: 0x4543D0
	// RVA: 0x31F2D10 Offset: 0x31F2E11 VA: 0x31F2D10
	public SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	[CompilerGeneratedAttribute] // RVA: 0x4543E0 Offset: 0x4544E1 VA: 0x4543E0
	// RVA: 0x31F2D20 Offset: 0x31F2E21 VA: 0x31F2D20
	public SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes() { }

	[CompilerGeneratedAttribute] // RVA: 0x4543F0 Offset: 0x4544F1 VA: 0x4543F0
	// RVA: 0x31F2D30 Offset: 0x31F2E31 VA: 0x31F2D30
	public LightmapBakeType get_lightmapBakeTypes() { }

	[CompilerGeneratedAttribute] // RVA: 0x454400 Offset: 0x454501 VA: 0x454400
	// RVA: 0x31F2D40 Offset: 0x31F2E41 VA: 0x31F2D40
	public LightmapsMode get_lightmapsModes() { }

	[CompilerGeneratedAttribute] // RVA: 0x454410 Offset: 0x454511 VA: 0x454410
	// RVA: 0x31F2D50 Offset: 0x31F2E51 VA: 0x31F2D50
	public bool get_enlighten() { }

	[CompilerGeneratedAttribute] // RVA: 0x454420 Offset: 0x454521 VA: 0x454420
	// RVA: 0x31F2D60 Offset: 0x31F2E61 VA: 0x31F2D60
	public bool get_rendersUIOverlay() { }

	[CompilerGeneratedAttribute] // RVA: 0x454430 Offset: 0x454531 VA: 0x454430
	// RVA: 0x31F2D70 Offset: 0x31F2E71 VA: 0x31F2D70
	public bool get_autoAmbientProbeBaking() { }

	[CompilerGeneratedAttribute] // RVA: 0x454440 Offset: 0x454541 VA: 0x454440
	// RVA: 0x31F2D80 Offset: 0x31F2E81 VA: 0x31F2D80
	public bool get_autoDefaultReflectionProbeBaking() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x454450 Offset: 0x454551 VA: 0x454450
	// RVA: 0x31F2D90 Offset: 0x31F2E91 VA: 0x31F2D90
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	// RVA: 0x31F2F60 Offset: 0x31F3061 VA: 0x31F2F60
	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x454460 Offset: 0x454561 VA: 0x454460
	// RVA: 0x31F2FE0 Offset: 0x31F30E1 VA: 0x31F2FE0
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	// RVA: 0x31F3180 Offset: 0x31F3281 VA: 0x31F3180
	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x454470 Offset: 0x454571 VA: 0x454470
	// RVA: 0x31F3200 Offset: 0x31F3301 VA: 0x31F3200
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x454480 Offset: 0x454581 VA: 0x454480
	// RVA: 0x31F33E0 Offset: 0x31F34E1 VA: 0x31F33E0
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x454490 Offset: 0x454591 VA: 0x454490
	// RVA: 0x31F3470 Offset: 0x31F3571 VA: 0x31F3470
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4544A0 Offset: 0x4545A1 VA: 0x4544A0
	// RVA: 0x31F3500 Offset: 0x31F3601 VA: 0x31F3500
	internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4544B0 Offset: 0x4545B1 VA: 0x4544B0
	// RVA: 0x31F3580 Offset: 0x31F3681 VA: 0x31F3580
	internal static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4544C0 Offset: 0x4545C1 VA: 0x4544C0
	// RVA: 0x31F3600 Offset: 0x31F3701 VA: 0x31F3600
	internal static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4544D0 Offset: 0x4545D1 VA: 0x4544D0
	// RVA: 0x31F3680 Offset: 0x31F3781 VA: 0x31F3680
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	// RVA: 0x31D93A0 Offset: 0x31D94A1 VA: 0x31D93A0
	public void .ctor() { }

	// RVA: 0x31F36A0 Offset: 0x31F37A1 VA: 0x31F36A0
	private static void .cctor() { }
}

