// Namespace: 
private class Observer.Subscribe<T, TState1, TState2, TState3> : IObserver<T> // TypeDefIndex: 6581
{
	// Fields
	private readonly TState1 state1; // 0x0
	private readonly TState2 state2; // 0x0
	private readonly TState3 state3; // 0x0
	private readonly Action<T, TState1, TState2, TState3> onNext; // 0x0
	private readonly Action<Exception, TState1, TState2, TState3> onError; // 0x0
	private readonly Action<TState1, TState2, TState3> onCompleted; // 0x0
	private int isStopped; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TState1 state1, TState2 state2, TState3 state3, Action<T, TState1, TState2, TState3> onNext, Action<Exception, TState1, TState2, TState3> onError, Action<TState1, TState2, TState3> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AC670 Offset: 0x34AC771 VA: 0x34AC670
	|-Observer.Subscribe<long, object, object, object>..ctor
	|
	|-RVA: 0x34AC820 Offset: 0x34AC921 VA: 0x34AC820
	|-Observer.Subscribe<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AC720 Offset: 0x34AC821 VA: 0x34AC720
	|-Observer.Subscribe<long, object, object, object>.OnNext
	|
	|-RVA: 0x34AC8D0 Offset: 0x34AC9D1 VA: 0x34AC8D0
	|-Observer.Subscribe<object, object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AC750 Offset: 0x34AC851 VA: 0x34AC750
	|-Observer.Subscribe<long, object, object, object>.OnError
	|
	|-RVA: 0x34AC900 Offset: 0x34ACA01 VA: 0x34AC900
	|-Observer.Subscribe<object, object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AC7C0 Offset: 0x34AC8C1 VA: 0x34AC7C0
	|-Observer.Subscribe<long, object, object, object>.OnCompleted
	|
	|-RVA: 0x34AC970 Offset: 0x34ACA71 VA: 0x34AC970
	|-Observer.Subscribe<object, object, object, object>.OnCompleted
	*/
}

