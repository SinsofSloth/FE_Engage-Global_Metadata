// Namespace: UnityEngine
[ExecuteInEditMode] // RVA: 0x52AF0 Offset: 0x52BF1 VA: 0x52AF0
[AssetFileNameExtensionAttribute] // RVA: 0x52AF0 Offset: 0x52BF1 VA: 0x52AF0
[RequiredByNativeCodeAttribute] // RVA: 0x52AF0 Offset: 0x52BF1 VA: 0x52AF0
[Serializable]
public sealed class GUISkin : ScriptableObject // TypeDefIndex: 4163
{
	// Fields
	[SerializeField] // RVA: 0x53520 Offset: 0x53621 VA: 0x53520
	private Font m_Font; // 0x18
	[SerializeField] // RVA: 0x53530 Offset: 0x53631 VA: 0x53530
	private GUIStyle m_box; // 0x20
	[SerializeField] // RVA: 0x53540 Offset: 0x53641 VA: 0x53540
	private GUIStyle m_button; // 0x28
	[SerializeField] // RVA: 0x53550 Offset: 0x53651 VA: 0x53550
	private GUIStyle m_toggle; // 0x30
	[SerializeField] // RVA: 0x53560 Offset: 0x53661 VA: 0x53560
	private GUIStyle m_label; // 0x38
	[SerializeField] // RVA: 0x53570 Offset: 0x53671 VA: 0x53570
	private GUIStyle m_textField; // 0x40
	[SerializeField] // RVA: 0x53580 Offset: 0x53681 VA: 0x53580
	private GUIStyle m_textArea; // 0x48
	[SerializeField] // RVA: 0x53590 Offset: 0x53691 VA: 0x53590
	private GUIStyle m_window; // 0x50
	[SerializeField] // RVA: 0x535A0 Offset: 0x536A1 VA: 0x535A0
	private GUIStyle m_horizontalSlider; // 0x58
	[SerializeField] // RVA: 0x535B0 Offset: 0x536B1 VA: 0x535B0
	private GUIStyle m_horizontalSliderThumb; // 0x60
	private GUIStyle m_horizontalSliderThumbExtent; // 0x68
	[SerializeField] // RVA: 0x535C0 Offset: 0x536C1 VA: 0x535C0
	private GUIStyle m_verticalSlider; // 0x70
	[SerializeField] // RVA: 0x535D0 Offset: 0x536D1 VA: 0x535D0
	private GUIStyle m_verticalSliderThumb; // 0x78
	private GUIStyle m_verticalSliderThumbExtent; // 0x80
	private GUIStyle m_SliderMixed; // 0x88
	[SerializeField] // RVA: 0x535E0 Offset: 0x536E1 VA: 0x535E0
	private GUIStyle m_horizontalScrollbar; // 0x90
	[SerializeField] // RVA: 0x535F0 Offset: 0x536F1 VA: 0x535F0
	private GUIStyle m_horizontalScrollbarThumb; // 0x98
	[SerializeField] // RVA: 0x53600 Offset: 0x53701 VA: 0x53600
	private GUIStyle m_horizontalScrollbarLeftButton; // 0xA0
	[SerializeField] // RVA: 0x53610 Offset: 0x53711 VA: 0x53610
	private GUIStyle m_horizontalScrollbarRightButton; // 0xA8
	[SerializeField] // RVA: 0x53620 Offset: 0x53721 VA: 0x53620
	private GUIStyle m_verticalScrollbar; // 0xB0
	[SerializeField] // RVA: 0x53630 Offset: 0x53731 VA: 0x53630
	private GUIStyle m_verticalScrollbarThumb; // 0xB8
	[SerializeField] // RVA: 0x53640 Offset: 0x53741 VA: 0x53640
	private GUIStyle m_verticalScrollbarUpButton; // 0xC0
	[SerializeField] // RVA: 0x53650 Offset: 0x53751 VA: 0x53650
	private GUIStyle m_verticalScrollbarDownButton; // 0xC8
	[SerializeField] // RVA: 0x53660 Offset: 0x53761 VA: 0x53660
	private GUIStyle m_ScrollView; // 0xD0
	[SerializeField] // RVA: 0x53670 Offset: 0x53771 VA: 0x53670
	internal GUIStyle[] m_CustomStyles; // 0xD8
	[SerializeField] // RVA: 0x53680 Offset: 0x53781 VA: 0x53680
	private GUISettings m_Settings; // 0xE0
	internal static GUIStyle ms_Error; // 0x0
	private Dictionary<string, GUIStyle> m_Styles; // 0xE8
	internal static GUISkin.SkinChangedDelegate m_SkinChanged; // 0x8
	internal static GUISkin current; // 0x10

	// Properties
	public Font font { get; set; }
	public GUIStyle box { get; set; }
	public GUIStyle label { get; set; }
	public GUIStyle textField { get; set; }
	public GUIStyle textArea { get; set; }
	public GUIStyle button { get; set; }
	public GUIStyle toggle { get; set; }
	public GUIStyle window { get; set; }
	public GUIStyle horizontalSlider { get; set; }
	public GUIStyle horizontalSliderThumb { get; set; }
	internal GUIStyle horizontalSliderThumbExtent { get; set; }
	internal GUIStyle sliderMixed { get; set; }
	public GUIStyle verticalSlider { get; set; }
	public GUIStyle verticalSliderThumb { get; set; }
	internal GUIStyle verticalSliderThumbExtent { get; set; }
	public GUIStyle horizontalScrollbar { get; set; }
	public GUIStyle horizontalScrollbarThumb { get; set; }
	public GUIStyle horizontalScrollbarLeftButton { get; set; }
	public GUIStyle horizontalScrollbarRightButton { get; set; }
	public GUIStyle verticalScrollbar { get; set; }
	public GUIStyle verticalScrollbarThumb { get; set; }
	public GUIStyle verticalScrollbarUpButton { get; set; }
	public GUIStyle verticalScrollbarDownButton { get; set; }
	public GUIStyle scrollView { get; set; }
	public GUIStyle[] customStyles { get; set; }
	public GUISettings settings { get; }
	internal static GUIStyle error { get; }

	// Methods

	// RVA: 0x3C81EB0 Offset: 0x3C81FB1 VA: 0x3C81EB0
	public void .ctor() { }

	// RVA: 0x3C81FD0 Offset: 0x3C820D1 VA: 0x3C81FD0
	internal void OnEnable() { }

	// RVA: 0x3C82110 Offset: 0x3C82211 VA: 0x3C82110
	internal static void CleanupRoots() { }

	// RVA: 0x3C82180 Offset: 0x3C82281 VA: 0x3C82180
	public Font get_font() { }

	// RVA: 0x3C82190 Offset: 0x3C82291 VA: 0x3C82190
	public void set_font(Font value) { }

	// RVA: 0x3C82390 Offset: 0x3C82491 VA: 0x3C82390
	public GUIStyle get_box() { }

	// RVA: 0x3C823A0 Offset: 0x3C824A1 VA: 0x3C823A0
	public void set_box(GUIStyle value) { }

	// RVA: 0x3C7A220 Offset: 0x3C7A321 VA: 0x3C7A220
	public GUIStyle get_label() { }

	// RVA: 0x3C82450 Offset: 0x3C82551 VA: 0x3C82450
	public void set_label(GUIStyle value) { }

	// RVA: 0x3C82500 Offset: 0x3C82601 VA: 0x3C82500
	public GUIStyle get_textField() { }

	// RVA: 0x3C82510 Offset: 0x3C82611 VA: 0x3C82510
	public void set_textField(GUIStyle value) { }

	// RVA: 0x3C825C0 Offset: 0x3C826C1 VA: 0x3C825C0
	public GUIStyle get_textArea() { }

	// RVA: 0x3C825D0 Offset: 0x3C826D1 VA: 0x3C825D0
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x3C72DF0 Offset: 0x3C72EF1 VA: 0x3C72DF0
	public GUIStyle get_button() { }

	// RVA: 0x3C82680 Offset: 0x3C82781 VA: 0x3C82680
	public void set_button(GUIStyle value) { }

	// RVA: 0x3C82730 Offset: 0x3C82831 VA: 0x3C82730
	public GUIStyle get_toggle() { }

	// RVA: 0x3C82740 Offset: 0x3C82841 VA: 0x3C82740
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x3C7BF20 Offset: 0x3C7C021 VA: 0x3C7BF20
	public GUIStyle get_window() { }

	// RVA: 0x3C827F0 Offset: 0x3C828F1 VA: 0x3C827F0
	public void set_window(GUIStyle value) { }

	// RVA: 0x3C7A600 Offset: 0x3C7A701 VA: 0x3C7A600
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x3C828A0 Offset: 0x3C829A1 VA: 0x3C828A0
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0x3C7A610 Offset: 0x3C7A711 VA: 0x3C7A610
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x3C82950 Offset: 0x3C82A51 VA: 0x3C82950
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x3C82A00 Offset: 0x3C82B01 VA: 0x3C82A00
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x3C82A10 Offset: 0x3C82B11 VA: 0x3C82A10
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x3C82AC0 Offset: 0x3C82BC1 VA: 0x3C82AC0
	internal GUIStyle get_sliderMixed() { }

	// RVA: 0x3C82AD0 Offset: 0x3C82BD1 VA: 0x3C82AD0
	internal void set_sliderMixed(GUIStyle value) { }

	// RVA: 0x3C82B80 Offset: 0x3C82C81 VA: 0x3C82B80
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x3C82B90 Offset: 0x3C82C91 VA: 0x3C82B90
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x3C82C40 Offset: 0x3C82D41 VA: 0x3C82C40
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x3C82C50 Offset: 0x3C82D51 VA: 0x3C82C50
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x3C82D00 Offset: 0x3C82E01 VA: 0x3C82D00
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x3C82D10 Offset: 0x3C82E11 VA: 0x3C82D10
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x3C7BA40 Offset: 0x3C7BB41 VA: 0x3C7BA40
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x3C82DC0 Offset: 0x3C82EC1 VA: 0x3C82DC0
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x3C82E70 Offset: 0x3C82F71 VA: 0x3C82E70
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x3C82E80 Offset: 0x3C82F81 VA: 0x3C82E80
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x3C82F30 Offset: 0x3C83031 VA: 0x3C82F30
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x3C82F40 Offset: 0x3C83041 VA: 0x3C82F40
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x3C82FF0 Offset: 0x3C830F1 VA: 0x3C82FF0
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x3C83000 Offset: 0x3C83101 VA: 0x3C83000
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x3C7BA50 Offset: 0x3C7BB51 VA: 0x3C7BA50
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x3C830B0 Offset: 0x3C831B1 VA: 0x3C830B0
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x3C83160 Offset: 0x3C83261 VA: 0x3C83160
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x3C83170 Offset: 0x3C83271 VA: 0x3C83170
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x3C83220 Offset: 0x3C83321 VA: 0x3C83220
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x3C83230 Offset: 0x3C83331 VA: 0x3C83230
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x3C832E0 Offset: 0x3C833E1 VA: 0x3C832E0
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x3C832F0 Offset: 0x3C833F1 VA: 0x3C832F0
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x3C7BA60 Offset: 0x3C7BB61 VA: 0x3C7BA60
	public GUIStyle get_scrollView() { }

	// RVA: 0x3C833A0 Offset: 0x3C834A1 VA: 0x3C833A0
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x3C83450 Offset: 0x3C83551 VA: 0x3C83450
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x3C83460 Offset: 0x3C83561 VA: 0x3C83460
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x3C83500 Offset: 0x3C83601 VA: 0x3C83500
	public GUISettings get_settings() { }

	// RVA: 0x3C83510 Offset: 0x3C83611 VA: 0x3C83510
	internal static GUIStyle get_error() { }

	// RVA: 0x3C82070 Offset: 0x3C82171 VA: 0x3C82070
	internal void Apply() { }

	// RVA: 0x3C837C0 Offset: 0x3C838C1 VA: 0x3C837C0
	private void BuildStyleCache() { }

	// RVA: 0x3C74790 Offset: 0x3C74891 VA: 0x3C74790
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x3C85760 Offset: 0x3C85861 VA: 0x3C85760
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x3C70D40 Offset: 0x3C70E41 VA: 0x3C70D40
	internal void MakeCurrent() { }

	// RVA: 0x3C857F0 Offset: 0x3C858F1 VA: 0x3C857F0
	public IEnumerator GetEnumerator() { }
}

