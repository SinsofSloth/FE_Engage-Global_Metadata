// Namespace: UnityEngine.Rendering.Universal
[MovedFromAttribute] // RVA: 0x47FB30 Offset: 0x47FC31 VA: 0x47FB30
public static class ShadowUtils // TypeDefIndex: 5341
{
	// Fields
	private static readonly RenderTextureFormat m_ShadowmapFormat; // 0x0
	private static readonly bool m_ForceShadowPointSampling; // 0x4

	// Methods

	// RVA: 0x31342B0 Offset: 0x31343B1 VA: 0x31342B0
	private static void .cctor() { }

	// RVA: 0x31343C0 Offset: 0x31344C1 VA: 0x31343C0
	public static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix) { }

	// RVA: 0x3134A50 Offset: 0x3134B51 VA: 0x3134A50
	public static bool ExtractDirectionalLightMatrix_NoCascade(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix) { }

	// RVA: 0x3134C60 Offset: 0x3134D61 VA: 0x3134C60
	public static bool ExtractSpotLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix) { }

	// RVA: 0x3134E00 Offset: 0x3134F01 VA: 0x3134E00
	public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings, Matrix4x4 proj, Matrix4x4 view) { }

	// RVA: 0x3134F30 Offset: 0x3135031 VA: 0x3134F30
	public static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings) { }

	// RVA: 0x3135060 Offset: 0x3135161 VA: 0x3135060
	public static int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount) { }

	// RVA: 0x3134900 Offset: 0x3134A01 VA: 0x3134900
	public static void ApplySliceTransform(ref ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight) { }

	// RVA: 0x31350B0 Offset: 0x31351B1 VA: 0x31350B0
	public static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, ref ShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution) { }

	// RVA: 0x3135330 Offset: 0x3135431 VA: 0x3135330
	public static void SetupShadowCasterConstantBuffer(CommandBuffer cmd, ref VisibleLight shadowLight, Vector4 shadowBias) { }

	// RVA: 0x31354C0 Offset: 0x31355C1 VA: 0x31354C0
	public static RenderTexture GetTemporaryShadowTexture(int width, int height, int bits) { }

	// RVA: 0x3134740 Offset: 0x3134841 VA: 0x3134740
	private static Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view) { }
}

