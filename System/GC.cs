// Namespace: System
public static class GC // TypeDefIndex: 224
{
	// Fields
	internal static readonly object EPHEMERON_TOMBSTONE; // 0x0

	// Properties
	public static int MaxGeneration { get; }

	// Methods

	// RVA: 0x38B67C0 Offset: 0x38B68C1 VA: 0x38B67C0
	private static int GetMaxGeneration() { }

	// RVA: 0x38B67D0 Offset: 0x38B68D1 VA: 0x38B67D0
	private static void InternalCollect(int generation) { }

	// RVA: 0x38B67E0 Offset: 0x38B68E1 VA: 0x38B67E0
	internal static void register_ephemeron_array(Ephemeron[] array) { }

	// RVA: 0x38B67F0 Offset: 0x38B68F1 VA: 0x38B67F0
	private static object get_ephemeron_tombstone() { }

	// RVA: 0x38B6800 Offset: 0x38B6901 VA: 0x38B6800
	public static void Collect() { }

	// RVA: 0x38B6930 Offset: 0x38B6A31 VA: 0x38B6930
	public static void Collect(int generation, GCCollectionMode mode) { }

	// RVA: 0x38B69F0 Offset: 0x38B6AF1 VA: 0x38B69F0
	public static void Collect(int generation, GCCollectionMode mode, bool blocking) { }

	// RVA: 0x38B6A80 Offset: 0x38B6B81 VA: 0x38B6A80
	public static void Collect(int generation, GCCollectionMode mode, bool blocking, bool compacting) { }

	[ReliabilityContractAttribute] // RVA: 0x47A740 Offset: 0x47A841 VA: 0x47A740
	// RVA: 0x38B6BA0 Offset: 0x38B6CA1 VA: 0x38B6BA0
	public static void KeepAlive(object obj) { }

	// RVA: 0x38B68C0 Offset: 0x38B69C1 VA: 0x38B68C0
	public static int get_MaxGeneration() { }

	// RVA: 0x38B6BB0 Offset: 0x38B6CB1 VA: 0x38B6BB0
	public static void WaitForPendingFinalizers() { }

	[ReliabilityContractAttribute] // RVA: 0x47A760 Offset: 0x47A861 VA: 0x47A760
	// RVA: 0x38B6BC0 Offset: 0x38B6CC1 VA: 0x38B6BC0
	private static void _SuppressFinalize(object o) { }

	[ReliabilityContractAttribute] // RVA: 0x47A780 Offset: 0x47A881 VA: 0x47A780
	// RVA: 0x38B32E0 Offset: 0x38B33E1 VA: 0x38B32E0
	public static void SuppressFinalize(object obj) { }

	// RVA: 0x38B6BD0 Offset: 0x38B6CD1 VA: 0x38B6BD0
	private static void _ReRegisterForFinalize(object o) { }

	// RVA: 0x38B6BE0 Offset: 0x38B6CE1 VA: 0x38B6BE0
	public static void ReRegisterForFinalize(object obj) { }

	// RVA: 0x38B6CA0 Offset: 0x38B6DA1 VA: 0x38B6CA0
	private static void .cctor() { }
}

