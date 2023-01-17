// Namespace: UnityEngine.Experimental.Rendering.Universal
internal static class Light2DLookupTexture // TypeDefIndex: 5483
{
	// Fields
	private static Texture2D s_PointLightLookupTexture; // 0x0
	private static Texture2D s_FalloffLookupTexture; // 0x8

	// Methods

	// RVA: 0x314CE90 Offset: 0x314CF91 VA: 0x314CE90
	public static Texture GetLightLookupTexture() { }

	// RVA: 0x314D2D0 Offset: 0x314D3D1 VA: 0x314D2D0
	public static Texture GetFalloffLookupTexture() { }

	// RVA: 0x314CF50 Offset: 0x314D051 VA: 0x314CF50
	private static Texture2D CreatePointLightLookupTexture() { }

	// RVA: 0x314D390 Offset: 0x314D491 VA: 0x314D390
	private static Texture2D CreateFalloffLookupTexture() { }
}

