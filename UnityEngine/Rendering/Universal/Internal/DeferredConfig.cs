// Namespace: UnityEngine.Rendering.Universal.Internal
internal static class DeferredConfig // TypeDefIndex: 5383
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x482F90 Offset: 0x483091 VA: 0x482F90
	private static bool <IsOpenGL>k__BackingField; // 0x0
	public const int kPreferredCBufferSize = 65536;
	public const int kPreferredStructuredBufferSize = 131072;
	public const int kTilePixelWidth = 16;
	public const int kTilePixelHeight = 16;
	public const int kTilerDepth = 3;
	public const int kTilerSubdivisions = 4;
	public const int kAvgLightPerTile = 32;
	public const int kTileDepthInfoIntermediateLevel = 1;
	public const bool kHasNativeQuadSupport = True;

	// Properties
	internal static bool IsOpenGL { get; set; }
	internal static bool UseCBufferForDepthRange { get; }
	internal static bool UseCBufferForTileList { get; }
	internal static bool UseCBufferForLightData { get; }
	internal static bool UseCBufferForLightList { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x4849E0 Offset: 0x484AE1 VA: 0x4849E0
	// RVA: 0x2D3BBD0 Offset: 0x2D3BCD1 VA: 0x2D3BBD0
	internal static bool get_IsOpenGL() { }

	[CompilerGeneratedAttribute] // RVA: 0x4849F0 Offset: 0x484AF1 VA: 0x4849F0
	// RVA: 0x2D3BC20 Offset: 0x2D3BD21 VA: 0x2D3BC20
	internal static void set_IsOpenGL(bool value) { }

	// RVA: 0x2D3BC80 Offset: 0x2D3BD81 VA: 0x2D3BC80
	internal static bool get_UseCBufferForDepthRange() { }

	// RVA: 0x2D3BC90 Offset: 0x2D3BD91 VA: 0x2D3BC90
	internal static bool get_UseCBufferForTileList() { }

	// RVA: 0x2D3BCA0 Offset: 0x2D3BDA1 VA: 0x2D3BCA0
	internal static bool get_UseCBufferForLightData() { }

	// RVA: 0x2D3BCB0 Offset: 0x2D3BDB1 VA: 0x2D3BCB0
	internal static bool get_UseCBufferForLightList() { }
}

