// Namespace: UniRx
public interface IReactiveCommand<T> : IObservable<T> // TypeDefIndex: 6744
{
	// Properties
	public abstract IReadOnlyReactiveProperty<bool> CanExecute { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IReadOnlyReactiveProperty<bool> get_CanExecute();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReactiveCommand<object>.get_CanExecute
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool Execute(T parameter);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReactiveCommand<object>.Execute
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract UniTask<T> WaitUntilExecuteAsync(CancellationToken cancellationToken);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReactiveCommand<object>.WaitUntilExecuteAsync
	*/
}

