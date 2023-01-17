// Namespace: UnityEngine.Experimental.Rendering.Universal
[ExtensionAttribute] // RVA: 0x480480 Offset: 0x480581 VA: 0x480480
internal static class ShadowRendering // TypeDefIndex: 5495
{
	// Fields
	private static readonly int k_LightPosID; // 0x0
	private static readonly int k_ShadowStencilGroupID; // 0x4
	private static readonly int k_ShadowIntensityID; // 0x8
	private static readonly int k_ShadowVolumeIntensityID; // 0xC
	private static readonly int k_ShadowRadiusID; // 0x10

	// Methods

	[ExtensionAttribute] // RVA: 0x485360 Offset: 0x485461 VA: 0x485360
	// RVA: 0x31322C0 Offset: 0x31323C1 VA: 0x31322C0
	private static Material GetShadowMaterial(Renderer2DData rendererData, int index) { }

	[ExtensionAttribute] // RVA: 0x485370 Offset: 0x485471 VA: 0x485370
	// RVA: 0x3132490 Offset: 0x3132591 VA: 0x3132490
	private static Material GetRemoveSelfShadowMaterial(Renderer2DData rendererData, int index) { }

	// RVA: 0x3132660 Offset: 0x3132761 VA: 0x3132660
	private static void CreateShadowRenderTexture(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int blendStyleIndex) { }

	// RVA: 0x31328A0 Offset: 0x31329A1 VA: 0x31328A0
	public static void RenderShadows(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int layerToRender, Light2D light, float shadowIntensity, RenderTargetIdentifier renderTexture, RenderTargetIdentifier depthTexture) { }

	// RVA: 0x3133260 Offset: 0x3133361 VA: 0x3133260
	private static void .cctor() { }
}

