// Namespace: App
public abstract class MapEditor : SingletonMonoBehaviour<MapEditor> // TypeDefIndex: 14027
{
	// Fields
	public MapEditor.EditObject[] m_EditObjects; // 0x20
	[SerializeField] // RVA: 0x29D310 Offset: 0x29D411 VA: 0x29D310
	private CasualMap m_CasualMapEditData; // 0x28
	private Map.CellMesh m_Mesh; // 0x30
	private Dictionary<int, MapEditor.EditObject> m_Dictionary; // 0x38
	private const int Version = 1;
	private bool m_IsEnableGrid; // 0x40
	private static bool s_IsPlaySound; // 0x0
	private static readonly Dictionary<MapPos, int> s_MapObjects; // 0x8
	private static readonly Dictionary<MapPos, int> s_MapObjectRotates; // 0x10
	public static int CasualMapSlotMax; // 0x18

	// Properties
	public int SizeX { get; }
	public int SizeZ { get; }

	// Methods

	// RVA: 0x21AFF50 Offset: 0x21B0051 VA: 0x21AFF50
	public void Start() { }

	// RVA: 0x21B0270 Offset: 0x21B0371 VA: 0x21B0270
	public static int CalcKey(string name) { }

	// RVA: 0x21B03E0 Offset: 0x21B04E1 VA: 0x21B03E0
	public GameObject FindObject(string name) { }

	// RVA: 0x21B04B0 Offset: 0x21B05B1 VA: 0x21B04B0
	public GameObject FindObject(int key) { }

	// RVA: 0x21B0540 Offset: 0x21B0641 VA: 0x21B0540
	public GameObject FindObject(int x, int z) { }

	// RVA: 0x21B0700 Offset: 0x21B0801 VA: 0x21B0700
	public TerrainData GetTerrain(string name) { }

	// RVA: 0x21B0780 Offset: 0x21B0881 VA: 0x21B0780
	public TerrainData GetTerrain(int key) { }

	// RVA: 0x21AAF30 Offset: 0x21AB031 VA: 0x21AAF30
	public void ForEachObject(Action<GameObject> func) { }

	// RVA: 0x21B08A0 Offset: 0x21B09A1 VA: 0x21B08A0
	public int get_SizeX() { }

	// RVA: 0x21B0920 Offset: 0x21B0A21 VA: 0x21B0920
	public int get_SizeZ() { }

	// RVA: 0x21B09A0 Offset: 0x21B0AA1 VA: 0x21B09A0
	public int GetEditObjectCount(int key) { }

	// RVA: 0x21B0AB0 Offset: 0x21B0BB1 VA: 0x21B0AB0
	public int GetEditObjectCount(string name) { }

	// RVA: 0x21B0B30 Offset: 0x21B0C31 VA: 0x21B0B30
	public int GetCategoryCount(MapEditorCategoryData category) { }

	// RVA: 0x21B0C70 Offset: 0x21B0D71 VA: 0x21B0C70
	public bool ContainsSettableArea(int x, int z, bool isOpponent = False) { }

	// RVA: 0x21B0E60 Offset: 0x21B0F61 VA: 0x21B0E60
	public bool IsOpponentArea(int x, int z) { }

	// RVA: 0x21B0F00 Offset: 0x21B1001 VA: 0x21B0F00
	public bool CanCreateObject(MapEditorCategoryData category) { }

	// RVA: 0x21B1000 Offset: 0x21B1101 VA: 0x21B1000
	public void ShowGrid() { }

	// RVA: 0x21B17D0 Offset: 0x21B18D1 VA: 0x21B17D0
	public void HideGrid() { }

	// RVA: 0x21B1010 Offset: 0x21B1111 VA: 0x21B1010
	private void UpdateGrid() { }

	// RVA: 0x21B17E0 Offset: 0x21B18E1 VA: 0x21B17E0
	private static Vector3 GetMapPosition(int cx, int cz) { }

	// RVA: 0x21B2420 Offset: 0x21B2521 VA: 0x21B2420
	public GameObject TryCreateObject(int x, int z, MapEditorObjectData obj, bool isUpdate = True, bool isRecord = True, bool isPlaySound = True) { }

	// RVA: 0x21B2600 Offset: 0x21B2701 VA: 0x21B2600
	private GameObject TryCreateObject(int x, int z, int key, bool isUpdate = True, bool isRecord = True, bool isPlaySound = True) { }

	// RVA: 0x21B3D30 Offset: 0x21B3E31 VA: 0x21B3D30
	public bool TryDeleteObject(int x, int z, bool isUpdate = True, bool isRecord = True, bool isPlaySound = True) { }

	// RVA: 0x21B4200 Offset: 0x21B4301 VA: 0x21B4200
	public GameObject TryReplaceObject(int x, int z, MapEditorObjectData objData) { }

	// RVA: 0x21B43D0 Offset: 0x21B44D1 VA: 0x21B43D0
	private bool CanReplace(GameObject deleteObj, MapEditorObjectData createObj) { }

	// RVA: 0x21ABD50 Offset: 0x21ABE51 VA: 0x21ABD50
	public void ClearObjectAll(bool isUpdate = True) { }

	// RVA: 0x21B2840 Offset: 0x21B2941 VA: 0x21B2840
	private GameObject InstantiateObject(GameObject putObject, int x, int z) { }

	// RVA: 0x21B4540 Offset: 0x21B4641 VA: 0x21B4540
	private void DeleteObject(MapObject putObject) { }

	// RVA: 0x21B40A0 Offset: 0x21B41A1 VA: 0x21B40A0
	private void DeleteObject(GameObject putObject) { }

	// RVA: 0x21B45D0 Offset: 0x21B46D1 VA: 0x21B45D0
	public bool TryRotateObject(int x, int z, bool isReverse = False) { }

	// RVA: 0x21B47B0 Offset: 0x21B48B1 VA: 0x21B47B0
	public void AddRotateObjectCommand(int x, int z, int prevRotate, int nextRotate) { }

	// RVA: 0x21B3FC0 Offset: 0x21B40C1 VA: 0x21B3FC0
	public int GetRotate(int x, int z) { }

	// RVA: 0x21B4500 Offset: 0x21B4601 VA: 0x21B4500
	public int GetRotate(GameObject gameObject) { }

	// RVA: 0x21B48B0 Offset: 0x21B49B1 VA: 0x21B48B0
	public void SetRotate(int x, int z, int rotate) { }

	// RVA: 0x21B46F0 Offset: 0x21B47F1 VA: 0x21B46F0
	public void SetRotate(GameObject gameObject, int rotate) { }

	// RVA: 0x21AC1C0 Offset: 0x21AC2C1 VA: 0x21AC1C0
	public void UpdateTerrain() { }

	// RVA: 0x21B2AC0 Offset: 0x21B2BC1 VA: 0x21B2AC0
	private void UpdateTerrain(int posX, int posZ) { }

	// RVA: 0x21B4970 Offset: 0x21B4A71 VA: 0x21B4970
	private void UpdateTerrainImpl() { }

	// RVA: 0x21B2970 Offset: 0x21B2A71 VA: 0x21B2970
	private static void PlayPutSound(string objectName) { }

	// RVA: 0x21B4130 Offset: 0x21B4231 VA: 0x21B4130
	private static void PlayDestroySound() { }

	// RVA: 0x21B4C70 Offset: 0x21B4D71 VA: 0x21B4C70
	public static void SetPlaySound(bool value) { }

	// RVA: 0x21B4CF0 Offset: 0x21B4DF1 VA: 0x21B4CF0
	public void Dump() { }

	// RVA: 0x21ABF10 Offset: 0x21AC011 VA: 0x21ABF10
	public GameObject TryCreateVersusObject(int x, int z, int key, bool isOpponent, bool isUpdate = True) { }

	// RVA: 0x21B4FA0 Offset: 0x21B50A1 VA: 0x21B4FA0
	public void ClearObjectOnSortie() { }

	// RVA: 0x21B50D0 Offset: 0x21B51D1 VA: 0x21B50D0
	public void SaveObjects() { }

	// RVA: 0x21B5440 Offset: 0x21B5541 VA: 0x21B5440
	public void LoadObjects() { }

	// RVA: 0x21B5690 Offset: 0x21B5791 VA: 0x21B5690
	public void LoadRotateAfterLoadObjects() { }

	// RVA: 0x21B5920 Offset: 0x21B5A21 VA: 0x21B5920
	public static void Serialize(Stream stream) { }

	// RVA: 0x21B5BA0 Offset: 0x21B5CA1 VA: 0x21B5BA0
	public static void Deserialize(Stream stream) { }

	// RVA: 0x21B5F90 Offset: 0x21B6091 VA: 0x21B5F90
	public void SaveCasual(int stage) { }

	// RVA: 0x21B62B0 Offset: 0x21B63B1 VA: 0x21B62B0
	public void LoadCasual(int stage) { }

	// RVA: 0x21B65C0 Offset: 0x21B66C1 VA: 0x21B65C0
	protected void .ctor() { }

	// RVA: 0x21B66A0 Offset: 0x21B67A1 VA: 0x21B66A0
	private static void .cctor() { }
}

