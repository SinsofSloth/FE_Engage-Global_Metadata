// Namespace: UniRx.Operators
internal class ImmediateReturnObservable<T> : IObservable<T>, IOptimizedObservable<T> // TypeDefIndex: 7025
{
	// Fields
	private readonly T value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB06E0 Offset: 0x1EB07E1 VA: 0x1EB06E0
	|-ImmediateReturnObservable<int>..ctor
	|
	|-RVA: 0x1EB0890 Offset: 0x1EB0991 VA: 0x1EB0890
	|-ImmediateReturnObservable<object>..ctor
	|
	|-RVA: 0x1EB0A50 Offset: 0x1EB0B51 VA: 0x1EB0A50
	|-ImmediateReturnObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool IsRequiredSubscribeOnCurrentThread() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB0710 Offset: 0x1EB0811 VA: 0x1EB0710
	|-ImmediateReturnObservable<int>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x1EB08D0 Offset: 0x1EB09D1 VA: 0x1EB08D0
	|-ImmediateReturnObservable<object>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x1EB0A80 Offset: 0x1EB0B81 VA: 0x1EB0A80
	|-ImmediateReturnObservable<Unit>.IsRequiredSubscribeOnCurrentThread
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IDisposable Subscribe(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB0720 Offset: 0x1EB0821 VA: 0x1EB0720
	|-ImmediateReturnObservable<int>.Subscribe
	|
	|-RVA: 0x1EB08E0 Offset: 0x1EB09E1 VA: 0x1EB08E0
	|-ImmediateReturnObservable<object>.Subscribe
	|
	|-RVA: 0x1EB0A90 Offset: 0x1EB0B91 VA: 0x1EB0A90
	|-ImmediateReturnObservable<Unit>.Subscribe
	*/
}

