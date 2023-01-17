// Namespace: UniRx.Async
[AsyncMethodBuilderAttribute] // RVA: 0x27970 Offset: 0x27A71 VA: 0x27970
public struct UniTask : IEquatable<UniTask> // TypeDefIndex: 5084
{
	// Fields
	private static readonly UniTask CanceledUniTask; // 0x0
	private static readonly UniTask<AsyncUnit> DefaultAsyncUnitTask; // 0x8
	private readonly IAwaiter awaiter; // 0x0

	// Properties
	public static UniTask CompletedTask { get; }
	[DebuggerHiddenAttribute] // RVA: 0x2F280 Offset: 0x2F381 VA: 0x2F280
	public AwaiterStatus Status { get; }
	[DebuggerHiddenAttribute] // RVA: 0x2F290 Offset: 0x2F391 VA: 0x2F290
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x2E865D0 Offset: 0x2E866D1 VA: 0x2E865D0
	public static IEnumerator ToCoroutine(Func<UniTask> taskFactory) { }

	// RVA: 0x2E866F0 Offset: 0x2E867F1 VA: 0x2E866F0
	public static YieldAwaitable Yield(PlayerLoopTiming timing = 4) { }

	// RVA: 0x2E86700 Offset: 0x2E86801 VA: 0x2E86700
	public static UniTask Yield(PlayerLoopTiming timing, CancellationToken cancellationToken) { }

	// RVA: 0x2E86790 Offset: 0x2E86891 VA: 0x2E86790
	public static UniTask<int> DelayFrame(int delayFrameCount, PlayerLoopTiming delayTiming = 4, CancellationToken cancellationToken) { }

	// RVA: 0x2E7F380 Offset: 0x2E7F481 VA: 0x2E7F380
	public static UniTask Delay(int millisecondsDelay, bool ignoreTimeScale = False, PlayerLoopTiming delayTiming = 4, CancellationToken cancellationToken) { }

	// RVA: 0x2E7F740 Offset: 0x2E7F841 VA: 0x2E7F740
	public static UniTask Delay(TimeSpan delayTimeSpan, bool ignoreTimeScale = False, PlayerLoopTiming delayTiming = 4, CancellationToken cancellationToken) { }

	// RVA: 0x2E72750 Offset: 0x2E72851 VA: 0x2E72750
	public static UniTask get_CompletedTask() { }

	// RVA: 0x2E868A0 Offset: 0x2E869A1 VA: 0x2E868A0
	public static UniTask FromException(Exception ex) { }

	// RVA: -1 Offset: -1
	public static UniTask<T> FromException<T>(Exception ex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2029380 Offset: 0x2029481 VA: 0x2029380
	|-UniTask.FromException<object>
	*/

	// RVA: -1 Offset: -1
	public static UniTask<T> FromResult<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2029420 Offset: 0x2029521 VA: 0x2029420
	|-UniTask.FromResult<bool>
	|
	|-RVA: 0x2029460 Offset: 0x2029561 VA: 0x2029460
	|-UniTask.FromResult<int>
	|
	|-RVA: 0x20294A0 Offset: 0x20295A1 VA: 0x20294A0
	|-UniTask.FromResult<object>
	*/

	// RVA: 0x2E86960 Offset: 0x2E86A61 VA: 0x2E86960
	public static UniTask FromCanceled() { }

	// RVA: -1 Offset: -1
	public static UniTask<T> FromCanceled<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2028FE0 Offset: 0x20290E1 VA: 0x2028FE0
	|-UniTask.FromCanceled<AsyncUnit>
	|
	|-RVA: 0x2029090 Offset: 0x2029191 VA: 0x2029090
	|-UniTask.FromCanceled<int>
	|
	|-RVA: 0x2029140 Offset: 0x2029241 VA: 0x2029140
	|-UniTask.FromCanceled<object>
	|
	|-RVA: 0x20291F0 Offset: 0x20292F1 VA: 0x20291F0
	|-UniTask.FromCanceled<float>
	*/

	// RVA: 0x2E7ECA0 Offset: 0x2E7EDA1 VA: 0x2E7ECA0
	public static UniTask FromCanceled(CancellationToken token) { }

	// RVA: -1 Offset: -1
	public static UniTask<T> FromCanceled<T>(CancellationToken token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20292A0 Offset: 0x20293A1 VA: 0x20292A0
	|-UniTask.FromCanceled<object>
	*/

	// RVA: -1 Offset: -1
	public static UniTask<T> Lazy<T>(Func<UniTask<T>> factory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20294E0 Offset: 0x20295E1 VA: 0x20294E0
	|-UniTask.Lazy<object>
	*/

	// RVA: 0x2E869D0 Offset: 0x2E86AD1 VA: 0x2E869D0
	public static void Void(Func<UniTask> asyncAction) { }

	// RVA: -1 Offset: -1
	public static void Void<T>(Func<T, UniTask> asyncAction, T state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2029740 Offset: 0x2029841 VA: 0x2029740
	|-UniTask.Void<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A060 Offset: 0x2A161 VA: 0x2A060
	// RVA: 0x2E86B60 Offset: 0x2E86C61 VA: 0x2E86B60
	public static UniTask Run(Action action, bool configureAwait = True) { }

	[AsyncStateMachineAttribute] // RVA: 0x2A0D0 Offset: 0x2A1D1 VA: 0x2A0D0
	// RVA: 0x2E86C20 Offset: 0x2E86D21 VA: 0x2E86C20
	public static UniTask Run(Action<object> action, object state, bool configureAwait = True) { }

	[AsyncStateMachineAttribute] // RVA: 0x2A140 Offset: 0x2A241 VA: 0x2A140
	// RVA: -1 Offset: -1
	public static UniTask<T> Run<T>(Func<T> func, bool configureAwait = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2029520 Offset: 0x2029621 VA: 0x2029520
	|-UniTask.Run<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A1B0 Offset: 0x2A2B1 VA: 0x2A1B0
	// RVA: -1 Offset: -1
	public static UniTask<T> Run<T>(Func<object, T> func, object state, bool configureAwait = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2029620 Offset: 0x2029721 VA: 0x2029620
	|-UniTask.Run<object>
	*/

	// RVA: 0x2E86D00 Offset: 0x2E86E01 VA: 0x2E86D00
	public static SwitchToMainThreadAwaitable SwitchToMainThread() { }

	// RVA: 0x2E86D10 Offset: 0x2E86E11 VA: 0x2E86D10
	public static SwitchToThreadPoolAwaitable SwitchToThreadPool() { }

	// RVA: 0x2E86D20 Offset: 0x2E86E21 VA: 0x2E86D20
	public static SwitchToTaskPoolAwaitable SwitchToTaskPool() { }

	// RVA: 0x2E86D30 Offset: 0x2E86E31 VA: 0x2E86D30
	public static SwitchToSynchronizationContextAwaitable SwitchToSynchronizationContext(SynchronizationContext syncContext) { }

	// RVA: 0x2E86DB0 Offset: 0x2E86EB1 VA: 0x2E86DB0
	public static UniTask WaitUntil(Func<bool> predicate, PlayerLoopTiming timing = 4, CancellationToken cancellationToken) { }

	// RVA: 0x2E86E40 Offset: 0x2E86F41 VA: 0x2E86E40
	public static UniTask WaitWhile(Func<bool> predicate, PlayerLoopTiming timing = 4, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	public static UniTask<U> WaitUntilValueChanged<T, U>(T target, Func<T, U> monitorFunction, PlayerLoopTiming monitorTiming = 4, IEqualityComparer<U> equalityComparer, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2029770 Offset: 0x2029871 VA: 0x2029770
	|-UniTask.WaitUntilValueChanged<object, object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A220 Offset: 0x2A321 VA: 0x2A220
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<T1, T2>> WhenAll<T1, T2>(UniTask<T1> task1, UniTask<T2> task2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2029A30 Offset: 0x2029B31 VA: 0x2029A30
	|-UniTask.WhenAll<object, object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A290 Offset: 0x2A391 VA: 0x2A290
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<T1, T2, T3>> WhenAll<T1, T2, T3>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2029B90 Offset: 0x2029C91 VA: 0x2029B90
	|-UniTask.WhenAll<object, object, object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A300 Offset: 0x2A401 VA: 0x2A300
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2029D30 Offset: 0x2029E31 VA: 0x2029D30
	|-UniTask.WhenAll<object, object, object, object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A370 Offset: 0x2A471 VA: 0x2A370
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2029F10 Offset: 0x202A011 VA: 0x2029F10
	|-UniTask.WhenAll<object, object, object, object, object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A3E0 Offset: 0x2A4E1 VA: 0x2A3E0
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202A100 Offset: 0x202A201 VA: 0x202A100
	|-UniTask.WhenAll<object, object, object, object, object, object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A450 Offset: 0x2A551 VA: 0x2A450
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202A340 Offset: 0x202A441 VA: 0x202A340
	|-UniTask.WhenAll<object, object, object, object, object, object, object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A4C0 Offset: 0x2A5C1 VA: 0x2A4C0
	// RVA: -1 Offset: -1
	public static UniTask<T[]> WhenAll<T>(UniTask<T>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2029950 Offset: 0x2029A51 VA: 0x2029950
	|-UniTask.WhenAll<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A530 Offset: 0x2A631 VA: 0x2A530
	// RVA: -1 Offset: -1
	public static UniTask<T[]> WhenAll<T>(IEnumerable<UniTask<T>> tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2029870 Offset: 0x2029971 VA: 0x2029870
	|-UniTask.WhenAll<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A5A0 Offset: 0x2A6A1 VA: 0x2A5A0
	// RVA: 0x2E86ED0 Offset: 0x2E86FD1 VA: 0x2E86ED0
	public static UniTask WhenAll(UniTask[] tasks) { }

	[AsyncStateMachineAttribute] // RVA: 0x2A610 Offset: 0x2A711 VA: 0x2A610
	// RVA: 0x2E86F80 Offset: 0x2E87081 VA: 0x2E86F80
	public static UniTask WhenAll(IEnumerable<UniTask> tasks) { }

	[AsyncStateMachineAttribute] // RVA: 0x2A680 Offset: 0x2A781 VA: 0x2A680
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>>> WhenAny<T0, T1>(UniTask<T0> task0, UniTask<T1> task1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202AAB0 Offset: 0x202ABB1 VA: 0x202AAB0
	|-UniTask.WhenAny<object, object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A6F0 Offset: 0x2A7F1 VA: 0x2A6F0
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>>> WhenAny<T0, T1, T2>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202AC50 Offset: 0x202AD51 VA: 0x202AC50
	|-UniTask.WhenAny<object, object, object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A760 Offset: 0x2A861 VA: 0x2A760
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>>> WhenAny<T0, T1, T2, T3>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202AE10 Offset: 0x202AF11 VA: 0x202AE10
	|-UniTask.WhenAny<object, object, object, object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A7D0 Offset: 0x2A8D1 VA: 0x2A7D0
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>>> WhenAny<T0, T1, T2, T3, T4>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202B040 Offset: 0x202B141 VA: 0x202B040
	|-UniTask.WhenAny<object, object, object, object, object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A840 Offset: 0x2A941 VA: 0x2A840
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>>> WhenAny<T0, T1, T2, T3, T4, T5>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202B2D0 Offset: 0x202B3D1 VA: 0x202B2D0
	|-UniTask.WhenAny<object, object, object, object, object, object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A8B0 Offset: 0x2A9B1 VA: 0x2A8B0
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>>>> WhenAny<T0, T1, T2, T3, T4, T5, T6>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202B5F0 Offset: 0x202B6F1 VA: 0x202B5F0
	|-UniTask.WhenAny<object, object, object, object, object, object, object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A920 Offset: 0x2AA21 VA: 0x2A920
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<int, ValueTuple<bool, T0>, ValueTuple<bool, T1>, ValueTuple<bool, T2>, ValueTuple<bool, T3>, ValueTuple<bool, T4>, ValueTuple<bool, T5>, ValueTuple<ValueTuple<bool, T6>, ValueTuple<bool, T7>>>> WhenAny<T0, T1, T2, T3, T4, T5, T6, T7>(UniTask<T0> task0, UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202B860 Offset: 0x202B961 VA: 0x202B860
	|-UniTask.WhenAny<object, object, object, object, object, object, object, object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2A990 Offset: 0x2AA91 VA: 0x2A990
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<bool, T0>> WhenAny<T0>(UniTask<T0> task0, UniTask task1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202A6E0 Offset: 0x202A7E1 VA: 0x202A6E0
	|-UniTask.WhenAny<ValueTuple<bool, AsyncUnit>>
	|
	|-RVA: 0x202A800 Offset: 0x202A901 VA: 0x202A800
	|-UniTask.WhenAny<ValueTuple<bool, object>>
	|
	|-RVA: 0x202A970 Offset: 0x202AA71 VA: 0x202A970
	|-UniTask.WhenAny<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2AA00 Offset: 0x2AB01 VA: 0x2AA00
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<int, T>> WhenAny<T>(UniTask<T>[] tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202A5D0 Offset: 0x202A6D1 VA: 0x202A5D0
	|-UniTask.WhenAny<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2AA70 Offset: 0x2AB71 VA: 0x2AA70
	// RVA: 0x2E87030 Offset: 0x2E87131 VA: 0x2E87030
	public static UniTask<int> WhenAny(UniTask[] tasks) { }

	[DebuggerHiddenAttribute] // RVA: 0x2AAE0 Offset: 0x2ABE1 VA: 0x2AAE0
	// RVA: 0x2E87160 Offset: 0x2E87261 VA: 0x2E87160
	public void .ctor(IAwaiter awaiter) { }

	[DebuggerHiddenAttribute] // RVA: 0x2AAF0 Offset: 0x2ABF1 VA: 0x2AAF0
	// RVA: 0x2E87170 Offset: 0x2E87271 VA: 0x2E87170
	public void .ctor(Func<UniTask> factory) { }

	// RVA: 0x2E82B40 Offset: 0x2E82C41 VA: 0x2E82B40
	public AwaiterStatus get_Status() { }

	// RVA: 0x2E82970 Offset: 0x2E82A71 VA: 0x2E82970
	public bool get_IsCompleted() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AB00 Offset: 0x2AC01 VA: 0x2AB00
	// RVA: 0x2E82D00 Offset: 0x2E82E01 VA: 0x2E82D00
	public void GetResult() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AB10 Offset: 0x2AC11 VA: 0x2AB10
	// RVA: 0x2E82E80 Offset: 0x2E82F81 VA: 0x2E82E80
	public UniTask.Awaiter GetAwaiter() { }

	// RVA: 0x2E7DB50 Offset: 0x2E7DC51 VA: 0x2E7DB50
	public UniTask<bool> SuppressCancellationThrow() { }

	// RVA: 0x2E871F0 Offset: 0x2E872F1 VA: 0x2E871F0 Slot: 4
	public bool Equals(UniTask other) { }

	// RVA: 0x2E87220 Offset: 0x2E87321 VA: 0x2E87220 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E87240 Offset: 0x2E87341 VA: 0x2E87240 Slot: 3
	public override string ToString() { }

	// RVA: 0x2E87410 Offset: 0x2E87511 VA: 0x2E87410
	public static UniTask<AsyncUnit> op_Implicit(UniTask task) { }

	// RVA: 0x2E87570 Offset: 0x2E87671 VA: 0x2E87570
	private static void .cctor() { }
}

// Namespace: UniRx.Async
[AsyncMethodBuilderAttribute] // RVA: 0x27FB0 Offset: 0x280B1 VA: 0x27FB0
public struct UniTask<T> : IEquatable<UniTask<T>> // TypeDefIndex: 5098
{
	// Fields
	private readonly T result; // 0x0
	private readonly IAwaiter<T> awaiter; // 0x0

	// Properties
	[DebuggerHiddenAttribute] // RVA: 0x2F2C0 Offset: 0x2F3C1 VA: 0x2F2C0
	public AwaiterStatus Status { get; }
	[DebuggerHiddenAttribute] // RVA: 0x2F2D0 Offset: 0x2F3D1 VA: 0x2F2D0
	public bool IsCompleted { get; }
	[DebuggerHiddenAttribute] // RVA: 0x2F2E0 Offset: 0x2F3E1 VA: 0x2F2E0
	public T Result { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CEE0 Offset: 0x2CFE1 VA: 0x2CEE0
	// RVA: -1 Offset: -1
	public void .ctor(T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35874F0 Offset: 0x35875F1 VA: 0x35874F0
	|-UniTask<UniTask<object>>..ctor
	|
	|-RVA: 0x3588030 Offset: 0x3588131 VA: 0x3588030
	|-UniTask<ValueTuple<bool, UniTask<object>>>..ctor
	|
	|-RVA: 0x3588C60 Offset: 0x3588D61 VA: 0x3588C60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>..ctor
	|
	|-RVA: 0x35898F0 Offset: 0x35899F1 VA: 0x35898F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..ctor
	|
	|-RVA: 0x358A620 Offset: 0x358A721 VA: 0x358A620
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..ctor
	|
	|-RVA: 0x302D9C0 Offset: 0x302DAC1 VA: 0x302D9C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..ctor
	|
	|-RVA: 0x302E440 Offset: 0x302E541 VA: 0x302E440
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..ctor
	|
	|-RVA: 0x302EEC0 Offset: 0x302EFC1 VA: 0x302EEC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..ctor
	|
	|-RVA: 0x302FC70 Offset: 0x302FD71 VA: 0x302FC70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..ctor
	|
	|-RVA: 0x30306F0 Offset: 0x30307F1 VA: 0x30306F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..ctor
	|
	|-RVA: 0x3031400 Offset: 0x3031501 VA: 0x3031400
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..ctor
	|
	|-RVA: 0x3032130 Offset: 0x3032231 VA: 0x3032130
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..ctor
	|
	|-RVA: 0x3032BE0 Offset: 0x3032CE1 VA: 0x3032BE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..ctor
	|
	|-RVA: 0x3033780 Offset: 0x3033881 VA: 0x3033780
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3034330 Offset: 0x3034431 VA: 0x3034330
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..ctor
	|
	|-RVA: 0x3034EE0 Offset: 0x3034FE1 VA: 0x3034EE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..ctor
	|
	|-RVA: 0x3035A90 Offset: 0x3035B91 VA: 0x3035A90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..ctor
	|
	|-RVA: 0x3036540 Offset: 0x3036641 VA: 0x3036540
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..ctor
	|
	|-RVA: 0x30370F0 Offset: 0x30371F1 VA: 0x30370F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..ctor
	|
	|-RVA: 0x3037AA0 Offset: 0x3037BA1 VA: 0x3037AA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..ctor
	|
	|-RVA: 0x3038600 Offset: 0x3038701 VA: 0x3038600
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..ctor
	|
	|-RVA: 0x30390E0 Offset: 0x30391E1 VA: 0x30390E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..ctor
	|
	|-RVA: 0x3039C90 Offset: 0x3039D91 VA: 0x3039C90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..ctor
	|
	|-RVA: 0x303A840 Offset: 0x303A941 VA: 0x303A840
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..ctor
	|
	|-RVA: 0x303B570 Offset: 0x303B671 VA: 0x303B570
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303C330 Offset: 0x303C431 VA: 0x303C330
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303D120 Offset: 0x303D221 VA: 0x303D120
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303DF90 Offset: 0x303E091 VA: 0x303DF90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303EE20 Offset: 0x303EF21 VA: 0x303EE20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303FBA0 Offset: 0x303FCA1 VA: 0x303FBA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..ctor
	|
	|-RVA: 0x3040620 Offset: 0x3040721 VA: 0x3040620
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..ctor
	|
	|-RVA: 0x30410A0 Offset: 0x30411A1 VA: 0x30410A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..ctor
	|
	|-RVA: 0x3041DE0 Offset: 0x3041EE1 VA: 0x3041DE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..ctor
	|
	|-RVA: 0x3042860 Offset: 0x3042961 VA: 0x3042860
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..ctor
	|
	|-RVA: 0x30434C0 Offset: 0x30435C1 VA: 0x30434C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..ctor
	|
	|-RVA: 0x30441D0 Offset: 0x30442D1 VA: 0x30441D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..ctor
	|
	|-RVA: 0x2A96980 Offset: 0x2A96A81 VA: 0x2A96980
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..ctor
	|
	|-RVA: 0x2A97690 Offset: 0x2A97791 VA: 0x2A97690
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2A983B0 Offset: 0x2A984B1 VA: 0x2A983B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..ctor
	|
	|-RVA: 0x2A99010 Offset: 0x2A99111 VA: 0x2A99010
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..ctor
	|
	|-RVA: 0x2A99C70 Offset: 0x2A99D71 VA: 0x2A99C70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..ctor
	|
	|-RVA: 0x2A9A860 Offset: 0x2A9A961 VA: 0x2A9A860
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..ctor
	|
	|-RVA: 0x2A9B580 Offset: 0x2A9B681 VA: 0x2A9B580
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..ctor
	|
	|-RVA: 0x2A9BFF0 Offset: 0x2A9C0F1 VA: 0x2A9BFF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..ctor
	|
	|-RVA: 0x2A9CC20 Offset: 0x2A9CD21 VA: 0x2A9CC20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..ctor
	|
	|-RVA: 0x2A9D8F0 Offset: 0x2A9D9F1 VA: 0x2A9D8F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..ctor
	|
	|-RVA: 0x2A9E550 Offset: 0x2A9E651 VA: 0x2A9E550
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..ctor
	|
	|-RVA: 0x2A9F270 Offset: 0x2A9F371 VA: 0x2A9F270
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..ctor
	|
	|-RVA: 0x2A9FF90 Offset: 0x2AA0091 VA: 0x2A9FF90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA0DB0 Offset: 0x2AA0EB1 VA: 0x2AA0DB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA1B20 Offset: 0x2AA1C21 VA: 0x2AA1B20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA2A10 Offset: 0x2AA2B11 VA: 0x2AA2A10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA3830 Offset: 0x2AA3931 VA: 0x2AA3830
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA47F0 Offset: 0x2AA48F1 VA: 0x2AA47F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA5650 Offset: 0x2AA5751 VA: 0x2AA5650
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA66F0 Offset: 0x2AA67F1 VA: 0x2AA66F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA75F0 Offset: 0x2AA76F1 VA: 0x2AA75F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA8670 Offset: 0x2AA8771 VA: 0x2AA8670
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA98B0 Offset: 0x2AA99B1 VA: 0x2AA98B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..ctor
	|
	|-RVA: 0x2AAA320 Offset: 0x2AAA421 VA: 0x2AAA320
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>..ctor
	|
	|-RVA: 0x2AAAD90 Offset: 0x2AAAE91 VA: 0x2AAAD90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>..ctor
	|
	|-RVA: 0x2AABAC0 Offset: 0x2AABBC1 VA: 0x2AABAC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>..ctor
	|
	|-RVA: 0x2AAC530 Offset: 0x2AAC631 VA: 0x2AAC530
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>..ctor
	|
	|-RVA: 0x2AAD200 Offset: 0x2AAD301 VA: 0x2AAD200
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>..ctor
	|
	|-RVA: 0x2AADE60 Offset: 0x2AADF61 VA: 0x2AADE60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>..ctor
	|
	|-RVA: 0x2AAE980 Offset: 0x2AAEA81 VA: 0x2AAE980
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>..ctor
	|
	|-RVA: 0x2AAF5D0 Offset: 0x2AAF6D1 VA: 0x2AAF5D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2AB0260 Offset: 0x2AB0361 VA: 0x2AB0260
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..ctor
	|
	|-RVA: 0x2AB0F20 Offset: 0x2AB1021 VA: 0x2AB0F20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>..ctor
	|
	|-RVA: 0x2AB1BE0 Offset: 0x2AB1CE1 VA: 0x2AB1BE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>..ctor
	|
	|-RVA: 0x2AB26F0 Offset: 0x2AB27F1 VA: 0x2AB26F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>..ctor
	|
	|-RVA: 0x2AB3380 Offset: 0x2AB3481 VA: 0x2AB3380
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>..ctor
	|
	|-RVA: 0x2AB3E00 Offset: 0x2AB3F01 VA: 0x2AB3E00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>..ctor
	|
	|-RVA: 0x2AB49E0 Offset: 0x2AB4AE1 VA: 0x2AB49E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>..ctor
	|
	|-RVA: 0x2AB5600 Offset: 0x2AB5701 VA: 0x2AB5600
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>..ctor
	|
	|-RVA: 0x2AB62C0 Offset: 0x2AB63C1 VA: 0x2AB62C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>..ctor
	|
	|-RVA: 0x2AB6F50 Offset: 0x2AB7051 VA: 0x2AB6F50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>..ctor
	|
	|-RVA: 0x2AB7BE0 Offset: 0x2AB7CE1 VA: 0x2AB7BE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2AB8A00 Offset: 0x2AB8B01 VA: 0x2AB8A00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>..ctor
	|
	|-RVA: 0x2AB9730 Offset: 0x2AB9831 VA: 0x2AB9730
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2ABA640 Offset: 0x2ABA741 VA: 0x2ABA640
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2ABB3B0 Offset: 0x2ABB4B1 VA: 0x2ABB3B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2ABC390 Offset: 0x2ABC491 VA: 0x2ABC390
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2ABD1B0 Offset: 0x2ABD2B1 VA: 0x2ABD1B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2ABE2A0 Offset: 0x2ABE3A1 VA: 0x2ABE2A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2ABF110 Offset: 0x2ABF211 VA: 0x2ABF110
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2AC02C0 Offset: 0x2AC03C1 VA: 0x2AC02C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2AC11D0 Offset: 0x2AC12D1 VA: 0x2AC11D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2CB8EF0 Offset: 0x2CB8FF1 VA: 0x2CB8EF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2CB9D10 Offset: 0x2CB9E11 VA: 0x2CB9D10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x2CBA7A0 Offset: 0x2CBA8A1 VA: 0x2CBA7A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x2CBB230 Offset: 0x2CBB331 VA: 0x2CBB230
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>..ctor
	|
	|-RVA: 0x2CBBE90 Offset: 0x2CBBF91 VA: 0x2CBBE90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>..ctor
	|
	|-RVA: 0x2CBC920 Offset: 0x2CBCA21 VA: 0x2CBC920
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>..ctor
	|
	|-RVA: 0x2CBD550 Offset: 0x2CBD651 VA: 0x2CBD550
	|-UniTask<ValueTuple<bool, ValueTuple<bool, double>>>..ctor
	|
	|-RVA: 0x2CBE150 Offset: 0x2CBE251 VA: 0x2CBE150
	|-UniTask<ValueTuple<bool, ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x2CBEC40 Offset: 0x2CBED41 VA: 0x2CBEC40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, long>>>..ctor
	|
	|-RVA: 0x2CBF840 Offset: 0x2CBF941 VA: 0x2CBF840
	|-UniTask<ValueTuple<bool, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2CC0460 Offset: 0x2CC0561 VA: 0x2CC0460
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>..ctor
	|
	|-RVA: 0x2CC1090 Offset: 0x2CC1191 VA: 0x2CC1090
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>..ctor
	|
	|-RVA: 0x2CC1CC0 Offset: 0x2CC1DC1 VA: 0x2CC1CC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x2CC27B0 Offset: 0x2CC28B1 VA: 0x2CC27B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>..ctor
	|
	|-RVA: 0x2CC33D0 Offset: 0x2CC34D1 VA: 0x2CC33D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>..ctor
	|
	|-RVA: 0x2CC3E60 Offset: 0x2CC3F61 VA: 0x2CC3E60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x2CC4980 Offset: 0x2CC4A81 VA: 0x2CC4980
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>..ctor
	|
	|-RVA: 0x2CC5570 Offset: 0x2CC5671 VA: 0x2CC5570
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>..ctor
	|
	|-RVA: 0x2CC61A0 Offset: 0x2CC62A1 VA: 0x2CC61A0
	|-UniTask<ValueTuple<bool, ValueTuple<int, object>>>..ctor
	|
	|-RVA: 0x2CC6DC0 Offset: 0x2CC6EC1 VA: 0x2CC6DC0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x2CC79F0 Offset: 0x2CC7AF1 VA: 0x2CC79F0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CC8760 Offset: 0x2CC8861 VA: 0x2CC8760
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>..ctor
	|
	|-RVA: 0x2CC93F0 Offset: 0x2CC94F1 VA: 0x2CC93F0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CCA250 Offset: 0x2CCA351 VA: 0x2CCA250
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>..ctor
	|
	|-RVA: 0x2CCAF70 Offset: 0x2CCB071 VA: 0x2CCAF70
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CCBEB0 Offset: 0x2CCBFB1 VA: 0x2CCBEB0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2CCCC20 Offset: 0x2CCCD21 VA: 0x2CCCC20
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CCDC40 Offset: 0x2CCDD41 VA: 0x2CCDC40
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2CCEA60 Offset: 0x2CCEB61 VA: 0x2CCEA60
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CCFB90 Offset: 0x2CCFC91 VA: 0x2CCFB90
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2CD09F0 Offset: 0x2CD0AF1 VA: 0x2CD09F0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2CD1AD0 Offset: 0x2CD1BD1 VA: 0x2CD1AD0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2CD2900 Offset: 0x2CD2A01 VA: 0x2CD2900
	|-UniTask<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x2CD3380 Offset: 0x2CD3481 VA: 0x2CD3380
	|-UniTask<ValueTuple<bool, bool>>..ctor
	|
	|-RVA: 0x2CD3E00 Offset: 0x2CD3F01 VA: 0x2CD3E00
	|-UniTask<ValueTuple<bool, Bounds>>..ctor
	|
	|-RVA: 0x2CD4AC0 Offset: 0x2CD4BC1 VA: 0x2CD4AC0
	|-UniTask<ValueTuple<bool, byte>>..ctor
	|
	|-RVA: 0x2CD5540 Offset: 0x2CD5641 VA: 0x2CD5540
	|-UniTask<ValueTuple<bool, Color>>..ctor
	|
	|-RVA: 0x2CD6120 Offset: 0x2CD6221 VA: 0x2CD6120
	|-UniTask<ValueTuple<bool, double>>..ctor
	|
	|-RVA: 0x2CD6C30 Offset: 0x2CD6D31 VA: 0x2CD6C30
	|-UniTask<ValueTuple<bool, int>>..ctor
	|
	|-RVA: 0x2CD7680 Offset: 0x2CD7781 VA: 0x2CD7680
	|-UniTask<ValueTuple<bool, long>>..ctor
	|
	|-RVA: 0x2CD8190 Offset: 0x2CD8291 VA: 0x2CD8190
	|-UniTask<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2CD8CD0 Offset: 0x2CD8DD1 VA: 0x2CD8CD0
	|-UniTask<ValueTuple<bool, Quaternion>>..ctor
	|
	|-RVA: 0x2CD98B0 Offset: 0x2CD99B1 VA: 0x2CD98B0
	|-UniTask<ValueTuple<bool, Rect>>..ctor
	|
	|-RVA: 0x2CDA490 Offset: 0x2CDA591 VA: 0x2CDA490
	|-UniTask<ValueTuple<bool, float>>..ctor
	|
	|-RVA: 0x2CDAEE0 Offset: 0x2CDAFE1 VA: 0x2CDAEE0
	|-UniTask<ValueTuple<bool, UniTask>>..ctor
	|
	|-RVA: 0x2CDBA20 Offset: 0x2CDBB21 VA: 0x2CDBA20
	|-UniTask<ValueTuple<bool, Unit>>..ctor
	|
	|-RVA: 0x2CDC4A0 Offset: 0x2CDC5A1 VA: 0x2CDC4A0
	|-UniTask<ValueTuple<bool, Vector2>>..ctor
	|
	|-RVA: 0x2CDCF80 Offset: 0x2CDD081 VA: 0x2CDCF80
	|-UniTask<ValueTuple<bool, Vector3>>..ctor
	|
	|-RVA: 0x2CDDA90 Offset: 0x2CDDB91 VA: 0x2CDDA90
	|-UniTask<ValueTuple<bool, Vector4>>..ctor
	|
	|-RVA: 0x2CDE670 Offset: 0x2CDE771 VA: 0x2CDE670
	|-UniTask<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x2CDF1B0 Offset: 0x2CDF2B1 VA: 0x2CDF1B0
	|-UniTask<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2CDFCF0 Offset: 0x2CDFDF1 VA: 0x2CDFCF0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2CE0A20 Offset: 0x2CE0B21 VA: 0x2CE0A20
	|-UniTask<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2CE1640 Offset: 0x2CE1741 VA: 0x2CE1640
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2DDD930 Offset: 0x2DDDA31 VA: 0x2DDD930
	|-UniTask<ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x2DDE5B0 Offset: 0x2DDE6B1 VA: 0x2DDE5B0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2DDF4B0 Offset: 0x2DDF5B1 VA: 0x2DDF4B0
	|-UniTask<ValueTuple<object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2DE01D0 Offset: 0x2DE02D1 VA: 0x2DE01D0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2DE11A0 Offset: 0x2DE12A1 VA: 0x2DE11A0
	|-UniTask<ValueTuple<object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2DE1F00 Offset: 0x2DE2001 VA: 0x2DE1F00
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2DE2FE0 Offset: 0x2DE30E1 VA: 0x2DE2FE0
	|-UniTask<ValueTuple<object, object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2DE3DF0 Offset: 0x2DE3EF1 VA: 0x2DE3DF0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2DE4FA0 Offset: 0x2DE50A1 VA: 0x2DE4FA0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2DE5DD0 Offset: 0x2DE5ED1 VA: 0x2DE5DD0
	|-UniTask<AsyncUnit>..ctor
	|
	|-RVA: 0x2DE6790 Offset: 0x2DE6891 VA: 0x2DE6790
	|-UniTask<bool>..ctor
	|
	|-RVA: 0x2DE7150 Offset: 0x2DE7251 VA: 0x2DE7150
	|-UniTask<Bounds>..ctor
	|
	|-RVA: 0x2DE7CC0 Offset: 0x2DE7DC1 VA: 0x2DE7CC0
	|-UniTask<byte>..ctor
	|
	|-RVA: 0x2DE8670 Offset: 0x2DE8771 VA: 0x2DE8670
	|-UniTask<Color>..ctor
	|
	|-RVA: 0x2DE9130 Offset: 0x2DE9231 VA: 0x2DE9130
	|-UniTask<double>..ctor
	|
	|-RVA: 0x2DE9B00 Offset: 0x2DE9C01 VA: 0x2DE9B00
	|-UniTask<int>..ctor
	|
	|-RVA: 0x2DEA4B0 Offset: 0x2DEA5B1 VA: 0x2DEA4B0
	|-UniTask<long>..ctor
	|
	|-RVA: 0x2DEAE80 Offset: 0x2DEAF81 VA: 0x2DEAE80
	|-UniTask<object>..ctor
	|
	|-RVA: 0x2DEB840 Offset: 0x2DEB941 VA: 0x2DEB840
	|-UniTask<Quaternion>..ctor
	|
	|-RVA: 0x2DEC300 Offset: 0x2DEC401 VA: 0x2DEC300
	|-UniTask<Rect>..ctor
	|
	|-RVA: 0x2DECDC0 Offset: 0x2DECEC1 VA: 0x2DECDC0
	|-UniTask<float>..ctor
	|
	|-RVA: 0x2DED780 Offset: 0x2DED881 VA: 0x2DED780
	|-UniTask<UniTask>..ctor
	|
	|-RVA: 0x2DEE180 Offset: 0x2DEE281 VA: 0x2DEE180
	|-UniTask<Unit>..ctor
	|
	|-RVA: 0x2DEEB40 Offset: 0x2DEEC41 VA: 0x2DEEB40
	|-UniTask<Vector2>..ctor
	|
	|-RVA: 0x2DEF550 Offset: 0x2DEF651 VA: 0x2DEF550
	|-UniTask<Vector3>..ctor
	|
	|-RVA: 0x2DEFFA0 Offset: 0x2DF00A1 VA: 0x2DEFFA0
	|-UniTask<Vector4>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CEF0 Offset: 0x2CFF1 VA: 0x2CEF0
	// RVA: -1 Offset: -1
	public void .ctor(IAwaiter<T> awaiter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3587530 Offset: 0x3587631 VA: 0x3587530
	|-UniTask<UniTask<object>>..ctor
	|
	|-RVA: 0x3588080 Offset: 0x3588181 VA: 0x3588080
	|-UniTask<ValueTuple<bool, UniTask<object>>>..ctor
	|
	|-RVA: 0x3588CB0 Offset: 0x3588DB1 VA: 0x3588CB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>..ctor
	|
	|-RVA: 0x3589930 Offset: 0x3589A31 VA: 0x3589930
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..ctor
	|
	|-RVA: 0x358A660 Offset: 0x358A761 VA: 0x358A660
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..ctor
	|
	|-RVA: 0x302D9E0 Offset: 0x302DAE1 VA: 0x302D9E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..ctor
	|
	|-RVA: 0x302E460 Offset: 0x302E561 VA: 0x302E460
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..ctor
	|
	|-RVA: 0x302EEF0 Offset: 0x302EFF1 VA: 0x302EEF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..ctor
	|
	|-RVA: 0x302FC90 Offset: 0x302FD91 VA: 0x302FC90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..ctor
	|
	|-RVA: 0x3030720 Offset: 0x3030821 VA: 0x3030720
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..ctor
	|
	|-RVA: 0x3031430 Offset: 0x3031531 VA: 0x3031430
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..ctor
	|
	|-RVA: 0x3032150 Offset: 0x3032251 VA: 0x3032150
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..ctor
	|
	|-RVA: 0x3032C10 Offset: 0x3032D11 VA: 0x3032C10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..ctor
	|
	|-RVA: 0x30337C0 Offset: 0x30338C1 VA: 0x30337C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3034360 Offset: 0x3034461 VA: 0x3034360
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..ctor
	|
	|-RVA: 0x3034F10 Offset: 0x3035011 VA: 0x3034F10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..ctor
	|
	|-RVA: 0x3035AB0 Offset: 0x3035BB1 VA: 0x3035AB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..ctor
	|
	|-RVA: 0x3036580 Offset: 0x3036681 VA: 0x3036580
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..ctor
	|
	|-RVA: 0x3037110 Offset: 0x3037211 VA: 0x3037110
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..ctor
	|
	|-RVA: 0x3037AD0 Offset: 0x3037BD1 VA: 0x3037AD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..ctor
	|
	|-RVA: 0x3038620 Offset: 0x3038721 VA: 0x3038620
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..ctor
	|
	|-RVA: 0x3039110 Offset: 0x3039211 VA: 0x3039110
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..ctor
	|
	|-RVA: 0x3039CD0 Offset: 0x3039DD1 VA: 0x3039CD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..ctor
	|
	|-RVA: 0x303A880 Offset: 0x303A981 VA: 0x303A880
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..ctor
	|
	|-RVA: 0x303B5B0 Offset: 0x303B6B1 VA: 0x303B5B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303C370 Offset: 0x303C471 VA: 0x303C370
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303D160 Offset: 0x303D261 VA: 0x303D160
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303DFD0 Offset: 0x303E0D1 VA: 0x303DFD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303EE60 Offset: 0x303EF61 VA: 0x303EE60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303FBC0 Offset: 0x303FCC1 VA: 0x303FBC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..ctor
	|
	|-RVA: 0x3040640 Offset: 0x3040741 VA: 0x3040640
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..ctor
	|
	|-RVA: 0x30410D0 Offset: 0x30411D1 VA: 0x30410D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..ctor
	|
	|-RVA: 0x3041E00 Offset: 0x3041F01 VA: 0x3041E00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..ctor
	|
	|-RVA: 0x3042880 Offset: 0x3042981 VA: 0x3042880
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..ctor
	|
	|-RVA: 0x30434F0 Offset: 0x30435F1 VA: 0x30434F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..ctor
	|
	|-RVA: 0x30441F0 Offset: 0x30442F1 VA: 0x30441F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..ctor
	|
	|-RVA: 0x2A969B0 Offset: 0x2A96AB1 VA: 0x2A969B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..ctor
	|
	|-RVA: 0x2A976D0 Offset: 0x2A977D1 VA: 0x2A976D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2A983D0 Offset: 0x2A984D1 VA: 0x2A983D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..ctor
	|
	|-RVA: 0x2A99030 Offset: 0x2A99131 VA: 0x2A99030
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..ctor
	|
	|-RVA: 0x2A99C90 Offset: 0x2A99D91 VA: 0x2A99C90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..ctor
	|
	|-RVA: 0x2A9A8A0 Offset: 0x2A9A9A1 VA: 0x2A9A8A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..ctor
	|
	|-RVA: 0x2A9B5A0 Offset: 0x2A9B6A1 VA: 0x2A9B5A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..ctor
	|
	|-RVA: 0x2A9C010 Offset: 0x2A9C111 VA: 0x2A9C010
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..ctor
	|
	|-RVA: 0x2A9CC50 Offset: 0x2A9CD51 VA: 0x2A9CC50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..ctor
	|
	|-RVA: 0x2A9D910 Offset: 0x2A9DA11 VA: 0x2A9D910
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..ctor
	|
	|-RVA: 0x2A9E590 Offset: 0x2A9E691 VA: 0x2A9E590
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..ctor
	|
	|-RVA: 0x2A9F2B0 Offset: 0x2A9F3B1 VA: 0x2A9F2B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..ctor
	|
	|-RVA: 0x2A9FFD0 Offset: 0x2AA00D1 VA: 0x2A9FFD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA0DF0 Offset: 0x2AA0EF1 VA: 0x2AA0DF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA1B60 Offset: 0x2AA1C61 VA: 0x2AA1B60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA2A50 Offset: 0x2AA2B51 VA: 0x2AA2A50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA3870 Offset: 0x2AA3971 VA: 0x2AA3870
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA4830 Offset: 0x2AA4931 VA: 0x2AA4830
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA5690 Offset: 0x2AA5791 VA: 0x2AA5690
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA6730 Offset: 0x2AA6831 VA: 0x2AA6730
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA7630 Offset: 0x2AA7731 VA: 0x2AA7630
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA86B0 Offset: 0x2AA87B1 VA: 0x2AA86B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA98C0 Offset: 0x2AA99C1 VA: 0x2AA98C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..ctor
	|
	|-RVA: 0x2AAA330 Offset: 0x2AAA431 VA: 0x2AAA330
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>..ctor
	|
	|-RVA: 0x2AAADC0 Offset: 0x2AAAEC1 VA: 0x2AAADC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>..ctor
	|
	|-RVA: 0x2AABAD0 Offset: 0x2AABBD1 VA: 0x2AABAD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>..ctor
	|
	|-RVA: 0x2AAC560 Offset: 0x2AAC661 VA: 0x2AAC560
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>..ctor
	|
	|-RVA: 0x2AAD220 Offset: 0x2AAD321 VA: 0x2AAD220
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>..ctor
	|
	|-RVA: 0x2AADE70 Offset: 0x2AADF71 VA: 0x2AADE70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>..ctor
	|
	|-RVA: 0x2AAE9A0 Offset: 0x2AAEAA1 VA: 0x2AAE9A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>..ctor
	|
	|-RVA: 0x2AAF620 Offset: 0x2AAF721 VA: 0x2AAF620
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2AB0290 Offset: 0x2AB0391 VA: 0x2AB0290
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..ctor
	|
	|-RVA: 0x2AB0F50 Offset: 0x2AB1051 VA: 0x2AB0F50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>..ctor
	|
	|-RVA: 0x2AB1BF0 Offset: 0x2AB1CF1 VA: 0x2AB1BF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>..ctor
	|
	|-RVA: 0x2AB2740 Offset: 0x2AB2841 VA: 0x2AB2740
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>..ctor
	|
	|-RVA: 0x2AB3390 Offset: 0x2AB3491 VA: 0x2AB3390
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>..ctor
	|
	|-RVA: 0x2AB3E20 Offset: 0x2AB3F21 VA: 0x2AB3E20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>..ctor
	|
	|-RVA: 0x2AB4A00 Offset: 0x2AB4B01 VA: 0x2AB4A00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>..ctor
	|
	|-RVA: 0x2AB5630 Offset: 0x2AB5731 VA: 0x2AB5630
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>..ctor
	|
	|-RVA: 0x2AB6310 Offset: 0x2AB6411 VA: 0x2AB6310
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>..ctor
	|
	|-RVA: 0x2AB6FA0 Offset: 0x2AB70A1 VA: 0x2AB6FA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>..ctor
	|
	|-RVA: 0x2AB7C20 Offset: 0x2AB7D21 VA: 0x2AB7C20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2AB8A40 Offset: 0x2AB8B41 VA: 0x2AB8A40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>..ctor
	|
	|-RVA: 0x2AB9770 Offset: 0x2AB9871 VA: 0x2AB9770
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2ABA680 Offset: 0x2ABA781 VA: 0x2ABA680
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2ABB3F0 Offset: 0x2ABB4F1 VA: 0x2ABB3F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2ABC3D0 Offset: 0x2ABC4D1 VA: 0x2ABC3D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2ABD1F0 Offset: 0x2ABD2F1 VA: 0x2ABD1F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2ABE2E0 Offset: 0x2ABE3E1 VA: 0x2ABE2E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2ABF150 Offset: 0x2ABF251 VA: 0x2ABF150
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2AC0300 Offset: 0x2AC0401 VA: 0x2AC0300
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2AC1210 Offset: 0x2AC1311 VA: 0x2AC1210
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2CB8F30 Offset: 0x2CB9031 VA: 0x2CB8F30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2CB9D30 Offset: 0x2CB9E31 VA: 0x2CB9D30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x2CBA7C0 Offset: 0x2CBA8C1 VA: 0x2CBA7C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x2CBB250 Offset: 0x2CBB351 VA: 0x2CBB250
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>..ctor
	|
	|-RVA: 0x2CBBEB0 Offset: 0x2CBBFB1 VA: 0x2CBBEB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>..ctor
	|
	|-RVA: 0x2CBC940 Offset: 0x2CBCA41 VA: 0x2CBC940
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>..ctor
	|
	|-RVA: 0x2CBD570 Offset: 0x2CBD671 VA: 0x2CBD570
	|-UniTask<ValueTuple<bool, ValueTuple<bool, double>>>..ctor
	|
	|-RVA: 0x2CBE170 Offset: 0x2CBE271 VA: 0x2CBE170
	|-UniTask<ValueTuple<bool, ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x2CBEC60 Offset: 0x2CBED61 VA: 0x2CBEC60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, long>>>..ctor
	|
	|-RVA: 0x2CBF880 Offset: 0x2CBF981 VA: 0x2CBF880
	|-UniTask<ValueTuple<bool, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2CC0480 Offset: 0x2CC0581 VA: 0x2CC0480
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>..ctor
	|
	|-RVA: 0x2CC10B0 Offset: 0x2CC11B1 VA: 0x2CC10B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>..ctor
	|
	|-RVA: 0x2CC1CE0 Offset: 0x2CC1DE1 VA: 0x2CC1CE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x2CC27F0 Offset: 0x2CC28F1 VA: 0x2CC27F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>..ctor
	|
	|-RVA: 0x2CC33F0 Offset: 0x2CC34F1 VA: 0x2CC33F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>..ctor
	|
	|-RVA: 0x2CC3E70 Offset: 0x2CC3F71 VA: 0x2CC3E70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x2CC49A0 Offset: 0x2CC4AA1 VA: 0x2CC49A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>..ctor
	|
	|-RVA: 0x2CC5590 Offset: 0x2CC5691 VA: 0x2CC5590
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>..ctor
	|
	|-RVA: 0x2CC61E0 Offset: 0x2CC62E1 VA: 0x2CC61E0
	|-UniTask<ValueTuple<bool, ValueTuple<int, object>>>..ctor
	|
	|-RVA: 0x2CC6E10 Offset: 0x2CC6F11 VA: 0x2CC6E10
	|-UniTask<ValueTuple<bool, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x2CC7A30 Offset: 0x2CC7B31 VA: 0x2CC7A30
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CC87B0 Offset: 0x2CC88B1 VA: 0x2CC87B0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>..ctor
	|
	|-RVA: 0x2CC9430 Offset: 0x2CC9531 VA: 0x2CC9430
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CCA290 Offset: 0x2CCA391 VA: 0x2CCA290
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>..ctor
	|
	|-RVA: 0x2CCAFB0 Offset: 0x2CCB0B1 VA: 0x2CCAFB0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CCBEF0 Offset: 0x2CCBFF1 VA: 0x2CCBEF0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2CCCC60 Offset: 0x2CCCD61 VA: 0x2CCCC60
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CCDC80 Offset: 0x2CCDD81 VA: 0x2CCDC80
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2CCEAA0 Offset: 0x2CCEBA1 VA: 0x2CCEAA0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CCFBD0 Offset: 0x2CCFCD1 VA: 0x2CCFBD0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2CD0A30 Offset: 0x2CD0B31 VA: 0x2CD0A30
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2CD1B10 Offset: 0x2CD1C11 VA: 0x2CD1B10
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2CD2910 Offset: 0x2CD2A11 VA: 0x2CD2910
	|-UniTask<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x2CD3390 Offset: 0x2CD3491 VA: 0x2CD3390
	|-UniTask<ValueTuple<bool, bool>>..ctor
	|
	|-RVA: 0x2CD3E30 Offset: 0x2CD3F31 VA: 0x2CD3E30
	|-UniTask<ValueTuple<bool, Bounds>>..ctor
	|
	|-RVA: 0x2CD4AD0 Offset: 0x2CD4BD1 VA: 0x2CD4AD0
	|-UniTask<ValueTuple<bool, byte>>..ctor
	|
	|-RVA: 0x2CD5560 Offset: 0x2CD5661 VA: 0x2CD5560
	|-UniTask<ValueTuple<bool, Color>>..ctor
	|
	|-RVA: 0x2CD6130 Offset: 0x2CD6231 VA: 0x2CD6130
	|-UniTask<ValueTuple<bool, double>>..ctor
	|
	|-RVA: 0x2CD6C40 Offset: 0x2CD6D41 VA: 0x2CD6C40
	|-UniTask<ValueTuple<bool, int>>..ctor
	|
	|-RVA: 0x2CD7690 Offset: 0x2CD7791 VA: 0x2CD7690
	|-UniTask<ValueTuple<bool, long>>..ctor
	|
	|-RVA: 0x2CD81D0 Offset: 0x2CD82D1 VA: 0x2CD81D0
	|-UniTask<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2CD8CF0 Offset: 0x2CD8DF1 VA: 0x2CD8CF0
	|-UniTask<ValueTuple<bool, Quaternion>>..ctor
	|
	|-RVA: 0x2CD98D0 Offset: 0x2CD99D1 VA: 0x2CD98D0
	|-UniTask<ValueTuple<bool, Rect>>..ctor
	|
	|-RVA: 0x2CDA4A0 Offset: 0x2CDA5A1 VA: 0x2CDA4A0
	|-UniTask<ValueTuple<bool, float>>..ctor
	|
	|-RVA: 0x2CDAF20 Offset: 0x2CDB021 VA: 0x2CDAF20
	|-UniTask<ValueTuple<bool, UniTask>>..ctor
	|
	|-RVA: 0x2CDBA30 Offset: 0x2CDBB31 VA: 0x2CDBA30
	|-UniTask<ValueTuple<bool, Unit>>..ctor
	|
	|-RVA: 0x2CDC4C0 Offset: 0x2CDC5C1 VA: 0x2CDC4C0
	|-UniTask<ValueTuple<bool, Vector2>>..ctor
	|
	|-RVA: 0x2CDCF90 Offset: 0x2CDD091 VA: 0x2CDCF90
	|-UniTask<ValueTuple<bool, Vector3>>..ctor
	|
	|-RVA: 0x2CDDAB0 Offset: 0x2CDDBB1 VA: 0x2CDDAB0
	|-UniTask<ValueTuple<bool, Vector4>>..ctor
	|
	|-RVA: 0x2CDE6B0 Offset: 0x2CDE7B1 VA: 0x2CDE6B0
	|-UniTask<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x2CDF1F0 Offset: 0x2CDF2F1 VA: 0x2CDF1F0
	|-UniTask<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2CDFD30 Offset: 0x2CDFE31 VA: 0x2CDFD30
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2CE0A60 Offset: 0x2CE0B61 VA: 0x2CE0A60
	|-UniTask<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2CE1680 Offset: 0x2CE1781 VA: 0x2CE1680
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2DDD970 Offset: 0x2DDDA71 VA: 0x2DDD970
	|-UniTask<ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x2DDE5F0 Offset: 0x2DDE6F1 VA: 0x2DDE5F0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2DDF4F0 Offset: 0x2DDF5F1 VA: 0x2DDF4F0
	|-UniTask<ValueTuple<object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2DE0210 Offset: 0x2DE0311 VA: 0x2DE0210
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2DE11E0 Offset: 0x2DE12E1 VA: 0x2DE11E0
	|-UniTask<ValueTuple<object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2DE1F40 Offset: 0x2DE2041 VA: 0x2DE1F40
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2DE3020 Offset: 0x2DE3121 VA: 0x2DE3020
	|-UniTask<ValueTuple<object, object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2DE3E30 Offset: 0x2DE3F31 VA: 0x2DE3E30
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2DE4FE0 Offset: 0x2DE50E1 VA: 0x2DE4FE0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2DE5DE0 Offset: 0x2DE5EE1 VA: 0x2DE5DE0
	|-UniTask<AsyncUnit>..ctor
	|
	|-RVA: 0x2DE67B0 Offset: 0x2DE68B1 VA: 0x2DE67B0
	|-UniTask<bool>..ctor
	|
	|-RVA: 0x2DE7170 Offset: 0x2DE7271 VA: 0x2DE7170
	|-UniTask<Bounds>..ctor
	|
	|-RVA: 0x2DE7CD0 Offset: 0x2DE7DD1 VA: 0x2DE7CD0
	|-UniTask<byte>..ctor
	|
	|-RVA: 0x2DE8690 Offset: 0x2DE8791 VA: 0x2DE8690
	|-UniTask<Color>..ctor
	|
	|-RVA: 0x2DE9140 Offset: 0x2DE9241 VA: 0x2DE9140
	|-UniTask<double>..ctor
	|
	|-RVA: 0x2DE9B10 Offset: 0x2DE9C11 VA: 0x2DE9B10
	|-UniTask<int>..ctor
	|
	|-RVA: 0x2DEA4C0 Offset: 0x2DEA5C1 VA: 0x2DEA4C0
	|-UniTask<long>..ctor
	|
	|-RVA: 0x2DEAEB0 Offset: 0x2DEAFB1 VA: 0x2DEAEB0
	|-UniTask<object>..ctor
	|-UniTask<Object>..ctor
	|-UniTask<UnityWebRequest>..ctor
	|
	|-RVA: 0x2DEB860 Offset: 0x2DEB961 VA: 0x2DEB860
	|-UniTask<Quaternion>..ctor
	|
	|-RVA: 0x2DEC320 Offset: 0x2DEC421 VA: 0x2DEC320
	|-UniTask<Rect>..ctor
	|
	|-RVA: 0x2DECDD0 Offset: 0x2DECED1 VA: 0x2DECDD0
	|-UniTask<float>..ctor
	|
	|-RVA: 0x2DED7C0 Offset: 0x2DED8C1 VA: 0x2DED7C0
	|-UniTask<UniTask>..ctor
	|
	|-RVA: 0x2DEE190 Offset: 0x2DEE291 VA: 0x2DEE190
	|-UniTask<Unit>..ctor
	|
	|-RVA: 0x2DEEB60 Offset: 0x2DEEC61 VA: 0x2DEEB60
	|-UniTask<Vector2>..ctor
	|
	|-RVA: 0x2DEF570 Offset: 0x2DEF671 VA: 0x2DEF570
	|-UniTask<Vector3>..ctor
	|
	|-RVA: 0x2DEFFC0 Offset: 0x2DF00C1 VA: 0x2DEFFC0
	|-UniTask<Vector4>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CF00 Offset: 0x2D001 VA: 0x2CF00
	// RVA: -1 Offset: -1
	public void .ctor(Func<UniTask<T>> factory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3587540 Offset: 0x3587641 VA: 0x3587540
	|-UniTask<UniTask<object>>..ctor
	|
	|-RVA: 0x3588090 Offset: 0x3588191 VA: 0x3588090
	|-UniTask<ValueTuple<bool, UniTask<object>>>..ctor
	|
	|-RVA: 0x3588CC0 Offset: 0x3588DC1 VA: 0x3588CC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>..ctor
	|
	|-RVA: 0x3589950 Offset: 0x3589A51 VA: 0x3589950
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..ctor
	|
	|-RVA: 0x358A680 Offset: 0x358A781 VA: 0x358A680
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..ctor
	|
	|-RVA: 0x302D9F0 Offset: 0x302DAF1 VA: 0x302D9F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..ctor
	|
	|-RVA: 0x302E470 Offset: 0x302E571 VA: 0x302E470
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..ctor
	|
	|-RVA: 0x302EF10 Offset: 0x302F011 VA: 0x302EF10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..ctor
	|
	|-RVA: 0x302FCA0 Offset: 0x302FDA1 VA: 0x302FCA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..ctor
	|
	|-RVA: 0x3030740 Offset: 0x3030841 VA: 0x3030740
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..ctor
	|
	|-RVA: 0x3031450 Offset: 0x3031551 VA: 0x3031450
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..ctor
	|
	|-RVA: 0x3032160 Offset: 0x3032261 VA: 0x3032160
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..ctor
	|
	|-RVA: 0x3032C30 Offset: 0x3032D31 VA: 0x3032C30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..ctor
	|
	|-RVA: 0x30337E0 Offset: 0x30338E1 VA: 0x30337E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x3034380 Offset: 0x3034481 VA: 0x3034380
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..ctor
	|
	|-RVA: 0x3034F30 Offset: 0x3035031 VA: 0x3034F30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..ctor
	|
	|-RVA: 0x3035AC0 Offset: 0x3035BC1 VA: 0x3035AC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..ctor
	|
	|-RVA: 0x30365A0 Offset: 0x30366A1 VA: 0x30365A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..ctor
	|
	|-RVA: 0x3037120 Offset: 0x3037221 VA: 0x3037120
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..ctor
	|
	|-RVA: 0x3037AF0 Offset: 0x3037BF1 VA: 0x3037AF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..ctor
	|
	|-RVA: 0x3038630 Offset: 0x3038731 VA: 0x3038630
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..ctor
	|
	|-RVA: 0x3039130 Offset: 0x3039231 VA: 0x3039130
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..ctor
	|
	|-RVA: 0x3039CF0 Offset: 0x3039DF1 VA: 0x3039CF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..ctor
	|
	|-RVA: 0x303A8A0 Offset: 0x303A9A1 VA: 0x303A8A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..ctor
	|
	|-RVA: 0x303B5D0 Offset: 0x303B6D1 VA: 0x303B5D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303C390 Offset: 0x303C491 VA: 0x303C390
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303D180 Offset: 0x303D281 VA: 0x303D180
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303DFF0 Offset: 0x303E0F1 VA: 0x303DFF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303EE80 Offset: 0x303EF81 VA: 0x303EE80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x303FBD0 Offset: 0x303FCD1 VA: 0x303FBD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..ctor
	|
	|-RVA: 0x3040650 Offset: 0x3040751 VA: 0x3040650
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..ctor
	|
	|-RVA: 0x30410F0 Offset: 0x30411F1 VA: 0x30410F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..ctor
	|
	|-RVA: 0x3041E10 Offset: 0x3041F11 VA: 0x3041E10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..ctor
	|
	|-RVA: 0x3042890 Offset: 0x3042991 VA: 0x3042890
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..ctor
	|
	|-RVA: 0x3043510 Offset: 0x3043611 VA: 0x3043510
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..ctor
	|
	|-RVA: 0x3044200 Offset: 0x3044301 VA: 0x3044200
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..ctor
	|
	|-RVA: 0x2A969D0 Offset: 0x2A96AD1 VA: 0x2A969D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..ctor
	|
	|-RVA: 0x2A976F0 Offset: 0x2A977F1 VA: 0x2A976F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2A983E0 Offset: 0x2A984E1 VA: 0x2A983E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..ctor
	|
	|-RVA: 0x2A99040 Offset: 0x2A99141 VA: 0x2A99040
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..ctor
	|
	|-RVA: 0x2A99CA0 Offset: 0x2A99DA1 VA: 0x2A99CA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..ctor
	|
	|-RVA: 0x2A9A8C0 Offset: 0x2A9A9C1 VA: 0x2A9A8C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..ctor
	|
	|-RVA: 0x2A9B5B0 Offset: 0x2A9B6B1 VA: 0x2A9B5B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..ctor
	|
	|-RVA: 0x2A9C020 Offset: 0x2A9C121 VA: 0x2A9C020
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..ctor
	|
	|-RVA: 0x2A9CC70 Offset: 0x2A9CD71 VA: 0x2A9CC70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..ctor
	|
	|-RVA: 0x2A9D920 Offset: 0x2A9DA21 VA: 0x2A9D920
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..ctor
	|
	|-RVA: 0x2A9E5B0 Offset: 0x2A9E6B1 VA: 0x2A9E5B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..ctor
	|
	|-RVA: 0x2A9F2D0 Offset: 0x2A9F3D1 VA: 0x2A9F2D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..ctor
	|
	|-RVA: 0x2A9FFF0 Offset: 0x2AA00F1 VA: 0x2A9FFF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA0E10 Offset: 0x2AA0F11 VA: 0x2AA0E10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA1B80 Offset: 0x2AA1C81 VA: 0x2AA1B80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA2A70 Offset: 0x2AA2B71 VA: 0x2AA2A70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA3890 Offset: 0x2AA3991 VA: 0x2AA3890
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA4850 Offset: 0x2AA4951 VA: 0x2AA4850
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA56C0 Offset: 0x2AA57C1 VA: 0x2AA56C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA6750 Offset: 0x2AA6851 VA: 0x2AA6750
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA7660 Offset: 0x2AA7761 VA: 0x2AA7660
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2AA86D0 Offset: 0x2AA87D1 VA: 0x2AA86D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2AA98D0 Offset: 0x2AA99D1 VA: 0x2AA98D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..ctor
	|
	|-RVA: 0x2AAA340 Offset: 0x2AAA441 VA: 0x2AAA340
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>..ctor
	|
	|-RVA: 0x2AAADE0 Offset: 0x2AAAEE1 VA: 0x2AAADE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>..ctor
	|
	|-RVA: 0x2AABAE0 Offset: 0x2AABBE1 VA: 0x2AABAE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>..ctor
	|
	|-RVA: 0x2AAC580 Offset: 0x2AAC681 VA: 0x2AAC580
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>..ctor
	|
	|-RVA: 0x2AAD230 Offset: 0x2AAD331 VA: 0x2AAD230
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>..ctor
	|
	|-RVA: 0x2AADE80 Offset: 0x2AADF81 VA: 0x2AADE80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>..ctor
	|
	|-RVA: 0x2AAE9B0 Offset: 0x2AAEAB1 VA: 0x2AAE9B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>..ctor
	|
	|-RVA: 0x2AAF630 Offset: 0x2AAF731 VA: 0x2AAF630
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2AB02B0 Offset: 0x2AB03B1 VA: 0x2AB02B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..ctor
	|
	|-RVA: 0x2AB0F70 Offset: 0x2AB1071 VA: 0x2AB0F70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>..ctor
	|
	|-RVA: 0x2AB1C00 Offset: 0x2AB1D01 VA: 0x2AB1C00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>..ctor
	|
	|-RVA: 0x2AB2750 Offset: 0x2AB2851 VA: 0x2AB2750
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>..ctor
	|
	|-RVA: 0x2AB33A0 Offset: 0x2AB34A1 VA: 0x2AB33A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>..ctor
	|
	|-RVA: 0x2AB3E30 Offset: 0x2AB3F31 VA: 0x2AB3E30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>..ctor
	|
	|-RVA: 0x2AB4A10 Offset: 0x2AB4B11 VA: 0x2AB4A10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>..ctor
	|
	|-RVA: 0x2AB5650 Offset: 0x2AB5751 VA: 0x2AB5650
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>..ctor
	|
	|-RVA: 0x2AB6320 Offset: 0x2AB6421 VA: 0x2AB6320
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>..ctor
	|
	|-RVA: 0x2AB6FB0 Offset: 0x2AB70B1 VA: 0x2AB6FB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>..ctor
	|
	|-RVA: 0x2AB7C40 Offset: 0x2AB7D41 VA: 0x2AB7C40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2AB8A60 Offset: 0x2AB8B61 VA: 0x2AB8A60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>..ctor
	|
	|-RVA: 0x2AB9790 Offset: 0x2AB9891 VA: 0x2AB9790
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2ABA6A0 Offset: 0x2ABA7A1 VA: 0x2ABA6A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2ABB410 Offset: 0x2ABB511 VA: 0x2ABB410
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2ABC3F0 Offset: 0x2ABC4F1 VA: 0x2ABC3F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2ABD220 Offset: 0x2ABD321 VA: 0x2ABD220
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2ABE300 Offset: 0x2ABE401 VA: 0x2ABE300
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2ABF180 Offset: 0x2ABF281 VA: 0x2ABF180
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2AC0320 Offset: 0x2AC0421 VA: 0x2AC0320
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2AC1240 Offset: 0x2AC1341 VA: 0x2AC1240
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2CB8F60 Offset: 0x2CB9061 VA: 0x2CB8F60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2CB9D40 Offset: 0x2CB9E41 VA: 0x2CB9D40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x2CBA7D0 Offset: 0x2CBA8D1 VA: 0x2CBA7D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x2CBB260 Offset: 0x2CBB361 VA: 0x2CBB260
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>..ctor
	|
	|-RVA: 0x2CBBEC0 Offset: 0x2CBBFC1 VA: 0x2CBBEC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>..ctor
	|
	|-RVA: 0x2CBC950 Offset: 0x2CBCA51 VA: 0x2CBC950
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>..ctor
	|
	|-RVA: 0x2CBD580 Offset: 0x2CBD681 VA: 0x2CBD580
	|-UniTask<ValueTuple<bool, ValueTuple<bool, double>>>..ctor
	|
	|-RVA: 0x2CBE180 Offset: 0x2CBE281 VA: 0x2CBE180
	|-UniTask<ValueTuple<bool, ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x2CBEC70 Offset: 0x2CBED71 VA: 0x2CBEC70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, long>>>..ctor
	|
	|-RVA: 0x2CBF890 Offset: 0x2CBF991 VA: 0x2CBF890
	|-UniTask<ValueTuple<bool, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2CC0490 Offset: 0x2CC0591 VA: 0x2CC0490
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>..ctor
	|
	|-RVA: 0x2CC10C0 Offset: 0x2CC11C1 VA: 0x2CC10C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>..ctor
	|
	|-RVA: 0x2CC1CF0 Offset: 0x2CC1DF1 VA: 0x2CC1CF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x2CC2800 Offset: 0x2CC2901 VA: 0x2CC2800
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>..ctor
	|
	|-RVA: 0x2CC3400 Offset: 0x2CC3501 VA: 0x2CC3400
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>..ctor
	|
	|-RVA: 0x2CC3E80 Offset: 0x2CC3F81 VA: 0x2CC3E80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x2CC49B0 Offset: 0x2CC4AB1 VA: 0x2CC49B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>..ctor
	|
	|-RVA: 0x2CC55A0 Offset: 0x2CC56A1 VA: 0x2CC55A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>..ctor
	|
	|-RVA: 0x2CC61F0 Offset: 0x2CC62F1 VA: 0x2CC61F0
	|-UniTask<ValueTuple<bool, ValueTuple<int, object>>>..ctor
	|
	|-RVA: 0x2CC6E20 Offset: 0x2CC6F21 VA: 0x2CC6E20
	|-UniTask<ValueTuple<bool, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x2CC7A50 Offset: 0x2CC7B51 VA: 0x2CC7A50
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CC87C0 Offset: 0x2CC88C1 VA: 0x2CC87C0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>..ctor
	|
	|-RVA: 0x2CC9450 Offset: 0x2CC9551 VA: 0x2CC9450
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CCA2B0 Offset: 0x2CCA3B1 VA: 0x2CCA2B0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>..ctor
	|
	|-RVA: 0x2CCAFD0 Offset: 0x2CCB0D1 VA: 0x2CCAFD0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CCBF10 Offset: 0x2CCC011 VA: 0x2CCBF10
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2CCCC80 Offset: 0x2CCCD81 VA: 0x2CCCC80
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CCDCA0 Offset: 0x2CCDDA1 VA: 0x2CCDCA0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2CCEAD0 Offset: 0x2CCEBD1 VA: 0x2CCEAD0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2CCFBF0 Offset: 0x2CCFCF1 VA: 0x2CCFBF0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x2CD0A60 Offset: 0x2CD0B61 VA: 0x2CD0A60
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2CD1B40 Offset: 0x2CD1C41 VA: 0x2CD1B40
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2CD2920 Offset: 0x2CD2A21 VA: 0x2CD2920
	|-UniTask<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x2CD33A0 Offset: 0x2CD34A1 VA: 0x2CD33A0
	|-UniTask<ValueTuple<bool, bool>>..ctor
	|
	|-RVA: 0x2CD3E50 Offset: 0x2CD3F51 VA: 0x2CD3E50
	|-UniTask<ValueTuple<bool, Bounds>>..ctor
	|
	|-RVA: 0x2CD4AE0 Offset: 0x2CD4BE1 VA: 0x2CD4AE0
	|-UniTask<ValueTuple<bool, byte>>..ctor
	|
	|-RVA: 0x2CD5570 Offset: 0x2CD5671 VA: 0x2CD5570
	|-UniTask<ValueTuple<bool, Color>>..ctor
	|
	|-RVA: 0x2CD6140 Offset: 0x2CD6241 VA: 0x2CD6140
	|-UniTask<ValueTuple<bool, double>>..ctor
	|
	|-RVA: 0x2CD6C50 Offset: 0x2CD6D51 VA: 0x2CD6C50
	|-UniTask<ValueTuple<bool, int>>..ctor
	|
	|-RVA: 0x2CD76A0 Offset: 0x2CD77A1 VA: 0x2CD76A0
	|-UniTask<ValueTuple<bool, long>>..ctor
	|
	|-RVA: 0x2CD81E0 Offset: 0x2CD82E1 VA: 0x2CD81E0
	|-UniTask<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2CD8D00 Offset: 0x2CD8E01 VA: 0x2CD8D00
	|-UniTask<ValueTuple<bool, Quaternion>>..ctor
	|
	|-RVA: 0x2CD98E0 Offset: 0x2CD99E1 VA: 0x2CD98E0
	|-UniTask<ValueTuple<bool, Rect>>..ctor
	|
	|-RVA: 0x2CDA4B0 Offset: 0x2CDA5B1 VA: 0x2CDA4B0
	|-UniTask<ValueTuple<bool, float>>..ctor
	|
	|-RVA: 0x2CDAF30 Offset: 0x2CDB031 VA: 0x2CDAF30
	|-UniTask<ValueTuple<bool, UniTask>>..ctor
	|
	|-RVA: 0x2CDBA40 Offset: 0x2CDBB41 VA: 0x2CDBA40
	|-UniTask<ValueTuple<bool, Unit>>..ctor
	|
	|-RVA: 0x2CDC4D0 Offset: 0x2CDC5D1 VA: 0x2CDC4D0
	|-UniTask<ValueTuple<bool, Vector2>>..ctor
	|
	|-RVA: 0x2CDCFA0 Offset: 0x2CDD0A1 VA: 0x2CDCFA0
	|-UniTask<ValueTuple<bool, Vector3>>..ctor
	|
	|-RVA: 0x2CDDAC0 Offset: 0x2CDDBC1 VA: 0x2CDDAC0
	|-UniTask<ValueTuple<bool, Vector4>>..ctor
	|
	|-RVA: 0x2CDE6C0 Offset: 0x2CDE7C1 VA: 0x2CDE6C0
	|-UniTask<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x2CDF200 Offset: 0x2CDF301 VA: 0x2CDF200
	|-UniTask<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2CDFD50 Offset: 0x2CDFE51 VA: 0x2CDFD50
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2CE0A70 Offset: 0x2CE0B71 VA: 0x2CE0A70
	|-UniTask<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2CE16A0 Offset: 0x2CE17A1 VA: 0x2CE16A0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2DDD980 Offset: 0x2DDDA81 VA: 0x2DDD980
	|-UniTask<ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x2DDE610 Offset: 0x2DDE711 VA: 0x2DDE610
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2DDF510 Offset: 0x2DDF611 VA: 0x2DDF510
	|-UniTask<ValueTuple<object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2DE0230 Offset: 0x2DE0331 VA: 0x2DE0230
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2DE1200 Offset: 0x2DE1301 VA: 0x2DE1200
	|-UniTask<ValueTuple<object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2DE1F70 Offset: 0x2DE2071 VA: 0x2DE1F70
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x2DE3040 Offset: 0x2DE3141 VA: 0x2DE3040
	|-UniTask<ValueTuple<object, object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x2DE3E60 Offset: 0x2DE3F61 VA: 0x2DE3E60
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2DE5010 Offset: 0x2DE5111 VA: 0x2DE5010
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2DE5DF0 Offset: 0x2DE5EF1 VA: 0x2DE5DF0
	|-UniTask<AsyncUnit>..ctor
	|
	|-RVA: 0x2DE67C0 Offset: 0x2DE68C1 VA: 0x2DE67C0
	|-UniTask<bool>..ctor
	|
	|-RVA: 0x2DE7180 Offset: 0x2DE7281 VA: 0x2DE7180
	|-UniTask<Bounds>..ctor
	|
	|-RVA: 0x2DE7CE0 Offset: 0x2DE7DE1 VA: 0x2DE7CE0
	|-UniTask<byte>..ctor
	|
	|-RVA: 0x2DE86A0 Offset: 0x2DE87A1 VA: 0x2DE86A0
	|-UniTask<Color>..ctor
	|
	|-RVA: 0x2DE9150 Offset: 0x2DE9251 VA: 0x2DE9150
	|-UniTask<double>..ctor
	|
	|-RVA: 0x2DE9B20 Offset: 0x2DE9C21 VA: 0x2DE9B20
	|-UniTask<int>..ctor
	|
	|-RVA: 0x2DEA4D0 Offset: 0x2DEA5D1 VA: 0x2DEA4D0
	|-UniTask<long>..ctor
	|
	|-RVA: 0x2DEAEC0 Offset: 0x2DEAFC1 VA: 0x2DEAEC0
	|-UniTask<object>..ctor
	|
	|-RVA: 0x2DEB870 Offset: 0x2DEB971 VA: 0x2DEB870
	|-UniTask<Quaternion>..ctor
	|
	|-RVA: 0x2DEC330 Offset: 0x2DEC431 VA: 0x2DEC330
	|-UniTask<Rect>..ctor
	|
	|-RVA: 0x2DECDE0 Offset: 0x2DECEE1 VA: 0x2DECDE0
	|-UniTask<float>..ctor
	|
	|-RVA: 0x2DED7D0 Offset: 0x2DED8D1 VA: 0x2DED7D0
	|-UniTask<UniTask>..ctor
	|
	|-RVA: 0x2DEE1A0 Offset: 0x2DEE2A1 VA: 0x2DEE1A0
	|-UniTask<Unit>..ctor
	|
	|-RVA: 0x2DEEB70 Offset: 0x2DEEC71 VA: 0x2DEEB70
	|-UniTask<Vector2>..ctor
	|
	|-RVA: 0x2DEF580 Offset: 0x2DEF681 VA: 0x2DEF580
	|-UniTask<Vector3>..ctor
	|
	|-RVA: 0x2DEFFD0 Offset: 0x2DF00D1 VA: 0x2DEFFD0
	|-UniTask<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	public AwaiterStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3587610 Offset: 0x3587711 VA: 0x3587610
	|-UniTask<UniTask<object>>.get_Status
	|
	|-RVA: 0x3588160 Offset: 0x3588261 VA: 0x3588160
	|-UniTask<ValueTuple<bool, UniTask<object>>>.get_Status
	|
	|-RVA: 0x3588D90 Offset: 0x3588E91 VA: 0x3588D90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.get_Status
	|
	|-RVA: 0x3589A20 Offset: 0x3589B21 VA: 0x3589A20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.get_Status
	|
	|-RVA: 0x358A750 Offset: 0x358A851 VA: 0x358A750
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.get_Status
	|
	|-RVA: 0x302DAC0 Offset: 0x302DBC1 VA: 0x302DAC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.get_Status
	|
	|-RVA: 0x302E540 Offset: 0x302E641 VA: 0x302E540
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.get_Status
	|
	|-RVA: 0x302EFF0 Offset: 0x302F0F1 VA: 0x302EFF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.get_Status
	|
	|-RVA: 0x302FD70 Offset: 0x302FE71 VA: 0x302FD70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.get_Status
	|
	|-RVA: 0x3030810 Offset: 0x3030911 VA: 0x3030810
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.get_Status
	|
	|-RVA: 0x3031520 Offset: 0x3031621 VA: 0x3031520
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.get_Status
	|
	|-RVA: 0x3032230 Offset: 0x3032331 VA: 0x3032230
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.get_Status
	|
	|-RVA: 0x3032D00 Offset: 0x3032E01 VA: 0x3032D00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.get_Status
	|
	|-RVA: 0x30338B0 Offset: 0x30339B1 VA: 0x30338B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x3034450 Offset: 0x3034551 VA: 0x3034450
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.get_Status
	|
	|-RVA: 0x3035000 Offset: 0x3035101 VA: 0x3035000
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.get_Status
	|
	|-RVA: 0x3035B90 Offset: 0x3035C91 VA: 0x3035B90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.get_Status
	|
	|-RVA: 0x3036670 Offset: 0x3036771 VA: 0x3036670
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.get_Status
	|
	|-RVA: 0x30371F0 Offset: 0x30372F1 VA: 0x30371F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.get_Status
	|
	|-RVA: 0x3037BC0 Offset: 0x3037CC1 VA: 0x3037BC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.get_Status
	|
	|-RVA: 0x3038700 Offset: 0x3038801 VA: 0x3038700
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.get_Status
	|
	|-RVA: 0x3039200 Offset: 0x3039301 VA: 0x3039200
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.get_Status
	|
	|-RVA: 0x3039DC0 Offset: 0x3039EC1 VA: 0x3039DC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.get_Status
	|
	|-RVA: 0x303A970 Offset: 0x303AA71 VA: 0x303A970
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.get_Status
	|
	|-RVA: 0x303B6B0 Offset: 0x303B7B1 VA: 0x303B6B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x303C470 Offset: 0x303C571 VA: 0x303C470
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x303D260 Offset: 0x303D361 VA: 0x303D260
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x303E0D0 Offset: 0x303E1D1 VA: 0x303E0D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x303EF60 Offset: 0x303F061 VA: 0x303EF60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.get_Status
	|
	|-RVA: 0x303FCA0 Offset: 0x303FDA1 VA: 0x303FCA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.get_Status
	|
	|-RVA: 0x3040720 Offset: 0x3040821 VA: 0x3040720
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.get_Status
	|
	|-RVA: 0x30411C0 Offset: 0x30412C1 VA: 0x30411C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.get_Status
	|
	|-RVA: 0x3041EE0 Offset: 0x3041FE1 VA: 0x3041EE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.get_Status
	|
	|-RVA: 0x3042960 Offset: 0x3042A61 VA: 0x3042960
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.get_Status
	|
	|-RVA: 0x30435E0 Offset: 0x30436E1 VA: 0x30435E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.get_Status
	|
	|-RVA: 0x30442D0 Offset: 0x30443D1 VA: 0x30442D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.get_Status
	|
	|-RVA: 0x2A96AA0 Offset: 0x2A96BA1 VA: 0x2A96AA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.get_Status
	|
	|-RVA: 0x2A977C0 Offset: 0x2A978C1 VA: 0x2A977C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2A984B0 Offset: 0x2A985B1 VA: 0x2A984B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.get_Status
	|
	|-RVA: 0x2A99110 Offset: 0x2A99211 VA: 0x2A99110
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.get_Status
	|
	|-RVA: 0x2A99D70 Offset: 0x2A99E71 VA: 0x2A99D70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.get_Status
	|
	|-RVA: 0x2A9A990 Offset: 0x2A9AA91 VA: 0x2A9A990
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.get_Status
	|
	|-RVA: 0x2A9B680 Offset: 0x2A9B781 VA: 0x2A9B680
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.get_Status
	|
	|-RVA: 0x2A9C0F0 Offset: 0x2A9C1F1 VA: 0x2A9C0F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.get_Status
	|
	|-RVA: 0x2A9CD40 Offset: 0x2A9CE41 VA: 0x2A9CD40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.get_Status
	|
	|-RVA: 0x2A9D9F0 Offset: 0x2A9DAF1 VA: 0x2A9D9F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.get_Status
	|
	|-RVA: 0x2A9E680 Offset: 0x2A9E781 VA: 0x2A9E680
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.get_Status
	|
	|-RVA: 0x2A9F3A0 Offset: 0x2A9F4A1 VA: 0x2A9F3A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.get_Status
	|
	|-RVA: 0x2AA00D0 Offset: 0x2AA01D1 VA: 0x2AA00D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2AA0EE0 Offset: 0x2AA0FE1 VA: 0x2AA0EE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.get_Status
	|
	|-RVA: 0x2AA1C60 Offset: 0x2AA1D61 VA: 0x2AA1C60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2AA2B50 Offset: 0x2AA2C51 VA: 0x2AA2B50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x2AA3970 Offset: 0x2AA3A71 VA: 0x2AA3970
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2AA4930 Offset: 0x2AA4A31 VA: 0x2AA4930
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x2AA57A0 Offset: 0x2AA58A1 VA: 0x2AA57A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2AA6830 Offset: 0x2AA6931 VA: 0x2AA6830
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x2AA7750 Offset: 0x2AA7851 VA: 0x2AA7750
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2AA87B0 Offset: 0x2AA88B1 VA: 0x2AA87B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.get_Status
	|
	|-RVA: 0x2AA99A0 Offset: 0x2AA9AA1 VA: 0x2AA99A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.get_Status
	|
	|-RVA: 0x2AAA410 Offset: 0x2AAA511 VA: 0x2AAA410
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.get_Status
	|
	|-RVA: 0x2AAAEB0 Offset: 0x2AAAFB1 VA: 0x2AAAEB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.get_Status
	|
	|-RVA: 0x2AABBB0 Offset: 0x2AABCB1 VA: 0x2AABBB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.get_Status
	|
	|-RVA: 0x2AAC650 Offset: 0x2AAC751 VA: 0x2AAC650
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.get_Status
	|
	|-RVA: 0x2AAD300 Offset: 0x2AAD401 VA: 0x2AAD300
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.get_Status
	|
	|-RVA: 0x2AADF50 Offset: 0x2AAE051 VA: 0x2AADF50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.get_Status
	|
	|-RVA: 0x2AAEA80 Offset: 0x2AAEB81 VA: 0x2AAEA80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.get_Status
	|
	|-RVA: 0x2AAF700 Offset: 0x2AAF801 VA: 0x2AAF700
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2AB0380 Offset: 0x2AB0481 VA: 0x2AB0380
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.get_Status
	|
	|-RVA: 0x2AB1040 Offset: 0x2AB1141 VA: 0x2AB1040
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.get_Status
	|
	|-RVA: 0x2AB1CD0 Offset: 0x2AB1DD1 VA: 0x2AB1CD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.get_Status
	|
	|-RVA: 0x2AB2820 Offset: 0x2AB2921 VA: 0x2AB2820
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.get_Status
	|
	|-RVA: 0x2AB3470 Offset: 0x2AB3571 VA: 0x2AB3470
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.get_Status
	|
	|-RVA: 0x2AB3F00 Offset: 0x2AB4001 VA: 0x2AB3F00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.get_Status
	|
	|-RVA: 0x2AB4AE0 Offset: 0x2AB4BE1 VA: 0x2AB4AE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.get_Status
	|
	|-RVA: 0x2AB5720 Offset: 0x2AB5821 VA: 0x2AB5720
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.get_Status
	|
	|-RVA: 0x2AB63F0 Offset: 0x2AB64F1 VA: 0x2AB63F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.get_Status
	|
	|-RVA: 0x2AB7080 Offset: 0x2AB7181 VA: 0x2AB7080
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.get_Status
	|
	|-RVA: 0x2AB7D20 Offset: 0x2AB7E21 VA: 0x2AB7D20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2AB8B30 Offset: 0x2AB8C31 VA: 0x2AB8B30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.get_Status
	|
	|-RVA: 0x2AB9870 Offset: 0x2AB9971 VA: 0x2AB9870
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2ABA770 Offset: 0x2ABA871 VA: 0x2ABA770
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x2ABB4F0 Offset: 0x2ABB5F1 VA: 0x2ABB4F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2ABC4D0 Offset: 0x2ABC5D1 VA: 0x2ABC4D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x2ABD300 Offset: 0x2ABD401 VA: 0x2ABD300
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2ABE3E0 Offset: 0x2ABE4E1 VA: 0x2ABE3E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x2ABF270 Offset: 0x2ABF371 VA: 0x2ABF270
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2AC0400 Offset: 0x2AC0501 VA: 0x2AC0400
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.get_Status
	|
	|-RVA: 0x2AC1330 Offset: 0x2AC1431 VA: 0x2AC1330
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2CB9050 Offset: 0x2CB9151 VA: 0x2CB9050
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Status
	|
	|-RVA: 0x2CB9E10 Offset: 0x2CB9F11 VA: 0x2CB9E10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_Status
	|
	|-RVA: 0x2CBA8A0 Offset: 0x2CBA9A1 VA: 0x2CBA8A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>.get_Status
	|
	|-RVA: 0x2CBB330 Offset: 0x2CBB431 VA: 0x2CBB330
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>.get_Status
	|
	|-RVA: 0x2CBBF90 Offset: 0x2CBC091 VA: 0x2CBBF90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>.get_Status
	|
	|-RVA: 0x2CBCA20 Offset: 0x2CBCB21 VA: 0x2CBCA20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>.get_Status
	|
	|-RVA: 0x2CBD650 Offset: 0x2CBD751 VA: 0x2CBD650
	|-UniTask<ValueTuple<bool, ValueTuple<bool, double>>>.get_Status
	|
	|-RVA: 0x2CBE250 Offset: 0x2CBE351 VA: 0x2CBE250
	|-UniTask<ValueTuple<bool, ValueTuple<bool, int>>>.get_Status
	|
	|-RVA: 0x2CBED40 Offset: 0x2CBEE41 VA: 0x2CBED40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, long>>>.get_Status
	|
	|-RVA: 0x2CBF960 Offset: 0x2CBFA61 VA: 0x2CBF960
	|-UniTask<ValueTuple<bool, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2CC0560 Offset: 0x2CC0661 VA: 0x2CC0560
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.get_Status
	|
	|-RVA: 0x2CC1190 Offset: 0x2CC1291 VA: 0x2CC1190
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>.get_Status
	|
	|-RVA: 0x2CC1DC0 Offset: 0x2CC1EC1 VA: 0x2CC1DC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, float>>>.get_Status
	|
	|-RVA: 0x2CC28D0 Offset: 0x2CC29D1 VA: 0x2CC28D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>.get_Status
	|
	|-RVA: 0x2CC34D0 Offset: 0x2CC35D1 VA: 0x2CC34D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>.get_Status
	|
	|-RVA: 0x2CC3F50 Offset: 0x2CC4051 VA: 0x2CC3F50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>.get_Status
	|
	|-RVA: 0x2CC4A80 Offset: 0x2CC4B81 VA: 0x2CC4A80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>.get_Status
	|
	|-RVA: 0x2CC5670 Offset: 0x2CC5771 VA: 0x2CC5670
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>.get_Status
	|
	|-RVA: 0x2CC62C0 Offset: 0x2CC63C1 VA: 0x2CC62C0
	|-UniTask<ValueTuple<bool, ValueTuple<int, object>>>.get_Status
	|
	|-RVA: 0x2CC6EF0 Offset: 0x2CC6FF1 VA: 0x2CC6EF0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object>>>.get_Status
	|
	|-RVA: 0x2CC7B20 Offset: 0x2CC7C21 VA: 0x2CC7B20
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2CC8890 Offset: 0x2CC8991 VA: 0x2CC8890
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>.get_Status
	|
	|-RVA: 0x2CC9530 Offset: 0x2CC9631 VA: 0x2CC9530
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2CCA380 Offset: 0x2CCA481 VA: 0x2CCA380
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>.get_Status
	|
	|-RVA: 0x2CCB0B0 Offset: 0x2CCB1B1 VA: 0x2CCB0B0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2CCBFE0 Offset: 0x2CCC0E1 VA: 0x2CCBFE0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x2CCCD60 Offset: 0x2CCCE61 VA: 0x2CCCD60
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2CCDD80 Offset: 0x2CCDE81 VA: 0x2CCDD80
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x2CCEBB0 Offset: 0x2CCECB1 VA: 0x2CCEBB0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2CCFCD0 Offset: 0x2CCFDD1 VA: 0x2CCFCD0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.get_Status
	|
	|-RVA: 0x2CD0B50 Offset: 0x2CD0C51 VA: 0x2CD0B50
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2CD1C30 Offset: 0x2CD1D31 VA: 0x2CD1C30
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Status
	|
	|-RVA: 0x2CD29F0 Offset: 0x2CD2AF1 VA: 0x2CD29F0
	|-UniTask<ValueTuple<bool, AsyncUnit>>.get_Status
	|
	|-RVA: 0x2CD3470 Offset: 0x2CD3571 VA: 0x2CD3470
	|-UniTask<ValueTuple<bool, bool>>.get_Status
	|
	|-RVA: 0x2CD3F20 Offset: 0x2CD4021 VA: 0x2CD3F20
	|-UniTask<ValueTuple<bool, Bounds>>.get_Status
	|
	|-RVA: 0x2CD4BB0 Offset: 0x2CD4CB1 VA: 0x2CD4BB0
	|-UniTask<ValueTuple<bool, byte>>.get_Status
	|
	|-RVA: 0x2CD5640 Offset: 0x2CD5741 VA: 0x2CD5640
	|-UniTask<ValueTuple<bool, Color>>.get_Status
	|
	|-RVA: 0x2CD6210 Offset: 0x2CD6311 VA: 0x2CD6210
	|-UniTask<ValueTuple<bool, double>>.get_Status
	|
	|-RVA: 0x2CD6D20 Offset: 0x2CD6E21 VA: 0x2CD6D20
	|-UniTask<ValueTuple<bool, int>>.get_Status
	|
	|-RVA: 0x2CD7770 Offset: 0x2CD7871 VA: 0x2CD7770
	|-UniTask<ValueTuple<bool, long>>.get_Status
	|
	|-RVA: 0x2CD82B0 Offset: 0x2CD83B1 VA: 0x2CD82B0
	|-UniTask<ValueTuple<bool, object>>.get_Status
	|
	|-RVA: 0x2CD8DD0 Offset: 0x2CD8ED1 VA: 0x2CD8DD0
	|-UniTask<ValueTuple<bool, Quaternion>>.get_Status
	|
	|-RVA: 0x2CD99B0 Offset: 0x2CD9AB1 VA: 0x2CD99B0
	|-UniTask<ValueTuple<bool, Rect>>.get_Status
	|
	|-RVA: 0x2CDA580 Offset: 0x2CDA681 VA: 0x2CDA580
	|-UniTask<ValueTuple<bool, float>>.get_Status
	|
	|-RVA: 0x2CDB000 Offset: 0x2CDB101 VA: 0x2CDB000
	|-UniTask<ValueTuple<bool, UniTask>>.get_Status
	|
	|-RVA: 0x2CDBB10 Offset: 0x2CDBC11 VA: 0x2CDBB10
	|-UniTask<ValueTuple<bool, Unit>>.get_Status
	|
	|-RVA: 0x2CDC5A0 Offset: 0x2CDC6A1 VA: 0x2CDC5A0
	|-UniTask<ValueTuple<bool, Vector2>>.get_Status
	|
	|-RVA: 0x2CDD070 Offset: 0x2CDD171 VA: 0x2CDD070
	|-UniTask<ValueTuple<bool, Vector3>>.get_Status
	|
	|-RVA: 0x2CDDB90 Offset: 0x2CDDC91 VA: 0x2CDDB90
	|-UniTask<ValueTuple<bool, Vector4>>.get_Status
	|
	|-RVA: 0x2CDE790 Offset: 0x2CDE891 VA: 0x2CDE790
	|-UniTask<ValueTuple<int, object>>.get_Status
	|
	|-RVA: 0x2CDF2D0 Offset: 0x2CDF3D1 VA: 0x2CDF2D0
	|-UniTask<ValueTuple<object, object>>.get_Status
	|
	|-RVA: 0x2CDFE20 Offset: 0x2CDFF21 VA: 0x2CDFE20
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2CE0B40 Offset: 0x2CE0C41 VA: 0x2CE0B40
	|-UniTask<ValueTuple<object, object, object>>.get_Status
	|
	|-RVA: 0x2CE1780 Offset: 0x2CE1881 VA: 0x2CE1780
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2DDDA50 Offset: 0x2DDDB51 VA: 0x2DDDA50
	|-UniTask<ValueTuple<object, object, object, object>>.get_Status
	|
	|-RVA: 0x2DDE6F0 Offset: 0x2DDE7F1 VA: 0x2DDE6F0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2DDF5E0 Offset: 0x2DDF6E1 VA: 0x2DDF5E0
	|-UniTask<ValueTuple<object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x2DE0310 Offset: 0x2DE0411 VA: 0x2DE0310
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2DE12D0 Offset: 0x2DE13D1 VA: 0x2DE12D0
	|-UniTask<ValueTuple<object, object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x2DE2050 Offset: 0x2DE2151 VA: 0x2DE2050
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Status
	|
	|-RVA: 0x2DE3120 Offset: 0x2DE3221 VA: 0x2DE3120
	|-UniTask<ValueTuple<object, object, object, object, object, object, object>>.get_Status
	|
	|-RVA: 0x2DE3F50 Offset: 0x2DE4051 VA: 0x2DE3F50
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2DE5100 Offset: 0x2DE5201 VA: 0x2DE5100
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Status
	|
	|-RVA: 0x2DE5EC0 Offset: 0x2DE5FC1 VA: 0x2DE5EC0
	|-UniTask<AsyncUnit>.get_Status
	|
	|-RVA: 0x2DE6890 Offset: 0x2DE6991 VA: 0x2DE6890
	|-UniTask<bool>.get_Status
	|
	|-RVA: 0x2DE7250 Offset: 0x2DE7351 VA: 0x2DE7250
	|-UniTask<Bounds>.get_Status
	|
	|-RVA: 0x2DE7DB0 Offset: 0x2DE7EB1 VA: 0x2DE7DB0
	|-UniTask<byte>.get_Status
	|
	|-RVA: 0x2DE8770 Offset: 0x2DE8871 VA: 0x2DE8770
	|-UniTask<Color>.get_Status
	|
	|-RVA: 0x2DE9220 Offset: 0x2DE9321 VA: 0x2DE9220
	|-UniTask<double>.get_Status
	|
	|-RVA: 0x2DE9BF0 Offset: 0x2DE9CF1 VA: 0x2DE9BF0
	|-UniTask<int>.get_Status
	|
	|-RVA: 0x2DEA5A0 Offset: 0x2DEA6A1 VA: 0x2DEA5A0
	|-UniTask<long>.get_Status
	|
	|-RVA: 0x2DEAF90 Offset: 0x2DEB091 VA: 0x2DEAF90
	|-UniTask<object>.get_Status
	|
	|-RVA: 0x2DEB940 Offset: 0x2DEBA41 VA: 0x2DEB940
	|-UniTask<Quaternion>.get_Status
	|
	|-RVA: 0x2DEC400 Offset: 0x2DEC501 VA: 0x2DEC400
	|-UniTask<Rect>.get_Status
	|
	|-RVA: 0x2DECEB0 Offset: 0x2DECFB1 VA: 0x2DECEB0
	|-UniTask<float>.get_Status
	|
	|-RVA: 0x2DED8A0 Offset: 0x2DED9A1 VA: 0x2DED8A0
	|-UniTask<UniTask>.get_Status
	|
	|-RVA: 0x2DEE270 Offset: 0x2DEE371 VA: 0x2DEE270
	|-UniTask<Unit>.get_Status
	|
	|-RVA: 0x2DEEC40 Offset: 0x2DEED41 VA: 0x2DEEC40
	|-UniTask<Vector2>.get_Status
	|
	|-RVA: 0x2DEF650 Offset: 0x2DEF751 VA: 0x2DEF650
	|-UniTask<Vector3>.get_Status
	|
	|-RVA: 0x2DF00A0 Offset: 0x2DF01A1 VA: 0x2DF00A0
	|-UniTask<Vector4>.get_Status
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35876C0 Offset: 0x35877C1 VA: 0x35876C0
	|-UniTask<UniTask<object>>.get_IsCompleted
	|
	|-RVA: 0x3588210 Offset: 0x3588311 VA: 0x3588210
	|-UniTask<ValueTuple<bool, UniTask<object>>>.get_IsCompleted
	|
	|-RVA: 0x3588E40 Offset: 0x3588F41 VA: 0x3588E40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.get_IsCompleted
	|
	|-RVA: 0x3589AD0 Offset: 0x3589BD1 VA: 0x3589AD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.get_IsCompleted
	|
	|-RVA: 0x358A800 Offset: 0x358A901 VA: 0x358A800
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x302DB70 Offset: 0x302DC71 VA: 0x302DB70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.get_IsCompleted
	|
	|-RVA: 0x302E5F0 Offset: 0x302E6F1 VA: 0x302E5F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.get_IsCompleted
	|
	|-RVA: 0x302F0A0 Offset: 0x302F1A1 VA: 0x302F0A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.get_IsCompleted
	|
	|-RVA: 0x302FE20 Offset: 0x302FF21 VA: 0x302FE20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.get_IsCompleted
	|
	|-RVA: 0x30308C0 Offset: 0x30309C1 VA: 0x30308C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.get_IsCompleted
	|
	|-RVA: 0x30315D0 Offset: 0x30316D1 VA: 0x30315D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.get_IsCompleted
	|
	|-RVA: 0x30322E0 Offset: 0x30323E1 VA: 0x30322E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.get_IsCompleted
	|
	|-RVA: 0x3032DB0 Offset: 0x3032EB1 VA: 0x3032DB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.get_IsCompleted
	|
	|-RVA: 0x3033960 Offset: 0x3033A61 VA: 0x3033960
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x3034500 Offset: 0x3034601 VA: 0x3034500
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.get_IsCompleted
	|
	|-RVA: 0x30350B0 Offset: 0x30351B1 VA: 0x30350B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.get_IsCompleted
	|
	|-RVA: 0x3035C40 Offset: 0x3035D41 VA: 0x3035C40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.get_IsCompleted
	|
	|-RVA: 0x3036720 Offset: 0x3036821 VA: 0x3036720
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.get_IsCompleted
	|
	|-RVA: 0x30372A0 Offset: 0x30373A1 VA: 0x30372A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.get_IsCompleted
	|
	|-RVA: 0x3037C70 Offset: 0x3037D71 VA: 0x3037C70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.get_IsCompleted
	|
	|-RVA: 0x30387B0 Offset: 0x30388B1 VA: 0x30387B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.get_IsCompleted
	|
	|-RVA: 0x30392B0 Offset: 0x30393B1 VA: 0x30392B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.get_IsCompleted
	|
	|-RVA: 0x3039E70 Offset: 0x3039F71 VA: 0x3039E70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x303AA20 Offset: 0x303AB21 VA: 0x303AA20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x303B760 Offset: 0x303B861 VA: 0x303B760
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x303C520 Offset: 0x303C621 VA: 0x303C520
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x303D310 Offset: 0x303D411 VA: 0x303D310
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x303E180 Offset: 0x303E281 VA: 0x303E180
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x303F010 Offset: 0x303F111 VA: 0x303F010
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x303FD50 Offset: 0x303FE51 VA: 0x303FD50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.get_IsCompleted
	|
	|-RVA: 0x30407D0 Offset: 0x30408D1 VA: 0x30407D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.get_IsCompleted
	|
	|-RVA: 0x3041270 Offset: 0x3041371 VA: 0x3041270
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.get_IsCompleted
	|
	|-RVA: 0x3041F90 Offset: 0x3042091 VA: 0x3041F90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.get_IsCompleted
	|
	|-RVA: 0x3042A10 Offset: 0x3042B11 VA: 0x3042A10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.get_IsCompleted
	|
	|-RVA: 0x3043690 Offset: 0x3043791 VA: 0x3043690
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.get_IsCompleted
	|
	|-RVA: 0x3044380 Offset: 0x3044481 VA: 0x3044380
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.get_IsCompleted
	|
	|-RVA: 0x2A96B50 Offset: 0x2A96C51 VA: 0x2A96B50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.get_IsCompleted
	|
	|-RVA: 0x2A97870 Offset: 0x2A97971 VA: 0x2A97870
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2A98560 Offset: 0x2A98661 VA: 0x2A98560
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.get_IsCompleted
	|
	|-RVA: 0x2A991C0 Offset: 0x2A992C1 VA: 0x2A991C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.get_IsCompleted
	|
	|-RVA: 0x2A99E20 Offset: 0x2A99F21 VA: 0x2A99E20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.get_IsCompleted
	|
	|-RVA: 0x2A9AA40 Offset: 0x2A9AB41 VA: 0x2A9AA40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.get_IsCompleted
	|
	|-RVA: 0x2A9B730 Offset: 0x2A9B831 VA: 0x2A9B730
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.get_IsCompleted
	|
	|-RVA: 0x2A9C1A0 Offset: 0x2A9C2A1 VA: 0x2A9C1A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.get_IsCompleted
	|
	|-RVA: 0x2A9CDF0 Offset: 0x2A9CEF1 VA: 0x2A9CDF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.get_IsCompleted
	|
	|-RVA: 0x2A9DAA0 Offset: 0x2A9DBA1 VA: 0x2A9DAA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.get_IsCompleted
	|
	|-RVA: 0x2A9E730 Offset: 0x2A9E831 VA: 0x2A9E730
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2A9F450 Offset: 0x2A9F551 VA: 0x2A9F450
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AA0180 Offset: 0x2AA0281 VA: 0x2AA0180
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AA0F90 Offset: 0x2AA1091 VA: 0x2AA0F90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AA1D10 Offset: 0x2AA1E11 VA: 0x2AA1D10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AA2C00 Offset: 0x2AA2D01 VA: 0x2AA2C00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AA3A20 Offset: 0x2AA3B21 VA: 0x2AA3A20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AA49E0 Offset: 0x2AA4AE1 VA: 0x2AA49E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AA5850 Offset: 0x2AA5951 VA: 0x2AA5850
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AA68E0 Offset: 0x2AA69E1 VA: 0x2AA68E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AA7800 Offset: 0x2AA7901 VA: 0x2AA7800
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AA8860 Offset: 0x2AA8961 VA: 0x2AA8860
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AA9A50 Offset: 0x2AA9B51 VA: 0x2AA9A50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.get_IsCompleted
	|
	|-RVA: 0x2AAA4C0 Offset: 0x2AAA5C1 VA: 0x2AAA4C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.get_IsCompleted
	|
	|-RVA: 0x2AAAF60 Offset: 0x2AAB061 VA: 0x2AAAF60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.get_IsCompleted
	|
	|-RVA: 0x2AABC60 Offset: 0x2AABD61 VA: 0x2AABC60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.get_IsCompleted
	|
	|-RVA: 0x2AAC700 Offset: 0x2AAC801 VA: 0x2AAC700
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.get_IsCompleted
	|
	|-RVA: 0x2AAD3B0 Offset: 0x2AAD4B1 VA: 0x2AAD3B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.get_IsCompleted
	|
	|-RVA: 0x2AAE000 Offset: 0x2AAE101 VA: 0x2AAE000
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.get_IsCompleted
	|
	|-RVA: 0x2AAEB30 Offset: 0x2AAEC31 VA: 0x2AAEB30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.get_IsCompleted
	|
	|-RVA: 0x2AAF7B0 Offset: 0x2AAF8B1 VA: 0x2AAF7B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AB0430 Offset: 0x2AB0531 VA: 0x2AB0430
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.get_IsCompleted
	|
	|-RVA: 0x2AB10F0 Offset: 0x2AB11F1 VA: 0x2AB10F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.get_IsCompleted
	|
	|-RVA: 0x2AB1D80 Offset: 0x2AB1E81 VA: 0x2AB1D80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.get_IsCompleted
	|
	|-RVA: 0x2AB28D0 Offset: 0x2AB29D1 VA: 0x2AB28D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.get_IsCompleted
	|
	|-RVA: 0x2AB3520 Offset: 0x2AB3621 VA: 0x2AB3520
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.get_IsCompleted
	|
	|-RVA: 0x2AB3FB0 Offset: 0x2AB40B1 VA: 0x2AB3FB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.get_IsCompleted
	|
	|-RVA: 0x2AB4B90 Offset: 0x2AB4C91 VA: 0x2AB4B90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.get_IsCompleted
	|
	|-RVA: 0x2AB57D0 Offset: 0x2AB58D1 VA: 0x2AB57D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.get_IsCompleted
	|
	|-RVA: 0x2AB64A0 Offset: 0x2AB65A1 VA: 0x2AB64A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AB7130 Offset: 0x2AB7231 VA: 0x2AB7130
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AB7DD0 Offset: 0x2AB7ED1 VA: 0x2AB7DD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AB8BE0 Offset: 0x2AB8CE1 VA: 0x2AB8BE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AB9920 Offset: 0x2AB9A21 VA: 0x2AB9920
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2ABA820 Offset: 0x2ABA921 VA: 0x2ABA820
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2ABB5A0 Offset: 0x2ABB6A1 VA: 0x2ABB5A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2ABC580 Offset: 0x2ABC681 VA: 0x2ABC580
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2ABD3B0 Offset: 0x2ABD4B1 VA: 0x2ABD3B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2ABE490 Offset: 0x2ABE591 VA: 0x2ABE490
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2ABF320 Offset: 0x2ABF421 VA: 0x2ABF320
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC04B0 Offset: 0x2AC05B1 VA: 0x2AC04B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2AC13E0 Offset: 0x2AC14E1 VA: 0x2AC13E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2CB9100 Offset: 0x2CB9201 VA: 0x2CB9100
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_IsCompleted
	|
	|-RVA: 0x2CB9EC0 Offset: 0x2CB9FC1 VA: 0x2CB9EC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_IsCompleted
	|
	|-RVA: 0x2CBA950 Offset: 0x2CBAA51 VA: 0x2CBA950
	|-UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>.get_IsCompleted
	|
	|-RVA: 0x2CBB3E0 Offset: 0x2CBB4E1 VA: 0x2CBB3E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>.get_IsCompleted
	|
	|-RVA: 0x2CBC040 Offset: 0x2CBC141 VA: 0x2CBC040
	|-UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>.get_IsCompleted
	|
	|-RVA: 0x2CBCAD0 Offset: 0x2CBCBD1 VA: 0x2CBCAD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>.get_IsCompleted
	|
	|-RVA: 0x2CBD700 Offset: 0x2CBD801 VA: 0x2CBD700
	|-UniTask<ValueTuple<bool, ValueTuple<bool, double>>>.get_IsCompleted
	|
	|-RVA: 0x2CBE300 Offset: 0x2CBE401 VA: 0x2CBE300
	|-UniTask<ValueTuple<bool, ValueTuple<bool, int>>>.get_IsCompleted
	|
	|-RVA: 0x2CBEDF0 Offset: 0x2CBEEF1 VA: 0x2CBEDF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, long>>>.get_IsCompleted
	|
	|-RVA: 0x2CBFA10 Offset: 0x2CBFB11 VA: 0x2CBFA10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2CC0610 Offset: 0x2CC0711 VA: 0x2CC0610
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.get_IsCompleted
	|
	|-RVA: 0x2CC1240 Offset: 0x2CC1341 VA: 0x2CC1240
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>.get_IsCompleted
	|
	|-RVA: 0x2CC1E70 Offset: 0x2CC1F71 VA: 0x2CC1E70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, float>>>.get_IsCompleted
	|
	|-RVA: 0x2CC2980 Offset: 0x2CC2A81 VA: 0x2CC2980
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>.get_IsCompleted
	|
	|-RVA: 0x2CC3580 Offset: 0x2CC3681 VA: 0x2CC3580
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>.get_IsCompleted
	|
	|-RVA: 0x2CC4000 Offset: 0x2CC4101 VA: 0x2CC4000
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>.get_IsCompleted
	|
	|-RVA: 0x2CC4B30 Offset: 0x2CC4C31 VA: 0x2CC4B30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>.get_IsCompleted
	|
	|-RVA: 0x2CC5720 Offset: 0x2CC5821 VA: 0x2CC5720
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>.get_IsCompleted
	|
	|-RVA: 0x2CC6370 Offset: 0x2CC6471 VA: 0x2CC6370
	|-UniTask<ValueTuple<bool, ValueTuple<int, object>>>.get_IsCompleted
	|
	|-RVA: 0x2CC6FA0 Offset: 0x2CC70A1 VA: 0x2CC6FA0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2CC7BD0 Offset: 0x2CC7CD1 VA: 0x2CC7BD0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2CC8940 Offset: 0x2CC8A41 VA: 0x2CC8940
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2CC95E0 Offset: 0x2CC96E1 VA: 0x2CC95E0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2CCA430 Offset: 0x2CCA531 VA: 0x2CCA430
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2CCB160 Offset: 0x2CCB261 VA: 0x2CCB160
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2CCC090 Offset: 0x2CCC191 VA: 0x2CCC090
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2CCCE10 Offset: 0x2CCCF11 VA: 0x2CCCE10
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2CCDE30 Offset: 0x2CCDF31 VA: 0x2CCDE30
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2CCEC60 Offset: 0x2CCED61 VA: 0x2CCEC60
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2CCFD80 Offset: 0x2CCFE81 VA: 0x2CCFD80
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.get_IsCompleted
	|
	|-RVA: 0x2CD0C00 Offset: 0x2CD0D01 VA: 0x2CD0C00
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2CD1CE0 Offset: 0x2CD1DE1 VA: 0x2CD1CE0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_IsCompleted
	|
	|-RVA: 0x2CD2AA0 Offset: 0x2CD2BA1 VA: 0x2CD2AA0
	|-UniTask<ValueTuple<bool, AsyncUnit>>.get_IsCompleted
	|
	|-RVA: 0x2CD3520 Offset: 0x2CD3621 VA: 0x2CD3520
	|-UniTask<ValueTuple<bool, bool>>.get_IsCompleted
	|
	|-RVA: 0x2CD3FD0 Offset: 0x2CD40D1 VA: 0x2CD3FD0
	|-UniTask<ValueTuple<bool, Bounds>>.get_IsCompleted
	|
	|-RVA: 0x2CD4C60 Offset: 0x2CD4D61 VA: 0x2CD4C60
	|-UniTask<ValueTuple<bool, byte>>.get_IsCompleted
	|
	|-RVA: 0x2CD56F0 Offset: 0x2CD57F1 VA: 0x2CD56F0
	|-UniTask<ValueTuple<bool, Color>>.get_IsCompleted
	|
	|-RVA: 0x2CD62C0 Offset: 0x2CD63C1 VA: 0x2CD62C0
	|-UniTask<ValueTuple<bool, double>>.get_IsCompleted
	|
	|-RVA: 0x2CD6DD0 Offset: 0x2CD6ED1 VA: 0x2CD6DD0
	|-UniTask<ValueTuple<bool, int>>.get_IsCompleted
	|
	|-RVA: 0x2CD7820 Offset: 0x2CD7921 VA: 0x2CD7820
	|-UniTask<ValueTuple<bool, long>>.get_IsCompleted
	|
	|-RVA: 0x2CD8360 Offset: 0x2CD8461 VA: 0x2CD8360
	|-UniTask<ValueTuple<bool, object>>.get_IsCompleted
	|
	|-RVA: 0x2CD8E80 Offset: 0x2CD8F81 VA: 0x2CD8E80
	|-UniTask<ValueTuple<bool, Quaternion>>.get_IsCompleted
	|
	|-RVA: 0x2CD9A60 Offset: 0x2CD9B61 VA: 0x2CD9A60
	|-UniTask<ValueTuple<bool, Rect>>.get_IsCompleted
	|
	|-RVA: 0x2CDA630 Offset: 0x2CDA731 VA: 0x2CDA630
	|-UniTask<ValueTuple<bool, float>>.get_IsCompleted
	|
	|-RVA: 0x2CDB0B0 Offset: 0x2CDB1B1 VA: 0x2CDB0B0
	|-UniTask<ValueTuple<bool, UniTask>>.get_IsCompleted
	|
	|-RVA: 0x2CDBBC0 Offset: 0x2CDBCC1 VA: 0x2CDBBC0
	|-UniTask<ValueTuple<bool, Unit>>.get_IsCompleted
	|
	|-RVA: 0x2CDC650 Offset: 0x2CDC751 VA: 0x2CDC650
	|-UniTask<ValueTuple<bool, Vector2>>.get_IsCompleted
	|
	|-RVA: 0x2CDD120 Offset: 0x2CDD221 VA: 0x2CDD120
	|-UniTask<ValueTuple<bool, Vector3>>.get_IsCompleted
	|
	|-RVA: 0x2CDDC40 Offset: 0x2CDDD41 VA: 0x2CDDC40
	|-UniTask<ValueTuple<bool, Vector4>>.get_IsCompleted
	|
	|-RVA: 0x2CDE840 Offset: 0x2CDE941 VA: 0x2CDE840
	|-UniTask<ValueTuple<int, object>>.get_IsCompleted
	|
	|-RVA: 0x2CDF380 Offset: 0x2CDF481 VA: 0x2CDF380
	|-UniTask<ValueTuple<object, object>>.get_IsCompleted
	|
	|-RVA: 0x2CDFED0 Offset: 0x2CDFFD1 VA: 0x2CDFED0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2CE0BF0 Offset: 0x2CE0CF1 VA: 0x2CE0BF0
	|-UniTask<ValueTuple<object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2CE1830 Offset: 0x2CE1931 VA: 0x2CE1830
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2DDDB00 Offset: 0x2DDDC01 VA: 0x2DDDB00
	|-UniTask<ValueTuple<object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2DDE7A0 Offset: 0x2DDE8A1 VA: 0x2DDE7A0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2DDF690 Offset: 0x2DDF791 VA: 0x2DDF690
	|-UniTask<ValueTuple<object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2DE03C0 Offset: 0x2DE04C1 VA: 0x2DE03C0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2DE1380 Offset: 0x2DE1481 VA: 0x2DE1380
	|-UniTask<ValueTuple<object, object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2DE2100 Offset: 0x2DE2201 VA: 0x2DE2100
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_IsCompleted
	|
	|-RVA: 0x2DE31D0 Offset: 0x2DE32D1 VA: 0x2DE31D0
	|-UniTask<ValueTuple<object, object, object, object, object, object, object>>.get_IsCompleted
	|
	|-RVA: 0x2DE4000 Offset: 0x2DE4101 VA: 0x2DE4000
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2DE51B0 Offset: 0x2DE52B1 VA: 0x2DE51B0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_IsCompleted
	|
	|-RVA: 0x2DE5F70 Offset: 0x2DE6071 VA: 0x2DE5F70
	|-UniTask<AsyncUnit>.get_IsCompleted
	|
	|-RVA: 0x2DE6940 Offset: 0x2DE6A41 VA: 0x2DE6940
	|-UniTask<bool>.get_IsCompleted
	|
	|-RVA: 0x2DE7300 Offset: 0x2DE7401 VA: 0x2DE7300
	|-UniTask<Bounds>.get_IsCompleted
	|
	|-RVA: 0x2DE7E60 Offset: 0x2DE7F61 VA: 0x2DE7E60
	|-UniTask<byte>.get_IsCompleted
	|
	|-RVA: 0x2DE8820 Offset: 0x2DE8921 VA: 0x2DE8820
	|-UniTask<Color>.get_IsCompleted
	|
	|-RVA: 0x2DE92D0 Offset: 0x2DE93D1 VA: 0x2DE92D0
	|-UniTask<double>.get_IsCompleted
	|
	|-RVA: 0x2DE9CA0 Offset: 0x2DE9DA1 VA: 0x2DE9CA0
	|-UniTask<int>.get_IsCompleted
	|
	|-RVA: 0x2DEA650 Offset: 0x2DEA751 VA: 0x2DEA650
	|-UniTask<long>.get_IsCompleted
	|
	|-RVA: 0x2DEB040 Offset: 0x2DEB141 VA: 0x2DEB040
	|-UniTask<object>.get_IsCompleted
	|
	|-RVA: 0x2DEB9F0 Offset: 0x2DEBAF1 VA: 0x2DEB9F0
	|-UniTask<Quaternion>.get_IsCompleted
	|
	|-RVA: 0x2DEC4B0 Offset: 0x2DEC5B1 VA: 0x2DEC4B0
	|-UniTask<Rect>.get_IsCompleted
	|
	|-RVA: 0x2DECF60 Offset: 0x2DED061 VA: 0x2DECF60
	|-UniTask<float>.get_IsCompleted
	|
	|-RVA: 0x2DED950 Offset: 0x2DEDA51 VA: 0x2DED950
	|-UniTask<UniTask>.get_IsCompleted
	|
	|-RVA: 0x2DEE320 Offset: 0x2DEE421 VA: 0x2DEE320
	|-UniTask<Unit>.get_IsCompleted
	|
	|-RVA: 0x2DEECF0 Offset: 0x2DEEDF1 VA: 0x2DEECF0
	|-UniTask<Vector2>.get_IsCompleted
	|
	|-RVA: 0x2DEF700 Offset: 0x2DEF801 VA: 0x2DEF700
	|-UniTask<Vector3>.get_IsCompleted
	|
	|-RVA: 0x2DF0150 Offset: 0x2DF0251 VA: 0x2DF0150
	|-UniTask<Vector4>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public T get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3587780 Offset: 0x3587881 VA: 0x3587780
	|-UniTask<UniTask<object>>.get_Result
	|
	|-RVA: 0x35882D0 Offset: 0x35883D1 VA: 0x35882D0
	|-UniTask<ValueTuple<bool, UniTask<object>>>.get_Result
	|
	|-RVA: 0x3588F00 Offset: 0x3589001 VA: 0x3588F00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.get_Result
	|
	|-RVA: 0x3589B90 Offset: 0x3589C91 VA: 0x3589B90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.get_Result
	|
	|-RVA: 0x358A8C0 Offset: 0x358A9C1 VA: 0x358A8C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.get_Result
	|
	|-RVA: 0x302DC30 Offset: 0x302DD31 VA: 0x302DC30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.get_Result
	|
	|-RVA: 0x302E6B0 Offset: 0x302E7B1 VA: 0x302E6B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.get_Result
	|
	|-RVA: 0x302F160 Offset: 0x302F261 VA: 0x302F160
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.get_Result
	|
	|-RVA: 0x302FEE0 Offset: 0x302FFE1 VA: 0x302FEE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.get_Result
	|
	|-RVA: 0x3030980 Offset: 0x3030A81 VA: 0x3030980
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.get_Result
	|
	|-RVA: 0x3031690 Offset: 0x3031791 VA: 0x3031690
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.get_Result
	|
	|-RVA: 0x30323A0 Offset: 0x30324A1 VA: 0x30323A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.get_Result
	|
	|-RVA: 0x3032E70 Offset: 0x3032F71 VA: 0x3032E70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.get_Result
	|
	|-RVA: 0x3033A20 Offset: 0x3033B21 VA: 0x3033A20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.get_Result
	|
	|-RVA: 0x30345C0 Offset: 0x30346C1 VA: 0x30345C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.get_Result
	|
	|-RVA: 0x3035170 Offset: 0x3035271 VA: 0x3035170
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.get_Result
	|
	|-RVA: 0x3035D00 Offset: 0x3035E01 VA: 0x3035D00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.get_Result
	|
	|-RVA: 0x30367E0 Offset: 0x30368E1 VA: 0x30367E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.get_Result
	|
	|-RVA: 0x3037360 Offset: 0x3037461 VA: 0x3037360
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.get_Result
	|
	|-RVA: 0x3037D30 Offset: 0x3037E31 VA: 0x3037D30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.get_Result
	|
	|-RVA: 0x3038870 Offset: 0x3038971 VA: 0x3038870
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.get_Result
	|
	|-RVA: 0x3039370 Offset: 0x3039471 VA: 0x3039370
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.get_Result
	|
	|-RVA: 0x3039F30 Offset: 0x303A031 VA: 0x3039F30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.get_Result
	|
	|-RVA: 0x303AAE0 Offset: 0x303ABE1 VA: 0x303AAE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.get_Result
	|
	|-RVA: 0x303B820 Offset: 0x303B921 VA: 0x303B820
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.get_Result
	|
	|-RVA: 0x303C5E0 Offset: 0x303C6E1 VA: 0x303C5E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.get_Result
	|
	|-RVA: 0x303D3D0 Offset: 0x303D4D1 VA: 0x303D3D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.get_Result
	|
	|-RVA: 0x303E240 Offset: 0x303E341 VA: 0x303E240
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.get_Result
	|
	|-RVA: 0x303F0D0 Offset: 0x303F1D1 VA: 0x303F0D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.get_Result
	|
	|-RVA: 0x303FE10 Offset: 0x303FF11 VA: 0x303FE10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.get_Result
	|
	|-RVA: 0x3040890 Offset: 0x3040991 VA: 0x3040890
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.get_Result
	|
	|-RVA: 0x3041330 Offset: 0x3041431 VA: 0x3041330
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.get_Result
	|
	|-RVA: 0x3042050 Offset: 0x3042151 VA: 0x3042050
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.get_Result
	|
	|-RVA: 0x3042AD0 Offset: 0x3042BD1 VA: 0x3042AD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.get_Result
	|
	|-RVA: 0x3043750 Offset: 0x3043851 VA: 0x3043750
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.get_Result
	|
	|-RVA: 0x3044440 Offset: 0x3044541 VA: 0x3044440
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.get_Result
	|
	|-RVA: 0x2A96C10 Offset: 0x2A96D11 VA: 0x2A96C10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.get_Result
	|
	|-RVA: 0x2A97930 Offset: 0x2A97A31 VA: 0x2A97930
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.get_Result
	|
	|-RVA: 0x2A98620 Offset: 0x2A98721 VA: 0x2A98620
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.get_Result
	|
	|-RVA: 0x2A99280 Offset: 0x2A99381 VA: 0x2A99280
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.get_Result
	|
	|-RVA: 0x2A99EE0 Offset: 0x2A99FE1 VA: 0x2A99EE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.get_Result
	|
	|-RVA: 0x2A9AB00 Offset: 0x2A9AC01 VA: 0x2A9AB00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.get_Result
	|
	|-RVA: 0x2A9B7F0 Offset: 0x2A9B8F1 VA: 0x2A9B7F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.get_Result
	|
	|-RVA: 0x2A9C260 Offset: 0x2A9C361 VA: 0x2A9C260
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.get_Result
	|
	|-RVA: 0x2A9CEB0 Offset: 0x2A9CFB1 VA: 0x2A9CEB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.get_Result
	|
	|-RVA: 0x2A9DB60 Offset: 0x2A9DC61 VA: 0x2A9DB60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.get_Result
	|
	|-RVA: 0x2A9E7F0 Offset: 0x2A9E8F1 VA: 0x2A9E7F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.get_Result
	|
	|-RVA: 0x2A9F510 Offset: 0x2A9F611 VA: 0x2A9F510
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.get_Result
	|
	|-RVA: 0x2AA0240 Offset: 0x2AA0341 VA: 0x2AA0240
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Result
	|
	|-RVA: 0x2AA1050 Offset: 0x2AA1151 VA: 0x2AA1050
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.get_Result
	|
	|-RVA: 0x2AA1DD0 Offset: 0x2AA1ED1 VA: 0x2AA1DD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Result
	|
	|-RVA: 0x2AA2CC0 Offset: 0x2AA2DC1 VA: 0x2AA2CC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.get_Result
	|
	|-RVA: 0x2AA3AE0 Offset: 0x2AA3BE1 VA: 0x2AA3AE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Result
	|
	|-RVA: 0x2AA4AA0 Offset: 0x2AA4BA1 VA: 0x2AA4AA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.get_Result
	|
	|-RVA: 0x2AA5910 Offset: 0x2AA5A11 VA: 0x2AA5910
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Result
	|
	|-RVA: 0x2AA69A0 Offset: 0x2AA6AA1 VA: 0x2AA69A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.get_Result
	|
	|-RVA: 0x2AA78C0 Offset: 0x2AA79C1 VA: 0x2AA78C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Result
	|
	|-RVA: 0x2AA8920 Offset: 0x2AA8A21 VA: 0x2AA8920
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.get_Result
	|
	|-RVA: 0x2AA9B10 Offset: 0x2AA9C11 VA: 0x2AA9B10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.get_Result
	|
	|-RVA: 0x2AAA580 Offset: 0x2AAA681 VA: 0x2AAA580
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.get_Result
	|
	|-RVA: 0x2AAB020 Offset: 0x2AAB121 VA: 0x2AAB020
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.get_Result
	|
	|-RVA: 0x2AABD20 Offset: 0x2AABE21 VA: 0x2AABD20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.get_Result
	|
	|-RVA: 0x2AAC7C0 Offset: 0x2AAC8C1 VA: 0x2AAC7C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.get_Result
	|
	|-RVA: 0x2AAD470 Offset: 0x2AAD571 VA: 0x2AAD470
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.get_Result
	|
	|-RVA: 0x2AAE0C0 Offset: 0x2AAE1C1 VA: 0x2AAE0C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.get_Result
	|
	|-RVA: 0x2AAEBF0 Offset: 0x2AAECF1 VA: 0x2AAEBF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.get_Result
	|
	|-RVA: 0x2AAF870 Offset: 0x2AAF971 VA: 0x2AAF870
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.get_Result
	|
	|-RVA: 0x2AB04F0 Offset: 0x2AB05F1 VA: 0x2AB04F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.get_Result
	|
	|-RVA: 0x2AB11B0 Offset: 0x2AB12B1 VA: 0x2AB11B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.get_Result
	|
	|-RVA: 0x2AB1E40 Offset: 0x2AB1F41 VA: 0x2AB1E40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.get_Result
	|
	|-RVA: 0x2AB2990 Offset: 0x2AB2A91 VA: 0x2AB2990
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.get_Result
	|
	|-RVA: 0x2AB35E0 Offset: 0x2AB36E1 VA: 0x2AB35E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.get_Result
	|
	|-RVA: 0x2AB4070 Offset: 0x2AB4171 VA: 0x2AB4070
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.get_Result
	|
	|-RVA: 0x2AB4C50 Offset: 0x2AB4D51 VA: 0x2AB4C50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.get_Result
	|
	|-RVA: 0x2AB5890 Offset: 0x2AB5991 VA: 0x2AB5890
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.get_Result
	|
	|-RVA: 0x2AB6560 Offset: 0x2AB6661 VA: 0x2AB6560
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.get_Result
	|
	|-RVA: 0x2AB71F0 Offset: 0x2AB72F1 VA: 0x2AB71F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.get_Result
	|
	|-RVA: 0x2AB7E90 Offset: 0x2AB7F91 VA: 0x2AB7E90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Result
	|
	|-RVA: 0x2AB8CA0 Offset: 0x2AB8DA1 VA: 0x2AB8CA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.get_Result
	|
	|-RVA: 0x2AB99E0 Offset: 0x2AB9AE1 VA: 0x2AB99E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Result
	|
	|-RVA: 0x2ABA8E0 Offset: 0x2ABA9E1 VA: 0x2ABA8E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.get_Result
	|
	|-RVA: 0x2ABB660 Offset: 0x2ABB761 VA: 0x2ABB660
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Result
	|
	|-RVA: 0x2ABC640 Offset: 0x2ABC741 VA: 0x2ABC640
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.get_Result
	|
	|-RVA: 0x2ABD470 Offset: 0x2ABD571 VA: 0x2ABD470
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Result
	|
	|-RVA: 0x2ABE550 Offset: 0x2ABE651 VA: 0x2ABE550
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.get_Result
	|
	|-RVA: 0x2ABF3E0 Offset: 0x2ABF4E1 VA: 0x2ABF3E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Result
	|
	|-RVA: 0x2AC0570 Offset: 0x2AC0671 VA: 0x2AC0570
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.get_Result
	|
	|-RVA: 0x2AC14A0 Offset: 0x2AC15A1 VA: 0x2AC14A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.get_Result
	|
	|-RVA: 0x2CB91C0 Offset: 0x2CB92C1 VA: 0x2CB91C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Result
	|
	|-RVA: 0x2CB9F80 Offset: 0x2CBA081 VA: 0x2CB9F80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_Result
	|
	|-RVA: 0x2CBAA10 Offset: 0x2CBAB11 VA: 0x2CBAA10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>.get_Result
	|
	|-RVA: 0x2CBB4A0 Offset: 0x2CBB5A1 VA: 0x2CBB4A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>.get_Result
	|
	|-RVA: 0x2CBC100 Offset: 0x2CBC201 VA: 0x2CBC100
	|-UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>.get_Result
	|
	|-RVA: 0x2CBCB90 Offset: 0x2CBCC91 VA: 0x2CBCB90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>.get_Result
	|
	|-RVA: 0x2CBD7C0 Offset: 0x2CBD8C1 VA: 0x2CBD7C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, double>>>.get_Result
	|
	|-RVA: 0x2CBE3C0 Offset: 0x2CBE4C1 VA: 0x2CBE3C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, int>>>.get_Result
	|
	|-RVA: 0x2CBEEB0 Offset: 0x2CBEFB1 VA: 0x2CBEEB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, long>>>.get_Result
	|
	|-RVA: 0x2CBFAD0 Offset: 0x2CBFBD1 VA: 0x2CBFAD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, object>>>.get_Result
	|
	|-RVA: 0x2CC06D0 Offset: 0x2CC07D1 VA: 0x2CC06D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.get_Result
	|
	|-RVA: 0x2CC1300 Offset: 0x2CC1401 VA: 0x2CC1300
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>.get_Result
	|
	|-RVA: 0x2CC1F30 Offset: 0x2CC2031 VA: 0x2CC1F30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, float>>>.get_Result
	|
	|-RVA: 0x2CC2A40 Offset: 0x2CC2B41 VA: 0x2CC2A40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>.get_Result
	|
	|-RVA: 0x2CC3640 Offset: 0x2CC3741 VA: 0x2CC3640
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>.get_Result
	|
	|-RVA: 0x2CC40C0 Offset: 0x2CC41C1 VA: 0x2CC40C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>.get_Result
	|
	|-RVA: 0x2CC4BF0 Offset: 0x2CC4CF1 VA: 0x2CC4BF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>.get_Result
	|
	|-RVA: 0x2CC57E0 Offset: 0x2CC58E1 VA: 0x2CC57E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>.get_Result
	|
	|-RVA: 0x2CC6430 Offset: 0x2CC6531 VA: 0x2CC6430
	|-UniTask<ValueTuple<bool, ValueTuple<int, object>>>.get_Result
	|
	|-RVA: 0x2CC7060 Offset: 0x2CC7161 VA: 0x2CC7060
	|-UniTask<ValueTuple<bool, ValueTuple<object, object>>>.get_Result
	|
	|-RVA: 0x2CC7C90 Offset: 0x2CC7D91 VA: 0x2CC7C90
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Result
	|
	|-RVA: 0x2CC8A00 Offset: 0x2CC8B01 VA: 0x2CC8A00
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>.get_Result
	|
	|-RVA: 0x2CC96A0 Offset: 0x2CC97A1 VA: 0x2CC96A0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Result
	|
	|-RVA: 0x2CCA4F0 Offset: 0x2CCA5F1 VA: 0x2CCA4F0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>.get_Result
	|
	|-RVA: 0x2CCB220 Offset: 0x2CCB321 VA: 0x2CCB220
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Result
	|
	|-RVA: 0x2CCC150 Offset: 0x2CCC251 VA: 0x2CCC150
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.get_Result
	|
	|-RVA: 0x2CCCED0 Offset: 0x2CCCFD1 VA: 0x2CCCED0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Result
	|
	|-RVA: 0x2CCDEF0 Offset: 0x2CCDFF1 VA: 0x2CCDEF0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.get_Result
	|
	|-RVA: 0x2CCED20 Offset: 0x2CCEE21 VA: 0x2CCED20
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Result
	|
	|-RVA: 0x2CCFE40 Offset: 0x2CCFF41 VA: 0x2CCFE40
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.get_Result
	|
	|-RVA: 0x2CD0CC0 Offset: 0x2CD0DC1 VA: 0x2CD0CC0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.get_Result
	|
	|-RVA: 0x2CD1DA0 Offset: 0x2CD1EA1 VA: 0x2CD1DA0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Result
	|
	|-RVA: 0x2CD2B60 Offset: 0x2CD2C61 VA: 0x2CD2B60
	|-UniTask<ValueTuple<bool, AsyncUnit>>.get_Result
	|
	|-RVA: 0x2CD35E0 Offset: 0x2CD36E1 VA: 0x2CD35E0
	|-UniTask<ValueTuple<bool, bool>>.get_Result
	|
	|-RVA: 0x2CD4090 Offset: 0x2CD4191 VA: 0x2CD4090
	|-UniTask<ValueTuple<bool, Bounds>>.get_Result
	|
	|-RVA: 0x2CD4D20 Offset: 0x2CD4E21 VA: 0x2CD4D20
	|-UniTask<ValueTuple<bool, byte>>.get_Result
	|
	|-RVA: 0x2CD57B0 Offset: 0x2CD58B1 VA: 0x2CD57B0
	|-UniTask<ValueTuple<bool, Color>>.get_Result
	|
	|-RVA: 0x2CD6380 Offset: 0x2CD6481 VA: 0x2CD6380
	|-UniTask<ValueTuple<bool, double>>.get_Result
	|
	|-RVA: 0x2CD6E90 Offset: 0x2CD6F91 VA: 0x2CD6E90
	|-UniTask<ValueTuple<bool, int>>.get_Result
	|
	|-RVA: 0x2CD78E0 Offset: 0x2CD79E1 VA: 0x2CD78E0
	|-UniTask<ValueTuple<bool, long>>.get_Result
	|
	|-RVA: 0x2CD8420 Offset: 0x2CD8521 VA: 0x2CD8420
	|-UniTask<ValueTuple<bool, object>>.get_Result
	|
	|-RVA: 0x2CD8F40 Offset: 0x2CD9041 VA: 0x2CD8F40
	|-UniTask<ValueTuple<bool, Quaternion>>.get_Result
	|
	|-RVA: 0x2CD9B20 Offset: 0x2CD9C21 VA: 0x2CD9B20
	|-UniTask<ValueTuple<bool, Rect>>.get_Result
	|
	|-RVA: 0x2CDA6F0 Offset: 0x2CDA7F1 VA: 0x2CDA6F0
	|-UniTask<ValueTuple<bool, float>>.get_Result
	|
	|-RVA: 0x2CDB170 Offset: 0x2CDB271 VA: 0x2CDB170
	|-UniTask<ValueTuple<bool, UniTask>>.get_Result
	|
	|-RVA: 0x2CDBC80 Offset: 0x2CDBD81 VA: 0x2CDBC80
	|-UniTask<ValueTuple<bool, Unit>>.get_Result
	|
	|-RVA: 0x2CDC710 Offset: 0x2CDC811 VA: 0x2CDC710
	|-UniTask<ValueTuple<bool, Vector2>>.get_Result
	|
	|-RVA: 0x2CDD1E0 Offset: 0x2CDD2E1 VA: 0x2CDD1E0
	|-UniTask<ValueTuple<bool, Vector3>>.get_Result
	|
	|-RVA: 0x2CDDD00 Offset: 0x2CDDE01 VA: 0x2CDDD00
	|-UniTask<ValueTuple<bool, Vector4>>.get_Result
	|
	|-RVA: 0x2CDE900 Offset: 0x2CDEA01 VA: 0x2CDE900
	|-UniTask<ValueTuple<int, object>>.get_Result
	|
	|-RVA: 0x2CDF440 Offset: 0x2CDF541 VA: 0x2CDF440
	|-UniTask<ValueTuple<object, object>>.get_Result
	|
	|-RVA: 0x2CDFF90 Offset: 0x2CE0091 VA: 0x2CDFF90
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Result
	|
	|-RVA: 0x2CE0CB0 Offset: 0x2CE0DB1 VA: 0x2CE0CB0
	|-UniTask<ValueTuple<object, object, object>>.get_Result
	|
	|-RVA: 0x2CE18F0 Offset: 0x2CE19F1 VA: 0x2CE18F0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Result
	|
	|-RVA: 0x2DDDBC0 Offset: 0x2DDDCC1 VA: 0x2DDDBC0
	|-UniTask<ValueTuple<object, object, object, object>>.get_Result
	|
	|-RVA: 0x2DDE860 Offset: 0x2DDE961 VA: 0x2DDE860
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Result
	|
	|-RVA: 0x2DDF750 Offset: 0x2DDF851 VA: 0x2DDF750
	|-UniTask<ValueTuple<object, object, object, object, object>>.get_Result
	|
	|-RVA: 0x2DE0480 Offset: 0x2DE0581 VA: 0x2DE0480
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Result
	|
	|-RVA: 0x2DE1440 Offset: 0x2DE1541 VA: 0x2DE1440
	|-UniTask<ValueTuple<object, object, object, object, object, object>>.get_Result
	|
	|-RVA: 0x2DE21C0 Offset: 0x2DE22C1 VA: 0x2DE21C0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Result
	|
	|-RVA: 0x2DE3290 Offset: 0x2DE3391 VA: 0x2DE3290
	|-UniTask<ValueTuple<object, object, object, object, object, object, object>>.get_Result
	|
	|-RVA: 0x2DE40C0 Offset: 0x2DE41C1 VA: 0x2DE40C0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_Result
	|
	|-RVA: 0x2DE5270 Offset: 0x2DE5371 VA: 0x2DE5270
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Result
	|
	|-RVA: 0x2DE6030 Offset: 0x2DE6131 VA: 0x2DE6030
	|-UniTask<AsyncUnit>.get_Result
	|
	|-RVA: 0x2DE6A00 Offset: 0x2DE6B01 VA: 0x2DE6A00
	|-UniTask<bool>.get_Result
	|
	|-RVA: 0x2DE73C0 Offset: 0x2DE74C1 VA: 0x2DE73C0
	|-UniTask<Bounds>.get_Result
	|
	|-RVA: 0x2DE7F20 Offset: 0x2DE8021 VA: 0x2DE7F20
	|-UniTask<byte>.get_Result
	|
	|-RVA: 0x2DE88E0 Offset: 0x2DE89E1 VA: 0x2DE88E0
	|-UniTask<Color>.get_Result
	|
	|-RVA: 0x2DE9390 Offset: 0x2DE9491 VA: 0x2DE9390
	|-UniTask<double>.get_Result
	|
	|-RVA: 0x2DE9D60 Offset: 0x2DE9E61 VA: 0x2DE9D60
	|-UniTask<int>.get_Result
	|
	|-RVA: 0x2DEA710 Offset: 0x2DEA811 VA: 0x2DEA710
	|-UniTask<long>.get_Result
	|
	|-RVA: 0x2DEB100 Offset: 0x2DEB201 VA: 0x2DEB100
	|-UniTask<object>.get_Result
	|
	|-RVA: 0x2DEBAB0 Offset: 0x2DEBBB1 VA: 0x2DEBAB0
	|-UniTask<Quaternion>.get_Result
	|
	|-RVA: 0x2DEC570 Offset: 0x2DEC671 VA: 0x2DEC570
	|-UniTask<Rect>.get_Result
	|
	|-RVA: 0x2DED020 Offset: 0x2DED121 VA: 0x2DED020
	|-UniTask<float>.get_Result
	|
	|-RVA: 0x2DEDA10 Offset: 0x2DEDB11 VA: 0x2DEDA10
	|-UniTask<UniTask>.get_Result
	|
	|-RVA: 0x2DEE3E0 Offset: 0x2DEE4E1 VA: 0x2DEE3E0
	|-UniTask<Unit>.get_Result
	|
	|-RVA: 0x2DEEDB0 Offset: 0x2DEEEB1 VA: 0x2DEEDB0
	|-UniTask<Vector2>.get_Result
	|
	|-RVA: 0x2DEF7C0 Offset: 0x2DEF8C1 VA: 0x2DEF7C0
	|-UniTask<Vector3>.get_Result
	|
	|-RVA: 0x2DF0210 Offset: 0x2DF0311 VA: 0x2DF0210
	|-UniTask<Vector4>.get_Result
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CF10 Offset: 0x2D011 VA: 0x2CF10
	// RVA: -1 Offset: -1
	public UniTask.Awaiter<T> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3587860 Offset: 0x3587961 VA: 0x3587860
	|-UniTask<UniTask<object>>.GetAwaiter
	|
	|-RVA: 0x35883D0 Offset: 0x35884D1 VA: 0x35883D0
	|-UniTask<ValueTuple<bool, UniTask<object>>>.GetAwaiter
	|
	|-RVA: 0x3589000 Offset: 0x3589101 VA: 0x3589000
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.GetAwaiter
	|
	|-RVA: 0x3589CA0 Offset: 0x3589DA1 VA: 0x3589CA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.GetAwaiter
	|
	|-RVA: 0x358A9D0 Offset: 0x358AAD1 VA: 0x358A9D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.GetAwaiter
	|
	|-RVA: 0x302DD10 Offset: 0x302DE11 VA: 0x302DD10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.GetAwaiter
	|
	|-RVA: 0x302E790 Offset: 0x302E891 VA: 0x302E790
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.GetAwaiter
	|
	|-RVA: 0x302F280 Offset: 0x302F381 VA: 0x302F280
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.GetAwaiter
	|
	|-RVA: 0x302FFC0 Offset: 0x30300C1 VA: 0x302FFC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.GetAwaiter
	|
	|-RVA: 0x3030AA0 Offset: 0x3030BA1 VA: 0x3030AA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.GetAwaiter
	|
	|-RVA: 0x30317A0 Offset: 0x30318A1 VA: 0x30317A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.GetAwaiter
	|
	|-RVA: 0x30324A0 Offset: 0x30325A1 VA: 0x30324A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.GetAwaiter
	|
	|-RVA: 0x3032F80 Offset: 0x3033081 VA: 0x3032F80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.GetAwaiter
	|
	|-RVA: 0x3033B30 Offset: 0x3033C31 VA: 0x3033B30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x30346E0 Offset: 0x30347E1 VA: 0x30346E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.GetAwaiter
	|
	|-RVA: 0x3035290 Offset: 0x3035391 VA: 0x3035290
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.GetAwaiter
	|
	|-RVA: 0x3035E00 Offset: 0x3035F01 VA: 0x3035E00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.GetAwaiter
	|
	|-RVA: 0x30368F0 Offset: 0x30369F1 VA: 0x30368F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.GetAwaiter
	|
	|-RVA: 0x3037440 Offset: 0x3037541 VA: 0x3037440
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.GetAwaiter
	|
	|-RVA: 0x3037E40 Offset: 0x3037F41 VA: 0x3037E40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.GetAwaiter
	|
	|-RVA: 0x3038970 Offset: 0x3038A71 VA: 0x3038970
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.GetAwaiter
	|
	|-RVA: 0x3039490 Offset: 0x3039591 VA: 0x3039490
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.GetAwaiter
	|
	|-RVA: 0x303A040 Offset: 0x303A141 VA: 0x303A040
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x303ABF0 Offset: 0x303ACF1 VA: 0x303ABF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x303B940 Offset: 0x303BA41 VA: 0x303B940
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x303C700 Offset: 0x303C801 VA: 0x303C700
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x303D500 Offset: 0x303D601 VA: 0x303D500
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x303E370 Offset: 0x303E471 VA: 0x303E370
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x303F210 Offset: 0x303F311 VA: 0x303F210
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x303FEF0 Offset: 0x303FFF1 VA: 0x303FEF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.GetAwaiter
	|
	|-RVA: 0x3040970 Offset: 0x3040A71 VA: 0x3040970
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.GetAwaiter
	|
	|-RVA: 0x3041440 Offset: 0x3041541 VA: 0x3041440
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.GetAwaiter
	|
	|-RVA: 0x3042130 Offset: 0x3042231 VA: 0x3042130
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.GetAwaiter
	|
	|-RVA: 0x3042BD0 Offset: 0x3042CD1 VA: 0x3042BD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.GetAwaiter
	|
	|-RVA: 0x3043860 Offset: 0x3043961 VA: 0x3043860
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.GetAwaiter
	|
	|-RVA: 0x3044540 Offset: 0x3044641 VA: 0x3044540
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.GetAwaiter
	|
	|-RVA: 0x2A96D20 Offset: 0x2A96E21 VA: 0x2A96D20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.GetAwaiter
	|
	|-RVA: 0x2A97A40 Offset: 0x2A97B41 VA: 0x2A97A40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2A98720 Offset: 0x2A98821 VA: 0x2A98720
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.GetAwaiter
	|
	|-RVA: 0x2A99380 Offset: 0x2A99481 VA: 0x2A99380
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.GetAwaiter
	|
	|-RVA: 0x2A99FE0 Offset: 0x2A9A0E1 VA: 0x2A99FE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.GetAwaiter
	|
	|-RVA: 0x2A9AC10 Offset: 0x2A9AD11 VA: 0x2A9AC10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.GetAwaiter
	|
	|-RVA: 0x2A9B8D0 Offset: 0x2A9B9D1 VA: 0x2A9B8D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.GetAwaiter
	|
	|-RVA: 0x2A9C360 Offset: 0x2A9C461 VA: 0x2A9C360
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.GetAwaiter
	|
	|-RVA: 0x2A9CFC0 Offset: 0x2A9D0C1 VA: 0x2A9CFC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.GetAwaiter
	|
	|-RVA: 0x2A9DC60 Offset: 0x2A9DD61 VA: 0x2A9DC60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.GetAwaiter
	|
	|-RVA: 0x2A9E900 Offset: 0x2A9EA01 VA: 0x2A9E900
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2A9F620 Offset: 0x2A9F721 VA: 0x2A9F620
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2AA0360 Offset: 0x2AA0461 VA: 0x2AA0360
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x2AA1160 Offset: 0x2AA1261 VA: 0x2AA1160
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2AA1F00 Offset: 0x2AA2001 VA: 0x2AA1F00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x2AA2DE0 Offset: 0x2AA2EE1 VA: 0x2AA2DE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2AA3C20 Offset: 0x2AA3D21 VA: 0x2AA3C20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x2AA4BC0 Offset: 0x2AA4CC1 VA: 0x2AA4BC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2AA5A60 Offset: 0x2AA5B61 VA: 0x2AA5A60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x2AA6AD0 Offset: 0x2AA6BD1 VA: 0x2AA6AD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2AA7A20 Offset: 0x2AA7B21 VA: 0x2AA7A20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x2AA8A50 Offset: 0x2AA8B51 VA: 0x2AA8A50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2AA9BF0 Offset: 0x2AA9CF1 VA: 0x2AA9BF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.GetAwaiter
	|
	|-RVA: 0x2AAA660 Offset: 0x2AAA761 VA: 0x2AAA660
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.GetAwaiter
	|
	|-RVA: 0x2AAB140 Offset: 0x2AAB241 VA: 0x2AAB140
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.GetAwaiter
	|
	|-RVA: 0x2AABE00 Offset: 0x2AABF01 VA: 0x2AABE00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.GetAwaiter
	|
	|-RVA: 0x2AAC8D0 Offset: 0x2AAC9D1 VA: 0x2AAC8D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.GetAwaiter
	|
	|-RVA: 0x2AAD570 Offset: 0x2AAD671 VA: 0x2AAD570
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.GetAwaiter
	|
	|-RVA: 0x2AAE1A0 Offset: 0x2AAE2A1 VA: 0x2AAE1A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.GetAwaiter
	|
	|-RVA: 0x2AAECF0 Offset: 0x2AAEDF1 VA: 0x2AAECF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.GetAwaiter
	|
	|-RVA: 0x2AAF970 Offset: 0x2AAFA71 VA: 0x2AAF970
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.GetAwaiter
	|
	|-RVA: 0x2AB0600 Offset: 0x2AB0701 VA: 0x2AB0600
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.GetAwaiter
	|
	|-RVA: 0x2AB12C0 Offset: 0x2AB13C1 VA: 0x2AB12C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.GetAwaiter
	|
	|-RVA: 0x2AB1F20 Offset: 0x2AB2021 VA: 0x2AB1F20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.GetAwaiter
	|
	|-RVA: 0x2AB2A90 Offset: 0x2AB2B91 VA: 0x2AB2A90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.GetAwaiter
	|
	|-RVA: 0x2AB36C0 Offset: 0x2AB37C1 VA: 0x2AB36C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.GetAwaiter
	|
	|-RVA: 0x2AB4170 Offset: 0x2AB4271 VA: 0x2AB4170
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.GetAwaiter
	|
	|-RVA: 0x2AB4D50 Offset: 0x2AB4E51 VA: 0x2AB4D50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.GetAwaiter
	|
	|-RVA: 0x2AB59A0 Offset: 0x2AB5AA1 VA: 0x2AB59A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.GetAwaiter
	|
	|-RVA: 0x2AB6660 Offset: 0x2AB6761 VA: 0x2AB6660
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.GetAwaiter
	|
	|-RVA: 0x2AB72F0 Offset: 0x2AB73F1 VA: 0x2AB72F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.GetAwaiter
	|
	|-RVA: 0x2AB7FB0 Offset: 0x2AB80B1 VA: 0x2AB7FB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2AB8DB0 Offset: 0x2AB8EB1 VA: 0x2AB8DB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.GetAwaiter
	|
	|-RVA: 0x2AB9B10 Offset: 0x2AB9C11 VA: 0x2AB9B10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2ABA9F0 Offset: 0x2ABAAF1 VA: 0x2ABA9F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.GetAwaiter
	|
	|-RVA: 0x2ABB7A0 Offset: 0x2ABB8A1 VA: 0x2ABB7A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2ABC760 Offset: 0x2ABC861 VA: 0x2ABC760
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.GetAwaiter
	|
	|-RVA: 0x2ABD5C0 Offset: 0x2ABD6C1 VA: 0x2ABD5C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2ABE670 Offset: 0x2ABE771 VA: 0x2ABE670
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.GetAwaiter
	|
	|-RVA: 0x2ABF540 Offset: 0x2ABF641 VA: 0x2ABF540
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2AC06A0 Offset: 0x2AC07A1 VA: 0x2AC06A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.GetAwaiter
	|
	|-RVA: 0x2AC15A0 Offset: 0x2AC16A1 VA: 0x2AC15A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x2CB92C0 Offset: 0x2CB93C1 VA: 0x2CB92C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetAwaiter
	|
	|-RVA: 0x2CBA060 Offset: 0x2CBA161 VA: 0x2CBA060
	|-UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.GetAwaiter
	|
	|-RVA: 0x2CBAAF0 Offset: 0x2CBABF1 VA: 0x2CBAAF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>.GetAwaiter
	|
	|-RVA: 0x2CBB5A0 Offset: 0x2CBB6A1 VA: 0x2CBB5A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>.GetAwaiter
	|
	|-RVA: 0x2CBC1E0 Offset: 0x2CBC2E1 VA: 0x2CBC1E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>.GetAwaiter
	|
	|-RVA: 0x2CBCC90 Offset: 0x2CBCD91 VA: 0x2CBCC90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>.GetAwaiter
	|
	|-RVA: 0x2CBD8C0 Offset: 0x2CBD9C1 VA: 0x2CBD8C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, double>>>.GetAwaiter
	|
	|-RVA: 0x2CBE4A0 Offset: 0x2CBE5A1 VA: 0x2CBE4A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, int>>>.GetAwaiter
	|
	|-RVA: 0x2CBEFB0 Offset: 0x2CBF0B1 VA: 0x2CBEFB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, long>>>.GetAwaiter
	|
	|-RVA: 0x2CBFBD0 Offset: 0x2CBFCD1 VA: 0x2CBFBD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, object>>>.GetAwaiter
	|
	|-RVA: 0x2CC07D0 Offset: 0x2CC08D1 VA: 0x2CC07D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.GetAwaiter
	|
	|-RVA: 0x2CC1400 Offset: 0x2CC1501 VA: 0x2CC1400
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>.GetAwaiter
	|
	|-RVA: 0x2CC2010 Offset: 0x2CC2111 VA: 0x2CC2010
	|-UniTask<ValueTuple<bool, ValueTuple<bool, float>>>.GetAwaiter
	|
	|-RVA: 0x2CC2B40 Offset: 0x2CC2C41 VA: 0x2CC2B40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>.GetAwaiter
	|
	|-RVA: 0x2CC3720 Offset: 0x2CC3821 VA: 0x2CC3720
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>.GetAwaiter
	|
	|-RVA: 0x2CC41A0 Offset: 0x2CC42A1 VA: 0x2CC41A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>.GetAwaiter
	|
	|-RVA: 0x2CC4CF0 Offset: 0x2CC4DF1 VA: 0x2CC4CF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>.GetAwaiter
	|
	|-RVA: 0x2CC58E0 Offset: 0x2CC59E1 VA: 0x2CC58E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>.GetAwaiter
	|
	|-RVA: 0x2CC6530 Offset: 0x2CC6631 VA: 0x2CC6530
	|-UniTask<ValueTuple<bool, ValueTuple<int, object>>>.GetAwaiter
	|
	|-RVA: 0x2CC7160 Offset: 0x2CC7261 VA: 0x2CC7160
	|-UniTask<ValueTuple<bool, ValueTuple<object, object>>>.GetAwaiter
	|
	|-RVA: 0x2CC7DA0 Offset: 0x2CC7EA1 VA: 0x2CC7DA0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetAwaiter
	|
	|-RVA: 0x2CC8B00 Offset: 0x2CC8C01 VA: 0x2CC8B00
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>.GetAwaiter
	|
	|-RVA: 0x2CC97C0 Offset: 0x2CC98C1 VA: 0x2CC97C0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetAwaiter
	|
	|-RVA: 0x2CCA600 Offset: 0x2CCA701 VA: 0x2CCA600
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>.GetAwaiter
	|
	|-RVA: 0x2CCB350 Offset: 0x2CCB451 VA: 0x2CCB350
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetAwaiter
	|
	|-RVA: 0x2CCC260 Offset: 0x2CCC361 VA: 0x2CCC260
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.GetAwaiter
	|
	|-RVA: 0x2CCD010 Offset: 0x2CCD111 VA: 0x2CCD010
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetAwaiter
	|
	|-RVA: 0x2CCE010 Offset: 0x2CCE111 VA: 0x2CCE010
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.GetAwaiter
	|
	|-RVA: 0x2CCEE70 Offset: 0x2CCEF71 VA: 0x2CCEE70
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetAwaiter
	|
	|-RVA: 0x2CCFF60 Offset: 0x2CD0061 VA: 0x2CCFF60
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.GetAwaiter
	|
	|-RVA: 0x2CD0E20 Offset: 0x2CD0F21 VA: 0x2CD0E20
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2CD1EA0 Offset: 0x2CD1FA1 VA: 0x2CD1EA0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetAwaiter
	|
	|-RVA: 0x2CD2C40 Offset: 0x2CD2D41 VA: 0x2CD2C40
	|-UniTask<ValueTuple<bool, AsyncUnit>>.GetAwaiter
	|
	|-RVA: 0x2CD36C0 Offset: 0x2CD37C1 VA: 0x2CD36C0
	|-UniTask<ValueTuple<bool, bool>>.GetAwaiter
	|
	|-RVA: 0x2CD41A0 Offset: 0x2CD42A1 VA: 0x2CD41A0
	|-UniTask<ValueTuple<bool, Bounds>>.GetAwaiter
	|
	|-RVA: 0x2CD4E00 Offset: 0x2CD4F01 VA: 0x2CD4E00
	|-UniTask<ValueTuple<bool, byte>>.GetAwaiter
	|
	|-RVA: 0x2CD58B0 Offset: 0x2CD59B1 VA: 0x2CD58B0
	|-UniTask<ValueTuple<bool, Color>>.GetAwaiter
	|
	|-RVA: 0x2CD6460 Offset: 0x2CD6561 VA: 0x2CD6460
	|-UniTask<ValueTuple<bool, double>>.GetAwaiter
	|
	|-RVA: 0x2CD6F60 Offset: 0x2CD7061 VA: 0x2CD6F60
	|-UniTask<ValueTuple<bool, int>>.GetAwaiter
	|
	|-RVA: 0x2CD79C0 Offset: 0x2CD7AC1 VA: 0x2CD79C0
	|-UniTask<ValueTuple<bool, long>>.GetAwaiter
	|
	|-RVA: 0x2CD8500 Offset: 0x2CD8601 VA: 0x2CD8500
	|-UniTask<ValueTuple<bool, object>>.GetAwaiter
	|
	|-RVA: 0x2CD9040 Offset: 0x2CD9141 VA: 0x2CD9040
	|-UniTask<ValueTuple<bool, Quaternion>>.GetAwaiter
	|
	|-RVA: 0x2CD9C20 Offset: 0x2CD9D21 VA: 0x2CD9C20
	|-UniTask<ValueTuple<bool, Rect>>.GetAwaiter
	|
	|-RVA: 0x2CDA7C0 Offset: 0x2CDA8C1 VA: 0x2CDA7C0
	|-UniTask<ValueTuple<bool, float>>.GetAwaiter
	|
	|-RVA: 0x2CDB250 Offset: 0x2CDB351 VA: 0x2CDB250
	|-UniTask<ValueTuple<bool, UniTask>>.GetAwaiter
	|
	|-RVA: 0x2CDBD60 Offset: 0x2CDBE61 VA: 0x2CDBD60
	|-UniTask<ValueTuple<bool, Unit>>.GetAwaiter
	|
	|-RVA: 0x2CDC7F0 Offset: 0x2CDC8F1 VA: 0x2CDC7F0
	|-UniTask<ValueTuple<bool, Vector2>>.GetAwaiter
	|
	|-RVA: 0x2CDD2C0 Offset: 0x2CDD3C1 VA: 0x2CDD2C0
	|-UniTask<ValueTuple<bool, Vector3>>.GetAwaiter
	|
	|-RVA: 0x2CDDE00 Offset: 0x2CDDF01 VA: 0x2CDDE00
	|-UniTask<ValueTuple<bool, Vector4>>.GetAwaiter
	|
	|-RVA: 0x2CDE9E0 Offset: 0x2CDEAE1 VA: 0x2CDE9E0
	|-UniTask<ValueTuple<int, object>>.GetAwaiter
	|
	|-RVA: 0x2CDF520 Offset: 0x2CDF621 VA: 0x2CDF520
	|-UniTask<ValueTuple<object, object>>.GetAwaiter
	|
	|-RVA: 0x2CE00A0 Offset: 0x2CE01A1 VA: 0x2CE00A0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetAwaiter
	|
	|-RVA: 0x2CE0DB0 Offset: 0x2CE0EB1 VA: 0x2CE0DB0
	|-UniTask<ValueTuple<object, object, object>>.GetAwaiter
	|
	|-RVA: 0x2CE1A10 Offset: 0x2CE1B11 VA: 0x2CE1A10
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetAwaiter
	|
	|-RVA: 0x2DDDCC0 Offset: 0x2DDDDC1 VA: 0x2DDDCC0
	|-UniTask<ValueTuple<object, object, object, object>>.GetAwaiter
	|
	|-RVA: 0x2DDE990 Offset: 0x2DDEA91 VA: 0x2DDE990
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetAwaiter
	|
	|-RVA: 0x2DDF860 Offset: 0x2DDF961 VA: 0x2DDF860
	|-UniTask<ValueTuple<object, object, object, object, object>>.GetAwaiter
	|
	|-RVA: 0x2DE05C0 Offset: 0x2DE06C1 VA: 0x2DE05C0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetAwaiter
	|
	|-RVA: 0x2DE1550 Offset: 0x2DE1651 VA: 0x2DE1550
	|-UniTask<ValueTuple<object, object, object, object, object, object>>.GetAwaiter
	|
	|-RVA: 0x2DE2310 Offset: 0x2DE2411 VA: 0x2DE2310
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetAwaiter
	|
	|-RVA: 0x2DE33B0 Offset: 0x2DE34B1 VA: 0x2DE33B0
	|-UniTask<ValueTuple<object, object, object, object, object, object, object>>.GetAwaiter
	|
	|-RVA: 0x2DE4220 Offset: 0x2DE4321 VA: 0x2DE4220
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.GetAwaiter
	|
	|-RVA: 0x2DE5370 Offset: 0x2DE5471 VA: 0x2DE5370
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetAwaiter
	|
	|-RVA: 0x2DE6110 Offset: 0x2DE6211 VA: 0x2DE6110
	|-UniTask<AsyncUnit>.GetAwaiter
	|
	|-RVA: 0x2DE6AD0 Offset: 0x2DE6BD1 VA: 0x2DE6AD0
	|-UniTask<bool>.GetAwaiter
	|
	|-RVA: 0x2DE74C0 Offset: 0x2DE75C1 VA: 0x2DE74C0
	|-UniTask<Bounds>.GetAwaiter
	|
	|-RVA: 0x2DE7FF0 Offset: 0x2DE80F1 VA: 0x2DE7FF0
	|-UniTask<byte>.GetAwaiter
	|
	|-RVA: 0x2DE89C0 Offset: 0x2DE8AC1 VA: 0x2DE89C0
	|-UniTask<Color>.GetAwaiter
	|
	|-RVA: 0x2DE9460 Offset: 0x2DE9561 VA: 0x2DE9460
	|-UniTask<double>.GetAwaiter
	|
	|-RVA: 0x2DE9E30 Offset: 0x2DE9F31 VA: 0x2DE9E30
	|-UniTask<int>.GetAwaiter
	|
	|-RVA: 0x2DEA7E0 Offset: 0x2DEA8E1 VA: 0x2DEA7E0
	|-UniTask<long>.GetAwaiter
	|
	|-RVA: 0x2DEB1D0 Offset: 0x2DEB2D1 VA: 0x2DEB1D0
	|-UniTask<object>.GetAwaiter
	|
	|-RVA: 0x2DEBB90 Offset: 0x2DEBC91 VA: 0x2DEBB90
	|-UniTask<Quaternion>.GetAwaiter
	|
	|-RVA: 0x2DEC650 Offset: 0x2DEC751 VA: 0x2DEC650
	|-UniTask<Rect>.GetAwaiter
	|
	|-RVA: 0x2DED0F0 Offset: 0x2DED1F1 VA: 0x2DED0F0
	|-UniTask<float>.GetAwaiter
	|
	|-RVA: 0x2DEDAE0 Offset: 0x2DEDBE1 VA: 0x2DEDAE0
	|-UniTask<UniTask>.GetAwaiter
	|
	|-RVA: 0x2DEE4C0 Offset: 0x2DEE5C1 VA: 0x2DEE4C0
	|-UniTask<Unit>.GetAwaiter
	|
	|-RVA: 0x2DEEE90 Offset: 0x2DEEF91 VA: 0x2DEEE90
	|-UniTask<Vector2>.GetAwaiter
	|
	|-RVA: 0x2DEF8A0 Offset: 0x2DEF9A1 VA: 0x2DEF8A0
	|-UniTask<Vector3>.GetAwaiter
	|
	|-RVA: 0x2DF02F0 Offset: 0x2DF03F1 VA: 0x2DF02F0
	|-UniTask<Vector4>.GetAwaiter
	*/

	// RVA: -1 Offset: -1
	public UniTask<ValueTuple<bool, T>> SuppressCancellationThrow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35878E0 Offset: 0x35879E1 VA: 0x35878E0
	|-UniTask<UniTask<object>>.SuppressCancellationThrow
	|
	|-RVA: 0x3588450 Offset: 0x3588551 VA: 0x3588450
	|-UniTask<ValueTuple<bool, UniTask<object>>>.SuppressCancellationThrow
	|
	|-RVA: 0x35890A0 Offset: 0x35891A1 VA: 0x35890A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3589D40 Offset: 0x3589E41 VA: 0x3589D40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x358AA90 Offset: 0x358AB91 VA: 0x358AA90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x302DD60 Offset: 0x302DE61 VA: 0x302DD60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x302E7E0 Offset: 0x302E8E1 VA: 0x302E7E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x302F340 Offset: 0x302F441 VA: 0x302F340
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3030010 Offset: 0x3030111 VA: 0x3030010
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3030B40 Offset: 0x3030C41 VA: 0x3030B40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3031860 Offset: 0x3031961 VA: 0x3031860
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3032520 Offset: 0x3032621 VA: 0x3032520
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3033040 Offset: 0x3033141 VA: 0x3033040
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3033BF0 Offset: 0x3033CF1 VA: 0x3033BF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3034780 Offset: 0x3034881 VA: 0x3034780
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3035330 Offset: 0x3035431 VA: 0x3035330
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3035E80 Offset: 0x3035F81 VA: 0x3035E80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x30369B0 Offset: 0x3036AB1 VA: 0x30369B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3037490 Offset: 0x3037591 VA: 0x3037490
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3037EE0 Offset: 0x3037FE1 VA: 0x3037EE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3038A10 Offset: 0x3038B11 VA: 0x3038A10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3039530 Offset: 0x3039631 VA: 0x3039530
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x303A100 Offset: 0x303A201 VA: 0x303A100
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x303ACB0 Offset: 0x303ADB1 VA: 0x303ACB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x303BA00 Offset: 0x303BB01 VA: 0x303BA00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x303C7D0 Offset: 0x303C8D1 VA: 0x303C7D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x303D5D0 Offset: 0x303D6D1 VA: 0x303D5D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x303E460 Offset: 0x303E561 VA: 0x303E460
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x303F300 Offset: 0x303F401 VA: 0x303F300
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x303FF40 Offset: 0x3040041 VA: 0x303FF40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x30409C0 Offset: 0x3040AC1 VA: 0x30409C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x30414E0 Offset: 0x30415E1 VA: 0x30414E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3042180 Offset: 0x3042281 VA: 0x3042180
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3042C70 Offset: 0x3042D71 VA: 0x3042C70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x3043900 Offset: 0x3043A01 VA: 0x3043900
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x30445C0 Offset: 0x30446C1 VA: 0x30445C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2A96DC0 Offset: 0x2A96EC1 VA: 0x2A96DC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2A97AE0 Offset: 0x2A97BE1 VA: 0x2A97AE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2A987C0 Offset: 0x2A988C1 VA: 0x2A987C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2A99420 Offset: 0x2A99521 VA: 0x2A99420
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2A9A060 Offset: 0x2A9A161 VA: 0x2A9A060
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2A9ACB0 Offset: 0x2A9ADB1 VA: 0x2A9ACB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2A9B920 Offset: 0x2A9BA21 VA: 0x2A9B920
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2A9C3E0 Offset: 0x2A9C4E1 VA: 0x2A9C3E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2A9D060 Offset: 0x2A9D161 VA: 0x2A9D060
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2A9DD00 Offset: 0x2A9DE01 VA: 0x2A9DD00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2A9E9A0 Offset: 0x2A9EAA1 VA: 0x2A9E9A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2A9F6C0 Offset: 0x2A9F7C1 VA: 0x2A9F6C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AA0430 Offset: 0x2AA0531 VA: 0x2AA0430
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AA1220 Offset: 0x2AA1321 VA: 0x2AA1220
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AA1FF0 Offset: 0x2AA20F1 VA: 0x2AA1FF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AA2EA0 Offset: 0x2AA2FA1 VA: 0x2AA2EA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AA3D30 Offset: 0x2AA3E31 VA: 0x2AA3D30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AA4C90 Offset: 0x2AA4D91 VA: 0x2AA4C90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AA5B90 Offset: 0x2AA5C91 VA: 0x2AA5B90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AA6BA0 Offset: 0x2AA6CA1 VA: 0x2AA6BA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AA7AD0 Offset: 0x2AA7BD1 VA: 0x2AA7AD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AA8B40 Offset: 0x2AA8C41 VA: 0x2AA8B40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AA9C40 Offset: 0x2AA9D41 VA: 0x2AA9C40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AAA6B0 Offset: 0x2AAA7B1 VA: 0x2AAA6B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AAB1E0 Offset: 0x2AAB2E1 VA: 0x2AAB1E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AABE50 Offset: 0x2AABF51 VA: 0x2AABE50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AAC970 Offset: 0x2AACA71 VA: 0x2AAC970
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AAD610 Offset: 0x2AAD711 VA: 0x2AAD610
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AAE220 Offset: 0x2AAE321 VA: 0x2AAE220
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AAED90 Offset: 0x2AAEE91 VA: 0x2AAED90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AAFA10 Offset: 0x2AAFB11 VA: 0x2AAFA10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AB06A0 Offset: 0x2AB07A1 VA: 0x2AB06A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AB1360 Offset: 0x2AB1461 VA: 0x2AB1360
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AB1FA0 Offset: 0x2AB20A1 VA: 0x2AB1FA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AB2B30 Offset: 0x2AB2C31 VA: 0x2AB2B30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AB3710 Offset: 0x2AB3811 VA: 0x2AB3710
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AB41F0 Offset: 0x2AB42F1 VA: 0x2AB41F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AB4DD0 Offset: 0x2AB4ED1 VA: 0x2AB4DD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AB5A40 Offset: 0x2AB5B41 VA: 0x2AB5A40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AB6700 Offset: 0x2AB6801 VA: 0x2AB6700
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AB7390 Offset: 0x2AB7491 VA: 0x2AB7390
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AB8070 Offset: 0x2AB8171 VA: 0x2AB8070
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AB8E50 Offset: 0x2AB8F51 VA: 0x2AB8E50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AB9BE0 Offset: 0x2AB9CE1 VA: 0x2AB9BE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2ABAAB0 Offset: 0x2ABABB1 VA: 0x2ABAAB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2ABB890 Offset: 0x2ABB991 VA: 0x2ABB890
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2ABC820 Offset: 0x2ABC921 VA: 0x2ABC820
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2ABD6D0 Offset: 0x2ABD7D1 VA: 0x2ABD6D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2ABE740 Offset: 0x2ABE841 VA: 0x2ABE740
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2ABF670 Offset: 0x2ABF771 VA: 0x2ABF670
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AC0770 Offset: 0x2AC0871 VA: 0x2AC0770
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2AC1650 Offset: 0x2AC1751 VA: 0x2AC1650
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CB9370 Offset: 0x2CB9471 VA: 0x2CB9370
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CBA0B0 Offset: 0x2CBA1B1 VA: 0x2CBA0B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CBAB40 Offset: 0x2CBAC41 VA: 0x2CBAB40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CBB640 Offset: 0x2CBB741 VA: 0x2CBB640
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CBC230 Offset: 0x2CBC331 VA: 0x2CBC230
	|-UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CBCD10 Offset: 0x2CBCE11 VA: 0x2CBCD10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CBD940 Offset: 0x2CBDA41 VA: 0x2CBD940
	|-UniTask<ValueTuple<bool, ValueTuple<bool, double>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CBE520 Offset: 0x2CBE621 VA: 0x2CBE520
	|-UniTask<ValueTuple<bool, ValueTuple<bool, int>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CBF030 Offset: 0x2CBF131 VA: 0x2CBF030
	|-UniTask<ValueTuple<bool, ValueTuple<bool, long>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CBFC50 Offset: 0x2CBFD51 VA: 0x2CBFC50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, object>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CC0850 Offset: 0x2CC0951 VA: 0x2CC0850
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CC1480 Offset: 0x2CC1581 VA: 0x2CC1480
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CC2090 Offset: 0x2CC2191 VA: 0x2CC2090
	|-UniTask<ValueTuple<bool, ValueTuple<bool, float>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CC2BC0 Offset: 0x2CC2CC1 VA: 0x2CC2BC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CC3770 Offset: 0x2CC3871 VA: 0x2CC3770
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CC4220 Offset: 0x2CC4321 VA: 0x2CC4220
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CC4D70 Offset: 0x2CC4E71 VA: 0x2CC4D70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CC5960 Offset: 0x2CC5A61 VA: 0x2CC5960
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CC65B0 Offset: 0x2CC66B1 VA: 0x2CC65B0
	|-UniTask<ValueTuple<bool, ValueTuple<int, object>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CC71E0 Offset: 0x2CC72E1 VA: 0x2CC71E0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CC7E60 Offset: 0x2CC7F61 VA: 0x2CC7E60
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CC8BA0 Offset: 0x2CC8CA1 VA: 0x2CC8BA0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CC9890 Offset: 0x2CC9991 VA: 0x2CC9890
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CCA6A0 Offset: 0x2CCA7A1 VA: 0x2CCA6A0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CCB440 Offset: 0x2CCB541 VA: 0x2CCB440
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CCC320 Offset: 0x2CCC421 VA: 0x2CCC320
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CCD120 Offset: 0x2CCD221 VA: 0x2CCD120
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CCE0D0 Offset: 0x2CCE1D1 VA: 0x2CCE0D0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CCEFA0 Offset: 0x2CCF0A1 VA: 0x2CCEFA0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CD0030 Offset: 0x2CD0131 VA: 0x2CD0030
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CD0ED0 Offset: 0x2CD0FD1 VA: 0x2CD0ED0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CD1F50 Offset: 0x2CD2051 VA: 0x2CD1F50
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CD2C90 Offset: 0x2CD2D91 VA: 0x2CD2C90
	|-UniTask<ValueTuple<bool, AsyncUnit>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CD3710 Offset: 0x2CD3811 VA: 0x2CD3710
	|-UniTask<ValueTuple<bool, bool>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CD4240 Offset: 0x2CD4341 VA: 0x2CD4240
	|-UniTask<ValueTuple<bool, Bounds>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CD4E50 Offset: 0x2CD4F51 VA: 0x2CD4E50
	|-UniTask<ValueTuple<bool, byte>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CD5930 Offset: 0x2CD5A31 VA: 0x2CD5930
	|-UniTask<ValueTuple<bool, Color>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CD64E0 Offset: 0x2CD65E1 VA: 0x2CD64E0
	|-UniTask<ValueTuple<bool, double>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CD6FB0 Offset: 0x2CD70B1 VA: 0x2CD6FB0
	|-UniTask<ValueTuple<bool, int>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CD7A40 Offset: 0x2CD7B41 VA: 0x2CD7A40
	|-UniTask<ValueTuple<bool, long>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CD8580 Offset: 0x2CD8681 VA: 0x2CD8580
	|-UniTask<ValueTuple<bool, object>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CD90C0 Offset: 0x2CD91C1 VA: 0x2CD90C0
	|-UniTask<ValueTuple<bool, Quaternion>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CD9CA0 Offset: 0x2CD9DA1 VA: 0x2CD9CA0
	|-UniTask<ValueTuple<bool, Rect>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CDA810 Offset: 0x2CDA911 VA: 0x2CDA810
	|-UniTask<ValueTuple<bool, float>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CDB2D0 Offset: 0x2CDB3D1 VA: 0x2CDB2D0
	|-UniTask<ValueTuple<bool, UniTask>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CDBDB0 Offset: 0x2CDBEB1 VA: 0x2CDBDB0
	|-UniTask<ValueTuple<bool, Unit>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CDC870 Offset: 0x2CDC971 VA: 0x2CDC870
	|-UniTask<ValueTuple<bool, Vector2>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CDD340 Offset: 0x2CDD441 VA: 0x2CDD340
	|-UniTask<ValueTuple<bool, Vector3>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CDDE80 Offset: 0x2CDDF81 VA: 0x2CDDE80
	|-UniTask<ValueTuple<bool, Vector4>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CDEA60 Offset: 0x2CDEB61 VA: 0x2CDEA60
	|-UniTask<ValueTuple<int, object>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CDF5A0 Offset: 0x2CDF6A1 VA: 0x2CDF5A0
	|-UniTask<ValueTuple<object, object>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CE0140 Offset: 0x2CE0241 VA: 0x2CE0140
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CE0E30 Offset: 0x2CE0F31 VA: 0x2CE0E30
	|-UniTask<ValueTuple<object, object, object>>.SuppressCancellationThrow
	|
	|-RVA: 0x2CE1AD0 Offset: 0x2CE1BD1 VA: 0x2CE1AD0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2DDDD60 Offset: 0x2DDDE61 VA: 0x2DDDD60
	|-UniTask<ValueTuple<object, object, object, object>>.SuppressCancellationThrow
	|
	|-RVA: 0x2DDEA60 Offset: 0x2DDEB61 VA: 0x2DDEA60
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2DDF900 Offset: 0x2DDFA01 VA: 0x2DDF900
	|-UniTask<ValueTuple<object, object, object, object, object>>.SuppressCancellationThrow
	|
	|-RVA: 0x2DE06B0 Offset: 0x2DE07B1 VA: 0x2DE06B0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2DE1600 Offset: 0x2DE1701 VA: 0x2DE1600
	|-UniTask<ValueTuple<object, object, object, object, object, object>>.SuppressCancellationThrow
	|
	|-RVA: 0x2DE2420 Offset: 0x2DE2521 VA: 0x2DE2420
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2DE3460 Offset: 0x2DE3561 VA: 0x2DE3460
	|-UniTask<ValueTuple<object, object, object, object, object, object, object>>.SuppressCancellationThrow
	|
	|-RVA: 0x2DE4350 Offset: 0x2DE4451 VA: 0x2DE4350
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2DE5420 Offset: 0x2DE5521 VA: 0x2DE5420
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.SuppressCancellationThrow
	|
	|-RVA: 0x2DE6160 Offset: 0x2DE6261 VA: 0x2DE6160
	|-UniTask<AsyncUnit>.SuppressCancellationThrow
	|
	|-RVA: 0x2DE6B20 Offset: 0x2DE6C21 VA: 0x2DE6B20
	|-UniTask<bool>.SuppressCancellationThrow
	|
	|-RVA: 0x2DE7540 Offset: 0x2DE7641 VA: 0x2DE7540
	|-UniTask<Bounds>.SuppressCancellationThrow
	|
	|-RVA: 0x2DE8040 Offset: 0x2DE8141 VA: 0x2DE8040
	|-UniTask<byte>.SuppressCancellationThrow
	|
	|-RVA: 0x2DE8A40 Offset: 0x2DE8B41 VA: 0x2DE8A40
	|-UniTask<Color>.SuppressCancellationThrow
	|
	|-RVA: 0x2DE94B0 Offset: 0x2DE95B1 VA: 0x2DE94B0
	|-UniTask<double>.SuppressCancellationThrow
	|
	|-RVA: 0x2DE9E80 Offset: 0x2DE9F81 VA: 0x2DE9E80
	|-UniTask<int>.SuppressCancellationThrow
	|
	|-RVA: 0x2DEA830 Offset: 0x2DEA931 VA: 0x2DEA830
	|-UniTask<long>.SuppressCancellationThrow
	|
	|-RVA: 0x2DEB220 Offset: 0x2DEB321 VA: 0x2DEB220
	|-UniTask<object>.SuppressCancellationThrow
	|
	|-RVA: 0x2DEBC10 Offset: 0x2DEBD11 VA: 0x2DEBC10
	|-UniTask<Quaternion>.SuppressCancellationThrow
	|
	|-RVA: 0x2DEC6D0 Offset: 0x2DEC7D1 VA: 0x2DEC6D0
	|-UniTask<Rect>.SuppressCancellationThrow
	|
	|-RVA: 0x2DED140 Offset: 0x2DED241 VA: 0x2DED140
	|-UniTask<float>.SuppressCancellationThrow
	|
	|-RVA: 0x2DEDB30 Offset: 0x2DEDC31 VA: 0x2DEDB30
	|-UniTask<UniTask>.SuppressCancellationThrow
	|
	|-RVA: 0x2DEE510 Offset: 0x2DEE611 VA: 0x2DEE510
	|-UniTask<Unit>.SuppressCancellationThrow
	|
	|-RVA: 0x2DEEEE0 Offset: 0x2DEEFE1 VA: 0x2DEEEE0
	|-UniTask<Vector2>.SuppressCancellationThrow
	|
	|-RVA: 0x2DEF920 Offset: 0x2DEFA21 VA: 0x2DEF920
	|-UniTask<Vector3>.SuppressCancellationThrow
	|
	|-RVA: 0x2DF0370 Offset: 0x2DF0471 VA: 0x2DF0370
	|-UniTask<Vector4>.SuppressCancellationThrow
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(UniTask<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3587BD0 Offset: 0x3587CD1 VA: 0x3587BD0
	|-UniTask<UniTask<object>>.Equals
	|
	|-RVA: 0x3588780 Offset: 0x3588881 VA: 0x3588780
	|-UniTask<ValueTuple<bool, UniTask<object>>>.Equals
	|
	|-RVA: 0x3589400 Offset: 0x3589501 VA: 0x3589400
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.Equals
	|
	|-RVA: 0x358A0D0 Offset: 0x358A1D1 VA: 0x358A0D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.Equals
	|
	|-RVA: 0x358ACC0 Offset: 0x358ADC1 VA: 0x358ACC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.Equals
	|
	|-RVA: 0x302DFF0 Offset: 0x302E0F1 VA: 0x302DFF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.Equals
	|
	|-RVA: 0x302EA70 Offset: 0x302EB71 VA: 0x302EA70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.Equals
	|
	|-RVA: 0x302F6C0 Offset: 0x302F7C1 VA: 0x302F6C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.Equals
	|
	|-RVA: 0x30302A0 Offset: 0x30303A1 VA: 0x30302A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.Equals
	|
	|-RVA: 0x3030E90 Offset: 0x3030F91 VA: 0x3030E90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.Equals
	|
	|-RVA: 0x3031BE0 Offset: 0x3031CE1 VA: 0x3031BE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.Equals
	|
	|-RVA: 0x3032700 Offset: 0x3032801 VA: 0x3032700
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.Equals
	|
	|-RVA: 0x3033230 Offset: 0x3033331 VA: 0x3033230
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.Equals
	|
	|-RVA: 0x3033DE0 Offset: 0x3033EE1 VA: 0x3033DE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x3034970 Offset: 0x3034A71 VA: 0x3034970
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.Equals
	|
	|-RVA: 0x3035520 Offset: 0x3035621 VA: 0x3035520
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.Equals
	|
	|-RVA: 0x3036060 Offset: 0x3036161 VA: 0x3036060
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.Equals
	|
	|-RVA: 0x3036BA0 Offset: 0x3036CA1 VA: 0x3036BA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.Equals
	|
	|-RVA: 0x3037650 Offset: 0x3037751 VA: 0x3037650
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.Equals
	|
	|-RVA: 0x30380C0 Offset: 0x30381C1 VA: 0x30380C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.Equals
	|
	|-RVA: 0x3038BF0 Offset: 0x3038CF1 VA: 0x3038BF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.Equals
	|
	|-RVA: 0x3039720 Offset: 0x3039821 VA: 0x3039720
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.Equals
	|
	|-RVA: 0x303A2F0 Offset: 0x303A3F1 VA: 0x303A2F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.Equals
	|
	|-RVA: 0x303AEA0 Offset: 0x303AFA1 VA: 0x303AEA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.Equals
	|
	|-RVA: 0x303BC00 Offset: 0x303BD01 VA: 0x303BC00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.Equals
	|
	|-RVA: 0x303C9E0 Offset: 0x303CAE1 VA: 0x303C9E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x303D7F0 Offset: 0x303D8F1 VA: 0x303D7F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x303E680 Offset: 0x303E781 VA: 0x303E680
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x303F530 Offset: 0x303F631 VA: 0x303F530
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.Equals
	|
	|-RVA: 0x30401D0 Offset: 0x30402D1 VA: 0x30401D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.Equals
	|
	|-RVA: 0x3040C50 Offset: 0x3040D51 VA: 0x3040C50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.Equals
	|
	|-RVA: 0x3041890 Offset: 0x3041991 VA: 0x3041890
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.Equals
	|
	|-RVA: 0x3042410 Offset: 0x3042511 VA: 0x3042410
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.Equals
	|
	|-RVA: 0x3042FD0 Offset: 0x30430D1 VA: 0x3042FD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.Equals
	|
	|-RVA: 0x3043C80 Offset: 0x3043D81 VA: 0x3043C80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.Equals
	|
	|-RVA: 0x30448D0 Offset: 0x30449D1 VA: 0x30448D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.Equals
	|
	|-RVA: 0x2A97140 Offset: 0x2A97241 VA: 0x2A97140
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.Equals
	|
	|-RVA: 0x2A97E60 Offset: 0x2A97F61 VA: 0x2A97E60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x2A98B20 Offset: 0x2A98C21 VA: 0x2A98B20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.Equals
	|
	|-RVA: 0x2A99780 Offset: 0x2A99881 VA: 0x2A99780
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.Equals
	|
	|-RVA: 0x2A9A380 Offset: 0x2A9A481 VA: 0x2A9A380
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.Equals
	|
	|-RVA: 0x2A9B030 Offset: 0x2A9B131 VA: 0x2A9B030
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.Equals
	|
	|-RVA: 0x2A9BBA0 Offset: 0x2A9BCA1 VA: 0x2A9BBA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.Equals
	|
	|-RVA: 0x2A9C740 Offset: 0x2A9C841 VA: 0x2A9C740
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.Equals
	|
	|-RVA: 0x2A9D3B0 Offset: 0x2A9D4B1 VA: 0x2A9D3B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.Equals
	|
	|-RVA: 0x2A9E060 Offset: 0x2A9E161 VA: 0x2A9E060
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.Equals
	|
	|-RVA: 0x2A9ED20 Offset: 0x2A9EE21 VA: 0x2A9ED20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.Equals
	|
	|-RVA: 0x2A9FA40 Offset: 0x2A9FB41 VA: 0x2A9FA40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.Equals
	|
	|-RVA: 0x2AA07F0 Offset: 0x2AA08F1 VA: 0x2AA07F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x2AA15D0 Offset: 0x2AA16D1 VA: 0x2AA15D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.Equals
	|
	|-RVA: 0x2AA23F0 Offset: 0x2AA24F1 VA: 0x2AA23F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x2AA3280 Offset: 0x2AA3381 VA: 0x2AA3280
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x2AA4170 Offset: 0x2AA4271 VA: 0x2AA4170
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x2AA5090 Offset: 0x2AA5191 VA: 0x2AA5090
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x2AA6010 Offset: 0x2AA6111 VA: 0x2AA6010
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x2AA6FD0 Offset: 0x2AA70D1 VA: 0x2AA6FD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x2AA7F20 Offset: 0x2AA8021 VA: 0x2AA7F20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x2AA8F90 Offset: 0x2AA9091 VA: 0x2AA8F90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.Equals
	|
	|-RVA: 0x2AA9EC0 Offset: 0x2AA9FC1 VA: 0x2AA9EC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.Equals
	|
	|-RVA: 0x2AAA930 Offset: 0x2AAAA31 VA: 0x2AAA930
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.Equals
	|
	|-RVA: 0x2AAB550 Offset: 0x2AAB651 VA: 0x2AAB550
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.Equals
	|
	|-RVA: 0x2AAC0D0 Offset: 0x2AAC1D1 VA: 0x2AAC0D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.Equals
	|
	|-RVA: 0x2AACCC0 Offset: 0x2AACDC1 VA: 0x2AACCC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.Equals
	|
	|-RVA: 0x2AAD970 Offset: 0x2AADA71 VA: 0x2AAD970
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.Equals
	|
	|-RVA: 0x2AAE520 Offset: 0x2AAE621 VA: 0x2AAE520
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.Equals
	|
	|-RVA: 0x2AAF0E0 Offset: 0x2AAF1E1 VA: 0x2AAF0E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.Equals
	|
	|-RVA: 0x2AAFD70 Offset: 0x2AAFE71 VA: 0x2AAFD70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x2AB09E0 Offset: 0x2AB0AE1 VA: 0x2AB09E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.Equals
	|
	|-RVA: 0x2AB16A0 Offset: 0x2AB17A1 VA: 0x2AB16A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.Equals
	|
	|-RVA: 0x2AB2290 Offset: 0x2AB2391 VA: 0x2AB2290
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.Equals
	|
	|-RVA: 0x2AB2E90 Offset: 0x2AB2F91 VA: 0x2AB2E90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.Equals
	|
	|-RVA: 0x2AB39A0 Offset: 0x2AB3AA1 VA: 0x2AB39A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.Equals
	|
	|-RVA: 0x2AB4500 Offset: 0x2AB4601 VA: 0x2AB4500
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.Equals
	|
	|-RVA: 0x2AB5120 Offset: 0x2AB5221 VA: 0x2AB5120
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.Equals
	|
	|-RVA: 0x2AB5D80 Offset: 0x2AB5E81 VA: 0x2AB5D80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.Equals
	|
	|-RVA: 0x2AB6A60 Offset: 0x2AB6B61 VA: 0x2AB6A60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.Equals
	|
	|-RVA: 0x2AB76F0 Offset: 0x2AB77F1 VA: 0x2AB76F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.Equals
	|
	|-RVA: 0x2AB8450 Offset: 0x2AB8551 VA: 0x2AB8450
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x2AB91E0 Offset: 0x2AB92E1 VA: 0x2AB91E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.Equals
	|
	|-RVA: 0x2ABA020 Offset: 0x2ABA121 VA: 0x2ABA020
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x2ABAE60 Offset: 0x2ABAF61 VA: 0x2ABAE60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.Equals
	|
	|-RVA: 0x2ABBD20 Offset: 0x2ABBE21 VA: 0x2ABBD20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x2ABCC00 Offset: 0x2ABCD01 VA: 0x2ABCC00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x2ABDBB0 Offset: 0x2ABDCB1 VA: 0x2ABDBB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x2ABEB50 Offset: 0x2ABEC51 VA: 0x2ABEB50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x2ABFB70 Offset: 0x2ABFC71 VA: 0x2ABFB70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x2AC0BB0 Offset: 0x2AC0CB1 VA: 0x2AC0BB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.Equals
	|
	|-RVA: 0x2AC1880 Offset: 0x2AC1981 VA: 0x2AC1880
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x2CB97B0 Offset: 0x2CB98B1 VA: 0x2CB97B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Equals
	|
	|-RVA: 0x2CBA320 Offset: 0x2CBA421 VA: 0x2CBA320
	|-UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.Equals
	|
	|-RVA: 0x2CBADB0 Offset: 0x2CBAEB1 VA: 0x2CBADB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>.Equals
	|
	|-RVA: 0x2CBB9A0 Offset: 0x2CBBAA1 VA: 0x2CBB9A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>.Equals
	|
	|-RVA: 0x2CBC4A0 Offset: 0x2CBC5A1 VA: 0x2CBC4A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>.Equals
	|
	|-RVA: 0x2CBD070 Offset: 0x2CBD171 VA: 0x2CBD070
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>.Equals
	|
	|-RVA: 0x2CBDC70 Offset: 0x2CBDD71 VA: 0x2CBDC70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, double>>>.Equals
	|
	|-RVA: 0x2CBE7C0 Offset: 0x2CBE8C1 VA: 0x2CBE7C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, int>>>.Equals
	|
	|-RVA: 0x2CBF360 Offset: 0x2CBF461 VA: 0x2CBF360
	|-UniTask<ValueTuple<bool, ValueTuple<bool, long>>>.Equals
	|
	|-RVA: 0x2CBFF80 Offset: 0x2CC0081 VA: 0x2CBFF80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x2CC0BB0 Offset: 0x2CC0CB1 VA: 0x2CC0BB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.Equals
	|
	|-RVA: 0x2CC17E0 Offset: 0x2CC18E1 VA: 0x2CC17E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>.Equals
	|
	|-RVA: 0x2CC2330 Offset: 0x2CC2431 VA: 0x2CC2330
	|-UniTask<ValueTuple<bool, ValueTuple<bool, float>>>.Equals
	|
	|-RVA: 0x2CC2EF0 Offset: 0x2CC2FF1 VA: 0x2CC2EF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>.Equals
	|
	|-RVA: 0x2CC39E0 Offset: 0x2CC3AE1 VA: 0x2CC39E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>.Equals
	|
	|-RVA: 0x2CC4520 Offset: 0x2CC4621 VA: 0x2CC4520
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>.Equals
	|
	|-RVA: 0x2CC5090 Offset: 0x2CC5191 VA: 0x2CC5090
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>.Equals
	|
	|-RVA: 0x2CC5CC0 Offset: 0x2CC5DC1 VA: 0x2CC5CC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>.Equals
	|
	|-RVA: 0x2CC68E0 Offset: 0x2CC69E1 VA: 0x2CC68E0
	|-UniTask<ValueTuple<bool, ValueTuple<int, object>>>.Equals
	|
	|-RVA: 0x2CC7510 Offset: 0x2CC7611 VA: 0x2CC7510
	|-UniTask<ValueTuple<bool, ValueTuple<object, object>>>.Equals
	|
	|-RVA: 0x2CC8210 Offset: 0x2CC8311 VA: 0x2CC8210
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x2CC8F00 Offset: 0x2CC9001 VA: 0x2CC8F00
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>.Equals
	|
	|-RVA: 0x2CC9C90 Offset: 0x2CC9D91 VA: 0x2CC9C90
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x2CCAA20 Offset: 0x2CCAB21 VA: 0x2CCAA20
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>.Equals
	|
	|-RVA: 0x2CCB890 Offset: 0x2CCB991 VA: 0x2CCB890
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x2CCC6D0 Offset: 0x2CCC7D1 VA: 0x2CCC6D0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x2CCD5C0 Offset: 0x2CCD6C1 VA: 0x2CCD5C0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x2CCE4B0 Offset: 0x2CCE5B1 VA: 0x2CCE4B0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x2CCF4B0 Offset: 0x2CCF5B1 VA: 0x2CCF4B0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x2CD0430 Offset: 0x2CD0531 VA: 0x2CD0430
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.Equals
	|
	|-RVA: 0x2CD1380 Offset: 0x2CD1481 VA: 0x2CD1380
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x2CD23B0 Offset: 0x2CD24B1 VA: 0x2CD23B0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Equals
	|
	|-RVA: 0x2CD2F20 Offset: 0x2CD3021 VA: 0x2CD2F20
	|-UniTask<ValueTuple<bool, AsyncUnit>>.Equals
	|
	|-RVA: 0x2CD39A0 Offset: 0x2CD3AA1 VA: 0x2CD39A0
	|-UniTask<ValueTuple<bool, bool>>.Equals
	|
	|-RVA: 0x2CD4580 Offset: 0x2CD4681 VA: 0x2CD4580
	|-UniTask<ValueTuple<bool, Bounds>>.Equals
	|
	|-RVA: 0x2CD50E0 Offset: 0x2CD51E1 VA: 0x2CD50E0
	|-UniTask<ValueTuple<bool, byte>>.Equals
	|
	|-RVA: 0x2CD5C40 Offset: 0x2CD5D41 VA: 0x2CD5C40
	|-UniTask<ValueTuple<bool, Color>>.Equals
	|
	|-RVA: 0x2CD67D0 Offset: 0x2CD68D1 VA: 0x2CD67D0
	|-UniTask<ValueTuple<bool, double>>.Equals
	|
	|-RVA: 0x2CD7250 Offset: 0x2CD7351 VA: 0x2CD7250
	|-UniTask<ValueTuple<bool, int>>.Equals
	|
	|-RVA: 0x2CD7D30 Offset: 0x2CD7E31 VA: 0x2CD7D30
	|-UniTask<ValueTuple<bool, long>>.Equals
	|
	|-RVA: 0x2CD8870 Offset: 0x2CD8971 VA: 0x2CD8870
	|-UniTask<ValueTuple<bool, object>>.Equals
	|
	|-RVA: 0x2CD93D0 Offset: 0x2CD94D1 VA: 0x2CD93D0
	|-UniTask<ValueTuple<bool, Quaternion>>.Equals
	|
	|-RVA: 0x2CD9FB0 Offset: 0x2CDA0B1 VA: 0x2CD9FB0
	|-UniTask<ValueTuple<bool, Rect>>.Equals
	|
	|-RVA: 0x2CDAAB0 Offset: 0x2CDABB1 VA: 0x2CDAAB0
	|-UniTask<ValueTuple<bool, float>>.Equals
	|
	|-RVA: 0x2CDB5C0 Offset: 0x2CDB6C1 VA: 0x2CDB5C0
	|-UniTask<ValueTuple<bool, UniTask>>.Equals
	|
	|-RVA: 0x2CDC040 Offset: 0x2CDC141 VA: 0x2CDC040
	|-UniTask<ValueTuple<bool, Unit>>.Equals
	|
	|-RVA: 0x2CDCB00 Offset: 0x2CDCC01 VA: 0x2CDCB00
	|-UniTask<ValueTuple<bool, Vector2>>.Equals
	|
	|-RVA: 0x2CDD630 Offset: 0x2CDD731 VA: 0x2CDD630
	|-UniTask<ValueTuple<bool, Vector3>>.Equals
	|
	|-RVA: 0x2CDE190 Offset: 0x2CDE291 VA: 0x2CDE190
	|-UniTask<ValueTuple<bool, Vector4>>.Equals
	|
	|-RVA: 0x2CDED50 Offset: 0x2CDEE51 VA: 0x2CDED50
	|-UniTask<ValueTuple<int, object>>.Equals
	|
	|-RVA: 0x2CDF890 Offset: 0x2CDF991 VA: 0x2CDF890
	|-UniTask<ValueTuple<object, object>>.Equals
	|
	|-RVA: 0x2CE04D0 Offset: 0x2CE05D1 VA: 0x2CE04D0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x2CE1160 Offset: 0x2CE1261 VA: 0x2CE1160
	|-UniTask<ValueTuple<object, object, object>>.Equals
	|
	|-RVA: 0x2CE1EB0 Offset: 0x2CE1FB1 VA: 0x2CE1EB0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x2DDE0C0 Offset: 0x2DDE1C1 VA: 0x2DDE0C0
	|-UniTask<ValueTuple<object, object, object, object>>.Equals
	|
	|-RVA: 0x2DDEE90 Offset: 0x2DDEF91 VA: 0x2DDEE90
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x2DDFC80 Offset: 0x2DDFD81 VA: 0x2DDFC80
	|-UniTask<ValueTuple<object, object, object, object, object>>.Equals
	|
	|-RVA: 0x2DE0B30 Offset: 0x2DE0C31 VA: 0x2DE0B30
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x2DE19B0 Offset: 0x2DE1AB1 VA: 0x2DE19B0
	|-UniTask<ValueTuple<object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x2DE28F0 Offset: 0x2DE29F1 VA: 0x2DE28F0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Equals
	|
	|-RVA: 0x2DE3840 Offset: 0x2DE3941 VA: 0x2DE3840
	|-UniTask<ValueTuple<object, object, object, object, object, object, object>>.Equals
	|
	|-RVA: 0x2DE4850 Offset: 0x2DE4951 VA: 0x2DE4850
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x2DE5880 Offset: 0x2DE5981 VA: 0x2DE5880
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Equals
	|
	|-RVA: 0x2DE63D0 Offset: 0x2DE64D1 VA: 0x2DE63D0
	|-UniTask<AsyncUnit>.Equals
	|
	|-RVA: 0x2DE6D90 Offset: 0x2DE6E91 VA: 0x2DE6D90
	|-UniTask<bool>.Equals
	|
	|-RVA: 0x2DE78A0 Offset: 0x2DE79A1 VA: 0x2DE78A0
	|-UniTask<Bounds>.Equals
	|
	|-RVA: 0x2DE82B0 Offset: 0x2DE83B1 VA: 0x2DE82B0
	|-UniTask<byte>.Equals
	|
	|-RVA: 0x2DE8D60 Offset: 0x2DE8E61 VA: 0x2DE8D60
	|-UniTask<Color>.Equals
	|
	|-RVA: 0x2DE9740 Offset: 0x2DE9841 VA: 0x2DE9740
	|-UniTask<double>.Equals
	|
	|-RVA: 0x2DEA0F0 Offset: 0x2DEA1F1 VA: 0x2DEA0F0
	|-UniTask<int>.Equals
	|
	|-RVA: 0x2DEAAC0 Offset: 0x2DEABC1 VA: 0x2DEAAC0
	|-UniTask<long>.Equals
	|
	|-RVA: 0x2DEB4B0 Offset: 0x2DEB5B1 VA: 0x2DEB4B0
	|-UniTask<object>.Equals
	|
	|-RVA: 0x2DEBF30 Offset: 0x2DEC031 VA: 0x2DEBF30
	|-UniTask<Quaternion>.Equals
	|
	|-RVA: 0x2DEC9F0 Offset: 0x2DECAF1 VA: 0x2DEC9F0
	|-UniTask<Rect>.Equals
	|
	|-RVA: 0x2DED3C0 Offset: 0x2DED4C1 VA: 0x2DED3C0
	|-UniTask<float>.Equals
	|
	|-RVA: 0x2DEDDC0 Offset: 0x2DEDEC1 VA: 0x2DEDDC0
	|-UniTask<UniTask>.Equals
	|
	|-RVA: 0x2DEE780 Offset: 0x2DEE881 VA: 0x2DEE780
	|-UniTask<Unit>.Equals
	|
	|-RVA: 0x2DEF190 Offset: 0x2DEF291 VA: 0x2DEF190
	|-UniTask<Vector2>.Equals
	|
	|-RVA: 0x2DEFBD0 Offset: 0x2DEFCD1 VA: 0x2DEFBD0
	|-UniTask<Vector3>.Equals
	|
	|-RVA: 0x2DF0690 Offset: 0x2DF0791 VA: 0x2DF0690
	|-UniTask<Vector4>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3587C90 Offset: 0x3587D91 VA: 0x3587C90
	|-UniTask<UniTask<object>>.GetHashCode
	|
	|-RVA: 0x3588890 Offset: 0x3588991 VA: 0x3588890
	|-UniTask<ValueTuple<bool, UniTask<object>>>.GetHashCode
	|
	|-RVA: 0x3589510 Offset: 0x3589611 VA: 0x3589510
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.GetHashCode
	|
	|-RVA: 0x358A200 Offset: 0x358A301 VA: 0x358A200
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.GetHashCode
	|
	|-RVA: 0x358ADF0 Offset: 0x358AEF1 VA: 0x358ADF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.GetHashCode
	|
	|-RVA: 0x302E0C0 Offset: 0x302E1C1 VA: 0x302E0C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.GetHashCode
	|
	|-RVA: 0x302EB40 Offset: 0x302EC41 VA: 0x302EB40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.GetHashCode
	|
	|-RVA: 0x302F810 Offset: 0x302F911 VA: 0x302F810
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.GetHashCode
	|
	|-RVA: 0x3030370 Offset: 0x3030471 VA: 0x3030370
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.GetHashCode
	|
	|-RVA: 0x3030FC0 Offset: 0x30310C1 VA: 0x3030FC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.GetHashCode
	|
	|-RVA: 0x3031D10 Offset: 0x3031E11 VA: 0x3031D10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.GetHashCode
	|
	|-RVA: 0x3032810 Offset: 0x3032911 VA: 0x3032810
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.GetHashCode
	|
	|-RVA: 0x3033360 Offset: 0x3033461 VA: 0x3033360
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.GetHashCode
	|
	|-RVA: 0x3033F10 Offset: 0x3034011 VA: 0x3033F10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x3034AA0 Offset: 0x3034BA1 VA: 0x3034AA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.GetHashCode
	|
	|-RVA: 0x3035650 Offset: 0x3035751 VA: 0x3035650
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.GetHashCode
	|
	|-RVA: 0x3036170 Offset: 0x3036271 VA: 0x3036170
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.GetHashCode
	|
	|-RVA: 0x3036CD0 Offset: 0x3036DD1 VA: 0x3036CD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.GetHashCode
	|
	|-RVA: 0x3037720 Offset: 0x3037821 VA: 0x3037720
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.GetHashCode
	|
	|-RVA: 0x30381F0 Offset: 0x30382F1 VA: 0x30381F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.GetHashCode
	|
	|-RVA: 0x3038D00 Offset: 0x3038E01 VA: 0x3038D00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.GetHashCode
	|
	|-RVA: 0x3039850 Offset: 0x3039951 VA: 0x3039850
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.GetHashCode
	|
	|-RVA: 0x303A420 Offset: 0x303A521 VA: 0x303A420
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.GetHashCode
	|
	|-RVA: 0x303AFD0 Offset: 0x303B0D1 VA: 0x303AFD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x303BD50 Offset: 0x303BE51 VA: 0x303BD50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x303CB30 Offset: 0x303CC31 VA: 0x303CB30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x303D960 Offset: 0x303DA61 VA: 0x303D960
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x303E7F0 Offset: 0x303E8F1 VA: 0x303E7F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x303F6C0 Offset: 0x303F7C1 VA: 0x303F6C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.GetHashCode
	|
	|-RVA: 0x30402A0 Offset: 0x30403A1 VA: 0x30402A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.GetHashCode
	|
	|-RVA: 0x3040D20 Offset: 0x3040E21 VA: 0x3040D20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.GetHashCode
	|
	|-RVA: 0x30419C0 Offset: 0x3041AC1 VA: 0x30419C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.GetHashCode
	|
	|-RVA: 0x30424E0 Offset: 0x30425E1 VA: 0x30424E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.GetHashCode
	|
	|-RVA: 0x30430E0 Offset: 0x30431E1 VA: 0x30430E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.GetHashCode
	|
	|-RVA: 0x3043DB0 Offset: 0x3043EB1 VA: 0x3043DB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.GetHashCode
	|
	|-RVA: 0x30449E0 Offset: 0x3044AE1 VA: 0x30449E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.GetHashCode
	|
	|-RVA: 0x2A97270 Offset: 0x2A97371 VA: 0x2A97270
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.GetHashCode
	|
	|-RVA: 0x2A97F90 Offset: 0x2A98091 VA: 0x2A97F90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x2A98C30 Offset: 0x2A98D31 VA: 0x2A98C30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.GetHashCode
	|
	|-RVA: 0x2A99890 Offset: 0x2A99991 VA: 0x2A99890
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.GetHashCode
	|
	|-RVA: 0x2A9A490 Offset: 0x2A9A591 VA: 0x2A9A490
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.GetHashCode
	|
	|-RVA: 0x2A9B160 Offset: 0x2A9B261 VA: 0x2A9B160
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.GetHashCode
	|
	|-RVA: 0x2A9BC70 Offset: 0x2A9BD71 VA: 0x2A9BC70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.GetHashCode
	|
	|-RVA: 0x2A9C850 Offset: 0x2A9C951 VA: 0x2A9C850
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.GetHashCode
	|
	|-RVA: 0x2A9D4E0 Offset: 0x2A9D5E1 VA: 0x2A9D4E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.GetHashCode
	|
	|-RVA: 0x2A9E170 Offset: 0x2A9E271 VA: 0x2A9E170
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.GetHashCode
	|
	|-RVA: 0x2A9EE50 Offset: 0x2A9EF51 VA: 0x2A9EE50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.GetHashCode
	|
	|-RVA: 0x2A9FB70 Offset: 0x2A9FC71 VA: 0x2A9FB70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.GetHashCode
	|
	|-RVA: 0x2AA0940 Offset: 0x2AA0A41 VA: 0x2AA0940
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x2AA1700 Offset: 0x2AA1801 VA: 0x2AA1700
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x2AA2560 Offset: 0x2AA2661 VA: 0x2AA2560
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x2AA33D0 Offset: 0x2AA34D1 VA: 0x2AA33D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x2AA4300 Offset: 0x2AA4401 VA: 0x2AA4300
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x2AA51E0 Offset: 0x2AA52E1 VA: 0x2AA51E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x2AA61C0 Offset: 0x2AA62C1 VA: 0x2AA61C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x2AA7140 Offset: 0x2AA7241 VA: 0x2AA7140
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x2AA80F0 Offset: 0x2AA81F1 VA: 0x2AA80F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x2AA9100 Offset: 0x2AA9201 VA: 0x2AA9100
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.GetHashCode
	|
	|-RVA: 0x2AA9F90 Offset: 0x2AAA091 VA: 0x2AA9F90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.GetHashCode
	|
	|-RVA: 0x2AAAA00 Offset: 0x2AAAB01 VA: 0x2AAAA00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.GetHashCode
	|
	|-RVA: 0x2AAB680 Offset: 0x2AAB781 VA: 0x2AAB680
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.GetHashCode
	|
	|-RVA: 0x2AAC1A0 Offset: 0x2AAC2A1 VA: 0x2AAC1A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.GetHashCode
	|
	|-RVA: 0x2AACDF0 Offset: 0x2AACEF1 VA: 0x2AACDF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.GetHashCode
	|
	|-RVA: 0x2AADA80 Offset: 0x2AADB81 VA: 0x2AADA80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.GetHashCode
	|
	|-RVA: 0x2AAE5E0 Offset: 0x2AAE6E1 VA: 0x2AAE5E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.GetHashCode
	|
	|-RVA: 0x2AAF1F0 Offset: 0x2AAF2F1 VA: 0x2AAF1F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.GetHashCode
	|
	|-RVA: 0x2AAFE80 Offset: 0x2AAFF81 VA: 0x2AAFE80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x2AB0B10 Offset: 0x2AB0C11 VA: 0x2AB0B10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.GetHashCode
	|
	|-RVA: 0x2AB17D0 Offset: 0x2AB18D1 VA: 0x2AB17D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.GetHashCode
	|
	|-RVA: 0x2AB2350 Offset: 0x2AB2451 VA: 0x2AB2350
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.GetHashCode
	|
	|-RVA: 0x2AB2FA0 Offset: 0x2AB30A1 VA: 0x2AB2FA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.GetHashCode
	|
	|-RVA: 0x2AB3A70 Offset: 0x2AB3B71 VA: 0x2AB3A70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.GetHashCode
	|
	|-RVA: 0x2AB4610 Offset: 0x2AB4711 VA: 0x2AB4610
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.GetHashCode
	|
	|-RVA: 0x2AB5230 Offset: 0x2AB5331 VA: 0x2AB5230
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.GetHashCode
	|
	|-RVA: 0x2AB5EB0 Offset: 0x2AB5FB1 VA: 0x2AB5EB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.GetHashCode
	|
	|-RVA: 0x2AB6B70 Offset: 0x2AB6C71 VA: 0x2AB6B70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.GetHashCode
	|
	|-RVA: 0x2AB7800 Offset: 0x2AB7901 VA: 0x2AB7800
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.GetHashCode
	|
	|-RVA: 0x2AB85A0 Offset: 0x2AB86A1 VA: 0x2AB85A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x2AB9310 Offset: 0x2AB9411 VA: 0x2AB9310
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x2ABA190 Offset: 0x2ABA291 VA: 0x2ABA190
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x2ABAF90 Offset: 0x2ABB091 VA: 0x2ABAF90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x2ABBEB0 Offset: 0x2ABBFB1 VA: 0x2ABBEB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x2ABCD50 Offset: 0x2ABCE51 VA: 0x2ABCD50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x2ABDD60 Offset: 0x2ABDE61 VA: 0x2ABDD60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x2ABECA0 Offset: 0x2ABEDA1 VA: 0x2ABECA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x2ABFD40 Offset: 0x2ABFE41 VA: 0x2ABFD40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x2AC0D20 Offset: 0x2AC0E21 VA: 0x2AC0D20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.GetHashCode
	|
	|-RVA: 0x2AC1990 Offset: 0x2AC1A91 VA: 0x2AC1990
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x2CB98C0 Offset: 0x2CB99C1 VA: 0x2CB98C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.GetHashCode
	|
	|-RVA: 0x2CBA3F0 Offset: 0x2CBA4F1 VA: 0x2CBA3F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.GetHashCode
	|
	|-RVA: 0x2CBAE80 Offset: 0x2CBAF81 VA: 0x2CBAE80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>.GetHashCode
	|
	|-RVA: 0x2CBBAB0 Offset: 0x2CBBBB1 VA: 0x2CBBAB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>.GetHashCode
	|
	|-RVA: 0x2CBC570 Offset: 0x2CBC671 VA: 0x2CBC570
	|-UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>.GetHashCode
	|
	|-RVA: 0x2CBD180 Offset: 0x2CBD281 VA: 0x2CBD180
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>.GetHashCode
	|
	|-RVA: 0x2CBDD80 Offset: 0x2CBDE81 VA: 0x2CBDD80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, double>>>.GetHashCode
	|
	|-RVA: 0x2CBE890 Offset: 0x2CBE991 VA: 0x2CBE890
	|-UniTask<ValueTuple<bool, ValueTuple<bool, int>>>.GetHashCode
	|
	|-RVA: 0x2CBF470 Offset: 0x2CBF571 VA: 0x2CBF470
	|-UniTask<ValueTuple<bool, ValueTuple<bool, long>>>.GetHashCode
	|
	|-RVA: 0x2CC0090 Offset: 0x2CC0191 VA: 0x2CC0090
	|-UniTask<ValueTuple<bool, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x2CC0CC0 Offset: 0x2CC0DC1 VA: 0x2CC0CC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.GetHashCode
	|
	|-RVA: 0x2CC18F0 Offset: 0x2CC19F1 VA: 0x2CC18F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>.GetHashCode
	|
	|-RVA: 0x2CC2400 Offset: 0x2CC2501 VA: 0x2CC2400
	|-UniTask<ValueTuple<bool, ValueTuple<bool, float>>>.GetHashCode
	|
	|-RVA: 0x2CC3000 Offset: 0x2CC3101 VA: 0x2CC3000
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>.GetHashCode
	|
	|-RVA: 0x2CC3AB0 Offset: 0x2CC3BB1 VA: 0x2CC3AB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>.GetHashCode
	|
	|-RVA: 0x2CC45E0 Offset: 0x2CC46E1 VA: 0x2CC45E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>.GetHashCode
	|
	|-RVA: 0x2CC51A0 Offset: 0x2CC52A1 VA: 0x2CC51A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>.GetHashCode
	|
	|-RVA: 0x2CC5DD0 Offset: 0x2CC5ED1 VA: 0x2CC5DD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>.GetHashCode
	|
	|-RVA: 0x2CC69F0 Offset: 0x2CC6AF1 VA: 0x2CC69F0
	|-UniTask<ValueTuple<bool, ValueTuple<int, object>>>.GetHashCode
	|
	|-RVA: 0x2CC7620 Offset: 0x2CC7721 VA: 0x2CC7620
	|-UniTask<ValueTuple<bool, ValueTuple<object, object>>>.GetHashCode
	|
	|-RVA: 0x2CC8340 Offset: 0x2CC8441 VA: 0x2CC8340
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x2CC9010 Offset: 0x2CC9111 VA: 0x2CC9010
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>.GetHashCode
	|
	|-RVA: 0x2CC9DE0 Offset: 0x2CC9EE1 VA: 0x2CC9DE0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x2CCAB50 Offset: 0x2CCAC51 VA: 0x2CCAB50
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x2CCBA00 Offset: 0x2CCBB01 VA: 0x2CCBA00
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x2CCC800 Offset: 0x2CCC901 VA: 0x2CCC800
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x2CCD750 Offset: 0x2CCD851 VA: 0x2CCD750
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x2CCE600 Offset: 0x2CCE701 VA: 0x2CCE600
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x2CCF660 Offset: 0x2CCF761 VA: 0x2CCF660
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x2CD0580 Offset: 0x2CD0681 VA: 0x2CD0580
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.GetHashCode
	|
	|-RVA: 0x2CD1550 Offset: 0x2CD1651 VA: 0x2CD1550
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x2CD24C0 Offset: 0x2CD25C1 VA: 0x2CD24C0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.GetHashCode
	|
	|-RVA: 0x2CD2FF0 Offset: 0x2CD30F1 VA: 0x2CD2FF0
	|-UniTask<ValueTuple<bool, AsyncUnit>>.GetHashCode
	|
	|-RVA: 0x2CD3A70 Offset: 0x2CD3B71 VA: 0x2CD3A70
	|-UniTask<ValueTuple<bool, bool>>.GetHashCode
	|
	|-RVA: 0x2CD46B0 Offset: 0x2CD47B1 VA: 0x2CD46B0
	|-UniTask<ValueTuple<bool, Bounds>>.GetHashCode
	|
	|-RVA: 0x2CD51B0 Offset: 0x2CD52B1 VA: 0x2CD51B0
	|-UniTask<ValueTuple<bool, byte>>.GetHashCode
	|
	|-RVA: 0x2CD5D50 Offset: 0x2CD5E51 VA: 0x2CD5D50
	|-UniTask<ValueTuple<bool, Color>>.GetHashCode
	|
	|-RVA: 0x2CD6890 Offset: 0x2CD6991 VA: 0x2CD6890
	|-UniTask<ValueTuple<bool, double>>.GetHashCode
	|
	|-RVA: 0x2CD7320 Offset: 0x2CD7421 VA: 0x2CD7320
	|-UniTask<ValueTuple<bool, int>>.GetHashCode
	|
	|-RVA: 0x2CD7DF0 Offset: 0x2CD7EF1 VA: 0x2CD7DF0
	|-UniTask<ValueTuple<bool, long>>.GetHashCode
	|
	|-RVA: 0x2CD8930 Offset: 0x2CD8A31 VA: 0x2CD8930
	|-UniTask<ValueTuple<bool, object>>.GetHashCode
	|
	|-RVA: 0x2CD94E0 Offset: 0x2CD95E1 VA: 0x2CD94E0
	|-UniTask<ValueTuple<bool, Quaternion>>.GetHashCode
	|
	|-RVA: 0x2CDA0C0 Offset: 0x2CDA1C1 VA: 0x2CDA0C0
	|-UniTask<ValueTuple<bool, Rect>>.GetHashCode
	|
	|-RVA: 0x2CDAB80 Offset: 0x2CDAC81 VA: 0x2CDAB80
	|-UniTask<ValueTuple<bool, float>>.GetHashCode
	|
	|-RVA: 0x2CDB680 Offset: 0x2CDB781 VA: 0x2CDB680
	|-UniTask<ValueTuple<bool, UniTask>>.GetHashCode
	|
	|-RVA: 0x2CDC110 Offset: 0x2CDC211 VA: 0x2CDC110
	|-UniTask<ValueTuple<bool, Unit>>.GetHashCode
	|
	|-RVA: 0x2CDCBD0 Offset: 0x2CDCCD1 VA: 0x2CDCBD0
	|-UniTask<ValueTuple<bool, Vector2>>.GetHashCode
	|
	|-RVA: 0x2CDD6F0 Offset: 0x2CDD7F1 VA: 0x2CDD6F0
	|-UniTask<ValueTuple<bool, Vector3>>.GetHashCode
	|
	|-RVA: 0x2CDE2A0 Offset: 0x2CDE3A1 VA: 0x2CDE2A0
	|-UniTask<ValueTuple<bool, Vector4>>.GetHashCode
	|
	|-RVA: 0x2CDEE10 Offset: 0x2CDEF11 VA: 0x2CDEE10
	|-UniTask<ValueTuple<int, object>>.GetHashCode
	|
	|-RVA: 0x2CDF950 Offset: 0x2CDFA51 VA: 0x2CDF950
	|-UniTask<ValueTuple<object, object>>.GetHashCode
	|
	|-RVA: 0x2CE0600 Offset: 0x2CE0701 VA: 0x2CE0600
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x2CE1270 Offset: 0x2CE1371 VA: 0x2CE1270
	|-UniTask<ValueTuple<object, object, object>>.GetHashCode
	|
	|-RVA: 0x2CE2000 Offset: 0x2CE2101 VA: 0x2CE2000
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x2DDE1D0 Offset: 0x2DDE2D1 VA: 0x2DDE1D0
	|-UniTask<ValueTuple<object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x2DDF000 Offset: 0x2DDF101 VA: 0x2DDF000
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x2DDFDB0 Offset: 0x2DDFEB1 VA: 0x2DDFDB0
	|-UniTask<ValueTuple<object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x2DE0CC0 Offset: 0x2DE0DC1 VA: 0x2DE0CC0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x2DE1AE0 Offset: 0x2DE1BE1 VA: 0x2DE1AE0
	|-UniTask<ValueTuple<object, object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x2DE2AA0 Offset: 0x2DE2BA1 VA: 0x2DE2AA0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.GetHashCode
	|
	|-RVA: 0x2DE3990 Offset: 0x2DE3A91 VA: 0x2DE3990
	|-UniTask<ValueTuple<object, object, object, object, object, object, object>>.GetHashCode
	|
	|-RVA: 0x2DE4A20 Offset: 0x2DE4B21 VA: 0x2DE4A20
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x2DE5990 Offset: 0x2DE5A91 VA: 0x2DE5990
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.GetHashCode
	|
	|-RVA: 0x2DE64A0 Offset: 0x2DE65A1 VA: 0x2DE64A0
	|-UniTask<AsyncUnit>.GetHashCode
	|
	|-RVA: 0x2DE6E60 Offset: 0x2DE6F61 VA: 0x2DE6E60
	|-UniTask<bool>.GetHashCode
	|
	|-RVA: 0x2DE79B0 Offset: 0x2DE7AB1 VA: 0x2DE79B0
	|-UniTask<Bounds>.GetHashCode
	|
	|-RVA: 0x2DE8380 Offset: 0x2DE8481 VA: 0x2DE8380
	|-UniTask<byte>.GetHashCode
	|
	|-RVA: 0x2DE8E30 Offset: 0x2DE8F31 VA: 0x2DE8E30
	|-UniTask<Color>.GetHashCode
	|
	|-RVA: 0x2DE9810 Offset: 0x2DE9911 VA: 0x2DE9810
	|-UniTask<double>.GetHashCode
	|
	|-RVA: 0x2DEA1C0 Offset: 0x2DEA2C1 VA: 0x2DEA1C0
	|-UniTask<int>.GetHashCode
	|
	|-RVA: 0x2DEAB90 Offset: 0x2DEAC91 VA: 0x2DEAB90
	|-UniTask<long>.GetHashCode
	|
	|-RVA: 0x2DEB580 Offset: 0x2DEB681 VA: 0x2DEB580
	|-UniTask<object>.GetHashCode
	|
	|-RVA: 0x2DEC000 Offset: 0x2DEC101 VA: 0x2DEC000
	|-UniTask<Quaternion>.GetHashCode
	|
	|-RVA: 0x2DECAC0 Offset: 0x2DECBC1 VA: 0x2DECAC0
	|-UniTask<Rect>.GetHashCode
	|
	|-RVA: 0x2DED490 Offset: 0x2DED591 VA: 0x2DED490
	|-UniTask<float>.GetHashCode
	|
	|-RVA: 0x2DEDE90 Offset: 0x2DEDF91 VA: 0x2DEDE90
	|-UniTask<UniTask>.GetHashCode
	|
	|-RVA: 0x2DEE850 Offset: 0x2DEE951 VA: 0x2DEE850
	|-UniTask<Unit>.GetHashCode
	|
	|-RVA: 0x2DEF260 Offset: 0x2DEF361 VA: 0x2DEF260
	|-UniTask<Vector2>.GetHashCode
	|
	|-RVA: 0x2DEFCA0 Offset: 0x2DEFDA1 VA: 0x2DEFCA0
	|-UniTask<Vector3>.GetHashCode
	|
	|-RVA: 0x2DF0760 Offset: 0x2DF0861 VA: 0x2DF0760
	|-UniTask<Vector4>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3587D30 Offset: 0x3587E31 VA: 0x3587D30
	|-UniTask<UniTask<object>>.ToString
	|
	|-RVA: 0x3588950 Offset: 0x3588A51 VA: 0x3588950
	|-UniTask<ValueTuple<bool, UniTask<object>>>.ToString
	|
	|-RVA: 0x35895D0 Offset: 0x35896D1 VA: 0x35895D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.ToString
	|
	|-RVA: 0x358A2E0 Offset: 0x358A3E1 VA: 0x358A2E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.ToString
	|
	|-RVA: 0x358AED0 Offset: 0x358AFD1 VA: 0x358AED0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.ToString
	|
	|-RVA: 0x302E160 Offset: 0x302E261 VA: 0x302E160
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.ToString
	|
	|-RVA: 0x302EBE0 Offset: 0x302ECE1 VA: 0x302EBE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.ToString
	|
	|-RVA: 0x302F910 Offset: 0x302FA11 VA: 0x302F910
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.ToString
	|
	|-RVA: 0x3030410 Offset: 0x3030511 VA: 0x3030410
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.ToString
	|
	|-RVA: 0x30310B0 Offset: 0x30311B1 VA: 0x30310B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.ToString
	|
	|-RVA: 0x3031DF0 Offset: 0x3031EF1 VA: 0x3031DF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.ToString
	|
	|-RVA: 0x30328D0 Offset: 0x30329D1 VA: 0x30328D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.ToString
	|
	|-RVA: 0x3033440 Offset: 0x3033541 VA: 0x3033440
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.ToString
	|
	|-RVA: 0x3033FF0 Offset: 0x30340F1 VA: 0x3033FF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x3034B90 Offset: 0x3034C91 VA: 0x3034B90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.ToString
	|
	|-RVA: 0x3035740 Offset: 0x3035841 VA: 0x3035740
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.ToString
	|
	|-RVA: 0x3036230 Offset: 0x3036331 VA: 0x3036230
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.ToString
	|
	|-RVA: 0x3036DB0 Offset: 0x3036EB1 VA: 0x3036DB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.ToString
	|
	|-RVA: 0x30377C0 Offset: 0x30378C1 VA: 0x30377C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.ToString
	|
	|-RVA: 0x30382D0 Offset: 0x30383D1 VA: 0x30382D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.ToString
	|
	|-RVA: 0x3038DC0 Offset: 0x3038EC1 VA: 0x3038DC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.ToString
	|
	|-RVA: 0x3039940 Offset: 0x3039A41 VA: 0x3039940
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.ToString
	|
	|-RVA: 0x303A500 Offset: 0x303A601 VA: 0x303A500
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.ToString
	|
	|-RVA: 0x303B0B0 Offset: 0x303B1B1 VA: 0x303B0B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.ToString
	|
	|-RVA: 0x303BE50 Offset: 0x303BF51 VA: 0x303BE50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.ToString
	|
	|-RVA: 0x303CC30 Offset: 0x303CD31 VA: 0x303CC30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.ToString
	|
	|-RVA: 0x303DA80 Offset: 0x303DB81 VA: 0x303DA80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.ToString
	|
	|-RVA: 0x303E910 Offset: 0x303EA11 VA: 0x303E910
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.ToString
	|
	|-RVA: 0x303F7F0 Offset: 0x303F8F1 VA: 0x303F7F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.ToString
	|
	|-RVA: 0x3040340 Offset: 0x3040441 VA: 0x3040340
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.ToString
	|
	|-RVA: 0x3040DC0 Offset: 0x3040EC1 VA: 0x3040DC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.ToString
	|
	|-RVA: 0x3041AA0 Offset: 0x3041BA1 VA: 0x3041AA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.ToString
	|
	|-RVA: 0x3042580 Offset: 0x3042681 VA: 0x3042580
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.ToString
	|
	|-RVA: 0x30431A0 Offset: 0x30432A1 VA: 0x30431A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.ToString
	|
	|-RVA: 0x3043E90 Offset: 0x3043F91 VA: 0x3043E90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.ToString
	|
	|-RVA: 0x3044AA0 Offset: 0x3044BA1 VA: 0x3044AA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.ToString
	|
	|-RVA: 0x2A97350 Offset: 0x2A97451 VA: 0x2A97350
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.ToString
	|
	|-RVA: 0x2A98070 Offset: 0x2A98171 VA: 0x2A98070
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x2A98CF0 Offset: 0x2A98DF1 VA: 0x2A98CF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.ToString
	|
	|-RVA: 0x2A99950 Offset: 0x2A99A51 VA: 0x2A99950
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.ToString
	|
	|-RVA: 0x2A9A550 Offset: 0x2A9A651 VA: 0x2A9A550
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.ToString
	|
	|-RVA: 0x2A9B240 Offset: 0x2A9B341 VA: 0x2A9B240
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.ToString
	|
	|-RVA: 0x2A9BD10 Offset: 0x2A9BE11 VA: 0x2A9BD10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.ToString
	|
	|-RVA: 0x2A9C910 Offset: 0x2A9CA11 VA: 0x2A9C910
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.ToString
	|
	|-RVA: 0x2A9D5C0 Offset: 0x2A9D6C1 VA: 0x2A9D5C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.ToString
	|
	|-RVA: 0x2A9E230 Offset: 0x2A9E331 VA: 0x2A9E230
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.ToString
	|
	|-RVA: 0x2A9EF30 Offset: 0x2A9F031 VA: 0x2A9EF30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.ToString
	|
	|-RVA: 0x2A9FC50 Offset: 0x2A9FD51 VA: 0x2A9FC50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.ToString
	|
	|-RVA: 0x2AA0A40 Offset: 0x2AA0B41 VA: 0x2AA0A40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x2AA17E0 Offset: 0x2AA18E1 VA: 0x2AA17E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.ToString
	|
	|-RVA: 0x2AA2680 Offset: 0x2AA2781 VA: 0x2AA2680
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x2AA34D0 Offset: 0x2AA35D1 VA: 0x2AA34D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.ToString
	|
	|-RVA: 0x2AA4430 Offset: 0x2AA4531 VA: 0x2AA4430
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x2AA52E0 Offset: 0x2AA53E1 VA: 0x2AA52E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.ToString
	|
	|-RVA: 0x2AA6310 Offset: 0x2AA6411 VA: 0x2AA6310
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x2AA7260 Offset: 0x2AA7361 VA: 0x2AA7260
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.ToString
	|
	|-RVA: 0x2AA8260 Offset: 0x2AA8361 VA: 0x2AA8260
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x2AA9220 Offset: 0x2AA9321 VA: 0x2AA9220
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.ToString
	|
	|-RVA: 0x2AAA020 Offset: 0x2AAA121 VA: 0x2AAA020
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.ToString
	|
	|-RVA: 0x2AAAA90 Offset: 0x2AAAB91 VA: 0x2AAAA90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.ToString
	|
	|-RVA: 0x2AAB770 Offset: 0x2AAB871 VA: 0x2AAB770
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.ToString
	|
	|-RVA: 0x2AAC230 Offset: 0x2AAC331 VA: 0x2AAC230
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.ToString
	|
	|-RVA: 0x2AACED0 Offset: 0x2AACFD1 VA: 0x2AACED0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.ToString
	|
	|-RVA: 0x2AADB40 Offset: 0x2AADC41 VA: 0x2AADB40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.ToString
	|
	|-RVA: 0x2AAE680 Offset: 0x2AAE781 VA: 0x2AAE680
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.ToString
	|
	|-RVA: 0x2AAF2B0 Offset: 0x2AAF3B1 VA: 0x2AAF2B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.ToString
	|
	|-RVA: 0x2AAFF40 Offset: 0x2AB0041 VA: 0x2AAFF40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x2AB0BF0 Offset: 0x2AB0CF1 VA: 0x2AB0BF0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.ToString
	|
	|-RVA: 0x2AB18B0 Offset: 0x2AB19B1 VA: 0x2AB18B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.ToString
	|
	|-RVA: 0x2AB23F0 Offset: 0x2AB24F1 VA: 0x2AB23F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.ToString
	|
	|-RVA: 0x2AB3060 Offset: 0x2AB3161 VA: 0x2AB3060
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.ToString
	|
	|-RVA: 0x2AB3B00 Offset: 0x2AB3C01 VA: 0x2AB3B00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.ToString
	|
	|-RVA: 0x2AB46D0 Offset: 0x2AB47D1 VA: 0x2AB46D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.ToString
	|
	|-RVA: 0x2AB52F0 Offset: 0x2AB53F1 VA: 0x2AB52F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.ToString
	|
	|-RVA: 0x2AB5F90 Offset: 0x2AB6091 VA: 0x2AB5F90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.ToString
	|
	|-RVA: 0x2AB6C30 Offset: 0x2AB6D31 VA: 0x2AB6C30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.ToString
	|
	|-RVA: 0x2AB78C0 Offset: 0x2AB79C1 VA: 0x2AB78C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.ToString
	|
	|-RVA: 0x2AB86A0 Offset: 0x2AB87A1 VA: 0x2AB86A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x2AB93F0 Offset: 0x2AB94F1 VA: 0x2AB93F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.ToString
	|
	|-RVA: 0x2ABA2B0 Offset: 0x2ABA3B1 VA: 0x2ABA2B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x2ABB070 Offset: 0x2ABB171 VA: 0x2ABB070
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.ToString
	|
	|-RVA: 0x2ABBFE0 Offset: 0x2ABC0E1 VA: 0x2ABBFE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x2ABCE50 Offset: 0x2ABCF51 VA: 0x2ABCE50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.ToString
	|
	|-RVA: 0x2ABDEB0 Offset: 0x2ABDFB1 VA: 0x2ABDEB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x2ABEDA0 Offset: 0x2ABEEA1 VA: 0x2ABEDA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.ToString
	|
	|-RVA: 0x2ABFEB0 Offset: 0x2ABFFB1 VA: 0x2ABFEB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x2AC0E40 Offset: 0x2AC0F41 VA: 0x2AC0E40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.ToString
	|
	|-RVA: 0x2AC1A80 Offset: 0x2AC1B81 VA: 0x2AC1A80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x2CB99C0 Offset: 0x2CB9AC1 VA: 0x2CB99C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.ToString
	|
	|-RVA: 0x2CBA490 Offset: 0x2CBA591 VA: 0x2CBA490
	|-UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.ToString
	|
	|-RVA: 0x2CBAF20 Offset: 0x2CBB021 VA: 0x2CBAF20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>.ToString
	|
	|-RVA: 0x2CBBB70 Offset: 0x2CBBC71 VA: 0x2CBBB70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>.ToString
	|
	|-RVA: 0x2CBC610 Offset: 0x2CBC711 VA: 0x2CBC610
	|-UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>.ToString
	|
	|-RVA: 0x2CBD240 Offset: 0x2CBD341 VA: 0x2CBD240
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>.ToString
	|
	|-RVA: 0x2CBDE40 Offset: 0x2CBDF41 VA: 0x2CBDE40
	|-UniTask<ValueTuple<bool, ValueTuple<bool, double>>>.ToString
	|
	|-RVA: 0x2CBE930 Offset: 0x2CBEA31 VA: 0x2CBE930
	|-UniTask<ValueTuple<bool, ValueTuple<bool, int>>>.ToString
	|
	|-RVA: 0x2CBF530 Offset: 0x2CBF631 VA: 0x2CBF530
	|-UniTask<ValueTuple<bool, ValueTuple<bool, long>>>.ToString
	|
	|-RVA: 0x2CC0150 Offset: 0x2CC0251 VA: 0x2CC0150
	|-UniTask<ValueTuple<bool, ValueTuple<bool, object>>>.ToString
	|
	|-RVA: 0x2CC0D80 Offset: 0x2CC0E81 VA: 0x2CC0D80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.ToString
	|
	|-RVA: 0x2CC19B0 Offset: 0x2CC1AB1 VA: 0x2CC19B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>.ToString
	|
	|-RVA: 0x2CC24A0 Offset: 0x2CC25A1 VA: 0x2CC24A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, float>>>.ToString
	|
	|-RVA: 0x2CC30C0 Offset: 0x2CC31C1 VA: 0x2CC30C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>.ToString
	|
	|-RVA: 0x2CC3B50 Offset: 0x2CC3C51 VA: 0x2CC3B50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>.ToString
	|
	|-RVA: 0x2CC4680 Offset: 0x2CC4781 VA: 0x2CC4680
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>.ToString
	|
	|-RVA: 0x2CC5260 Offset: 0x2CC5361 VA: 0x2CC5260
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>.ToString
	|
	|-RVA: 0x2CC5E90 Offset: 0x2CC5F91 VA: 0x2CC5E90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>.ToString
	|
	|-RVA: 0x2CC6AB0 Offset: 0x2CC6BB1 VA: 0x2CC6AB0
	|-UniTask<ValueTuple<bool, ValueTuple<int, object>>>.ToString
	|
	|-RVA: 0x2CC76E0 Offset: 0x2CC77E1 VA: 0x2CC76E0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object>>>.ToString
	|
	|-RVA: 0x2CC8420 Offset: 0x2CC8521 VA: 0x2CC8420
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x2CC90D0 Offset: 0x2CC91D1 VA: 0x2CC90D0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>.ToString
	|
	|-RVA: 0x2CC9EE0 Offset: 0x2CC9FE1 VA: 0x2CC9EE0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x2CCAC30 Offset: 0x2CCAD31 VA: 0x2CCAC30
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>.ToString
	|
	|-RVA: 0x2CCBB20 Offset: 0x2CCBC21 VA: 0x2CCBB20
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x2CCC8E0 Offset: 0x2CCC9E1 VA: 0x2CCC8E0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.ToString
	|
	|-RVA: 0x2CCD880 Offset: 0x2CCD981 VA: 0x2CCD880
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x2CCE700 Offset: 0x2CCE801 VA: 0x2CCE700
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.ToString
	|
	|-RVA: 0x2CCF7B0 Offset: 0x2CCF8B1 VA: 0x2CCF7B0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x2CD0680 Offset: 0x2CD0781 VA: 0x2CD0680
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.ToString
	|
	|-RVA: 0x2CD16C0 Offset: 0x2CD17C1 VA: 0x2CD16C0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x2CD25B0 Offset: 0x2CD26B1 VA: 0x2CD25B0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.ToString
	|
	|-RVA: 0x2CD3080 Offset: 0x2CD3181 VA: 0x2CD3080
	|-UniTask<ValueTuple<bool, AsyncUnit>>.ToString
	|
	|-RVA: 0x2CD3B00 Offset: 0x2CD3C01 VA: 0x2CD3B00
	|-UniTask<ValueTuple<bool, bool>>.ToString
	|
	|-RVA: 0x2CD4790 Offset: 0x2CD4891 VA: 0x2CD4790
	|-UniTask<ValueTuple<bool, Bounds>>.ToString
	|
	|-RVA: 0x2CD5240 Offset: 0x2CD5341 VA: 0x2CD5240
	|-UniTask<ValueTuple<bool, byte>>.ToString
	|
	|-RVA: 0x2CD5E10 Offset: 0x2CD5F11 VA: 0x2CD5E10
	|-UniTask<ValueTuple<bool, Color>>.ToString
	|
	|-RVA: 0x2CD6930 Offset: 0x2CD6A31 VA: 0x2CD6930
	|-UniTask<ValueTuple<bool, double>>.ToString
	|
	|-RVA: 0x2CD73B0 Offset: 0x2CD74B1 VA: 0x2CD73B0
	|-UniTask<ValueTuple<bool, int>>.ToString
	|
	|-RVA: 0x2CD7E90 Offset: 0x2CD7F91 VA: 0x2CD7E90
	|-UniTask<ValueTuple<bool, long>>.ToString
	|
	|-RVA: 0x2CD89D0 Offset: 0x2CD8AD1 VA: 0x2CD89D0
	|-UniTask<ValueTuple<bool, object>>.ToString
	|
	|-RVA: 0x2CD95A0 Offset: 0x2CD96A1 VA: 0x2CD95A0
	|-UniTask<ValueTuple<bool, Quaternion>>.ToString
	|
	|-RVA: 0x2CDA180 Offset: 0x2CDA281 VA: 0x2CDA180
	|-UniTask<ValueTuple<bool, Rect>>.ToString
	|
	|-RVA: 0x2CDAC10 Offset: 0x2CDAD11 VA: 0x2CDAC10
	|-UniTask<ValueTuple<bool, float>>.ToString
	|
	|-RVA: 0x2CDB720 Offset: 0x2CDB821 VA: 0x2CDB720
	|-UniTask<ValueTuple<bool, UniTask>>.ToString
	|
	|-RVA: 0x2CDC1A0 Offset: 0x2CDC2A1 VA: 0x2CDC1A0
	|-UniTask<ValueTuple<bool, Unit>>.ToString
	|
	|-RVA: 0x2CDCC70 Offset: 0x2CDCD71 VA: 0x2CDCC70
	|-UniTask<ValueTuple<bool, Vector2>>.ToString
	|
	|-RVA: 0x2CDD790 Offset: 0x2CDD891 VA: 0x2CDD790
	|-UniTask<ValueTuple<bool, Vector3>>.ToString
	|
	|-RVA: 0x2CDE360 Offset: 0x2CDE461 VA: 0x2CDE360
	|-UniTask<ValueTuple<bool, Vector4>>.ToString
	|
	|-RVA: 0x2CDEEB0 Offset: 0x2CDEFB1 VA: 0x2CDEEB0
	|-UniTask<ValueTuple<int, object>>.ToString
	|
	|-RVA: 0x2CDF9F0 Offset: 0x2CDFAF1 VA: 0x2CDF9F0
	|-UniTask<ValueTuple<object, object>>.ToString
	|
	|-RVA: 0x2CE06E0 Offset: 0x2CE07E1 VA: 0x2CE06E0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.ToString
	|
	|-RVA: 0x2CE1330 Offset: 0x2CE1431 VA: 0x2CE1330
	|-UniTask<ValueTuple<object, object, object>>.ToString
	|
	|-RVA: 0x2CE2100 Offset: 0x2CE2201 VA: 0x2CE2100
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.ToString
	|
	|-RVA: 0x2DDE290 Offset: 0x2DDE391 VA: 0x2DDE290
	|-UniTask<ValueTuple<object, object, object, object>>.ToString
	|
	|-RVA: 0x2DDF120 Offset: 0x2DDF221 VA: 0x2DDF120
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.ToString
	|
	|-RVA: 0x2DDFE90 Offset: 0x2DDFF91 VA: 0x2DDFE90
	|-UniTask<ValueTuple<object, object, object, object, object>>.ToString
	|
	|-RVA: 0x2DE0DF0 Offset: 0x2DE0EF1 VA: 0x2DE0DF0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.ToString
	|
	|-RVA: 0x2DE1BC0 Offset: 0x2DE1CC1 VA: 0x2DE1BC0
	|-UniTask<ValueTuple<object, object, object, object, object, object>>.ToString
	|
	|-RVA: 0x2DE2BF0 Offset: 0x2DE2CF1 VA: 0x2DE2BF0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.ToString
	|
	|-RVA: 0x2DE3A90 Offset: 0x2DE3B91 VA: 0x2DE3A90
	|-UniTask<ValueTuple<object, object, object, object, object, object, object>>.ToString
	|
	|-RVA: 0x2DE4B90 Offset: 0x2DE4C91 VA: 0x2DE4B90
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x2DE5A80 Offset: 0x2DE5B81 VA: 0x2DE5A80
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.ToString
	|
	|-RVA: 0x2DE6500 Offset: 0x2DE6601 VA: 0x2DE6500
	|-UniTask<AsyncUnit>.ToString
	|
	|-RVA: 0x2DE6EC0 Offset: 0x2DE6FC1 VA: 0x2DE6EC0
	|-UniTask<bool>.ToString
	|
	|-RVA: 0x2DE7A10 Offset: 0x2DE7B11 VA: 0x2DE7A10
	|-UniTask<Bounds>.ToString
	|
	|-RVA: 0x2DE83E0 Offset: 0x2DE84E1 VA: 0x2DE83E0
	|-UniTask<byte>.ToString
	|
	|-RVA: 0x2DE8E90 Offset: 0x2DE8F91 VA: 0x2DE8E90
	|-UniTask<Color>.ToString
	|
	|-RVA: 0x2DE9870 Offset: 0x2DE9971 VA: 0x2DE9870
	|-UniTask<double>.ToString
	|
	|-RVA: 0x2DEA220 Offset: 0x2DEA321 VA: 0x2DEA220
	|-UniTask<int>.ToString
	|
	|-RVA: 0x2DEABF0 Offset: 0x2DEACF1 VA: 0x2DEABF0
	|-UniTask<long>.ToString
	|
	|-RVA: 0x2DEB5B0 Offset: 0x2DEB6B1 VA: 0x2DEB5B0
	|-UniTask<object>.ToString
	|
	|-RVA: 0x2DEC060 Offset: 0x2DEC161 VA: 0x2DEC060
	|-UniTask<Quaternion>.ToString
	|
	|-RVA: 0x2DECB20 Offset: 0x2DECC21 VA: 0x2DECB20
	|-UniTask<Rect>.ToString
	|
	|-RVA: 0x2DED4F0 Offset: 0x2DED5F1 VA: 0x2DED4F0
	|-UniTask<float>.ToString
	|
	|-RVA: 0x2DEDEF0 Offset: 0x2DEDFF1 VA: 0x2DEDEF0
	|-UniTask<UniTask>.ToString
	|
	|-RVA: 0x2DEE8B0 Offset: 0x2DEE9B1 VA: 0x2DEE8B0
	|-UniTask<Unit>.ToString
	|
	|-RVA: 0x2DEF2C0 Offset: 0x2DEF3C1 VA: 0x2DEF2C0
	|-UniTask<Vector2>.ToString
	|
	|-RVA: 0x2DEFD00 Offset: 0x2DEFE01 VA: 0x2DEFD00
	|-UniTask<Vector3>.ToString
	|
	|-RVA: 0x2DF07C0 Offset: 0x2DF08C1 VA: 0x2DF07C0
	|-UniTask<Vector4>.ToString
	*/

	// RVA: -1 Offset: -1
	public static UniTask op_Implicit(UniTask<T> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3587FF0 Offset: 0x35880F1 VA: 0x3587FF0
	|-UniTask<UniTask<object>>.op_Implicit
	|
	|-RVA: 0x3588C20 Offset: 0x3588D21 VA: 0x3588C20
	|-UniTask<ValueTuple<bool, UniTask<object>>>.op_Implicit
	|
	|-RVA: 0x35898B0 Offset: 0x35899B1 VA: 0x35898B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.op_Implicit
	|
	|-RVA: 0x358A5E0 Offset: 0x358A6E1 VA: 0x358A5E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.op_Implicit
	|
	|-RVA: 0x358B1D0 Offset: 0x358B2D1 VA: 0x358B1D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.op_Implicit
	|
	|-RVA: 0x302E400 Offset: 0x302E501 VA: 0x302E400
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.op_Implicit
	|
	|-RVA: 0x302EE80 Offset: 0x302EF81 VA: 0x302EE80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.op_Implicit
	|
	|-RVA: 0x302FC30 Offset: 0x302FD31 VA: 0x302FC30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.op_Implicit
	|
	|-RVA: 0x30306B0 Offset: 0x30307B1 VA: 0x30306B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.op_Implicit
	|
	|-RVA: 0x30313C0 Offset: 0x30314C1 VA: 0x30313C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.op_Implicit
	|
	|-RVA: 0x30320F0 Offset: 0x30321F1 VA: 0x30320F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.op_Implicit
	|
	|-RVA: 0x3032BA0 Offset: 0x3032CA1 VA: 0x3032BA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.op_Implicit
	|
	|-RVA: 0x3033740 Offset: 0x3033841 VA: 0x3033740
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.op_Implicit
	|
	|-RVA: 0x30342F0 Offset: 0x30343F1 VA: 0x30342F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.op_Implicit
	|
	|-RVA: 0x3034EA0 Offset: 0x3034FA1 VA: 0x3034EA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.op_Implicit
	|
	|-RVA: 0x3035A50 Offset: 0x3035B51 VA: 0x3035A50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.op_Implicit
	|
	|-RVA: 0x3036500 Offset: 0x3036601 VA: 0x3036500
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.op_Implicit
	|
	|-RVA: 0x30370B0 Offset: 0x30371B1 VA: 0x30370B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.op_Implicit
	|
	|-RVA: 0x3037A60 Offset: 0x3037B61 VA: 0x3037A60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.op_Implicit
	|
	|-RVA: 0x30385C0 Offset: 0x30386C1 VA: 0x30385C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.op_Implicit
	|
	|-RVA: 0x30390A0 Offset: 0x30391A1 VA: 0x30390A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.op_Implicit
	|
	|-RVA: 0x3039C50 Offset: 0x3039D51 VA: 0x3039C50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.op_Implicit
	|
	|-RVA: 0x303A800 Offset: 0x303A901 VA: 0x303A800
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.op_Implicit
	|
	|-RVA: 0x303B3B0 Offset: 0x303B4B1 VA: 0x303B3B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.op_Implicit
	|
	|-RVA: 0x303C170 Offset: 0x303C271 VA: 0x303C170
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.op_Implicit
	|
	|-RVA: 0x303CF60 Offset: 0x303D061 VA: 0x303CF60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.op_Implicit
	|
	|-RVA: 0x303DDD0 Offset: 0x303DED1 VA: 0x303DDD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.op_Implicit
	|
	|-RVA: 0x303EC60 Offset: 0x303ED61 VA: 0x303EC60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.op_Implicit
	|
	|-RVA: 0x303FB60 Offset: 0x303FC61 VA: 0x303FB60
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.op_Implicit
	|
	|-RVA: 0x30405E0 Offset: 0x30406E1 VA: 0x30405E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.op_Implicit
	|
	|-RVA: 0x3041060 Offset: 0x3041161 VA: 0x3041060
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.op_Implicit
	|
	|-RVA: 0x3041DA0 Offset: 0x3041EA1 VA: 0x3041DA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.op_Implicit
	|
	|-RVA: 0x3042820 Offset: 0x3042921 VA: 0x3042820
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.op_Implicit
	|
	|-RVA: 0x3043480 Offset: 0x3043581 VA: 0x3043480
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.op_Implicit
	|
	|-RVA: 0x3044190 Offset: 0x3044291 VA: 0x3044190
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.op_Implicit
	|
	|-RVA: 0x3044D70 Offset: 0x3044E71 VA: 0x3044D70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.op_Implicit
	|
	|-RVA: 0x2A97650 Offset: 0x2A97751 VA: 0x2A97650
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.op_Implicit
	|
	|-RVA: 0x2A98370 Offset: 0x2A98471 VA: 0x2A98370
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.op_Implicit
	|
	|-RVA: 0x2A98FD0 Offset: 0x2A990D1 VA: 0x2A98FD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.op_Implicit
	|
	|-RVA: 0x2A99C30 Offset: 0x2A99D31 VA: 0x2A99C30
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.op_Implicit
	|
	|-RVA: 0x2A9A820 Offset: 0x2A9A921 VA: 0x2A9A820
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.op_Implicit
	|
	|-RVA: 0x2A9B540 Offset: 0x2A9B641 VA: 0x2A9B540
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.op_Implicit
	|
	|-RVA: 0x2A9BFB0 Offset: 0x2A9C0B1 VA: 0x2A9BFB0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.op_Implicit
	|
	|-RVA: 0x2A9CBE0 Offset: 0x2A9CCE1 VA: 0x2A9CBE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.op_Implicit
	|
	|-RVA: 0x2A9D8B0 Offset: 0x2A9D9B1 VA: 0x2A9D8B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.op_Implicit
	|
	|-RVA: 0x2A9E510 Offset: 0x2A9E611 VA: 0x2A9E510
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.op_Implicit
	|
	|-RVA: 0x2A9F230 Offset: 0x2A9F331 VA: 0x2A9F230
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.op_Implicit
	|
	|-RVA: 0x2A9FF50 Offset: 0x2AA0051 VA: 0x2A9FF50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.op_Implicit
	|
	|-RVA: 0x2AA0D70 Offset: 0x2AA0E71 VA: 0x2AA0D70
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.op_Implicit
	|
	|-RVA: 0x2AA1AE0 Offset: 0x2AA1BE1 VA: 0x2AA1AE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.op_Implicit
	|
	|-RVA: 0x2AA29D0 Offset: 0x2AA2AD1 VA: 0x2AA29D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.op_Implicit
	|
	|-RVA: 0x2AA37F0 Offset: 0x2AA38F1 VA: 0x2AA37F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.op_Implicit
	|
	|-RVA: 0x2AA47B0 Offset: 0x2AA48B1 VA: 0x2AA47B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.op_Implicit
	|
	|-RVA: 0x2AA5610 Offset: 0x2AA5711 VA: 0x2AA5610
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.op_Implicit
	|
	|-RVA: 0x2AA66B0 Offset: 0x2AA67B1 VA: 0x2AA66B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.op_Implicit
	|
	|-RVA: 0x2AA75B0 Offset: 0x2AA76B1 VA: 0x2AA75B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.op_Implicit
	|
	|-RVA: 0x2AA8630 Offset: 0x2AA8731 VA: 0x2AA8630
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.op_Implicit
	|
	|-RVA: 0x2AA9570 Offset: 0x2AA9671 VA: 0x2AA9570
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.op_Implicit
	|
	|-RVA: 0x2AAA2E0 Offset: 0x2AAA3E1 VA: 0x2AAA2E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.op_Implicit
	|
	|-RVA: 0x2AAAD50 Offset: 0x2AAAE51 VA: 0x2AAAD50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.op_Implicit
	|
	|-RVA: 0x2AABA80 Offset: 0x2AABB81 VA: 0x2AABA80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.op_Implicit
	|
	|-RVA: 0x2AAC4F0 Offset: 0x2AAC5F1 VA: 0x2AAC4F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.op_Implicit
	|
	|-RVA: 0x2AAD1C0 Offset: 0x2AAD2C1 VA: 0x2AAD1C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.op_Implicit
	|
	|-RVA: 0x2AADE20 Offset: 0x2AADF21 VA: 0x2AADE20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.op_Implicit
	|
	|-RVA: 0x2AAE940 Offset: 0x2AAEA41 VA: 0x2AAE940
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.op_Implicit
	|
	|-RVA: 0x2AAF590 Offset: 0x2AAF691 VA: 0x2AAF590
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.op_Implicit
	|
	|-RVA: 0x2AB0220 Offset: 0x2AB0321 VA: 0x2AB0220
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.op_Implicit
	|
	|-RVA: 0x2AB0EE0 Offset: 0x2AB0FE1 VA: 0x2AB0EE0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.op_Implicit
	|
	|-RVA: 0x2AB1BA0 Offset: 0x2AB1CA1 VA: 0x2AB1BA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.op_Implicit
	|
	|-RVA: 0x2AB26B0 Offset: 0x2AB27B1 VA: 0x2AB26B0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.op_Implicit
	|
	|-RVA: 0x2AB3340 Offset: 0x2AB3441 VA: 0x2AB3340
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.op_Implicit
	|
	|-RVA: 0x2AB3DC0 Offset: 0x2AB3EC1 VA: 0x2AB3DC0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.op_Implicit
	|
	|-RVA: 0x2AB49A0 Offset: 0x2AB4AA1 VA: 0x2AB49A0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.op_Implicit
	|
	|-RVA: 0x2AB55C0 Offset: 0x2AB56C1 VA: 0x2AB55C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.op_Implicit
	|
	|-RVA: 0x2AB6280 Offset: 0x2AB6381 VA: 0x2AB6280
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.op_Implicit
	|
	|-RVA: 0x2AB6F10 Offset: 0x2AB7011 VA: 0x2AB6F10
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.op_Implicit
	|
	|-RVA: 0x2AB7BA0 Offset: 0x2AB7CA1 VA: 0x2AB7BA0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.op_Implicit
	|
	|-RVA: 0x2AB89C0 Offset: 0x2AB8AC1 VA: 0x2AB89C0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.op_Implicit
	|
	|-RVA: 0x2AB96F0 Offset: 0x2AB97F1 VA: 0x2AB96F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.op_Implicit
	|
	|-RVA: 0x2ABA600 Offset: 0x2ABA701 VA: 0x2ABA600
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.op_Implicit
	|
	|-RVA: 0x2ABB370 Offset: 0x2ABB471 VA: 0x2ABB370
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.op_Implicit
	|
	|-RVA: 0x2ABC350 Offset: 0x2ABC451 VA: 0x2ABC350
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.op_Implicit
	|
	|-RVA: 0x2ABD170 Offset: 0x2ABD271 VA: 0x2ABD170
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.op_Implicit
	|
	|-RVA: 0x2ABE260 Offset: 0x2ABE361 VA: 0x2ABE260
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.op_Implicit
	|
	|-RVA: 0x2ABF0D0 Offset: 0x2ABF1D1 VA: 0x2ABF0D0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.op_Implicit
	|
	|-RVA: 0x2AC0280 Offset: 0x2AC0381 VA: 0x2AC0280
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.op_Implicit
	|
	|-RVA: 0x2AC1190 Offset: 0x2AC1291 VA: 0x2AC1190
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.op_Implicit
	|
	|-RVA: 0x2AC1D90 Offset: 0x2AC1E91 VA: 0x2AC1D90
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.op_Implicit
	|
	|-RVA: 0x2CB9CD0 Offset: 0x2CB9DD1 VA: 0x2CB9CD0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.op_Implicit
	|
	|-RVA: 0x2CBA760 Offset: 0x2CBA861 VA: 0x2CBA760
	|-UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.op_Implicit
	|
	|-RVA: 0x2CBB1F0 Offset: 0x2CBB2F1 VA: 0x2CBB1F0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>.op_Implicit
	|
	|-RVA: 0x2CBBE50 Offset: 0x2CBBF51 VA: 0x2CBBE50
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>.op_Implicit
	|
	|-RVA: 0x2CBC8E0 Offset: 0x2CBC9E1 VA: 0x2CBC8E0
	|-UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>.op_Implicit
	|
	|-RVA: 0x2CBD510 Offset: 0x2CBD611 VA: 0x2CBD510
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>.op_Implicit
	|
	|-RVA: 0x2CBE110 Offset: 0x2CBE211 VA: 0x2CBE110
	|-UniTask<ValueTuple<bool, ValueTuple<bool, double>>>.op_Implicit
	|
	|-RVA: 0x2CBEC00 Offset: 0x2CBED01 VA: 0x2CBEC00
	|-UniTask<ValueTuple<bool, ValueTuple<bool, int>>>.op_Implicit
	|
	|-RVA: 0x2CBF800 Offset: 0x2CBF901 VA: 0x2CBF800
	|-UniTask<ValueTuple<bool, ValueTuple<bool, long>>>.op_Implicit
	|
	|-RVA: 0x2CC0420 Offset: 0x2CC0521 VA: 0x2CC0420
	|-UniTask<ValueTuple<bool, ValueTuple<bool, object>>>.op_Implicit
	|
	|-RVA: 0x2CC1050 Offset: 0x2CC1151 VA: 0x2CC1050
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.op_Implicit
	|
	|-RVA: 0x2CC1C80 Offset: 0x2CC1D81 VA: 0x2CC1C80
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>.op_Implicit
	|
	|-RVA: 0x2CC2770 Offset: 0x2CC2871 VA: 0x2CC2770
	|-UniTask<ValueTuple<bool, ValueTuple<bool, float>>>.op_Implicit
	|
	|-RVA: 0x2CC3390 Offset: 0x2CC3491 VA: 0x2CC3390
	|-UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>.op_Implicit
	|
	|-RVA: 0x2CC3E20 Offset: 0x2CC3F21 VA: 0x2CC3E20
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>.op_Implicit
	|
	|-RVA: 0x2CC4940 Offset: 0x2CC4A41 VA: 0x2CC4940
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>.op_Implicit
	|
	|-RVA: 0x2CC5530 Offset: 0x2CC5631 VA: 0x2CC5530
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>.op_Implicit
	|
	|-RVA: 0x2CC6160 Offset: 0x2CC6261 VA: 0x2CC6160
	|-UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>.op_Implicit
	|
	|-RVA: 0x2CC6D80 Offset: 0x2CC6E81 VA: 0x2CC6D80
	|-UniTask<ValueTuple<bool, ValueTuple<int, object>>>.op_Implicit
	|
	|-RVA: 0x2CC79B0 Offset: 0x2CC7AB1 VA: 0x2CC79B0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object>>>.op_Implicit
	|
	|-RVA: 0x2CC8720 Offset: 0x2CC8821 VA: 0x2CC8720
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.op_Implicit
	|
	|-RVA: 0x2CC93B0 Offset: 0x2CC94B1 VA: 0x2CC93B0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>.op_Implicit
	|
	|-RVA: 0x2CCA210 Offset: 0x2CCA311 VA: 0x2CCA210
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.op_Implicit
	|
	|-RVA: 0x2CCAF30 Offset: 0x2CCB031 VA: 0x2CCAF30
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>.op_Implicit
	|
	|-RVA: 0x2CCBE70 Offset: 0x2CCBF71 VA: 0x2CCBE70
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.op_Implicit
	|
	|-RVA: 0x2CCCBE0 Offset: 0x2CCCCE1 VA: 0x2CCCBE0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.op_Implicit
	|
	|-RVA: 0x2CCDC00 Offset: 0x2CCDD01 VA: 0x2CCDC00
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.op_Implicit
	|
	|-RVA: 0x2CCEA20 Offset: 0x2CCEB21 VA: 0x2CCEA20
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.op_Implicit
	|
	|-RVA: 0x2CCFB50 Offset: 0x2CCFC51 VA: 0x2CCFB50
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.op_Implicit
	|
	|-RVA: 0x2CD09B0 Offset: 0x2CD0AB1 VA: 0x2CD09B0
	|-UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.op_Implicit
	|
	|-RVA: 0x2CD1A90 Offset: 0x2CD1B91 VA: 0x2CD1A90
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.op_Implicit
	|
	|-RVA: 0x2CD28C0 Offset: 0x2CD29C1 VA: 0x2CD28C0
	|-UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.op_Implicit
	|
	|-RVA: 0x2CD3340 Offset: 0x2CD3441 VA: 0x2CD3340
	|-UniTask<ValueTuple<bool, AsyncUnit>>.op_Implicit
	|
	|-RVA: 0x2CD3DC0 Offset: 0x2CD3EC1 VA: 0x2CD3DC0
	|-UniTask<ValueTuple<bool, bool>>.op_Implicit
	|
	|-RVA: 0x2CD4A80 Offset: 0x2CD4B81 VA: 0x2CD4A80
	|-UniTask<ValueTuple<bool, Bounds>>.op_Implicit
	|
	|-RVA: 0x2CD5500 Offset: 0x2CD5601 VA: 0x2CD5500
	|-UniTask<ValueTuple<bool, byte>>.op_Implicit
	|
	|-RVA: 0x2CD60E0 Offset: 0x2CD61E1 VA: 0x2CD60E0
	|-UniTask<ValueTuple<bool, Color>>.op_Implicit
	|
	|-RVA: 0x2CD6BF0 Offset: 0x2CD6CF1 VA: 0x2CD6BF0
	|-UniTask<ValueTuple<bool, double>>.op_Implicit
	|
	|-RVA: 0x2CD7640 Offset: 0x2CD7741 VA: 0x2CD7640
	|-UniTask<ValueTuple<bool, int>>.op_Implicit
	|
	|-RVA: 0x2CD8150 Offset: 0x2CD8251 VA: 0x2CD8150
	|-UniTask<ValueTuple<bool, long>>.op_Implicit
	|
	|-RVA: 0x2CD8C90 Offset: 0x2CD8D91 VA: 0x2CD8C90
	|-UniTask<ValueTuple<bool, object>>.op_Implicit
	|
	|-RVA: 0x2CD9870 Offset: 0x2CD9971 VA: 0x2CD9870
	|-UniTask<ValueTuple<bool, Quaternion>>.op_Implicit
	|
	|-RVA: 0x2CDA450 Offset: 0x2CDA551 VA: 0x2CDA450
	|-UniTask<ValueTuple<bool, Rect>>.op_Implicit
	|
	|-RVA: 0x2CDAEA0 Offset: 0x2CDAFA1 VA: 0x2CDAEA0
	|-UniTask<ValueTuple<bool, float>>.op_Implicit
	|
	|-RVA: 0x2CDB9E0 Offset: 0x2CDBAE1 VA: 0x2CDB9E0
	|-UniTask<ValueTuple<bool, UniTask>>.op_Implicit
	|
	|-RVA: 0x2CDC460 Offset: 0x2CDC561 VA: 0x2CDC460
	|-UniTask<ValueTuple<bool, Unit>>.op_Implicit
	|
	|-RVA: 0x2CDCF40 Offset: 0x2CDD041 VA: 0x2CDCF40
	|-UniTask<ValueTuple<bool, Vector2>>.op_Implicit
	|
	|-RVA: 0x2CDDA50 Offset: 0x2CDDB51 VA: 0x2CDDA50
	|-UniTask<ValueTuple<bool, Vector3>>.op_Implicit
	|
	|-RVA: 0x2CDE630 Offset: 0x2CDE731 VA: 0x2CDE630
	|-UniTask<ValueTuple<bool, Vector4>>.op_Implicit
	|
	|-RVA: 0x2CDF170 Offset: 0x2CDF271 VA: 0x2CDF170
	|-UniTask<ValueTuple<int, object>>.op_Implicit
	|
	|-RVA: 0x2CDFCB0 Offset: 0x2CDFDB1 VA: 0x2CDFCB0
	|-UniTask<ValueTuple<object, object>>.op_Implicit
	|
	|-RVA: 0x2CE09E0 Offset: 0x2CE0AE1 VA: 0x2CE09E0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.op_Implicit
	|
	|-RVA: 0x2CE1600 Offset: 0x2CE1701 VA: 0x2CE1600
	|-UniTask<ValueTuple<object, object, object>>.op_Implicit
	|
	|-RVA: 0x2CE2420 Offset: 0x2CE2521 VA: 0x2CE2420
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.op_Implicit
	|
	|-RVA: 0x2DDE570 Offset: 0x2DDE671 VA: 0x2DDE570
	|-UniTask<ValueTuple<object, object, object, object>>.op_Implicit
	|
	|-RVA: 0x2DDF470 Offset: 0x2DDF571 VA: 0x2DDF470
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.op_Implicit
	|
	|-RVA: 0x2DE0190 Offset: 0x2DE0291 VA: 0x2DE0190
	|-UniTask<ValueTuple<object, object, object, object, object>>.op_Implicit
	|
	|-RVA: 0x2DE1160 Offset: 0x2DE1261 VA: 0x2DE1160
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.op_Implicit
	|
	|-RVA: 0x2DE1EC0 Offset: 0x2DE1FC1 VA: 0x2DE1EC0
	|-UniTask<ValueTuple<object, object, object, object, object, object>>.op_Implicit
	|
	|-RVA: 0x2DE2FA0 Offset: 0x2DE30A1 VA: 0x2DE2FA0
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.op_Implicit
	|
	|-RVA: 0x2DE3DB0 Offset: 0x2DE3EB1 VA: 0x2DE3DB0
	|-UniTask<ValueTuple<object, object, object, object, object, object, object>>.op_Implicit
	|
	|-RVA: 0x2DE4F60 Offset: 0x2DE5061 VA: 0x2DE4F60
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.op_Implicit
	|
	|-RVA: 0x2DE5D90 Offset: 0x2DE5E91 VA: 0x2DE5D90
	|-UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.op_Implicit
	|
	|-RVA: 0x2DE6750 Offset: 0x2DE6851 VA: 0x2DE6750
	|-UniTask<AsyncUnit>.op_Implicit
	|
	|-RVA: 0x2DEB800 Offset: 0x2DEB901 VA: 0x2DEB800
	|-UniTask<AxisEventData>.op_Implicit
	|-UniTask<BaseEventData>.op_Implicit
	|-UniTask<Collider>.op_Implicit
	|-UniTask<Collider2D>.op_Implicit
	|-UniTask<Collision>.op_Implicit
	|-UniTask<Collision2D>.op_Implicit
	|-UniTask<GameObject>.op_Implicit
	|-UniTask<Joint2D>.op_Implicit
	|-UniTask<object>.op_Implicit
	|-UniTask<PointerEventData>.op_Implicit
	|
	|-RVA: 0x2DE7110 Offset: 0x2DE7211 VA: 0x2DE7110
	|-UniTask<bool>.op_Implicit
	|
	|-RVA: 0x2DE7C80 Offset: 0x2DE7D81 VA: 0x2DE7C80
	|-UniTask<Bounds>.op_Implicit
	|
	|-RVA: 0x2DE8630 Offset: 0x2DE8731 VA: 0x2DE8630
	|-UniTask<byte>.op_Implicit
	|
	|-RVA: 0x2DE90F0 Offset: 0x2DE91F1 VA: 0x2DE90F0
	|-UniTask<Color>.op_Implicit
	|
	|-RVA: 0x2DE9AC0 Offset: 0x2DE9BC1 VA: 0x2DE9AC0
	|-UniTask<double>.op_Implicit
	|
	|-RVA: 0x2DEA470 Offset: 0x2DEA571 VA: 0x2DEA470
	|-UniTask<int>.op_Implicit
	|
	|-RVA: 0x2DEAE40 Offset: 0x2DEAF41 VA: 0x2DEAE40
	|-UniTask<long>.op_Implicit
	|
	|-RVA: 0x2DEC2C0 Offset: 0x2DEC3C1 VA: 0x2DEC2C0
	|-UniTask<Quaternion>.op_Implicit
	|
	|-RVA: 0x2DECD80 Offset: 0x2DECE81 VA: 0x2DECD80
	|-UniTask<Rect>.op_Implicit
	|
	|-RVA: 0x2DED740 Offset: 0x2DED841 VA: 0x2DED740
	|-UniTask<float>.op_Implicit
	|
	|-RVA: 0x2DEE140 Offset: 0x2DEE241 VA: 0x2DEE140
	|-UniTask<UniTask>.op_Implicit
	|
	|-RVA: 0x2DEEB00 Offset: 0x2DEEC01 VA: 0x2DEEB00
	|-UniTask<Unit>.op_Implicit
	|
	|-RVA: 0x2DEF510 Offset: 0x2DEF611 VA: 0x2DEF510
	|-UniTask<Vector2>.op_Implicit
	|
	|-RVA: 0x2DEFF60 Offset: 0x2DF0061 VA: 0x2DEFF60
	|-UniTask<Vector3>.op_Implicit
	|
	|-RVA: 0x2DF0A20 Offset: 0x2DF0B21 VA: 0x2DF0A20
	|-UniTask<Vector4>.op_Implicit
	*/
}

