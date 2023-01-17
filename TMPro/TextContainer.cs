// Namespace: TMPro
[RequireComponent] // RVA: 0x4D2D0 Offset: 0x4D3D1 VA: 0x4D2D0
public class TextContainer : UIBehaviour // TypeDefIndex: 7489
{
	// Fields
	private bool m_hasChanged; // 0x18
	[SerializeField] // RVA: 0x4E540 Offset: 0x4E641 VA: 0x4E540
	private Vector2 m_pivot; // 0x1C
	[SerializeField] // RVA: 0x4E550 Offset: 0x4E651 VA: 0x4E550
	private TextContainerAnchors m_anchorPosition; // 0x24
	[SerializeField] // RVA: 0x4E560 Offset: 0x4E661 VA: 0x4E560
	private Rect m_rect; // 0x28
	private bool m_isDefaultWidth; // 0x38
	private bool m_isDefaultHeight; // 0x39
	private bool m_isAutoFitting; // 0x3A
	private Vector3[] m_corners; // 0x40
	private Vector3[] m_worldCorners; // 0x48
	[SerializeField] // RVA: 0x4E570 Offset: 0x4E671 VA: 0x4E570
	private Vector4 m_margins; // 0x50
	private RectTransform m_rectTransform; // 0x60
	private static Vector2 k_defaultSize; // 0x0
	private TextMeshPro m_textMeshPro; // 0x68

	// Properties
	public bool hasChanged { get; set; }
	public Vector2 pivot { get; set; }
	public TextContainerAnchors anchorPosition { get; set; }
	public Rect rect { get; set; }
	public Vector2 size { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public bool isDefaultWidth { get; }
	public bool isDefaultHeight { get; }
	public bool isAutoFitting { get; set; }
	public Vector3[] corners { get; }
	public Vector3[] worldCorners { get; }
	public Vector4 margins { get; set; }
	public RectTransform rectTransform { get; }
	public TextMeshPro textMeshPro { get; }

	// Methods

	// RVA: 0x1988920 Offset: 0x1988A21 VA: 0x1988920
	public bool get_hasChanged() { }

	// RVA: 0x1988930 Offset: 0x1988A31 VA: 0x1988930
	public void set_hasChanged(bool value) { }

	// RVA: 0x1988940 Offset: 0x1988A41 VA: 0x1988940
	public Vector2 get_pivot() { }

	// RVA: 0x1988950 Offset: 0x1988A51 VA: 0x1988950
	public void set_pivot(Vector2 value) { }

	// RVA: 0x1988E00 Offset: 0x1988F01 VA: 0x1988E00
	public TextContainerAnchors get_anchorPosition() { }

	// RVA: 0x1988E10 Offset: 0x1988F11 VA: 0x1988E10
	public void set_anchorPosition(TextContainerAnchors value) { }

	// RVA: 0x1988EE0 Offset: 0x1988FE1 VA: 0x1988EE0
	public Rect get_rect() { }

	// RVA: 0x1988EF0 Offset: 0x1988FF1 VA: 0x1988EF0
	public void set_rect(Rect value) { }

	// RVA: 0x1988F80 Offset: 0x1989081 VA: 0x1988F80
	public Vector2 get_size() { }

	// RVA: 0x1988FD0 Offset: 0x19890D1 VA: 0x1988FD0
	public void set_size(Vector2 value) { }

	// RVA: 0x1989150 Offset: 0x1989251 VA: 0x1989150
	public float get_width() { }

	// RVA: 0x1989160 Offset: 0x1989261 VA: 0x1989160
	public void set_width(float value) { }

	// RVA: 0x1989210 Offset: 0x1989311 VA: 0x1989210
	public float get_height() { }

	// RVA: 0x1989220 Offset: 0x1989321 VA: 0x1989220
	public void set_height(float value) { }

	// RVA: 0x19892D0 Offset: 0x19893D1 VA: 0x19892D0
	public bool get_isDefaultWidth() { }

	// RVA: 0x19892E0 Offset: 0x19893E1 VA: 0x19892E0
	public bool get_isDefaultHeight() { }

	// RVA: 0x19892F0 Offset: 0x19893F1 VA: 0x19892F0
	public bool get_isAutoFitting() { }

	// RVA: 0x1989300 Offset: 0x1989401 VA: 0x1989300
	public void set_isAutoFitting(bool value) { }

	// RVA: 0x1989310 Offset: 0x1989411 VA: 0x1989310
	public Vector3[] get_corners() { }

	// RVA: 0x1989320 Offset: 0x1989421 VA: 0x1989320
	public Vector3[] get_worldCorners() { }

	// RVA: 0x1989330 Offset: 0x1989431 VA: 0x1989330
	public Vector4 get_margins() { }

	// RVA: 0x1989340 Offset: 0x1989441 VA: 0x1989340
	public void set_margins(Vector4 value) { }

	// RVA: 0x19893B0 Offset: 0x19894B1 VA: 0x19893B0
	public RectTransform get_rectTransform() { }

	// RVA: 0x1989470 Offset: 0x1989571 VA: 0x1989470
	public TextMeshPro get_textMeshPro() { }

	// RVA: 0x1989530 Offset: 0x1989631 VA: 0x1989530 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1989600 Offset: 0x1989701 VA: 0x1989600 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1989610 Offset: 0x1989711 VA: 0x1989610 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1988CB0 Offset: 0x1988DB1 VA: 0x1988CB0
	private void OnContainerChanged() { }

	// RVA: 0x1989810 Offset: 0x1989911 VA: 0x1989810 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x19890C0 Offset: 0x19891C1 VA: 0x19890C0
	private void SetRect(Vector2 size) { }

	// RVA: 0x1989620 Offset: 0x1989721 VA: 0x1989620
	private void UpdateCorners() { }

	// RVA: 0x1988E90 Offset: 0x1988F91 VA: 0x1988E90
	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	// RVA: 0x1988B50 Offset: 0x1988C51 VA: 0x1988B50
	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	// RVA: 0x1989980 Offset: 0x1989A81 VA: 0x1989980
	public void .ctor() { }

	// RVA: 0x1989A20 Offset: 0x1989B21 VA: 0x1989A20
	private static void .cctor() { }
}

