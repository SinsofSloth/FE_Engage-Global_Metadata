// Namespace: UniRx
[DefaultMemberAttribute] // RVA: 0x13340 Offset: 0x13441 VA: 0x13340
public interface IReadOnlyReactiveCollection<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 6740
{
	// Properties
	public abstract int Count { get; }
	public abstract T Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveCollection<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveCollection<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IObservable<CollectionAddEvent<T>> ObserveAdd();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveCollection<object>.ObserveAdd
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IObservable<int> ObserveCountChanged(bool notifyCurrentCount = False);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveCollection<object>.ObserveCountChanged
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IObservable<CollectionMoveEvent<T>> ObserveMove();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveCollection<object>.ObserveMove
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IObservable<CollectionRemoveEvent<T>> ObserveRemove();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveCollection<object>.ObserveRemove
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IObservable<CollectionReplaceEvent<T>> ObserveReplace();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveCollection<object>.ObserveReplace
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IObservable<Unit> ObserveReset();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyReactiveCollection<object>.ObserveReset
	*/
}

