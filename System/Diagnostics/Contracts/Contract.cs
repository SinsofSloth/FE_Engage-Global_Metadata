// Namespace: System.Diagnostics.Contracts
public static class Contract // TypeDefIndex: 1456
{
	// Methods

	[ReliabilityContractAttribute] // RVA: 0x47D9F0 Offset: 0x47DAF1 VA: 0x47D9F0
	// RVA: -1 Offset: -1
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229BDD0 Offset: 0x229BED1 VA: 0x229BDD0
	|-Contract.ForAll<object>
	|-Contract.ForAll<Type>
	*/
}

