// Namespace: UniRx
public interface IReadOnlyReactiveProperty<T> : IObservable<T> // TypeDefIndex: 6764
{
	// Properties
	public abstract T Value { get; }
	public abstract bool HasValue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Value();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveProperty<object>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_HasValue();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveProperty<object>.get_HasValue
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract UniTask<T> WaitUntilValueChangedAsync(CancellationToken cancellationToken);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveProperty<object>.WaitUntilValueChangedAsync
	*/
}

