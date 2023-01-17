// Namespace: System.Collections.Generic
[DebuggerDisplayAttribute] // RVA: 0x309E0 Offset: 0x30AE1 VA: 0x309E0
[DebuggerTypeProxyAttribute] // RVA: 0x309E0 Offset: 0x30AE1 VA: 0x309E0
[Serializable]
public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 2416
{
	// Fields
	private T[] _array; // 0x0
	private int _head; // 0x0
	private int _tail; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0
	private object _syncRoot; // 0x0
	private const int MinimumGrow = 4;
	private const int GrowFactor = 200;

	// Properties
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87A70 Offset: 0x2A87B71 VA: 0x2A87A70
	|-Queue<TimeInterval<object>>..ctor
	|
	|-RVA: 0x2A88630 Offset: 0x2A88731 VA: 0x2A88630
	|-Queue<Timestamped<object>>..ctor
	|
	|-RVA: 0x2A892C0 Offset: 0x2A893C1 VA: 0x2A892C0
	|-Queue<ValueTuple<object, float>>..ctor
	|-Queue<ValueTuple<string, float>>..ctor
	|
	|-RVA: 0x2A8B640 Offset: 0x2A8B741 VA: 0x2A8B640
	|-Queue<Action>..ctor
	|-Queue<Collider>..ctor
	|-Queue<GmapSpot>..ctor
	|-Queue<GodBondHolder>..ctor
	|-Queue<IEnumerator>..ctor
	|-Queue<object>..ctor
	|-Queue<WebRequestQueueOperation>..ctor
	|-Queue<CFNetwork.GetProxyData>..ctor
	|-Queue<SaveData.Manager.Task>..ctor
	|
	|-RVA: 0x2A89E80 Offset: 0x2A89F81 VA: 0x2A89E80
	|-Queue<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2A8AB10 Offset: 0x2A8AC11 VA: 0x2A8AB10
	|-Queue<int>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87AC0 Offset: 0x2A87BC1 VA: 0x2A87AC0
	|-Queue<TimeInterval<object>>..ctor
	|
	|-RVA: 0x2A88680 Offset: 0x2A88781 VA: 0x2A88680
	|-Queue<Timestamped<object>>..ctor
	|
	|-RVA: 0x2A89310 Offset: 0x2A89411 VA: 0x2A89310
	|-Queue<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x2A8B690 Offset: 0x2A8B791 VA: 0x2A8B690
	|-Queue<AchieveData>..ctor
	|-Queue<object>..ctor
	|-Queue<Object>..ctor
	|-Queue<string>..ctor
	|-Queue<Transform>..ctor
	|
	|-RVA: 0x2A89ED0 Offset: 0x2A89FD1 VA: 0x2A89ED0
	|-Queue<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2A8AB60 Offset: 0x2A8AC61 VA: 0x2A8AB60
	|-Queue<int>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87BB0 Offset: 0x2A87CB1 VA: 0x2A87BB0
	|-Queue<TimeInterval<object>>..ctor
	|
	|-RVA: 0x2A88770 Offset: 0x2A88871 VA: 0x2A88770
	|-Queue<Timestamped<object>>..ctor
	|
	|-RVA: 0x2A89400 Offset: 0x2A89501 VA: 0x2A89400
	|-Queue<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x2A89FC0 Offset: 0x2A8A0C1 VA: 0x2A89FC0
	|-Queue<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2A8AC50 Offset: 0x2A8AD51 VA: 0x2A8AC50
	|-Queue<int>..ctor
	|
	|-RVA: 0x2A8B780 Offset: 0x2A8B881 VA: 0x2A8B780
	|-Queue<object>..ctor
	|-Queue<string>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87C80 Offset: 0x2A87D81 VA: 0x2A87C80
	|-Queue<TimeInterval<object>>.get_Count
	|
	|-RVA: 0x2A88840 Offset: 0x2A88941 VA: 0x2A88840
	|-Queue<Timestamped<object>>.get_Count
	|
	|-RVA: 0x2A894D0 Offset: 0x2A895D1 VA: 0x2A894D0
	|-Queue<ValueTuple<object, float>>.get_Count
	|-Queue<ValueTuple<string, float>>.get_Count
	|
	|-RVA: 0x2A8B850 Offset: 0x2A8B951 VA: 0x2A8B850
	|-Queue<AchieveData>.get_Count
	|-Queue<Action>.get_Count
	|-Queue<Collider>.get_Count
	|-Queue<GmapSpot>.get_Count
	|-Queue<GodBondHolder>.get_Count
	|-Queue<IEnumerator>.get_Count
	|-Queue<object>.get_Count
	|-Queue<Object>.get_Count
	|-Queue<string>.get_Count
	|-Queue<Transform>.get_Count
	|-Queue<WebRequestQueueOperation>.get_Count
	|-Queue<CFNetwork.GetProxyData>.get_Count
	|-Queue<SaveData.Manager.Task>.get_Count
	|
	|-RVA: 0x2A8A090 Offset: 0x2A8A191 VA: 0x2A8A090
	|-Queue<AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x2A8AD20 Offset: 0x2A8AE21 VA: 0x2A8AD20
	|-Queue<int>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87C90 Offset: 0x2A87D91 VA: 0x2A87C90
	|-Queue<TimeInterval<object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A88850 Offset: 0x2A88951 VA: 0x2A88850
	|-Queue<Timestamped<object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A894E0 Offset: 0x2A895E1 VA: 0x2A894E0
	|-Queue<ValueTuple<object, float>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8A0A0 Offset: 0x2A8A1A1 VA: 0x2A8A0A0
	|-Queue<AsyncOperationHandle>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8AD30 Offset: 0x2A8AE31 VA: 0x2A8AD30
	|-Queue<int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A8B860 Offset: 0x2A8B961 VA: 0x2A8B860
	|-Queue<object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87CA0 Offset: 0x2A87DA1 VA: 0x2A87CA0
	|-Queue<TimeInterval<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A88860 Offset: 0x2A88961 VA: 0x2A88860
	|-Queue<Timestamped<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A894F0 Offset: 0x2A895F1 VA: 0x2A894F0
	|-Queue<ValueTuple<object, float>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8A0B0 Offset: 0x2A8A1B1 VA: 0x2A8A0B0
	|-Queue<AsyncOperationHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8AD40 Offset: 0x2A8AE41 VA: 0x2A8AD40
	|-Queue<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A8B870 Offset: 0x2A8B971 VA: 0x2A8B870
	|-Queue<object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87D30 Offset: 0x2A87E31 VA: 0x2A87D30
	|-Queue<TimeInterval<object>>.Clear
	|
	|-RVA: 0x2A888F0 Offset: 0x2A889F1 VA: 0x2A888F0
	|-Queue<Timestamped<object>>.Clear
	|
	|-RVA: 0x2A89580 Offset: 0x2A89681 VA: 0x2A89580
	|-Queue<ValueTuple<object, float>>.Clear
	|-Queue<ValueTuple<string, float>>.Clear
	|
	|-RVA: 0x2A8B900 Offset: 0x2A8BA01 VA: 0x2A8B900
	|-Queue<AchieveData>.Clear
	|-Queue<Action>.Clear
	|-Queue<Collider>.Clear
	|-Queue<object>.Clear
	|-Queue<string>.Clear
	|-Queue<Transform>.Clear
	|
	|-RVA: 0x2A8A140 Offset: 0x2A8A241 VA: 0x2A8A140
	|-Queue<AsyncOperationHandle>.Clear
	|
	|-RVA: 0x2A8ADD0 Offset: 0x2A8AED1 VA: 0x2A8ADD0
	|-Queue<int>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87DA0 Offset: 0x2A87EA1 VA: 0x2A87DA0
	|-Queue<TimeInterval<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A88960 Offset: 0x2A88A61 VA: 0x2A88960
	|-Queue<Timestamped<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A895F0 Offset: 0x2A896F1 VA: 0x2A895F0
	|-Queue<ValueTuple<object, float>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8A1B0 Offset: 0x2A8A2B1 VA: 0x2A8A1B0
	|-Queue<AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8ADF0 Offset: 0x2A8AEF1 VA: 0x2A8ADF0
	|-Queue<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A8B970 Offset: 0x2A8BA71 VA: 0x2A8B970
	|-Queue<object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A88080 Offset: 0x2A88181 VA: 0x2A88080
	|-Queue<TimeInterval<object>>.Enqueue
	|
	|-RVA: 0x2A88C40 Offset: 0x2A88D41 VA: 0x2A88C40
	|-Queue<Timestamped<object>>.Enqueue
	|
	|-RVA: 0x2A898D0 Offset: 0x2A899D1 VA: 0x2A898D0
	|-Queue<ValueTuple<object, float>>.Enqueue
	|-Queue<ValueTuple<string, float>>.Enqueue
	|
	|-RVA: 0x2A8BC50 Offset: 0x2A8BD51 VA: 0x2A8BC50
	|-Queue<AchieveData>.Enqueue
	|-Queue<Action>.Enqueue
	|-Queue<Collider>.Enqueue
	|-Queue<GmapSpot>.Enqueue
	|-Queue<GodBondHolder>.Enqueue
	|-Queue<IEnumerator>.Enqueue
	|-Queue<object>.Enqueue
	|-Queue<Object>.Enqueue
	|-Queue<string>.Enqueue
	|-Queue<Transform>.Enqueue
	|-Queue<WebRequestQueueOperation>.Enqueue
	|-Queue<CFNetwork.GetProxyData>.Enqueue
	|-Queue<SaveData.Manager.Task>.Enqueue
	|
	|-RVA: 0x2A8A490 Offset: 0x2A8A591 VA: 0x2A8A490
	|-Queue<AsyncOperationHandle>.Enqueue
	|
	|-RVA: 0x2A8B0D0 Offset: 0x2A8B1D1 VA: 0x2A8B0D0
	|-Queue<int>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public Queue.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A88160 Offset: 0x2A88261 VA: 0x2A88160
	|-Queue<TimeInterval<object>>.GetEnumerator
	|
	|-RVA: 0x2A88D40 Offset: 0x2A88E41 VA: 0x2A88D40
	|-Queue<Timestamped<object>>.GetEnumerator
	|
	|-RVA: 0x2A899B0 Offset: 0x2A89AB1 VA: 0x2A899B0
	|-Queue<ValueTuple<object, float>>.GetEnumerator
	|
	|-RVA: 0x2A8A590 Offset: 0x2A8A691 VA: 0x2A8A590
	|-Queue<AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x2A8B190 Offset: 0x2A8B291 VA: 0x2A8B190
	|-Queue<int>.GetEnumerator
	|
	|-RVA: 0x2A8BD20 Offset: 0x2A8BE21 VA: 0x2A8BD20
	|-Queue<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A881C0 Offset: 0x2A882C1 VA: 0x2A881C0
	|-Queue<TimeInterval<object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2A88DB0 Offset: 0x2A88EB1 VA: 0x2A88DB0
	|-Queue<Timestamped<object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2A89A10 Offset: 0x2A89B11 VA: 0x2A89A10
	|-Queue<ValueTuple<object, float>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2A8A600 Offset: 0x2A8A701 VA: 0x2A8A600
	|-Queue<AsyncOperationHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2A8B1F0 Offset: 0x2A8B2F1 VA: 0x2A8B1F0
	|-Queue<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2A8BD80 Offset: 0x2A8BE81 VA: 0x2A8BD80
	|-Queue<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A88240 Offset: 0x2A88341 VA: 0x2A88240
	|-Queue<TimeInterval<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A88E40 Offset: 0x2A88F41 VA: 0x2A88E40
	|-Queue<Timestamped<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A89A90 Offset: 0x2A89B91 VA: 0x2A89A90
	|-Queue<ValueTuple<object, float>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8A690 Offset: 0x2A8A791 VA: 0x2A8A690
	|-Queue<AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8B270 Offset: 0x2A8B371 VA: 0x2A8B270
	|-Queue<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A8BE00 Offset: 0x2A8BF01 VA: 0x2A8BE00
	|-Queue<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A882C0 Offset: 0x2A883C1 VA: 0x2A882C0
	|-Queue<TimeInterval<object>>.Dequeue
	|
	|-RVA: 0x2A88ED0 Offset: 0x2A88FD1 VA: 0x2A88ED0
	|-Queue<Timestamped<object>>.Dequeue
	|
	|-RVA: 0x2A89B10 Offset: 0x2A89C11 VA: 0x2A89B10
	|-Queue<ValueTuple<object, float>>.Dequeue
	|-Queue<ValueTuple<string, float>>.Dequeue
	|
	|-RVA: 0x2A8BE80 Offset: 0x2A8BF81 VA: 0x2A8BE80
	|-Queue<AchieveData>.Dequeue
	|-Queue<Action>.Dequeue
	|-Queue<Collider>.Dequeue
	|-Queue<GmapSpot>.Dequeue
	|-Queue<GodBondHolder>.Dequeue
	|-Queue<IEnumerator>.Dequeue
	|-Queue<object>.Dequeue
	|-Queue<Object>.Dequeue
	|-Queue<string>.Dequeue
	|-Queue<Transform>.Dequeue
	|-Queue<WebRequestQueueOperation>.Dequeue
	|-Queue<CFNetwork.GetProxyData>.Dequeue
	|-Queue<SaveData.Manager.Task>.Dequeue
	|
	|-RVA: 0x2A8A720 Offset: 0x2A8A821 VA: 0x2A8A720
	|-Queue<AsyncOperationHandle>.Dequeue
	|
	|-RVA: 0x2A8B2F0 Offset: 0x2A8B3F1 VA: 0x2A8B2F0
	|-Queue<int>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A88380 Offset: 0x2A88481 VA: 0x2A88380
	|-Queue<TimeInterval<object>>.Peek
	|
	|-RVA: 0x2A88FC0 Offset: 0x2A890C1 VA: 0x2A88FC0
	|-Queue<Timestamped<object>>.Peek
	|
	|-RVA: 0x2A89BD0 Offset: 0x2A89CD1 VA: 0x2A89BD0
	|-Queue<ValueTuple<object, float>>.Peek
	|
	|-RVA: 0x2A8A810 Offset: 0x2A8A911 VA: 0x2A8A810
	|-Queue<AsyncOperationHandle>.Peek
	|
	|-RVA: 0x2A8B3A0 Offset: 0x2A8B4A1 VA: 0x2A8B3A0
	|-Queue<int>.Peek
	|
	|-RVA: 0x2A8BF40 Offset: 0x2A8C041 VA: 0x2A8BF40
	|-Queue<object>.Peek
	|-Queue<string>.Peek
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A883F0 Offset: 0x2A884F1 VA: 0x2A883F0
	|-Queue<TimeInterval<object>>.Contains
	|
	|-RVA: 0x2A89040 Offset: 0x2A89141 VA: 0x2A89040
	|-Queue<Timestamped<object>>.Contains
	|
	|-RVA: 0x2A89C40 Offset: 0x2A89D41 VA: 0x2A89C40
	|-Queue<ValueTuple<object, float>>.Contains
	|
	|-RVA: 0x2A8A890 Offset: 0x2A8A991 VA: 0x2A8A890
	|-Queue<AsyncOperationHandle>.Contains
	|
	|-RVA: 0x2A8BFB0 Offset: 0x2A8C0B1 VA: 0x2A8BFB0
	|-Queue<Collider>.Contains
	|-Queue<object>.Contains
	|
	|-RVA: 0x2A8B410 Offset: 0x2A8B511 VA: 0x2A8B410
	|-Queue<int>.Contains
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A884D0 Offset: 0x2A885D1 VA: 0x2A884D0
	|-Queue<TimeInterval<object>>.SetCapacity
	|
	|-RVA: 0x2A89160 Offset: 0x2A89261 VA: 0x2A89160
	|-Queue<Timestamped<object>>.SetCapacity
	|
	|-RVA: 0x2A89D20 Offset: 0x2A89E21 VA: 0x2A89D20
	|-Queue<ValueTuple<object, float>>.SetCapacity
	|
	|-RVA: 0x2A8A9B0 Offset: 0x2A8AAB1 VA: 0x2A8A9B0
	|-Queue<AsyncOperationHandle>.SetCapacity
	|
	|-RVA: 0x2A8B4E0 Offset: 0x2A8B5E1 VA: 0x2A8B4E0
	|-Queue<int>.SetCapacity
	|
	|-RVA: 0x2A8C080 Offset: 0x2A8C181 VA: 0x2A8C080
	|-Queue<object>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	private void MoveNext(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A885B0 Offset: 0x2A886B1 VA: 0x2A885B0
	|-Queue<TimeInterval<object>>.MoveNext
	|
	|-RVA: 0x2A89240 Offset: 0x2A89341 VA: 0x2A89240
	|-Queue<Timestamped<object>>.MoveNext
	|
	|-RVA: 0x2A89E00 Offset: 0x2A89F01 VA: 0x2A89E00
	|-Queue<ValueTuple<object, float>>.MoveNext
	|
	|-RVA: 0x2A8AA90 Offset: 0x2A8AB91 VA: 0x2A8AA90
	|-Queue<AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x2A8B5C0 Offset: 0x2A8B6C1 VA: 0x2A8B5C0
	|-Queue<int>.MoveNext
	|
	|-RVA: 0x2A8C160 Offset: 0x2A8C261 VA: 0x2A8C160
	|-Queue<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void ThrowForEmptyQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A885D0 Offset: 0x2A886D1 VA: 0x2A885D0
	|-Queue<TimeInterval<object>>.ThrowForEmptyQueue
	|
	|-RVA: 0x2A89260 Offset: 0x2A89361 VA: 0x2A89260
	|-Queue<Timestamped<object>>.ThrowForEmptyQueue
	|
	|-RVA: 0x2A89E20 Offset: 0x2A89F21 VA: 0x2A89E20
	|-Queue<ValueTuple<object, float>>.ThrowForEmptyQueue
	|
	|-RVA: 0x2A8AAB0 Offset: 0x2A8ABB1 VA: 0x2A8AAB0
	|-Queue<AsyncOperationHandle>.ThrowForEmptyQueue
	|
	|-RVA: 0x2A8B5E0 Offset: 0x2A8B6E1 VA: 0x2A8B5E0
	|-Queue<int>.ThrowForEmptyQueue
	|
	|-RVA: 0x2A8C180 Offset: 0x2A8C281 VA: 0x2A8C180
	|-Queue<object>.ThrowForEmptyQueue
	*/
}

