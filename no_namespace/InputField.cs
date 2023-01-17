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
public enum InputField.LineType // TypeDefIndex: 4286
{
	// Fields
	public int value__; // 0x0
	public const InputField.LineType SingleLine = 0;
	public const InputField.LineType MultiLineSubmit = 1;
	public const InputField.LineType MultiLineNewline = 2;
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
protected enum InputField.EditState // TypeDefIndex: 4290
{
	// Fields
	public int value__; // 0x0
	public const InputField.EditState Continue = 0;
	public const InputField.EditState Finish = 1;
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

