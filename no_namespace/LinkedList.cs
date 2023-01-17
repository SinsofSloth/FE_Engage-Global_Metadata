// Namespace: 
[Serializable]
public struct LinkedList.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 2412
{
	// Fields
	private LinkedList<T> _list; // 0x0
	private LinkedListNode<T> _node; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(LinkedList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB0000 Offset: 0x2EB0101 VA: 0x2EB0000
	|-LinkedList.Enumerator<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2EB0CF0 Offset: 0x2EB0DF1 VA: 0x2EB0CF0
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2EB19E0 Offset: 0x2EB1AE1 VA: 0x2EB19E0
	|-LinkedList.Enumerator<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2EB91B0 Offset: 0x2EB92B1 VA: 0x2EB91B0
	|-LinkedList.Enumerator<object>..ctor
	|
	|-RVA: 0x2EBEC60 Offset: 0x2EBED61 VA: 0x2EBEC60
	|-LinkedList.Enumerator<TablePair>..ctor
	|
	|-RVA: 0x2E07F60 Offset: 0x2E08061 VA: 0x2E07F60
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x2E0DAC0 Offset: 0x2E0DBC1 VA: 0x2E0DAC0
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB0050 Offset: 0x2EB0151 VA: 0x2EB0050
	|-LinkedList.Enumerator<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2EB0D40 Offset: 0x2EB0E41 VA: 0x2EB0D40
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2EB1A30 Offset: 0x2EB1B31 VA: 0x2EB1A30
	|-LinkedList.Enumerator<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2EB9200 Offset: 0x2EB9301 VA: 0x2EB9200
	|-LinkedList.Enumerator<object>..ctor
	|
	|-RVA: 0x2EBECB0 Offset: 0x2EBEDB1 VA: 0x2EBECB0
	|-LinkedList.Enumerator<TablePair>..ctor
	|
	|-RVA: 0x2E07FB0 Offset: 0x2E080B1 VA: 0x2E07FB0
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x2E0DB10 Offset: 0x2E0DC11 VA: 0x2E0DB10
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB0090 Offset: 0x2EB0191 VA: 0x2EB0090
	|-LinkedList.Enumerator<ValueTuple<object, object>>.get_Current
	|
	|-RVA: 0x2EB0D80 Offset: 0x2EB0E81 VA: 0x2EB0D80
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.get_Current
	|
	|-RVA: 0x2EB1A70 Offset: 0x2EB1B71 VA: 0x2EB1A70
	|-LinkedList.Enumerator<AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x2EB9240 Offset: 0x2EB9341 VA: 0x2EB9240
	|-LinkedList.Enumerator<object>.get_Current
	|-LinkedList.Enumerator<State>.get_Current
	|-LinkedList.Enumerator<WebConnection>.get_Current
	|
	|-RVA: 0x2EBECF0 Offset: 0x2EBEDF1 VA: 0x2EBECF0
	|-LinkedList.Enumerator<TablePair>.get_Current
	|
	|-RVA: 0x2E07FF0 Offset: 0x2E080F1 VA: 0x2E07FF0
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.get_Current
	|
	|-RVA: 0x2E0DB50 Offset: 0x2E0DC51 VA: 0x2E0DB50
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB00A0 Offset: 0x2EB01A1 VA: 0x2EB00A0
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB0DA0 Offset: 0x2EB0EA1 VA: 0x2EB0DA0
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB1A90 Offset: 0x2EB1B91 VA: 0x2EB1A90
	|-LinkedList.Enumerator<AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB9250 Offset: 0x2EB9351 VA: 0x2EB9250
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBED00 Offset: 0x2EBEE01 VA: 0x2EBED00
	|-LinkedList.Enumerator<TablePair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E08010 Offset: 0x2E08111 VA: 0x2E08010
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0DB60 Offset: 0x2E0DC61 VA: 0x2E0DB60
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB01C0 Offset: 0x2EB02C1 VA: 0x2EB01C0
	|-LinkedList.Enumerator<ValueTuple<object, object>>.MoveNext
	|
	|-RVA: 0x2EB0ED0 Offset: 0x2EB0FD1 VA: 0x2EB0ED0
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.MoveNext
	|
	|-RVA: 0x2EB1BC0 Offset: 0x2EB1CC1 VA: 0x2EB1BC0
	|-LinkedList.Enumerator<AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x2EB9330 Offset: 0x2EB9431 VA: 0x2EB9330
	|-LinkedList.Enumerator<object>.MoveNext
	|-LinkedList.Enumerator<State>.MoveNext
	|-LinkedList.Enumerator<WebConnection>.MoveNext
	|
	|-RVA: 0x2EBEE20 Offset: 0x2EBEF21 VA: 0x2EBEE20
	|-LinkedList.Enumerator<TablePair>.MoveNext
	|
	|-RVA: 0x2E08140 Offset: 0x2E08241 VA: 0x2E08140
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.MoveNext
	|
	|-RVA: 0x2E0DC80 Offset: 0x2E0DD81 VA: 0x2E0DC80
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB0310 Offset: 0x2EB0411 VA: 0x2EB0310
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB1030 Offset: 0x2EB1131 VA: 0x2EB1030
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB1D20 Offset: 0x2EB1E21 VA: 0x2EB1D20
	|-LinkedList.Enumerator<AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB9480 Offset: 0x2EB9581 VA: 0x2EB9480
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EBEF70 Offset: 0x2EBF071 VA: 0x2EBEF70
	|-LinkedList.Enumerator<TablePair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E082A0 Offset: 0x2E083A1 VA: 0x2E082A0
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E0DDD0 Offset: 0x2E0DED1 VA: 0x2E0DDD0
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB03A0 Offset: 0x2EB04A1 VA: 0x2EB03A0
	|-LinkedList.Enumerator<ValueTuple<object, object>>.Dispose
	|
	|-RVA: 0x2EB10D0 Offset: 0x2EB11D1 VA: 0x2EB10D0
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.Dispose
	|
	|-RVA: 0x2EB1DC0 Offset: 0x2EB1EC1 VA: 0x2EB1DC0
	|-LinkedList.Enumerator<AsyncOperationHandle>.Dispose
	|
	|-RVA: 0x2EB9510 Offset: 0x2EB9611 VA: 0x2EB9510
	|-LinkedList.Enumerator<object>.Dispose
	|-LinkedList.Enumerator<State>.Dispose
	|-LinkedList.Enumerator<WebConnection>.Dispose
	|
	|-RVA: 0x2EBF000 Offset: 0x2EBF101 VA: 0x2EBF000
	|-LinkedList.Enumerator<TablePair>.Dispose
	|
	|-RVA: 0x2E08340 Offset: 0x2E08441 VA: 0x2E08340
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.Dispose
	|
	|-RVA: 0x2E0DE60 Offset: 0x2E0DF61 VA: 0x2E0DE60
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB03B0 Offset: 0x2EB04B1 VA: 0x2EB03B0
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x2EB10E0 Offset: 0x2EB11E1 VA: 0x2EB10E0
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x2EB1DD0 Offset: 0x2EB1ED1 VA: 0x2EB1DD0
	|-LinkedList.Enumerator<AsyncOperationHandle>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x2EB9520 Offset: 0x2EB9621 VA: 0x2EB9520
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x2EBF010 Offset: 0x2EBF111 VA: 0x2EBF010
	|-LinkedList.Enumerator<TablePair>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x2E08350 Offset: 0x2E08451 VA: 0x2E08350
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x2E0DE70 Offset: 0x2E0DF71 VA: 0x2E0DE70
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB03F0 Offset: 0x2EB04F1 VA: 0x2EB03F0
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x2EB1120 Offset: 0x2EB1221 VA: 0x2EB1120
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x2EB1E10 Offset: 0x2EB1F11 VA: 0x2EB1E10
	|-LinkedList.Enumerator<AsyncOperationHandle>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x2EB9560 Offset: 0x2EB9661 VA: 0x2EB9560
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x2EBF050 Offset: 0x2EBF151 VA: 0x2EBF050
	|-LinkedList.Enumerator<TablePair>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x2E08390 Offset: 0x2E08491 VA: 0x2E08390
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x2E0DEB0 Offset: 0x2E0DFB1 VA: 0x2E0DEB0
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/
}

