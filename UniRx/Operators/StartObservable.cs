// Namespace: UniRx.Operators
internal class StartObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7073
{
	// Fields
	private readonly Action action; // 0x0
	private readonly Func<T> function; // 0x0
	private readonly IScheduler scheduler; // 0x0
	private readonly Nullable<TimeSpan> startAfter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> function, Nullable<TimeSpan> startAfter, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C1EF0 Offset: 0x36C1FF1 VA: 0x36C1EF0
	|-StartObservable<object>..ctor
	|
	|-RVA: 0x36C2320 Offset: 0x36C2421 VA: 0x36C2320
	|-StartObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Action action, Nullable<TimeSpan> startAfter, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C1FD0 Offset: 0x36C20D1 VA: 0x36C1FD0
	|-StartObservable<object>..ctor
	|
	|-RVA: 0x36C2400 Offset: 0x36C2501 VA: 0x36C2400
	|-StartObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C20B0 Offset: 0x36C21B1 VA: 0x36C20B0
	|-StartObservable<object>.SubscribeCore
	|
	|-RVA: 0x36C24E0 Offset: 0x36C25E1 VA: 0x36C24E0
	|-StartObservable<Unit>.SubscribeCore
	*/
}

