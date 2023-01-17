// Namespace: UniRx.Operators
internal class ScanObservable<TSource> : OperatorObservableBase<TSource> // TypeDefIndex: 7036
{
	// Fields
	private readonly IObservable<TSource> source; // 0x0
	private readonly Func<TSource, TSource, TSource> accumulator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, Func<TSource, TSource, TSource> accumulator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30000A0 Offset: 0x30001A1 VA: 0x30000A0
	|-ScanObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TSource> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3000120 Offset: 0x3000221 VA: 0x3000120
	|-ScanObservable<object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class ScanObservable<TSource, TAccumulate> : OperatorObservableBase<TAccumulate> // TypeDefIndex: 7038
{
	// Fields
	private readonly IObservable<TSource> source; // 0x0
	private readonly TAccumulate seed; // 0x0
	private readonly Func<TAccumulate, TSource, TAccumulate> accumulator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3000220 Offset: 0x3000321 VA: 0x3000220
	|-ScanObservable<object, object>..ctor
	|
	|-RVA: 0x30003C0 Offset: 0x30004C1 VA: 0x30003C0
	|-ScanObservable<Unit, long>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TAccumulate> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30002C0 Offset: 0x30003C1 VA: 0x30002C0
	|-ScanObservable<object, object>.SubscribeCore
	|
	|-RVA: 0x3000450 Offset: 0x3000551 VA: 0x3000450
	|-ScanObservable<Unit, long>.SubscribeCore
	*/
}

