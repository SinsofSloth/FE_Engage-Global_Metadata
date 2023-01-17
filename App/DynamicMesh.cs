// Namespace: App
public class DynamicMesh : IDisposable // TypeDefIndex: 14085
{
	// Fields
	private const int STACK_COUNT = 64;
	private static readonly Bounds BOUNDS; // 0x0
	private Mesh m_Mesh; // 0x10
	private RawStructList<Vector3> m_Positions; // 0x18
	private RawStructList<Vector3> m_Normals; // 0x20
	private RawStructList<Vector4> m_Tangents; // 0x28
	private RawStructList<Color> m_Colors; // 0x30
	private RawStructList<Vector2> m_UV0; // 0x38
	private RawStructList<Vector2> m_UV1; // 0x40
	private RawStructList<Vector2>[] m_UVs; // 0x48
	private Stack<DynamicMesh.State> m_Stack; // 0x50
	private DynamicMesh.State[] m_States; // 0x58
	private int m_StripIndex; // 0x60

	// Properties
	public Mesh Mesh { get; }

	// Methods

	// RVA: 0x25ED900 Offset: 0x25EDA01 VA: 0x25ED900
	public void .ctor(int vertexCapacity) { }

	// RVA: 0x25EDDB0 Offset: 0x25EDEB1 VA: 0x25EDDB0
	public void .ctor(int subMeshCount, int vertexCapacity) { }

	// RVA: 0x25EDE00 Offset: 0x25EDF01 VA: 0x25EDE00
	public void .ctor(GameObject go, int subMeshCount = 1, int vertexCapacity = 4096) { }

	// RVA: 0x25EDE50 Offset: 0x25EDF51 VA: 0x25EDE50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x25ED940 Offset: 0x25EDA41 VA: 0x25ED940
	private void Setup(GameObject go, int subMeshCount, int vertexCapacity) { }

	// RVA: 0x25EDEC0 Offset: 0x25EDFC1 VA: 0x25EDEC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x25EE0C0 Offset: 0x25EE1C1 VA: 0x25EE0C0
	public Mesh get_Mesh() { }

	// RVA: 0x25EE0D0 Offset: 0x25EE1D1 VA: 0x25EE0D0
	public void AddPosition(in Vector3 position) { }

	// RVA: 0x25EE160 Offset: 0x25EE261 VA: 0x25EE160
	public void AddNormal(in Vector3 normal) { }

	// RVA: 0x25EE1F0 Offset: 0x25EE2F1 VA: 0x25EE1F0
	public void AddTangents(in Vector4 tangent) { }

	// RVA: 0x25EE280 Offset: 0x25EE381 VA: 0x25EE280
	public void AddColor(in Color color) { }

	// RVA: 0x25EE310 Offset: 0x25EE411 VA: 0x25EE310
	public void AddUV(in Vector2 uv) { }

	// RVA: 0x25EE390 Offset: 0x25EE491 VA: 0x25EE390
	public void AddUV(int ch, in Vector2 uv) { }

	// RVA: 0x25EE430 Offset: 0x25EE531 VA: 0x25EE430
	public void AddVertex(in Vector3 position, in Color color) { }

	// RVA: 0x25EE500 Offset: 0x25EE601 VA: 0x25EE500
	public void AddVertex(in Vector3 position, in Color color, in Vector2 uv) { }

	// RVA: 0x25EE620 Offset: 0x25EE721 VA: 0x25EE620
	public void AddVertex(in Vector3 position, in Vector2 uv) { }

	// RVA: 0x25EE6F0 Offset: 0x25EE7F1 VA: 0x25EE6F0
	public void StripBegin() { }

	// RVA: 0x25EEAA0 Offset: 0x25EEBA1 VA: 0x25EEAA0
	public void StripEnd() { }

	// RVA: 0x25EDFA0 Offset: 0x25EE0A1 VA: 0x25EDFA0
	public void Clear() { }

	// RVA: 0x25EEB60 Offset: 0x25EEC61 VA: 0x25EEB60
	protected DynamicMesh.Scope CreateScope(DynamicMesh.Mode mode = 0, int subMeshIndex = 0) { }

	// RVA: 0x25EEBA0 Offset: 0x25EECA1 VA: 0x25EEBA0
	public void Begin(DynamicMesh.Mode mode = 0, int subMeshIndex = 0) { }

	// RVA: 0x25EEC30 Offset: 0x25EED31 VA: 0x25EEC30
	public void End() { }

	// RVA: 0x25EF110 Offset: 0x25EF211 VA: 0x25EF110
	private DynamicMesh.Mode GetCommonMode() { }

	// RVA: 0x25EED40 Offset: 0x25EEE41 VA: 0x25EED40
	private void Commit() { }

	// RVA: 0x25EF190 Offset: 0x25EF291 VA: 0x25EF190
	public void CopySubMesh(int srcMeshIndex, int dstMeshIndex) { }

	// RVA: 0x25EF1D0 Offset: 0x25EF2D1 VA: 0x25EF1D0
	private static void .cctor() { }
}

