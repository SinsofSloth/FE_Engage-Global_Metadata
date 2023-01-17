// Namespace: UniRx
public class ReactiveCommand : ReactiveCommand<Unit> // TypeDefIndex: 6746
{
	// Methods

	// RVA: 0x19ED550 Offset: 0x19ED651 VA: 0x19ED550
	public void .ctor() { }

	// RVA: 0x19ED5D0 Offset: 0x19ED6D1 VA: 0x19ED5D0
	public void .ctor(IObservable<bool> canExecuteSource, bool initialValue = True) { }

	// RVA: 0x19ED670 Offset: 0x19ED771 VA: 0x19ED670
	public bool Execute() { }

	// RVA: 0x19ED750 Offset: 0x19ED851 VA: 0x19ED750
	public void ForceExecute() { }
}

// Namespace: UniRx
public class ReactiveCommand<T> : IReactiveCommand<T>, IObservable<T>, IDisposable // TypeDefIndex: 6748
{
	// Fields
	private readonly Subject<T> trigger; // 0x0
	private readonly IDisposable canExecuteSubscription; // 0x0
	private ReactiveProperty<bool> canExecute; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x13CE0 Offset: 0x13DE1 VA: 0x13CE0
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
	|-RVA: 0x2A8F450 Offset: 0x2A8F551 VA: 0x2A8F450
	|-ReactiveCommand<object>.get_CanExecute
	|
	|-RVA: 0x2A90460 Offset: 0x2A90561 VA: 0x2A90460
	|-ReactiveCommand<Unit>.get_CanExecute
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17200 Offset: 0x17301 VA: 0x17200
	// RVA: -1 Offset: -1
	public bool get_IsDisposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8F460 Offset: 0x2A8F561 VA: 0x2A8F460
	|-ReactiveCommand<object>.get_IsDisposed
	|
	|-RVA: 0x2A90470 Offset: 0x2A90571 VA: 0x2A90470
	|-ReactiveCommand<Unit>.get_IsDisposed
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17210 Offset: 0x17311 VA: 0x17210
	// RVA: -1 Offset: -1
	private void set_IsDisposed(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8F470 Offset: 0x2A8F571 VA: 0x2A8F470
	|-ReactiveCommand<object>.set_IsDisposed
	|
	|-RVA: 0x2A90480 Offset: 0x2A90581 VA: 0x2A90480
	|-ReactiveCommand<Unit>.set_IsDisposed
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8F480 Offset: 0x2A8F581 VA: 0x2A8F480
	|-ReactiveCommand<object>..ctor
	|
	|-RVA: 0x2A90490 Offset: 0x2A90591 VA: 0x2A90490
	|-ReactiveCommand<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<bool> canExecuteSource, bool initialValue = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8F5B0 Offset: 0x2A8F6B1 VA: 0x2A8F5B0
	|-ReactiveCommand<object>..ctor
	|
	|-RVA: 0x2A905C0 Offset: 0x2A906C1 VA: 0x2A905C0
	|-ReactiveCommand<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool Execute(T parameter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8F8E0 Offset: 0x2A8F9E1 VA: 0x2A8F8E0
	|-ReactiveCommand<object>.Execute
	|
	|-RVA: 0x2A908F0 Offset: 0x2A909F1 VA: 0x2A908F0
	|-ReactiveCommand<Unit>.Execute
	*/

	// RVA: -1 Offset: -1
	public void ForceExecute(T parameter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8F9C0 Offset: 0x2A8FAC1 VA: 0x2A8F9C0
	|-ReactiveCommand<object>.ForceExecute
	|
	|-RVA: 0x2A909D0 Offset: 0x2A90AD1 VA: 0x2A909D0
	|-ReactiveCommand<Unit>.ForceExecute
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IDisposable Subscribe(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8F9E0 Offset: 0x2A8FAE1 VA: 0x2A8F9E0
	|-ReactiveCommand<object>.Subscribe
	|
	|-RVA: 0x2A909F0 Offset: 0x2A90AF1 VA: 0x2A909F0
	|-ReactiveCommand<Unit>.Subscribe
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8FA00 Offset: 0x2A8FB01 VA: 0x2A8FA00
	|-ReactiveCommand<object>.Dispose
	|
	|-RVA: 0x2A90A10 Offset: 0x2A90B11 VA: 0x2A90A10
	|-ReactiveCommand<Unit>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public UniTask<T> WaitUntilExecuteAsync(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8FD20 Offset: 0x2A8FE21 VA: 0x2A8FD20
	|-ReactiveCommand<object>.WaitUntilExecuteAsync
	|
	|-RVA: 0x2A90D30 Offset: 0x2A90E31 VA: 0x2A90D30
	|-ReactiveCommand<Unit>.WaitUntilExecuteAsync
	*/

	// RVA: -1 Offset: -1
	private static void CancelCallback(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A900B0 Offset: 0x2A901B1 VA: 0x2A900B0
	|-ReactiveCommand<object>.CancelCallback
	|
	|-RVA: 0x2A910C0 Offset: 0x2A911C1 VA: 0x2A910C0
	|-ReactiveCommand<Unit>.CancelCallback
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A90390 Offset: 0x2A90491 VA: 0x2A90390
	|-ReactiveCommand<object>..cctor
	|
	|-RVA: 0x2A913A0 Offset: 0x2A914A1 VA: 0x2A913A0
	|-ReactiveCommand<Unit>..cctor
	*/
}

