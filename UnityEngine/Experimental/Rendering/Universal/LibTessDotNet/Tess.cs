// Namespace: UnityEngine.Experimental.Rendering.Universal.LibTessDotNet
internal class Tess // TypeDefIndex: 5524
{
	// Fields
	private Mesh _mesh; // 0x10
	private Vec3 _normal; // 0x18
	private Vec3 _sUnit; // 0x24
	private Vec3 _tUnit; // 0x30
	private float _bminX; // 0x3C
	private float _bminY; // 0x40
	private float _bmaxX; // 0x44
	private float _bmaxY; // 0x48
	private WindingRule _windingRule; // 0x4C
	private Dict<Tess.ActiveRegion> _dict; // 0x50
	private PriorityQueue<MeshUtils.Vertex> _pq; // 0x58
	private MeshUtils.Vertex _event; // 0x60
	private CombineCallback _combineCallback; // 0x68
	private ContourVertex[] _vertices; // 0x70
	private int _vertexCount; // 0x78
	private int[] _elements; // 0x80
	private int _elementCount; // 0x88
	public float SUnitX; // 0x8C
	public float SUnitY; // 0x90
	public float SentinelCoord; // 0x94
	public bool NoEmptyPolygons; // 0x98
	public bool UsePooling; // 0x99

	// Properties
	public Vec3 Normal { get; set; }
	public ContourVertex[] Vertices { get; }
	public int VertexCount { get; }
	public int[] Elements { get; }
	public int ElementCount { get; }

	// Methods

	// RVA: 0x3137870 Offset: 0x3137971 VA: 0x3137870
	private Tess.ActiveRegion RegionBelow(Tess.ActiveRegion reg) { }

	// RVA: 0x3137880 Offset: 0x3137981 VA: 0x3137880
	private Tess.ActiveRegion RegionAbove(Tess.ActiveRegion reg) { }

	// RVA: 0x3137890 Offset: 0x3137991 VA: 0x3137890
	private bool EdgeLeq(Tess.ActiveRegion reg1, Tess.ActiveRegion reg2) { }

	// RVA: 0x31379D0 Offset: 0x3137AD1 VA: 0x31379D0
	private void DeleteRegion(Tess.ActiveRegion reg) { }

	// RVA: 0x3137A40 Offset: 0x3137B41 VA: 0x3137A40
	private void FixUpperEdge(Tess.ActiveRegion reg, MeshUtils.Edge newEdge) { }

	// RVA: 0x3137AA0 Offset: 0x3137BA1 VA: 0x3137AA0
	private Tess.ActiveRegion TopLeftRegion(Tess.ActiveRegion reg) { }

	// RVA: 0x3137B70 Offset: 0x3137C71 VA: 0x3137B70
	private Tess.ActiveRegion TopRightRegion(Tess.ActiveRegion reg) { }

	// RVA: 0x3137BC0 Offset: 0x3137CC1 VA: 0x3137BC0
	private Tess.ActiveRegion AddRegionBelow(Tess.ActiveRegion regAbove, MeshUtils.Edge eNewUp) { }

	// RVA: 0x3137CA0 Offset: 0x3137DA1 VA: 0x3137CA0
	private void ComputeWinding(Tess.ActiveRegion reg) { }

	// RVA: 0x3137CF0 Offset: 0x3137DF1 VA: 0x3137CF0
	private void FinishRegion(Tess.ActiveRegion reg) { }

	// RVA: 0x3137D80 Offset: 0x3137E81 VA: 0x3137D80
	private MeshUtils.Edge FinishLeftRegions(Tess.ActiveRegion regFirst, Tess.ActiveRegion regLast) { }

	// RVA: 0x3137F70 Offset: 0x3138071 VA: 0x3137F70
	private void AddRightEdges(Tess.ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp) { }

	// RVA: 0x31386D0 Offset: 0x31387D1 VA: 0x31386D0
	private void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2) { }

	// RVA: 0x31386E0 Offset: 0x31387E1 VA: 0x31386E0
	private void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1) { }

	// RVA: 0x31387E0 Offset: 0x31388E1 VA: 0x31387E0
	private void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo) { }

	// RVA: 0x3138240 Offset: 0x3138341 VA: 0x3138240
	private bool CheckForRightSplice(Tess.ActiveRegion regUp) { }

	// RVA: 0x3138B90 Offset: 0x3138C91 VA: 0x3138B90
	private bool CheckForLeftSplice(Tess.ActiveRegion regUp) { }

	// RVA: 0x3138D20 Offset: 0x3138E21 VA: 0x3138D20
	private bool CheckForIntersect(Tess.ActiveRegion regUp) { }

	// RVA: 0x3138400 Offset: 0x3138501 VA: 0x3138400
	private void WalkDirtyRegions(Tess.ActiveRegion regUp) { }

	// RVA: 0x3139370 Offset: 0x3139471 VA: 0x3139370
	private void ConnectRightVertex(Tess.ActiveRegion regUp, MeshUtils.Edge eBottomLeft) { }

	// RVA: 0x3139570 Offset: 0x3139671 VA: 0x3139570
	private void ConnectLeftDegenerate(Tess.ActiveRegion regUp, MeshUtils.Vertex vEvent) { }

	// RVA: 0x3139730 Offset: 0x3139831 VA: 0x3139730
	private void ConnectLeftVertex(MeshUtils.Vertex vEvent) { }

	// RVA: 0x3139660 Offset: 0x3139761 VA: 0x3139660
	private void SweepEvent(MeshUtils.Vertex vEvent) { }

	// RVA: 0x31399C0 Offset: 0x3139AC1 VA: 0x31399C0
	private void AddSentinel(float smin, float smax, float t) { }

	// RVA: 0x3139AF0 Offset: 0x3139BF1 VA: 0x3139AF0
	private void InitEdgeDict() { }

	// RVA: 0x3139C10 Offset: 0x3139D11 VA: 0x3139C10
	private void DoneEdgeDict() { }

	// RVA: 0x3139CF0 Offset: 0x3139DF1 VA: 0x3139CF0
	private void RemoveDegenerateEdges() { }

	// RVA: 0x3139E20 Offset: 0x3139F21 VA: 0x3139E20
	private void InitPriorityQ() { }

	// RVA: 0x313A030 Offset: 0x313A131 VA: 0x313A030
	private void DonePriorityQ() { }

	// RVA: 0x313A040 Offset: 0x313A141 VA: 0x313A040
	private void RemoveDegenerateFaces() { }

	// RVA: 0x313A0D0 Offset: 0x313A1D1 VA: 0x313A0D0
	protected void ComputeInterior() { }

	// RVA: 0x313A2C0 Offset: 0x313A3C1 VA: 0x313A2C0
	public Vec3 get_Normal() { }

	// RVA: 0x313A2D0 Offset: 0x313A3D1 VA: 0x313A2D0
	public void set_Normal(Vec3 value) { }

	// RVA: 0x313A2E0 Offset: 0x313A3E1 VA: 0x313A2E0
	public ContourVertex[] get_Vertices() { }

	// RVA: 0x313A2F0 Offset: 0x313A3F1 VA: 0x313A2F0
	public int get_VertexCount() { }

	// RVA: 0x313A300 Offset: 0x313A401 VA: 0x313A300
	public int[] get_Elements() { }

	// RVA: 0x313A310 Offset: 0x313A411 VA: 0x313A310
	public int get_ElementCount() { }

	// RVA: 0x3133CA0 Offset: 0x3133DA1 VA: 0x3133CA0
	public void .ctor() { }

	// RVA: 0x313A320 Offset: 0x313A421 VA: 0x313A320
	private void ComputeNormal(ref Vec3 norm) { }

	// RVA: 0x313AA10 Offset: 0x313AB11 VA: 0x313AA10
	private void CheckOrientation() { }

	// RVA: 0x313AB20 Offset: 0x313AC21 VA: 0x313AB20
	private void ProjectPolygon() { }

	// RVA: 0x313AE40 Offset: 0x313AF41 VA: 0x313AE40
	private void TessellateMonoRegion(MeshUtils.Face face) { }

	// RVA: 0x313B060 Offset: 0x313B161 VA: 0x313B060
	private void TessellateInterior() { }

	// RVA: 0x313B0C0 Offset: 0x313B1C1 VA: 0x313B0C0
	private void DiscardExterior() { }

	// RVA: 0x313B120 Offset: 0x313B221 VA: 0x313B120
	private void SetWindingNumber(int value, bool keepOnlyBoundary) { }

	// RVA: 0x313B230 Offset: 0x313B331 VA: 0x313B230
	private int GetNeighbourFace(MeshUtils.Edge edge) { }

	// RVA: 0x313B290 Offset: 0x313B391 VA: 0x313B290
	private void OutputPolymesh(ElementType elementType, int polySize) { }

	// RVA: 0x313B730 Offset: 0x313B831 VA: 0x313B730
	private void OutputContours() { }

	// RVA: 0x313B970 Offset: 0x313BA71 VA: 0x313B970
	private float SignedArea(ContourVertex[] vertices) { }

	// RVA: 0x313BA10 Offset: 0x313BB11 VA: 0x313BA10
	public void AddContour(ContourVertex[] vertices) { }

	// RVA: 0x3133D80 Offset: 0x3133E81 VA: 0x3133D80
	public void AddContour(ContourVertex[] vertices, ContourOrientation forceOrientation) { }

	// RVA: 0x313BA20 Offset: 0x313BB21 VA: 0x313BA20
	public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize) { }

	// RVA: 0x3134070 Offset: 0x3134171 VA: 0x3134070
	public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize, CombineCallback combineCallback) { }
}

