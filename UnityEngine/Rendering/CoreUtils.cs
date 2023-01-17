// Namespace: UnityEngine.Rendering
public static class CoreUtils // TypeDefIndex: 4625
{
	// Fields
	public static readonly Vector3[] lookAtList; // 0x0
	public static readonly Vector3[] upVectorList; // 0x8
	public const int editMenuPriority1 = 320;
	public const int editMenuPriority2 = 331;
	public const int editMenuPriority3 = 342;
	public const int editMenuPriority4 = 353;
	public const int assetCreateMenuPriority1 = 230;
	public const int assetCreateMenuPriority2 = 241;
	public const int assetCreateMenuPriority3 = 300;
	public const int gameObjectMenuPriority = 10;
	private static Cubemap m_BlackCubeTexture; // 0x10
	private static Cubemap m_MagentaCubeTexture; // 0x18
	private static CubemapArray m_MagentaCubeTextureArray; // 0x20
	private static Cubemap m_WhiteCubeTexture; // 0x28
	private static RenderTexture m_EmptyUAV; // 0x30
	private static Texture3D m_BlackVolumeTexture; // 0x38
	private static IEnumerable<Type> m_AssemblyTypes; // 0x40

	// Properties
	public static Cubemap blackCubeTexture { get; }
	public static Cubemap magentaCubeTexture { get; }
	public static CubemapArray magentaCubeTextureArray { get; }
	public static Cubemap whiteCubeTexture { get; }
	public static RenderTexture emptyUAV { get; }
	public static Texture3D blackVolumeTexture { get; }

	// Methods

	// RVA: 0x1B2DEC0 Offset: 0x1B2DFC1 VA: 0x1B2DEC0
	public static Cubemap get_blackCubeTexture() { }

	// RVA: 0x1B2E1C0 Offset: 0x1B2E2C1 VA: 0x1B2E1C0
	public static Cubemap get_magentaCubeTexture() { }

	// RVA: 0x1B2E4C0 Offset: 0x1B2E5C1 VA: 0x1B2E4C0
	public static CubemapArray get_magentaCubeTextureArray() { }

	// RVA: 0x1B2E880 Offset: 0x1B2E981 VA: 0x1B2E880
	public static Cubemap get_whiteCubeTexture() { }

	// RVA: 0x1B2EB80 Offset: 0x1B2EC81 VA: 0x1B2EB80
	public static RenderTexture get_emptyUAV() { }

	// RVA: 0x1B2ECE0 Offset: 0x1B2EDE1 VA: 0x1B2ECE0
	public static Texture3D get_blackVolumeTexture() { }

	// RVA: 0x1B2EE90 Offset: 0x1B2EF91 VA: 0x1B2EE90
	public static void ClearRenderTarget(CommandBuffer cmd, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x1B2EEB0 Offset: 0x1B2EFB1 VA: 0x1B2EEB0
	private static int FixupDepthSlice(int depthSlice, RTHandle buffer) { }

	// RVA: 0x1B2EEF0 Offset: 0x1B2EFF1 VA: 0x1B2EEF0
	private static int FixupDepthSlice(int depthSlice, CubemapFace cubemapFace) { }

	// RVA: 0x1B2EF10 Offset: 0x1B2F011 VA: 0x1B2EF10
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x1B2F030 Offset: 0x1B2F131 VA: 0x1B2F030
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag = 0, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x1B2F1C0 Offset: 0x1B2F2C1 VA: 0x1B2F1C0
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x1B2F4A0 Offset: 0x1B2F5A1 VA: 0x1B2F4A0
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x1B2F360 Offset: 0x1B2F461 VA: 0x1B2F360
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x1B2F680 Offset: 0x1B2F781 VA: 0x1B2F680
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer) { }

	// RVA: 0x1B2F8C0 Offset: 0x1B2F9C1 VA: 0x1B2F8C0
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag = 0) { }

	// RVA: 0x1B2F7B0 Offset: 0x1B2F8B1 VA: 0x1B2F7B0
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x1B2FA40 Offset: 0x1B2FB41 VA: 0x1B2FA40
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x1B2FB50 Offset: 0x1B2FC51 VA: 0x1B2FB50
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag) { }

	// RVA: 0x1B2FCD0 Offset: 0x1B2FDD1 VA: 0x1B2FCD0
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x1B2FE20 Offset: 0x1B2FF21 VA: 0x1B2FE20
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag) { }

	// RVA: 0x1B30010 Offset: 0x1B30111 VA: 0x1B30010
	private static void SetViewportAndClear(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x1B301D0 Offset: 0x1B302D1 VA: 0x1B301D0
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x1B30310 Offset: 0x1B30411 VA: 0x1B30310
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag = 0, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x1B303F0 Offset: 0x1B304F1 VA: 0x1B303F0
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x1B306D0 Offset: 0x1B307D1 VA: 0x1B306D0
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x1B30510 Offset: 0x1B30611 VA: 0x1B30510
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x1B30800 Offset: 0x1B30901 VA: 0x1B30800
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer) { }

	// RVA: 0x1B309A0 Offset: 0x1B30AA1 VA: 0x1B309A0
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag = 0) { }

	// RVA: 0x1B30A90 Offset: 0x1B30B91 VA: 0x1B30A90
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x1B30140 Offset: 0x1B30241 VA: 0x1B30140
	public static void SetViewport(CommandBuffer cmd, RTHandle target) { }

	// RVA: 0x1B30BA0 Offset: 0x1B30CA1 VA: 0x1B30BA0
	public static string GetRenderTargetAutoName(int width, int height, int depth, RenderTextureFormat format, string name, bool mips = False, bool enableMSAA = False, MSAASamples msaaSamples = 1) { }

	// RVA: 0x1B30EA0 Offset: 0x1B30FA1 VA: 0x1B30EA0
	public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, string name, bool mips = False, bool enableMSAA = False, MSAASamples msaaSamples = 1) { }

	// RVA: 0x1B30CB0 Offset: 0x1B30DB1 VA: 0x1B30CB0
	private static string GetRenderTargetAutoName(int width, int height, int depth, string format, string name, bool mips = False, bool enableMSAA = False, MSAASamples msaaSamples = 1) { }

	// RVA: 0x1B30FB0 Offset: 0x1B310B1 VA: 0x1B30FB0
	public static string GetTextureAutoName(int width, int height, TextureFormat format, TextureDimension dim = 0, string name = "", bool mips = False, int depth = 0) { }

	// RVA: 0x1B314F0 Offset: 0x1B315F1 VA: 0x1B314F0
	public static string GetTextureAutoName(int width, int height, GraphicsFormat format, TextureDimension dim = 0, string name = "", bool mips = False, int depth = 0) { }

	// RVA: 0x1B310B0 Offset: 0x1B311B1 VA: 0x1B310B0
	private static string GetTextureAutoName(int width, int height, string format, TextureDimension dim = 0, string name = "", bool mips = False, int depth = 0) { }

	// RVA: 0x1B315F0 Offset: 0x1B316F1 VA: 0x1B315F0
	public static void ClearCubemap(CommandBuffer cmd, RenderTexture renderTexture, Color clearColor, bool clearMips = False) { }

	// RVA: 0x1B317E0 Offset: 0x1B318E1 VA: 0x1B317E0
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x1B31870 Offset: 0x1B31971 VA: 0x1B31870
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x1B31920 Offset: 0x1B31A21 VA: 0x1B31920
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x1B31A00 Offset: 0x1B31B01 VA: 0x1B31A00
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x1B31AD0 Offset: 0x1B31BD1 VA: 0x1B31AD0
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x1B31C20 Offset: 0x1B31D21 VA: 0x1B31C20
	public static Color ConvertSRGBToActiveColorSpace(Color color) { }

	// RVA: 0x1B31CA0 Offset: 0x1B31DA1 VA: 0x1B31CA0
	public static Color ConvertLinearToActiveColorSpace(Color color) { }

	// RVA: 0x1B31D20 Offset: 0x1B31E21 VA: 0x1B31D20
	public static Material CreateEngineMaterial(string shaderPath) { }

	// RVA: 0x1B31E70 Offset: 0x1B31F71 VA: 0x1B31E70
	public static Material CreateEngineMaterial(Shader shader) { }

	// RVA: -1 Offset: -1
	public static bool HasFlag<T>(T mask, T flag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229D380 Offset: 0x229D481 VA: 0x229D380
	|-CoreUtils.HasFlag<object>
	*/

	// RVA: -1 Offset: -1
	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229D4A0 Offset: 0x229D5A1 VA: 0x229D4A0
	|-CoreUtils.Swap<int>
	|
	|-RVA: 0x229D4C0 Offset: 0x229D5C1 VA: 0x229D4C0
	|-CoreUtils.Swap<object>
	*/

	// RVA: 0x1B31F80 Offset: 0x1B32081 VA: 0x1B31F80
	public static void SetKeyword(CommandBuffer cmd, string keyword, bool state) { }

	// RVA: 0x1B31FA0 Offset: 0x1B320A1 VA: 0x1B31FA0
	public static void SetKeyword(Material material, string keyword, bool state) { }

	// RVA: 0x1B31FC0 Offset: 0x1B320C1 VA: 0x1B31FC0
	public static void SetKeyword(ComputeShader cs, string keyword, bool state) { }

	// RVA: 0x1B31FE0 Offset: 0x1B320E1 VA: 0x1B31FE0
	public static void Destroy(Object obj) { }

	// RVA: 0x1B32090 Offset: 0x1B32191 VA: 0x1B32090
	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	// RVA: -1 Offset: -1
	public static IEnumerable<Type> GetAllTypesDerivedFrom<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229D160 Offset: 0x229D261 VA: 0x229D160
	|-CoreUtils.GetAllTypesDerivedFrom<object>
	|-CoreUtils.GetAllTypesDerivedFrom<VolumeComponent>
	*/

	// RVA: 0x1B32280 Offset: 0x1B32381 VA: 0x1B32280
	public static void SafeRelease(ComputeBuffer buffer) { }

	// RVA: 0x1B32290 Offset: 0x1B32391 VA: 0x1B32290
	public static Mesh CreateCubeMesh(Vector3 min, Vector3 max) { }

	// RVA: 0x1B32630 Offset: 0x1B32731 VA: 0x1B32630
	public static bool ArePostProcessesEnabled(Camera camera) { }

	// RVA: 0x1B32640 Offset: 0x1B32741 VA: 0x1B32640
	public static bool AreAnimatedMaterialsEnabled(Camera camera) { }

	// RVA: 0x1B32650 Offset: 0x1B32751 VA: 0x1B32650
	public static bool IsSceneLightingDisabled(Camera camera) { }

	// RVA: 0x1B32660 Offset: 0x1B32761 VA: 0x1B32660
	public static bool IsLightOverlapDebugEnabled(Camera camera) { }

	// RVA: 0x1B32670 Offset: 0x1B32771 VA: 0x1B32670
	public static bool IsSceneViewFogEnabled(Camera camera) { }

	// RVA: 0x1B32680 Offset: 0x1B32781 VA: 0x1B32680
	public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, RendererList rendererList) { }

	// RVA: 0x1B32810 Offset: 0x1B32911 VA: 0x1B32810
	private static void .cctor() { }
}

