// Namespace: 
private class ScanObservable.Scan<TSource, TAccumulate> : OperatorObserverBase<TSource, TAccumulate> // TypeDefIndex: 7037
{
	// Fields
	private readonly ScanObservable<TSource, TAccumulate> parent; // 0x0
	private TAccumulate accumulation; // 0x0
	private bool isFirst; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ScanObservable<TSource, TAccumulate> parent, IObserver<TAccumulate> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFF5E0 Offset: 0x2FFF6E1 VA: 0x2FFF5E0
	|-ScanObservable.Scan<object, object>..ctor
	|
	|-RVA: 0x2FFFB50 Offset: 0x2FFFC51 VA: 0x2FFFB50
	|-ScanObservable.Scan<Unit, long>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFF640 Offset: 0x2FFF741 VA: 0x2FFF640
	|-ScanObservable.Scan<object, object>.OnNext
	|
	|-RVA: 0x2FFFBB0 Offset: 0x2FFFCB1 VA: 0x2FFFBB0
	|-ScanObservable.Scan<Unit, long>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFF8E0 Offset: 0x2FFF9E1 VA: 0x2FFF8E0
	|-ScanObservable.Scan<object, object>.OnError
	|
	|-RVA: 0x2FFFE30 Offset: 0x2FFFF31 VA: 0x2FFFE30
	|-ScanObservable.Scan<Unit, long>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FFFA20 Offset: 0x2FFFB21 VA: 0x2FFFA20
	|-ScanObservable.Scan<object, object>.OnCompleted
	|
	|-RVA: 0x2FFFF70 Offset: 0x3000071 VA: 0x2FFFF70
	|-ScanObservable.Scan<Unit, long>.OnCompleted
	*/
}

