// Namespace: 
internal static class DeferredLights.ShaderConstants // TypeDefIndex: 5385
{
	// Fields
	public static readonly int _LitStencilRef; // 0x0
	public static readonly int _LitStencilReadMask; // 0x4
	public static readonly int _LitStencilWriteMask; // 0x8
	public static readonly int _SimpleLitStencilRef; // 0xC
	public static readonly int _SimpleLitStencilReadMask; // 0x10
	public static readonly int _SimpleLitStencilWriteMask; // 0x14
	public static readonly int _StencilRef; // 0x18
	public static readonly int _StencilReadMask; // 0x1C
	public static readonly int _StencilWriteMask; // 0x20
	public static readonly int _LitPunctualStencilRef; // 0x24
	public static readonly int _LitPunctualStencilReadMask; // 0x28
	public static readonly int _LitPunctualStencilWriteMask; // 0x2C
	public static readonly int _SimpleLitPunctualStencilRef; // 0x30
	public static readonly int _SimpleLitPunctualStencilReadMask; // 0x34
	public static readonly int _SimpleLitPunctualStencilWriteMask; // 0x38
	public static readonly int _LitDirStencilRef; // 0x3C
	public static readonly int _LitDirStencilReadMask; // 0x40
	public static readonly int _LitDirStencilWriteMask; // 0x44
	public static readonly int _SimpleLitDirStencilRef; // 0x48
	public static readonly int _SimpleLitDirStencilReadMask; // 0x4C
	public static readonly int _SimpleLitDirStencilWriteMask; // 0x50
	public static readonly int _ClearStencilRef; // 0x54
	public static readonly int _ClearStencilReadMask; // 0x58
	public static readonly int _ClearStencilWriteMask; // 0x5C
	public static readonly int UDepthRanges; // 0x60
	public static readonly int _DepthRanges; // 0x64
	public static readonly int _DownsamplingWidth; // 0x68
	public static readonly int _DownsamplingHeight; // 0x6C
	public static readonly int _SourceShiftX; // 0x70
	public static readonly int _SourceShiftY; // 0x74
	public static readonly int _TileShiftX; // 0x78
	public static readonly int _TileShiftY; // 0x7C
	public static readonly int _tileXCount; // 0x80
	public static readonly int _DepthRangeOffset; // 0x84
	public static readonly int _BitmaskTex; // 0x88
	public static readonly int UTileList; // 0x8C
	public static readonly int _TileList; // 0x90
	public static readonly int UPunctualLightBuffer; // 0x94
	public static readonly int _PunctualLightBuffer; // 0x98
	public static readonly int URelLightList; // 0x9C
	public static readonly int _RelLightList; // 0xA0
	public static readonly int _TilePixelWidth; // 0xA4
	public static readonly int _TilePixelHeight; // 0xA8
	public static readonly int _InstanceOffset; // 0xAC
	public static readonly int _DepthTex; // 0xB0
	public static readonly int _DepthTexSize; // 0xB4
	public static readonly int _ScreenSize; // 0xB8
	public static readonly int _ScreenToWorld; // 0xBC
	public static readonly int _unproject0; // 0xC0
	public static readonly int _unproject1; // 0xC4
	public static int _MainLightPosition; // 0xC8
	public static int _MainLightColor; // 0xCC
	public static int _SpotLightScale; // 0xD0
	public static int _SpotLightBias; // 0xD4
	public static int _SpotLightGuard; // 0xD8
	public static int _LightPosWS; // 0xDC
	public static int _LightColor; // 0xE0
	public static int _LightAttenuation; // 0xE4
	public static int _LightOcclusionProbInfo; // 0xE8
	public static int _LightDirection; // 0xEC
	public static int _LightFlags; // 0xF0
	public static int _ShadowLightIndex; // 0xF4

	// Methods

	// RVA: 0x2FA27E0 Offset: 0x2FA28E1 VA: 0x2FA27E0
	private static void .cctor() { }
}

// Namespace: 
private struct DeferredLights.CullLightsJob : IJob // TypeDefIndex: 5386
{
	// Fields
	public DeferredTiler tiler; // 0x0
	[ReadOnlyAttribute] // RVA: 0x4830D0 Offset: 0x4831D1 VA: 0x4830D0
	[NativeDisableContainerSafetyRestrictionAttribute] // RVA: 0x4830D0 Offset: 0x4831D1 VA: 0x4830D0
	public NativeArray<DeferredTiler.PrePunctualLight> prePunctualLights; // 0x78
	[NativeDisableContainerSafetyRestrictionAttribute] // RVA: 0x483110 Offset: 0x483211 VA: 0x483110
	[ReadOnlyAttribute] // RVA: 0x483110 Offset: 0x483211 VA: 0x483110
	public NativeArray<ushort> coarseTiles; // 0x88
	[ReadOnlyAttribute] // RVA: 0x483150 Offset: 0x483251 VA: 0x483150
	[NativeDisableContainerSafetyRestrictionAttribute] // RVA: 0x483150 Offset: 0x483251 VA: 0x483150
	public NativeArray<uint> coarseTileHeaders; // 0x98
	public int coarseHeaderOffset; // 0xA8
	public int istart; // 0xAC
	public int iend; // 0xB0
	public int jstart; // 0xB4
	public int jend; // 0xB8

	// Methods

	// RVA: 0x2FA2770 Offset: 0x2FA2871 VA: 0x2FA2770 Slot: 4
	public void Execute() { }
}

// Namespace: 
private struct DeferredLights.DrawCall // TypeDefIndex: 5387
{
	// Fields
	public ComputeBuffer tileList; // 0x0
	public ComputeBuffer punctualLightBuffer; // 0x8
	public ComputeBuffer relLightList; // 0x10
	public int tileListSize; // 0x18
	public int punctualLightBufferSize; // 0x1C
	public int relLightListSize; // 0x20
	public int instanceOffset; // 0x24
	public int instanceCount; // 0x28
}

// Namespace: 
internal enum DeferredLights.GBufferHandles // TypeDefIndex: 5388
{
	// Fields
	public int value__; // 0x0
	public const DeferredLights.GBufferHandles DepthAsColor = 0;
	public const DeferredLights.GBufferHandles Albedo = 1;
	public const DeferredLights.GBufferHandles SpecularMetallic = 2;
	public const DeferredLights.GBufferHandles NormalSmoothness = 3;
	public const DeferredLights.GBufferHandles Lighting = 4;
	public const DeferredLights.GBufferHandles ShadowMask = 5;
	public const DeferredLights.GBufferHandles Count = 6;
}

