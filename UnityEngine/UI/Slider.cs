// Namespace: UnityEngine.UI
[RequireComponent] // RVA: 0x433B0 Offset: 0x434B1 VA: 0x433B0
[ExecuteAlways] // RVA: 0x433B0 Offset: 0x434B1 VA: 0x433B0
[AddComponentMenu] // RVA: 0x433B0 Offset: 0x434B1 VA: 0x433B0
public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 4348
{
	// Fields
	[SerializeField] // RVA: 0x455B0 Offset: 0x456B1 VA: 0x455B0
	private RectTransform m_FillRect; // 0xF8
	[SerializeField] // RVA: 0x455C0 Offset: 0x456C1 VA: 0x455C0
	private RectTransform m_HandleRect; // 0x100
	[SerializeField] // RVA: 0x455D0 Offset: 0x456D1 VA: 0x455D0
	[SpaceAttribute] // RVA: 0x455D0 Offset: 0x456D1 VA: 0x455D0
	private Slider.Direction m_Direction; // 0x108
	[SerializeField] // RVA: 0x45610 Offset: 0x45711 VA: 0x45610
	private float m_MinValue; // 0x10C
	[SerializeField] // RVA: 0x45620 Offset: 0x45721 VA: 0x45620
	private float m_MaxValue; // 0x110
	[SerializeField] // RVA: 0x45630 Offset: 0x45731 VA: 0x45630
	private bool m_WholeNumbers; // 0x114
	[SerializeField] // RVA: 0x45640 Offset: 0x45741 VA: 0x45640
	protected float m_Value; // 0x118
	[SpaceAttribute] // RVA: 0x45650 Offset: 0x45751 VA: 0x45650
	[SerializeField] // RVA: 0x45650 Offset: 0x45751 VA: 0x45650
	private Slider.SliderEvent m_OnValueChanged; // 0x120
	private Image m_FillImage; // 0x128
	private Transform m_FillTransform; // 0x130
	private RectTransform m_FillContainerRect; // 0x138
	private Transform m_HandleTransform; // 0x140
	private RectTransform m_HandleContainerRect; // 0x148
	private Vector2 m_Offset; // 0x150
	private DrivenRectTransformTracker m_Tracker; // 0x158
	private bool m_DelayedUpdateVisuals; // 0x159

	// Properties
	public RectTransform fillRect { get; set; }
	public RectTransform handleRect { get; set; }
	public Slider.Direction direction { get; set; }
	public float minValue { get; set; }
	public float maxValue { get; set; }
	public bool wholeNumbers { get; set; }
	public virtual float value { get; set; }
	public float normalizedValue { get; set; }
	public Slider.SliderEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Slider.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x1B7EE70 Offset: 0x1B7EF71 VA: 0x1B7EE70
	public RectTransform get_fillRect() { }

	// RVA: 0x1B7EE80 Offset: 0x1B7EF81 VA: 0x1B7EE80
	public void set_fillRect(RectTransform value) { }

	// RVA: 0x1B7F580 Offset: 0x1B7F681 VA: 0x1B7F580
	public RectTransform get_handleRect() { }

	// RVA: 0x1B7F590 Offset: 0x1B7F691 VA: 0x1B7F590
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x1B7F610 Offset: 0x1B7F711 VA: 0x1B7F610
	public Slider.Direction get_direction() { }

	// RVA: 0x1B7F620 Offset: 0x1B7F721 VA: 0x1B7F620
	public void set_direction(Slider.Direction value) { }

	// RVA: 0x1B7F6A0 Offset: 0x1B7F7A1 VA: 0x1B7F6A0
	public float get_minValue() { }

	// RVA: 0x1B7F6B0 Offset: 0x1B7F7B1 VA: 0x1B7F6B0
	public void set_minValue(float value) { }

	// RVA: 0x1B7F750 Offset: 0x1B7F851 VA: 0x1B7F750
	public float get_maxValue() { }

	// RVA: 0x1B7F760 Offset: 0x1B7F861 VA: 0x1B7F760
	public void set_maxValue(float value) { }

	// RVA: 0x1B7F800 Offset: 0x1B7F901 VA: 0x1B7F800
	public bool get_wholeNumbers() { }

	// RVA: 0x1B7F810 Offset: 0x1B7F911 VA: 0x1B7F810
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x1B7F8B0 Offset: 0x1B7F9B1 VA: 0x1B7F8B0 Slot: 46
	public virtual float get_value() { }

	// RVA: 0x1B7F970 Offset: 0x1B7FA71 VA: 0x1B7F970 Slot: 47
	public virtual void set_value(float value) { }

	// RVA: 0x1B7F990 Offset: 0x1B7FA91 VA: 0x1B7F990 Slot: 48
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x1B7F9B0 Offset: 0x1B7FAB1 VA: 0x1B7F9B0
	public float get_normalizedValue() { }

	// RVA: 0x1B7FA30 Offset: 0x1B7FB31 VA: 0x1B7FA30
	public void set_normalizedValue(float value) { }

	// RVA: 0x1B7FA70 Offset: 0x1B7FB71 VA: 0x1B7FA70
	public Slider.SliderEvent get_onValueChanged() { }

	// RVA: 0x1B7FA80 Offset: 0x1B7FB81 VA: 0x1B7FA80
	public void set_onValueChanged(Slider.SliderEvent value) { }

	// RVA: 0x1B7FA90 Offset: 0x1B7FB91 VA: 0x1B7FA90
	private float get_stepSize() { }

	// RVA: 0x1B7FAC0 Offset: 0x1B7FBC1 VA: 0x1B7FAC0
	protected void .ctor() { }

	// RVA: 0x1B7FB80 Offset: 0x1B7FC81 VA: 0x1B7FB80 Slot: 49
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1B7FB90 Offset: 0x1B7FC91 VA: 0x1B7FB90 Slot: 50
	public virtual void LayoutComplete() { }

	// RVA: 0x1B7FBA0 Offset: 0x1B7FCA1 VA: 0x1B7FBA0 Slot: 51
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1B7FBB0 Offset: 0x1B7FCB1 VA: 0x1B7FBB0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1B7FC00 Offset: 0x1B7FD01 VA: 0x1B7FC00 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1B7FC30 Offset: 0x1B7FD31 VA: 0x1B7FC30 Slot: 52
	protected virtual void Update() { }

	// RVA: 0x1B7FC80 Offset: 0x1B7FD81 VA: 0x1B7FC80 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1B7EF00 Offset: 0x1B7F001 VA: 0x1B7EF00
	private void UpdateCachedReferences() { }

	// RVA: 0x1B7FFF0 Offset: 0x1B800F1 VA: 0x1B7FFF0
	private float ClampValue(float input) { }

	// RVA: 0x1B800E0 Offset: 0x1B801E1 VA: 0x1B800E0 Slot: 53
	protected virtual void Set(float input, bool sendCallback = True) { }

	// RVA: 0x1B80250 Offset: 0x1B80351 VA: 0x1B80250 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1B800D0 Offset: 0x1B801D1 VA: 0x1B800D0
	private Slider.Axis get_axis() { }

	// RVA: 0x1B800B0 Offset: 0x1B801B1 VA: 0x1B800B0
	private bool get_reverseValue() { }

	// RVA: 0x1B7F240 Offset: 0x1B7F341 VA: 0x1B7F240
	private void UpdateVisuals() { }

	// RVA: 0x1B802A0 Offset: 0x1B803A1 VA: 0x1B802A0
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x1B80570 Offset: 0x1B80671 VA: 0x1B80570
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1B805E0 Offset: 0x1B806E1 VA: 0x1B805E0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1B808C0 Offset: 0x1B809C1 VA: 0x1B808C0 Slot: 54
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1B809B0 Offset: 0x1B80AB1 VA: 0x1B809B0 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x1B80C30 Offset: 0x1B80D31 VA: 0x1B80C30 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x1B80C60 Offset: 0x1B80D61 VA: 0x1B80C60 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x1B80C90 Offset: 0x1B80D91 VA: 0x1B80C90 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x1B80CC0 Offset: 0x1B80DC1 VA: 0x1B80CC0 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x1B80CF0 Offset: 0x1B80DF1 VA: 0x1B80CF0 Slot: 55
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1B80D00 Offset: 0x1B80E01 VA: 0x1B80D00
	public void SetDirection(Slider.Direction direction, bool includeRectLayouts) { }

	// RVA: 0x1B80EF0 Offset: 0x1B80FF1 VA: 0x1B80EF0 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

