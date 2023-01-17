// Namespace: System.Threading
public static class LazyInitializer // TypeDefIndex: 740
{
	// Methods

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295B080 Offset: 0x295B181 VA: 0x295B080
	|-LazyInitializer.EnsureInitialized<ManualResetEvent>
	|-LazyInitializer.EnsureInitialized<object>
	|-LazyInitializer.EnsureInitialized<SemaphoreSlim>
	|-LazyInitializer.EnsureInitialized<Task.ContingentProperties>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295B0E0 Offset: 0x295B1E1 VA: 0x295B0E0
	|-LazyInitializer.EnsureInitializedCore<object>
	*/
}

