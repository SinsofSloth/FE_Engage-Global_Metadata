// Namespace: UniRx.Operators
internal class AggregateObservable<TSource> : OperatorObservableBase<TSource> // TypeDefIndex: 6854
{
	// Fields
	private readonly IObservable<TSource> source; // 0x0
	private readonly Func<TSource, TSource, TSource> accumulator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, Func<TSource, TSource, TSource> accumulator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6550 Offset: 0x1FF6651 VA: 0x1FF6550
	|-AggregateObservable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TSource> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF65D0 Offset: 0x1FF66D1 VA: 0x1FF65D0
	|-AggregateObservable<object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class AggregateObservable<TSource, TAccumulate> : OperatorObservableBase<TAccumulate> // TypeDefIndex: 6856
{
	// Fields
	private readonly IObservable<TSource> source; // 0x0
	private readonly TAccumulate seed; // 0x0
	private readonly Func<TAccumulate, TSource, TAccumulate> accumulator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF66D0 Offset: 0x1FF67D1 VA: 0x1FF66D0
	|-AggregateObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TAccumulate> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6770 Offset: 0x1FF6871 VA: 0x1FF6770
	|-AggregateObservable<object, object>.SubscribeCore
	*/
}

// Namespace: UniRx.Operators
internal class AggregateObservable<TSource, TAccumulate, TResult> : OperatorObservableBase<TResult> // TypeDefIndex: 6858
{
	// Fields
	private readonly IObservable<TSource> source; // 0x0
	private readonly TAccumulate seed; // 0x0
	private readonly Func<TAccumulate, TSource, TAccumulate> accumulator; // 0x0
	private readonly Func<TAccumulate, TResult> resultSelector; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator, Func<TAccumulate, TResult> resultSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6870 Offset: 0x1FF6971 VA: 0x1FF6870
	|-AggregateObservable<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override IDisposable SubscribeCore(IObserver<TResult> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6920 Offset: 0x1FF6A21 VA: 0x1FF6920
	|-AggregateObservable<object, object, object>.SubscribeCore
	*/
}

