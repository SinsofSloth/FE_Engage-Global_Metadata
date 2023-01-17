// Namespace: UnityEngine.UI
public class VertexHelper : IDisposable // TypeDefIndex: 4367
{
	// Fields
	private List<Vector3> m_Positions; // 0x10
	private List<Color32> m_Colors; // 0x18
	private List<Vector4> m_Uv0S; // 0x20
	private List<Vector4> m_Uv1S; // 0x28
	private List<Vector4> m_Uv2S; // 0x30
	private List<Vector4> m_Uv3S; // 0x38
	private List<Vector3> m_Normals; // 0x40
	private List<Vector4> m_Tangents; // 0x48
	private List<int> m_Indices; // 0x50
	private static readonly Vector4 s_DefaultTangent; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x10
	private bool m_ListsInitalized; // 0x58

	// Properties
	public int currentVertCount { get; }
	public int currentIndexCount { get; }

	// Methods

	// RVA: 0x1BFB230 Offset: 0x1BFB331 VA: 0x1BFB230
	public void .ctor() { }

	// RVA: 0x1BFB240 Offset: 0x1BFB341 VA: 0x1BFB240
	public void .ctor(Mesh m) { }

	// RVA: 0x1BFB470 Offset: 0x1BFB571 VA: 0x1BFB470
	private void InitializeListIfRequired() { }

	// RVA: 0x1BFB6B0 Offset: 0x1BFB7B1 VA: 0x1BFB6B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1BF8080 Offset: 0x1BF8181 VA: 0x1BF8080
	public void Clear() { }

	// RVA: 0x1BFB950 Offset: 0x1BFBA51 VA: 0x1BFB950
	public int get_currentVertCount() { }

	// RVA: 0x1BFB9B0 Offset: 0x1BFBAB1 VA: 0x1BFB9B0
	public int get_currentIndexCount() { }

	// RVA: 0x1BFBA10 Offset: 0x1BFBB11 VA: 0x1BFBA10
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	// RVA: 0x1BFBC10 Offset: 0x1BFBD11 VA: 0x1BFBC10
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x1BFBD60 Offset: 0x1BFBE61 VA: 0x1BFBD60
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x1BFBEC0 Offset: 0x1BFBFC1 VA: 0x1BFBEC0
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x1BFC0D0 Offset: 0x1BFC1D1 VA: 0x1BFC0D0
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x1BFC1E0 Offset: 0x1BFC2E1 VA: 0x1BFC1E0
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	// RVA: 0x1BFC340 Offset: 0x1BFC441 VA: 0x1BFC340
	public void AddVert(UIVertex v) { }

	// RVA: 0x1BFC3E0 Offset: 0x1BFC4E1 VA: 0x1BFC3E0
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x1BF81A0 Offset: 0x1BF82A1 VA: 0x1BF81A0
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x1BFC480 Offset: 0x1BFC581 VA: 0x1BFC480
	public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) { }

	// RVA: 0x1BFC530 Offset: 0x1BFC631 VA: 0x1BFC530
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	// RVA: 0x1BFC590 Offset: 0x1BFC691 VA: 0x1BFC590
	public void GetUIVertexStream(List<UIVertex> stream) { }

	// RVA: 0x1BFC5F0 Offset: 0x1BFC6F1 VA: 0x1BFC5F0
	private static void .cctor() { }
}

