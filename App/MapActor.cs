// Namespace: App
public class MapActor // TypeDefIndex: 11904
{
	// Fields
	private const float MoveTime = 0.2;
	private const float StickMargin = 0.5;

	// Methods

	// RVA: 0x2310CC0 Offset: 0x2310DC1 VA: 0x2310CC0
	private static bool IsInvasion(int ox, int oz, int nx, int nz) { }

	// RVA: 0x2310E80 Offset: 0x2310F81 VA: 0x2310E80
	private static bool IsDiagonallyDir(int ox, int oz, int nx, int nz) { }

	// RVA: 0x23114B0 Offset: 0x23115B1 VA: 0x23114B0
	private static bool IsConnect(int x, int z, Dir.Type dir) { }

	// RVA: 0x2312390 Offset: 0x2312491 VA: 0x2312390
	private static Vector3 Extrusion(Vector3 pos, float radius) { }

	// RVA: 0x23129B0 Offset: 0x2312AB1 VA: 0x23129B0
	public static MapActor.MoveResult TickMove(Unit unit) { }

	// RVA: 0x2313630 Offset: 0x2313731 VA: 0x2313630
	public void .ctor() { }
}

