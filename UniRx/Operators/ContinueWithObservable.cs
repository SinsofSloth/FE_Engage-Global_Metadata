// Namespace: UniRx.Operators
internal class ContinueWithObservable<TSource, TResult> : OperatorObservableBase<TResult> // TypeDefIndex: 6917
{
	// Fields
	private readonly IObservable<TSource> source; // 0x0
	private readonly Func<TSource, IObservable<TResult>> selector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, Func<TSource, IObservable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250D540 Offset: 0x250D641 VA: 0x250D540
	|-ContinueWithObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250D5C0 Offset: 0x250D6C1 VA: 0x250D5C0
	|-ContinueWithObservable<object, object>.SubscribeCore
	*/
}

