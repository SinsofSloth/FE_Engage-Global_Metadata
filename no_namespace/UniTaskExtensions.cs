// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28030 Offset: 0x28131 VA: 0x28030
private struct UniTaskExtensions.ToCoroutineEnumerator.<RunTask>d__6 : IAsyncStateMachine // TypeDefIndex: 5108
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x8
	public UniTask task; // 0x10
	public UniTaskExtensions.ToCoroutineEnumerator <>4__this; // 0x18
	private UniTask.Awaiter <>u__1; // 0x20

	// Methods

	// RVA: 0x1C2F430 Offset: 0x1C2F531 VA: 0x1C2F430 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2DBC0 Offset: 0x2DCC1 VA: 0x2DBC0
	// RVA: 0x1C2F7A0 Offset: 0x1C2F8A1 VA: 0x1C2F7A0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
private class UniTaskExtensions.ToCoroutineEnumerator : IEnumerator // TypeDefIndex: 5109
{
	// Fields
	private bool completed; // 0x10
	private UniTask task; // 0x18
	private Action<Exception> exceptionHandler; // 0x20
	private bool isStarted; // 0x28
	private ExceptionDispatchInfo exception; // 0x30

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1C2B9C0 Offset: 0x1C2BAC1 VA: 0x1C2B9C0
	public void .ctor(UniTask task, Action<Exception> exceptionHandler) { }

	[AsyncStateMachineAttribute] // RVA: 0x2DB50 Offset: 0x2DC51 VA: 0x2DB50
	// RVA: 0x1C2BA20 Offset: 0x1C2BB21 VA: 0x1C2BA20
	private UniTaskVoid RunTask(UniTask task) { }

	// RVA: 0x1C2BB00 Offset: 0x1C2BC01 VA: 0x1C2BB00 Slot: 5
	public object get_Current() { }

	// RVA: 0x1C2BB10 Offset: 0x1C2BC11 VA: 0x1C2BB10 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1C2BBE0 Offset: 0x1C2BCE1 VA: 0x1C2BBE0 Slot: 6
	public void Reset() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28040 Offset: 0x28141 VA: 0x28040
private struct UniTaskExtensions.ToCoroutineEnumerator.<RunTask>d__8<T> : IAsyncStateMachine // TypeDefIndex: 5110
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T> task; // 0x0
	public UniTaskExtensions.ToCoroutineEnumerator<T> <>4__this; // 0x0
	private UniTask.Awaiter<T> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3163E90 Offset: 0x3163F91 VA: 0x3163E90
	|-UniTaskExtensions.ToCoroutineEnumerator.<RunTask>d__8<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DC40 Offset: 0x2DD41 VA: 0x2DC40
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3164290 Offset: 0x3164391 VA: 0x3164290
	|-UniTaskExtensions.ToCoroutineEnumerator.<RunTask>d__8<object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTaskExtensions.ToCoroutineEnumerator<T> : IEnumerator // TypeDefIndex: 5111
{
	// Fields
	private bool completed; // 0x0
	private Action<T> resultHandler; // 0x0
	private Action<Exception> exceptionHandler; // 0x0
	private bool isStarted; // 0x0
	private UniTask<T> task; // 0x0
	private object current; // 0x0
	private ExceptionDispatchInfo exception; // 0x0

	// Properties
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T> task, Action<T> resultHandler, Action<Exception> exceptionHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356E660 Offset: 0x356E761 VA: 0x356E660
	|-UniTaskExtensions.ToCoroutineEnumerator<object>..ctor
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2DBD0 Offset: 0x2DCD1 VA: 0x2DBD0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask(UniTask<T> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356E6E0 Offset: 0x356E7E1 VA: 0x356E6E0
	|-UniTaskExtensions.ToCoroutineEnumerator<object>.RunTask
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356E7B0 Offset: 0x356E8B1 VA: 0x356E7B0
	|-UniTaskExtensions.ToCoroutineEnumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356E7C0 Offset: 0x356E8C1 VA: 0x356E7C0
	|-UniTaskExtensions.ToCoroutineEnumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356E890 Offset: 0x356E991 VA: 0x356E890
	|-UniTaskExtensions.ToCoroutineEnumerator<object>.Reset
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28050 Offset: 0x28151 VA: 0x28050
[Serializable]
private sealed class UniTaskExtensions.<>c__9<T> // TypeDefIndex: 5112
{
	// Fields
	public static readonly UniTaskExtensions.<>c__9<T> <>9; // 0x0
	public static Action<Task<T>, object> <>9__9_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36EE0 Offset: 0x2B36FE1 VA: 0x2B36EE0
	|-UniTaskExtensions.<>c__9<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36FC0 Offset: 0x2B370C1 VA: 0x2B36FC0
	|-UniTaskExtensions.<>c__9<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <AsUniTask>b__9_0(Task<T> x, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36FD0 Offset: 0x2B370D1 VA: 0x2B36FD0
	|-UniTaskExtensions.<>c__9<object>.<AsUniTask>b__9_0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28060 Offset: 0x28161 VA: 0x28060
[Serializable]
private sealed class UniTaskExtensions.<>c // TypeDefIndex: 5113
{
	// Fields
	public static readonly UniTaskExtensions.<>c <>9; // 0x0
	public static Action<Task, object> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x1C2A560 Offset: 0x1C2A661 VA: 0x1C2A560
	private static void .cctor() { }

	// RVA: 0x1C2A5D0 Offset: 0x1C2A6D1 VA: 0x1C2A5D0
	public void .ctor() { }

	// RVA: 0x1C2A5E0 Offset: 0x1C2A6E1 VA: 0x1C2A5E0
	internal void <AsUniTask>b__10_0(Task x, object state) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28070 Offset: 0x28171 VA: 0x28070
private struct UniTaskExtensions.<Timeout>d__14<T> : IAsyncStateMachine // TypeDefIndex: 5114
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<T> <>t__builder; // 0x0
	public TimeSpan timeout; // 0x0
	public bool ignoreTimeScale; // 0x0
	public PlayerLoopTiming timeoutCheckTiming; // 0x0
	public UniTask<T> task; // 0x0
	public CancellationTokenSource taskCancellationTokenSource; // 0x0
	private CancellationTokenSource <delayCancellationTokenSource>5__2; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x299B0 Offset: 0x29AB1 VA: 0x299B0
	private UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, T>>> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBC0E0 Offset: 0x1FBC1E1 VA: 0x1FBC0E0
	|-UniTaskExtensions.<Timeout>d__14<AsyncUnit>.MoveNext
	|
	|-RVA: 0x1FBC5C0 Offset: 0x1FBC6C1 VA: 0x1FBC5C0
	|-UniTaskExtensions.<Timeout>d__14<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DC50 Offset: 0x2DD51 VA: 0x2DC50
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBC570 Offset: 0x1FBC671 VA: 0x1FBC570
	|-UniTaskExtensions.<Timeout>d__14<AsyncUnit>.SetStateMachine
	|
	|-RVA: 0x1FBCAA0 Offset: 0x1FBCBA1 VA: 0x1FBCAA0
	|-UniTaskExtensions.<Timeout>d__14<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28080 Offset: 0x28181 VA: 0x28080
private struct UniTaskExtensions.<TimeoutWithoutException>d__15 : IAsyncStateMachine // TypeDefIndex: 5115
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x8
	public UniTask task; // 0x20
	public TimeSpan timeout; // 0x28
	public bool ignoreTimeScale; // 0x30
	public PlayerLoopTiming timeoutCheckTiming; // 0x34
	public CancellationTokenSource taskCancellationTokenSource; // 0x38
	[TupleElementNamesAttribute] // RVA: 0x29A90 Offset: 0x29B91 VA: 0x29A90
	private UniTask.Awaiter<ValueTuple<bool, AsyncUnit>> <>u__1; // 0x40

	// Methods

	// RVA: 0x1C2B720 Offset: 0x1C2B821 VA: 0x1C2B720 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2DC60 Offset: 0x2DD61 VA: 0x2DC60
	// RVA: 0x1C2B960 Offset: 0x1C2BA61 VA: 0x1C2B960 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28090 Offset: 0x28191 VA: 0x28090
private struct UniTaskExtensions.<TimeoutWithoutException>d__16<T> : IAsyncStateMachine // TypeDefIndex: 5116
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x29B40 Offset: 0x29C41 VA: 0x29B40
	public AsyncUniTaskMethodBuilder<ValueTuple<bool, T>> <>t__builder; // 0x0
	public TimeSpan timeout; // 0x0
	public bool ignoreTimeScale; // 0x0
	public PlayerLoopTiming timeoutCheckTiming; // 0x0
	public UniTask<T> task; // 0x0
	public CancellationTokenSource taskCancellationTokenSource; // 0x0
	private CancellationTokenSource <delayCancellationTokenSource>5__2; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x29BF0 Offset: 0x29CF1 VA: 0x29BF0
	private UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, T>>> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBCAF0 Offset: 0x1FBCBF1 VA: 0x1FBCAF0
	|-UniTaskExtensions.<TimeoutWithoutException>d__16<AsyncUnit>.MoveNext
	|
	|-RVA: 0x1FBCFC0 Offset: 0x1FBD0C1 VA: 0x1FBCFC0
	|-UniTaskExtensions.<TimeoutWithoutException>d__16<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DC70 Offset: 0x2DD71 VA: 0x2DC70
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBCF70 Offset: 0x1FBD071 VA: 0x1FBCF70
	|-UniTaskExtensions.<TimeoutWithoutException>d__16<AsyncUnit>.SetStateMachine
	|
	|-RVA: 0x1FBD490 Offset: 0x1FBD591 VA: 0x1FBD490
	|-UniTaskExtensions.<TimeoutWithoutException>d__16<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x280A0 Offset: 0x281A1 VA: 0x280A0
private struct UniTaskExtensions.<ForgetCore>d__19 : IAsyncStateMachine // TypeDefIndex: 5117
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x8
	public UniTask task; // 0x10
	private UniTask.Awaiter <>u__1; // 0x18

	// Methods

	// RVA: 0x1C2B060 Offset: 0x1C2B161 VA: 0x1C2B060 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2DC80 Offset: 0x2DD81 VA: 0x2DC80
	// RVA: 0x1C2B200 Offset: 0x1C2B301 VA: 0x1C2B200 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x280B0 Offset: 0x281B1 VA: 0x280B0
private struct UniTaskExtensions.<ForgetCoreWithCatch>d__20 : IAsyncStateMachine // TypeDefIndex: 5118
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x8
	public UniTask task; // 0x10
	public bool handleExceptionOnMainThread; // 0x18
	public Action<Exception> exceptionHandler; // 0x20
	private object <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30
	private UniTask.Awaiter <>u__1; // 0x38
	private Exception <ex>5__4; // 0x40
	private SwitchToMainThreadAwaitable.Awaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x1C2B210 Offset: 0x1C2B311 VA: 0x1C2B210 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2DC90 Offset: 0x2DD91 VA: 0x2DC90
	// RVA: 0x1C2B710 Offset: 0x1C2B811 VA: 0x1C2B710 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x280C0 Offset: 0x281C1 VA: 0x280C0
private struct UniTaskExtensions.<ForgetCore>d__23<T> : IAsyncStateMachine // TypeDefIndex: 5119
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T> task; // 0x0
	private UniTask.Awaiter<T> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x314F1D0 Offset: 0x314F2D1 VA: 0x314F1D0
	|-UniTaskExtensions.<ForgetCore>d__23<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DCA0 Offset: 0x2DDA1 VA: 0x2DCA0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x314F390 Offset: 0x314F491 VA: 0x314F390
	|-UniTaskExtensions.<ForgetCore>d__23<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x280D0 Offset: 0x281D1 VA: 0x280D0
private struct UniTaskExtensions.<ForgetCoreWithCatch>d__24<T> : IAsyncStateMachine // TypeDefIndex: 5120
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T> task; // 0x0
	public bool handleExceptionOnMainThread; // 0x0
	public Action<Exception> exceptionHandler; // 0x0
	private object <>7__wrap1; // 0x0
	private int <>7__wrap2; // 0x0
	private UniTask.Awaiter<T> <>u__1; // 0x0
	private Exception <ex>5__4; // 0x0
	private SwitchToMainThreadAwaitable.Awaiter <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x314F3A0 Offset: 0x314F4A1 VA: 0x314F3A0
	|-UniTaskExtensions.<ForgetCoreWithCatch>d__24<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DCB0 Offset: 0x2DDB1 VA: 0x2DCB0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x314F8F0 Offset: 0x314F9F1 VA: 0x314F8F0
	|-UniTaskExtensions.<ForgetCoreWithCatch>d__24<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x280E0 Offset: 0x281E1 VA: 0x280E0
private struct UniTaskExtensions.<ContinueWith>d__25<T> : IAsyncStateMachine // TypeDefIndex: 5121
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x0
	public Action<T> continuationFunction; // 0x0
	public UniTask<T> task; // 0x0
	private Action<T> <>7__wrap1; // 0x0
	private UniTask.Awaiter<T> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B49210 Offset: 0x2B49311 VA: 0x2B49210
	|-UniTaskExtensions.<ContinueWith>d__25<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DCC0 Offset: 0x2DDC1 VA: 0x2DCC0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B49460 Offset: 0x2B49561 VA: 0x2B49460
	|-UniTaskExtensions.<ContinueWith>d__25<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x280F0 Offset: 0x281F1 VA: 0x280F0
private struct UniTaskExtensions.<ContinueWith>d__26<T> : IAsyncStateMachine // TypeDefIndex: 5122
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x0
	public Func<T, UniTask> continuationFunction; // 0x0
	public UniTask<T> task; // 0x0
	private Func<T, UniTask> <>7__wrap1; // 0x0
	private UniTask.Awaiter<T> <>u__1; // 0x0
	private UniTask.Awaiter <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B49470 Offset: 0x2B49571 VA: 0x2B49470
	|-UniTaskExtensions.<ContinueWith>d__26<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DCD0 Offset: 0x2DDD1 VA: 0x2DCD0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B49770 Offset: 0x2B49871 VA: 0x2B49770
	|-UniTaskExtensions.<ContinueWith>d__26<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28100 Offset: 0x28201 VA: 0x28100
private struct UniTaskExtensions.<ContinueWith>d__27<T, TR> : IAsyncStateMachine // TypeDefIndex: 5123
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<TR> <>t__builder; // 0x0
	public Func<T, TR> continuationFunction; // 0x0
	public UniTask<T> task; // 0x0
	private Func<T, TR> <>7__wrap1; // 0x0
	private UniTask.Awaiter<T> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B49780 Offset: 0x2B49881 VA: 0x2B49780
	|-UniTaskExtensions.<ContinueWith>d__27<object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DCE0 Offset: 0x2DDE1 VA: 0x2DCE0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B499F0 Offset: 0x2B49AF1 VA: 0x2B499F0
	|-UniTaskExtensions.<ContinueWith>d__27<object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28110 Offset: 0x28211 VA: 0x28110
private struct UniTaskExtensions.<ContinueWith>d__28<T, TR> : IAsyncStateMachine // TypeDefIndex: 5124
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<TR> <>t__builder; // 0x0
	public Func<T, UniTask<TR>> continuationFunction; // 0x0
	public UniTask<T> task; // 0x0
	private Func<T, UniTask<TR>> <>7__wrap1; // 0x0
	private UniTask.Awaiter<T> <>u__1; // 0x0
	private UniTask.Awaiter<TR> <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B49A40 Offset: 0x2B49B41 VA: 0x2B49A40
	|-UniTaskExtensions.<ContinueWith>d__28<object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DCF0 Offset: 0x2DDF1 VA: 0x2DCF0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B49DD0 Offset: 0x2B49ED1 VA: 0x2B49DD0
	|-UniTaskExtensions.<ContinueWith>d__28<object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28120 Offset: 0x28221 VA: 0x28120
private struct UniTaskExtensions.<ContinueWith>d__29 : IAsyncStateMachine // TypeDefIndex: 5125
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public UniTask task; // 0x18
	public Action continuationFunction; // 0x20
	private UniTask.Awaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x1C2AC30 Offset: 0x1C2AD31 VA: 0x1C2AC30 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2DD00 Offset: 0x2DE01 VA: 0x2DD00
	// RVA: 0x1C2ADE0 Offset: 0x1C2AEE1 VA: 0x1C2ADE0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28130 Offset: 0x28231 VA: 0x28130
private struct UniTaskExtensions.<ContinueWith>d__30 : IAsyncStateMachine // TypeDefIndex: 5126
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public UniTask task; // 0x18
	public Func<UniTask> continuationFunction; // 0x20
	private UniTask.Awaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x1C2ADF0 Offset: 0x1C2AEF1 VA: 0x1C2ADF0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2DD10 Offset: 0x2DE11 VA: 0x2DD10
	// RVA: 0x1C2B050 Offset: 0x1C2B151 VA: 0x1C2B050 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28140 Offset: 0x28241 VA: 0x28140
private struct UniTaskExtensions.<ContinueWith>d__31<T> : IAsyncStateMachine // TypeDefIndex: 5127
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<T> <>t__builder; // 0x0
	public UniTask task; // 0x0
	public Func<T> continuationFunction; // 0x0
	private UniTask.Awaiter <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B49E20 Offset: 0x2B49F21 VA: 0x2B49E20
	|-UniTaskExtensions.<ContinueWith>d__31<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DD20 Offset: 0x2DE21 VA: 0x2DD20
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4A020 Offset: 0x2B4A121 VA: 0x2B4A020
	|-UniTaskExtensions.<ContinueWith>d__31<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28150 Offset: 0x28251 VA: 0x28150
private struct UniTaskExtensions.<ContinueWith>d__32<T> : IAsyncStateMachine // TypeDefIndex: 5128
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<T> <>t__builder; // 0x0
	public UniTask task; // 0x0
	public Func<UniTask<T>> continuationFunction; // 0x0
	private UniTask.Awaiter <>u__1; // 0x0
	private UniTask.Awaiter<T> <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4A070 Offset: 0x2B4A171 VA: 0x2B4A070
	|-UniTaskExtensions.<ContinueWith>d__32<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DD30 Offset: 0x2DE31 VA: 0x2DD30
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4A380 Offset: 0x2B4A481 VA: 0x2B4A380
	|-UniTaskExtensions.<ContinueWith>d__32<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28160 Offset: 0x28261 VA: 0x28160
private struct UniTaskExtensions.<ConfigureAwait>d__33 : IAsyncStateMachine // TypeDefIndex: 5129
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public Task task; // 0x18
	public PlayerLoopTiming timing; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28
	private YieldAwaitable.Awaiter <>u__2; // 0x38

	// Methods

	// RVA: 0x1C2A750 Offset: 0x1C2A851 VA: 0x1C2A750 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2DD40 Offset: 0x2DE41 VA: 0x2DD40
	// RVA: 0x1C2A9C0 Offset: 0x1C2AAC1 VA: 0x1C2A9C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28170 Offset: 0x28271 VA: 0x28170
private struct UniTaskExtensions.<ConfigureAwait>d__34<T> : IAsyncStateMachine // TypeDefIndex: 5130
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<T> <>t__builder; // 0x0
	public Task<T> task; // 0x0
	public PlayerLoopTiming timing; // 0x0
	private T <v>5__2; // 0x0
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<T> <>u__1; // 0x0
	private YieldAwaitable.Awaiter <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B48AE0 Offset: 0x2B48BE1 VA: 0x2B48AE0
	|-UniTaskExtensions.<ConfigureAwait>d__34<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DD50 Offset: 0x2DE51 VA: 0x2DD50
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B48E50 Offset: 0x2B48F51 VA: 0x2B48E50
	|-UniTaskExtensions.<ConfigureAwait>d__34<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28180 Offset: 0x28281 VA: 0x28180
private struct UniTaskExtensions.<ConfigureAwait>d__35 : IAsyncStateMachine // TypeDefIndex: 5131
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public UniTask task; // 0x18
	public PlayerLoopTiming timing; // 0x20
	private UniTask.Awaiter <>u__1; // 0x28
	private YieldAwaitable.Awaiter <>u__2; // 0x30

	// Methods

	// RVA: 0x1C2A9D0 Offset: 0x1C2AAD1 VA: 0x1C2A9D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2DD60 Offset: 0x2DE61 VA: 0x2DD60
	// RVA: 0x1C2AC20 Offset: 0x1C2AD21 VA: 0x1C2AC20 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x28190 Offset: 0x28291 VA: 0x28190
private struct UniTaskExtensions.<ConfigureAwait>d__36<T> : IAsyncStateMachine // TypeDefIndex: 5132
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<T> <>t__builder; // 0x0
	public UniTask<T> task; // 0x0
	public PlayerLoopTiming timing; // 0x0
	private T <v>5__2; // 0x0
	private UniTask.Awaiter<T> <>u__1; // 0x0
	private YieldAwaitable.Awaiter <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B48EA0 Offset: 0x2B48FA1 VA: 0x2B48EA0
	|-UniTaskExtensions.<ConfigureAwait>d__36<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DD70 Offset: 0x2DE71 VA: 0x2DD70
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B491C0 Offset: 0x2B492C1 VA: 0x2B491C0
	|-UniTaskExtensions.<ConfigureAwait>d__36<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x281A0 Offset: 0x282A1 VA: 0x281A0
private struct UniTaskExtensions.<Unwrap>d__37<T> : IAsyncStateMachine // TypeDefIndex: 5133
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<T> <>t__builder; // 0x0
	public UniTask<UniTask<T>> task; // 0x0
	private UniTask.Awaiter<UniTask<T>> <>u__1; // 0x0
	private UniTask.Awaiter<T> <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBD7E0 Offset: 0x1FBD8E1 VA: 0x1FBD7E0
	|-UniTaskExtensions.<Unwrap>d__37<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DD80 Offset: 0x2DE81 VA: 0x2DD80
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBDB10 Offset: 0x1FBDC11 VA: 0x1FBDB10
	|-UniTaskExtensions.<Unwrap>d__37<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x281B0 Offset: 0x282B1 VA: 0x281B0
private struct UniTaskExtensions.<Unwrap>d__38<T> : IAsyncStateMachine // TypeDefIndex: 5134
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x0
	public UniTask<UniTask> task; // 0x0
	private UniTask.Awaiter<UniTask> <>u__1; // 0x0
	private UniTask.Awaiter <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBDB60 Offset: 0x1FBDC61 VA: 0x1FBDB60
	|-UniTaskExtensions.<Unwrap>d__38<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2DD90 Offset: 0x2DE91 VA: 0x2DD90
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBDDF0 Offset: 0x1FBDEF1 VA: 0x1FBDDF0
	|-UniTaskExtensions.<Unwrap>d__38<object>.SetStateMachine
	*/
}

