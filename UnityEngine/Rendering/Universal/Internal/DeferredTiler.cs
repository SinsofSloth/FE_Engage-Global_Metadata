// Namespace: UnityEngine.Rendering.Universal.Internal
internal struct DeferredTiler // TypeDefIndex: 5394
{
	// Fields
	private int m_TilePixelWidth; // 0x0
	private int m_TilePixelHeight; // 0x4
	private int m_TileXCount; // 0x8
	private int m_TileYCount; // 0xC
	private int m_TileHeaderSize; // 0x10
	private int m_AvgLightPerTile; // 0x14
	private int m_TilerLevel; // 0x18
	private FrustumPlanes m_FrustumPlanes; // 0x1C
	private bool m_IsOrthographic; // 0x34
	[NativeDisableContainerSafetyRestrictionAttribute] // RVA: 0x483190 Offset: 0x483291 VA: 0x483190
	private NativeArray<int> m_Counters; // 0x38
	[NativeDisableContainerSafetyRestrictionAttribute] // RVA: 0x4831A0 Offset: 0x4832A1 VA: 0x4831A0
	private NativeArray<ushort> m_TileData; // 0x48
	[NativeDisableContainerSafetyRestrictionAttribute] // RVA: 0x4831B0 Offset: 0x4832B1 VA: 0x4831B0
	private NativeArray<uint> m_TileHeaders; // 0x58
	[NativeDisableContainerSafetyRestrictionAttribute] // RVA: 0x4831C0 Offset: 0x4832C1 VA: 0x4831C0
	private NativeArray<PreTile> m_PreTiles; // 0x68

	// Properties
	public int TilerLevel { get; }
	public int TileXCount { get; }
	public int TileYCount { get; }
	public int TilePixelWidth { get; }
	public int TilePixelHeight { get; }
	public int TileHeaderSize { get; }
	public int MaxLightPerTile { get; }
	public int TileDataCapacity { get; }
	public NativeArray<ushort> Tiles { get; }
	public NativeArray<uint> TileHeaders { get; }

	// Methods

	// RVA: 0x313C430 Offset: 0x313C531 VA: 0x313C430
	public void .ctor(int tilePixelWidth, int tilePixelHeight, int avgLightPerTile, int tilerLevel) { }

	// RVA: 0x313C480 Offset: 0x313C581 VA: 0x313C480
	public int get_TilerLevel() { }

	// RVA: 0x313C490 Offset: 0x313C591 VA: 0x313C490
	public int get_TileXCount() { }

	// RVA: 0x313C4A0 Offset: 0x313C5A1 VA: 0x313C4A0
	public int get_TileYCount() { }

	// RVA: 0x313C4B0 Offset: 0x313C5B1 VA: 0x313C4B0
	public int get_TilePixelWidth() { }

	// RVA: 0x313C4C0 Offset: 0x313C5C1 VA: 0x313C4C0
	public int get_TilePixelHeight() { }

	// RVA: 0x313C4D0 Offset: 0x313C5D1 VA: 0x313C4D0
	public int get_TileHeaderSize() { }

	// RVA: 0x313C4E0 Offset: 0x313C5E1 VA: 0x313C4E0
	public int get_MaxLightPerTile() { }

	// RVA: 0x313C560 Offset: 0x313C661 VA: 0x313C560
	public int get_TileDataCapacity() { }

	// RVA: 0x313C5E0 Offset: 0x313C6E1 VA: 0x313C5E0
	public NativeArray<ushort> get_Tiles() { }

	// RVA: 0x313C5F0 Offset: 0x313C6F1 VA: 0x313C5F0
	public NativeArray<uint> get_TileHeaders() { }

	// RVA: 0x313C600 Offset: 0x313C701 VA: 0x313C600
	public void GetTileOffsetAndCount(int i, int j, out int offset, out int count) { }

	// RVA: 0x313C630 Offset: 0x313C731 VA: 0x313C630
	public int GetTileHeaderOffset(int i, int j) { }

	// RVA: 0x313C650 Offset: 0x313C751 VA: 0x313C650
	public void Setup(int tileDataCapacity) { }

	// RVA: 0x313C780 Offset: 0x313C881 VA: 0x313C780
	public void OnCameraCleanup() { }

	// RVA: 0x313C8A0 Offset: 0x313C9A1 VA: 0x313C8A0
	public void PrecomputeTiles(Matrix4x4 proj, bool isOrthographic, int renderWidth, int renderHeight) { }

	// RVA: 0x313D470 Offset: 0x313D571 VA: 0x313D470
	public void CullFinalLights(ref NativeArray<DeferredTiler.PrePunctualLight> punctualLights, ref NativeArray<ushort> lightIndices, int lightStartIndex, int lightCount, int istart, int iend, int jstart, int jend) { }

	// RVA: 0x313DE70 Offset: 0x313DF71 VA: 0x313DE70
	public void CullIntermediateLights(ref NativeArray<DeferredTiler.PrePunctualLight> punctualLights, ref NativeArray<ushort> lightIndices, int lightStartIndex, int lightCount, int istart, int iend, int jstart, int jend) { }

	// RVA: 0x313E4F0 Offset: 0x313E5F1 VA: 0x313E4F0
	private int AddTileData(ushort* lightData, ref int size) { }

	// RVA: 0x313E5E0 Offset: 0x313E6E1 VA: 0x313E5E0
	private static bool IntersectionLineSphere(float3 centre, float radius, float3 raySource, float3 rayDirection, out float t0, out float t1) { }

	// RVA: 0x313E750 Offset: 0x313E851 VA: 0x313E750
	private static bool Clip(ref PreTile tile, float3 posVS, float radius) { }

	// RVA: 0x313EA90 Offset: 0x313EB91 VA: 0x313EA90
	private static DeferredTiler.ClipResult ClipPartial(float4 plane, float4 sidePlaneA, float4 sidePlaneB, float3 posVS, float radius, float radiusSq, ref int insideCount) { }

	// RVA: 0x313EB80 Offset: 0x313EC81 VA: 0x313EB80
	private static float4 MakePlane(float3 pb, float3 pc) { }

	// RVA: 0x313EC60 Offset: 0x313ED61 VA: 0x313EC60
	private static float4 MakePlane(float3 pa, float3 pb, float3 pc) { }

	// RVA: 0x313ED90 Offset: 0x313EE91 VA: 0x313ED90
	private static float DistanceToPlane(float4 plane, float3 p) { }

	// RVA: 0x313EDB0 Offset: 0x313EEB1 VA: 0x313EDB0
	private static float SignedSq(float f) { }

	// RVA: 0x313EDD0 Offset: 0x313EED1 VA: 0x313EDD0
	private static float min2(float a, float b) { }

	// RVA: 0x313EDE0 Offset: 0x313EEE1 VA: 0x313EDE0
	private static float max2(float a, float b) { }

	// RVA: 0x313EDF0 Offset: 0x313EEF1 VA: 0x313EDF0
	private static float max3(float a, float b, float c) { }

	// RVA: 0x313EE10 Offset: 0x313EF11 VA: 0x313EE10
	public static uint _f32tof16(float x) { }

	// RVA: 0x313EE80 Offset: 0x313EF81 VA: 0x313EE80
	private static int Align(int s, int alignment) { }
}

