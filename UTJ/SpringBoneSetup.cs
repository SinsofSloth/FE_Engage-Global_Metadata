// Namespace: UTJ
public static class SpringBoneSetup // TypeDefIndex: 6382
{
	// Methods

	// RVA: 0x3113BA0 Offset: 0x3113CA1 VA: 0x3113BA0
	public static void DestroyUnityObject(Object objectToDestroy) { }

	// RVA: 0x3113C10 Offset: 0x3113D11 VA: 0x3113C10
	public static string GetAutoSaveDirectory() { }

	// RVA: 0x3113C20 Offset: 0x3113D21 VA: 0x3113C20
	public static string GetAutoSavePath(string rootObjectName) { }

	// RVA: 0x3113CE0 Offset: 0x3113DE1 VA: 0x3113CE0
	public static void AutoLoad(SpringManager springManager) { }

	// RVA: 0x3113DD0 Offset: 0x3113ED1 VA: 0x3113DD0
	public static void AutoSave(SpringManager springManager) { }

	// RVA: 0x3113E20 Offset: 0x3113F21 VA: 0x3113E20
	public static void DestroySpringManagersAndBones(GameObject rootObject) { }

	// RVA: 0x31144E0 Offset: 0x31145E1 VA: 0x31144E0
	public static void FindAndAssignSpringBones(SpringManager springManager, bool includeInactive = False) { }

	// RVA: 0x31148F0 Offset: 0x31149F1 VA: 0x31148F0
	public static void AssignSpringBonesRecursively(Transform rootObject) { }

	// RVA: 0x3114A10 Offset: 0x3114B11 VA: 0x3114A10
	public static Dictionary<Transform, List<SpringBone>> GetPivotToSpringBoneMap(GameObject rootObject) { }

	// RVA: 0x3114EA0 Offset: 0x3114FA1 VA: 0x3114EA0
	public static void FixAllPivotNodePositions(GameObject rootObject) { }

	// RVA: 0x31151C0 Offset: 0x31152C1 VA: 0x31151C0
	public static GameObject CreateSpringPivotNode(SpringBone springBone) { }

	// RVA: 0x3113A10 Offset: 0x3113B11 VA: 0x3113A10
	public static bool IsPivotProbablySafeToDestroy(Transform pivot, IEnumerable<Transform> skinBones) { }

	// RVA: 0x3113FD0 Offset: 0x31140D1 VA: 0x3113FD0
	private static void DestroyPivotObjects(GameObject rootObject) { }

	// RVA: 0x3115770 Offset: 0x3115871 VA: 0x3115770
	private static bool IsPivotSideDirectionValid(Vector3 lookDirection, Vector3 sideDirection) { }

	// RVA: 0x3115810 Offset: 0x3115911 VA: 0x3115810
	private static Vector3 FindClosestMeshNormalToPoint(Transform rootObject, Vector3 sourcePoint) { }

	// RVA: 0x3115E30 Offset: 0x3115F31 VA: 0x3115E30
	private static bool TryToGetPivotSideDirection(SpringBone springBone, Vector3 lookDirection, out Vector3 sideDirection) { }

	// RVA: 0x31154D0 Offset: 0x31155D1 VA: 0x31154D0
	private static Quaternion GetPivotRotation(SpringBone springBone) { }

	// RVA: 0x31145B0 Offset: 0x31146B1 VA: 0x31145B0
	private static List<SpringBone> GetSpringBonesSortedByDepth(GameObject rootObject, bool includeInactive) { }
}

