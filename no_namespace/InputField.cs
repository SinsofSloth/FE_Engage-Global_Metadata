// Namespace: 
public enum InputField.ContentType // TypeDefIndex: 4283
{
	// Fields
	public int value__; // 0x0
	public const InputField.ContentType Standard = 0;
	public const InputField.ContentType Autocorrected = 1;
	public const InputField.ContentType IntegerNumber = 2;
	public const InputField.ContentType DecimalNumber = 3;
	public const InputField.ContentType Alphanumeric = 4;
	public const InputField.ContentType Name = 5;
	public const InputField.ContentType EmailAddress = 6;
	public const InputField.ContentType Password = 7;
	public const InputField.ContentType Pin = 8;
	public const InputField.ContentType Custom = 9;
}

// Namespace: 
public enum InputField.InputType // TypeDefIndex: 4284
{
	// Fields
	public int value__; // 0x0
	public const InputField.InputType Standard = 0;
	public const InputField.InputType AutoCorrect = 1;
	public const InputField.InputType Password = 2;
}

// Namespace: 
public enum InputField.CharacterValidation // TypeDefIndex: 4285
{
	// Fields
	public int value__; // 0x0
	public const InputField.CharacterValidation None = 0;
	public const InputField.CharacterValidation Integer = 1;
	public const InputField.CharacterValidation Decimal = 2;
	public const InputField.CharacterValidation Alphanumeric = 3;
	public const InputField.CharacterValidation Name = 4;
	public const InputField.CharacterValidation EmailAddress = 5;
}

// Namespace: 
public enum InputField.LineType // TypeDefIndex: 4286
{
	// Fields
	public int value__; // 0x0
	public const InputField.LineType SingleLine = 0;
	public const InputField.LineType MultiLineSubmit = 1;
	public const InputField.LineType MultiLineNewline = 2;
}

// Namespace: 
public sealed class InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 4287
{
	// Methods

	// RVA: 0x1BFD820 Offset: 0x1BFD921 VA: 0x1BFD820
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BFD840 Offset: 0x1BFD941 VA: 0x1BFD840 Slot: 13
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0x1BFDBE0 Offset: 0x1BFDCE1 VA: 0x1BFDBE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0x1BFDCB0 Offset: 0x1BFDDB1 VA: 0x1BFDCB0 Slot: 15
	public virtual char EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[Serializable]
public class InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 4288
{
	// Methods

	// RVA: 0x1BFDCE0 Offset: 0x1BFDDE1 VA: 0x1BFDCE0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 4289
{
	// Methods

	// RVA: 0x1BFD7C0 Offset: 0x1BFD8C1 VA: 0x1BFD7C0
	public void .ctor() { }
}

// Namespace: 
protected enum InputField.EditState // TypeDefIndex: 4290
{
	// Fields
	public int value__; // 0x0
	public const InputField.EditState Continue = 0;
	public const InputField.EditState Finish = 1;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x42B80 Offset: 0x42C81 VA: 0x42B80
private sealed class InputField.<CaretBlink>d__161 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4291
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InputField <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x45EB0 Offset: 0x45FB1 VA: 0x45EB0
	// RVA: 0x1BFD2A0 Offset: 0x1BFD3A1 VA: 0x1BFD2A0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x45EC0 Offset: 0x45FC1 VA: 0x45EC0
	// RVA: 0x1BFD2D0 Offset: 0x1BFD3D1 VA: 0x1BFD2D0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1BFD2E0 Offset: 0x1BFD3E1 VA: 0x1BFD2E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x45ED0 Offset: 0x45FD1 VA: 0x45ED0
	// RVA: 0x1BFD410 Offset: 0x1BFD511 VA: 0x1BFD410 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x45EE0 Offset: 0x45FE1 VA: 0x45EE0
	// RVA: 0x1BFD420 Offset: 0x1BFD521 VA: 0x1BFD420 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x45EF0 Offset: 0x45FF1 VA: 0x45EF0
	// RVA: 0x1BFD460 Offset: 0x1BFD561 VA: 0x1BFD460 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x42B90 Offset: 0x42C91 VA: 0x42B90
private sealed class InputField.<MouseDragOutsideRect>d__183 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4292
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PointerEventData eventData; // 0x20
	public InputField <>4__this; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x45F00 Offset: 0x46001 VA: 0x45F00
	// RVA: 0x1BFD470 Offset: 0x1BFD571 VA: 0x1BFD470
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x45F10 Offset: 0x46011 VA: 0x45F10
	// RVA: 0x1BFD4A0 Offset: 0x1BFD5A1 VA: 0x1BFD4A0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1BFD4B0 Offset: 0x1BFD5B1 VA: 0x1BFD4B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x45F20 Offset: 0x46021 VA: 0x45F20
	// RVA: 0x1BFD760 Offset: 0x1BFD861 VA: 0x1BFD760 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x45F30 Offset: 0x46031 VA: 0x45F30
	// RVA: 0x1BFD770 Offset: 0x1BFD871 VA: 0x1BFD770 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x45F40 Offset: 0x46041 VA: 0x45F40
	// RVA: 0x1BFD7B0 Offset: 0x1BFD8B1 VA: 0x1BFD7B0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

