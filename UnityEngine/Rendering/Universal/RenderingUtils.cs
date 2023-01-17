// Namespace: UnityEngine.Rendering.Universal
[MovedFromAttribute] // RVA: 0x47F950 Offset: 0x47FA51 VA: 0x47F950
public static class RenderingUtils // TypeDefIndex: 5332
{
	// Fields
	private static List<ShaderTagId> m_LegacyShaderPassNames; // 0x0
	private static Mesh s_FullscreenMesh; // 0x8
	private static Material s_ErrorMaterial; // 0x10
	internal static readonly int UNITY_STEREO_MATRIX_V; // 0x18
	internal static readonly int UNITY_STEREO_MATRIX_IV; // 0x1C
	internal static readonly int UNITY_STEREO_MATRIX_P; // 0x20
	internal static readonly int UNITY_STEREO_MATRIX_IP; // 0x24
	internal static readonly int UNITY_STEREO_MATRIX_VP; // 0x28
	internal static readonly int UNITY_STEREO_MATRIX_IVP; // 0x2C
	internal static readonly int UNITY_STEREO_CAMERA_PROJECTION; // 0x30
	internal static readonly int UNITY_STEREO_CAMERA_INV_PROJECTION; // 0x34
	internal static readonly int UNITY_STEREO_VECTOR_CAMPOS; // 0x38
	private static readonly RenderingUtils.StereoConstants stereoConstants; // 0x40
	private static Dictionary<RenderTextureFormat, bool> m_RenderTextureFormatSupport; // 0x48
	private static Dictionary<GraphicsFormat, Dictionary<FormatUsage, bool>> m_GraphicsFormatSupport; // 0x50

	// Properties
	public static Mesh fullscreenMesh { get; }
	internal static bool useStructuredBuffer { get; }
	private static Material errorMaterial { get; }

	// Methods

	// RVA: 0x3123260 Offset: 0x3123361 VA: 0x3123260
	public static Mesh get_fullscreenMesh() { }

	// RVA: 0x31235E0 Offset: 0x31236E1 VA: 0x31235E0
	internal static bool get_useStructuredBuffer() { }

	// RVA: 0x31235F0 Offset: 0x31236F1 VA: 0x31235F0
	private static Material get_errorMaterial() { }

	// RVA: 0x31237C0 Offset: 0x31238C1 VA: 0x31237C0
	public static void SetViewAndProjectionMatrices(CommandBuffer cmd, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, bool setInverseMatrices) { }

	// RVA: 0x3123C20 Offset: 0x3123D21 VA: 0x3123C20
	internal static void SetStereoViewAndProjectionMatrices(CommandBuffer cmd, Matrix4x4[] viewMatrix, Matrix4x4[] projMatrix, Matrix4x4[] cameraProjMatrix, bool setInverseMatrices) { }

	// RVA: 0x3124240 Offset: 0x3124341 VA: 0x3124240
	internal static void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int passIndex = 0, bool useDrawProcedural = False, RenderBufferLoadAction colorLoadAction = 0, RenderBufferStoreAction colorStoreAction = 0, RenderBufferLoadAction depthLoadAction = 0, RenderBufferStoreAction depthStoreAction = 0) { }

	[ConditionalAttribute] // RVA: 0x484730 Offset: 0x484831 VA: 0x484730
	[ConditionalAttribute] // RVA: 0x484730 Offset: 0x484831 VA: 0x484730
	// RVA: 0x3124550 Offset: 0x3124651 VA: 0x3124550
	internal static void RenderObjectsWithError(ScriptableRenderContext context, ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags) { }

	// RVA: 0x31248B0 Offset: 0x31249B1 VA: 0x31248B0
	internal static void ClearSystemInfoCache() { }

	// RVA: 0x3124960 Offset: 0x3124A61 VA: 0x3124960
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0x3124A70 Offset: 0x3124B71 VA: 0x3124A70
	public static bool SupportsGraphicsFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x3124C50 Offset: 0x3124D51 VA: 0x3124C50
	internal static int GetLastValidColorBufferIndex(RenderTargetIdentifier[] colorBuffers) { }

	// RVA: 0x3124D20 Offset: 0x3124E21 VA: 0x3124D20
	internal static uint GetValidColorBufferCount(RenderTargetIdentifier[] colorBuffers) { }

	// RVA: 0x3124E10 Offset: 0x3124F11 VA: 0x3124E10
	internal static bool IsMRT(RenderTargetIdentifier[] colorBuffers) { }

	// RVA: 0x3124F50 Offset: 0x3125051 VA: 0x3124F50
	internal static bool Contains(RenderTargetIdentifier[] source, RenderTargetIdentifier value) { }

	// RVA: 0x3125010 Offset: 0x3125111 VA: 0x3125010
	internal static int IndexOf(RenderTargetIdentifier[] source, RenderTargetIdentifier value) { }

	// RVA: 0x31250F0 Offset: 0x31251F1 VA: 0x31250F0
	internal static uint CountDistinct(RenderTargetIdentifier[] source, RenderTargetIdentifier value) { }

	// RVA: 0x3125240 Offset: 0x3125341 VA: 0x3125240
	internal static int LastValid(RenderTargetIdentifier[] source) { }

	// RVA: 0x3125320 Offset: 0x3125421 VA: 0x3125320
	internal static bool Contains(ClearFlag a, ClearFlag b) { }

	// RVA: 0x3125330 Offset: 0x3125431 VA: 0x3125330
	internal static bool SequenceEqual(RenderTargetIdentifier[] left, RenderTargetIdentifier[] right) { }

	// RVA: 0x3125430 Offset: 0x3125531 VA: 0x3125430
	private static void .cctor() { }
}

