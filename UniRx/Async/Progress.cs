// Namespace: UniRx.Async
public static class Progress // TypeDefIndex: 4942
{
	// Methods

	// RVA: -1 Offset: -1
	public static IProgress<T> Create<T>(Action<T> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2012B10 Offset: 0x2012C11 VA: 0x2012B10
	|-Progress.Create<object>
	*/

	// RVA: -1 Offset: -1
	public static IProgress<T> CreateOnlyValueChanged<T>(Action<T> handler, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2012C00 Offset: 0x2012D01 VA: 0x2012C00
	|-Progress.CreateOnlyValueChanged<object>
	*/
}

