// Namespace: UnityEngine.ResourceManagement
internal class ChainOperationTypelessDepedency<TObject> : AsyncOperationBase<TObject> // TypeDefIndex: 5539
{
	// Fields
	private AsyncOperationHandle m_DepOp; // 0x0
	private AsyncOperationHandle<TObject> m_WrappedOp; // 0x0
	private DownloadStatus m_depStatus; // 0x0
	private DownloadStatus m_wrapStatus; // 0x0
	private Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> m_Callback; // 0x0
	private Action<AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted; // 0x0
	private bool m_ReleaseDependenciesOnFailure; // 0x0

	// Properties
	protected override string DebugName { get; }
	protected override float Progress { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D37C0 Offset: 0x30D38C1 VA: 0x30D37C0
	|-ChainOperationTypelessDepedency<bool>..ctor
	|
	|-RVA: 0x30D4100 Offset: 0x30D4201 VA: 0x30D4100
	|-ChainOperationTypelessDepedency<long>..ctor
	|
	|-RVA: 0x30D4A40 Offset: 0x30D4B41 VA: 0x30D4A40
	|-ChainOperationTypelessDepedency<object>..ctor
	|
	|-RVA: 0x30D5380 Offset: 0x30D5481 VA: 0x30D5380
	|-ChainOperationTypelessDepedency<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D3860 Offset: 0x30D3961 VA: 0x30D3860
	|-ChainOperationTypelessDepedency<bool>.get_DebugName
	|
	|-RVA: 0x30D41A0 Offset: 0x30D42A1 VA: 0x30D41A0
	|-ChainOperationTypelessDepedency<long>.get_DebugName
	|
	|-RVA: 0x30D4AE0 Offset: 0x30D4BE1 VA: 0x30D4AE0
	|-ChainOperationTypelessDepedency<object>.get_DebugName
	|
	|-RVA: 0x30D5420 Offset: 0x30D5521 VA: 0x30D5420
	|-ChainOperationTypelessDepedency<SceneInstance>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D3940 Offset: 0x30D3A41 VA: 0x30D3940
	|-ChainOperationTypelessDepedency<bool>.GetDependencies
	|
	|-RVA: 0x30D4280 Offset: 0x30D4381 VA: 0x30D4280
	|-ChainOperationTypelessDepedency<long>.GetDependencies
	|
	|-RVA: 0x30D4BC0 Offset: 0x30D4CC1 VA: 0x30D4BC0
	|-ChainOperationTypelessDepedency<object>.GetDependencies
	|
	|-RVA: 0x30D5500 Offset: 0x30D5601 VA: 0x30D5500
	|-ChainOperationTypelessDepedency<SceneInstance>.GetDependencies
	*/

	// RVA: -1 Offset: -1
	public void Init(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D39D0 Offset: 0x30D3AD1 VA: 0x30D39D0
	|-ChainOperationTypelessDepedency<bool>.Init
	|
	|-RVA: 0x30D4310 Offset: 0x30D4411 VA: 0x30D4310
	|-ChainOperationTypelessDepedency<long>.Init
	|
	|-RVA: 0x30D4C50 Offset: 0x30D4D51 VA: 0x30D4C50
	|-ChainOperationTypelessDepedency<object>.Init
	|
	|-RVA: 0x30D5590 Offset: 0x30D5691 VA: 0x30D5590
	|-ChainOperationTypelessDepedency<SceneInstance>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D3A80 Offset: 0x30D3B81 VA: 0x30D3A80
	|-ChainOperationTypelessDepedency<bool>.InvokeWaitForCompletion
	|
	|-RVA: 0x30D43C0 Offset: 0x30D44C1 VA: 0x30D43C0
	|-ChainOperationTypelessDepedency<long>.InvokeWaitForCompletion
	|
	|-RVA: 0x30D4D00 Offset: 0x30D4E01 VA: 0x30D4D00
	|-ChainOperationTypelessDepedency<object>.InvokeWaitForCompletion
	|
	|-RVA: 0x30D5640 Offset: 0x30D5741 VA: 0x30D5640
	|-ChainOperationTypelessDepedency<SceneInstance>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D3B70 Offset: 0x30D3C71 VA: 0x30D3B70
	|-ChainOperationTypelessDepedency<bool>.Execute
	|
	|-RVA: 0x30D44B0 Offset: 0x30D45B1 VA: 0x30D44B0
	|-ChainOperationTypelessDepedency<long>.Execute
	|
	|-RVA: 0x30D4DF0 Offset: 0x30D4EF1 VA: 0x30D4DF0
	|-ChainOperationTypelessDepedency<object>.Execute
	|
	|-RVA: 0x30D5730 Offset: 0x30D5831 VA: 0x30D5730
	|-ChainOperationTypelessDepedency<SceneInstance>.Execute
	*/

	// RVA: -1 Offset: -1
	private void OnWrappedCompleted(AsyncOperationHandle<TObject> x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D3C30 Offset: 0x30D3D31 VA: 0x30D3C30
	|-ChainOperationTypelessDepedency<bool>.OnWrappedCompleted
	|
	|-RVA: 0x30D4570 Offset: 0x30D4671 VA: 0x30D4570
	|-ChainOperationTypelessDepedency<long>.OnWrappedCompleted
	|
	|-RVA: 0x30D4EB0 Offset: 0x30D4FB1 VA: 0x30D4EB0
	|-ChainOperationTypelessDepedency<object>.OnWrappedCompleted
	|
	|-RVA: 0x30D57F0 Offset: 0x30D58F1 VA: 0x30D57F0
	|-ChainOperationTypelessDepedency<SceneInstance>.OnWrappedCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D3D50 Offset: 0x30D3E51 VA: 0x30D3D50
	|-ChainOperationTypelessDepedency<bool>.Destroy
	|
	|-RVA: 0x30D4690 Offset: 0x30D4791 VA: 0x30D4690
	|-ChainOperationTypelessDepedency<long>.Destroy
	|
	|-RVA: 0x30D4FD0 Offset: 0x30D50D1 VA: 0x30D4FD0
	|-ChainOperationTypelessDepedency<object>.Destroy
	|
	|-RVA: 0x30D5920 Offset: 0x30D5A21 VA: 0x30D5920
	|-ChainOperationTypelessDepedency<SceneInstance>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D3DE0 Offset: 0x30D3EE1 VA: 0x30D3DE0
	|-ChainOperationTypelessDepedency<bool>.ReleaseDependencies
	|
	|-RVA: 0x30D4720 Offset: 0x30D4821 VA: 0x30D4720
	|-ChainOperationTypelessDepedency<long>.ReleaseDependencies
	|
	|-RVA: 0x30D5060 Offset: 0x30D5161 VA: 0x30D5060
	|-ChainOperationTypelessDepedency<object>.ReleaseDependencies
	|
	|-RVA: 0x30D59B0 Offset: 0x30D5AB1 VA: 0x30D59B0
	|-ChainOperationTypelessDepedency<SceneInstance>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D3E20 Offset: 0x30D3F21 VA: 0x30D3E20
	|-ChainOperationTypelessDepedency<bool>.GetDownloadStatus
	|
	|-RVA: 0x30D4760 Offset: 0x30D4861 VA: 0x30D4760
	|-ChainOperationTypelessDepedency<long>.GetDownloadStatus
	|
	|-RVA: 0x30D50A0 Offset: 0x30D51A1 VA: 0x30D50A0
	|-ChainOperationTypelessDepedency<object>.GetDownloadStatus
	|
	|-RVA: 0x30D59F0 Offset: 0x30D5AF1 VA: 0x30D59F0
	|-ChainOperationTypelessDepedency<SceneInstance>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	private void RefreshDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D3EB0 Offset: 0x30D3FB1 VA: 0x30D3EB0
	|-ChainOperationTypelessDepedency<bool>.RefreshDownloadStatus
	|
	|-RVA: 0x30D47F0 Offset: 0x30D48F1 VA: 0x30D47F0
	|-ChainOperationTypelessDepedency<long>.RefreshDownloadStatus
	|
	|-RVA: 0x30D5130 Offset: 0x30D5231 VA: 0x30D5130
	|-ChainOperationTypelessDepedency<object>.RefreshDownloadStatus
	|
	|-RVA: 0x30D5A80 Offset: 0x30D5B81 VA: 0x30D5A80
	|-ChainOperationTypelessDepedency<SceneInstance>.RefreshDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D3FC0 Offset: 0x30D40C1 VA: 0x30D3FC0
	|-ChainOperationTypelessDepedency<bool>.get_Progress
	|
	|-RVA: 0x30D4900 Offset: 0x30D4A01 VA: 0x30D4900
	|-ChainOperationTypelessDepedency<long>.get_Progress
	|
	|-RVA: 0x30D5240 Offset: 0x30D5341 VA: 0x30D5240
	|-ChainOperationTypelessDepedency<object>.get_Progress
	|
	|-RVA: 0x30D5B90 Offset: 0x30D5C91 VA: 0x30D5B90
	|-ChainOperationTypelessDepedency<SceneInstance>.get_Progress
	*/
}

