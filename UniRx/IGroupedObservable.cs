// Namespace: UniRx
public interface IGroupedObservable<TKey, TElement> : IObservable<TElement> // TypeDefIndex: 6648
{
	// Properties
	public abstract TKey Key { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TKey get_Key();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGroupedObservable<object, object>.get_Key
	*/
}

