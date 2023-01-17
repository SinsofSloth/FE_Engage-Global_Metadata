// Namespace: System.Collections.Generic
public sealed class LinkedListNode<T> // TypeDefIndex: 2414
{
	// Fields
	internal LinkedList<T> list; // 0x0
	internal LinkedListNode<T> next; // 0x0
	internal LinkedListNode<T> prev; // 0x0
	internal T item; // 0x0

	// Properties
	public LinkedList<T> List { get; }
	public LinkedListNode<T> Next { get; }
	public LinkedListNode<T> Previous { get; }
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD6930 Offset: 0x2AD6A31 VA: 0x2AD6930
	|-LinkedListNode<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2AD6AC0 Offset: 0x2AD6BC1 VA: 0x2AD6AC0
	|-LinkedListNode<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2AD6C60 Offset: 0x2AD6D61 VA: 0x2AD6C60
	|-LinkedListNode<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2AD6E00 Offset: 0x2AD6F01 VA: 0x2AD6E00
	|-LinkedListNode<object>..ctor
	|
	|-RVA: 0x2AD6F70 Offset: 0x2AD7071 VA: 0x2AD6F70
	|-LinkedListNode<TablePair>..ctor
	|
	|-RVA: 0x2AD7100 Offset: 0x2AD7201 VA: 0x2AD7100
	|-LinkedListNode<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x2AD72B0 Offset: 0x2AD73B1 VA: 0x2AD72B0
	|-LinkedListNode<SimpleAnimationPlayable.QueuedState>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(LinkedList<T> list, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD6980 Offset: 0x2AD6A81 VA: 0x2AD6980
	|-LinkedListNode<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2AD6B00 Offset: 0x2AD6C01 VA: 0x2AD6B00
	|-LinkedListNode<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2AD6CA0 Offset: 0x2AD6DA1 VA: 0x2AD6CA0
	|-LinkedListNode<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2AD6E40 Offset: 0x2AD6F41 VA: 0x2AD6E40
	|-LinkedListNode<object>..ctor
	|
	|-RVA: 0x2AD6FC0 Offset: 0x2AD70C1 VA: 0x2AD6FC0
	|-LinkedListNode<TablePair>..ctor
	|
	|-RVA: 0x2AD7150 Offset: 0x2AD7251 VA: 0x2AD7150
	|-LinkedListNode<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x2AD7300 Offset: 0x2AD7401 VA: 0x2AD7300
	|-LinkedListNode<SimpleAnimationPlayable.QueuedState>..ctor
	*/

	// RVA: -1 Offset: -1
	public LinkedList<T> get_List() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD69E0 Offset: 0x2AD6AE1 VA: 0x2AD69E0
	|-LinkedListNode<ValueTuple<object, object>>.get_List
	|
	|-RVA: 0x2AD6B60 Offset: 0x2AD6C61 VA: 0x2AD6B60
	|-LinkedListNode<ValueTuple<object, object, object>>.get_List
	|
	|-RVA: 0x2AD6D00 Offset: 0x2AD6E01 VA: 0x2AD6D00
	|-LinkedListNode<AsyncOperationHandle>.get_List
	|
	|-RVA: 0x2AD6E90 Offset: 0x2AD6F91 VA: 0x2AD6E90
	|-LinkedListNode<object>.get_List
	|
	|-RVA: 0x2AD7020 Offset: 0x2AD7121 VA: 0x2AD7020
	|-LinkedListNode<TablePair>.get_List
	|
	|-RVA: 0x2AD71B0 Offset: 0x2AD72B1 VA: 0x2AD71B0
	|-LinkedListNode<DelayedActionManager.DelegateInfo>.get_List
	|
	|-RVA: 0x2AD7360 Offset: 0x2AD7461 VA: 0x2AD7360
	|-LinkedListNode<SimpleAnimationPlayable.QueuedState>.get_List
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> get_Next() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD69F0 Offset: 0x2AD6AF1 VA: 0x2AD69F0
	|-LinkedListNode<ValueTuple<object, object>>.get_Next
	|-LinkedListNode<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>.get_Next
	|
	|-RVA: 0x2AD6B70 Offset: 0x2AD6C71 VA: 0x2AD6B70
	|-LinkedListNode<ValueTuple<object, object, object>>.get_Next
	|-LinkedListNode<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>.get_Next
	|
	|-RVA: 0x2AD6EA0 Offset: 0x2AD6FA1 VA: 0x2AD6EA0
	|-LinkedListNode<Action>.get_Next
	|-LinkedListNode<CachedCodeEntry>.get_Next
	|-LinkedListNode<object>.get_Next
	|-LinkedListNode<State>.get_Next
	|-LinkedListNode<WebConnection>.get_Next
	|-LinkedListNode<WebOperation>.get_Next
	|
	|-RVA: 0x2AD6D10 Offset: 0x2AD6E11 VA: 0x2AD6D10
	|-LinkedListNode<AsyncOperationHandle>.get_Next
	|
	|-RVA: 0x2AD7030 Offset: 0x2AD7131 VA: 0x2AD7030
	|-LinkedListNode<TablePair>.get_Next
	|
	|-RVA: 0x2AD71C0 Offset: 0x2AD72C1 VA: 0x2AD71C0
	|-LinkedListNode<DelayedActionManager.DelegateInfo>.get_Next
	|
	|-RVA: 0x2AD7370 Offset: 0x2AD7471 VA: 0x2AD7370
	|-LinkedListNode<SimpleAnimationPlayable.QueuedState>.get_Next
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> get_Previous() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD6A20 Offset: 0x2AD6B21 VA: 0x2AD6A20
	|-LinkedListNode<ValueTuple<object, object>>.get_Previous
	|
	|-RVA: 0x2AD6BA0 Offset: 0x2AD6CA1 VA: 0x2AD6BA0
	|-LinkedListNode<ValueTuple<object, object, object>>.get_Previous
	|
	|-RVA: 0x2AD6D40 Offset: 0x2AD6E41 VA: 0x2AD6D40
	|-LinkedListNode<AsyncOperationHandle>.get_Previous
	|
	|-RVA: 0x2AD6ED0 Offset: 0x2AD6FD1 VA: 0x2AD6ED0
	|-LinkedListNode<object>.get_Previous
	|
	|-RVA: 0x2AD7060 Offset: 0x2AD7161 VA: 0x2AD7060
	|-LinkedListNode<TablePair>.get_Previous
	|
	|-RVA: 0x2AD71F0 Offset: 0x2AD72F1 VA: 0x2AD71F0
	|-LinkedListNode<DelayedActionManager.DelegateInfo>.get_Previous
	|
	|-RVA: 0x2AD73A0 Offset: 0x2AD74A1 VA: 0x2AD73A0
	|-LinkedListNode<SimpleAnimationPlayable.QueuedState>.get_Previous
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD6A50 Offset: 0x2AD6B51 VA: 0x2AD6A50
	|-LinkedListNode<ValueTuple<object, object>>.get_Value
	|-LinkedListNode<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>>.get_Value
	|
	|-RVA: 0x2AD6BD0 Offset: 0x2AD6CD1 VA: 0x2AD6BD0
	|-LinkedListNode<ValueTuple<object, object, object>>.get_Value
	|-LinkedListNode<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>>.get_Value
	|
	|-RVA: 0x2AD6F00 Offset: 0x2AD7001 VA: 0x2AD6F00
	|-LinkedListNode<Action>.get_Value
	|-LinkedListNode<CachedCodeEntry>.get_Value
	|-LinkedListNode<object>.get_Value
	|-LinkedListNode<State>.get_Value
	|-LinkedListNode<WebConnection>.get_Value
	|-LinkedListNode<WebOperation>.get_Value
	|
	|-RVA: 0x2AD6D70 Offset: 0x2AD6E71 VA: 0x2AD6D70
	|-LinkedListNode<AsyncOperationHandle>.get_Value
	|
	|-RVA: 0x2AD7090 Offset: 0x2AD7191 VA: 0x2AD7090
	|-LinkedListNode<TablePair>.get_Value
	|
	|-RVA: 0x2AD7220 Offset: 0x2AD7321 VA: 0x2AD7220
	|-LinkedListNode<DelayedActionManager.DelegateInfo>.get_Value
	|
	|-RVA: 0x2AD73D0 Offset: 0x2AD74D1 VA: 0x2AD73D0
	|-LinkedListNode<SimpleAnimationPlayable.QueuedState>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD6A60 Offset: 0x2AD6B61 VA: 0x2AD6A60
	|-LinkedListNode<ValueTuple<object, object>>.set_Value
	|
	|-RVA: 0x2AD6BF0 Offset: 0x2AD6CF1 VA: 0x2AD6BF0
	|-LinkedListNode<ValueTuple<object, object, object>>.set_Value
	|
	|-RVA: 0x2AD6D90 Offset: 0x2AD6E91 VA: 0x2AD6D90
	|-LinkedListNode<AsyncOperationHandle>.set_Value
	|
	|-RVA: 0x2AD6F10 Offset: 0x2AD7011 VA: 0x2AD6F10
	|-LinkedListNode<object>.set_Value
	|
	|-RVA: 0x2AD70A0 Offset: 0x2AD71A1 VA: 0x2AD70A0
	|-LinkedListNode<TablePair>.set_Value
	|
	|-RVA: 0x2AD7240 Offset: 0x2AD7341 VA: 0x2AD7240
	|-LinkedListNode<DelayedActionManager.DelegateInfo>.set_Value
	|
	|-RVA: 0x2AD73E0 Offset: 0x2AD74E1 VA: 0x2AD73E0
	|-LinkedListNode<SimpleAnimationPlayable.QueuedState>.set_Value
	*/

	// RVA: -1 Offset: -1
	internal void Invalidate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD6A70 Offset: 0x2AD6B71 VA: 0x2AD6A70
	|-LinkedListNode<ValueTuple<object, object>>.Invalidate
	|
	|-RVA: 0x2AD6C10 Offset: 0x2AD6D11 VA: 0x2AD6C10
	|-LinkedListNode<ValueTuple<object, object, object>>.Invalidate
	|
	|-RVA: 0x2AD6DB0 Offset: 0x2AD6EB1 VA: 0x2AD6DB0
	|-LinkedListNode<AsyncOperationHandle>.Invalidate
	|
	|-RVA: 0x2AD6F20 Offset: 0x2AD7021 VA: 0x2AD6F20
	|-LinkedListNode<object>.Invalidate
	|
	|-RVA: 0x2AD70B0 Offset: 0x2AD71B1 VA: 0x2AD70B0
	|-LinkedListNode<TablePair>.Invalidate
	|
	|-RVA: 0x2AD7260 Offset: 0x2AD7361 VA: 0x2AD7260
	|-LinkedListNode<DelayedActionManager.DelegateInfo>.Invalidate
	|
	|-RVA: 0x2AD73F0 Offset: 0x2AD74F1 VA: 0x2AD73F0
	|-LinkedListNode<SimpleAnimationPlayable.QueuedState>.Invalidate
	*/
}

