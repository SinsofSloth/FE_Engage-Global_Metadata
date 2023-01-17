// Namespace: Combat
internal class VerticalLayoutUI : IDisposable // TypeDefIndex: 8750
{
	// Fields
	public Color DefaultHighlightedColor; // 0x10
	public Color DefaultPressedColor; // 0x20
	public Color DefaultSelectedColor; // 0x30
	public TextAnchor DefaultTextAnchor; // 0x40
	public float DefaultWidgetWidth; // 0x44
	public float DefaultWidgetHeight; // 0x48
	public float DefaultItemMargin; // 0x4C
	public int DefaultFontSize; // 0x50
	public Color DefaultFontColor; // 0x54
	public bool UseTextOutline; // 0x64
	private Vector3 m_InitialPosition; // 0x68
	private Vector3 m_CurrentPosition; // 0x74
	private Canvas m_Canvas; // 0x80
	private bool m_bInitialSelected; // 0x88
	public List<GameObject> m_Widgets; // 0x90

	// Methods

	// RVA: 0x26C0830 Offset: 0x26C0931 VA: 0x26C0830
	public void .ctor(Canvas canvas, Vector3 anchor) { }

	// RVA: 0x26C09F0 Offset: 0x26C0AF1 VA: 0x26C09F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x26C0B00 Offset: 0x26C0C01 VA: 0x26C0B00
	public Text Text(string text) { }

	// RVA: 0x26C0FB0 Offset: 0x26C10B1 VA: 0x26C0FB0
	public Button Button(string text, Action OnPressed) { }

	// RVA: 0x26C1280 Offset: 0x26C1381 VA: 0x26C1280
	public static Button MinimizeLeft(Button button) { }

	// RVA: 0x26C13D0 Offset: 0x26C14D1 VA: 0x26C13D0
	public Slider Slider(ReactiveProperty<float> property, float minValue = 0, float maxValue = 1, Action<float> OnValueChanged) { }

	// RVA: 0x26C17B0 Offset: 0x26C18B1 VA: 0x26C17B0
	public void Slider(string text, float textRatio, ReactiveProperty<float> property, float minValue = 0, float maxValue = 1, Action<float> OnValueChanged) { }

	// RVA: 0x26C19E0 Offset: 0x26C1AE1 VA: 0x26C19E0
	private static string MakeStr(string label, float value) { }

	// RVA: 0x26C1BF0 Offset: 0x26C1CF1 VA: 0x26C1BF0
	public Dropdown Dropdown(string headline, List<string> items, Action<string> OnValueChanged) { }

	// RVA: 0x26C1DA0 Offset: 0x26C1EA1 VA: 0x26C1DA0
	public Toggle Toggle(string text) { }

	// RVA: 0x26C1F90 Offset: 0x26C2091 VA: 0x26C1F90
	public void Space(float space) { }

	// RVA: 0x26C1AD0 Offset: 0x26C1BD1 VA: 0x26C1AD0
	private static void SetRectTransformXW(Component com, float w, float x = 0) { }

	// RVA: 0x26C11F0 Offset: 0x26C12F1 VA: 0x26C11F0
	private void SetColors(Selectable widget) { }

	// RVA: 0x26C1710 Offset: 0x26C1811 VA: 0x26C1710
	private void SetColors(Slider widget) { }

	// RVA: 0x26C0DE0 Offset: 0x26C0EE1 VA: 0x26C0DE0
	private static void SetTextColorAndOutline(Text text, Color color, bool outline) { }

	// RVA: 0x26C0ED0 Offset: 0x26C0FD1 VA: 0x26C0ED0
	private static void SetPosition(Component c, Vector2 v) { }

	// RVA: 0x26C0C80 Offset: 0x26C0D81 VA: 0x26C0C80
	private static void SetSize(Component c, float width, float height) { }

	// RVA: 0x26C0D70 Offset: 0x26C0E71 VA: 0x26C0D70
	private static void SetFontSize(Text widget, int size = -1) { }
}

