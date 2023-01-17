// Namespace: 
private class UniTaskObservableExtensions.ToUniTaskObserver<T> : IObserver<T> // TypeDefIndex: 6656
{
	// Fields
	private static readonly Action<object> callback; // 0x0
	private readonly UniTaskCompletionSource<T> promise; // 0x0
	private readonly SingleAssignmentDisposable disposable; // 0x0
	private readonly CancellationToken cancellationToken; // 0x0
	private readonly CancellationTokenRegistration registration; // 0x0
	private bool hasValue; // 0x0
	private T latestValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UniTaskCompletionSource<T> promise, SingleAssignmentDisposable disposable, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356FBC0 Offset: 0x356FCC1 VA: 0x356FBC0
	|-UniTaskObservableExtensions.ToUniTaskObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void OnCanceled(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356FD70 Offset: 0x356FE71 VA: 0x356FD70
	|-UniTaskObservableExtensions.ToUniTaskObserver<object>.OnCanceled
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356FE70 Offset: 0x356FF71 VA: 0x356FE70
	|-UniTaskObservableExtensions.ToUniTaskObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356FE80 Offset: 0x356FF81 VA: 0x356FE80
	|-UniTaskObservableExtensions.ToUniTaskObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x356FF60 Offset: 0x3570061 VA: 0x356FF60
	|-UniTaskObservableExtensions.ToUniTaskObserver<object>.OnCompleted
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35700D0 Offset: 0x35701D1 VA: 0x35700D0
	|-UniTaskObservableExtensions.ToUniTaskObserver<object>..cctor
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x12F80 Offset: 0x13081 VA: 0x12F80
private struct UniTaskObservableExtensions.<Fire>d__3<T> : IAsyncStateMachine // TypeDefIndex: 6658
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncUniTaskVoidMethodBuilder <>t__builder; // 0x0
	public UniTask<T> task; // 0x0
	public AsyncSubject<T> subject; // 0x0
	private UniTask.Awaiter<T> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x314EE40 Offset: 0x314EF41 VA: 0x314EE40
	|-UniTaskObservableExtensions.<Fire>d__3<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x162A0 Offset: 0x163A1 VA: 0x162A0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x314F1C0 Offset: 0x314F2C1 VA: 0x314F1C0
	|-UniTaskObservableExtensions.<Fire>d__3<object>.SetStateMachine
	*/
}

