// Namespace: UnityEngine.UI
[ExecuteAlways] // RVA: 0x43290 Offset: 0x43391 VA: 0x43290
[RequireComponent] // RVA: 0x43290 Offset: 0x43391 VA: 0x43290
[AddComponentMenu] // RVA: 0x43290 Offset: 0x43391 VA: 0x43290
public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 4340
{
	// Fields
	[SerializeField] // RVA: 0x45210 Offset: 0x45311 VA: 0x45210
	private RectTransform m_HandleRect; // 0xF8
	[SerializeField] // RVA: 0x45220 Offset: 0x45321 VA: 0x45220
	private Scrollbar.Direction m_Direction; // 0x100
	[SerializeField] // RVA: 0x45230 Offset: 0x45331 VA: 0x45230
	[RangeAttribute] // RVA: 0x45230 Offset: 0x45331 VA: 0x45230
	private float m_Value; // 0x104
	[SerializeField] // RVA: 0x45270 Offset: 0x45371 VA: 0x45270
	[RangeAttribute] // RVA: 0x45270 Offset: 0x45371 VA: 0x45270
	private float m_Size; // 0x108
	[SerializeField] // RVA: 0x452B0 Offset: 0x453B1 VA: 0x452B0
	[RangeAttribute] // RVA: 0x452B0 Offset: 0x453B1 VA: 0x452B0
	private int m_NumberOfSteps; // 0x10C
	[SpaceAttribute] // RVA: 0x452F0 Offset: 0x453F1 VA: 0x452F0
	[SerializeField] // RVA: 0x452F0 Offset: 0x453F1 VA: 0x452F0
	private Scrollbar.ScrollEvent m_OnValueChanged; // 0x110
	private RectTransform m_ContainerRect; // 0x118
	private Vector2 m_Offset; // 0x120
	private DrivenRectTransformTracker m_Tracker; // 0x128
	private Coroutine m_PointerDownRepeat; // 0x130
	private bool isPointerDownAndNotDragging; // 0x138
	private bool m_DelayedUpdateVisuals; // 0x139

	// Properties
	public RectTransform handleRect { get; set; }
	public Scrollbar.Direction direction { get; set; }
	public float value { get; set; }
	public float size { get; set; }
	public int numberOfSteps { get; set; }
	public Scrollbar.ScrollEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Scrollbar.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x1B79AF0 Offset: 0x1B79BF1 VA: 0x1B79AF0
	public RectTransform get_handleRect() { }

	// RVA: 0x1B79B00 Offset: 0x1B79C01 VA: 0x1B79B00
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x1B79ED0 Offset: 0x1B79FD1 VA: 0x1B79ED0
	public Scrollbar.Direction get_direction() { }

	// RVA: 0x1B79EE0 Offset: 0x1B79FE1 VA: 0x1B79EE0
	public void set_direction(Scrollbar.Direction value) { }

	// RVA: 0x1B79F60 Offset: 0x1B7A061 VA: 0x1B79F60
	protected void .ctor() { }

	// RVA: 0x1B7A170 Offset: 0x1B7A271 VA: 0x1B7A170
	public float get_value() { }

	// RVA: 0x1B78440 Offset: 0x1B78541 VA: 0x1B78440
	public void set_value(float value) { }

	// RVA: 0x1B7A440 Offset: 0x1B7A541 VA: 0x1B7A440 Slot: 47
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x1B7A450 Offset: 0x1B7A551 VA: 0x1B7A450
	public float get_size() { }

	// RVA: 0x1B782A0 Offset: 0x1B783A1 VA: 0x1B782A0
	public void set_size(float value) { }

	// RVA: 0x1B7A460 Offset: 0x1B7A561 VA: 0x1B7A460
	public int get_numberOfSteps() { }

	// RVA: 0x1B7A470 Offset: 0x1B7A571 VA: 0x1B7A470
	public void set_numberOfSteps(int value) { }

	// RVA: 0x1B7A500 Offset: 0x1B7A601 VA: 0x1B7A500
	public Scrollbar.ScrollEvent get_onValueChanged() { }

	// RVA: 0x1B7A510 Offset: 0x1B7A611 VA: 0x1B7A510
	public void set_onValueChanged(Scrollbar.ScrollEvent value) { }

	// RVA: 0x1B7A520 Offset: 0x1B7A621 VA: 0x1B7A520
	private float get_stepSize() { }

	// RVA: 0x1B7A550 Offset: 0x1B7A651 VA: 0x1B7A550 Slot: 48
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1B7A560 Offset: 0x1B7A661 VA: 0x1B7A560 Slot: 49
	public virtual void LayoutComplete() { }

	// RVA: 0x1B7A570 Offset: 0x1B7A671 VA: 0x1B7A570 Slot: 50
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1B7A580 Offset: 0x1B7A681 VA: 0x1B7A580 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1B7A8B0 Offset: 0x1B7A9B1 VA: 0x1B7A8B0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1B7AA50 Offset: 0x1B7AB51 VA: 0x1B7AA50 Slot: 51
	protected virtual void Update() { }

	// RVA: 0x1B79B80 Offset: 0x1B79C81 VA: 0x1B79B80
	private void UpdateCachedReferences() { }

	// RVA: 0x1B7A240 Offset: 0x1B7A341 VA: 0x1B7A240
	private void Set(float input, bool sendCallback = True) { }

	// RVA: 0x1B7AA70 Offset: 0x1B7AB71 VA: 0x1B7AA70 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1B7AAC0 Offset: 0x1B7ABC1 VA: 0x1B7AAC0
	private Scrollbar.Axis get_axis() { }

	// RVA: 0x1B7AAD0 Offset: 0x1B7ABD1 VA: 0x1B7AAD0
	private bool get_reverseValue() { }

	// RVA: 0x1B79CA0 Offset: 0x1B79DA1 VA: 0x1B79CA0
	private void UpdateVisuals() { }

	// RVA: 0x1B7AAF0 Offset: 0x1B7ABF1 VA: 0x1B7AAF0
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x1B7AE30 Offset: 0x1B7AF31 VA: 0x1B7AE30
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x1B7AEB0 Offset: 0x1B7AFB1 VA: 0x1B7AEB0
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1B7AF20 Offset: 0x1B7B021 VA: 0x1B7AF20 Slot: 52
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1B7B1B0 Offset: 0x1B7B2B1 VA: 0x1B7B1B0 Slot: 53
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1B7B280 Offset: 0x1B7B381 VA: 0x1B7B280 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1B7B680 Offset: 0x1B7B781 VA: 0x1B7B680
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x460B0 Offset: 0x461B1 VA: 0x460B0
	// RVA: 0x1B7B5D0 Offset: 0x1B7B6D1 VA: 0x1B7B5D0
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	// RVA: 0x1B7B790 Offset: 0x1B7B891 VA: 0x1B7B790 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1B7B920 Offset: 0x1B7BA21 VA: 0x1B7B920 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x1B7BE10 Offset: 0x1B7BF11 VA: 0x1B7BE10 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x1B7BEF0 Offset: 0x1B7BFF1 VA: 0x1B7BEF0 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x1B7BFD0 Offset: 0x1B7C0D1 VA: 0x1B7BFD0 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x1B7C0B0 Offset: 0x1B7C1B1 VA: 0x1B7C0B0 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x1B7C190 Offset: 0x1B7C291 VA: 0x1B7C190 Slot: 54
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1B7C1A0 Offset: 0x1B7C2A1 VA: 0x1B7C1A0
	public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts) { }

	// RVA: 0x1B7C390 Offset: 0x1B7C491 VA: 0x1B7C390 Slot: 43
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

