// Namespace: System.Collections.Generic
[TypeDependencyAttribute] // RVA: 0x477830 Offset: 0x477931 VA: 0x477830
public interface IReadOnlyCollection<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 1436
{
	// Properties
	public abstract int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyCollection<object>.get_Count
	*/
}

