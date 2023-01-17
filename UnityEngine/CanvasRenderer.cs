// Namespace: UnityEngine
[NativeClassAttribute] // RVA: 0x68530 Offset: 0x68631 VA: 0x68530
[NativeHeaderAttribute] // RVA: 0x68530 Offset: 0x68631 VA: 0x68530
public sealed class CanvasRenderer : Component // TypeDefIndex: 4227
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x687C0 Offset: 0x688C1 VA: 0x687C0
	[CompilerGeneratedAttribute] // RVA: 0x687C0 Offset: 0x688C1 VA: 0x687C0
	private bool <isMask>k__BackingField; // 0x18

	// Properties
	public bool hasPopInstruction { get; set; }
	public int materialCount { get; set; }
	public int popMaterialCount { get; set; }
	public int absoluteDepth { get; }
	public bool hasMoved { get; }
	public bool cullTransparentMesh { get; set; }
	[NativePropertyAttribute] // RVA: 0x68C30 Offset: 0x68D31 VA: 0x68C30
	public bool hasRectClipping { get; }
	[NativePropertyAttribute] // RVA: 0x68C70 Offset: 0x68D71 VA: 0x68C70
	public int relativeDepth { get; }
	[NativePropertyAttribute] // RVA: 0x68CB0 Offset: 0x68DB1 VA: 0x68CB0
	public bool cull { get; set; }
	[ObsoleteAttribute] // RVA: 0x68CF0 Offset: 0x68DF1 VA: 0x68CF0
	public bool isMask { get; set; }
	public Vector2 clippingSoftness { get; set; }

	// Methods

	// RVA: 0x1C519D0 Offset: 0x1C51AD1 VA: 0x1C519D0
	public bool get_hasPopInstruction() { }

	// RVA: 0x1C51A20 Offset: 0x1C51B21 VA: 0x1C51A20
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x1C51A70 Offset: 0x1C51B71 VA: 0x1C51A70
	public int get_materialCount() { }

	// RVA: 0x1C51AC0 Offset: 0x1C51BC1 VA: 0x1C51AC0
	public void set_materialCount(int value) { }

	// RVA: 0x1C51B10 Offset: 0x1C51C11 VA: 0x1C51B10
	public int get_popMaterialCount() { }

	// RVA: 0x1C51B60 Offset: 0x1C51C61 VA: 0x1C51B60
	public void set_popMaterialCount(int value) { }

	// RVA: 0x1C51BB0 Offset: 0x1C51CB1 VA: 0x1C51BB0
	public int get_absoluteDepth() { }

	// RVA: 0x1C51C00 Offset: 0x1C51D01 VA: 0x1C51C00
	public bool get_hasMoved() { }

	// RVA: 0x1C51C50 Offset: 0x1C51D51 VA: 0x1C51C50
	public bool get_cullTransparentMesh() { }

	// RVA: 0x1C51CA0 Offset: 0x1C51DA1 VA: 0x1C51CA0
	public void set_cullTransparentMesh(bool value) { }

	// RVA: 0x1C51CF0 Offset: 0x1C51DF1 VA: 0x1C51CF0
	public bool get_hasRectClipping() { }

	// RVA: 0x1C51D40 Offset: 0x1C51E41 VA: 0x1C51D40
	public int get_relativeDepth() { }

	// RVA: 0x1C51D90 Offset: 0x1C51E91 VA: 0x1C51D90
	public bool get_cull() { }

	// RVA: 0x1C51DE0 Offset: 0x1C51EE1 VA: 0x1C51DE0
	public void set_cull(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x68880 Offset: 0x68981 VA: 0x68880
	// RVA: 0x1C51E30 Offset: 0x1C51F31 VA: 0x1C51E30
	public bool get_isMask() { }

	[CompilerGeneratedAttribute] // RVA: 0x68890 Offset: 0x68991 VA: 0x68890
	// RVA: 0x1C51E40 Offset: 0x1C51F41 VA: 0x1C51E40
	public void set_isMask(bool value) { }

	// RVA: 0x1C51E50 Offset: 0x1C51F51 VA: 0x1C51E50
	public void SetColor(Color color) { }

	// RVA: 0x1C51F00 Offset: 0x1C52001 VA: 0x1C51F00
	public Color GetColor() { }

	// RVA: 0x1C51FB0 Offset: 0x1C520B1 VA: 0x1C51FB0
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x1C52060 Offset: 0x1C52161 VA: 0x1C52060
	public Vector2 get_clippingSoftness() { }

	// RVA: 0x1C52110 Offset: 0x1C52211 VA: 0x1C52110
	public void set_clippingSoftness(Vector2 value) { }

	// RVA: 0x1C521C0 Offset: 0x1C522C1 VA: 0x1C521C0
	public void DisableRectClipping() { }

	// RVA: 0x1C52210 Offset: 0x1C52311 VA: 0x1C52210
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x1C52270 Offset: 0x1C52371 VA: 0x1C52270
	public Material GetMaterial(int index) { }

	// RVA: 0x1C522C0 Offset: 0x1C523C1 VA: 0x1C522C0
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x1C52320 Offset: 0x1C52421 VA: 0x1C52320
	public Material GetPopMaterial(int index) { }

	// RVA: 0x1C52370 Offset: 0x1C52471 VA: 0x1C52370
	public void SetTexture(Texture texture) { }

	// RVA: 0x1C523C0 Offset: 0x1C524C1 VA: 0x1C523C0
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x1C52410 Offset: 0x1C52511 VA: 0x1C52410
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x1C52460 Offset: 0x1C52561 VA: 0x1C52460
	public void Clear() { }

	// RVA: 0x1C524B0 Offset: 0x1C525B1 VA: 0x1C524B0
	public float GetAlpha() { }

	// RVA: 0x1C52510 Offset: 0x1C52611 VA: 0x1C52510
	public void SetAlpha(float alpha) { }

	// RVA: 0x1C525B0 Offset: 0x1C526B1 VA: 0x1C525B0
	public float GetInheritedAlpha() { }

	// RVA: 0x1C52600 Offset: 0x1C52701 VA: 0x1C52600
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x1C52740 Offset: 0x1C52841 VA: 0x1C52740
	public Material GetMaterial() { }

	// RVA: 0x1C52790 Offset: 0x1C52891 VA: 0x1C52790
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x1C528D0 Offset: 0x1C529D1 VA: 0x1C528D0
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x1C52AA0 Offset: 0x1C52BA1 VA: 0x1C52AA0
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x1C52BB0 Offset: 0x1C52CB1 VA: 0x1C52BB0
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x1C52D10 Offset: 0x1C52E11 VA: 0x1C52D10
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents) { }

	// RVA: 0x1C52E20 Offset: 0x1C52F21 VA: 0x1C52E20
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[ObsoleteAttribute] // RVA: 0x688A0 Offset: 0x689A1 VA: 0x688A0
	// RVA: 0x1C52EC0 Offset: 0x1C52FC1 VA: 0x1C52EC0
	public void SetVertices(List<UIVertex> vertices) { }

	[ObsoleteAttribute] // RVA: 0x688E0 Offset: 0x689E1 VA: 0x688E0
	// RVA: 0x1C52F40 Offset: 0x1C53041 VA: 0x1C52F40
	public void SetVertices(UIVertex[] vertices, int size) { }

	[StaticAccessorAttribute] // RVA: 0x68920 Offset: 0x68A21 VA: 0x68920
	// RVA: 0x1C52A50 Offset: 0x1C52B51 VA: 0x1C52A50
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[StaticAccessorAttribute] // RVA: 0x68960 Offset: 0x68A61 VA: 0x68960
	// RVA: 0x1C529B0 Offset: 0x1C52AB1 VA: 0x1C529B0
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	[StaticAccessorAttribute] // RVA: 0x689A0 Offset: 0x68AA1 VA: 0x689A0
	// RVA: 0x1C52C60 Offset: 0x1C52D61 VA: 0x1C52C60
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x1C53460 Offset: 0x1C53561 VA: 0x1C53460
	public void .ctor() { }

	// RVA: 0x1C51EB0 Offset: 0x1C51FB1 VA: 0x1C51EB0
	private void SetColor_Injected(ref Color color) { }

	// RVA: 0x1C51F60 Offset: 0x1C52061 VA: 0x1C51F60
	private void GetColor_Injected(out Color ret) { }

	// RVA: 0x1C52010 Offset: 0x1C52111 VA: 0x1C52010
	private void EnableRectClipping_Injected(ref Rect rect) { }

	// RVA: 0x1C520C0 Offset: 0x1C521C1 VA: 0x1C520C0
	private void get_clippingSoftness_Injected(out Vector2 ret) { }

	// RVA: 0x1C52170 Offset: 0x1C52271 VA: 0x1C52170
	private void set_clippingSoftness_Injected(ref Vector2 value) { }
}

