// Namespace: UniRx.Operators
internal class FromCoroutineObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7213
{
	// Fields
	private readonly Func<IObserver<T>, CancellationToken, IEnumerator> coroutine; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<IObserver<T>, CancellationToken, IEnumerator> coroutine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E13E0 Offset: 0x33E14E1 VA: 0x33E13E0
	|-FromCoroutineObservable<long>..ctor
	|
	|-RVA: 0x33E1560 Offset: 0x33E1661 VA: 0x33E1560
	|-FromCoroutineObservable<object>..ctor
	|
	|-RVA: 0x33E16E0 Offset: 0x33E17E1 VA: 0x33E16E0
	|-FromCoroutineObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1430 Offset: 0x33E1531 VA: 0x33E1430
	|-FromCoroutineObservable<long>.SubscribeCore
	|
	|-RVA: 0x33E15B0 Offset: 0x33E16B1 VA: 0x33E15B0
	|-FromCoroutineObservable<object>.SubscribeCore
	|
	|-RVA: 0x33E1730 Offset: 0x33E1831 VA: 0x33E1730
	|-FromCoroutineObservable<Unit>.SubscribeCore
	*/
}

