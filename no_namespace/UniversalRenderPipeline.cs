// Namespace: 
public static class UniversalRenderPipeline.Profiling.Pipeline.Renderer // TypeDefIndex: 5353
{
	// Fields
	private const string k_Name = "ScriptableRenderer";
	public static readonly ProfilingSampler setupCullingParameters; // 0x0
	public static readonly ProfilingSampler setup; // 0x8

	// Methods

	// RVA: 0x2FA7A10 Offset: 0x2FA7B11 VA: 0x2FA7A10
	private static void .cctor() { }
}

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
public static class UniversalRenderPipeline.Profiling.Pipeline.XR // TypeDefIndex: 5355
{
	// Fields
	public static readonly ProfilingSampler mirrorView; // 0x0

	// Methods

	// RVA: 0x2FA7AF0 Offset: 0x2FA7BF1 VA: 0x2FA7AF0
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
private static class UniversalRenderPipeline.Profiling // TypeDefIndex: 5357
{
	// Fields
	private static Dictionary<int, ProfilingSampler> s_HashSamplerCache; // 0x0
	public static readonly ProfilingSampler unknownSampler; // 0x8

	// Methods

	// RVA: 0x2FA7010 Offset: 0x2FA7111 VA: 0x2FA7010
	public static ProfilingSampler TryGetOrAddCameraSampler(Camera camera) { }

	// RVA: 0x2FA7080 Offset: 0x2FA7181 VA: 0x2FA7080
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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x47FD50 Offset: 0x47FE51 VA: 0x47FD50
[Serializable]
private sealed class UniversalRenderPipeline.<>c // TypeDefIndex: 5359
{
	// Fields
	public static readonly UniversalRenderPipeline.<>c <>9; // 0x0
	public static Comparison<Camera> <>9__25_0; // 0x8

	// Methods

	// RVA: 0x2FA6DD0 Offset: 0x2FA6ED1 VA: 0x2FA6DD0
	private static void .cctor() { }

	// RVA: 0x2FA6E40 Offset: 0x2FA6F41 VA: 0x2FA6E40
	public void .ctor() { }

	// RVA: 0x2FA6E50 Offset: 0x2FA6F51 VA: 0x2FA6E50
	internal int <.ctor>b__25_0(Camera camera1, Camera camera2) { }

	// RVA: 0x2FA6ED0 Offset: 0x2FA6FD1 VA: 0x2FA6ED0
	internal void <.cctor>b__73_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }
}

