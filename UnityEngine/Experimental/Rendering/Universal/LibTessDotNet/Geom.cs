// Namespace: UnityEngine.Experimental.Rendering.Universal.LibTessDotNet
internal static class Geom // TypeDefIndex: 5508
{
	// Methods

	// RVA: 0x31489F0 Offset: 0x3148AF1 VA: 0x31489F0
	public static bool IsWindingInside(WindingRule rule, int n) { }

	// RVA: 0x3148AA0 Offset: 0x3148BA1 VA: 0x3148AA0
	public static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w) { }

	// RVA: 0x3148AE0 Offset: 0x3148BE1 VA: 0x3148AE0
	public static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs) { }

	// RVA: 0x3148B10 Offset: 0x3148C11 VA: 0x3148B10
	public static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs) { }

	// RVA: 0x3148B50 Offset: 0x3148C51 VA: 0x3148B50
	public static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w) { }

	// RVA: 0x3148BB0 Offset: 0x3148CB1 VA: 0x3148BB0
	public static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w) { }

	// RVA: 0x3148C00 Offset: 0x3148D01 VA: 0x3148C00
	public static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs) { }

	// RVA: 0x3148C40 Offset: 0x3148D41 VA: 0x3148C40
	public static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w) { }

	// RVA: 0x3148CA0 Offset: 0x3148DA1 VA: 0x3148CA0
	public static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w) { }

	// RVA: 0x3148CF0 Offset: 0x3148DF1 VA: 0x3148CF0
	public static bool EdgeGoesLeft(MeshUtils.Edge e) { }

	// RVA: 0x3148D60 Offset: 0x3148E61 VA: 0x3148D60
	public static bool EdgeGoesRight(MeshUtils.Edge e) { }

	// RVA: 0x3148DD0 Offset: 0x3148ED1 VA: 0x3148DD0
	public static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v) { }

	// RVA: 0x3148E60 Offset: 0x3148F61 VA: 0x3148E60
	public static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc) { }

	// RVA: 0x3148E90 Offset: 0x3148F91 VA: 0x3148E90
	public static float Interpolate(float a, float x, float b, float y) { }

	// RVA: 0x3148EE0 Offset: 0x3148FE1 VA: 0x3148EE0
	private static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b) { }

	// RVA: 0x3148F20 Offset: 0x3149021 VA: 0x3148F20
	public static void EdgeIntersect(MeshUtils.Vertex o1, MeshUtils.Vertex d1, MeshUtils.Vertex o2, MeshUtils.Vertex d2, MeshUtils.Vertex v) { }
}

