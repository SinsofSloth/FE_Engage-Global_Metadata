// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public struct AsyncOperationHandle : IEnumerator // TypeDefIndex: 5616
{
	// Fields
	private static bool m_IsWaitingForCompletion; // 0x0
	internal IAsyncOperation m_InternalOp; // 0x0
	private int m_Version; // 0x8
	private string m_LocationName; // 0x10

	// Properties
	internal static bool IsWaitingForCompletion { get; set; }
	internal string LocationName { get; set; }
	public string DebugName { get; }
	private IAsyncOperation InternalOp { get; }
	public bool IsDone { get; }
	public Exception OperationException { get; }
	public float PercentComplete { get; }
	internal int ReferenceCount { get; }
	public object Result { get; }
	public AsyncOperationStatus Status { get; }
	public Task<object> Task { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x36265C0 Offset: 0x36266C1 VA: 0x36265C0
	internal static bool get_IsWaitingForCompletion() { }

	// RVA: 0x3626630 Offset: 0x3626731 VA: 0x3626630
	internal static void set_IsWaitingForCompletion(bool value) { }

	// RVA: 0x36266B0 Offset: 0x36267B1 VA: 0x36266B0
	internal string get_LocationName() { }

	// RVA: 0x36266C0 Offset: 0x36267C1 VA: 0x36266C0
	internal void set_LocationName(string value) { }

	// RVA: 0x36266D0 Offset: 0x36267D1 VA: 0x36266D0
	internal void .ctor(IAsyncOperation op) { }

	// RVA: 0x36267C0 Offset: 0x36268C1 VA: 0x36267C0
	internal void .ctor(IAsyncOperation op, int version) { }

	// RVA: 0x3626800 Offset: 0x3626901 VA: 0x3626800
	internal void .ctor(IAsyncOperation op, string locationName) { }

	// RVA: 0x36268F0 Offset: 0x36269F1 VA: 0x36268F0
	internal void .ctor(IAsyncOperation op, int version, string locationName) { }

	// RVA: 0x3626940 Offset: 0x3626A41 VA: 0x3626940
	internal AsyncOperationHandle Acquire() { }

	// RVA: 0x3626B10 Offset: 0x3626C11 VA: 0x3626B10
	public void add_Completed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x3626BD0 Offset: 0x3626CD1 VA: 0x3626BD0
	public void remove_Completed(Action<AsyncOperationHandle> value) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<T> Convert<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27359A0 Offset: 0x2735AA1 VA: 0x27359A0
	|-AsyncOperationHandle.Convert<IList<AsyncOperationHandle>>
	|-AsyncOperationHandle.Convert<IList<IAssetBundleResource>>
	|-AsyncOperationHandle.Convert<object>
	|
	|-RVA: 0x2735A10 Offset: 0x2735B11 VA: 0x2735A10
	|-AsyncOperationHandle.Convert<SceneInstance>
	*/

	// RVA: 0x3626C90 Offset: 0x3626D91 VA: 0x3626C90
	public bool Equals(AsyncOperationHandle other) { }

	// RVA: 0x3626CC0 Offset: 0x3626DC1 VA: 0x3626CC0
	public string get_DebugName() { }

	// RVA: 0x3626F10 Offset: 0x3627011 VA: 0x3626F10
	public void add_Destroyed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x3626FD0 Offset: 0x36270D1 VA: 0x3626FD0
	public void remove_Destroyed(Action<AsyncOperationHandle> value) { }

	// RVA: 0x3627090 Offset: 0x3627191 VA: 0x3627090
	public void GetDependencies(List<AsyncOperationHandle> deps) { }

	// RVA: 0x3627150 Offset: 0x3627251 VA: 0x3627150 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3626A10 Offset: 0x3626B11 VA: 0x3626A10
	private IAsyncOperation get_InternalOp() { }

	// RVA: 0x3627190 Offset: 0x3627291 VA: 0x3627190
	public bool get_IsDone() { }

	// RVA: 0x3626E40 Offset: 0x3626F41 VA: 0x3626E40
	public bool IsValid() { }

	// RVA: 0x3627300 Offset: 0x3627401 VA: 0x3627300
	public Exception get_OperationException() { }

	// RVA: 0x36273B0 Offset: 0x36274B1 VA: 0x36273B0
	public float get_PercentComplete() { }

	// RVA: 0x3627460 Offset: 0x3627561 VA: 0x3627460
	public DownloadStatus GetDownloadStatus() { }

	// RVA: 0x3627510 Offset: 0x3627611 VA: 0x3627510
	internal DownloadStatus InternalGetDownloadStatus(HashSet<object> visited) { }

	// RVA: 0x3627680 Offset: 0x3627781 VA: 0x3627680
	internal int get_ReferenceCount() { }

	// RVA: 0x3627730 Offset: 0x3627831 VA: 0x3627730
	internal void Release() { }

	// RVA: 0x36277F0 Offset: 0x36278F1 VA: 0x36277F0
	public object get_Result() { }

	// RVA: 0x36278A0 Offset: 0x36279A1 VA: 0x36278A0
	public AsyncOperationStatus get_Status() { }

	// RVA: 0x3627950 Offset: 0x3627A51 VA: 0x3627950
	public Task<object> get_Task() { }

	// RVA: 0x3627A00 Offset: 0x3627B01 VA: 0x3627A00 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x3627AB0 Offset: 0x3627BB1 VA: 0x3627AB0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x3627AD0 Offset: 0x3627BD1 VA: 0x3627AD0 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x3627AE0 Offset: 0x3627BE1 VA: 0x3627AE0
	public object WaitForCompletion() { }

	// RVA: 0x3627EF0 Offset: 0x3627FF1 VA: 0x3627EF0
	private static void .cctor() { }
}

