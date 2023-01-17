// Namespace: App
internal class MapEditChecker // TypeDefIndex: 11969
{
	// Properties
	private static int SizeX { get; }
	private static int SizeZ { get; }

	// Methods

	// RVA: 0x21A9B90 Offset: 0x21A9C91 VA: 0x21A9B90
	public static bool Check(bool isOpponent = False) { }

	// RVA: 0x21A9F90 Offset: 0x21AA091 VA: 0x21A9F90
	private static int get_SizeX() { }

	// RVA: 0x21AA010 Offset: 0x21AA111 VA: 0x21AA010
	private static int get_SizeZ() { }

	// RVA: 0x21AA090 Offset: 0x21AA191 VA: 0x21AA090
	private static int GetUnitCount() { }

	// RVA: 0x21AA0D0 Offset: 0x21AA1D1 VA: 0x21AA0D0
	private static int GetOpponentCount() { }

	// RVA: 0x21AA110 Offset: 0x21AA211 VA: 0x21AA110
	private static bool CanMove(int x, int z, bool breakableIsTrue = False) { }

	// RVA: 0x21AA180 Offset: 0x21AA281 VA: 0x21AA180
	private static bool CanMoveBreakable(int x, int z) { }

	// RVA: 0x21AA2A0 Offset: 0x21AA3A1 VA: 0x21AA2A0
	private static TerrainData GetTerrain(int x, int z) { }

	// RVA: 0x21AA3F0 Offset: 0x21AA4F1 VA: 0x21AA3F0
	private static bool ExistsUnit(int x, int z) { }

	// RVA: 0x21A9DC0 Offset: 0x21A9EC1 VA: 0x21A9DC0
	private static bool CheckMyMap() { }

	// RVA: 0x21A9BA0 Offset: 0x21A9CA1 VA: 0x21A9BA0
	private static bool CheckOpponentMap() { }

	// RVA: 0x21AA490 Offset: 0x21AA591 VA: 0x21AA490
	private static int CheckRecursive(MapPos pos, MapEditChecker.CheckRange range, HashSet<MapPos> reachSet, int totalCount = 0) { }

	// RVA: 0x21AA6B0 Offset: 0x21AA7B1 VA: 0x21AA6B0
	public void .ctor() { }
}

