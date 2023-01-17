// Namespace: UniRx
public interface IAsyncReactiveCommand<T> // TypeDefIndex: 6745
{
	// Properties
	public abstract IReadOnlyReactiveProperty<bool> CanExecute { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IReadOnlyReactiveProperty<bool> get_CanExecute();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncReactiveCommand<object>.get_CanExecute
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDisposable Execute(T parameter);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncReactiveCommand<object>.Execute
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IDisposable Subscribe(Func<T, IObservable<Unit>> asyncAction);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncReactiveCommand<object>.Subscribe
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract UniTask<T> WaitUntilExecuteAsync(CancellationToken cancellationToken);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAsyncReactiveCommand<object>.WaitUntilExecuteAsync
	*/
}

