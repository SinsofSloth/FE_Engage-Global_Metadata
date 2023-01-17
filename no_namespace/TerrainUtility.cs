// Namespace: 
public sealed class TerrainUtility.TerrainMap.TerrainFilter : MulticastDelegate // TypeDefIndex: 7553
{
	// Methods

	// RVA: 0x3F06AE0 Offset: 0x3F06BE1 VA: 0x3F06AE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3F07B10 Offset: 0x3F07C11 VA: 0x3F07B10 Slot: 13
	public virtual bool Invoke(Terrain terrain) { }

	// RVA: 0x3F08920 Offset: 0x3F08A21 VA: 0x3F08920 Slot: 14
	public virtual IAsyncResult BeginInvoke(Terrain terrain, AsyncCallback callback, object object) { }

	// RVA: 0x3F08950 Offset: 0x3F08A51 VA: 0x3F08950 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public struct TerrainUtility.TerrainMap.TileCoord // TypeDefIndex: 7554
{
	// Fields
	public readonly int tileX; // 0x0
	public readonly int tileZ; // 0x4

	// Methods

	// RVA: 0x3F07650 Offset: 0x3F07751 VA: 0x3F07650
	public void .ctor(int tileX, int tileZ) { }
}

// Namespace: 
public enum TerrainUtility.TerrainMap.ErrorCode // TypeDefIndex: 7555
{
	// Fields
	public int value__; // 0x0
	public const TerrainUtility.TerrainMap.ErrorCode OK = 0;
	public const TerrainUtility.TerrainMap.ErrorCode Overlapping = 1;
	public const TerrainUtility.TerrainMap.ErrorCode SizeMismatch = 4;
	public const TerrainUtility.TerrainMap.ErrorCode EdgeAlignmentMismatch = 8;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x48E1C0 Offset: 0x48E2C1 VA: 0x48E1C0
private sealed class TerrainUtility.TerrainMap.<>c__DisplayClass4_0 // TypeDefIndex: 7556
{
	// Fields
	public int groupID; // 0x10

	// Methods

	// RVA: 0x3F07660 Offset: 0x3F07761 VA: 0x3F07660
	public void .ctor() { }

	// RVA: 0x3F088C0 Offset: 0x3F089C1 VA: 0x3F088C0
	internal bool <CreateFromPlacement>b__0(Terrain x) { }
}

// Namespace: 
public class TerrainUtility.TerrainMap // TypeDefIndex: 7557
{
	// Fields
	private Vector3 m_patchSize; // 0x10
	public TerrainUtility.TerrainMap.ErrorCode m_errorCode; // 0x1C
	public Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain> m_terrainTiles; // 0x20

	// Methods

	// RVA: 0x3F072E0 Offset: 0x3F073E1 VA: 0x3F072E0
	public Terrain GetTerrain(int tileX, int tileZ) { }

	// RVA: 0x3F06B00 Offset: 0x3F06C01 VA: 0x3F06B00
	public static TerrainUtility.TerrainMap CreateFromPlacement(Terrain originTerrain, TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation = True) { }

	// RVA: 0x3F07670 Offset: 0x3F07771 VA: 0x3F07670
	public static TerrainUtility.TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation = True) { }

	// RVA: 0x3F07A80 Offset: 0x3F07B81 VA: 0x3F07A80
	public void .ctor() { }

	// RVA: 0x3F08110 Offset: 0x3F08211 VA: 0x3F08110
	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	// RVA: 0x3F07E70 Offset: 0x3F07F71 VA: 0x3F07E70
	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	// RVA: 0x3F08260 Offset: 0x3F08361 VA: 0x3F08260
	private void ValidateTerrain(int tileX, int tileZ) { }

	// RVA: 0x3F07FE0 Offset: 0x3F080E1 VA: 0x3F07FE0
	private TerrainUtility.TerrainMap.ErrorCode Validate() { }
}

// Namespace: 
public class TerrainUtility.TerrainGroups : Dictionary<int, TerrainUtility.TerrainMap> // TypeDefIndex: 7558
{
	// Methods

	// RVA: 0x3F06A70 Offset: 0x3F06B71 VA: 0x3F06A70
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x48E1D0 Offset: 0x48E2D1 VA: 0x48E1D0
private sealed class TerrainUtility.<>c__DisplayClass4_0 // TypeDefIndex: 7559
{
	// Fields
	public bool onlyAutoConnectedTerrains; // 0x10

	// Methods

	// RVA: 0x3F06A60 Offset: 0x3F06B61 VA: 0x3F06A60
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x48E1E0 Offset: 0x48E2E1 VA: 0x48E1E0
private sealed class TerrainUtility.<>c__DisplayClass4_1 // TypeDefIndex: 7560
{
	// Fields
	public Terrain t; // 0x10
	public TerrainUtility.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x3F06AD0 Offset: 0x3F06BD1 VA: 0x3F06AD0
	public void .ctor() { }

	// RVA: 0x3F07560 Offset: 0x3F07661 VA: 0x3F07560
	internal bool <CollectTerrains>b__0(Terrain x) { }
}

