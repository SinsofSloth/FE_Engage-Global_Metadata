// Namespace: UniRx
public class ReadOnlyReactiveProperty<T> : IReadOnlyReactiveProperty<T>, IObservable<T>, IDisposable, IOptimizedObservable<T>, IObserverLinkedList<T>, IObserver<T> // TypeDefIndex: 6769
{
	// Fields
	private static readonly IEqualityComparer<T> defaultEqualityComparer; // 0x0
	private readonly bool distinctUntilChanged; // 0x0
	private bool canPublishValueOnSubscribe; // 0x0
	private bool isDisposed; // 0x0
	private bool isSourceCompleted; // 0x0
	private T latestValue; // 0x0
	private Exception lastException; // 0x0
	private IDisposable sourceConnection; // 0x0
	private ObserverNode<T> root; // 0x0
	private ObserverNode<T> last; // 0x0
	private static readonly Action<object> Callback; // 0x0
	private ReactivePropertyReusablePromise<T> commonPromise; // 0x0
	private Dictionary<CancellationToken, ReactivePropertyReusablePromise<T>> removablePromises; // 0x0

	// Properties
	public T Value { get; }
	public bool HasValue { get; }
	protected virtual IEqualityComparer<T> EqualityComparer { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE6650 Offset: 0x2FE6751 VA: 0x2FE6650
	|-ReadOnlyReactiveProperty<bool>.get_Value
	|
	|-RVA: 0x2FE7E30 Offset: 0x2FE7F31 VA: 0x2FE7E30
	|-ReadOnlyReactiveProperty<object>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool get_HasValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE6660 Offset: 0x2FE6761 VA: 0x2FE6660
	|-ReadOnlyReactiveProperty<bool>.get_HasValue
	|
	|-RVA: 0x2FE7E40 Offset: 0x2FE7F41 VA: 0x2FE7E40
	|-ReadOnlyReactiveProperty<object>.get_HasValue
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected virtual IEqualityComparer<T> get_EqualityComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE6670 Offset: 0x2FE6771 VA: 0x2FE6670
	|-ReadOnlyReactiveProperty<bool>.get_EqualityComparer
	|
	|-RVA: 0x2FE7E50 Offset: 0x2FE7F51 VA: 0x2FE7E50
	|-ReadOnlyReactiveProperty<object>.get_EqualityComparer
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE6720 Offset: 0x2FE6821 VA: 0x2FE6720
	|-ReadOnlyReactiveProperty<bool>..ctor
	|
	|-RVA: 0x2FE7F00 Offset: 0x2FE8001 VA: 0x2FE7F00
	|-ReadOnlyReactiveProperty<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, bool distinctUntilChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE67E0 Offset: 0x2FE68E1 VA: 0x2FE67E0
	|-ReadOnlyReactiveProperty<bool>..ctor
	|
	|-RVA: 0x2FE7FC0 Offset: 0x2FE80C1 VA: 0x2FE7FC0
	|-ReadOnlyReactiveProperty<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, T initialValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE68B0 Offset: 0x2FE69B1 VA: 0x2FE68B0
	|-ReadOnlyReactiveProperty<bool>..ctor
	|
	|-RVA: 0x2FE8090 Offset: 0x2FE8191 VA: 0x2FE8090
	|-ReadOnlyReactiveProperty<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T> source, T initialValue, bool distinctUntilChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE6990 Offset: 0x2FE6A91 VA: 0x2FE6990
	|-ReadOnlyReactiveProperty<bool>..ctor
	|
	|-RVA: 0x2FE8180 Offset: 0x2FE8281 VA: 0x2FE8180
	|-ReadOnlyReactiveProperty<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IDisposable Subscribe(IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE6A80 Offset: 0x2FE6B81 VA: 0x2FE6A80
	|-ReadOnlyReactiveProperty<bool>.Subscribe
	|
	|-RVA: 0x2FE8270 Offset: 0x2FE8371 VA: 0x2FE8270
	|-ReadOnlyReactiveProperty<object>.Subscribe
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE6E80 Offset: 0x2FE6F81 VA: 0x2FE6E80
	|-ReadOnlyReactiveProperty<bool>.Dispose
	|
	|-RVA: 0x2FE8670 Offset: 0x2FE8771 VA: 0x2FE8670
	|-ReadOnlyReactiveProperty<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE6F10 Offset: 0x2FE7011 VA: 0x2FE6F10
	|-ReadOnlyReactiveProperty<bool>.Dispose
	|
	|-RVA: 0x2FE8700 Offset: 0x2FE8801 VA: 0x2FE8700
	|-ReadOnlyReactiveProperty<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void UniRx.IObserverLinkedList<T>.UnsubscribeNode(ObserverNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE7210 Offset: 0x2FE7311 VA: 0x2FE7210
	|-ReadOnlyReactiveProperty<bool>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	|
	|-RVA: 0x2FE8A00 Offset: 0x2FE8B01 VA: 0x2FE8A00
	|-ReadOnlyReactiveProperty<object>.UniRx.IObserverLinkedList<T>.UnsubscribeNode
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.IObserver<T>.OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE73A0 Offset: 0x2FE74A1 VA: 0x2FE73A0
	|-ReadOnlyReactiveProperty<bool>.System.IObserver<T>.OnNext
	|
	|-RVA: 0x2FE8B90 Offset: 0x2FE8C91 VA: 0x2FE8B90
	|-ReadOnlyReactiveProperty<object>.System.IObserver<T>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.IObserver<T>.OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE7540 Offset: 0x2FE7641 VA: 0x2FE7540
	|-ReadOnlyReactiveProperty<bool>.System.IObserver<T>.OnError
	|
	|-RVA: 0x2FE8D40 Offset: 0x2FE8E41 VA: 0x2FE8D40
	|-ReadOnlyReactiveProperty<object>.System.IObserver<T>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.IObserver<T>.OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE75E0 Offset: 0x2FE76E1 VA: 0x2FE75E0
	|-ReadOnlyReactiveProperty<bool>.System.IObserver<T>.OnCompleted
	|
	|-RVA: 0x2FE8DE0 Offset: 0x2FE8EE1 VA: 0x2FE8DE0
	|-ReadOnlyReactiveProperty<object>.System.IObserver<T>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE7620 Offset: 0x2FE7721 VA: 0x2FE7620
	|-ReadOnlyReactiveProperty<bool>.ToString
	|
	|-RVA: 0x2FE8E20 Offset: 0x2FE8F21 VA: 0x2FE8E20
	|-ReadOnlyReactiveProperty<object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool IsRequiredSubscribeOnCurrentThread() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE7670 Offset: 0x2FE7771 VA: 0x2FE7670
	|-ReadOnlyReactiveProperty<bool>.IsRequiredSubscribeOnCurrentThread
	|
	|-RVA: 0x2FE8E90 Offset: 0x2FE8F91 VA: 0x2FE8E90
	|-ReadOnlyReactiveProperty<object>.IsRequiredSubscribeOnCurrentThread
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public UniTask<T> WaitUntilValueChangedAsync(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE7680 Offset: 0x2FE7781 VA: 0x2FE7680
	|-ReadOnlyReactiveProperty<bool>.WaitUntilValueChangedAsync
	|
	|-RVA: 0x2FE8EA0 Offset: 0x2FE8FA1 VA: 0x2FE8EA0
	|-ReadOnlyReactiveProperty<object>.WaitUntilValueChangedAsync
	*/

	// RVA: -1 Offset: -1
	private static void CancelCallback(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE7A00 Offset: 0x2FE7B01 VA: 0x2FE7A00
	|-ReadOnlyReactiveProperty<bool>.CancelCallback
	|
	|-RVA: 0x2FE9220 Offset: 0x2FE9321 VA: 0x2FE9220
	|-ReadOnlyReactiveProperty<object>.CancelCallback
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE7C90 Offset: 0x2FE7D91 VA: 0x2FE7C90
	|-ReadOnlyReactiveProperty<bool>..cctor
	|
	|-RVA: 0x2FE94B0 Offset: 0x2FE95B1 VA: 0x2FE94B0
	|-ReadOnlyReactiveProperty<object>..cctor
	*/
}

