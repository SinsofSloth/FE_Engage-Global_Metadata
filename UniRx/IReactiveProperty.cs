// Namespace: UniRx
public interface IReactiveProperty<T> : IReadOnlyReactiveProperty<T>, IObservable<T> // TypeDefIndex: 6765
{
	// Properties
	public abstract T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Value();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReactiveProperty<object>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Value(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReactiveProperty<object>.set_Value
	*/
}

