// Namespace: UniRx
[DefaultMemberAttribute] // RVA: 0x13380 Offset: 0x13481 VA: 0x13380
public interface IReactiveCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyReactiveCollection<T> // TypeDefIndex: 6741
{
	// Properties
	public abstract int Count { get; }
	public abstract T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReactiveCollection<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReactiveCollection<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_Item(int index, T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReactiveCollection<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Move(int oldIndex, int newIndex);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReactiveCollection<object>.Move
	*/
}

