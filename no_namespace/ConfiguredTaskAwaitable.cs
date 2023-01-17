// Namespace: 
public struct ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1259
{
	// Fields
	private readonly Task<TResult> m_task; // 0x0
	private readonly bool m_continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2509F70 Offset: 0x250A071 VA: 0x2509F70
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>..ctor
	|
	|-RVA: 0x250A080 Offset: 0x250A181 VA: 0x250A080
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x250A190 Offset: 0x250A291 VA: 0x250A190
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x250A2A0 Offset: 0x250A3A1 VA: 0x250A2A0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x250A3D0 Offset: 0x250A4D1 VA: 0x250A3D0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x250A500 Offset: 0x250A601 VA: 0x250A500
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>..ctor
	|
	|-RVA: 0x250A610 Offset: 0x250A711 VA: 0x250A610
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>..ctor
	|
	|-RVA: 0x250A720 Offset: 0x250A821 VA: 0x250A720
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long>..ctor
	|
	|-RVA: 0x250A830 Offset: 0x250A931 VA: 0x250A830
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>..ctor
	|
	|-RVA: 0x250A940 Offset: 0x250AA41 VA: 0x250A940
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SceneInstance>..ctor
	|
	|-RVA: 0x250AA50 Offset: 0x250AB51 VA: 0x250AA50
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2509FA0 Offset: 0x250A0A1 VA: 0x2509FA0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.get_IsCompleted
	|
	|-RVA: 0x250A0B0 Offset: 0x250A1B1 VA: 0x250A0B0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, WebOperation>>.get_IsCompleted
	|
	|-RVA: 0x250A1C0 Offset: 0x250A2C1 VA: 0x250A1C0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<int, int>>.get_IsCompleted
	|
	|-RVA: 0x250A2D0 Offset: 0x250A3D1 VA: 0x250A2D0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<WebHeaderCollection, byte[], int>>.get_IsCompleted
	|
	|-RVA: 0x250A400 Offset: 0x250A501 VA: 0x250A400
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.get_IsCompleted
	|
	|-RVA: 0x250A860 Offset: 0x250A961 VA: 0x250A860
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<BufferOffsetSize>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebRequestStream>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebCompletionSource.Result>.get_IsCompleted
	|
	|-RVA: 0x250A530 Offset: 0x250A631 VA: 0x250A530
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x250A640 Offset: 0x250A741 VA: 0x250A640
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0x250A750 Offset: 0x250A851 VA: 0x250A750
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long>.get_IsCompleted
	|
	|-RVA: 0x250A970 Offset: 0x250AA71 VA: 0x250A970
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SceneInstance>.get_IsCompleted
	|
	|-RVA: 0x250AA80 Offset: 0x250AB81 VA: 0x250AA80
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2509FB0 Offset: 0x250A0B1 VA: 0x2509FB0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.OnCompleted
	|
	|-RVA: 0x250A0C0 Offset: 0x250A1C1 VA: 0x250A0C0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.OnCompleted
	|
	|-RVA: 0x250A1D0 Offset: 0x250A2D1 VA: 0x250A1D0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<int, int>>.OnCompleted
	|
	|-RVA: 0x250A2E0 Offset: 0x250A3E1 VA: 0x250A2E0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.OnCompleted
	|
	|-RVA: 0x250A410 Offset: 0x250A511 VA: 0x250A410
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.OnCompleted
	|
	|-RVA: 0x250A540 Offset: 0x250A641 VA: 0x250A540
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.OnCompleted
	|
	|-RVA: 0x250A650 Offset: 0x250A751 VA: 0x250A650
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.OnCompleted
	|
	|-RVA: 0x250A760 Offset: 0x250A861 VA: 0x250A760
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long>.OnCompleted
	|
	|-RVA: 0x250A870 Offset: 0x250A971 VA: 0x250A870
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.OnCompleted
	|
	|-RVA: 0x250A980 Offset: 0x250AA81 VA: 0x250A980
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SceneInstance>.OnCompleted
	|
	|-RVA: 0x250AA90 Offset: 0x250AB91 VA: 0x250AA90
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2509FD0 Offset: 0x250A0D1 VA: 0x2509FD0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|
	|-RVA: 0x250A0E0 Offset: 0x250A1E1 VA: 0x250A0E0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x250A1F0 Offset: 0x250A2F1 VA: 0x250A1F0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<int, int>>.UnsafeOnCompleted
	|
	|-RVA: 0x250A300 Offset: 0x250A401 VA: 0x250A300
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.UnsafeOnCompleted
	|
	|-RVA: 0x250A430 Offset: 0x250A531 VA: 0x250A430
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x250A560 Offset: 0x250A661 VA: 0x250A560
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x250A670 Offset: 0x250A771 VA: 0x250A670
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x250A780 Offset: 0x250A881 VA: 0x250A780
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long>.UnsafeOnCompleted
	|
	|-RVA: 0x250A890 Offset: 0x250A991 VA: 0x250A890
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.UnsafeOnCompleted
	|
	|-RVA: 0x250A9A0 Offset: 0x250AAA1 VA: 0x250A9A0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SceneInstance>.UnsafeOnCompleted
	|
	|-RVA: 0x250AAB0 Offset: 0x250ABB1 VA: 0x250AAB0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2509FF0 Offset: 0x250A0F1 VA: 0x2509FF0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.GetResult
	|
	|-RVA: 0x250A100 Offset: 0x250A201 VA: 0x250A100
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, WebOperation>>.GetResult
	|
	|-RVA: 0x250A210 Offset: 0x250A311 VA: 0x250A210
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<int, int>>.GetResult
	|
	|-RVA: 0x250A320 Offset: 0x250A421 VA: 0x250A320
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<WebHeaderCollection, byte[], int>>.GetResult
	|
	|-RVA: 0x250A450 Offset: 0x250A551 VA: 0x250A450
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.GetResult
	|
	|-RVA: 0x250A8B0 Offset: 0x250A9B1 VA: 0x250A8B0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<BufferOffsetSize>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebRequestStream>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebCompletionSource.Result>.GetResult
	|
	|-RVA: 0x250A580 Offset: 0x250A681 VA: 0x250A580
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x250A690 Offset: 0x250A791 VA: 0x250A690
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.GetResult
	|
	|-RVA: 0x250A7A0 Offset: 0x250A8A1 VA: 0x250A7A0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long>.GetResult
	|
	|-RVA: 0x250A9C0 Offset: 0x250AAC1 VA: 0x250A9C0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SceneInstance>.GetResult
	|
	|-RVA: 0x250AAD0 Offset: 0x250ABD1 VA: 0x250AAD0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.GetResult
	*/
}

