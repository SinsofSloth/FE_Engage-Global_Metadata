// Namespace: System.Collections.Generic
[DebuggerDisplayAttribute] // RVA: 0x30950 Offset: 0x30A51 VA: 0x30950
[DebuggerTypeProxyAttribute] // RVA: 0x30950 Offset: 0x30A51 VA: 0x30950
[Serializable]
public class LinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 2413
{
	// Fields
	internal LinkedListNode<T> head; // 0x0
	internal int count; // 0x0
	internal int version; // 0x0
	private object _syncRoot; // 0x0
	private SerializationInfo _siInfo; // 0x0
	private const string VersionName = "Version";
	private const string CountName = "Count";
	private const string ValuesName = "Data";

	// Properties
	public int Count { get; }
	public LinkedListNode<T> First { get; }
	public LinkedListNode<T> Last { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7440 Offset: 0x2AD7541 VA: 0x2AD7440
	|-LinkedList<ValueTuple<object, object>>..ctor
	|-LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>..ctor
	|
	|-RVA: 0x2AD8AB0 Offset: 0x2AD8BB1 VA: 0x2AD8AB0
	|-LinkedList<ValueTuple<object, object, object>>..ctor
	|-LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>..ctor
	|
	|-RVA: 0x2ADB9F0 Offset: 0x2ADBAF1 VA: 0x2ADB9F0
	|-LinkedList<Action>..ctor
	|-LinkedList<CachedCodeEntry>..ctor
	|-LinkedList<object>..ctor
	|-LinkedList<State>..ctor
	|-LinkedList<WeakReference>..ctor
	|-LinkedList<WebConnection>..ctor
	|-LinkedList<WebOperation>..ctor
	|
	|-RVA: 0x2ADA250 Offset: 0x2ADA351 VA: 0x2ADA250
	|-LinkedList<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2ADD000 Offset: 0x2ADD101 VA: 0x2ADD000
	|-LinkedList<TablePair>..ctor
	|
	|-RVA: 0x2ADE670 Offset: 0x2ADE771 VA: 0x2ADE670
	|-LinkedList<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x3AFF0F0 Offset: 0x3AFF1F1 VA: 0x3AFF0F0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7450 Offset: 0x2AD7551 VA: 0x2AD7450
	|-LinkedList<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2AD8AC0 Offset: 0x2AD8BC1 VA: 0x2AD8AC0
	|-LinkedList<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2ADA260 Offset: 0x2ADA361 VA: 0x2ADA260
	|-LinkedList<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2ADBA00 Offset: 0x2ADBB01 VA: 0x2ADBA00
	|-LinkedList<object>..ctor
	|
	|-RVA: 0x2ADD010 Offset: 0x2ADD111 VA: 0x2ADD010
	|-LinkedList<TablePair>..ctor
	|
	|-RVA: 0x2ADE680 Offset: 0x2ADE781 VA: 0x2ADE680
	|-LinkedList<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x3AFF100 Offset: 0x3AFF201 VA: 0x3AFF100
	|-LinkedList<SimpleAnimationPlayable.QueuedState>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7490 Offset: 0x2AD7591 VA: 0x2AD7490
	|-LinkedList<ValueTuple<object, object>>.get_Count
	|-LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>.get_Count
	|
	|-RVA: 0x2AD8B00 Offset: 0x2AD8C01 VA: 0x2AD8B00
	|-LinkedList<ValueTuple<object, object, object>>.get_Count
	|-LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>.get_Count
	|
	|-RVA: 0x2ADA2A0 Offset: 0x2ADA3A1 VA: 0x2ADA2A0
	|-LinkedList<AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x2ADBA40 Offset: 0x2ADBB41 VA: 0x2ADBA40
	|-LinkedList<CachedCodeEntry>.get_Count
	|-LinkedList<object>.get_Count
	|-LinkedList<WebConnection>.get_Count
	|-LinkedList<WebOperation>.get_Count
	|
	|-RVA: 0x2ADD050 Offset: 0x2ADD151 VA: 0x2ADD050
	|-LinkedList<TablePair>.get_Count
	|
	|-RVA: 0x2ADE6C0 Offset: 0x2ADE7C1 VA: 0x2ADE6C0
	|-LinkedList<DelayedActionManager.DelegateInfo>.get_Count
	|
	|-RVA: 0x3AFF140 Offset: 0x3AFF241 VA: 0x3AFF140
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.get_Count
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> get_First() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD74A0 Offset: 0x2AD75A1 VA: 0x2AD74A0
	|-LinkedList<ValueTuple<object, object>>.get_First
	|-LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>.get_First
	|
	|-RVA: 0x2AD8B10 Offset: 0x2AD8C11 VA: 0x2AD8B10
	|-LinkedList<ValueTuple<object, object, object>>.get_First
	|-LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>.get_First
	|
	|-RVA: 0x2ADBA50 Offset: 0x2ADBB51 VA: 0x2ADBA50
	|-LinkedList<Action>.get_First
	|-LinkedList<CachedCodeEntry>.get_First
	|-LinkedList<object>.get_First
	|-LinkedList<State>.get_First
	|-LinkedList<WebConnection>.get_First
	|-LinkedList<WebOperation>.get_First
	|
	|-RVA: 0x2ADA2B0 Offset: 0x2ADA3B1 VA: 0x2ADA2B0
	|-LinkedList<AsyncOperationHandle>.get_First
	|
	|-RVA: 0x2ADD060 Offset: 0x2ADD161 VA: 0x2ADD060
	|-LinkedList<TablePair>.get_First
	|
	|-RVA: 0x2ADE6D0 Offset: 0x2ADE7D1 VA: 0x2ADE6D0
	|-LinkedList<DelayedActionManager.DelegateInfo>.get_First
	|
	|-RVA: 0x3AFF150 Offset: 0x3AFF251 VA: 0x3AFF150
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.get_First
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> get_Last() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD74B0 Offset: 0x2AD75B1 VA: 0x2AD74B0
	|-LinkedList<ValueTuple<object, object>>.get_Last
	|
	|-RVA: 0x2AD8B20 Offset: 0x2AD8C21 VA: 0x2AD8B20
	|-LinkedList<ValueTuple<object, object, object>>.get_Last
	|
	|-RVA: 0x2ADA2C0 Offset: 0x2ADA3C1 VA: 0x2ADA2C0
	|-LinkedList<AsyncOperationHandle>.get_Last
	|
	|-RVA: 0x2ADBA60 Offset: 0x2ADBB61 VA: 0x2ADBA60
	|-LinkedList<object>.get_Last
	|-LinkedList<State>.get_Last
	|
	|-RVA: 0x2ADD070 Offset: 0x2ADD171 VA: 0x2ADD070
	|-LinkedList<TablePair>.get_Last
	|
	|-RVA: 0x2ADE6E0 Offset: 0x2ADE7E1 VA: 0x2ADE6E0
	|-LinkedList<DelayedActionManager.DelegateInfo>.get_Last
	|
	|-RVA: 0x3AFF160 Offset: 0x3AFF261 VA: 0x3AFF160
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.get_Last
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD74D0 Offset: 0x2AD75D1 VA: 0x2AD74D0
	|-LinkedList<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AD8B40 Offset: 0x2AD8C41 VA: 0x2AD8B40
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ADA2E0 Offset: 0x2ADA3E1 VA: 0x2ADA2E0
	|-LinkedList<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ADBA80 Offset: 0x2ADBB81 VA: 0x2ADBA80
	|-LinkedList<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ADD090 Offset: 0x2ADD191 VA: 0x2ADD090
	|-LinkedList<TablePair>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2ADE700 Offset: 0x2ADE801 VA: 0x2ADE700
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3AFF180 Offset: 0x3AFF281 VA: 0x3AFF180
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD74E0 Offset: 0x2AD75E1 VA: 0x2AD74E0
	|-LinkedList<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2AD8B50 Offset: 0x2AD8C51 VA: 0x2AD8B50
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2ADA2F0 Offset: 0x2ADA3F1 VA: 0x2ADA2F0
	|-LinkedList<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2ADBA90 Offset: 0x2ADBB91 VA: 0x2ADBA90
	|-LinkedList<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2ADD0A0 Offset: 0x2ADD1A1 VA: 0x2ADD0A0
	|-LinkedList<TablePair>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2ADE710 Offset: 0x2ADE811 VA: 0x2ADE710
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3AFF190 Offset: 0x3AFF291 VA: 0x3AFF190
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7500 Offset: 0x2AD7601 VA: 0x2AD7500
	|-LinkedList<ValueTuple<object, object>>.AddBefore
	|
	|-RVA: 0x2AD8BA0 Offset: 0x2AD8CA1 VA: 0x2AD8BA0
	|-LinkedList<ValueTuple<object, object, object>>.AddBefore
	|
	|-RVA: 0x2ADA340 Offset: 0x2ADA441 VA: 0x2ADA340
	|-LinkedList<AsyncOperationHandle>.AddBefore
	|
	|-RVA: 0x2ADBAB0 Offset: 0x2ADBBB1 VA: 0x2ADBAB0
	|-LinkedList<object>.AddBefore
	|
	|-RVA: 0x2ADD0C0 Offset: 0x2ADD1C1 VA: 0x2ADD0C0
	|-LinkedList<TablePair>.AddBefore
	|
	|-RVA: 0x2ADE760 Offset: 0x2ADE861 VA: 0x2ADE760
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddBefore
	|
	|-RVA: 0x3AFF1B0 Offset: 0x3AFF2B1 VA: 0x3AFF1B0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.AddBefore
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> AddFirst(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD75C0 Offset: 0x2AD76C1 VA: 0x2AD75C0
	|-LinkedList<ValueTuple<object, object>>.AddFirst
	|
	|-RVA: 0x2AD8C60 Offset: 0x2AD8D61 VA: 0x2AD8C60
	|-LinkedList<ValueTuple<object, object, object>>.AddFirst
	|
	|-RVA: 0x2ADA400 Offset: 0x2ADA501 VA: 0x2ADA400
	|-LinkedList<AsyncOperationHandle>.AddFirst
	|
	|-RVA: 0x2ADBB70 Offset: 0x2ADBC71 VA: 0x2ADBB70
	|-LinkedList<CachedCodeEntry>.AddFirst
	|-LinkedList<object>.AddFirst
	|-LinkedList<State>.AddFirst
	|-LinkedList<WebConnection>.AddFirst
	|
	|-RVA: 0x2ADD180 Offset: 0x2ADD281 VA: 0x2ADD180
	|-LinkedList<TablePair>.AddFirst
	|
	|-RVA: 0x2ADE820 Offset: 0x2ADE921 VA: 0x2ADE820
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddFirst
	|
	|-RVA: 0x3AFF270 Offset: 0x3AFF371 VA: 0x3AFF270
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.AddFirst
	*/

	// RVA: -1 Offset: -1
	public void AddFirst(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD76A0 Offset: 0x2AD77A1 VA: 0x2AD76A0
	|-LinkedList<ValueTuple<object, object>>.AddFirst
	|
	|-RVA: 0x2AD8D50 Offset: 0x2AD8E51 VA: 0x2AD8D50
	|-LinkedList<ValueTuple<object, object, object>>.AddFirst
	|
	|-RVA: 0x2ADA4F0 Offset: 0x2ADA5F1 VA: 0x2ADA4F0
	|-LinkedList<AsyncOperationHandle>.AddFirst
	|
	|-RVA: 0x2ADBC40 Offset: 0x2ADBD41 VA: 0x2ADBC40
	|-LinkedList<CachedCodeEntry>.AddFirst
	|-LinkedList<object>.AddFirst
	|
	|-RVA: 0x2ADD260 Offset: 0x2ADD361 VA: 0x2ADD260
	|-LinkedList<TablePair>.AddFirst
	|
	|-RVA: 0x2ADE910 Offset: 0x2ADEA11 VA: 0x2ADE910
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddFirst
	|
	|-RVA: 0x3AFF350 Offset: 0x3AFF451 VA: 0x3AFF350
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.AddFirst
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> AddLast(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7740 Offset: 0x2AD7841 VA: 0x2AD7740
	|-LinkedList<ValueTuple<object, object>>.AddLast
	|-LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>.AddLast
	|
	|-RVA: 0x2AD8DF0 Offset: 0x2AD8EF1 VA: 0x2AD8DF0
	|-LinkedList<ValueTuple<object, object, object>>.AddLast
	|-LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>.AddLast
	|
	|-RVA: 0x2ADBCE0 Offset: 0x2ADBDE1 VA: 0x2ADBCE0
	|-LinkedList<Action>.AddLast
	|-LinkedList<object>.AddLast
	|-LinkedList<State>.AddLast
	|-LinkedList<WeakReference>.AddLast
	|-LinkedList<WebOperation>.AddLast
	|
	|-RVA: 0x2ADA590 Offset: 0x2ADA691 VA: 0x2ADA590
	|-LinkedList<AsyncOperationHandle>.AddLast
	|
	|-RVA: 0x2ADD300 Offset: 0x2ADD401 VA: 0x2ADD300
	|-LinkedList<TablePair>.AddLast
	|
	|-RVA: 0x2ADE9B0 Offset: 0x2ADEAB1 VA: 0x2ADE9B0
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddLast
	|
	|-RVA: 0x3AFF3F0 Offset: 0x3AFF4F1 VA: 0x3AFF3F0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.AddLast
	*/

	// RVA: -1 Offset: -1
	public void AddLast(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7800 Offset: 0x2AD7901 VA: 0x2AD7800
	|-LinkedList<ValueTuple<object, object>>.AddLast
	|
	|-RVA: 0x2AD8ED0 Offset: 0x2AD8FD1 VA: 0x2AD8ED0
	|-LinkedList<ValueTuple<object, object, object>>.AddLast
	|
	|-RVA: 0x2ADA670 Offset: 0x2ADA771 VA: 0x2ADA670
	|-LinkedList<AsyncOperationHandle>.AddLast
	|
	|-RVA: 0x2ADBD90 Offset: 0x2ADBE91 VA: 0x2ADBD90
	|-LinkedList<object>.AddLast
	|
	|-RVA: 0x2ADD3C0 Offset: 0x2ADD4C1 VA: 0x2ADD3C0
	|-LinkedList<TablePair>.AddLast
	|
	|-RVA: 0x2ADEA90 Offset: 0x2ADEB91 VA: 0x2ADEA90
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddLast
	|
	|-RVA: 0x3AFF4B0 Offset: 0x3AFF5B1 VA: 0x3AFF4B0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.AddLast
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7890 Offset: 0x2AD7991 VA: 0x2AD7890
	|-LinkedList<ValueTuple<object, object>>.Clear
	|
	|-RVA: 0x2AD8F60 Offset: 0x2AD9061 VA: 0x2AD8F60
	|-LinkedList<ValueTuple<object, object, object>>.Clear
	|
	|-RVA: 0x2ADA700 Offset: 0x2ADA801 VA: 0x2ADA700
	|-LinkedList<AsyncOperationHandle>.Clear
	|
	|-RVA: 0x2ADBE20 Offset: 0x2ADBF21 VA: 0x2ADBE20
	|-LinkedList<object>.Clear
	|-LinkedList<State>.Clear
	|
	|-RVA: 0x2ADD450 Offset: 0x2ADD551 VA: 0x2ADD450
	|-LinkedList<TablePair>.Clear
	|
	|-RVA: 0x2ADEB20 Offset: 0x2ADEC21 VA: 0x2ADEB20
	|-LinkedList<DelayedActionManager.DelegateInfo>.Clear
	|
	|-RVA: 0x3AFF540 Offset: 0x3AFF641 VA: 0x3AFF540
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7930 Offset: 0x2AD7A31 VA: 0x2AD7930
	|-LinkedList<ValueTuple<object, object>>.Contains
	|
	|-RVA: 0x2AD9000 Offset: 0x2AD9101 VA: 0x2AD9000
	|-LinkedList<ValueTuple<object, object, object>>.Contains
	|
	|-RVA: 0x2ADA7A0 Offset: 0x2ADA8A1 VA: 0x2ADA7A0
	|-LinkedList<AsyncOperationHandle>.Contains
	|
	|-RVA: 0x2ADBEC0 Offset: 0x2ADBFC1 VA: 0x2ADBEC0
	|-LinkedList<object>.Contains
	|
	|-RVA: 0x2ADD4F0 Offset: 0x2ADD5F1 VA: 0x2ADD4F0
	|-LinkedList<TablePair>.Contains
	|
	|-RVA: 0x2ADEBC0 Offset: 0x2ADECC1 VA: 0x2ADEBC0
	|-LinkedList<DelayedActionManager.DelegateInfo>.Contains
	|
	|-RVA: 0x3AFF5E0 Offset: 0x3AFF6E1 VA: 0x3AFF5E0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7960 Offset: 0x2AD7A61 VA: 0x2AD7960
	|-LinkedList<ValueTuple<object, object>>.CopyTo
	|-LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>.CopyTo
	|
	|-RVA: 0x2AD9050 Offset: 0x2AD9151 VA: 0x2AD9050
	|-LinkedList<ValueTuple<object, object, object>>.CopyTo
	|-LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>.CopyTo
	|
	|-RVA: 0x2ADA7F0 Offset: 0x2ADA8F1 VA: 0x2ADA7F0
	|-LinkedList<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x2ADBEF0 Offset: 0x2ADBFF1 VA: 0x2ADBEF0
	|-LinkedList<object>.CopyTo
	|
	|-RVA: 0x2ADD520 Offset: 0x2ADD621 VA: 0x2ADD520
	|-LinkedList<TablePair>.CopyTo
	|
	|-RVA: 0x2ADEC20 Offset: 0x2ADED21 VA: 0x2ADEC20
	|-LinkedList<DelayedActionManager.DelegateInfo>.CopyTo
	|
	|-RVA: 0x3AFF610 Offset: 0x3AFF711 VA: 0x3AFF610
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> Find(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7B70 Offset: 0x2AD7C71 VA: 0x2AD7B70
	|-LinkedList<ValueTuple<object, object>>.Find
	|
	|-RVA: 0x2AD9290 Offset: 0x2AD9391 VA: 0x2AD9290
	|-LinkedList<ValueTuple<object, object, object>>.Find
	|
	|-RVA: 0x2ADAA30 Offset: 0x2ADAB31 VA: 0x2ADAA30
	|-LinkedList<AsyncOperationHandle>.Find
	|
	|-RVA: 0x2ADC0F0 Offset: 0x2ADC1F1 VA: 0x2ADC0F0
	|-LinkedList<object>.Find
	|
	|-RVA: 0x2ADD730 Offset: 0x2ADD831 VA: 0x2ADD730
	|-LinkedList<TablePair>.Find
	|
	|-RVA: 0x2ADEE50 Offset: 0x2ADEF51 VA: 0x2ADEE50
	|-LinkedList<DelayedActionManager.DelegateInfo>.Find
	|
	|-RVA: 0x3AFF820 Offset: 0x3AFF921 VA: 0x3AFF820
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.Find
	*/

	// RVA: -1 Offset: -1
	public LinkedList.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7C00 Offset: 0x2AD7D01 VA: 0x2AD7C00
	|-LinkedList<ValueTuple<object, object>>.GetEnumerator
	|
	|-RVA: 0x2AD9360 Offset: 0x2AD9461 VA: 0x2AD9360
	|-LinkedList<ValueTuple<object, object, object>>.GetEnumerator
	|
	|-RVA: 0x2ADAB00 Offset: 0x2ADAC01 VA: 0x2ADAB00
	|-LinkedList<AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x2ADC190 Offset: 0x2ADC291 VA: 0x2ADC190
	|-LinkedList<object>.GetEnumerator
	|-LinkedList<State>.GetEnumerator
	|-LinkedList<WebConnection>.GetEnumerator
	|
	|-RVA: 0x2ADD7C0 Offset: 0x2ADD8C1 VA: 0x2ADD7C0
	|-LinkedList<TablePair>.GetEnumerator
	|
	|-RVA: 0x2ADEF20 Offset: 0x2ADF021 VA: 0x2ADEF20
	|-LinkedList<DelayedActionManager.DelegateInfo>.GetEnumerator
	|
	|-RVA: 0x3AFF8B0 Offset: 0x3AFF9B1 VA: 0x3AFF8B0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7C70 Offset: 0x2AD7D71 VA: 0x2AD7C70
	|-LinkedList<ValueTuple<object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AD93D0 Offset: 0x2AD94D1 VA: 0x2AD93D0
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ADAB70 Offset: 0x2ADAC71 VA: 0x2ADAB70
	|-LinkedList<AsyncOperationHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ADC200 Offset: 0x2ADC301 VA: 0x2ADC200
	|-LinkedList<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ADD830 Offset: 0x2ADD931 VA: 0x2ADD830
	|-LinkedList<TablePair>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2ADEF90 Offset: 0x2ADF091 VA: 0x2ADEF90
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3AFF920 Offset: 0x3AFFA21 VA: 0x3AFF920
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7D00 Offset: 0x2AD7E01 VA: 0x2AD7D00
	|-LinkedList<ValueTuple<object, object>>.Remove
	|-LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>.Remove
	|
	|-RVA: 0x2AD9460 Offset: 0x2AD9561 VA: 0x2AD9460
	|-LinkedList<ValueTuple<object, object, object>>.Remove
	|-LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>.Remove
	|
	|-RVA: 0x2ADAC00 Offset: 0x2ADAD01 VA: 0x2ADAC00
	|-LinkedList<AsyncOperationHandle>.Remove
	|
	|-RVA: 0x2ADC290 Offset: 0x2ADC391 VA: 0x2ADC290
	|-LinkedList<object>.Remove
	|-LinkedList<WebConnection>.Remove
	|-LinkedList<WebOperation>.Remove
	|
	|-RVA: 0x2ADD8C0 Offset: 0x2ADD9C1 VA: 0x2ADD8C0
	|-LinkedList<TablePair>.Remove
	|
	|-RVA: 0x2ADF030 Offset: 0x2ADF131 VA: 0x2ADF030
	|-LinkedList<DelayedActionManager.DelegateInfo>.Remove
	|
	|-RVA: 0x3AFF9B0 Offset: 0x3AFFAB1 VA: 0x3AFF9B0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Remove(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7D60 Offset: 0x2AD7E61 VA: 0x2AD7D60
	|-LinkedList<ValueTuple<object, object>>.Remove
	|-LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>.Remove
	|
	|-RVA: 0x2AD94E0 Offset: 0x2AD95E1 VA: 0x2AD94E0
	|-LinkedList<ValueTuple<object, object, object>>.Remove
	|-LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>.Remove
	|
	|-RVA: 0x2ADC2F0 Offset: 0x2ADC3F1 VA: 0x2ADC2F0
	|-LinkedList<Action>.Remove
	|-LinkedList<CachedCodeEntry>.Remove
	|-LinkedList<object>.Remove
	|-LinkedList<State>.Remove
	|-LinkedList<WebConnection>.Remove
	|-LinkedList<WebOperation>.Remove
	|
	|-RVA: 0x2ADAC80 Offset: 0x2ADAD81 VA: 0x2ADAC80
	|-LinkedList<AsyncOperationHandle>.Remove
	|
	|-RVA: 0x2ADD920 Offset: 0x2ADDA21 VA: 0x2ADD920
	|-LinkedList<TablePair>.Remove
	|
	|-RVA: 0x2ADF0B0 Offset: 0x2ADF1B1 VA: 0x2ADF0B0
	|-LinkedList<DelayedActionManager.DelegateInfo>.Remove
	|
	|-RVA: 0x3AFFA10 Offset: 0x3AFFB11 VA: 0x3AFFA10
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.Remove
	*/

	// RVA: -1 Offset: -1
	public void RemoveFirst() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7DC0 Offset: 0x2AD7EC1 VA: 0x2AD7DC0
	|-LinkedList<ValueTuple<object, object>>.RemoveFirst
	|
	|-RVA: 0x2AD9540 Offset: 0x2AD9641 VA: 0x2AD9540
	|-LinkedList<ValueTuple<object, object, object>>.RemoveFirst
	|
	|-RVA: 0x2ADACE0 Offset: 0x2ADADE1 VA: 0x2ADACE0
	|-LinkedList<AsyncOperationHandle>.RemoveFirst
	|
	|-RVA: 0x2ADC350 Offset: 0x2ADC451 VA: 0x2ADC350
	|-LinkedList<object>.RemoveFirst
	|-LinkedList<State>.RemoveFirst
	|
	|-RVA: 0x2ADD980 Offset: 0x2ADDA81 VA: 0x2ADD980
	|-LinkedList<TablePair>.RemoveFirst
	|
	|-RVA: 0x2ADF110 Offset: 0x2ADF211 VA: 0x2ADF110
	|-LinkedList<DelayedActionManager.DelegateInfo>.RemoveFirst
	|
	|-RVA: 0x3AFFA70 Offset: 0x3AFFB71 VA: 0x3AFFA70
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.RemoveFirst
	*/

	// RVA: -1 Offset: -1
	public void RemoveLast() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7E40 Offset: 0x2AD7F41 VA: 0x2AD7E40
	|-LinkedList<ValueTuple<object, object>>.RemoveLast
	|
	|-RVA: 0x2AD95C0 Offset: 0x2AD96C1 VA: 0x2AD95C0
	|-LinkedList<ValueTuple<object, object, object>>.RemoveLast
	|
	|-RVA: 0x2ADAD60 Offset: 0x2ADAE61 VA: 0x2ADAD60
	|-LinkedList<AsyncOperationHandle>.RemoveLast
	|
	|-RVA: 0x2ADC3D0 Offset: 0x2ADC4D1 VA: 0x2ADC3D0
	|-LinkedList<CachedCodeEntry>.RemoveLast
	|-LinkedList<object>.RemoveLast
	|
	|-RVA: 0x2ADDA00 Offset: 0x2ADDB01 VA: 0x2ADDA00
	|-LinkedList<TablePair>.RemoveLast
	|
	|-RVA: 0x2ADF190 Offset: 0x2ADF291 VA: 0x2ADF190
	|-LinkedList<DelayedActionManager.DelegateInfo>.RemoveLast
	|
	|-RVA: 0x3AFFAF0 Offset: 0x3AFFBF1 VA: 0x3AFFAF0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.RemoveLast
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD7EC0 Offset: 0x2AD7FC1 VA: 0x2AD7EC0
	|-LinkedList<ValueTuple<object, object>>.GetObjectData
	|
	|-RVA: 0x2AD9640 Offset: 0x2AD9741 VA: 0x2AD9640
	|-LinkedList<ValueTuple<object, object, object>>.GetObjectData
	|
	|-RVA: 0x2ADADE0 Offset: 0x2ADAEE1 VA: 0x2ADADE0
	|-LinkedList<AsyncOperationHandle>.GetObjectData
	|
	|-RVA: 0x2ADC450 Offset: 0x2ADC551 VA: 0x2ADC450
	|-LinkedList<object>.GetObjectData
	|
	|-RVA: 0x2ADDA80 Offset: 0x2ADDB81 VA: 0x2ADDA80
	|-LinkedList<TablePair>.GetObjectData
	|
	|-RVA: 0x2ADF210 Offset: 0x2ADF311 VA: 0x2ADF210
	|-LinkedList<DelayedActionManager.DelegateInfo>.GetObjectData
	|
	|-RVA: 0x3AFFB70 Offset: 0x3AFFC71 VA: 0x3AFFB70
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD8090 Offset: 0x2AD8191 VA: 0x2AD8090
	|-LinkedList<ValueTuple<object, object>>.OnDeserialization
	|
	|-RVA: 0x2AD9810 Offset: 0x2AD9911 VA: 0x2AD9810
	|-LinkedList<ValueTuple<object, object, object>>.OnDeserialization
	|
	|-RVA: 0x2ADAFB0 Offset: 0x2ADB0B1 VA: 0x2ADAFB0
	|-LinkedList<AsyncOperationHandle>.OnDeserialization
	|
	|-RVA: 0x2ADC620 Offset: 0x2ADC721 VA: 0x2ADC620
	|-LinkedList<object>.OnDeserialization
	|
	|-RVA: 0x2ADDC50 Offset: 0x2ADDD51 VA: 0x2ADDC50
	|-LinkedList<TablePair>.OnDeserialization
	|
	|-RVA: 0x2ADF3E0 Offset: 0x2ADF4E1 VA: 0x2ADF3E0
	|-LinkedList<DelayedActionManager.DelegateInfo>.OnDeserialization
	|
	|-RVA: 0x3AFFD40 Offset: 0x3AFFE41 VA: 0x3AFFD40
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD82D0 Offset: 0x2AD83D1 VA: 0x2AD82D0
	|-LinkedList<ValueTuple<object, object>>.InternalInsertNodeBefore
	|
	|-RVA: 0x2AD9A60 Offset: 0x2AD9B61 VA: 0x2AD9A60
	|-LinkedList<ValueTuple<object, object, object>>.InternalInsertNodeBefore
	|
	|-RVA: 0x2ADB200 Offset: 0x2ADB301 VA: 0x2ADB200
	|-LinkedList<AsyncOperationHandle>.InternalInsertNodeBefore
	|
	|-RVA: 0x2ADC860 Offset: 0x2ADC961 VA: 0x2ADC860
	|-LinkedList<object>.InternalInsertNodeBefore
	|
	|-RVA: 0x2ADDE90 Offset: 0x2ADDF91 VA: 0x2ADDE90
	|-LinkedList<TablePair>.InternalInsertNodeBefore
	|
	|-RVA: 0x2ADF630 Offset: 0x2ADF731 VA: 0x2ADF630
	|-LinkedList<DelayedActionManager.DelegateInfo>.InternalInsertNodeBefore
	|
	|-RVA: 0x3AFFF80 Offset: 0x3B00081 VA: 0x3AFFF80
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.InternalInsertNodeBefore
	*/

	// RVA: -1 Offset: -1
	private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD8350 Offset: 0x2AD8451 VA: 0x2AD8350
	|-LinkedList<ValueTuple<object, object>>.InternalInsertNodeToEmptyList
	|
	|-RVA: 0x2AD9AE0 Offset: 0x2AD9BE1 VA: 0x2AD9AE0
	|-LinkedList<ValueTuple<object, object, object>>.InternalInsertNodeToEmptyList
	|
	|-RVA: 0x2ADB280 Offset: 0x2ADB381 VA: 0x2ADB280
	|-LinkedList<AsyncOperationHandle>.InternalInsertNodeToEmptyList
	|
	|-RVA: 0x2ADC8E0 Offset: 0x2ADC9E1 VA: 0x2ADC8E0
	|-LinkedList<object>.InternalInsertNodeToEmptyList
	|
	|-RVA: 0x2ADDF10 Offset: 0x2ADE011 VA: 0x2ADDF10
	|-LinkedList<TablePair>.InternalInsertNodeToEmptyList
	|
	|-RVA: 0x2ADF6B0 Offset: 0x2ADF7B1 VA: 0x2ADF6B0
	|-LinkedList<DelayedActionManager.DelegateInfo>.InternalInsertNodeToEmptyList
	|
	|-RVA: 0x3B00000 Offset: 0x3B00101 VA: 0x3B00000
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.InternalInsertNodeToEmptyList
	*/

	// RVA: -1 Offset: -1
	internal void InternalRemoveNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD83B0 Offset: 0x2AD84B1 VA: 0x2AD83B0
	|-LinkedList<ValueTuple<object, object>>.InternalRemoveNode
	|
	|-RVA: 0x2AD9B40 Offset: 0x2AD9C41 VA: 0x2AD9B40
	|-LinkedList<ValueTuple<object, object, object>>.InternalRemoveNode
	|
	|-RVA: 0x2ADB2E0 Offset: 0x2ADB3E1 VA: 0x2ADB2E0
	|-LinkedList<AsyncOperationHandle>.InternalRemoveNode
	|
	|-RVA: 0x2ADC940 Offset: 0x2ADCA41 VA: 0x2ADC940
	|-LinkedList<object>.InternalRemoveNode
	|
	|-RVA: 0x2ADDF70 Offset: 0x2ADE071 VA: 0x2ADDF70
	|-LinkedList<TablePair>.InternalRemoveNode
	|
	|-RVA: 0x2ADF710 Offset: 0x2ADF811 VA: 0x2ADF710
	|-LinkedList<DelayedActionManager.DelegateInfo>.InternalRemoveNode
	|
	|-RVA: 0x3B00060 Offset: 0x3B00161 VA: 0x3B00060
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.InternalRemoveNode
	*/

	// RVA: -1 Offset: -1
	internal void ValidateNewNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD8460 Offset: 0x2AD8561 VA: 0x2AD8460
	|-LinkedList<ValueTuple<object, object>>.ValidateNewNode
	|
	|-RVA: 0x2AD9BF0 Offset: 0x2AD9CF1 VA: 0x2AD9BF0
	|-LinkedList<ValueTuple<object, object, object>>.ValidateNewNode
	|
	|-RVA: 0x2ADB390 Offset: 0x2ADB491 VA: 0x2ADB390
	|-LinkedList<AsyncOperationHandle>.ValidateNewNode
	|
	|-RVA: 0x2ADC9F0 Offset: 0x2ADCAF1 VA: 0x2ADC9F0
	|-LinkedList<object>.ValidateNewNode
	|
	|-RVA: 0x2ADE020 Offset: 0x2ADE121 VA: 0x2ADE020
	|-LinkedList<TablePair>.ValidateNewNode
	|
	|-RVA: 0x2ADF7C0 Offset: 0x2ADF8C1 VA: 0x2ADF7C0
	|-LinkedList<DelayedActionManager.DelegateInfo>.ValidateNewNode
	|
	|-RVA: 0x3B00110 Offset: 0x3B00211 VA: 0x3B00110
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.ValidateNewNode
	*/

	// RVA: -1 Offset: -1
	internal void ValidateNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD8500 Offset: 0x2AD8601 VA: 0x2AD8500
	|-LinkedList<ValueTuple<object, object>>.ValidateNode
	|
	|-RVA: 0x2AD9C90 Offset: 0x2AD9D91 VA: 0x2AD9C90
	|-LinkedList<ValueTuple<object, object, object>>.ValidateNode
	|
	|-RVA: 0x2ADB430 Offset: 0x2ADB531 VA: 0x2ADB430
	|-LinkedList<AsyncOperationHandle>.ValidateNode
	|
	|-RVA: 0x2ADCA90 Offset: 0x2ADCB91 VA: 0x2ADCA90
	|-LinkedList<object>.ValidateNode
	|
	|-RVA: 0x2ADE0C0 Offset: 0x2ADE1C1 VA: 0x2ADE0C0
	|-LinkedList<TablePair>.ValidateNode
	|
	|-RVA: 0x2ADF860 Offset: 0x2ADF961 VA: 0x2ADF860
	|-LinkedList<DelayedActionManager.DelegateInfo>.ValidateNode
	|
	|-RVA: 0x3B001B0 Offset: 0x3B002B1 VA: 0x3B001B0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.ValidateNode
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD85B0 Offset: 0x2AD86B1 VA: 0x2AD85B0
	|-LinkedList<ValueTuple<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AD9D40 Offset: 0x2AD9E41 VA: 0x2AD9D40
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2ADB4E0 Offset: 0x2ADB5E1 VA: 0x2ADB4E0
	|-LinkedList<AsyncOperationHandle>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2ADCB40 Offset: 0x2ADCC41 VA: 0x2ADCB40
	|-LinkedList<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2ADE170 Offset: 0x2ADE271 VA: 0x2ADE170
	|-LinkedList<TablePair>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2ADF910 Offset: 0x2ADFA11 VA: 0x2ADF910
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x3B00260 Offset: 0x3B00361 VA: 0x3B00260
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD85C0 Offset: 0x2AD86C1 VA: 0x2AD85C0
	|-LinkedList<ValueTuple<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AD9D50 Offset: 0x2AD9E51 VA: 0x2AD9D50
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2ADB4F0 Offset: 0x2ADB5F1 VA: 0x2ADB4F0
	|-LinkedList<AsyncOperationHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2ADCB50 Offset: 0x2ADCC51 VA: 0x2ADCB50
	|-LinkedList<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2ADE180 Offset: 0x2ADE281 VA: 0x2ADE180
	|-LinkedList<TablePair>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2ADF920 Offset: 0x2ADFA21 VA: 0x2ADF920
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x3B00270 Offset: 0x3B00371 VA: 0x3B00270
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD8650 Offset: 0x2AD8751 VA: 0x2AD8650
	|-LinkedList<ValueTuple<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AD9DE0 Offset: 0x2AD9EE1 VA: 0x2AD9DE0
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2ADB580 Offset: 0x2ADB681 VA: 0x2ADB580
	|-LinkedList<AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2ADCBE0 Offset: 0x2ADCCE1 VA: 0x2ADCBE0
	|-LinkedList<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2ADE210 Offset: 0x2ADE311 VA: 0x2ADE210
	|-LinkedList<TablePair>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2ADF9B0 Offset: 0x2ADFAB1 VA: 0x2ADF9B0
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x3B00300 Offset: 0x3B00401 VA: 0x3B00300
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD8A20 Offset: 0x2AD8B21 VA: 0x2AD8A20
	|-LinkedList<ValueTuple<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ADA1C0 Offset: 0x2ADA2C1 VA: 0x2ADA1C0
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ADB960 Offset: 0x2ADBA61 VA: 0x2ADB960
	|-LinkedList<AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ADCF70 Offset: 0x2ADD071 VA: 0x2ADCF70
	|-LinkedList<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ADE5E0 Offset: 0x2ADE6E1 VA: 0x2ADE5E0
	|-LinkedList<TablePair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2ADFD90 Offset: 0x2ADFE91 VA: 0x2ADFD90
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3B006D0 Offset: 0x3B007D1 VA: 0x3B006D0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.System.Collections.IEnumerable.GetEnumerator
	*/
}

