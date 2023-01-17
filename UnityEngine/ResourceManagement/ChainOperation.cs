// Namespace: UnityEngine.ResourceManagement
internal class ChainOperation<TObject, TObjectDependency> : AsyncOperationBase<TObject> // TypeDefIndex: 5538
{
	// Fields
	private AsyncOperationHandle<TObjectDependency> m_DepOp; // 0x0
	private AsyncOperationHandle<TObject> m_WrappedOp; // 0x0
	private DownloadStatus m_depStatus; // 0x0
	private DownloadStatus m_wrapStatus; // 0x0
	private Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> m_Callback; // 0x0
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
	|-RVA: 0x30D5CD0 Offset: 0x30D5DD1 VA: 0x30D5CD0
	|-ChainOperation<object, object>..ctor
	|
	|-RVA: 0x30D68A0 Offset: 0x30D69A1 VA: 0x30D68A0
	|-ChainOperation<SceneInstance, SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D5D70 Offset: 0x30D5E71 VA: 0x30D5D70
	|-ChainOperation<object, object>.get_DebugName
	|
	|-RVA: 0x30D6940 Offset: 0x30D6A41 VA: 0x30D6940
	|-ChainOperation<SceneInstance, SceneInstance>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D6030 Offset: 0x30D6131 VA: 0x30D6030
	|-ChainOperation<object, object>.GetDependencies
	|
	|-RVA: 0x30D6C00 Offset: 0x30D6D01 VA: 0x30D6C00
	|-ChainOperation<SceneInstance, SceneInstance>.GetDependencies
	*/

	// RVA: -1 Offset: -1
	public void Init(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D6110 Offset: 0x30D6211 VA: 0x30D6110
	|-ChainOperation<object, object>.Init
	|
	|-RVA: 0x30D6CE0 Offset: 0x30D6DE1 VA: 0x30D6CE0
	|-ChainOperation<SceneInstance, SceneInstance>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D61C0 Offset: 0x30D62C1 VA: 0x30D61C0
	|-ChainOperation<object, object>.InvokeWaitForCompletion
	|
	|-RVA: 0x30D6D90 Offset: 0x30D6E91 VA: 0x30D6D90
	|-ChainOperation<SceneInstance, SceneInstance>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D62C0 Offset: 0x30D63C1 VA: 0x30D62C0
	|-ChainOperation<object, object>.Execute
	|
	|-RVA: 0x30D6E90 Offset: 0x30D6F91 VA: 0x30D6E90
	|-ChainOperation<SceneInstance, SceneInstance>.Execute
	*/

	// RVA: -1 Offset: -1
	private void OnWrappedCompleted(AsyncOperationHandle<TObject> x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D6380 Offset: 0x30D6481 VA: 0x30D6380
	|-ChainOperation<object, object>.OnWrappedCompleted
	|
	|-RVA: 0x30D6F50 Offset: 0x30D7051 VA: 0x30D6F50
	|-ChainOperation<SceneInstance, SceneInstance>.OnWrappedCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D64A0 Offset: 0x30D65A1 VA: 0x30D64A0
	|-ChainOperation<object, object>.Destroy
	|
	|-RVA: 0x30D7080 Offset: 0x30D7181 VA: 0x30D7080
	|-ChainOperation<SceneInstance, SceneInstance>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D6540 Offset: 0x30D6641 VA: 0x30D6540
	|-ChainOperation<object, object>.ReleaseDependencies
	|
	|-RVA: 0x30D7120 Offset: 0x30D7221 VA: 0x30D7120
	|-ChainOperation<SceneInstance, SceneInstance>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D65A0 Offset: 0x30D66A1 VA: 0x30D65A0
	|-ChainOperation<object, object>.GetDownloadStatus
	|
	|-RVA: 0x30D7180 Offset: 0x30D7281 VA: 0x30D7180
	|-ChainOperation<SceneInstance, SceneInstance>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	private void RefreshDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D6630 Offset: 0x30D6731 VA: 0x30D6630
	|-ChainOperation<object, object>.RefreshDownloadStatus
	|
	|-RVA: 0x30D7210 Offset: 0x30D7311 VA: 0x30D7210
	|-ChainOperation<SceneInstance, SceneInstance>.RefreshDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30D6750 Offset: 0x30D6851 VA: 0x30D6750
	|-ChainOperation<object, object>.get_Progress
	|
	|-RVA: 0x30D7330 Offset: 0x30D7431 VA: 0x30D7330
	|-ChainOperation<SceneInstance, SceneInstance>.get_Progress
	*/
}

