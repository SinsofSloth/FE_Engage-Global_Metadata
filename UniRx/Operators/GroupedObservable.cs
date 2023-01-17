// Namespace: UniRx.Operators
internal class GroupedObservable<TKey, TElement> : IGroupedObservable<TKey, TElement>, IObservable<TElement> // TypeDefIndex: 6979
{
	// Fields
	private readonly TKey key; // 0x0
	private readonly IObservable<TElement> subject; // 0x0
	private readonly RefCountDisposable refCount; // 0x0

	// Properties
	public TKey Key { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A13900 Offset: 0x3A13A01 VA: 0x3A13900
	|-GroupedObservable<object, object>.get_Key
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TKey key, ISubject<TElement> subject, RefCountDisposable refCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A13910 Offset: 0x3A13A11 VA: 0x3A13910
	|-GroupedObservable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IDisposable Subscribe(IObserver<TElement> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A13980 Offset: 0x3A13A81 VA: 0x3A13980
	|-GroupedObservable<object, object>.Subscribe
	*/
}

