// Namespace: UniRx.Async.Internal
internal static class Error // TypeDefIndex: 5210
{
	// Methods

	// RVA: -1 Offset: -1
	public static void ThrowArgumentNullException<T>(T value, string paramName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B21E0 Offset: 0x22B22E1 VA: 0x22B21E0
	|-Error.ThrowArgumentNullException<AsyncOperation>
	|-Error.ThrowArgumentNullException<object>
	|-Error.ThrowArgumentNullException<ResourceRequest>
	|-Error.ThrowArgumentNullException<SynchronizationContext>
	|-Error.ThrowArgumentNullException<UnityWebRequestAsyncOperation>
	|-Error.ThrowArgumentNullException<WWW>
	*/

	// RVA: 0x2E824C0 Offset: 0x2E825C1 VA: 0x2E824C0
	private static void ThrowArgumentNullExceptionCore(string paramName) { }

	// RVA: -1 Offset: -1
	public static void ThrowArgumentException<T>(string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B2190 Offset: 0x22B2291 VA: 0x22B2190
	|-Error.ThrowArgumentException<object>
	*/

	// RVA: 0x2E82510 Offset: 0x2E82611 VA: 0x2E82510
	public static void ThrowNotYetCompleted() { }

	// RVA: -1 Offset: -1
	public static T ThrowNotYetCompleted<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B2200 Offset: 0x22B2301 VA: 0x22B2200
	|-Error.ThrowNotYetCompleted<object>
	|-Error.ThrowNotYetCompleted<Object>
	|-Error.ThrowNotYetCompleted<UnityWebRequest>
	*/

	// RVA: -1 Offset: -1
	public static void ThrowWhenContinuationIsAlreadyRegistered<T>(T continuationField) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B2260 Offset: 0x22B2361 VA: 0x22B2260
	|-Error.ThrowWhenContinuationIsAlreadyRegistered<Action<AsyncOperation>>
	|-Error.ThrowWhenContinuationIsAlreadyRegistered<Action>
	|-Error.ThrowWhenContinuationIsAlreadyRegistered<object>
	*/

	// RVA: 0x2E82570 Offset: 0x2E82671 VA: 0x2E82570
	private static void ThrowInvalidOperationExceptionCore(string message) { }

	// RVA: 0x2E825C0 Offset: 0x2E826C1 VA: 0x2E825C0
	public static void ThrowOperationCanceledException() { }
}

