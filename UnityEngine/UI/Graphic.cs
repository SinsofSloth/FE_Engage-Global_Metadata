// Namespace: UnityEngine.UI
[RequireComponent] // RVA: 0x428E0 Offset: 0x429E1 VA: 0x428E0
[ExecuteAlways] // RVA: 0x428E0 Offset: 0x429E1 VA: 0x428E0
[DisallowMultipleComponent] // RVA: 0x428E0 Offset: 0x429E1 VA: 0x428E0
public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 4267
{
	// Fields
	protected static Material s_DefaultUI; // 0x0
	protected static Texture2D s_WhiteTexture; // 0x8
	[FormerlySerializedAsAttribute] // RVA: 0x44280 Offset: 0x44381 VA: 0x44280
	[SerializeField] // RVA: 0x44280 Offset: 0x44381 VA: 0x44280
	protected Material m_Material; // 0x18
	[SerializeField] // RVA: 0x442D0 Offset: 0x443D1 VA: 0x442D0
	private Color m_Color; // 0x20
	protected bool m_SkipLayoutUpdate; // 0x30
	protected bool m_SkipMaterialUpdate; // 0x31
	[SerializeField] // RVA: 0x442E0 Offset: 0x443E1 VA: 0x442E0
	private bool m_RaycastTarget; // 0x32
	[SerializeField] // RVA: 0x442F0 Offset: 0x443F1 VA: 0x442F0
	private Vector4 m_RaycastPadding; // 0x34
	private RectTransform m_RectTransform; // 0x48
	private CanvasRenderer m_CanvasRenderer; // 0x50
	private Canvas m_Canvas; // 0x58
	private bool m_VertsDirty; // 0x60
	private bool m_MaterialDirty; // 0x61
	protected UnityAction m_OnDirtyLayoutCallback; // 0x68
	protected UnityAction m_OnDirtyVertsCallback; // 0x70
	protected UnityAction m_OnDirtyMaterialCallback; // 0x78
	protected static Mesh s_Mesh; // 0x10
	private static readonly VertexHelper s_VertexHelper; // 0x18
	protected Mesh m_CachedMesh; // 0x80
	protected Vector2[] m_CachedUvs; // 0x88
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x44300 Offset: 0x44401 VA: 0x44300
	private bool <useLegacyMeshGeneration>k__BackingField; // 0x98

	// Properties
	public static Material defaultGraphicMaterial { get; }
	public virtual Color color { get; set; }
	public virtual bool raycastTarget { get; set; }
	public Vector4 raycastPadding { get; set; }
	protected bool useLegacyMeshGeneration { get; set; }
	public int depth { get; }
	public RectTransform rectTransform { get; }
	public Canvas canvas { get; }
	public CanvasRenderer canvasRenderer { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Material material { get; set; }
	public virtual Material materialForRendering { get; }
	public virtual Texture mainTexture { get; }
	protected static Mesh workerMesh { get; }

	// Methods

	// RVA: 0x1A4FB70 Offset: 0x1A4FC71 VA: 0x1A4FB70
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0x1A4FC80 Offset: 0x1A4FD81 VA: 0x1A4FC80 Slot: 22
	public virtual Color get_color() { }

	// RVA: 0x1A4FC90 Offset: 0x1A4FD91 VA: 0x1A4FC90 Slot: 23
	public virtual void set_color(Color value) { }

	// RVA: 0x1A4FCE0 Offset: 0x1A4FDE1 VA: 0x1A4FCE0 Slot: 24
	public virtual bool get_raycastTarget() { }

	// RVA: 0x1A4FCF0 Offset: 0x1A4FDF1 VA: 0x1A4FCF0 Slot: 25
	public virtual void set_raycastTarget(bool value) { }

	// RVA: 0x1A502C0 Offset: 0x1A503C1 VA: 0x1A502C0
	public Vector4 get_raycastPadding() { }

	// RVA: 0x1A502D0 Offset: 0x1A503D1 VA: 0x1A502D0
	public void set_raycastPadding(Vector4 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x45CD0 Offset: 0x45DD1 VA: 0x45CD0
	// RVA: 0x1A502F0 Offset: 0x1A503F1 VA: 0x1A502F0
	protected bool get_useLegacyMeshGeneration() { }

	[CompilerGeneratedAttribute] // RVA: 0x45CE0 Offset: 0x45DE1 VA: 0x45CE0
	// RVA: 0x1A50300 Offset: 0x1A50401 VA: 0x1A50300
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x1A50310 Offset: 0x1A50411 VA: 0x1A50310
	protected void .ctor() { }

	// RVA: 0x1A503F0 Offset: 0x1A504F1 VA: 0x1A503F0 Slot: 26
	public virtual void SetAllDirty() { }

	// RVA: 0x1A50470 Offset: 0x1A50571 VA: 0x1A50470 Slot: 27
	public virtual void SetLayoutDirty() { }

	// RVA: 0x1A50600 Offset: 0x1A50701 VA: 0x1A50600 Slot: 28
	public virtual void SetVerticesDirty() { }

	// RVA: 0x1A506F0 Offset: 0x1A507F1 VA: 0x1A506F0 Slot: 29
	public virtual void SetMaterialDirty() { }

	// RVA: 0x1A507E0 Offset: 0x1A508E1 VA: 0x1A507E0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1A508F0 Offset: 0x1A509F1 VA: 0x1A508F0 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x1A50BF0 Offset: 0x1A50CF1 VA: 0x1A50BF0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1A510F0 Offset: 0x1A511F1 VA: 0x1A510F0
	public int get_depth() { }

	// RVA: 0x1A50570 Offset: 0x1A50671 VA: 0x1A50570 Slot: 30
	public RectTransform get_rectTransform() { }

	// RVA: 0x1A4FEA0 Offset: 0x1A4FFA1 VA: 0x1A4FEA0
	public Canvas get_canvas() { }

	// RVA: 0x1A50D20 Offset: 0x1A50E21 VA: 0x1A50D20
	private void CacheCanvas() { }

	// RVA: 0x1A51110 Offset: 0x1A51211 VA: 0x1A51110
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x1A511D0 Offset: 0x1A512D1 VA: 0x1A511D0 Slot: 31
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x1A51240 Offset: 0x1A51341 VA: 0x1A51240 Slot: 32
	public virtual Material get_material() { }

	// RVA: 0x1A512E0 Offset: 0x1A513E1 VA: 0x1A512E0 Slot: 33
	public virtual void set_material(Material value) { }

	// RVA: 0x1A513A0 Offset: 0x1A514A1 VA: 0x1A513A0 Slot: 34
	public virtual Material get_materialForRendering() { }

	// RVA: 0x1A515D0 Offset: 0x1A516D1 VA: 0x1A515D0 Slot: 35
	public virtual Texture get_mainTexture() { }

	// RVA: 0x1A51640 Offset: 0x1A51741 VA: 0x1A51640 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A517F0 Offset: 0x1A518F1 VA: 0x1A517F0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1A51A50 Offset: 0x1A51B51 VA: 0x1A51A50 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1A51B20 Offset: 0x1A51C21 VA: 0x1A51B20 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1A51CC0 Offset: 0x1A51DC1 VA: 0x1A51CC0 Slot: 36
	public virtual void OnCullingChanged() { }

	// RVA: 0x1A51DB0 Offset: 0x1A51EB1 VA: 0x1A51DB0 Slot: 37
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1A51EA0 Offset: 0x1A51FA1 VA: 0x1A51EA0 Slot: 38
	public virtual void LayoutComplete() { }

	// RVA: 0x1A51EB0 Offset: 0x1A51FB1 VA: 0x1A51EB0 Slot: 39
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1A51EC0 Offset: 0x1A51FC1 VA: 0x1A51EC0 Slot: 40
	protected virtual void UpdateMaterial() { }

	// RVA: 0x1A51F70 Offset: 0x1A52071 VA: 0x1A51F70 Slot: 41
	protected virtual void UpdateGeometry() { }

	// RVA: 0x1A52430 Offset: 0x1A52531 VA: 0x1A52430
	private void DoMeshGeneration() { }

	// RVA: 0x1A51F80 Offset: 0x1A52081 VA: 0x1A51F80
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x1A52910 Offset: 0x1A52A11 VA: 0x1A52910
	protected static Mesh get_workerMesh() { }

	[EditorBrowsableAttribute] // RVA: 0x45CF0 Offset: 0x45DF1 VA: 0x45CF0
	[ObsoleteAttribute] // RVA: 0x45CF0 Offset: 0x45DF1 VA: 0x45CF0
	// RVA: 0x1A52A80 Offset: 0x1A52B81 VA: 0x1A52A80 Slot: 42
	protected virtual void OnFillVBO(List<UIVertex> vbo) { }

	[ObsoleteAttribute] // RVA: 0x45D50 Offset: 0x45E51 VA: 0x45D50
	// RVA: 0x1A52A90 Offset: 0x1A52B91 VA: 0x1A52A90 Slot: 43
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x1A52B30 Offset: 0x1A52C31 VA: 0x1A52B30 Slot: 44
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1A53150 Offset: 0x1A53251 VA: 0x1A53150 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1A53160 Offset: 0x1A53261 VA: 0x1A53160 Slot: 45
	public virtual void SetNativeSize() { }

	// RVA: 0x1A53170 Offset: 0x1A53271 VA: 0x1A53170 Slot: 46
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1A53640 Offset: 0x1A53741 VA: 0x1A53640
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x1A52DB0 Offset: 0x1A52EB1 VA: 0x1A52DB0
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x1A53930 Offset: 0x1A53A31 VA: 0x1A53930 Slot: 47
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x1A53950 Offset: 0x1A53A51 VA: 0x1A53950 Slot: 48
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x1A53C10 Offset: 0x1A53D11 VA: 0x1A53C10
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x1A53C40 Offset: 0x1A53D41 VA: 0x1A53C40 Slot: 49
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x1A53CF0 Offset: 0x1A53DF1 VA: 0x1A53CF0
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x1A53D80 Offset: 0x1A53E81 VA: 0x1A53D80
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x1A53E10 Offset: 0x1A53F11 VA: 0x1A53E10
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x1A53EA0 Offset: 0x1A53FA1 VA: 0x1A53EA0
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x1A53F30 Offset: 0x1A54031 VA: 0x1A53F30
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x1A53FC0 Offset: 0x1A540C1 VA: 0x1A53FC0
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x1A54050 Offset: 0x1A54151 VA: 0x1A54050
	private static void .cctor() { }

	// RVA: 0x1A54100 Offset: 0x1A54201 VA: 0x1A54100 Slot: 18
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

