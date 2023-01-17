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

