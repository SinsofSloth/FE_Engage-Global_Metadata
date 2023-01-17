// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x12D70 Offset: 0x12E71 VA: 0x12D70
public static class ObservableExtensions // TypeDefIndex: 6585
{
	// Methods

	[ExtensionAttribute] // RVA: 0x157F0 Offset: 0x158F1 VA: 0x157F0
	// RVA: -1 Offset: -1
	public static IDisposable Subscribe<T>(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297C030 Offset: 0x297C131 VA: 0x297C030
	|-ObservableExtensions.Subscribe<object>
	|
	|-RVA: 0x297C160 Offset: 0x297C261 VA: 0x297C160
	|-ObservableExtensions.Subscribe<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x15800 Offset: 0x15901 VA: 0x15800
	// RVA: -1 Offset: -1
	public static IDisposable Subscribe<T>(IObservable<T> source, Action<T> onNext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297C290 Offset: 0x297C391 VA: 0x297C290
	|-ObservableExtensions.Subscribe<Pair<int>>
	|
	|-RVA: 0x297C3A0 Offset: 0x297C4A1 VA: 0x297C3A0
	|-ObservableExtensions.Subscribe<ValueTuple<Character, GameObject>>
	|-ObservableExtensions.Subscribe<ValueTuple<object, object>>
	|
	|-RVA: 0x297C4B0 Offset: 0x297C5B1 VA: 0x297C4B0
	|-ObservableExtensions.Subscribe<ValueTuple<float, int>>
	|
	|-RVA: 0x297C5C0 Offset: 0x297C6C1 VA: 0x297C5C0
	|-ObservableExtensions.Subscribe<ValueTuple<float, Int32Enum>>
	|-ObservableExtensions.Subscribe<ValueTuple<float, WeaponStyle>>
	|
	|-RVA: 0x297C8F0 Offset: 0x297C9F1 VA: 0x297C8F0
	|-ObservableExtensions.Subscribe<AnimationEvent>
	|-ObservableExtensions.Subscribe<Character>
	|-ObservableExtensions.Subscribe<Collision>
	|-ObservableExtensions.Subscribe<object>
	|-ObservableExtensions.Subscribe<Phase>
	|
	|-RVA: 0x297C6D0 Offset: 0x297C7D1 VA: 0x297C6D0
	|-ObservableExtensions.Subscribe<int>
	|
	|-RVA: 0x297C7E0 Offset: 0x297C8E1 VA: 0x297C7E0
	|-ObservableExtensions.Subscribe<long>
	|
	|-RVA: 0x297CA00 Offset: 0x297CB01 VA: 0x297CA00
	|-ObservableExtensions.Subscribe<float>
	|
	|-RVA: 0x297CB10 Offset: 0x297CC11 VA: 0x297CB10
	|-ObservableExtensions.Subscribe<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x15810 Offset: 0x15911 VA: 0x15810
	// RVA: -1 Offset: -1
	public static IDisposable Subscribe<T>(IObservable<T> source, Action<T> onNext, Action<Exception> onError) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297CD30 Offset: 0x297CE31 VA: 0x297CD30
	|-ObservableExtensions.Subscribe<object>
	|
	|-RVA: 0x297CE40 Offset: 0x297CF41 VA: 0x297CE40
	|-ObservableExtensions.Subscribe<Unit>
	*/

	[ExtensionAttribute] // RVA: 0x15820 Offset: 0x15921 VA: 0x15820
	// RVA: -1 Offset: -1
	public static IDisposable Subscribe<T>(IObservable<T> source, Action<T> onNext, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297CC20 Offset: 0x297CD21 VA: 0x297CC20
	|-ObservableExtensions.Subscribe<object>
	*/

	[ExtensionAttribute] // RVA: 0x15830 Offset: 0x15931 VA: 0x15830
	// RVA: -1 Offset: -1
	public static IDisposable Subscribe<T>(IObservable<T> source, Action<T> onNext, Action<Exception> onError, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297CF50 Offset: 0x297D051 VA: 0x297CF50
	|-ObservableExtensions.Subscribe<object>
	*/

	[ExtensionAttribute] // RVA: 0x15840 Offset: 0x15941 VA: 0x15840
	// RVA: -1 Offset: -1
	public static IDisposable SubscribeWithState<T, TState>(IObservable<T> source, TState state, Action<T, TState> onNext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297D010 Offset: 0x297D111 VA: 0x297D010
	|-ObservableExtensions.SubscribeWithState<bool, ReactiveProperty<bool>>
	|-ObservableExtensions.SubscribeWithState<bool, object>
	|-ObservableExtensions.SubscribeWithState<bool, Selectable>
	|
	|-RVA: 0x297D1A0 Offset: 0x297D2A1 VA: 0x297D1A0
	|-ObservableExtensions.SubscribeWithState<object, object>
	|-ObservableExtensions.SubscribeWithState<string, Text>
	|
	|-RVA: 0x297D330 Offset: 0x297D431 VA: 0x297D330
	|-ObservableExtensions.SubscribeWithState<Unit, IAsyncReactiveCommand<Unit>>
	|-ObservableExtensions.SubscribeWithState<Unit, IReactiveCommand<Unit>>
	|-ObservableExtensions.SubscribeWithState<Unit, object>
	*/

	[ExtensionAttribute] // RVA: 0x15850 Offset: 0x15951 VA: 0x15850
	// RVA: -1 Offset: -1
	public static IDisposable SubscribeWithState<T, TState>(IObservable<T> source, TState state, Action<T, TState> onNext, Action<Exception, TState> onError) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297D620 Offset: 0x297D721 VA: 0x297D620
	|-ObservableExtensions.SubscribeWithState<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x15860 Offset: 0x15961 VA: 0x15860
	// RVA: -1 Offset: -1
	public static IDisposable SubscribeWithState<T, TState>(IObservable<T> source, TState state, Action<T, TState> onNext, Action<TState> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297D4C0 Offset: 0x297D5C1 VA: 0x297D4C0
	|-ObservableExtensions.SubscribeWithState<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x15870 Offset: 0x15971 VA: 0x15870
	// RVA: -1 Offset: -1
	public static IDisposable SubscribeWithState<T, TState>(IObservable<T> source, TState state, Action<T, TState> onNext, Action<Exception, TState> onError, Action<TState> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297D780 Offset: 0x297D881 VA: 0x297D780
	|-ObservableExtensions.SubscribeWithState<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x15880 Offset: 0x15981 VA: 0x15880
	// RVA: -1 Offset: -1
	public static IDisposable SubscribeWithState2<T, TState1, TState2>(IObservable<T> source, TState1 state1, TState2 state2, Action<T, TState1, TState2> onNext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297D840 Offset: 0x297D941 VA: 0x297D840
	|-ObservableExtensions.SubscribeWithState2<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x15890 Offset: 0x15991 VA: 0x15890
	// RVA: -1 Offset: -1
	public static IDisposable SubscribeWithState2<T, TState1, TState2>(IObservable<T> source, TState1 state1, TState2 state2, Action<T, TState1, TState2> onNext, Action<Exception, TState1, TState2> onError) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297DB50 Offset: 0x297DC51 VA: 0x297DB50
	|-ObservableExtensions.SubscribeWithState2<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x158A0 Offset: 0x159A1 VA: 0x158A0
	// RVA: -1 Offset: -1
	public static IDisposable SubscribeWithState2<T, TState1, TState2>(IObservable<T> source, TState1 state1, TState2 state2, Action<T, TState1, TState2> onNext, Action<TState1, TState2> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297D9E0 Offset: 0x297DAE1 VA: 0x297D9E0
	|-ObservableExtensions.SubscribeWithState2<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x158B0 Offset: 0x159B1 VA: 0x158B0
	// RVA: -1 Offset: -1
	public static IDisposable SubscribeWithState2<T, TState1, TState2>(IObservable<T> source, TState1 state1, TState2 state2, Action<T, TState1, TState2> onNext, Action<Exception, TState1, TState2> onError, Action<TState1, TState2> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297DCC0 Offset: 0x297DDC1 VA: 0x297DCC0
	|-ObservableExtensions.SubscribeWithState2<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x158C0 Offset: 0x159C1 VA: 0x158C0
	// RVA: -1 Offset: -1
	public static IDisposable SubscribeWithState3<T, TState1, TState2, TState3>(IObservable<T> source, TState1 state1, TState2 state2, TState3 state3, Action<T, TState1, TState2, TState3> onNext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297DD90 Offset: 0x297DE91 VA: 0x297DD90
	|-ObservableExtensions.SubscribeWithState3<long, object, object, object>
	|
	|-RVA: 0x297DF40 Offset: 0x297E041 VA: 0x297DF40
	|-ObservableExtensions.SubscribeWithState3<object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x158D0 Offset: 0x159D1 VA: 0x158D0
	// RVA: -1 Offset: -1
	public static IDisposable SubscribeWithState3<T, TState1, TState2, TState3>(IObservable<T> source, TState1 state1, TState2 state2, TState3 state3, Action<T, TState1, TState2, TState3> onNext, Action<Exception, TState1, TState2, TState3> onError) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297E270 Offset: 0x297E371 VA: 0x297E270
	|-ObservableExtensions.SubscribeWithState3<object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x158E0 Offset: 0x159E1 VA: 0x158E0
	// RVA: -1 Offset: -1
	public static IDisposable SubscribeWithState3<T, TState1, TState2, TState3>(IObservable<T> source, TState1 state1, TState2 state2, TState3 state3, Action<T, TState1, TState2, TState3> onNext, Action<TState1, TState2, TState3> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297E0F0 Offset: 0x297E1F1 VA: 0x297E0F0
	|-ObservableExtensions.SubscribeWithState3<object, object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x158F0 Offset: 0x159F1 VA: 0x158F0
	// RVA: -1 Offset: -1
	public static IDisposable SubscribeWithState3<T, TState1, TState2, TState3>(IObservable<T> source, TState1 state1, TState2 state2, TState3 state3, Action<T, TState1, TState2, TState3> onNext, Action<Exception, TState1, TState2, TState3> onError, Action<TState1, TState2, TState3> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297E3F0 Offset: 0x297E4F1 VA: 0x297E3F0
	|-ObservableExtensions.SubscribeWithState3<object, object, object, object>
	*/
}

