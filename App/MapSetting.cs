// Namespace: App
[ExecuteInEditMode] // RVA: 0x2794A0 Offset: 0x2795A1 VA: 0x2794A0
[DisallowMultipleComponent] // RVA: 0x2794A0 Offset: 0x2795A1 VA: 0x2794A0
[Serializable]
public abstract class MapSetting : SingletonMonoBehaviour<MapSetting> // TypeDefIndex: 14042
{
	// Fields
	[SerializeField] // RVA: 0x29D690 Offset: 0x29D791 VA: 0x29D690
	private MapTerrain m_MapTerrain; // 0x20
	private List<MapObject> m_ObjectList; // 0x28
	private Dictionary<string, MapObject> m_ObjectDictionary; // 0x30
	private static MapBackupList s_BackupList; // 0x0
	private MapTerrain m_MapDevelop; // 0x38

	// Properties
	public static MapTerrain MapTerrain { get; }
	public static int Width { get; }
	public static int Height { get; }

	// Methods

	// RVA: 0x27173D0 Offset: 0x27174D1 VA: 0x27173D0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2717430 Offset: 0x2717531 VA: 0x2717430
	private void Start() { }

	// RVA: 0x27179D0 Offset: 0x2717AD1 VA: 0x27179D0
	private void Update() { }

	// RVA: 0x27179E0 Offset: 0x2717AE1 VA: 0x27179E0
	public MapObject FindMapObjectFromName(string name) { }

	// RVA: 0x2717B70 Offset: 0x2717C71 VA: 0x2717B70
	public MapObject FindMapObjectFromKey(string key) { }

	// RVA: 0x2717C00 Offset: 0x2717D01 VA: 0x2717C00
	private void Activate() { }

	// RVA: 0x2717E00 Offset: 0x2717F01 VA: 0x2717E00
	private void Inactive() { }

	// RVA: 0x2717F60 Offset: 0x2718061 VA: 0x2717F60
	private void ChangedActiveScene(Scene current, Scene next) { }

	// RVA: 0x2717FC0 Offset: 0x27180C1 VA: 0x2717FC0
	private void OnEnable() { }

	// RVA: 0x2718090 Offset: 0x2718191 VA: 0x2718090
	private void OnDisable() { }

	// RVA: 0x2717840 Offset: 0x2717941 VA: 0x2717840
	private void CommitMapObject() { }

	// RVA: 0x2718160 Offset: 0x2718261 VA: 0x2718160
	public static void Serialize(Stream stream) { }

	// RVA: 0x27181E0 Offset: 0x27182E1 VA: 0x27181E0
	public static void Deserialize(Stream stream) { }

	// RVA: 0x2718260 Offset: 0x2718361 VA: 0x2718260
	public static void Resume() { }

	// RVA: 0x27182F0 Offset: 0x27183F1 VA: 0x27182F0
	public List<MapObject> GetObjectList() { }

	// RVA: 0x27175E0 Offset: 0x27176E1 VA: 0x27175E0
	public void UpdateLODGroup() { }

	// RVA: 0x2718300 Offset: 0x2718401 VA: 0x2718300
	public static MapTerrain get_MapTerrain() { }

	// RVA: 0x27183F0 Offset: 0x27184F1 VA: 0x27183F0
	public static int get_Width() { }

	// RVA: 0x27184B0 Offset: 0x27185B1 VA: 0x27184B0
	public static int get_Height() { }

	// RVA: 0x2718570 Offset: 0x2718671 VA: 0x2718570
	protected void .ctor() { }

	// RVA: 0x27186A0 Offset: 0x27187A1 VA: 0x27186A0
	private static void .cctor() { }
}

