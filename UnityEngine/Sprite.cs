// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43F1A0 Offset: 0x43F2A1 VA: 0x43F1A0
[NativeHeaderAttribute] // RVA: 0x43F1A0 Offset: 0x43F2A1 VA: 0x43F1A0
[NativeTypeAttribute] // RVA: 0x43F1A0 Offset: 0x43F2A1 VA: 0x43F1A0
[NativeHeaderAttribute] // RVA: 0x43F1A0 Offset: 0x43F2A1 VA: 0x43F1A0
[ExcludeFromPresetAttribute] // RVA: 0x43F1A0 Offset: 0x43F2A1 VA: 0x43F1A0
public sealed class Sprite : Object // TypeDefIndex: 3657
{
	// Properties
	public Bounds bounds { get; }
	public Rect rect { get; }
	public Vector4 border { get; }
	public Texture2D texture { get; }
	public float pixelsPerUnit { get; }
	public float spriteAtlasTextureScale { get; }
	public Texture2D associatedAlphaSplitTexture { get; }
	public Vector2 pivot { get; }
	public bool packed { get; }
	public SpritePackingMode packingMode { get; }
	public SpritePackingRotation packingRotation { get; }
	public Rect textureRect { get; }
	public Vector2 textureRectOffset { get; }
	public Vector2[] vertices { get; }
	public ushort[] triangles { get; }
	public Vector2[] uv { get; }

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x451CB0 Offset: 0x451DB1 VA: 0x451CB0
	// RVA: 0x31EEBD0 Offset: 0x31EECD1 VA: 0x31EEBD0
	private void .ctor() { }

	// RVA: 0x31EEC40 Offset: 0x31EED41 VA: 0x31EEC40
	internal int GetPackingMode() { }

	// RVA: 0x31EEC90 Offset: 0x31EED91 VA: 0x31EEC90
	internal int GetPackingRotation() { }

	// RVA: 0x31EECE0 Offset: 0x31EEDE1 VA: 0x31EECE0
	internal int GetPacked() { }

	// RVA: 0x31EED30 Offset: 0x31EEE31 VA: 0x31EED30
	internal Rect GetTextureRect() { }

	// RVA: 0x31EEDE0 Offset: 0x31EEEE1 VA: 0x31EEDE0
	internal Vector2 GetTextureRectOffset() { }

	// RVA: 0x31EEE90 Offset: 0x31EEF91 VA: 0x31EEE90
	internal Vector4 GetInnerUVs() { }

	// RVA: 0x31EEF40 Offset: 0x31EF041 VA: 0x31EEF40
	internal Vector4 GetOuterUVs() { }

	// RVA: 0x31EEFF0 Offset: 0x31EF0F1 VA: 0x31EEFF0
	internal Vector4 GetPadding() { }

	[FreeFunctionAttribute] // RVA: 0x451CC0 Offset: 0x451DC1 VA: 0x451CC0
	// RVA: 0x31EF0A0 Offset: 0x31EF1A1 VA: 0x31EF0A0
	internal static Sprite CreateSpriteWithoutTextureScripting(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	[FreeFunctionAttribute] // RVA: 0x451D00 Offset: 0x451E01 VA: 0x451D00
	// RVA: 0x31EF180 Offset: 0x31EF281 VA: 0x31EF180
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x31EF2D0 Offset: 0x31EF3D1 VA: 0x31EF2D0
	public Bounds get_bounds() { }

	// RVA: 0x31EF3A0 Offset: 0x31EF4A1 VA: 0x31EF3A0
	public Rect get_rect() { }

	// RVA: 0x31EF450 Offset: 0x31EF551 VA: 0x31EF450
	public Vector4 get_border() { }

	// RVA: 0x31EF500 Offset: 0x31EF601 VA: 0x31EF500
	public Texture2D get_texture() { }

	// RVA: 0x31EF550 Offset: 0x31EF651 VA: 0x31EF550
	internal Texture2D GetSecondaryTexture(int index) { }

	[NativeMethodAttribute] // RVA: 0x451D40 Offset: 0x451E41 VA: 0x451D40
	// RVA: 0x31EF5A0 Offset: 0x31EF6A1 VA: 0x31EF5A0
	public float get_pixelsPerUnit() { }

	[NativeMethodAttribute] // RVA: 0x451D80 Offset: 0x451E81 VA: 0x451D80
	// RVA: 0x31EF5F0 Offset: 0x31EF6F1 VA: 0x31EF5F0
	public float get_spriteAtlasTextureScale() { }

	[NativeMethodAttribute] // RVA: 0x451DC0 Offset: 0x451EC1 VA: 0x451DC0
	// RVA: 0x31EF640 Offset: 0x31EF741 VA: 0x31EF640
	public Texture2D get_associatedAlphaSplitTexture() { }

	[NativeMethodAttribute] // RVA: 0x451E00 Offset: 0x451F01 VA: 0x451E00
	// RVA: 0x31EF690 Offset: 0x31EF791 VA: 0x31EF690
	public Vector2 get_pivot() { }

	// RVA: 0x31EF740 Offset: 0x31EF841 VA: 0x31EF740
	public bool get_packed() { }

	// RVA: 0x31EF790 Offset: 0x31EF891 VA: 0x31EF790
	public SpritePackingMode get_packingMode() { }

	// RVA: 0x31EF7E0 Offset: 0x31EF8E1 VA: 0x31EF7E0
	public SpritePackingRotation get_packingRotation() { }

	// RVA: 0x31EF830 Offset: 0x31EF931 VA: 0x31EF830
	public Rect get_textureRect() { }

	// RVA: 0x31EF930 Offset: 0x31EFA31 VA: 0x31EF930
	public Vector2 get_textureRectOffset() { }

	[FreeFunctionAttribute] // RVA: 0x451E40 Offset: 0x451F41 VA: 0x451E40
	// RVA: 0x31EFA30 Offset: 0x31EFB31 VA: 0x31EFA30
	public Vector2[] get_vertices() { }

	[FreeFunctionAttribute] // RVA: 0x451E90 Offset: 0x451F91 VA: 0x451E90
	// RVA: 0x31EFA80 Offset: 0x31EFB81 VA: 0x31EFA80
	public ushort[] get_triangles() { }

	[FreeFunctionAttribute] // RVA: 0x451EE0 Offset: 0x451FE1 VA: 0x451EE0
	// RVA: 0x31EFAD0 Offset: 0x31EFBD1 VA: 0x31EFAD0
	public Vector2[] get_uv() { }

	// RVA: 0x31EFB20 Offset: 0x31EFC21 VA: 0x31EFB20
	public int GetPhysicsShapeCount() { }

	// RVA: 0x31EFB70 Offset: 0x31EFC71 VA: 0x31EFB70
	public int GetPhysicsShapePointCount(int shapeIdx) { }

	[NativeMethodAttribute] // RVA: 0x451F30 Offset: 0x452031 VA: 0x451F30
	// RVA: 0x31EFC90 Offset: 0x31EFD91 VA: 0x31EFC90
	private int Internal_GetPhysicsShapePointCount(int shapeIdx) { }

	// RVA: 0x31EFCE0 Offset: 0x31EFDE1 VA: 0x31EFCE0
	public int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape) { }

	[FreeFunctionAttribute] // RVA: 0x451F70 Offset: 0x452071 VA: 0x451F70
	// RVA: 0x31EFE50 Offset: 0x31EFF51 VA: 0x31EFE50
	private static void GetPhysicsShapeImpl(Sprite sprite, int shapeIdx, List<Vector2> physicsShape) { }

	// RVA: 0x31EFEB0 Offset: 0x31EFFB1 VA: 0x31EFEB0
	public void OverridePhysicsShape(IList<Vector2[]> physicsShapes) { }

	[FreeFunctionAttribute] // RVA: 0x451FC0 Offset: 0x4520C1 VA: 0x451FC0
	// RVA: 0x31F02A0 Offset: 0x31F03A1 VA: 0x31F02A0
	private static void OverridePhysicsShapeCount(Sprite sprite, int physicsShapeCount) { }

	[FreeFunctionAttribute] // RVA: 0x452000 Offset: 0x452101 VA: 0x452000
	// RVA: 0x31F02F0 Offset: 0x31F03F1 VA: 0x31F02F0
	private static void OverridePhysicsShape(Sprite sprite, Vector2[] physicsShape, int idx) { }

	[FreeFunctionAttribute] // RVA: 0x452050 Offset: 0x452151 VA: 0x452050
	// RVA: 0x31F0350 Offset: 0x31F0451 VA: 0x31F0350
	public void OverrideGeometry(Vector2[] vertices, ushort[] triangles) { }

	// RVA: 0x31F03B0 Offset: 0x31F04B1 VA: 0x31F03B0
	internal static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	// RVA: 0x31F0420 Offset: 0x31F0521 VA: 0x31F0420
	internal static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits) { }

	// RVA: 0x31F0490 Offset: 0x31F0591 VA: 0x31F0490
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x31F0830 Offset: 0x31F0931 VA: 0x31F0830
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0x31F0850 Offset: 0x31F0951 VA: 0x31F0850
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	// RVA: 0x31F0910 Offset: 0x31F0A11 VA: 0x31F0910
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	// RVA: 0x31F09C0 Offset: 0x31F0AC1 VA: 0x31F09C0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	// RVA: 0x31F0A70 Offset: 0x31F0B71 VA: 0x31F0A70
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0x31EED90 Offset: 0x31EEE91 VA: 0x31EED90
	private void GetTextureRect_Injected(out Rect ret) { }

	// RVA: 0x31EEE40 Offset: 0x31EEF41 VA: 0x31EEE40
	private void GetTextureRectOffset_Injected(out Vector2 ret) { }

	// RVA: 0x31EEEF0 Offset: 0x31EEFF1 VA: 0x31EEEF0
	private void GetInnerUVs_Injected(out Vector4 ret) { }

	// RVA: 0x31EEFA0 Offset: 0x31EF0A1 VA: 0x31EEFA0
	private void GetOuterUVs_Injected(out Vector4 ret) { }

	// RVA: 0x31EF050 Offset: 0x31EF151 VA: 0x31EF050
	private void GetPadding_Injected(out Vector4 ret) { }

	// RVA: 0x31EF110 Offset: 0x31EF211 VA: 0x31EF110
	private static Sprite CreateSpriteWithoutTextureScripting_Injected(ref Rect rect, ref Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	// RVA: 0x31EF230 Offset: 0x31EF331 VA: 0x31EF230
	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x31EF350 Offset: 0x31EF451 VA: 0x31EF350
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x31EF400 Offset: 0x31EF501 VA: 0x31EF400
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x31EF4B0 Offset: 0x31EF5B1 VA: 0x31EF4B0
	private void get_border_Injected(out Vector4 ret) { }

	// RVA: 0x31EF6F0 Offset: 0x31EF7F1 VA: 0x31EF6F0
	private void get_pivot_Injected(out Vector2 ret) { }
}

