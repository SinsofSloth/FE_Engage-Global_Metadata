// Namespace: UniRx.Operators
internal class ZipLatestObservable<TLeft, TRight, TResult> : OperatorObservableBase<TResult> // TypeDefIndex: 7179
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
	|-RVA: 0x3EF6DD0 Offset: 0x3EF6ED1 VA: 0x3EF6DD0
	|-ZipLatestObservable<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF6E90 Offset: 0x3EF6F91 VA: 0x3EF6E90
	|-ZipLatestObservable<object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class ZipLatestObservable<T> : OperatorObservableBase<IList<T>> // TypeDefIndex: 7182
{
	// Fields
	private readonly IObservable<T>[] sources; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T>[] sources) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF6CE0 Offset: 0x3EF6DE1 VA: 0x3EF6CE0
	|-ZipLatestObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<IList<T>> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF6D30 Offset: 0x3EF6E31 VA: 0x3EF6D30
	|-ZipLatestObservable<object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class ZipLatestObservable<T1, T2, T3, TR> : OperatorObservableBase<TR> // TypeDefIndex: 7184
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private ZipLatestFunc<T1, T2, T3, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, ZipLatestFunc<T1, T2, T3, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF6F30 Offset: 0x3EF7031 VA: 0x3EF6F30
	|-ZipLatestObservable<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7020 Offset: 0x3EF7121 VA: 0x3EF7020
	|-ZipLatestObservable<object, object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class ZipLatestObservable<T1, T2, T3, T4, TR> : OperatorObservableBase<TR> // TypeDefIndex: 7186
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private IObservable<T4> source4; // 0x0
	private ZipLatestFunc<T1, T2, T3, T4, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, ZipLatestFunc<T1, T2, T3, T4, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF70C0 Offset: 0x3EF71C1 VA: 0x3EF70C0
	|-ZipLatestObservable<object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF71F0 Offset: 0x3EF72F1 VA: 0x3EF71F0
	|-ZipLatestObservable<object, object, object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class ZipLatestObservable<T1, T2, T3, T4, T5, TR> : OperatorObservableBase<TR> // TypeDefIndex: 7188
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private IObservable<T4> source4; // 0x0
	private IObservable<T5> source5; // 0x0
	private ZipLatestFunc<T1, T2, T3, T4, T5, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, ZipLatestFunc<T1, T2, T3, T4, T5, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7290 Offset: 0x3EF7391 VA: 0x3EF7290
	|-ZipLatestObservable<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF73F0 Offset: 0x3EF74F1 VA: 0x3EF73F0
	|-ZipLatestObservable<object, object, object, object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class ZipLatestObservable<T1, T2, T3, T4, T5, T6, TR> : OperatorObservableBase<TR> // TypeDefIndex: 7190
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private IObservable<T4> source4; // 0x0
	private IObservable<T5> source5; // 0x0
	private IObservable<T6> source6; // 0x0
	private ZipLatestFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, IObservable<T6> source6, ZipLatestFunc<T1, T2, T3, T4, T5, T6, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7490 Offset: 0x3EF7591 VA: 0x3EF7490
	|-ZipLatestObservable<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7620 Offset: 0x3EF7721 VA: 0x3EF7620
	|-ZipLatestObservable<object, object, object, object, object, object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class ZipLatestObservable<T1, T2, T3, T4, T5, T6, T7, TR> : OperatorObservableBase<TR> // TypeDefIndex: 7192
{
	// Fields
	private IObservable<T1> source1; // 0x0
	private IObservable<T2> source2; // 0x0
	private IObservable<T3> source3; // 0x0
	private IObservable<T4> source4; // 0x0
	private IObservable<T5> source5; // 0x0
	private IObservable<T6> source6; // 0x0
	private IObservable<T7> source7; // 0x0
	private ZipLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T1> source1, IObservable<T2> source2, IObservable<T3> source3, IObservable<T4> source4, IObservable<T5> source5, IObservable<T6> source6, IObservable<T7> source7, ZipLatestFunc<T1, T2, T3, T4, T5, T6, T7, TR> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF76C0 Offset: 0x3EF77C1 VA: 0x3EF76C0
	|-ZipLatestObservable<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TR> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7880 Offset: 0x3EF7981 VA: 0x3EF7880
	|-ZipLatestObservable<object, object, object, object, object, object, object, object>.SubscribeCore
	*/
}

