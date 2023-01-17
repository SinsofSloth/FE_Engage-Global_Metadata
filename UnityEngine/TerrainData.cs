// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x48E150 Offset: 0x48E251 VA: 0x48E150
[NativeHeaderAttribute] // RVA: 0x48E150 Offset: 0x48E251 VA: 0x48E150
[NativeHeaderAttribute] // RVA: 0x48E150 Offset: 0x48E251 VA: 0x48E150
public sealed class TerrainData : Object // TypeDefIndex: 7549
{
	// Fields
	internal static readonly int k_MaximumResolution; // 0x0
	internal static readonly int k_MinimumDetailResolutionPerPatch; // 0x4
	internal static readonly int k_MaximumDetailResolutionPerPatch; // 0x8
	internal static readonly int k_MaximumDetailPatchCount; // 0xC
	internal static readonly int k_MaximumDetailsPerRes; // 0x10
	internal static readonly int k_MinimumAlphamapResolution; // 0x14
	internal static readonly int k_MaximumAlphamapResolution; // 0x18
	internal static readonly int k_MinimumBaseMapResolution; // 0x1C
	internal static readonly int k_MaximumBaseMapResolution; // 0x20

	// Properties
	public int heightmapResolution { get; }
	private int internalHeightmapResolution { get; }
	public Vector3 heightmapScale { get; }
	public Vector3 size { get; }
	public int alphamapLayers { get; }
	public int alphamapResolution { get; }
	private int Internal_alphamapResolution { get; }
	public int alphamapWidth { get; }
	public int alphamapHeight { get; }
	internal Terrain[] users { get; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0x48E270 Offset: 0x48E371 VA: 0x48E270
	[ThreadSafeAttribute] // RVA: 0x48E270 Offset: 0x48E371 VA: 0x48E270
	// RVA: 0x3F05490 Offset: 0x3F05591 VA: 0x3F05490
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	// RVA: 0x3F054E0 Offset: 0x3F055E1 VA: 0x3F054E0
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x48E2C0 Offset: 0x48E3C1 VA: 0x48E2C0
	// RVA: 0x3F055B0 Offset: 0x3F056B1 VA: 0x3F055B0
	private static void Internal_Create(TerrainData terrainData) { }

	// RVA: 0x3F05600 Offset: 0x3F05701 VA: 0x3F05600
	public int get_heightmapResolution() { }

	[NativeNameAttribute] // RVA: 0x48E300 Offset: 0x48E401 VA: 0x48E300
	// RVA: 0x3F05650 Offset: 0x3F05751 VA: 0x3F05650
	private int get_internalHeightmapResolution() { }

	[NativeNameAttribute] // RVA: 0x48E340 Offset: 0x48E441 VA: 0x48E340
	// RVA: 0x3F056A0 Offset: 0x3F057A1 VA: 0x3F056A0
	public Vector3 get_heightmapScale() { }

	[NativeNameAttribute] // RVA: 0x48E380 Offset: 0x48E481 VA: 0x48E380
	// RVA: 0x3F05750 Offset: 0x3F05851 VA: 0x3F05750
	public Vector3 get_size() { }

	// RVA: 0x3F05800 Offset: 0x3F05901 VA: 0x3F05800
	public float[,] GetHeights(int xBase, int yBase, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x48E3C0 Offset: 0x48E4C1 VA: 0x48E3C0
	// RVA: 0x3F05940 Offset: 0x3F05A41 VA: 0x3F05940
	private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

	// RVA: 0x3F059B0 Offset: 0x3F05AB1 VA: 0x3F059B0
	public void SetHeights(int xBase, int yBase, float[,] heights) { }

	[FreeFunctionAttribute] // RVA: 0x48E410 Offset: 0x48E511 VA: 0x48E410
	// RVA: 0x3F05CA0 Offset: 0x3F05DA1 VA: 0x3F05CA0
	private void Internal_SetHeights(int xBase, int yBase, int width, int height, float[,] heights) { }

	[NativeNameAttribute] // RVA: 0x48E460 Offset: 0x48E561 VA: 0x48E460
	// RVA: 0x3F05D20 Offset: 0x3F05E21 VA: 0x3F05D20
	public Vector3 GetInterpolatedNormal(float x, float y) { }

	[NativeNameAttribute] // RVA: 0x48E4A0 Offset: 0x48E5A1 VA: 0x48E4A0
	// RVA: 0x3F05E10 Offset: 0x3F05F11 VA: 0x3F05E10
	public int get_alphamapLayers() { }

	// RVA: 0x3F05E60 Offset: 0x3F05F61 VA: 0x3F05E60
	public float[,,] GetAlphamaps(int x, int y, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x48E4E0 Offset: 0x48E5E1 VA: 0x48E4E0
	// RVA: 0x3F05F30 Offset: 0x3F06031 VA: 0x3F05F30
	private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height) { }

	// RVA: 0x3F05FA0 Offset: 0x3F060A1 VA: 0x3F05FA0
	public int get_alphamapResolution() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x48E530 Offset: 0x48E631 VA: 0x48E530
	[NativeNameAttribute] // RVA: 0x48E530 Offset: 0x48E631 VA: 0x48E530
	// RVA: 0x3F06040 Offset: 0x3F06141 VA: 0x3F06040
	internal float GetAlphamapResolutionInternal() { }

	[NativeNameAttribute] // RVA: 0x48E580 Offset: 0x48E681 VA: 0x48E580
	// RVA: 0x3F05FF0 Offset: 0x3F060F1 VA: 0x3F05FF0
	private int get_Internal_alphamapResolution() { }

	// RVA: 0x3F06090 Offset: 0x3F06191 VA: 0x3F06090
	public int get_alphamapWidth() { }

	// RVA: 0x3F060E0 Offset: 0x3F061E1 VA: 0x3F060E0
	public int get_alphamapHeight() { }

	// RVA: 0x3F06130 Offset: 0x3F06231 VA: 0x3F06130
	public void SetAlphamaps(int x, int y, float[,,] map) { }

	[FreeFunctionAttribute] // RVA: 0x48E5C0 Offset: 0x48E6C1 VA: 0x48E5C0
	// RVA: 0x3F062C0 Offset: 0x3F063C1 VA: 0x3F062C0
	private void Internal_SetAlphamaps(int x, int y, int width, int height, float[,,] map) { }

	// RVA: 0x3F04B80 Offset: 0x3F04C81 VA: 0x3F04B80
	internal Terrain[] get_users() { }

	// RVA: 0x3F06340 Offset: 0x3F06441 VA: 0x3F06340
	private static void .cctor() { }

	// RVA: 0x3F05700 Offset: 0x3F05801 VA: 0x3F05700
	private void get_heightmapScale_Injected(out Vector3 ret) { }

	// RVA: 0x3F057B0 Offset: 0x3F058B1 VA: 0x3F057B0
	private void get_size_Injected(out Vector3 ret) { }

	// RVA: 0x3F05DA0 Offset: 0x3F05EA1 VA: 0x3F05DA0
	private void GetInterpolatedNormal_Injected(float x, float y, out Vector3 ret) { }
}

