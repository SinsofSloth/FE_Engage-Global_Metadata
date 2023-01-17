// Namespace: App
public class Map // TypeDefIndex: 11887
{
	// Fields
	public static readonly int Layer_CameraTransparent; // 0x0
	public const int LOD_COUNT = 6;
	public const float CELL_SIZE = 5;
	public const float CELL_INV = 0.2;
	public const float CELL_HALF = 2.5;
	public const float CELL_QUATER = 1.25;
	public const float CELL_OCTER = 0.625;
	public const float CELL_OFFSET = 0.125;
	public const float CELL_SLOPE = 1.75;
	public static readonly Vector3 CELL_SIZE3; // 0x4
	public const float RAY_RADUIS = 0.0390625;
	public const float RAY_OFFSET = 0.0390625;
	public static readonly Vector3[] RAY_OFFSETS; // 0x10
	public static readonly Vector3[] CELL_OFFSETS; // 0x18
	public const float OFFSET_RATIO = 1.0158731;
	private static List<MapObject> s_EventList; // 0x20
	private static RaycastHit[] s_EventHits; // 0x28
	private static readonly char[] AttributeSeparator; // 0x30
	private static readonly int RenderLayerMask; // 0x38
	private static readonly int ColliderLayerMask; // 0x3C
	private static readonly int AttributeLayerMask; // 0x40
	private const float RAY_HEIGHT_EVENT = 500;
	private const float RAY_HEIGHT_GROUND = 3;
	private const float RAY_DISTANCE_GROUND = 30;
	public static BindHolder s_UpdateBinder; // 0x48

	// Properties
	public static float GridAlpha { get; set; }
	public static float TerrAlpha { get; set; }
	public static bool ShowLayer { get; set; }
	public static bool ShowOverlap { get; set; }

	// Methods

	// RVA: 0x22FBE20 Offset: 0x22FBF21 VA: 0x22FBE20
	public static float get_GridAlpha() { }

	// RVA: 0x22FBE30 Offset: 0x22FBF31 VA: 0x22FBE30
	public static void set_GridAlpha(float value) { }

	// RVA: 0x22FBE40 Offset: 0x22FBF41 VA: 0x22FBE40
	public static float get_TerrAlpha() { }

	// RVA: 0x22FBE50 Offset: 0x22FBF51 VA: 0x22FBE50
	public static void set_TerrAlpha(float value) { }

	// RVA: 0x22FBE60 Offset: 0x22FBF61 VA: 0x22FBE60
	public static bool get_ShowLayer() { }

	// RVA: 0x22FBE70 Offset: 0x22FBF71 VA: 0x22FBE70
	public static void set_ShowLayer(bool value) { }

	// RVA: 0x22FBE80 Offset: 0x22FBF81 VA: 0x22FBE80
	public static bool get_ShowOverlap() { }

	// RVA: 0x22FBE90 Offset: 0x22FBF91 VA: 0x22FBE90
	public static void set_ShowOverlap(bool value) { }

	// RVA: 0x22FBEA0 Offset: 0x22FBFA1 VA: 0x22FBEA0
	public static float GetHeight(Vector3 pos) { }

	// RVA: 0x22FCA70 Offset: 0x22FCB71 VA: 0x22FCA70
	public static float GetHeight(float x, float z) { }

	// RVA: 0x22FD5E0 Offset: 0x22FD6E1 VA: 0x22FD5E0
	public static float GetUnder(Vector3 pos) { }

	// RVA: 0x22FE170 Offset: 0x22FE271 VA: 0x22FE170
	public static float GetUnder(float x, float z) { }

	// RVA: 0x22FECB0 Offset: 0x22FEDB1 VA: 0x22FECB0
	public static float GetEdge(int x, int z, Dir.Type dir) { }

	// RVA: 0x22FF3A0 Offset: 0x22FF4A1 VA: 0x22FF3A0
	public static bool IsConnect(int x, int z, Dir.Type dir) { }

	// RVA: 0x23001D0 Offset: 0x23002D1 VA: 0x23001D0
	public static float CellToWorld(int v) { }

	// RVA: 0x2300200 Offset: 0x2300301 VA: 0x2300200
	public static int WorldToCell(float v) { }

	// RVA: 0x2300240 Offset: 0x2300341 VA: 0x2300240
	public static float WorldToCenter(float v) { }

	// RVA: 0x2300300 Offset: 0x2300401 VA: 0x2300300
	public static Vector3 CellToWorld(int x, int z) { }

	// RVA: 0x2300F80 Offset: 0x2301081 VA: 0x2300F80
	public static void SetTerrain(int x, int z, string tid, bool doUpdate = True) { }

	// RVA: 0x23011D0 Offset: 0x23012D1 VA: 0x23011D0
	private static void UpdateUnitPosition() { }

	// RVA: 0x23013D0 Offset: 0x23014D1 VA: 0x23013D0
	public static void UpdatePosition() { }

	// RVA: 0x23014C0 Offset: 0x23015C1 VA: 0x23014C0
	public static void UpdateTerrain() { }

	// RVA: 0x2301F10 Offset: 0x2302011 VA: 0x2301F10
	public static void ApplyPreview() { }

	// RVA: 0x2302060 Offset: 0x2302161 VA: 0x2302060
	public static bool HasEventObjects(int x, int z) { }

	// RVA: 0x2302420 Offset: 0x2302521 VA: 0x2302420
	public static bool HasEventObject(int x, int z, MapObject.Kinds kind) { }

	// RVA: 0x23024E0 Offset: 0x23025E1 VA: 0x23024E0
	private static MapObject GetEventObject(int x, int z, MapObject.Kinds kind) { }

	// RVA: 0x23020F0 Offset: 0x23021F1 VA: 0x23020F0
	private static List<MapObject> GetEventObjects(int x, int z) { }

	// RVA: 0x2302670 Offset: 0x2302771 VA: 0x2302670
	private static MapObject.Actions GetActionImpl(int x, int z) { }

	// RVA: 0x2302730 Offset: 0x2302831 VA: 0x2302730
	private static void PlayActionImpl(int x, int z, MapObject.Actions action) { }

	// RVA: 0x23028B0 Offset: 0x23029B1 VA: 0x23028B0
	private static void ResetActionImpl(int x, int z, MapObject.Actions action) { }

	// RVA: 0x2302A40 Offset: 0x2302B41 VA: 0x2302A40
	public static void PlayAction(int x, int z, MapObject.Actions action) { }

	// RVA: 0x2302BC0 Offset: 0x2302CC1 VA: 0x2302BC0
	public static void PlayActionMove(int x, int z, int movedX, int movedZ, MapObject.Actions action) { }

	// RVA: 0x2302DF0 Offset: 0x2302EF1 VA: 0x2302DF0
	private static int GetStateImpl(int x, int z) { }

	// RVA: 0x2302EB0 Offset: 0x2302FB1 VA: 0x2302EB0
	private static void SetStateImpl(int x, int z, int state, bool isPlay) { }

	// RVA: 0x2303070 Offset: 0x2303171 VA: 0x2303070
	public static void SetState(int x, int z, int state) { }

	// RVA: 0x23031F0 Offset: 0x23032F1 VA: 0x23031F0
	public static void PlayState(int x, int z, int state) { }

	// RVA: 0x2303370 Offset: 0x2303471 VA: 0x2303370
	public static void ResetAction(int x, int z, MapObject.Actions action) { }

	// RVA: 0x23033F0 Offset: 0x23034F1 VA: 0x23033F0
	public static bool IsPlaying(int x, int z) { }

	// RVA: 0x23034E0 Offset: 0x23035E1 VA: 0x23034E0
	public static void PlayEndurance(int x, int z, int hp, int maxHp) { }

	// RVA: 0x2303720 Offset: 0x2303821 VA: 0x2303720
	public static void PlayEnduranceForRewind(int x, int z, int hp, int maxHp) { }

	// RVA: 0x23035A0 Offset: 0x23036A1 VA: 0x23035A0
	private static void PlayEnduranceImpl(int x, int z, float ratio = 0) { }

	// RVA: 0x23037D0 Offset: 0x23038D1 VA: 0x23037D0
	private static void PlayAroundRoofImpl(int x, int z, MapObject.Actions action) { }

	// RVA: 0x2303970 Offset: 0x2303A71 VA: 0x2303970
	private static bool CanLinkable(TerrainData terrain) { }

	// RVA: 0x23039A0 Offset: 0x2303AA1 VA: 0x23039A0
	private static TerrainData TryChangeTerrain(int x, int z) { }

	// RVA: 0x2303B70 Offset: 0x2303C71 VA: 0x2303B70
	private static TerrainData TryResumeTerrain(int x, int z) { }

	// RVA: 0x2303D00 Offset: 0x2303E01 VA: 0x2303D00
	public static void Open(int x, int z) { }

	// RVA: 0x2303EF0 Offset: 0x2303FF1 VA: 0x2303EF0
	public static void Close(int x, int z) { }

	// RVA: 0x23040A0 Offset: 0x23041A1 VA: 0x23040A0
	public static void Broken(int x, int z) { }

	// RVA: 0x23042B0 Offset: 0x23043B1 VA: 0x23042B0
	public static void ResetBroken(int x, int z) { }

	// RVA: 0x2304440 Offset: 0x2304541 VA: 0x2304440
	private static void TorchImpl(int x, int z, bool enable, bool warning = False) { }

	// RVA: 0x2304590 Offset: 0x2304691 VA: 0x2304590
	private static void TorchImpl(int x, int z) { }

	// RVA: 0x2301850 Offset: 0x2301951 VA: 0x2301850
	public static void UpdateTorch() { }

	// RVA: 0x2301080 Offset: 0x2301181 VA: 0x2301080
	public static void SetTerrain(int x, int z, int index, bool doUpdate = True) { }

	// RVA: 0x2304920 Offset: 0x2304A21 VA: 0x2304920
	public static List<Map.Pos> FillTerrain(int x, int z, string tid) { }

	// RVA: 0x2304B50 Offset: 0x2304C51 VA: 0x2304B50
	public static GroundAttribute GetGroundAttribute(Vector3 pos) { }

	// RVA: 0x2304DD0 Offset: 0x2304ED1 VA: 0x2304DD0
	public static GroundAttribute GetGroundAttribute(Vector3 pos, int layerMask) { }

	// RVA: 0x2304C10 Offset: 0x2304D11 VA: 0x2304C10
	public static GroundAttribute GetGroundAttribute(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x2304E90 Offset: 0x2304F91 VA: 0x2304E90
	private static GroundAttribute GetGroundAttribute(ref RaycastHit hit) { }

	// RVA: 0x2305320 Offset: 0x2305421 VA: 0x2305320
	public static bool CanEnterTerrain(Unit unit, int x, int z) { }

	// RVA: 0x2305020 Offset: 0x2305121 VA: 0x2305020
	private static string GetAttributeName(RaycastHit hit) { }

	// RVA: 0x2305500 Offset: 0x2305601 VA: 0x2305500
	private static void SetEnable(Transform transform, bool enable, int renderMask, int colliderMask) { }

	// RVA: 0x23056D0 Offset: 0x23057D1 VA: 0x23056D0
	public static void SetRenderEnable(Transform transform, bool enable) { }

	// RVA: 0x2305750 Offset: 0x2305851 VA: 0x2305750
	public static void SetColliderEnable(Transform transform, bool enable) { }

	// RVA: 0x23057D0 Offset: 0x23058D1 VA: 0x23057D0
	public static int GetRange(int x1, int z1, int x2, int z2) { }

	// RVA: 0x2305820 Offset: 0x2305921 VA: 0x2305820
	public static int GetRange(Unit unit, Unit target) { }

	// RVA: 0x2305D10 Offset: 0x2305E11 VA: 0x2305D10
	public static int GetRange(int x, int z, Unit target) { }

	// RVA: 0x2305F60 Offset: 0x2306061 VA: 0x2305F60
	public static bool IsRange(int attackX, int attackZ, int targetX, int targetZ, int near, int far) { }

	// RVA: 0x2306020 Offset: 0x2306121 VA: 0x2306020
	public static bool IsRange(int range, int near, int far) { }

	// RVA: 0x2306040 Offset: 0x2306141 VA: 0x2306040
	public static bool IsRange(Unit unit, Unit target, int near, int far) { }

	// RVA: 0x2306720 Offset: 0x2306821 VA: 0x2306720
	public static bool IsRange(int attackUnitX, int attackUnitZ, int attackUnitSize, int targetUnitX, int targetUnitZ, int targetUnitSize, int near, int far) { }

	// RVA: 0x2306DB0 Offset: 0x2306EB1 VA: 0x2306DB0
	public static bool GetRangePos(Unit unit, Unit target, int near, int far, out int attackX, out int attackZ, out int targetX, out int targetZ) { }

	// RVA: 0x23075F0 Offset: 0x23076F1 VA: 0x23075F0
	public static bool GetRangePos(int attackUnitX, int attackUnitZ, int attackUnitSize, int targetUnitX, int targetUnitZ, int targetUnitSize, int near, int far, out int attackX, out int attackZ, out int targetX, out int targetZ) { }

	// RVA: 0x2307DD0 Offset: 0x2307ED1 VA: 0x2307DD0
	public static bool GetNearestPos(Unit attack, Unit target, out int attackX, out int attackZ, out int targetX, out int targetZ) { }

	// RVA: 0x23082D0 Offset: 0x23083D1 VA: 0x23082D0
	public static bool GetNearestPos(Unit attack, int attackUnitX, int attackUnitZ, Unit target, out int attackX, out int attackZ, out int targetX, out int targetZ) { }

	// RVA: 0x23087D0 Offset: 0x23088D1 VA: 0x23087D0
	public static bool GetNearestPos(Unit attack, int attackUnitX, int attackUnitZ, PokeInspector target, out int attackX, out int attackZ, out int targetX, out int targetZ) { }

	// RVA: 0x2308D60 Offset: 0x2308E61 VA: 0x2308D60
	public static bool GetNearestPos(int attackUnitX, int attackUnitZ, int attackUnitSize, int targetUnitX, int targetUnitZ, int targetUnitSize, out int attackX, out int attackZ, out int targetX, out int targetZ) { }

	// RVA: 0x23091A0 Offset: 0x23092A1 VA: 0x23091A0
	public static bool GetNearestPos(int attackPosX, int attackPosZ, int attackSizeW, int attackSizeH, int targetPosX, int targetPosZ, int targetSizeW, int targetSizeH, out int attackX, out int attackZ, out int targetX, out int targetZ) { }

	// RVA: 0x23095E0 Offset: 0x23096E1 VA: 0x23095E0
	public static bool GetTargetPos(Unit unit, int x, int z, Unit target, int near, int far, SkillData commandSkill, out int attackX, out int attackZ, out int targetX, out int targetZ) { }

	// RVA: 0x2309C10 Offset: 0x2309D11 VA: 0x2309C10
	public static bool TestTerrainFlag(int x, int z, TerrainData.Flags flags) { }

	// RVA: 0x2309D70 Offset: 0x2309E71 VA: 0x2309D70
	public static MapObject GetCannonObject(int x, int z) { }

	// RVA: 0x2309DF0 Offset: 0x2309EF1 VA: 0x2309DF0
	public static MapObject GetCannonObject(Vector3 pos) { }

	// RVA: 0x2309F00 Offset: 0x230A001 VA: 0x2309F00
	public static bool HasBreakable(int x, int z) { }

	// RVA: 0x2309FA0 Offset: 0x230A0A1 VA: 0x2309FA0
	public static bool GetBreakableRect(int x, int z, out int x1, out int z1, out int x2, out int z2) { }

	// RVA: 0x230A230 Offset: 0x230A331 VA: 0x230A230
	public static void RegistGlobalKey() { }

	// RVA: 0x230A3F0 Offset: 0x230A4F1 VA: 0x230A3F0
	public static void CommitGlobalKey() { }

	// RVA: 0x230A7F0 Offset: 0x230A8F1 VA: 0x230A7F0
	public static Vector3 BreakableCenterPosition(int x, int z) { }

	// RVA: 0x230B5A0 Offset: 0x230B6A1 VA: 0x230B5A0
	public static Vector3 GetUnderPos(int x, int z) { }

	// RVA: 0x230CCF0 Offset: 0x230CDF1 VA: 0x230CCF0
	public static Vector3 GetOverPos(int x, int z) { }

	// RVA: 0x230E520 Offset: 0x230E621 VA: 0x230E520
	public static Vector3 GetEffectPos(int x, int z) { }

	// RVA: 0x230FDA0 Offset: 0x230FEA1 VA: 0x230FDA0
	public static void SetMaterialFloat(string name, string material, string property, float value) { }

	// RVA: 0x230FF20 Offset: 0x2310021 VA: 0x230FF20
	public static void SetMaterialColor(string name, string material, string property, Color color) { }

	// RVA: 0x23100C0 Offset: 0x23101C1 VA: 0x23100C0
	public static void UpdateBindBegin() { }

	// RVA: 0x2310130 Offset: 0x2310231 VA: 0x2310130
	public static void UpdateBindEnd() { }

	// RVA: 0x23017E0 Offset: 0x23018E1 VA: 0x23017E0
	public static bool IsUpdateBind() { }

	// RVA: 0x23101E0 Offset: 0x23102E1 VA: 0x23101E0
	public static bool TryCreateOverlap(Unit unit, int x, int z, string tid) { }

	// RVA: 0x2310360 Offset: 0x2310461 VA: 0x2310360
	public static bool TryCreateOverlap(Unit unit, int x, int z, TerrainData terrain) { }

	// RVA: 0x2310440 Offset: 0x2310541 VA: 0x2310440
	public void .ctor() { }

	// RVA: 0x2310450 Offset: 0x2310551 VA: 0x2310450
	private static void .cctor() { }
}

