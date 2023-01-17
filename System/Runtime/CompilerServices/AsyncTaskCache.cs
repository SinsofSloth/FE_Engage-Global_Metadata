// Namespace: System.Runtime.CompilerServices
internal static class AsyncTaskCache // TypeDefIndex: 1238
{
	// Fields
	internal static readonly Task<bool> TrueTask; // 0x0
	internal static readonly Task<bool> FalseTask; // 0x8
	internal static readonly Task<int>[] Int32Tasks; // 0x10

	// Methods

	// RVA: 0x356ACF0 Offset: 0x356ADF1 VA: 0x356ACF0
	private static Task<int>[] CreateInt32Tasks() { }

	// RVA: -1 Offset: -1
	internal static Task<TResult> CreateCacheableTask<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2735C00 Offset: 0x2735D01 VA: 0x2735C00
	|-AsyncTaskCache.CreateCacheableTask<Nullable<int>>
	|
	|-RVA: 0x2735C70 Offset: 0x2735D71 VA: 0x2735C70
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<bool, object>>
	|
	|-RVA: 0x2735CF0 Offset: 0x2735DF1 VA: 0x2735CF0
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<int, int>>
	|
	|-RVA: 0x2735D60 Offset: 0x2735E61 VA: 0x2735D60
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<object, object, int>>
	|
	|-RVA: 0x2735DF0 Offset: 0x2735EF1 VA: 0x2735DF0
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<object, bool, bool, object, object>>
	|
	|-RVA: 0x2735E80 Offset: 0x2735F81 VA: 0x2735E80
	|-AsyncTaskCache.CreateCacheableTask<bool>
	|
	|-RVA: 0x2735EF0 Offset: 0x2735FF1 VA: 0x2735EF0
	|-AsyncTaskCache.CreateCacheableTask<int>
	|
	|-RVA: 0x2735F60 Offset: 0x2736061 VA: 0x2735F60
	|-AsyncTaskCache.CreateCacheableTask<object>
	|
	|-RVA: 0x2735FD0 Offset: 0x27360D1 VA: 0x2735FD0
	|-AsyncTaskCache.CreateCacheableTask<VoidTaskResult>
	*/

	// RVA: 0x356AE30 Offset: 0x356AF31 VA: 0x356AE30
	private static void .cctor() { }
}

