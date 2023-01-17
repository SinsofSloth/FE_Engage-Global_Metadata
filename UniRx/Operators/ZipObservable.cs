// Namespace: UniRx.Operators
internal class ZipObservable<TLeft, TRight, TResult> : OperatorObservableBase<TResult> // TypeDefIndex: 7154
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
	|-RVA: 0x3EF8280 Offset: 0x3EF8381 VA: 0x3EF8280
	|-ZipObservable<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF8340 Offset: 0x3EF8441 VA: 0x3EF8340
	|-ZipObservable<object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class ZipObservable<T> : OperatorObservableBase<IList<T>> // TypeDefIndex: 7157
{
	// Fields
	private readonly IObservable<T>[] sources; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T>[] sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF8190 Offset: 0x3EF8291 VA: 0x3EF8190
	|-ZipObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<IList<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF81E0 Offset: 0x3EF82E1 VA: 0x3EF81E0
	|-ZipObservable<object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class ZipObservable<T1, T2, T3, TR> : OperatorObservableBase<TR> // TypeDefIndex: 7159
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private ZipFunc<T1, T2, T3, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, ZipFunc<T1, T2, T3, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF83E0 Offset: 0x3EF84E1 VA: 0x3EF83E0
	|-ZipObservable<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF84D0 Offset: 0x3EF85D1 VA: 0x3EF84D0
	|-ZipObservable<object, object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class ZipObservable<T1, T2, T3, T4, TR> : OperatorObservableBase<TR> // TypeDefIndex: 7161
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private IObservable<T4> source4; // 0x0
	private ZipFunc<T1, T2, T3, T4, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, ZipFunc<T1, T2, T3, T4, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF8570 Offset: 0x3EF8671 VA: 0x3EF8570
	|-ZipObservable<object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF86A0 Offset: 0x3EF87A1 VA: 0x3EF86A0
	|-ZipObservable<object, object, object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class ZipObservable<T1, T2, T3, T4, T5, TR> : OperatorObservableBase<TR> // TypeDefIndex: 7163
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private IObservable<T4> source4; // 0x0
	private IObservable<T5> source5; // 0x0
	private ZipFunc<T1, T2, T3, T4, T5, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, ZipFunc<T1, T2, T3, T4, T5, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF8740 Offset: 0x3EF8841 VA: 0x3EF8740
	|-ZipObservable<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF88A0 Offset: 0x3EF89A1 VA: 0x3EF88A0
	|-ZipObservable<object, object, object, object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class ZipObservable<T1, T2, T3, T4, T5, T6, TR> : OperatorObservableBase<TR> // TypeDefIndex: 7165
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private IObservable<T4> source4; // 0x0
	private IObservable<T5> source5; // 0x0
	private IObservable<T6> source6; // 0x0
	private ZipFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, IObservable<T6> source6, ZipFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF8940 Offset: 0x3EF8A41 VA: 0x3EF8940
	|-ZipObservable<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF8AD0 Offset: 0x3EF8BD1 VA: 0x3EF8AD0
	|-ZipObservable<object, object, object, object, object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class ZipObservable<T1, T2, T3, T4, T5, T6, T7, TR> : OperatorObservableBase<TR> // TypeDefIndex: 7167
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private IObservable<T4> source4; // 0x0
	private IObservable<T5> source5; // 0x0
	private IObservable<T6> source6; // 0x0
	private IObservable<T7> source7; // 0x0
	private ZipFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, IObservable<T6> source6, IObservable<T7> source7, ZipFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF8B70 Offset: 0x3EF8C71 VA: 0x3EF8B70
	|-ZipObservable<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF8D30 Offset: 0x3EF8E31 VA: 0x3EF8D30
	|-ZipObservable<object, object, object, object, object, object, object, object>.SubscribeCore
	*/
}

