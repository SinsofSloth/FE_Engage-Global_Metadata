// Namespace: UniRx.Operators
internal class ConcatObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6915
{
	// Fields
	private readonly IEnumerable<IObservable<T>> sources; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<IObservable<T>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2503CB0 Offset: 0x2503DB1 VA: 0x2503CB0
	|-ConcatObservable<object>..ctor
	|
	|-RVA: 0x2503F10 Offset: 0x2504011 VA: 0x2503F10
	|-ConcatObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public IObservable<T> Combine(IEnumerable<IObservable<T>> combineSources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2503D00 Offset: 0x2503E01 VA: 0x2503D00
	|-ConcatObservable<object>.Combine
	|
	|-RVA: 0x2503F60 Offset: 0x2504061 VA: 0x2503F60
	|-ConcatObservable<Unit>.Combine
	*/

	[IteratorStateMachineAttribute] // RVA: 0x182B0 Offset: 0x183B1 VA: 0x182B0
	// RVA: -1 Offset: -1
	private static IEnumerable<IObservable<T>> CombineSources(IEnumerable<IObservable<T>> first, IEnumerable<IObservable<T>> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2503D90 Offset: 0x2503E91 VA: 0x2503D90
	|-ConcatObservable<object>.CombineSources
	|
	|-RVA: 0x2503FF0 Offset: 0x25040F1 VA: 0x2503FF0
	|-ConcatObservable<Unit>.CombineSources
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2503E70 Offset: 0x2503F71 VA: 0x2503E70
	|-ConcatObservable<object>.SubscribeCore
	|
	|-RVA: 0x25040D0 Offset: 0x25041D1 VA: 0x25040D0
	|-ConcatObservable<Unit>.SubscribeCore
	*/
}

