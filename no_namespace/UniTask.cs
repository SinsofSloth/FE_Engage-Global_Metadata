// Namespace: 
private class UniTask.YieldPromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 4943
{
	// Methods

	// RVA: 0x1C2A4E0 Offset: 0x1C2A5E1 VA: 0x1C2A4E0
	public void .ctor(PlayerLoopTiming timing, CancellationToken cancellationToken) { }

	// RVA: 0x1C2A4F0 Offset: 0x1C2A5F1 VA: 0x1C2A4F0 Slot: 15
	protected override void OnRunningStart() { }

	// RVA: 0x1C2A500 Offset: 0x1C2A601 VA: 0x1C2A500 Slot: 16
	public override bool MoveNext() { }
}

// Namespace: 
private class UniTask.DelayFramePromise : PlayerLoopReusablePromiseBase<int> // TypeDefIndex: 4944
{
	// Fields
	private readonly int delayFrameCount; // 0x3C
	private int currentFrameCount; // 0x40

	// Methods

	// RVA: 0x1C296A0 Offset: 0x1C297A1 VA: 0x1C296A0
	public void .ctor(int delayFrameCount, PlayerLoopTiming timing, CancellationToken cancellationToken) { }

	// RVA: 0x1C29720 Offset: 0x1C29821 VA: 0x1C29720 Slot: 16
	protected override void OnRunningStart() { }

	// RVA: 0x1C29730 Offset: 0x1C29831 VA: 0x1C29730 Slot: 17
	public override bool MoveNext() { }
}

// Namespace: 
private class UniTask.DelayPromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 4945
{
	// Fields
	private readonly float delayFrameTimeSpan; // 0x34
	private float elapsed; // 0x38

	// Methods

	// RVA: 0x1C29920 Offset: 0x1C29A21 VA: 0x1C29920
	public void .ctor(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken) { }

	// RVA: 0x1C29970 Offset: 0x1C29A71 VA: 0x1C29970 Slot: 15
	protected override void OnRunningStart() { }

	// RVA: 0x1C29980 Offset: 0x1C29A81 VA: 0x1C29980 Slot: 16
	public override bool MoveNext() { }
}

// Namespace: 
private class UniTask.DelayIgnoreTimeScalePromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 4946
{
	// Fields
	private readonly float delayFrameTimeSpan; // 0x34
	private float elapsed; // 0x38

	// Methods

	// RVA: 0x1C29810 Offset: 0x1C29911 VA: 0x1C29810
	public void .ctor(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken) { }

	// RVA: 0x1C29860 Offset: 0x1C29961 VA: 0x1C29860 Slot: 15
	protected override void OnRunningStart() { }

	// RVA: 0x1C29870 Offset: 0x1C29971 VA: 0x1C29870 Slot: 16
	public override bool MoveNext() { }
}

// Namespace: 
private static class UniTask.CanceledUniTaskCache<T> // TypeDefIndex: 4947
{
	// Fields
	public static readonly UniTask<T> Task; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C8320 Offset: 0x30C8421 VA: 0x30C8320
	|-UniTask.CanceledUniTaskCache<AsyncUnit>..cctor
	|
	|-RVA: 0x30C8490 Offset: 0x30C8591 VA: 0x30C8490
	|-UniTask.CanceledUniTaskCache<int>..cctor
	|
	|-RVA: 0x30C8600 Offset: 0x30C8701 VA: 0x30C8600
	|-UniTask.CanceledUniTaskCache<object>..cctor
	|
	|-RVA: 0x30C8760 Offset: 0x30C8861 VA: 0x30C8760
	|-UniTask.CanceledUniTaskCache<float>..cctor
	*/
}

// Namespace: 
private class UniTask.WaitUntilPromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 4948
{
	// Fields
	private readonly Func<bool> predicate; // 0x38

	// Methods

	// RVA: 0x1C29F10 Offset: 0x1C2A011 VA: 0x1C29F10
	public void .ctor(Func<bool> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken) { }

	// RVA: 0x1C29F50 Offset: 0x1C2A051 VA: 0x1C29F50 Slot: 15
	protected override void OnRunningStart() { }

	// RVA: 0x1C29F60 Offset: 0x1C2A061 VA: 0x1C29F60 Slot: 16
	public override bool MoveNext() { }
}

// Namespace: 
private class UniTask.WaitWhilePromise : PlayerLoopReusablePromiseBase // TypeDefIndex: 4949
{
	// Fields
	private readonly Func<bool> predicate; // 0x38

	// Methods

	// RVA: 0x1C2A0C0 Offset: 0x1C2A1C1 VA: 0x1C2A0C0
	public void .ctor(Func<bool> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken) { }

	// RVA: 0x1C2A100 Offset: 0x1C2A201 VA: 0x1C2A100 Slot: 15
	protected override void OnRunningStart() { }

	// RVA: 0x1C2A110 Offset: 0x1C2A211 VA: 0x1C2A110 Slot: 16
	public override bool MoveNext() { }
}

// Namespace: 
private class UniTask.WaitUntilValueChangedUnityObjectPromise<T, U> : PlayerLoopReusablePromiseBase<U> // TypeDefIndex: 4950
{
	// Fields
	private readonly T target; // 0x0
	private readonly Func<T, U> monitorFunction; // 0x0
	private readonly IEqualityComparer<U> equalityComparer; // 0x0
	private U currentValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T target, Func<T, U> monitorFunction, IEqualityComparer<U> equalityComparer, PlayerLoopTiming timing, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD96E0 Offset: 0x2FD97E1 VA: 0x2FD96E0
	|-UniTask.WaitUntilValueChangedUnityObjectPromise<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 16
	protected override void OnRunningStart() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD9810 Offset: 0x2FD9911 VA: 0x2FD9810
	|-UniTask.WaitUntilValueChangedUnityObjectPromise<object, object>.OnRunningStart
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD9820 Offset: 0x2FD9921 VA: 0x2FD9820
	|-UniTask.WaitUntilValueChangedUnityObjectPromise<object, object>.MoveNext
	*/
}

// Namespace: 
private class UniTask.WaitUntilValueChangedStandardObjectPromise<T, U> : PlayerLoopReusablePromiseBase<U> // TypeDefIndex: 4951
{
	// Fields
	private readonly WeakReference<T> target; // 0x0
	private readonly Func<T, U> monitorFunction; // 0x0
	private readonly IEqualityComparer<U> equalityComparer; // 0x0
	private U currentValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T target, Func<T, U> monitorFunction, IEqualityComparer<U> equalityComparer, PlayerLoopTiming timing, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD9320 Offset: 0x2FD9421 VA: 0x2FD9320
	|-UniTask.WaitUntilValueChangedStandardObjectPromise<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 16
	protected override void OnRunningStart() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD9490 Offset: 0x2FD9591 VA: 0x2FD9490
	|-UniTask.WaitUntilValueChangedStandardObjectPromise<object, object>.OnRunningStart
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD94A0 Offset: 0x2FD95A1 VA: 0x2FD94A0
	|-UniTask.WaitUntilValueChangedStandardObjectPromise<object, object>.MoveNext
	*/
}

// Namespace: 
public struct UniTask.WhenAllPromise.Awaiter<T1, T2> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4952
{
	// Fields
	private UniTask.WhenAllPromise<T1, T2> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAllPromise<T1, T2> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF45C0 Offset: 0x1DF46C1 VA: 0x1DF45C0
	|-UniTask.WhenAllPromise.Awaiter<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF45D0 Offset: 0x1DF46D1 VA: 0x1DF45D0
	|-UniTask.WhenAllPromise.Awaiter<object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<T1, T2> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4600 Offset: 0x1DF4701 VA: 0x1DF4600
	|-UniTask.WhenAllPromise.Awaiter<object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4680 Offset: 0x1DF4781 VA: 0x1DF4680
	|-UniTask.WhenAllPromise.Awaiter<object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4720 Offset: 0x1DF4821 VA: 0x1DF4720
	|-UniTask.WhenAllPromise.Awaiter<object, object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279E0 Offset: 0x27AE1 VA: 0x279E0
private struct UniTask.WhenAllPromise.<RunTask1Async>d__9<T1, T2> : IAsyncStateMachine // TypeDefIndex: 4953
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T1> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2> <>4__this; // 0x0
	private UniTask.Awaiter<T1> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3159F90 Offset: 0x315A091 VA: 0x3159F90
	|-UniTask.WhenAllPromise.<RunTask1Async>d__9<object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2AC00 Offset: 0x2AD01 VA: 0x2AC00
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315A300 Offset: 0x315A401 VA: 0x315A300
	|-UniTask.WhenAllPromise.<RunTask1Async>d__9<object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279F0 Offset: 0x27AF1 VA: 0x279F0
private struct UniTask.WhenAllPromise.<RunTask2Async>d__11<T1, T2> : IAsyncStateMachine // TypeDefIndex: 4954
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T2> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2> <>4__this; // 0x0
	private UniTask.Awaiter<T2> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315B870 Offset: 0x315B971 VA: 0x315B870
	|-UniTask.WhenAllPromise.<RunTask2Async>d__11<object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2AC10 Offset: 0x2AD11 VA: 0x2AC10
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315BBE0 Offset: 0x315BCE1 VA: 0x315BBE0
	|-UniTask.WhenAllPromise.<RunTask2Async>d__11<object, object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAllPromise<T1, T2> // TypeDefIndex: 4955
{
	// Fields
	private const int MaxCount = 2;
	private T1 result1; // 0x0
	private T2 result2; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private int completeCount; // 0x0
	private Action whenComplete; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T1> task1, UniTask<T2> task2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDD9D0 Offset: 0x2FDDAD1 VA: 0x2FDD9D0
	|-UniTask.WhenAllPromise<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDDA80 Offset: 0x2FDDB81 VA: 0x2FDDA80
	|-UniTask.WhenAllPromise<object, object>.TryCallContinuation
	*/

	// RVA: -1 Offset: -1
	private void RunTask1(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDDAB0 Offset: 0x2FDDBB1 VA: 0x2FDDAB0
	|-UniTask.WhenAllPromise<object, object>.RunTask1
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2AB20 Offset: 0x2AC21 VA: 0x2AB20
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask1Async(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDDC10 Offset: 0x2FDDD11 VA: 0x2FDDC10
	|-UniTask.WhenAllPromise<object, object>.RunTask1Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask2(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDDCE0 Offset: 0x2FDDDE1 VA: 0x2FDDCE0
	|-UniTask.WhenAllPromise<object, object>.RunTask2
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2AB90 Offset: 0x2AC91 VA: 0x2AB90
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask2Async(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDDE40 Offset: 0x2FDDF41 VA: 0x2FDDE40
	|-UniTask.WhenAllPromise<object, object>.RunTask2Async
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAllPromise.Awaiter<T1, T2> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDDF10 Offset: 0x2FDE011 VA: 0x2FDDF10
	|-UniTask.WhenAllPromise<object, object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAllPromise.Awaiter<T1, T2, T3> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4956
{
	// Fields
	private UniTask.WhenAllPromise<T1, T2, T3> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAllPromise<T1, T2, T3> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4AA0 Offset: 0x1DF4BA1 VA: 0x1DF4AA0
	|-UniTask.WhenAllPromise.Awaiter<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4AB0 Offset: 0x1DF4BB1 VA: 0x1DF4AB0
	|-UniTask.WhenAllPromise.Awaiter<object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<T1, T2, T3> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4AE0 Offset: 0x1DF4BE1 VA: 0x1DF4AE0
	|-UniTask.WhenAllPromise.Awaiter<object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4B90 Offset: 0x1DF4C91 VA: 0x1DF4B90
	|-UniTask.WhenAllPromise.Awaiter<object, object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4C30 Offset: 0x1DF4D31 VA: 0x1DF4C30
	|-UniTask.WhenAllPromise.Awaiter<object, object, object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A00 Offset: 0x27B01 VA: 0x27A00
private struct UniTask.WhenAllPromise.<RunTask1Async>d__10<T1, T2, T3> : IAsyncStateMachine // TypeDefIndex: 4957
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T1> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3> <>4__this; // 0x0
	private UniTask.Awaiter<T1> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3158E10 Offset: 0x3158F11 VA: 0x3158E10
	|-UniTask.WhenAllPromise.<RunTask1Async>d__10<object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2AD70 Offset: 0x2AE71 VA: 0x2AD70
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3159180 Offset: 0x3159281 VA: 0x3159180
	|-UniTask.WhenAllPromise.<RunTask1Async>d__10<object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A10 Offset: 0x27B11 VA: 0x27A10
private struct UniTask.WhenAllPromise.<RunTask2Async>d__12<T1, T2, T3> : IAsyncStateMachine // TypeDefIndex: 4958
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T2> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3> <>4__this; // 0x0
	private UniTask.Awaiter<T2> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315BBF0 Offset: 0x315BCF1 VA: 0x315BBF0
	|-UniTask.WhenAllPromise.<RunTask2Async>d__12<object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2AD80 Offset: 0x2AE81 VA: 0x2AD80
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315BF60 Offset: 0x315C061 VA: 0x315BF60
	|-UniTask.WhenAllPromise.<RunTask2Async>d__12<object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A20 Offset: 0x27B21 VA: 0x27A20
private struct UniTask.WhenAllPromise.<RunTask3Async>d__14<T1, T2, T3> : IAsyncStateMachine // TypeDefIndex: 4959
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T3> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3> <>4__this; // 0x0
	private UniTask.Awaiter<T3> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315DF40 Offset: 0x315E041 VA: 0x315DF40
	|-UniTask.WhenAllPromise.<RunTask3Async>d__14<object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2AD90 Offset: 0x2AE91 VA: 0x2AD90
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315E2B0 Offset: 0x315E3B1 VA: 0x315E2B0
	|-UniTask.WhenAllPromise.<RunTask3Async>d__14<object, object, object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAllPromise<T1, T2, T3> // TypeDefIndex: 4960
{
	// Fields
	private const int MaxCount = 3;
	private T1 result1; // 0x0
	private T2 result2; // 0x0
	private T3 result3; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private int completeCount; // 0x0
	private Action whenComplete; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDDF40 Offset: 0x2FDE041 VA: 0x2FDDF40
	|-UniTask.WhenAllPromise<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDE020 Offset: 0x2FDE121 VA: 0x2FDE020
	|-UniTask.WhenAllPromise<object, object, object>.TryCallContinuation
	*/

	// RVA: -1 Offset: -1
	private void RunTask1(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDE050 Offset: 0x2FDE151 VA: 0x2FDE050
	|-UniTask.WhenAllPromise<object, object, object>.RunTask1
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2AC20 Offset: 0x2AD21 VA: 0x2AC20
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask1Async(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDE1B0 Offset: 0x2FDE2B1 VA: 0x2FDE1B0
	|-UniTask.WhenAllPromise<object, object, object>.RunTask1Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask2(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDE280 Offset: 0x2FDE381 VA: 0x2FDE280
	|-UniTask.WhenAllPromise<object, object, object>.RunTask2
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2AC90 Offset: 0x2AD91 VA: 0x2AC90
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask2Async(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDE3E0 Offset: 0x2FDE4E1 VA: 0x2FDE3E0
	|-UniTask.WhenAllPromise<object, object, object>.RunTask2Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask3(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDE4B0 Offset: 0x2FDE5B1 VA: 0x2FDE4B0
	|-UniTask.WhenAllPromise<object, object, object>.RunTask3
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2AD00 Offset: 0x2AE01 VA: 0x2AD00
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask3Async(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDE610 Offset: 0x2FDE711 VA: 0x2FDE610
	|-UniTask.WhenAllPromise<object, object, object>.RunTask3Async
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAllPromise.Awaiter<T1, T2, T3> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDE6E0 Offset: 0x2FDE7E1 VA: 0x2FDE6E0
	|-UniTask.WhenAllPromise<object, object, object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAllPromise.Awaiter<T1, T2, T3, T4> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4961
{
	// Fields
	private UniTask.WhenAllPromise<T1, T2, T3, T4> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAllPromise<T1, T2, T3, T4> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5010 Offset: 0x1DF5111 VA: 0x1DF5010
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5020 Offset: 0x1DF5121 VA: 0x1DF5020
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<T1, T2, T3, T4> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5050 Offset: 0x1DF5151 VA: 0x1DF5050
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5100 Offset: 0x1DF5201 VA: 0x1DF5100
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF51A0 Offset: 0x1DF52A1 VA: 0x1DF51A0
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A30 Offset: 0x27B31 VA: 0x27A30
private struct UniTask.WhenAllPromise.<RunTask1Async>d__11<T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 4962
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T1> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4> <>4__this; // 0x0
	private UniTask.Awaiter<T1> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3159190 Offset: 0x3159291 VA: 0x3159190
	|-UniTask.WhenAllPromise.<RunTask1Async>d__11<object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2AF60 Offset: 0x2B061 VA: 0x2AF60
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3159500 Offset: 0x3159601 VA: 0x3159500
	|-UniTask.WhenAllPromise.<RunTask1Async>d__11<object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A40 Offset: 0x27B41 VA: 0x27A40
private struct UniTask.WhenAllPromise.<RunTask2Async>d__13<T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 4963
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T2> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4> <>4__this; // 0x0
	private UniTask.Awaiter<T2> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315BF70 Offset: 0x315C071 VA: 0x315BF70
	|-UniTask.WhenAllPromise.<RunTask2Async>d__13<object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2AF70 Offset: 0x2B071 VA: 0x2AF70
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315C2E0 Offset: 0x315C3E1 VA: 0x315C2E0
	|-UniTask.WhenAllPromise.<RunTask2Async>d__13<object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A50 Offset: 0x27B51 VA: 0x27A50
private struct UniTask.WhenAllPromise.<RunTask3Async>d__15<T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 4964
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T3> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4> <>4__this; // 0x0
	private UniTask.Awaiter<T3> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315E2C0 Offset: 0x315E3C1 VA: 0x315E2C0
	|-UniTask.WhenAllPromise.<RunTask3Async>d__15<object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2AF80 Offset: 0x2B081 VA: 0x2AF80
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315E630 Offset: 0x315E731 VA: 0x315E630
	|-UniTask.WhenAllPromise.<RunTask3Async>d__15<object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A60 Offset: 0x27B61 VA: 0x27A60
private struct UniTask.WhenAllPromise.<RunTask4Async>d__17<T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 4965
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T4> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4> <>4__this; // 0x0
	private UniTask.Awaiter<T4> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315FF00 Offset: 0x3160001 VA: 0x315FF00
	|-UniTask.WhenAllPromise.<RunTask4Async>d__17<object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2AF90 Offset: 0x2B091 VA: 0x2AF90
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3160270 Offset: 0x3160371 VA: 0x3160270
	|-UniTask.WhenAllPromise.<RunTask4Async>d__17<object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAllPromise<T1, T2, T3, T4> // TypeDefIndex: 4966
{
	// Fields
	private const int MaxCount = 4;
	private T1 result1; // 0x0
	private T2 result2; // 0x0
	private T3 result3; // 0x0
	private T4 result4; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private int completeCount; // 0x0
	private Action whenComplete; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDE710 Offset: 0x2FDE811 VA: 0x2FDE710
	|-UniTask.WhenAllPromise<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDE820 Offset: 0x2FDE921 VA: 0x2FDE820
	|-UniTask.WhenAllPromise<object, object, object, object>.TryCallContinuation
	*/

	// RVA: -1 Offset: -1
	private void RunTask1(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDE850 Offset: 0x2FDE951 VA: 0x2FDE850
	|-UniTask.WhenAllPromise<object, object, object, object>.RunTask1
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2ADA0 Offset: 0x2AEA1 VA: 0x2ADA0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask1Async(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDE9B0 Offset: 0x2FDEAB1 VA: 0x2FDE9B0
	|-UniTask.WhenAllPromise<object, object, object, object>.RunTask1Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask2(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDEA80 Offset: 0x2FDEB81 VA: 0x2FDEA80
	|-UniTask.WhenAllPromise<object, object, object, object>.RunTask2
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2AE10 Offset: 0x2AF11 VA: 0x2AE10
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask2Async(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDEBE0 Offset: 0x2FDECE1 VA: 0x2FDEBE0
	|-UniTask.WhenAllPromise<object, object, object, object>.RunTask2Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask3(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDECB0 Offset: 0x2FDEDB1 VA: 0x2FDECB0
	|-UniTask.WhenAllPromise<object, object, object, object>.RunTask3
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2AE80 Offset: 0x2AF81 VA: 0x2AE80
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask3Async(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDEE10 Offset: 0x2FDEF11 VA: 0x2FDEE10
	|-UniTask.WhenAllPromise<object, object, object, object>.RunTask3Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask4(UniTask<T4> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDEEE0 Offset: 0x2FDEFE1 VA: 0x2FDEEE0
	|-UniTask.WhenAllPromise<object, object, object, object>.RunTask4
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2AEF0 Offset: 0x2AFF1 VA: 0x2AEF0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask4Async(UniTask<T4> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDF040 Offset: 0x2FDF141 VA: 0x2FDF040
	|-UniTask.WhenAllPromise<object, object, object, object>.RunTask4Async
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAllPromise.Awaiter<T1, T2, T3, T4> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDF110 Offset: 0x2FDF211 VA: 0x2FDF110
	|-UniTask.WhenAllPromise<object, object, object, object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAllPromise.Awaiter<T1, T2, T3, T4, T5> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4967
{
	// Fields
	private UniTask.WhenAllPromise<T1, T2, T3, T4, T5> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAllPromise<T1, T2, T3, T4, T5> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF55F0 Offset: 0x1DF56F1 VA: 0x1DF55F0
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5600 Offset: 0x1DF5701 VA: 0x1DF5600
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<T1, T2, T3, T4, T5> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5630 Offset: 0x1DF5731 VA: 0x1DF5630
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5700 Offset: 0x1DF5801 VA: 0x1DF5700
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF57A0 Offset: 0x1DF58A1 VA: 0x1DF57A0
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A70 Offset: 0x27B71 VA: 0x27A70
private struct UniTask.WhenAllPromise.<RunTask1Async>d__12<T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 4968
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T1> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5> <>4__this; // 0x0
	private UniTask.Awaiter<T1> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3159510 Offset: 0x3159611 VA: 0x3159510
	|-UniTask.WhenAllPromise.<RunTask1Async>d__12<object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B1D0 Offset: 0x2B2D1 VA: 0x2B1D0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3159880 Offset: 0x3159981 VA: 0x3159880
	|-UniTask.WhenAllPromise.<RunTask1Async>d__12<object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A80 Offset: 0x27B81 VA: 0x27A80
private struct UniTask.WhenAllPromise.<RunTask2Async>d__14<T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 4969
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T2> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5> <>4__this; // 0x0
	private UniTask.Awaiter<T2> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315C2F0 Offset: 0x315C3F1 VA: 0x315C2F0
	|-UniTask.WhenAllPromise.<RunTask2Async>d__14<object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B1E0 Offset: 0x2B2E1 VA: 0x2B1E0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315C660 Offset: 0x315C761 VA: 0x315C660
	|-UniTask.WhenAllPromise.<RunTask2Async>d__14<object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27A90 Offset: 0x27B91 VA: 0x27A90
private struct UniTask.WhenAllPromise.<RunTask3Async>d__16<T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 4970
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T3> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5> <>4__this; // 0x0
	private UniTask.Awaiter<T3> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315E640 Offset: 0x315E741 VA: 0x315E640
	|-UniTask.WhenAllPromise.<RunTask3Async>d__16<object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B1F0 Offset: 0x2B2F1 VA: 0x2B1F0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315E9B0 Offset: 0x315EAB1 VA: 0x315E9B0
	|-UniTask.WhenAllPromise.<RunTask3Async>d__16<object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27AA0 Offset: 0x27BA1 VA: 0x27AA0
private struct UniTask.WhenAllPromise.<RunTask4Async>d__18<T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 4971
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T4> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5> <>4__this; // 0x0
	private UniTask.Awaiter<T4> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3160280 Offset: 0x3160381 VA: 0x3160280
	|-UniTask.WhenAllPromise.<RunTask4Async>d__18<object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B200 Offset: 0x2B301 VA: 0x2B200
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31605F0 Offset: 0x31606F1 VA: 0x31605F0
	|-UniTask.WhenAllPromise.<RunTask4Async>d__18<object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27AB0 Offset: 0x27BB1 VA: 0x27AB0
private struct UniTask.WhenAllPromise.<RunTask5Async>d__20<T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 4972
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T5> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5> <>4__this; // 0x0
	private UniTask.Awaiter<T5> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31617B0 Offset: 0x31618B1 VA: 0x31617B0
	|-UniTask.WhenAllPromise.<RunTask5Async>d__20<object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B210 Offset: 0x2B311 VA: 0x2B210
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3161B20 Offset: 0x3161C21 VA: 0x3161B20
	|-UniTask.WhenAllPromise.<RunTask5Async>d__20<object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAllPromise<T1, T2, T3, T4, T5> // TypeDefIndex: 4973
{
	// Fields
	private const int MaxCount = 5;
	private T1 result1; // 0x0
	private T2 result2; // 0x0
	private T3 result3; // 0x0
	private T4 result4; // 0x0
	private T5 result5; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private int completeCount; // 0x0
	private Action whenComplete; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDF140 Offset: 0x2FDF241 VA: 0x2FDF140
	|-UniTask.WhenAllPromise<object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDF290 Offset: 0x2FDF391 VA: 0x2FDF290
	|-UniTask.WhenAllPromise<object, object, object, object, object>.TryCallContinuation
	*/

	// RVA: -1 Offset: -1
	private void RunTask1(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDF2C0 Offset: 0x2FDF3C1 VA: 0x2FDF2C0
	|-UniTask.WhenAllPromise<object, object, object, object, object>.RunTask1
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2AFA0 Offset: 0x2B0A1 VA: 0x2AFA0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask1Async(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDF420 Offset: 0x2FDF521 VA: 0x2FDF420
	|-UniTask.WhenAllPromise<object, object, object, object, object>.RunTask1Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask2(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDF4F0 Offset: 0x2FDF5F1 VA: 0x2FDF4F0
	|-UniTask.WhenAllPromise<object, object, object, object, object>.RunTask2
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B010 Offset: 0x2B111 VA: 0x2B010
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask2Async(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDF650 Offset: 0x2FDF751 VA: 0x2FDF650
	|-UniTask.WhenAllPromise<object, object, object, object, object>.RunTask2Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask3(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDF720 Offset: 0x2FDF821 VA: 0x2FDF720
	|-UniTask.WhenAllPromise<object, object, object, object, object>.RunTask3
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B080 Offset: 0x2B181 VA: 0x2B080
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask3Async(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDF880 Offset: 0x2FDF981 VA: 0x2FDF880
	|-UniTask.WhenAllPromise<object, object, object, object, object>.RunTask3Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask4(UniTask<T4> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDF950 Offset: 0x2FDFA51 VA: 0x2FDF950
	|-UniTask.WhenAllPromise<object, object, object, object, object>.RunTask4
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B0F0 Offset: 0x2B1F1 VA: 0x2B0F0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask4Async(UniTask<T4> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDFAB0 Offset: 0x2FDFBB1 VA: 0x2FDFAB0
	|-UniTask.WhenAllPromise<object, object, object, object, object>.RunTask4Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask5(UniTask<T5> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDFB80 Offset: 0x2FDFC81 VA: 0x2FDFB80
	|-UniTask.WhenAllPromise<object, object, object, object, object>.RunTask5
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B160 Offset: 0x2B261 VA: 0x2B160
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask5Async(UniTask<T5> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDFCE0 Offset: 0x2FDFDE1 VA: 0x2FDFCE0
	|-UniTask.WhenAllPromise<object, object, object, object, object>.RunTask5Async
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAllPromise.Awaiter<T1, T2, T3, T4, T5> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDFDB0 Offset: 0x2FDFEB1 VA: 0x2FDFDB0
	|-UniTask.WhenAllPromise<object, object, object, object, object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAllPromise.Awaiter<T1, T2, T3, T4, T5, T6> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4974
{
	// Fields
	private UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5C30 Offset: 0x1DF5D31 VA: 0x1DF5C30
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5C40 Offset: 0x1DF5D41 VA: 0x1DF5C40
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<T1, T2, T3, T4, T5, T6> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5C70 Offset: 0x1DF5D71 VA: 0x1DF5C70
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5D40 Offset: 0x1DF5E41 VA: 0x1DF5D40
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5DE0 Offset: 0x1DF5EE1 VA: 0x1DF5DE0
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object, object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27AC0 Offset: 0x27BC1 VA: 0x27AC0
private struct UniTask.WhenAllPromise.<RunTask1Async>d__13<T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 4975
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T1> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this; // 0x0
	private UniTask.Awaiter<T1> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3159890 Offset: 0x3159991 VA: 0x3159890
	|-UniTask.WhenAllPromise.<RunTask1Async>d__13<object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B4C0 Offset: 0x2B5C1 VA: 0x2B4C0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3159C00 Offset: 0x3159D01 VA: 0x3159C00
	|-UniTask.WhenAllPromise.<RunTask1Async>d__13<object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27AD0 Offset: 0x27BD1 VA: 0x27AD0
private struct UniTask.WhenAllPromise.<RunTask2Async>d__15<T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 4976
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T2> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this; // 0x0
	private UniTask.Awaiter<T2> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315C670 Offset: 0x315C771 VA: 0x315C670
	|-UniTask.WhenAllPromise.<RunTask2Async>d__15<object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B4D0 Offset: 0x2B5D1 VA: 0x2B4D0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315C9E0 Offset: 0x315CAE1 VA: 0x315C9E0
	|-UniTask.WhenAllPromise.<RunTask2Async>d__15<object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27AE0 Offset: 0x27BE1 VA: 0x27AE0
private struct UniTask.WhenAllPromise.<RunTask3Async>d__17<T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 4977
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T3> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this; // 0x0
	private UniTask.Awaiter<T3> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315E9C0 Offset: 0x315EAC1 VA: 0x315E9C0
	|-UniTask.WhenAllPromise.<RunTask3Async>d__17<object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B4E0 Offset: 0x2B5E1 VA: 0x2B4E0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315ED30 Offset: 0x315EE31 VA: 0x315ED30
	|-UniTask.WhenAllPromise.<RunTask3Async>d__17<object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27AF0 Offset: 0x27BF1 VA: 0x27AF0
private struct UniTask.WhenAllPromise.<RunTask4Async>d__19<T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 4978
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T4> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this; // 0x0
	private UniTask.Awaiter<T4> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3160600 Offset: 0x3160701 VA: 0x3160600
	|-UniTask.WhenAllPromise.<RunTask4Async>d__19<object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B4F0 Offset: 0x2B5F1 VA: 0x2B4F0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3160970 Offset: 0x3160A71 VA: 0x3160970
	|-UniTask.WhenAllPromise.<RunTask4Async>d__19<object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27B00 Offset: 0x27C01 VA: 0x27B00
private struct UniTask.WhenAllPromise.<RunTask5Async>d__21<T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 4979
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T5> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this; // 0x0
	private UniTask.Awaiter<T5> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3161B30 Offset: 0x3161C31 VA: 0x3161B30
	|-UniTask.WhenAllPromise.<RunTask5Async>d__21<object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B500 Offset: 0x2B601 VA: 0x2B500
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3161EA0 Offset: 0x3161FA1 VA: 0x3161EA0
	|-UniTask.WhenAllPromise.<RunTask5Async>d__21<object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27B10 Offset: 0x27C11 VA: 0x27B10
private struct UniTask.WhenAllPromise.<RunTask6Async>d__23<T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 4980
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T6> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6> <>4__this; // 0x0
	private UniTask.Awaiter<T6> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3162950 Offset: 0x3162A51 VA: 0x3162950
	|-UniTask.WhenAllPromise.<RunTask6Async>d__23<object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B510 Offset: 0x2B611 VA: 0x2B510
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3162CC0 Offset: 0x3162DC1 VA: 0x3162CC0
	|-UniTask.WhenAllPromise.<RunTask6Async>d__23<object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6> // TypeDefIndex: 4981
{
	// Fields
	private const int MaxCount = 6;
	private T1 result1; // 0x0
	private T2 result2; // 0x0
	private T3 result3; // 0x0
	private T4 result4; // 0x0
	private T5 result5; // 0x0
	private T6 result6; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private int completeCount; // 0x0
	private Action whenComplete; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDFDE0 Offset: 0x2FDFEE1 VA: 0x2FDFDE0
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDFF60 Offset: 0x2FE0061 VA: 0x2FDFF60
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>.TryCallContinuation
	*/

	// RVA: -1 Offset: -1
	private void RunTask1(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDFF90 Offset: 0x2FE0091 VA: 0x2FDFF90
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>.RunTask1
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B220 Offset: 0x2B321 VA: 0x2B220
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask1Async(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE00F0 Offset: 0x2FE01F1 VA: 0x2FE00F0
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>.RunTask1Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask2(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE01C0 Offset: 0x2FE02C1 VA: 0x2FE01C0
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>.RunTask2
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B290 Offset: 0x2B391 VA: 0x2B290
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask2Async(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE0320 Offset: 0x2FE0421 VA: 0x2FE0320
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>.RunTask2Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask3(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE03F0 Offset: 0x2FE04F1 VA: 0x2FE03F0
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>.RunTask3
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B300 Offset: 0x2B401 VA: 0x2B300
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask3Async(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE0550 Offset: 0x2FE0651 VA: 0x2FE0550
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>.RunTask3Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask4(UniTask<T4> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE0620 Offset: 0x2FE0721 VA: 0x2FE0620
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>.RunTask4
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B370 Offset: 0x2B471 VA: 0x2B370
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask4Async(UniTask<T4> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE0780 Offset: 0x2FE0881 VA: 0x2FE0780
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>.RunTask4Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask5(UniTask<T5> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE0850 Offset: 0x2FE0951 VA: 0x2FE0850
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>.RunTask5
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B3E0 Offset: 0x2B4E1 VA: 0x2B3E0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask5Async(UniTask<T5> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE09B0 Offset: 0x2FE0AB1 VA: 0x2FE09B0
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>.RunTask5Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask6(UniTask<T6> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE0A80 Offset: 0x2FE0B81 VA: 0x2FE0A80
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>.RunTask6
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B450 Offset: 0x2B551 VA: 0x2B450
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask6Async(UniTask<T6> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE0BE0 Offset: 0x2FE0CE1 VA: 0x2FE0BE0
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>.RunTask6Async
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAllPromise.Awaiter<T1, T2, T3, T4, T5, T6> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE0CB0 Offset: 0x2FE0DB1 VA: 0x2FE0CB0
	|-UniTask.WhenAllPromise<object, object, object, object, object, object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAllPromise.Awaiter<T1, T2, T3, T4, T5, T6, T7> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4982
{
	// Fields
	private UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF62C0 Offset: 0x1DF63C1 VA: 0x1DF62C0
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF62D0 Offset: 0x1DF63D1 VA: 0x1DF62D0
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<T1, T2, T3, T4, T5, T6, T7> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF6300 Offset: 0x1DF6401 VA: 0x1DF6300
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF63F0 Offset: 0x1DF64F1 VA: 0x1DF63F0
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object, object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF6490 Offset: 0x1DF6591 VA: 0x1DF6490
	|-UniTask.WhenAllPromise.Awaiter<object, object, object, object, object, object, object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27B20 Offset: 0x27C21 VA: 0x27B20
private struct UniTask.WhenAllPromise.<RunTask1Async>d__14<T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 4983
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T1> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T1> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3159C10 Offset: 0x3159D11 VA: 0x3159C10
	|-UniTask.WhenAllPromise.<RunTask1Async>d__14<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B830 Offset: 0x2B931 VA: 0x2B830
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3159F80 Offset: 0x315A081 VA: 0x3159F80
	|-UniTask.WhenAllPromise.<RunTask1Async>d__14<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27B30 Offset: 0x27C31 VA: 0x27B30
private struct UniTask.WhenAllPromise.<RunTask2Async>d__16<T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 4984
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T2> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T2> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315C9F0 Offset: 0x315CAF1 VA: 0x315C9F0
	|-UniTask.WhenAllPromise.<RunTask2Async>d__16<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B840 Offset: 0x2B941 VA: 0x2B840
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315CD60 Offset: 0x315CE61 VA: 0x315CD60
	|-UniTask.WhenAllPromise.<RunTask2Async>d__16<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27B40 Offset: 0x27C41 VA: 0x27B40
private struct UniTask.WhenAllPromise.<RunTask3Async>d__18<T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 4985
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T3> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T3> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315ED40 Offset: 0x315EE41 VA: 0x315ED40
	|-UniTask.WhenAllPromise.<RunTask3Async>d__18<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B850 Offset: 0x2B951 VA: 0x2B850
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315F0B0 Offset: 0x315F1B1 VA: 0x315F0B0
	|-UniTask.WhenAllPromise.<RunTask3Async>d__18<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27B50 Offset: 0x27C51 VA: 0x27B50
private struct UniTask.WhenAllPromise.<RunTask4Async>d__20<T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 4986
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T4> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T4> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3160980 Offset: 0x3160A81 VA: 0x3160980
	|-UniTask.WhenAllPromise.<RunTask4Async>d__20<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B860 Offset: 0x2B961 VA: 0x2B860
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3160CF0 Offset: 0x3160DF1 VA: 0x3160CF0
	|-UniTask.WhenAllPromise.<RunTask4Async>d__20<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27B60 Offset: 0x27C61 VA: 0x27B60
private struct UniTask.WhenAllPromise.<RunTask5Async>d__22<T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 4987
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T5> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T5> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3161EB0 Offset: 0x3161FB1 VA: 0x3161EB0
	|-UniTask.WhenAllPromise.<RunTask5Async>d__22<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B870 Offset: 0x2B971 VA: 0x2B870
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3162220 Offset: 0x3162321 VA: 0x3162220
	|-UniTask.WhenAllPromise.<RunTask5Async>d__22<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27B70 Offset: 0x27C71 VA: 0x27B70
private struct UniTask.WhenAllPromise.<RunTask6Async>d__24<T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 4988
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T6> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T6> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3162CD0 Offset: 0x3162DD1 VA: 0x3162CD0
	|-UniTask.WhenAllPromise.<RunTask6Async>d__24<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B880 Offset: 0x2B981 VA: 0x2B880
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3163040 Offset: 0x3163141 VA: 0x3163040
	|-UniTask.WhenAllPromise.<RunTask6Async>d__24<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27B80 Offset: 0x27C81 VA: 0x27B80
private struct UniTask.WhenAllPromise.<RunTask7Async>d__26<T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 4989
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T7> task; // 0x0
	public UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T7> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31633E0 Offset: 0x31634E1 VA: 0x31633E0
	|-UniTask.WhenAllPromise.<RunTask7Async>d__26<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B890 Offset: 0x2B991 VA: 0x2B890
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3163750 Offset: 0x3163851 VA: 0x3163750
	|-UniTask.WhenAllPromise.<RunTask7Async>d__26<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> // TypeDefIndex: 4990
{
	// Fields
	private const int MaxCount = 7;
	private T1 result1; // 0x0
	private T2 result2; // 0x0
	private T3 result3; // 0x0
	private T4 result4; // 0x0
	private T5 result5; // 0x0
	private T6 result6; // 0x0
	private T7 result7; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private int completeCount; // 0x0
	private Action whenComplete; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE0CE0 Offset: 0x2FE0DE1 VA: 0x2FE0CE0
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE0E80 Offset: 0x2FE0F81 VA: 0x2FE0E80
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.TryCallContinuation
	*/

	// RVA: -1 Offset: -1
	private void RunTask1(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE0EB0 Offset: 0x2FE0FB1 VA: 0x2FE0EB0
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.RunTask1
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B520 Offset: 0x2B621 VA: 0x2B520
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask1Async(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE1010 Offset: 0x2FE1111 VA: 0x2FE1010
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.RunTask1Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask2(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE10E0 Offset: 0x2FE11E1 VA: 0x2FE10E0
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.RunTask2
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B590 Offset: 0x2B691 VA: 0x2B590
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask2Async(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE1240 Offset: 0x2FE1341 VA: 0x2FE1240
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.RunTask2Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask3(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE1310 Offset: 0x2FE1411 VA: 0x2FE1310
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.RunTask3
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B600 Offset: 0x2B701 VA: 0x2B600
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask3Async(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE1470 Offset: 0x2FE1571 VA: 0x2FE1470
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.RunTask3Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask4(UniTask<T4> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE1540 Offset: 0x2FE1641 VA: 0x2FE1540
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.RunTask4
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B670 Offset: 0x2B771 VA: 0x2B670
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask4Async(UniTask<T4> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE16A0 Offset: 0x2FE17A1 VA: 0x2FE16A0
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.RunTask4Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask5(UniTask<T5> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE1770 Offset: 0x2FE1871 VA: 0x2FE1770
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.RunTask5
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B6E0 Offset: 0x2B7E1 VA: 0x2B6E0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask5Async(UniTask<T5> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE18D0 Offset: 0x2FE19D1 VA: 0x2FE18D0
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.RunTask5Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask6(UniTask<T6> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE19A0 Offset: 0x2FE1AA1 VA: 0x2FE19A0
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.RunTask6
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B750 Offset: 0x2B851 VA: 0x2B750
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask6Async(UniTask<T6> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE1B00 Offset: 0x2FE1C01 VA: 0x2FE1B00
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.RunTask6Async
	*/

	// RVA: -1 Offset: -1
	private void RunTask7(UniTask<T7> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE1BD0 Offset: 0x2FE1CD1 VA: 0x2FE1BD0
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.RunTask7
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B7C0 Offset: 0x2B8C1 VA: 0x2B7C0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask7Async(UniTask<T7> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE1D30 Offset: 0x2FE1E31 VA: 0x2FE1D30
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.RunTask7Async
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAllPromise.Awaiter<T1, T2, T3, T4, T5, T6, T7> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE1E00 Offset: 0x2FE1F01 VA: 0x2FE1E00
	|-UniTask.WhenAllPromise<object, object, object, object, object, object, object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAllPromise.Awaiter<T> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4991
{
	// Fields
	private UniTask.WhenAllPromise<T> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAllPromise<T> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF2800 Offset: 0x1DF2901 VA: 0x1DF2800
	|-UniTask.WhenAllPromise.Awaiter<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF2810 Offset: 0x1DF2911 VA: 0x1DF2810
	|-UniTask.WhenAllPromise.Awaiter<object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public T[] GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF2840 Offset: 0x1DF2941 VA: 0x1DF2840
	|-UniTask.WhenAllPromise.Awaiter<object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF2880 Offset: 0x1DF2981 VA: 0x1DF2880
	|-UniTask.WhenAllPromise.Awaiter<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF2930 Offset: 0x1DF2A31 VA: 0x1DF2930
	|-UniTask.WhenAllPromise.Awaiter<object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27B90 Offset: 0x27C91 VA: 0x27B90
private struct UniTask.WhenAllPromise.<RunTask>d__6<T> : IAsyncStateMachine // TypeDefIndex: 4992
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T> task; // 0x0
	public UniTask.WhenAllPromise<T> <>4__this; // 0x0
	public int index; // 0x0
	private UniTask.Awaiter<T> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3163760 Offset: 0x3163861 VA: 0x3163760
	|-UniTask.WhenAllPromise.<RunTask>d__6<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2B910 Offset: 0x2BA11 VA: 0x2B910
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3163AF0 Offset: 0x3163BF1 VA: 0x3163AF0
	|-UniTask.WhenAllPromise.<RunTask>d__6<object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAllPromise<T> // TypeDefIndex: 4993
{
	// Fields
	private readonly T[] result; // 0x0
	private int completeCount; // 0x0
	private Action whenComplete; // 0x0
	private ExceptionDispatchInfo exception; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T>[] tasks, int tasksLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDD5D0 Offset: 0x2FDD6D1 VA: 0x2FDD5D0
	|-UniTask.WhenAllPromise<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDD8A0 Offset: 0x2FDD9A1 VA: 0x2FDD8A0
	|-UniTask.WhenAllPromise<object>.TryCallContinuation
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B8A0 Offset: 0x2B9A1 VA: 0x2B8A0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask(UniTask<T> task, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDD8D0 Offset: 0x2FDD9D1 VA: 0x2FDD8D0
	|-UniTask.WhenAllPromise<object>.RunTask
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAllPromise.Awaiter<T> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDD9A0 Offset: 0x2FDDAA1 VA: 0x2FDD9A0
	|-UniTask.WhenAllPromise<object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAllPromise.Awaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4994
{
	// Fields
	private UniTask.WhenAllPromise parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x1C2EF80 Offset: 0x1C2F081 VA: 0x1C2EF80
	public void .ctor(UniTask.WhenAllPromise parent) { }

	// RVA: 0x1C288E0 Offset: 0x1C289E1 VA: 0x1C288E0
	public bool get_IsCompleted() { }

	// RVA: 0x1C28910 Offset: 0x1C28A11 VA: 0x1C28910
	public void GetResult() { }

	// RVA: 0x1C2EF90 Offset: 0x1C2F091 VA: 0x1C2EF90 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1C2EFF0 Offset: 0x1C2F0F1 VA: 0x1C2EFF0 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27BA0 Offset: 0x27CA1 VA: 0x27BA0
private struct UniTask.WhenAllPromise.<RunTask>d__6 : IAsyncStateMachine // TypeDefIndex: 4995
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x8
	public UniTask task; // 0x10
	public UniTask.WhenAllPromise <>4__this; // 0x18
	private UniTask.Awaiter <>u__1; // 0x20

	// Methods

	// RVA: 0x1C2ECB0 Offset: 0x1C2EDB1 VA: 0x1C2ECB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2B990 Offset: 0x2BA91 VA: 0x2B990
	// RVA: 0x1C2EF70 Offset: 0x1C2F071 VA: 0x1C2EF70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
private class UniTask.WhenAllPromise // TypeDefIndex: 4996
{
	// Fields
	private int completeCount; // 0x10
	private int resultLength; // 0x14
	private Action whenComplete; // 0x18
	private ExceptionDispatchInfo exception; // 0x20

	// Methods

	// RVA: 0x1C28670 Offset: 0x1C28771 VA: 0x1C28670
	public void .ctor(UniTask[] tasks, int tasksLength) { }

	// RVA: 0x1C2A270 Offset: 0x1C2A371 VA: 0x1C2A270
	private void TryCallContinuation() { }

	[AsyncStateMachineAttribute] // RVA: 0x2B920 Offset: 0x2BA21 VA: 0x2B920
	// RVA: 0x1C2A2A0 Offset: 0x1C2A3A1 VA: 0x1C2A2A0
	private UniTaskVoid RunTask(UniTask task, int index) { }

	// RVA: 0x1C288B0 Offset: 0x1C289B1 VA: 0x1C288B0
	public UniTask.WhenAllPromise.Awaiter GetAwaiter() { }
}

// Namespace: 
public struct UniTask.WhenAnyPromise.Awaiter<T0, T1> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 4997
{
	// Fields
	private UniTask.WhenAnyPromise<T0, T1> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAnyPromise<T0, T1> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF47A0 Offset: 0x1DF48A1 VA: 0x1DF47A0
	|-UniTask.WhenAnyPromise.Awaiter<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF47B0 Offset: 0x1DF48B1 VA: 0x1DF47B0
	|-UniTask.WhenAnyPromise.Awaiter<object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4830 Offset: 0x1DF4931 VA: 0x1DF4830
	|-UniTask.WhenAnyPromise.Awaiter<object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4970 Offset: 0x1DF4A71 VA: 0x1DF4970
	|-UniTask.WhenAnyPromise.Awaiter<object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF49C0 Offset: 0x1DF4AC1 VA: 0x1DF49C0
	|-UniTask.WhenAnyPromise.Awaiter<object, object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27BB0 Offset: 0x27CB1 VA: 0x27BB0
private struct UniTask.WhenAnyPromise.<RunTask0>d__10<T0, T1> : IAsyncStateMachine // TypeDefIndex: 4998
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T0> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1> <>4__this; // 0x0
	private UniTask.Awaiter<T0> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31547D0 Offset: 0x31548D1 VA: 0x31547D0
	|-UniTask.WhenAnyPromise.<RunTask0>d__10<object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2BA80 Offset: 0x2BB81 VA: 0x2BA80
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3154B50 Offset: 0x3154C51 VA: 0x3154B50
	|-UniTask.WhenAnyPromise.<RunTask0>d__10<object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27BC0 Offset: 0x27CC1 VA: 0x27BC0
private struct UniTask.WhenAnyPromise.<RunTask1>d__11<T0, T1> : IAsyncStateMachine // TypeDefIndex: 4999
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T1> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1> <>4__this; // 0x0
	private UniTask.Awaiter<T1> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3157520 Offset: 0x3157621 VA: 0x3157520
	|-UniTask.WhenAnyPromise.<RunTask1>d__11<object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2BA90 Offset: 0x2BB91 VA: 0x2BA90
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31578A0 Offset: 0x31579A1 VA: 0x31578A0
	|-UniTask.WhenAnyPromise.<RunTask1>d__11<object, object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAnyPromise<T0, T1> // TypeDefIndex: 5000
{
	// Fields
	private T0 result0; // 0x0
	private T1 result1; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private Action whenComplete; // 0x0
	private int completeCount; // 0x0
	private int winArgumentIndex; // 0x0

	// Properties
	private bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	private bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE28C0 Offset: 0x2FE29C1 VA: 0x2FE28C0
	|-UniTask.WhenAnyPromise<object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T0> task0, UniTask<T1> task1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2900 Offset: 0x2FE2A01 VA: 0x2FE2900
	|-UniTask.WhenAnyPromise<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE29E0 Offset: 0x2FE2AE1 VA: 0x2FE29E0
	|-UniTask.WhenAnyPromise<object, object>.TryCallContinuation
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2B9A0 Offset: 0x2BAA1 VA: 0x2B9A0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask0(UniTask<T0> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2A10 Offset: 0x2FE2B11 VA: 0x2FE2A10
	|-UniTask.WhenAnyPromise<object, object>.RunTask0
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2BA10 Offset: 0x2BB11 VA: 0x2BA10
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask1(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2AE0 Offset: 0x2FE2BE1 VA: 0x2FE2AE0
	|-UniTask.WhenAnyPromise<object, object>.RunTask1
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAnyPromise.Awaiter<T0, T1> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2BB0 Offset: 0x2FE2CB1 VA: 0x2FE2BB0
	|-UniTask.WhenAnyPromise<object, object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAnyPromise.Awaiter<T0, T1, T2> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5001
{
	// Fields
	private UniTask.WhenAnyPromise<T0, T1, T2> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAnyPromise<T0, T1, T2> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4CB0 Offset: 0x1DF4DB1 VA: 0x1DF4CB0
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4CC0 Offset: 0x1DF4DC1 VA: 0x1DF4CC0
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4D40 Offset: 0x1DF4E41 VA: 0x1DF4D40
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4EE0 Offset: 0x1DF4FE1 VA: 0x1DF4EE0
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF4F30 Offset: 0x1DF5031 VA: 0x1DF4F30
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27BD0 Offset: 0x27CD1 VA: 0x27BD0
private struct UniTask.WhenAnyPromise.<RunTask0>d__11<T0, T1, T2> : IAsyncStateMachine // TypeDefIndex: 5002
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T0> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2> <>4__this; // 0x0
	private UniTask.Awaiter<T0> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3154B60 Offset: 0x3154C61 VA: 0x3154B60
	|-UniTask.WhenAnyPromise.<RunTask0>d__11<object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2BBF0 Offset: 0x2BCF1 VA: 0x2BBF0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3154EE0 Offset: 0x3154FE1 VA: 0x3154EE0
	|-UniTask.WhenAnyPromise.<RunTask0>d__11<object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27BE0 Offset: 0x27CE1 VA: 0x27BE0
private struct UniTask.WhenAnyPromise.<RunTask1>d__12<T0, T1, T2> : IAsyncStateMachine // TypeDefIndex: 5003
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T1> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2> <>4__this; // 0x0
	private UniTask.Awaiter<T1> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31578B0 Offset: 0x31579B1 VA: 0x31578B0
	|-UniTask.WhenAnyPromise.<RunTask1>d__12<object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2BC00 Offset: 0x2BD01 VA: 0x2BC00
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3157C30 Offset: 0x3157D31 VA: 0x3157C30
	|-UniTask.WhenAnyPromise.<RunTask1>d__12<object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27BF0 Offset: 0x27CF1 VA: 0x27BF0
private struct UniTask.WhenAnyPromise.<RunTask2>d__13<T0, T1, T2> : IAsyncStateMachine // TypeDefIndex: 5004
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T2> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2> <>4__this; // 0x0
	private UniTask.Awaiter<T2> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315A310 Offset: 0x315A411 VA: 0x315A310
	|-UniTask.WhenAnyPromise.<RunTask2>d__13<object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2BC10 Offset: 0x2BD11 VA: 0x2BC10
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315A690 Offset: 0x315A791 VA: 0x315A690
	|-UniTask.WhenAnyPromise.<RunTask2>d__13<object, object, object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAnyPromise<T0, T1, T2> // TypeDefIndex: 5005
{
	// Fields
	private T0 result0; // 0x0
	private T1 result1; // 0x0
	private T2 result2; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private Action whenComplete; // 0x0
	private int completeCount; // 0x0
	private int winArgumentIndex; // 0x0

	// Properties
	private bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	private bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2BE0 Offset: 0x2FE2CE1 VA: 0x2FE2BE0
	|-UniTask.WhenAnyPromise<object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2C20 Offset: 0x2FE2D21 VA: 0x2FE2C20
	|-UniTask.WhenAnyPromise<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2D40 Offset: 0x2FE2E41 VA: 0x2FE2D40
	|-UniTask.WhenAnyPromise<object, object, object>.TryCallContinuation
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2BAA0 Offset: 0x2BBA1 VA: 0x2BAA0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask0(UniTask<T0> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2D70 Offset: 0x2FE2E71 VA: 0x2FE2D70
	|-UniTask.WhenAnyPromise<object, object, object>.RunTask0
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2BB10 Offset: 0x2BC11 VA: 0x2BB10
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask1(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2E40 Offset: 0x2FE2F41 VA: 0x2FE2E40
	|-UniTask.WhenAnyPromise<object, object, object>.RunTask1
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2BB80 Offset: 0x2BC81 VA: 0x2BB80
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask2(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2F10 Offset: 0x2FE3011 VA: 0x2FE2F10
	|-UniTask.WhenAnyPromise<object, object, object>.RunTask2
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAnyPromise.Awaiter<T0, T1, T2> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2FE0 Offset: 0x2FE30E1 VA: 0x2FE2FE0
	|-UniTask.WhenAnyPromise<object, object, object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5006
{
	// Fields
	private UniTask.WhenAnyPromise<T0, T1, T2, T3> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAnyPromise<T0, T1, T2, T3> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5220 Offset: 0x1DF5321 VA: 0x1DF5220
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5230 Offset: 0x1DF5331 VA: 0x1DF5230
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF52B0 Offset: 0x1DF53B1 VA: 0x1DF52B0
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF54C0 Offset: 0x1DF55C1 VA: 0x1DF54C0
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5510 Offset: 0x1DF5611 VA: 0x1DF5510
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27C00 Offset: 0x27D01 VA: 0x27C00
private struct UniTask.WhenAnyPromise.<RunTask0>d__12<T0, T1, T2, T3> : IAsyncStateMachine // TypeDefIndex: 5007
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T0> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3> <>4__this; // 0x0
	private UniTask.Awaiter<T0> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3154EF0 Offset: 0x3154FF1 VA: 0x3154EF0
	|-UniTask.WhenAnyPromise.<RunTask0>d__12<object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2BDE0 Offset: 0x2BEE1 VA: 0x2BDE0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3155270 Offset: 0x3155371 VA: 0x3155270
	|-UniTask.WhenAnyPromise.<RunTask0>d__12<object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27C10 Offset: 0x27D11 VA: 0x27C10
private struct UniTask.WhenAnyPromise.<RunTask1>d__13<T0, T1, T2, T3> : IAsyncStateMachine // TypeDefIndex: 5008
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T1> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3> <>4__this; // 0x0
	private UniTask.Awaiter<T1> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3157C40 Offset: 0x3157D41 VA: 0x3157C40
	|-UniTask.WhenAnyPromise.<RunTask1>d__13<object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2BDF0 Offset: 0x2BEF1 VA: 0x2BDF0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3157FC0 Offset: 0x31580C1 VA: 0x3157FC0
	|-UniTask.WhenAnyPromise.<RunTask1>d__13<object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27C20 Offset: 0x27D21 VA: 0x27C20
private struct UniTask.WhenAnyPromise.<RunTask2>d__14<T0, T1, T2, T3> : IAsyncStateMachine // TypeDefIndex: 5009
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T2> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3> <>4__this; // 0x0
	private UniTask.Awaiter<T2> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315A6A0 Offset: 0x315A7A1 VA: 0x315A6A0
	|-UniTask.WhenAnyPromise.<RunTask2>d__14<object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2BE00 Offset: 0x2BF01 VA: 0x2BE00
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315AA20 Offset: 0x315AB21 VA: 0x315AA20
	|-UniTask.WhenAnyPromise.<RunTask2>d__14<object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27C30 Offset: 0x27D31 VA: 0x27C30
private struct UniTask.WhenAnyPromise.<RunTask3>d__15<T0, T1, T2, T3> : IAsyncStateMachine // TypeDefIndex: 5010
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T3> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3> <>4__this; // 0x0
	private UniTask.Awaiter<T3> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315CD70 Offset: 0x315CE71 VA: 0x315CD70
	|-UniTask.WhenAnyPromise.<RunTask3>d__15<object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2BE10 Offset: 0x2BF11 VA: 0x2BE10
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315D0F0 Offset: 0x315D1F1 VA: 0x315D0F0
	|-UniTask.WhenAnyPromise.<RunTask3>d__15<object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAnyPromise<T0, T1, T2, T3> // TypeDefIndex: 5011
{
	// Fields
	private T0 result0; // 0x0
	private T1 result1; // 0x0
	private T2 result2; // 0x0
	private T3 result3; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private Action whenComplete; // 0x0
	private int completeCount; // 0x0
	private int winArgumentIndex; // 0x0

	// Properties
	private bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	private bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3010 Offset: 0x2FE3111 VA: 0x2FE3010
	|-UniTask.WhenAnyPromise<object, object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3050 Offset: 0x2FE3151 VA: 0x2FE3050
	|-UniTask.WhenAnyPromise<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE31B0 Offset: 0x2FE32B1 VA: 0x2FE31B0
	|-UniTask.WhenAnyPromise<object, object, object, object>.TryCallContinuation
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2BC20 Offset: 0x2BD21 VA: 0x2BC20
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask0(UniTask<T0> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE31E0 Offset: 0x2FE32E1 VA: 0x2FE31E0
	|-UniTask.WhenAnyPromise<object, object, object, object>.RunTask0
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2BC90 Offset: 0x2BD91 VA: 0x2BC90
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask1(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE32B0 Offset: 0x2FE33B1 VA: 0x2FE32B0
	|-UniTask.WhenAnyPromise<object, object, object, object>.RunTask1
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2BD00 Offset: 0x2BE01 VA: 0x2BD00
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask2(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3380 Offset: 0x2FE3481 VA: 0x2FE3380
	|-UniTask.WhenAnyPromise<object, object, object, object>.RunTask2
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2BD70 Offset: 0x2BE71 VA: 0x2BD70
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask3(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3450 Offset: 0x2FE3551 VA: 0x2FE3450
	|-UniTask.WhenAnyPromise<object, object, object, object>.RunTask3
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3520 Offset: 0x2FE3621 VA: 0x2FE3520
	|-UniTask.WhenAnyPromise<object, object, object, object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3, T4> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5012
{
	// Fields
	private UniTask.WhenAnyPromise<T0, T1, T2, T3, T4> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAnyPromise<T0, T1, T2, T3, T4> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5820 Offset: 0x1DF5921 VA: 0x1DF5820
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5830 Offset: 0x1DF5931 VA: 0x1DF5830
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF58B0 Offset: 0x1DF59B1 VA: 0x1DF58B0
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5B00 Offset: 0x1DF5C01 VA: 0x1DF5B00
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5B50 Offset: 0x1DF5C51 VA: 0x1DF5B50
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27C40 Offset: 0x27D41 VA: 0x27C40
private struct UniTask.WhenAnyPromise.<RunTask0>d__13<T0, T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 5013
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T0> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this; // 0x0
	private UniTask.Awaiter<T0> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3155280 Offset: 0x3155381 VA: 0x3155280
	|-UniTask.WhenAnyPromise.<RunTask0>d__13<object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C050 Offset: 0x2C151 VA: 0x2C050
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3155600 Offset: 0x3155701 VA: 0x3155600
	|-UniTask.WhenAnyPromise.<RunTask0>d__13<object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27C50 Offset: 0x27D51 VA: 0x27C50
private struct UniTask.WhenAnyPromise.<RunTask1>d__14<T0, T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 5014
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T1> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this; // 0x0
	private UniTask.Awaiter<T1> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3157FD0 Offset: 0x31580D1 VA: 0x3157FD0
	|-UniTask.WhenAnyPromise.<RunTask1>d__14<object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C060 Offset: 0x2C161 VA: 0x2C060
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3158350 Offset: 0x3158451 VA: 0x3158350
	|-UniTask.WhenAnyPromise.<RunTask1>d__14<object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27C60 Offset: 0x27D61 VA: 0x27C60
private struct UniTask.WhenAnyPromise.<RunTask2>d__15<T0, T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 5015
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T2> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this; // 0x0
	private UniTask.Awaiter<T2> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315AA30 Offset: 0x315AB31 VA: 0x315AA30
	|-UniTask.WhenAnyPromise.<RunTask2>d__15<object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C070 Offset: 0x2C171 VA: 0x2C070
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315ADB0 Offset: 0x315AEB1 VA: 0x315ADB0
	|-UniTask.WhenAnyPromise.<RunTask2>d__15<object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27C70 Offset: 0x27D71 VA: 0x27C70
private struct UniTask.WhenAnyPromise.<RunTask3>d__16<T0, T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 5016
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T3> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this; // 0x0
	private UniTask.Awaiter<T3> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315D100 Offset: 0x315D201 VA: 0x315D100
	|-UniTask.WhenAnyPromise.<RunTask3>d__16<object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C080 Offset: 0x2C181 VA: 0x2C080
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315D480 Offset: 0x315D581 VA: 0x315D480
	|-UniTask.WhenAnyPromise.<RunTask3>d__16<object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27C80 Offset: 0x27D81 VA: 0x27C80
private struct UniTask.WhenAnyPromise.<RunTask4>d__17<T0, T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 5017
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T4> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4> <>4__this; // 0x0
	private UniTask.Awaiter<T4> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315F0C0 Offset: 0x315F1C1 VA: 0x315F0C0
	|-UniTask.WhenAnyPromise.<RunTask4>d__17<object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C090 Offset: 0x2C191 VA: 0x2C090
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315F440 Offset: 0x315F541 VA: 0x315F440
	|-UniTask.WhenAnyPromise.<RunTask4>d__17<object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAnyPromise<T0, T1, T2, T3, T4> // TypeDefIndex: 5018
{
	// Fields
	private T0 result0; // 0x0
	private T1 result1; // 0x0
	private T2 result2; // 0x0
	private T3 result3; // 0x0
	private T4 result4; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private Action whenComplete; // 0x0
	private int completeCount; // 0x0
	private int winArgumentIndex; // 0x0

	// Properties
	private bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	private bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3550 Offset: 0x2FE3651 VA: 0x2FE3550
	|-UniTask.WhenAnyPromise<object, object, object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3590 Offset: 0x2FE3691 VA: 0x2FE3590
	|-UniTask.WhenAnyPromise<object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3730 Offset: 0x2FE3831 VA: 0x2FE3730
	|-UniTask.WhenAnyPromise<object, object, object, object, object>.TryCallContinuation
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2BE20 Offset: 0x2BF21 VA: 0x2BE20
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask0(UniTask<T0> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3760 Offset: 0x2FE3861 VA: 0x2FE3760
	|-UniTask.WhenAnyPromise<object, object, object, object, object>.RunTask0
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2BE90 Offset: 0x2BF91 VA: 0x2BE90
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask1(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3830 Offset: 0x2FE3931 VA: 0x2FE3830
	|-UniTask.WhenAnyPromise<object, object, object, object, object>.RunTask1
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2BF00 Offset: 0x2C001 VA: 0x2BF00
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask2(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3900 Offset: 0x2FE3A01 VA: 0x2FE3900
	|-UniTask.WhenAnyPromise<object, object, object, object, object>.RunTask2
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2BF70 Offset: 0x2C071 VA: 0x2BF70
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask3(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE39D0 Offset: 0x2FE3AD1 VA: 0x2FE39D0
	|-UniTask.WhenAnyPromise<object, object, object, object, object>.RunTask3
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2BFE0 Offset: 0x2C0E1 VA: 0x2BFE0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask4(UniTask<T4> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3AA0 Offset: 0x2FE3BA1 VA: 0x2FE3AA0
	|-UniTask.WhenAnyPromise<object, object, object, object, object>.RunTask4
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3, T4> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3B70 Offset: 0x2FE3C71 VA: 0x2FE3B70
	|-UniTask.WhenAnyPromise<object, object, object, object, object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3, T4, T5> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5019
{
	// Fields
	private UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5E60 Offset: 0x1DF5F61 VA: 0x1DF5E60
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5E70 Offset: 0x1DF5F71 VA: 0x1DF5E70
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF5EF0 Offset: 0x1DF5FF1 VA: 0x1DF5EF0
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF6190 Offset: 0x1DF6291 VA: 0x1DF6190
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF61E0 Offset: 0x1DF62E1 VA: 0x1DF61E0
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27C90 Offset: 0x27D91 VA: 0x27C90
private struct UniTask.WhenAnyPromise.<RunTask0>d__14<T0, T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 5020
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T0> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this; // 0x0
	private UniTask.Awaiter<T0> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3155610 Offset: 0x3155711 VA: 0x3155610
	|-UniTask.WhenAnyPromise.<RunTask0>d__14<object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C340 Offset: 0x2C441 VA: 0x2C340
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3155990 Offset: 0x3155A91 VA: 0x3155990
	|-UniTask.WhenAnyPromise.<RunTask0>d__14<object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27CA0 Offset: 0x27DA1 VA: 0x27CA0
private struct UniTask.WhenAnyPromise.<RunTask1>d__15<T0, T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 5021
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T1> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this; // 0x0
	private UniTask.Awaiter<T1> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3158360 Offset: 0x3158461 VA: 0x3158360
	|-UniTask.WhenAnyPromise.<RunTask1>d__15<object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C350 Offset: 0x2C451 VA: 0x2C350
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31586E0 Offset: 0x31587E1 VA: 0x31586E0
	|-UniTask.WhenAnyPromise.<RunTask1>d__15<object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27CB0 Offset: 0x27DB1 VA: 0x27CB0
private struct UniTask.WhenAnyPromise.<RunTask2>d__16<T0, T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 5022
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T2> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this; // 0x0
	private UniTask.Awaiter<T2> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315ADC0 Offset: 0x315AEC1 VA: 0x315ADC0
	|-UniTask.WhenAnyPromise.<RunTask2>d__16<object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C360 Offset: 0x2C461 VA: 0x2C360
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315B140 Offset: 0x315B241 VA: 0x315B140
	|-UniTask.WhenAnyPromise.<RunTask2>d__16<object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27CC0 Offset: 0x27DC1 VA: 0x27CC0
private struct UniTask.WhenAnyPromise.<RunTask3>d__17<T0, T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 5023
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T3> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this; // 0x0
	private UniTask.Awaiter<T3> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315D490 Offset: 0x315D591 VA: 0x315D490
	|-UniTask.WhenAnyPromise.<RunTask3>d__17<object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C370 Offset: 0x2C471 VA: 0x2C370
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315D810 Offset: 0x315D911 VA: 0x315D810
	|-UniTask.WhenAnyPromise.<RunTask3>d__17<object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27CD0 Offset: 0x27DD1 VA: 0x27CD0
private struct UniTask.WhenAnyPromise.<RunTask4>d__18<T0, T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 5024
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T4> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this; // 0x0
	private UniTask.Awaiter<T4> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315F450 Offset: 0x315F551 VA: 0x315F450
	|-UniTask.WhenAnyPromise.<RunTask4>d__18<object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C380 Offset: 0x2C481 VA: 0x2C380
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315F7D0 Offset: 0x315F8D1 VA: 0x315F7D0
	|-UniTask.WhenAnyPromise.<RunTask4>d__18<object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27CE0 Offset: 0x27DE1 VA: 0x27CE0
private struct UniTask.WhenAnyPromise.<RunTask5>d__19<T0, T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 5025
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T5> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5> <>4__this; // 0x0
	private UniTask.Awaiter<T5> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3160D00 Offset: 0x3160E01 VA: 0x3160D00
	|-UniTask.WhenAnyPromise.<RunTask5>d__19<object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C390 Offset: 0x2C491 VA: 0x2C390
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3161080 Offset: 0x3161181 VA: 0x3161080
	|-UniTask.WhenAnyPromise.<RunTask5>d__19<object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5> // TypeDefIndex: 5026
{
	// Fields
	private T0 result0; // 0x0
	private T1 result1; // 0x0
	private T2 result2; // 0x0
	private T3 result3; // 0x0
	private T4 result4; // 0x0
	private T5 result5; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private Action whenComplete; // 0x0
	private int completeCount; // 0x0
	private int winArgumentIndex; // 0x0

	// Properties
	private bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	private bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3BA0 Offset: 0x2FE3CA1 VA: 0x2FE3BA0
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3BE0 Offset: 0x2FE3CE1 VA: 0x2FE3BE0
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3DC0 Offset: 0x2FE3EC1 VA: 0x2FE3DC0
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object>.TryCallContinuation
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C0A0 Offset: 0x2C1A1 VA: 0x2C0A0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask0(UniTask<T0> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3DF0 Offset: 0x2FE3EF1 VA: 0x2FE3DF0
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object>.RunTask0
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C110 Offset: 0x2C211 VA: 0x2C110
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask1(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3EC0 Offset: 0x2FE3FC1 VA: 0x2FE3EC0
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object>.RunTask1
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C180 Offset: 0x2C281 VA: 0x2C180
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask2(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE3F90 Offset: 0x2FE4091 VA: 0x2FE3F90
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object>.RunTask2
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C1F0 Offset: 0x2C2F1 VA: 0x2C1F0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask3(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4060 Offset: 0x2FE4161 VA: 0x2FE4060
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object>.RunTask3
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C260 Offset: 0x2C361 VA: 0x2C260
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask4(UniTask<T4> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4130 Offset: 0x2FE4231 VA: 0x2FE4130
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object>.RunTask4
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C2D0 Offset: 0x2C3D1 VA: 0x2C2D0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask5(UniTask<T5> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4200 Offset: 0x2FE4301 VA: 0x2FE4200
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object>.RunTask5
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3, T4, T5> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE42D0 Offset: 0x2FE43D1 VA: 0x2FE42D0
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3, T4, T5, T6> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5027
{
	// Fields
	private UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF6510 Offset: 0x1DF6611 VA: 0x1DF6510
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF6520 Offset: 0x1DF6621 VA: 0x1DF6520
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF65A0 Offset: 0x1DF66A1 VA: 0x1DF65A0
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF68C0 Offset: 0x1DF69C1 VA: 0x1DF68C0
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF6910 Offset: 0x1DF6A11 VA: 0x1DF6910
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object, object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27CF0 Offset: 0x27DF1 VA: 0x27CF0
private struct UniTask.WhenAnyPromise.<RunTask0>d__15<T0, T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 5028
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T0> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this; // 0x0
	private UniTask.Awaiter<T0> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31559A0 Offset: 0x3155AA1 VA: 0x31559A0
	|-UniTask.WhenAnyPromise.<RunTask0>d__15<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C6B0 Offset: 0x2C7B1 VA: 0x2C6B0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3155D20 Offset: 0x3155E21 VA: 0x3155D20
	|-UniTask.WhenAnyPromise.<RunTask0>d__15<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27D00 Offset: 0x27E01 VA: 0x27D00
private struct UniTask.WhenAnyPromise.<RunTask1>d__16<T0, T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 5029
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T1> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this; // 0x0
	private UniTask.Awaiter<T1> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31586F0 Offset: 0x31587F1 VA: 0x31586F0
	|-UniTask.WhenAnyPromise.<RunTask1>d__16<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C6C0 Offset: 0x2C7C1 VA: 0x2C6C0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3158A70 Offset: 0x3158B71 VA: 0x3158A70
	|-UniTask.WhenAnyPromise.<RunTask1>d__16<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27D10 Offset: 0x27E11 VA: 0x27D10
private struct UniTask.WhenAnyPromise.<RunTask2>d__17<T0, T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 5030
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T2> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this; // 0x0
	private UniTask.Awaiter<T2> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315B150 Offset: 0x315B251 VA: 0x315B150
	|-UniTask.WhenAnyPromise.<RunTask2>d__17<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C6D0 Offset: 0x2C7D1 VA: 0x2C6D0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315B4D0 Offset: 0x315B5D1 VA: 0x315B4D0
	|-UniTask.WhenAnyPromise.<RunTask2>d__17<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27D20 Offset: 0x27E21 VA: 0x27D20
private struct UniTask.WhenAnyPromise.<RunTask3>d__18<T0, T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 5031
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T3> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this; // 0x0
	private UniTask.Awaiter<T3> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315D820 Offset: 0x315D921 VA: 0x315D820
	|-UniTask.WhenAnyPromise.<RunTask3>d__18<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C6E0 Offset: 0x2C7E1 VA: 0x2C6E0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315DBA0 Offset: 0x315DCA1 VA: 0x315DBA0
	|-UniTask.WhenAnyPromise.<RunTask3>d__18<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27D30 Offset: 0x27E31 VA: 0x27D30
private struct UniTask.WhenAnyPromise.<RunTask4>d__19<T0, T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 5032
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T4> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this; // 0x0
	private UniTask.Awaiter<T4> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315F7E0 Offset: 0x315F8E1 VA: 0x315F7E0
	|-UniTask.WhenAnyPromise.<RunTask4>d__19<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C6F0 Offset: 0x2C7F1 VA: 0x2C6F0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315FB60 Offset: 0x315FC61 VA: 0x315FB60
	|-UniTask.WhenAnyPromise.<RunTask4>d__19<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27D40 Offset: 0x27E41 VA: 0x27D40
private struct UniTask.WhenAnyPromise.<RunTask5>d__20<T0, T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 5033
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T5> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this; // 0x0
	private UniTask.Awaiter<T5> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3161090 Offset: 0x3161191 VA: 0x3161090
	|-UniTask.WhenAnyPromise.<RunTask5>d__20<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C700 Offset: 0x2C801 VA: 0x2C700
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3161410 Offset: 0x3161511 VA: 0x3161410
	|-UniTask.WhenAnyPromise.<RunTask5>d__20<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27D50 Offset: 0x27E51 VA: 0x27D50
private struct UniTask.WhenAnyPromise.<RunTask6>d__21<T0, T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 5034
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T6> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> <>4__this; // 0x0
	private UniTask.Awaiter<T6> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3162230 Offset: 0x3162331 VA: 0x3162230
	|-UniTask.WhenAnyPromise.<RunTask6>d__21<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2C710 Offset: 0x2C811 VA: 0x2C710
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31625B0 Offset: 0x31626B1 VA: 0x31625B0
	|-UniTask.WhenAnyPromise.<RunTask6>d__21<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6> // TypeDefIndex: 5035
{
	// Fields
	private T0 result0; // 0x0
	private T1 result1; // 0x0
	private T2 result2; // 0x0
	private T3 result3; // 0x0
	private T4 result4; // 0x0
	private T5 result5; // 0x0
	private T6 result6; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private Action whenComplete; // 0x0
	private int completeCount; // 0x0
	private int winArgumentIndex; // 0x0

	// Properties
	private bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	private bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4300 Offset: 0x2FE4401 VA: 0x2FE4300
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4340 Offset: 0x2FE4441 VA: 0x2FE4340
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4560 Offset: 0x2FE4661 VA: 0x2FE4560
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object>.TryCallContinuation
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C3A0 Offset: 0x2C4A1 VA: 0x2C3A0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask0(UniTask<T0> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4590 Offset: 0x2FE4691 VA: 0x2FE4590
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object>.RunTask0
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C410 Offset: 0x2C511 VA: 0x2C410
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask1(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4660 Offset: 0x2FE4761 VA: 0x2FE4660
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object>.RunTask1
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C480 Offset: 0x2C581 VA: 0x2C480
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask2(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4730 Offset: 0x2FE4831 VA: 0x2FE4730
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object>.RunTask2
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C4F0 Offset: 0x2C5F1 VA: 0x2C4F0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask3(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4800 Offset: 0x2FE4901 VA: 0x2FE4800
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object>.RunTask3
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C560 Offset: 0x2C661 VA: 0x2C560
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask4(UniTask<T4> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE48D0 Offset: 0x2FE49D1 VA: 0x2FE48D0
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object>.RunTask4
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C5D0 Offset: 0x2C6D1 VA: 0x2C5D0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask5(UniTask<T5> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE49A0 Offset: 0x2FE4AA1 VA: 0x2FE49A0
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object>.RunTask5
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C640 Offset: 0x2C741 VA: 0x2C640
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask6(UniTask<T6> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4A70 Offset: 0x2FE4B71 VA: 0x2FE4A70
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object>.RunTask6
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3, T4, T5, T6> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4B40 Offset: 0x2FE4C41 VA: 0x2FE4B40
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3, T4, T5, T6, T7> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5036
{
	// Fields
	private UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF69F0 Offset: 0x1DF6AF1 VA: 0x1DF69F0
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF6A00 Offset: 0x1DF6B01 VA: 0x1DF6A00
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF6A80 Offset: 0x1DF6B81 VA: 0x1DF6A80
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object, object, object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF6DF0 Offset: 0x1DF6EF1 VA: 0x1DF6DF0
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object, object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF6E40 Offset: 0x1DF6F41 VA: 0x1DF6E40
	|-UniTask.WhenAnyPromise.Awaiter<object, object, object, object, object, object, object, object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27D60 Offset: 0x27E61 VA: 0x27D60
private struct UniTask.WhenAnyPromise.<RunTask0>d__16<T0, T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 5037
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T0> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T0> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3155D30 Offset: 0x3155E31 VA: 0x3155D30
	|-UniTask.WhenAnyPromise.<RunTask0>d__16<object, object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CAA0 Offset: 0x2CBA1 VA: 0x2CAA0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31560B0 Offset: 0x31561B1 VA: 0x31560B0
	|-UniTask.WhenAnyPromise.<RunTask0>d__16<object, object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27D70 Offset: 0x27E71 VA: 0x27D70
private struct UniTask.WhenAnyPromise.<RunTask1>d__17<T0, T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 5038
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T1> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T1> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3158A80 Offset: 0x3158B81 VA: 0x3158A80
	|-UniTask.WhenAnyPromise.<RunTask1>d__17<object, object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CAB0 Offset: 0x2CBB1 VA: 0x2CAB0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3158E00 Offset: 0x3158F01 VA: 0x3158E00
	|-UniTask.WhenAnyPromise.<RunTask1>d__17<object, object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27D80 Offset: 0x27E81 VA: 0x27D80
private struct UniTask.WhenAnyPromise.<RunTask2>d__18<T0, T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 5039
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T2> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T2> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315B4E0 Offset: 0x315B5E1 VA: 0x315B4E0
	|-UniTask.WhenAnyPromise.<RunTask2>d__18<object, object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CAC0 Offset: 0x2CBC1 VA: 0x2CAC0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315B860 Offset: 0x315B961 VA: 0x315B860
	|-UniTask.WhenAnyPromise.<RunTask2>d__18<object, object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27D90 Offset: 0x27E91 VA: 0x27D90
private struct UniTask.WhenAnyPromise.<RunTask3>d__19<T0, T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 5040
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T3> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T3> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315DBB0 Offset: 0x315DCB1 VA: 0x315DBB0
	|-UniTask.WhenAnyPromise.<RunTask3>d__19<object, object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CAD0 Offset: 0x2CBD1 VA: 0x2CAD0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315DF30 Offset: 0x315E031 VA: 0x315DF30
	|-UniTask.WhenAnyPromise.<RunTask3>d__19<object, object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27DA0 Offset: 0x27EA1 VA: 0x27DA0
private struct UniTask.WhenAnyPromise.<RunTask4>d__20<T0, T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 5041
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T4> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T4> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315FB70 Offset: 0x315FC71 VA: 0x315FB70
	|-UniTask.WhenAnyPromise.<RunTask4>d__20<object, object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CAE0 Offset: 0x2CBE1 VA: 0x2CAE0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x315FEF0 Offset: 0x315FFF1 VA: 0x315FEF0
	|-UniTask.WhenAnyPromise.<RunTask4>d__20<object, object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27DB0 Offset: 0x27EB1 VA: 0x27DB0
private struct UniTask.WhenAnyPromise.<RunTask5>d__21<T0, T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 5042
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T5> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T5> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3161420 Offset: 0x3161521 VA: 0x3161420
	|-UniTask.WhenAnyPromise.<RunTask5>d__21<object, object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CAF0 Offset: 0x2CBF1 VA: 0x2CAF0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31617A0 Offset: 0x31618A1 VA: 0x31617A0
	|-UniTask.WhenAnyPromise.<RunTask5>d__21<object, object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27DC0 Offset: 0x27EC1 VA: 0x27DC0
private struct UniTask.WhenAnyPromise.<RunTask6>d__22<T0, T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 5043
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T6> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T6> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31625C0 Offset: 0x31626C1 VA: 0x31625C0
	|-UniTask.WhenAnyPromise.<RunTask6>d__22<object, object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CB00 Offset: 0x2CC01 VA: 0x2CB00
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3162940 Offset: 0x3162A41 VA: 0x3162940
	|-UniTask.WhenAnyPromise.<RunTask6>d__22<object, object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27DD0 Offset: 0x27ED1 VA: 0x27DD0
private struct UniTask.WhenAnyPromise.<RunTask7>d__23<T0, T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 5044
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T7> task; // 0x0
	public UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> <>4__this; // 0x0
	private UniTask.Awaiter<T7> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3163050 Offset: 0x3163151 VA: 0x3163050
	|-UniTask.WhenAnyPromise.<RunTask7>d__23<object, object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CB10 Offset: 0x2CC11 VA: 0x2CB10
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31633D0 Offset: 0x31634D1 VA: 0x31633D0
	|-UniTask.WhenAnyPromise.<RunTask7>d__23<object, object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAnyPromise<T0, T1, T2, T3, T4, T5, T6, T7> // TypeDefIndex: 5045
{
	// Fields
	private T0 result0; // 0x0
	private T1 result1; // 0x0
	private T2 result2; // 0x0
	private T3 result3; // 0x0
	private T4 result4; // 0x0
	private T5 result5; // 0x0
	private T6 result6; // 0x0
	private T7 result7; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private Action whenComplete; // 0x0
	private int completeCount; // 0x0
	private int winArgumentIndex; // 0x0

	// Properties
	private bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	private bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4B70 Offset: 0x2FE4C71 VA: 0x2FE4B70
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4BB0 Offset: 0x2FE4CB1 VA: 0x2FE4BB0
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4E10 Offset: 0x2FE4F11 VA: 0x2FE4E10
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object, object>.TryCallContinuation
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C720 Offset: 0x2C821 VA: 0x2C720
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask0(UniTask<T0> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4E40 Offset: 0x2FE4F41 VA: 0x2FE4E40
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object, object>.RunTask0
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C790 Offset: 0x2C891 VA: 0x2C790
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask1(UniTask<T1> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4F10 Offset: 0x2FE5011 VA: 0x2FE4F10
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object, object>.RunTask1
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C800 Offset: 0x2C901 VA: 0x2C800
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask2(UniTask<T2> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE4FE0 Offset: 0x2FE50E1 VA: 0x2FE4FE0
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object, object>.RunTask2
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C870 Offset: 0x2C971 VA: 0x2C870
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask3(UniTask<T3> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE50B0 Offset: 0x2FE51B1 VA: 0x2FE50B0
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object, object>.RunTask3
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C8E0 Offset: 0x2C9E1 VA: 0x2C8E0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask4(UniTask<T4> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE5180 Offset: 0x2FE5281 VA: 0x2FE5180
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object, object>.RunTask4
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C950 Offset: 0x2CA51 VA: 0x2C950
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask5(UniTask<T5> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE5250 Offset: 0x2FE5351 VA: 0x2FE5250
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object, object>.RunTask5
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2C9C0 Offset: 0x2CAC1 VA: 0x2C9C0
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask6(UniTask<T6> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE5320 Offset: 0x2FE5421 VA: 0x2FE5320
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object, object>.RunTask6
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2CA30 Offset: 0x2CB31 VA: 0x2CA30
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask7(UniTask<T7> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE53F0 Offset: 0x2FE54F1 VA: 0x2FE53F0
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object, object>.RunTask7
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3, T4, T5, T6, T7> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE54C0 Offset: 0x2FE55C1 VA: 0x2FE54C0
	|-UniTask.WhenAnyPromise<object, object, object, object, object, object, object, object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.UnitWhenAnyPromise.Awaiter<T0> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5046
{
	// Fields
	private UniTask.UnitWhenAnyPromise<T0> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.UnitWhenAnyPromise<T0> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DE9B40 Offset: 0x1DE9C41 VA: 0x1DE9B40
	|-UniTask.UnitWhenAnyPromise.Awaiter<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x1DEB7E0 Offset: 0x1DEB8E1 VA: 0x1DEB7E0
	|-UniTask.UnitWhenAnyPromise.Awaiter<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1DF25B0 Offset: 0x1DF26B1 VA: 0x1DF25B0
	|-UniTask.UnitWhenAnyPromise.Awaiter<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DE9B50 Offset: 0x1DE9C51 VA: 0x1DE9B50
	|-UniTask.UnitWhenAnyPromise.Awaiter<ValueTuple<bool, AsyncUnit>>.get_IsCompleted
	|
	|-RVA: 0x1DEB7F0 Offset: 0x1DEB8F1 VA: 0x1DEB7F0
	|-UniTask.UnitWhenAnyPromise.Awaiter<ValueTuple<bool, object>>.get_IsCompleted
	|
	|-RVA: 0x1DF25C0 Offset: 0x1DF26C1 VA: 0x1DF25C0
	|-UniTask.UnitWhenAnyPromise.Awaiter<object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<bool, T0> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DE9BD0 Offset: 0x1DE9CD1 VA: 0x1DE9BD0
	|-UniTask.UnitWhenAnyPromise.Awaiter<ValueTuple<bool, AsyncUnit>>.GetResult
	|
	|-RVA: 0x1DEB870 Offset: 0x1DEB971 VA: 0x1DEB870
	|-UniTask.UnitWhenAnyPromise.Awaiter<ValueTuple<bool, object>>.GetResult
	|
	|-RVA: 0x1DF2640 Offset: 0x1DF2741 VA: 0x1DF2640
	|-UniTask.UnitWhenAnyPromise.Awaiter<object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DE9C60 Offset: 0x1DE9D61 VA: 0x1DE9C60
	|-UniTask.UnitWhenAnyPromise.Awaiter<ValueTuple<bool, AsyncUnit>>.OnCompleted
	|
	|-RVA: 0x1DEB920 Offset: 0x1DEBA21 VA: 0x1DEB920
	|-UniTask.UnitWhenAnyPromise.Awaiter<ValueTuple<bool, object>>.OnCompleted
	|
	|-RVA: 0x1DF26D0 Offset: 0x1DF27D1 VA: 0x1DF26D0
	|-UniTask.UnitWhenAnyPromise.Awaiter<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DE9CB0 Offset: 0x1DE9DB1 VA: 0x1DE9CB0
	|-UniTask.UnitWhenAnyPromise.Awaiter<ValueTuple<bool, AsyncUnit>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEB970 Offset: 0x1DEBA71 VA: 0x1DEB970
	|-UniTask.UnitWhenAnyPromise.Awaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF2720 Offset: 0x1DF2821 VA: 0x1DF2720
	|-UniTask.UnitWhenAnyPromise.Awaiter<object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27DE0 Offset: 0x27EE1 VA: 0x27DE0
private struct UniTask.UnitWhenAnyPromise.<RunTask0>d__9<T0> : IAsyncStateMachine // TypeDefIndex: 5047
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T0> task; // 0x0
	public UniTask.UnitWhenAnyPromise<T0> <>4__this; // 0x0
	private UniTask.Awaiter<T0> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31560C0 Offset: 0x31561C1 VA: 0x31560C0
	|-UniTask.UnitWhenAnyPromise.<RunTask0>d__9<ValueTuple<bool, AsyncUnit>>.MoveNext
	|
	|-RVA: 0x3156440 Offset: 0x3156541 VA: 0x3156440
	|-UniTask.UnitWhenAnyPromise.<RunTask0>d__9<ValueTuple<bool, object>>.MoveNext
	|
	|-RVA: 0x3156800 Offset: 0x3156901 VA: 0x3156800
	|-UniTask.UnitWhenAnyPromise.<RunTask0>d__9<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CC00 Offset: 0x2CD01 VA: 0x2CC00
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3156430 Offset: 0x3156531 VA: 0x3156430
	|-UniTask.UnitWhenAnyPromise.<RunTask0>d__9<ValueTuple<bool, AsyncUnit>>.SetStateMachine
	|
	|-RVA: 0x31567F0 Offset: 0x31568F1 VA: 0x31567F0
	|-UniTask.UnitWhenAnyPromise.<RunTask0>d__9<ValueTuple<bool, object>>.SetStateMachine
	|
	|-RVA: 0x3156B80 Offset: 0x3156C81 VA: 0x3156B80
	|-UniTask.UnitWhenAnyPromise.<RunTask0>d__9<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27DF0 Offset: 0x27EF1 VA: 0x27DF0
private struct UniTask.UnitWhenAnyPromise.<RunTask1>d__10<T0> : IAsyncStateMachine // TypeDefIndex: 5048
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask task; // 0x0
	public UniTask.UnitWhenAnyPromise<T0> <>4__this; // 0x0
	private UniTask.Awaiter <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3156B90 Offset: 0x3156C91 VA: 0x3156B90
	|-UniTask.UnitWhenAnyPromise.<RunTask1>d__10<ValueTuple<bool, AsyncUnit>>.MoveNext
	|
	|-RVA: 0x3156EC0 Offset: 0x3156FC1 VA: 0x3156EC0
	|-UniTask.UnitWhenAnyPromise.<RunTask1>d__10<ValueTuple<bool, object>>.MoveNext
	|
	|-RVA: 0x31571F0 Offset: 0x31572F1 VA: 0x31571F0
	|-UniTask.UnitWhenAnyPromise.<RunTask1>d__10<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CC10 Offset: 0x2CD11 VA: 0x2CC10
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3156EB0 Offset: 0x3156FB1 VA: 0x3156EB0
	|-UniTask.UnitWhenAnyPromise.<RunTask1>d__10<ValueTuple<bool, AsyncUnit>>.SetStateMachine
	|
	|-RVA: 0x31571E0 Offset: 0x31572E1 VA: 0x31571E0
	|-UniTask.UnitWhenAnyPromise.<RunTask1>d__10<ValueTuple<bool, object>>.SetStateMachine
	|
	|-RVA: 0x3157510 Offset: 0x3157611 VA: 0x3157510
	|-UniTask.UnitWhenAnyPromise.<RunTask1>d__10<object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.UnitWhenAnyPromise<T0> // TypeDefIndex: 5049
{
	// Fields
	private T0 result0; // 0x0
	private ExceptionDispatchInfo exception; // 0x0
	private Action whenComplete; // 0x0
	private int completeCount; // 0x0
	private int winArgumentIndex; // 0x0

	// Properties
	private bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	private bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF1700 Offset: 0x2DF1801 VA: 0x2DF1700
	|-UniTask.UnitWhenAnyPromise<ValueTuple<bool, AsyncUnit>>.get_IsCompleted
	|
	|-RVA: 0x2DF1A00 Offset: 0x2DF1B01 VA: 0x2DF1A00
	|-UniTask.UnitWhenAnyPromise<ValueTuple<bool, object>>.get_IsCompleted
	|
	|-RVA: 0x2DF1D10 Offset: 0x2DF1E11 VA: 0x2DF1D10
	|-UniTask.UnitWhenAnyPromise<object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T0> task0, UniTask task1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF1740 Offset: 0x2DF1841 VA: 0x2DF1740
	|-UniTask.UnitWhenAnyPromise<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x2DF1A40 Offset: 0x2DF1B41 VA: 0x2DF1A40
	|-UniTask.UnitWhenAnyPromise<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2DF1D50 Offset: 0x2DF1E51 VA: 0x2DF1D50
	|-UniTask.UnitWhenAnyPromise<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF1810 Offset: 0x2DF1911 VA: 0x2DF1810
	|-UniTask.UnitWhenAnyPromise<ValueTuple<bool, AsyncUnit>>.TryCallContinuation
	|
	|-RVA: 0x2DF1B20 Offset: 0x2DF1C21 VA: 0x2DF1B20
	|-UniTask.UnitWhenAnyPromise<ValueTuple<bool, object>>.TryCallContinuation
	|
	|-RVA: 0x2DF1E20 Offset: 0x2DF1F21 VA: 0x2DF1E20
	|-UniTask.UnitWhenAnyPromise<object>.TryCallContinuation
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2CB20 Offset: 0x2CC21 VA: 0x2CB20
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask0(UniTask<T0> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF1840 Offset: 0x2DF1941 VA: 0x2DF1840
	|-UniTask.UnitWhenAnyPromise<ValueTuple<bool, AsyncUnit>>.RunTask0
	|
	|-RVA: 0x2DF1B50 Offset: 0x2DF1C51 VA: 0x2DF1B50
	|-UniTask.UnitWhenAnyPromise<ValueTuple<bool, object>>.RunTask0
	|
	|-RVA: 0x2DF1E50 Offset: 0x2DF1F51 VA: 0x2DF1E50
	|-UniTask.UnitWhenAnyPromise<object>.RunTask0
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2CB90 Offset: 0x2CC91 VA: 0x2CB90
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask1(UniTask task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF1910 Offset: 0x2DF1A11 VA: 0x2DF1910
	|-UniTask.UnitWhenAnyPromise<ValueTuple<bool, AsyncUnit>>.RunTask1
	|
	|-RVA: 0x2DF1C20 Offset: 0x2DF1D21 VA: 0x2DF1C20
	|-UniTask.UnitWhenAnyPromise<ValueTuple<bool, object>>.RunTask1
	|
	|-RVA: 0x2DF1F20 Offset: 0x2DF2021 VA: 0x2DF1F20
	|-UniTask.UnitWhenAnyPromise<object>.RunTask1
	*/

	// RVA: -1 Offset: -1
	public UniTask.UnitWhenAnyPromise.Awaiter<T0> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF19D0 Offset: 0x2DF1AD1 VA: 0x2DF19D0
	|-UniTask.UnitWhenAnyPromise<ValueTuple<bool, AsyncUnit>>.GetAwaiter
	|
	|-RVA: 0x2DF1CE0 Offset: 0x2DF1DE1 VA: 0x2DF1CE0
	|-UniTask.UnitWhenAnyPromise<ValueTuple<bool, object>>.GetAwaiter
	|
	|-RVA: 0x2DF1FE0 Offset: 0x2DF20E1 VA: 0x2DF1FE0
	|-UniTask.UnitWhenAnyPromise<object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAnyPromise.Awaiter<T> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5050
{
	// Fields
	private UniTask.WhenAnyPromise<T> parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTask.WhenAnyPromise<T> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF29B0 Offset: 0x1DF2AB1 VA: 0x1DF29B0
	|-UniTask.WhenAnyPromise.Awaiter<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF29C0 Offset: 0x1DF2AC1 VA: 0x1DF29C0
	|-UniTask.WhenAnyPromise.Awaiter<object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public ValueTuple<int, T> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF2A40 Offset: 0x1DF2B41 VA: 0x1DF2A40
	|-UniTask.WhenAnyPromise.Awaiter<object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF2AD0 Offset: 0x1DF2BD1 VA: 0x1DF2AD0
	|-UniTask.WhenAnyPromise.Awaiter<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF2B20 Offset: 0x1DF2C21 VA: 0x1DF2B20
	|-UniTask.WhenAnyPromise.Awaiter<object>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27E00 Offset: 0x27F01 VA: 0x27E00
private struct UniTask.WhenAnyPromise.<RunTask>d__8<T> : IAsyncStateMachine // TypeDefIndex: 5051
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T> task; // 0x0
	public UniTask.WhenAnyPromise<T> <>4__this; // 0x0
	public int index; // 0x0
	private UniTask.Awaiter<T> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3163B00 Offset: 0x3163C01 VA: 0x3163B00
	|-UniTask.WhenAnyPromise.<RunTask>d__8<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CC90 Offset: 0x2CD91 VA: 0x2CC90
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3163E80 Offset: 0x3163F81 VA: 0x3163E80
	|-UniTask.WhenAnyPromise.<RunTask>d__8<object>.SetStateMachine
	*/
}

// Namespace: 
private class UniTask.WhenAnyPromise<T> // TypeDefIndex: 5052
{
	// Fields
	private T result; // 0x0
	private int completeCount; // 0x0
	private int winArgumentIndex; // 0x0
	private Action whenComplete; // 0x0
	private ExceptionDispatchInfo exception; // 0x0

	// Properties
	public bool IsComplete { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_IsComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2670 Offset: 0x2FE2771 VA: 0x2FE2670
	|-UniTask.WhenAnyPromise<object>.get_IsComplete
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE26B0 Offset: 0x2FE27B1 VA: 0x2FE26B0
	|-UniTask.WhenAnyPromise<object>..ctor
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2CC20 Offset: 0x2CD21 VA: 0x2CC20
	// RVA: -1 Offset: -1
	private UniTaskVoid RunTask(UniTask<T> task, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2790 Offset: 0x2FE2891 VA: 0x2FE2790
	|-UniTask.WhenAnyPromise<object>.RunTask
	*/

	// RVA: -1 Offset: -1
	private void TryCallContinuation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2860 Offset: 0x2FE2961 VA: 0x2FE2860
	|-UniTask.WhenAnyPromise<object>.TryCallContinuation
	*/

	// RVA: -1 Offset: -1
	public UniTask.WhenAnyPromise.Awaiter<T> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2890 Offset: 0x2FE2991 VA: 0x2FE2890
	|-UniTask.WhenAnyPromise<object>.GetAwaiter
	*/
}

// Namespace: 
public struct UniTask.WhenAnyPromise.Awaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5053
{
	// Fields
	private UniTask.WhenAnyPromise parent; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x1C2F320 Offset: 0x1C2F421 VA: 0x1C2F320
	public void .ctor(UniTask.WhenAnyPromise parent) { }

	// RVA: 0x1C28ED0 Offset: 0x1C28FD1 VA: 0x1C28ED0
	public bool get_IsCompleted() { }

	// RVA: 0x1C28F20 Offset: 0x1C29021 VA: 0x1C28F20
	public int GetResult() { }

	// RVA: 0x1C2F330 Offset: 0x1C2F431 VA: 0x1C2F330 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1C2F3B0 Offset: 0x1C2F4B1 VA: 0x1C2F3B0 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27E10 Offset: 0x27F11 VA: 0x27E10
private struct UniTask.WhenAnyPromise.<RunTask>d__7 : IAsyncStateMachine // TypeDefIndex: 5054
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x8
	public UniTask task; // 0x10
	public UniTask.WhenAnyPromise <>4__this; // 0x18
	public int index; // 0x20
	private UniTask.Awaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x1C2F050 Offset: 0x1C2F151 VA: 0x1C2F050 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD10 Offset: 0x2CE11 VA: 0x2CD10
	// RVA: 0x1C2F310 Offset: 0x1C2F411 VA: 0x1C2F310 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
private class UniTask.WhenAnyPromise // TypeDefIndex: 5055
{
	// Fields
	private int completeCount; // 0x10
	private int winArgumentIndex; // 0x14
	private Action whenComplete; // 0x18
	private ExceptionDispatchInfo exception; // 0x20

	// Properties
	public bool IsComplete { get; }

	// Methods

	// RVA: 0x1C2A380 Offset: 0x1C2A481 VA: 0x1C2A380
	public bool get_IsComplete() { }

	// RVA: 0x1C28DE0 Offset: 0x1C28EE1 VA: 0x1C28DE0
	public void .ctor(UniTask[] tasks) { }

	[AsyncStateMachineAttribute] // RVA: 0x2CCA0 Offset: 0x2CDA1 VA: 0x2CCA0
	// RVA: 0x1C2A3C0 Offset: 0x1C2A4C1 VA: 0x1C2A3C0
	private UniTaskVoid RunTask(UniTask task, int index) { }

	// RVA: 0x1C2A4B0 Offset: 0x1C2A5B1 VA: 0x1C2A4B0
	private void TryCallContinuation() { }

	// RVA: 0x1C28EA0 Offset: 0x1C28FA1 VA: 0x1C28EA0
	public UniTask.WhenAnyPromise.Awaiter GetAwaiter() { }
}

// Namespace: 
private class UniTask.AsyncUnitAwaiter : IAwaiter<AsyncUnit>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5056
{
	// Fields
	private readonly IAwaiter awaiter; // 0x10

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: 0x1C28FC0 Offset: 0x1C290C1 VA: 0x1C28FC0
	public void .ctor(IAwaiter awaiter) { }

	// RVA: 0x1C29000 Offset: 0x1C29101 VA: 0x1C29000 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x1C290B0 Offset: 0x1C291B1 VA: 0x1C290B0 Slot: 5
	public AwaiterStatus get_Status() { }

	// RVA: 0x1C29160 Offset: 0x1C29261 VA: 0x1C29160 Slot: 4
	public AsyncUnit GetResult() { }

	// RVA: 0x1C29250 Offset: 0x1C29351 VA: 0x1C29250 Slot: 9
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1C29300 Offset: 0x1C29401 VA: 0x1C29300 Slot: 8
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x1C293B0 Offset: 0x1C294B1 VA: 0x1C293B0 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }
}

// Namespace: 
private class UniTask.IsCanceledAwaiter : IAwaiter<bool>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5057
{
	// Fields
	private readonly IAwaiter awaiter; // 0x10

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: 0x1C29A30 Offset: 0x1C29B31 VA: 0x1C29A30
	public void .ctor(IAwaiter awaiter) { }

	// RVA: 0x1C29A70 Offset: 0x1C29B71 VA: 0x1C29A70 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x1C29B20 Offset: 0x1C29C21 VA: 0x1C29B20 Slot: 5
	public AwaiterStatus get_Status() { }

	// RVA: 0x1C29BD0 Offset: 0x1C29CD1 VA: 0x1C29BD0 Slot: 4
	public bool GetResult() { }

	// RVA: 0x1C29D00 Offset: 0x1C29E01 VA: 0x1C29D00 Slot: 9
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1C29DB0 Offset: 0x1C29EB1 VA: 0x1C29DB0 Slot: 8
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x1C29E60 Offset: 0x1C29F61 VA: 0x1C29E60 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }
}

// Namespace: 
public struct UniTask.Awaiter : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5058
{
	// Fields
	private readonly UniTask task; // 0x0

	// Properties
	[DebuggerHiddenAttribute] // RVA: 0x2F2A0 Offset: 0x2F3A1 VA: 0x2F2A0
	public bool IsCompleted { get; }
	[DebuggerHiddenAttribute] // RVA: 0x2F2B0 Offset: 0x2F3B1 VA: 0x2F2B0
	public AwaiterStatus Status { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CD20 Offset: 0x2CE21 VA: 0x2CD20
	// RVA: 0x1C29460 Offset: 0x1C29561 VA: 0x1C29460
	public void .ctor(UniTask task) { }

	// RVA: 0x1C29470 Offset: 0x1C29571 VA: 0x1C29470 Slot: 5
	public bool get_IsCompleted() { }

	// RVA: 0x1C294A0 Offset: 0x1C295A1 VA: 0x1C294A0 Slot: 4
	public AwaiterStatus get_Status() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD30 Offset: 0x2CE31 VA: 0x2CD30
	// RVA: 0x1C294D0 Offset: 0x1C295D1 VA: 0x1C294D0 Slot: 6
	public void GetResult() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD40 Offset: 0x2CE41 VA: 0x2CD40
	// RVA: 0x1C29500 Offset: 0x1C29601 VA: 0x1C29500 Slot: 8
	public void OnCompleted(Action continuation) { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD50 Offset: 0x2CE51 VA: 0x2CD50
	// RVA: 0x1C295D0 Offset: 0x1C296D1 VA: 0x1C295D0 Slot: 7
	public void UnsafeOnCompleted(Action continuation) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27E20 Offset: 0x27F21 VA: 0x27E20
private struct UniTask.<Run>d__24 : IAsyncStateMachine // TypeDefIndex: 5059
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public Action action; // 0x18
	public bool configureAwait; // 0x20
	private SwitchToThreadPoolAwaitable.Awaiter <>u__1; // 0x21
	private YieldAwaitable.Awaiter <>u__2; // 0x24

	// Methods

	// RVA: 0x2E90CC0 Offset: 0x2E90DC1 VA: 0x2E90CC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD60 Offset: 0x2CE61 VA: 0x2CD60
	// RVA: 0x2E90EF0 Offset: 0x2E90FF1 VA: 0x2E90EF0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27E30 Offset: 0x27F31 VA: 0x27E30
private struct UniTask.<Run>d__25 : IAsyncStateMachine // TypeDefIndex: 5060
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public Action<object> action; // 0x18
	public object state; // 0x20
	public bool configureAwait; // 0x28
	private SwitchToThreadPoolAwaitable.Awaiter <>u__1; // 0x29
	private YieldAwaitable.Awaiter <>u__2; // 0x2C

	// Methods

	// RVA: 0x2E90F00 Offset: 0x2E91001 VA: 0x2E90F00 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD70 Offset: 0x2CE71 VA: 0x2CD70
	// RVA: 0x2E91140 Offset: 0x2E91241 VA: 0x2E91140 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27E40 Offset: 0x27F41 VA: 0x27E40
private struct UniTask.<Run>d__26<T> : IAsyncStateMachine // TypeDefIndex: 5061
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<T> <>t__builder; // 0x0
	public Func<T> func; // 0x0
	public bool configureAwait; // 0x0
	private T <result>5__2; // 0x0
	private SwitchToThreadPoolAwaitable.Awaiter <>u__1; // 0x0
	private YieldAwaitable.Awaiter <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153E40 Offset: 0x3153F41 VA: 0x3153E40
	|-UniTask.<Run>d__26<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CD80 Offset: 0x2CE81 VA: 0x2CD80
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3154190 Offset: 0x3154291 VA: 0x3154190
	|-UniTask.<Run>d__26<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27E50 Offset: 0x27F51 VA: 0x27E50
private struct UniTask.<Run>d__27<T> : IAsyncStateMachine // TypeDefIndex: 5062
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<T> <>t__builder; // 0x0
	public Func<object, T> func; // 0x0
	public object state; // 0x0
	public bool configureAwait; // 0x0
	private T <result>5__2; // 0x0
	private SwitchToThreadPoolAwaitable.Awaiter <>u__1; // 0x0
	private YieldAwaitable.Awaiter <>u__2; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31541E0 Offset: 0x31542E1 VA: 0x31541E0
	|-UniTask.<Run>d__27<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CD90 Offset: 0x2CE91 VA: 0x2CD90
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3154530 Offset: 0x3154631 VA: 0x3154530
	|-UniTask.<Run>d__27<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27E60 Offset: 0x27F61 VA: 0x27E60
private struct UniTask.<WhenAll>d__39<T1, T2> : IAsyncStateMachine // TypeDefIndex: 5063
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x28520 Offset: 0x28621 VA: 0x28520
	public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2>> <>t__builder; // 0x0
	public UniTask<T1> task1; // 0x0
	public UniTask<T2> task2; // 0x0
	private UniTask.WhenAllPromise.Awaiter<T1, T2> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBDE00 Offset: 0x1FBDF01 VA: 0x1FBDE00
	|-UniTask.<WhenAll>d__39<object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CDA0 Offset: 0x2CEA1 VA: 0x2CDA0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBE0D0 Offset: 0x1FBE1D1 VA: 0x1FBE0D0
	|-UniTask.<WhenAll>d__39<object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27E70 Offset: 0x27F71 VA: 0x27E70
private struct UniTask.<WhenAll>d__40<T1, T2, T3> : IAsyncStateMachine // TypeDefIndex: 5064
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x285D0 Offset: 0x286D1 VA: 0x285D0
	public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3>> <>t__builder; // 0x0
	public UniTask<T1> task1; // 0x0
	public UniTask<T2> task2; // 0x0
	public UniTask<T3> task3; // 0x0
	private UniTask.WhenAllPromise.Awaiter<T1, T2, T3> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBE120 Offset: 0x1FBE221 VA: 0x1FBE120
	|-UniTask.<WhenAll>d__40<object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CDB0 Offset: 0x2CEB1 VA: 0x2CDB0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBE430 Offset: 0x1FBE531 VA: 0x1FBE430
	|-UniTask.<WhenAll>d__40<object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27E80 Offset: 0x27F81 VA: 0x27E80
private struct UniTask.<WhenAll>d__41<T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 5065
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x28690 Offset: 0x28791 VA: 0x28690
	public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4>> <>t__builder; // 0x0
	public UniTask<T1> task1; // 0x0
	public UniTask<T2> task2; // 0x0
	public UniTask<T3> task3; // 0x0
	public UniTask<T4> task4; // 0x0
	private UniTask.WhenAllPromise.Awaiter<T1, T2, T3, T4> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBE480 Offset: 0x1FBE581 VA: 0x1FBE480
	|-UniTask.<WhenAll>d__41<object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CDC0 Offset: 0x2CEC1 VA: 0x2CDC0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBE7B0 Offset: 0x1FBE8B1 VA: 0x1FBE7B0
	|-UniTask.<WhenAll>d__41<object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27E90 Offset: 0x27F91 VA: 0x27E90
private struct UniTask.<WhenAll>d__42<T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 5066
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x28770 Offset: 0x28871 VA: 0x28770
	public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4, T5>> <>t__builder; // 0x0
	public UniTask<T1> task1; // 0x0
	public UniTask<T2> task2; // 0x0
	public UniTask<T3> task3; // 0x0
	public UniTask<T4> task4; // 0x0
	public UniTask<T5> task5; // 0x0
	private UniTask.WhenAllPromise.Awaiter<T1, T2, T3, T4, T5> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBE800 Offset: 0x1FBE901 VA: 0x1FBE800
	|-UniTask.<WhenAll>d__42<object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CDD0 Offset: 0x2CED1 VA: 0x2CDD0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBEB60 Offset: 0x1FBEC61 VA: 0x1FBEB60
	|-UniTask.<WhenAll>d__42<object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27EA0 Offset: 0x27FA1 VA: 0x27EA0
private struct UniTask.<WhenAll>d__43<T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 5067
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x28870 Offset: 0x28971 VA: 0x28870
	public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4, T5, T6>> <>t__builder; // 0x0
	public UniTask<T1> task1; // 0x0
	public UniTask<T2> task2; // 0x0
	public UniTask<T3> task3; // 0x0
	public UniTask<T4> task4; // 0x0
	public UniTask<T5> task5; // 0x0
	public UniTask<T6> task6; // 0x0
	private UniTask.WhenAllPromise.Awaiter<T1, T2, T3, T4, T5, T6> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBEBB0 Offset: 0x1FBECB1 VA: 0x1FBEBB0
	|-UniTask.<WhenAll>d__43<object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CDE0 Offset: 0x2CEE1 VA: 0x2CDE0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBEF20 Offset: 0x1FBF021 VA: 0x1FBEF20
	|-UniTask.<WhenAll>d__43<object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27EB0 Offset: 0x27FB1 VA: 0x27EB0
private struct UniTask.<WhenAll>d__44<T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 5068
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x28990 Offset: 0x28A91 VA: 0x28990
	public AsyncUniTaskMethodBuilder<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> <>t__builder; // 0x0
	public UniTask<T1> task1; // 0x0
	public UniTask<T2> task2; // 0x0
	public UniTask<T3> task3; // 0x0
	public UniTask<T4> task4; // 0x0
	public UniTask<T5> task5; // 0x0
	public UniTask<T6> task6; // 0x0
	public UniTask<T7> task7; // 0x0
	private UniTask.WhenAllPromise.Awaiter<T1, T2, T3, T4, T5, T6, T7> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBEF70 Offset: 0x1FBF071 VA: 0x1FBEF70
	|-UniTask.<WhenAll>d__44<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CDF0 Offset: 0x2CEF1 VA: 0x2CDF0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBF320 Offset: 0x1FBF421 VA: 0x1FBF320
	|-UniTask.<WhenAll>d__44<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27EC0 Offset: 0x27FC1 VA: 0x27EC0
private struct UniTask.<WhenAll>d__51<T> : IAsyncStateMachine // TypeDefIndex: 5069
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<T[]> <>t__builder; // 0x0
	public UniTask<T>[] tasks; // 0x0
	private UniTask.WhenAllPromise.Awaiter<T> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBF370 Offset: 0x1FBF471 VA: 0x1FBF370
	|-UniTask.<WhenAll>d__51<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CE00 Offset: 0x2CF01 VA: 0x2CE00
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBF630 Offset: 0x1FBF731 VA: 0x1FBF630
	|-UniTask.<WhenAll>d__51<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27ED0 Offset: 0x27FD1 VA: 0x27ED0
private struct UniTask.<WhenAll>d__52<T> : IAsyncStateMachine // TypeDefIndex: 5070
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<T[]> <>t__builder; // 0x0
	public IEnumerable<UniTask<T>> tasks; // 0x0
	private UniTask.WhenAllPromise.Awaiter<T> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBF680 Offset: 0x1FBF781 VA: 0x1FBF680
	|-UniTask.<WhenAll>d__52<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CE10 Offset: 0x2CF11 VA: 0x2CE10
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBFB20 Offset: 0x1FBFC21 VA: 0x1FBFB20
	|-UniTask.<WhenAll>d__52<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27EE0 Offset: 0x27FE1 VA: 0x27EE0
private struct UniTask.<WhenAll>d__53 : IAsyncStateMachine // TypeDefIndex: 5071
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public UniTask[] tasks; // 0x18
	private UniTask.WhenAllPromise.Awaiter <>u__1; // 0x20

	// Methods

	// RVA: 0x1C284B0 Offset: 0x1C285B1 VA: 0x1C284B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CE20 Offset: 0x2CF21 VA: 0x2CE20
	// RVA: 0x1C28930 Offset: 0x1C28A31 VA: 0x1C28930 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27EF0 Offset: 0x27FF1 VA: 0x27EF0
private struct UniTask.<WhenAll>d__54 : IAsyncStateMachine // TypeDefIndex: 5072
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder <>t__builder; // 0x8
	public IEnumerable<UniTask> tasks; // 0x18
	private UniTask.WhenAllPromise.Awaiter <>u__1; // 0x20

	// Methods

	// RVA: 0x1C28940 Offset: 0x1C28A41 VA: 0x1C28940 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CE30 Offset: 0x2CF31 VA: 0x2CE30
	// RVA: 0x1C28BE0 Offset: 0x1C28CE1 VA: 0x1C28BE0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27F00 Offset: 0x28001 VA: 0x27F00
private struct UniTask.<WhenAny>d__57<T0, T1> : IAsyncStateMachine // TypeDefIndex: 5073
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x28AC0 Offset: 0x28BC1 VA: 0x28AC0
	public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>>> <>t__builder; // 0x0
	public UniTask<T0> task0; // 0x0
	public UniTask<T1> task1; // 0x0
	private UniTask.WhenAnyPromise.Awaiter<T0, T1> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBFB70 Offset: 0x1FBFC71 VA: 0x1FBFB70
	|-UniTask.<WhenAny>d__57<object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CE40 Offset: 0x2CF41 VA: 0x2CE40
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBFEA0 Offset: 0x1FBFFA1 VA: 0x1FBFEA0
	|-UniTask.<WhenAny>d__57<object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27F10 Offset: 0x28011 VA: 0x27F10
private struct UniTask.<WhenAny>d__58<T0, T1, T2> : IAsyncStateMachine // TypeDefIndex: 5074
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x28BE0 Offset: 0x28CE1 VA: 0x28BE0
	public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>>> <>t__builder; // 0x0
	public UniTask<T0> task0; // 0x0
	public UniTask<T1> task1; // 0x0
	public UniTask<T2> task2; // 0x0
	private UniTask.WhenAnyPromise.Awaiter<T0, T1, T2> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBFEF0 Offset: 0x1FBFFF1 VA: 0x1FBFEF0
	|-UniTask.<WhenAny>d__58<object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CE50 Offset: 0x2CF51 VA: 0x2CE50
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC0240 Offset: 0x1FC0341 VA: 0x1FC0240
	|-UniTask.<WhenAny>d__58<object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27F20 Offset: 0x28021 VA: 0x27F20
private struct UniTask.<WhenAny>d__59<T0, T1, T2, T3> : IAsyncStateMachine // TypeDefIndex: 5075
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x28D40 Offset: 0x28E41 VA: 0x28D40
	public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>>> <>t__builder; // 0x0
	public UniTask<T0> task0; // 0x0
	public UniTask<T1> task1; // 0x0
	public UniTask<T2> task2; // 0x0
	public UniTask<T3> task3; // 0x0
	private UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC0290 Offset: 0x1FC0391 VA: 0x1FC0290
	|-UniTask.<WhenAny>d__59<object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CE60 Offset: 0x2CF61 VA: 0x2CE60
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC0620 Offset: 0x1FC0721 VA: 0x1FC0620
	|-UniTask.<WhenAny>d__59<object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27F30 Offset: 0x28031 VA: 0x27F30
private struct UniTask.<WhenAny>d__60<T0, T1, T2, T3, T4> : IAsyncStateMachine // TypeDefIndex: 5076
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x28EE0 Offset: 0x28FE1 VA: 0x28EE0
	public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>>> <>t__builder; // 0x0
	public UniTask<T0> task0; // 0x0
	public UniTask<T1> task1; // 0x0
	public UniTask<T2> task2; // 0x0
	public UniTask<T3> task3; // 0x0
	public UniTask<T4> task4; // 0x0
	private UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3, T4> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC0670 Offset: 0x1FC0771 VA: 0x1FC0670
	|-UniTask.<WhenAny>d__60<object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CE70 Offset: 0x2CF71 VA: 0x2CE70
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC0A20 Offset: 0x1FC0B21 VA: 0x1FC0A20
	|-UniTask.<WhenAny>d__60<object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27F40 Offset: 0x28041 VA: 0x27F40
private struct UniTask.<WhenAny>d__61<T0, T1, T2, T3, T4, T5> : IAsyncStateMachine // TypeDefIndex: 5077
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x290D0 Offset: 0x291D1 VA: 0x290D0
	public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>>> <>t__builder; // 0x0
	public UniTask<T0> task0; // 0x0
	public UniTask<T1> task1; // 0x0
	public UniTask<T2> task2; // 0x0
	public UniTask<T3> task3; // 0x0
	public UniTask<T4> task4; // 0x0
	public UniTask<T5> task5; // 0x0
	private UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3, T4, T5> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC0A70 Offset: 0x1FC0B71 VA: 0x1FC0A70
	|-UniTask.<WhenAny>d__61<object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CE80 Offset: 0x2CF81 VA: 0x2CE80
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC0E60 Offset: 0x1FC0F61 VA: 0x1FC0E60
	|-UniTask.<WhenAny>d__61<object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27F50 Offset: 0x28051 VA: 0x27F50
private struct UniTask.<WhenAny>d__62<T0, T1, T2, T3, T4, T5, T6> : IAsyncStateMachine // TypeDefIndex: 5078
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x29300 Offset: 0x29401 VA: 0x29300
	public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>>> <>t__builder; // 0x0
	public UniTask<T0> task0; // 0x0
	public UniTask<T1> task1; // 0x0
	public UniTask<T2> task2; // 0x0
	public UniTask<T3> task3; // 0x0
	public UniTask<T4> task4; // 0x0
	public UniTask<T5> task5; // 0x0
	public UniTask<T6> task6; // 0x0
	private UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3, T4, T5, T6> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC0EB0 Offset: 0x1FC0FB1 VA: 0x1FC0EB0
	|-UniTask.<WhenAny>d__62<object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CE90 Offset: 0x2CF91 VA: 0x2CE90
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC12C0 Offset: 0x1FC13C1 VA: 0x1FC12C0
	|-UniTask.<WhenAny>d__62<object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27F60 Offset: 0x28061 VA: 0x27F60
private struct UniTask.<WhenAny>d__63<T0, T1, T2, T3, T4, T5, T6, T7> : IAsyncStateMachine // TypeDefIndex: 5079
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x29580 Offset: 0x29681 VA: 0x29580
	public AsyncUniTaskMethodBuilder<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>>> <>t__builder; // 0x0
	public UniTask<T0> task0; // 0x0
	public UniTask<T1> task1; // 0x0
	public UniTask<T2> task2; // 0x0
	public UniTask<T3> task3; // 0x0
	public UniTask<T4> task4; // 0x0
	public UniTask<T5> task5; // 0x0
	public UniTask<T6> task6; // 0x0
	public UniTask<T7> task7; // 0x0
	private UniTask.WhenAnyPromise.Awaiter<T0, T1, T2, T3, T4, T5, T6, T7> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC1310 Offset: 0x1FC1411 VA: 0x1FC1310
	|-UniTask.<WhenAny>d__63<object, object, object, object, object, object, object, object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CEA0 Offset: 0x2CFA1 VA: 0x2CEA0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC16C0 Offset: 0x1FC17C1 VA: 0x1FC16C0
	|-UniTask.<WhenAny>d__63<object, object, object, object, object, object, object, object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27F70 Offset: 0x28071 VA: 0x27F70
private struct UniTask.<WhenAny>d__71<T0> : IAsyncStateMachine // TypeDefIndex: 5080
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x29850 Offset: 0x29951 VA: 0x29850
	public AsyncUniTaskMethodBuilder<ValueTuple<bool, T0>> <>t__builder; // 0x0
	public UniTask<T0> task0; // 0x0
	public UniTask task1; // 0x0
	private UniTask.UnitWhenAnyPromise.Awaiter<T0> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC1710 Offset: 0x1FC1811 VA: 0x1FC1710
	|-UniTask.<WhenAny>d__71<ValueTuple<bool, AsyncUnit>>.MoveNext
	|
	|-RVA: 0x1FC1A20 Offset: 0x1FC1B21 VA: 0x1FC1A20
	|-UniTask.<WhenAny>d__71<ValueTuple<bool, object>>.MoveNext
	|
	|-RVA: 0x1FC1D80 Offset: 0x1FC1E81 VA: 0x1FC1D80
	|-UniTask.<WhenAny>d__71<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CEB0 Offset: 0x2CFB1 VA: 0x2CEB0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC19D0 Offset: 0x1FC1AD1 VA: 0x1FC19D0
	|-UniTask.<WhenAny>d__71<ValueTuple<bool, AsyncUnit>>.SetStateMachine
	|
	|-RVA: 0x1FC1D30 Offset: 0x1FC1E31 VA: 0x1FC1D30
	|-UniTask.<WhenAny>d__71<ValueTuple<bool, object>>.SetStateMachine
	|
	|-RVA: 0x1FC2050 Offset: 0x1FC2151 VA: 0x1FC2050
	|-UniTask.<WhenAny>d__71<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27F80 Offset: 0x28081 VA: 0x27F80
private struct UniTask.<WhenAny>d__72<T> : IAsyncStateMachine // TypeDefIndex: 5081
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x29900 Offset: 0x29A01 VA: 0x29900
	public AsyncUniTaskMethodBuilder<ValueTuple<int, T>> <>t__builder; // 0x0
	public UniTask<T>[] tasks; // 0x0
	private UniTask.WhenAnyPromise.Awaiter<T> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC20A0 Offset: 0x1FC21A1 VA: 0x1FC20A0
	|-UniTask.<WhenAny>d__72<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CEC0 Offset: 0x2CFC1 VA: 0x2CEC0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FC2360 Offset: 0x1FC2461 VA: 0x1FC2360
	|-UniTask.<WhenAny>d__72<object>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27F90 Offset: 0x28091 VA: 0x27F90
private struct UniTask.<WhenAny>d__73 : IAsyncStateMachine // TypeDefIndex: 5082
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskMethodBuilder<int> <>t__builder; // 0x8
	public UniTask[] tasks; // 0x20
	private UniTask.WhenAnyPromise.Awaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x1C28BF0 Offset: 0x1C28CF1 VA: 0x1C28BF0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CED0 Offset: 0x2CFD1 VA: 0x2CED0
	// RVA: 0x1C28F60 Offset: 0x1C29061 VA: 0x1C28F60 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x27FA0 Offset: 0x280A1 VA: 0x27FA0
[Serializable]
private sealed class UniTask.<>c // TypeDefIndex: 5083
{
	// Fields
	public static readonly UniTask.<>c <>9; // 0x0

	// Methods

	// RVA: 0x2E90B90 Offset: 0x2E90C91 VA: 0x2E90B90
	private static void .cctor() { }

	// RVA: 0x2E90C00 Offset: 0x2E90D01 VA: 0x2E90C00
	public void .ctor() { }

	// RVA: 0x2E90C10 Offset: 0x2E90D11 VA: 0x2E90C10
	internal UniTask <.cctor>b__96_0() { }
}

// Namespace: 
private class UniTask.IsCanceledAwaiter<T> : IAwaiter<ValueTuple<bool, T>>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5096
{
	// Fields
	private readonly IAwaiter<T> awaiter; // 0x0

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IAwaiter<T> awaiter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8C690 Offset: 0x2D8C791 VA: 0x2D8C690
	|-UniTask.IsCanceledAwaiter<UniTask<object>>..ctor
	|
	|-RVA: 0x2D8CBB0 Offset: 0x2D8CCB1 VA: 0x2D8CBB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, UniTask<object>>>..ctor
	|
	|-RVA: 0x2D8D110 Offset: 0x2D8D211 VA: 0x2D8D110
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>..ctor
	|
	|-RVA: 0x2D8D690 Offset: 0x2D8D791 VA: 0x2D8D690
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..ctor
	|
	|-RVA: 0x2D8DC20 Offset: 0x2D8DD21 VA: 0x2D8DC20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..ctor
	|
	|-RVA: 0x2D8E1C0 Offset: 0x2D8E2C1 VA: 0x2D8E1C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..ctor
	|
	|-RVA: 0x2D8E700 Offset: 0x2D8E801 VA: 0x2D8E700
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..ctor
	|
	|-RVA: 0x2D8EC40 Offset: 0x2D8ED41 VA: 0x2D8EC40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..ctor
	|
	|-RVA: 0x2D8F1F0 Offset: 0x2D8F2F1 VA: 0x2D8F1F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..ctor
	|
	|-RVA: 0x2D8F730 Offset: 0x2D8F831 VA: 0x2D8F730
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..ctor
	|
	|-RVA: 0x2D8FCC0 Offset: 0x2D8FDC1 VA: 0x2D8FCC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..ctor
	|
	|-RVA: 0x2D90260 Offset: 0x2D90361 VA: 0x2D90260
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..ctor
	|
	|-RVA: 0x2D907D0 Offset: 0x2D908D1 VA: 0x2D907D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..ctor
	|
	|-RVA: 0x2D90D70 Offset: 0x2D90E71 VA: 0x2D90D70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2D91310 Offset: 0x2D91411 VA: 0x2D91310
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..ctor
	|
	|-RVA: 0x2D918A0 Offset: 0x2D919A1 VA: 0x2D918A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..ctor
	|
	|-RVA: 0x2D91E30 Offset: 0x2D91F31 VA: 0x2D91E30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..ctor
	|
	|-RVA: 0x2D923A0 Offset: 0x2D924A1 VA: 0x2D923A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..ctor
	|
	|-RVA: 0x2D92940 Offset: 0x2D92A41 VA: 0x2D92940
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..ctor
	|
	|-RVA: 0x2D92E80 Offset: 0x2D92F81 VA: 0x2D92E80
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..ctor
	|
	|-RVA: 0x2D93400 Offset: 0x2D93501 VA: 0x2D93400
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..ctor
	|
	|-RVA: 0x2D93980 Offset: 0x2D93A81 VA: 0x2D93980
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..ctor
	|
	|-RVA: 0x2D93F10 Offset: 0x2D94011 VA: 0x2D93F10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..ctor
	|
	|-RVA: 0x2D944B0 Offset: 0x2D945B1 VA: 0x2D944B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..ctor
	|
	|-RVA: 0x2D94A50 Offset: 0x2D94B51 VA: 0x2D94A50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..ctor
	|
	|-RVA: 0x2D95000 Offset: 0x2D95101 VA: 0x2D95000
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x2D955C0 Offset: 0x2D956C1 VA: 0x2D955C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x2D95B80 Offset: 0x2D95C81 VA: 0x2D95B80
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x2D96170 Offset: 0x2D96271 VA: 0x2D96170
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x2D96770 Offset: 0x2D96871 VA: 0x2D96770
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..ctor
	|
	|-RVA: 0x2D96CA0 Offset: 0x2D96DA1 VA: 0x2D96CA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..ctor
	|
	|-RVA: 0x2D971D0 Offset: 0x2D972D1 VA: 0x2D971D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..ctor
	|
	|-RVA: 0x2D97770 Offset: 0x2D97871 VA: 0x2D97770
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..ctor
	|
	|-RVA: 0x2D97CA0 Offset: 0x2D97DA1 VA: 0x2D97CA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..ctor
	|
	|-RVA: 0x2D98220 Offset: 0x2D98321 VA: 0x2D98220
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..ctor
	|
	|-RVA: 0x2D987B0 Offset: 0x2D988B1 VA: 0x2D987B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..ctor
	|
	|-RVA: 0x2D98D10 Offset: 0x2D98E11 VA: 0x2D98D10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..ctor
	|
	|-RVA: 0x2D992A0 Offset: 0x2D993A1 VA: 0x2D992A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2D99830 Offset: 0x2D99931 VA: 0x2D99830
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..ctor
	|
	|-RVA: 0x2D99DB0 Offset: 0x2D99EB1 VA: 0x2D99DB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..ctor
	|
	|-RVA: 0x2D9A330 Offset: 0x2D9A431 VA: 0x2D9A330
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..ctor
	|
	|-RVA: 0x2D9A890 Offset: 0x2D9A991 VA: 0x2D9A890
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..ctor
	|
	|-RVA: 0x2D9AE20 Offset: 0x2D9AF21 VA: 0x2D9AE20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..ctor
	|
	|-RVA: 0x2D9B350 Offset: 0x2D9B451 VA: 0x2D9B350
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..ctor
	|
	|-RVA: 0x2D9B8C0 Offset: 0x2D9B9C1 VA: 0x2D9B8C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..ctor
	|
	|-RVA: 0x2D9BE40 Offset: 0x2D9BF41 VA: 0x2D9BE40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..ctor
	|
	|-RVA: 0x2D9C3C0 Offset: 0x2D9C4C1 VA: 0x2D9C3C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..ctor
	|
	|-RVA: 0x2D9C950 Offset: 0x2D9CA51 VA: 0x2D9C950
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..ctor
	|
	|-RVA: 0x2D9CEE0 Offset: 0x2D9CFE1 VA: 0x2D9CEE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2D9D4A0 Offset: 0x2D9D5A1 VA: 0x2D9D4A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..ctor
	|
	|-RVA: 0x2D9DA40 Offset: 0x2D9DB41 VA: 0x2D9DA40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2D9E030 Offset: 0x2D9E131 VA: 0x2D9E030
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2D9E5E0 Offset: 0x2D9E6E1 VA: 0x2D9E5E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2D9EBF0 Offset: 0x2D9ECF1 VA: 0x2D9EBF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2D9F1B0 Offset: 0x2D9F2B1 VA: 0x2D9F1B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2D9F7E0 Offset: 0x2D9F8E1 VA: 0x2D9F7E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2D9FDA0 Offset: 0x2D9FEA1 VA: 0x2D9FDA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2DA03C0 Offset: 0x2DA04C1 VA: 0x2DA03C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2DA09B0 Offset: 0x2DA0AB1 VA: 0x2DA09B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..ctor
	|
	|-RVA: 0x2DA0EE0 Offset: 0x2DA0FE1 VA: 0x2DA0EE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>..ctor
	|
	|-RVA: 0x2DA1410 Offset: 0x2DA1511 VA: 0x2DA1410
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>..ctor
	|
	|-RVA: 0x2DA19A0 Offset: 0x2DA1AA1 VA: 0x2DA19A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>..ctor
	|
	|-RVA: 0x2DA1ED0 Offset: 0x2DA1FD1 VA: 0x2DA1ED0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>..ctor
	|
	|-RVA: 0x2DA2450 Offset: 0x2DA2551 VA: 0x2DA2450
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>..ctor
	|
	|-RVA: 0x2DA29D0 Offset: 0x2DA2AD1 VA: 0x2DA29D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>..ctor
	|
	|-RVA: 0x2DA2F00 Offset: 0x2DA3001 VA: 0x2DA2F00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>..ctor
	|
	|-RVA: 0x2DA3480 Offset: 0x2DA3581 VA: 0x2DA3480
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2DA3A00 Offset: 0x2DA3B01 VA: 0x2DA3A00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..ctor
	|
	|-RVA: 0x2DA3F80 Offset: 0x2DA4081 VA: 0x2DA3F80
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>..ctor
	|
	|-RVA: 0x2DA4500 Offset: 0x2DA4601 VA: 0x2DA4500
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>..ctor
	|
	|-RVA: 0x2DA4A30 Offset: 0x2DA4B31 VA: 0x2DA4A30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>..ctor
	|
	|-RVA: 0x2DA4FB0 Offset: 0x2DA50B1 VA: 0x2DA4FB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>..ctor
	|
	|-RVA: 0x2DA54E0 Offset: 0x2DA55E1 VA: 0x2DA54E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>..ctor
	|
	|-RVA: 0x2DA5A40 Offset: 0x2DA5B41 VA: 0x2DA5A40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>..ctor
	|
	|-RVA: 0x2DA5FB0 Offset: 0x2DA60B1 VA: 0x2DA5FB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>..ctor
	|
	|-RVA: 0x2DA6530 Offset: 0x2DA6631 VA: 0x2DA6530
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>..ctor
	|
	|-RVA: 0x2DA6AB0 Offset: 0x2DA6BB1 VA: 0x2DA6AB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>..ctor
	|
	|-RVA: 0x2DA7030 Offset: 0x2DA7131 VA: 0x2DA7030
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2DA75E0 Offset: 0x2DA76E1 VA: 0x2DA75E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>..ctor
	|
	|-RVA: 0x2DA7B70 Offset: 0x2DA7C71 VA: 0x2DA7B70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2DA8130 Offset: 0x2DA8231 VA: 0x2DA8130
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2DA86D0 Offset: 0x2DA87D1 VA: 0x2DA86D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2DA8CD0 Offset: 0x2DA8DD1 VA: 0x2DA8CD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2DA9280 Offset: 0x2DA9381 VA: 0x2DA9280
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2DA98B0 Offset: 0x2DA99B1 VA: 0x2DA98B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2DA9E70 Offset: 0x2DA9F71 VA: 0x2DA9E70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2DAA4C0 Offset: 0x2DAA5C1 VA: 0x2DAA4C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2DAAA80 Offset: 0x2DAAB81 VA: 0x2DAAA80
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2DAB040 Offset: 0x2DAB141 VA: 0x2DAB040
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2DAB610 Offset: 0x2DAB711 VA: 0x2DAB610
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x2DABB30 Offset: 0x2DABC31 VA: 0x2DABB30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x2DAC050 Offset: 0x2DAC151 VA: 0x2DAC050
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>..ctor
	|
	|-RVA: 0x2DAC5D0 Offset: 0x2DAC6D1 VA: 0x2DAC5D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, byte>>>..ctor
	|
	|-RVA: 0x2DACAF0 Offset: 0x2DACBF1 VA: 0x2DACAF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Color>>>..ctor
	|
	|-RVA: 0x2DAD060 Offset: 0x2DAD161 VA: 0x2DAD060
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, double>>>..ctor
	|
	|-RVA: 0x2DAD5C0 Offset: 0x2DAD6C1 VA: 0x2DAD5C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x2F64E00 Offset: 0x2F64F01 VA: 0x2F64E00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, long>>>..ctor
	|
	|-RVA: 0x2F65360 Offset: 0x2F65461 VA: 0x2F65360
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2F658C0 Offset: 0x2F659C1 VA: 0x2F658C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>..ctor
	|
	|-RVA: 0x2F65E30 Offset: 0x2F65F31 VA: 0x2F65E30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>..ctor
	|
	|-RVA: 0x2F663A0 Offset: 0x2F664A1 VA: 0x2F663A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x2F668B0 Offset: 0x2F669B1 VA: 0x2F668B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>..ctor
	|
	|-RVA: 0x2F66E10 Offset: 0x2F66F11 VA: 0x2F66E10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>..ctor
	|
	|-RVA: 0x2F67330 Offset: 0x2F67431 VA: 0x2F67330
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x2F67860 Offset: 0x2F67961 VA: 0x2F67860
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>..ctor
	|
	|-RVA: 0x2F67DC0 Offset: 0x2F67EC1 VA: 0x2F67DC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>..ctor
	|
	|-RVA: 0x2F68330 Offset: 0x2F68431 VA: 0x2F68330
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, object>>>..ctor
	|
	|-RVA: 0x2F68890 Offset: 0x2F68991 VA: 0x2F68890
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x2F68DF0 Offset: 0x2F68EF1 VA: 0x2F68DF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2F69390 Offset: 0x2F69491 VA: 0x2F69390
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object>>>..ctor
	|
	|-RVA: 0x2F69910 Offset: 0x2F69A11 VA: 0x2F69910
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2F69ED0 Offset: 0x2F69FD1 VA: 0x2F69ED0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>..ctor
	|
	|-RVA: 0x2F6A460 Offset: 0x2F6A561 VA: 0x2F6A460
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2F6AA50 Offset: 0x2F6AB51 VA: 0x2F6AA50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2F6AFF0 Offset: 0x2F6B0F1 VA: 0x2F6AFF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2F6B600 Offset: 0x2F6B701 VA: 0x2F6B600
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2F6BBB0 Offset: 0x2F6BCB1 VA: 0x2F6BBB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2F6C1E0 Offset: 0x2F6C2E1 VA: 0x2F6C1E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2F6C7A0 Offset: 0x2F6C8A1 VA: 0x2F6C7A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2F6CDC0 Offset: 0x2F6CEC1 VA: 0x2F6CDC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2F6D390 Offset: 0x2F6D491 VA: 0x2F6D390
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x2F6D8C0 Offset: 0x2F6D9C1 VA: 0x2F6D8C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, bool>>..ctor
	|
	|-RVA: 0x2F6DDF0 Offset: 0x2F6DEF1 VA: 0x2F6DDF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Bounds>>..ctor
	|
	|-RVA: 0x2F6E370 Offset: 0x2F6E471 VA: 0x2F6E370
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, byte>>..ctor
	|
	|-RVA: 0x2F6E8A0 Offset: 0x2F6E9A1 VA: 0x2F6E8A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Color>>..ctor
	|
	|-RVA: 0x2F6EE00 Offset: 0x2F6EF01 VA: 0x2F6EE00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, double>>..ctor
	|
	|-RVA: 0x2F6F320 Offset: 0x2F6F421 VA: 0x2F6F320
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, int>>..ctor
	|
	|-RVA: 0x2F6F840 Offset: 0x2F6F941 VA: 0x2F6F840
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, long>>..ctor
	|
	|-RVA: 0x2F6FD60 Offset: 0x2F6FE61 VA: 0x2F6FD60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2F70280 Offset: 0x2F70381 VA: 0x2F70280
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Quaternion>>..ctor
	|
	|-RVA: 0x2F707E0 Offset: 0x2F708E1 VA: 0x2F707E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Rect>>..ctor
	|
	|-RVA: 0x2F70D40 Offset: 0x2F70E41 VA: 0x2F70D40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, float>>..ctor
	|
	|-RVA: 0x2F71260 Offset: 0x2F71361 VA: 0x2F71260
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, UniTask>>..ctor
	|
	|-RVA: 0x2F71780 Offset: 0x2F71881 VA: 0x2F71780
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Unit>>..ctor
	|
	|-RVA: 0x2F71CB0 Offset: 0x2F71DB1 VA: 0x2F71CB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector2>>..ctor
	|
	|-RVA: 0x2F721C0 Offset: 0x2F722C1 VA: 0x2F721C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector3>>..ctor
	|
	|-RVA: 0x2F726F0 Offset: 0x2F727F1 VA: 0x2F726F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector4>>..ctor
	|
	|-RVA: 0x2F72C50 Offset: 0x2F72D51 VA: 0x2F72C50
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x2F73170 Offset: 0x2F73271 VA: 0x2F73170
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2F73690 Offset: 0x2F73791 VA: 0x2F73690
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2F73C20 Offset: 0x2F73D21 VA: 0x2F73C20
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2F74180 Offset: 0x2F74281 VA: 0x2F74180
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2F74730 Offset: 0x2F74831 VA: 0x2F74730
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x2F74CB0 Offset: 0x2F74DB1 VA: 0x2F74CB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2F75270 Offset: 0x2F75371 VA: 0x2F75270
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2F75800 Offset: 0x2F75901 VA: 0x2F75800
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2F75E00 Offset: 0x2F75F01 VA: 0x2F75E00
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2F763A0 Offset: 0x2F764A1 VA: 0x2F763A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2F769D0 Offset: 0x2F76AD1 VA: 0x2F769D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2F76F80 Offset: 0x2F77081 VA: 0x2F76F80
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2F775D0 Offset: 0x2F776D1 VA: 0x2F775D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2F77B90 Offset: 0x2F77C91 VA: 0x2F77B90
	|-UniTask.IsCanceledAwaiter<AsyncUnit>..ctor
	|
	|-RVA: 0x2F780A0 Offset: 0x2F781A1 VA: 0x2F780A0
	|-UniTask.IsCanceledAwaiter<bool>..ctor
	|
	|-RVA: 0x2F785B0 Offset: 0x2F786B1 VA: 0x2F785B0
	|-UniTask.IsCanceledAwaiter<Bounds>..ctor
	|
	|-RVA: 0x2F78B20 Offset: 0x2F78C21 VA: 0x2F78B20
	|-UniTask.IsCanceledAwaiter<byte>..ctor
	|
	|-RVA: 0x2F79030 Offset: 0x2F79131 VA: 0x2F79030
	|-UniTask.IsCanceledAwaiter<Color>..ctor
	|
	|-RVA: 0x2F79560 Offset: 0x2F79661 VA: 0x2F79560
	|-UniTask.IsCanceledAwaiter<double>..ctor
	|
	|-RVA: 0x2F79A70 Offset: 0x2F79B71 VA: 0x2F79A70
	|-UniTask.IsCanceledAwaiter<int>..ctor
	|
	|-RVA: 0x2F79F80 Offset: 0x2F7A081 VA: 0x2F79F80
	|-UniTask.IsCanceledAwaiter<long>..ctor
	|
	|-RVA: 0x2F7A490 Offset: 0x2F7A591 VA: 0x2F7A490
	|-UniTask.IsCanceledAwaiter<object>..ctor
	|
	|-RVA: 0x2F7A9A0 Offset: 0x2F7AAA1 VA: 0x2F7A9A0
	|-UniTask.IsCanceledAwaiter<Quaternion>..ctor
	|
	|-RVA: 0x2F7AED0 Offset: 0x2F7AFD1 VA: 0x2F7AED0
	|-UniTask.IsCanceledAwaiter<Rect>..ctor
	|
	|-RVA: 0x2F7B400 Offset: 0x2F7B501 VA: 0x2F7B400
	|-UniTask.IsCanceledAwaiter<float>..ctor
	|
	|-RVA: 0x2F7B910 Offset: 0x2F7BA11 VA: 0x2F7B910
	|-UniTask.IsCanceledAwaiter<UniTask>..ctor
	|
	|-RVA: 0x2F7BE20 Offset: 0x2F7BF21 VA: 0x2F7BE20
	|-UniTask.IsCanceledAwaiter<Unit>..ctor
	|
	|-RVA: 0x2F7C330 Offset: 0x2F7C431 VA: 0x2F7C330
	|-UniTask.IsCanceledAwaiter<Vector2>..ctor
	|
	|-RVA: 0x2F7C850 Offset: 0x2F7C951 VA: 0x2F7C850
	|-UniTask.IsCanceledAwaiter<Vector3>..ctor
	|
	|-RVA: 0x2F7CD60 Offset: 0x2F7CE61 VA: 0x2F7CD60
	|-UniTask.IsCanceledAwaiter<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8C6D0 Offset: 0x2D8C7D1 VA: 0x2D8C6D0
	|-UniTask.IsCanceledAwaiter<UniTask<object>>.get_IsCompleted
	|
	|-RVA: 0x2D8CBF0 Offset: 0x2D8CCF1 VA: 0x2D8CBF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, UniTask<object>>>.get_IsCompleted
	|
	|-RVA: 0x2D8D150 Offset: 0x2D8D251 VA: 0x2D8D150
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.get_IsCompleted
	|
	|-RVA: 0x2D8D6D0 Offset: 0x2D8D7D1 VA: 0x2D8D6D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D8DC60 Offset: 0x2D8DD61 VA: 0x2D8DC60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D8E200 Offset: 0x2D8E301 VA: 0x2D8E200
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D8E740 Offset: 0x2D8E841 VA: 0x2D8E740
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D8EC80 Offset: 0x2D8ED81 VA: 0x2D8EC80
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D8F230 Offset: 0x2D8F331 VA: 0x2D8F230
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D8F770 Offset: 0x2D8F871 VA: 0x2D8F770
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D8FD00 Offset: 0x2D8FE01 VA: 0x2D8FD00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D902A0 Offset: 0x2D903A1 VA: 0x2D902A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D90810 Offset: 0x2D90911 VA: 0x2D90810
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D90DB0 Offset: 0x2D90EB1 VA: 0x2D90DB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D91350 Offset: 0x2D91451 VA: 0x2D91350
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D918E0 Offset: 0x2D919E1 VA: 0x2D918E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D91E70 Offset: 0x2D91F71 VA: 0x2D91E70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D923E0 Offset: 0x2D924E1 VA: 0x2D923E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D92980 Offset: 0x2D92A81 VA: 0x2D92980
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D92EC0 Offset: 0x2D92FC1 VA: 0x2D92EC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D93440 Offset: 0x2D93541 VA: 0x2D93440
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D939C0 Offset: 0x2D93AC1 VA: 0x2D939C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D93F50 Offset: 0x2D94051 VA: 0x2D93F50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D944F0 Offset: 0x2D945F1 VA: 0x2D944F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D94A90 Offset: 0x2D94B91 VA: 0x2D94A90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D95040 Offset: 0x2D95141 VA: 0x2D95040
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D95600 Offset: 0x2D95701 VA: 0x2D95600
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D95BC0 Offset: 0x2D95CC1 VA: 0x2D95BC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D961B0 Offset: 0x2D962B1 VA: 0x2D961B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D967B0 Offset: 0x2D968B1 VA: 0x2D967B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D96CE0 Offset: 0x2D96DE1 VA: 0x2D96CE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D97210 Offset: 0x2D97311 VA: 0x2D97210
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D977B0 Offset: 0x2D978B1 VA: 0x2D977B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D97CE0 Offset: 0x2D97DE1 VA: 0x2D97CE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D98260 Offset: 0x2D98361 VA: 0x2D98260
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D987F0 Offset: 0x2D988F1 VA: 0x2D987F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D98D50 Offset: 0x2D98E51 VA: 0x2D98D50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D992E0 Offset: 0x2D993E1 VA: 0x2D992E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D99870 Offset: 0x2D99971 VA: 0x2D99870
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D99DF0 Offset: 0x2D99EF1 VA: 0x2D99DF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9A370 Offset: 0x2D9A471 VA: 0x2D9A370
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9A8D0 Offset: 0x2D9A9D1 VA: 0x2D9A8D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9AE60 Offset: 0x2D9AF61 VA: 0x2D9AE60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9B390 Offset: 0x2D9B491 VA: 0x2D9B390
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9B900 Offset: 0x2D9BA01 VA: 0x2D9B900
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9BE80 Offset: 0x2D9BF81 VA: 0x2D9BE80
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9C400 Offset: 0x2D9C501 VA: 0x2D9C400
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9C990 Offset: 0x2D9CA91 VA: 0x2D9C990
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9CF20 Offset: 0x2D9D021 VA: 0x2D9CF20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9D4E0 Offset: 0x2D9D5E1 VA: 0x2D9D4E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9DA80 Offset: 0x2D9DB81 VA: 0x2D9DA80
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9E070 Offset: 0x2D9E171 VA: 0x2D9E070
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9E620 Offset: 0x2D9E721 VA: 0x2D9E620
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9EC30 Offset: 0x2D9ED31 VA: 0x2D9EC30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9F1F0 Offset: 0x2D9F2F1 VA: 0x2D9F1F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9F820 Offset: 0x2D9F921 VA: 0x2D9F820
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2D9FDE0 Offset: 0x2D9FEE1 VA: 0x2D9FDE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA0400 Offset: 0x2DA0501 VA: 0x2DA0400
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA09F0 Offset: 0x2DA0AF1 VA: 0x2DA09F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA0F20 Offset: 0x2DA1021 VA: 0x2DA0F20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA1450 Offset: 0x2DA1551 VA: 0x2DA1450
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA19E0 Offset: 0x2DA1AE1 VA: 0x2DA19E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA1F10 Offset: 0x2DA2011 VA: 0x2DA1F10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA2490 Offset: 0x2DA2591 VA: 0x2DA2490
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA2A10 Offset: 0x2DA2B11 VA: 0x2DA2A10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA2F40 Offset: 0x2DA3041 VA: 0x2DA2F40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA34C0 Offset: 0x2DA35C1 VA: 0x2DA34C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA3A40 Offset: 0x2DA3B41 VA: 0x2DA3A40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA3FC0 Offset: 0x2DA40C1 VA: 0x2DA3FC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA4540 Offset: 0x2DA4641 VA: 0x2DA4540
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA4A70 Offset: 0x2DA4B71 VA: 0x2DA4A70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA4FF0 Offset: 0x2DA50F1 VA: 0x2DA4FF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA5520 Offset: 0x2DA5621 VA: 0x2DA5520
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA5A80 Offset: 0x2DA5B81 VA: 0x2DA5A80
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA5FF0 Offset: 0x2DA60F1 VA: 0x2DA5FF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA6570 Offset: 0x2DA6671 VA: 0x2DA6570
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA6AF0 Offset: 0x2DA6BF1 VA: 0x2DA6AF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA7070 Offset: 0x2DA7171 VA: 0x2DA7070
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA7620 Offset: 0x2DA7721 VA: 0x2DA7620
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA7BB0 Offset: 0x2DA7CB1 VA: 0x2DA7BB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA8170 Offset: 0x2DA8271 VA: 0x2DA8170
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA8710 Offset: 0x2DA8811 VA: 0x2DA8710
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA8D10 Offset: 0x2DA8E11 VA: 0x2DA8D10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA92C0 Offset: 0x2DA93C1 VA: 0x2DA92C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA98F0 Offset: 0x2DA99F1 VA: 0x2DA98F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2DA9EB0 Offset: 0x2DA9FB1 VA: 0x2DA9EB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2DAA500 Offset: 0x2DAA601 VA: 0x2DAA500
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2DAAAC0 Offset: 0x2DAABC1 VA: 0x2DAAAC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2DAB080 Offset: 0x2DAB181 VA: 0x2DAB080
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2DAB650 Offset: 0x2DAB751 VA: 0x2DAB650
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_IsCompleted
	|
	|-RVA: 0x2DABB70 Offset: 0x2DABC71 VA: 0x2DABB70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.get_IsCompleted
	|
	|-RVA: 0x2DAC090 Offset: 0x2DAC191 VA: 0x2DAC090
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.get_IsCompleted
	|
	|-RVA: 0x2DAC610 Offset: 0x2DAC711 VA: 0x2DAC610
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.get_IsCompleted
	|
	|-RVA: 0x2DACB30 Offset: 0x2DACC31 VA: 0x2DACB30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.get_IsCompleted
	|
	|-RVA: 0x2DAD0A0 Offset: 0x2DAD1A1 VA: 0x2DAD0A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, double>>>.get_IsCompleted
	|
	|-RVA: 0x2DAD600 Offset: 0x2DAD701 VA: 0x2DAD600
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, int>>>.get_IsCompleted
	|
	|-RVA: 0x2F64E40 Offset: 0x2F64F41 VA: 0x2F64E40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, long>>>.get_IsCompleted
	|
	|-RVA: 0x2F653A0 Offset: 0x2F654A1 VA: 0x2F653A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2F65900 Offset: 0x2F65A01 VA: 0x2F65900
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.get_IsCompleted
	|
	|-RVA: 0x2F65E70 Offset: 0x2F65F71 VA: 0x2F65E70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.get_IsCompleted
	|
	|-RVA: 0x2F663E0 Offset: 0x2F664E1 VA: 0x2F663E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, float>>>.get_IsCompleted
	|
	|-RVA: 0x2F668F0 Offset: 0x2F669F1 VA: 0x2F668F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.get_IsCompleted
	|
	|-RVA: 0x2F66E50 Offset: 0x2F66F51 VA: 0x2F66E50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.get_IsCompleted
	|
	|-RVA: 0x2F67370 Offset: 0x2F67471 VA: 0x2F67370
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.get_IsCompleted
	|
	|-RVA: 0x2F678A0 Offset: 0x2F679A1 VA: 0x2F678A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.get_IsCompleted
	|
	|-RVA: 0x2F67E00 Offset: 0x2F67F01 VA: 0x2F67E00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.get_IsCompleted
	|
	|-RVA: 0x2F68370 Offset: 0x2F68471 VA: 0x2F68370
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, object>>>.get_IsCompleted
	|
	|-RVA: 0x2F688D0 Offset: 0x2F689D1 VA: 0x2F688D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2F68E30 Offset: 0x2F68F31 VA: 0x2F68E30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2F693D0 Offset: 0x2F694D1 VA: 0x2F693D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2F69950 Offset: 0x2F69A51 VA: 0x2F69950
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2F69F10 Offset: 0x2F6A011 VA: 0x2F69F10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2F6A4A0 Offset: 0x2F6A5A1 VA: 0x2F6A4A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2F6AA90 Offset: 0x2F6AB91 VA: 0x2F6AA90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2F6B030 Offset: 0x2F6B131 VA: 0x2F6B030
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2F6B640 Offset: 0x2F6B741 VA: 0x2F6B640
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2F6BBF0 Offset: 0x2F6BCF1 VA: 0x2F6BBF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2F6C220 Offset: 0x2F6C321 VA: 0x2F6C220
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2F6C7E0 Offset: 0x2F6C8E1 VA: 0x2F6C7E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F6CE00 Offset: 0x2F6CF01 VA: 0x2F6CE00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F6D3D0 Offset: 0x2F6D4D1 VA: 0x2F6D3D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, AsyncUnit>>.get_IsCompleted
	|
	|-RVA: 0x2F6D900 Offset: 0x2F6DA01 VA: 0x2F6D900
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, bool>>.get_IsCompleted
	|
	|-RVA: 0x2F6DE30 Offset: 0x2F6DF31 VA: 0x2F6DE30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Bounds>>.get_IsCompleted
	|
	|-RVA: 0x2F6E3B0 Offset: 0x2F6E4B1 VA: 0x2F6E3B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, byte>>.get_IsCompleted
	|
	|-RVA: 0x2F6E8E0 Offset: 0x2F6E9E1 VA: 0x2F6E8E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Color>>.get_IsCompleted
	|
	|-RVA: 0x2F6EE40 Offset: 0x2F6EF41 VA: 0x2F6EE40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, double>>.get_IsCompleted
	|
	|-RVA: 0x2F6F360 Offset: 0x2F6F461 VA: 0x2F6F360
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, int>>.get_IsCompleted
	|
	|-RVA: 0x2F6F880 Offset: 0x2F6F981 VA: 0x2F6F880
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, long>>.get_IsCompleted
	|
	|-RVA: 0x2F6FDA0 Offset: 0x2F6FEA1 VA: 0x2F6FDA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, object>>.get_IsCompleted
	|
	|-RVA: 0x2F702C0 Offset: 0x2F703C1 VA: 0x2F702C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Quaternion>>.get_IsCompleted
	|
	|-RVA: 0x2F70820 Offset: 0x2F70921 VA: 0x2F70820
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Rect>>.get_IsCompleted
	|
	|-RVA: 0x2F70D80 Offset: 0x2F70E81 VA: 0x2F70D80
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, float>>.get_IsCompleted
	|
	|-RVA: 0x2F712A0 Offset: 0x2F713A1 VA: 0x2F712A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, UniTask>>.get_IsCompleted
	|
	|-RVA: 0x2F717C0 Offset: 0x2F718C1 VA: 0x2F717C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Unit>>.get_IsCompleted
	|
	|-RVA: 0x2F71CF0 Offset: 0x2F71DF1 VA: 0x2F71CF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector2>>.get_IsCompleted
	|
	|-RVA: 0x2F72200 Offset: 0x2F72301 VA: 0x2F72200
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector3>>.get_IsCompleted
	|
	|-RVA: 0x2F72730 Offset: 0x2F72831 VA: 0x2F72730
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector4>>.get_IsCompleted
	|
	|-RVA: 0x2F72C90 Offset: 0x2F72D91 VA: 0x2F72C90
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, object>>.get_IsCompleted
	|
	|-RVA: 0x2F731B0 Offset: 0x2F732B1 VA: 0x2F731B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object>>.get_IsCompleted
	|
	|-RVA: 0x2F736D0 Offset: 0x2F737D1 VA: 0x2F736D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2F73C60 Offset: 0x2F73D61 VA: 0x2F73C60
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2F741C0 Offset: 0x2F742C1 VA: 0x2F741C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2F74770 Offset: 0x2F74871 VA: 0x2F74770
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2F74CF0 Offset: 0x2F74DF1 VA: 0x2F74CF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2F752B0 Offset: 0x2F753B1 VA: 0x2F752B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2F75840 Offset: 0x2F75941 VA: 0x2F75840
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2F75E40 Offset: 0x2F75F41 VA: 0x2F75E40
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2F763E0 Offset: 0x2F764E1 VA: 0x2F763E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2F76A10 Offset: 0x2F76B11 VA: 0x2F76A10
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2F76FC0 Offset: 0x2F770C1 VA: 0x2F76FC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2F77610 Offset: 0x2F77711 VA: 0x2F77610
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2F77BD0 Offset: 0x2F77CD1 VA: 0x2F77BD0
	|-UniTask.IsCanceledAwaiter<AsyncUnit>.get_IsCompleted
	|
	|-RVA: 0x2F780E0 Offset: 0x2F781E1 VA: 0x2F780E0
	|-UniTask.IsCanceledAwaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x2F785F0 Offset: 0x2F786F1 VA: 0x2F785F0
	|-UniTask.IsCanceledAwaiter<Bounds>.get_IsCompleted
	|
	|-RVA: 0x2F78B60 Offset: 0x2F78C61 VA: 0x2F78B60
	|-UniTask.IsCanceledAwaiter<byte>.get_IsCompleted
	|
	|-RVA: 0x2F79070 Offset: 0x2F79171 VA: 0x2F79070
	|-UniTask.IsCanceledAwaiter<Color>.get_IsCompleted
	|
	|-RVA: 0x2F795A0 Offset: 0x2F796A1 VA: 0x2F795A0
	|-UniTask.IsCanceledAwaiter<double>.get_IsCompleted
	|
	|-RVA: 0x2F79AB0 Offset: 0x2F79BB1 VA: 0x2F79AB0
	|-UniTask.IsCanceledAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0x2F79FC0 Offset: 0x2F7A0C1 VA: 0x2F79FC0
	|-UniTask.IsCanceledAwaiter<long>.get_IsCompleted
	|
	|-RVA: 0x2F7A4D0 Offset: 0x2F7A5D1 VA: 0x2F7A4D0
	|-UniTask.IsCanceledAwaiter<object>.get_IsCompleted
	|
	|-RVA: 0x2F7A9E0 Offset: 0x2F7AAE1 VA: 0x2F7A9E0
	|-UniTask.IsCanceledAwaiter<Quaternion>.get_IsCompleted
	|
	|-RVA: 0x2F7AF10 Offset: 0x2F7B011 VA: 0x2F7AF10
	|-UniTask.IsCanceledAwaiter<Rect>.get_IsCompleted
	|
	|-RVA: 0x2F7B440 Offset: 0x2F7B541 VA: 0x2F7B440
	|-UniTask.IsCanceledAwaiter<float>.get_IsCompleted
	|
	|-RVA: 0x2F7B950 Offset: 0x2F7BA51 VA: 0x2F7B950
	|-UniTask.IsCanceledAwaiter<UniTask>.get_IsCompleted
	|
	|-RVA: 0x2F7BE60 Offset: 0x2F7BF61 VA: 0x2F7BE60
	|-UniTask.IsCanceledAwaiter<Unit>.get_IsCompleted
	|
	|-RVA: 0x2F7C370 Offset: 0x2F7C471 VA: 0x2F7C370
	|-UniTask.IsCanceledAwaiter<Vector2>.get_IsCompleted
	|
	|-RVA: 0x2F7C890 Offset: 0x2F7C991 VA: 0x2F7C890
	|-UniTask.IsCanceledAwaiter<Vector3>.get_IsCompleted
	|
	|-RVA: 0x2F7CDA0 Offset: 0x2F7CEA1 VA: 0x2F7CDA0
	|-UniTask.IsCanceledAwaiter<Vector4>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public AwaiterStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8C780 Offset: 0x2D8C881 VA: 0x2D8C780
	|-UniTask.IsCanceledAwaiter<UniTask<object>>.get_Status
	|
	|-RVA: 0x2D8CCA0 Offset: 0x2D8CDA1 VA: 0x2D8CCA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, UniTask<object>>>.get_Status
	|
	|-RVA: 0x2D8D200 Offset: 0x2D8D301 VA: 0x2D8D200
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.get_Status
	|
	|-RVA: 0x2D8D780 Offset: 0x2D8D881 VA: 0x2D8D780
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.get_Status
	|
	|-RVA: 0x2D8DD10 Offset: 0x2D8DE11 VA: 0x2D8DD10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.get_Status
	|
	|-RVA: 0x2D8E2B0 Offset: 0x2D8E3B1 VA: 0x2D8E2B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.get_Status
	|
	|-RVA: 0x2D8E7F0 Offset: 0x2D8E8F1 VA: 0x2D8E7F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.get_Status
	|
	|-RVA: 0x2D8ED30 Offset: 0x2D8EE31 VA: 0x2D8ED30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.get_Status
	|
	|-RVA: 0x2D8F2E0 Offset: 0x2D8F3E1 VA: 0x2D8F2E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.get_Status
	|
	|-RVA: 0x2D8F820 Offset: 0x2D8F921 VA: 0x2D8F820
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.get_Status
	|
	|-RVA: 0x2D8FDB0 Offset: 0x2D8FEB1 VA: 0x2D8FDB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.get_Status
	|
	|-RVA: 0x2D90350 Offset: 0x2D90451 VA: 0x2D90350
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.get_Status
	|
	|-RVA: 0x2D908C0 Offset: 0x2D909C1 VA: 0x2D908C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.get_Status
	|
	|-RVA: 0x2D90E60 Offset: 0x2D90F61 VA: 0x2D90E60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2D91400 Offset: 0x2D91501 VA: 0x2D91400
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.get_Status
	|
	|-RVA: 0x2D91990 Offset: 0x2D91A91 VA: 0x2D91990
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.get_Status
	|
	|-RVA: 0x2D91F20 Offset: 0x2D92021 VA: 0x2D91F20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.get_Status
	|
	|-RVA: 0x2D92490 Offset: 0x2D92591 VA: 0x2D92490
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.get_Status
	|
	|-RVA: 0x2D92A30 Offset: 0x2D92B31 VA: 0x2D92A30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.get_Status
	|
	|-RVA: 0x2D92F70 Offset: 0x2D93071 VA: 0x2D92F70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.get_Status
	|
	|-RVA: 0x2D934F0 Offset: 0x2D935F1 VA: 0x2D934F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.get_Status
	|
	|-RVA: 0x2D93A70 Offset: 0x2D93B71 VA: 0x2D93A70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.get_Status
	|
	|-RVA: 0x2D94000 Offset: 0x2D94101 VA: 0x2D94000
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.get_Status
	|
	|-RVA: 0x2D945A0 Offset: 0x2D946A1 VA: 0x2D945A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.get_Status
	|
	|-RVA: 0x2D94B40 Offset: 0x2D94C41 VA: 0x2D94B40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x2D950F0 Offset: 0x2D951F1 VA: 0x2D950F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x2D956B0 Offset: 0x2D957B1 VA: 0x2D956B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x2D95C70 Offset: 0x2D95D71 VA: 0x2D95C70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x2D96260 Offset: 0x2D96361 VA: 0x2D96260
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x2D96860 Offset: 0x2D96961 VA: 0x2D96860
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.get_Status
	|
	|-RVA: 0x2D96D90 Offset: 0x2D96E91 VA: 0x2D96D90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.get_Status
	|
	|-RVA: 0x2D972C0 Offset: 0x2D973C1 VA: 0x2D972C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.get_Status
	|
	|-RVA: 0x2D97860 Offset: 0x2D97961 VA: 0x2D97860
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.get_Status
	|
	|-RVA: 0x2D97D90 Offset: 0x2D97E91 VA: 0x2D97D90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.get_Status
	|
	|-RVA: 0x2D98310 Offset: 0x2D98411 VA: 0x2D98310
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.get_Status
	|
	|-RVA: 0x2D988A0 Offset: 0x2D989A1 VA: 0x2D988A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.get_Status
	|
	|-RVA: 0x2D98E00 Offset: 0x2D98F01 VA: 0x2D98E00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.get_Status
	|
	|-RVA: 0x2D99390 Offset: 0x2D99491 VA: 0x2D99390
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2D99920 Offset: 0x2D99A21 VA: 0x2D99920
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.get_Status
	|
	|-RVA: 0x2D99EA0 Offset: 0x2D99FA1 VA: 0x2D99EA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.get_Status
	|
	|-RVA: 0x2D9A420 Offset: 0x2D9A521 VA: 0x2D9A420
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.get_Status
	|
	|-RVA: 0x2D9A980 Offset: 0x2D9AA81 VA: 0x2D9A980
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.get_Status
	|
	|-RVA: 0x2D9AF10 Offset: 0x2D9B011 VA: 0x2D9AF10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.get_Status
	|
	|-RVA: 0x2D9B440 Offset: 0x2D9B541 VA: 0x2D9B440
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.get_Status
	|
	|-RVA: 0x2D9B9B0 Offset: 0x2D9BAB1 VA: 0x2D9B9B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.get_Status
	|
	|-RVA: 0x2D9BF30 Offset: 0x2D9C031 VA: 0x2D9BF30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.get_Status
	|
	|-RVA: 0x2D9C4B0 Offset: 0x2D9C5B1 VA: 0x2D9C4B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.get_Status
	|
	|-RVA: 0x2D9CA40 Offset: 0x2D9CB41 VA: 0x2D9CA40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.get_Status
	|
	|-RVA: 0x2D9CFD0 Offset: 0x2D9D0D1 VA: 0x2D9CFD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2D9D590 Offset: 0x2D9D691 VA: 0x2D9D590
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.get_Status
	|
	|-RVA: 0x2D9DB30 Offset: 0x2D9DC31 VA: 0x2D9DB30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2D9E120 Offset: 0x2D9E221 VA: 0x2D9E120
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x2D9E6D0 Offset: 0x2D9E7D1 VA: 0x2D9E6D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2D9ECE0 Offset: 0x2D9EDE1 VA: 0x2D9ECE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x2D9F2A0 Offset: 0x2D9F3A1 VA: 0x2D9F2A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2D9F8D0 Offset: 0x2D9F9D1 VA: 0x2D9F8D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x2D9FE90 Offset: 0x2D9FF91 VA: 0x2D9FE90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2DA04B0 Offset: 0x2DA05B1 VA: 0x2DA04B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x2DA0AA0 Offset: 0x2DA0BA1 VA: 0x2DA0AA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.get_Status
	|
	|-RVA: 0x2DA0FD0 Offset: 0x2DA10D1 VA: 0x2DA0FD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.get_Status
	|
	|-RVA: 0x2DA1500 Offset: 0x2DA1601 VA: 0x2DA1500
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.get_Status
	|
	|-RVA: 0x2DA1A90 Offset: 0x2DA1B91 VA: 0x2DA1A90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.get_Status
	|
	|-RVA: 0x2DA1FC0 Offset: 0x2DA20C1 VA: 0x2DA1FC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.get_Status
	|
	|-RVA: 0x2DA2540 Offset: 0x2DA2641 VA: 0x2DA2540
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.get_Status
	|
	|-RVA: 0x2DA2AC0 Offset: 0x2DA2BC1 VA: 0x2DA2AC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.get_Status
	|
	|-RVA: 0x2DA2FF0 Offset: 0x2DA30F1 VA: 0x2DA2FF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.get_Status
	|
	|-RVA: 0x2DA3570 Offset: 0x2DA3671 VA: 0x2DA3570
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2DA3AF0 Offset: 0x2DA3BF1 VA: 0x2DA3AF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.get_Status
	|
	|-RVA: 0x2DA4070 Offset: 0x2DA4171 VA: 0x2DA4070
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.get_Status
	|
	|-RVA: 0x2DA45F0 Offset: 0x2DA46F1 VA: 0x2DA45F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.get_Status
	|
	|-RVA: 0x2DA4B20 Offset: 0x2DA4C21 VA: 0x2DA4B20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.get_Status
	|
	|-RVA: 0x2DA50A0 Offset: 0x2DA51A1 VA: 0x2DA50A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.get_Status
	|
	|-RVA: 0x2DA55D0 Offset: 0x2DA56D1 VA: 0x2DA55D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.get_Status
	|
	|-RVA: 0x2DA5B30 Offset: 0x2DA5C31 VA: 0x2DA5B30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.get_Status
	|
	|-RVA: 0x2DA60A0 Offset: 0x2DA61A1 VA: 0x2DA60A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.get_Status
	|
	|-RVA: 0x2DA6620 Offset: 0x2DA6721 VA: 0x2DA6620
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.get_Status
	|
	|-RVA: 0x2DA6BA0 Offset: 0x2DA6CA1 VA: 0x2DA6BA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.get_Status
	|
	|-RVA: 0x2DA7120 Offset: 0x2DA7221 VA: 0x2DA7120
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2DA76D0 Offset: 0x2DA77D1 VA: 0x2DA76D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.get_Status
	|
	|-RVA: 0x2DA7C60 Offset: 0x2DA7D61 VA: 0x2DA7C60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2DA8220 Offset: 0x2DA8321 VA: 0x2DA8220
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x2DA87C0 Offset: 0x2DA88C1 VA: 0x2DA87C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2DA8DC0 Offset: 0x2DA8EC1 VA: 0x2DA8DC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x2DA9370 Offset: 0x2DA9471 VA: 0x2DA9370
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2DA99A0 Offset: 0x2DA9AA1 VA: 0x2DA99A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x2DA9F60 Offset: 0x2DAA061 VA: 0x2DA9F60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2DAA5B0 Offset: 0x2DAA6B1 VA: 0x2DAA5B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x2DAAB70 Offset: 0x2DAAC71 VA: 0x2DAAB70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2DAB130 Offset: 0x2DAB231 VA: 0x2DAB130
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2DAB700 Offset: 0x2DAB801 VA: 0x2DAB700
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_Status
	|
	|-RVA: 0x2DABC20 Offset: 0x2DABD21 VA: 0x2DABC20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.get_Status
	|
	|-RVA: 0x2DAC140 Offset: 0x2DAC241 VA: 0x2DAC140
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.get_Status
	|
	|-RVA: 0x2DAC6C0 Offset: 0x2DAC7C1 VA: 0x2DAC6C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.get_Status
	|
	|-RVA: 0x2DACBE0 Offset: 0x2DACCE1 VA: 0x2DACBE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.get_Status
	|
	|-RVA: 0x2DAD150 Offset: 0x2DAD251 VA: 0x2DAD150
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, double>>>.get_Status
	|
	|-RVA: 0x2DAD6B0 Offset: 0x2DAD7B1 VA: 0x2DAD6B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, int>>>.get_Status
	|
	|-RVA: 0x2F64EF0 Offset: 0x2F64FF1 VA: 0x2F64EF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, long>>>.get_Status
	|
	|-RVA: 0x2F65450 Offset: 0x2F65551 VA: 0x2F65450
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2F659B0 Offset: 0x2F65AB1 VA: 0x2F659B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.get_Status
	|
	|-RVA: 0x2F65F20 Offset: 0x2F66021 VA: 0x2F65F20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.get_Status
	|
	|-RVA: 0x2F66490 Offset: 0x2F66591 VA: 0x2F66490
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, float>>>.get_Status
	|
	|-RVA: 0x2F669A0 Offset: 0x2F66AA1 VA: 0x2F669A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.get_Status
	|
	|-RVA: 0x2F66F00 Offset: 0x2F67001 VA: 0x2F66F00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.get_Status
	|
	|-RVA: 0x2F67420 Offset: 0x2F67521 VA: 0x2F67420
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.get_Status
	|
	|-RVA: 0x2F67950 Offset: 0x2F67A51 VA: 0x2F67950
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.get_Status
	|
	|-RVA: 0x2F67EB0 Offset: 0x2F67FB1 VA: 0x2F67EB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.get_Status
	|
	|-RVA: 0x2F68420 Offset: 0x2F68521 VA: 0x2F68420
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, object>>>.get_Status
	|
	|-RVA: 0x2F68980 Offset: 0x2F68A81 VA: 0x2F68980
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object>>>.get_Status
	|
	|-RVA: 0x2F68EE0 Offset: 0x2F68FE1 VA: 0x2F68EE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2F69480 Offset: 0x2F69581 VA: 0x2F69480
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.get_Status
	|
	|-RVA: 0x2F69A00 Offset: 0x2F69B01 VA: 0x2F69A00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2F69FC0 Offset: 0x2F6A0C1 VA: 0x2F69FC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.get_Status
	|
	|-RVA: 0x2F6A550 Offset: 0x2F6A651 VA: 0x2F6A550
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2F6AB40 Offset: 0x2F6AC41 VA: 0x2F6AB40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x2F6B0E0 Offset: 0x2F6B1E1 VA: 0x2F6B0E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2F6B6F0 Offset: 0x2F6B7F1 VA: 0x2F6B6F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x2F6BCA0 Offset: 0x2F6BDA1 VA: 0x2F6BCA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2F6C2D0 Offset: 0x2F6C3D1 VA: 0x2F6C2D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x2F6C890 Offset: 0x2F6C991 VA: 0x2F6C890
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2F6CEB0 Offset: 0x2F6CFB1 VA: 0x2F6CEB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2F6D480 Offset: 0x2F6D581 VA: 0x2F6D480
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, AsyncUnit>>.get_Status
	|
	|-RVA: 0x2F6D9B0 Offset: 0x2F6DAB1 VA: 0x2F6D9B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, bool>>.get_Status
	|
	|-RVA: 0x2F6DEE0 Offset: 0x2F6DFE1 VA: 0x2F6DEE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Bounds>>.get_Status
	|
	|-RVA: 0x2F6E460 Offset: 0x2F6E561 VA: 0x2F6E460
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, byte>>.get_Status
	|
	|-RVA: 0x2F6E990 Offset: 0x2F6EA91 VA: 0x2F6E990
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Color>>.get_Status
	|
	|-RVA: 0x2F6EEF0 Offset: 0x2F6EFF1 VA: 0x2F6EEF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, double>>.get_Status
	|
	|-RVA: 0x2F6F410 Offset: 0x2F6F511 VA: 0x2F6F410
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, int>>.get_Status
	|
	|-RVA: 0x2F6F930 Offset: 0x2F6FA31 VA: 0x2F6F930
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, long>>.get_Status
	|
	|-RVA: 0x2F6FE50 Offset: 0x2F6FF51 VA: 0x2F6FE50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, object>>.get_Status
	|
	|-RVA: 0x2F70370 Offset: 0x2F70471 VA: 0x2F70370
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Quaternion>>.get_Status
	|
	|-RVA: 0x2F708D0 Offset: 0x2F709D1 VA: 0x2F708D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Rect>>.get_Status
	|
	|-RVA: 0x2F70E30 Offset: 0x2F70F31 VA: 0x2F70E30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, float>>.get_Status
	|
	|-RVA: 0x2F71350 Offset: 0x2F71451 VA: 0x2F71350
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, UniTask>>.get_Status
	|
	|-RVA: 0x2F71870 Offset: 0x2F71971 VA: 0x2F71870
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Unit>>.get_Status
	|
	|-RVA: 0x2F71DA0 Offset: 0x2F71EA1 VA: 0x2F71DA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector2>>.get_Status
	|
	|-RVA: 0x2F722B0 Offset: 0x2F723B1 VA: 0x2F722B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector3>>.get_Status
	|
	|-RVA: 0x2F727E0 Offset: 0x2F728E1 VA: 0x2F727E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector4>>.get_Status
	|
	|-RVA: 0x2F72D40 Offset: 0x2F72E41 VA: 0x2F72D40
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, object>>.get_Status
	|
	|-RVA: 0x2F73260 Offset: 0x2F73361 VA: 0x2F73260
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object>>.get_Status
	|
	|-RVA: 0x2F73780 Offset: 0x2F73881 VA: 0x2F73780
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2F73D10 Offset: 0x2F73E11 VA: 0x2F73D10
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object>>.get_Status
	|
	|-RVA: 0x2F74270 Offset: 0x2F74371 VA: 0x2F74270
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2F74820 Offset: 0x2F74921 VA: 0x2F74820
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object>>.get_Status
	|
	|-RVA: 0x2F74DA0 Offset: 0x2F74EA1 VA: 0x2F74DA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2F75360 Offset: 0x2F75461 VA: 0x2F75360
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x2F758F0 Offset: 0x2F759F1 VA: 0x2F758F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2F75EF0 Offset: 0x2F75FF1 VA: 0x2F75EF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x2F76490 Offset: 0x2F76591 VA: 0x2F76490
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2F76AC0 Offset: 0x2F76BC1 VA: 0x2F76AC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x2F77070 Offset: 0x2F77171 VA: 0x2F77070
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2F776C0 Offset: 0x2F777C1 VA: 0x2F776C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2F77C80 Offset: 0x2F77D81 VA: 0x2F77C80
	|-UniTask.IsCanceledAwaiter<AsyncUnit>.get_Status
	|
	|-RVA: 0x2F78190 Offset: 0x2F78291 VA: 0x2F78190
	|-UniTask.IsCanceledAwaiter<bool>.get_Status
	|
	|-RVA: 0x2F786A0 Offset: 0x2F787A1 VA: 0x2F786A0
	|-UniTask.IsCanceledAwaiter<Bounds>.get_Status
	|
	|-RVA: 0x2F78C10 Offset: 0x2F78D11 VA: 0x2F78C10
	|-UniTask.IsCanceledAwaiter<byte>.get_Status
	|
	|-RVA: 0x2F79120 Offset: 0x2F79221 VA: 0x2F79120
	|-UniTask.IsCanceledAwaiter<Color>.get_Status
	|
	|-RVA: 0x2F79650 Offset: 0x2F79751 VA: 0x2F79650
	|-UniTask.IsCanceledAwaiter<double>.get_Status
	|
	|-RVA: 0x2F79B60 Offset: 0x2F79C61 VA: 0x2F79B60
	|-UniTask.IsCanceledAwaiter<int>.get_Status
	|
	|-RVA: 0x2F7A070 Offset: 0x2F7A171 VA: 0x2F7A070
	|-UniTask.IsCanceledAwaiter<long>.get_Status
	|
	|-RVA: 0x2F7A580 Offset: 0x2F7A681 VA: 0x2F7A580
	|-UniTask.IsCanceledAwaiter<object>.get_Status
	|
	|-RVA: 0x2F7AA90 Offset: 0x2F7AB91 VA: 0x2F7AA90
	|-UniTask.IsCanceledAwaiter<Quaternion>.get_Status
	|
	|-RVA: 0x2F7AFC0 Offset: 0x2F7B0C1 VA: 0x2F7AFC0
	|-UniTask.IsCanceledAwaiter<Rect>.get_Status
	|
	|-RVA: 0x2F7B4F0 Offset: 0x2F7B5F1 VA: 0x2F7B4F0
	|-UniTask.IsCanceledAwaiter<float>.get_Status
	|
	|-RVA: 0x2F7BA00 Offset: 0x2F7BB01 VA: 0x2F7BA00
	|-UniTask.IsCanceledAwaiter<UniTask>.get_Status
	|
	|-RVA: 0x2F7BF10 Offset: 0x2F7C011 VA: 0x2F7BF10
	|-UniTask.IsCanceledAwaiter<Unit>.get_Status
	|
	|-RVA: 0x2F7C420 Offset: 0x2F7C521 VA: 0x2F7C420
	|-UniTask.IsCanceledAwaiter<Vector2>.get_Status
	|
	|-RVA: 0x2F7C940 Offset: 0x2F7CA41 VA: 0x2F7C940
	|-UniTask.IsCanceledAwaiter<Vector3>.get_Status
	|
	|-RVA: 0x2F7CE50 Offset: 0x2F7CF51 VA: 0x2F7CE50
	|-UniTask.IsCanceledAwaiter<Vector4>.get_Status
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public ValueTuple<bool, T> GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8C830 Offset: 0x2D8C931 VA: 0x2D8C830
	|-UniTask.IsCanceledAwaiter<UniTask<object>>.GetResult
	|
	|-RVA: 0x2D8CD50 Offset: 0x2D8CE51 VA: 0x2D8CD50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, UniTask<object>>>.GetResult
	|
	|-RVA: 0x2D8D2B0 Offset: 0x2D8D3B1 VA: 0x2D8D2B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.GetResult
	|
	|-RVA: 0x2D8D830 Offset: 0x2D8D931 VA: 0x2D8D830
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.GetResult
	|
	|-RVA: 0x2D8DDC0 Offset: 0x2D8DEC1 VA: 0x2D8DDC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.GetResult
	|
	|-RVA: 0x2D8E360 Offset: 0x2D8E461 VA: 0x2D8E360
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.GetResult
	|
	|-RVA: 0x2D8E8A0 Offset: 0x2D8E9A1 VA: 0x2D8E8A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.GetResult
	|
	|-RVA: 0x2D8EDE0 Offset: 0x2D8EEE1 VA: 0x2D8EDE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.GetResult
	|
	|-RVA: 0x2D8F390 Offset: 0x2D8F491 VA: 0x2D8F390
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.GetResult
	|
	|-RVA: 0x2D8F8D0 Offset: 0x2D8F9D1 VA: 0x2D8F8D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.GetResult
	|
	|-RVA: 0x2D8FE60 Offset: 0x2D8FF61 VA: 0x2D8FE60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.GetResult
	|
	|-RVA: 0x2D90400 Offset: 0x2D90501 VA: 0x2D90400
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.GetResult
	|
	|-RVA: 0x2D90970 Offset: 0x2D90A71 VA: 0x2D90970
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.GetResult
	|
	|-RVA: 0x2D90F10 Offset: 0x2D91011 VA: 0x2D90F10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x2D914B0 Offset: 0x2D915B1 VA: 0x2D914B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.GetResult
	|
	|-RVA: 0x2D91A40 Offset: 0x2D91B41 VA: 0x2D91A40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.GetResult
	|
	|-RVA: 0x2D91FD0 Offset: 0x2D920D1 VA: 0x2D91FD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.GetResult
	|
	|-RVA: 0x2D92540 Offset: 0x2D92641 VA: 0x2D92540
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.GetResult
	|
	|-RVA: 0x2D92AE0 Offset: 0x2D92BE1 VA: 0x2D92AE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.GetResult
	|
	|-RVA: 0x2D93020 Offset: 0x2D93121 VA: 0x2D93020
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.GetResult
	|
	|-RVA: 0x2D935A0 Offset: 0x2D936A1 VA: 0x2D935A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.GetResult
	|
	|-RVA: 0x2D93B20 Offset: 0x2D93C21 VA: 0x2D93B20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.GetResult
	|
	|-RVA: 0x2D940B0 Offset: 0x2D941B1 VA: 0x2D940B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.GetResult
	|
	|-RVA: 0x2D94650 Offset: 0x2D94751 VA: 0x2D94650
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.GetResult
	|
	|-RVA: 0x2D94BF0 Offset: 0x2D94CF1 VA: 0x2D94BF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x2D951A0 Offset: 0x2D952A1 VA: 0x2D951A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x2D95760 Offset: 0x2D95861 VA: 0x2D95760
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x2D95D20 Offset: 0x2D95E21 VA: 0x2D95D20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x2D96310 Offset: 0x2D96411 VA: 0x2D96310
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x2D96910 Offset: 0x2D96A11 VA: 0x2D96910
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.GetResult
	|
	|-RVA: 0x2D96E40 Offset: 0x2D96F41 VA: 0x2D96E40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.GetResult
	|
	|-RVA: 0x2D97370 Offset: 0x2D97471 VA: 0x2D97370
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.GetResult
	|
	|-RVA: 0x2D97910 Offset: 0x2D97A11 VA: 0x2D97910
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.GetResult
	|
	|-RVA: 0x2D97E40 Offset: 0x2D97F41 VA: 0x2D97E40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.GetResult
	|
	|-RVA: 0x2D983C0 Offset: 0x2D984C1 VA: 0x2D983C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.GetResult
	|
	|-RVA: 0x2D98950 Offset: 0x2D98A51 VA: 0x2D98950
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.GetResult
	|
	|-RVA: 0x2D98EB0 Offset: 0x2D98FB1 VA: 0x2D98EB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.GetResult
	|
	|-RVA: 0x2D99440 Offset: 0x2D99541 VA: 0x2D99440
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2D999D0 Offset: 0x2D99AD1 VA: 0x2D999D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.GetResult
	|
	|-RVA: 0x2D99F50 Offset: 0x2D9A051 VA: 0x2D99F50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.GetResult
	|
	|-RVA: 0x2D9A4D0 Offset: 0x2D9A5D1 VA: 0x2D9A4D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.GetResult
	|
	|-RVA: 0x2D9AA30 Offset: 0x2D9AB31 VA: 0x2D9AA30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.GetResult
	|
	|-RVA: 0x2D9AFC0 Offset: 0x2D9B0C1 VA: 0x2D9AFC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.GetResult
	|
	|-RVA: 0x2D9B4F0 Offset: 0x2D9B5F1 VA: 0x2D9B4F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.GetResult
	|
	|-RVA: 0x2D9BA60 Offset: 0x2D9BB61 VA: 0x2D9BA60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.GetResult
	|
	|-RVA: 0x2D9BFE0 Offset: 0x2D9C0E1 VA: 0x2D9BFE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.GetResult
	|
	|-RVA: 0x2D9C560 Offset: 0x2D9C661 VA: 0x2D9C560
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.GetResult
	|
	|-RVA: 0x2D9CAF0 Offset: 0x2D9CBF1 VA: 0x2D9CAF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.GetResult
	|
	|-RVA: 0x2D9D080 Offset: 0x2D9D181 VA: 0x2D9D080
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x2D9D640 Offset: 0x2D9D741 VA: 0x2D9D640
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.GetResult
	|
	|-RVA: 0x2D9DBE0 Offset: 0x2D9DCE1 VA: 0x2D9DBE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x2D9E1D0 Offset: 0x2D9E2D1 VA: 0x2D9E1D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x2D9E780 Offset: 0x2D9E881 VA: 0x2D9E780
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x2D9ED90 Offset: 0x2D9EE91 VA: 0x2D9ED90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x2D9F350 Offset: 0x2D9F451 VA: 0x2D9F350
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x2D9F980 Offset: 0x2D9FA81 VA: 0x2D9F980
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x2D9FF40 Offset: 0x2DA0041 VA: 0x2D9FF40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x2DA0560 Offset: 0x2DA0661 VA: 0x2DA0560
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x2DA0B50 Offset: 0x2DA0C51 VA: 0x2DA0B50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.GetResult
	|
	|-RVA: 0x2DA1080 Offset: 0x2DA1181 VA: 0x2DA1080
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.GetResult
	|
	|-RVA: 0x2DA15B0 Offset: 0x2DA16B1 VA: 0x2DA15B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.GetResult
	|
	|-RVA: 0x2DA1B40 Offset: 0x2DA1C41 VA: 0x2DA1B40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.GetResult
	|
	|-RVA: 0x2DA2070 Offset: 0x2DA2171 VA: 0x2DA2070
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.GetResult
	|
	|-RVA: 0x2DA25F0 Offset: 0x2DA26F1 VA: 0x2DA25F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.GetResult
	|
	|-RVA: 0x2DA2B70 Offset: 0x2DA2C71 VA: 0x2DA2B70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.GetResult
	|
	|-RVA: 0x2DA30A0 Offset: 0x2DA31A1 VA: 0x2DA30A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.GetResult
	|
	|-RVA: 0x2DA3620 Offset: 0x2DA3721 VA: 0x2DA3620
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2DA3BA0 Offset: 0x2DA3CA1 VA: 0x2DA3BA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.GetResult
	|
	|-RVA: 0x2DA4120 Offset: 0x2DA4221 VA: 0x2DA4120
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.GetResult
	|
	|-RVA: 0x2DA46A0 Offset: 0x2DA47A1 VA: 0x2DA46A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.GetResult
	|
	|-RVA: 0x2DA4BD0 Offset: 0x2DA4CD1 VA: 0x2DA4BD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.GetResult
	|
	|-RVA: 0x2DA5150 Offset: 0x2DA5251 VA: 0x2DA5150
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.GetResult
	|
	|-RVA: 0x2DA5680 Offset: 0x2DA5781 VA: 0x2DA5680
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.GetResult
	|
	|-RVA: 0x2DA5BE0 Offset: 0x2DA5CE1 VA: 0x2DA5BE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.GetResult
	|
	|-RVA: 0x2DA6150 Offset: 0x2DA6251 VA: 0x2DA6150
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.GetResult
	|
	|-RVA: 0x2DA66D0 Offset: 0x2DA67D1 VA: 0x2DA66D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.GetResult
	|
	|-RVA: 0x2DA6C50 Offset: 0x2DA6D51 VA: 0x2DA6C50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.GetResult
	|
	|-RVA: 0x2DA71D0 Offset: 0x2DA72D1 VA: 0x2DA71D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2DA7780 Offset: 0x2DA7881 VA: 0x2DA7780
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.GetResult
	|
	|-RVA: 0x2DA7D10 Offset: 0x2DA7E11 VA: 0x2DA7D10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2DA82D0 Offset: 0x2DA83D1 VA: 0x2DA82D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x2DA8870 Offset: 0x2DA8971 VA: 0x2DA8870
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2DA8E70 Offset: 0x2DA8F71 VA: 0x2DA8E70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x2DA9420 Offset: 0x2DA9521 VA: 0x2DA9420
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2DA9A50 Offset: 0x2DA9B51 VA: 0x2DA9A50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x2DAA010 Offset: 0x2DAA111 VA: 0x2DAA010
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2DAA660 Offset: 0x2DAA761 VA: 0x2DAA660
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x2DAAC20 Offset: 0x2DAAD21 VA: 0x2DAAC20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x2DAB1E0 Offset: 0x2DAB2E1 VA: 0x2DAB1E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x2DAB7B0 Offset: 0x2DAB8B1 VA: 0x2DAB7B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.GetResult
	|
	|-RVA: 0x2DABCD0 Offset: 0x2DABDD1 VA: 0x2DABCD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.GetResult
	|
	|-RVA: 0x2DAC1F0 Offset: 0x2DAC2F1 VA: 0x2DAC1F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.GetResult
	|
	|-RVA: 0x2DAC770 Offset: 0x2DAC871 VA: 0x2DAC770
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.GetResult
	|
	|-RVA: 0x2DACC90 Offset: 0x2DACD91 VA: 0x2DACC90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.GetResult
	|
	|-RVA: 0x2DAD200 Offset: 0x2DAD301 VA: 0x2DAD200
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, double>>>.GetResult
	|
	|-RVA: 0x2DAD760 Offset: 0x2DAD861 VA: 0x2DAD760
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, int>>>.GetResult
	|
	|-RVA: 0x2F64FA0 Offset: 0x2F650A1 VA: 0x2F64FA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, long>>>.GetResult
	|
	|-RVA: 0x2F65500 Offset: 0x2F65601 VA: 0x2F65500
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x2F65A60 Offset: 0x2F65B61 VA: 0x2F65A60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.GetResult
	|
	|-RVA: 0x2F65FD0 Offset: 0x2F660D1 VA: 0x2F65FD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.GetResult
	|
	|-RVA: 0x2F66540 Offset: 0x2F66641 VA: 0x2F66540
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, float>>>.GetResult
	|
	|-RVA: 0x2F66A50 Offset: 0x2F66B51 VA: 0x2F66A50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.GetResult
	|
	|-RVA: 0x2F66FB0 Offset: 0x2F670B1 VA: 0x2F66FB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.GetResult
	|
	|-RVA: 0x2F674D0 Offset: 0x2F675D1 VA: 0x2F674D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.GetResult
	|
	|-RVA: 0x2F67A00 Offset: 0x2F67B01 VA: 0x2F67A00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.GetResult
	|
	|-RVA: 0x2F67F60 Offset: 0x2F68061 VA: 0x2F67F60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.GetResult
	|
	|-RVA: 0x2F684D0 Offset: 0x2F685D1 VA: 0x2F684D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, object>>>.GetResult
	|
	|-RVA: 0x2F68A30 Offset: 0x2F68B31 VA: 0x2F68A30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object>>>.GetResult
	|
	|-RVA: 0x2F68F90 Offset: 0x2F69091 VA: 0x2F68F90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2F69530 Offset: 0x2F69631 VA: 0x2F69530
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.GetResult
	|
	|-RVA: 0x2F69AB0 Offset: 0x2F69BB1 VA: 0x2F69AB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2F6A070 Offset: 0x2F6A171 VA: 0x2F6A070
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.GetResult
	|
	|-RVA: 0x2F6A600 Offset: 0x2F6A701 VA: 0x2F6A600
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2F6ABF0 Offset: 0x2F6ACF1 VA: 0x2F6ABF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.GetResult
	|
	|-RVA: 0x2F6B190 Offset: 0x2F6B291 VA: 0x2F6B190
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2F6B7A0 Offset: 0x2F6B8A1 VA: 0x2F6B7A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.GetResult
	|
	|-RVA: 0x2F6BD50 Offset: 0x2F6BE51 VA: 0x2F6BD50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2F6C380 Offset: 0x2F6C481 VA: 0x2F6C380
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.GetResult
	|
	|-RVA: 0x2F6C940 Offset: 0x2F6CA41 VA: 0x2F6C940
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2F6CF60 Offset: 0x2F6D061 VA: 0x2F6CF60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x2F6D530 Offset: 0x2F6D631 VA: 0x2F6D530
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, AsyncUnit>>.GetResult
	|
	|-RVA: 0x2F6DA60 Offset: 0x2F6DB61 VA: 0x2F6DA60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, bool>>.GetResult
	|
	|-RVA: 0x2F6DF90 Offset: 0x2F6E091 VA: 0x2F6DF90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Bounds>>.GetResult
	|
	|-RVA: 0x2F6E510 Offset: 0x2F6E611 VA: 0x2F6E510
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, byte>>.GetResult
	|
	|-RVA: 0x2F6EA40 Offset: 0x2F6EB41 VA: 0x2F6EA40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Color>>.GetResult
	|
	|-RVA: 0x2F6EFA0 Offset: 0x2F6F0A1 VA: 0x2F6EFA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, double>>.GetResult
	|
	|-RVA: 0x2F6F4C0 Offset: 0x2F6F5C1 VA: 0x2F6F4C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, int>>.GetResult
	|
	|-RVA: 0x2F6F9E0 Offset: 0x2F6FAE1 VA: 0x2F6F9E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, long>>.GetResult
	|
	|-RVA: 0x2F6FF00 Offset: 0x2F70001 VA: 0x2F6FF00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, object>>.GetResult
	|
	|-RVA: 0x2F70420 Offset: 0x2F70521 VA: 0x2F70420
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Quaternion>>.GetResult
	|
	|-RVA: 0x2F70980 Offset: 0x2F70A81 VA: 0x2F70980
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Rect>>.GetResult
	|
	|-RVA: 0x2F70EE0 Offset: 0x2F70FE1 VA: 0x2F70EE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, float>>.GetResult
	|
	|-RVA: 0x2F71400 Offset: 0x2F71501 VA: 0x2F71400
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, UniTask>>.GetResult
	|
	|-RVA: 0x2F71920 Offset: 0x2F71A21 VA: 0x2F71920
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Unit>>.GetResult
	|
	|-RVA: 0x2F71E50 Offset: 0x2F71F51 VA: 0x2F71E50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector2>>.GetResult
	|
	|-RVA: 0x2F72360 Offset: 0x2F72461 VA: 0x2F72360
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector3>>.GetResult
	|
	|-RVA: 0x2F72890 Offset: 0x2F72991 VA: 0x2F72890
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector4>>.GetResult
	|
	|-RVA: 0x2F72DF0 Offset: 0x2F72EF1 VA: 0x2F72DF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, object>>.GetResult
	|
	|-RVA: 0x2F73310 Offset: 0x2F73411 VA: 0x2F73310
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object>>.GetResult
	|
	|-RVA: 0x2F73830 Offset: 0x2F73931 VA: 0x2F73830
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x2F73DC0 Offset: 0x2F73EC1 VA: 0x2F73DC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object>>.GetResult
	|
	|-RVA: 0x2F74320 Offset: 0x2F74421 VA: 0x2F74320
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x2F748D0 Offset: 0x2F749D1 VA: 0x2F748D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object>>.GetResult
	|
	|-RVA: 0x2F74E50 Offset: 0x2F74F51 VA: 0x2F74E50
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x2F75410 Offset: 0x2F75511 VA: 0x2F75410
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object>>.GetResult
	|
	|-RVA: 0x2F759A0 Offset: 0x2F75AA1 VA: 0x2F759A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x2F75FA0 Offset: 0x2F760A1 VA: 0x2F75FA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object, object>>.GetResult
	|
	|-RVA: 0x2F76540 Offset: 0x2F76641 VA: 0x2F76540
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x2F76B70 Offset: 0x2F76C71 VA: 0x2F76B70
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object, object, object>>.GetResult
	|
	|-RVA: 0x2F77120 Offset: 0x2F77221 VA: 0x2F77120
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2F77770 Offset: 0x2F77871 VA: 0x2F77770
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x2F77D30 Offset: 0x2F77E31 VA: 0x2F77D30
	|-UniTask.IsCanceledAwaiter<AsyncUnit>.GetResult
	|
	|-RVA: 0x2F78240 Offset: 0x2F78341 VA: 0x2F78240
	|-UniTask.IsCanceledAwaiter<bool>.GetResult
	|
	|-RVA: 0x2F78750 Offset: 0x2F78851 VA: 0x2F78750
	|-UniTask.IsCanceledAwaiter<Bounds>.GetResult
	|
	|-RVA: 0x2F78CC0 Offset: 0x2F78DC1 VA: 0x2F78CC0
	|-UniTask.IsCanceledAwaiter<byte>.GetResult
	|
	|-RVA: 0x2F791D0 Offset: 0x2F792D1 VA: 0x2F791D0
	|-UniTask.IsCanceledAwaiter<Color>.GetResult
	|
	|-RVA: 0x2F79700 Offset: 0x2F79801 VA: 0x2F79700
	|-UniTask.IsCanceledAwaiter<double>.GetResult
	|
	|-RVA: 0x2F79C10 Offset: 0x2F79D11 VA: 0x2F79C10
	|-UniTask.IsCanceledAwaiter<int>.GetResult
	|
	|-RVA: 0x2F7A120 Offset: 0x2F7A221 VA: 0x2F7A120
	|-UniTask.IsCanceledAwaiter<long>.GetResult
	|
	|-RVA: 0x2F7A630 Offset: 0x2F7A731 VA: 0x2F7A630
	|-UniTask.IsCanceledAwaiter<object>.GetResult
	|
	|-RVA: 0x2F7AB40 Offset: 0x2F7AC41 VA: 0x2F7AB40
	|-UniTask.IsCanceledAwaiter<Quaternion>.GetResult
	|
	|-RVA: 0x2F7B070 Offset: 0x2F7B171 VA: 0x2F7B070
	|-UniTask.IsCanceledAwaiter<Rect>.GetResult
	|
	|-RVA: 0x2F7B5A0 Offset: 0x2F7B6A1 VA: 0x2F7B5A0
	|-UniTask.IsCanceledAwaiter<float>.GetResult
	|
	|-RVA: 0x2F7BAB0 Offset: 0x2F7BBB1 VA: 0x2F7BAB0
	|-UniTask.IsCanceledAwaiter<UniTask>.GetResult
	|
	|-RVA: 0x2F7BFC0 Offset: 0x2F7C0C1 VA: 0x2F7BFC0
	|-UniTask.IsCanceledAwaiter<Unit>.GetResult
	|
	|-RVA: 0x2F7C4D0 Offset: 0x2F7C5D1 VA: 0x2F7C4D0
	|-UniTask.IsCanceledAwaiter<Vector2>.GetResult
	|
	|-RVA: 0x2F7C9F0 Offset: 0x2F7CAF1 VA: 0x2F7C9F0
	|-UniTask.IsCanceledAwaiter<Vector3>.GetResult
	|
	|-RVA: 0x2F7CF00 Offset: 0x2F7D001 VA: 0x2F7CF00
	|-UniTask.IsCanceledAwaiter<Vector4>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8C9C0 Offset: 0x2D8CAC1 VA: 0x2D8C9C0
	|-UniTask.IsCanceledAwaiter<UniTask<object>>.OnCompleted
	|
	|-RVA: 0x2D8CF10 Offset: 0x2D8D011 VA: 0x2D8CF10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, UniTask<object>>>.OnCompleted
	|
	|-RVA: 0x2D8D490 Offset: 0x2D8D591 VA: 0x2D8D490
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.OnCompleted
	|
	|-RVA: 0x2D8DA20 Offset: 0x2D8DB21 VA: 0x2D8DA20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.OnCompleted
	|
	|-RVA: 0x2D8DFC0 Offset: 0x2D8E0C1 VA: 0x2D8DFC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.OnCompleted
	|
	|-RVA: 0x2D8E510 Offset: 0x2D8E611 VA: 0x2D8E510
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.OnCompleted
	|
	|-RVA: 0x2D8EA50 Offset: 0x2D8EB51 VA: 0x2D8EA50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.OnCompleted
	|
	|-RVA: 0x2D8EFF0 Offset: 0x2D8F0F1 VA: 0x2D8EFF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.OnCompleted
	|
	|-RVA: 0x2D8F540 Offset: 0x2D8F641 VA: 0x2D8F540
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.OnCompleted
	|
	|-RVA: 0x2D8FAC0 Offset: 0x2D8FBC1 VA: 0x2D8FAC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.OnCompleted
	|
	|-RVA: 0x2D90060 Offset: 0x2D90161 VA: 0x2D90060
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.OnCompleted
	|
	|-RVA: 0x2D905D0 Offset: 0x2D906D1 VA: 0x2D905D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.OnCompleted
	|
	|-RVA: 0x2D90B70 Offset: 0x2D90C71 VA: 0x2D90B70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.OnCompleted
	|
	|-RVA: 0x2D91110 Offset: 0x2D91211 VA: 0x2D91110
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2D916A0 Offset: 0x2D917A1 VA: 0x2D916A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.OnCompleted
	|
	|-RVA: 0x2D91C30 Offset: 0x2D91D31 VA: 0x2D91C30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.OnCompleted
	|
	|-RVA: 0x2D921A0 Offset: 0x2D922A1 VA: 0x2D921A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.OnCompleted
	|
	|-RVA: 0x2D92740 Offset: 0x2D92841 VA: 0x2D92740
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.OnCompleted
	|
	|-RVA: 0x2D92C90 Offset: 0x2D92D91 VA: 0x2D92C90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.OnCompleted
	|
	|-RVA: 0x2D93200 Offset: 0x2D93301 VA: 0x2D93200
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.OnCompleted
	|
	|-RVA: 0x2D93780 Offset: 0x2D93881 VA: 0x2D93780
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.OnCompleted
	|
	|-RVA: 0x2D93D10 Offset: 0x2D93E11 VA: 0x2D93D10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.OnCompleted
	|
	|-RVA: 0x2D942B0 Offset: 0x2D943B1 VA: 0x2D942B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2D94850 Offset: 0x2D94951 VA: 0x2D94850
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2D94E00 Offset: 0x2D94F01 VA: 0x2D94E00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2D953C0 Offset: 0x2D954C1 VA: 0x2D953C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2D95980 Offset: 0x2D95A81 VA: 0x2D95980
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2D95F70 Offset: 0x2D96071 VA: 0x2D95F70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2D96570 Offset: 0x2D96671 VA: 0x2D96570
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2D96AB0 Offset: 0x2D96BB1 VA: 0x2D96AB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.OnCompleted
	|
	|-RVA: 0x2D96FE0 Offset: 0x2D970E1 VA: 0x2D96FE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.OnCompleted
	|
	|-RVA: 0x2D97570 Offset: 0x2D97671 VA: 0x2D97570
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.OnCompleted
	|
	|-RVA: 0x2D97AB0 Offset: 0x2D97BB1 VA: 0x2D97AB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.OnCompleted
	|
	|-RVA: 0x2D98020 Offset: 0x2D98121 VA: 0x2D98020
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.OnCompleted
	|
	|-RVA: 0x2D985B0 Offset: 0x2D986B1 VA: 0x2D985B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.OnCompleted
	|
	|-RVA: 0x2D98B10 Offset: 0x2D98C11 VA: 0x2D98B10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.OnCompleted
	|
	|-RVA: 0x2D990A0 Offset: 0x2D991A1 VA: 0x2D990A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.OnCompleted
	|
	|-RVA: 0x2D99630 Offset: 0x2D99731 VA: 0x2D99630
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2D99BB0 Offset: 0x2D99CB1 VA: 0x2D99BB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.OnCompleted
	|
	|-RVA: 0x2D9A130 Offset: 0x2D9A231 VA: 0x2D9A130
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.OnCompleted
	|
	|-RVA: 0x2D9A690 Offset: 0x2D9A791 VA: 0x2D9A690
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.OnCompleted
	|
	|-RVA: 0x2D9AC20 Offset: 0x2D9AD21 VA: 0x2D9AC20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.OnCompleted
	|
	|-RVA: 0x2D9B160 Offset: 0x2D9B261 VA: 0x2D9B160
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.OnCompleted
	|
	|-RVA: 0x2D9B6C0 Offset: 0x2D9B7C1 VA: 0x2D9B6C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.OnCompleted
	|
	|-RVA: 0x2D9BC40 Offset: 0x2D9BD41 VA: 0x2D9BC40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.OnCompleted
	|
	|-RVA: 0x2D9C1C0 Offset: 0x2D9C2C1 VA: 0x2D9C1C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.OnCompleted
	|
	|-RVA: 0x2D9C750 Offset: 0x2D9C851 VA: 0x2D9C750
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.OnCompleted
	|
	|-RVA: 0x2D9CCE0 Offset: 0x2D9CDE1 VA: 0x2D9CCE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.OnCompleted
	|
	|-RVA: 0x2D9D2A0 Offset: 0x2D9D3A1 VA: 0x2D9D2A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2D9D840 Offset: 0x2D9D941 VA: 0x2D9D840
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x2D9DE30 Offset: 0x2D9DF31 VA: 0x2D9DE30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2D9E3E0 Offset: 0x2D9E4E1 VA: 0x2D9E3E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x2D9E9F0 Offset: 0x2D9EAF1 VA: 0x2D9E9F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2D9EFB0 Offset: 0x2D9F0B1 VA: 0x2D9EFB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x2D9F5E0 Offset: 0x2D9F6E1 VA: 0x2D9F5E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2D9FBA0 Offset: 0x2D9FCA1 VA: 0x2D9FBA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x2DA01C0 Offset: 0x2DA02C1 VA: 0x2DA01C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2DA07B0 Offset: 0x2DA08B1 VA: 0x2DA07B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x2DA0CF0 Offset: 0x2DA0DF1 VA: 0x2DA0CF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.OnCompleted
	|
	|-RVA: 0x2DA1220 Offset: 0x2DA1321 VA: 0x2DA1220
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.OnCompleted
	|
	|-RVA: 0x2DA17A0 Offset: 0x2DA18A1 VA: 0x2DA17A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.OnCompleted
	|
	|-RVA: 0x2DA1CE0 Offset: 0x2DA1DE1 VA: 0x2DA1CE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.OnCompleted
	|
	|-RVA: 0x2DA2250 Offset: 0x2DA2351 VA: 0x2DA2250
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.OnCompleted
	|
	|-RVA: 0x2DA27D0 Offset: 0x2DA28D1 VA: 0x2DA27D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.OnCompleted
	|
	|-RVA: 0x2DA2D10 Offset: 0x2DA2E11 VA: 0x2DA2D10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.OnCompleted
	|
	|-RVA: 0x2DA3280 Offset: 0x2DA3381 VA: 0x2DA3280
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.OnCompleted
	|
	|-RVA: 0x2DA3800 Offset: 0x2DA3901 VA: 0x2DA3800
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2DA3D80 Offset: 0x2DA3E81 VA: 0x2DA3D80
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.OnCompleted
	|
	|-RVA: 0x2DA4300 Offset: 0x2DA4401 VA: 0x2DA4300
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.OnCompleted
	|
	|-RVA: 0x2DA4840 Offset: 0x2DA4941 VA: 0x2DA4840
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.OnCompleted
	|
	|-RVA: 0x2DA4DB0 Offset: 0x2DA4EB1 VA: 0x2DA4DB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.OnCompleted
	|
	|-RVA: 0x2DA52F0 Offset: 0x2DA53F1 VA: 0x2DA52F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.OnCompleted
	|
	|-RVA: 0x2DA5840 Offset: 0x2DA5941 VA: 0x2DA5840
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.OnCompleted
	|
	|-RVA: 0x2DA5DB0 Offset: 0x2DA5EB1 VA: 0x2DA5DB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.OnCompleted
	|
	|-RVA: 0x2DA6330 Offset: 0x2DA6431 VA: 0x2DA6330
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.OnCompleted
	|
	|-RVA: 0x2DA68B0 Offset: 0x2DA69B1 VA: 0x2DA68B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.OnCompleted
	|
	|-RVA: 0x2DA6E30 Offset: 0x2DA6F31 VA: 0x2DA6E30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.OnCompleted
	|
	|-RVA: 0x2DA73E0 Offset: 0x2DA74E1 VA: 0x2DA73E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2DA7970 Offset: 0x2DA7A71 VA: 0x2DA7970
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x2DA7F30 Offset: 0x2DA8031 VA: 0x2DA7F30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2DA84D0 Offset: 0x2DA85D1 VA: 0x2DA84D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x2DA8AD0 Offset: 0x2DA8BD1 VA: 0x2DA8AD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2DA9080 Offset: 0x2DA9181 VA: 0x2DA9080
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x2DA96B0 Offset: 0x2DA97B1 VA: 0x2DA96B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2DA9C70 Offset: 0x2DA9D71 VA: 0x2DA9C70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x2DAA2C0 Offset: 0x2DAA3C1 VA: 0x2DAA2C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2DAA880 Offset: 0x2DAA981 VA: 0x2DAA880
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x2DAAE40 Offset: 0x2DAAF41 VA: 0x2DAAE40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2DAB410 Offset: 0x2DAB511 VA: 0x2DAB410
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2DAB940 Offset: 0x2DABA41 VA: 0x2DAB940
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.OnCompleted
	|
	|-RVA: 0x2DABE60 Offset: 0x2DABF61 VA: 0x2DABE60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.OnCompleted
	|
	|-RVA: 0x2DAC3D0 Offset: 0x2DAC4D1 VA: 0x2DAC3D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.OnCompleted
	|
	|-RVA: 0x2DAC900 Offset: 0x2DACA01 VA: 0x2DAC900
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.OnCompleted
	|
	|-RVA: 0x2DACE60 Offset: 0x2DACF61 VA: 0x2DACE60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.OnCompleted
	|
	|-RVA: 0x2DAD3C0 Offset: 0x2DAD4C1 VA: 0x2DAD3C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, double>>>.OnCompleted
	|
	|-RVA: 0x2DAD8E0 Offset: 0x2DAD9E1 VA: 0x2DAD8E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, int>>>.OnCompleted
	|
	|-RVA: 0x2F65160 Offset: 0x2F65261 VA: 0x2F65160
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, long>>>.OnCompleted
	|
	|-RVA: 0x2F656C0 Offset: 0x2F657C1 VA: 0x2F656C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x2F65C30 Offset: 0x2F65D31 VA: 0x2F65C30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.OnCompleted
	|
	|-RVA: 0x2F661A0 Offset: 0x2F662A1 VA: 0x2F661A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.OnCompleted
	|
	|-RVA: 0x2F666C0 Offset: 0x2F667C1 VA: 0x2F666C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, float>>>.OnCompleted
	|
	|-RVA: 0x2F66C10 Offset: 0x2F66D11 VA: 0x2F66C10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.OnCompleted
	|
	|-RVA: 0x2F67140 Offset: 0x2F67241 VA: 0x2F67140
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.OnCompleted
	|
	|-RVA: 0x2F67670 Offset: 0x2F67771 VA: 0x2F67670
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.OnCompleted
	|
	|-RVA: 0x2F67BC0 Offset: 0x2F67CC1 VA: 0x2F67BC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.OnCompleted
	|
	|-RVA: 0x2F68130 Offset: 0x2F68231 VA: 0x2F68130
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.OnCompleted
	|
	|-RVA: 0x2F68690 Offset: 0x2F68791 VA: 0x2F68690
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, object>>>.OnCompleted
	|
	|-RVA: 0x2F68BF0 Offset: 0x2F68CF1 VA: 0x2F68BF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object>>>.OnCompleted
	|
	|-RVA: 0x2F69190 Offset: 0x2F69291 VA: 0x2F69190
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2F69710 Offset: 0x2F69811 VA: 0x2F69710
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.OnCompleted
	|
	|-RVA: 0x2F69CD0 Offset: 0x2F69DD1 VA: 0x2F69CD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2F6A260 Offset: 0x2F6A361 VA: 0x2F6A260
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x2F6A850 Offset: 0x2F6A951 VA: 0x2F6A850
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2F6ADF0 Offset: 0x2F6AEF1 VA: 0x2F6ADF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x2F6B400 Offset: 0x2F6B501 VA: 0x2F6B400
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2F6B9B0 Offset: 0x2F6BAB1 VA: 0x2F6B9B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x2F6BFE0 Offset: 0x2F6C0E1 VA: 0x2F6BFE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2F6C5A0 Offset: 0x2F6C6A1 VA: 0x2F6C5A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x2F6CBC0 Offset: 0x2F6CCC1 VA: 0x2F6CBC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2F6D190 Offset: 0x2F6D291 VA: 0x2F6D190
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x2F6D6D0 Offset: 0x2F6D7D1 VA: 0x2F6D6D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, AsyncUnit>>.OnCompleted
	|
	|-RVA: 0x2F6DC00 Offset: 0x2F6DD01 VA: 0x2F6DC00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, bool>>.OnCompleted
	|
	|-RVA: 0x2F6E170 Offset: 0x2F6E271 VA: 0x2F6E170
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Bounds>>.OnCompleted
	|
	|-RVA: 0x2F6E6B0 Offset: 0x2F6E7B1 VA: 0x2F6E6B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, byte>>.OnCompleted
	|
	|-RVA: 0x2F6EC00 Offset: 0x2F6ED01 VA: 0x2F6EC00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Color>>.OnCompleted
	|
	|-RVA: 0x2F6F130 Offset: 0x2F6F231 VA: 0x2F6F130
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, double>>.OnCompleted
	|
	|-RVA: 0x2F6F650 Offset: 0x2F6F751 VA: 0x2F6F650
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, int>>.OnCompleted
	|
	|-RVA: 0x2F6FB70 Offset: 0x2F6FC71 VA: 0x2F6FB70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, long>>.OnCompleted
	|
	|-RVA: 0x2F70090 Offset: 0x2F70191 VA: 0x2F70090
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, object>>.OnCompleted
	|
	|-RVA: 0x2F705E0 Offset: 0x2F706E1 VA: 0x2F705E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Quaternion>>.OnCompleted
	|
	|-RVA: 0x2F70B40 Offset: 0x2F70C41 VA: 0x2F70B40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Rect>>.OnCompleted
	|
	|-RVA: 0x2F71070 Offset: 0x2F71171 VA: 0x2F71070
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, float>>.OnCompleted
	|
	|-RVA: 0x2F71590 Offset: 0x2F71691 VA: 0x2F71590
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, UniTask>>.OnCompleted
	|
	|-RVA: 0x2F71AC0 Offset: 0x2F71BC1 VA: 0x2F71AC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Unit>>.OnCompleted
	|
	|-RVA: 0x2F71FD0 Offset: 0x2F720D1 VA: 0x2F71FD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector2>>.OnCompleted
	|
	|-RVA: 0x2F72500 Offset: 0x2F72601 VA: 0x2F72500
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector3>>.OnCompleted
	|
	|-RVA: 0x2F72A50 Offset: 0x2F72B51 VA: 0x2F72A50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector4>>.OnCompleted
	|
	|-RVA: 0x2F72F80 Offset: 0x2F73081 VA: 0x2F72F80
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, object>>.OnCompleted
	|
	|-RVA: 0x2F734A0 Offset: 0x2F735A1 VA: 0x2F734A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object>>.OnCompleted
	|
	|-RVA: 0x2F73A20 Offset: 0x2F73B21 VA: 0x2F73A20
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x2F73F80 Offset: 0x2F74081 VA: 0x2F73F80
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object>>.OnCompleted
	|
	|-RVA: 0x2F74530 Offset: 0x2F74631 VA: 0x2F74530
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x2F74AB0 Offset: 0x2F74BB1 VA: 0x2F74AB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x2F75070 Offset: 0x2F75171 VA: 0x2F75070
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x2F75600 Offset: 0x2F75701 VA: 0x2F75600
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x2F75C00 Offset: 0x2F75D01 VA: 0x2F75C00
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x2F761A0 Offset: 0x2F762A1 VA: 0x2F761A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x2F767D0 Offset: 0x2F768D1 VA: 0x2F767D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x2F76D80 Offset: 0x2F76E81 VA: 0x2F76D80
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x2F773D0 Offset: 0x2F774D1 VA: 0x2F773D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2F77990 Offset: 0x2F77A91 VA: 0x2F77990
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x2F77EB0 Offset: 0x2F77FB1 VA: 0x2F77EB0
	|-UniTask.IsCanceledAwaiter<AsyncUnit>.OnCompleted
	|
	|-RVA: 0x2F783C0 Offset: 0x2F784C1 VA: 0x2F783C0
	|-UniTask.IsCanceledAwaiter<bool>.OnCompleted
	|
	|-RVA: 0x2F78920 Offset: 0x2F78A21 VA: 0x2F78920
	|-UniTask.IsCanceledAwaiter<Bounds>.OnCompleted
	|
	|-RVA: 0x2F78E40 Offset: 0x2F78F41 VA: 0x2F78E40
	|-UniTask.IsCanceledAwaiter<byte>.OnCompleted
	|
	|-RVA: 0x2F79370 Offset: 0x2F79471 VA: 0x2F79370
	|-UniTask.IsCanceledAwaiter<Color>.OnCompleted
	|
	|-RVA: 0x2F79880 Offset: 0x2F79981 VA: 0x2F79880
	|-UniTask.IsCanceledAwaiter<double>.OnCompleted
	|
	|-RVA: 0x2F79D90 Offset: 0x2F79E91 VA: 0x2F79D90
	|-UniTask.IsCanceledAwaiter<int>.OnCompleted
	|
	|-RVA: 0x2F7A2A0 Offset: 0x2F7A3A1 VA: 0x2F7A2A0
	|-UniTask.IsCanceledAwaiter<long>.OnCompleted
	|
	|-RVA: 0x2F7A7B0 Offset: 0x2F7A8B1 VA: 0x2F7A7B0
	|-UniTask.IsCanceledAwaiter<object>.OnCompleted
	|
	|-RVA: 0x2F7ACE0 Offset: 0x2F7ADE1 VA: 0x2F7ACE0
	|-UniTask.IsCanceledAwaiter<Quaternion>.OnCompleted
	|
	|-RVA: 0x2F7B210 Offset: 0x2F7B311 VA: 0x2F7B210
	|-UniTask.IsCanceledAwaiter<Rect>.OnCompleted
	|
	|-RVA: 0x2F7B720 Offset: 0x2F7B821 VA: 0x2F7B720
	|-UniTask.IsCanceledAwaiter<float>.OnCompleted
	|
	|-RVA: 0x2F7BC30 Offset: 0x2F7BD31 VA: 0x2F7BC30
	|-UniTask.IsCanceledAwaiter<UniTask>.OnCompleted
	|
	|-RVA: 0x2F7C140 Offset: 0x2F7C241 VA: 0x2F7C140
	|-UniTask.IsCanceledAwaiter<Unit>.OnCompleted
	|
	|-RVA: 0x2F7C660 Offset: 0x2F7C761 VA: 0x2F7C660
	|-UniTask.IsCanceledAwaiter<Vector2>.OnCompleted
	|
	|-RVA: 0x2F7CB70 Offset: 0x2F7CC71 VA: 0x2F7CB70
	|-UniTask.IsCanceledAwaiter<Vector3>.OnCompleted
	|
	|-RVA: 0x2F7D0A0 Offset: 0x2F7D1A1 VA: 0x2F7D0A0
	|-UniTask.IsCanceledAwaiter<Vector4>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8CA70 Offset: 0x2D8CB71 VA: 0x2D8CA70
	|-UniTask.IsCanceledAwaiter<UniTask<object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D8CFC0 Offset: 0x2D8D0C1 VA: 0x2D8CFC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, UniTask<object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D8D540 Offset: 0x2D8D641 VA: 0x2D8D540
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D8DAD0 Offset: 0x2D8DBD1 VA: 0x2D8DAD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D8E070 Offset: 0x2D8E171 VA: 0x2D8E070
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D8E5C0 Offset: 0x2D8E6C1 VA: 0x2D8E5C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D8EB00 Offset: 0x2D8EC01 VA: 0x2D8EB00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D8F0A0 Offset: 0x2D8F1A1 VA: 0x2D8F0A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D8F5F0 Offset: 0x2D8F6F1 VA: 0x2D8F5F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D8FB70 Offset: 0x2D8FC71 VA: 0x2D8FB70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D90110 Offset: 0x2D90211 VA: 0x2D90110
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D90680 Offset: 0x2D90781 VA: 0x2D90680
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D90C20 Offset: 0x2D90D21 VA: 0x2D90C20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D911C0 Offset: 0x2D912C1 VA: 0x2D911C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D91750 Offset: 0x2D91851 VA: 0x2D91750
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D91CE0 Offset: 0x2D91DE1 VA: 0x2D91CE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D92250 Offset: 0x2D92351 VA: 0x2D92250
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D927F0 Offset: 0x2D928F1 VA: 0x2D927F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D92D40 Offset: 0x2D92E41 VA: 0x2D92D40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D932B0 Offset: 0x2D933B1 VA: 0x2D932B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D93830 Offset: 0x2D93931 VA: 0x2D93830
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D93DC0 Offset: 0x2D93EC1 VA: 0x2D93DC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D94360 Offset: 0x2D94461 VA: 0x2D94360
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D94900 Offset: 0x2D94A01 VA: 0x2D94900
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D94EB0 Offset: 0x2D94FB1 VA: 0x2D94EB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D95470 Offset: 0x2D95571 VA: 0x2D95470
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D95A30 Offset: 0x2D95B31 VA: 0x2D95A30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D96020 Offset: 0x2D96121 VA: 0x2D96020
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D96620 Offset: 0x2D96721 VA: 0x2D96620
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D96B60 Offset: 0x2D96C61 VA: 0x2D96B60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D97090 Offset: 0x2D97191 VA: 0x2D97090
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D97620 Offset: 0x2D97721 VA: 0x2D97620
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D97B60 Offset: 0x2D97C61 VA: 0x2D97B60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D980D0 Offset: 0x2D981D1 VA: 0x2D980D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D98660 Offset: 0x2D98761 VA: 0x2D98660
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D98BC0 Offset: 0x2D98CC1 VA: 0x2D98BC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D99150 Offset: 0x2D99251 VA: 0x2D99150
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D996E0 Offset: 0x2D997E1 VA: 0x2D996E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D99C60 Offset: 0x2D99D61 VA: 0x2D99C60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9A1E0 Offset: 0x2D9A2E1 VA: 0x2D9A1E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9A740 Offset: 0x2D9A841 VA: 0x2D9A740
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9ACD0 Offset: 0x2D9ADD1 VA: 0x2D9ACD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9B210 Offset: 0x2D9B311 VA: 0x2D9B210
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9B770 Offset: 0x2D9B871 VA: 0x2D9B770
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9BCF0 Offset: 0x2D9BDF1 VA: 0x2D9BCF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9C270 Offset: 0x2D9C371 VA: 0x2D9C270
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9C800 Offset: 0x2D9C901 VA: 0x2D9C800
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9CD90 Offset: 0x2D9CE91 VA: 0x2D9CD90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9D350 Offset: 0x2D9D451 VA: 0x2D9D350
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9D8F0 Offset: 0x2D9D9F1 VA: 0x2D9D8F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9DEE0 Offset: 0x2D9DFE1 VA: 0x2D9DEE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9E490 Offset: 0x2D9E591 VA: 0x2D9E490
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9EAA0 Offset: 0x2D9EBA1 VA: 0x2D9EAA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9F060 Offset: 0x2D9F161 VA: 0x2D9F060
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9F690 Offset: 0x2D9F791 VA: 0x2D9F690
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2D9FC50 Offset: 0x2D9FD51 VA: 0x2D9FC50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA0270 Offset: 0x2DA0371 VA: 0x2DA0270
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA0860 Offset: 0x2DA0961 VA: 0x2DA0860
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA0DA0 Offset: 0x2DA0EA1 VA: 0x2DA0DA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA12D0 Offset: 0x2DA13D1 VA: 0x2DA12D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA1850 Offset: 0x2DA1951 VA: 0x2DA1850
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA1D90 Offset: 0x2DA1E91 VA: 0x2DA1D90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA2300 Offset: 0x2DA2401 VA: 0x2DA2300
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA2880 Offset: 0x2DA2981 VA: 0x2DA2880
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA2DC0 Offset: 0x2DA2EC1 VA: 0x2DA2DC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA3330 Offset: 0x2DA3431 VA: 0x2DA3330
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA38B0 Offset: 0x2DA39B1 VA: 0x2DA38B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA3E30 Offset: 0x2DA3F31 VA: 0x2DA3E30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA43B0 Offset: 0x2DA44B1 VA: 0x2DA43B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA48F0 Offset: 0x2DA49F1 VA: 0x2DA48F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA4E60 Offset: 0x2DA4F61 VA: 0x2DA4E60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA53A0 Offset: 0x2DA54A1 VA: 0x2DA53A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA58F0 Offset: 0x2DA59F1 VA: 0x2DA58F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA5E60 Offset: 0x2DA5F61 VA: 0x2DA5E60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA63E0 Offset: 0x2DA64E1 VA: 0x2DA63E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA6960 Offset: 0x2DA6A61 VA: 0x2DA6960
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA6EE0 Offset: 0x2DA6FE1 VA: 0x2DA6EE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA7490 Offset: 0x2DA7591 VA: 0x2DA7490
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA7A20 Offset: 0x2DA7B21 VA: 0x2DA7A20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA7FE0 Offset: 0x2DA80E1 VA: 0x2DA7FE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA8580 Offset: 0x2DA8681 VA: 0x2DA8580
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA8B80 Offset: 0x2DA8C81 VA: 0x2DA8B80
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA9130 Offset: 0x2DA9231 VA: 0x2DA9130
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA9760 Offset: 0x2DA9861 VA: 0x2DA9760
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DA9D20 Offset: 0x2DA9E21 VA: 0x2DA9D20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DAA370 Offset: 0x2DAA471 VA: 0x2DAA370
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DAA930 Offset: 0x2DAAA31 VA: 0x2DAA930
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DAAEF0 Offset: 0x2DAAFF1 VA: 0x2DAAEF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DAB4C0 Offset: 0x2DAB5C1 VA: 0x2DAB4C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DAB9F0 Offset: 0x2DABAF1 VA: 0x2DAB9F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DABF10 Offset: 0x2DAC011 VA: 0x2DABF10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DAC480 Offset: 0x2DAC581 VA: 0x2DAC480
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DAC9B0 Offset: 0x2DACAB1 VA: 0x2DAC9B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DACF10 Offset: 0x2DAD011 VA: 0x2DACF10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DAD470 Offset: 0x2DAD571 VA: 0x2DAD470
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, double>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2DAD990 Offset: 0x2DADA91 VA: 0x2DAD990
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, int>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F65210 Offset: 0x2F65311 VA: 0x2F65210
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, long>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F65770 Offset: 0x2F65871 VA: 0x2F65770
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F65CE0 Offset: 0x2F65DE1 VA: 0x2F65CE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F66250 Offset: 0x2F66351 VA: 0x2F66250
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F66770 Offset: 0x2F66871 VA: 0x2F66770
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, float>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F66CC0 Offset: 0x2F66DC1 VA: 0x2F66CC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F671F0 Offset: 0x2F672F1 VA: 0x2F671F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F67720 Offset: 0x2F67821 VA: 0x2F67720
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F67C70 Offset: 0x2F67D71 VA: 0x2F67C70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F681E0 Offset: 0x2F682E1 VA: 0x2F681E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F68740 Offset: 0x2F68841 VA: 0x2F68740
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F68CA0 Offset: 0x2F68DA1 VA: 0x2F68CA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F69240 Offset: 0x2F69341 VA: 0x2F69240
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F697C0 Offset: 0x2F698C1 VA: 0x2F697C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F69D80 Offset: 0x2F69E81 VA: 0x2F69D80
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6A310 Offset: 0x2F6A411 VA: 0x2F6A310
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6A900 Offset: 0x2F6AA01 VA: 0x2F6A900
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6AEA0 Offset: 0x2F6AFA1 VA: 0x2F6AEA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6B4B0 Offset: 0x2F6B5B1 VA: 0x2F6B4B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6BA60 Offset: 0x2F6BB61 VA: 0x2F6BA60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6C090 Offset: 0x2F6C191 VA: 0x2F6C090
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6C650 Offset: 0x2F6C751 VA: 0x2F6C650
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6CC70 Offset: 0x2F6CD71 VA: 0x2F6CC70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6D240 Offset: 0x2F6D341 VA: 0x2F6D240
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6D780 Offset: 0x2F6D881 VA: 0x2F6D780
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, AsyncUnit>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6DCB0 Offset: 0x2F6DDB1 VA: 0x2F6DCB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, bool>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6E220 Offset: 0x2F6E321 VA: 0x2F6E220
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Bounds>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6E760 Offset: 0x2F6E861 VA: 0x2F6E760
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, byte>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6ECB0 Offset: 0x2F6EDB1 VA: 0x2F6ECB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Color>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6F1E0 Offset: 0x2F6F2E1 VA: 0x2F6F1E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, double>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6F700 Offset: 0x2F6F801 VA: 0x2F6F700
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, int>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F6FC20 Offset: 0x2F6FD21 VA: 0x2F6FC20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, long>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F70140 Offset: 0x2F70241 VA: 0x2F70140
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F70690 Offset: 0x2F70791 VA: 0x2F70690
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Quaternion>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F70BF0 Offset: 0x2F70CF1 VA: 0x2F70BF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Rect>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F71120 Offset: 0x2F71221 VA: 0x2F71120
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, float>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F71640 Offset: 0x2F71741 VA: 0x2F71640
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, UniTask>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F71B70 Offset: 0x2F71C71 VA: 0x2F71B70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Unit>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F72080 Offset: 0x2F72181 VA: 0x2F72080
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector2>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F725B0 Offset: 0x2F726B1 VA: 0x2F725B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector3>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F72B00 Offset: 0x2F72C01 VA: 0x2F72B00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector4>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F73030 Offset: 0x2F73131 VA: 0x2F73030
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F73550 Offset: 0x2F73651 VA: 0x2F73550
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F73AD0 Offset: 0x2F73BD1 VA: 0x2F73AD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F74030 Offset: 0x2F74131 VA: 0x2F74030
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F745E0 Offset: 0x2F746E1 VA: 0x2F745E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F74B60 Offset: 0x2F74C61 VA: 0x2F74B60
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F75120 Offset: 0x2F75221 VA: 0x2F75120
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F756B0 Offset: 0x2F757B1 VA: 0x2F756B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F75CB0 Offset: 0x2F75DB1 VA: 0x2F75CB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F76250 Offset: 0x2F76351 VA: 0x2F76250
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F76880 Offset: 0x2F76981 VA: 0x2F76880
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F76E30 Offset: 0x2F76F31 VA: 0x2F76E30
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F77480 Offset: 0x2F77581 VA: 0x2F77480
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F77A40 Offset: 0x2F77B41 VA: 0x2F77A40
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F77F60 Offset: 0x2F78061 VA: 0x2F77F60
	|-UniTask.IsCanceledAwaiter<AsyncUnit>.UnsafeOnCompleted
	|
	|-RVA: 0x2F78470 Offset: 0x2F78571 VA: 0x2F78470
	|-UniTask.IsCanceledAwaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x2F789D0 Offset: 0x2F78AD1 VA: 0x2F789D0
	|-UniTask.IsCanceledAwaiter<Bounds>.UnsafeOnCompleted
	|
	|-RVA: 0x2F78EF0 Offset: 0x2F78FF1 VA: 0x2F78EF0
	|-UniTask.IsCanceledAwaiter<byte>.UnsafeOnCompleted
	|
	|-RVA: 0x2F79420 Offset: 0x2F79521 VA: 0x2F79420
	|-UniTask.IsCanceledAwaiter<Color>.UnsafeOnCompleted
	|
	|-RVA: 0x2F79930 Offset: 0x2F79A31 VA: 0x2F79930
	|-UniTask.IsCanceledAwaiter<double>.UnsafeOnCompleted
	|
	|-RVA: 0x2F79E40 Offset: 0x2F79F41 VA: 0x2F79E40
	|-UniTask.IsCanceledAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x2F7A350 Offset: 0x2F7A451 VA: 0x2F7A350
	|-UniTask.IsCanceledAwaiter<long>.UnsafeOnCompleted
	|
	|-RVA: 0x2F7A860 Offset: 0x2F7A961 VA: 0x2F7A860
	|-UniTask.IsCanceledAwaiter<object>.UnsafeOnCompleted
	|
	|-RVA: 0x2F7AD90 Offset: 0x2F7AE91 VA: 0x2F7AD90
	|-UniTask.IsCanceledAwaiter<Quaternion>.UnsafeOnCompleted
	|
	|-RVA: 0x2F7B2C0 Offset: 0x2F7B3C1 VA: 0x2F7B2C0
	|-UniTask.IsCanceledAwaiter<Rect>.UnsafeOnCompleted
	|
	|-RVA: 0x2F7B7D0 Offset: 0x2F7B8D1 VA: 0x2F7B7D0
	|-UniTask.IsCanceledAwaiter<float>.UnsafeOnCompleted
	|
	|-RVA: 0x2F7BCE0 Offset: 0x2F7BDE1 VA: 0x2F7BCE0
	|-UniTask.IsCanceledAwaiter<UniTask>.UnsafeOnCompleted
	|
	|-RVA: 0x2F7C1F0 Offset: 0x2F7C2F1 VA: 0x2F7C1F0
	|-UniTask.IsCanceledAwaiter<Unit>.UnsafeOnCompleted
	|
	|-RVA: 0x2F7C710 Offset: 0x2F7C811 VA: 0x2F7C710
	|-UniTask.IsCanceledAwaiter<Vector2>.UnsafeOnCompleted
	|
	|-RVA: 0x2F7CC20 Offset: 0x2F7CD21 VA: 0x2F7CC20
	|-UniTask.IsCanceledAwaiter<Vector3>.UnsafeOnCompleted
	|
	|-RVA: 0x2F7D150 Offset: 0x2F7D251 VA: 0x2F7D150
	|-UniTask.IsCanceledAwaiter<Vector4>.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D8CB20 Offset: 0x2D8CC21 VA: 0x2D8CB20
	|-UniTask.IsCanceledAwaiter<UniTask<object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D8D070 Offset: 0x2D8D171 VA: 0x2D8D070
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, UniTask<object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D8D5F0 Offset: 0x2D8D6F1 VA: 0x2D8D5F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D8DB80 Offset: 0x2D8DC81 VA: 0x2D8DB80
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D8E120 Offset: 0x2D8E221 VA: 0x2D8E120
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D8E670 Offset: 0x2D8E771 VA: 0x2D8E670
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D8EBB0 Offset: 0x2D8ECB1 VA: 0x2D8EBB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D8F150 Offset: 0x2D8F251 VA: 0x2D8F150
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D8F6A0 Offset: 0x2D8F7A1 VA: 0x2D8F6A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D8FC20 Offset: 0x2D8FD21 VA: 0x2D8FC20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D901C0 Offset: 0x2D902C1 VA: 0x2D901C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D90730 Offset: 0x2D90831 VA: 0x2D90730
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D90CD0 Offset: 0x2D90DD1 VA: 0x2D90CD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D91270 Offset: 0x2D91371 VA: 0x2D91270
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D91800 Offset: 0x2D91901 VA: 0x2D91800
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D91D90 Offset: 0x2D91E91 VA: 0x2D91D90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D92300 Offset: 0x2D92401 VA: 0x2D92300
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D928A0 Offset: 0x2D929A1 VA: 0x2D928A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D92DF0 Offset: 0x2D92EF1 VA: 0x2D92DF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D93360 Offset: 0x2D93461 VA: 0x2D93360
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D938E0 Offset: 0x2D939E1 VA: 0x2D938E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D93E70 Offset: 0x2D93F71 VA: 0x2D93E70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D94410 Offset: 0x2D94511 VA: 0x2D94410
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D949B0 Offset: 0x2D94AB1 VA: 0x2D949B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D94F60 Offset: 0x2D95061 VA: 0x2D94F60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D95520 Offset: 0x2D95621 VA: 0x2D95520
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D95AE0 Offset: 0x2D95BE1 VA: 0x2D95AE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D960D0 Offset: 0x2D961D1 VA: 0x2D960D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D966D0 Offset: 0x2D967D1 VA: 0x2D966D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D96C10 Offset: 0x2D96D11 VA: 0x2D96C10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D97140 Offset: 0x2D97241 VA: 0x2D97140
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D976D0 Offset: 0x2D977D1 VA: 0x2D976D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D97C10 Offset: 0x2D97D11 VA: 0x2D97C10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D98180 Offset: 0x2D98281 VA: 0x2D98180
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D98710 Offset: 0x2D98811 VA: 0x2D98710
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D98C70 Offset: 0x2D98D71 VA: 0x2D98C70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D99200 Offset: 0x2D99301 VA: 0x2D99200
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D99790 Offset: 0x2D99891 VA: 0x2D99790
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D99D10 Offset: 0x2D99E11 VA: 0x2D99D10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9A290 Offset: 0x2D9A391 VA: 0x2D9A290
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9A7F0 Offset: 0x2D9A8F1 VA: 0x2D9A7F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9AD80 Offset: 0x2D9AE81 VA: 0x2D9AD80
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9B2C0 Offset: 0x2D9B3C1 VA: 0x2D9B2C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9B820 Offset: 0x2D9B921 VA: 0x2D9B820
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9BDA0 Offset: 0x2D9BEA1 VA: 0x2D9BDA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9C320 Offset: 0x2D9C421 VA: 0x2D9C320
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9C8B0 Offset: 0x2D9C9B1 VA: 0x2D9C8B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9CE40 Offset: 0x2D9CF41 VA: 0x2D9CE40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9D400 Offset: 0x2D9D501 VA: 0x2D9D400
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9D9A0 Offset: 0x2D9DAA1 VA: 0x2D9D9A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9DF90 Offset: 0x2D9E091 VA: 0x2D9DF90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9E540 Offset: 0x2D9E641 VA: 0x2D9E540
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9EB50 Offset: 0x2D9EC51 VA: 0x2D9EB50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9F110 Offset: 0x2D9F211 VA: 0x2D9F110
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9F740 Offset: 0x2D9F841 VA: 0x2D9F740
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2D9FD00 Offset: 0x2D9FE01 VA: 0x2D9FD00
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA0320 Offset: 0x2DA0421 VA: 0x2DA0320
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA0910 Offset: 0x2DA0A11 VA: 0x2DA0910
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA0E50 Offset: 0x2DA0F51 VA: 0x2DA0E50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA1380 Offset: 0x2DA1481 VA: 0x2DA1380
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA1900 Offset: 0x2DA1A01 VA: 0x2DA1900
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA1E40 Offset: 0x2DA1F41 VA: 0x2DA1E40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA23B0 Offset: 0x2DA24B1 VA: 0x2DA23B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA2930 Offset: 0x2DA2A31 VA: 0x2DA2930
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA2E70 Offset: 0x2DA2F71 VA: 0x2DA2E70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA33E0 Offset: 0x2DA34E1 VA: 0x2DA33E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA3960 Offset: 0x2DA3A61 VA: 0x2DA3960
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA3EE0 Offset: 0x2DA3FE1 VA: 0x2DA3EE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA4460 Offset: 0x2DA4561 VA: 0x2DA4460
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA49A0 Offset: 0x2DA4AA1 VA: 0x2DA49A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA4F10 Offset: 0x2DA5011 VA: 0x2DA4F10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA5450 Offset: 0x2DA5551 VA: 0x2DA5450
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA59A0 Offset: 0x2DA5AA1 VA: 0x2DA59A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA5F10 Offset: 0x2DA6011 VA: 0x2DA5F10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA6490 Offset: 0x2DA6591 VA: 0x2DA6490
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA6A10 Offset: 0x2DA6B11 VA: 0x2DA6A10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA6F90 Offset: 0x2DA7091 VA: 0x2DA6F90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA7540 Offset: 0x2DA7641 VA: 0x2DA7540
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA7AD0 Offset: 0x2DA7BD1 VA: 0x2DA7AD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA8090 Offset: 0x2DA8191 VA: 0x2DA8090
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA8630 Offset: 0x2DA8731 VA: 0x2DA8630
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA8C30 Offset: 0x2DA8D31 VA: 0x2DA8C30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA91E0 Offset: 0x2DA92E1 VA: 0x2DA91E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA9810 Offset: 0x2DA9911 VA: 0x2DA9810
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DA9DD0 Offset: 0x2DA9ED1 VA: 0x2DA9DD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DAA420 Offset: 0x2DAA521 VA: 0x2DAA420
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DAA9E0 Offset: 0x2DAAAE1 VA: 0x2DAA9E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DAAFA0 Offset: 0x2DAB0A1 VA: 0x2DAAFA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DAB570 Offset: 0x2DAB671 VA: 0x2DAB570
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DABAA0 Offset: 0x2DABBA1 VA: 0x2DABAA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DABFC0 Offset: 0x2DAC0C1 VA: 0x2DABFC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DAC530 Offset: 0x2DAC631 VA: 0x2DAC530
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DACA60 Offset: 0x2DACB61 VA: 0x2DACA60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DACFC0 Offset: 0x2DAD0C1 VA: 0x2DACFC0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DAD520 Offset: 0x2DAD621 VA: 0x2DAD520
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, double>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2DADA40 Offset: 0x2DADB41 VA: 0x2DADA40
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, int>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F652C0 Offset: 0x2F653C1 VA: 0x2F652C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, long>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F65820 Offset: 0x2F65921 VA: 0x2F65820
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F65D90 Offset: 0x2F65E91 VA: 0x2F65D90
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F66300 Offset: 0x2F66401 VA: 0x2F66300
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F66820 Offset: 0x2F66921 VA: 0x2F66820
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, float>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F66D70 Offset: 0x2F66E71 VA: 0x2F66D70
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F672A0 Offset: 0x2F673A1 VA: 0x2F672A0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F677D0 Offset: 0x2F678D1 VA: 0x2F677D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F67D20 Offset: 0x2F67E21 VA: 0x2F67D20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F68290 Offset: 0x2F68391 VA: 0x2F68290
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F687F0 Offset: 0x2F688F1 VA: 0x2F687F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F68D50 Offset: 0x2F68E51 VA: 0x2F68D50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F692F0 Offset: 0x2F693F1 VA: 0x2F692F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F69870 Offset: 0x2F69971 VA: 0x2F69870
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F69E30 Offset: 0x2F69F31 VA: 0x2F69E30
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6A3C0 Offset: 0x2F6A4C1 VA: 0x2F6A3C0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6A9B0 Offset: 0x2F6AAB1 VA: 0x2F6A9B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6AF50 Offset: 0x2F6B051 VA: 0x2F6AF50
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6B560 Offset: 0x2F6B661 VA: 0x2F6B560
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6BB10 Offset: 0x2F6BC11 VA: 0x2F6BB10
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6C140 Offset: 0x2F6C241 VA: 0x2F6C140
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6C700 Offset: 0x2F6C801 VA: 0x2F6C700
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6CD20 Offset: 0x2F6CE21 VA: 0x2F6CD20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6D2F0 Offset: 0x2F6D3F1 VA: 0x2F6D2F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6D830 Offset: 0x2F6D931 VA: 0x2F6D830
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, AsyncUnit>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6DD60 Offset: 0x2F6DE61 VA: 0x2F6DD60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, bool>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6E2D0 Offset: 0x2F6E3D1 VA: 0x2F6E2D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Bounds>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6E810 Offset: 0x2F6E911 VA: 0x2F6E810
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, byte>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6ED60 Offset: 0x2F6EE61 VA: 0x2F6ED60
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Color>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6F290 Offset: 0x2F6F391 VA: 0x2F6F290
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, double>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6F7B0 Offset: 0x2F6F8B1 VA: 0x2F6F7B0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, int>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F6FCD0 Offset: 0x2F6FDD1 VA: 0x2F6FCD0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, long>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F701F0 Offset: 0x2F702F1 VA: 0x2F701F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F70740 Offset: 0x2F70841 VA: 0x2F70740
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Quaternion>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F70CA0 Offset: 0x2F70DA1 VA: 0x2F70CA0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Rect>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F711D0 Offset: 0x2F712D1 VA: 0x2F711D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, float>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F716F0 Offset: 0x2F717F1 VA: 0x2F716F0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, UniTask>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F71C20 Offset: 0x2F71D21 VA: 0x2F71C20
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Unit>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F72130 Offset: 0x2F72231 VA: 0x2F72130
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector2>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F72660 Offset: 0x2F72761 VA: 0x2F72660
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector3>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F72BB0 Offset: 0x2F72CB1 VA: 0x2F72BB0
	|-UniTask.IsCanceledAwaiter<ValueTuple<bool, Vector4>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F730E0 Offset: 0x2F731E1 VA: 0x2F730E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F73600 Offset: 0x2F73701 VA: 0x2F73600
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F73B80 Offset: 0x2F73C81 VA: 0x2F73B80
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F740E0 Offset: 0x2F741E1 VA: 0x2F740E0
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F74690 Offset: 0x2F74791 VA: 0x2F74690
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F74C10 Offset: 0x2F74D11 VA: 0x2F74C10
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F751D0 Offset: 0x2F752D1 VA: 0x2F751D0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F75760 Offset: 0x2F75861 VA: 0x2F75760
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F75D60 Offset: 0x2F75E61 VA: 0x2F75D60
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F76300 Offset: 0x2F76401 VA: 0x2F76300
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F76930 Offset: 0x2F76A31 VA: 0x2F76930
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F76EE0 Offset: 0x2F76FE1 VA: 0x2F76EE0
	|-UniTask.IsCanceledAwaiter<ValueTuple<object, object, object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F77530 Offset: 0x2F77631 VA: 0x2F77530
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F77AF0 Offset: 0x2F77BF1 VA: 0x2F77AF0
	|-UniTask.IsCanceledAwaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F78010 Offset: 0x2F78111 VA: 0x2F78010
	|-UniTask.IsCanceledAwaiter<AsyncUnit>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F78520 Offset: 0x2F78621 VA: 0x2F78520
	|-UniTask.IsCanceledAwaiter<bool>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F78A80 Offset: 0x2F78B81 VA: 0x2F78A80
	|-UniTask.IsCanceledAwaiter<Bounds>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F78FA0 Offset: 0x2F790A1 VA: 0x2F78FA0
	|-UniTask.IsCanceledAwaiter<byte>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F794D0 Offset: 0x2F795D1 VA: 0x2F794D0
	|-UniTask.IsCanceledAwaiter<Color>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F799E0 Offset: 0x2F79AE1 VA: 0x2F799E0
	|-UniTask.IsCanceledAwaiter<double>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F79EF0 Offset: 0x2F79FF1 VA: 0x2F79EF0
	|-UniTask.IsCanceledAwaiter<int>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F7A400 Offset: 0x2F7A501 VA: 0x2F7A400
	|-UniTask.IsCanceledAwaiter<long>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F7A910 Offset: 0x2F7AA11 VA: 0x2F7A910
	|-UniTask.IsCanceledAwaiter<object>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F7AE40 Offset: 0x2F7AF41 VA: 0x2F7AE40
	|-UniTask.IsCanceledAwaiter<Quaternion>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F7B370 Offset: 0x2F7B471 VA: 0x2F7B370
	|-UniTask.IsCanceledAwaiter<Rect>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F7B880 Offset: 0x2F7B981 VA: 0x2F7B880
	|-UniTask.IsCanceledAwaiter<float>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F7BD90 Offset: 0x2F7BE91 VA: 0x2F7BD90
	|-UniTask.IsCanceledAwaiter<UniTask>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F7C2A0 Offset: 0x2F7C3A1 VA: 0x2F7C2A0
	|-UniTask.IsCanceledAwaiter<Unit>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F7C7C0 Offset: 0x2F7C8C1 VA: 0x2F7C7C0
	|-UniTask.IsCanceledAwaiter<Vector2>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F7CCD0 Offset: 0x2F7CDD1 VA: 0x2F7CCD0
	|-UniTask.IsCanceledAwaiter<Vector3>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F7D200 Offset: 0x2F7D301 VA: 0x2F7D200
	|-UniTask.IsCanceledAwaiter<Vector4>.UniRx.Async.IAwaiter.GetResult
	*/
}

// Namespace: 
public struct UniTask.Awaiter<T> : IAwaiter<T>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5097
{
	// Fields
	private readonly UniTask<T> task; // 0x0

	// Properties
	[DebuggerHiddenAttribute] // RVA: 0x2F2F0 Offset: 0x2F3F1 VA: 0x2F2F0
	public bool IsCompleted { get; }
	[DebuggerHiddenAttribute] // RVA: 0x2F300 Offset: 0x2F401 VA: 0x2F300
	public AwaiterStatus Status { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CF20 Offset: 0x2D021 VA: 0x2CF20
	// RVA: -1 Offset: -1
	public void .ctor(UniTask<T> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5F160 Offset: 0x2F5F261 VA: 0x2F5F160
	|-UniTask.Awaiter<UniTask<object>>..ctor
	|
	|-RVA: 0x2F5F4C0 Offset: 0x2F5F5C1 VA: 0x2F5F4C0
	|-UniTask.Awaiter<ValueTuple<bool, UniTask<object>>>..ctor
	|
	|-RVA: 0x2F5F830 Offset: 0x2F5F931 VA: 0x2F5F830
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>..ctor
	|
	|-RVA: 0x2F5FBC0 Offset: 0x2F5FCC1 VA: 0x2F5FBC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..ctor
	|
	|-RVA: 0x2F5FF50 Offset: 0x2F60051 VA: 0x2F5FF50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..ctor
	|
	|-RVA: 0x2F60320 Offset: 0x2F60421 VA: 0x2F60320
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..ctor
	|
	|-RVA: 0x2F60630 Offset: 0x2F60731 VA: 0x2F60630
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..ctor
	|
	|-RVA: 0x2F60940 Offset: 0x2F60A41 VA: 0x2F60940
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..ctor
	|
	|-RVA: 0x2F60D10 Offset: 0x2F60E11 VA: 0x2F60D10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..ctor
	|
	|-RVA: 0x2F61020 Offset: 0x2F61121 VA: 0x2F61020
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..ctor
	|
	|-RVA: 0x2F613B0 Offset: 0x2F614B1 VA: 0x2F613B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..ctor
	|
	|-RVA: 0x2F61780 Offset: 0x2F61881 VA: 0x2F61780
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..ctor
	|
	|-RVA: 0x2F61AF0 Offset: 0x2F61BF1 VA: 0x2F61AF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..ctor
	|
	|-RVA: 0x2F61EC0 Offset: 0x2F61FC1 VA: 0x2F61EC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2F62290 Offset: 0x2F62391 VA: 0x2F62290
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..ctor
	|
	|-RVA: 0x2F62620 Offset: 0x2F62721 VA: 0x2F62620
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..ctor
	|
	|-RVA: 0x2F629B0 Offset: 0x2F62AB1 VA: 0x2F629B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..ctor
	|
	|-RVA: 0x2F62D20 Offset: 0x2F62E21 VA: 0x2F62D20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..ctor
	|
	|-RVA: 0x2F630F0 Offset: 0x2F631F1 VA: 0x2F630F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..ctor
	|
	|-RVA: 0x2F63400 Offset: 0x2F63501 VA: 0x2F63400
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..ctor
	|
	|-RVA: 0x2F63790 Offset: 0x2F63891 VA: 0x2F63790
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..ctor
	|
	|-RVA: 0x2F63B20 Offset: 0x2F63C21 VA: 0x2F63B20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..ctor
	|
	|-RVA: 0x2F63EB0 Offset: 0x2F63FB1 VA: 0x2F63EB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..ctor
	|
	|-RVA: 0x2F64280 Offset: 0x2F64381 VA: 0x2F64280
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..ctor
	|
	|-RVA: 0x2F64650 Offset: 0x2F64751 VA: 0x2F64650
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..ctor
	|
	|-RVA: 0x2F64A20 Offset: 0x2F64B21 VA: 0x2F64A20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1DD4520 Offset: 0x1DD4621 VA: 0x1DD4520
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1DD4900 Offset: 0x1DD4A01 VA: 0x1DD4900
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1DD4D20 Offset: 0x1DD4E21 VA: 0x1DD4D20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1DD5140 Offset: 0x1DD5241 VA: 0x1DD5140
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..ctor
	|
	|-RVA: 0x1DD5450 Offset: 0x1DD5551 VA: 0x1DD5450
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..ctor
	|
	|-RVA: 0x1DD5760 Offset: 0x1DD5861 VA: 0x1DD5760
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..ctor
	|
	|-RVA: 0x1DD5AF0 Offset: 0x1DD5BF1 VA: 0x1DD5AF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..ctor
	|
	|-RVA: 0x1DD5E00 Offset: 0x1DD5F01 VA: 0x1DD5E00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..ctor
	|
	|-RVA: 0x1DD6190 Offset: 0x1DD6291 VA: 0x1DD6190
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..ctor
	|
	|-RVA: 0x1DD6520 Offset: 0x1DD6621 VA: 0x1DD6520
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..ctor
	|
	|-RVA: 0x1DD6890 Offset: 0x1DD6991 VA: 0x1DD6890
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..ctor
	|
	|-RVA: 0x1DD6C20 Offset: 0x1DD6D21 VA: 0x1DD6C20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DD6FB0 Offset: 0x1DD70B1 VA: 0x1DD6FB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..ctor
	|
	|-RVA: 0x1DD7340 Offset: 0x1DD7441 VA: 0x1DD7340
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..ctor
	|
	|-RVA: 0x1DD76D0 Offset: 0x1DD77D1 VA: 0x1DD76D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..ctor
	|
	|-RVA: 0x1DD7A40 Offset: 0x1DD7B41 VA: 0x1DD7A40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..ctor
	|
	|-RVA: 0x1DD7DD0 Offset: 0x1DD7ED1 VA: 0x1DD7DD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..ctor
	|
	|-RVA: 0x1DD80E0 Offset: 0x1DD81E1 VA: 0x1DD80E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..ctor
	|
	|-RVA: 0x1DD8450 Offset: 0x1DD8551 VA: 0x1DD8450
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..ctor
	|
	|-RVA: 0x1DD87E0 Offset: 0x1DD88E1 VA: 0x1DD87E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..ctor
	|
	|-RVA: 0x1DD8B70 Offset: 0x1DD8C71 VA: 0x1DD8B70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..ctor
	|
	|-RVA: 0x1DD8F00 Offset: 0x1DD9001 VA: 0x1DD8F00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..ctor
	|
	|-RVA: 0x1DD9290 Offset: 0x1DD9391 VA: 0x1DD9290
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1DD9670 Offset: 0x1DD9771 VA: 0x1DD9670
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..ctor
	|
	|-RVA: 0x1DD9A40 Offset: 0x1DD9B41 VA: 0x1DD9A40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1DD9E60 Offset: 0x1DD9F61 VA: 0x1DD9E60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1DDA230 Offset: 0x1DDA331 VA: 0x1DDA230
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1DDA660 Offset: 0x1DDA761 VA: 0x1DDA660
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1DDAA40 Offset: 0x1DDAB41 VA: 0x1DDAA40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1DDAEB0 Offset: 0x1DDAFB1 VA: 0x1DDAEB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1DDB290 Offset: 0x1DDB391 VA: 0x1DDB290
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1DDB650 Offset: 0x1DDB751 VA: 0x1DDB650
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1DDBA70 Offset: 0x1DDBB71 VA: 0x1DDBA70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..ctor
	|
	|-RVA: 0x1DDBD80 Offset: 0x1DDBE81 VA: 0x1DDBD80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>..ctor
	|
	|-RVA: 0x1DDC090 Offset: 0x1DDC191 VA: 0x1DDC090
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>..ctor
	|
	|-RVA: 0x1DDC420 Offset: 0x1DDC521 VA: 0x1DDC420
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>..ctor
	|
	|-RVA: 0x1DDC730 Offset: 0x1DDC831 VA: 0x1DDC730
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>..ctor
	|
	|-RVA: 0x1DDCAC0 Offset: 0x1DDCBC1 VA: 0x1DDCAC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>..ctor
	|
	|-RVA: 0x1DDCE50 Offset: 0x1DDCF51 VA: 0x1DDCE50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>..ctor
	|
	|-RVA: 0x1DDD1B0 Offset: 0x1DDD2B1 VA: 0x1DDD1B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>..ctor
	|
	|-RVA: 0x1DDD540 Offset: 0x1DDD641 VA: 0x1DDD540
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DDD8D0 Offset: 0x1DDD9D1 VA: 0x1DDD8D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..ctor
	|
	|-RVA: 0x1DDDC60 Offset: 0x1DDDD61 VA: 0x1DDDC60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>..ctor
	|
	|-RVA: 0x1DDDFF0 Offset: 0x1DDE0F1 VA: 0x1DDDFF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>..ctor
	|
	|-RVA: 0x1DDE350 Offset: 0x1DDE451 VA: 0x1DDE350
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>..ctor
	|
	|-RVA: 0x1DDE6E0 Offset: 0x1DDE7E1 VA: 0x1DDE6E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>..ctor
	|
	|-RVA: 0x1DDE9F0 Offset: 0x1DDEAF1 VA: 0x1DDE9F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>..ctor
	|
	|-RVA: 0x1DDED60 Offset: 0x1DDEE61 VA: 0x1DDED60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>..ctor
	|
	|-RVA: 0x1DDF0D0 Offset: 0x1DDF1D1 VA: 0x1DDF0D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>..ctor
	|
	|-RVA: 0x1DDF460 Offset: 0x1DDF561 VA: 0x1DDF460
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>..ctor
	|
	|-RVA: 0x1DDF7F0 Offset: 0x1DDF8F1 VA: 0x1DDF7F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>..ctor
	|
	|-RVA: 0x1DDFB80 Offset: 0x1DDFC81 VA: 0x1DDFB80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DDFF50 Offset: 0x1DE0051 VA: 0x1DDFF50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>..ctor
	|
	|-RVA: 0x1DE02E0 Offset: 0x1DE03E1 VA: 0x1DE02E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DE06C0 Offset: 0x1DE07C1 VA: 0x1DE06C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1DE0A90 Offset: 0x1DE0B91 VA: 0x1DE0A90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DE0EB0 Offset: 0x1DE0FB1 VA: 0x1DE0EB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1DE1280 Offset: 0x1DE1381 VA: 0x1DE1280
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DE16B0 Offset: 0x1DE17B1 VA: 0x1DE16B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1DE1A90 Offset: 0x1DE1B91 VA: 0x1DE1A90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DE1F10 Offset: 0x1DE2011 VA: 0x1DE1F10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1DE22F0 Offset: 0x1DE23F1 VA: 0x1DE22F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1DE2680 Offset: 0x1DE2781 VA: 0x1DE2680
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1DE2A10 Offset: 0x1DE2B11 VA: 0x1DE2A10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x1DE2D20 Offset: 0x1DE2E21 VA: 0x1DE2D20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x1DE3030 Offset: 0x1DE3131 VA: 0x1DE3030
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>..ctor
	|
	|-RVA: 0x1DE33C0 Offset: 0x1DE34C1 VA: 0x1DE33C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, byte>>>..ctor
	|
	|-RVA: 0x1DE36D0 Offset: 0x1DE37D1 VA: 0x1DE36D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Color>>>..ctor
	|
	|-RVA: 0x1DE3A40 Offset: 0x1DE3B41 VA: 0x1DE3A40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, double>>>..ctor
	|
	|-RVA: 0x1DE3DB0 Offset: 0x1DE3EB1 VA: 0x1DE3DB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x1DE4110 Offset: 0x1DE4211 VA: 0x1DE4110
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, long>>>..ctor
	|
	|-RVA: 0x1DE4480 Offset: 0x1DE4581 VA: 0x1DE4480
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1DE47F0 Offset: 0x1DE48F1 VA: 0x1DE47F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>..ctor
	|
	|-RVA: 0x1DE4B60 Offset: 0x1DE4C61 VA: 0x1DE4B60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>..ctor
	|
	|-RVA: 0x1DE4ED0 Offset: 0x1DE4FD1 VA: 0x1DE4ED0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x1DE5230 Offset: 0x1DE5331 VA: 0x1DE5230
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>..ctor
	|
	|-RVA: 0x1DE55A0 Offset: 0x1DE56A1 VA: 0x1DE55A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>..ctor
	|
	|-RVA: 0x1DE58B0 Offset: 0x1DE59B1 VA: 0x1DE58B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x1DE5C10 Offset: 0x1DE5D11 VA: 0x1DE5C10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>..ctor
	|
	|-RVA: 0x1DE5F80 Offset: 0x1DE6081 VA: 0x1DE5F80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>..ctor
	|
	|-RVA: 0x1DE62F0 Offset: 0x1DE63F1 VA: 0x1DE62F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, object>>>..ctor
	|
	|-RVA: 0x1DE6660 Offset: 0x1DE6761 VA: 0x1DE6660
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x1DE69D0 Offset: 0x1DE6AD1 VA: 0x1DE69D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DE6DA0 Offset: 0x1DE6EA1 VA: 0x1DE6DA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object>>>..ctor
	|
	|-RVA: 0x1DE7130 Offset: 0x1DE7231 VA: 0x1DE7130
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DE7510 Offset: 0x1DE7611 VA: 0x1DE7510
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>..ctor
	|
	|-RVA: 0x1DE78A0 Offset: 0x1DE79A1 VA: 0x1DE78A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DE7CC0 Offset: 0x1DE7DC1 VA: 0x1DE7CC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1DE8090 Offset: 0x1DE8191 VA: 0x1DE8090
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DE84C0 Offset: 0x1DE85C1 VA: 0x1DE84C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1DE8890 Offset: 0x1DE8991 VA: 0x1DE8890
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DE8D00 Offset: 0x1DE8E01 VA: 0x1DE8D00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1DE90E0 Offset: 0x1DE91E1 VA: 0x1DE90E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DE94A0 Offset: 0x1DE95A1 VA: 0x1DE94A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1DE9830 Offset: 0x1DE9931 VA: 0x1DE9830
	|-UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x1DE9D90 Offset: 0x1DE9E91 VA: 0x1DE9D90
	|-UniTask.Awaiter<ValueTuple<bool, bool>>..ctor
	|
	|-RVA: 0x1DEA0A0 Offset: 0x1DEA1A1 VA: 0x1DEA0A0
	|-UniTask.Awaiter<ValueTuple<bool, Bounds>>..ctor
	|
	|-RVA: 0x1DEA430 Offset: 0x1DEA531 VA: 0x1DEA430
	|-UniTask.Awaiter<ValueTuple<bool, byte>>..ctor
	|
	|-RVA: 0x1DEA740 Offset: 0x1DEA841 VA: 0x1DEA740
	|-UniTask.Awaiter<ValueTuple<bool, Color>>..ctor
	|
	|-RVA: 0x1DEAAB0 Offset: 0x1DEABB1 VA: 0x1DEAAB0
	|-UniTask.Awaiter<ValueTuple<bool, double>>..ctor
	|
	|-RVA: 0x1DEAE10 Offset: 0x1DEAF11 VA: 0x1DEAE10
	|-UniTask.Awaiter<ValueTuple<bool, int>>..ctor
	|
	|-RVA: 0x1DEB120 Offset: 0x1DEB221 VA: 0x1DEB120
	|-UniTask.Awaiter<ValueTuple<bool, long>>..ctor
	|
	|-RVA: 0x1DEB480 Offset: 0x1DEB581 VA: 0x1DEB480
	|-UniTask.Awaiter<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1DEBA50 Offset: 0x1DEBB51 VA: 0x1DEBA50
	|-UniTask.Awaiter<ValueTuple<bool, Quaternion>>..ctor
	|
	|-RVA: 0x1DEBDC0 Offset: 0x1DEBEC1 VA: 0x1DEBDC0
	|-UniTask.Awaiter<ValueTuple<bool, Rect>>..ctor
	|
	|-RVA: 0x1DEC130 Offset: 0x1DEC231 VA: 0x1DEC130
	|-UniTask.Awaiter<ValueTuple<bool, float>>..ctor
	|
	|-RVA: 0x1DEC440 Offset: 0x1DEC541 VA: 0x1DEC440
	|-UniTask.Awaiter<ValueTuple<bool, UniTask>>..ctor
	|
	|-RVA: 0x1DEC7A0 Offset: 0x1DEC8A1 VA: 0x1DEC7A0
	|-UniTask.Awaiter<ValueTuple<bool, Unit>>..ctor
	|
	|-RVA: 0x1DECAB0 Offset: 0x1DECBB1 VA: 0x1DECAB0
	|-UniTask.Awaiter<ValueTuple<bool, Vector2>>..ctor
	|
	|-RVA: 0x1DECE10 Offset: 0x1DECF11 VA: 0x1DECE10
	|-UniTask.Awaiter<ValueTuple<bool, Vector3>>..ctor
	|
	|-RVA: 0x1DED170 Offset: 0x1DED271 VA: 0x1DED170
	|-UniTask.Awaiter<ValueTuple<bool, Vector4>>..ctor
	|
	|-RVA: 0x1DED4E0 Offset: 0x1DED5E1 VA: 0x1DED4E0
	|-UniTask.Awaiter<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x1DED840 Offset: 0x1DED941 VA: 0x1DED840
	|-UniTask.Awaiter<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x1DEDBA0 Offset: 0x1DEDCA1 VA: 0x1DEDBA0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1DEDF30 Offset: 0x1DEE031 VA: 0x1DEDF30
	|-UniTask.Awaiter<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x1DEE2A0 Offset: 0x1DEE3A1 VA: 0x1DEE2A0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1DEE670 Offset: 0x1DEE771 VA: 0x1DEE670
	|-UniTask.Awaiter<ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x1DEEA00 Offset: 0x1DEEB01 VA: 0x1DEEA00
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1DEEDE0 Offset: 0x1DEEEE1 VA: 0x1DEEDE0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object>>..ctor
	|
	|-RVA: 0x1DEF170 Offset: 0x1DEF271 VA: 0x1DEF170
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1DEF590 Offset: 0x1DEF691 VA: 0x1DEF590
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x1DEF960 Offset: 0x1DEFA61 VA: 0x1DEF960
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1DEFD90 Offset: 0x1DEFE91 VA: 0x1DEFD90
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x1DF0160 Offset: 0x1DF0261 VA: 0x1DF0160
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DF05E0 Offset: 0x1DF06E1 VA: 0x1DF05E0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1DF0970 Offset: 0x1DF0A71 VA: 0x1DF0970
	|-UniTask.Awaiter<AsyncUnit>..ctor
	|
	|-RVA: 0x1DF0C80 Offset: 0x1DF0D81 VA: 0x1DF0C80
	|-UniTask.Awaiter<bool>..ctor
	|
	|-RVA: 0x1DF0F90 Offset: 0x1DF1091 VA: 0x1DF0F90
	|-UniTask.Awaiter<Bounds>..ctor
	|
	|-RVA: 0x1DF1300 Offset: 0x1DF1401 VA: 0x1DF1300
	|-UniTask.Awaiter<byte>..ctor
	|
	|-RVA: 0x1DF1610 Offset: 0x1DF1711 VA: 0x1DF1610
	|-UniTask.Awaiter<Color>..ctor
	|
	|-RVA: 0x1DF1970 Offset: 0x1DF1A71 VA: 0x1DF1970
	|-UniTask.Awaiter<double>..ctor
	|
	|-RVA: 0x1DF1C80 Offset: 0x1DF1D81 VA: 0x1DF1C80
	|-UniTask.Awaiter<int>..ctor
	|
	|-RVA: 0x1DF1F90 Offset: 0x1DF2091 VA: 0x1DF1F90
	|-UniTask.Awaiter<long>..ctor
	|
	|-RVA: 0x1DF22A0 Offset: 0x1DF23A1 VA: 0x1DF22A0
	|-UniTask.Awaiter<object>..ctor
	|
	|-RVA: 0x1DF2C00 Offset: 0x1DF2D01 VA: 0x1DF2C00
	|-UniTask.Awaiter<Quaternion>..ctor
	|
	|-RVA: 0x1DF2F60 Offset: 0x1DF3061 VA: 0x1DF2F60
	|-UniTask.Awaiter<Rect>..ctor
	|
	|-RVA: 0x1DF32C0 Offset: 0x1DF33C1 VA: 0x1DF32C0
	|-UniTask.Awaiter<float>..ctor
	|
	|-RVA: 0x1DF35D0 Offset: 0x1DF36D1 VA: 0x1DF35D0
	|-UniTask.Awaiter<UniTask>..ctor
	|
	|-RVA: 0x1DF38E0 Offset: 0x1DF39E1 VA: 0x1DF38E0
	|-UniTask.Awaiter<Unit>..ctor
	|
	|-RVA: 0x1DF3BF0 Offset: 0x1DF3CF1 VA: 0x1DF3BF0
	|-UniTask.Awaiter<Vector2>..ctor
	|
	|-RVA: 0x1DF3F00 Offset: 0x1DF4001 VA: 0x1DF3F00
	|-UniTask.Awaiter<Vector3>..ctor
	|
	|-RVA: 0x1DF4260 Offset: 0x1DF4361 VA: 0x1DF4260
	|-UniTask.Awaiter<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5F180 Offset: 0x2F5F281 VA: 0x2F5F180
	|-UniTask.Awaiter<UniTask<object>>.get_IsCompleted
	|
	|-RVA: 0x2F5F4E0 Offset: 0x2F5F5E1 VA: 0x2F5F4E0
	|-UniTask.Awaiter<ValueTuple<bool, UniTask<object>>>.get_IsCompleted
	|
	|-RVA: 0x2F5F860 Offset: 0x2F5F961 VA: 0x2F5F860
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.get_IsCompleted
	|
	|-RVA: 0x2F5FBF0 Offset: 0x2F5FCF1 VA: 0x2F5FBF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F5FF80 Offset: 0x2F60081 VA: 0x2F5FF80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F60330 Offset: 0x2F60431 VA: 0x2F60330
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F60640 Offset: 0x2F60741 VA: 0x2F60640
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F60970 Offset: 0x2F60A71 VA: 0x2F60970
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F60D20 Offset: 0x2F60E21 VA: 0x2F60D20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F61050 Offset: 0x2F61151 VA: 0x2F61050
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F613E0 Offset: 0x2F614E1 VA: 0x2F613E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F617A0 Offset: 0x2F618A1 VA: 0x2F617A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F61B20 Offset: 0x2F61C21 VA: 0x2F61B20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F61EF0 Offset: 0x2F61FF1 VA: 0x2F61EF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F622C0 Offset: 0x2F623C1 VA: 0x2F622C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F62650 Offset: 0x2F62751 VA: 0x2F62650
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F629D0 Offset: 0x2F62AD1 VA: 0x2F629D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F62D50 Offset: 0x2F62E51 VA: 0x2F62D50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F63100 Offset: 0x2F63201 VA: 0x2F63100
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F63430 Offset: 0x2F63531 VA: 0x2F63430
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F637C0 Offset: 0x2F638C1 VA: 0x2F637C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F63B50 Offset: 0x2F63C51 VA: 0x2F63B50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F63EE0 Offset: 0x2F63FE1 VA: 0x2F63EE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F642B0 Offset: 0x2F643B1 VA: 0x2F642B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F64680 Offset: 0x2F64781 VA: 0x2F64680
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2F64A50 Offset: 0x2F64B51 VA: 0x2F64A50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD4550 Offset: 0x1DD4651 VA: 0x1DD4550
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD4930 Offset: 0x1DD4A31 VA: 0x1DD4930
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD4D50 Offset: 0x1DD4E51 VA: 0x1DD4D50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD5150 Offset: 0x1DD5251 VA: 0x1DD5150
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD5460 Offset: 0x1DD5561 VA: 0x1DD5460
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD5790 Offset: 0x1DD5891 VA: 0x1DD5790
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD5B00 Offset: 0x1DD5C01 VA: 0x1DD5B00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD5E30 Offset: 0x1DD5F31 VA: 0x1DD5E30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD61C0 Offset: 0x1DD62C1 VA: 0x1DD61C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD6540 Offset: 0x1DD6641 VA: 0x1DD6540
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD68C0 Offset: 0x1DD69C1 VA: 0x1DD68C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD6C50 Offset: 0x1DD6D51 VA: 0x1DD6C50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD6FE0 Offset: 0x1DD70E1 VA: 0x1DD6FE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD7370 Offset: 0x1DD7471 VA: 0x1DD7370
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD76F0 Offset: 0x1DD77F1 VA: 0x1DD76F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD7A70 Offset: 0x1DD7B71 VA: 0x1DD7A70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD7DE0 Offset: 0x1DD7EE1 VA: 0x1DD7DE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD8100 Offset: 0x1DD8201 VA: 0x1DD8100
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD8480 Offset: 0x1DD8581 VA: 0x1DD8480
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD8810 Offset: 0x1DD8911 VA: 0x1DD8810
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD8BA0 Offset: 0x1DD8CA1 VA: 0x1DD8BA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD8F30 Offset: 0x1DD9031 VA: 0x1DD8F30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD92C0 Offset: 0x1DD93C1 VA: 0x1DD92C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD96A0 Offset: 0x1DD97A1 VA: 0x1DD96A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD9A70 Offset: 0x1DD9B71 VA: 0x1DD9A70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DD9E90 Offset: 0x1DD9F91 VA: 0x1DD9E90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDA260 Offset: 0x1DDA361 VA: 0x1DDA260
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDA690 Offset: 0x1DDA791 VA: 0x1DDA690
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDAA70 Offset: 0x1DDAB71 VA: 0x1DDAA70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDAEE0 Offset: 0x1DDAFE1 VA: 0x1DDAEE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDB2C0 Offset: 0x1DDB3C1 VA: 0x1DDB2C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDB680 Offset: 0x1DDB781 VA: 0x1DDB680
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDBA80 Offset: 0x1DDBB81 VA: 0x1DDBA80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDBD90 Offset: 0x1DDBE91 VA: 0x1DDBD90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDC0C0 Offset: 0x1DDC1C1 VA: 0x1DDC0C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDC430 Offset: 0x1DDC531 VA: 0x1DDC430
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDC760 Offset: 0x1DDC861 VA: 0x1DDC760
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDCAF0 Offset: 0x1DDCBF1 VA: 0x1DDCAF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDCE70 Offset: 0x1DDCF71 VA: 0x1DDCE70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDD1E0 Offset: 0x1DDD2E1 VA: 0x1DDD1E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDD570 Offset: 0x1DDD671 VA: 0x1DDD570
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDD900 Offset: 0x1DDDA01 VA: 0x1DDD900
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDDC90 Offset: 0x1DDDD91 VA: 0x1DDDC90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDE010 Offset: 0x1DDE111 VA: 0x1DDE010
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDE380 Offset: 0x1DDE481 VA: 0x1DDE380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDE6F0 Offset: 0x1DDE7F1 VA: 0x1DDE6F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDEA10 Offset: 0x1DDEB11 VA: 0x1DDEA10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDED80 Offset: 0x1DDEE81 VA: 0x1DDED80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDF100 Offset: 0x1DDF201 VA: 0x1DDF100
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDF490 Offset: 0x1DDF591 VA: 0x1DDF490
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDF820 Offset: 0x1DDF921 VA: 0x1DDF820
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDFBB0 Offset: 0x1DDFCB1 VA: 0x1DDFBB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DDFF80 Offset: 0x1DE0081 VA: 0x1DDFF80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE0310 Offset: 0x1DE0411 VA: 0x1DE0310
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE06F0 Offset: 0x1DE07F1 VA: 0x1DE06F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE0AC0 Offset: 0x1DE0BC1 VA: 0x1DE0AC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE0EE0 Offset: 0x1DE0FE1 VA: 0x1DE0EE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE12B0 Offset: 0x1DE13B1 VA: 0x1DE12B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE16E0 Offset: 0x1DE17E1 VA: 0x1DE16E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE1AC0 Offset: 0x1DE1BC1 VA: 0x1DE1AC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE1F40 Offset: 0x1DE2041 VA: 0x1DE1F40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE2320 Offset: 0x1DE2421 VA: 0x1DE2320
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE26B0 Offset: 0x1DE27B1 VA: 0x1DE26B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE2A20 Offset: 0x1DE2B21 VA: 0x1DE2A20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_IsCompleted
	|
	|-RVA: 0x1DE2D30 Offset: 0x1DE2E31 VA: 0x1DE2D30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.get_IsCompleted
	|
	|-RVA: 0x1DE3060 Offset: 0x1DE3161 VA: 0x1DE3060
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.get_IsCompleted
	|
	|-RVA: 0x1DE33D0 Offset: 0x1DE34D1 VA: 0x1DE33D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.get_IsCompleted
	|
	|-RVA: 0x1DE36F0 Offset: 0x1DE37F1 VA: 0x1DE36F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.get_IsCompleted
	|
	|-RVA: 0x1DE3A60 Offset: 0x1DE3B61 VA: 0x1DE3A60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, double>>>.get_IsCompleted
	|
	|-RVA: 0x1DE3DD0 Offset: 0x1DE3ED1 VA: 0x1DE3DD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, int>>>.get_IsCompleted
	|
	|-RVA: 0x1DE4130 Offset: 0x1DE4231 VA: 0x1DE4130
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, long>>>.get_IsCompleted
	|
	|-RVA: 0x1DE44A0 Offset: 0x1DE45A1 VA: 0x1DE44A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE4810 Offset: 0x1DE4911 VA: 0x1DE4810
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.get_IsCompleted
	|
	|-RVA: 0x1DE4B80 Offset: 0x1DE4C81 VA: 0x1DE4B80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.get_IsCompleted
	|
	|-RVA: 0x1DE4EF0 Offset: 0x1DE4FF1 VA: 0x1DE4EF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, float>>>.get_IsCompleted
	|
	|-RVA: 0x1DE5250 Offset: 0x1DE5351 VA: 0x1DE5250
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.get_IsCompleted
	|
	|-RVA: 0x1DE55B0 Offset: 0x1DE56B1 VA: 0x1DE55B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.get_IsCompleted
	|
	|-RVA: 0x1DE58D0 Offset: 0x1DE59D1 VA: 0x1DE58D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.get_IsCompleted
	|
	|-RVA: 0x1DE5C30 Offset: 0x1DE5D31 VA: 0x1DE5C30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.get_IsCompleted
	|
	|-RVA: 0x1DE5FA0 Offset: 0x1DE60A1 VA: 0x1DE5FA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.get_IsCompleted
	|
	|-RVA: 0x1DE6310 Offset: 0x1DE6411 VA: 0x1DE6310
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE6680 Offset: 0x1DE6781 VA: 0x1DE6680
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE6A00 Offset: 0x1DE6B01 VA: 0x1DE6A00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE6DD0 Offset: 0x1DE6ED1 VA: 0x1DE6DD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE7160 Offset: 0x1DE7261 VA: 0x1DE7160
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE7540 Offset: 0x1DE7641 VA: 0x1DE7540
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE78D0 Offset: 0x1DE79D1 VA: 0x1DE78D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE7CF0 Offset: 0x1DE7DF1 VA: 0x1DE7CF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE80C0 Offset: 0x1DE81C1 VA: 0x1DE80C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE84F0 Offset: 0x1DE85F1 VA: 0x1DE84F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE88C0 Offset: 0x1DE89C1 VA: 0x1DE88C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE8D30 Offset: 0x1DE8E31 VA: 0x1DE8D30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DE9110 Offset: 0x1DE9211 VA: 0x1DE9110
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE94D0 Offset: 0x1DE95D1 VA: 0x1DE94D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x1DE9840 Offset: 0x1DE9941 VA: 0x1DE9840
	|-UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>.get_IsCompleted
	|
	|-RVA: 0x1DE9DA0 Offset: 0x1DE9EA1 VA: 0x1DE9DA0
	|-UniTask.Awaiter<ValueTuple<bool, bool>>.get_IsCompleted
	|
	|-RVA: 0x1DEA0D0 Offset: 0x1DEA1D1 VA: 0x1DEA0D0
	|-UniTask.Awaiter<ValueTuple<bool, Bounds>>.get_IsCompleted
	|
	|-RVA: 0x1DEA440 Offset: 0x1DEA541 VA: 0x1DEA440
	|-UniTask.Awaiter<ValueTuple<bool, byte>>.get_IsCompleted
	|
	|-RVA: 0x1DEA760 Offset: 0x1DEA861 VA: 0x1DEA760
	|-UniTask.Awaiter<ValueTuple<bool, Color>>.get_IsCompleted
	|
	|-RVA: 0x1DEAAD0 Offset: 0x1DEABD1 VA: 0x1DEAAD0
	|-UniTask.Awaiter<ValueTuple<bool, double>>.get_IsCompleted
	|
	|-RVA: 0x1DEAE20 Offset: 0x1DEAF21 VA: 0x1DEAE20
	|-UniTask.Awaiter<ValueTuple<bool, int>>.get_IsCompleted
	|
	|-RVA: 0x1DEB140 Offset: 0x1DEB241 VA: 0x1DEB140
	|-UniTask.Awaiter<ValueTuple<bool, long>>.get_IsCompleted
	|
	|-RVA: 0x1DEB4A0 Offset: 0x1DEB5A1 VA: 0x1DEB4A0
	|-UniTask.Awaiter<ValueTuple<bool, object>>.get_IsCompleted
	|
	|-RVA: 0x1DEBA70 Offset: 0x1DEBB71 VA: 0x1DEBA70
	|-UniTask.Awaiter<ValueTuple<bool, Quaternion>>.get_IsCompleted
	|
	|-RVA: 0x1DEBDE0 Offset: 0x1DEBEE1 VA: 0x1DEBDE0
	|-UniTask.Awaiter<ValueTuple<bool, Rect>>.get_IsCompleted
	|
	|-RVA: 0x1DEC140 Offset: 0x1DEC241 VA: 0x1DEC140
	|-UniTask.Awaiter<ValueTuple<bool, float>>.get_IsCompleted
	|
	|-RVA: 0x1DEC460 Offset: 0x1DEC561 VA: 0x1DEC460
	|-UniTask.Awaiter<ValueTuple<bool, UniTask>>.get_IsCompleted
	|
	|-RVA: 0x1DEC7B0 Offset: 0x1DEC8B1 VA: 0x1DEC7B0
	|-UniTask.Awaiter<ValueTuple<bool, Unit>>.get_IsCompleted
	|
	|-RVA: 0x1DECAD0 Offset: 0x1DECBD1 VA: 0x1DECAD0
	|-UniTask.Awaiter<ValueTuple<bool, Vector2>>.get_IsCompleted
	|
	|-RVA: 0x1DECE30 Offset: 0x1DECF31 VA: 0x1DECE30
	|-UniTask.Awaiter<ValueTuple<bool, Vector3>>.get_IsCompleted
	|
	|-RVA: 0x1DED190 Offset: 0x1DED291 VA: 0x1DED190
	|-UniTask.Awaiter<ValueTuple<bool, Vector4>>.get_IsCompleted
	|
	|-RVA: 0x1DED500 Offset: 0x1DED601 VA: 0x1DED500
	|-UniTask.Awaiter<ValueTuple<int, object>>.get_IsCompleted
	|
	|-RVA: 0x1DED860 Offset: 0x1DED961 VA: 0x1DED860
	|-UniTask.Awaiter<ValueTuple<object, object>>.get_IsCompleted
	|
	|-RVA: 0x1DEDBD0 Offset: 0x1DEDCD1 VA: 0x1DEDBD0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DEDF50 Offset: 0x1DEE051 VA: 0x1DEDF50
	|-UniTask.Awaiter<ValueTuple<object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x1DEE2D0 Offset: 0x1DEE3D1 VA: 0x1DEE2D0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DEE6A0 Offset: 0x1DEE7A1 VA: 0x1DEE6A0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x1DEEA30 Offset: 0x1DEEB31 VA: 0x1DEEA30
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DEEE10 Offset: 0x1DEEF11 VA: 0x1DEEE10
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x1DEF1A0 Offset: 0x1DEF2A1 VA: 0x1DEF1A0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DEF5C0 Offset: 0x1DEF6C1 VA: 0x1DEF5C0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x1DEF990 Offset: 0x1DEFA91 VA: 0x1DEF990
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x1DEFDC0 Offset: 0x1DEFEC1 VA: 0x1DEFDC0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x1DF0190 Offset: 0x1DF0291 VA: 0x1DF0190
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DF0610 Offset: 0x1DF0711 VA: 0x1DF0610
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x1DF0980 Offset: 0x1DF0A81 VA: 0x1DF0980
	|-UniTask.Awaiter<AsyncUnit>.get_IsCompleted
	|
	|-RVA: 0x1DF0C90 Offset: 0x1DF0D91 VA: 0x1DF0C90
	|-UniTask.Awaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x1DF0FB0 Offset: 0x1DF10B1 VA: 0x1DF0FB0
	|-UniTask.Awaiter<Bounds>.get_IsCompleted
	|
	|-RVA: 0x1DF1310 Offset: 0x1DF1411 VA: 0x1DF1310
	|-UniTask.Awaiter<byte>.get_IsCompleted
	|
	|-RVA: 0x1DF1630 Offset: 0x1DF1731 VA: 0x1DF1630
	|-UniTask.Awaiter<Color>.get_IsCompleted
	|
	|-RVA: 0x1DF1980 Offset: 0x1DF1A81 VA: 0x1DF1980
	|-UniTask.Awaiter<double>.get_IsCompleted
	|
	|-RVA: 0x1DF1C90 Offset: 0x1DF1D91 VA: 0x1DF1C90
	|-UniTask.Awaiter<int>.get_IsCompleted
	|
	|-RVA: 0x1DF1FA0 Offset: 0x1DF20A1 VA: 0x1DF1FA0
	|-UniTask.Awaiter<long>.get_IsCompleted
	|
	|-RVA: 0x1DF22B0 Offset: 0x1DF23B1 VA: 0x1DF22B0
	|-UniTask.Awaiter<object>.get_IsCompleted
	|
	|-RVA: 0x1DF2C20 Offset: 0x1DF2D21 VA: 0x1DF2C20
	|-UniTask.Awaiter<Quaternion>.get_IsCompleted
	|
	|-RVA: 0x1DF2F80 Offset: 0x1DF3081 VA: 0x1DF2F80
	|-UniTask.Awaiter<Rect>.get_IsCompleted
	|
	|-RVA: 0x1DF32D0 Offset: 0x1DF33D1 VA: 0x1DF32D0
	|-UniTask.Awaiter<float>.get_IsCompleted
	|
	|-RVA: 0x1DF35E0 Offset: 0x1DF36E1 VA: 0x1DF35E0
	|-UniTask.Awaiter<UniTask>.get_IsCompleted
	|
	|-RVA: 0x1DF38F0 Offset: 0x1DF39F1 VA: 0x1DF38F0
	|-UniTask.Awaiter<Unit>.get_IsCompleted
	|
	|-RVA: 0x1DF3C00 Offset: 0x1DF3D01 VA: 0x1DF3C00
	|-UniTask.Awaiter<Vector2>.get_IsCompleted
	|
	|-RVA: 0x1DF3F20 Offset: 0x1DF4021 VA: 0x1DF3F20
	|-UniTask.Awaiter<Vector3>.get_IsCompleted
	|
	|-RVA: 0x1DF4280 Offset: 0x1DF4381 VA: 0x1DF4280
	|-UniTask.Awaiter<Vector4>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public AwaiterStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5F1E0 Offset: 0x2F5F2E1 VA: 0x2F5F1E0
	|-UniTask.Awaiter<UniTask<object>>.get_Status
	|
	|-RVA: 0x2F5F540 Offset: 0x2F5F641 VA: 0x2F5F540
	|-UniTask.Awaiter<ValueTuple<bool, UniTask<object>>>.get_Status
	|
	|-RVA: 0x2F5F8C0 Offset: 0x2F5F9C1 VA: 0x2F5F8C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.get_Status
	|
	|-RVA: 0x2F5FC50 Offset: 0x2F5FD51 VA: 0x2F5FC50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.get_Status
	|
	|-RVA: 0x2F5FFF0 Offset: 0x2F600F1 VA: 0x2F5FFF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.get_Status
	|
	|-RVA: 0x2F60380 Offset: 0x2F60481 VA: 0x2F60380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.get_Status
	|
	|-RVA: 0x2F60690 Offset: 0x2F60791 VA: 0x2F60690
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.get_Status
	|
	|-RVA: 0x2F609E0 Offset: 0x2F60AE1 VA: 0x2F609E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.get_Status
	|
	|-RVA: 0x2F60D70 Offset: 0x2F60E71 VA: 0x2F60D70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.get_Status
	|
	|-RVA: 0x2F610B0 Offset: 0x2F611B1 VA: 0x2F610B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.get_Status
	|
	|-RVA: 0x2F61450 Offset: 0x2F61551 VA: 0x2F61450
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.get_Status
	|
	|-RVA: 0x2F61800 Offset: 0x2F61901 VA: 0x2F61800
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.get_Status
	|
	|-RVA: 0x2F61B90 Offset: 0x2F61C91 VA: 0x2F61B90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.get_Status
	|
	|-RVA: 0x2F61F60 Offset: 0x2F62061 VA: 0x2F61F60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2F62320 Offset: 0x2F62421 VA: 0x2F62320
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.get_Status
	|
	|-RVA: 0x2F626B0 Offset: 0x2F627B1 VA: 0x2F626B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.get_Status
	|
	|-RVA: 0x2F62A30 Offset: 0x2F62B31 VA: 0x2F62A30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.get_Status
	|
	|-RVA: 0x2F62DC0 Offset: 0x2F62EC1 VA: 0x2F62DC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.get_Status
	|
	|-RVA: 0x2F63150 Offset: 0x2F63251 VA: 0x2F63150
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.get_Status
	|
	|-RVA: 0x2F63490 Offset: 0x2F63591 VA: 0x2F63490
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.get_Status
	|
	|-RVA: 0x2F63820 Offset: 0x2F63921 VA: 0x2F63820
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.get_Status
	|
	|-RVA: 0x2F63BB0 Offset: 0x2F63CB1 VA: 0x2F63BB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.get_Status
	|
	|-RVA: 0x2F63F50 Offset: 0x2F64051 VA: 0x2F63F50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.get_Status
	|
	|-RVA: 0x2F64320 Offset: 0x2F64421 VA: 0x2F64320
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.get_Status
	|
	|-RVA: 0x2F646F0 Offset: 0x2F647F1 VA: 0x2F646F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x2F64AC0 Offset: 0x2F64BC1 VA: 0x2F64AC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x1DD45C0 Offset: 0x1DD46C1 VA: 0x1DD45C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x1DD49B0 Offset: 0x1DD4AB1 VA: 0x1DD49B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x1DD4DD0 Offset: 0x1DD4ED1 VA: 0x1DD4DD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x1DD51A0 Offset: 0x1DD52A1 VA: 0x1DD51A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.get_Status
	|
	|-RVA: 0x1DD54B0 Offset: 0x1DD55B1 VA: 0x1DD54B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.get_Status
	|
	|-RVA: 0x1DD57F0 Offset: 0x1DD58F1 VA: 0x1DD57F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.get_Status
	|
	|-RVA: 0x1DD5B50 Offset: 0x1DD5C51 VA: 0x1DD5B50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.get_Status
	|
	|-RVA: 0x1DD5E90 Offset: 0x1DD5F91 VA: 0x1DD5E90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.get_Status
	|
	|-RVA: 0x1DD6220 Offset: 0x1DD6321 VA: 0x1DD6220
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.get_Status
	|
	|-RVA: 0x1DD65A0 Offset: 0x1DD66A1 VA: 0x1DD65A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.get_Status
	|
	|-RVA: 0x1DD6920 Offset: 0x1DD6A21 VA: 0x1DD6920
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.get_Status
	|
	|-RVA: 0x1DD6CB0 Offset: 0x1DD6DB1 VA: 0x1DD6CB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DD7040 Offset: 0x1DD7141 VA: 0x1DD7040
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.get_Status
	|
	|-RVA: 0x1DD73D0 Offset: 0x1DD74D1 VA: 0x1DD73D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.get_Status
	|
	|-RVA: 0x1DD7750 Offset: 0x1DD7851 VA: 0x1DD7750
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.get_Status
	|
	|-RVA: 0x1DD7AD0 Offset: 0x1DD7BD1 VA: 0x1DD7AD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.get_Status
	|
	|-RVA: 0x1DD7E30 Offset: 0x1DD7F31 VA: 0x1DD7E30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.get_Status
	|
	|-RVA: 0x1DD8160 Offset: 0x1DD8261 VA: 0x1DD8160
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.get_Status
	|
	|-RVA: 0x1DD84E0 Offset: 0x1DD85E1 VA: 0x1DD84E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.get_Status
	|
	|-RVA: 0x1DD8870 Offset: 0x1DD8971 VA: 0x1DD8870
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.get_Status
	|
	|-RVA: 0x1DD8C00 Offset: 0x1DD8D01 VA: 0x1DD8C00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.get_Status
	|
	|-RVA: 0x1DD8F90 Offset: 0x1DD9091 VA: 0x1DD8F90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.get_Status
	|
	|-RVA: 0x1DD9330 Offset: 0x1DD9431 VA: 0x1DD9330
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x1DD9710 Offset: 0x1DD9811 VA: 0x1DD9710
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.get_Status
	|
	|-RVA: 0x1DD9AF0 Offset: 0x1DD9BF1 VA: 0x1DD9AF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x1DD9F00 Offset: 0x1DDA001 VA: 0x1DD9F00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x1DDA2E0 Offset: 0x1DDA3E1 VA: 0x1DDA2E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x1DDA700 Offset: 0x1DDA801 VA: 0x1DDA700
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x1DDAB00 Offset: 0x1DDAC01 VA: 0x1DDAB00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x1DDAF50 Offset: 0x1DDB051 VA: 0x1DDAF50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x1DDB320 Offset: 0x1DDB421 VA: 0x1DDB320
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x1DDB700 Offset: 0x1DDB801 VA: 0x1DDB700
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x1DDBAD0 Offset: 0x1DDBBD1 VA: 0x1DDBAD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.get_Status
	|
	|-RVA: 0x1DDBDE0 Offset: 0x1DDBEE1 VA: 0x1DDBDE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.get_Status
	|
	|-RVA: 0x1DDC120 Offset: 0x1DDC221 VA: 0x1DDC120
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.get_Status
	|
	|-RVA: 0x1DDC480 Offset: 0x1DDC581 VA: 0x1DDC480
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.get_Status
	|
	|-RVA: 0x1DDC7C0 Offset: 0x1DDC8C1 VA: 0x1DDC7C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.get_Status
	|
	|-RVA: 0x1DDCB50 Offset: 0x1DDCC51 VA: 0x1DDCB50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.get_Status
	|
	|-RVA: 0x1DDCED0 Offset: 0x1DDCFD1 VA: 0x1DDCED0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.get_Status
	|
	|-RVA: 0x1DDD240 Offset: 0x1DDD341 VA: 0x1DDD240
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.get_Status
	|
	|-RVA: 0x1DDD5D0 Offset: 0x1DDD6D1 VA: 0x1DDD5D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DDD960 Offset: 0x1DDDA61 VA: 0x1DDD960
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.get_Status
	|
	|-RVA: 0x1DDDCF0 Offset: 0x1DDDDF1 VA: 0x1DDDCF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.get_Status
	|
	|-RVA: 0x1DDE070 Offset: 0x1DDE171 VA: 0x1DDE070
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.get_Status
	|
	|-RVA: 0x1DDE3E0 Offset: 0x1DDE4E1 VA: 0x1DDE3E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.get_Status
	|
	|-RVA: 0x1DDE740 Offset: 0x1DDE841 VA: 0x1DDE740
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.get_Status
	|
	|-RVA: 0x1DDEA70 Offset: 0x1DDEB71 VA: 0x1DDEA70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.get_Status
	|
	|-RVA: 0x1DDEDE0 Offset: 0x1DDEEE1 VA: 0x1DDEDE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.get_Status
	|
	|-RVA: 0x1DDF160 Offset: 0x1DDF261 VA: 0x1DDF160
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.get_Status
	|
	|-RVA: 0x1DDF4F0 Offset: 0x1DDF5F1 VA: 0x1DDF4F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.get_Status
	|
	|-RVA: 0x1DDF880 Offset: 0x1DDF981 VA: 0x1DDF880
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.get_Status
	|
	|-RVA: 0x1DDFC20 Offset: 0x1DDFD21 VA: 0x1DDFC20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DDFFE0 Offset: 0x1DE00E1 VA: 0x1DDFFE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.get_Status
	|
	|-RVA: 0x1DE0380 Offset: 0x1DE0481 VA: 0x1DE0380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DE0760 Offset: 0x1DE0861 VA: 0x1DE0760
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x1DE0B40 Offset: 0x1DE0C41 VA: 0x1DE0B40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DE0F50 Offset: 0x1DE1051 VA: 0x1DE0F50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x1DE1330 Offset: 0x1DE1431 VA: 0x1DE1330
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DE1750 Offset: 0x1DE1851 VA: 0x1DE1750
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x1DE1B50 Offset: 0x1DE1C51 VA: 0x1DE1B50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DE1FB0 Offset: 0x1DE20B1 VA: 0x1DE1FB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x1DE2380 Offset: 0x1DE2481 VA: 0x1DE2380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x1DE2710 Offset: 0x1DE2811 VA: 0x1DE2710
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x1DE2A70 Offset: 0x1DE2B71 VA: 0x1DE2A70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_Status
	|
	|-RVA: 0x1DE2D80 Offset: 0x1DE2E81 VA: 0x1DE2D80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.get_Status
	|
	|-RVA: 0x1DE30C0 Offset: 0x1DE31C1 VA: 0x1DE30C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.get_Status
	|
	|-RVA: 0x1DE3420 Offset: 0x1DE3521 VA: 0x1DE3420
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.get_Status
	|
	|-RVA: 0x1DE3750 Offset: 0x1DE3851 VA: 0x1DE3750
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.get_Status
	|
	|-RVA: 0x1DE3AC0 Offset: 0x1DE3BC1 VA: 0x1DE3AC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, double>>>.get_Status
	|
	|-RVA: 0x1DE3E30 Offset: 0x1DE3F31 VA: 0x1DE3E30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, int>>>.get_Status
	|
	|-RVA: 0x1DE4190 Offset: 0x1DE4291 VA: 0x1DE4190
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, long>>>.get_Status
	|
	|-RVA: 0x1DE4500 Offset: 0x1DE4601 VA: 0x1DE4500
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x1DE4870 Offset: 0x1DE4971 VA: 0x1DE4870
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.get_Status
	|
	|-RVA: 0x1DE4BE0 Offset: 0x1DE4CE1 VA: 0x1DE4BE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.get_Status
	|
	|-RVA: 0x1DE4F50 Offset: 0x1DE5051 VA: 0x1DE4F50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, float>>>.get_Status
	|
	|-RVA: 0x1DE52B0 Offset: 0x1DE53B1 VA: 0x1DE52B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.get_Status
	|
	|-RVA: 0x1DE5600 Offset: 0x1DE5701 VA: 0x1DE5600
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.get_Status
	|
	|-RVA: 0x1DE5930 Offset: 0x1DE5A31 VA: 0x1DE5930
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.get_Status
	|
	|-RVA: 0x1DE5C90 Offset: 0x1DE5D91 VA: 0x1DE5C90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.get_Status
	|
	|-RVA: 0x1DE6000 Offset: 0x1DE6101 VA: 0x1DE6000
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.get_Status
	|
	|-RVA: 0x1DE6370 Offset: 0x1DE6471 VA: 0x1DE6370
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, object>>>.get_Status
	|
	|-RVA: 0x1DE66E0 Offset: 0x1DE67E1 VA: 0x1DE66E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object>>>.get_Status
	|
	|-RVA: 0x1DE6A70 Offset: 0x1DE6B71 VA: 0x1DE6A70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DE6E30 Offset: 0x1DE6F31 VA: 0x1DE6E30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.get_Status
	|
	|-RVA: 0x1DE71D0 Offset: 0x1DE72D1 VA: 0x1DE71D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DE75A0 Offset: 0x1DE76A1 VA: 0x1DE75A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.get_Status
	|
	|-RVA: 0x1DE7950 Offset: 0x1DE7A51 VA: 0x1DE7950
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DE7D60 Offset: 0x1DE7E61 VA: 0x1DE7D60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x1DE8140 Offset: 0x1DE8241 VA: 0x1DE8140
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DE8560 Offset: 0x1DE8661 VA: 0x1DE8560
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x1DE8950 Offset: 0x1DE8A51 VA: 0x1DE8950
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DE8DA0 Offset: 0x1DE8EA1 VA: 0x1DE8DA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x1DE9170 Offset: 0x1DE9271 VA: 0x1DE9170
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DE9530 Offset: 0x1DE9631 VA: 0x1DE9530
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x1DE9890 Offset: 0x1DE9991 VA: 0x1DE9890
	|-UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>.get_Status
	|
	|-RVA: 0x1DE9DF0 Offset: 0x1DE9EF1 VA: 0x1DE9DF0
	|-UniTask.Awaiter<ValueTuple<bool, bool>>.get_Status
	|
	|-RVA: 0x1DEA130 Offset: 0x1DEA231 VA: 0x1DEA130
	|-UniTask.Awaiter<ValueTuple<bool, Bounds>>.get_Status
	|
	|-RVA: 0x1DEA490 Offset: 0x1DEA591 VA: 0x1DEA490
	|-UniTask.Awaiter<ValueTuple<bool, byte>>.get_Status
	|
	|-RVA: 0x1DEA7C0 Offset: 0x1DEA8C1 VA: 0x1DEA7C0
	|-UniTask.Awaiter<ValueTuple<bool, Color>>.get_Status
	|
	|-RVA: 0x1DEAB30 Offset: 0x1DEAC31 VA: 0x1DEAB30
	|-UniTask.Awaiter<ValueTuple<bool, double>>.get_Status
	|
	|-RVA: 0x1DEAE70 Offset: 0x1DEAF71 VA: 0x1DEAE70
	|-UniTask.Awaiter<ValueTuple<bool, int>>.get_Status
	|
	|-RVA: 0x1DEB1A0 Offset: 0x1DEB2A1 VA: 0x1DEB1A0
	|-UniTask.Awaiter<ValueTuple<bool, long>>.get_Status
	|
	|-RVA: 0x1DEB500 Offset: 0x1DEB601 VA: 0x1DEB500
	|-UniTask.Awaiter<ValueTuple<bool, object>>.get_Status
	|
	|-RVA: 0x1DEBAD0 Offset: 0x1DEBBD1 VA: 0x1DEBAD0
	|-UniTask.Awaiter<ValueTuple<bool, Quaternion>>.get_Status
	|
	|-RVA: 0x1DEBE40 Offset: 0x1DEBF41 VA: 0x1DEBE40
	|-UniTask.Awaiter<ValueTuple<bool, Rect>>.get_Status
	|
	|-RVA: 0x1DEC190 Offset: 0x1DEC291 VA: 0x1DEC190
	|-UniTask.Awaiter<ValueTuple<bool, float>>.get_Status
	|
	|-RVA: 0x1DEC4C0 Offset: 0x1DEC5C1 VA: 0x1DEC4C0
	|-UniTask.Awaiter<ValueTuple<bool, UniTask>>.get_Status
	|
	|-RVA: 0x1DEC800 Offset: 0x1DEC901 VA: 0x1DEC800
	|-UniTask.Awaiter<ValueTuple<bool, Unit>>.get_Status
	|
	|-RVA: 0x1DECB30 Offset: 0x1DECC31 VA: 0x1DECB30
	|-UniTask.Awaiter<ValueTuple<bool, Vector2>>.get_Status
	|
	|-RVA: 0x1DECE90 Offset: 0x1DECF91 VA: 0x1DECE90
	|-UniTask.Awaiter<ValueTuple<bool, Vector3>>.get_Status
	|
	|-RVA: 0x1DED1F0 Offset: 0x1DED2F1 VA: 0x1DED1F0
	|-UniTask.Awaiter<ValueTuple<bool, Vector4>>.get_Status
	|
	|-RVA: 0x1DED560 Offset: 0x1DED661 VA: 0x1DED560
	|-UniTask.Awaiter<ValueTuple<int, object>>.get_Status
	|
	|-RVA: 0x1DED8C0 Offset: 0x1DED9C1 VA: 0x1DED8C0
	|-UniTask.Awaiter<ValueTuple<object, object>>.get_Status
	|
	|-RVA: 0x1DEDC30 Offset: 0x1DEDD31 VA: 0x1DEDC30
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x1DEDFB0 Offset: 0x1DEE0B1 VA: 0x1DEDFB0
	|-UniTask.Awaiter<ValueTuple<object, object, object>>.get_Status
	|
	|-RVA: 0x1DEE340 Offset: 0x1DEE441 VA: 0x1DEE340
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x1DEE700 Offset: 0x1DEE801 VA: 0x1DEE700
	|-UniTask.Awaiter<ValueTuple<object, object, object, object>>.get_Status
	|
	|-RVA: 0x1DEEAA0 Offset: 0x1DEEBA1 VA: 0x1DEEAA0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x1DEEE70 Offset: 0x1DEEF71 VA: 0x1DEEE70
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x1DEF220 Offset: 0x1DEF321 VA: 0x1DEF220
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x1DEF630 Offset: 0x1DEF731 VA: 0x1DEF630
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x1DEFA10 Offset: 0x1DEFB11 VA: 0x1DEFA10
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x1DEFE30 Offset: 0x1DEFF31 VA: 0x1DEFE30
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x1DF0220 Offset: 0x1DF0321 VA: 0x1DF0220
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DF0670 Offset: 0x1DF0771 VA: 0x1DF0670
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x1DF09D0 Offset: 0x1DF0AD1 VA: 0x1DF09D0
	|-UniTask.Awaiter<AsyncUnit>.get_Status
	|
	|-RVA: 0x1DF0CE0 Offset: 0x1DF0DE1 VA: 0x1DF0CE0
	|-UniTask.Awaiter<bool>.get_Status
	|
	|-RVA: 0x1DF1010 Offset: 0x1DF1111 VA: 0x1DF1010
	|-UniTask.Awaiter<Bounds>.get_Status
	|
	|-RVA: 0x1DF1360 Offset: 0x1DF1461 VA: 0x1DF1360
	|-UniTask.Awaiter<byte>.get_Status
	|
	|-RVA: 0x1DF1690 Offset: 0x1DF1791 VA: 0x1DF1690
	|-UniTask.Awaiter<Color>.get_Status
	|
	|-RVA: 0x1DF19D0 Offset: 0x1DF1AD1 VA: 0x1DF19D0
	|-UniTask.Awaiter<double>.get_Status
	|
	|-RVA: 0x1DF1CE0 Offset: 0x1DF1DE1 VA: 0x1DF1CE0
	|-UniTask.Awaiter<int>.get_Status
	|
	|-RVA: 0x1DF1FF0 Offset: 0x1DF20F1 VA: 0x1DF1FF0
	|-UniTask.Awaiter<long>.get_Status
	|
	|-RVA: 0x1DF2300 Offset: 0x1DF2401 VA: 0x1DF2300
	|-UniTask.Awaiter<object>.get_Status
	|
	|-RVA: 0x1DF2C80 Offset: 0x1DF2D81 VA: 0x1DF2C80
	|-UniTask.Awaiter<Quaternion>.get_Status
	|
	|-RVA: 0x1DF2FE0 Offset: 0x1DF30E1 VA: 0x1DF2FE0
	|-UniTask.Awaiter<Rect>.get_Status
	|
	|-RVA: 0x1DF3320 Offset: 0x1DF3421 VA: 0x1DF3320
	|-UniTask.Awaiter<float>.get_Status
	|
	|-RVA: 0x1DF3630 Offset: 0x1DF3731 VA: 0x1DF3630
	|-UniTask.Awaiter<UniTask>.get_Status
	|
	|-RVA: 0x1DF3940 Offset: 0x1DF3A41 VA: 0x1DF3940
	|-UniTask.Awaiter<Unit>.get_Status
	|
	|-RVA: 0x1DF3C50 Offset: 0x1DF3D51 VA: 0x1DF3C50
	|-UniTask.Awaiter<Vector2>.get_Status
	|
	|-RVA: 0x1DF3F80 Offset: 0x1DF4081 VA: 0x1DF3F80
	|-UniTask.Awaiter<Vector3>.get_Status
	|
	|-RVA: 0x1DF42E0 Offset: 0x1DF43E1 VA: 0x1DF42E0
	|-UniTask.Awaiter<Vector4>.get_Status
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CF30 Offset: 0x2D031 VA: 0x2CF30
	// RVA: -1 Offset: -1 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5F240 Offset: 0x2F5F341 VA: 0x2F5F240
	|-UniTask.Awaiter<UniTask<object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F5F5A0 Offset: 0x2F5F6A1 VA: 0x2F5F5A0
	|-UniTask.Awaiter<ValueTuple<bool, UniTask<object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F5F920 Offset: 0x2F5FA21 VA: 0x2F5F920
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F5FCB0 Offset: 0x2F5FDB1 VA: 0x2F5FCB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F60060 Offset: 0x2F60161 VA: 0x2F60060
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F603D0 Offset: 0x2F604D1 VA: 0x2F603D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F606E0 Offset: 0x2F607E1 VA: 0x2F606E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F60A50 Offset: 0x2F60B51 VA: 0x2F60A50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F60DC0 Offset: 0x2F60EC1 VA: 0x2F60DC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F61110 Offset: 0x2F61211 VA: 0x2F61110
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F614C0 Offset: 0x2F615C1 VA: 0x2F614C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F61860 Offset: 0x2F61961 VA: 0x2F61860
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F61C00 Offset: 0x2F61D01 VA: 0x2F61C00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F61FD0 Offset: 0x2F620D1 VA: 0x2F61FD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F62380 Offset: 0x2F62481 VA: 0x2F62380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F62710 Offset: 0x2F62811 VA: 0x2F62710
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F62A90 Offset: 0x2F62B91 VA: 0x2F62A90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F62E30 Offset: 0x2F62F31 VA: 0x2F62E30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F631A0 Offset: 0x2F632A1 VA: 0x2F631A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F634F0 Offset: 0x2F635F1 VA: 0x2F634F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F63880 Offset: 0x2F63981 VA: 0x2F63880
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F63C10 Offset: 0x2F63D11 VA: 0x2F63C10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F63FC0 Offset: 0x2F640C1 VA: 0x2F63FC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F64390 Offset: 0x2F64491 VA: 0x2F64390
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F64760 Offset: 0x2F64861 VA: 0x2F64760
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x2F64B30 Offset: 0x2F64C31 VA: 0x2F64B30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD4630 Offset: 0x1DD4731 VA: 0x1DD4630
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD4A30 Offset: 0x1DD4B31 VA: 0x1DD4A30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD4E50 Offset: 0x1DD4F51 VA: 0x1DD4E50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD51F0 Offset: 0x1DD52F1 VA: 0x1DD51F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD5500 Offset: 0x1DD5601 VA: 0x1DD5500
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD5850 Offset: 0x1DD5951 VA: 0x1DD5850
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD5BA0 Offset: 0x1DD5CA1 VA: 0x1DD5BA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD5EF0 Offset: 0x1DD5FF1 VA: 0x1DD5EF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD6280 Offset: 0x1DD6381 VA: 0x1DD6280
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD6600 Offset: 0x1DD6701 VA: 0x1DD6600
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD6980 Offset: 0x1DD6A81 VA: 0x1DD6980
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD6D10 Offset: 0x1DD6E11 VA: 0x1DD6D10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD70A0 Offset: 0x1DD71A1 VA: 0x1DD70A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD7430 Offset: 0x1DD7531 VA: 0x1DD7430
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD77B0 Offset: 0x1DD78B1 VA: 0x1DD77B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD7B30 Offset: 0x1DD7C31 VA: 0x1DD7B30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD7E80 Offset: 0x1DD7F81 VA: 0x1DD7E80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD81C0 Offset: 0x1DD82C1 VA: 0x1DD81C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD8540 Offset: 0x1DD8641 VA: 0x1DD8540
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD88D0 Offset: 0x1DD89D1 VA: 0x1DD88D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD8C60 Offset: 0x1DD8D61 VA: 0x1DD8C60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD8FF0 Offset: 0x1DD90F1 VA: 0x1DD8FF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD93A0 Offset: 0x1DD94A1 VA: 0x1DD93A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD9780 Offset: 0x1DD9881 VA: 0x1DD9780
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD9B70 Offset: 0x1DD9C71 VA: 0x1DD9B70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DD9F70 Offset: 0x1DDA071 VA: 0x1DD9F70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDA360 Offset: 0x1DDA461 VA: 0x1DDA360
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDA770 Offset: 0x1DDA871 VA: 0x1DDA770
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDAB90 Offset: 0x1DDAC91 VA: 0x1DDAB90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDAFC0 Offset: 0x1DDB0C1 VA: 0x1DDAFC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDB380 Offset: 0x1DDB481 VA: 0x1DDB380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDB780 Offset: 0x1DDB881 VA: 0x1DDB780
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDBB20 Offset: 0x1DDBC21 VA: 0x1DDBB20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDBE30 Offset: 0x1DDBF31 VA: 0x1DDBE30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDC180 Offset: 0x1DDC281 VA: 0x1DDC180
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDC4D0 Offset: 0x1DDC5D1 VA: 0x1DDC4D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDC820 Offset: 0x1DDC921 VA: 0x1DDC820
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDCBB0 Offset: 0x1DDCCB1 VA: 0x1DDCBB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDCF30 Offset: 0x1DDD031 VA: 0x1DDCF30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDD2A0 Offset: 0x1DDD3A1 VA: 0x1DDD2A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDD630 Offset: 0x1DDD731 VA: 0x1DDD630
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDD9C0 Offset: 0x1DDDAC1 VA: 0x1DDD9C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDDD50 Offset: 0x1DDDE51 VA: 0x1DDDD50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDE0D0 Offset: 0x1DDE1D1 VA: 0x1DDE0D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDE440 Offset: 0x1DDE541 VA: 0x1DDE440
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDE790 Offset: 0x1DDE891 VA: 0x1DDE790
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDEAD0 Offset: 0x1DDEBD1 VA: 0x1DDEAD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDEE40 Offset: 0x1DDEF41 VA: 0x1DDEE40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDF1C0 Offset: 0x1DDF2C1 VA: 0x1DDF1C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDF550 Offset: 0x1DDF651 VA: 0x1DDF550
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDF8E0 Offset: 0x1DDF9E1 VA: 0x1DDF8E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DDFC90 Offset: 0x1DDFD91 VA: 0x1DDFC90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE0040 Offset: 0x1DE0141 VA: 0x1DE0040
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE03F0 Offset: 0x1DE04F1 VA: 0x1DE03F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE07D0 Offset: 0x1DE08D1 VA: 0x1DE07D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE0BC0 Offset: 0x1DE0CC1 VA: 0x1DE0BC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE0FC0 Offset: 0x1DE10C1 VA: 0x1DE0FC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE13B0 Offset: 0x1DE14B1 VA: 0x1DE13B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE17C0 Offset: 0x1DE18C1 VA: 0x1DE17C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE1BE0 Offset: 0x1DE1CE1 VA: 0x1DE1BE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE2020 Offset: 0x1DE2121 VA: 0x1DE2020
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE23E0 Offset: 0x1DE24E1 VA: 0x1DE23E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE2770 Offset: 0x1DE2871 VA: 0x1DE2770
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE2AC0 Offset: 0x1DE2BC1 VA: 0x1DE2AC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE2DD0 Offset: 0x1DE2ED1 VA: 0x1DE2DD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE3120 Offset: 0x1DE3221 VA: 0x1DE3120
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE3470 Offset: 0x1DE3571 VA: 0x1DE3470
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE37B0 Offset: 0x1DE38B1 VA: 0x1DE37B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE3B20 Offset: 0x1DE3C21 VA: 0x1DE3B20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, double>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE3E90 Offset: 0x1DE3F91 VA: 0x1DE3E90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, int>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE41F0 Offset: 0x1DE42F1 VA: 0x1DE41F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, long>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE4560 Offset: 0x1DE4661 VA: 0x1DE4560
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE48D0 Offset: 0x1DE49D1 VA: 0x1DE48D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE4C40 Offset: 0x1DE4D41 VA: 0x1DE4C40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE4FB0 Offset: 0x1DE50B1 VA: 0x1DE4FB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, float>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE5310 Offset: 0x1DE5411 VA: 0x1DE5310
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE5650 Offset: 0x1DE5751 VA: 0x1DE5650
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE5990 Offset: 0x1DE5A91 VA: 0x1DE5990
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE5CF0 Offset: 0x1DE5DF1 VA: 0x1DE5CF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE6060 Offset: 0x1DE6161 VA: 0x1DE6060
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE63D0 Offset: 0x1DE64D1 VA: 0x1DE63D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE6740 Offset: 0x1DE6841 VA: 0x1DE6740
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE6AE0 Offset: 0x1DE6BE1 VA: 0x1DE6AE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE6E90 Offset: 0x1DE6F91 VA: 0x1DE6E90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE7240 Offset: 0x1DE7341 VA: 0x1DE7240
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE7600 Offset: 0x1DE7701 VA: 0x1DE7600
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE79D0 Offset: 0x1DE7AD1 VA: 0x1DE79D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE7DD0 Offset: 0x1DE7ED1 VA: 0x1DE7DD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE81C0 Offset: 0x1DE82C1 VA: 0x1DE81C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE85D0 Offset: 0x1DE86D1 VA: 0x1DE85D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE89E0 Offset: 0x1DE8AE1 VA: 0x1DE89E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE8E10 Offset: 0x1DE8F11 VA: 0x1DE8E10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE91D0 Offset: 0x1DE92D1 VA: 0x1DE91D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE9590 Offset: 0x1DE9691 VA: 0x1DE9590
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE98E0 Offset: 0x1DE99E1 VA: 0x1DE98E0
	|-UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DE9E40 Offset: 0x1DE9F41 VA: 0x1DE9E40
	|-UniTask.Awaiter<ValueTuple<bool, bool>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEA190 Offset: 0x1DEA291 VA: 0x1DEA190
	|-UniTask.Awaiter<ValueTuple<bool, Bounds>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEA4E0 Offset: 0x1DEA5E1 VA: 0x1DEA4E0
	|-UniTask.Awaiter<ValueTuple<bool, byte>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEA820 Offset: 0x1DEA921 VA: 0x1DEA820
	|-UniTask.Awaiter<ValueTuple<bool, Color>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEAB90 Offset: 0x1DEAC91 VA: 0x1DEAB90
	|-UniTask.Awaiter<ValueTuple<bool, double>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEAEC0 Offset: 0x1DEAFC1 VA: 0x1DEAEC0
	|-UniTask.Awaiter<ValueTuple<bool, int>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEB200 Offset: 0x1DEB301 VA: 0x1DEB200
	|-UniTask.Awaiter<ValueTuple<bool, long>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEB560 Offset: 0x1DEB661 VA: 0x1DEB560
	|-UniTask.Awaiter<ValueTuple<bool, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEBB30 Offset: 0x1DEBC31 VA: 0x1DEBB30
	|-UniTask.Awaiter<ValueTuple<bool, Quaternion>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEBEA0 Offset: 0x1DEBFA1 VA: 0x1DEBEA0
	|-UniTask.Awaiter<ValueTuple<bool, Rect>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEC1E0 Offset: 0x1DEC2E1 VA: 0x1DEC1E0
	|-UniTask.Awaiter<ValueTuple<bool, float>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEC520 Offset: 0x1DEC621 VA: 0x1DEC520
	|-UniTask.Awaiter<ValueTuple<bool, UniTask>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEC850 Offset: 0x1DEC951 VA: 0x1DEC850
	|-UniTask.Awaiter<ValueTuple<bool, Unit>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DECB90 Offset: 0x1DECC91 VA: 0x1DECB90
	|-UniTask.Awaiter<ValueTuple<bool, Vector2>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DECEF0 Offset: 0x1DECFF1 VA: 0x1DECEF0
	|-UniTask.Awaiter<ValueTuple<bool, Vector3>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DED250 Offset: 0x1DED351 VA: 0x1DED250
	|-UniTask.Awaiter<ValueTuple<bool, Vector4>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DED5C0 Offset: 0x1DED6C1 VA: 0x1DED5C0
	|-UniTask.Awaiter<ValueTuple<int, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DED920 Offset: 0x1DEDA21 VA: 0x1DED920
	|-UniTask.Awaiter<ValueTuple<object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEDC90 Offset: 0x1DEDD91 VA: 0x1DEDC90
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEE010 Offset: 0x1DEE111 VA: 0x1DEE010
	|-UniTask.Awaiter<ValueTuple<object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEE3B0 Offset: 0x1DEE4B1 VA: 0x1DEE3B0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEE760 Offset: 0x1DEE861 VA: 0x1DEE760
	|-UniTask.Awaiter<ValueTuple<object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEEB10 Offset: 0x1DEEC11 VA: 0x1DEEB10
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEEED0 Offset: 0x1DEEFD1 VA: 0x1DEEED0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEF2A0 Offset: 0x1DEF3A1 VA: 0x1DEF2A0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEF6A0 Offset: 0x1DEF7A1 VA: 0x1DEF6A0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEFA90 Offset: 0x1DEFB91 VA: 0x1DEFA90
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DEFEA0 Offset: 0x1DEFFA1 VA: 0x1DEFEA0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object, object>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF02B0 Offset: 0x1DF03B1 VA: 0x1DF02B0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF06D0 Offset: 0x1DF07D1 VA: 0x1DF06D0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF0A20 Offset: 0x1DF0B21 VA: 0x1DF0A20
	|-UniTask.Awaiter<AsyncUnit>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF0D30 Offset: 0x1DF0E31 VA: 0x1DF0D30
	|-UniTask.Awaiter<bool>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF1070 Offset: 0x1DF1171 VA: 0x1DF1070
	|-UniTask.Awaiter<Bounds>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF13B0 Offset: 0x1DF14B1 VA: 0x1DF13B0
	|-UniTask.Awaiter<byte>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF16F0 Offset: 0x1DF17F1 VA: 0x1DF16F0
	|-UniTask.Awaiter<Color>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF1A20 Offset: 0x1DF1B21 VA: 0x1DF1A20
	|-UniTask.Awaiter<double>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF1D30 Offset: 0x1DF1E31 VA: 0x1DF1D30
	|-UniTask.Awaiter<int>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF2040 Offset: 0x1DF2141 VA: 0x1DF2040
	|-UniTask.Awaiter<long>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF2350 Offset: 0x1DF2451 VA: 0x1DF2350
	|-UniTask.Awaiter<object>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF2CE0 Offset: 0x1DF2DE1 VA: 0x1DF2CE0
	|-UniTask.Awaiter<Quaternion>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF3040 Offset: 0x1DF3141 VA: 0x1DF3040
	|-UniTask.Awaiter<Rect>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF3370 Offset: 0x1DF3471 VA: 0x1DF3370
	|-UniTask.Awaiter<float>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF3680 Offset: 0x1DF3781 VA: 0x1DF3680
	|-UniTask.Awaiter<UniTask>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF3990 Offset: 0x1DF3A91 VA: 0x1DF3990
	|-UniTask.Awaiter<Unit>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF3CA0 Offset: 0x1DF3DA1 VA: 0x1DF3CA0
	|-UniTask.Awaiter<Vector2>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF3FE0 Offset: 0x1DF40E1 VA: 0x1DF3FE0
	|-UniTask.Awaiter<Vector3>.UniRx.Async.IAwaiter.GetResult
	|
	|-RVA: 0x1DF4340 Offset: 0x1DF4441 VA: 0x1DF4340
	|-UniTask.Awaiter<Vector4>.UniRx.Async.IAwaiter.GetResult
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CF40 Offset: 0x2D041 VA: 0x2CF40
	// RVA: -1 Offset: -1 Slot: 4
	public T GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5F2C0 Offset: 0x2F5F3C1 VA: 0x2F5F2C0
	|-UniTask.Awaiter<UniTask<object>>.GetResult
	|
	|-RVA: 0x2F5F620 Offset: 0x2F5F721 VA: 0x2F5F620
	|-UniTask.Awaiter<ValueTuple<bool, UniTask<object>>>.GetResult
	|
	|-RVA: 0x2F5F9A0 Offset: 0x2F5FAA1 VA: 0x2F5F9A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.GetResult
	|
	|-RVA: 0x2F5FD30 Offset: 0x2F5FE31 VA: 0x2F5FD30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.GetResult
	|
	|-RVA: 0x2F600F0 Offset: 0x2F601F1 VA: 0x2F600F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.GetResult
	|
	|-RVA: 0x2F60440 Offset: 0x2F60541 VA: 0x2F60440
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.GetResult
	|
	|-RVA: 0x2F60750 Offset: 0x2F60851 VA: 0x2F60750
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.GetResult
	|
	|-RVA: 0x2F60AE0 Offset: 0x2F60BE1 VA: 0x2F60AE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.GetResult
	|
	|-RVA: 0x2F60E30 Offset: 0x2F60F31 VA: 0x2F60E30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.GetResult
	|
	|-RVA: 0x2F61190 Offset: 0x2F61291 VA: 0x2F61190
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.GetResult
	|
	|-RVA: 0x2F61550 Offset: 0x2F61651 VA: 0x2F61550
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.GetResult
	|
	|-RVA: 0x2F618E0 Offset: 0x2F619E1 VA: 0x2F618E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.GetResult
	|
	|-RVA: 0x2F61C90 Offset: 0x2F61D91 VA: 0x2F61C90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.GetResult
	|
	|-RVA: 0x2F62060 Offset: 0x2F62161 VA: 0x2F62060
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x2F62400 Offset: 0x2F62501 VA: 0x2F62400
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.GetResult
	|
	|-RVA: 0x2F62790 Offset: 0x2F62891 VA: 0x2F62790
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.GetResult
	|
	|-RVA: 0x2F62B10 Offset: 0x2F62C11 VA: 0x2F62B10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.GetResult
	|
	|-RVA: 0x2F62EC0 Offset: 0x2F62FC1 VA: 0x2F62EC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.GetResult
	|
	|-RVA: 0x2F63210 Offset: 0x2F63311 VA: 0x2F63210
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.GetResult
	|
	|-RVA: 0x2F63570 Offset: 0x2F63671 VA: 0x2F63570
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.GetResult
	|
	|-RVA: 0x2F63900 Offset: 0x2F63A01 VA: 0x2F63900
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.GetResult
	|
	|-RVA: 0x2F63C90 Offset: 0x2F63D91 VA: 0x2F63C90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.GetResult
	|
	|-RVA: 0x2F64050 Offset: 0x2F64151 VA: 0x2F64050
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.GetResult
	|
	|-RVA: 0x2F64420 Offset: 0x2F64521 VA: 0x2F64420
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.GetResult
	|
	|-RVA: 0x2F647F0 Offset: 0x2F648F1 VA: 0x2F647F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x2F64BC0 Offset: 0x2F64CC1 VA: 0x2F64BC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x1DD46C0 Offset: 0x1DD47C1 VA: 0x1DD46C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x1DD4AD0 Offset: 0x1DD4BD1 VA: 0x1DD4AD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x1DD4EF0 Offset: 0x1DD4FF1 VA: 0x1DD4EF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.GetResult
	|
	|-RVA: 0x1DD5260 Offset: 0x1DD5361 VA: 0x1DD5260
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.GetResult
	|
	|-RVA: 0x1DD5570 Offset: 0x1DD5671 VA: 0x1DD5570
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.GetResult
	|
	|-RVA: 0x1DD58D0 Offset: 0x1DD59D1 VA: 0x1DD58D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.GetResult
	|
	|-RVA: 0x1DD5C10 Offset: 0x1DD5D11 VA: 0x1DD5C10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.GetResult
	|
	|-RVA: 0x1DD5F70 Offset: 0x1DD6071 VA: 0x1DD5F70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.GetResult
	|
	|-RVA: 0x1DD6300 Offset: 0x1DD6401 VA: 0x1DD6300
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.GetResult
	|
	|-RVA: 0x1DD6680 Offset: 0x1DD6781 VA: 0x1DD6680
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.GetResult
	|
	|-RVA: 0x1DD6A00 Offset: 0x1DD6B01 VA: 0x1DD6A00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.GetResult
	|
	|-RVA: 0x1DD6D90 Offset: 0x1DD6E91 VA: 0x1DD6D90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DD7120 Offset: 0x1DD7221 VA: 0x1DD7120
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.GetResult
	|
	|-RVA: 0x1DD74B0 Offset: 0x1DD75B1 VA: 0x1DD74B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.GetResult
	|
	|-RVA: 0x1DD7830 Offset: 0x1DD7931 VA: 0x1DD7830
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.GetResult
	|
	|-RVA: 0x1DD7BB0 Offset: 0x1DD7CB1 VA: 0x1DD7BB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.GetResult
	|
	|-RVA: 0x1DD7EF0 Offset: 0x1DD7FF1 VA: 0x1DD7EF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.GetResult
	|
	|-RVA: 0x1DD8240 Offset: 0x1DD8341 VA: 0x1DD8240
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.GetResult
	|
	|-RVA: 0x1DD85C0 Offset: 0x1DD86C1 VA: 0x1DD85C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.GetResult
	|
	|-RVA: 0x1DD8950 Offset: 0x1DD8A51 VA: 0x1DD8950
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.GetResult
	|
	|-RVA: 0x1DD8CE0 Offset: 0x1DD8DE1 VA: 0x1DD8CE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.GetResult
	|
	|-RVA: 0x1DD9070 Offset: 0x1DD9171 VA: 0x1DD9070
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.GetResult
	|
	|-RVA: 0x1DD9430 Offset: 0x1DD9531 VA: 0x1DD9430
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x1DD9810 Offset: 0x1DD9911 VA: 0x1DD9810
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.GetResult
	|
	|-RVA: 0x1DD9C10 Offset: 0x1DD9D11 VA: 0x1DD9C10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x1DDA000 Offset: 0x1DDA101 VA: 0x1DDA000
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x1DDA400 Offset: 0x1DDA501 VA: 0x1DDA400
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x1DDA800 Offset: 0x1DDA901 VA: 0x1DDA800
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x1DDAC40 Offset: 0x1DDAD41 VA: 0x1DDAC40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x1DDB050 Offset: 0x1DDB151 VA: 0x1DDB050
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x1DDB400 Offset: 0x1DDB501 VA: 0x1DDB400
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x1DDB820 Offset: 0x1DDB921 VA: 0x1DDB820
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.GetResult
	|
	|-RVA: 0x1DDBB90 Offset: 0x1DDBC91 VA: 0x1DDBB90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.GetResult
	|
	|-RVA: 0x1DDBEA0 Offset: 0x1DDBFA1 VA: 0x1DDBEA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.GetResult
	|
	|-RVA: 0x1DDC200 Offset: 0x1DDC301 VA: 0x1DDC200
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.GetResult
	|
	|-RVA: 0x1DDC540 Offset: 0x1DDC641 VA: 0x1DDC540
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.GetResult
	|
	|-RVA: 0x1DDC8A0 Offset: 0x1DDC9A1 VA: 0x1DDC8A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.GetResult
	|
	|-RVA: 0x1DDCC30 Offset: 0x1DDCD31 VA: 0x1DDCC30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.GetResult
	|
	|-RVA: 0x1DDCFB0 Offset: 0x1DDD0B1 VA: 0x1DDCFB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.GetResult
	|
	|-RVA: 0x1DDD320 Offset: 0x1DDD421 VA: 0x1DDD320
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.GetResult
	|
	|-RVA: 0x1DDD6B0 Offset: 0x1DDD7B1 VA: 0x1DDD6B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DDDA40 Offset: 0x1DDDB41 VA: 0x1DDDA40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.GetResult
	|
	|-RVA: 0x1DDDDD0 Offset: 0x1DDDED1 VA: 0x1DDDDD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.GetResult
	|
	|-RVA: 0x1DDE150 Offset: 0x1DDE251 VA: 0x1DDE150
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.GetResult
	|
	|-RVA: 0x1DDE4C0 Offset: 0x1DDE5C1 VA: 0x1DDE4C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.GetResult
	|
	|-RVA: 0x1DDE800 Offset: 0x1DDE901 VA: 0x1DDE800
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.GetResult
	|
	|-RVA: 0x1DDEB50 Offset: 0x1DDEC51 VA: 0x1DDEB50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.GetResult
	|
	|-RVA: 0x1DDEEC0 Offset: 0x1DDEFC1 VA: 0x1DDEEC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.GetResult
	|
	|-RVA: 0x1DDF240 Offset: 0x1DDF341 VA: 0x1DDF240
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.GetResult
	|
	|-RVA: 0x1DDF5D0 Offset: 0x1DDF6D1 VA: 0x1DDF5D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.GetResult
	|
	|-RVA: 0x1DDF960 Offset: 0x1DDFA61 VA: 0x1DDF960
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.GetResult
	|
	|-RVA: 0x1DDFD20 Offset: 0x1DDFE21 VA: 0x1DDFD20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DE00C0 Offset: 0x1DE01C1 VA: 0x1DE00C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.GetResult
	|
	|-RVA: 0x1DE0480 Offset: 0x1DE0581 VA: 0x1DE0480
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DE0860 Offset: 0x1DE0961 VA: 0x1DE0860
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x1DE0C60 Offset: 0x1DE0D61 VA: 0x1DE0C60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DE1050 Offset: 0x1DE1151 VA: 0x1DE1050
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x1DE1450 Offset: 0x1DE1551 VA: 0x1DE1450
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DE1850 Offset: 0x1DE1951 VA: 0x1DE1850
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x1DE1C90 Offset: 0x1DE1D91 VA: 0x1DE1C90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DE20B0 Offset: 0x1DE21B1 VA: 0x1DE20B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.GetResult
	|
	|-RVA: 0x1DE2460 Offset: 0x1DE2561 VA: 0x1DE2460
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x1DE27F0 Offset: 0x1DE28F1 VA: 0x1DE27F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetResult
	|
	|-RVA: 0x1DE2B30 Offset: 0x1DE2C31 VA: 0x1DE2B30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.GetResult
	|
	|-RVA: 0x1DE2E40 Offset: 0x1DE2F41 VA: 0x1DE2E40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.GetResult
	|
	|-RVA: 0x1DE31A0 Offset: 0x1DE32A1 VA: 0x1DE31A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.GetResult
	|
	|-RVA: 0x1DE34E0 Offset: 0x1DE35E1 VA: 0x1DE34E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.GetResult
	|
	|-RVA: 0x1DE3830 Offset: 0x1DE3931 VA: 0x1DE3830
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.GetResult
	|
	|-RVA: 0x1DE3BA0 Offset: 0x1DE3CA1 VA: 0x1DE3BA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, double>>>.GetResult
	|
	|-RVA: 0x1DE3F10 Offset: 0x1DE4011 VA: 0x1DE3F10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, int>>>.GetResult
	|
	|-RVA: 0x1DE4270 Offset: 0x1DE4371 VA: 0x1DE4270
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, long>>>.GetResult
	|
	|-RVA: 0x1DE45E0 Offset: 0x1DE46E1 VA: 0x1DE45E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x1DE4950 Offset: 0x1DE4A51 VA: 0x1DE4950
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.GetResult
	|
	|-RVA: 0x1DE4CC0 Offset: 0x1DE4DC1 VA: 0x1DE4CC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.GetResult
	|
	|-RVA: 0x1DE5030 Offset: 0x1DE5131 VA: 0x1DE5030
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, float>>>.GetResult
	|
	|-RVA: 0x1DE5390 Offset: 0x1DE5491 VA: 0x1DE5390
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.GetResult
	|
	|-RVA: 0x1DE56C0 Offset: 0x1DE57C1 VA: 0x1DE56C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.GetResult
	|
	|-RVA: 0x1DE5A10 Offset: 0x1DE5B11 VA: 0x1DE5A10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.GetResult
	|
	|-RVA: 0x1DE5D70 Offset: 0x1DE5E71 VA: 0x1DE5D70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.GetResult
	|
	|-RVA: 0x1DE60E0 Offset: 0x1DE61E1 VA: 0x1DE60E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.GetResult
	|
	|-RVA: 0x1DE6450 Offset: 0x1DE6551 VA: 0x1DE6450
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, object>>>.GetResult
	|
	|-RVA: 0x1DE67C0 Offset: 0x1DE68C1 VA: 0x1DE67C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object>>>.GetResult
	|
	|-RVA: 0x1DE6B70 Offset: 0x1DE6C71 VA: 0x1DE6B70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DE6F10 Offset: 0x1DE7011 VA: 0x1DE6F10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.GetResult
	|
	|-RVA: 0x1DE72D0 Offset: 0x1DE73D1 VA: 0x1DE72D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DE7680 Offset: 0x1DE7781 VA: 0x1DE7680
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.GetResult
	|
	|-RVA: 0x1DE7A70 Offset: 0x1DE7B71 VA: 0x1DE7A70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DE7E60 Offset: 0x1DE7F61 VA: 0x1DE7E60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.GetResult
	|
	|-RVA: 0x1DE8260 Offset: 0x1DE8361 VA: 0x1DE8260
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DE8660 Offset: 0x1DE8761 VA: 0x1DE8660
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.GetResult
	|
	|-RVA: 0x1DE8A90 Offset: 0x1DE8B91 VA: 0x1DE8A90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DE8EA0 Offset: 0x1DE8FA1 VA: 0x1DE8EA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.GetResult
	|
	|-RVA: 0x1DE9250 Offset: 0x1DE9351 VA: 0x1DE9250
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DE9610 Offset: 0x1DE9711 VA: 0x1DE9610
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetResult
	|
	|-RVA: 0x1DE9950 Offset: 0x1DE9A51 VA: 0x1DE9950
	|-UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>.GetResult
	|
	|-RVA: 0x1DE9EB0 Offset: 0x1DE9FB1 VA: 0x1DE9EB0
	|-UniTask.Awaiter<ValueTuple<bool, bool>>.GetResult
	|
	|-RVA: 0x1DEA210 Offset: 0x1DEA311 VA: 0x1DEA210
	|-UniTask.Awaiter<ValueTuple<bool, Bounds>>.GetResult
	|
	|-RVA: 0x1DEA550 Offset: 0x1DEA651 VA: 0x1DEA550
	|-UniTask.Awaiter<ValueTuple<bool, byte>>.GetResult
	|
	|-RVA: 0x1DEA8A0 Offset: 0x1DEA9A1 VA: 0x1DEA8A0
	|-UniTask.Awaiter<ValueTuple<bool, Color>>.GetResult
	|
	|-RVA: 0x1DEAC10 Offset: 0x1DEAD11 VA: 0x1DEAC10
	|-UniTask.Awaiter<ValueTuple<bool, double>>.GetResult
	|
	|-RVA: 0x1DEAF30 Offset: 0x1DEB031 VA: 0x1DEAF30
	|-UniTask.Awaiter<ValueTuple<bool, int>>.GetResult
	|
	|-RVA: 0x1DEB280 Offset: 0x1DEB381 VA: 0x1DEB280
	|-UniTask.Awaiter<ValueTuple<bool, long>>.GetResult
	|
	|-RVA: 0x1DEB5E0 Offset: 0x1DEB6E1 VA: 0x1DEB5E0
	|-UniTask.Awaiter<ValueTuple<bool, object>>.GetResult
	|
	|-RVA: 0x1DEBBB0 Offset: 0x1DEBCB1 VA: 0x1DEBBB0
	|-UniTask.Awaiter<ValueTuple<bool, Quaternion>>.GetResult
	|
	|-RVA: 0x1DEBF20 Offset: 0x1DEC021 VA: 0x1DEBF20
	|-UniTask.Awaiter<ValueTuple<bool, Rect>>.GetResult
	|
	|-RVA: 0x1DEC250 Offset: 0x1DEC351 VA: 0x1DEC250
	|-UniTask.Awaiter<ValueTuple<bool, float>>.GetResult
	|
	|-RVA: 0x1DEC5A0 Offset: 0x1DEC6A1 VA: 0x1DEC5A0
	|-UniTask.Awaiter<ValueTuple<bool, UniTask>>.GetResult
	|
	|-RVA: 0x1DEC8C0 Offset: 0x1DEC9C1 VA: 0x1DEC8C0
	|-UniTask.Awaiter<ValueTuple<bool, Unit>>.GetResult
	|
	|-RVA: 0x1DECC10 Offset: 0x1DECD11 VA: 0x1DECC10
	|-UniTask.Awaiter<ValueTuple<bool, Vector2>>.GetResult
	|
	|-RVA: 0x1DECF70 Offset: 0x1DED071 VA: 0x1DECF70
	|-UniTask.Awaiter<ValueTuple<bool, Vector3>>.GetResult
	|
	|-RVA: 0x1DED2D0 Offset: 0x1DED3D1 VA: 0x1DED2D0
	|-UniTask.Awaiter<ValueTuple<bool, Vector4>>.GetResult
	|
	|-RVA: 0x1DED640 Offset: 0x1DED741 VA: 0x1DED640
	|-UniTask.Awaiter<ValueTuple<int, object>>.GetResult
	|
	|-RVA: 0x1DED9A0 Offset: 0x1DEDAA1 VA: 0x1DED9A0
	|-UniTask.Awaiter<ValueTuple<object, object>>.GetResult
	|
	|-RVA: 0x1DEDD10 Offset: 0x1DEDE11 VA: 0x1DEDD10
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x1DEE090 Offset: 0x1DEE191 VA: 0x1DEE090
	|-UniTask.Awaiter<ValueTuple<object, object, object>>.GetResult
	|
	|-RVA: 0x1DEE440 Offset: 0x1DEE541 VA: 0x1DEE440
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x1DEE7E0 Offset: 0x1DEE8E1 VA: 0x1DEE7E0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object>>.GetResult
	|
	|-RVA: 0x1DEEBA0 Offset: 0x1DEECA1 VA: 0x1DEEBA0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x1DEEF50 Offset: 0x1DEF051 VA: 0x1DEEF50
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object>>.GetResult
	|
	|-RVA: 0x1DEF340 Offset: 0x1DEF441 VA: 0x1DEF340
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x1DEF730 Offset: 0x1DEF831 VA: 0x1DEF730
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object>>.GetResult
	|
	|-RVA: 0x1DEFB30 Offset: 0x1DEFC31 VA: 0x1DEFB30
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetResult
	|
	|-RVA: 0x1DEFF30 Offset: 0x1DF0031 VA: 0x1DEFF30
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object, object>>.GetResult
	|
	|-RVA: 0x1DF0360 Offset: 0x1DF0461 VA: 0x1DF0360
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DF0750 Offset: 0x1DF0851 VA: 0x1DF0750
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetResult
	|
	|-RVA: 0x1DF0A90 Offset: 0x1DF0B91 VA: 0x1DF0A90
	|-UniTask.Awaiter<AsyncUnit>.GetResult
	|
	|-RVA: 0x1DF0DA0 Offset: 0x1DF0EA1 VA: 0x1DF0DA0
	|-UniTask.Awaiter<bool>.GetResult
	|
	|-RVA: 0x1DF10F0 Offset: 0x1DF11F1 VA: 0x1DF10F0
	|-UniTask.Awaiter<Bounds>.GetResult
	|
	|-RVA: 0x1DF1420 Offset: 0x1DF1521 VA: 0x1DF1420
	|-UniTask.Awaiter<byte>.GetResult
	|
	|-RVA: 0x1DF1770 Offset: 0x1DF1871 VA: 0x1DF1770
	|-UniTask.Awaiter<Color>.GetResult
	|
	|-RVA: 0x1DF1A90 Offset: 0x1DF1B91 VA: 0x1DF1A90
	|-UniTask.Awaiter<double>.GetResult
	|
	|-RVA: 0x1DF1DA0 Offset: 0x1DF1EA1 VA: 0x1DF1DA0
	|-UniTask.Awaiter<int>.GetResult
	|
	|-RVA: 0x1DF20B0 Offset: 0x1DF21B1 VA: 0x1DF20B0
	|-UniTask.Awaiter<long>.GetResult
	|
	|-RVA: 0x1DF23C0 Offset: 0x1DF24C1 VA: 0x1DF23C0
	|-UniTask.Awaiter<object>.GetResult
	|
	|-RVA: 0x1DF2D60 Offset: 0x1DF2E61 VA: 0x1DF2D60
	|-UniTask.Awaiter<Quaternion>.GetResult
	|
	|-RVA: 0x1DF30C0 Offset: 0x1DF31C1 VA: 0x1DF30C0
	|-UniTask.Awaiter<Rect>.GetResult
	|
	|-RVA: 0x1DF33E0 Offset: 0x1DF34E1 VA: 0x1DF33E0
	|-UniTask.Awaiter<float>.GetResult
	|
	|-RVA: 0x1DF36F0 Offset: 0x1DF37F1 VA: 0x1DF36F0
	|-UniTask.Awaiter<UniTask>.GetResult
	|
	|-RVA: 0x1DF3A00 Offset: 0x1DF3B01 VA: 0x1DF3A00
	|-UniTask.Awaiter<Unit>.GetResult
	|
	|-RVA: 0x1DF3D10 Offset: 0x1DF3E11 VA: 0x1DF3D10
	|-UniTask.Awaiter<Vector2>.GetResult
	|
	|-RVA: 0x1DF4060 Offset: 0x1DF4161 VA: 0x1DF4060
	|-UniTask.Awaiter<Vector3>.GetResult
	|
	|-RVA: 0x1DF43C0 Offset: 0x1DF44C1 VA: 0x1DF43C0
	|-UniTask.Awaiter<Vector4>.GetResult
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CF50 Offset: 0x2D051 VA: 0x2CF50
	// RVA: -1 Offset: -1 Slot: 9
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5F320 Offset: 0x2F5F421 VA: 0x2F5F320
	|-UniTask.Awaiter<UniTask<object>>.OnCompleted
	|
	|-RVA: 0x2F5F690 Offset: 0x2F5F791 VA: 0x2F5F690
	|-UniTask.Awaiter<ValueTuple<bool, UniTask<object>>>.OnCompleted
	|
	|-RVA: 0x2F5FA20 Offset: 0x2F5FB21 VA: 0x2F5FA20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.OnCompleted
	|
	|-RVA: 0x2F5FDB0 Offset: 0x2F5FEB1 VA: 0x2F5FDB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.OnCompleted
	|
	|-RVA: 0x2F60180 Offset: 0x2F60281 VA: 0x2F60180
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.OnCompleted
	|
	|-RVA: 0x2F60490 Offset: 0x2F60591 VA: 0x2F60490
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.OnCompleted
	|
	|-RVA: 0x2F607A0 Offset: 0x2F608A1 VA: 0x2F607A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.OnCompleted
	|
	|-RVA: 0x2F60B70 Offset: 0x2F60C71 VA: 0x2F60B70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.OnCompleted
	|
	|-RVA: 0x2F60E80 Offset: 0x2F60F81 VA: 0x2F60E80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.OnCompleted
	|
	|-RVA: 0x2F61210 Offset: 0x2F61311 VA: 0x2F61210
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.OnCompleted
	|
	|-RVA: 0x2F615E0 Offset: 0x2F616E1 VA: 0x2F615E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.OnCompleted
	|
	|-RVA: 0x2F61950 Offset: 0x2F61A51 VA: 0x2F61950
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.OnCompleted
	|
	|-RVA: 0x2F61D20 Offset: 0x2F61E21 VA: 0x2F61D20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.OnCompleted
	|
	|-RVA: 0x2F620F0 Offset: 0x2F621F1 VA: 0x2F620F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2F62480 Offset: 0x2F62581 VA: 0x2F62480
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.OnCompleted
	|
	|-RVA: 0x2F62810 Offset: 0x2F62911 VA: 0x2F62810
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.OnCompleted
	|
	|-RVA: 0x2F62B80 Offset: 0x2F62C81 VA: 0x2F62B80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.OnCompleted
	|
	|-RVA: 0x2F62F50 Offset: 0x2F63051 VA: 0x2F62F50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.OnCompleted
	|
	|-RVA: 0x2F63260 Offset: 0x2F63361 VA: 0x2F63260
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.OnCompleted
	|
	|-RVA: 0x2F635F0 Offset: 0x2F636F1 VA: 0x2F635F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.OnCompleted
	|
	|-RVA: 0x2F63980 Offset: 0x2F63A81 VA: 0x2F63980
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.OnCompleted
	|
	|-RVA: 0x2F63D10 Offset: 0x2F63E11 VA: 0x2F63D10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.OnCompleted
	|
	|-RVA: 0x2F640E0 Offset: 0x2F641E1 VA: 0x2F640E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2F644B0 Offset: 0x2F645B1 VA: 0x2F644B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2F64880 Offset: 0x2F64981 VA: 0x2F64880
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x2F64C60 Offset: 0x2F64D61 VA: 0x2F64C60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DD4760 Offset: 0x1DD4861 VA: 0x1DD4760
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DD4B80 Offset: 0x1DD4C81 VA: 0x1DD4B80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DD4FA0 Offset: 0x1DD50A1 VA: 0x1DD4FA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DD52B0 Offset: 0x1DD53B1 VA: 0x1DD52B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.OnCompleted
	|
	|-RVA: 0x1DD55C0 Offset: 0x1DD56C1 VA: 0x1DD55C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.OnCompleted
	|
	|-RVA: 0x1DD5950 Offset: 0x1DD5A51 VA: 0x1DD5950
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.OnCompleted
	|
	|-RVA: 0x1DD5C60 Offset: 0x1DD5D61 VA: 0x1DD5C60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.OnCompleted
	|
	|-RVA: 0x1DD5FF0 Offset: 0x1DD60F1 VA: 0x1DD5FF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.OnCompleted
	|
	|-RVA: 0x1DD6380 Offset: 0x1DD6481 VA: 0x1DD6380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.OnCompleted
	|
	|-RVA: 0x1DD66F0 Offset: 0x1DD67F1 VA: 0x1DD66F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.OnCompleted
	|
	|-RVA: 0x1DD6A80 Offset: 0x1DD6B81 VA: 0x1DD6A80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.OnCompleted
	|
	|-RVA: 0x1DD6E10 Offset: 0x1DD6F11 VA: 0x1DD6E10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DD71A0 Offset: 0x1DD72A1 VA: 0x1DD71A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.OnCompleted
	|
	|-RVA: 0x1DD7530 Offset: 0x1DD7631 VA: 0x1DD7530
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.OnCompleted
	|
	|-RVA: 0x1DD78A0 Offset: 0x1DD79A1 VA: 0x1DD78A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.OnCompleted
	|
	|-RVA: 0x1DD7C30 Offset: 0x1DD7D31 VA: 0x1DD7C30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.OnCompleted
	|
	|-RVA: 0x1DD7F40 Offset: 0x1DD8041 VA: 0x1DD7F40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.OnCompleted
	|
	|-RVA: 0x1DD82B0 Offset: 0x1DD83B1 VA: 0x1DD82B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.OnCompleted
	|
	|-RVA: 0x1DD8640 Offset: 0x1DD8741 VA: 0x1DD8640
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.OnCompleted
	|
	|-RVA: 0x1DD89D0 Offset: 0x1DD8AD1 VA: 0x1DD89D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.OnCompleted
	|
	|-RVA: 0x1DD8D60 Offset: 0x1DD8E61 VA: 0x1DD8D60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DD90F0 Offset: 0x1DD91F1 VA: 0x1DD90F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DD94D0 Offset: 0x1DD95D1 VA: 0x1DD94D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DD98A0 Offset: 0x1DD99A1 VA: 0x1DD98A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DD9CC0 Offset: 0x1DD9DC1 VA: 0x1DD9CC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DDA090 Offset: 0x1DDA191 VA: 0x1DDA090
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DDA4C0 Offset: 0x1DDA5C1 VA: 0x1DDA4C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DDA8A0 Offset: 0x1DDA9A1 VA: 0x1DDA8A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DDAD10 Offset: 0x1DDAE11 VA: 0x1DDAD10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DDB0F0 Offset: 0x1DDB1F1 VA: 0x1DDB0F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DDB4B0 Offset: 0x1DDB5B1 VA: 0x1DDB4B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DDB8D0 Offset: 0x1DDB9D1 VA: 0x1DDB8D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DDBBE0 Offset: 0x1DDBCE1 VA: 0x1DDBBE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.OnCompleted
	|
	|-RVA: 0x1DDBEF0 Offset: 0x1DDBFF1 VA: 0x1DDBEF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.OnCompleted
	|
	|-RVA: 0x1DDC280 Offset: 0x1DDC381 VA: 0x1DDC280
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.OnCompleted
	|
	|-RVA: 0x1DDC590 Offset: 0x1DDC691 VA: 0x1DDC590
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.OnCompleted
	|
	|-RVA: 0x1DDC920 Offset: 0x1DDCA21 VA: 0x1DDC920
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.OnCompleted
	|
	|-RVA: 0x1DDCCB0 Offset: 0x1DDCDB1 VA: 0x1DDCCB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.OnCompleted
	|
	|-RVA: 0x1DDD010 Offset: 0x1DDD111 VA: 0x1DDD010
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.OnCompleted
	|
	|-RVA: 0x1DDD3A0 Offset: 0x1DDD4A1 VA: 0x1DDD3A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.OnCompleted
	|
	|-RVA: 0x1DDD730 Offset: 0x1DDD831 VA: 0x1DDD730
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DDDAC0 Offset: 0x1DDDBC1 VA: 0x1DDDAC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.OnCompleted
	|
	|-RVA: 0x1DDDE50 Offset: 0x1DDDF51 VA: 0x1DDDE50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.OnCompleted
	|
	|-RVA: 0x1DDE1B0 Offset: 0x1DDE2B1 VA: 0x1DDE1B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.OnCompleted
	|
	|-RVA: 0x1DDE540 Offset: 0x1DDE641 VA: 0x1DDE540
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.OnCompleted
	|
	|-RVA: 0x1DDE850 Offset: 0x1DDE951 VA: 0x1DDE850
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.OnCompleted
	|
	|-RVA: 0x1DDEBC0 Offset: 0x1DDECC1 VA: 0x1DDEBC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.OnCompleted
	|
	|-RVA: 0x1DDEF30 Offset: 0x1DDF031 VA: 0x1DDEF30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.OnCompleted
	|
	|-RVA: 0x1DDF2C0 Offset: 0x1DDF3C1 VA: 0x1DDF2C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.OnCompleted
	|
	|-RVA: 0x1DDF650 Offset: 0x1DDF751 VA: 0x1DDF650
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.OnCompleted
	|
	|-RVA: 0x1DDF9E0 Offset: 0x1DDFAE1 VA: 0x1DDF9E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.OnCompleted
	|
	|-RVA: 0x1DDFDB0 Offset: 0x1DDFEB1 VA: 0x1DDFDB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DE0140 Offset: 0x1DE0241 VA: 0x1DE0140
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE0520 Offset: 0x1DE0621 VA: 0x1DE0520
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DE08F0 Offset: 0x1DE09F1 VA: 0x1DE08F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE0D10 Offset: 0x1DE0E11 VA: 0x1DE0D10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DE10E0 Offset: 0x1DE11E1 VA: 0x1DE10E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE1510 Offset: 0x1DE1611 VA: 0x1DE1510
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DE18F0 Offset: 0x1DE19F1 VA: 0x1DE18F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE1D70 Offset: 0x1DE1E71 VA: 0x1DE1D70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DE2150 Offset: 0x1DE2251 VA: 0x1DE2150
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE24E0 Offset: 0x1DE25E1 VA: 0x1DE24E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DE2870 Offset: 0x1DE2971 VA: 0x1DE2870
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.OnCompleted
	|
	|-RVA: 0x1DE2B80 Offset: 0x1DE2C81 VA: 0x1DE2B80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.OnCompleted
	|
	|-RVA: 0x1DE2E90 Offset: 0x1DE2F91 VA: 0x1DE2E90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.OnCompleted
	|
	|-RVA: 0x1DE3220 Offset: 0x1DE3321 VA: 0x1DE3220
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.OnCompleted
	|
	|-RVA: 0x1DE3530 Offset: 0x1DE3631 VA: 0x1DE3530
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.OnCompleted
	|
	|-RVA: 0x1DE38A0 Offset: 0x1DE39A1 VA: 0x1DE38A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.OnCompleted
	|
	|-RVA: 0x1DE3C10 Offset: 0x1DE3D11 VA: 0x1DE3C10
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, double>>>.OnCompleted
	|
	|-RVA: 0x1DE3F70 Offset: 0x1DE4071 VA: 0x1DE3F70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, int>>>.OnCompleted
	|
	|-RVA: 0x1DE42E0 Offset: 0x1DE43E1 VA: 0x1DE42E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, long>>>.OnCompleted
	|
	|-RVA: 0x1DE4650 Offset: 0x1DE4751 VA: 0x1DE4650
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x1DE49C0 Offset: 0x1DE4AC1 VA: 0x1DE49C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.OnCompleted
	|
	|-RVA: 0x1DE4D30 Offset: 0x1DE4E31 VA: 0x1DE4D30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.OnCompleted
	|
	|-RVA: 0x1DE5090 Offset: 0x1DE5191 VA: 0x1DE5090
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, float>>>.OnCompleted
	|
	|-RVA: 0x1DE5400 Offset: 0x1DE5501 VA: 0x1DE5400
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.OnCompleted
	|
	|-RVA: 0x1DE5710 Offset: 0x1DE5811 VA: 0x1DE5710
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.OnCompleted
	|
	|-RVA: 0x1DE5A70 Offset: 0x1DE5B71 VA: 0x1DE5A70
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.OnCompleted
	|
	|-RVA: 0x1DE5DE0 Offset: 0x1DE5EE1 VA: 0x1DE5DE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.OnCompleted
	|
	|-RVA: 0x1DE6150 Offset: 0x1DE6251 VA: 0x1DE6150
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.OnCompleted
	|
	|-RVA: 0x1DE64C0 Offset: 0x1DE65C1 VA: 0x1DE64C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, object>>>.OnCompleted
	|
	|-RVA: 0x1DE6830 Offset: 0x1DE6931 VA: 0x1DE6830
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object>>>.OnCompleted
	|
	|-RVA: 0x1DE6C00 Offset: 0x1DE6D01 VA: 0x1DE6C00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE6F90 Offset: 0x1DE7091 VA: 0x1DE6F90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.OnCompleted
	|
	|-RVA: 0x1DE7370 Offset: 0x1DE7471 VA: 0x1DE7370
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE7700 Offset: 0x1DE7801 VA: 0x1DE7700
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x1DE7B20 Offset: 0x1DE7C21 VA: 0x1DE7B20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE7EF0 Offset: 0x1DE7FF1 VA: 0x1DE7EF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x1DE8320 Offset: 0x1DE8421 VA: 0x1DE8320
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE86F0 Offset: 0x1DE87F1 VA: 0x1DE86F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x1DE8B60 Offset: 0x1DE8C61 VA: 0x1DE8B60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DE8F40 Offset: 0x1DE9041 VA: 0x1DE8F40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.OnCompleted
	|
	|-RVA: 0x1DE9300 Offset: 0x1DE9401 VA: 0x1DE9300
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DE9690 Offset: 0x1DE9791 VA: 0x1DE9690
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.OnCompleted
	|
	|-RVA: 0x1DE99A0 Offset: 0x1DE9AA1 VA: 0x1DE99A0
	|-UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>.OnCompleted
	|
	|-RVA: 0x1DE9F00 Offset: 0x1DEA001 VA: 0x1DE9F00
	|-UniTask.Awaiter<ValueTuple<bool, bool>>.OnCompleted
	|
	|-RVA: 0x1DEA290 Offset: 0x1DEA391 VA: 0x1DEA290
	|-UniTask.Awaiter<ValueTuple<bool, Bounds>>.OnCompleted
	|
	|-RVA: 0x1DEA5A0 Offset: 0x1DEA6A1 VA: 0x1DEA5A0
	|-UniTask.Awaiter<ValueTuple<bool, byte>>.OnCompleted
	|
	|-RVA: 0x1DEA910 Offset: 0x1DEAA11 VA: 0x1DEA910
	|-UniTask.Awaiter<ValueTuple<bool, Color>>.OnCompleted
	|
	|-RVA: 0x1DEAC70 Offset: 0x1DEAD71 VA: 0x1DEAC70
	|-UniTask.Awaiter<ValueTuple<bool, double>>.OnCompleted
	|
	|-RVA: 0x1DEAF80 Offset: 0x1DEB081 VA: 0x1DEAF80
	|-UniTask.Awaiter<ValueTuple<bool, int>>.OnCompleted
	|
	|-RVA: 0x1DEB2E0 Offset: 0x1DEB3E1 VA: 0x1DEB2E0
	|-UniTask.Awaiter<ValueTuple<bool, long>>.OnCompleted
	|
	|-RVA: 0x1DEB640 Offset: 0x1DEB741 VA: 0x1DEB640
	|-UniTask.Awaiter<ValueTuple<bool, object>>.OnCompleted
	|
	|-RVA: 0x1DEBC20 Offset: 0x1DEBD21 VA: 0x1DEBC20
	|-UniTask.Awaiter<ValueTuple<bool, Quaternion>>.OnCompleted
	|
	|-RVA: 0x1DEBF90 Offset: 0x1DEC091 VA: 0x1DEBF90
	|-UniTask.Awaiter<ValueTuple<bool, Rect>>.OnCompleted
	|
	|-RVA: 0x1DEC2A0 Offset: 0x1DEC3A1 VA: 0x1DEC2A0
	|-UniTask.Awaiter<ValueTuple<bool, float>>.OnCompleted
	|
	|-RVA: 0x1DEC600 Offset: 0x1DEC701 VA: 0x1DEC600
	|-UniTask.Awaiter<ValueTuple<bool, UniTask>>.OnCompleted
	|
	|-RVA: 0x1DEC910 Offset: 0x1DECA11 VA: 0x1DEC910
	|-UniTask.Awaiter<ValueTuple<bool, Unit>>.OnCompleted
	|
	|-RVA: 0x1DECC70 Offset: 0x1DECD71 VA: 0x1DECC70
	|-UniTask.Awaiter<ValueTuple<bool, Vector2>>.OnCompleted
	|
	|-RVA: 0x1DECFD0 Offset: 0x1DED0D1 VA: 0x1DECFD0
	|-UniTask.Awaiter<ValueTuple<bool, Vector3>>.OnCompleted
	|
	|-RVA: 0x1DED340 Offset: 0x1DED441 VA: 0x1DED340
	|-UniTask.Awaiter<ValueTuple<bool, Vector4>>.OnCompleted
	|
	|-RVA: 0x1DED6A0 Offset: 0x1DED7A1 VA: 0x1DED6A0
	|-UniTask.Awaiter<ValueTuple<int, object>>.OnCompleted
	|
	|-RVA: 0x1DEDA00 Offset: 0x1DEDB01 VA: 0x1DEDA00
	|-UniTask.Awaiter<ValueTuple<object, object>>.OnCompleted
	|
	|-RVA: 0x1DEDD90 Offset: 0x1DEDE91 VA: 0x1DEDD90
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x1DEE100 Offset: 0x1DEE201 VA: 0x1DEE100
	|-UniTask.Awaiter<ValueTuple<object, object, object>>.OnCompleted
	|
	|-RVA: 0x1DEE4D0 Offset: 0x1DEE5D1 VA: 0x1DEE4D0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x1DEE860 Offset: 0x1DEE961 VA: 0x1DEE860
	|-UniTask.Awaiter<ValueTuple<object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x1DEEC40 Offset: 0x1DEED41 VA: 0x1DEEC40
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x1DEEFD0 Offset: 0x1DEF0D1 VA: 0x1DEEFD0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x1DEF3F0 Offset: 0x1DEF4F1 VA: 0x1DEF3F0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x1DEF7C0 Offset: 0x1DEF8C1 VA: 0x1DEF7C0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x1DEFBF0 Offset: 0x1DEFCF1 VA: 0x1DEFBF0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.OnCompleted
	|
	|-RVA: 0x1DEFFC0 Offset: 0x1DF00C1 VA: 0x1DEFFC0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object, object>>.OnCompleted
	|
	|-RVA: 0x1DF0440 Offset: 0x1DF0541 VA: 0x1DF0440
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DF07D0 Offset: 0x1DF08D1 VA: 0x1DF07D0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.OnCompleted
	|
	|-RVA: 0x1DF0AE0 Offset: 0x1DF0BE1 VA: 0x1DF0AE0
	|-UniTask.Awaiter<AsyncUnit>.OnCompleted
	|
	|-RVA: 0x1DF0DF0 Offset: 0x1DF0EF1 VA: 0x1DF0DF0
	|-UniTask.Awaiter<bool>.OnCompleted
	|
	|-RVA: 0x1DF1160 Offset: 0x1DF1261 VA: 0x1DF1160
	|-UniTask.Awaiter<Bounds>.OnCompleted
	|
	|-RVA: 0x1DF1470 Offset: 0x1DF1571 VA: 0x1DF1470
	|-UniTask.Awaiter<byte>.OnCompleted
	|
	|-RVA: 0x1DF17D0 Offset: 0x1DF18D1 VA: 0x1DF17D0
	|-UniTask.Awaiter<Color>.OnCompleted
	|
	|-RVA: 0x1DF1AE0 Offset: 0x1DF1BE1 VA: 0x1DF1AE0
	|-UniTask.Awaiter<double>.OnCompleted
	|
	|-RVA: 0x1DF1DF0 Offset: 0x1DF1EF1 VA: 0x1DF1DF0
	|-UniTask.Awaiter<int>.OnCompleted
	|
	|-RVA: 0x1DF2100 Offset: 0x1DF2201 VA: 0x1DF2100
	|-UniTask.Awaiter<long>.OnCompleted
	|
	|-RVA: 0x1DF2410 Offset: 0x1DF2511 VA: 0x1DF2410
	|-UniTask.Awaiter<object>.OnCompleted
	|
	|-RVA: 0x1DF2DC0 Offset: 0x1DF2EC1 VA: 0x1DF2DC0
	|-UniTask.Awaiter<Quaternion>.OnCompleted
	|
	|-RVA: 0x1DF3120 Offset: 0x1DF3221 VA: 0x1DF3120
	|-UniTask.Awaiter<Rect>.OnCompleted
	|
	|-RVA: 0x1DF3430 Offset: 0x1DF3531 VA: 0x1DF3430
	|-UniTask.Awaiter<float>.OnCompleted
	|
	|-RVA: 0x1DF3740 Offset: 0x1DF3841 VA: 0x1DF3740
	|-UniTask.Awaiter<UniTask>.OnCompleted
	|
	|-RVA: 0x1DF3A50 Offset: 0x1DF3B51 VA: 0x1DF3A50
	|-UniTask.Awaiter<Unit>.OnCompleted
	|
	|-RVA: 0x1DF3D60 Offset: 0x1DF3E61 VA: 0x1DF3D60
	|-UniTask.Awaiter<Vector2>.OnCompleted
	|
	|-RVA: 0x1DF40C0 Offset: 0x1DF41C1 VA: 0x1DF40C0
	|-UniTask.Awaiter<Vector3>.OnCompleted
	|
	|-RVA: 0x1DF4420 Offset: 0x1DF4521 VA: 0x1DF4420
	|-UniTask.Awaiter<Vector4>.OnCompleted
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CF60 Offset: 0x2D061 VA: 0x2CF60
	// RVA: -1 Offset: -1 Slot: 8
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5F3F0 Offset: 0x2F5F4F1 VA: 0x2F5F3F0
	|-UniTask.Awaiter<UniTask<object>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F5F760 Offset: 0x2F5F861 VA: 0x2F5F760
	|-UniTask.Awaiter<ValueTuple<bool, UniTask<object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F5FAF0 Offset: 0x2F5FBF1 VA: 0x2F5FAF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F5FE80 Offset: 0x2F5FF81 VA: 0x2F5FE80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F60250 Offset: 0x2F60351 VA: 0x2F60250
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F60560 Offset: 0x2F60661 VA: 0x2F60560
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F60870 Offset: 0x2F60971 VA: 0x2F60870
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F60C40 Offset: 0x2F60D41 VA: 0x2F60C40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F60F50 Offset: 0x2F61051 VA: 0x2F60F50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F612E0 Offset: 0x2F613E1 VA: 0x2F612E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F616B0 Offset: 0x2F617B1 VA: 0x2F616B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F61A20 Offset: 0x2F61B21 VA: 0x2F61A20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F61DF0 Offset: 0x2F61EF1 VA: 0x2F61DF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F621C0 Offset: 0x2F622C1 VA: 0x2F621C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F62550 Offset: 0x2F62651 VA: 0x2F62550
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F628E0 Offset: 0x2F629E1 VA: 0x2F628E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F62C50 Offset: 0x2F62D51 VA: 0x2F62C50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F63020 Offset: 0x2F63121 VA: 0x2F63020
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F63330 Offset: 0x2F63431 VA: 0x2F63330
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F636C0 Offset: 0x2F637C1 VA: 0x2F636C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F63A50 Offset: 0x2F63B51 VA: 0x2F63A50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F63DE0 Offset: 0x2F63EE1 VA: 0x2F63DE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F641B0 Offset: 0x2F642B1 VA: 0x2F641B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F64580 Offset: 0x2F64681 VA: 0x2F64580
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F64950 Offset: 0x2F64A51 VA: 0x2F64950
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x2F64D30 Offset: 0x2F64E31 VA: 0x2F64D30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD4830 Offset: 0x1DD4931 VA: 0x1DD4830
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD4C50 Offset: 0x1DD4D51 VA: 0x1DD4C50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD5070 Offset: 0x1DD5171 VA: 0x1DD5070
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD5380 Offset: 0x1DD5481 VA: 0x1DD5380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD5690 Offset: 0x1DD5791 VA: 0x1DD5690
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD5A20 Offset: 0x1DD5B21 VA: 0x1DD5A20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD5D30 Offset: 0x1DD5E31 VA: 0x1DD5D30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD60C0 Offset: 0x1DD61C1 VA: 0x1DD60C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD6450 Offset: 0x1DD6551 VA: 0x1DD6450
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD67C0 Offset: 0x1DD68C1 VA: 0x1DD67C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD6B50 Offset: 0x1DD6C51 VA: 0x1DD6B50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD6EE0 Offset: 0x1DD6FE1 VA: 0x1DD6EE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD7270 Offset: 0x1DD7371 VA: 0x1DD7270
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD7600 Offset: 0x1DD7701 VA: 0x1DD7600
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD7970 Offset: 0x1DD7A71 VA: 0x1DD7970
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD7D00 Offset: 0x1DD7E01 VA: 0x1DD7D00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD8010 Offset: 0x1DD8111 VA: 0x1DD8010
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD8380 Offset: 0x1DD8481 VA: 0x1DD8380
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD8710 Offset: 0x1DD8811 VA: 0x1DD8710
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD8AA0 Offset: 0x1DD8BA1 VA: 0x1DD8AA0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD8E30 Offset: 0x1DD8F31 VA: 0x1DD8E30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD91C0 Offset: 0x1DD92C1 VA: 0x1DD91C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD95A0 Offset: 0x1DD96A1 VA: 0x1DD95A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD9970 Offset: 0x1DD9A71 VA: 0x1DD9970
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DD9D90 Offset: 0x1DD9E91 VA: 0x1DD9D90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDA160 Offset: 0x1DDA261 VA: 0x1DDA160
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDA590 Offset: 0x1DDA691 VA: 0x1DDA590
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDA970 Offset: 0x1DDAA71 VA: 0x1DDA970
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDADE0 Offset: 0x1DDAEE1 VA: 0x1DDADE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDB1C0 Offset: 0x1DDB2C1 VA: 0x1DDB1C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDB580 Offset: 0x1DDB681 VA: 0x1DDB580
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDB9A0 Offset: 0x1DDBAA1 VA: 0x1DDB9A0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDBCB0 Offset: 0x1DDBDB1 VA: 0x1DDBCB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDBFC0 Offset: 0x1DDC0C1 VA: 0x1DDBFC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDC350 Offset: 0x1DDC451 VA: 0x1DDC350
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDC660 Offset: 0x1DDC761 VA: 0x1DDC660
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDC9F0 Offset: 0x1DDCAF1 VA: 0x1DDC9F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDCD80 Offset: 0x1DDCE81 VA: 0x1DDCD80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDD0E0 Offset: 0x1DDD1E1 VA: 0x1DDD0E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDD470 Offset: 0x1DDD571 VA: 0x1DDD470
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDD800 Offset: 0x1DDD901 VA: 0x1DDD800
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDDB90 Offset: 0x1DDDC91 VA: 0x1DDDB90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDDF20 Offset: 0x1DDE021 VA: 0x1DDDF20
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDE280 Offset: 0x1DDE381 VA: 0x1DDE280
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDE610 Offset: 0x1DDE711 VA: 0x1DDE610
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDE920 Offset: 0x1DDEA21 VA: 0x1DDE920
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDEC90 Offset: 0x1DDED91 VA: 0x1DDEC90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDF000 Offset: 0x1DDF101 VA: 0x1DDF000
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDF390 Offset: 0x1DDF491 VA: 0x1DDF390
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDF720 Offset: 0x1DDF821 VA: 0x1DDF720
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDFAB0 Offset: 0x1DDFBB1 VA: 0x1DDFAB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DDFE80 Offset: 0x1DDFF81 VA: 0x1DDFE80
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE0210 Offset: 0x1DE0311 VA: 0x1DE0210
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE05F0 Offset: 0x1DE06F1 VA: 0x1DE05F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE09C0 Offset: 0x1DE0AC1 VA: 0x1DE09C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE0DE0 Offset: 0x1DE0EE1 VA: 0x1DE0DE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE11B0 Offset: 0x1DE12B1 VA: 0x1DE11B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE15E0 Offset: 0x1DE16E1 VA: 0x1DE15E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE19C0 Offset: 0x1DE1AC1 VA: 0x1DE19C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE1E40 Offset: 0x1DE1F41 VA: 0x1DE1E40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE2220 Offset: 0x1DE2321 VA: 0x1DE2220
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE25B0 Offset: 0x1DE26B1 VA: 0x1DE25B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE2940 Offset: 0x1DE2A41 VA: 0x1DE2940
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE2C50 Offset: 0x1DE2D51 VA: 0x1DE2C50
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE2F60 Offset: 0x1DE3061 VA: 0x1DE2F60
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, bool>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE32F0 Offset: 0x1DE33F1 VA: 0x1DE32F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Bounds>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE3600 Offset: 0x1DE3701 VA: 0x1DE3600
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, byte>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE3970 Offset: 0x1DE3A71 VA: 0x1DE3970
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Color>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE3CE0 Offset: 0x1DE3DE1 VA: 0x1DE3CE0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, double>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE4040 Offset: 0x1DE4141 VA: 0x1DE4040
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, int>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE43B0 Offset: 0x1DE44B1 VA: 0x1DE43B0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, long>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE4720 Offset: 0x1DE4821 VA: 0x1DE4720
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE4A90 Offset: 0x1DE4B91 VA: 0x1DE4A90
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE4E00 Offset: 0x1DE4F01 VA: 0x1DE4E00
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Rect>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE5160 Offset: 0x1DE5261 VA: 0x1DE5160
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, float>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE54D0 Offset: 0x1DE55D1 VA: 0x1DE54D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, UniTask>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE57E0 Offset: 0x1DE58E1 VA: 0x1DE57E0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Unit>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE5B40 Offset: 0x1DE5C41 VA: 0x1DE5B40
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector2>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE5EB0 Offset: 0x1DE5FB1 VA: 0x1DE5EB0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector3>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE6220 Offset: 0x1DE6321 VA: 0x1DE6220
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<bool, Vector4>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE6590 Offset: 0x1DE6691 VA: 0x1DE6590
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE6900 Offset: 0x1DE6A01 VA: 0x1DE6900
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE6CD0 Offset: 0x1DE6DD1 VA: 0x1DE6CD0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE7060 Offset: 0x1DE7161 VA: 0x1DE7060
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE7440 Offset: 0x1DE7541 VA: 0x1DE7440
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE77D0 Offset: 0x1DE78D1 VA: 0x1DE77D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE7BF0 Offset: 0x1DE7CF1 VA: 0x1DE7BF0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE7FC0 Offset: 0x1DE80C1 VA: 0x1DE7FC0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE83F0 Offset: 0x1DE84F1 VA: 0x1DE83F0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE87C0 Offset: 0x1DE88C1 VA: 0x1DE87C0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE8C30 Offset: 0x1DE8D31 VA: 0x1DE8C30
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE9010 Offset: 0x1DE9111 VA: 0x1DE9010
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE93D0 Offset: 0x1DE94D1 VA: 0x1DE93D0
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE9760 Offset: 0x1DE9861 VA: 0x1DE9760
	|-UniTask.Awaiter<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE9A70 Offset: 0x1DE9B71 VA: 0x1DE9A70
	|-UniTask.Awaiter<ValueTuple<bool, AsyncUnit>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DE9FD0 Offset: 0x1DEA0D1 VA: 0x1DE9FD0
	|-UniTask.Awaiter<ValueTuple<bool, bool>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEA360 Offset: 0x1DEA461 VA: 0x1DEA360
	|-UniTask.Awaiter<ValueTuple<bool, Bounds>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEA670 Offset: 0x1DEA771 VA: 0x1DEA670
	|-UniTask.Awaiter<ValueTuple<bool, byte>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEA9E0 Offset: 0x1DEAAE1 VA: 0x1DEA9E0
	|-UniTask.Awaiter<ValueTuple<bool, Color>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEAD40 Offset: 0x1DEAE41 VA: 0x1DEAD40
	|-UniTask.Awaiter<ValueTuple<bool, double>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEB050 Offset: 0x1DEB151 VA: 0x1DEB050
	|-UniTask.Awaiter<ValueTuple<bool, int>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEB3B0 Offset: 0x1DEB4B1 VA: 0x1DEB3B0
	|-UniTask.Awaiter<ValueTuple<bool, long>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEB710 Offset: 0x1DEB811 VA: 0x1DEB710
	|-UniTask.Awaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEBCF0 Offset: 0x1DEBDF1 VA: 0x1DEBCF0
	|-UniTask.Awaiter<ValueTuple<bool, Quaternion>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEC060 Offset: 0x1DEC161 VA: 0x1DEC060
	|-UniTask.Awaiter<ValueTuple<bool, Rect>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEC370 Offset: 0x1DEC471 VA: 0x1DEC370
	|-UniTask.Awaiter<ValueTuple<bool, float>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEC6D0 Offset: 0x1DEC7D1 VA: 0x1DEC6D0
	|-UniTask.Awaiter<ValueTuple<bool, UniTask>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEC9E0 Offset: 0x1DECAE1 VA: 0x1DEC9E0
	|-UniTask.Awaiter<ValueTuple<bool, Unit>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DECD40 Offset: 0x1DECE41 VA: 0x1DECD40
	|-UniTask.Awaiter<ValueTuple<bool, Vector2>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DED0A0 Offset: 0x1DED1A1 VA: 0x1DED0A0
	|-UniTask.Awaiter<ValueTuple<bool, Vector3>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DED410 Offset: 0x1DED511 VA: 0x1DED410
	|-UniTask.Awaiter<ValueTuple<bool, Vector4>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DED770 Offset: 0x1DED871 VA: 0x1DED770
	|-UniTask.Awaiter<ValueTuple<int, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEDAD0 Offset: 0x1DEDBD1 VA: 0x1DEDAD0
	|-UniTask.Awaiter<ValueTuple<object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEDE60 Offset: 0x1DEDF61 VA: 0x1DEDE60
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEE1D0 Offset: 0x1DEE2D1 VA: 0x1DEE1D0
	|-UniTask.Awaiter<ValueTuple<object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEE5A0 Offset: 0x1DEE6A1 VA: 0x1DEE5A0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEE930 Offset: 0x1DEEA31 VA: 0x1DEE930
	|-UniTask.Awaiter<ValueTuple<object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEED10 Offset: 0x1DEEE11 VA: 0x1DEED10
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEF0A0 Offset: 0x1DEF1A1 VA: 0x1DEF0A0
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEF4C0 Offset: 0x1DEF5C1 VA: 0x1DEF4C0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEF890 Offset: 0x1DEF991 VA: 0x1DEF890
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DEFCC0 Offset: 0x1DEFDC1 VA: 0x1DEFCC0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF0090 Offset: 0x1DF0191 VA: 0x1DF0090
	|-UniTask.Awaiter<ValueTuple<object, object, object, object, object, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF0510 Offset: 0x1DF0611 VA: 0x1DF0510
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF08A0 Offset: 0x1DF09A1 VA: 0x1DF08A0
	|-UniTask.Awaiter<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF0BB0 Offset: 0x1DF0CB1 VA: 0x1DF0BB0
	|-UniTask.Awaiter<AsyncUnit>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF0EC0 Offset: 0x1DF0FC1 VA: 0x1DF0EC0
	|-UniTask.Awaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF1230 Offset: 0x1DF1331 VA: 0x1DF1230
	|-UniTask.Awaiter<Bounds>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF1540 Offset: 0x1DF1641 VA: 0x1DF1540
	|-UniTask.Awaiter<byte>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF18A0 Offset: 0x1DF19A1 VA: 0x1DF18A0
	|-UniTask.Awaiter<Color>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF1BB0 Offset: 0x1DF1CB1 VA: 0x1DF1BB0
	|-UniTask.Awaiter<double>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF1EC0 Offset: 0x1DF1FC1 VA: 0x1DF1EC0
	|-UniTask.Awaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF21D0 Offset: 0x1DF22D1 VA: 0x1DF21D0
	|-UniTask.Awaiter<long>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF24E0 Offset: 0x1DF25E1 VA: 0x1DF24E0
	|-UniTask.Awaiter<object>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF2E90 Offset: 0x1DF2F91 VA: 0x1DF2E90
	|-UniTask.Awaiter<Quaternion>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF31F0 Offset: 0x1DF32F1 VA: 0x1DF31F0
	|-UniTask.Awaiter<Rect>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF3500 Offset: 0x1DF3601 VA: 0x1DF3500
	|-UniTask.Awaiter<float>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF3810 Offset: 0x1DF3911 VA: 0x1DF3810
	|-UniTask.Awaiter<UniTask>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF3B20 Offset: 0x1DF3C21 VA: 0x1DF3B20
	|-UniTask.Awaiter<Unit>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF3E30 Offset: 0x1DF3F31 VA: 0x1DF3E30
	|-UniTask.Awaiter<Vector2>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF4190 Offset: 0x1DF4291 VA: 0x1DF4190
	|-UniTask.Awaiter<Vector3>.UnsafeOnCompleted
	|
	|-RVA: 0x1DF44F0 Offset: 0x1DF45F1 VA: 0x1DF44F0
	|-UniTask.Awaiter<Vector4>.UnsafeOnCompleted
	*/
}

