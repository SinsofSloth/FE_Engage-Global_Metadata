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

// Namespace: 
private class TakeUntilObservable.TakeUntil<T, TOther> : OperatorObserverBase<T, T> // TypeDefIndex: 7091
{
	// Fields
	private readonly TakeUntilObservable<T, TOther> parent; // 0x0
	private object gate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TakeUntilObservable<T, TOther> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BBD80 Offset: 0x34BBE81 VA: 0x34BBD80
	|-TakeUntilObservable.TakeUntil<object, object>..ctor
	|
	|-RVA: 0x34BC520 Offset: 0x34BC621 VA: 0x34BC520
	|-TakeUntilObservable.TakeUntil<object, Unit>..ctor
	|
	|-RVA: 0x34BCCC0 Offset: 0x34BCDC1 VA: 0x34BCCC0
	|-TakeUntilObservable.TakeUntil<Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BBE40 Offset: 0x34BBF41 VA: 0x34BBE40
	|-TakeUntilObservable.TakeUntil<object, object>.Run
	|
	|-RVA: 0x34BC5E0 Offset: 0x34BC6E1 VA: 0x34BC5E0
	|-TakeUntilObservable.TakeUntil<object, Unit>.Run
	|
	|-RVA: 0x34BCD80 Offset: 0x34BCE81 VA: 0x34BCD80
	|-TakeUntilObservable.TakeUntil<Unit, object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BC010 Offset: 0x34BC111 VA: 0x34BC010
	|-TakeUntilObservable.TakeUntil<object, object>.OnNext
	|
	|-RVA: 0x34BC7B0 Offset: 0x34BC8B1 VA: 0x34BC7B0
	|-TakeUntilObservable.TakeUntil<object, Unit>.OnNext
	|
	|-RVA: 0x34BCF50 Offset: 0x34BD051 VA: 0x34BCF50
	|-TakeUntilObservable.TakeUntil<Unit, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BC170 Offset: 0x34BC271 VA: 0x34BC170
	|-TakeUntilObservable.TakeUntil<object, object>.OnError
	|
	|-RVA: 0x34BC910 Offset: 0x34BCA11 VA: 0x34BC910
	|-TakeUntilObservable.TakeUntil<object, Unit>.OnError
	|
	|-RVA: 0x34BD0B0 Offset: 0x34BD1B1 VA: 0x34BD0B0
	|-TakeUntilObservable.TakeUntil<Unit, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34BC350 Offset: 0x34BC451 VA: 0x34BC350
	|-TakeUntilObservable.TakeUntil<object, object>.OnCompleted
	|
	|-RVA: 0x34BCAF0 Offset: 0x34BCBF1 VA: 0x34BCAF0
	|-TakeUntilObservable.TakeUntil<object, Unit>.OnCompleted
	|
	|-RVA: 0x34BD290 Offset: 0x34BD391 VA: 0x34BD290
	|-TakeUntilObservable.TakeUntil<Unit, object>.OnCompleted
	*/
}

