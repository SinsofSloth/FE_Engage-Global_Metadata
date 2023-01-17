// Namespace: App
public class MapRoute : SingletonClass<MapRoute> // TypeDefIndex: 12209
{
	// Fields
	public const int Max = 128;
	private const int ScoreCross = 1073741824;
	private const int ScoreContinue = 536870912;
	private const int ScoreDistance = 4096;
	private const int ScoreAvoid = 16;
	private const int ScoreDef = 1;
	private Dir.Type[] m_Routes; // 0x20
	private byte m_Count; // 0x28
	private sbyte m_FirstX; // 0x29
	private sbyte m_FirstZ; // 0x2A
	private sbyte m_LastX; // 0x2B
	private sbyte m_LastZ; // 0x2C
	private sbyte m_CursorX; // 0x2D
	private sbyte m_CursorZ; // 0x2E
	private byte m_Cost; // 0x2F
	private MapMind.Type m_Mind; // 0x30
	private bool m_Active; // 0x34
	private MapPos[] m_Cells; // 0x38

	// Properties
	public Dir.Type[] Routes { get; }
	public int Count { get; }
	public int FirstX { get; }
	public int FirstZ { get; }
	public int LastX { get; }
	public int LastZ { get; }
	public int CursorX { get; }
	public int CursorZ { get; }
	public MapMind.Type Mind { get; }

	// Methods

	// RVA: 0x278FF20 Offset: 0x2790021 VA: 0x278FF20
	public static int GetGoalX(int x, Dir.Type[] routes) { }

	// RVA: 0x278FFB0 Offset: 0x27900B1 VA: 0x278FFB0
	public static int GetGoalZ(int z, Dir.Type[] routes) { }

	// RVA: 0x2790040 Offset: 0x2790141 VA: 0x2790040
	public static Dir.Type GetGoalDir(Dir.Type[] routes) { }

	// RVA: 0x27900D0 Offset: 0x27901D1 VA: 0x27900D0
	public int GetGoalX() { }

	// RVA: 0x27900E0 Offset: 0x27901E1 VA: 0x27900E0
	public int GetGoalZ() { }

	// RVA: 0x27900F0 Offset: 0x27901F1 VA: 0x27900F0
	public int GetGoalX(int x) { }

	// RVA: 0x2790100 Offset: 0x2790201 VA: 0x2790100
	public int GetGoalZ(int z) { }

	// RVA: 0x2790110 Offset: 0x2790211 VA: 0x2790110
	public Dir.Type GetGoalDir() { }

	// RVA: 0x27901A0 Offset: 0x27902A1 VA: 0x27901A0
	public static void SetOneRoute(Dir.Type[] routes, Dir.Type dir) { }

	// RVA: 0x27901E0 Offset: 0x27902E1 VA: 0x27901E0
	public static void SetOneRoute(Dir.Type[] routes, int sx, int sz, int tx, int tz) { }

	// RVA: 0x2790240 Offset: 0x2790341 VA: 0x2790240
	public static int GetRouteCost(Unit unit, int firstX, int firstZ, Dir.Type[] routes) { }

	// RVA: 0x2790310 Offset: 0x2790411 VA: 0x2790310
	public void .ctor() { }

	// RVA: 0x2790400 Offset: 0x2790501 VA: 0x2790400
	public void Reset() { }

	// RVA: 0x2790440 Offset: 0x2790541 VA: 0x2790440
	public void Reset(int x, int z) { }

	// RVA: 0x27904A0 Offset: 0x27905A1 VA: 0x27904A0
	public void Reset(MapMind.Type mind) { }

	// RVA: 0x27904F0 Offset: 0x27905F1 VA: 0x27904F0
	public void Tick(int x, int z) { }

	// RVA: 0x27909C0 Offset: 0x2790AC1 VA: 0x27909C0
	private MapRoute.Flag GetMindMask(int x, int z, MapRoute.Flag flag) { }

	// RVA: 0x2790930 Offset: 0x2790A31 VA: 0x2790930
	public bool TickMind(int x, int z, MapRoute.Flag flag) { }

	// RVA: 0x2791770 Offset: 0x2791871 VA: 0x2791770
	public bool CanMindSeek(int x, int z, MapRoute.Flag flag) { }

	// RVA: 0x2791810 Offset: 0x2791911 VA: 0x2791810
	public bool CanPassable(MapDeploy deploy) { }

	// RVA: 0x2791950 Offset: 0x2791A51 VA: 0x2791950
	public int GetCross(int x, int z) { }

	// RVA: 0x2791A50 Offset: 0x2791B51 VA: 0x2791A50
	public void SetForAI(int firstX, int firstZ, int lastX, int lastZ) { }

	// RVA: 0x2791FE0 Offset: 0x27920E1 VA: 0x2791FE0
	public void SetForReplay(int firstX, int firstZ, int lastX, int lastZ) { }

	// RVA: 0x2792060 Offset: 0x2792161 VA: 0x2792060
	public void SetForResume(int firstX, int firstZ, int lastX, int lastZ) { }

	// RVA: 0x27923A0 Offset: 0x27924A1 VA: 0x27923A0
	public void SetForEvent(int firstX, int firstZ, int lastX, int lastZ) { }

	// RVA: 0x27926F0 Offset: 0x27927F1 VA: 0x27926F0
	public void SetForEvent(int firstX, int firstZ, string str) { }

	// RVA: 0x2792860 Offset: 0x2792961 VA: 0x2792860
	public void SetForEscape(Dir.Type dir) { }

	// RVA: 0x27928E0 Offset: 0x27929E1 VA: 0x27928E0
	public Dir.Type[] get_Routes() { }

	// RVA: 0x27928F0 Offset: 0x27929F1 VA: 0x27928F0
	public int get_Count() { }

	// RVA: 0x2792900 Offset: 0x2792A01 VA: 0x2792900
	public int get_FirstX() { }

	// RVA: 0x2792910 Offset: 0x2792A11 VA: 0x2792910
	public int get_FirstZ() { }

	// RVA: 0x2792920 Offset: 0x2792A21 VA: 0x2792920
	public int get_LastX() { }

	// RVA: 0x2792930 Offset: 0x2792A31 VA: 0x2792930
	public int get_LastZ() { }

	// RVA: 0x2792940 Offset: 0x2792A41 VA: 0x2792940
	public int get_CursorX() { }

	// RVA: 0x2792950 Offset: 0x2792A51 VA: 0x2792950
	public int get_CursorZ() { }

	// RVA: 0x2792960 Offset: 0x2792A61 VA: 0x2792960
	public MapMind.Type get_Mind() { }

	// RVA: 0x2792970 Offset: 0x2792A71 VA: 0x2792970
	private int GetMovePower(Unit unit) { }

	// RVA: 0x2792160 Offset: 0x2792261 VA: 0x2792160
	private bool TryAddMove(int x, int z) { }

	// RVA: 0x2790680 Offset: 0x2790781 VA: 0x2790680
	private void TickMove(int x, int z) { }

	// RVA: 0x2791150 Offset: 0x2791251 VA: 0x2791150
	private bool TickMindHere(int x, int z, MapRoute.Flag flag) { }

	// RVA: 0x2792D40 Offset: 0x2792E41 VA: 0x2792D40
	private bool TryGetCandidate(Unit unit, int x, int z, MapRoute.Flag flag, out int candidateX, out int candidateZ, out MapMind.Type candidateMind, out int candidateScoreTerrain) { }

	// RVA: 0x2793B50 Offset: 0x2793C51 VA: 0x2793B50
	private void BeginMaskMove(Unit unit, int startX, int startZ, int movePower) { }

	// RVA: 0x2793CA0 Offset: 0x2793DA1 VA: 0x2793CA0
	private void EndMaskMove() { }

	// RVA: 0x2791540 Offset: 0x2791641 VA: 0x2791540
	private bool TickMindSeek(int x, int z, MapRoute.Flag flag) { }

	// RVA: 0x27937F0 Offset: 0x27938F1 VA: 0x27937F0
	private int GetMindSeekScore(MapMind.Type mind) { }

	// RVA: 0x2793830 Offset: 0x2793931 VA: 0x2793830
	private int GetMindSeekScoreTerrain(int x, int z, int range) { }

	// RVA: 0x2791AD0 Offset: 0x2791BD1 VA: 0x2791AD0
	private void Seek(int x, int z) { }

	// RVA: 0x2793ED0 Offset: 0x2793FD1 VA: 0x2793ED0
	private void AddRouteLast(Dir.Type dir) { }

	// RVA: 0x2793F30 Offset: 0x2794031 VA: 0x2793F30
	private void AddRouteFirst(Dir.Type dir) { }

	// RVA: 0x2792470 Offset: 0x2792571 VA: 0x2792470
	private void Clamp(int firstX, int firstZ, int lastX, int lastZ) { }

	// RVA: 0x27937A0 Offset: 0x27938A1 VA: 0x27937A0
	private bool TryBack(int x, int z) { }

	// RVA: 0x2793D60 Offset: 0x2793E61 VA: 0x2793D60
	private void Back(int index) { }

	// RVA: 0x2793FD0 Offset: 0x27940D1 VA: 0x2793FD0
	public static void ForEach(Dir.Type[] routes, int firstX, int firstZ, MapRoute.Func func) { }

	// RVA: 0x27940A0 Offset: 0x27941A1 VA: 0x27940A0
	public bool IsEnable() { }

	// RVA: 0x27940B0 Offset: 0x27941B1 VA: 0x27940B0
	public bool IsActive() { }

	// RVA: 0x27940C0 Offset: 0x27941C1 VA: 0x27940C0
	public void SetActive(bool active) { }
}

