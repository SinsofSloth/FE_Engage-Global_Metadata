// Namespace: 
private class CreateObservable.Create<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6918
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250DD40 Offset: 0x250DE41 VA: 0x250DD40
	|-CreateObservable.Create<object>..ctor
	|
	|-RVA: 0x250E080 Offset: 0x250E181 VA: 0x250E080
	|-CreateObservable.Create<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250DD60 Offset: 0x250DE61 VA: 0x250DD60
	|-CreateObservable.Create<object>.OnNext
	|
	|-RVA: 0x250E0A0 Offset: 0x250E1A1 VA: 0x250E0A0
	|-CreateObservable.Create<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250DE10 Offset: 0x250DF11 VA: 0x250DE10
	|-CreateObservable.Create<object>.OnError
	|
	|-RVA: 0x250E150 Offset: 0x250E251 VA: 0x250E150
	|-CreateObservable.Create<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250DF50 Offset: 0x250E051 VA: 0x250DF50
	|-CreateObservable.Create<object>.OnCompleted
	|
	|-RVA: 0x250E290 Offset: 0x250E391 VA: 0x250E290
	|-CreateObservable.Create<Unit>.OnCompleted
	*/
}

// Namespace: 
private class CreateObservable.Create<T, TState> : OperatorObserverBase<T, T> // TypeDefIndex: 6920
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250E3C0 Offset: 0x250E4C1 VA: 0x250E3C0
	|-CreateObservable.Create<bool, object>..ctor
	|
	|-RVA: 0x250E700 Offset: 0x250E801 VA: 0x250E700
	|-CreateObservable.Create<int, object>..ctor
	|
	|-RVA: 0x250EA40 Offset: 0x250EB41 VA: 0x250EA40
	|-CreateObservable.Create<object, object>..ctor
	|
	|-RVA: 0x250ED80 Offset: 0x250EE81 VA: 0x250ED80
	|-CreateObservable.Create<float, object>..ctor
	|
	|-RVA: 0x250F0C0 Offset: 0x250F1C1 VA: 0x250F0C0
	|-CreateObservable.Create<Vector2, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250E3E0 Offset: 0x250E4E1 VA: 0x250E3E0
	|-CreateObservable.Create<bool, object>.OnNext
	|
	|-RVA: 0x250E720 Offset: 0x250E821 VA: 0x250E720
	|-CreateObservable.Create<int, object>.OnNext
	|
	|-RVA: 0x250EA60 Offset: 0x250EB61 VA: 0x250EA60
	|-CreateObservable.Create<object, object>.OnNext
	|
	|-RVA: 0x250EDA0 Offset: 0x250EEA1 VA: 0x250EDA0
	|-CreateObservable.Create<float, object>.OnNext
	|
	|-RVA: 0x250F0E0 Offset: 0x250F1E1 VA: 0x250F0E0
	|-CreateObservable.Create<Vector2, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250E490 Offset: 0x250E591 VA: 0x250E490
	|-CreateObservable.Create<bool, object>.OnError
	|
	|-RVA: 0x250E7D0 Offset: 0x250E8D1 VA: 0x250E7D0
	|-CreateObservable.Create<int, object>.OnError
	|
	|-RVA: 0x250EB10 Offset: 0x250EC11 VA: 0x250EB10
	|-CreateObservable.Create<object, object>.OnError
	|
	|-RVA: 0x250EE50 Offset: 0x250EF51 VA: 0x250EE50
	|-CreateObservable.Create<float, object>.OnError
	|
	|-RVA: 0x250F190 Offset: 0x250F291 VA: 0x250F190
	|-CreateObservable.Create<Vector2, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250E5D0 Offset: 0x250E6D1 VA: 0x250E5D0
	|-CreateObservable.Create<bool, object>.OnCompleted
	|
	|-RVA: 0x250E910 Offset: 0x250EA11 VA: 0x250E910
	|-CreateObservable.Create<int, object>.OnCompleted
	|
	|-RVA: 0x250EC50 Offset: 0x250ED51 VA: 0x250EC50
	|-CreateObservable.Create<object, object>.OnCompleted
	|
	|-RVA: 0x250EF90 Offset: 0x250F091 VA: 0x250EF90
	|-CreateObservable.Create<float, object>.OnCompleted
	|
	|-RVA: 0x250F2D0 Offset: 0x250F3D1 VA: 0x250F2D0
	|-CreateObservable.Create<Vector2, object>.OnCompleted
	*/
}

