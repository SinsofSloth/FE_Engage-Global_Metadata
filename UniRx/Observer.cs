// Namespace: UniRx
public static class Observer // TypeDefIndex: 6583
{
	// Methods

	// RVA: -1 Offset: -1
	internal static IObserver<T> CreateSubscribeObserver<T>(Action<T> onNext, Action<Exception> onError, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297EF00 Offset: 0x297F001 VA: 0x297EF00
	|-Observer.CreateSubscribeObserver<Pair<int>>
	|
	|-RVA: 0x297F060 Offset: 0x297F161 VA: 0x297F060
	|-Observer.CreateSubscribeObserver<ValueTuple<object, object>>
	|
	|-RVA: 0x297F1C0 Offset: 0x297F2C1 VA: 0x297F1C0
	|-Observer.CreateSubscribeObserver<ValueTuple<float, int>>
	|
	|-RVA: 0x297F320 Offset: 0x297F421 VA: 0x297F320
	|-Observer.CreateSubscribeObserver<ValueTuple<float, Int32Enum>>
	|
	|-RVA: 0x297F480 Offset: 0x297F581 VA: 0x297F480
	|-Observer.CreateSubscribeObserver<int>
	|
	|-RVA: 0x297F5E0 Offset: 0x297F6E1 VA: 0x297F5E0
	|-Observer.CreateSubscribeObserver<long>
	|
	|-RVA: 0x297F740 Offset: 0x297F841 VA: 0x297F740
	|-Observer.CreateSubscribeObserver<object>
	|
	|-RVA: 0x297F8A0 Offset: 0x297F9A1 VA: 0x297F8A0
	|-Observer.CreateSubscribeObserver<float>
	|
	|-RVA: 0x297FA00 Offset: 0x297FB01 VA: 0x297FA00
	|-Observer.CreateSubscribeObserver<Unit>
	*/

	// RVA: -1 Offset: -1
	internal static IObserver<T> CreateSubscribeWithStateObserver<T, TState>(TState state, Action<T, TState> onNext, Action<Exception, TState> onError, Action<TState> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297FD40 Offset: 0x297FE41 VA: 0x297FD40
	|-Observer.CreateSubscribeWithStateObserver<bool, object>
	|
	|-RVA: 0x297FDD0 Offset: 0x297FED1 VA: 0x297FDD0
	|-Observer.CreateSubscribeWithStateObserver<object, object>
	|
	|-RVA: 0x297FE60 Offset: 0x297FF61 VA: 0x297FE60
	|-Observer.CreateSubscribeWithStateObserver<Unit, object>
	*/

	// RVA: -1 Offset: -1
	internal static IObserver<T> CreateSubscribeWithState2Observer<T, TState1, TState2>(TState1 state1, TState2 state2, Action<T, TState1, TState2> onNext, Action<Exception, TState1, TState2> onError, Action<TState1, TState2> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297FB60 Offset: 0x297FC61 VA: 0x297FB60
	|-Observer.CreateSubscribeWithState2Observer<object, object, object>
	*/

	// RVA: -1 Offset: -1
	internal static IObserver<T> CreateSubscribeWithState3Observer<T, TState1, TState2, TState3>(TState1 state1, TState2 state2, TState3 state3, Action<T, TState1, TState2, TState3> onNext, Action<Exception, TState1, TState2, TState3> onError, Action<TState1, TState2, TState3> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297FC00 Offset: 0x297FD01 VA: 0x297FC00
	|-Observer.CreateSubscribeWithState3Observer<long, object, object, object>
	|
	|-RVA: 0x297FCA0 Offset: 0x297FDA1 VA: 0x297FCA0
	|-Observer.CreateSubscribeWithState3Observer<object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public static IObserver<T> Create<T>(Action<T> onNext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297EB60 Offset: 0x297EC61 VA: 0x297EB60
	|-Observer.Create<object>
	*/

	// RVA: -1 Offset: -1
	public static IObserver<T> Create<T>(Action<T> onNext, Action<Exception> onError) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297EC90 Offset: 0x297ED91 VA: 0x297EC90
	|-Observer.Create<object>
	*/

	// RVA: -1 Offset: -1
	public static IObserver<T> Create<T>(Action<T> onNext, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297EBF0 Offset: 0x297ECF1 VA: 0x297EBF0
	|-Observer.Create<object>
	*/

	// RVA: -1 Offset: -1
	public static IObserver<T> Create<T>(Action<T> onNext, Action<Exception> onError, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297ED30 Offset: 0x297EE31 VA: 0x297ED30
	|-Observer.Create<object>
	*/

	// RVA: -1 Offset: -1
	public static IObserver<T> CreateAutoDetachObserver<T>(IObserver<T> observer, IDisposable disposable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297EE90 Offset: 0x297EF91 VA: 0x297EE90
	|-Observer.CreateAutoDetachObserver<object>
	*/
}

