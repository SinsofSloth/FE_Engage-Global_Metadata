// Namespace: UniRx
public class AsyncReactiveCommand<T> : IAsyncReactiveCommand<T> // TypeDefIndex: 6752
{
	// Fields
	private ImmutableList<Func<T, IObservable<Unit>>> asyncActions; // 0x0
	private readonly object gate; // 0x0
	private readonly IReactiveProperty<bool> canExecuteSource; // 0x0
	private readonly IReadOnlyReactiveProperty<bool> canExecute; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x13CF0 Offset: 0x13DF1 VA: 0x13CF0
	private bool <IsDisposed>k__BackingField; // 0x0
	private static readonly Action<object> Callback; // 0x0
	private ReactivePropertyReusablePromise<T> commonPromise; // 0x0
	private Dictionary<CancellationToken, ReactivePropertyReusablePromise<T>> removablePromises; // 0x0

	// Properties
	public IReadOnlyReactiveProperty<bool> CanExecute { get; }
	public bool IsDisposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public IReadOnlyReactiveProperty<bool> get_CanExecute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E3920 Offset: 0x32E3A21 VA: 0x32E3920
	|-AsyncReactiveCommand<object>.get_CanExecute
	|
	|-RVA: 0x32E53E0 Offset: 0x32E54E1 VA: 0x32E53E0
	|-AsyncReactiveCommand<Unit>.get_CanExecute
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17220 Offset: 0x17321 VA: 0x17220
	// RVA: -1 Offset: -1
	public bool get_IsDisposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E3930 Offset: 0x32E3A31 VA: 0x32E3930
	|-AsyncReactiveCommand<object>.get_IsDisposed
	|
	|-RVA: 0x32E53F0 Offset: 0x32E54F1 VA: 0x32E53F0
	|-AsyncReactiveCommand<Unit>.get_IsDisposed
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17230 Offset: 0x17331 VA: 0x17230
	// RVA: -1 Offset: -1
	private void set_IsDisposed(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E3940 Offset: 0x32E3A41 VA: 0x32E3940
	|-AsyncReactiveCommand<object>.set_IsDisposed
	|
	|-RVA: 0x32E5400 Offset: 0x32E5501 VA: 0x32E5400
	|-AsyncReactiveCommand<Unit>.set_IsDisposed
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E3950 Offset: 0x32E3A51 VA: 0x32E3950
	|-AsyncReactiveCommand<object>..ctor
	|
	|-RVA: 0x32E5410 Offset: 0x32E5511 VA: 0x32E5410
	|-AsyncReactiveCommand<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<bool> canExecuteSource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E3AE0 Offset: 0x32E3BE1 VA: 0x32E3AE0
	|-AsyncReactiveCommand<object>..ctor
	|
	|-RVA: 0x32E55A0 Offset: 0x32E56A1 VA: 0x32E55A0
	|-AsyncReactiveCommand<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IReactiveProperty<bool> sharedCanExecute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E3E80 Offset: 0x32E3F81 VA: 0x32E3E80
	|-AsyncReactiveCommand<object>..ctor
	|
	|-RVA: 0x32E5940 Offset: 0x32E5A41 VA: 0x32E5940
	|-AsyncReactiveCommand<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IDisposable Execute(T parameter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E3FC0 Offset: 0x32E40C1 VA: 0x32E3FC0
	|-AsyncReactiveCommand<object>.Execute
	|
	|-RVA: 0x32E5A80 Offset: 0x32E5B81 VA: 0x32E5A80
	|-AsyncReactiveCommand<Unit>.Execute
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public IDisposable Subscribe(Func<T, IObservable<Unit>> asyncAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E46E0 Offset: 0x32E47E1 VA: 0x32E46E0
	|-AsyncReactiveCommand<object>.Subscribe
	|
	|-RVA: 0x32E61A0 Offset: 0x32E62A1 VA: 0x32E61A0
	|-AsyncReactiveCommand<Unit>.Subscribe
	*/

	// RVA: -1 Offset: -1
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E4830 Offset: 0x32E4931 VA: 0x32E4830
	|-AsyncReactiveCommand<object>.Dispose
	|
	|-RVA: 0x32E62F0 Offset: 0x32E63F1 VA: 0x32E62F0
	|-AsyncReactiveCommand<Unit>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public UniTask<T> WaitUntilExecuteAsync(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E4B40 Offset: 0x32E4C41 VA: 0x32E4B40
	|-AsyncReactiveCommand<object>.WaitUntilExecuteAsync
	|
	|-RVA: 0x32E6600 Offset: 0x32E6701 VA: 0x32E6600
	|-AsyncReactiveCommand<Unit>.WaitUntilExecuteAsync
	*/

	// RVA: -1 Offset: -1
	private static void CancelCallback(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E4ED0 Offset: 0x32E4FD1 VA: 0x32E4ED0
	|-AsyncReactiveCommand<object>.CancelCallback
	|
	|-RVA: 0x32E6990 Offset: 0x32E6A91 VA: 0x32E6990
	|-AsyncReactiveCommand<Unit>.CancelCallback
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E51B0 Offset: 0x32E52B1 VA: 0x32E51B0
	|-AsyncReactiveCommand<object>..cctor
	|
	|-RVA: 0x32E6C70 Offset: 0x32E6D71 VA: 0x32E6C70
	|-AsyncReactiveCommand<Unit>..cctor
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17240 Offset: 0x17341 VA: 0x17240
	// RVA: -1 Offset: -1
	private void <Execute>b__13_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E5280 Offset: 0x32E5381 VA: 0x32E5280
	|-AsyncReactiveCommand<object>.<Execute>b__13_0
	|
	|-RVA: 0x32E6D40 Offset: 0x32E6E41 VA: 0x32E6D40
	|-AsyncReactiveCommand<Unit>.<Execute>b__13_0
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17250 Offset: 0x17351 VA: 0x17250
	// RVA: -1 Offset: -1
	private void <Execute>b__13_1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32E5330 Offset: 0x32E5431 VA: 0x32E5330
	|-AsyncReactiveCommand<object>.<Execute>b__13_1
	|
	|-RVA: 0x32E6DF0 Offset: 0x32E6EF1 VA: 0x32E6DF0
	|-AsyncReactiveCommand<Unit>.<Execute>b__13_1
	*/
}

