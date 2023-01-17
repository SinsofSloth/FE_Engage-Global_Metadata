// Namespace: 
public enum Scrollbar.Direction // TypeDefIndex: 4336
{
	// Fields
	public int value__; // 0x0
	public const Scrollbar.Direction LeftToRight = 0;
	public const Scrollbar.Direction RightToLeft = 1;
	public const Scrollbar.Direction BottomToTop = 2;
	public const Scrollbar.Direction TopToBottom = 3;
}

// Namespace: 
[Serializable]
public class Scrollbar.ScrollEvent : UnityEvent<float> // TypeDefIndex: 4337
{
	// Methods

	// RVA: 0x1C00B60 Offset: 0x1C00C61 VA: 0x1C00B60
	public void .ctor() { }
}

// Namespace: 
private enum Scrollbar.Axis // TypeDefIndex: 4338
{
	// Fields
	public int value__; // 0x0
	public const Scrollbar.Axis Horizontal = 0;
	public const Scrollbar.Axis Vertical = 1;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x43330 Offset: 0x43431 VA: 0x43330
private sealed class Scrollbar.<ClickRepeat>d__58 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 4339
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Scrollbar <>4__this; // 0x20
	public Vector2 screenPosition; // 0x28
	public Camera camera; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x46120 Offset: 0x46221 VA: 0x46120
	// RVA: 0x1C008F0 Offset: 0x1C009F1 VA: 0x1C008F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x46130 Offset: 0x46231 VA: 0x46130
	// RVA: 0x1C00920 Offset: 0x1C00A21 VA: 0x1C00920 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1C00930 Offset: 0x1C00A31 VA: 0x1C00930 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x46140 Offset: 0x46241 VA: 0x46140
	// RVA: 0x1C00B00 Offset: 0x1C00C01 VA: 0x1C00B00 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x46150 Offset: 0x46251 VA: 0x46150
	// RVA: 0x1C00B10 Offset: 0x1C00C11 VA: 0x1C00B10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x46160 Offset: 0x46261 VA: 0x46160
	// RVA: 0x1C00B50 Offset: 0x1C00C51 VA: 0x1C00B50 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

