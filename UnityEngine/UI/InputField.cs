// Namespace: UnityEngine.UI
[AddComponentMenu] // RVA: 0x42B40 Offset: 0x42C41 VA: 0x42B40
public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 4293
{
	// Fields
	protected TouchScreenKeyboard m_Keyboard; // 0xF8
	private static readonly char[] kSeparators; // 0x0
	[SerializeField] // RVA: 0x444D0 Offset: 0x445D1 VA: 0x444D0
	[FormerlySerializedAsAttribute] // RVA: 0x444D0 Offset: 0x445D1 VA: 0x444D0
	protected Text m_TextComponent; // 0x100
	[SerializeField] // RVA: 0x44520 Offset: 0x44621 VA: 0x44520
	protected Graphic m_Placeholder; // 0x108
	[SerializeField] // RVA: 0x44530 Offset: 0x44631 VA: 0x44530
	private InputField.ContentType m_ContentType; // 0x110
	[FormerlySerializedAsAttribute] // RVA: 0x44540 Offset: 0x44641 VA: 0x44540
	[SerializeField] // RVA: 0x44540 Offset: 0x44641 VA: 0x44540
	private InputField.InputType m_InputType; // 0x114
	[FormerlySerializedAsAttribute] // RVA: 0x44590 Offset: 0x44691 VA: 0x44590
	[SerializeField] // RVA: 0x44590 Offset: 0x44691 VA: 0x44590
	private char m_AsteriskChar; // 0x118
	[SerializeField] // RVA: 0x445E0 Offset: 0x446E1 VA: 0x445E0
	[FormerlySerializedAsAttribute] // RVA: 0x445E0 Offset: 0x446E1 VA: 0x445E0
	private TouchScreenKeyboardType m_KeyboardType; // 0x11C
	[SerializeField] // RVA: 0x44630 Offset: 0x44731 VA: 0x44630
	private InputField.LineType m_LineType; // 0x120
	[FormerlySerializedAsAttribute] // RVA: 0x44640 Offset: 0x44741 VA: 0x44640
	[SerializeField] // RVA: 0x44640 Offset: 0x44741 VA: 0x44640
	private bool m_HideMobileInput; // 0x124
	[FormerlySerializedAsAttribute] // RVA: 0x44690 Offset: 0x44791 VA: 0x44690
	[SerializeField] // RVA: 0x44690 Offset: 0x44791 VA: 0x44690
	private InputField.CharacterValidation m_CharacterValidation; // 0x128
	[SerializeField] // RVA: 0x446E0 Offset: 0x447E1 VA: 0x446E0
	[FormerlySerializedAsAttribute] // RVA: 0x446E0 Offset: 0x447E1 VA: 0x446E0
	private int m_CharacterLimit; // 0x12C
	[FormerlySerializedAsAttribute] // RVA: 0x44730 Offset: 0x44831 VA: 0x44730
	[SerializeField] // RVA: 0x44730 Offset: 0x44831 VA: 0x44730
	[FormerlySerializedAsAttribute] // RVA: 0x44730 Offset: 0x44831 VA: 0x44730
	[FormerlySerializedAsAttribute] // RVA: 0x44730 Offset: 0x44831 VA: 0x44730
	private InputField.SubmitEvent m_OnEndEdit; // 0x130
	[FormerlySerializedAsAttribute] // RVA: 0x447D0 Offset: 0x448D1 VA: 0x447D0
	[FormerlySerializedAsAttribute] // RVA: 0x447D0 Offset: 0x448D1 VA: 0x447D0
	[SerializeField] // RVA: 0x447D0 Offset: 0x448D1 VA: 0x447D0
	private InputField.OnChangeEvent m_OnValueChanged; // 0x138
	[SerializeField] // RVA: 0x44840 Offset: 0x44941 VA: 0x44840
	[FormerlySerializedAsAttribute] // RVA: 0x44840 Offset: 0x44941 VA: 0x44840
	private InputField.OnValidateInput m_OnValidateInput; // 0x140
	[FormerlySerializedAsAttribute] // RVA: 0x44890 Offset: 0x44991 VA: 0x44890
	[SerializeField] // RVA: 0x44890 Offset: 0x44991 VA: 0x44890
	private Color m_CaretColor; // 0x148
	[SerializeField] // RVA: 0x448E0 Offset: 0x449E1 VA: 0x448E0
	private bool m_CustomCaretColor; // 0x158
	[SerializeField] // RVA: 0x448F0 Offset: 0x449F1 VA: 0x448F0
	private Color m_SelectionColor; // 0x15C
	[FormerlySerializedAsAttribute] // RVA: 0x44900 Offset: 0x44A01 VA: 0x44900
	[SerializeField] // RVA: 0x44900 Offset: 0x44A01 VA: 0x44900
	protected string m_Text; // 0x170
	[SerializeField] // RVA: 0x44950 Offset: 0x44A51 VA: 0x44950
	[RangeAttribute] // RVA: 0x44950 Offset: 0x44A51 VA: 0x44950
	private float m_CaretBlinkRate; // 0x178
	[SerializeField] // RVA: 0x44990 Offset: 0x44A91 VA: 0x44990
	[RangeAttribute] // RVA: 0x44990 Offset: 0x44A91 VA: 0x44990
	private int m_CaretWidth; // 0x17C
	[SerializeField] // RVA: 0x449D0 Offset: 0x44AD1 VA: 0x449D0
	private bool m_ReadOnly; // 0x180
	[SerializeField] // RVA: 0x449E0 Offset: 0x44AE1 VA: 0x449E0
	private bool m_ShouldActivateOnSelect; // 0x181
	protected int m_CaretPosition; // 0x184
	protected int m_CaretSelectPosition; // 0x188
	private RectTransform caretRectTrans; // 0x190
	protected UIVertex[] m_CursorVerts; // 0x198
	private TextGenerator m_InputTextCache; // 0x1A0
	private CanvasRenderer m_CachedInputRenderer; // 0x1A8
	private bool m_PreventFontCallback; // 0x1B0
	protected Mesh m_Mesh; // 0x1B8
	private bool m_AllowInput; // 0x1C0
	private bool m_ShouldActivateNextUpdate; // 0x1C1
	private bool m_UpdateDrag; // 0x1C2
	private bool m_DragPositionOutOfBounds; // 0x1C3
	private const float kHScrollSpeed = 0.05;
	private const float kVScrollSpeed = 0.1;
	protected bool m_CaretVisible; // 0x1C4
	private Coroutine m_BlinkCoroutine; // 0x1C8
	private float m_BlinkStartTime; // 0x1D0
	protected int m_DrawStart; // 0x1D4
	protected int m_DrawEnd; // 0x1D8
	private Coroutine m_DragCoroutine; // 0x1E0
	private string m_OriginalText; // 0x1E8
	private bool m_WasCanceled; // 0x1F0
	private bool m_HasDoneFocusTransition; // 0x1F1
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x1F8
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x200
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private Event m_ProcessingEvent; // 0x208
	private const int k_MaxTextLength = 16382;

	// Properties
	private BaseInput input { get; }
	private string compositionString { get; }
	protected Mesh mesh { get; }
	protected TextGenerator cachedInputTextGenerator { get; }
	public bool shouldHideMobileInput { get; set; }
	public virtual bool shouldActivateOnSelect { get; set; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public InputField.SubmitEvent onEndEdit { get; set; }
	[ObsoleteAttribute] // RVA: 0x467A0 Offset: 0x468A1 VA: 0x467A0
	public InputField.OnChangeEvent onValueChange { get; set; }
	public InputField.OnChangeEvent onValueChanged { get; set; }
	public InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public InputField.ContentType contentType { get; set; }
	public InputField.LineType lineType { get; set; }
	public InputField.InputType inputType { get; set; }
	public TouchScreenKeyboard touchScreenKeyboard { get; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public InputField.CharacterValidation characterValidation { get; set; }
	public bool readOnly { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x1BE5380 Offset: 0x1BE5481 VA: 0x1BE5380
	private BaseInput get_input() { }

	// RVA: 0x1BE54E0 Offset: 0x1BE55E1 VA: 0x1BE54E0
	private string get_compositionString() { }

	// RVA: 0x1BE5580 Offset: 0x1BE5681 VA: 0x1BE5580
	protected void .ctor() { }

	// RVA: 0x1BE5880 Offset: 0x1BE5981 VA: 0x1BE5880
	protected Mesh get_mesh() { }

	// RVA: 0x1BE5940 Offset: 0x1BE5A41 VA: 0x1BE5940
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x1BE59D0 Offset: 0x1BE5AD1 VA: 0x1BE59D0
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x1BE5A30 Offset: 0x1BE5B31 VA: 0x1BE5A30
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x1BE5A90 Offset: 0x1BE5B91 VA: 0x1BE5A90 Slot: 59
	public virtual void set_shouldActivateOnSelect(bool value) { }

	// RVA: 0x1BE5AA0 Offset: 0x1BE5BA1 VA: 0x1BE5AA0 Slot: 60
	public virtual bool get_shouldActivateOnSelect() { }

	// RVA: 0x1BE5AE0 Offset: 0x1BE5BE1 VA: 0x1BE5AE0
	public string get_text() { }

	// RVA: 0x1BE5AF0 Offset: 0x1BE5BF1 VA: 0x1BE5AF0
	public void set_text(string value) { }

	// RVA: 0x1BE5E80 Offset: 0x1BE5F81 VA: 0x1BE5E80
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x1BE5B00 Offset: 0x1BE5C01 VA: 0x1BE5B00
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0x1BE6400 Offset: 0x1BE6501 VA: 0x1BE6400
	public bool get_isFocused() { }

	// RVA: 0x1BE6410 Offset: 0x1BE6511 VA: 0x1BE6410
	public float get_caretBlinkRate() { }

	// RVA: 0x1BE6420 Offset: 0x1BE6521 VA: 0x1BE6420
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x1BE6590 Offset: 0x1BE6691 VA: 0x1BE6590
	public int get_caretWidth() { }

	// RVA: 0x1BE65A0 Offset: 0x1BE66A1 VA: 0x1BE65A0
	public void set_caretWidth(int value) { }

	// RVA: 0x1BE66D0 Offset: 0x1BE67D1 VA: 0x1BE66D0
	public Text get_textComponent() { }

	// RVA: 0x1BE66E0 Offset: 0x1BE67E1 VA: 0x1BE66E0
	public void set_textComponent(Text value) { }

	// RVA: 0x1BE6980 Offset: 0x1BE6A81 VA: 0x1BE6980
	public Graphic get_placeholder() { }

	// RVA: 0x1BE6990 Offset: 0x1BE6A91 VA: 0x1BE6990
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1BE69F0 Offset: 0x1BE6AF1 VA: 0x1BE69F0
	public Color get_caretColor() { }

	// RVA: 0x1BE6A40 Offset: 0x1BE6B41 VA: 0x1BE6A40
	public void set_caretColor(Color value) { }

	// RVA: 0x1BE6AD0 Offset: 0x1BE6BD1 VA: 0x1BE6AD0
	public bool get_customCaretColor() { }

	// RVA: 0x1BE6AE0 Offset: 0x1BE6BE1 VA: 0x1BE6AE0
	public void set_customCaretColor(bool value) { }

	// RVA: 0x1BE6B80 Offset: 0x1BE6C81 VA: 0x1BE6B80
	public Color get_selectionColor() { }

	// RVA: 0x1BE6BA0 Offset: 0x1BE6CA1 VA: 0x1BE6BA0
	public void set_selectionColor(Color value) { }

	// RVA: 0x1BE6C30 Offset: 0x1BE6D31 VA: 0x1BE6C30
	public InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0x1BE6C40 Offset: 0x1BE6D41 VA: 0x1BE6C40
	public void set_onEndEdit(InputField.SubmitEvent value) { }

	// RVA: 0x1BE6CA0 Offset: 0x1BE6DA1 VA: 0x1BE6CA0
	public InputField.OnChangeEvent get_onValueChange() { }

	// RVA: 0x1BE6CB0 Offset: 0x1BE6DB1 VA: 0x1BE6CB0
	public void set_onValueChange(InputField.OnChangeEvent value) { }

	// RVA: 0x1BE6D70 Offset: 0x1BE6E71 VA: 0x1BE6D70
	public InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x1BE6D10 Offset: 0x1BE6E11 VA: 0x1BE6D10
	public void set_onValueChanged(InputField.OnChangeEvent value) { }

	// RVA: 0x1BE6D80 Offset: 0x1BE6E81 VA: 0x1BE6D80
	public InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x1BE6D90 Offset: 0x1BE6E91 VA: 0x1BE6D90
	public void set_onValidateInput(InputField.OnValidateInput value) { }

	// RVA: 0x1BE6DF0 Offset: 0x1BE6EF1 VA: 0x1BE6DF0
	public int get_characterLimit() { }

	// RVA: 0x1BE6E00 Offset: 0x1BE6F01 VA: 0x1BE6E00
	public void set_characterLimit(int value) { }

	// RVA: 0x1BE6EE0 Offset: 0x1BE6FE1 VA: 0x1BE6EE0
	public InputField.ContentType get_contentType() { }

	// RVA: 0x1BE6EF0 Offset: 0x1BE6FF1 VA: 0x1BE6EF0
	public void set_contentType(InputField.ContentType value) { }

	// RVA: 0x1BE70F0 Offset: 0x1BE71F1 VA: 0x1BE70F0
	public InputField.LineType get_lineType() { }

	// RVA: 0x1BE7100 Offset: 0x1BE7201 VA: 0x1BE7100
	public void set_lineType(InputField.LineType value) { }

	// RVA: 0x1BE7270 Offset: 0x1BE7371 VA: 0x1BE7270
	public InputField.InputType get_inputType() { }

	// RVA: 0x1BE7280 Offset: 0x1BE7381 VA: 0x1BE7280
	public void set_inputType(InputField.InputType value) { }

	// RVA: 0x1BE7330 Offset: 0x1BE7431 VA: 0x1BE7330
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x1BE7340 Offset: 0x1BE7441 VA: 0x1BE7340
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x1BE7350 Offset: 0x1BE7451 VA: 0x1BE7350
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x1BE73E0 Offset: 0x1BE74E1 VA: 0x1BE73E0
	public InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x1BE73F0 Offset: 0x1BE74F1 VA: 0x1BE73F0
	public void set_characterValidation(InputField.CharacterValidation value) { }

	// RVA: 0x1BE7480 Offset: 0x1BE7581 VA: 0x1BE7480
	public bool get_readOnly() { }

	// RVA: 0x1BE7490 Offset: 0x1BE7591 VA: 0x1BE7490
	public void set_readOnly(bool value) { }

	// RVA: 0x1BE74A0 Offset: 0x1BE75A1 VA: 0x1BE74A0
	public bool get_multiLine() { }

	// RVA: 0x1BE74C0 Offset: 0x1BE75C1 VA: 0x1BE74C0
	public char get_asteriskChar() { }

	// RVA: 0x1BE74D0 Offset: 0x1BE75D1 VA: 0x1BE74D0
	public void set_asteriskChar(char value) { }

	// RVA: 0x1BE7550 Offset: 0x1BE7651 VA: 0x1BE7550
	public bool get_wasCanceled() { }

	// RVA: 0x1BE7560 Offset: 0x1BE7661 VA: 0x1BE7560
	protected void ClampPos(ref int pos) { }

	// RVA: 0x1BE7590 Offset: 0x1BE7691 VA: 0x1BE7590
	protected int get_caretPositionInternal() { }

	// RVA: 0x1BE75C0 Offset: 0x1BE76C1 VA: 0x1BE75C0
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x1BE75F0 Offset: 0x1BE76F1 VA: 0x1BE75F0
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x1BE7620 Offset: 0x1BE7721 VA: 0x1BE7620
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x1BE7650 Offset: 0x1BE7751 VA: 0x1BE7650
	private bool get_hasSelection() { }

	// RVA: 0x1BE76A0 Offset: 0x1BE77A1 VA: 0x1BE76A0
	public int get_caretPosition() { }

	// RVA: 0x1BE76D0 Offset: 0x1BE77D1 VA: 0x1BE76D0
	public void set_caretPosition(int value) { }

	// RVA: 0x1BE7850 Offset: 0x1BE7951 VA: 0x1BE7850
	public int get_selectionAnchorPosition() { }

	// RVA: 0x1BE7770 Offset: 0x1BE7871 VA: 0x1BE7770
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x1BE7880 Offset: 0x1BE7981 VA: 0x1BE7880
	public int get_selectionFocusPosition() { }

	// RVA: 0x1BE77E0 Offset: 0x1BE78E1 VA: 0x1BE77E0
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x1BE78B0 Offset: 0x1BE79B1 VA: 0x1BE78B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1BE7B20 Offset: 0x1BE7C21 VA: 0x1BE7B20 Slot: 7
	protected override void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0x45D90 Offset: 0x45E91 VA: 0x45D90
	// RVA: 0x1BE7FD0 Offset: 0x1BE80D1 VA: 0x1BE7FD0
	private IEnumerator CaretBlink() { }

	// RVA: 0x1BE8050 Offset: 0x1BE8151 VA: 0x1BE8050
	private void SetCaretVisible() { }

	// RVA: 0x1BE64B0 Offset: 0x1BE65B1 VA: 0x1BE64B0
	private void SetCaretActive() { }

	// RVA: 0x1BE80A0 Offset: 0x1BE81A1 VA: 0x1BE80A0
	private void UpdateCaretMaterial() { }

	// RVA: 0x1BE81D0 Offset: 0x1BE82D1 VA: 0x1BE81D0
	protected void OnFocus() { }

	// RVA: 0x1BE8210 Offset: 0x1BE8311 VA: 0x1BE8210
	protected void SelectAll() { }

	// RVA: 0x1BE8250 Offset: 0x1BE8351 VA: 0x1BE8250
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x1BE8310 Offset: 0x1BE8411 VA: 0x1BE8310
	public void MoveTextStart(bool shift) { }

	// RVA: 0x1BE83B0 Offset: 0x1BE84B1 VA: 0x1BE83B0
	private static string get_clipboard() { }

	// RVA: 0x1BE83C0 Offset: 0x1BE84C1 VA: 0x1BE83C0
	private static void set_clipboard(string value) { }

	// RVA: 0x1BE83D0 Offset: 0x1BE84D1 VA: 0x1BE83D0
	private bool TouchScreenKeyboardShouldBeUsed() { }

	// RVA: 0x1BE8410 Offset: 0x1BE8511 VA: 0x1BE8410
	private bool InPlaceEditing() { }

	// RVA: 0x1BE8460 Offset: 0x1BE8561 VA: 0x1BE8460
	private bool InPlaceEditingChanged() { }

	// RVA: 0x1BE84A0 Offset: 0x1BE85A1 VA: 0x1BE84A0
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x1BE8590 Offset: 0x1BE8691 VA: 0x1BE8590 Slot: 61
	protected virtual void LateUpdate() { }

	[ObsoleteAttribute] // RVA: 0x45E00 Offset: 0x45F01 VA: 0x45E00
	// RVA: 0x1BE9B50 Offset: 0x1BE9C51 VA: 0x1BE9B50
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x1BE9D80 Offset: 0x1BE9E81 VA: 0x1BE9D80
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x1BE9F80 Offset: 0x1BEA081 VA: 0x1BE9F80
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x1BEA380 Offset: 0x1BEA481 VA: 0x1BEA380
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1BEA480 Offset: 0x1BEA581 VA: 0x1BEA480 Slot: 62
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1BEA4B0 Offset: 0x1BEA5B1 VA: 0x1BEA4B0 Slot: 63
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x45E40 Offset: 0x45F41 VA: 0x45E40
	// RVA: 0x1BEA710 Offset: 0x1BEA811 VA: 0x1BEA710
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x1BEA7A0 Offset: 0x1BEA8A1 VA: 0x1BEA7A0 Slot: 64
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1BEA7D0 Offset: 0x1BEA8D1 VA: 0x1BEA7D0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1BEA9C0 Offset: 0x1BEAAC1 VA: 0x1BEA9C0
	protected InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x1BEB970 Offset: 0x1BEBA71 VA: 0x1BEB970
	private bool IsValidChar(char c) { }

	// RVA: 0x1BEB9E0 Offset: 0x1BEBAE1 VA: 0x1BEB9E0
	public void ProcessEvent(Event e) { }

	// RVA: 0x1BEB9F0 Offset: 0x1BEBAF1 VA: 0x1BEB9F0 Slot: 65
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x1BEB390 Offset: 0x1BEB491 VA: 0x1BEB390
	private string GetSelectedString() { }

	// RVA: 0x1BEBB50 Offset: 0x1BEBC51 VA: 0x1BEBB50
	private int FindtNextWordBegin() { }

	// RVA: 0x1BEB800 Offset: 0x1BEB901 VA: 0x1BEB800
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x1BEBC30 Offset: 0x1BEBD31 VA: 0x1BEBC30
	private int FindtPrevWordBegin() { }

	// RVA: 0x1BEB6B0 Offset: 0x1BEB7B1 VA: 0x1BEB6B0
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x1BEBD00 Offset: 0x1BEBE01 VA: 0x1BEBD00
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x1BEBE10 Offset: 0x1BEBF11 VA: 0x1BEBE10
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x1BEC330 Offset: 0x1BEC431 VA: 0x1BEC330
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x1BEB960 Offset: 0x1BEBA61 VA: 0x1BEB960
	private void MoveDown(bool shift) { }

	// RVA: 0x1BEC810 Offset: 0x1BEC911 VA: 0x1BEC810
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x1BEB950 Offset: 0x1BEBA51 VA: 0x1BEB950
	private void MoveUp(bool shift) { }

	// RVA: 0x1BEC970 Offset: 0x1BECA71 VA: 0x1BEC970
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x1BEB450 Offset: 0x1BEB551 VA: 0x1BEB450
	private void Delete() { }

	// RVA: 0x1BEB1B0 Offset: 0x1BEB2B1 VA: 0x1BEB1B0
	private void ForwardSpace() { }

	// RVA: 0x1BEAF70 Offset: 0x1BEB071 VA: 0x1BEAF70
	private void Backspace() { }

	// RVA: 0x1BECAD0 Offset: 0x1BECBD1 VA: 0x1BECAD0
	private void Insert(char c) { }

	// RVA: 0x1BEB660 Offset: 0x1BEB761 VA: 0x1BEB660
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x1BE9AC0 Offset: 0x1BE9BC1 VA: 0x1BE9AC0
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x1BE5E90 Offset: 0x1BE5F91 VA: 0x1BE5E90
	private void SendOnValueChanged() { }

	// RVA: 0x1BECC50 Offset: 0x1BECD51 VA: 0x1BECC50
	protected void SendOnSubmit() { }

	// RVA: 0x1BECCE0 Offset: 0x1BECDE1 VA: 0x1BECCE0 Slot: 66
	protected virtual void Append(string input) { }

	// RVA: 0x1BECDA0 Offset: 0x1BECEA1 VA: 0x1BECDA0 Slot: 67
	protected virtual void Append(char input) { }

	// RVA: 0x1BE5F20 Offset: 0x1BE6021 VA: 0x1BE5F20
	protected void UpdateLabel() { }

	// RVA: 0x1BEDFD0 Offset: 0x1BEE0D1 VA: 0x1BEDFD0
	private bool IsSelectionVisible() { }

	// RVA: 0x1BEE080 Offset: 0x1BEE181 VA: 0x1BEE080
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x1BEA200 Offset: 0x1BEA301 VA: 0x1BEA200
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x1BED050 Offset: 0x1BED151 VA: 0x1BED050
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x1BEE1E0 Offset: 0x1BEE2E1 VA: 0x1BEE1E0
	public void ForceLabelUpdate() { }

	// RVA: 0x1BE6660 Offset: 0x1BE6761 VA: 0x1BE6660
	private void MarkGeometryAsDirty() { }

	// RVA: 0x1BEE1F0 Offset: 0x1BEE2F1 VA: 0x1BEE1F0 Slot: 68
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1BEE680 Offset: 0x1BEE781 VA: 0x1BEE680 Slot: 69
	public virtual void LayoutComplete() { }

	// RVA: 0x1BEE690 Offset: 0x1BEE791 VA: 0x1BEE690 Slot: 70
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1BEE200 Offset: 0x1BEE301 VA: 0x1BEE200
	private void UpdateGeometry() { }

	// RVA: 0x1BE8FC0 Offset: 0x1BE90C1 VA: 0x1BE8FC0
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x1BEE6A0 Offset: 0x1BEE7A1 VA: 0x1BEE6A0
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x1BEE8B0 Offset: 0x1BEE9B1 VA: 0x1BEE8B0
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x1BEF740 Offset: 0x1BEF841 VA: 0x1BEF740
	private void CreateCursorVerts() { }

	// RVA: 0x1BEEF80 Offset: 0x1BEF081 VA: 0x1BEEF80
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x1BE9440 Offset: 0x1BE9541 VA: 0x1BE9440
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x1BEF910 Offset: 0x1BEFA11 VA: 0x1BEF910
	public void ActivateInputField() { }

	// RVA: 0x1BE8B90 Offset: 0x1BE8C91 VA: 0x1BE8B90
	private void ActivateInputFieldInternal() { }

	// RVA: 0x1BEFA40 Offset: 0x1BEFB41 VA: 0x1BEFA40 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1BEFA90 Offset: 0x1BEFB91 VA: 0x1BEFA90 Slot: 71
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1BE7D90 Offset: 0x1BE7E91 VA: 0x1BE7D90
	public void DeactivateInputField() { }

	// RVA: 0x1BEFAA0 Offset: 0x1BEFBA1 VA: 0x1BEFAA0 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1BEFAD0 Offset: 0x1BEFBD1 VA: 0x1BEFAD0 Slot: 72
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1BE7030 Offset: 0x1BE7131 VA: 0x1BE7030
	private void EnforceContentType() { }

	// RVA: 0x1BE57D0 Offset: 0x1BE58D1 VA: 0x1BE57D0
	private void EnforceTextHOverflow() { }

	// RVA: 0x1BE7200 Offset: 0x1BE7301 VA: 0x1BE7200
	private void SetToCustomIfContentTypeIsNot(InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x1BE7310 Offset: 0x1BE7411 VA: 0x1BE7310
	private void SetToCustom() { }

	// RVA: 0x1BEFB30 Offset: 0x1BEFC31 VA: 0x1BEFB30 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x1BEFB70 Offset: 0x1BEFC71 VA: 0x1BEFB70 Slot: 73
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1BEFB80 Offset: 0x1BEFC81 VA: 0x1BEFB80 Slot: 74
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1BEFB90 Offset: 0x1BEFC91 VA: 0x1BEFB90 Slot: 75
	public virtual float get_minWidth() { }

	// RVA: 0x1BEFBA0 Offset: 0x1BEFCA1 VA: 0x1BEFBA0 Slot: 76
	public virtual float get_preferredWidth() { }

	// RVA: 0x1BEFD00 Offset: 0x1BEFE01 VA: 0x1BEFD00 Slot: 77
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1BEFD10 Offset: 0x1BEFE11 VA: 0x1BEFD10 Slot: 78
	public virtual float get_minHeight() { }

	// RVA: 0x1BEFD20 Offset: 0x1BEFE21 VA: 0x1BEFD20 Slot: 79
	public virtual float get_preferredHeight() { }

	// RVA: 0x1BEFEA0 Offset: 0x1BEFFA1 VA: 0x1BEFEA0 Slot: 80
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1BEFEB0 Offset: 0x1BEFFB1 VA: 0x1BEFEB0 Slot: 81
	public virtual int get_layoutPriority() { }

	// RVA: 0x1BEFEC0 Offset: 0x1BEFFC1 VA: 0x1BEFEC0
	private static void .cctor() { }

	// RVA: 0x1BEFF60 Offset: 0x1BF0061 VA: 0x1BEFF60 Slot: 46
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

