// Namespace: UnityEngine.UI
[AddComponentMenu] // RVA: 0x43120 Offset: 0x43221 VA: 0x43120
[ExecuteAlways] // RVA: 0x43120 Offset: 0x43221 VA: 0x43120
[DisallowMultipleComponent] // RVA: 0x43120 Offset: 0x43221 VA: 0x43120
[RequireComponent] // RVA: 0x43120 Offset: 0x43221 VA: 0x43120
public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 4331
{
	// Fields
	private readonly RectangularVertexClipper m_VertexClipper; // 0x18
	private RectTransform m_RectTransform; // 0x20
	private HashSet<MaskableGraphic> m_MaskableTargets; // 0x28
	private HashSet<IClippable> m_ClipTargets; // 0x30
	private bool m_ShouldRecalculateClipRects; // 0x38
	private List<RectMask2D> m_Clippers; // 0x40
	private Rect m_LastClipRectCanvasSpace; // 0x48
	private bool m_ForceClip; // 0x58
	[SerializeField] // RVA: 0x450F0 Offset: 0x451F1 VA: 0x450F0
	private Vector4 m_Padding; // 0x5C
	[SerializeField] // RVA: 0x45100 Offset: 0x45201 VA: 0x45100
	private Vector2Int m_Softness; // 0x6C
	private Canvas m_Canvas; // 0x78
	private Vector3[] m_Corners; // 0x80

	// Properties
	public Vector4 padding { get; set; }
	public Vector2Int softness { get; set; }
	private Canvas Canvas { get; }
	public Rect canvasRect { get; }
	public RectTransform rectTransform { get; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x1B72FC0 Offset: 0x1B730C1 VA: 0x1B72FC0
	public Vector4 get_padding() { }

	// RVA: 0x1B72FD0 Offset: 0x1B730D1 VA: 0x1B72FD0
	public void set_padding(Vector4 value) { }

	// RVA: 0x1B72FF0 Offset: 0x1B730F1 VA: 0x1B72FF0
	public Vector2Int get_softness() { }

	// RVA: 0x1B73000 Offset: 0x1B73101 VA: 0x1B73000
	public void set_softness(Vector2Int value) { }

	// RVA: 0x1B73050 Offset: 0x1B73151 VA: 0x1B73050
	private Canvas get_Canvas() { }

	// RVA: 0x1B731F0 Offset: 0x1B732F1 VA: 0x1B731F0
	public Rect get_canvasRect() { }

	// RVA: 0x1B73280 Offset: 0x1B73381 VA: 0x1B73280
	public RectTransform get_rectTransform() { }

	// RVA: 0x1B73500 Offset: 0x1B73601 VA: 0x1B73500
	protected void .ctor() { }

	// RVA: 0x1B73790 Offset: 0x1B73891 VA: 0x1B73790 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1B737D0 Offset: 0x1B738D1 VA: 0x1B737D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1B73890 Offset: 0x1B73991 VA: 0x1B73890 Slot: 19
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1B739D0 Offset: 0x1B73AD1 VA: 0x1B739D0
	private Rect get_rootCanvasRect() { }

	// RVA: 0x1B73BE0 Offset: 0x1B73CE1 VA: 0x1B73BE0 Slot: 20
	public virtual void PerformClipping() { }

	// RVA: 0x1B74390 Offset: 0x1B74491 VA: 0x1B74390 Slot: 21
	public virtual void UpdateClipSoftness() { }

	// RVA: 0x1B6D7D0 Offset: 0x1B6D8D1 VA: 0x1B6D7D0
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x1B6D620 Offset: 0x1B6D721 VA: 0x1B6D620
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x1B74690 Offset: 0x1B74791 VA: 0x1B74690 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1B746C0 Offset: 0x1B747C1 VA: 0x1B746C0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }
}

