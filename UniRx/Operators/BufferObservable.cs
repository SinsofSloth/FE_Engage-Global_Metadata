// Namespace: UniRx.Operators
internal class BufferObservable<T> : OperatorObservableBase<IList<T>> // TypeDefIndex: 6878
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly int count; // 0x0
	private readonly int skip; // 0x0
	private readonly TimeSpan timeSpan; // 0x0
	private readonly TimeSpan timeShift; // 0x0
	private readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, int count, int skip) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BD9E0 Offset: 0x30BDAE1 VA: 0x30BD9E0
	|-BufferObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, TimeSpan timeSpan, TimeSpan timeShift, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BDA70 Offset: 0x30BDB71 VA: 0x30BDA70
	|-BufferObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, TimeSpan timeSpan, int count, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BDB80 Offset: 0x30BDC81 VA: 0x30BDB80
	|-BufferObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<IList<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30BDC90 Offset: 0x30BDD91 VA: 0x30BDC90
	|-BufferObservable<object>.SubscribeCore
	*/
}

