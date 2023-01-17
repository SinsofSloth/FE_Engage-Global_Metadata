// Namespace: UniRx.Operators
internal class CombineLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> : OperatorObservableBase<TR> // TypeDefIndex: 6909
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private IObservable<T4> source4; // 0x0
	private IObservable<T5> source5; // 0x0
	private IObservable<T6> source6; // 0x0
	private IObservable<T7> source7; // 0x0
	private CombineLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, IObservable<T6> source6, IObservable<T7> source7, CombineLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3C00 Offset: 0x30E3D01 VA: 0x30E3C00
	|-CombineLatestObservable<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3DC0 Offset: 0x30E3EC1 VA: 0x30E3DC0
	|-CombineLatestObservable<object, object, object, object, object, object, object, object>.SubscribeCore
	*/
}

