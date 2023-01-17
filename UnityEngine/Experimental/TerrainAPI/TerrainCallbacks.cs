// Namespace: UnityEngine.Experimental.TerrainAPI
public static class TerrainCallbacks // TypeDefIndex: 7552
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x48E1F0 Offset: 0x48E2F1 VA: 0x48E1F0
	[DebuggerBrowsableAttribute] // RVA: 0x48E1F0 Offset: 0x48E2F1 VA: 0x48E1F0
	private static TerrainCallbacks.HeightmapChangedCallback heightmapChanged; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x48E230 Offset: 0x48E331 VA: 0x48E230
	[CompilerGeneratedAttribute] // RVA: 0x48E230 Offset: 0x48E331 VA: 0x48E230
	private static TerrainCallbacks.TextureChangedCallback textureChanged; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x48E610 Offset: 0x48E711 VA: 0x48E610
	// RVA: 0x3F04A70 Offset: 0x3F04B71 VA: 0x3F04A70
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x48E620 Offset: 0x48E721 VA: 0x48E620
	// RVA: 0x3F04F90 Offset: 0x3F05091 VA: 0x3F04F90
	internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) { }
}

