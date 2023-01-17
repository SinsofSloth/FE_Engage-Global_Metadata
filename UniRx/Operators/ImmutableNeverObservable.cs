// Namespace: UniRx.Operators
internal class ImmutableNeverObservable<T> : IObservable<T>, IOptimizedObservable<T> // TypeDefIndex: 6995
{
	// Fields
	internal static ImmutableNeverObservable<T> Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public bool IsRequiredSubscribeOnCurrentThread() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2810 Offset: 0x1EB2911 VA: 0x1EB2810
	|-ImmutableNeverObservable<object>.IsRequiredSubscribeOnCurrentThread
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IDisposable Subscribe(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2820 Offset: 0x1EB2921 VA: 0x1EB2820
	|-ImmutableNeverObservable<object>.Subscribe
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB2890 Offset: 0x1EB2991 VA: 0x1EB2890
	|-ImmutableNeverObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB28A0 Offset: 0x1EB29A1 VA: 0x1EB28A0
	|-ImmutableNeverObservable<object>..cctor
	*/
}

