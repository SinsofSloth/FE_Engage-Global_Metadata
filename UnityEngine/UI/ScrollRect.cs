// Namespace: UnityEngine.UI
[ExecuteAlways] // RVA: 0x431D0 Offset: 0x432D1 VA: 0x431D0
[AddComponentMenu] // RVA: 0x431D0 Offset: 0x432D1 VA: 0x431D0
[DisallowMultipleComponent] // RVA: 0x431D0 Offset: 0x432D1 VA: 0x431D0
[SelectionBaseAttribute] // RVA: 0x431D0 Offset: 0x432D1 VA: 0x431D0
[RequireComponent] // RVA: 0x431D0 Offset: 0x432D1 VA: 0x431D0
public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 4335
{
	// Fields
	[SerializeField] // RVA: 0x45110 Offset: 0x45211 VA: 0x45110
	private RectTransform m_Content; // 0x18
	[SerializeField] // RVA: 0x45120 Offset: 0x45221 VA: 0x45120
	private bool m_Horizontal; // 0x20
	[SerializeField] // RVA: 0x45130 Offset: 0x45231 VA: 0x45130
	private bool m_Vertical; // 0x21
	[SerializeField] // RVA: 0x45140 Offset: 0x45241 VA: 0x45140
	private ScrollRect.MovementType m_MovementType; // 0x24
	[SerializeField] // RVA: 0x45150 Offset: 0x45251 VA: 0x45150
	private float m_Elasticity; // 0x28
	[SerializeField] // RVA: 0x45160 Offset: 0x45261 VA: 0x45160
	private bool m_Inertia; // 0x2C
	[SerializeField] // RVA: 0x45170 Offset: 0x45271 VA: 0x45170
	private float m_DecelerationRate; // 0x30
	[SerializeField] // RVA: 0x45180 Offset: 0x45281 VA: 0x45180
	private float m_ScrollSensitivity; // 0x34
	[SerializeField] // RVA: 0x45190 Offset: 0x45291 VA: 0x45190
	private RectTransform m_Viewport; // 0x38
	[SerializeField] // RVA: 0x451A0 Offset: 0x452A1 VA: 0x451A0
	private Scrollbar m_HorizontalScrollbar; // 0x40
	[SerializeField] // RVA: 0x451B0 Offset: 0x452B1 VA: 0x451B0
	private Scrollbar m_VerticalScrollbar; // 0x48
	[SerializeField] // RVA: 0x451C0 Offset: 0x452C1 VA: 0x451C0
	private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x50
	[SerializeField] // RVA: 0x451D0 Offset: 0x452D1 VA: 0x451D0
	private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x54
	[SerializeField] // RVA: 0x451E0 Offset: 0x452E1 VA: 0x451E0
	private float m_HorizontalScrollbarSpacing; // 0x58
	[SerializeField] // RVA: 0x451F0 Offset: 0x452F1 VA: 0x451F0
	private float m_VerticalScrollbarSpacing; // 0x5C
	[SerializeField] // RVA: 0x45200 Offset: 0x45301 VA: 0x45200
	private ScrollRect.ScrollRectEvent m_OnValueChanged; // 0x60
	private Vector2 m_PointerStartLocalCursor; // 0x68
	protected Vector2 m_ContentStartPosition; // 0x70
	private RectTransform m_ViewRect; // 0x78
	protected Bounds m_ContentBounds; // 0x80
	private Bounds m_ViewBounds; // 0x98
	private Vector2 m_Velocity; // 0xB0
	private bool m_Dragging; // 0xB8
	private bool m_Scrolling; // 0xB9
	private Vector2 m_PrevPosition; // 0xBC
	private Bounds m_PrevContentBounds; // 0xC4
	private Bounds m_PrevViewBounds; // 0xDC
	private bool m_HasRebuiltLayout; // 0xF4
	private bool m_HSliderExpand; // 0xF5
	private bool m_VSliderExpand; // 0xF6
	private float m_HSliderHeight; // 0xF8
	private float m_VSliderWidth; // 0xFC
	private RectTransform m_Rect; // 0x100
	private RectTransform m_HorizontalScrollbarRect; // 0x108
	private RectTransform m_VerticalScrollbarRect; // 0x110
	private DrivenRectTransformTracker m_Tracker; // 0x118
	private readonly Vector3[] m_Corners; // 0x120

	// Properties
	public RectTransform content { get; set; }
	public bool horizontal { get; set; }
	public bool vertical { get; set; }
	public ScrollRect.MovementType movementType { get; set; }
	public float elasticity { get; set; }
	public bool inertia { get; set; }
	public float decelerationRate { get; set; }
	public float scrollSensitivity { get; set; }
	public RectTransform viewport { get; set; }
	public Scrollbar horizontalScrollbar { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
	public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
	public float horizontalScrollbarSpacing { get; set; }
	public float verticalScrollbarSpacing { get; set; }
	public ScrollRect.ScrollRectEvent onValueChanged { get; set; }
	protected RectTransform viewRect { get; }
	public Vector2 velocity { get; set; }
	private RectTransform rectTransform { get; }
	public Vector2 normalizedPosition { get; set; }
	public float horizontalNormalizedPosition { get; set; }
	public float verticalNormalizedPosition { get; set; }
	private bool hScrollingNeeded { get; }
	private bool vScrollingNeeded { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x1B75450 Offset: 0x1B75551 VA: 0x1B75450
	public RectTransform get_content() { }

	// RVA: 0x1B75460 Offset: 0x1B75561 VA: 0x1B75460
	public void set_content(RectTransform value) { }

	// RVA: 0x1B75470 Offset: 0x1B75571 VA: 0x1B75470
	public bool get_horizontal() { }

	// RVA: 0x1B75480 Offset: 0x1B75581 VA: 0x1B75480
	public void set_horizontal(bool value) { }

	// RVA: 0x1B75490 Offset: 0x1B75591 VA: 0x1B75490
	public bool get_vertical() { }

	// RVA: 0x1B754A0 Offset: 0x1B755A1 VA: 0x1B754A0
	public void set_vertical(bool value) { }

	// RVA: 0x1B754B0 Offset: 0x1B755B1 VA: 0x1B754B0
	public ScrollRect.MovementType get_movementType() { }

	// RVA: 0x1B754C0 Offset: 0x1B755C1 VA: 0x1B754C0
	public void set_movementType(ScrollRect.MovementType value) { }

	// RVA: 0x1B754D0 Offset: 0x1B755D1 VA: 0x1B754D0
	public float get_elasticity() { }

	// RVA: 0x1B754E0 Offset: 0x1B755E1 VA: 0x1B754E0
	public void set_elasticity(float value) { }

	// RVA: 0x1B754F0 Offset: 0x1B755F1 VA: 0x1B754F0
	public bool get_inertia() { }

	// RVA: 0x1B75500 Offset: 0x1B75601 VA: 0x1B75500
	public void set_inertia(bool value) { }

	// RVA: 0x1B75510 Offset: 0x1B75611 VA: 0x1B75510
	public float get_decelerationRate() { }

	// RVA: 0x1B75520 Offset: 0x1B75621 VA: 0x1B75520
	public void set_decelerationRate(float value) { }

	// RVA: 0x1B75530 Offset: 0x1B75631 VA: 0x1B75530
	public float get_scrollSensitivity() { }

	// RVA: 0x1B75540 Offset: 0x1B75641 VA: 0x1B75540
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x1B75550 Offset: 0x1B75651 VA: 0x1B75550
	public RectTransform get_viewport() { }

	// RVA: 0x1B75560 Offset: 0x1B75661 VA: 0x1B75560
	public void set_viewport(RectTransform value) { }

	// RVA: 0x1B75670 Offset: 0x1B75771 VA: 0x1B75670
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x1B75680 Offset: 0x1B75781 VA: 0x1B75680
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x1B75840 Offset: 0x1B75941 VA: 0x1B75840
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x1B75850 Offset: 0x1B75951 VA: 0x1B75850
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x1B75A10 Offset: 0x1B75B11 VA: 0x1B75A10
	public ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x1B75A20 Offset: 0x1B75B21 VA: 0x1B75A20
	public void set_horizontalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x1B75A30 Offset: 0x1B75B31 VA: 0x1B75A30
	public ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x1B75A40 Offset: 0x1B75B41 VA: 0x1B75A40
	public void set_verticalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x1B75A50 Offset: 0x1B75B51 VA: 0x1B75A50
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x1B75A60 Offset: 0x1B75B61 VA: 0x1B75A60
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x1B75B90 Offset: 0x1B75C91 VA: 0x1B75B90
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x1B75BA0 Offset: 0x1B75CA1 VA: 0x1B75BA0
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x1B75C40 Offset: 0x1B75D41 VA: 0x1B75C40
	public ScrollRect.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x1B75C50 Offset: 0x1B75D51 VA: 0x1B75C50
	public void set_onValueChanged(ScrollRect.ScrollRectEvent value) { }

	// RVA: 0x1B75C60 Offset: 0x1B75D61 VA: 0x1B75C60
	protected RectTransform get_viewRect() { }

	// RVA: 0x1B75D80 Offset: 0x1B75E81 VA: 0x1B75D80
	public Vector2 get_velocity() { }

	// RVA: 0x1B75D90 Offset: 0x1B75E91 VA: 0x1B75D90
	public void set_velocity(Vector2 value) { }

	// RVA: 0x1B75DA0 Offset: 0x1B75EA1 VA: 0x1B75DA0
	private RectTransform get_rectTransform() { }

	// RVA: 0x1B75E60 Offset: 0x1B75F61 VA: 0x1B75E60
	protected void .ctor() { }

	// RVA: 0x1B75F60 Offset: 0x1B76061 VA: 0x1B75F60 Slot: 38
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1B76CB0 Offset: 0x1B76DB1 VA: 0x1B76CB0 Slot: 39
	public virtual void LayoutComplete() { }

	// RVA: 0x1B76CC0 Offset: 0x1B76DC1 VA: 0x1B76CC0 Slot: 40
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1B75FC0 Offset: 0x1B760C1 VA: 0x1B75FC0
	private void UpdateCachedData() { }

	// RVA: 0x1B76CD0 Offset: 0x1B76DD1 VA: 0x1B76CD0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1B76F30 Offset: 0x1B77031 VA: 0x1B76F30 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1B77160 Offset: 0x1B77261 VA: 0x1B77160 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x1B771F0 Offset: 0x1B772F1 VA: 0x1B771F0
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x1B77280 Offset: 0x1B77381 VA: 0x1B77280 Slot: 41
	public virtual void StopMovement() { }

	// RVA: 0x1B772B0 Offset: 0x1B773B1 VA: 0x1B772B0 Slot: 42
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x1B774B0 Offset: 0x1B775B1 VA: 0x1B774B0 Slot: 43
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1B774F0 Offset: 0x1B775F1 VA: 0x1B774F0 Slot: 44
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1B77660 Offset: 0x1B77761 VA: 0x1B77660 Slot: 45
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1B77680 Offset: 0x1B77781 VA: 0x1B77680 Slot: 46
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1B77980 Offset: 0x1B77A81 VA: 0x1B77980 Slot: 47
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x1B77A50 Offset: 0x1B77B51 VA: 0x1B77A50 Slot: 48
	protected virtual void LateUpdate() { }

	// RVA: 0x1B76BF0 Offset: 0x1B76CF1 VA: 0x1B76BF0
	protected void UpdatePrevData() { }

	// RVA: 0x1B76910 Offset: 0x1B76A11 VA: 0x1B76910
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x1B78190 Offset: 0x1B78291 VA: 0x1B78190
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x1B78550 Offset: 0x1B78651 VA: 0x1B78550
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x1B78330 Offset: 0x1B78431 VA: 0x1B78330
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x1B785B0 Offset: 0x1B786B1 VA: 0x1B785B0
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x1B78450 Offset: 0x1B78551 VA: 0x1B78450
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x1B785D0 Offset: 0x1B786D1 VA: 0x1B785D0
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x1B785F0 Offset: 0x1B786F1 VA: 0x1B785F0
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x1B78610 Offset: 0x1B78711 VA: 0x1B78610
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x1B78630 Offset: 0x1B78731 VA: 0x1B78630 Slot: 49
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x1B77920 Offset: 0x1B77A21 VA: 0x1B77920
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x1B78830 Offset: 0x1B78931 VA: 0x1B78830 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1B788C0 Offset: 0x1B789C1 VA: 0x1B788C0
	private bool get_hScrollingNeeded() { }

	// RVA: 0x1B78940 Offset: 0x1B78A41 VA: 0x1B78940
	private bool get_vScrollingNeeded() { }

	// RVA: 0x1B789C0 Offset: 0x1B78AC1 VA: 0x1B789C0 Slot: 50
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1B789D0 Offset: 0x1B78AD1 VA: 0x1B789D0 Slot: 51
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1B789E0 Offset: 0x1B78AE1 VA: 0x1B789E0 Slot: 52
	public virtual float get_minWidth() { }

	// RVA: 0x1B789F0 Offset: 0x1B78AF1 VA: 0x1B789F0 Slot: 53
	public virtual float get_preferredWidth() { }

	// RVA: 0x1B78A00 Offset: 0x1B78B01 VA: 0x1B78A00 Slot: 54
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1B78A10 Offset: 0x1B78B11 VA: 0x1B78A10 Slot: 55
	public virtual float get_minHeight() { }

	// RVA: 0x1B78A20 Offset: 0x1B78B21 VA: 0x1B78A20 Slot: 56
	public virtual float get_preferredHeight() { }

	// RVA: 0x1B78A30 Offset: 0x1B78B31 VA: 0x1B78A30 Slot: 57
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1B78A40 Offset: 0x1B78B41 VA: 0x1B78A40 Slot: 58
	public virtual int get_layoutPriority() { }

	// RVA: 0x1B78A50 Offset: 0x1B78B51 VA: 0x1B78A50 Slot: 59
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1B790A0 Offset: 0x1B791A1 VA: 0x1B790A0 Slot: 60
	public virtual void SetLayoutVertical() { }

	// RVA: 0x1B781D0 Offset: 0x1B782D1 VA: 0x1B781D0
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x1B79460 Offset: 0x1B79561 VA: 0x1B79460
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x1B79180 Offset: 0x1B79281 VA: 0x1B79180
	private void UpdateScrollbarLayout() { }

	// RVA: 0x1B763D0 Offset: 0x1B764D1 VA: 0x1B763D0
	protected void UpdateBounds() { }

	// RVA: 0x1B79560 Offset: 0x1B79661 VA: 0x1B79560
	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	// RVA: 0x1B78F90 Offset: 0x1B79091 VA: 0x1B78F90
	private Bounds GetBounds() { }

	// RVA: 0x1B79610 Offset: 0x1B79711 VA: 0x1B79610
	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x1B77470 Offset: 0x1B77571 VA: 0x1B77470
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x1B79960 Offset: 0x1B79A61 VA: 0x1B79960
	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta) { }

	// RVA: 0x1B75B00 Offset: 0x1B75C01 VA: 0x1B75B00
	protected void SetDirty() { }

	// RVA: 0x1B75590 Offset: 0x1B75691 VA: 0x1B75590
	protected void SetDirtyCaching() { }

	// RVA: 0x1B79AE0 Offset: 0x1B79BE1 VA: 0x1B79AE0 Slot: 23
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

