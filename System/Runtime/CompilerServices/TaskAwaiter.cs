// Namespace: System.Runtime.CompilerServices
public struct TaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1256
{
	// Fields
	private readonly Task<TResult> m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C32C0 Offset: 0x34C33C1 VA: 0x34C32C0
	|-TaskAwaiter<Nullable<int>>..ctor
	|
	|-RVA: 0x34C33B0 Offset: 0x34C34B1 VA: 0x34C33B0
	|-TaskAwaiter<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x34C34A0 Offset: 0x34C35A1 VA: 0x34C34A0
	|-TaskAwaiter<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x34C3590 Offset: 0x34C3691 VA: 0x34C3590
	|-TaskAwaiter<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x34C36A0 Offset: 0x34C37A1 VA: 0x34C36A0
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x34C37B0 Offset: 0x34C38B1 VA: 0x34C37B0
	|-TaskAwaiter<bool>..ctor
	|
	|-RVA: 0x34C38A0 Offset: 0x34C39A1 VA: 0x34C38A0
	|-TaskAwaiter<int>..ctor
	|
	|-RVA: 0x34C3990 Offset: 0x34C3A91 VA: 0x34C3990
	|-TaskAwaiter<long>..ctor
	|
	|-RVA: 0x34C3A80 Offset: 0x34C3B81 VA: 0x34C3A80
	|-TaskAwaiter<object>..ctor
	|
	|-RVA: 0x34C3B70 Offset: 0x34C3C71 VA: 0x34C3B70
	|-TaskAwaiter<SceneInstance>..ctor
	|
	|-RVA: 0x34C3C60 Offset: 0x34C3D61 VA: 0x34C3C60
	|-TaskAwaiter<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C32D0 Offset: 0x34C33D1 VA: 0x34C32D0
	|-TaskAwaiter<Nullable<int>>.get_IsCompleted
	|
	|-RVA: 0x34C33C0 Offset: 0x34C34C1 VA: 0x34C33C0
	|-TaskAwaiter<ValueTuple<bool, object>>.get_IsCompleted
	|
	|-RVA: 0x34C34B0 Offset: 0x34C35B1 VA: 0x34C34B0
	|-TaskAwaiter<ValueTuple<int, int>>.get_IsCompleted
	|
	|-RVA: 0x34C35A0 Offset: 0x34C36A1 VA: 0x34C35A0
	|-TaskAwaiter<ValueTuple<object, object, int>>.get_IsCompleted
	|
	|-RVA: 0x34C36B0 Offset: 0x34C37B1 VA: 0x34C36B0
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.get_IsCompleted
	|
	|-RVA: 0x34C37C0 Offset: 0x34C38C1 VA: 0x34C37C0
	|-TaskAwaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x34C38B0 Offset: 0x34C39B1 VA: 0x34C38B0
	|-TaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0x34C39A0 Offset: 0x34C3AA1 VA: 0x34C39A0
	|-TaskAwaiter<long>.get_IsCompleted
	|
	|-RVA: 0x34C3A90 Offset: 0x34C3B91 VA: 0x34C3A90
	|-TaskAwaiter<object>.get_IsCompleted
	|-TaskAwaiter<WebRequestStream>.get_IsCompleted
	|-TaskAwaiter<WebResponseStream>.get_IsCompleted
	|
	|-RVA: 0x34C3B80 Offset: 0x34C3C81 VA: 0x34C3B80
	|-TaskAwaiter<SceneInstance>.get_IsCompleted
	|
	|-RVA: 0x34C3C70 Offset: 0x34C3D71 VA: 0x34C3C70
	|-TaskAwaiter<VoidTaskResult>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C32E0 Offset: 0x34C33E1 VA: 0x34C32E0
	|-TaskAwaiter<Nullable<int>>.OnCompleted
	|
	|-RVA: 0x34C33D0 Offset: 0x34C34D1 VA: 0x34C33D0
	|-TaskAwaiter<ValueTuple<bool, object>>.OnCompleted
	|
	|-RVA: 0x34C34C0 Offset: 0x34C35C1 VA: 0x34C34C0
	|-TaskAwaiter<ValueTuple<int, int>>.OnCompleted
	|
	|-RVA: 0x34C35B0 Offset: 0x34C36B1 VA: 0x34C35B0
	|-TaskAwaiter<ValueTuple<object, object, int>>.OnCompleted
	|
	|-RVA: 0x34C36C0 Offset: 0x34C37C1 VA: 0x34C36C0
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.OnCompleted
	|
	|-RVA: 0x34C37D0 Offset: 0x34C38D1 VA: 0x34C37D0
	|-TaskAwaiter<bool>.OnCompleted
	|
	|-RVA: 0x34C38C0 Offset: 0x34C39C1 VA: 0x34C38C0
	|-TaskAwaiter<int>.OnCompleted
	|
	|-RVA: 0x34C39B0 Offset: 0x34C3AB1 VA: 0x34C39B0
	|-TaskAwaiter<long>.OnCompleted
	|
	|-RVA: 0x34C3AA0 Offset: 0x34C3BA1 VA: 0x34C3AA0
	|-TaskAwaiter<object>.OnCompleted
	|
	|-RVA: 0x34C3B90 Offset: 0x34C3C91 VA: 0x34C3B90
	|-TaskAwaiter<SceneInstance>.OnCompleted
	|
	|-RVA: 0x34C3C80 Offset: 0x34C3D81 VA: 0x34C3C80
	|-TaskAwaiter<VoidTaskResult>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C3300 Offset: 0x34C3401 VA: 0x34C3300
	|-TaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|
	|-RVA: 0x34C33F0 Offset: 0x34C34F1 VA: 0x34C33F0
	|-TaskAwaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x34C34E0 Offset: 0x34C35E1 VA: 0x34C34E0
	|-TaskAwaiter<ValueTuple<int, int>>.UnsafeOnCompleted
	|
	|-RVA: 0x34C35D0 Offset: 0x34C36D1 VA: 0x34C35D0
	|-TaskAwaiter<ValueTuple<object, object, int>>.UnsafeOnCompleted
	|
	|-RVA: 0x34C36E0 Offset: 0x34C37E1 VA: 0x34C36E0
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x34C37F0 Offset: 0x34C38F1 VA: 0x34C37F0
	|-TaskAwaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x34C38E0 Offset: 0x34C39E1 VA: 0x34C38E0
	|-TaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x34C39D0 Offset: 0x34C3AD1 VA: 0x34C39D0
	|-TaskAwaiter<long>.UnsafeOnCompleted
	|
	|-RVA: 0x34C3AC0 Offset: 0x34C3BC1 VA: 0x34C3AC0
	|-TaskAwaiter<object>.UnsafeOnCompleted
	|
	|-RVA: 0x34C3BB0 Offset: 0x34C3CB1 VA: 0x34C3BB0
	|-TaskAwaiter<SceneInstance>.UnsafeOnCompleted
	|
	|-RVA: 0x34C3CA0 Offset: 0x34C3DA1 VA: 0x34C3CA0
	|-TaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34C3320 Offset: 0x34C3421 VA: 0x34C3320
	|-TaskAwaiter<Nullable<int>>.GetResult
	|
	|-RVA: 0x34C3410 Offset: 0x34C3511 VA: 0x34C3410
	|-TaskAwaiter<ValueTuple<bool, object>>.GetResult
	|
	|-RVA: 0x34C3500 Offset: 0x34C3601 VA: 0x34C3500
	|-TaskAwaiter<ValueTuple<int, int>>.GetResult
	|
	|-RVA: 0x34C35F0 Offset: 0x34C36F1 VA: 0x34C35F0
	|-TaskAwaiter<ValueTuple<object, object, int>>.GetResult
	|
	|-RVA: 0x34C3700 Offset: 0x34C3801 VA: 0x34C3700
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.GetResult
	|
	|-RVA: 0x34C3810 Offset: 0x34C3911 VA: 0x34C3810
	|-TaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x34C3900 Offset: 0x34C3A01 VA: 0x34C3900
	|-TaskAwaiter<int>.GetResult
	|
	|-RVA: 0x34C39F0 Offset: 0x34C3AF1 VA: 0x34C39F0
	|-TaskAwaiter<long>.GetResult
	|
	|-RVA: 0x34C3AE0 Offset: 0x34C3BE1 VA: 0x34C3AE0
	|-TaskAwaiter<object>.GetResult
	|-TaskAwaiter<WebRequestStream>.GetResult
	|-TaskAwaiter<WebResponseStream>.GetResult
	|
	|-RVA: 0x34C3BD0 Offset: 0x34C3CD1 VA: 0x34C3BD0
	|-TaskAwaiter<SceneInstance>.GetResult
	|
	|-RVA: 0x34C3CC0 Offset: 0x34C3DC1 VA: 0x34C3CC0
	|-TaskAwaiter<VoidTaskResult>.GetResult
	*/
}

