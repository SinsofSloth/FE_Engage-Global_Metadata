// Namespace: UnityEngine.Rendering.Universal.Internal
internal class DeferredLights // TypeDefIndex: 5389
{
	// Fields
	private static readonly string k_SetupLights; // 0x0
	private static readonly string k_DeferredPass; // 0x8
	private static readonly string k_TileDepthInfo; // 0x10
	private static readonly string k_DeferredTiledPass; // 0x18
	private static readonly string k_DeferredStencilPass; // 0x20
	private static readonly string k_DeferredFogPass; // 0x28
	private static readonly string k_ClearStencilPartial; // 0x30
	private static readonly string k_SetupLightConstants; // 0x38
	private static readonly float kStencilShapeGuard; // 0x40
	private static readonly ProfilingSampler m_ProfilingSetupLights; // 0x48
	private static readonly ProfilingSampler m_ProfilingDeferredPass; // 0x50
	private static readonly ProfilingSampler m_ProfilingTileDepthInfo; // 0x58
	private static readonly ProfilingSampler m_ProfilingSetupLightConstants; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x482FA0 Offset: 0x4830A1 VA: 0x482FA0
	private bool <UseRenderPass>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x482FB0 Offset: 0x4830B1 VA: 0x482FB0
	private bool <HasDepthPrepass>k__BackingField; // 0x11
	[CompilerGeneratedAttribute] // RVA: 0x482FC0 Offset: 0x4830C1 VA: 0x482FC0
	private bool <IsOverlay>k__BackingField; // 0x12
	[CompilerGeneratedAttribute] // RVA: 0x482FD0 Offset: 0x4830D1 VA: 0x482FD0
	private bool <AccurateGbufferNormals>k__BackingField; // 0x13
	[CompilerGeneratedAttribute] // RVA: 0x482FE0 Offset: 0x4830E1 VA: 0x482FE0
	private bool <TiledDeferredShading>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x482FF0 Offset: 0x4830F1 VA: 0x482FF0
	private MixedLightingSetup <MixedLightingSetup>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x483000 Offset: 0x483101 VA: 0x483000
	private bool <UseJobSystem>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x483010 Offset: 0x483111 VA: 0x483010
	private int <RenderWidth>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x483020 Offset: 0x483121 VA: 0x483020
	private int <RenderHeight>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x483030 Offset: 0x483131 VA: 0x483030
	private RenderTargetHandle[] <GbufferAttachments>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x483040 Offset: 0x483141 VA: 0x483040
	private RenderTargetHandle <DepthAttachment>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x483050 Offset: 0x483151 VA: 0x483050
	private RenderTargetHandle <DepthCopyTexture>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x483060 Offset: 0x483161 VA: 0x483060
	private RenderTargetHandle <DepthInfoTexture>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x483070 Offset: 0x483171 VA: 0x483070
	private RenderTargetHandle <TileDepthInfoTexture>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x483080 Offset: 0x483181 VA: 0x483080
	private RenderTargetIdentifier[] <GbufferAttachmentIdentifiers>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x483090 Offset: 0x483191 VA: 0x483090
	private RenderTargetIdentifier <DepthAttachmentIdentifier>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x4830A0 Offset: 0x4831A1 VA: 0x4830A0
	private RenderTargetIdentifier <DepthCopyTextureIdentifier>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x4830B0 Offset: 0x4831B1 VA: 0x4830B0
	private RenderTargetIdentifier <DepthInfoTextureIdentifier>k__BackingField; // 0x148
	[CompilerGeneratedAttribute] // RVA: 0x4830C0 Offset: 0x4831C1 VA: 0x4830C0
	private RenderTargetIdentifier <TileDepthInfoTextureIdentifier>k__BackingField; // 0x170
	private int m_CachedRenderWidth; // 0x198
	private int m_CachedRenderHeight; // 0x19C
	private Matrix4x4 m_CachedProjectionMatrix; // 0x1A0
	private DeferredTiler[] m_Tilers; // 0x1E0
	private int[] m_TileDataCapacities; // 0x1E8
	private bool m_HasTileVisLights; // 0x1F0
	private NativeArray<ushort> m_stencilVisLights; // 0x1F8
	private NativeArray<ushort> m_stencilVisLightOffsets; // 0x208
	private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass; // 0x218
	private Mesh m_SphereMesh; // 0x220
	private Mesh m_HemisphereMesh; // 0x228
	private Mesh m_FullscreenMesh; // 0x230
	private int m_MaxDepthRangePerBatch; // 0x238
	private int m_MaxTilesPerBatch; // 0x23C
	private int m_MaxPunctualLightPerBatch; // 0x240
	private int m_MaxRelLightIndicesPerBatch; // 0x244
	private Material m_TileDepthInfoMaterial; // 0x248
	private Material m_TileDeferredMaterial; // 0x250
	private Material m_StencilDeferredMaterial; // 0x258
	private Matrix4x4[] m_ScreenToWorld; // 0x260
	private ProfilingSampler m_ProfilingSamplerDeferredTiledPass; // 0x268
	private ProfilingSampler m_ProfilingSamplerDeferredStencilPass; // 0x270
	private ProfilingSampler m_ProfilingSamplerDeferredFogPass; // 0x278
	private ProfilingSampler m_ProfilingSamplerClearStencilPartialPass; // 0x280

	// Properties
	internal int GbufferDepthIndex { get; }
	internal int GBufferAlbedoIndex { get; }
	internal int GBufferSpecularMetallicIndex { get; }
	internal int GBufferNormalSmoothnessIndex { get; }
	internal int GBufferLightingIndex { get; }
	internal int GBufferShadowMask { get; }
	internal int GBufferSliceCount { get; }
	internal bool UseShadowMask { get; }
	internal bool UseRenderPass { get; set; }
	internal bool HasDepthPrepass { get; set; }
	internal bool IsOverlay { get; set; }
	internal bool AccurateGbufferNormals { get; set; }
	internal bool TiledDeferredShading { get; set; }
	internal MixedLightingSetup MixedLightingSetup { get; set; }
	internal bool UseJobSystem { get; set; }
	internal int RenderWidth { get; set; }
	internal int RenderHeight { get; set; }
	internal RenderTargetHandle[] GbufferAttachments { get; set; }
	internal RenderTargetHandle DepthAttachment { get; set; }
	internal RenderTargetHandle DepthCopyTexture { get; set; }
	internal RenderTargetHandle DepthInfoTexture { get; set; }
	internal RenderTargetHandle TileDepthInfoTexture { get; set; }
	internal RenderTargetIdentifier[] GbufferAttachmentIdentifiers { get; set; }
	internal RenderTargetIdentifier DepthAttachmentIdentifier { get; set; }
	internal RenderTargetIdentifier DepthCopyTextureIdentifier { get; set; }
	internal RenderTargetIdentifier DepthInfoTextureIdentifier { get; set; }
	internal RenderTargetIdentifier TileDepthInfoTextureIdentifier { get; set; }

	// Methods

	// RVA: 0x2D3BCC0 Offset: 0x2D3BDC1 VA: 0x2D3BCC0
	internal int get_GbufferDepthIndex() { }

	// RVA: 0x2D3BCD0 Offset: 0x2D3BDD1 VA: 0x2D3BCD0
	internal int get_GBufferAlbedoIndex() { }

	// RVA: 0x2D3BCE0 Offset: 0x2D3BDE1 VA: 0x2D3BCE0
	internal int get_GBufferSpecularMetallicIndex() { }

	// RVA: 0x2D3BCF0 Offset: 0x2D3BDF1 VA: 0x2D3BCF0
	internal int get_GBufferNormalSmoothnessIndex() { }

	// RVA: 0x2D3BD00 Offset: 0x2D3BE01 VA: 0x2D3BD00
	internal int get_GBufferLightingIndex() { }

	// RVA: 0x2D3BD10 Offset: 0x2D3BE11 VA: 0x2D3BD10
	internal int get_GBufferShadowMask() { }

	// RVA: 0x2D3BD50 Offset: 0x2D3BE51 VA: 0x2D3BD50
	internal int get_GBufferSliceCount() { }

	// RVA: 0x2D3BD70 Offset: 0x2D3BE71 VA: 0x2D3BD70
	internal GraphicsFormat GetGBufferFormat(int index) { }

	// RVA: 0x2D3BD40 Offset: 0x2D3BE41 VA: 0x2D3BD40
	internal bool get_UseShadowMask() { }

	[CompilerGeneratedAttribute] // RVA: 0x484A00 Offset: 0x484B01 VA: 0x484A00
	// RVA: 0x2D3BE30 Offset: 0x2D3BF31 VA: 0x2D3BE30
	internal bool get_UseRenderPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x484A10 Offset: 0x484B11 VA: 0x484A10
	// RVA: 0x2D3BE40 Offset: 0x2D3BF41 VA: 0x2D3BE40
	internal void set_UseRenderPass(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484A20 Offset: 0x484B21 VA: 0x484A20
	// RVA: 0x2D3BE50 Offset: 0x2D3BF51 VA: 0x2D3BE50
	internal bool get_HasDepthPrepass() { }

	[CompilerGeneratedAttribute] // RVA: 0x484A30 Offset: 0x484B31 VA: 0x484A30
	// RVA: 0x2D3BE60 Offset: 0x2D3BF61 VA: 0x2D3BE60
	internal void set_HasDepthPrepass(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484A40 Offset: 0x484B41 VA: 0x484A40
	// RVA: 0x2D3BE70 Offset: 0x2D3BF71 VA: 0x2D3BE70
	internal bool get_IsOverlay() { }

	[CompilerGeneratedAttribute] // RVA: 0x484A50 Offset: 0x484B51 VA: 0x484A50
	// RVA: 0x2D3BE80 Offset: 0x2D3BF81 VA: 0x2D3BE80
	internal void set_IsOverlay(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484A60 Offset: 0x484B61 VA: 0x484A60
	// RVA: 0x2D3BE90 Offset: 0x2D3BF91 VA: 0x2D3BE90
	internal bool get_AccurateGbufferNormals() { }

	[CompilerGeneratedAttribute] // RVA: 0x484A70 Offset: 0x484B71 VA: 0x484A70
	// RVA: 0x2D3BEA0 Offset: 0x2D3BFA1 VA: 0x2D3BEA0
	internal void set_AccurateGbufferNormals(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484A80 Offset: 0x484B81 VA: 0x484A80
	// RVA: 0x2D3BEB0 Offset: 0x2D3BFB1 VA: 0x2D3BEB0
	internal bool get_TiledDeferredShading() { }

	[CompilerGeneratedAttribute] // RVA: 0x484A90 Offset: 0x484B91 VA: 0x484A90
	// RVA: 0x2D3BEC0 Offset: 0x2D3BFC1 VA: 0x2D3BEC0
	internal void set_TiledDeferredShading(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484AA0 Offset: 0x484BA1 VA: 0x484AA0
	// RVA: 0x2D3BED0 Offset: 0x2D3BFD1 VA: 0x2D3BED0
	internal MixedLightingSetup get_MixedLightingSetup() { }

	[CompilerGeneratedAttribute] // RVA: 0x484AB0 Offset: 0x484BB1 VA: 0x484AB0
	// RVA: 0x2D3BEE0 Offset: 0x2D3BFE1 VA: 0x2D3BEE0
	internal void set_MixedLightingSetup(MixedLightingSetup value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484AC0 Offset: 0x484BC1 VA: 0x484AC0
	// RVA: 0x2D3BEF0 Offset: 0x2D3BFF1 VA: 0x2D3BEF0
	internal bool get_UseJobSystem() { }

	[CompilerGeneratedAttribute] // RVA: 0x484AD0 Offset: 0x484BD1 VA: 0x484AD0
	// RVA: 0x2D3BF00 Offset: 0x2D3C001 VA: 0x2D3BF00
	internal void set_UseJobSystem(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484AE0 Offset: 0x484BE1 VA: 0x484AE0
	// RVA: 0x2D3BF10 Offset: 0x2D3C011 VA: 0x2D3BF10
	internal int get_RenderWidth() { }

	[CompilerGeneratedAttribute] // RVA: 0x484AF0 Offset: 0x484BF1 VA: 0x484AF0
	// RVA: 0x2D3BF20 Offset: 0x2D3C021 VA: 0x2D3BF20
	internal void set_RenderWidth(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484B00 Offset: 0x484C01 VA: 0x484B00
	// RVA: 0x2D3BF30 Offset: 0x2D3C031 VA: 0x2D3BF30
	internal int get_RenderHeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x484B10 Offset: 0x484C11 VA: 0x484B10
	// RVA: 0x2D3BF40 Offset: 0x2D3C041 VA: 0x2D3BF40
	internal void set_RenderHeight(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484B20 Offset: 0x484C21 VA: 0x484B20
	// RVA: 0x2D3BF50 Offset: 0x2D3C051 VA: 0x2D3BF50
	internal RenderTargetHandle[] get_GbufferAttachments() { }

	[CompilerGeneratedAttribute] // RVA: 0x484B30 Offset: 0x484C31 VA: 0x484B30
	// RVA: 0x2D3BF60 Offset: 0x2D3C061 VA: 0x2D3BF60
	internal void set_GbufferAttachments(RenderTargetHandle[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484B40 Offset: 0x484C41 VA: 0x484B40
	// RVA: 0x2D3BF70 Offset: 0x2D3C071 VA: 0x2D3BF70
	internal RenderTargetHandle get_DepthAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x484B50 Offset: 0x484C51 VA: 0x484B50
	// RVA: 0x2D3BF90 Offset: 0x2D3C091 VA: 0x2D3BF90
	internal void set_DepthAttachment(RenderTargetHandle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484B60 Offset: 0x484C61 VA: 0x484B60
	// RVA: 0x2D3BFB0 Offset: 0x2D3C0B1 VA: 0x2D3BFB0
	internal RenderTargetHandle get_DepthCopyTexture() { }

	[CompilerGeneratedAttribute] // RVA: 0x484B70 Offset: 0x484C71 VA: 0x484B70
	// RVA: 0x2D3BFD0 Offset: 0x2D3C0D1 VA: 0x2D3BFD0
	internal void set_DepthCopyTexture(RenderTargetHandle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484B80 Offset: 0x484C81 VA: 0x484B80
	// RVA: 0x2D3BFF0 Offset: 0x2D3C0F1 VA: 0x2D3BFF0
	internal RenderTargetHandle get_DepthInfoTexture() { }

	[CompilerGeneratedAttribute] // RVA: 0x484B90 Offset: 0x484C91 VA: 0x484B90
	// RVA: 0x2D3C010 Offset: 0x2D3C111 VA: 0x2D3C010
	internal void set_DepthInfoTexture(RenderTargetHandle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484BA0 Offset: 0x484CA1 VA: 0x484BA0
	// RVA: 0x2D3C030 Offset: 0x2D3C131 VA: 0x2D3C030
	internal RenderTargetHandle get_TileDepthInfoTexture() { }

	[CompilerGeneratedAttribute] // RVA: 0x484BB0 Offset: 0x484CB1 VA: 0x484BB0
	// RVA: 0x2D3C050 Offset: 0x2D3C151 VA: 0x2D3C050
	internal void set_TileDepthInfoTexture(RenderTargetHandle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484BC0 Offset: 0x484CC1 VA: 0x484BC0
	// RVA: 0x2D3C070 Offset: 0x2D3C171 VA: 0x2D3C070
	internal RenderTargetIdentifier[] get_GbufferAttachmentIdentifiers() { }

	[CompilerGeneratedAttribute] // RVA: 0x484BD0 Offset: 0x484CD1 VA: 0x484BD0
	// RVA: 0x2D3C080 Offset: 0x2D3C181 VA: 0x2D3C080
	internal void set_GbufferAttachmentIdentifiers(RenderTargetIdentifier[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484BE0 Offset: 0x484CE1 VA: 0x484BE0
	// RVA: 0x2D3C090 Offset: 0x2D3C191 VA: 0x2D3C090
	internal RenderTargetIdentifier get_DepthAttachmentIdentifier() { }

	[CompilerGeneratedAttribute] // RVA: 0x484BF0 Offset: 0x484CF1 VA: 0x484BF0
	// RVA: 0x2D3C0B0 Offset: 0x2D3C1B1 VA: 0x2D3C0B0
	internal void set_DepthAttachmentIdentifier(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484C00 Offset: 0x484D01 VA: 0x484C00
	// RVA: 0x2D3C0D0 Offset: 0x2D3C1D1 VA: 0x2D3C0D0
	internal RenderTargetIdentifier get_DepthCopyTextureIdentifier() { }

	[CompilerGeneratedAttribute] // RVA: 0x484C10 Offset: 0x484D11 VA: 0x484C10
	// RVA: 0x2D3C0F0 Offset: 0x2D3C1F1 VA: 0x2D3C0F0
	internal void set_DepthCopyTextureIdentifier(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484C20 Offset: 0x484D21 VA: 0x484C20
	// RVA: 0x2D3C110 Offset: 0x2D3C211 VA: 0x2D3C110
	internal RenderTargetIdentifier get_DepthInfoTextureIdentifier() { }

	[CompilerGeneratedAttribute] // RVA: 0x484C30 Offset: 0x484D31 VA: 0x484C30
	// RVA: 0x2D3C130 Offset: 0x2D3C231 VA: 0x2D3C130
	internal void set_DepthInfoTextureIdentifier(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x484C40 Offset: 0x484D41 VA: 0x484C40
	// RVA: 0x2D3C150 Offset: 0x2D3C251 VA: 0x2D3C150
	internal RenderTargetIdentifier get_TileDepthInfoTextureIdentifier() { }

	[CompilerGeneratedAttribute] // RVA: 0x484C50 Offset: 0x484D51 VA: 0x484C50
	// RVA: 0x2D3C170 Offset: 0x2D3C271 VA: 0x2D3C170
	internal void set_TileDepthInfoTextureIdentifier(RenderTargetIdentifier value) { }

	// RVA: 0x2D3C190 Offset: 0x2D3C291 VA: 0x2D3C190
	internal void .ctor(Material tileDepthInfoMaterial, Material tileDeferredMaterial, Material stencilDeferredMaterial) { }

	// RVA: 0x2D3CB80 Offset: 0x2D3CC81 VA: 0x2D3CB80
	internal ref DeferredTiler GetTiler(int i) { }

	// RVA: 0x2D3CBC0 Offset: 0x2D3CCC1 VA: 0x2D3CBC0
	internal void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D3E3A0 Offset: 0x2D3E4A1 VA: 0x2D3E3A0
	public void ResolveMixedLightingMode(ref RenderingData renderingData) { }

	// RVA: 0x2D3E500 Offset: 0x2D3E601 VA: 0x2D3E500
	public bool IsRuntimeSupportedThisFrame() { }

	// RVA: 0x2D3E590 Offset: 0x2D3E691 VA: 0x2D3E590
	public void Setup(ref RenderingData renderingData, AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass, bool hasDepthPrepass, bool isOverlay, RenderTargetHandle depthCopyTexture, RenderTargetHandle depthInfoTexture, RenderTargetHandle tileDepthInfoTexture, RenderTargetHandle depthAttachment, RenderTargetHandle[] gbufferHandles) { }

	// RVA: 0x2D3EFD0 Offset: 0x2D3F0D1 VA: 0x2D3EFD0
	public void OnCameraCleanup(CommandBuffer cmd) { }

	// RVA: 0x2D3F1D0 Offset: 0x2D3F2D1 VA: 0x2D3F1D0
	internal static StencilState OverwriteStencil(StencilState s, int stencilWriteMask) { }

	// RVA: 0x2D3F3A0 Offset: 0x2D3F4A1 VA: 0x2D3F3A0
	internal static RenderStateBlock OverwriteStencil(RenderStateBlock block, int stencilWriteMask, int stencilRef) { }

	// RVA: 0x2D3F640 Offset: 0x2D3F741 VA: 0x2D3F640
	internal bool HasTileLights() { }

	// RVA: 0x2D3F650 Offset: 0x2D3F751 VA: 0x2D3F650
	internal bool HasTileDepthRangeExtraPass() { }

	// RVA: 0x2D3F6C0 Offset: 0x2D3F7C1 VA: 0x2D3F6C0
	internal void ExecuteTileDepthInfoPass(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D40380 Offset: 0x2D40481 VA: 0x2D40380
	internal void ExecuteDownsampleBitmaskPass(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D40970 Offset: 0x2D40A71 VA: 0x2D40970
	internal void ClearStencilPartial(CommandBuffer cmd) { }

	// RVA: 0x2D40C40 Offset: 0x2D40D41 VA: 0x2D40C40
	internal void ExecuteDeferredPass(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2D3E2C0 Offset: 0x2D3E3C1 VA: 0x2D3E2C0
	private void SetupShaderLightConstants(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2D42D70 Offset: 0x2D42E71 VA: 0x2D42D70
	private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData) { }

	// RVA: 0x2D40E90 Offset: 0x2D40F91 VA: 0x2D40E90
	private void SetupMatrixConstants(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2D3E2D0 Offset: 0x2D3E3D1 VA: 0x2D3E2D0
	private void SortLights(ref NativeArray<DeferredTiler.PrePunctualLight> prePunctualLights) { }

	// RVA: 0x2D3EE40 Offset: 0x2D3EF41 VA: 0x2D3EE40
	private bool CheckHasTileLights(ref NativeArray<VisibleLight> visibleLights) { }

	// RVA: 0x2D3DA30 Offset: 0x2D3DB31 VA: 0x2D3DA30
	private void PrecomputeLights(out NativeArray<DeferredTiler.PrePunctualLight> prePunctualLights, out NativeArray<ushort> stencilVisLights, out NativeArray<ushort> stencilVisLightOffsets, ref NativeArray<VisibleLight> visibleLights, bool hasAdditionalLights, Matrix4x4 view, bool isOrthographic, float zNear) { }

	// RVA: 0x2D41630 Offset: 0x2D41731 VA: 0x2D41630
	private void RenderTileLights(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2D42830 Offset: 0x2D42931 VA: 0x2D42830
	private void RenderStencilLights(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2D43E70 Offset: 0x2D43F71 VA: 0x2D43E70
	private void RenderStencilDirectionalLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights, int mainLightIndex) { }

	// RVA: 0x2D444A0 Offset: 0x2D445A1 VA: 0x2D444A0
	private void RenderStencilPointLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights) { }

	// RVA: 0x2D44BF0 Offset: 0x2D44CF1 VA: 0x2D44BF0
	private void RenderStencilSpotLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights) { }

	// RVA: 0x2D42BD0 Offset: 0x2D42CD1 VA: 0x2D42BD0
	private void RenderFog(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2D42EA0 Offset: 0x2D42FA1 VA: 0x2D42EA0
	private int TrimLights(ref NativeArray<ushort> trimmedLights, ref NativeArray<ushort> tiles, int offset, int lightCount, ref BitArray usedLights) { }

	// RVA: 0x2D42F50 Offset: 0x2D43051 VA: 0x2D42F50
	private void StorePunctualLightData(ref NativeArray<uint4> punctualLightBuffer, int storeIndex, ref NativeArray<VisibleLight> visibleLights, int index) { }

	// RVA: 0x2D42F30 Offset: 0x2D43031 VA: 0x2D42F30
	private void StoreTileData(ref NativeArray<uint4> tileList, int storeIndex, uint tileID, uint listBitMask, ushort relLightOffset, ushort lightCount) { }

	// RVA: 0x2D45470 Offset: 0x2D45571 VA: 0x2D45470
	private bool IsTileLight(VisibleLight visibleLight) { }

	// RVA: 0x2D43230 Offset: 0x2D43331 VA: 0x2D43230
	private static Mesh CreateSphereMesh() { }

	// RVA: 0x2D43880 Offset: 0x2D43981 VA: 0x2D43880
	private static Mesh CreateHemisphereMesh() { }

	// RVA: 0x2D40AF0 Offset: 0x2D40BF1 VA: 0x2D40AF0
	private static Mesh CreateFullscreenMesh() { }

	// RVA: 0x2D42F00 Offset: 0x2D43001 VA: 0x2D42F00
	private static int Align(int s, int alignment) { }

	// RVA: 0x2D42F20 Offset: 0x2D43021 VA: 0x2D42F20
	private static uint PackTileID(uint i, uint j) { }

	// RVA: 0x2D453B0 Offset: 0x2D454B1 VA: 0x2D453B0
	private static uint FloatToUInt(float val) { }

	// RVA: 0x2D455B0 Offset: 0x2D456B1 VA: 0x2D455B0
	private static uint Half2ToUInt(float x, float y) { }

	// RVA: 0x2D45600 Offset: 0x2D45701 VA: 0x2D45600
	private static void .cctor() { }
}

