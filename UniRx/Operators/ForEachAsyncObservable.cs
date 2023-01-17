// Namespace: UniRx.Operators
internal class ForEachAsyncObservable<T> : OperatorObservableBase<Unit> // TypeDefIndex: 6968
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Action<T> onNext; // 0x0
	private readonly Action<T, int> onNextWithIndex; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Action<T> onNext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DDE00 Offset: 0x33DDF01 VA: 0x33DDE00
	|-ForEachAsyncObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Action<T, int> onNext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DDEB0 Offset: 0x33DDFB1 VA: 0x33DDEB0
	|-ForEachAsyncObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<Unit> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DDF60 Offset: 0x33DE061 VA: 0x33DDF60
	|-ForEachAsyncObservable<object>.SubscribeCore
	*/
}

