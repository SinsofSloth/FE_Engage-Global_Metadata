// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x138F0 Offset: 0x139F1 VA: 0x138F0
private sealed class AsyncObjectPool.<>c__DisplayClass13_0<T> // TypeDefIndex: 6843
{
	// Fields
	public AsyncObjectPool<T> <>4__this; // 0x0
	public float instanceCountRatio; // 0x0
	public int minSize; // 0x0
	public bool callOnBeforeRent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B37EB0 Offset: 0x2B37FB1 VA: 0x2B37EB0
	|-AsyncObjectPool.<>c__DisplayClass13_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <StartShrinkTimer>b__0(long _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B37EC0 Offset: 0x2B37FC1 VA: 0x2B37EC0
	|-AsyncObjectPool.<>c__DisplayClass13_0<object>.<StartShrinkTimer>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <StartShrinkTimer>b__1(long _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B37EE0 Offset: 0x2B37FE1 VA: 0x2B37EE0
	|-AsyncObjectPool.<>c__DisplayClass13_0<object>.<StartShrinkTimer>b__1
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13900 Offset: 0x13A01 VA: 0x13900
private sealed class AsyncObjectPool.<>c__DisplayClass15_0<T> // TypeDefIndex: 6844
{
	// Fields
	public AsyncObjectPool<T> <>4__this; // 0x0
	public int preloadCount; // 0x0
	public int threshold; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38810 Offset: 0x2B38911 VA: 0x2B38810
	|-AsyncObjectPool.<>c__DisplayClass15_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IEnumerator <PreloadAsync>b__0(IObserver<Unit> observer, CancellationToken cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B38820 Offset: 0x2B38921 VA: 0x2B38820
	|-AsyncObjectPool.<>c__DisplayClass15_0<object>.<PreloadAsync>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x13910 Offset: 0x13A11 VA: 0x13910
private sealed class AsyncObjectPool.<PreloadCore>d__16<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 6845
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public int preloadCount; // 0x0
	public AsyncObjectPool<T> <>4__this; // 0x0
	public int threshold; // 0x0
	public CancellationToken cancellationToken; // 0x0
	public IObserver<Unit> observer; // 0x0
	private ObservableYieldInstruction<Unit> <awaiter>5__2; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x17F80 Offset: 0x18081 VA: 0x17F80
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151BB0 Offset: 0x3151CB1 VA: 0x3151BB0
	|-AsyncObjectPool.<PreloadCore>d__16<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x17F90 Offset: 0x18091 VA: 0x17F90
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151BE0 Offset: 0x3151CE1 VA: 0x3151BE0
	|-AsyncObjectPool.<PreloadCore>d__16<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151BF0 Offset: 0x3151CF1 VA: 0x3151BF0
	|-AsyncObjectPool.<PreloadCore>d__16<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x17FA0 Offset: 0x180A1 VA: 0x17FA0
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3152140 Offset: 0x3152241 VA: 0x3152140
	|-AsyncObjectPool.<PreloadCore>d__16<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x17FB0 Offset: 0x180B1 VA: 0x17FB0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3152150 Offset: 0x3152251 VA: 0x3152150
	|-AsyncObjectPool.<PreloadCore>d__16<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x17FC0 Offset: 0x180C1 VA: 0x17FC0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3152190 Offset: 0x3152291 VA: 0x3152190
	|-AsyncObjectPool.<PreloadCore>d__16<object>.System.Collections.IEnumerator.get_Current
	*/
}

