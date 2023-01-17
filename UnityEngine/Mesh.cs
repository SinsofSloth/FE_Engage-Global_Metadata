// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43D1F0 Offset: 0x43D2F1 VA: 0x43D1F0
[RequiredByNativeCodeAttribute] // RVA: 0x43D1F0 Offset: 0x43D2F1 VA: 0x43D1F0
public sealed class Mesh : Object // TypeDefIndex: 3511
{
	// Properties
	public IndexFormat indexFormat { get; set; }
	public int vertexBufferCount { get; }
	public int blendShapeCount { get; }
	[NativeNameAttribute] // RVA: 0x459EC0 Offset: 0x459FC1 VA: 0x459EC0
	public Matrix4x4[] bindposes { get; set; }
	public bool isReadable { get; }
	internal bool canAccess { get; }
	public int vertexCount { get; }
	public int subMeshCount { get; set; }
	public Bounds bounds { get; set; }
	public Vector3[] vertices { get; set; }
	public Vector3[] normals { get; set; }
	public Vector4[] tangents { get; set; }
	public Vector2[] uv { get; set; }
	public Vector2[] uv2 { get; set; }
	public Vector2[] uv3 { get; set; }
	public Vector2[] uv4 { get; set; }
	public Vector2[] uv5 { get; set; }
	public Vector2[] uv6 { get; set; }
	public Vector2[] uv7 { get; set; }
	public Vector2[] uv8 { get; set; }
	public Color[] colors { get; set; }
	public Color32[] colors32 { get; set; }
	public int vertexAttributeCount { get; }
	public int[] triangles { get; set; }
	public BoneWeight[] boneWeights { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x44A8B0 Offset: 0x44A9B1 VA: 0x44A8B0
	// RVA: 0x3481330 Offset: 0x3481431 VA: 0x3481330
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x44A8F0 Offset: 0x44A9F1 VA: 0x44A8F0
	// RVA: 0x3481380 Offset: 0x3481481 VA: 0x3481380
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x44A900 Offset: 0x44AA01 VA: 0x44A900
	// RVA: 0x3481420 Offset: 0x3481521 VA: 0x3481420
	internal static Mesh FromInstanceID(int id) { }

	// RVA: 0x3481470 Offset: 0x3481571 VA: 0x3481470
	public IndexFormat get_indexFormat() { }

	// RVA: 0x34814C0 Offset: 0x34815C1 VA: 0x34814C0
	public void set_indexFormat(IndexFormat value) { }

	// RVA: 0x3481510 Offset: 0x3481611 VA: 0x3481510
	internal uint GetTotalIndexCount() { }

	[FreeFunctionAttribute] // RVA: 0x44A940 Offset: 0x44AA41 VA: 0x44A940
	// RVA: 0x3481560 Offset: 0x3481661 VA: 0x3481560
	public void SetIndexBufferParams(int indexCount, IndexFormat format) { }

	[FreeFunctionAttribute] // RVA: 0x44A990 Offset: 0x44AA91 VA: 0x44A990
	// RVA: 0x34815C0 Offset: 0x34816C1 VA: 0x34815C0
	private void InternalSetIndexBufferData(IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x44A9E0 Offset: 0x44AAE1 VA: 0x44A9E0
	// RVA: 0x3481650 Offset: 0x3481751 VA: 0x3481650
	private void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x44AA30 Offset: 0x44AB31 VA: 0x44AA30
	// RVA: 0x34816E0 Offset: 0x34817E1 VA: 0x34816E0
	private void SetVertexBufferParamsFromPtr(int vertexCount, IntPtr attributesPtr, int attributesCount) { }

	[FreeFunctionAttribute] // RVA: 0x44AA80 Offset: 0x44AB81 VA: 0x44AA80
	// RVA: 0x3481750 Offset: 0x3481851 VA: 0x3481750
	private void SetVertexBufferParamsFromArray(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunctionAttribute] // RVA: 0x44AAD0 Offset: 0x44ABD1 VA: 0x44AAD0
	// RVA: 0x34817B0 Offset: 0x34818B1 VA: 0x34817B0
	private void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x44AB20 Offset: 0x44AC21 VA: 0x44AB20
	// RVA: 0x3481850 Offset: 0x3481951 VA: 0x3481850
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x44AB70 Offset: 0x44AC71 VA: 0x44AB70
	// RVA: 0x34818F0 Offset: 0x34819F1 VA: 0x34818F0
	private Array GetVertexAttributesAlloc() { }

	[FreeFunctionAttribute] // RVA: 0x44ABC0 Offset: 0x44ACC1 VA: 0x44ABC0
	// RVA: 0x3481940 Offset: 0x3481A41 VA: 0x3481940
	private int GetVertexAttributesArray(VertexAttributeDescriptor[] attributes) { }

	[FreeFunctionAttribute] // RVA: 0x44AC10 Offset: 0x44AD11 VA: 0x44AC10
	// RVA: 0x3481990 Offset: 0x3481A91 VA: 0x3481990
	private int GetVertexAttributesList(List<VertexAttributeDescriptor> attributes) { }

	[FreeFunctionAttribute] // RVA: 0x44AC60 Offset: 0x44AD61 VA: 0x44AC60
	// RVA: 0x34819E0 Offset: 0x3481AE1 VA: 0x34819E0
	private int GetVertexAttributeCountImpl() { }

	[FreeFunctionAttribute] // RVA: 0x44ACB0 Offset: 0x44ADB1 VA: 0x44ACB0
	// RVA: 0x3481A30 Offset: 0x3481B31 VA: 0x3481A30
	public VertexAttributeDescriptor GetVertexAttribute(int index) { }

	[FreeFunctionAttribute] // RVA: 0x44AD00 Offset: 0x44AE01 VA: 0x44AD00
	// RVA: 0x3481B00 Offset: 0x3481C01 VA: 0x3481B00
	private uint GetIndexStartImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x44AD50 Offset: 0x44AE51 VA: 0x44AD50
	// RVA: 0x3481B50 Offset: 0x3481C51 VA: 0x3481B50
	private uint GetIndexCountImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x44ADA0 Offset: 0x44AEA1 VA: 0x44ADA0
	// RVA: 0x3481BA0 Offset: 0x3481CA1 VA: 0x3481BA0
	private uint GetTrianglesCountImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x44ADF0 Offset: 0x44AEF1 VA: 0x44ADF0
	// RVA: 0x3481BF0 Offset: 0x3481CF1 VA: 0x3481BF0
	private uint GetBaseVertexImpl(int submesh) { }

	[FreeFunctionAttribute] // RVA: 0x44AE40 Offset: 0x44AF41 VA: 0x44AE40
	// RVA: 0x3481C40 Offset: 0x3481D41 VA: 0x3481C40
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x44AE90 Offset: 0x44AF91 VA: 0x44AE90
	// RVA: 0x3481CA0 Offset: 0x3481DA1 VA: 0x3481CA0
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x44AEE0 Offset: 0x44AFE1 VA: 0x44AEE0
	// RVA: 0x3481D00 Offset: 0x3481E01 VA: 0x3481D00
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x44AF30 Offset: 0x44B031 VA: 0x44AF30
	// RVA: 0x3481DA0 Offset: 0x3481EA1 VA: 0x3481DA0
	private void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x44AF80 Offset: 0x44B081 VA: 0x44AF80
	// RVA: 0x3481E40 Offset: 0x3481F41 VA: 0x3481E40
	private void GetTrianglesNonAllocImpl([Out] int[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x44AFD0 Offset: 0x44B0D1 VA: 0x44AFD0
	// RVA: 0x3481EB0 Offset: 0x3481FB1 VA: 0x3481EB0
	private void GetTrianglesNonAllocImpl16([Out] ushort[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x44B020 Offset: 0x44B121 VA: 0x44B020
	// RVA: 0x3481F20 Offset: 0x3482021 VA: 0x3481F20
	private void GetIndicesNonAllocImpl([Out] int[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x44B070 Offset: 0x44B171 VA: 0x44B070
	// RVA: 0x3481F90 Offset: 0x3482091 VA: 0x3481F90
	private void GetIndicesNonAllocImpl16([Out] ushort[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunctionAttribute] // RVA: 0x44B0C0 Offset: 0x44B1C1 VA: 0x44B0C0
	// RVA: 0x3482000 Offset: 0x3482101 VA: 0x3482000
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunctionAttribute] // RVA: 0x44B110 Offset: 0x44B211 VA: 0x44B110
	// RVA: 0x3482050 Offset: 0x3482151 VA: 0x3482050
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunctionAttribute] // RVA: 0x44B160 Offset: 0x44B261 VA: 0x44B160
	// RVA: 0x34820A0 Offset: 0x34821A1 VA: 0x34820A0
	public int GetVertexAttributeDimension(VertexAttribute attr) { }

	[FreeFunctionAttribute] // RVA: 0x44B1B0 Offset: 0x44B2B1 VA: 0x44B1B0
	// RVA: 0x34820F0 Offset: 0x34821F1 VA: 0x34820F0
	public VertexAttributeFormat GetVertexAttributeFormat(VertexAttribute attr) { }

	[FreeFunctionAttribute] // RVA: 0x44B200 Offset: 0x44B301 VA: 0x44B200
	// RVA: 0x3482140 Offset: 0x3482241 VA: 0x3482140
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x44B250 Offset: 0x44B351 VA: 0x44B250
	// RVA: 0x34821E0 Offset: 0x34822E1 VA: 0x34821E0
	private void SetNativeArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0x44B2A0 Offset: 0x44B3A1 VA: 0x44B2A0
	// RVA: 0x3482280 Offset: 0x3482381 VA: 0x3482280
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunctionAttribute] // RVA: 0x44B2F0 Offset: 0x44B3F1 VA: 0x44B2F0
	// RVA: 0x34822F0 Offset: 0x34823F1 VA: 0x34822F0
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	[FreeFunctionAttribute] // RVA: 0x44B340 Offset: 0x44B441 VA: 0x44B340
	// RVA: 0x3482360 Offset: 0x3482461 VA: 0x3482360
	public int get_vertexBufferCount() { }

	[NativeThrowsAttribute] // RVA: 0x44B390 Offset: 0x44B491 VA: 0x44B390
	[FreeFunctionAttribute] // RVA: 0x44B390 Offset: 0x44B491 VA: 0x44B390
	// RVA: 0x34823B0 Offset: 0x34824B1 VA: 0x34823B0
	public IntPtr GetNativeVertexBufferPtr(int index) { }

	[FreeFunctionAttribute] // RVA: 0x44B400 Offset: 0x44B501 VA: 0x44B400
	// RVA: 0x3482400 Offset: 0x3482501 VA: 0x3482400
	public IntPtr GetNativeIndexBufferPtr() { }

	[NativeMethodAttribute] // RVA: 0x44B450 Offset: 0x44B551 VA: 0x44B450
	// RVA: 0x3482450 Offset: 0x3482551 VA: 0x3482450
	public int get_blendShapeCount() { }

	[FreeFunctionAttribute] // RVA: 0x44B4A0 Offset: 0x44B5A1 VA: 0x44B4A0
	// RVA: 0x34824A0 Offset: 0x34825A1 VA: 0x34824A0
	public void ClearBlendShapes() { }

	[FreeFunctionAttribute] // RVA: 0x44B4F0 Offset: 0x44B5F1 VA: 0x44B4F0
	// RVA: 0x34824F0 Offset: 0x34825F1 VA: 0x34824F0
	public string GetBlendShapeName(int shapeIndex) { }

	[FreeFunctionAttribute] // RVA: 0x44B540 Offset: 0x44B641 VA: 0x44B540
	// RVA: 0x3482540 Offset: 0x3482641 VA: 0x3482540
	public int GetBlendShapeIndex(string blendShapeName) { }

	[FreeFunctionAttribute] // RVA: 0x44B590 Offset: 0x44B691 VA: 0x44B590
	// RVA: 0x3482590 Offset: 0x3482691 VA: 0x3482590
	public int GetBlendShapeFrameCount(int shapeIndex) { }

	[FreeFunctionAttribute] // RVA: 0x44B5E0 Offset: 0x44B6E1 VA: 0x44B5E0
	// RVA: 0x34825E0 Offset: 0x34826E1 VA: 0x34825E0
	public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex) { }

	[FreeFunctionAttribute] // RVA: 0x44B630 Offset: 0x44B731 VA: 0x44B630
	// RVA: 0x3482640 Offset: 0x3482741 VA: 0x3482640
	public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	[FreeFunctionAttribute] // RVA: 0x44B680 Offset: 0x44B781 VA: 0x44B680
	// RVA: 0x34826C0 Offset: 0x34827C1 VA: 0x34826C0
	public void AddBlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	[NativeMethodAttribute] // RVA: 0x44B6D0 Offset: 0x44B7D1 VA: 0x44B6D0
	// RVA: 0x3482740 Offset: 0x3482841 VA: 0x3482740
	private bool HasBoneWeights() { }

	[FreeFunctionAttribute] // RVA: 0x44B710 Offset: 0x44B811 VA: 0x44B710
	// RVA: 0x3482790 Offset: 0x3482891 VA: 0x3482790
	private BoneWeight[] GetBoneWeightsImpl() { }

	[FreeFunctionAttribute] // RVA: 0x44B760 Offset: 0x44B861 VA: 0x44B760
	// RVA: 0x34827E0 Offset: 0x34828E1 VA: 0x34827E0
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	// RVA: 0x3482830 Offset: 0x3482931 VA: 0x3482830
	public void SetBoneWeights(NativeArray<byte> bonesPerVertex, NativeArray<BoneWeight1> weights) { }

	[FreeFunctionAttribute] // RVA: 0x44B7B0 Offset: 0x44B8B1 VA: 0x44B7B0
	// RVA: 0x3482920 Offset: 0x3482A21 VA: 0x3482920
	private void InternalSetBoneWeights(IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize) { }

	// RVA: 0x3482990 Offset: 0x3482A91 VA: 0x3482990
	public NativeArray<BoneWeight1> GetAllBoneWeights() { }

	// RVA: 0x3482AF0 Offset: 0x3482BF1 VA: 0x3482AF0
	public NativeArray<byte> GetBonesPerVertex() { }

	[FreeFunctionAttribute] // RVA: 0x44B800 Offset: 0x44B901 VA: 0x44B800
	// RVA: 0x3482AA0 Offset: 0x3482BA1 VA: 0x3482AA0
	private int GetAllBoneWeightsArraySize() { }

	[FreeFunctionAttribute] // RVA: 0x44B850 Offset: 0x44B951 VA: 0x44B850
	// RVA: 0x3482A50 Offset: 0x3482B51 VA: 0x3482A50
	private IntPtr GetAllBoneWeightsArray() { }

	[FreeFunctionAttribute] // RVA: 0x44B8A0 Offset: 0x44B9A1 VA: 0x44B8A0
	// RVA: 0x3482C40 Offset: 0x3482D41 VA: 0x3482C40
	private IntPtr GetBonesPerVertexArray() { }

	// RVA: 0x3482C90 Offset: 0x3482D91 VA: 0x3482C90
	private int GetBindposeCount() { }

	// RVA: 0x3482CE0 Offset: 0x3482DE1 VA: 0x3482CE0
	public Matrix4x4[] get_bindposes() { }

	// RVA: 0x3482D30 Offset: 0x3482E31 VA: 0x3482D30
	public void set_bindposes(Matrix4x4[] value) { }

	[FreeFunctionAttribute] // RVA: 0x44B8F0 Offset: 0x44B9F1 VA: 0x44B8F0
	// RVA: 0x3482D80 Offset: 0x3482E81 VA: 0x3482D80
	private void GetBoneWeightsNonAllocImpl([Out] BoneWeight[] values) { }

	[FreeFunctionAttribute] // RVA: 0x44B940 Offset: 0x44BA41 VA: 0x44B940
	// RVA: 0x3482DD0 Offset: 0x3482ED1 VA: 0x3482DD0
	private void GetBindposesNonAllocImpl([Out] Matrix4x4[] values) { }

	[NativeMethodAttribute] // RVA: 0x44B990 Offset: 0x44BA91 VA: 0x44B990
	// RVA: 0x3482E20 Offset: 0x3482F21 VA: 0x3482E20
	public bool get_isReadable() { }

	[NativeMethodAttribute] // RVA: 0x44B9D0 Offset: 0x44BAD1 VA: 0x44B9D0
	// RVA: 0x3482E70 Offset: 0x3482F71 VA: 0x3482E70
	internal bool get_canAccess() { }

	[NativeMethodAttribute] // RVA: 0x44BA10 Offset: 0x44BB11 VA: 0x44BA10
	// RVA: 0x3482BF0 Offset: 0x3482CF1 VA: 0x3482BF0
	public int get_vertexCount() { }

	[NativeMethodAttribute] // RVA: 0x44BA50 Offset: 0x44BB51 VA: 0x44BA50
	// RVA: 0x3482EC0 Offset: 0x3482FC1 VA: 0x3482EC0
	public int get_subMeshCount() { }

	[FreeFunctionAttribute] // RVA: 0x44BAA0 Offset: 0x44BBA1 VA: 0x44BAA0
	// RVA: 0x3482F10 Offset: 0x3483011 VA: 0x3482F10
	public void set_subMeshCount(int value) { }

	[FreeFunctionAttribute] // RVA: 0x44BAF0 Offset: 0x44BBF1 VA: 0x44BAF0
	// RVA: 0x3482F60 Offset: 0x3483061 VA: 0x3482F60
	public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

	[FreeFunctionAttribute] // RVA: 0x44BB40 Offset: 0x44BC41 VA: 0x44BB40
	// RVA: 0x3483040 Offset: 0x3483141 VA: 0x3483040
	public SubMeshDescriptor GetSubMesh(int index) { }

	[FreeFunctionAttribute] // RVA: 0x44BB90 Offset: 0x44BC91 VA: 0x44BB90
	// RVA: 0x3483130 Offset: 0x3483231 VA: 0x3483130
	private void SetAllSubMeshesAtOnceFromArray(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags = 0) { }

	[FreeFunctionAttribute] // RVA: 0x44BBE0 Offset: 0x44BCE1 VA: 0x44BBE0
	// RVA: 0x34831A0 Offset: 0x34832A1 VA: 0x34831A0
	private void SetAllSubMeshesAtOnceFromNativeArray(IntPtr desc, int start, int count, MeshUpdateFlags flags = 0) { }

	// RVA: 0x3483210 Offset: 0x3483311 VA: 0x3483210
	public Bounds get_bounds() { }

	// RVA: 0x34832E0 Offset: 0x34833E1 VA: 0x34832E0
	public void set_bounds(Bounds value) { }

	[NativeMethodAttribute] // RVA: 0x44BC30 Offset: 0x44BD31 VA: 0x44BC30
	// RVA: 0x3483380 Offset: 0x3483481 VA: 0x3483380
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethodAttribute] // RVA: 0x44BC70 Offset: 0x44BD71 VA: 0x44BC70
	// RVA: 0x34833D0 Offset: 0x34834D1 VA: 0x34833D0
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	[NativeMethodAttribute] // RVA: 0x44BCB0 Offset: 0x44BDB1 VA: 0x44BCB0
	// RVA: 0x3483420 Offset: 0x3483521 VA: 0x3483420
	private void RecalculateNormalsImpl(MeshUpdateFlags flags) { }

	[NativeMethodAttribute] // RVA: 0x44BCF0 Offset: 0x44BDF1 VA: 0x44BCF0
	// RVA: 0x3483470 Offset: 0x3483571 VA: 0x3483470
	private void RecalculateTangentsImpl(MeshUpdateFlags flags) { }

	[NativeMethodAttribute] // RVA: 0x44BD30 Offset: 0x44BE31 VA: 0x44BD30
	// RVA: 0x34834C0 Offset: 0x34835C1 VA: 0x34834C0
	private void MarkDynamicImpl() { }

	[NativeMethodAttribute] // RVA: 0x44BD70 Offset: 0x44BE71 VA: 0x44BD70
	// RVA: 0x3483510 Offset: 0x3483611 VA: 0x3483510
	public void MarkModified() { }

	[NativeMethodAttribute] // RVA: 0x44BDB0 Offset: 0x44BEB1 VA: 0x44BDB0
	// RVA: 0x3483560 Offset: 0x3483661 VA: 0x3483560
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0x44BDF0 Offset: 0x44BEF1 VA: 0x44BDF0
	// RVA: 0x34835B0 Offset: 0x34836B1 VA: 0x34835B0
	private MeshTopology GetTopologyImpl(int submesh) { }

	[NativeMethodAttribute] // RVA: 0x44BE40 Offset: 0x44BF41 VA: 0x44BE40
	// RVA: 0x3483600 Offset: 0x3483701 VA: 0x3483600
	private void RecalculateUVDistributionMetricImpl(int uvSetIndex, float uvAreaThreshold) { }

	[NativeMethodAttribute] // RVA: 0x44BE80 Offset: 0x44BF81 VA: 0x44BE80
	// RVA: 0x3483660 Offset: 0x3483761 VA: 0x3483660
	private void RecalculateUVDistributionMetricsImpl(float uvAreaThreshold) { }

	[NativeMethodAttribute] // RVA: 0x44BEC0 Offset: 0x44BFC1 VA: 0x44BEC0
	// RVA: 0x34836B0 Offset: 0x34837B1 VA: 0x34836B0
	public float GetUVDistributionMetric(int uvSetIndex) { }

	[NativeMethodAttribute] // RVA: 0x44BF00 Offset: 0x44C001 VA: 0x44BF00
	// RVA: 0x3483700 Offset: 0x3483801 VA: 0x3483700
	private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	[NativeMethodAttribute] // RVA: 0x44BF60 Offset: 0x44C061 VA: 0x44BF60
	// RVA: 0x3483770 Offset: 0x3483871 VA: 0x3483770
	private void OptimizeImpl() { }

	[NativeMethodAttribute] // RVA: 0x44BFA0 Offset: 0x44C0A1 VA: 0x44BFA0
	// RVA: 0x34837C0 Offset: 0x34838C1 VA: 0x34837C0
	private void OptimizeIndexBuffersImpl() { }

	[NativeMethodAttribute] // RVA: 0x44BFE0 Offset: 0x44C0E1 VA: 0x44BFE0
	// RVA: 0x3483810 Offset: 0x3483911 VA: 0x3483810
	private void OptimizeReorderVertexBufferImpl() { }

	// RVA: 0x3483860 Offset: 0x3483961 VA: 0x3483860
	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x34838E0 Offset: 0x34839E1 VA: 0x34838E0
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29642F0 Offset: 0x29643F1 VA: 0x29642F0
	|-Mesh.GetAllocArrayFromChannel<Color>
	|
	|-RVA: 0x29643F0 Offset: 0x29644F1 VA: 0x29643F0
	|-Mesh.GetAllocArrayFromChannel<Color32>
	|
	|-RVA: 0x29644F0 Offset: 0x29645F1 VA: 0x29644F0
	|-Mesh.GetAllocArrayFromChannel<object>
	|
	|-RVA: 0x29645F0 Offset: 0x29646F1 VA: 0x29645F0
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|
	|-RVA: 0x29646F0 Offset: 0x29647F1 VA: 0x29646F0
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|
	|-RVA: 0x29647F0 Offset: 0x29648F1 VA: 0x29647F0
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2964110 Offset: 0x2964211 VA: 0x2964110
	|-Mesh.GetAllocArrayFromChannel<Color>
	|
	|-RVA: 0x2964170 Offset: 0x2964271 VA: 0x2964170
	|-Mesh.GetAllocArrayFromChannel<object>
	|
	|-RVA: 0x29641D0 Offset: 0x29642D1 VA: 0x29641D0
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|
	|-RVA: 0x2964230 Offset: 0x2964331 VA: 0x2964230
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|
	|-RVA: 0x2964290 Offset: 0x2964391 VA: 0x2964290
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	*/

	// RVA: 0x3483980 Offset: 0x3483A81 VA: 0x3483980
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: 0x3483C30 Offset: 0x3483D31 VA: 0x3483C30
	private void SetSizedNativeArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29656A0 Offset: 0x29657A1 VA: 0x29656A0
	|-Mesh.SetArrayForChannel<Color32>
	|
	|-RVA: 0x2965720 Offset: 0x2965821 VA: 0x2965720
	|-Mesh.SetArrayForChannel<object>
	*/

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, T[] values, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29653D0 Offset: 0x29654D1 VA: 0x29653D0
	|-Mesh.SetArrayForChannel<Color>
	|
	|-RVA: 0x2965460 Offset: 0x2965561 VA: 0x2965460
	|-Mesh.SetArrayForChannel<object>
	|
	|-RVA: 0x29654F0 Offset: 0x29655F1 VA: 0x29654F0
	|-Mesh.SetArrayForChannel<Vector2>
	|
	|-RVA: 0x2965580 Offset: 0x2965681 VA: 0x2965580
	|-Mesh.SetArrayForChannel<Vector3>
	|
	|-RVA: 0x2965610 Offset: 0x2965711 VA: 0x2965610
	|-Mesh.SetArrayForChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2965C60 Offset: 0x2965D61 VA: 0x2965C60
	|-Mesh.SetListForChannel<Color32>
	|
	|-RVA: 0x2965D20 Offset: 0x2965E21 VA: 0x2965D20
	|-Mesh.SetListForChannel<object>
	|
	|-RVA: 0x2965DE0 Offset: 0x2965EE1 VA: 0x2965DE0
	|-Mesh.SetListForChannel<Vector2>
	|
	|-RVA: 0x2965EA0 Offset: 0x2965FA1 VA: 0x2965EA0
	|-Mesh.SetListForChannel<Vector3>
	|
	|-RVA: 0x2965F60 Offset: 0x2966061 VA: 0x2965F60
	|-Mesh.SetListForChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2965960 Offset: 0x2965A61 VA: 0x2965960
	|-Mesh.SetListForChannel<Color>
	|
	|-RVA: 0x2965A20 Offset: 0x2965B21 VA: 0x2965A20
	|-Mesh.SetListForChannel<object>
	|
	|-RVA: 0x2965AE0 Offset: 0x2965BE1 VA: 0x2965AE0
	|-Mesh.SetListForChannel<Vector3>
	|
	|-RVA: 0x2965BA0 Offset: 0x2965CA1 VA: 0x2965BA0
	|-Mesh.SetListForChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29648F0 Offset: 0x29649F1 VA: 0x29648F0
	|-Mesh.GetListForChannel<Color>
	|
	|-RVA: 0x2964910 Offset: 0x2964A11 VA: 0x2964910
	|-Mesh.GetListForChannel<object>
	|
	|-RVA: 0x2964930 Offset: 0x2964A31 VA: 0x2964930
	|-Mesh.GetListForChannel<Vector2>
	|
	|-RVA: 0x2964950 Offset: 0x2964A51 VA: 0x2964950
	|-Mesh.GetListForChannel<Vector3>
	|
	|-RVA: 0x2964970 Offset: 0x2964A71 VA: 0x2964970
	|-Mesh.GetListForChannel<Vector4>
	*/

	// RVA: -1 Offset: -1
	private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2964990 Offset: 0x2964A91 VA: 0x2964990
	|-Mesh.GetListForChannel<Color>
	|
	|-RVA: 0x2964A90 Offset: 0x2964B91 VA: 0x2964A90
	|-Mesh.GetListForChannel<Color32>
	|
	|-RVA: 0x2964B90 Offset: 0x2964C91 VA: 0x2964B90
	|-Mesh.GetListForChannel<object>
	|
	|-RVA: 0x2964C90 Offset: 0x2964D91 VA: 0x2964C90
	|-Mesh.GetListForChannel<Vector2>
	|
	|-RVA: 0x2964D90 Offset: 0x2964E91 VA: 0x2964D90
	|-Mesh.GetListForChannel<Vector3>
	|
	|-RVA: 0x2964E90 Offset: 0x2964F91 VA: 0x2964E90
	|-Mesh.GetListForChannel<Vector4>
	*/

	// RVA: 0x3483EE0 Offset: 0x3483FE1 VA: 0x3483EE0
	public Vector3[] get_vertices() { }

	// RVA: 0x3483F40 Offset: 0x3484041 VA: 0x3483F40
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x3483FB0 Offset: 0x34840B1 VA: 0x3483FB0
	public Vector3[] get_normals() { }

	// RVA: 0x3484010 Offset: 0x3484111 VA: 0x3484010
	public void set_normals(Vector3[] value) { }

	// RVA: 0x3484080 Offset: 0x3484181 VA: 0x3484080
	public Vector4[] get_tangents() { }

	// RVA: 0x34840E0 Offset: 0x34841E1 VA: 0x34840E0
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x3484150 Offset: 0x3484251 VA: 0x3484150
	public Vector2[] get_uv() { }

	// RVA: 0x34841B0 Offset: 0x34842B1 VA: 0x34841B0
	public void set_uv(Vector2[] value) { }

	// RVA: 0x3484220 Offset: 0x3484321 VA: 0x3484220
	public Vector2[] get_uv2() { }

	// RVA: 0x3484280 Offset: 0x3484381 VA: 0x3484280
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x34842F0 Offset: 0x34843F1 VA: 0x34842F0
	public Vector2[] get_uv3() { }

	// RVA: 0x3484350 Offset: 0x3484451 VA: 0x3484350
	public void set_uv3(Vector2[] value) { }

	// RVA: 0x34843C0 Offset: 0x34844C1 VA: 0x34843C0
	public Vector2[] get_uv4() { }

	// RVA: 0x3484420 Offset: 0x3484521 VA: 0x3484420
	public void set_uv4(Vector2[] value) { }

	// RVA: 0x3484490 Offset: 0x3484591 VA: 0x3484490
	public Vector2[] get_uv5() { }

	// RVA: 0x34844F0 Offset: 0x34845F1 VA: 0x34844F0
	public void set_uv5(Vector2[] value) { }

	// RVA: 0x3484560 Offset: 0x3484661 VA: 0x3484560
	public Vector2[] get_uv6() { }

	// RVA: 0x34845C0 Offset: 0x34846C1 VA: 0x34845C0
	public void set_uv6(Vector2[] value) { }

	// RVA: 0x3484630 Offset: 0x3484731 VA: 0x3484630
	public Vector2[] get_uv7() { }

	// RVA: 0x3484690 Offset: 0x3484791 VA: 0x3484690
	public void set_uv7(Vector2[] value) { }

	// RVA: 0x3484700 Offset: 0x3484801 VA: 0x3484700
	public Vector2[] get_uv8() { }

	// RVA: 0x3484760 Offset: 0x3484861 VA: 0x3484760
	public void set_uv8(Vector2[] value) { }

	// RVA: 0x34847D0 Offset: 0x34848D1 VA: 0x34847D0
	public Color[] get_colors() { }

	// RVA: 0x3484830 Offset: 0x3484931 VA: 0x3484830
	public void set_colors(Color[] value) { }

	// RVA: 0x34848A0 Offset: 0x34849A1 VA: 0x34848A0
	public Color32[] get_colors32() { }

	// RVA: 0x3484900 Offset: 0x3484A01 VA: 0x3484900
	public void set_colors32(Color32[] value) { }

	// RVA: 0x3484970 Offset: 0x3484A71 VA: 0x3484970
	public void GetVertices(List<Vector3> vertices) { }

	// RVA: 0x3484A60 Offset: 0x3484B61 VA: 0x3484A60
	public void SetVertices(List<Vector3> inVertices) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C020 Offset: 0x44C121 VA: 0x44C020
	// RVA: 0x3484B10 Offset: 0x3484C11 VA: 0x3484B10
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	// RVA: 0x3484B90 Offset: 0x3484C91 VA: 0x3484B90
	public void SetVertices(List<Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x3484C20 Offset: 0x3484D21 VA: 0x3484C20
	public void SetVertices(Vector3[] inVertices) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C030 Offset: 0x44C131 VA: 0x44C030
	// RVA: 0x3484CC0 Offset: 0x3484DC1 VA: 0x3484CC0
	public void SetVertices(Vector3[] inVertices, int start, int length) { }

	// RVA: 0x3484D40 Offset: 0x3484E41 VA: 0x3484D40
	public void SetVertices(Vector3[] inVertices, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	public void SetVertices<T>(NativeArray<T> inVertices) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C040 Offset: 0x44C141 VA: 0x44C040
	// RVA: -1 Offset: -1
	public void SetVertices<T>(NativeArray<T> inVertices, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetVertices<T>(NativeArray<T> inVertices, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x3484DD0 Offset: 0x3484ED1 VA: 0x3484DD0
	public void GetNormals(List<Vector3> normals) { }

	// RVA: 0x3484EC0 Offset: 0x3484FC1 VA: 0x3484EC0
	public void SetNormals(List<Vector3> inNormals) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C050 Offset: 0x44C151 VA: 0x44C050
	// RVA: 0x3484F70 Offset: 0x3485071 VA: 0x3484F70
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	// RVA: 0x3484FF0 Offset: 0x34850F1 VA: 0x3484FF0
	public void SetNormals(List<Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x3485080 Offset: 0x3485181 VA: 0x3485080
	public void SetNormals(Vector3[] inNormals) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C060 Offset: 0x44C161 VA: 0x44C060
	// RVA: 0x3485110 Offset: 0x3485211 VA: 0x3485110
	public void SetNormals(Vector3[] inNormals, int start, int length) { }

	// RVA: 0x3485190 Offset: 0x3485291 VA: 0x3485190
	public void SetNormals(Vector3[] inNormals, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	public void SetNormals<T>(NativeArray<T> inNormals) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C070 Offset: 0x44C171 VA: 0x44C070
	// RVA: -1 Offset: -1
	public void SetNormals<T>(NativeArray<T> inNormals, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetNormals<T>(NativeArray<T> inNormals, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x3485220 Offset: 0x3485321 VA: 0x3485220
	public void GetTangents(List<Vector4> tangents) { }

	// RVA: 0x3485310 Offset: 0x3485411 VA: 0x3485310
	public void SetTangents(List<Vector4> inTangents) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C080 Offset: 0x44C181 VA: 0x44C080
	// RVA: 0x34853C0 Offset: 0x34854C1 VA: 0x34853C0
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	// RVA: 0x3485440 Offset: 0x3485541 VA: 0x3485440
	public void SetTangents(List<Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x34854D0 Offset: 0x34855D1 VA: 0x34854D0
	public void SetTangents(Vector4[] inTangents) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C090 Offset: 0x44C191 VA: 0x44C090
	// RVA: 0x3485560 Offset: 0x3485661 VA: 0x3485560
	public void SetTangents(Vector4[] inTangents, int start, int length) { }

	// RVA: 0x34855E0 Offset: 0x34856E1 VA: 0x34855E0
	public void SetTangents(Vector4[] inTangents, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	public void SetTangents<T>(NativeArray<T> inTangents) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C0A0 Offset: 0x44C1A1 VA: 0x44C0A0
	// RVA: -1 Offset: -1
	public void SetTangents<T>(NativeArray<T> inTangents, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetTangents<T>(NativeArray<T> inTangents, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x3485670 Offset: 0x3485771 VA: 0x3485670
	public void GetColors(List<Color> colors) { }

	// RVA: 0x3485760 Offset: 0x3485861 VA: 0x3485760
	public void SetColors(List<Color> inColors) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C0B0 Offset: 0x44C1B1 VA: 0x44C0B0
	// RVA: 0x3485810 Offset: 0x3485911 VA: 0x3485810
	public void SetColors(List<Color> inColors, int start, int length) { }

	// RVA: 0x3485890 Offset: 0x3485991 VA: 0x3485890
	public void SetColors(List<Color> inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x3485920 Offset: 0x3485A21 VA: 0x3485920
	public void SetColors(Color[] inColors) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C0C0 Offset: 0x44C1C1 VA: 0x44C0C0
	// RVA: 0x34859B0 Offset: 0x3485AB1 VA: 0x34859B0
	public void SetColors(Color[] inColors, int start, int length) { }

	// RVA: 0x3485A30 Offset: 0x3485B31 VA: 0x3485A30
	public void SetColors(Color[] inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x3485AC0 Offset: 0x3485BC1 VA: 0x3485AC0
	public void GetColors(List<Color32> colors) { }

	// RVA: 0x3485BC0 Offset: 0x3485CC1 VA: 0x3485BC0
	public void SetColors(List<Color32> inColors) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C0D0 Offset: 0x44C1D1 VA: 0x44C0D0
	// RVA: 0x3485C90 Offset: 0x3485D91 VA: 0x3485C90
	public void SetColors(List<Color32> inColors, int start, int length) { }

	// RVA: 0x3485D30 Offset: 0x3485E31 VA: 0x3485D30
	public void SetColors(List<Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x3485DD0 Offset: 0x3485ED1 VA: 0x3485DD0
	public void SetColors(Color32[] inColors) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C0E0 Offset: 0x44C1E1 VA: 0x44C0E0
	// RVA: 0x3485E60 Offset: 0x3485F61 VA: 0x3485E60
	public void SetColors(Color32[] inColors, int start, int length) { }

	// RVA: 0x3485EE0 Offset: 0x3485FE1 VA: 0x3485EE0
	public void SetColors(Color32[] inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	public void SetColors<T>(NativeArray<T> inColors) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C0F0 Offset: 0x44C1F1 VA: 0x44C0F0
	// RVA: -1 Offset: -1
	public void SetColors<T>(NativeArray<T> inColors, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetColors<T>(NativeArray<T> inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2966020 Offset: 0x2966121 VA: 0x2966020
	|-Mesh.SetUvsImpl<object>
	|
	|-RVA: 0x2966150 Offset: 0x2966251 VA: 0x2966150
	|-Mesh.SetUvsImpl<Vector2>
	|
	|-RVA: 0x2966280 Offset: 0x2966381 VA: 0x2966280
	|-Mesh.SetUvsImpl<Vector3>
	|
	|-RVA: 0x29663B0 Offset: 0x29664B1 VA: 0x29663B0
	|-Mesh.SetUvsImpl<Vector4>
	*/

	// RVA: 0x3485F70 Offset: 0x3486071 VA: 0x3485F70
	public void SetUVs(int channel, List<Vector2> uvs) { }

	// RVA: 0x34860C0 Offset: 0x34861C1 VA: 0x34860C0
	public void SetUVs(int channel, List<Vector3> uvs) { }

	// RVA: 0x3486210 Offset: 0x3486311 VA: 0x3486210
	public void SetUVs(int channel, List<Vector4> uvs) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C100 Offset: 0x44C201 VA: 0x44C100
	// RVA: 0x3486030 Offset: 0x3486131 VA: 0x3486030
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	// RVA: 0x3486360 Offset: 0x3486461 VA: 0x3486360
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C110 Offset: 0x44C211 VA: 0x44C110
	// RVA: 0x3486180 Offset: 0x3486281 VA: 0x3486180
	public void SetUVs(int channel, List<Vector3> uvs, int start, int length) { }

	// RVA: 0x34863F0 Offset: 0x34864F1 VA: 0x34863F0
	public void SetUVs(int channel, List<Vector3> uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C120 Offset: 0x44C221 VA: 0x44C120
	// RVA: 0x34862D0 Offset: 0x34863D1 VA: 0x34862D0
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	// RVA: 0x3486480 Offset: 0x3486581 VA: 0x3486480
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x3486510 Offset: 0x3486611 VA: 0x3486510
	private void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, MeshUpdateFlags flags) { }

	// RVA: 0x3486630 Offset: 0x3486731 VA: 0x3486630
	public void SetUVs(int channel, Vector2[] uvs) { }

	// RVA: 0x34866B0 Offset: 0x34867B1 VA: 0x34866B0
	public void SetUVs(int channel, Vector3[] uvs) { }

	// RVA: 0x3486730 Offset: 0x3486831 VA: 0x3486730
	public void SetUVs(int channel, Vector4[] uvs) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C130 Offset: 0x44C231 VA: 0x44C130
	// RVA: 0x3486690 Offset: 0x3486791 VA: 0x3486690
	public void SetUVs(int channel, Vector2[] uvs, int start, int length) { }

	// RVA: 0x34867B0 Offset: 0x34868B1 VA: 0x34867B0
	public void SetUVs(int channel, Vector2[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C140 Offset: 0x44C241 VA: 0x44C140
	// RVA: 0x3486710 Offset: 0x3486811 VA: 0x3486710
	public void SetUVs(int channel, Vector3[] uvs, int start, int length) { }

	// RVA: 0x34867D0 Offset: 0x34868D1 VA: 0x34867D0
	public void SetUVs(int channel, Vector3[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C150 Offset: 0x44C251 VA: 0x44C150
	// RVA: 0x3486790 Offset: 0x3486891 VA: 0x3486790
	public void SetUVs(int channel, Vector4[] uvs, int start, int length) { }

	// RVA: 0x34867F0 Offset: 0x34868F1 VA: 0x34867F0
	public void SetUVs(int channel, Vector4[] uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	public void SetUVs<T>(int channel, NativeArray<T> uvs) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C160 Offset: 0x44C261 VA: 0x44C160
	// RVA: -1 Offset: -1
	public void SetUVs<T>(int channel, NativeArray<T> uvs, int start, int length) { }

	// RVA: -1 Offset: -1
	public void SetUVs<T>(int channel, NativeArray<T> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2964F90 Offset: 0x2965091 VA: 0x2964F90
	|-Mesh.GetUVsImpl<object>
	|
	|-RVA: 0x29650A0 Offset: 0x29651A1 VA: 0x29650A0
	|-Mesh.GetUVsImpl<Vector2>
	|
	|-RVA: 0x29651B0 Offset: 0x29652B1 VA: 0x29651B0
	|-Mesh.GetUVsImpl<Vector3>
	|
	|-RVA: 0x29652C0 Offset: 0x29653C1 VA: 0x29652C0
	|-Mesh.GetUVsImpl<Vector4>
	*/

	// RVA: 0x3486810 Offset: 0x3486911 VA: 0x3486810
	public void GetUVs(int channel, List<Vector2> uvs) { }

	// RVA: 0x3486880 Offset: 0x3486981 VA: 0x3486880
	public void GetUVs(int channel, List<Vector3> uvs) { }

	// RVA: 0x34868F0 Offset: 0x34869F1 VA: 0x34868F0
	public void GetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x3486960 Offset: 0x3486A61 VA: 0x3486960
	public int get_vertexAttributeCount() { }

	// RVA: 0x34869B0 Offset: 0x3486AB1 VA: 0x34869B0
	public VertexAttributeDescriptor[] GetVertexAttributes() { }

	// RVA: 0x3486A60 Offset: 0x3486B61 VA: 0x3486A60
	public int GetVertexAttributes(VertexAttributeDescriptor[] attributes) { }

	// RVA: 0x3486AB0 Offset: 0x3486BB1 VA: 0x3486AB0
	public int GetVertexAttributes(List<VertexAttributeDescriptor> attributes) { }

	// RVA: 0x3486B00 Offset: 0x3486C01 VA: 0x3486B00
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	// RVA: 0x3486B60 Offset: 0x3486C61 VA: 0x3486B60
	public void SetVertexBufferParams(int vertexCount, NativeArray<VertexAttributeDescriptor> attributes) { }

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29664E0 Offset: 0x29665E1 VA: 0x29664E0
	|-Mesh.SetVertexBufferData<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x29666E0 Offset: 0x29667E1 VA: 0x29666E0
	|-Mesh.SetVertexBufferData<LightUtility.SpriteLightMeshVertex>
	*/

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	// RVA: -1 Offset: -1
	public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	// RVA: 0x3486C10 Offset: 0x3486D11 VA: 0x3486C10
	public static Mesh.MeshDataArray AcquireReadOnlyMeshData(Mesh mesh) { }

	// RVA: 0x3486C50 Offset: 0x3486D51 VA: 0x3486C50
	public static Mesh.MeshDataArray AcquireReadOnlyMeshData(Mesh[] meshes) { }

	// RVA: 0x3486CF0 Offset: 0x3486DF1 VA: 0x3486CF0
	public static Mesh.MeshDataArray AcquireReadOnlyMeshData(List<Mesh> meshes) { }

	// RVA: 0x3486DE0 Offset: 0x3486EE1 VA: 0x3486DE0
	public static Mesh.MeshDataArray AllocateWritableMeshData(int meshCount) { }

	// RVA: 0x3486E10 Offset: 0x3486F11 VA: 0x3486E10
	public static void ApplyAndDisposeWritableMeshData(Mesh.MeshDataArray data, Mesh mesh, MeshUpdateFlags flags = 0) { }

	// RVA: 0x34870E0 Offset: 0x34871E1 VA: 0x34870E0
	public static void ApplyAndDisposeWritableMeshData(Mesh.MeshDataArray data, Mesh[] meshes, MeshUpdateFlags flags = 0) { }

	// RVA: 0x3487240 Offset: 0x3487341 VA: 0x3487240
	public static void ApplyAndDisposeWritableMeshData(Mesh.MeshDataArray data, List<Mesh> meshes, MeshUpdateFlags flags = 0) { }

	// RVA: 0x34873F0 Offset: 0x34874F1 VA: 0x34873F0
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x3487590 Offset: 0x3487691 VA: 0x3487590
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x3487710 Offset: 0x3487811 VA: 0x3487710
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x3487720 Offset: 0x3487821 VA: 0x3487720
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x3487730 Offset: 0x3487831 VA: 0x3487730
	public int[] get_triangles() { }

	// RVA: 0x3487800 Offset: 0x3487901 VA: 0x3487800
	public void set_triangles(int[] value) { }

	// RVA: 0x34879C0 Offset: 0x3487AC1 VA: 0x34879C0
	public int[] GetTriangles(int submesh) { }

	// RVA: 0x3487A70 Offset: 0x3487B71 VA: 0x3487A70
	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	// RVA: 0x3487B20 Offset: 0x3487C21 VA: 0x3487B20
	public void GetTriangles(List<int> triangles, int submesh) { }

	// RVA: 0x3487B30 Offset: 0x3487C31 VA: 0x3487B30
	public void GetTriangles(List<int> triangles, int submesh, bool applyBaseVertex) { }

	// RVA: 0x3487CF0 Offset: 0x3487DF1 VA: 0x3487CF0
	public void GetTriangles(List<ushort> triangles, int submesh, bool applyBaseVertex = True) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C170 Offset: 0x44C271 VA: 0x44C170
	// RVA: 0x3487EB0 Offset: 0x3487FB1 VA: 0x3487EB0
	public int[] GetIndices(int submesh) { }

	// RVA: 0x3487F60 Offset: 0x3488061 VA: 0x3487F60
	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C180 Offset: 0x44C281 VA: 0x44C180
	// RVA: 0x3488010 Offset: 0x3488111 VA: 0x3488010
	public void GetIndices(List<int> indices, int submesh) { }

	// RVA: 0x3488020 Offset: 0x3488121 VA: 0x3488020
	public void GetIndices(List<int> indices, int submesh, bool applyBaseVertex) { }

	// RVA: 0x3488290 Offset: 0x3488391 VA: 0x3488290
	public void GetIndices(List<ushort> indices, int submesh, bool applyBaseVertex = True) { }

	// RVA: -1 Offset: -1
	public void SetIndexBufferData<T>(NativeArray<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	// RVA: -1 Offset: -1
	public void SetIndexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	// RVA: -1 Offset: -1
	public void SetIndexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	// RVA: 0x3488430 Offset: 0x3488531 VA: 0x3488430
	public uint GetIndexStart(int submesh) { }

	// RVA: 0x34881C0 Offset: 0x34882C1 VA: 0x34881C0
	public uint GetIndexCount(int submesh) { }

	// RVA: 0x3488500 Offset: 0x3488601 VA: 0x3488500
	public uint GetBaseVertex(int submesh) { }

	// RVA: 0x34885D0 Offset: 0x34886D1 VA: 0x34885D0
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x3487910 Offset: 0x3487A11 VA: 0x3487910
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C190 Offset: 0x44C291 VA: 0x44C190
	// RVA: 0x3488770 Offset: 0x3488871 VA: 0x3488770
	public void SetTriangles(int[] triangles, int submesh) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C1A0 Offset: 0x44C2A1 VA: 0x44C1A0
	// RVA: 0x3488870 Offset: 0x3488971 VA: 0x3488870
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds) { }

	// RVA: 0x3488780 Offset: 0x3488881 VA: 0x3488780
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x3488880 Offset: 0x3488981 VA: 0x3488880
	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x3488960 Offset: 0x3488A61 VA: 0x3488960
	public void SetTriangles(ushort[] triangles, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x3488A50 Offset: 0x3488B51 VA: 0x3488A50
	public void SetTriangles(ushort[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C1B0 Offset: 0x44C2B1 VA: 0x44C1B0
	// RVA: 0x3488B30 Offset: 0x3488C31 VA: 0x3488B30
	public void SetTriangles(List<int> triangles, int submesh) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C1C0 Offset: 0x44C2C1 VA: 0x44C1C0
	// RVA: 0x3488C60 Offset: 0x3488D61 VA: 0x3488C60
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds) { }

	// RVA: 0x3488BC0 Offset: 0x3488CC1 VA: 0x3488BC0
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x3488CF0 Offset: 0x3488DF1 VA: 0x3488CF0
	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x3488E20 Offset: 0x3488F21 VA: 0x3488E20
	public void SetTriangles(List<ushort> triangles, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x3488EC0 Offset: 0x3488FC1 VA: 0x3488EC0
	public void SetTriangles(List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C1D0 Offset: 0x44C2D1 VA: 0x44C1D0
	// RVA: 0x3488FF0 Offset: 0x34890F1 VA: 0x3488FF0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C1E0 Offset: 0x44C2E1 VA: 0x44C1E0
	// RVA: 0x34891C0 Offset: 0x34892C1 VA: 0x34891C0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	// RVA: 0x34890D0 Offset: 0x34891D1 VA: 0x34890D0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x34892B0 Offset: 0x34893B1 VA: 0x34892B0
	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x34893A0 Offset: 0x34894A1 VA: 0x34893A0
	public void SetIndices(ushort[] indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x3489490 Offset: 0x3489591 VA: 0x3489490
	public void SetIndices(ushort[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: -1 Offset: -1
	public void SetIndices<T>(NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29657A0 Offset: 0x29658A1 VA: 0x29657A0
	|-Mesh.SetIndices<ushort>
	*/

	// RVA: -1 Offset: -1
	public void SetIndices<T>(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29657F0 Offset: 0x29658F1 VA: 0x29657F0
	|-Mesh.SetIndices<ushort>
	*/

	// RVA: 0x3489580 Offset: 0x3489681 VA: 0x3489580
	public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x3489630 Offset: 0x3489731 VA: 0x3489630
	public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x3489770 Offset: 0x3489871 VA: 0x3489770
	public void SetIndices(List<ushort> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x3489820 Offset: 0x3489921 VA: 0x3489820
	public void SetIndices(List<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x3489960 Offset: 0x3489A61 VA: 0x3489960
	public void SetSubMeshes(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags = 0) { }

	// RVA: 0x3489C40 Offset: 0x3489D41 VA: 0x3489C40
	public void SetSubMeshes(SubMeshDescriptor[] desc, MeshUpdateFlags flags = 0) { }

	// RVA: 0x3489C60 Offset: 0x3489D61 VA: 0x3489C60
	public void SetSubMeshes(List<SubMeshDescriptor> desc, int start, int count, MeshUpdateFlags flags = 0) { }

	// RVA: 0x3489CF0 Offset: 0x3489DF1 VA: 0x3489CF0
	public void SetSubMeshes(List<SubMeshDescriptor> desc, MeshUpdateFlags flags = 0) { }

	// RVA: -1 Offset: -1
	public void SetSubMeshes<T>(NativeArray<T> desc, int start, int count, MeshUpdateFlags flags = 0) { }

	// RVA: -1 Offset: -1
	public void SetSubMeshes<T>(NativeArray<T> desc, MeshUpdateFlags flags = 0) { }

	// RVA: 0x3489D90 Offset: 0x3489E91 VA: 0x3489D90
	public void GetBindposes(List<Matrix4x4> bindposes) { }

	// RVA: 0x3489ED0 Offset: 0x3489FD1 VA: 0x3489ED0
	public void GetBoneWeights(List<BoneWeight> boneWeights) { }

	// RVA: 0x348A030 Offset: 0x348A131 VA: 0x348A030
	public BoneWeight[] get_boneWeights() { }

	// RVA: 0x348A080 Offset: 0x348A181 VA: 0x348A080
	public void set_boneWeights(BoneWeight[] value) { }

	// RVA: 0x348A0D0 Offset: 0x348A1D1 VA: 0x348A0D0
	public void Clear(bool keepVertexLayout) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C1F0 Offset: 0x44C2F1 VA: 0x44C1F0
	// RVA: 0x348A120 Offset: 0x348A221 VA: 0x348A120
	public void Clear() { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C200 Offset: 0x44C301 VA: 0x44C200
	// RVA: 0x348A170 Offset: 0x348A271 VA: 0x348A170
	public void RecalculateBounds() { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C210 Offset: 0x44C311 VA: 0x44C210
	// RVA: 0x348A310 Offset: 0x348A411 VA: 0x348A310
	public void RecalculateNormals() { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C220 Offset: 0x44C321 VA: 0x44C220
	// RVA: 0x348A4B0 Offset: 0x348A5B1 VA: 0x348A4B0
	public void RecalculateTangents() { }

	// RVA: 0x348A180 Offset: 0x348A281 VA: 0x348A180
	public void RecalculateBounds(MeshUpdateFlags flags) { }

	// RVA: 0x348A320 Offset: 0x348A421 VA: 0x348A320
	public void RecalculateNormals(MeshUpdateFlags flags) { }

	// RVA: 0x348A4C0 Offset: 0x348A5C1 VA: 0x348A4C0
	public void RecalculateTangents(MeshUpdateFlags flags) { }

	// RVA: 0x348A650 Offset: 0x348A751 VA: 0x348A650
	public void RecalculateUVDistributionMetric(int uvSetIndex, float uvAreaThreshold = 1E-09) { }

	// RVA: 0x348A7F0 Offset: 0x348A8F1 VA: 0x348A7F0
	public void RecalculateUVDistributionMetrics(float uvAreaThreshold = 1E-09) { }

	// RVA: 0x348A990 Offset: 0x348AA91 VA: 0x348A990
	public void MarkDynamic() { }

	// RVA: 0x348AA30 Offset: 0x348AB31 VA: 0x348AA30
	public void UploadMeshData(bool markNoLongerReadable) { }

	// RVA: 0x348AAD0 Offset: 0x348ABD1 VA: 0x348AAD0
	public void Optimize() { }

	// RVA: 0x348AC60 Offset: 0x348AD61 VA: 0x348AC60
	public void OptimizeIndexBuffers() { }

	// RVA: 0x348ADF0 Offset: 0x348AEF1 VA: 0x348ADF0
	public void OptimizeReorderVertexBuffer() { }

	// RVA: 0x348AF80 Offset: 0x348B081 VA: 0x348AF80
	public MeshTopology GetTopology(int submesh) { }

	// RVA: 0x348B090 Offset: 0x348B191 VA: 0x348B090
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C230 Offset: 0x44C331 VA: 0x44C230
	// RVA: 0x348B100 Offset: 0x348B201 VA: 0x348B100
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C240 Offset: 0x44C341 VA: 0x44C240
	// RVA: 0x348B170 Offset: 0x348B271 VA: 0x348B170
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44C250 Offset: 0x44C351 VA: 0x44C250
	// RVA: 0x348B1D0 Offset: 0x348B2D1 VA: 0x348B1D0
	public void CombineMeshes(CombineInstance[] combine) { }

	// RVA: 0x3481AA0 Offset: 0x3481BA1 VA: 0x3481AA0
	private void GetVertexAttribute_Injected(int index, out VertexAttributeDescriptor ret) { }

	// RVA: 0x3482FD0 Offset: 0x34830D1 VA: 0x3482FD0
	private void SetSubMesh_Injected(int index, ref SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

	// RVA: 0x34830D0 Offset: 0x34831D1 VA: 0x34830D0
	private void GetSubMesh_Injected(int index, out SubMeshDescriptor ret) { }

	// RVA: 0x3483290 Offset: 0x3483391 VA: 0x3483290
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x3483330 Offset: 0x3483431 VA: 0x3483330
	private void set_bounds_Injected(ref Bounds value) { }
}

