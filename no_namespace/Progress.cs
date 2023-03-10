// Namespace: 
private sealed class Progress.NullProgress<T> : IProgress<T> // TypeDefIndex: 4939
{
	// Fields
	public static readonly IProgress<T> Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A9D80 Offset: 0x31A9E81 VA: 0x31A9D80
	|-Progress.NullProgress<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Report(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A9D90 Offset: 0x31A9E91 VA: 0x31A9D90
	|-Progress.NullProgress<object>.Report
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A9DA0 Offset: 0x31A9EA1 VA: 0x31A9DA0
	|-Progress.NullProgress<object>..cctor
	*/
}

// Namespace: 
private sealed class Progress.AnonymousProgress<T> : IProgress<T> // TypeDefIndex: 4940
{
	// Fields
	private readonly Action<T> action; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8390 Offset: 0x1FF8491 VA: 0x1FF8390
	|-Progress.AnonymousProgress<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Report(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF83D0 Offset: 0x1FF84D1 VA: 0x1FF83D0
	|-Progress.AnonymousProgress<object>.Report
	*/
}

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

