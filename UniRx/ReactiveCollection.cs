// Namespace: UniRx
[Serializable]
public class ReactiveCollection<T> : Collection<T>, IReactiveCollection<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyReactiveCollection<T>, IDisposable // TypeDefIndex: 6742
{
	// Fields
	private bool isDisposed; // 0x0
	private Subject<int> countChanged; // 0x0
	private Subject<Unit> collectionReset; // 0x0
	private Subject<CollectionAddEvent<T>> collectionAdd; // 0x0
	private Subject<CollectionMoveEvent<T>> collectionMove; // 0x0
	private Subject<CollectionRemoveEvent<T>> collectionRemove; // 0x0
	private Subject<CollectionReplaceEvent<T>> collectionReplace; // 0x0
	private bool disposedValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8E370 Offset: 0x2A8E471 VA: 0x2A8E370
	|-ReactiveCollection<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8E390 Offset: 0x2A8E491 VA: 0x2A8E390
	|-ReactiveCollection<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8E6A0 Offset: 0x2A8E7A1 VA: 0x2A8E6A0
	|-ReactiveCollection<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 34
	protected override void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8E730 Offset: 0x2A8E831 VA: 0x2A8E730
	|-ReactiveCollection<object>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected override void InsertItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8E8C0 Offset: 0x2A8E9C1 VA: 0x2A8E8C0
	|-ReactiveCollection<object>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public void Move(int oldIndex, int newIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8E9C0 Offset: 0x2A8EAC1 VA: 0x2A8E9C0
	|-ReactiveCollection<object>.Move
	*/

	// RVA: -1 Offset: -1 Slot: 51
	protected virtual void MoveItem(int oldIndex, int newIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8E9D0 Offset: 0x2A8EAD1 VA: 0x2A8E9D0
	|-ReactiveCollection<object>.MoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected override void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8EAB0 Offset: 0x2A8EBB1 VA: 0x2A8EAB0
	|-ReactiveCollection<object>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected override void SetItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8EBD0 Offset: 0x2A8ECD1 VA: 0x2A8EBD0
	|-ReactiveCollection<object>.SetItem
	*/

	// RVA: -1 Offset: -1 Slot: 45
	public IObservable<int> ObserveCountChanged(bool notifyCurrentCount = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8ECB0 Offset: 0x2A8EDB1 VA: 0x2A8ECB0
	|-ReactiveCollection<object>.ObserveCountChanged
	*/

	// RVA: -1 Offset: -1 Slot: 49
	public IObservable<Unit> ObserveReset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8EE60 Offset: 0x2A8EF61 VA: 0x2A8EE60
	|-ReactiveCollection<object>.ObserveReset
	*/

	// RVA: -1 Offset: -1 Slot: 44
	public IObservable<CollectionAddEvent<T>> ObserveAdd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8EF60 Offset: 0x2A8F061 VA: 0x2A8EF60
	|-ReactiveCollection<object>.ObserveAdd
	*/

	// RVA: -1 Offset: -1 Slot: 46
	public IObservable<CollectionMoveEvent<T>> ObserveMove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8F050 Offset: 0x2A8F151 VA: 0x2A8F050
	|-ReactiveCollection<object>.ObserveMove
	*/

	// RVA: -1 Offset: -1 Slot: 47
	public IObservable<CollectionRemoveEvent<T>> ObserveRemove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8F140 Offset: 0x2A8F241 VA: 0x2A8F140
	|-ReactiveCollection<object>.ObserveRemove
	*/

	// RVA: -1 Offset: -1 Slot: 48
	public IObservable<CollectionReplaceEvent<T>> ObserveReplace() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8F230 Offset: 0x2A8F331 VA: 0x2A8F230
	|-ReactiveCollection<object>.ObserveReplace
	*/

	// RVA: -1 Offset: -1
	private void DisposeSubject<TSubject>(ref Subject<TSubject> subject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2554480 Offset: 0x2554581 VA: 0x2554480
	|-ReactiveCollection<object>.DisposeSubject<CollectionAddEvent<object>>
	|
	|-RVA: 0x2554550 Offset: 0x2554651 VA: 0x2554550
	|-ReactiveCollection<object>.DisposeSubject<CollectionMoveEvent<object>>
	|
	|-RVA: 0x2554620 Offset: 0x2554721 VA: 0x2554620
	|-ReactiveCollection<object>.DisposeSubject<CollectionRemoveEvent<object>>
	|
	|-RVA: 0x25546F0 Offset: 0x25547F1 VA: 0x25546F0
	|-ReactiveCollection<object>.DisposeSubject<CollectionReplaceEvent<object>>
	|
	|-RVA: 0x25547C0 Offset: 0x25548C1 VA: 0x25547C0
	|-ReactiveCollection<object>.DisposeSubject<int>
	|
	|-RVA: 0x2554890 Offset: 0x2554991 VA: 0x2554890
	|-ReactiveCollection<object>.DisposeSubject<object>
	|
	|-RVA: 0x2554960 Offset: 0x2554A61 VA: 0x2554960
	|-ReactiveCollection<object>.DisposeSubject<Unit>
	*/

	// RVA: -1 Offset: -1 Slot: 52
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8F320 Offset: 0x2A8F421 VA: 0x2A8F320
	|-ReactiveCollection<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 50
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8F410 Offset: 0x2A8F511 VA: 0x2A8F410
	|-ReactiveCollection<object>.Dispose
	*/

	[CompilerGeneratedAttribute] // RVA: 0x171E0 Offset: 0x172E1 VA: 0x171E0
	// RVA: -1 Offset: -1
	private int <ObserveCountChanged>b__11_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A8F430 Offset: 0x2A8F531 VA: 0x2A8F430
	|-ReactiveCollection<object>.<ObserveCountChanged>b__11_0
	*/
}

