// Namespace: 
public enum TMP_Compatibility.AnchorPositions // TypeDefIndex: 7343
{
	// Fields
	public int value__; // 0x0
	public const TMP_Compatibility.AnchorPositions TopLeft = 0;
	public const TMP_Compatibility.AnchorPositions Top = 1;
	public const TMP_Compatibility.AnchorPositions TopRight = 2;
	public const TMP_Compatibility.AnchorPositions Left = 3;
	public const TMP_Compatibility.AnchorPositions Center = 4;
	public const TMP_Compatibility.AnchorPositions Right = 5;
	public const TMP_Compatibility.AnchorPositions BottomLeft = 6;
	public const TMP_Compatibility.AnchorPositions Bottom = 7;
	public const TMP_Compatibility.AnchorPositions BottomRight = 8;
	public const TMP_Compatibility.AnchorPositions BaseLine = 9;
	public const TMP_Compatibility.AnchorPositions None = 10;
}

// Namespace: 
public struct TMP_DefaultControls.Resources // TypeDefIndex: 7353
{
	// Fields
	public Sprite standard; // 0x0
	public Sprite background; // 0x8
	public Sprite inputField; // 0x10
	public Sprite knob; // 0x18
	public Sprite checkmark; // 0x20
	public Sprite dropdown; // 0x28
	public Sprite mask; // 0x30
}

// Namespace: 
protected internal class TMP_Dropdown.DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler // TypeDefIndex: 7355
{
	// Fields
	[SerializeField] // RVA: 0x4D4B0 Offset: 0x4D5B1 VA: 0x4D4B0
	private TMP_Text m_Text; // 0x18
	[SerializeField] // RVA: 0x4D4C0 Offset: 0x4D5C1 VA: 0x4D4C0
	private Image m_Image; // 0x20
	[SerializeField] // RVA: 0x4D4D0 Offset: 0x4D5D1 VA: 0x4D4D0
	private RectTransform m_RectTransform; // 0x28
	[SerializeField] // RVA: 0x4D4E0 Offset: 0x4D5E1 VA: 0x4D4E0
	private Toggle m_Toggle; // 0x30

	// Properties
	public TMP_Text text { get; set; }
	public Image image { get; set; }
	public RectTransform rectTransform { get; set; }
	public Toggle toggle { get; set; }

	// Methods

	// RVA: 0x1C0FD70 Offset: 0x1C0FE71 VA: 0x1C0FD70
	public TMP_Text get_text() { }

	// RVA: 0x1C0FD80 Offset: 0x1C0FE81 VA: 0x1C0FD80
	public void set_text(TMP_Text value) { }

	// RVA: 0x1C0FD90 Offset: 0x1C0FE91 VA: 0x1C0FD90
	public Image get_image() { }

	// RVA: 0x1C0FDA0 Offset: 0x1C0FEA1 VA: 0x1C0FDA0
	public void set_image(Image value) { }

	// RVA: 0x1C0FDB0 Offset: 0x1C0FEB1 VA: 0x1C0FDB0
	public RectTransform get_rectTransform() { }

	// RVA: 0x1C0FDC0 Offset: 0x1C0FEC1 VA: 0x1C0FDC0
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x1C0FDD0 Offset: 0x1C0FED1 VA: 0x1C0FDD0
	public Toggle get_toggle() { }

	// RVA: 0x1C0FDE0 Offset: 0x1C0FEE1 VA: 0x1C0FDE0
	public void set_toggle(Toggle value) { }

	// RVA: 0x1C0FDF0 Offset: 0x1C0FEF1 VA: 0x1C0FDF0 Slot: 6
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1C0FE80 Offset: 0x1C0FF81 VA: 0x1C0FE80 Slot: 7
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1C0FF40 Offset: 0x1C10041 VA: 0x1C0FF40
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_Dropdown.OptionData // TypeDefIndex: 7356
{
	// Fields
	[SerializeField] // RVA: 0x4D4F0 Offset: 0x4D5F1 VA: 0x4D4F0
	private string m_Text; // 0x10
	[SerializeField] // RVA: 0x4D500 Offset: 0x4D601 VA: 0x4D500
	private Sprite m_Image; // 0x18

	// Properties
	public string text { get; set; }
	public Sprite image { get; set; }

	// Methods

	// RVA: 0x1C0FF50 Offset: 0x1C10051 VA: 0x1C0FF50
	public string get_text() { }

	// RVA: 0x1C0FF60 Offset: 0x1C10061 VA: 0x1C0FF60
	public void set_text(string value) { }

	// RVA: 0x1C0FF70 Offset: 0x1C10071 VA: 0x1C0FF70
	public Sprite get_image() { }

	// RVA: 0x1C0FF80 Offset: 0x1C10081 VA: 0x1C0FF80
	public void set_image(Sprite value) { }

	// RVA: 0x1C0FF90 Offset: 0x1C10091 VA: 0x1C0FF90
	public void .ctor() { }

	// RVA: 0x1C0FFA0 Offset: 0x1C100A1 VA: 0x1C0FFA0
	public void .ctor(string text) { }

	// RVA: 0x1C0FFE0 Offset: 0x1C100E1 VA: 0x1C0FFE0
	public void .ctor(Sprite image) { }

	// RVA: 0x1C10020 Offset: 0x1C10121 VA: 0x1C10020
	public void .ctor(string text, Sprite image) { }
}

// Namespace: 
[Serializable]
public class TMP_Dropdown.OptionDataList // TypeDefIndex: 7357
{
	// Fields
	[SerializeField] // RVA: 0x4D510 Offset: 0x4D611 VA: 0x4D510
	private List<TMP_Dropdown.OptionData> m_Options; // 0x10

	// Properties
	public List<TMP_Dropdown.OptionData> options { get; set; }

	// Methods

	// RVA: 0x1C10070 Offset: 0x1C10171 VA: 0x1C10070
	public List<TMP_Dropdown.OptionData> get_options() { }

	// RVA: 0x1C10080 Offset: 0x1C10181 VA: 0x1C10080
	public void set_options(List<TMP_Dropdown.OptionData> value) { }

	// RVA: 0x1C10090 Offset: 0x1C10191 VA: 0x1C10090
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_Dropdown.DropdownEvent : UnityEvent<int> // TypeDefIndex: 7358
{
	// Methods

	// RVA: 0x1C0FD10 Offset: 0x1C0FE11 VA: 0x1C0FD10
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4CCC0 Offset: 0x4CDC1 VA: 0x4CCC0
private sealed class TMP_Dropdown.<>c__DisplayClass69_0 // TypeDefIndex: 7359
{
	// Fields
	public TMP_Dropdown.DropdownItem item; // 0x10
	public TMP_Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x1C0FB80 Offset: 0x1C0FC81 VA: 0x1C0FB80
	public void .ctor() { }

	// RVA: 0x1C0FB90 Offset: 0x1C0FC91 VA: 0x1C0FB90
	internal void <Show>b__0(bool x) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4CCD0 Offset: 0x4CDD1 VA: 0x4CCD0
private sealed class TMP_Dropdown.<DelayedDestroyDropdownList>d__81 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7360
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float delay; // 0x20
	public TMP_Dropdown <>4__this; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x4E6B0 Offset: 0x4E7B1 VA: 0x4E6B0
	// RVA: 0x1C0FBB0 Offset: 0x1C0FCB1 VA: 0x1C0FBB0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x4E6C0 Offset: 0x4E7C1 VA: 0x4E6C0
	// RVA: 0x1C0FBE0 Offset: 0x1C0FCE1 VA: 0x1C0FBE0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1C0FBF0 Offset: 0x1C0FCF1 VA: 0x1C0FBF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x4E6D0 Offset: 0x4E7D1 VA: 0x4E6D0
	// RVA: 0x1C0FCB0 Offset: 0x1C0FDB1 VA: 0x1C0FCB0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x4E6E0 Offset: 0x4E7E1 VA: 0x4E6E0
	// RVA: 0x1C0FCC0 Offset: 0x1C0FDC1 VA: 0x1C0FCC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x4E6F0 Offset: 0x4E7F1 VA: 0x4E6F0
	// RVA: 0x1C0FD00 Offset: 0x1C0FE01 VA: 0x1C0FD00 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4CCF0 Offset: 0x4CDF1 VA: 0x4CCF0
[Serializable]
private sealed class TMP_FontAsset.<>c // TypeDefIndex: 7363
{
	// Fields
	public static readonly TMP_FontAsset.<>c <>9; // 0x0
	public static Func<TMP_Character, uint> <>9__124_0; // 0x8
	public static Func<Glyph, uint> <>9__125_0; // 0x10

	// Methods

	// RVA: 0x1C10120 Offset: 0x1C10221 VA: 0x1C10120
	private static void .cctor() { }

	// RVA: 0x1C10190 Offset: 0x1C10291 VA: 0x1C10190
	public void .ctor() { }

	// RVA: 0x1C101A0 Offset: 0x1C102A1 VA: 0x1C101A0
	internal uint <SortCharacterTable>b__124_0(TMP_Character c) { }

	// RVA: 0x1C101B0 Offset: 0x1C102B1 VA: 0x1C101B0
	internal uint <SortGlyphTable>b__125_0(Glyph c) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4CD40 Offset: 0x4CE41 VA: 0x4CD40
[Serializable]
private sealed class TMP_FontFeatureTable.<>c // TypeDefIndex: 7379
{
	// Fields
	public static readonly TMP_FontFeatureTable.<>c <>9; // 0x0
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_0; // 0x8
	public static Func<TMP_GlyphPairAdjustmentRecord, uint> <>9__6_1; // 0x10

	// Methods

	// RVA: 0x1C101C0 Offset: 0x1C102C1 VA: 0x1C101C0
	private static void .cctor() { }

	// RVA: 0x1C10230 Offset: 0x1C10331 VA: 0x1C10230
	public void .ctor() { }

	// RVA: 0x1C10240 Offset: 0x1C10341 VA: 0x1C10240
	internal uint <SortGlyphPairAdjustmentRecords>b__6_0(TMP_GlyphPairAdjustmentRecord s) { }

	// RVA: 0x1C10250 Offset: 0x1C10351 VA: 0x1C10250
	internal uint <SortGlyphPairAdjustmentRecords>b__6_1(TMP_GlyphPairAdjustmentRecord s) { }
}

// Namespace: 
public enum TMP_InputField.ContentType // TypeDefIndex: 7386
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.ContentType Standard = 0;
	public const TMP_InputField.ContentType Autocorrected = 1;
	public const TMP_InputField.ContentType IntegerNumber = 2;
	public const TMP_InputField.ContentType DecimalNumber = 3;
	public const TMP_InputField.ContentType Alphanumeric = 4;
	public const TMP_InputField.ContentType Name = 5;
	public const TMP_InputField.ContentType EmailAddress = 6;
	public const TMP_InputField.ContentType Password = 7;
	public const TMP_InputField.ContentType Pin = 8;
	public const TMP_InputField.ContentType Custom = 9;
}

// Namespace: 
public enum TMP_InputField.InputType // TypeDefIndex: 7387
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.InputType Standard = 0;
	public const TMP_InputField.InputType AutoCorrect = 1;
	public const TMP_InputField.InputType Password = 2;
}

// Namespace: 
public enum TMP_InputField.CharacterValidation // TypeDefIndex: 7388
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.CharacterValidation None = 0;
	public const TMP_InputField.CharacterValidation Digit = 1;
	public const TMP_InputField.CharacterValidation Integer = 2;
	public const TMP_InputField.CharacterValidation Decimal = 3;
	public const TMP_InputField.CharacterValidation Alphanumeric = 4;
	public const TMP_InputField.CharacterValidation Name = 5;
	public const TMP_InputField.CharacterValidation Regex = 6;
	public const TMP_InputField.CharacterValidation EmailAddress = 7;
	public const TMP_InputField.CharacterValidation CustomValidator = 8;
}

// Namespace: 
public enum TMP_InputField.LineType // TypeDefIndex: 7389
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.LineType SingleLine = 0;
	public const TMP_InputField.LineType MultiLineSubmit = 1;
	public const TMP_InputField.LineType MultiLineNewline = 2;
}

// Namespace: 
public sealed class TMP_InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 7390
{
	// Methods

	// RVA: 0x1C107B0 Offset: 0x1C108B1 VA: 0x1C107B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C107D0 Offset: 0x1C108D1 VA: 0x1C107D0 Slot: 13
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0x1C10B70 Offset: 0x1C10C71 VA: 0x1C10B70 Slot: 14
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0x1C10C40 Offset: 0x1C10D41 VA: 0x1C10C40 Slot: 15
	public virtual char EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 7391
{
	// Methods

	// RVA: 0x1C10CD0 Offset: 0x1C10DD1 VA: 0x1C10CD0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 7392
{
	// Methods

	// RVA: 0x1C10750 Offset: 0x1C10851 VA: 0x1C10750
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.SelectionEvent : UnityEvent<string> // TypeDefIndex: 7393
{
	// Methods

	// RVA: 0x1C10C70 Offset: 0x1C10D71 VA: 0x1C10C70
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 7394
{
	// Methods

	// RVA: 0x1C10D30 Offset: 0x1C10E31 VA: 0x1C10D30
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 7395
{
	// Methods

	// RVA: 0x1C10D90 Offset: 0x1C10E91 VA: 0x1C10D90
	public void .ctor() { }
}

// Namespace: 
protected enum TMP_InputField.EditState // TypeDefIndex: 7396
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.EditState Continue = 0;
	public const TMP_InputField.EditState Finish = 1;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4CDA0 Offset: 0x4CEA1 VA: 0x4CDA0
private sealed class TMP_InputField.<CaretBlink>d__276 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7397
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_InputField <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x4E7E0 Offset: 0x4E8E1 VA: 0x4E7E0
	// RVA: 0x1C10260 Offset: 0x1C10361 VA: 0x1C10260
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x4E7F0 Offset: 0x4E8F1 VA: 0x4E7F0
	// RVA: 0x1C10290 Offset: 0x1C10391 VA: 0x1C10290 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1C102A0 Offset: 0x1C103A1 VA: 0x1C102A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x4E800 Offset: 0x4E901 VA: 0x4E800
	// RVA: 0x1C103E0 Offset: 0x1C104E1 VA: 0x1C103E0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x4E810 Offset: 0x4E911 VA: 0x4E810
	// RVA: 0x1C103F0 Offset: 0x1C104F1 VA: 0x1C103F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x4E820 Offset: 0x4E921 VA: 0x4E820
	// RVA: 0x1C10430 Offset: 0x1C10531 VA: 0x1C10430 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4CDB0 Offset: 0x4CEB1 VA: 0x4CDB0
private sealed class TMP_InputField.<MouseDragOutsideRect>d__294 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7398
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_InputField <>4__this; // 0x20
	public PointerEventData eventData; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x4E830 Offset: 0x4E931 VA: 0x4E830
	// RVA: 0x1C10440 Offset: 0x1C10541 VA: 0x1C10440
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x4E840 Offset: 0x4E941 VA: 0x4E840
	// RVA: 0x1C10470 Offset: 0x1C10571 VA: 0x1C10470 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1C10480 Offset: 0x1C10581 VA: 0x1C10480 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x4E850 Offset: 0x4E951 VA: 0x4E850
	// RVA: 0x1C106F0 Offset: 0x1C107F1 VA: 0x1C106F0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x4E860 Offset: 0x4E961 VA: 0x4E860
	// RVA: 0x1C10700 Offset: 0x1C10801 VA: 0x1C10700 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x4E870 Offset: 0x4E971 VA: 0x4E870
	// RVA: 0x1C10740 Offset: 0x1C10841 VA: 0x1C10740 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4CDC0 Offset: 0x4CEC1 VA: 0x4CDC0
[Serializable]
private sealed class TMP_ListPool.<>c<T> // TypeDefIndex: 7403
{
	// Fields
	public static readonly TMP_ListPool.<>c<T> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33730 Offset: 0x2B33831 VA: 0x2B33730
	|-TMP_ListPool.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33810 Offset: 0x2B33911 VA: 0x2B33810
	|-TMP_ListPool.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__3_0(List<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33820 Offset: 0x2B33921 VA: 0x2B33820
	|-TMP_ListPool.<>c<object>.<.cctor>b__3_0
	*/
}

// Namespace: 
private class TMP_MaterialManager.FallbackMaterial // TypeDefIndex: 7405
{
	// Fields
	public long fallbackID; // 0x10
	public Material sourceMaterial; // 0x18
	internal int sourceMaterialCRC; // 0x20
	public Material fallbackMaterial; // 0x28
	public int count; // 0x30

	// Methods

	// RVA: 0x1C11030 Offset: 0x1C11131 VA: 0x1C11030
	public void .ctor() { }
}

// Namespace: 
private class TMP_MaterialManager.MaskingMaterial // TypeDefIndex: 7406
{
	// Fields
	public Material baseMaterial; // 0x10
	public Material stencilMaterial; // 0x18
	public int count; // 0x20
	public int stencilID; // 0x24

	// Methods

	// RVA: 0x1C11040 Offset: 0x1C11141 VA: 0x1C11040
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4CDD0 Offset: 0x4CED1 VA: 0x4CDD0
private sealed class TMP_MaterialManager.<>c__DisplayClass9_0 // TypeDefIndex: 7407
{
	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x1C10FA0 Offset: 0x1C110A1 VA: 0x1C10FA0
	public void .ctor() { }

	// RVA: 0x1C10FB0 Offset: 0x1C110B1 VA: 0x1C10FB0
	internal bool <GetBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4CDE0 Offset: 0x4CEE1 VA: 0x4CDE0
private sealed class TMP_MaterialManager.<>c__DisplayClass11_0 // TypeDefIndex: 7408
{
	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x1C10DF0 Offset: 0x1C10EF1 VA: 0x1C10DF0
	public void .ctor() { }

	// RVA: 0x1C10E00 Offset: 0x1C10F01 VA: 0x1C10E00
	internal bool <AddMaskingMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4CDF0 Offset: 0x4CEF1 VA: 0x4CDF0
private sealed class TMP_MaterialManager.<>c__DisplayClass12_0 // TypeDefIndex: 7409
{
	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x1C10E80 Offset: 0x1C10F81 VA: 0x1C10E80
	public void .ctor() { }

	// RVA: 0x1C10E90 Offset: 0x1C10F91 VA: 0x1C10E90
	internal bool <RemoveStencilMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4CE00 Offset: 0x4CF01 VA: 0x4CE00
private sealed class TMP_MaterialManager.<>c__DisplayClass13_0 // TypeDefIndex: 7410
{
	// Fields
	public Material baseMaterial; // 0x10

	// Methods

	// RVA: 0x1C10F10 Offset: 0x1C11011 VA: 0x1C10F10
	public void .ctor() { }

	// RVA: 0x1C10F20 Offset: 0x1C11021 VA: 0x1C10F20
	internal bool <ReleaseBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }
}

// Namespace: 
public class TMP_Settings.LineBreakingTable // TypeDefIndex: 7422
{
	// Fields
	public Dictionary<int, char> leadingCharacters; // 0x10
	public Dictionary<int, char> followingCharacters; // 0x18

	// Methods

	// RVA: 0x1C11050 Offset: 0x1C11151 VA: 0x1C11050
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4CEA0 Offset: 0x4CFA1 VA: 0x4CEA0
private sealed class TMP_SpriteAnimator.<DoSpriteAnimationInternal>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7426
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_SpriteAnimator <>4__this; // 0x20
	public int start; // 0x28
	public int end; // 0x2C
	public TMP_SpriteAsset spriteAsset; // 0x30
	public int currentCharacter; // 0x38
	public int framerate; // 0x3C
	private int <currentFrame>5__2; // 0x40
	private TMP_CharacterInfo <charInfo>5__3; // 0x48
	private int <materialIndex>5__4; // 0x1C0
	private int <vertexIndex>5__5; // 0x1C4
	private TMP_MeshInfo <meshInfo>5__6; // 0x1C8
	private float <baseSpriteScale>5__7; // 0x218
	private float <elapsedTime>5__8; // 0x21C
	private float <targetTime>5__9; // 0x220

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x4E910 Offset: 0x4EA11 VA: 0x4E910
	// RVA: 0x1C11060 Offset: 0x1C11161 VA: 0x1C11060
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x4E920 Offset: 0x4EA21 VA: 0x4E920
	// RVA: 0x1C11090 Offset: 0x1C11191 VA: 0x1C11090 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1C110A0 Offset: 0x1C111A1 VA: 0x1C110A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x4E930 Offset: 0x4EA31 VA: 0x4E930
	// RVA: 0x1C118C0 Offset: 0x1C119C1 VA: 0x1C118C0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x4E940 Offset: 0x4EA41 VA: 0x4E940
	// RVA: 0x1C118D0 Offset: 0x1C119D1 VA: 0x1C118D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x4E950 Offset: 0x4EA51 VA: 0x4E950
	// RVA: 0x1C11910 Offset: 0x1C11A11 VA: 0x1C11910 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4CEC0 Offset: 0x4CFC1 VA: 0x4CEC0
[Serializable]
private sealed class TMP_SpriteAsset.<>c // TypeDefIndex: 7428
{
	// Fields
	public static readonly TMP_SpriteAsset.<>c <>9; // 0x0
	public static Func<TMP_SpriteGlyph, uint> <>9__40_0; // 0x8
	public static Func<TMP_SpriteCharacter, uint> <>9__41_0; // 0x10

	// Methods

	// RVA: 0x1C11920 Offset: 0x1C11A21 VA: 0x1C11920
	private static void .cctor() { }

	// RVA: 0x1C11990 Offset: 0x1C11A91 VA: 0x1C11990
	public void .ctor() { }

	// RVA: 0x1C119A0 Offset: 0x1C11AA1 VA: 0x1C119A0
	internal uint <SortGlyphTable>b__40_0(TMP_SpriteGlyph item) { }

	// RVA: 0x1C119B0 Offset: 0x1C11AB1 VA: 0x1C119B0
	internal uint <SortCharacterTable>b__41_0(TMP_SpriteCharacter c) { }
}

// Namespace: 
protected struct TMP_Text.CharacterSubstitution // TypeDefIndex: 7448
{
	// Fields
	public int index; // 0x0
	public uint unicode; // 0x4

	// Methods

	// RVA: 0x1C11A50 Offset: 0x1C11B51 VA: 0x1C11A50
	public void .ctor(int index, uint unicode) { }
}

// Namespace: 
internal enum TMP_Text.TextInputSources // TypeDefIndex: 7449
{
	// Fields
	public int value__; // 0x0
	public const TMP_Text.TextInputSources TextInputBox = 0;
	public const TMP_Text.TextInputSources SetText = 1;
	public const TMP_Text.TextInputSources SetTextArray = 2;
	public const TMP_Text.TextInputSources TextString = 3;
}

// Namespace: 
[DebuggerDisplayAttribute] // RVA: 0x4CFF0 Offset: 0x4D0F1 VA: 0x4CFF0
internal struct TMP_Text.UnicodeChar // TypeDefIndex: 7450
{
	// Fields
	public int unicode; // 0x0
	public int stringIndex; // 0x4
	public int length; // 0x8
}

// Namespace: 
protected struct TMP_Text.SpecialCharacter // TypeDefIndex: 7451
{
	// Fields
	public TMP_Character character; // 0x0
	public TMP_FontAsset fontAsset; // 0x8
	public Material material; // 0x10
	public int materialIndex; // 0x18

	// Methods

	// RVA: 0x1C11A60 Offset: 0x1C11B61 VA: 0x1C11A60
	public void .ctor(TMP_Character character, int materialIndex) { }
}

// Namespace: 
[DefaultMemberAttribute] // RVA: 0x4D030 Offset: 0x4D131 VA: 0x4D030
private struct TMP_Text.TextBackingContainer // TypeDefIndex: 7452
{
	// Fields
	private uint[] m_Array; // 0x0
	private int m_Count; // 0x8

	// Properties
	public int Capacity { get; }
	public int Count { get; set; }
	public uint Item { get; set; }

	// Methods

	// RVA: 0x1C11B80 Offset: 0x1C11C81 VA: 0x1C11B80
	public int get_Capacity() { }

	// RVA: 0x1C11B90 Offset: 0x1C11C91 VA: 0x1C11B90
	public int get_Count() { }

	// RVA: 0x1C11BA0 Offset: 0x1C11CA1 VA: 0x1C11BA0
	public void set_Count(int value) { }

	// RVA: 0x1C11BB0 Offset: 0x1C11CB1 VA: 0x1C11BB0
	public uint get_Item(int index) { }

	// RVA: 0x1C11BF0 Offset: 0x1C11CF1 VA: 0x1C11BF0
	public void set_Item(int index, uint value) { }

	// RVA: 0x1C11D10 Offset: 0x1C11E11 VA: 0x1C11D10
	public void .ctor(int size) { }

	// RVA: 0x1C11CA0 Offset: 0x1C11DA1 VA: 0x1C11CA0
	public void Resize(int size) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x4D070 Offset: 0x4D171 VA: 0x4D070
[Serializable]
private sealed class TMP_Text.<>c // TypeDefIndex: 7453
{
	// Fields
	public static readonly TMP_Text.<>c <>9; // 0x0
	public static Action<TMP_TextInfo> <>9__622_0; // 0x8

	// Methods

	// RVA: 0x1C119C0 Offset: 0x1C11AC1 VA: 0x1C119C0
	private static void .cctor() { }

	// RVA: 0x1C11A30 Offset: 0x1C11B31 VA: 0x1C11A30
	public void .ctor() { }

	// RVA: 0x1C11A40 Offset: 0x1C11B41 VA: 0x1C11A40
	internal void <.ctor>b__622_0(TMP_TextInfo <p0>) { }
}

// Namespace: 
private struct TMP_TextUtilities.LineSegment // TypeDefIndex: 7464
{
	// Fields
	public Vector3 Point1; // 0x0
	public Vector3 Point2; // 0xC

	// Methods

	// RVA: 0x1C11D80 Offset: 0x1C11E81 VA: 0x1C11D80
	public void .ctor(Vector3 p1, Vector3 p2) { }
}

