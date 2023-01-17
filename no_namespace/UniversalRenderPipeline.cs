// Namespace: 
public static class UniversalRenderPipeline.Profiling.Pipeline.Context // TypeDefIndex: 5354
{
	// Fields
	private const string k_Name = "Context";
	public static readonly ProfilingSampler submit; // 0x0

	// Methods

	// RVA: 0x2FA7970 Offset: 0x2FA7A71 VA: 0x2FA7970
	private static void .cctor() { }
}

// Namespace: 
public static class UniversalRenderPipeline.Profiling.Pipeline // TypeDefIndex: 5356
{
	// Fields
	public static readonly ProfilingSampler beginFrameRendering; // 0x0
	public static readonly ProfilingSampler endFrameRendering; // 0x8
	public static readonly ProfilingSampler beginCameraRendering; // 0x10
	public static readonly ProfilingSampler endCameraRendering; // 0x18
	private const string k_Name = "UniversalRenderPipeline";
	public static readonly ProfilingSampler initializeCameraData; // 0x20
	public static readonly ProfilingSampler initializeStackedCameraData; // 0x28
	public static readonly ProfilingSampler initializeAdditionalCameraData; // 0x30
	public static readonly ProfilingSampler initializeRenderingData; // 0x38
	public static readonly ProfilingSampler initializeShadowData; // 0x40
	public static readonly ProfilingSampler initializeLightData; // 0x48
	public static readonly ProfilingSampler getPerObjectLightFlags; // 0x50
	public static readonly ProfilingSampler getMainLightIndex; // 0x58
	public static readonly ProfilingSampler setupPerFrameShaderConstants; // 0x60

	// Methods

	// RVA: 0x2FA75C0 Offset: 0x2FA76C1 VA: 0x2FA75C0
	private static void .cctor() { }
}

// Namespace: 
public static class UniversalRenderPipeline.CustomRPTime // TypeDefIndex: 5358
{
	// Fields
	public static bool _Enabled; // 0x0
	public static double _Time; // 0x8
	public static double _PrevTime; // 0x10
	public static readonly double _TimeResetValue; // 0x18

	// Methods

	// RVA: 0x2FA6F90 Offset: 0x2FA7091 VA: 0x2FA6F90
	private static void .cctor() { }
}

