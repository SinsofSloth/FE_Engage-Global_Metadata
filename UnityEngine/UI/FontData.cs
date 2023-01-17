// Namespace: UnityEngine.UI
[Serializable]
public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 4265
{
	// Fields
	[SerializeField] // RVA: 0x44080 Offset: 0x44181 VA: 0x44080
	[FormerlySerializedAsAttribute] // RVA: 0x44080 Offset: 0x44181 VA: 0x44080
	private Font m_Font; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0x440D0 Offset: 0x441D1 VA: 0x440D0
	[SerializeField] // RVA: 0x440D0 Offset: 0x441D1 VA: 0x440D0
	private int m_FontSize; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x44120 Offset: 0x44221 VA: 0x44120
	[SerializeField] // RVA: 0x44120 Offset: 0x44221 VA: 0x44120
	private FontStyle m_FontStyle; // 0x1C
	[SerializeField] // RVA: 0x44170 Offset: 0x44271 VA: 0x44170
	private bool m_BestFit; // 0x20
	[SerializeField] // RVA: 0x44180 Offset: 0x44281 VA: 0x44180
	private int m_MinSize; // 0x24
	[SerializeField] // RVA: 0x44190 Offset: 0x44291 VA: 0x44190
	private int m_MaxSize; // 0x28
	[SerializeField] // RVA: 0x441A0 Offset: 0x442A1 VA: 0x441A0
	[FormerlySerializedAsAttribute] // RVA: 0x441A0 Offset: 0x442A1 VA: 0x441A0
	private TextAnchor m_Alignment; // 0x2C
	[SerializeField] // RVA: 0x441F0 Offset: 0x442F1 VA: 0x441F0
	private bool m_AlignByGeometry; // 0x30
	[SerializeField] // RVA: 0x44200 Offset: 0x44301 VA: 0x44200
	[FormerlySerializedAsAttribute] // RVA: 0x44200 Offset: 0x44301 VA: 0x44200
	private bool m_RichText; // 0x31
	[SerializeField] // RVA: 0x44250 Offset: 0x44351 VA: 0x44250
	private HorizontalWrapMode m_HorizontalOverflow; // 0x34
	[SerializeField] // RVA: 0x44260 Offset: 0x44361 VA: 0x44260
	private VerticalWrapMode m_VerticalOverflow; // 0x38
	[SerializeField] // RVA: 0x44270 Offset: 0x44371 VA: 0x44270
	private float m_LineSpacing; // 0x3C

	// Properties
	public static FontData defaultFontData { get; }
	public Font font { get; set; }
	public int fontSize { get; set; }
	public FontStyle fontStyle { get; set; }
	public bool bestFit { get; set; }
	public int minSize { get; set; }
	public int maxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public bool richText { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }

	// Methods

	// RVA: 0x1A4F220 Offset: 0x1A4F321 VA: 0x1A4F220
	public static FontData get_defaultFontData() { }

	// RVA: 0x1A4F2C0 Offset: 0x1A4F3C1 VA: 0x1A4F2C0
	public Font get_font() { }

	// RVA: 0x1A4F2D0 Offset: 0x1A4F3D1 VA: 0x1A4F2D0
	public void set_font(Font value) { }

	// RVA: 0x1A4F2E0 Offset: 0x1A4F3E1 VA: 0x1A4F2E0
	public int get_fontSize() { }

	// RVA: 0x1A4F2F0 Offset: 0x1A4F3F1 VA: 0x1A4F2F0
	public void set_fontSize(int value) { }

	// RVA: 0x1A4F300 Offset: 0x1A4F401 VA: 0x1A4F300
	public FontStyle get_fontStyle() { }

	// RVA: 0x1A4F310 Offset: 0x1A4F411 VA: 0x1A4F310
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x1A4F320 Offset: 0x1A4F421 VA: 0x1A4F320
	public bool get_bestFit() { }

	// RVA: 0x1A4F330 Offset: 0x1A4F431 VA: 0x1A4F330
	public void set_bestFit(bool value) { }

	// RVA: 0x1A4F340 Offset: 0x1A4F441 VA: 0x1A4F340
	public int get_minSize() { }

	// RVA: 0x1A4F350 Offset: 0x1A4F451 VA: 0x1A4F350
	public void set_minSize(int value) { }

	// RVA: 0x1A4F360 Offset: 0x1A4F461 VA: 0x1A4F360
	public int get_maxSize() { }

	// RVA: 0x1A4F370 Offset: 0x1A4F471 VA: 0x1A4F370
	public void set_maxSize(int value) { }

	// RVA: 0x1A4F380 Offset: 0x1A4F481 VA: 0x1A4F380
	public TextAnchor get_alignment() { }

	// RVA: 0x1A4F390 Offset: 0x1A4F491 VA: 0x1A4F390
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1A4F3A0 Offset: 0x1A4F4A1 VA: 0x1A4F3A0
	public bool get_alignByGeometry() { }

	// RVA: 0x1A4F3B0 Offset: 0x1A4F4B1 VA: 0x1A4F3B0
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x1A4F3C0 Offset: 0x1A4F4C1 VA: 0x1A4F3C0
	public bool get_richText() { }

	// RVA: 0x1A4F3D0 Offset: 0x1A4F4D1 VA: 0x1A4F3D0
	public void set_richText(bool value) { }

	// RVA: 0x1A4F3E0 Offset: 0x1A4F4E1 VA: 0x1A4F3E0
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x1A4F3F0 Offset: 0x1A4F4F1 VA: 0x1A4F3F0
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x1A4F400 Offset: 0x1A4F501 VA: 0x1A4F400
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x1A4F410 Offset: 0x1A4F511 VA: 0x1A4F410
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x1A4F420 Offset: 0x1A4F521 VA: 0x1A4F420
	public float get_lineSpacing() { }

	// RVA: 0x1A4F430 Offset: 0x1A4F531 VA: 0x1A4F430
	public void set_lineSpacing(float value) { }

	// RVA: 0x1A4F440 Offset: 0x1A4F541 VA: 0x1A4F440 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x1A4F450 Offset: 0x1A4F551 VA: 0x1A4F450 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x1A4F2B0 Offset: 0x1A4F3B1 VA: 0x1A4F2B0
	public void .ctor() { }
}

