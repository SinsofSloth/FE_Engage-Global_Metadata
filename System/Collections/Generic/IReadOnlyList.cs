// Namespace: System.Collections.Generic
[DefaultMemberAttribute] // RVA: 0x4778B0 Offset: 0x4779B1 VA: 0x4778B0
[TypeDependencyAttribute] // RVA: 0x4778B0 Offset: 0x4779B1 VA: 0x4778B0
public interface IReadOnlyList<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 1438
{
	// Properties
	public abstract T Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyList<object>.get_Item
	*/
}

