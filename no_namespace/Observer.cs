// Namespace: 
private class Observer.AnonymousObserver<T> : IObserver<T> // TypeDefIndex: 6575
{
	// Fields
	private readonly Action<T> onNext; // 0x0
	private readonly Action<Exception> onError; // 0x0
	private readonly Action onCompleted; // 0x0
	private int isStopped; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<T> onNext, Action<Exception> onError, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8220 Offset: 0x1FF8321 VA: 0x1FF8220
	|-Observer.AnonymousObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8290 Offset: 0x1FF8391 VA: 0x1FF8290
	|-Observer.AnonymousObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF82C0 Offset: 0x1FF83C1 VA: 0x1FF82C0
	|-Observer.AnonymousObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8340 Offset: 0x1FF8441 VA: 0x1FF8340
	|-Observer.AnonymousObserver<object>.OnCompleted
	*/
}

// Namespace: 
private class Observer.EmptyOnNextAnonymousObserver<T> : IObserver<T> // TypeDefIndex: 6576
{
	// Fields
	private readonly Action<Exception> onError; // 0x0
	private readonly Action onCompleted; // 0x0
	private int isStopped; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<Exception> onError, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D29170 Offset: 0x1D29271 VA: 0x1D29170
	|-Observer.EmptyOnNextAnonymousObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D291C0 Offset: 0x1D292C1 VA: 0x1D291C0
	|-Observer.EmptyOnNextAnonymousObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D291D0 Offset: 0x1D292D1 VA: 0x1D291D0
	|-Observer.EmptyOnNextAnonymousObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1D29250 Offset: 0x1D29351 VA: 0x1D29250
	|-Observer.EmptyOnNextAnonymousObserver<object>.OnCompleted
	*/
}

// Namespace: 
private class Observer.Subscribe<T> : IObserver<T> // TypeDefIndex: 6577
{
	// Fields
	private readonly Action<T> onNext; // 0x0
	private readonly Action<Exception> onError; // 0x0
	private readonly Action onCompleted; // 0x0
	private int isStopped; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<T> onNext, Action<Exception> onError, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36E4F70 Offset: 0x36E5071 VA: 0x36E4F70
	|-Observer.Subscribe<Pair<int>>..ctor
	|
	|-RVA: 0x36E50E0 Offset: 0x36E51E1 VA: 0x36E50E0
	|-Observer.Subscribe<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x36E5250 Offset: 0x36E5351 VA: 0x36E5250
	|-Observer.Subscribe<ValueTuple<float, int>>..ctor
	|
	|-RVA: 0x36E53C0 Offset: 0x36E54C1 VA: 0x36E53C0
	|-Observer.Subscribe<ValueTuple<float, Int32Enum>>..ctor
	|
	|-RVA: 0x34AB920 Offset: 0x34ABA21 VA: 0x34AB920
	|-Observer.Subscribe<int>..ctor
	|
	|-RVA: 0x34ABA90 Offset: 0x34ABB91 VA: 0x34ABA90
	|-Observer.Subscribe<long>..ctor
	|
	|-RVA: 0x34ABC00 Offset: 0x34ABD01 VA: 0x34ABC00
	|-Observer.Subscribe<object>..ctor
	|
	|-RVA: 0x34ABD70 Offset: 0x34ABE71 VA: 0x34ABD70
	|-Observer.Subscribe<float>..ctor
	|
	|-RVA: 0x34ABEE0 Offset: 0x34ABFE1 VA: 0x34ABEE0
	|-Observer.Subscribe<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36E4FE0 Offset: 0x36E50E1 VA: 0x36E4FE0
	|-Observer.Subscribe<Pair<int>>.OnNext
	|
	|-RVA: 0x36E5150 Offset: 0x36E5251 VA: 0x36E5150
	|-Observer.Subscribe<ValueTuple<object, object>>.OnNext
	|
	|-RVA: 0x36E52C0 Offset: 0x36E53C1 VA: 0x36E52C0
	|-Observer.Subscribe<ValueTuple<float, int>>.OnNext
	|
	|-RVA: 0x36E5430 Offset: 0x36E5531 VA: 0x36E5430
	|-Observer.Subscribe<ValueTuple<float, Int32Enum>>.OnNext
	|
	|-RVA: 0x34AB990 Offset: 0x34ABA91 VA: 0x34AB990
	|-Observer.Subscribe<int>.OnNext
	|
	|-RVA: 0x34ABB00 Offset: 0x34ABC01 VA: 0x34ABB00
	|-Observer.Subscribe<long>.OnNext
	|
	|-RVA: 0x34ABC70 Offset: 0x34ABD71 VA: 0x34ABC70
	|-Observer.Subscribe<object>.OnNext
	|
	|-RVA: 0x34ABDE0 Offset: 0x34ABEE1 VA: 0x34ABDE0
	|-Observer.Subscribe<float>.OnNext
	|
	|-RVA: 0x34ABF50 Offset: 0x34AC051 VA: 0x34ABF50
	|-Observer.Subscribe<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36E5010 Offset: 0x36E5111 VA: 0x36E5010
	|-Observer.Subscribe<Pair<int>>.OnError
	|
	|-RVA: 0x36E5180 Offset: 0x36E5281 VA: 0x36E5180
	|-Observer.Subscribe<ValueTuple<object, object>>.OnError
	|
	|-RVA: 0x36E52F0 Offset: 0x36E53F1 VA: 0x36E52F0
	|-Observer.Subscribe<ValueTuple<float, int>>.OnError
	|
	|-RVA: 0x36E5460 Offset: 0x36E5561 VA: 0x36E5460
	|-Observer.Subscribe<ValueTuple<float, Int32Enum>>.OnError
	|
	|-RVA: 0x34AB9C0 Offset: 0x34ABAC1 VA: 0x34AB9C0
	|-Observer.Subscribe<int>.OnError
	|
	|-RVA: 0x34ABB30 Offset: 0x34ABC31 VA: 0x34ABB30
	|-Observer.Subscribe<long>.OnError
	|
	|-RVA: 0x34ABCA0 Offset: 0x34ABDA1 VA: 0x34ABCA0
	|-Observer.Subscribe<object>.OnError
	|
	|-RVA: 0x34ABE10 Offset: 0x34ABF11 VA: 0x34ABE10
	|-Observer.Subscribe<float>.OnError
	|
	|-RVA: 0x34ABF80 Offset: 0x34AC081 VA: 0x34ABF80
	|-Observer.Subscribe<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36E5090 Offset: 0x36E5191 VA: 0x36E5090
	|-Observer.Subscribe<Pair<int>>.OnCompleted
	|
	|-RVA: 0x36E5200 Offset: 0x36E5301 VA: 0x36E5200
	|-Observer.Subscribe<ValueTuple<object, object>>.OnCompleted
	|
	|-RVA: 0x36E5370 Offset: 0x36E5471 VA: 0x36E5370
	|-Observer.Subscribe<ValueTuple<float, int>>.OnCompleted
	|
	|-RVA: 0x36E54E0 Offset: 0x36E55E1 VA: 0x36E54E0
	|-Observer.Subscribe<ValueTuple<float, Int32Enum>>.OnCompleted
	|
	|-RVA: 0x34ABA40 Offset: 0x34ABB41 VA: 0x34ABA40
	|-Observer.Subscribe<int>.OnCompleted
	|
	|-RVA: 0x34ABBB0 Offset: 0x34ABCB1 VA: 0x34ABBB0
	|-Observer.Subscribe<long>.OnCompleted
	|
	|-RVA: 0x34ABD20 Offset: 0x34ABE21 VA: 0x34ABD20
	|-Observer.Subscribe<object>.OnCompleted
	|
	|-RVA: 0x34ABE90 Offset: 0x34ABF91 VA: 0x34ABE90
	|-Observer.Subscribe<float>.OnCompleted
	|
	|-RVA: 0x34AC000 Offset: 0x34AC101 VA: 0x34AC000
	|-Observer.Subscribe<Unit>.OnCompleted
	*/
}

// Namespace: 
private class Observer.Subscribe_<T> : IObserver<T> // TypeDefIndex: 6578
{
	// Fields
	private readonly Action<Exception> onError; // 0x0
	private readonly Action onCompleted; // 0x0
	private int isStopped; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<Exception> onError, Action onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36E44C0 Offset: 0x36E45C1 VA: 0x36E44C0
	|-Observer.Subscribe_<Pair<int>>..ctor
	|
	|-RVA: 0x36E45F0 Offset: 0x36E46F1 VA: 0x36E45F0
	|-Observer.Subscribe_<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x36E4720 Offset: 0x36E4821 VA: 0x36E4720
	|-Observer.Subscribe_<ValueTuple<float, int>>..ctor
	|
	|-RVA: 0x36E4850 Offset: 0x36E4951 VA: 0x36E4850
	|-Observer.Subscribe_<ValueTuple<float, Int32Enum>>..ctor
	|
	|-RVA: 0x36E4980 Offset: 0x36E4A81 VA: 0x36E4980
	|-Observer.Subscribe_<int>..ctor
	|
	|-RVA: 0x36E4AB0 Offset: 0x36E4BB1 VA: 0x36E4AB0
	|-Observer.Subscribe_<long>..ctor
	|
	|-RVA: 0x36E4BE0 Offset: 0x36E4CE1 VA: 0x36E4BE0
	|-Observer.Subscribe_<object>..ctor
	|
	|-RVA: 0x36E4D10 Offset: 0x36E4E11 VA: 0x36E4D10
	|-Observer.Subscribe_<float>..ctor
	|
	|-RVA: 0x36E4E40 Offset: 0x36E4F41 VA: 0x36E4E40
	|-Observer.Subscribe_<Unit>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36E4510 Offset: 0x36E4611 VA: 0x36E4510
	|-Observer.Subscribe_<Pair<int>>.OnNext
	|
	|-RVA: 0x36E4640 Offset: 0x36E4741 VA: 0x36E4640
	|-Observer.Subscribe_<ValueTuple<object, object>>.OnNext
	|
	|-RVA: 0x36E4770 Offset: 0x36E4871 VA: 0x36E4770
	|-Observer.Subscribe_<ValueTuple<float, int>>.OnNext
	|
	|-RVA: 0x36E48A0 Offset: 0x36E49A1 VA: 0x36E48A0
	|-Observer.Subscribe_<ValueTuple<float, Int32Enum>>.OnNext
	|
	|-RVA: 0x36E49D0 Offset: 0x36E4AD1 VA: 0x36E49D0
	|-Observer.Subscribe_<int>.OnNext
	|
	|-RVA: 0x36E4B00 Offset: 0x36E4C01 VA: 0x36E4B00
	|-Observer.Subscribe_<long>.OnNext
	|
	|-RVA: 0x36E4C30 Offset: 0x36E4D31 VA: 0x36E4C30
	|-Observer.Subscribe_<object>.OnNext
	|
	|-RVA: 0x36E4D60 Offset: 0x36E4E61 VA: 0x36E4D60
	|-Observer.Subscribe_<float>.OnNext
	|
	|-RVA: 0x36E4E90 Offset: 0x36E4F91 VA: 0x36E4E90
	|-Observer.Subscribe_<Unit>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36E4520 Offset: 0x36E4621 VA: 0x36E4520
	|-Observer.Subscribe_<Pair<int>>.OnError
	|
	|-RVA: 0x36E4650 Offset: 0x36E4751 VA: 0x36E4650
	|-Observer.Subscribe_<ValueTuple<object, object>>.OnError
	|
	|-RVA: 0x36E4780 Offset: 0x36E4881 VA: 0x36E4780
	|-Observer.Subscribe_<ValueTuple<float, int>>.OnError
	|
	|-RVA: 0x36E48B0 Offset: 0x36E49B1 VA: 0x36E48B0
	|-Observer.Subscribe_<ValueTuple<float, Int32Enum>>.OnError
	|
	|-RVA: 0x36E49E0 Offset: 0x36E4AE1 VA: 0x36E49E0
	|-Observer.Subscribe_<int>.OnError
	|
	|-RVA: 0x36E4B10 Offset: 0x36E4C11 VA: 0x36E4B10
	|-Observer.Subscribe_<long>.OnError
	|
	|-RVA: 0x36E4C40 Offset: 0x36E4D41 VA: 0x36E4C40
	|-Observer.Subscribe_<object>.OnError
	|
	|-RVA: 0x36E4D70 Offset: 0x36E4E71 VA: 0x36E4D70
	|-Observer.Subscribe_<float>.OnError
	|
	|-RVA: 0x36E4EA0 Offset: 0x36E4FA1 VA: 0x36E4EA0
	|-Observer.Subscribe_<Unit>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36E45A0 Offset: 0x36E46A1 VA: 0x36E45A0
	|-Observer.Subscribe_<Pair<int>>.OnCompleted
	|
	|-RVA: 0x36E46D0 Offset: 0x36E47D1 VA: 0x36E46D0
	|-Observer.Subscribe_<ValueTuple<object, object>>.OnCompleted
	|
	|-RVA: 0x36E4800 Offset: 0x36E4901 VA: 0x36E4800
	|-Observer.Subscribe_<ValueTuple<float, int>>.OnCompleted
	|
	|-RVA: 0x36E4930 Offset: 0x36E4A31 VA: 0x36E4930
	|-Observer.Subscribe_<ValueTuple<float, Int32Enum>>.OnCompleted
	|
	|-RVA: 0x36E4A60 Offset: 0x36E4B61 VA: 0x36E4A60
	|-Observer.Subscribe_<int>.OnCompleted
	|
	|-RVA: 0x36E4B90 Offset: 0x36E4C91 VA: 0x36E4B90
	|-Observer.Subscribe_<long>.OnCompleted
	|
	|-RVA: 0x36E4CC0 Offset: 0x36E4DC1 VA: 0x36E4CC0
	|-Observer.Subscribe_<object>.OnCompleted
	|
	|-RVA: 0x36E4DF0 Offset: 0x36E4EF1 VA: 0x36E4DF0
	|-Observer.Subscribe_<float>.OnCompleted
	|
	|-RVA: 0x36E4F20 Offset: 0x36E5021 VA: 0x36E4F20
	|-Observer.Subscribe_<Unit>.OnCompleted
	*/
}

// Namespace: 
private class Observer.Subscribe<T, TState> : IObserver<T> // TypeDefIndex: 6579
{
	// Fields
	private readonly TState state; // 0x0
	private readonly Action<T, TState> onNext; // 0x0
	private readonly Action<Exception, TState> onError; // 0x0
	private readonly Action<TState> onCompleted; // 0x0
	private int isStopped; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TState state, Action<T, TState> onNext, Action<Exception, TState> onError, Action<TState> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AC050 Offset: 0x34AC151 VA: 0x34AC050
	|-Observer.Subscribe<bool, object>..ctor
	|
	|-RVA: 0x34AC1D0 Offset: 0x34AC2D1 VA: 0x34AC1D0
	|-Observer.Subscribe<object, object>..ctor
	|
	|-RVA: 0x34AC350 Offset: 0x34AC451 VA: 0x34AC350
	|-Observer.Subscribe<Unit, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AC0D0 Offset: 0x34AC1D1 VA: 0x34AC0D0
	|-Observer.Subscribe<bool, object>.OnNext
	|
	|-RVA: 0x34AC250 Offset: 0x34AC351 VA: 0x34AC250
	|-Observer.Subscribe<object, object>.OnNext
	|
	|-RVA: 0x34AC3D0 Offset: 0x34AC4D1 VA: 0x34AC3D0
	|-Observer.Subscribe<Unit, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AC100 Offset: 0x34AC201 VA: 0x34AC100
	|-Observer.Subscribe<bool, object>.OnError
	|
	|-RVA: 0x34AC280 Offset: 0x34AC381 VA: 0x34AC280
	|-Observer.Subscribe<object, object>.OnError
	|
	|-RVA: 0x34AC400 Offset: 0x34AC501 VA: 0x34AC400
	|-Observer.Subscribe<Unit, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AC170 Offset: 0x34AC271 VA: 0x34AC170
	|-Observer.Subscribe<bool, object>.OnCompleted
	|
	|-RVA: 0x34AC2F0 Offset: 0x34AC3F1 VA: 0x34AC2F0
	|-Observer.Subscribe<object, object>.OnCompleted
	|
	|-RVA: 0x34AC470 Offset: 0x34AC571 VA: 0x34AC470
	|-Observer.Subscribe<Unit, object>.OnCompleted
	*/
}

// Namespace: 
private class Observer.Subscribe<T, TState1, TState2> : IObserver<T> // TypeDefIndex: 6580
{
	// Fields
	private readonly TState1 state1; // 0x0
	private readonly TState2 state2; // 0x0
	private readonly Action<T, TState1, TState2> onNext; // 0x0
	private readonly Action<Exception, TState1, TState2> onError; // 0x0
	private readonly Action<TState1, TState2> onCompleted; // 0x0
	private int isStopped; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TState1 state1, TState2 state2, Action<T, TState1, TState2> onNext, Action<Exception, TState1, TState2> onError, Action<TState1, TState2> onCompleted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AC4D0 Offset: 0x34AC5D1 VA: 0x34AC4D0
	|-Observer.Subscribe<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AC570 Offset: 0x34AC671 VA: 0x34AC570
	|-Observer.Subscribe<object, object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AC5A0 Offset: 0x34AC6A1 VA: 0x34AC5A0
	|-Observer.Subscribe<object, object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34AC610 Offset: 0x34AC711 VA: 0x34AC610
	|-Observer.Subscribe<object, object, object>.OnCompleted
	*/
}

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

// Namespace: 
private class Observer.AutoDetachObserver<T> : OperatorObserverBase<T, T> // TypeDefIndex: 6582
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5E7F0 Offset: 0x2F5E8F1 VA: 0x2F5E7F0
	|-Observer.AutoDetachObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5E810 Offset: 0x2F5E911 VA: 0x2F5E810
	|-Observer.AutoDetachObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5E970 Offset: 0x2F5EA71 VA: 0x2F5E970
	|-Observer.AutoDetachObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F5EAB0 Offset: 0x2F5EBB1 VA: 0x2F5EAB0
	|-Observer.AutoDetachObserver<object>.OnCompleted
	*/
}

