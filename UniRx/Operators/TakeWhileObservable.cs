// Namespace: UniRx.Operators
internal class TakeWhileObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7095
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Func<T, bool> predicate; // 0x0
	private readonly Func<T, int, bool> predicateWithIndex; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BFC90 Offset: 0x34BFD91 VA: 0x34BFC90
	|-TakeWhileObservable<long>..ctor
	|
	|-RVA: 0x34BFE80 Offset: 0x34BFF81 VA: 0x34BFE80
	|-TakeWhileObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<T, int, bool> predicateWithIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BFD10 Offset: 0x34BFE11 VA: 0x34BFD10
	|-TakeWhileObservable<long>..ctor
	|
	|-RVA: 0x34BFF00 Offset: 0x34C0001 VA: 0x34BFF00
	|-TakeWhileObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BFD90 Offset: 0x34BFE91 VA: 0x34BFD90
	|-TakeWhileObservable<long>.SubscribeCore
	|
	|-RVA: 0x34BFF80 Offset: 0x34C0081 VA: 0x34BFF80
	|-TakeWhileObservable<object>.SubscribeCore
	*/
}

