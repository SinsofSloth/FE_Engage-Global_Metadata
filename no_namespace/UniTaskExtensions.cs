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

