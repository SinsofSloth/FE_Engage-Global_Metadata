// Namespace: System.Collections.Generic
[DefaultMemberAttribute] // RVA: 0x4777D0 Offset: 0x4778D1 VA: 0x4777D0
[TypeDependencyAttribute] // RVA: 0x4777D0 Offset: 0x4778D1 VA: 0x4777D0
public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 1435
{
	// Properties
	public abstract T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(int index, T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int IndexOf(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Insert(int index, T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RemoveAt(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<object>.RemoveAt
	*/
}

