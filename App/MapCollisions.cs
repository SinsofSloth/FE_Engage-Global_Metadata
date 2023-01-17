// Namespace: App
public abstract class MapCollisions : SingletonMonoBehaviour<MapCollisions> // TypeDefIndex: 14023
{
	// Fields
	private const float HeightOffset = 80;
	private const string CombatBorders = "CombatBorders";

	// Methods

	// RVA: 0x2C8D750 Offset: 0x2C8D851 VA: 0x2C8D750
	private static void CreateBorder(GameObject prefab, GameObject parent, string name, Vector3 pos, Vector3 scale) { }

	// RVA: 0x2C8D8B0 Offset: 0x2C8D9B1 VA: 0x2C8D8B0
	private static float GetMinHeight(int x, int z) { }

	// RVA: 0x2C8E490 Offset: 0x2C8E591 VA: 0x2C8E490
	private static void CreateBorder(GameObject prefab, GameObject parent, string name, int x, int z) { }

	// RVA: 0x2C8E6D0 Offset: 0x2C8E7D1 VA: 0x2C8E6D0
	private static void CreateEdge(GameObject prefab, GameObject parent, string name, int x, int z, Dir.Type mask = 15) { }

	// RVA: 0x2C8E870 Offset: 0x2C8E971 VA: 0x2C8E870
	private GameObject CreateChild(string name) { }

	// RVA: 0x2C8E9A0 Offset: 0x2C8EAA1 VA: 0x2C8E9A0
	public void Setup() { }

	// RVA: 0x2C90580 Offset: 0x2C90681 VA: 0x2C90580
	public void CreteaCombatBorders(BattleCalculator calculator) { }

	// RVA: 0x2C905F0 Offset: 0x2C906F1 VA: 0x2C905F0
	public void CreteaCombatBorders(bool canSkyBattle, BattleInfoSide allowSide) { }

	// RVA: 0x2C95950 Offset: 0x2C95A51 VA: 0x2C95950
	public void DeleteCombatBorders() { }

	// RVA: 0x2C95A40 Offset: 0x2C95B41 VA: 0x2C95A40
	public static GameObject TryCreateInstance() { }

	// RVA: 0x2C95BA0 Offset: 0x2C95CA1 VA: 0x2C95BA0
	protected void .ctor() { }
}

