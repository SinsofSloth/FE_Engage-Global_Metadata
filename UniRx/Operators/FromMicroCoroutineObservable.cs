// Namespace: UniRx.Operators
internal class FromMicroCoroutineObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7215
{
	// Fields
	private readonly Func<IObserver<T>, CancellationToken, IEnumerator> coroutine; // 0x0
	private readonly FrameCountType frameCountType; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<IObserver<T>, CancellationToken, IEnumerator> coroutine, FrameCountType frameCountType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E48A0 Offset: 0x33E49A1 VA: 0x33E48A0
	|-FromMicroCoroutineObservable<long>..ctor
	|
	|-RVA: 0x33E4B70 Offset: 0x33E4C71 VA: 0x33E4B70
	|-FromMicroCoroutineObservable<object>..ctor
	|
	|-RVA: 0x1E4C890 Offset: 0x1E4C991 VA: 0x1E4C890
	|-FromMicroCoroutineObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E4900 Offset: 0x33E4A01 VA: 0x33E4900
	|-FromMicroCoroutineObservable<long>.SubscribeCore
	|
	|-RVA: 0x33E4BD0 Offset: 0x33E4CD1 VA: 0x33E4BD0
	|-FromMicroCoroutineObservable<object>.SubscribeCore
	|
	|-RVA: 0x1E4C8F0 Offset: 0x1E4C9F1 VA: 0x1E4C8F0
	|-FromMicroCoroutineObservable<Unit>.SubscribeCore
	*/
}

