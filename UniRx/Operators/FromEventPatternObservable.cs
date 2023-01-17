// Namespace: UniRx.Operators
internal class FromEventPatternObservable<TDelegate, TEventArgs> : OperatorObservableBase<EventPattern<TEventArgs>> // TypeDefIndex: 6970
{
	// Fields
	private readonly Func<EventHandler<TEventArgs>, TDelegate> conversion; // 0x0
	private readonly Action<TDelegate> addHandler; // 0x0
	private readonly Action<TDelegate> removeHandler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<EventHandler<TEventArgs>, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E3B70 Offset: 0x33E3C71 VA: 0x33E3B70
	|-FromEventPatternObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<EventPattern<TEventArgs>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E3BF0 Offset: 0x33E3CF1 VA: 0x33E3BF0
	|-FromEventPatternObservable<object, object>.SubscribeCore
	*/
}

