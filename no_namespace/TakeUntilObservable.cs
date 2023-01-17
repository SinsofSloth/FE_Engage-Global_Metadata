// Namespace: 
private class TakeUntilObservable.TakeUntil.TakeUntilOther<T, TOther> : IObserver<TOther> // TypeDefIndex: 7090
{
	// Fields
	private readonly TakeUntilObservable.TakeUntil<T, TOther> sourceObserver; // 0x0
	private readonly IDisposable subscription; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TakeUntilObservable.TakeUntil<T, TOther> sourceObserver, IDisposable subscription) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BD850 Offset: 0x34BD951 VA: 0x34BD850
	|-TakeUntilObservable.TakeUntil.TakeUntilOther<object, object>..ctor
	|
	|-RVA: 0x34BDFF0 Offset: 0x34BE0F1 VA: 0x34BDFF0
	|-TakeUntilObservable.TakeUntil.TakeUntilOther<object, Unit>..ctor
	|
	|-RVA: 0x34BE790 Offset: 0x34BE891 VA: 0x34BE790
	|-TakeUntilObservable.TakeUntil.TakeUntilOther<Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(TOther value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BD8A0 Offset: 0x34BD9A1 VA: 0x34BD8A0
	|-TakeUntilObservable.TakeUntil.TakeUntilOther<object, object>.OnNext
	|
	|-RVA: 0x34BE040 Offset: 0x34BE141 VA: 0x34BE040
	|-TakeUntilObservable.TakeUntil.TakeUntilOther<object, Unit>.OnNext
	|
	|-RVA: 0x34BE7E0 Offset: 0x34BE8E1 VA: 0x34BE7E0
	|-TakeUntilObservable.TakeUntil.TakeUntilOther<Unit, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BDB10 Offset: 0x34BDC11 VA: 0x34BDB10
	|-TakeUntilObservable.TakeUntil.TakeUntilOther<object, object>.OnError
	|
	|-RVA: 0x34BE2B0 Offset: 0x34BE3B1 VA: 0x34BE2B0
	|-TakeUntilObservable.TakeUntil.TakeUntilOther<object, Unit>.OnError
	|
	|-RVA: 0x34BEA50 Offset: 0x34BEB51 VA: 0x34BEA50
	|-TakeUntilObservable.TakeUntil.TakeUntilOther<Unit, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BDD80 Offset: 0x34BDE81 VA: 0x34BDD80
	|-TakeUntilObservable.TakeUntil.TakeUntilOther<object, object>.OnCompleted
	|
	|-RVA: 0x34BE520 Offset: 0x34BE621 VA: 0x34BE520
	|-TakeUntilObservable.TakeUntil.TakeUntilOther<object, Unit>.OnCompleted
	|
	|-RVA: 0x34BECC0 Offset: 0x34BEDC1 VA: 0x34BECC0
	|-TakeUntilObservable.TakeUntil.TakeUntilOther<Unit, object>.OnCompleted
	*/
}

