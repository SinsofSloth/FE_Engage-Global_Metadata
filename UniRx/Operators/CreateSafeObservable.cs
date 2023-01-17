// Namespace: UniRx.Operators
internal class CreateSafeObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6923
{
	// Fields
	private readonly Func<IObserver<T>, IDisposable> subscribe; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<IObserver<T>, IDisposable> subscribe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2510380 Offset: 0x2510481 VA: 0x2510380
	|-CreateSafeObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<IObserver<T>, IDisposable> subscribe, bool isRequiredSubscribeOnCurrentThread) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25103D0 Offset: 0x25104D1 VA: 0x25103D0
	|-CreateSafeObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2510420 Offset: 0x2510521 VA: 0x2510420
	|-CreateSafeObservable<object>.SubscribeCore
	*/
}

