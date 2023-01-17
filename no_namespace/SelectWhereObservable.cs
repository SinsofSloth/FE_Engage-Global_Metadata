// Namespace: 
private class SelectWhereObservable.SelectWhere<T, TR> : OperatorObserverBase<T, TR> // TypeDefIndex: 7057
{
	// Fields
	private readonly SelectWhereObservable<T, TR> parent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SelectWhereObservable<T, TR> parent, IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x342F020 Offset: 0x342F121 VA: 0x342F020
	|-SelectWhereObservable.SelectWhere<bool, bool>..ctor
	|
	|-RVA: 0x342F6D0 Offset: 0x342F7D1 VA: 0x342F6D0
	|-SelectWhereObservable.SelectWhere<object, bool>..ctor
	|
	|-RVA: 0x342FD80 Offset: 0x342FE81 VA: 0x342FD80
	|-SelectWhereObservable.SelectWhere<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x342F070 Offset: 0x342F171 VA: 0x342F070
	|-SelectWhereObservable.SelectWhere<bool, bool>.OnNext
	|
	|-RVA: 0x342F720 Offset: 0x342F821 VA: 0x342F720
	|-SelectWhereObservable.SelectWhere<object, bool>.OnNext
	|
	|-RVA: 0x342FDD0 Offset: 0x342FED1 VA: 0x342FDD0
	|-SelectWhereObservable.SelectWhere<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x342F460 Offset: 0x342F561 VA: 0x342F460
	|-SelectWhereObservable.SelectWhere<bool, bool>.OnError
	|
	|-RVA: 0x342FB10 Offset: 0x342FC11 VA: 0x342FB10
	|-SelectWhereObservable.SelectWhere<object, bool>.OnError
	|
	|-RVA: 0x34301C0 Offset: 0x34302C1 VA: 0x34301C0
	|-SelectWhereObservable.SelectWhere<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x342F5A0 Offset: 0x342F6A1 VA: 0x342F5A0
	|-SelectWhereObservable.SelectWhere<bool, bool>.OnCompleted
	|
	|-RVA: 0x342FC50 Offset: 0x342FD51 VA: 0x342FC50
	|-SelectWhereObservable.SelectWhere<object, bool>.OnCompleted
	|
	|-RVA: 0x3430300 Offset: 0x3430401 VA: 0x3430300
	|-SelectWhereObservable.SelectWhere<object, object>.OnCompleted
	*/
}

