// Namespace: App
public class Random // TypeDefIndex: 13908
{
	// Fields
	private static Random[] s_Rand; // 0x0
	private RandomSeed m_Seed; // 0x10

	// Properties
	public static Random System { get; }
	public static Random Game { get; }
	public static Random Spot { get; }
	public static Random Hub { get; }
	public static Random HubItem { get; }
	public static Random KillBonus { get; }
	public static Random Combat { get; }
	public Vector3 insideUnitSphere { get; }
	public Vector2 insideUnitCircle { get; }
	public RandomSeed Seed { get; set; }

	// Methods

	// RVA: 0x27681E0 Offset: 0x27682E1 VA: 0x27681E0
	public static void InitializeAll() { }

	// RVA: 0x2768C30 Offset: 0x2768D31 VA: 0x2768C30
	public static void InitializeAll(uint v) { }

	// RVA: 0x2768D80 Offset: 0x2768E81 VA: 0x2768D80
	public static Random GetInstance(Random.Type type) { }

	// RVA: 0x2768E00 Offset: 0x2768F01 VA: 0x2768E00
	public static bool IsSave(Random.Type type) { }

	// RVA: 0x2768880 Offset: 0x2768981 VA: 0x2768880
	public static Random get_System() { }

	// RVA: 0x2768E10 Offset: 0x2768F11 VA: 0x2768E10
	public static Random get_Game() { }

	// RVA: 0x2768E80 Offset: 0x2768F81 VA: 0x2768E80
	public static Random get_Spot() { }

	// RVA: 0x2768EF0 Offset: 0x2768FF1 VA: 0x2768EF0
	public static Random get_Hub() { }

	// RVA: 0x2768F60 Offset: 0x2769061 VA: 0x2768F60
	public static Random get_HubItem() { }

	// RVA: 0x2768FD0 Offset: 0x27690D1 VA: 0x2768FD0
	public static Random get_KillBonus() { }

	// RVA: 0x2769040 Offset: 0x2769141 VA: 0x2769040
	public static Random get_Combat() { }

	// RVA: 0x2768850 Offset: 0x2768951 VA: 0x2768850
	public void .ctor() { }

	// RVA: 0x27690B0 Offset: 0x27691B1 VA: 0x27690B0
	public void .ctor(uint seed) { }

	// RVA: 0x27688F0 Offset: 0x27689F1 VA: 0x27688F0
	public void Initialize() { }

	// RVA: 0x2768AA0 Offset: 0x2768BA1 VA: 0x2768AA0
	public void Initialize(uint v) { }

	// RVA: 0x27691E0 Offset: 0x27692E1 VA: 0x27691E0
	public int Peek() { }

	// RVA: 0x2769220 Offset: 0x2769321 VA: 0x2769220
	public Random Spin(int count) { }

	// RVA: 0x2768A70 Offset: 0x2768B71 VA: 0x2768A70
	public int GetValue() { }

	// RVA: 0x2769290 Offset: 0x2769391 VA: 0x2769290
	public float GetF01() { }

	// RVA: 0x2769310 Offset: 0x2769411 VA: 0x2769310
	public int GetValue(int num) { }

	// RVA: 0x2769350 Offset: 0x2769451 VA: 0x2769350
	public int GetMinMax(int min, int max) { }

	// RVA: 0x2769390 Offset: 0x2769491 VA: 0x2769390
	public float GetMinMax(float min, float max) { }

	// RVA: 0x27693E0 Offset: 0x27694E1 VA: 0x27693E0
	public int GetMaxMin(int min, int max) { }

	// RVA: 0x2769430 Offset: 0x2769531 VA: 0x2769430
	public Vector3 get_insideUnitSphere() { }

	// RVA: 0x27695A0 Offset: 0x27696A1 VA: 0x27695A0
	public Vector2 get_insideUnitCircle() { }

	// RVA: 0x2769650 Offset: 0x2769751 VA: 0x2769650
	public bool IsProbability100(float percent) { }

	// RVA: -1 Offset: -1
	public void Shuffle<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2015510 Offset: 0x2015611 VA: 0x2015510
	|-Random.Shuffle<GmapSpot>
	|-Random.Shuffle<object>
	|-Random.Shuffle<RelayCompletionAwardData>
	|-Random.Shuffle<string>
	|-Random.Shuffle<Unit>
	|
	|-RVA: 0x20154E0 Offset: 0x20155E1 VA: 0x20154E0
	|-Random.Shuffle<int>
	*/

	// RVA: 0x27696C0 Offset: 0x27697C1 VA: 0x27696C0
	public int GetIndex(int[] ratioTable) { }

	// RVA: 0x27697D0 Offset: 0x27698D1 VA: 0x27697D0
	public RandomSeed get_Seed() { }

	// RVA: 0x27697E0 Offset: 0x27698E1 VA: 0x27697E0
	public void set_Seed(RandomSeed value) { }

	[ConditionalAttribute] // RVA: 0x2CD8C0 Offset: 0x2CD9C1 VA: 0x2CD8C0
	// RVA: 0x27697F0 Offset: 0x27698F1 VA: 0x27697F0
	public void Dump() { }

	// RVA: 0x2769800 Offset: 0x2769901 VA: 0x2769800
	public static void Serialize(Stream stream) { }

	// RVA: 0x2769C30 Offset: 0x2769D31 VA: 0x2769C30
	public static void Deserialize(Stream stream) { }
}

