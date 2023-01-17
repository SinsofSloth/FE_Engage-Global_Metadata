// Namespace: UniRx.Operators
internal class SkipObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7064
{
	// Fields
	private readonly IObservable<T> source; // 0x0
	private readonly int count; // 0x0
	private readonly TimeSpan duration; // 0x0
	internal readonly IScheduler scheduler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3441290 Offset: 0x3441391 VA: 0x3441290
	|-SkipObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, TimeSpan duration, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3441310 Offset: 0x3441411 VA: 0x3441310
	|-SkipObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IObservable<T> Combine(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3441420 Offset: 0x3441521 VA: 0x3441420
	|-SkipObservable<object>.Combine
	*/

	// RVA: -1 Offset: -1
	public IObservable<T> Combine(TimeSpan duration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34414A0 Offset: 0x34415A1 VA: 0x34414A0
	|-SkipObservable<object>.Combine
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3441580 Offset: 0x3441681 VA: 0x3441580
	|-SkipObservable<object>.SubscribeCore
	*/
}

