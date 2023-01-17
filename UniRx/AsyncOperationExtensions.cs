// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x12FA0 Offset: 0x130A1 VA: 0x12FA0
public static class AsyncOperationExtensions // TypeDefIndex: 6667
{
	// Methods

	[ExtensionAttribute] // RVA: 0x162C0 Offset: 0x163C1 VA: 0x162C0
	// RVA: 0x19CCD50 Offset: 0x19CCE51 VA: 0x19CCD50
	public static IObservable<AsyncOperation> AsObservable(AsyncOperation asyncOperation, IProgress<float> progress) { }

	[ExtensionAttribute] // RVA: 0x162D0 Offset: 0x163D1 VA: 0x162D0
	// RVA: -1 Offset: -1
	public static IObservable<T> AsAsyncOperationObservable<T>(T asyncOperation, IProgress<float> progress) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27357C0 Offset: 0x27358C1 VA: 0x27357C0
	|-AsyncOperationExtensions.AsAsyncOperationObservable<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x162E0 Offset: 0x163E1 VA: 0x162E0
	// RVA: -1 Offset: -1
	private static IEnumerator AsObservableCore<T>(T asyncOperation, IObserver<T> observer, IProgress<float> reportProgress, CancellationToken cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27358E0 Offset: 0x27359E1 VA: 0x27358E0
	|-AsyncOperationExtensions.AsObservableCore<AsyncOperation>
	|-AsyncOperationExtensions.AsObservableCore<object>
	*/
}

