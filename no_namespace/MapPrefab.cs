// Namespace: 
public enum MapPrefab.Category // TypeDefIndex: 14034
{
	// Fields
	public int value__; // 0x0
	public const MapPrefab.Category 無し = 0;
	public const MapPrefab.Category 建物 = 1;
	public const MapPrefab.Category 岩 = 2;
	public const MapPrefab.Category 木 = 3;
	public const MapPrefab.Category 箱 = 4;
	public const MapPrefab.Category 樽 = 5;
	public const MapPrefab.Category 人工物 = 6;
	public const MapPrefab.Category 自然物 = 7;
	public const MapPrefab.Category 補給 = 8;
	public const MapPrefab.Category 動物 = 9;
	public const MapPrefab.Category 小物 = 10;
	public const MapPrefab.Category 食べ物 = 11;
	public const MapPrefab.Category プロトタイプ = 12;
}

// Namespace: 
public enum MapPrefab.Region // TypeDefIndex: 14035
{
	// Fields
	public int value__; // 0x0
	public const MapPrefab.Region 無し = 0;
	public const MapPrefab.Region 温暖 = 1;
	public const MapPrefab.Region 熱帯 = 2;
	public const MapPrefab.Region 乾燥 = 3;
	public const MapPrefab.Region 寒冷 = 4;
}

// Namespace: 
[Serializable]
public class MapPrefab.Entity // TypeDefIndex: 14036
{
	// Fields
	public GameObject gameObject; // 0x10
	public MapPrefab.Region region; // 0x18
	public MapPrefab.Category category; // 0x1C
	public string name; // 0x20
	public string time; // 0x28
	public string user; // 0x30
	public string comment; // 0x38

	// Methods

	// RVA: 0x2413980 Offset: 0x2413A81 VA: 0x2413980
	public void Update() { }

	// RVA: 0x2413A30 Offset: 0x2413B31 VA: 0x2413A30
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279470 Offset: 0x279571 VA: 0x279470
[Serializable]
private sealed class MapPrefab.<>c // TypeDefIndex: 14037
{
	// Fields
	public static readonly MapPrefab.<>c <>9; // 0x0
	public static Comparison<MapPrefab.Entity> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x24138F0 Offset: 0x24139F1 VA: 0x24138F0
	private static void .cctor() { }

	// RVA: 0x2413960 Offset: 0x2413A61 VA: 0x2413960
	public void .ctor() { }

	// RVA: 0x2413970 Offset: 0x2413A71 VA: 0x2413970
	internal int <Sort>b__6_0(MapPrefab.Entity a, MapPrefab.Entity b) { }
}

