// Namespace: UniRx.Operators
internal class TimeoutFrameObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7232
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly int frameCount; // 0x0
	private readonly FrameCountType frameCountType; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, int frameCount, FrameCountType frameCountType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399EC90 Offset: 0x399ED91 VA: 0x399EC90
	|-TimeoutFrameObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399ED20 Offset: 0x399EE21 VA: 0x399ED20
	|-TimeoutFrameObservable<object>.SubscribeCore
	*/
}

