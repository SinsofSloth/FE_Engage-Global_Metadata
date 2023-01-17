// Namespace: UnityEngine
internal struct SliderHandler // TypeDefIndex: 4178
{
	// Fields
	private readonly Rect position; // 0x0
	private readonly float currentValue; // 0x10
	private readonly float size; // 0x14
	private readonly float start; // 0x18
	private readonly float end; // 0x1C
	private readonly GUIStyle slider; // 0x20
	private readonly GUIStyle thumb; // 0x28
	private readonly GUIStyle thumbExtent; // 0x30
	private readonly bool horiz; // 0x38
	private readonly int id; // 0x3C

	// Methods

	// RVA: 0x3C741C0 Offset: 0x3C742C1 VA: 0x3C741C0
	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x3C74250 Offset: 0x3C74351 VA: 0x3C74250
	public float Handle() { }

	// RVA: 0x3C88050 Offset: 0x3C88151 VA: 0x3C88050
	private float OnMouseDown() { }

	// RVA: 0x3C886B0 Offset: 0x3C887B1 VA: 0x3C886B0
	private float OnMouseDrag() { }

	// RVA: 0x3C88870 Offset: 0x3C88971 VA: 0x3C88870
	private float OnMouseUp() { }

	// RVA: 0x3C88940 Offset: 0x3C88A41 VA: 0x3C88940
	private float OnRepaint() { }

	// RVA: 0x3C87FC0 Offset: 0x3C880C1 VA: 0x3C87FC0
	private EventType CurrentEventType() { }

	// RVA: 0x3C89350 Offset: 0x3C89451 VA: 0x3C89350
	private int CurrentScrollTroughSide() { }

	// RVA: 0x3C890A0 Offset: 0x3C891A1 VA: 0x3C890A0
	private bool IsEmptySlider() { }

	// RVA: 0x3C89160 Offset: 0x3C89261 VA: 0x3C89160
	private bool SupportsPageMovements() { }

	// RVA: 0x3C89480 Offset: 0x3C89581 VA: 0x3C89480
	private float PageMovementValue() { }

	// RVA: 0x3C89A60 Offset: 0x3C89B61 VA: 0x3C89A60
	private float PageUpMovementBound() { }

	// RVA: 0x3C89050 Offset: 0x3C89151 VA: 0x3C89050
	private Event CurrentEvent() { }

	// RVA: 0x3C89540 Offset: 0x3C89641 VA: 0x3C89540
	private float ValueForCurrentMousePosition() { }

	// RVA: 0x3C895F0 Offset: 0x3C896F1 VA: 0x3C895F0
	private float Clamp(float value) { }

	// RVA: 0x3C89040 Offset: 0x3C89141 VA: 0x3C89040
	private Rect ThumbSelectionRect() { }

	// RVA: 0x3C89110 Offset: 0x3C89211 VA: 0x3C89110
	private void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x3C89210 Offset: 0x3C89311 VA: 0x3C89210
	private SliderState SliderState() { }

	// RVA: 0x3C89950 Offset: 0x3C89A51 VA: 0x3C89950
	private Rect ThumbExtRect() { }

	// RVA: 0x3C89A50 Offset: 0x3C89B51 VA: 0x3C89A50
	private Rect ThumbRect() { }

	// RVA: 0x3C89B50 Offset: 0x3C89C51 VA: 0x3C89B50
	private Rect VerticalThumbRect() { }

	// RVA: 0x3C89E90 Offset: 0x3C89F91 VA: 0x3C89E90
	private Rect HorizontalThumbRect() { }

	// RVA: 0x3C890B0 Offset: 0x3C891B1 VA: 0x3C890B0
	private float ClampedCurrentValue() { }

	// RVA: 0x3C89650 Offset: 0x3C89751 VA: 0x3C89650
	private float MousePosition() { }

	// RVA: 0x3C89770 Offset: 0x3C89871 VA: 0x3C89770
	private float ValuesPerPixel() { }

	// RVA: 0x3C8A1F0 Offset: 0x3C8A2F1 VA: 0x3C8A1F0
	private float ThumbSize() { }

	// RVA: 0x3C89B20 Offset: 0x3C89C21 VA: 0x3C89B20
	private float MaxValue() { }

	// RVA: 0x3C89B10 Offset: 0x3C89C11 VA: 0x3C89B10
	private float MinValue() { }
}

