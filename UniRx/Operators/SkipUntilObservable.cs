// Namespace: UniRx.Operators
internal class SkipUntilObservable<T, TOther> : OperatorObservableBase<T> // TypeDefIndex: 7068
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly IObservable<TOther> other; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, IObservable<TOther> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3442010 Offset: 0x3442111 VA: 0x3442010
	|-SkipUntilObservable<object, object>..ctor
	|
	|-RVA: 0x3442160 Offset: 0x3442261 VA: 0x3442160
	|-SkipUntilObservable<Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34420C0 Offset: 0x34421C1 VA: 0x34420C0
	|-SkipUntilObservable<object, object>.SubscribeCore
	|
	|-RVA: 0x3442210 Offset: 0x3442311 VA: 0x3442210
	|-SkipUntilObservable<Unit, object>.SubscribeCore
	*/
}

