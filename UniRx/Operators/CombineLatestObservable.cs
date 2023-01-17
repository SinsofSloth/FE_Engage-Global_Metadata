// Namespace: UniRx.Operators
internal class CombineLatestObservable<TLeft, TRight, TResult> : OperatorObservableBase<TResult> // TypeDefIndex: 6896
{
	// Fields
	private readonly IObservable<TLeft> left; // 0x0
	private readonly IObservable<TRight> right; // 0x0
	private readonly Func<TLeft, TRight, TResult> selector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TLeft> left, IObservable<TRight> right, Func<TLeft, TRight, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E31B0 Offset: 0x30E32B1 VA: 0x30E31B0
	|-CombineLatestObservable<bool, bool, bool>..ctor
	|
	|-RVA: 0x30E3310 Offset: 0x30E3411 VA: 0x30E3310
	|-CombineLatestObservable<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3270 Offset: 0x30E3371 VA: 0x30E3270
	|-CombineLatestObservable<bool, bool, bool>.SubscribeCore
	|
	|-RVA: 0x30E33D0 Offset: 0x30E34D1 VA: 0x30E33D0
	|-CombineLatestObservable<object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class CombineLatestObservable<T> : OperatorObservableBase<IList<T>> // TypeDefIndex: 6899
{
	// Fields
	private readonly IObservable<T>[] sources; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T>[] sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E2FD0 Offset: 0x30E30D1 VA: 0x30E2FD0
	|-CombineLatestObservable<bool>..ctor
	|
	|-RVA: 0x30E30C0 Offset: 0x30E31C1 VA: 0x30E30C0
	|-CombineLatestObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<IList<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3020 Offset: 0x30E3121 VA: 0x30E3020
	|-CombineLatestObservable<bool>.SubscribeCore
	|
	|-RVA: 0x30E3110 Offset: 0x30E3211 VA: 0x30E3110
	|-CombineLatestObservable<object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class CombineLatestObservable<T1, T2, T3, TR> : OperatorObservableBase<TR> // TypeDefIndex: 6901
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private CombineLatestFunc<T1, T2, T3, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, CombineLatestFunc<T1, T2, T3, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3470 Offset: 0x30E3571 VA: 0x30E3470
	|-CombineLatestObservable<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3560 Offset: 0x30E3661 VA: 0x30E3560
	|-CombineLatestObservable<object, object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class CombineLatestObservable<T1, T2, T3, T4, TR> : OperatorObservableBase<TR> // TypeDefIndex: 6903
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private IObservable<T4> source4; // 0x0
	private CombineLatestFunc<T1, T2, T3, T4, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, CombineLatestFunc<T1, T2, T3, T4, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3600 Offset: 0x30E3701 VA: 0x30E3600
	|-CombineLatestObservable<object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3730 Offset: 0x30E3831 VA: 0x30E3730
	|-CombineLatestObservable<object, object, object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class CombineLatestObservable<T1, T2, T3, T4, T5, TR> : OperatorObservableBase<TR> // TypeDefIndex: 6905
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private IObservable<T4> source4; // 0x0
	private IObservable<T5> source5; // 0x0
	private CombineLatestFunc<T1, T2, T3, T4, T5, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, CombineLatestFunc<T1, T2, T3, T4, T5, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E37D0 Offset: 0x30E38D1 VA: 0x30E37D0
	|-CombineLatestObservable<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3930 Offset: 0x30E3A31 VA: 0x30E3930
	|-CombineLatestObservable<object, object, object, object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class CombineLatestObservable<T1, T2, T3, T4, T5, T6, TR> : OperatorObservableBase<TR> // TypeDefIndex: 6907
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private IObservable<T4> source4; // 0x0
	private IObservable<T5> source5; // 0x0
	private IObservable<T6> source6; // 0x0
	private CombineLatestFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, IObservable<T6> source6, CombineLatestFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E39D0 Offset: 0x30E3AD1 VA: 0x30E39D0
	|-CombineLatestObservable<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3B60 Offset: 0x30E3C61 VA: 0x30E3B60
	|-CombineLatestObservable<object, object, object, object, object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class CombineLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> : OperatorObservableBase<TR> // TypeDefIndex: 6909
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private IObservable<T4> source4; // 0x0
	private IObservable<T5> source5; // 0x0
	private IObservable<T6> source6; // 0x0
	private IObservable<T7> source7; // 0x0
	private CombineLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, IObservable<T6> source6, IObservable<T7> source7, CombineLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3C00 Offset: 0x30E3D01 VA: 0x30E3C00
	|-CombineLatestObservable<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E3DC0 Offset: 0x30E3EC1 VA: 0x30E3DC0
	|-CombineLatestObservable<object, object, object, object, object, object, object, object>.SubscribeCore
	*/
}

