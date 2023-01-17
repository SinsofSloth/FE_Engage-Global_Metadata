// Namespace: UnityEngine.UI
[AddComponentMenu] // RVA: 0x42970 Offset: 0x42A71 VA: 0x42970
[RequireComponent] // RVA: 0x42970 Offset: 0x42A71 VA: 0x42970
public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 4270
{
	// Fields
	protected const int kNoEventMaskSet = -1;
	[FormerlySerializedAsAttribute] // RVA: 0x44310 Offset: 0x44411 VA: 0x44310
	[SerializeField] // RVA: 0x44310 Offset: 0x44411 VA: 0x44310
	private bool m_IgnoreReversedGraphics; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0x44360 Offset: 0x44461 VA: 0x44360
	[SerializeField] // RVA: 0x44360 Offset: 0x44461 VA: 0x44360
	private GraphicRaycaster.BlockingObjects m_BlockingObjects; // 0x24
	[SerializeField] // RVA: 0x443B0 Offset: 0x444B1 VA: 0x443B0
	protected LayerMask m_BlockingMask; // 0x28
	private Canvas m_Canvas; // 0x30
	private List<Graphic> m_RaycastResults; // 0x38
	private static readonly List<Graphic> s_SortedGraphics; // 0x0

	// Properties
	public override int sortOrderPriority { get; }
	public override int renderOrderPriority { get; }
	public bool ignoreReversedGraphics { get; set; }
	public GraphicRaycaster.BlockingObjects blockingObjects { get; set; }
	public LayerMask blockingMask { get; set; }
	private Canvas canvas { get; }
	public override Camera eventCamera { get; }

	// Methods

	// RVA: 0x1A54110 Offset: 0x1A54211 VA: 0x1A54110 Slot: 20
	public override int get_sortOrderPriority() { }

	// RVA: 0x1A54220 Offset: 0x1A54321 VA: 0x1A54220 Slot: 21
	public override int get_renderOrderPriority() { }

	// RVA: 0x1A54270 Offset: 0x1A54371 VA: 0x1A54270
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x1A54280 Offset: 0x1A54381 VA: 0x1A54280
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x1A54290 Offset: 0x1A54391 VA: 0x1A54290
	public GraphicRaycaster.BlockingObjects get_blockingObjects() { }

	// RVA: 0x1A542A0 Offset: 0x1A543A1 VA: 0x1A542A0
	public void set_blockingObjects(GraphicRaycaster.BlockingObjects value) { }

	// RVA: 0x1A542B0 Offset: 0x1A543B1 VA: 0x1A542B0
	public LayerMask get_blockingMask() { }

	// RVA: 0x1A542C0 Offset: 0x1A543C1 VA: 0x1A542C0
	public void set_blockingMask(LayerMask value) { }

	// RVA: 0x1A542D0 Offset: 0x1A543D1 VA: 0x1A542D0
	protected void .ctor() { }

	// RVA: 0x1A54160 Offset: 0x1A54261 VA: 0x1A54160
	private Canvas get_canvas() { }

	// RVA: 0x1A54380 Offset: 0x1A54481 VA: 0x1A54380 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x1A55610 Offset: 0x1A55711 VA: 0x1A55610 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x1A55040 Offset: 0x1A55141 VA: 0x1A55040
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	// RVA: 0x1A556F0 Offset: 0x1A557F1 VA: 0x1A556F0
	private static void .cctor() { }
}

