// Namespace: App
public class MapDispos // TypeDefIndex: 11967
{
	// Methods

	// RVA: 0x2CB3590 Offset: 0x2CB3691 VA: 0x2CB3590
	public static void Load(string fileName) { }

	// RVA: 0x2CB35A0 Offset: 0x2CB36A1 VA: 0x2CB35A0
	public static void Unload() { }

	// RVA: 0x2CB3620 Offset: 0x2CB3721 VA: 0x2CB3620
	public static void CreateFirst() { }

	// RVA: 0x2CB4700 Offset: 0x2CB4801 VA: 0x2CB4700
	private static void CreateFirstEncount() { }

	// RVA: 0x2CB68D0 Offset: 0x2CB69D1 VA: 0x2CB68D0
	private static string GetEncountPlayeGroup(int playerIndex) { }

	// RVA: 0x2CB6960 Offset: 0x2CB6A61 VA: 0x2CB6960
	private static string GetEncountMobGroup(int playerIndex, int mobIndex) { }

	// RVA: 0x2CB6A10 Offset: 0x2CB6B11 VA: 0x2CB6A10
	private static string GetEncountTerrainGroup(int playerIndex) { }

	// RVA: 0x2CB6AA0 Offset: 0x2CB6BA1 VA: 0x2CB6AA0
	private static int GetEncountPlayerCount() { }

	// RVA: 0x2CB6C40 Offset: 0x2CB6D41 VA: 0x2CB6C40
	private static int GetEncountMobCount(int playerIndex) { }

	// RVA: 0x2CB6D70 Offset: 0x2CB6E71 VA: 0x2CB6D70
	private static int GetFakeIndex(int index, string key, int count) { }

	// RVA: 0x2CB49D0 Offset: 0x2CB4AD1 VA: 0x2CB49D0
	private static void CreateFirstChallenge() { }

	// RVA: 0x2CB4D70 Offset: 0x2CB4E71 VA: 0x2CB4D70
	private static void CreateFirstDlcGod() { }

	// RVA: 0x2CB3B90 Offset: 0x2CB3C91 VA: 0x2CB3B90
	private static void CreateFirstVersusCasual() { }

	// RVA: 0x2CB40B0 Offset: 0x2CB41B1 VA: 0x2CB40B0
	private static void CreateFirstVersusRanked() { }

	// RVA: 0x2CB4550 Offset: 0x2CB4651 VA: 0x2CB4550
	private static void CreateFirstVersusMock() { }

	// RVA: 0x2CB78B0 Offset: 0x2CB79B1 VA: 0x2CB78B0
	private static void CreateVersusOpponentTeam(MapEditData editData) { }

	// RVA: 0x2CB7AA0 Offset: 0x2CB7BA1 VA: 0x2CB7AA0
	private static void CreateVersusPlayerTeam(MapEditData editData) { }

	// RVA: 0x2CB4BE0 Offset: 0x2CB4CE1 VA: 0x2CB4BE0
	private static void CreateFirstEdit() { }

	// RVA: 0x2CB7E30 Offset: 0x2CB7F31 VA: 0x2CB7E30
	private static void CreateVersusEditTeam(MapEditData editData) { }

	// RVA: 0x2CB82F0 Offset: 0x2CB83F1 VA: 0x2CB82F0
	private static void ResetSortiePositionForEdit(out Stack<MapDispos.Pos> posStack) { }

	// RVA: 0x2CB8650 Offset: 0x2CB8751 VA: 0x2CB8650
	public static void CreateProcess(ProcInst super, string group, MapDispos.Flag disposFlag, string positionGroup) { }

	// RVA: 0x2CB8790 Offset: 0x2CB8891 VA: 0x2CB8790
	public static bool IsWaitProcess() { }

	// RVA: 0x2CB8800 Offset: 0x2CB8901 VA: 0x2CB8800
	private static string GetDebugHeader() { }

	// RVA: 0x2CB4F00 Offset: 0x2CB5001 VA: 0x2CB4F00
	private static void CreatePlayerTeam(string group) { }

	// RVA: 0x2CB6040 Offset: 0x2CB6141 VA: 0x2CB6040
	private static void TryCreateDisposTeam(string group) { }

	// RVA: 0x2CB8AD0 Offset: 0x2CB8BD1 VA: 0x2CB8AD0
	private static void CreateDisposTeam(string group, string positionGroup) { }

	// RVA: 0x2CB6290 Offset: 0x2CB6391 VA: 0x2CB6290
	private static void CreateEncountDisposTeam(string group) { }

	// RVA: 0x2CB6D80 Offset: 0x2CB6E81 VA: 0x2CB6D80
	private static void CreateChallengeDisposTeam(string group, Random random) { }

	// RVA: 0x2CB7350 Offset: 0x2CB7451 VA: 0x2CB7350
	private static void CreateDlcGodDisposTeam(string group, string positionGroup) { }

	// RVA: 0x2CB8880 Offset: 0x2CB8981 VA: 0x2CB8880
	private static Unit CreateUnit(DisposData data) { }

	// RVA: 0x2CB6810 Offset: 0x2CB6911 VA: 0x2CB6810
	private static void CreateEncountTerrain(int playerIndex) { }

	// RVA: 0x2CB60F0 Offset: 0x2CB61F1 VA: 0x2CB60F0
	private static bool TryCreateTerrain(string group) { }

	// RVA: 0x2CB8E90 Offset: 0x2CB8F91 VA: 0x2CB8E90
	private static float GetForceAngle(Unit unit, DisposData.Directions dir = 0) { }

	// RVA: 0x2CB8A90 Offset: 0x2CB8B91 VA: 0x2CB8A90
	private static float GetForceAngle(Force.Type force, DisposData.Directions dir = 0) { }

	// RVA: 0x2CB7720 Offset: 0x2CB7821 VA: 0x2CB7720
	private static void SetupUnit(Unit unit, int x, int z, Force.Type forceType, DisposData.Directions dir = 0) { }

	// RVA: 0x2CB88F0 Offset: 0x2CB89F1 VA: 0x2CB88F0
	private static int GetSortieLimit() { }

	// RVA: 0x2CB8EE0 Offset: 0x2CB8FE1 VA: 0x2CB8EE0
	public void .ctor() { }
}

