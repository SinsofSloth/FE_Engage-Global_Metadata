// Namespace: UnityEngine.UI
[AddComponentMenu] // RVA: 0x43450 Offset: 0x43551 VA: 0x43450
[RequireComponent] // RVA: 0x43450 Offset: 0x43551 VA: 0x43450
public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 4352
{
	// Fields
	[SerializeField] // RVA: 0x45710 Offset: 0x45811 VA: 0x45710
	private FontData m_FontData; // 0xD0
	[SerializeField] // RVA: 0x45720 Offset: 0x45821 VA: 0x45720
	[TextAreaAttribute] // RVA: 0x45720 Offset: 0x45821 VA: 0x45720
	protected string m_Text; // 0xD8
	private TextGenerator m_TextCache; // 0xE0
	private TextGenerator m_TextCacheForLayout; // 0xE8
	protected static Material s_DefaultText; // 0x0
	protected bool m_DisableFontTextureRebuiltCallback; // 0xF0
	private readonly UIVertex[] m_TempVerts; // 0xF8

	// Properties
	public TextGenerator cachedTextGenerator { get; }
	public TextGenerator cachedTextGeneratorForLayout { get; }
	public override Texture mainTexture { get; }
	public Font font { get; set; }
	public virtual string text { get; set; }
	public bool supportRichText { get; set; }
	public bool resizeTextForBestFit { get; set; }
	public int resizeTextMinSize { get; set; }
	public int resizeTextMaxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public int fontSize { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }
	public FontStyle fontStyle { get; set; }
	public float pixelsPerUnit { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x1BF66D0 Offset: 0x1BF67D1 VA: 0x1BF66D0
	protected void .ctor() { }

	// RVA: 0x1BF6790 Offset: 0x1BF6891 VA: 0x1BF6790
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x1BF6830 Offset: 0x1BF6931 VA: 0x1BF6830
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x1BF68C0 Offset: 0x1BF69C1 VA: 0x1BF68C0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x1BF6A90 Offset: 0x1BF6B91 VA: 0x1BF6A90
	public void FontTextureChanged() { }

	// RVA: 0x1BF6A80 Offset: 0x1BF6B81 VA: 0x1BF6A80
	public Font get_font() { }

	// RVA: 0x1BF6C40 Offset: 0x1BF6D41 VA: 0x1BF6C40
	public void set_font(Font value) { }

	// RVA: 0x1BF6D80 Offset: 0x1BF6E81 VA: 0x1BF6D80 Slot: 74
	public virtual string get_text() { }

	// RVA: 0x1BF6D90 Offset: 0x1BF6E91 VA: 0x1BF6D90 Slot: 75
	public virtual void set_text(string value) { }

	// RVA: 0x1BF6E80 Offset: 0x1BF6F81 VA: 0x1BF6E80
	public bool get_supportRichText() { }

	// RVA: 0x1BF6E90 Offset: 0x1BF6F91 VA: 0x1BF6E90
	public void set_supportRichText(bool value) { }

	// RVA: 0x1BF6F00 Offset: 0x1BF7001 VA: 0x1BF6F00
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x1BF6F10 Offset: 0x1BF7011 VA: 0x1BF6F10
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x1BF6F80 Offset: 0x1BF7081 VA: 0x1BF6F80
	public int get_resizeTextMinSize() { }

	// RVA: 0x1BF6F90 Offset: 0x1BF7091 VA: 0x1BF6F90
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x1BF6FF0 Offset: 0x1BF70F1 VA: 0x1BF6FF0
	public int get_resizeTextMaxSize() { }

	// RVA: 0x1BF7000 Offset: 0x1BF7101 VA: 0x1BF7000
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x1BF7060 Offset: 0x1BF7161 VA: 0x1BF7060
	public TextAnchor get_alignment() { }

	// RVA: 0x1BF7070 Offset: 0x1BF7171 VA: 0x1BF7070
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1BF70D0 Offset: 0x1BF71D1 VA: 0x1BF70D0
	public bool get_alignByGeometry() { }

	// RVA: 0x1BF70E0 Offset: 0x1BF71E1 VA: 0x1BF70E0
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x1BF7120 Offset: 0x1BF7221 VA: 0x1BF7120
	public int get_fontSize() { }

	// RVA: 0x1BF7130 Offset: 0x1BF7231 VA: 0x1BF7130
	public void set_fontSize(int value) { }

	// RVA: 0x1BF7190 Offset: 0x1BF7291 VA: 0x1BF7190
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x1BF71A0 Offset: 0x1BF72A1 VA: 0x1BF71A0
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x1BF7200 Offset: 0x1BF7301 VA: 0x1BF7200
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x1BF7210 Offset: 0x1BF7311 VA: 0x1BF7210
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x1BF7270 Offset: 0x1BF7371 VA: 0x1BF7270
	public float get_lineSpacing() { }

	// RVA: 0x1BF7280 Offset: 0x1BF7381 VA: 0x1BF7280
	public void set_lineSpacing(float value) { }

	// RVA: 0x1BF72E0 Offset: 0x1BF73E1 VA: 0x1BF72E0
	public FontStyle get_fontStyle() { }

	// RVA: 0x1BF72F0 Offset: 0x1BF73F1 VA: 0x1BF72F0
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x1BF7350 Offset: 0x1BF7451 VA: 0x1BF7350
	public float get_pixelsPerUnit() { }

	// RVA: 0x1BF74A0 Offset: 0x1BF75A1 VA: 0x1BF74A0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1BF75A0 Offset: 0x1BF76A1 VA: 0x1BF75A0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1BF7620 Offset: 0x1BF7721 VA: 0x1BF7620 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x1BF76C0 Offset: 0x1BF77C1 VA: 0x1BF76C0
	internal void AssignDefaultFont() { }

	// RVA: 0x1BF7740 Offset: 0x1BF7841 VA: 0x1BF7740
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x1BF7900 Offset: 0x1BF7A01 VA: 0x1BF7900
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x1BF7950 Offset: 0x1BF7A51 VA: 0x1BF7950 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x1BF8410 Offset: 0x1BF8511 VA: 0x1BF8410 Slot: 76
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1BF8420 Offset: 0x1BF8521 VA: 0x1BF8420 Slot: 77
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1BF8430 Offset: 0x1BF8531 VA: 0x1BF8430 Slot: 78
	public virtual float get_minWidth() { }

	// RVA: 0x1BF8440 Offset: 0x1BF8541 VA: 0x1BF8440 Slot: 79
	public virtual float get_preferredWidth() { }

	// RVA: 0x1BF8550 Offset: 0x1BF8651 VA: 0x1BF8550 Slot: 80
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1BF8560 Offset: 0x1BF8661 VA: 0x1BF8560 Slot: 81
	public virtual float get_minHeight() { }

	// RVA: 0x1BF8570 Offset: 0x1BF8671 VA: 0x1BF8570 Slot: 82
	public virtual float get_preferredHeight() { }

	// RVA: 0x1BF86A0 Offset: 0x1BF87A1 VA: 0x1BF86A0 Slot: 83
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1BF86B0 Offset: 0x1BF87B1 VA: 0x1BF86B0 Slot: 84
	public virtual int get_layoutPriority() { }

	// RVA: 0x1BF86C0 Offset: 0x1BF87C1 VA: 0x1BF86C0
	private static void .cctor() { }
}

