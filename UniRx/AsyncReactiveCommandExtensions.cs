// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x13410 Offset: 0x13511 VA: 0x13410
public static class AsyncReactiveCommandExtensions // TypeDefIndex: 6756
{
	// Methods

	[ExtensionAttribute] // RVA: 0x172C0 Offset: 0x173C1 VA: 0x172C0
	// RVA: 0x19CD110 Offset: 0x19CD211 VA: 0x19CD110
	public static AsyncReactiveCommand ToAsyncReactiveCommand(IReactiveProperty<bool> sharedCanExecuteSource) { }

	[ExtensionAttribute] // RVA: 0x172D0 Offset: 0x173D1 VA: 0x172D0
	// RVA: -1 Offset: -1
	public static AsyncReactiveCommand<T> ToAsyncReactiveCommand<T>(IReactiveProperty<bool> sharedCanExecuteSource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2735B90 Offset: 0x2735C91 VA: 0x2735B90
	|-AsyncReactiveCommandExtensions.ToAsyncReactiveCommand<object>
	*/

	[ExtensionAttribute] // RVA: 0x172E0 Offset: 0x173E1 VA: 0x172E0
	// RVA: -1 Offset: -1
	public static UniTask.Awaiter<T> GetAwaiter<T>(IAsyncReactiveCommand<T> command) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2735A80 Offset: 0x2735B81 VA: 0x2735A80
	|-AsyncReactiveCommandExtensions.GetAwaiter<object>
	*/

	[ExtensionAttribute] // RVA: 0x172F0 Offset: 0x173F1 VA: 0x172F0
	// RVA: 0x19CD1D0 Offset: 0x19CD2D1 VA: 0x19CD1D0
	public static IDisposable BindTo(IAsyncReactiveCommand<Unit> command, Button button) { }

	[ExtensionAttribute] // RVA: 0x17300 Offset: 0x17401 VA: 0x17300
	// RVA: 0x19CD3B0 Offset: 0x19CD4B1 VA: 0x19CD3B0
	public static IDisposable BindToOnClick(IAsyncReactiveCommand<Unit> command, Button button, Func<Unit, IObservable<Unit>> asyncOnClick) { }

	[ExtensionAttribute] // RVA: 0x17310 Offset: 0x17411 VA: 0x17310
	// RVA: 0x19CD600 Offset: 0x19CD701 VA: 0x19CD600
	public static IDisposable BindToOnClick(Button button, Func<Unit, IObservable<Unit>> asyncOnClick) { }

	[ExtensionAttribute] // RVA: 0x17320 Offset: 0x17421 VA: 0x17320
	// RVA: 0x19CD6D0 Offset: 0x19CD7D1 VA: 0x19CD6D0
	public static IDisposable BindToOnClick(Button button, IReactiveProperty<bool> sharedCanExecuteSource, Func<Unit, IObservable<Unit>> asyncOnClick) { }
}

