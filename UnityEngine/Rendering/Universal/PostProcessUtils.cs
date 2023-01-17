// Namespace: UnityEngine.Rendering.Universal
public static class PostProcessUtils // TypeDefIndex: 5322
{
	// Methods

	[ObsoleteAttribute] // RVA: 0x484610 Offset: 0x484711 VA: 0x484610
	// RVA: 0x3371810 Offset: 0x3371911 VA: 0x3371810
	public static int ConfigureDithering(PostProcessData data, int index, Camera camera, Material material) { }

	// RVA: 0x3371560 Offset: 0x3371661 VA: 0x3371560
	public static int ConfigureDithering(PostProcessData data, int index, int cameraPixelWidth, int cameraPixelHeight, Material material) { }

	[ObsoleteAttribute] // RVA: 0x484650 Offset: 0x484751 VA: 0x484650
	// RVA: 0x3371880 Offset: 0x3371981 VA: 0x3371880
	public static void ConfigureFilmGrain(PostProcessData data, FilmGrain settings, Camera camera, Material material) { }

	// RVA: 0x33712E0 Offset: 0x33713E1 VA: 0x33712E0
	public static void ConfigureFilmGrain(PostProcessData data, FilmGrain settings, int cameraPixelWidth, int cameraPixelHeight, Material material) { }

	// RVA: 0x3370CD0 Offset: 0x3370DD1 VA: 0x3370CD0
	internal static void SetSourceSize(CommandBuffer cmd, RenderTextureDescriptor desc) { }
}

