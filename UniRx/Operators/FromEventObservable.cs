// Namespace: UniRx.Operators
internal class FromEventObservable<TDelegate> : OperatorObservableBase<Unit> // TypeDefIndex: 6972
{
	// Fields
	private readonly Func<Action, TDelegate> conversion; // 0x0
	private readonly Action<TDelegate> addHandler; // 0x0
	private readonly Action<TDelegate> removeHandler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<Action, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E2FB0 Offset: 0x33E30B1 VA: 0x33E2FB0
	|-FromEventObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<Unit> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E3050 Offset: 0x33E3151 VA: 0x33E3050
	|-FromEventObservable<object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class FromEventObservable<TDelegate, TEventArgs> : OperatorObservableBase<TEventArgs> // TypeDefIndex: 6974
{
	// Fields
	private readonly Func<Action<TEventArgs>, TDelegate> conversion; // 0x0
	private readonly Action<TDelegate> addHandler; // 0x0
	private readonly Action<TDelegate> removeHandler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<Action<TEventArgs>, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E3130 Offset: 0x33E3231 VA: 0x33E3130
	|-FromEventObservable<object, bool>..ctor
	|
	|-RVA: 0x33E3290 Offset: 0x33E3391 VA: 0x33E3290
	|-FromEventObservable<object, int>..ctor
	|
	|-RVA: 0x33E33F0 Offset: 0x33E34F1 VA: 0x33E33F0
	|-FromEventObservable<object, object>..ctor
	|
	|-RVA: 0x33E3550 Offset: 0x33E3651 VA: 0x33E3550
	|-FromEventObservable<object, float>..ctor
	|
	|-RVA: 0x33E36B0 Offset: 0x33E37B1 VA: 0x33E36B0
	|-FromEventObservable<object, Vector2>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TEventArgs> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E31B0 Offset: 0x33E32B1 VA: 0x33E31B0
	|-FromEventObservable<object, bool>.SubscribeCore
	|
	|-RVA: 0x33E3310 Offset: 0x33E3411 VA: 0x33E3310
	|-FromEventObservable<object, int>.SubscribeCore
	|
	|-RVA: 0x33E3470 Offset: 0x33E3571 VA: 0x33E3470
	|-FromEventObservable<object, object>.SubscribeCore
	|
	|-RVA: 0x33E35D0 Offset: 0x33E36D1 VA: 0x33E35D0
	|-FromEventObservable<object, float>.SubscribeCore
	|
	|-RVA: 0x33E3730 Offset: 0x33E3831 VA: 0x33E3730
	|-FromEventObservable<object, Vector2>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class FromEventObservable : OperatorObservableBase<Unit> // TypeDefIndex: 6976
{
	// Fields
	private readonly Action<Action> addHandler; // 0x18
	private readonly Action<Action> removeHandler; // 0x20

	// Methods

	// RVA: 0x19D04E0 Offset: 0x19D05E1 VA: 0x19D04E0
	public void .ctor(Action<Action> addHandler, Action<Action> removeHandler) { }

	// RVA: 0x19D0570 Offset: 0x19D0671 VA: 0x19D0570 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<Unit> observer, IDisposable cancel) { }
}

// Namespace: UniRx.Operators
internal class FromEventObservable_<T> : OperatorObservableBase<T> // TypeDefIndex: 6978
{
	// Fields
	private readonly Action<Action<T>> addHandler; // 0x0
	private readonly Action<Action<T>> removeHandler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<Action<T>> addHandler, Action<Action<T>> removeHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E2E70 Offset: 0x33E2F71 VA: 0x33E2E70
	|-FromEventObservable_<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E2ED0 Offset: 0x33E2FD1 VA: 0x33E2ED0
	|-FromEventObservable_<object>.SubscribeCore
	*/
}

