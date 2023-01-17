// Namespace: UniRx.Operators
internal class CatchObservable<T, TException> : OperatorObservableBase<T> // TypeDefIndex: 6885
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly Func<TException, IObservable<T>> errorHandler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, Func<TException, IObservable<T>> errorHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D36A0 Offset: 0x30D37A1 VA: 0x30D36A0
	|-CatchObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D3720 Offset: 0x30D3821 VA: 0x30D3720
	|-CatchObservable<object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class CatchObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 6887
{
	// Fields
	private readonly IEnumerable<IObservable<T>> sources; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<IObservable<T>> sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D35B0 Offset: 0x30D36B1 VA: 0x30D35B0
	|-CatchObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D3600 Offset: 0x30D3701 VA: 0x30D3600
	|-CatchObservable<object>.SubscribeCore
	*/
}

