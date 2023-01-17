// Namespace: UniRx.Operators
internal class SampleFrameObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7221
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
	|-RVA: 0x2FFE3F0 Offset: 0x2FFE4F1 VA: 0x2FFE3F0
	|-SampleFrameObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFE480 Offset: 0x2FFE581 VA: 0x2FFE480
	|-SampleFrameObservable<object>.SubscribeCore
	*/
}

