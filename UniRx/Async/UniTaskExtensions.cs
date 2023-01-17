// Namespace: UniRx.Async
[ExtensionAttribute] // RVA: 0x28020 Offset: 0x28121 VA: 0x28020
public static class UniTaskExtensions // TypeDefIndex: 5135
{
	// Methods

	[ExtensionAttribute] // RVA: 0x2CFF0 Offset: 0x2D0F1 VA: 0x2CFF0
	// RVA: 0x2E87D00 Offset: 0x2E87E01 VA: 0x2E87D00
	public static UniTask.Awaiter GetAwaiter(IEnumerable<UniTask> tasks) { }

	[ExtensionAttribute] // RVA: 0x2D000 Offset: 0x2D101 VA: 0x2D000
	// RVA: -1 Offset: -1
	public static UniTask.Awaiter<T[]> GetAwaiter<T>(IEnumerable<UniTask<T>> tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202C7C0 Offset: 0x202C8C1 VA: 0x202C7C0
	|-UniTaskExtensions.GetAwaiter<object>
	*/

	[ExtensionAttribute] // RVA: 0x2D010 Offset: 0x2D111 VA: 0x2D010
	// RVA: -1 Offset: -1
	public static UniTask.Awaiter<ValueTuple<T1, T2>> GetAwaiter<T1, T2>(ValueTuple<UniTask<T1>, UniTask<T2>> tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202C860 Offset: 0x202C961 VA: 0x202C860
	|-UniTaskExtensions.GetAwaiter<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x2D020 Offset: 0x2D121 VA: 0x2D020
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<T1, T2, T3>> WhenAll<T1, T2, T3>(ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>> tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202D180 Offset: 0x202D281 VA: 0x202D180
	|-UniTaskExtensions.WhenAll<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x2D030 Offset: 0x2D131 VA: 0x2D030
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>(ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>> tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202D260 Offset: 0x202D361 VA: 0x202D260
	|-UniTaskExtensions.WhenAll<object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x2D040 Offset: 0x2D141 VA: 0x2D040
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<T1, T2, T3, T4, T5>> WhenAll<T1, T2, T3, T4, T5>(ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>> tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202D360 Offset: 0x202D461 VA: 0x202D360
	|-UniTaskExtensions.WhenAll<object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x2D050 Offset: 0x2D151 VA: 0x2D050
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6>> WhenAll<T1, T2, T3, T4, T5, T6>(ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>> tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202D470 Offset: 0x202D571 VA: 0x202D470
	|-UniTaskExtensions.WhenAll<object, object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x2D060 Offset: 0x2D161 VA: 0x2D060
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>(ValueTuple<UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>, UniTask<T7>> tasks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202D590 Offset: 0x202D691 VA: 0x202D590
	|-UniTaskExtensions.WhenAll<object, object, object, object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x2D070 Offset: 0x2D171 VA: 0x2D070
	// RVA: 0x2E87E10 Offset: 0x2E87F11 VA: 0x2E87E10
	public static UniTask<AsyncUnit> AsAsyncUnitUniTask(UniTask task) { }

	[ExtensionAttribute] // RVA: 0x2D080 Offset: 0x2D181 VA: 0x2D080
	// RVA: -1 Offset: -1
	public static UniTask<T> AsUniTask<T>(Task<T> task, bool useCurrentSynchronizationContext = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202BAC0 Offset: 0x202BBC1 VA: 0x202BAC0
	|-UniTaskExtensions.AsUniTask<object>
	*/

	[ExtensionAttribute] // RVA: 0x2D090 Offset: 0x2D191 VA: 0x2D090
	// RVA: 0x2E87E80 Offset: 0x2E87F81 VA: 0x2E87E80
	public static UniTask AsUniTask(Task task, bool useCurrentSynchronizationContext = True) { }

	[ExtensionAttribute] // RVA: 0x2D0A0 Offset: 0x2D1A1 VA: 0x2D0A0
	// RVA: -1 Offset: -1
	public static IEnumerator ToCoroutine<T>(UniTask<T> task, Action<T> resultHandler, Action<Exception> exceptionHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202CF30 Offset: 0x202D031 VA: 0x202CF30
	|-UniTaskExtensions.ToCoroutine<object>
	*/

	[ExtensionAttribute] // RVA: 0x2D0B0 Offset: 0x2D1B1 VA: 0x2D0B0
	// RVA: 0x2E86680 Offset: 0x2E86781 VA: 0x2E86680
	public static IEnumerator ToCoroutine(UniTask task, Action<Exception> exceptionHandler) { }

	[ExtensionAttribute] // RVA: 0x2D0C0 Offset: 0x2D1C1 VA: 0x2D0C0
	// RVA: 0x2E88060 Offset: 0x2E88161 VA: 0x2E88060
	public static UniTask Timeout(UniTask task, TimeSpan timeout, bool ignoreTimeScale = True, PlayerLoopTiming timeoutCheckTiming = 4, CancellationTokenSource taskCancellationTokenSource) { }

	[AsyncStateMachineAttribute] // RVA: 0x2D0D0 Offset: 0x2D1D1 VA: 0x2D0D0
	[ExtensionAttribute] // RVA: 0x2D0D0 Offset: 0x2D1D1 VA: 0x2D0D0
	// RVA: -1 Offset: -1
	public static UniTask<T> Timeout<T>(UniTask<T> task, TimeSpan timeout, bool ignoreTimeScale = True, PlayerLoopTiming timeoutCheckTiming = 4, CancellationTokenSource taskCancellationTokenSource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202C950 Offset: 0x202CA51 VA: 0x202C950
	|-UniTaskExtensions.Timeout<AsyncUnit>
	|
	|-RVA: 0x202CAC0 Offset: 0x202CBC1 VA: 0x202CAC0
	|-UniTaskExtensions.Timeout<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2D150 Offset: 0x2D251 VA: 0x2D150
	[ExtensionAttribute] // RVA: 0x2D150 Offset: 0x2D251 VA: 0x2D150
	// RVA: 0x2E88150 Offset: 0x2E88251 VA: 0x2E88150
	public static UniTask<bool> TimeoutWithoutException(UniTask task, TimeSpan timeout, bool ignoreTimeScale = True, PlayerLoopTiming timeoutCheckTiming = 4, CancellationTokenSource taskCancellationTokenSource) { }

	[ExtensionAttribute] // RVA: 0x2D1D0 Offset: 0x2D2D1 VA: 0x2D1D0
	[AsyncStateMachineAttribute] // RVA: 0x2D1D0 Offset: 0x2D2D1 VA: 0x2D1D0
	// RVA: -1 Offset: -1
	public static UniTask<ValueTuple<bool, T>> TimeoutWithoutException<T>(UniTask<T> task, TimeSpan timeout, bool ignoreTimeScale = True, PlayerLoopTiming timeoutCheckTiming = 4, CancellationTokenSource taskCancellationTokenSource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202CC30 Offset: 0x202CD31 VA: 0x202CC30
	|-UniTaskExtensions.TimeoutWithoutException<AsyncUnit>
	|
	|-RVA: 0x202CDA0 Offset: 0x202CEA1 VA: 0x202CDA0
	|-UniTaskExtensions.TimeoutWithoutException<object>
	*/

	[ExtensionAttribute] // RVA: 0x2D250 Offset: 0x2D351 VA: 0x2D250
	// RVA: 0x2E86AB0 Offset: 0x2E86BB1 VA: 0x2E86AB0
	public static void Forget(UniTask task) { }

	[ExtensionAttribute] // RVA: 0x2D260 Offset: 0x2D361 VA: 0x2D260
	// RVA: 0x2E88390 Offset: 0x2E88491 VA: 0x2E88390
	public static void Forget(UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = True) { }

	[AsyncStateMachineAttribute] // RVA: 0x2D270 Offset: 0x2D371 VA: 0x2D270
	// RVA: 0x2E882E0 Offset: 0x2E883E1 VA: 0x2E882E0
	private static UniTaskVoid ForgetCore(UniTask task) { }

	[AsyncStateMachineAttribute] // RVA: 0x2D2E0 Offset: 0x2D3E1 VA: 0x2D2E0
	// RVA: 0x2E884F0 Offset: 0x2E885F1 VA: 0x2E884F0
	private static UniTaskVoid ForgetCoreWithCatch(UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread) { }

	[ExtensionAttribute] // RVA: 0x2D350 Offset: 0x2D451 VA: 0x2D350
	// RVA: -1 Offset: -1
	public static void Forget<T>(UniTask<T> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202C5A0 Offset: 0x202C6A1 VA: 0x202C5A0
	|-UniTaskExtensions.Forget<object>
	*/

	[ExtensionAttribute] // RVA: 0x2D360 Offset: 0x2D461 VA: 0x2D360
	// RVA: -1 Offset: -1
	public static void Forget<T>(UniTask<T> task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202C5E0 Offset: 0x202C6E1 VA: 0x202C5E0
	|-UniTaskExtensions.Forget<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2D370 Offset: 0x2D471 VA: 0x2D370
	// RVA: -1 Offset: -1
	private static UniTaskVoid ForgetCore<T>(UniTask<T> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202C640 Offset: 0x202C741 VA: 0x202C640
	|-UniTaskExtensions.ForgetCore<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2D3E0 Offset: 0x2D4E1 VA: 0x2D3E0
	// RVA: -1 Offset: -1
	private static UniTaskVoid ForgetCoreWithCatch<T>(UniTask<T> task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202C6E0 Offset: 0x202C7E1 VA: 0x202C6E0
	|-UniTaskExtensions.ForgetCoreWithCatch<object>
	*/

	[ExtensionAttribute] // RVA: 0x2D450 Offset: 0x2D551 VA: 0x2D450
	[AsyncStateMachineAttribute] // RVA: 0x2D450 Offset: 0x2D551 VA: 0x2D450
	// RVA: -1 Offset: -1
	public static UniTask ContinueWith<T>(UniTask<T> task, Action<T> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202C1C0 Offset: 0x202C2C1 VA: 0x202C1C0
	|-UniTaskExtensions.ContinueWith<object>
	*/

	[ExtensionAttribute] // RVA: 0x2D4D0 Offset: 0x2D5D1 VA: 0x2D4D0
	[AsyncStateMachineAttribute] // RVA: 0x2D4D0 Offset: 0x2D5D1 VA: 0x2D4D0
	// RVA: -1 Offset: -1
	public static UniTask ContinueWith<T>(UniTask<T> task, Func<T, UniTask> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202C280 Offset: 0x202C381 VA: 0x202C280
	|-UniTaskExtensions.ContinueWith<object>
	*/

	[ExtensionAttribute] // RVA: 0x2D550 Offset: 0x2D651 VA: 0x2D550
	[AsyncStateMachineAttribute] // RVA: 0x2D550 Offset: 0x2D651 VA: 0x2D550
	// RVA: -1 Offset: -1
	public static UniTask<TR> ContinueWith<T, TR>(UniTask<T> task, Func<T, TR> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202C340 Offset: 0x202C441 VA: 0x202C340
	|-UniTaskExtensions.ContinueWith<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x2D5D0 Offset: 0x2D6D1 VA: 0x2D5D0
	[AsyncStateMachineAttribute] // RVA: 0x2D5D0 Offset: 0x2D6D1 VA: 0x2D5D0
	// RVA: -1 Offset: -1
	public static UniTask<TR> ContinueWith<T, TR>(UniTask<T> task, Func<T, UniTask<TR>> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202C460 Offset: 0x202C561 VA: 0x202C460
	|-UniTaskExtensions.ContinueWith<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x2D650 Offset: 0x2D751 VA: 0x2D650
	[AsyncStateMachineAttribute] // RVA: 0x2D650 Offset: 0x2D751 VA: 0x2D650
	// RVA: 0x2E885D0 Offset: 0x2E886D1 VA: 0x2E885D0
	public static UniTask ContinueWith(UniTask task, Action continuationFunction) { }

	[ExtensionAttribute] // RVA: 0x2D6D0 Offset: 0x2D7D1 VA: 0x2D6D0
	[AsyncStateMachineAttribute] // RVA: 0x2D6D0 Offset: 0x2D7D1 VA: 0x2D6D0
	// RVA: 0x2E886A0 Offset: 0x2E887A1 VA: 0x2E886A0
	public static UniTask ContinueWith(UniTask task, Func<UniTask> continuationFunction) { }

	[AsyncStateMachineAttribute] // RVA: 0x2D750 Offset: 0x2D851 VA: 0x2D750
	[ExtensionAttribute] // RVA: 0x2D750 Offset: 0x2D851 VA: 0x2D750
	// RVA: -1 Offset: -1
	public static UniTask<T> ContinueWith<T>(UniTask task, Func<T> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202BFA0 Offset: 0x202C0A1 VA: 0x202BFA0
	|-UniTaskExtensions.ContinueWith<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2D7D0 Offset: 0x2D8D1 VA: 0x2D7D0
	[ExtensionAttribute] // RVA: 0x2D7D0 Offset: 0x2D8D1 VA: 0x2D7D0
	// RVA: -1 Offset: -1
	public static UniTask<T> ContinueWith<T>(UniTask task, Func<UniTask<T>> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202C0B0 Offset: 0x202C1B1 VA: 0x202C0B0
	|-UniTaskExtensions.ContinueWith<object>
	*/

	[ExtensionAttribute] // RVA: 0x2D850 Offset: 0x2D951 VA: 0x2D850
	[AsyncStateMachineAttribute] // RVA: 0x2D850 Offset: 0x2D951 VA: 0x2D850
	// RVA: 0x2E88770 Offset: 0x2E88871 VA: 0x2E88770
	public static UniTask ConfigureAwait(Task task, PlayerLoopTiming timing) { }

	[AsyncStateMachineAttribute] // RVA: 0x2D8D0 Offset: 0x2D9D1 VA: 0x2D8D0
	[ExtensionAttribute] // RVA: 0x2D8D0 Offset: 0x2D9D1 VA: 0x2D8D0
	// RVA: -1 Offset: -1
	public static UniTask<T> ConfigureAwait<T>(Task<T> task, PlayerLoopTiming timing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202BD70 Offset: 0x202BE71 VA: 0x202BD70
	|-UniTaskExtensions.ConfigureAwait<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2D950 Offset: 0x2DA51 VA: 0x2D950
	[ExtensionAttribute] // RVA: 0x2D950 Offset: 0x2DA51 VA: 0x2D950
	// RVA: 0x2E88830 Offset: 0x2E88931 VA: 0x2E88830
	public static UniTask ConfigureAwait(UniTask task, PlayerLoopTiming timing) { }

	[AsyncStateMachineAttribute] // RVA: 0x2D9D0 Offset: 0x2DAD1 VA: 0x2D9D0
	[ExtensionAttribute] // RVA: 0x2D9D0 Offset: 0x2DAD1 VA: 0x2D9D0
	// RVA: -1 Offset: -1
	public static UniTask<T> ConfigureAwait<T>(UniTask<T> task, PlayerLoopTiming timing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202BE80 Offset: 0x202BF81 VA: 0x202BE80
	|-UniTaskExtensions.ConfigureAwait<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2DA50 Offset: 0x2DB51 VA: 0x2DA50
	[ExtensionAttribute] // RVA: 0x2DA50 Offset: 0x2DB51 VA: 0x2DA50
	// RVA: -1 Offset: -1
	public static UniTask<T> Unwrap<T>(UniTask<UniTask<T>> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202CFC0 Offset: 0x202D0C1 VA: 0x202CFC0
	|-UniTaskExtensions.Unwrap<object>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x2DAD0 Offset: 0x2DBD1 VA: 0x2DAD0
	[ExtensionAttribute] // RVA: 0x2DAD0 Offset: 0x2DBD1 VA: 0x2DAD0
	// RVA: -1 Offset: -1
	public static UniTask Unwrap<T>(UniTask<UniTask> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x202D0E0 Offset: 0x202D1E1 VA: 0x202D0E0
	|-UniTaskExtensions.Unwrap<object>
	*/
}

