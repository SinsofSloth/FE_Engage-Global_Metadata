// Namespace: UniRx.Operators
internal class TakeObservable<T> : OperatorObservableBase<T> // TypeDefIndex: 7086
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
	|-RVA: 0x34BABC0 Offset: 0x34BACC1 VA: 0x34BABC0
	|-TakeObservable<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x34BB030 Offset: 0x34BB131 VA: 0x34BB030
	|-TakeObservable<long>..ctor
	|
	|-RVA: 0x34BB4A0 Offset: 0x34BB5A1 VA: 0x34BB4A0
	|-TakeObservable<object>..ctor
	|
	|-RVA: 0x34BB910 Offset: 0x34BBA11 VA: 0x34BB910
	|-TakeObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, TimeSpan duration, IScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BAC40 Offset: 0x34BAD41 VA: 0x34BAC40
	|-TakeObservable<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x34BB0B0 Offset: 0x34BB1B1 VA: 0x34BB0B0
	|-TakeObservable<long>..ctor
	|
	|-RVA: 0x34BB520 Offset: 0x34BB621 VA: 0x34BB520
	|-TakeObservable<object>..ctor
	|
	|-RVA: 0x34BB990 Offset: 0x34BBA91 VA: 0x34BB990
	|-TakeObservable<Unit>..ctor
	*/

	// RVA: -1 Offset: -1
	public IObservable<T> Combine(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BAD50 Offset: 0x34BAE51 VA: 0x34BAD50
	|-TakeObservable<ValueTuple<object, object>>.Combine
	|
	|-RVA: 0x34BB1C0 Offset: 0x34BB2C1 VA: 0x34BB1C0
	|-TakeObservable<long>.Combine
	|
	|-RVA: 0x34BB630 Offset: 0x34BB731 VA: 0x34BB630
	|-TakeObservable<object>.Combine
	|
	|-RVA: 0x34BBAA0 Offset: 0x34BBBA1 VA: 0x34BBAA0
	|-TakeObservable<Unit>.Combine
	*/

	// RVA: -1 Offset: -1
	public IObservable<T> Combine(TimeSpan duration) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BADE0 Offset: 0x34BAEE1 VA: 0x34BADE0
	|-TakeObservable<ValueTuple<object, object>>.Combine
	|
	|-RVA: 0x34BB250 Offset: 0x34BB351 VA: 0x34BB250
	|-TakeObservable<long>.Combine
	|
	|-RVA: 0x34BB6C0 Offset: 0x34BB7C1 VA: 0x34BB6C0
	|-TakeObservable<object>.Combine
	|
	|-RVA: 0x34BBB30 Offset: 0x34BBC31 VA: 0x34BBB30
	|-TakeObservable<Unit>.Combine
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BAEC0 Offset: 0x34BAFC1 VA: 0x34BAEC0
	|-TakeObservable<ValueTuple<object, object>>.SubscribeCore
	|
	|-RVA: 0x34BB330 Offset: 0x34BB431 VA: 0x34BB330
	|-TakeObservable<long>.SubscribeCore
	|
	|-RVA: 0x34BB7A0 Offset: 0x34BB8A1 VA: 0x34BB7A0
	|-TakeObservable<object>.SubscribeCore
	|
	|-RVA: 0x34BBC10 Offset: 0x34BBD11 VA: 0x34BBC10
	|-TakeObservable<Unit>.SubscribeCore
	*/
}

