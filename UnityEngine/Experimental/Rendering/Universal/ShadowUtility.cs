// Namespace: UnityEngine.Experimental.Rendering.Universal
internal class ShadowUtility // TypeDefIndex: 5498
{
	// Methods

	// RVA: 0x3133490 Offset: 0x3133591 VA: 0x3133490
	private static ShadowUtility.Edge CreateEdge(int triangleIndexA, int triangleIndexB, List<Vector3> vertices, List<int> triangles) { }

	// RVA: 0x3133630 Offset: 0x3133731 VA: 0x3133630
	private static void PopulateEdgeArray(List<Vector3> vertices, List<int> triangles, List<ShadowUtility.Edge> edges) { }

	// RVA: 0x3133790 Offset: 0x3133891 VA: 0x3133790
	private static bool IsOutsideEdge(int edgeIndex, List<ShadowUtility.Edge> edgesToProcess) { }

	// RVA: 0x31338F0 Offset: 0x31339F1 VA: 0x31338F0
	private static void SortEdges(List<ShadowUtility.Edge> edgesToProcess) { }

	// RVA: 0x3133950 Offset: 0x3133A51 VA: 0x3133950
	private static void CreateShadowTriangles(List<Vector3> vertices, List<Color> colors, List<int> triangles, List<Vector4> tangents, List<ShadowUtility.Edge> edges) { }

	// RVA: 0x3133BF0 Offset: 0x3133CF1 VA: 0x3133BF0
	private static object InterpCustomVertexData(Vec3 position, object[] data, float[] weights) { }

	// RVA: 0x3133C20 Offset: 0x3133D21 VA: 0x3133C20
	private static void InitializeTangents(int tangentsToAdd, List<Vector4> tangents) { }

	// RVA: 0x3130A90 Offset: 0x3130B91 VA: 0x3130A90
	public static void GenerateShadowMesh(Mesh mesh, Vector3[] shapePath) { }

	// RVA: 0x31342A0 Offset: 0x31343A1 VA: 0x31342A0
	public void .ctor() { }
}

