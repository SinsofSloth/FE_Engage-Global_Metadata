// Namespace: UnityEngine.UI
[AddComponentMenu] // RVA: 0x42AB0 Offset: 0x42BB1 VA: 0x42AB0
[RequireComponent] // RVA: 0x42AB0 Offset: 0x42BB1 VA: 0x42AB0
public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 4282
{
	// Fields
	protected static Material s_ETC1DefaultUI; // 0x0
	[SerializeField] // RVA: 0x443C0 Offset: 0x444C1 VA: 0x443C0
	[FormerlySerializedAsAttribute] // RVA: 0x443C0 Offset: 0x444C1 VA: 0x443C0
	private Sprite m_Sprite; // 0xD0
	private Sprite m_OverrideSprite; // 0xD8
	[SerializeField] // RVA: 0x44410 Offset: 0x44511 VA: 0x44410
	private Image.Type m_Type; // 0xE0
	[SerializeField] // RVA: 0x44420 Offset: 0x44521 VA: 0x44420
	private bool m_PreserveAspect; // 0xE4
	[SerializeField] // RVA: 0x44430 Offset: 0x44531 VA: 0x44430
	private bool m_FillCenter; // 0xE5
	[SerializeField] // RVA: 0x44440 Offset: 0x44541 VA: 0x44440
	private Image.FillMethod m_FillMethod; // 0xE8
	[RangeAttribute] // RVA: 0x44450 Offset: 0x44551 VA: 0x44450
	[SerializeField] // RVA: 0x44450 Offset: 0x44551 VA: 0x44450
	private float m_FillAmount; // 0xEC
	[SerializeField] // RVA: 0x44490 Offset: 0x44591 VA: 0x44490
	private bool m_FillClockwise; // 0xF0
	[SerializeField] // RVA: 0x444A0 Offset: 0x445A1 VA: 0x444A0
	private int m_FillOrigin; // 0xF4
	private float m_AlphaHitTestMinimumThreshold; // 0xF8
	private bool m_Tracked; // 0xFC
	[SerializeField] // RVA: 0x444B0 Offset: 0x445B1 VA: 0x444B0
	private bool m_UseSpriteMesh; // 0xFD
	[SerializeField] // RVA: 0x444C0 Offset: 0x445C1 VA: 0x444C0
	private float m_PixelsPerUnitMultiplier; // 0x100
	private float m_CachedReferencePixelsPerUnit; // 0x104
	private static readonly Vector2[] s_VertScratch; // 0x8
	private static readonly Vector2[] s_UVScratch; // 0x10
	private static readonly Vector3[] s_Xy; // 0x18
	private static readonly Vector3[] s_Uv; // 0x20
	private static List<Image> m_TrackedTexturelessImages; // 0x28
	private static bool s_Initialized; // 0x30

	// Properties
	public Sprite sprite { get; set; }
	public Sprite overrideSprite { get; set; }
	private Sprite activeSprite { get; }
	public Image.Type type { get; set; }
	public bool preserveAspect { get; set; }
	public bool fillCenter { get; set; }
	public Image.FillMethod fillMethod { get; set; }
	public float fillAmount { get; set; }
	public bool fillClockwise { get; set; }
	public int fillOrigin { get; set; }
	[ObsoleteAttribute] // RVA: 0x46760 Offset: 0x46861 VA: 0x46760
	public float eventAlphaThreshold { get; set; }
	public float alphaHitTestMinimumThreshold { get; set; }
	public bool useSpriteMesh { get; set; }
	public static Material defaultETC1GraphicMaterial { get; }
	public override Texture mainTexture { get; }
	public bool hasBorder { get; }
	public float pixelsPerUnitMultiplier { get; set; }
	public float pixelsPerUnit { get; }
	protected float multipliedPixelsPerUnit { get; }
	public override Material material { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x1BDDA20 Offset: 0x1BDDB21 VA: 0x1BDDA20
	public Sprite get_sprite() { }

	// RVA: 0x1BDDA30 Offset: 0x1BDDB31 VA: 0x1BDDA30
	public void set_sprite(Sprite value) { }

	// RVA: 0x1BDDEC0 Offset: 0x1BDDFC1 VA: 0x1BDDEC0
	public void DisableSpriteOptimizations() { }

	// RVA: 0x1BDDED0 Offset: 0x1BDDFD1 VA: 0x1BDDED0
	public Sprite get_overrideSprite() { }

	// RVA: 0x1BDDFF0 Offset: 0x1BDE0F1 VA: 0x1BDDFF0
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x1BDDF60 Offset: 0x1BDE061 VA: 0x1BDDF60
	private Sprite get_activeSprite() { }

	// RVA: 0x1BDE080 Offset: 0x1BDE181 VA: 0x1BDE080
	public Image.Type get_type() { }

	// RVA: 0x1BDE090 Offset: 0x1BDE191 VA: 0x1BDE090
	public void set_type(Image.Type value) { }

	// RVA: 0x1BDE120 Offset: 0x1BDE221 VA: 0x1BDE120
	public bool get_preserveAspect() { }

	// RVA: 0x1BDE130 Offset: 0x1BDE231 VA: 0x1BDE130
	public void set_preserveAspect(bool value) { }

	// RVA: 0x1BDE1C0 Offset: 0x1BDE2C1 VA: 0x1BDE1C0
	public bool get_fillCenter() { }

	// RVA: 0x1BDE1D0 Offset: 0x1BDE2D1 VA: 0x1BDE1D0
	public void set_fillCenter(bool value) { }

	// RVA: 0x1BDE260 Offset: 0x1BDE361 VA: 0x1BDE260
	public Image.FillMethod get_fillMethod() { }

	// RVA: 0x1BDE270 Offset: 0x1BDE371 VA: 0x1BDE270
	public void set_fillMethod(Image.FillMethod value) { }

	// RVA: 0x1BDE2F0 Offset: 0x1BDE3F1 VA: 0x1BDE2F0
	public float get_fillAmount() { }

	// RVA: 0x1BDE300 Offset: 0x1BDE401 VA: 0x1BDE300
	public void set_fillAmount(float value) { }

	// RVA: 0x1BDE3A0 Offset: 0x1BDE4A1 VA: 0x1BDE3A0
	public bool get_fillClockwise() { }

	// RVA: 0x1BDE3B0 Offset: 0x1BDE4B1 VA: 0x1BDE3B0
	public void set_fillClockwise(bool value) { }

	// RVA: 0x1BDE440 Offset: 0x1BDE541 VA: 0x1BDE440
	public int get_fillOrigin() { }

	// RVA: 0x1BDE450 Offset: 0x1BDE551 VA: 0x1BDE450
	public void set_fillOrigin(int value) { }

	// RVA: 0x1BDE4E0 Offset: 0x1BDE5E1 VA: 0x1BDE4E0
	public float get_eventAlphaThreshold() { }

	// RVA: 0x1BDE4F0 Offset: 0x1BDE5F1 VA: 0x1BDE4F0
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x1BDE500 Offset: 0x1BDE601 VA: 0x1BDE500
	public float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x1BDE510 Offset: 0x1BDE611 VA: 0x1BDE510
	public void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0x1BDE520 Offset: 0x1BDE621 VA: 0x1BDE520
	public bool get_useSpriteMesh() { }

	// RVA: 0x1BDE530 Offset: 0x1BDE631 VA: 0x1BDE530
	public void set_useSpriteMesh(bool value) { }

	// RVA: 0x1BDE5C0 Offset: 0x1BDE6C1 VA: 0x1BDE5C0
	protected void .ctor() { }

	// RVA: 0x1BDE610 Offset: 0x1BDE711 VA: 0x1BDE610
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x1BDE720 Offset: 0x1BDE821 VA: 0x1BDE720 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x1BDE970 Offset: 0x1BDEA71 VA: 0x1BDE970
	public bool get_hasBorder() { }

	// RVA: 0x1BDEAF0 Offset: 0x1BDEBF1 VA: 0x1BDEAF0
	public float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x1BDEB00 Offset: 0x1BDEC01 VA: 0x1BDEB00
	public void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x1BDEB50 Offset: 0x1BDEC51 VA: 0x1BDEB50
	public float get_pixelsPerUnit() { }

	// RVA: 0x1BDED30 Offset: 0x1BDEE31 VA: 0x1BDED30
	protected float get_multipliedPixelsPerUnit() { }

	// RVA: 0x1BDED60 Offset: 0x1BDEE61 VA: 0x1BDED60 Slot: 32
	public override Material get_material() { }

	// RVA: 0x1BDEF80 Offset: 0x1BDF081 VA: 0x1BDEF80 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x1BDEF90 Offset: 0x1BDF091 VA: 0x1BDEF90 Slot: 77
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x1BDEFA0 Offset: 0x1BDF0A1 VA: 0x1BDEFA0 Slot: 78
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x1BDF010 Offset: 0x1BDF111 VA: 0x1BDF010
	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	// RVA: 0x1BDF170 Offset: 0x1BDF271 VA: 0x1BDF170
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x1BDF5E0 Offset: 0x1BDF6E1 VA: 0x1BDF5E0 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x1BDF840 Offset: 0x1BDF941 VA: 0x1BDF840 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x1BDDD10 Offset: 0x1BDDE11 VA: 0x1BDDD10
	private void TrackSprite() { }

	// RVA: 0x1BE2FD0 Offset: 0x1BE30D1 VA: 0x1BE2FD0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1BE3000 Offset: 0x1BE3101 VA: 0x1BE3000 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1BE3190 Offset: 0x1BE3291 VA: 0x1BE3190 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1BE3350 Offset: 0x1BE3451 VA: 0x1BE3350 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1BDF9F0 Offset: 0x1BDFAF1 VA: 0x1BDF9F0
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x1BDFDC0 Offset: 0x1BDFEC1 VA: 0x1BDFDC0
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x1BE0380 Offset: 0x1BE0481 VA: 0x1BE0380
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x1BE0FC0 Offset: 0x1BE10C1 VA: 0x1BE0FC0
	private void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x1BE39A0 Offset: 0x1BE3AA1 VA: 0x1BE39A0
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x1BE37C0 Offset: 0x1BE38C1 VA: 0x1BE37C0
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x1BE3470 Offset: 0x1BE3571 VA: 0x1BE3470
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x1BE2100 Offset: 0x1BE2201 VA: 0x1BE2100
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x1BE3BE0 Offset: 0x1BE3CE1 VA: 0x1BE3BE0
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x1BE3D30 Offset: 0x1BE3E31 VA: 0x1BE3D30
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x1BE4100 Offset: 0x1BE4201 VA: 0x1BE4100 Slot: 79
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1BE4110 Offset: 0x1BE4211 VA: 0x1BE4110 Slot: 80
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1BE4120 Offset: 0x1BE4221 VA: 0x1BE4120 Slot: 81
	public virtual float get_minWidth() { }

	// RVA: 0x1BE4130 Offset: 0x1BE4231 VA: 0x1BE4130 Slot: 82
	public virtual float get_preferredWidth() { }

	// RVA: 0x1BE4320 Offset: 0x1BE4421 VA: 0x1BE4320 Slot: 83
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1BE4330 Offset: 0x1BE4431 VA: 0x1BE4330 Slot: 84
	public virtual float get_minHeight() { }

	// RVA: 0x1BE4340 Offset: 0x1BE4441 VA: 0x1BE4340 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x1BE4530 Offset: 0x1BE4631 VA: 0x1BE4530 Slot: 86
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1BE4540 Offset: 0x1BE4641 VA: 0x1BE4540 Slot: 87
	public virtual int get_layoutPriority() { }

	// RVA: 0x1BE4550 Offset: 0x1BE4651 VA: 0x1BE4550 Slot: 88
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x1BE4A90 Offset: 0x1BE4B91 VA: 0x1BE4A90
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x1BE4F70 Offset: 0x1BE5071 VA: 0x1BE4F70
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x1BE2E40 Offset: 0x1BE2F41 VA: 0x1BE2E40
	private static void TrackImage(Image g) { }

	// RVA: 0x1BE3100 Offset: 0x1BE3201 VA: 0x1BE3100
	private static void UnTrackImage(Image g) { }

	// RVA: 0x1BE51E0 Offset: 0x1BE52E1 VA: 0x1BE51E0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1BE5220 Offset: 0x1BE5321 VA: 0x1BE5220
	private static void .cctor() { }
}

