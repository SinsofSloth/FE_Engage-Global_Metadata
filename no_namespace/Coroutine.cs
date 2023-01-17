// Namespace: 
public enum Coroutine.CoroutineType // TypeDefIndex: 5929
{
	// Fields
	public int value__; // 0x0
	public const Coroutine.CoroutineType Coroutine = 0;
	public const Coroutine.CoroutineType ClrCallback = 1;
	public const Coroutine.CoroutineType ClrCallbackDead = 2;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xD350 Offset: 0xD451 VA: 0xD350
private sealed class Coroutine.<AsTypedEnumerable>d__10 : IEnumerable<DynValue>, IEnumerable, IEnumerator<DynValue>, IEnumerator, IDisposable // TypeDefIndex: 5930
{
	// Fields
	private int <>1__state; // 0x10
	private DynValue <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public Coroutine <>4__this; // 0x28

	// Properties
	private DynValue System.Collections.Generic.IEnumerator<MoonSharp.Interpreter.DynValue>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0xF6D0 Offset: 0xF7D1 VA: 0xF6D0
	// RVA: 0x3356110 Offset: 0x3356211 VA: 0x3356110
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0xF6E0 Offset: 0xF7E1 VA: 0xF6E0
	// RVA: 0x3356150 Offset: 0x3356251 VA: 0x3356150 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3356160 Offset: 0x3356261 VA: 0x3356160 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0xF6F0 Offset: 0xF7F1 VA: 0xF6F0
	// RVA: 0x3356260 Offset: 0x3356361 VA: 0x3356260 Slot: 6
	private DynValue System.Collections.Generic.IEnumerator<MoonSharp.Interpreter.DynValue>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0xF700 Offset: 0xF801 VA: 0xF700
	// RVA: 0x3356270 Offset: 0x3356371 VA: 0x3356270 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0xF710 Offset: 0xF811 VA: 0xF710
	// RVA: 0x33562B0 Offset: 0x33563B1 VA: 0x33562B0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0xF720 Offset: 0xF821 VA: 0xF720
	// RVA: 0x33562C0 Offset: 0x33563C1 VA: 0x33562C0 Slot: 4
	private IEnumerator<DynValue> System.Collections.Generic.IEnumerable<MoonSharp.Interpreter.DynValue>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0xF730 Offset: 0xF831 VA: 0xF730
	// RVA: 0x3356380 Offset: 0x3356481 VA: 0x3356380 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xD360 Offset: 0xD461 VA: 0xD360
private sealed class Coroutine.<AsEnumerable>d__11 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5931
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public Coroutine <>4__this; // 0x28
	private IEnumerator<DynValue> <>7__wrap1; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0xF740 Offset: 0xF841 VA: 0xF740
	// RVA: 0x3355A80 Offset: 0x3355B81 VA: 0x3355A80
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0xF750 Offset: 0xF851 VA: 0xF750
	// RVA: 0x3355AC0 Offset: 0x3355BC1 VA: 0x3355AC0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3355C50 Offset: 0x3355D51 VA: 0x3355C50 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x3355B90 Offset: 0x3355C91 VA: 0x3355B90
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0xF760 Offset: 0xF861 VA: 0xF760
	// RVA: 0x3355FE0 Offset: 0x33560E1 VA: 0x3355FE0 Slot: 6
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0xF770 Offset: 0xF871 VA: 0xF770
	// RVA: 0x3355FF0 Offset: 0x33560F1 VA: 0x3355FF0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0xF780 Offset: 0xF881 VA: 0xF780
	// RVA: 0x3356030 Offset: 0x3356131 VA: 0x3356030 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0xF790 Offset: 0xF891 VA: 0xF790
	// RVA: 0x3356040 Offset: 0x3356141 VA: 0x3356040 Slot: 4
	private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0xF7A0 Offset: 0xF8A1 VA: 0xF7A0
	// RVA: 0x3356100 Offset: 0x3356201 VA: 0x3356100 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xD370 Offset: 0xD471 VA: 0xD370
private sealed class Coroutine.<AsEnumerable>d__12<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 5932
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public Coroutine <>4__this; // 0x0
	private IEnumerator<DynValue> <>7__wrap1; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0xF7B0 Offset: 0xF8B1 VA: 0xF7B0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B44F20 Offset: 0x2B45021 VA: 0x2B44F20
	|-Coroutine.<AsEnumerable>d__12<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0xF7C0 Offset: 0xF8C1 VA: 0xF7C0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B44F60 Offset: 0x2B45061 VA: 0x2B44F60
	|-Coroutine.<AsEnumerable>d__12<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B44F90 Offset: 0x2B45091 VA: 0x2B44F90
	|-Coroutine.<AsEnumerable>d__12<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45230 Offset: 0x2B45331 VA: 0x2B45230
	|-Coroutine.<AsEnumerable>d__12<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0xF7D0 Offset: 0xF8D1 VA: 0xF7D0
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B452F0 Offset: 0x2B453F1 VA: 0x2B452F0
	|-Coroutine.<AsEnumerable>d__12<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0xF7E0 Offset: 0xF8E1 VA: 0xF7E0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45300 Offset: 0x2B45401 VA: 0x2B45300
	|-Coroutine.<AsEnumerable>d__12<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0xF7F0 Offset: 0xF8F1 VA: 0xF7F0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45340 Offset: 0x2B45441 VA: 0x2B45340
	|-Coroutine.<AsEnumerable>d__12<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0xF800 Offset: 0xF901 VA: 0xF800
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45350 Offset: 0x2B45451 VA: 0x2B45350
	|-Coroutine.<AsEnumerable>d__12<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0xF810 Offset: 0xF911 VA: 0xF810
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45400 Offset: 0x2B45501 VA: 0x2B45400
	|-Coroutine.<AsEnumerable>d__12<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xD380 Offset: 0xD481 VA: 0xD380
private sealed class Coroutine.<AsUnityCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5933
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Coroutine <>4__this; // 0x20
	private IEnumerator<DynValue> <>7__wrap1; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0xF820 Offset: 0xF921 VA: 0xF820
	// RVA: 0x3356390 Offset: 0x3356491 VA: 0x3356390
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0xF830 Offset: 0xF931 VA: 0xF830
	// RVA: 0x33563C0 Offset: 0x33564C1 VA: 0x33563C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3356550 Offset: 0x3356651 VA: 0x3356550 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x3356490 Offset: 0x3356591 VA: 0x3356490
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0xF840 Offset: 0xF941 VA: 0xF840
	// RVA: 0x33568D0 Offset: 0x33569D1 VA: 0x33568D0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0xF850 Offset: 0xF951 VA: 0xF850
	// RVA: 0x33568E0 Offset: 0x33569E1 VA: 0x33568E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0xF860 Offset: 0xF961 VA: 0xF860
	// RVA: 0x3356920 Offset: 0x3356A21 VA: 0x3356920 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

