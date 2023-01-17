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

