// Namespace: 
private sealed class Progress.OnlyValueChangedProgress<T> : IProgress<T> // TypeDefIndex: 4941
{
	// Fields
	private readonly Action<T> action; // 0x0
	private readonly IEqualityComparer<T> comparer; // 0x0
	private bool isFirstCall; // 0x0
	private T latestValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<T> action, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37163C0 Offset: 0x37164C1 VA: 0x37163C0
	|-Progress.OnlyValueChangedProgress<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Report(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3716420 Offset: 0x3716521 VA: 0x3716420
	|-Progress.OnlyValueChangedProgress<object>.Report
	*/
}

