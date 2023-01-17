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
public class TMP_Dropdown.DropdownEvent : UnityEvent<int> // TypeDefIndex: 7358
{
	// Methods

	// RVA: 0x1C0FD10 Offset: 0x1C0FE11 VA: 0x1C0FD10
	public void .ctor() { }
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
public class TMP_InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 7392
{
	// Methods

	// RVA: 0x1C10750 Offset: 0x1C10851 VA: 0x1C10750
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
protected enum TMP_InputField.EditState // TypeDefIndex: 7396
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.EditState Continue = 0;
	public const TMP_InputField.EditState Finish = 1;
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
[DebuggerDisplayAttribute] // RVA: 0x4CFF0 Offset: 0x4D0F1 VA: 0x4CFF0
internal struct TMP_Text.UnicodeChar // TypeDefIndex: 7450
{
	// Fields
	public int unicode; // 0x0
	public int stringIndex; // 0x4
	public int length; // 0x8
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
private struct TMP_TextUtilities.LineSegment // TypeDefIndex: 7464
{
	// Fields
	public Vector3 Point1; // 0x0
	public Vector3 Point2; // 0xC

	// Methods

	// RVA: 0x1C11D80 Offset: 0x1C11E81 VA: 0x1C11D80
	public void .ctor(Vector3 p1, Vector3 p2) { }
}

