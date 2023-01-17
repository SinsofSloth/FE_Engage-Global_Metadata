// Namespace: UnityEngine
internal struct TouchScreenKeyboard_InternalConstructorHelperArguments // TypeDefIndex: 3639
{
	// Fields
	public uint keyboardType; // 0x0
	public uint autocorrection; // 0x4
	public uint multiline; // 0x8
	public uint secure; // 0xC
	public uint alert; // 0x10
	public int characterLimit; // 0x14
}

// Namespace: UnityEngine
[NativeConditionalAttribute] // RVA: 0x43EF70 Offset: 0x43F071 VA: 0x43EF70
[NativeHeaderAttribute] // RVA: 0x43EF70 Offset: 0x43F071 VA: 0x43EF70
[NativeHeaderAttribute] // RVA: 0x43EF70 Offset: 0x43F071 VA: 0x43EF70
public class TouchScreenKeyboard // TypeDefIndex: 3641
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public static bool isSupported { get; }
	public static bool isInPlaceEditingAllowed { get; }
	public string text { get; set; }
	public static bool hideInput { set; }
	public bool active { get; set; }
	public TouchScreenKeyboard.Status status { get; }
	public int characterLimit { set; }
	public bool canGetSelection { get; }
	public bool canSetSelection { get; }
	public RangeInt selection { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x4512F0 Offset: 0x4513F1 VA: 0x4512F0
	// RVA: 0x3846280 Offset: 0x3846381 VA: 0x3846280
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x38462D0 Offset: 0x38463D1 VA: 0x38462D0
	private void Destroy() { }

	// RVA: 0x3846390 Offset: 0x3846491 VA: 0x3846390 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3846400 Offset: 0x3846501 VA: 0x3846400
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunctionAttribute] // RVA: 0x451340 Offset: 0x451441 VA: 0x451340
	// RVA: 0x3846570 Offset: 0x3846671 VA: 0x3846570
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x38465D0 Offset: 0x38466D1 VA: 0x38465D0
	public static bool get_isSupported() { }

	// RVA: 0x3846670 Offset: 0x3846771 VA: 0x3846670
	public static bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x3846680 Offset: 0x3846781 VA: 0x3846680
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[NativeNameAttribute] // RVA: 0x451380 Offset: 0x451481 VA: 0x451380
	// RVA: 0x3846740 Offset: 0x3846841 VA: 0x3846740
	public string get_text() { }

	[NativeNameAttribute] // RVA: 0x4513C0 Offset: 0x4514C1 VA: 0x4513C0
	// RVA: 0x3846790 Offset: 0x3846891 VA: 0x3846790
	public void set_text(string value) { }

	[NativeNameAttribute] // RVA: 0x451400 Offset: 0x451501 VA: 0x451400
	// RVA: 0x38467E0 Offset: 0x38468E1 VA: 0x38467E0
	public static void set_hideInput(bool value) { }

	[NativeNameAttribute] // RVA: 0x451440 Offset: 0x451541 VA: 0x451440
	// RVA: 0x3846830 Offset: 0x3846931 VA: 0x3846830
	public bool get_active() { }

	[NativeNameAttribute] // RVA: 0x451480 Offset: 0x451581 VA: 0x451480
	// RVA: 0x3846880 Offset: 0x3846981 VA: 0x3846880
	public void set_active(bool value) { }

	[NativeNameAttribute] // RVA: 0x4514C0 Offset: 0x4515C1 VA: 0x4514C0
	// RVA: 0x38468D0 Offset: 0x38469D1 VA: 0x38468D0
	public TouchScreenKeyboard.Status get_status() { }

	[NativeNameAttribute] // RVA: 0x451500 Offset: 0x451601 VA: 0x451500
	// RVA: 0x3846920 Offset: 0x3846A21 VA: 0x3846920
	public void set_characterLimit(int value) { }

	[NativeNameAttribute] // RVA: 0x451540 Offset: 0x451641 VA: 0x451540
	// RVA: 0x3846970 Offset: 0x3846A71 VA: 0x3846970
	public bool get_canGetSelection() { }

	[NativeNameAttribute] // RVA: 0x451580 Offset: 0x451681 VA: 0x451580
	// RVA: 0x38469C0 Offset: 0x3846AC1 VA: 0x38469C0
	public bool get_canSetSelection() { }

	// RVA: 0x3846A10 Offset: 0x3846B11 VA: 0x3846A10
	public RangeInt get_selection() { }

	// RVA: 0x3846AC0 Offset: 0x3846BC1 VA: 0x3846AC0
	public void set_selection(RangeInt value) { }

	// RVA: 0x3846A70 Offset: 0x3846B71 VA: 0x3846A70
	private static void GetSelection(out int start, out int length) { }

	// RVA: 0x3846BB0 Offset: 0x3846CB1 VA: 0x3846BB0
	private static void SetSelection(int start, int length) { }
}

