// Namespace: UnityEngine.ResourceManagement.AsyncOperations
public abstract class AsyncOperationBase<TObject> : IAsyncOperation // TypeDefIndex: 5614
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x72AD0 Offset: 0x72BD1 VA: 0x72AD0
	private TObject <Result>k__BackingField; // 0x0
	private int m_referenceCount; // 0x0
	private AsyncOperationStatus m_Status; // 0x0
	private Exception m_Error; // 0x0
	internal ResourceManager m_RM; // 0x0
	internal int m_Version; // 0x0
	private DelegateList<AsyncOperationHandle> m_DestroyedAction; // 0x0
	private DelegateList<AsyncOperationHandle<TObject>> m_CompletedActionT; // 0x0
	private Action<IAsyncOperation> m_OnDestroyAction; // 0x0
	private Action<AsyncOperationHandle> m_dependencyCompleteAction; // 0x0
	protected internal bool HasExecuted; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x72AE0 Offset: 0x72BE1 VA: 0x72AE0
	private bool <IsRunning>k__BackingField; // 0x0
	private TaskCompletionSource<TObject> m_taskCompletionSource; // 0x0
	private TaskCompletionSource<object> m_taskCompletionSourceTypeless; // 0x0
	private bool m_InDeferredCallbackQueue; // 0x0
	private DelegateList<float> m_UpdateCallbacks; // 0x0
	private Action<float> m_UpdateCallback; // 0x0

	// Properties
	protected virtual float Progress { get; }
	protected virtual string DebugName { get; }
	public TObject Result { get; set; }
	internal int Version { get; }
	internal bool CompletedEventHasListeners { get; }
	internal bool DestroyedEventHasListeners { get; }
	internal Action<IAsyncOperation> OnDestroy { set; }
	internal int ReferenceCount { get; }
	public bool IsRunning { get; set; }
	internal Task<TObject> Task { get; }
	private Task<object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Task { get; }
	internal AsyncOperationStatus Status { get; }
	internal Exception OperationException { get; set; }
	internal object Current { get; }
	internal bool IsDone { get; }
	internal float PercentComplete { get; }
	internal AsyncOperationHandle<TObject> Handle { get; }
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Version { get; }
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.ReferenceCount { get; }
	private float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.PercentComplete { get; }
	private AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Status { get; }
	private Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.OperationException { get; }
	private bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IsDone { get; }
	private AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Handle { get; }
	private Action<IAsyncOperation> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.OnDestroy { set; }
	private string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DebugName { get; }
	private Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.ResultType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract void Execute();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AsyncOperationBase<object>.Execute
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected virtual void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D80E0 Offset: 0x32D81E1 VA: 0x32D80E0
	|-AsyncOperationBase<IList<IResourceLocation>>.Destroy
	|-AsyncOperationBase<IResourceLocator>.Destroy
	|-AsyncOperationBase<object>.Destroy
	|
	|-RVA: 0x32D3650 Offset: 0x32D3751 VA: 0x32D3650
	|-AsyncOperationBase<bool>.Destroy
	|
	|-RVA: 0x32D5BA0 Offset: 0x32D5CA1 VA: 0x32D5BA0
	|-AsyncOperationBase<long>.Destroy
	|
	|-RVA: 0x32DA550 Offset: 0x32DA651 VA: 0x32DA550
	|-AsyncOperationBase<SceneInstance>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected virtual float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D80F0 Offset: 0x32D81F1 VA: 0x32D80F0
	|-AsyncOperationBase<IList<IResourceLocation>>.get_Progress
	|-AsyncOperationBase<List<IResourceLocator>>.get_Progress
	|-AsyncOperationBase<List<string>>.get_Progress
	|-AsyncOperationBase<object>.get_Progress
	|
	|-RVA: 0x32D3660 Offset: 0x32D3761 VA: 0x32D3660
	|-AsyncOperationBase<bool>.get_Progress
	|
	|-RVA: 0x32D5BB0 Offset: 0x32D5CB1 VA: 0x32D5BB0
	|-AsyncOperationBase<long>.get_Progress
	|
	|-RVA: 0x32DA560 Offset: 0x32DA661 VA: 0x32DA560
	|-AsyncOperationBase<SceneInstance>.get_Progress
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected virtual string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D8100 Offset: 0x32D8201 VA: 0x32D8100
	|-AsyncOperationBase<List<IResourceLocator>>.get_DebugName
	|-AsyncOperationBase<List<string>>.get_DebugName
	|-AsyncOperationBase<object>.get_DebugName
	|
	|-RVA: 0x32D3670 Offset: 0x32D3771 VA: 0x32D3670
	|-AsyncOperationBase<bool>.get_DebugName
	|
	|-RVA: 0x32D5BC0 Offset: 0x32D5CC1 VA: 0x32D5BC0
	|-AsyncOperationBase<long>.get_DebugName
	|
	|-RVA: 0x32DA570 Offset: 0x32DA671 VA: 0x32DA570
	|-AsyncOperationBase<SceneInstance>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected virtual void GetDependencies(List<AsyncOperationHandle> dependencies) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D8110 Offset: 0x32D8211 VA: 0x32D8110
	|-AsyncOperationBase<IList<IResourceLocation>>.GetDependencies
	|-AsyncOperationBase<IResourceLocator>.GetDependencies
	|-AsyncOperationBase<object>.GetDependencies
	|
	|-RVA: 0x32D3680 Offset: 0x32D3781 VA: 0x32D3680
	|-AsyncOperationBase<bool>.GetDependencies
	|
	|-RVA: 0x32D5BD0 Offset: 0x32D5CD1 VA: 0x32D5BD0
	|-AsyncOperationBase<long>.GetDependencies
	|
	|-RVA: 0x32DA580 Offset: 0x32DA681 VA: 0x32DA580
	|-AsyncOperationBase<SceneInstance>.GetDependencies
	*/

	[CompilerGeneratedAttribute] // RVA: 0x72FA0 Offset: 0x730A1 VA: 0x72FA0
	// RVA: -1 Offset: -1
	public TObject get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D8120 Offset: 0x32D8221 VA: 0x32D8120
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.get_Result
	|-AsyncOperationBase<GameObject>.get_Result
	|-AsyncOperationBase<IResourceLocator>.get_Result
	|-AsyncOperationBase<object>.get_Result
	|
	|-RVA: 0x32D3690 Offset: 0x32D3791 VA: 0x32D3690
	|-AsyncOperationBase<bool>.get_Result
	|
	|-RVA: 0x32D5BE0 Offset: 0x32D5CE1 VA: 0x32D5BE0
	|-AsyncOperationBase<long>.get_Result
	|
	|-RVA: 0x32DA590 Offset: 0x32DA691 VA: 0x32DA590
	|-AsyncOperationBase<SceneInstance>.get_Result
	*/

	[CompilerGeneratedAttribute] // RVA: 0x72FB0 Offset: 0x730B1 VA: 0x72FB0
	// RVA: -1 Offset: -1
	public void set_Result(TObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D8130 Offset: 0x32D8231 VA: 0x32D8130
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.set_Result
	|-AsyncOperationBase<IResourceLocator>.set_Result
	|-AsyncOperationBase<object>.set_Result
	|
	|-RVA: 0x32D36A0 Offset: 0x32D37A1 VA: 0x32D36A0
	|-AsyncOperationBase<bool>.set_Result
	|
	|-RVA: 0x32D5BF0 Offset: 0x32D5CF1 VA: 0x32D5BF0
	|-AsyncOperationBase<long>.set_Result
	|
	|-RVA: 0x32DA5A0 Offset: 0x32DA6A1 VA: 0x32DA5A0
	|-AsyncOperationBase<SceneInstance>.set_Result
	*/

	// RVA: -1 Offset: -1
	internal int get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D36B0 Offset: 0x32D37B1 VA: 0x32D36B0
	|-AsyncOperationBase<bool>.get_Version
	|
	|-RVA: 0x32D5C00 Offset: 0x32D5D01 VA: 0x32D5C00
	|-AsyncOperationBase<long>.get_Version
	|
	|-RVA: 0x32D8140 Offset: 0x32D8241 VA: 0x32D8140
	|-AsyncOperationBase<object>.get_Version
	|
	|-RVA: 0x32DA5B0 Offset: 0x32DA6B1 VA: 0x32DA5B0
	|-AsyncOperationBase<SceneInstance>.get_Version
	*/

	// RVA: -1 Offset: -1
	internal bool get_CompletedEventHasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D36C0 Offset: 0x32D37C1 VA: 0x32D36C0
	|-AsyncOperationBase<bool>.get_CompletedEventHasListeners
	|
	|-RVA: 0x32D5C10 Offset: 0x32D5D11 VA: 0x32D5C10
	|-AsyncOperationBase<long>.get_CompletedEventHasListeners
	|
	|-RVA: 0x32D8150 Offset: 0x32D8251 VA: 0x32D8150
	|-AsyncOperationBase<object>.get_CompletedEventHasListeners
	|
	|-RVA: 0x32DA5C0 Offset: 0x32DA6C1 VA: 0x32DA5C0
	|-AsyncOperationBase<SceneInstance>.get_CompletedEventHasListeners
	*/

	// RVA: -1 Offset: -1
	internal bool get_DestroyedEventHasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3700 Offset: 0x32D3801 VA: 0x32D3700
	|-AsyncOperationBase<bool>.get_DestroyedEventHasListeners
	|
	|-RVA: 0x32D5C50 Offset: 0x32D5D51 VA: 0x32D5C50
	|-AsyncOperationBase<long>.get_DestroyedEventHasListeners
	|
	|-RVA: 0x32D8190 Offset: 0x32D8291 VA: 0x32D8190
	|-AsyncOperationBase<object>.get_DestroyedEventHasListeners
	|
	|-RVA: 0x32DA600 Offset: 0x32DA701 VA: 0x32DA600
	|-AsyncOperationBase<SceneInstance>.get_DestroyedEventHasListeners
	*/

	// RVA: -1 Offset: -1
	internal void set_OnDestroy(Action<IAsyncOperation> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3760 Offset: 0x32D3861 VA: 0x32D3760
	|-AsyncOperationBase<bool>.set_OnDestroy
	|
	|-RVA: 0x32D5CB0 Offset: 0x32D5DB1 VA: 0x32D5CB0
	|-AsyncOperationBase<long>.set_OnDestroy
	|
	|-RVA: 0x32D81F0 Offset: 0x32D82F1 VA: 0x32D81F0
	|-AsyncOperationBase<object>.set_OnDestroy
	|
	|-RVA: 0x32DA660 Offset: 0x32DA761 VA: 0x32DA660
	|-AsyncOperationBase<SceneInstance>.set_OnDestroy
	*/

	// RVA: -1 Offset: -1
	internal int get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3770 Offset: 0x32D3871 VA: 0x32D3770
	|-AsyncOperationBase<bool>.get_ReferenceCount
	|
	|-RVA: 0x32D5CC0 Offset: 0x32D5DC1 VA: 0x32D5CC0
	|-AsyncOperationBase<long>.get_ReferenceCount
	|
	|-RVA: 0x32D8200 Offset: 0x32D8301 VA: 0x32D8200
	|-AsyncOperationBase<object>.get_ReferenceCount
	|
	|-RVA: 0x32DA670 Offset: 0x32DA771 VA: 0x32DA670
	|-AsyncOperationBase<SceneInstance>.get_ReferenceCount
	*/

	[CompilerGeneratedAttribute] // RVA: 0x72FC0 Offset: 0x730C1 VA: 0x72FC0
	// RVA: -1 Offset: -1 Slot: 18
	public bool get_IsRunning() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D8210 Offset: 0x32D8311 VA: 0x32D8210
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.get_IsRunning
	|-AsyncOperationBase<IList<IResourceLocation>>.get_IsRunning
	|-AsyncOperationBase<List<IResourceLocator>>.get_IsRunning
	|-AsyncOperationBase<List<string>>.get_IsRunning
	|-AsyncOperationBase<GameObject>.get_IsRunning
	|-AsyncOperationBase<IResourceLocator>.get_IsRunning
	|-AsyncOperationBase<object>.get_IsRunning
	|
	|-RVA: 0x32D3780 Offset: 0x32D3881 VA: 0x32D3780
	|-AsyncOperationBase<bool>.get_IsRunning
	|
	|-RVA: 0x32D5CD0 Offset: 0x32D5DD1 VA: 0x32D5CD0
	|-AsyncOperationBase<long>.get_IsRunning
	|
	|-RVA: 0x32DA680 Offset: 0x32DA781 VA: 0x32DA680
	|-AsyncOperationBase<SceneInstance>.get_IsRunning
	*/

	[CompilerGeneratedAttribute] // RVA: 0x72FD0 Offset: 0x730D1 VA: 0x72FD0
	// RVA: -1 Offset: -1
	internal void set_IsRunning(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3790 Offset: 0x32D3891 VA: 0x32D3790
	|-AsyncOperationBase<bool>.set_IsRunning
	|
	|-RVA: 0x32D5CE0 Offset: 0x32D5DE1 VA: 0x32D5CE0
	|-AsyncOperationBase<long>.set_IsRunning
	|
	|-RVA: 0x32D8220 Offset: 0x32D8321 VA: 0x32D8220
	|-AsyncOperationBase<object>.set_IsRunning
	|
	|-RVA: 0x32DA690 Offset: 0x32DA791 VA: 0x32DA690
	|-AsyncOperationBase<SceneInstance>.set_IsRunning
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D8230 Offset: 0x32D8331 VA: 0x32D8230
	|-AsyncOperationBase<IList<AsyncOperationHandle>>..ctor
	|-AsyncOperationBase<IList<IResourceLocation>>..ctor
	|-AsyncOperationBase<List<IResourceLocator>>..ctor
	|-AsyncOperationBase<List<string>>..ctor
	|-AsyncOperationBase<GameObject>..ctor
	|-AsyncOperationBase<IResourceLocator>..ctor
	|-AsyncOperationBase<object>..ctor
	|
	|-RVA: 0x32D37A0 Offset: 0x32D38A1 VA: 0x32D37A0
	|-AsyncOperationBase<bool>..ctor
	|
	|-RVA: 0x32D5CF0 Offset: 0x32D5DF1 VA: 0x32D5CF0
	|-AsyncOperationBase<long>..ctor
	|
	|-RVA: 0x32DA6A0 Offset: 0x32DA7A1 VA: 0x32DA6A0
	|-AsyncOperationBase<SceneInstance>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static string ShortenPath(string p, bool keepExtension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D38C0 Offset: 0x32D39C1 VA: 0x32D38C0
	|-AsyncOperationBase<bool>.ShortenPath
	|
	|-RVA: 0x32D5E10 Offset: 0x32D5F11 VA: 0x32D5E10
	|-AsyncOperationBase<long>.ShortenPath
	|
	|-RVA: 0x32D8350 Offset: 0x32D8451 VA: 0x32D8350
	|-AsyncOperationBase<object>.ShortenPath
	|
	|-RVA: 0x32DA7C0 Offset: 0x32DA8C1 VA: 0x32DA7C0
	|-AsyncOperationBase<SceneInstance>.ShortenPath
	*/

	// RVA: -1 Offset: -1
	internal void IncrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3950 Offset: 0x32D3A51 VA: 0x32D3950
	|-AsyncOperationBase<bool>.IncrementReferenceCount
	|
	|-RVA: 0x32D5EA0 Offset: 0x32D5FA1 VA: 0x32D5EA0
	|-AsyncOperationBase<long>.IncrementReferenceCount
	|
	|-RVA: 0x32D83E0 Offset: 0x32D84E1 VA: 0x32D83E0
	|-AsyncOperationBase<object>.IncrementReferenceCount
	|
	|-RVA: 0x32DA850 Offset: 0x32DA951 VA: 0x32DA850
	|-AsyncOperationBase<SceneInstance>.IncrementReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void WaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D8500 Offset: 0x32D8601 VA: 0x32D8500
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.WaitForCompletion
	|-AsyncOperationBase<IList<IResourceLocation>>.WaitForCompletion
	|-AsyncOperationBase<List<IResourceLocator>>.WaitForCompletion
	|-AsyncOperationBase<List<string>>.WaitForCompletion
	|-AsyncOperationBase<GameObject>.WaitForCompletion
	|-AsyncOperationBase<IResourceLocator>.WaitForCompletion
	|-AsyncOperationBase<object>.WaitForCompletion
	|
	|-RVA: 0x32D3A70 Offset: 0x32D3B71 VA: 0x32D3A70
	|-AsyncOperationBase<bool>.WaitForCompletion
	|
	|-RVA: 0x32D5FC0 Offset: 0x32D60C1 VA: 0x32D5FC0
	|-AsyncOperationBase<long>.WaitForCompletion
	|
	|-RVA: 0x32DA970 Offset: 0x32DAA71 VA: 0x32DA970
	|-AsyncOperationBase<SceneInstance>.WaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected virtual bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3AB0 Offset: 0x32D3BB1 VA: 0x32D3AB0
	|-AsyncOperationBase<bool>.InvokeWaitForCompletion
	|
	|-RVA: 0x32D6000 Offset: 0x32D6101 VA: 0x32D6000
	|-AsyncOperationBase<long>.InvokeWaitForCompletion
	|
	|-RVA: 0x32D8540 Offset: 0x32D8641 VA: 0x32D8540
	|-AsyncOperationBase<object>.InvokeWaitForCompletion
	|
	|-RVA: 0x32DA9B0 Offset: 0x32DAAB1 VA: 0x32DA9B0
	|-AsyncOperationBase<SceneInstance>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1
	internal void DecrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3AD0 Offset: 0x32D3BD1 VA: 0x32D3AD0
	|-AsyncOperationBase<bool>.DecrementReferenceCount
	|
	|-RVA: 0x32D8560 Offset: 0x32D8661 VA: 0x32D8560
	|-AsyncOperationBase<GameObject>.DecrementReferenceCount
	|-AsyncOperationBase<object>.DecrementReferenceCount
	|
	|-RVA: 0x32D6020 Offset: 0x32D6121 VA: 0x32D6020
	|-AsyncOperationBase<long>.DecrementReferenceCount
	|
	|-RVA: 0x32DA9D0 Offset: 0x32DAAD1 VA: 0x32DA9D0
	|-AsyncOperationBase<SceneInstance>.DecrementReferenceCount
	*/

	// RVA: -1 Offset: -1
	internal Task<TObject> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D3EA0 Offset: 0x32D3FA1 VA: 0x32D3EA0
	|-AsyncOperationBase<bool>.get_Task
	|
	|-RVA: 0x32D63F0 Offset: 0x32D64F1 VA: 0x32D63F0
	|-AsyncOperationBase<long>.get_Task
	|
	|-RVA: 0x32D8930 Offset: 0x32D8A31 VA: 0x32D8930
	|-AsyncOperationBase<object>.get_Task
	|
	|-RVA: 0x32DADA0 Offset: 0x32DAEA1 VA: 0x32DADA0
	|-AsyncOperationBase<SceneInstance>.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private Task<object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D8A40 Offset: 0x32D8B41 VA: 0x32D8A40
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0x32D3FB0 Offset: 0x32D40B1 VA: 0x32D3FB0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0x32D6500 Offset: 0x32D6601 VA: 0x32D6500
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	|
	|-RVA: 0x32DAEB0 Offset: 0x32DAFB1 VA: 0x32DAEB0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D8B60 Offset: 0x32D8C61 VA: 0x32D8B60
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.ToString
	|-AsyncOperationBase<IList<IResourceLocation>>.ToString
	|-AsyncOperationBase<List<IResourceLocator>>.ToString
	|-AsyncOperationBase<List<string>>.ToString
	|-AsyncOperationBase<GameObject>.ToString
	|-AsyncOperationBase<IResourceLocator>.ToString
	|-AsyncOperationBase<object>.ToString
	|
	|-RVA: 0x32D4110 Offset: 0x32D4211 VA: 0x32D4110
	|-AsyncOperationBase<bool>.ToString
	|
	|-RVA: 0x32D6660 Offset: 0x32D6761 VA: 0x32D6660
	|-AsyncOperationBase<long>.ToString
	|
	|-RVA: 0x32DB010 Offset: 0x32DB111 VA: 0x32DB010
	|-AsyncOperationBase<SceneInstance>.ToString
	*/

	// RVA: -1 Offset: -1
	private void RegisterForDeferredCallbackEvent(bool incrementReferenceCount = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4300 Offset: 0x32D4401 VA: 0x32D4300
	|-AsyncOperationBase<bool>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0x32D6850 Offset: 0x32D6951 VA: 0x32D6850
	|-AsyncOperationBase<long>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0x32D8D20 Offset: 0x32D8E21 VA: 0x32D8D20
	|-AsyncOperationBase<object>.RegisterForDeferredCallbackEvent
	|
	|-RVA: 0x32DB200 Offset: 0x32DB301 VA: 0x32DB200
	|-AsyncOperationBase<SceneInstance>.RegisterForDeferredCallbackEvent
	*/

	// RVA: -1 Offset: -1
	internal void add_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4370 Offset: 0x32D4471 VA: 0x32D4370
	|-AsyncOperationBase<bool>.add_Completed
	|
	|-RVA: 0x32D68C0 Offset: 0x32D69C1 VA: 0x32D68C0
	|-AsyncOperationBase<long>.add_Completed
	|
	|-RVA: 0x32D8D90 Offset: 0x32D8E91 VA: 0x32D8D90
	|-AsyncOperationBase<object>.add_Completed
	|
	|-RVA: 0x32DB270 Offset: 0x32DB371 VA: 0x32DB270
	|-AsyncOperationBase<SceneInstance>.add_Completed
	*/

	// RVA: -1 Offset: -1
	internal void remove_Completed(Action<AsyncOperationHandle<TObject>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4400 Offset: 0x32D4501 VA: 0x32D4400
	|-AsyncOperationBase<bool>.remove_Completed
	|
	|-RVA: 0x32D6950 Offset: 0x32D6A51 VA: 0x32D6950
	|-AsyncOperationBase<long>.remove_Completed
	|
	|-RVA: 0x32D8E20 Offset: 0x32D8F21 VA: 0x32D8E20
	|-AsyncOperationBase<object>.remove_Completed
	|
	|-RVA: 0x32DB300 Offset: 0x32DB401 VA: 0x32DB300
	|-AsyncOperationBase<SceneInstance>.remove_Completed
	*/

	// RVA: -1 Offset: -1
	internal void add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4420 Offset: 0x32D4521 VA: 0x32D4420
	|-AsyncOperationBase<bool>.add_Destroyed
	|
	|-RVA: 0x32D6970 Offset: 0x32D6A71 VA: 0x32D6970
	|-AsyncOperationBase<long>.add_Destroyed
	|
	|-RVA: 0x32D8E40 Offset: 0x32D8F41 VA: 0x32D8E40
	|-AsyncOperationBase<object>.add_Destroyed
	|
	|-RVA: 0x32DB320 Offset: 0x32DB421 VA: 0x32DB320
	|-AsyncOperationBase<SceneInstance>.add_Destroyed
	*/

	// RVA: -1 Offset: -1
	internal void remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D44B0 Offset: 0x32D45B1 VA: 0x32D44B0
	|-AsyncOperationBase<bool>.remove_Destroyed
	|
	|-RVA: 0x32D6A00 Offset: 0x32D6B01 VA: 0x32D6A00
	|-AsyncOperationBase<long>.remove_Destroyed
	|
	|-RVA: 0x32D8ED0 Offset: 0x32D8FD1 VA: 0x32D8ED0
	|-AsyncOperationBase<object>.remove_Destroyed
	|
	|-RVA: 0x32DB3B0 Offset: 0x32DB4B1 VA: 0x32DB3B0
	|-AsyncOperationBase<SceneInstance>.remove_Destroyed
	*/

	// RVA: -1 Offset: -1
	internal void add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4520 Offset: 0x32D4621 VA: 0x32D4520
	|-AsyncOperationBase<bool>.add_CompletedTypeless
	|
	|-RVA: 0x32D6A70 Offset: 0x32D6B71 VA: 0x32D6A70
	|-AsyncOperationBase<long>.add_CompletedTypeless
	|
	|-RVA: 0x32D8F40 Offset: 0x32D9041 VA: 0x32D8F40
	|-AsyncOperationBase<object>.add_CompletedTypeless
	|
	|-RVA: 0x32DB420 Offset: 0x32DB521 VA: 0x32DB420
	|-AsyncOperationBase<SceneInstance>.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	internal void remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4600 Offset: 0x32D4701 VA: 0x32D4600
	|-AsyncOperationBase<bool>.remove_CompletedTypeless
	|
	|-RVA: 0x32D6B50 Offset: 0x32D6C51 VA: 0x32D6B50
	|-AsyncOperationBase<long>.remove_CompletedTypeless
	|
	|-RVA: 0x32D9020 Offset: 0x32D9121 VA: 0x32D9020
	|-AsyncOperationBase<object>.remove_CompletedTypeless
	|
	|-RVA: 0x32DB500 Offset: 0x32DB601 VA: 0x32DB500
	|-AsyncOperationBase<SceneInstance>.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationStatus get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D46E0 Offset: 0x32D47E1 VA: 0x32D46E0
	|-AsyncOperationBase<bool>.get_Status
	|
	|-RVA: 0x32D6C30 Offset: 0x32D6D31 VA: 0x32D6C30
	|-AsyncOperationBase<long>.get_Status
	|
	|-RVA: 0x32D9100 Offset: 0x32D9201 VA: 0x32D9100
	|-AsyncOperationBase<object>.get_Status
	|
	|-RVA: 0x32DB5E0 Offset: 0x32DB6E1 VA: 0x32DB5E0
	|-AsyncOperationBase<SceneInstance>.get_Status
	*/

	// RVA: -1 Offset: -1
	internal Exception get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D46F0 Offset: 0x32D47F1 VA: 0x32D46F0
	|-AsyncOperationBase<bool>.get_OperationException
	|
	|-RVA: 0x32D6C40 Offset: 0x32D6D41 VA: 0x32D6C40
	|-AsyncOperationBase<long>.get_OperationException
	|
	|-RVA: 0x32D9110 Offset: 0x32D9211 VA: 0x32D9110
	|-AsyncOperationBase<object>.get_OperationException
	|
	|-RVA: 0x32DB5F0 Offset: 0x32DB6F1 VA: 0x32DB5F0
	|-AsyncOperationBase<SceneInstance>.get_OperationException
	*/

	// RVA: -1 Offset: -1
	private void set_OperationException(Exception value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4700 Offset: 0x32D4801 VA: 0x32D4700
	|-AsyncOperationBase<bool>.set_OperationException
	|
	|-RVA: 0x32D6C50 Offset: 0x32D6D51 VA: 0x32D6C50
	|-AsyncOperationBase<long>.set_OperationException
	|
	|-RVA: 0x32D9120 Offset: 0x32D9221 VA: 0x32D9120
	|-AsyncOperationBase<object>.set_OperationException
	|
	|-RVA: 0x32DB600 Offset: 0x32DB701 VA: 0x32DB600
	|-AsyncOperationBase<SceneInstance>.set_OperationException
	*/

	// RVA: -1 Offset: -1
	internal bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D48C0 Offset: 0x32D49C1 VA: 0x32D48C0
	|-AsyncOperationBase<bool>.MoveNext
	|
	|-RVA: 0x32D6E10 Offset: 0x32D6F11 VA: 0x32D6E10
	|-AsyncOperationBase<long>.MoveNext
	|
	|-RVA: 0x32D92E0 Offset: 0x32D93E1 VA: 0x32D92E0
	|-AsyncOperationBase<object>.MoveNext
	|
	|-RVA: 0x32DB7C0 Offset: 0x32DB8C1 VA: 0x32DB7C0
	|-AsyncOperationBase<SceneInstance>.MoveNext
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D48F0 Offset: 0x32D49F1 VA: 0x32D48F0
	|-AsyncOperationBase<bool>.Reset
	|
	|-RVA: 0x32D6E40 Offset: 0x32D6F41 VA: 0x32D6E40
	|-AsyncOperationBase<long>.Reset
	|
	|-RVA: 0x32D9310 Offset: 0x32D9411 VA: 0x32D9310
	|-AsyncOperationBase<object>.Reset
	|
	|-RVA: 0x32DB7F0 Offset: 0x32DB8F1 VA: 0x32DB7F0
	|-AsyncOperationBase<SceneInstance>.Reset
	*/

	// RVA: -1 Offset: -1
	internal object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4900 Offset: 0x32D4A01 VA: 0x32D4900
	|-AsyncOperationBase<bool>.get_Current
	|
	|-RVA: 0x32D6E50 Offset: 0x32D6F51 VA: 0x32D6E50
	|-AsyncOperationBase<long>.get_Current
	|
	|-RVA: 0x32D9320 Offset: 0x32D9421 VA: 0x32D9320
	|-AsyncOperationBase<object>.get_Current
	|
	|-RVA: 0x32DB800 Offset: 0x32DB901 VA: 0x32DB800
	|-AsyncOperationBase<SceneInstance>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D9330 Offset: 0x32D9431 VA: 0x32D9330
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.get_IsDone
	|-AsyncOperationBase<List<IResourceLocator>>.get_IsDone
	|-AsyncOperationBase<List<string>>.get_IsDone
	|-AsyncOperationBase<GameObject>.get_IsDone
	|-AsyncOperationBase<IResourceLocator>.get_IsDone
	|-AsyncOperationBase<object>.get_IsDone
	|
	|-RVA: 0x32D4910 Offset: 0x32D4A11 VA: 0x32D4910
	|-AsyncOperationBase<bool>.get_IsDone
	|
	|-RVA: 0x32D6E60 Offset: 0x32D6F61 VA: 0x32D6E60
	|-AsyncOperationBase<long>.get_IsDone
	|
	|-RVA: 0x32DB810 Offset: 0x32DB911 VA: 0x32DB810
	|-AsyncOperationBase<SceneInstance>.get_IsDone
	*/

	// RVA: -1 Offset: -1
	internal float get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4980 Offset: 0x32D4A81 VA: 0x32D4980
	|-AsyncOperationBase<bool>.get_PercentComplete
	|
	|-RVA: 0x32D6ED0 Offset: 0x32D6FD1 VA: 0x32D6ED0
	|-AsyncOperationBase<long>.get_PercentComplete
	|
	|-RVA: 0x32D93A0 Offset: 0x32D94A1 VA: 0x32D93A0
	|-AsyncOperationBase<object>.get_PercentComplete
	|
	|-RVA: 0x32DB880 Offset: 0x32DB981 VA: 0x32DB880
	|-AsyncOperationBase<SceneInstance>.get_PercentComplete
	*/

	// RVA: -1 Offset: -1
	internal void InvokeCompletionEvent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4A40 Offset: 0x32D4B41 VA: 0x32D4A40
	|-AsyncOperationBase<bool>.InvokeCompletionEvent
	|
	|-RVA: 0x32D6F90 Offset: 0x32D7091 VA: 0x32D6F90
	|-AsyncOperationBase<long>.InvokeCompletionEvent
	|
	|-RVA: 0x32D9460 Offset: 0x32D9561 VA: 0x32D9460
	|-AsyncOperationBase<object>.InvokeCompletionEvent
	|
	|-RVA: 0x32DB940 Offset: 0x32DBA41 VA: 0x32DB940
	|-AsyncOperationBase<SceneInstance>.InvokeCompletionEvent
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> get_Handle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D9610 Offset: 0x32D9711 VA: 0x32D9610
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.get_Handle
	|-AsyncOperationBase<object>.get_Handle
	|
	|-RVA: 0x32D4C20 Offset: 0x32D4D21 VA: 0x32D4C20
	|-AsyncOperationBase<bool>.get_Handle
	|
	|-RVA: 0x32D7160 Offset: 0x32D7261 VA: 0x32D7160
	|-AsyncOperationBase<long>.get_Handle
	|
	|-RVA: 0x32DBB20 Offset: 0x32DBC21 VA: 0x32DBB20
	|-AsyncOperationBase<SceneInstance>.get_Handle
	*/

	// RVA: -1 Offset: -1
	private void UpdateCallback(float unscaledDeltaTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4D00 Offset: 0x32D4E01 VA: 0x32D4D00
	|-AsyncOperationBase<bool>.UpdateCallback
	|
	|-RVA: 0x32D7240 Offset: 0x32D7341 VA: 0x32D7240
	|-AsyncOperationBase<long>.UpdateCallback
	|
	|-RVA: 0x32D96F0 Offset: 0x32D97F1 VA: 0x32D96F0
	|-AsyncOperationBase<object>.UpdateCallback
	|
	|-RVA: 0x32DBC00 Offset: 0x32DBD01 VA: 0x32DBC00
	|-AsyncOperationBase<SceneInstance>.UpdateCallback
	*/

	// RVA: -1 Offset: -1
	public void Complete(TObject result, bool success, string errorMsg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D97C0 Offset: 0x32D98C1 VA: 0x32D97C0
	|-AsyncOperationBase<IList<IResourceLocation>>.Complete
	|-AsyncOperationBase<List<IResourceLocator>>.Complete
	|-AsyncOperationBase<List<string>>.Complete
	|-AsyncOperationBase<GameObject>.Complete
	|-AsyncOperationBase<IResourceLocator>.Complete
	|-AsyncOperationBase<object>.Complete
	|
	|-RVA: 0x32D4DD0 Offset: 0x32D4ED1 VA: 0x32D4DD0
	|-AsyncOperationBase<bool>.Complete
	|
	|-RVA: 0x32D7310 Offset: 0x32D7411 VA: 0x32D7310
	|-AsyncOperationBase<long>.Complete
	|
	|-RVA: 0x32DBCD0 Offset: 0x32DBDD1 VA: 0x32DBCD0
	|-AsyncOperationBase<SceneInstance>.Complete
	*/

	// RVA: -1 Offset: -1
	public void Complete(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D4DF0 Offset: 0x32D4EF1 VA: 0x32D4DF0
	|-AsyncOperationBase<bool>.Complete
	|
	|-RVA: 0x32D7330 Offset: 0x32D7431 VA: 0x32D7330
	|-AsyncOperationBase<long>.Complete
	|
	|-RVA: 0x32D97E0 Offset: 0x32D98E1 VA: 0x32D97E0
	|-AsyncOperationBase<object>.Complete
	|
	|-RVA: 0x32DBCF0 Offset: 0x32DBDF1 VA: 0x32DBCF0
	|-AsyncOperationBase<SceneInstance>.Complete
	*/

	// RVA: -1 Offset: -1
	public void Complete(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D98B0 Offset: 0x32D99B1 VA: 0x32D98B0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.Complete
	|-AsyncOperationBase<object>.Complete
	|
	|-RVA: 0x32D4EC0 Offset: 0x32D4FC1 VA: 0x32D4EC0
	|-AsyncOperationBase<bool>.Complete
	|
	|-RVA: 0x32D7400 Offset: 0x32D7501 VA: 0x32D7400
	|-AsyncOperationBase<long>.Complete
	|
	|-RVA: 0x32DBDC0 Offset: 0x32DBEC1 VA: 0x32DBDC0
	|-AsyncOperationBase<SceneInstance>.Complete
	*/

	// RVA: -1 Offset: -1
	internal void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D5430 Offset: 0x32D5531 VA: 0x32D5430
	|-AsyncOperationBase<bool>.Start
	|
	|-RVA: 0x32D7970 Offset: 0x32D7A71 VA: 0x32D7970
	|-AsyncOperationBase<long>.Start
	|
	|-RVA: 0x32D9E20 Offset: 0x32D9F21 VA: 0x32D9E20
	|-AsyncOperationBase<object>.Start
	|
	|-RVA: 0x32DC340 Offset: 0x32DC441 VA: 0x32DC340
	|-AsyncOperationBase<SceneInstance>.Start
	*/

	// RVA: -1 Offset: -1
	internal void InvokeExecute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA020 Offset: 0x32DA121 VA: 0x32DA020
	|-AsyncOperationBase<IList<IResourceLocation>>.InvokeExecute
	|-AsyncOperationBase<List<IResourceLocator>>.InvokeExecute
	|-AsyncOperationBase<List<string>>.InvokeExecute
	|-AsyncOperationBase<GameObject>.InvokeExecute
	|-AsyncOperationBase<IResourceLocator>.InvokeExecute
	|-AsyncOperationBase<object>.InvokeExecute
	|
	|-RVA: 0x32D5630 Offset: 0x32D5731 VA: 0x32D5630
	|-AsyncOperationBase<bool>.InvokeExecute
	|
	|-RVA: 0x32D7B70 Offset: 0x32D7C71 VA: 0x32D7B70
	|-AsyncOperationBase<long>.InvokeExecute
	|
	|-RVA: 0x32DC540 Offset: 0x32DC641 VA: 0x32DC540
	|-AsyncOperationBase<SceneInstance>.InvokeExecute
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA0D0 Offset: 0x32DA1D1 VA: 0x32DA0D0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0x32D56E0 Offset: 0x32D57E1 VA: 0x32D56E0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0x32D7C20 Offset: 0x32D7D21 VA: 0x32D7C20
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	|
	|-RVA: 0x32DC5F0 Offset: 0x32DC6F1 VA: 0x32DC5F0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA0F0 Offset: 0x32DA1F1 VA: 0x32DA0F0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|
	|-RVA: 0x32D5700 Offset: 0x32D5801 VA: 0x32D5700
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|
	|-RVA: 0x32D7C40 Offset: 0x32D7D41 VA: 0x32D7C40
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	|
	|-RVA: 0x32DC610 Offset: 0x32DC711 VA: 0x32DC610
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA110 Offset: 0x32DA211 VA: 0x32DA110
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0x32D5720 Offset: 0x32D5821 VA: 0x32D5720
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0x32D7C60 Offset: 0x32D7D61 VA: 0x32D7C60
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	|
	|-RVA: 0x32DC630 Offset: 0x32DC731 VA: 0x32DC630
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed(Action<AsyncOperationHandle> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA130 Offset: 0x32DA231 VA: 0x32DA130
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0x32D5740 Offset: 0x32D5841 VA: 0x32D5740
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0x32D7C80 Offset: 0x32D7D81 VA: 0x32D7C80
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	|
	|-RVA: 0x32DC650 Offset: 0x32DC751 VA: 0x32DC650
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA150 Offset: 0x32DA251 VA: 0x32DA150
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|
	|-RVA: 0x32D5760 Offset: 0x32D5861 VA: 0x32D5760
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|
	|-RVA: 0x32D7CA0 Offset: 0x32D7DA1 VA: 0x32D7CA0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	|
	|-RVA: 0x32DC670 Offset: 0x32DC771 VA: 0x32DC670
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA170 Offset: 0x32DA271 VA: 0x32DA170
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0x32D5780 Offset: 0x32D5881 VA: 0x32D5780
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0x32D7CC0 Offset: 0x32D7DC1 VA: 0x32D7CC0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	|
	|-RVA: 0x32DC690 Offset: 0x32DC791 VA: 0x32DC690
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA190 Offset: 0x32DA291 VA: 0x32DA190
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0x32D57A0 Offset: 0x32D58A1 VA: 0x32D57A0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0x32D7CE0 Offset: 0x32D7DE1 VA: 0x32D7CE0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	|
	|-RVA: 0x32DC6B0 Offset: 0x32DC7B1 VA: 0x32DC6B0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA1B0 Offset: 0x32DA2B1 VA: 0x32DA1B0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0x32D57C0 Offset: 0x32D58C1 VA: 0x32D57C0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0x32D7D00 Offset: 0x32D7E01 VA: 0x32D7D00
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	|
	|-RVA: 0x32DC6D0 Offset: 0x32DC7D1 VA: 0x32DC6D0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA1D0 Offset: 0x32DA2D1 VA: 0x32DA1D0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|
	|-RVA: 0x32D57E0 Offset: 0x32D58E1 VA: 0x32D57E0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|
	|-RVA: 0x32D7D20 Offset: 0x32D7E21 VA: 0x32D7D20
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	|
	|-RVA: 0x32DC6F0 Offset: 0x32DC7F1 VA: 0x32DC6F0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA1F0 Offset: 0x32DA2F1 VA: 0x32DA1F0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0x32D5800 Offset: 0x32D5901 VA: 0x32D5800
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0x32D7D40 Offset: 0x32D7E41 VA: 0x32D7D40
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	|
	|-RVA: 0x32DC710 Offset: 0x32DC811 VA: 0x32DC710
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA210 Offset: 0x32DA311 VA: 0x32DA210
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|
	|-RVA: 0x32D5820 Offset: 0x32D5921 VA: 0x32D5820
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|
	|-RVA: 0x32D7D60 Offset: 0x32D7E61 VA: 0x32D7D60
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	|
	|-RVA: 0x32DC730 Offset: 0x32DC831 VA: 0x32DC730
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy(Action<IAsyncOperation> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA2A0 Offset: 0x32DA3A1 VA: 0x32DA2A0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|
	|-RVA: 0x32D58B0 Offset: 0x32D59B1 VA: 0x32D58B0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|
	|-RVA: 0x32D7DF0 Offset: 0x32D7EF1 VA: 0x32D7DF0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	|
	|-RVA: 0x32DC7C0 Offset: 0x32DC8C1 VA: 0x32DC7C0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA2C0 Offset: 0x32DA3C1 VA: 0x32DA2C0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|
	|-RVA: 0x32D58D0 Offset: 0x32D59D1 VA: 0x32D58D0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|
	|-RVA: 0x32D7E10 Offset: 0x32D7F11 VA: 0x32D7E10
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	|
	|-RVA: 0x32DC7E0 Offset: 0x32DC8E1 VA: 0x32DC7E0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private object UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA2D0 Offset: 0x32DA3D1 VA: 0x32DA2D0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0x32D58E0 Offset: 0x32D59E1 VA: 0x32D58E0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0x32D7E20 Offset: 0x32D7F21 VA: 0x32D7E20
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	|
	|-RVA: 0x32DC7F0 Offset: 0x32DC8F1 VA: 0x32DC7F0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA2F0 Offset: 0x32DA3F1 VA: 0x32DA2F0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|
	|-RVA: 0x32D5940 Offset: 0x32D5A41 VA: 0x32D5940
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|
	|-RVA: 0x32D7E80 Offset: 0x32D7F81 VA: 0x32D7E80
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	|
	|-RVA: 0x32DC860 Offset: 0x32DC961 VA: 0x32DC860
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA370 Offset: 0x32DA471 VA: 0x32DA370
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|
	|-RVA: 0x32D59C0 Offset: 0x32D5AC1 VA: 0x32D59C0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|
	|-RVA: 0x32D7F00 Offset: 0x32D8001 VA: 0x32D7F00
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	|
	|-RVA: 0x32DC8E0 Offset: 0x32DC9E1 VA: 0x32DC8E0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA380 Offset: 0x32DA481 VA: 0x32DA380
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0x32D59D0 Offset: 0x32D5AD1 VA: 0x32D59D0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0x32D7F10 Offset: 0x32D8011 VA: 0x32D7F10
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	|
	|-RVA: 0x32DC8F0 Offset: 0x32DC9F1 VA: 0x32DC8F0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA3A0 Offset: 0x32DA4A1 VA: 0x32DA3A0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0x32D59F0 Offset: 0x32D5AF1 VA: 0x32D59F0
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0x32D7F30 Offset: 0x32D8031 VA: 0x32D7F30
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	|
	|-RVA: 0x32DC910 Offset: 0x32DCA11 VA: 0x32DC910
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA3C0 Offset: 0x32DA4C1 VA: 0x32DA3C0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0x32D5A10 Offset: 0x32D5B11 VA: 0x32D5A10
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0x32D7F50 Offset: 0x32D8051 VA: 0x32D7F50
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	|
	|-RVA: 0x32DC930 Offset: 0x32DCA31 VA: 0x32DC930
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA3E0 Offset: 0x32DA4E1 VA: 0x32DA3E0
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0x32D5A30 Offset: 0x32D5B31 VA: 0x32D5A30
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0x32D7F70 Offset: 0x32D8071 VA: 0x32D7F70
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	|
	|-RVA: 0x32DC950 Offset: 0x32DCA51 VA: 0x32DC950
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal virtual void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA430 Offset: 0x32DA531 VA: 0x32DA430
	|-AsyncOperationBase<IList<IResourceLocation>>.ReleaseDependencies
	|-AsyncOperationBase<List<IResourceLocator>>.ReleaseDependencies
	|-AsyncOperationBase<List<string>>.ReleaseDependencies
	|-AsyncOperationBase<GameObject>.ReleaseDependencies
	|-AsyncOperationBase<IResourceLocator>.ReleaseDependencies
	|-AsyncOperationBase<object>.ReleaseDependencies
	|
	|-RVA: 0x32D5A80 Offset: 0x32D5B81 VA: 0x32D5A80
	|-AsyncOperationBase<bool>.ReleaseDependencies
	|
	|-RVA: 0x32D7FC0 Offset: 0x32D80C1 VA: 0x32D7FC0
	|-AsyncOperationBase<long>.ReleaseDependencies
	|
	|-RVA: 0x32DC9A0 Offset: 0x32DCAA1 VA: 0x32DC9A0
	|-AsyncOperationBase<SceneInstance>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private DownloadStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA440 Offset: 0x32DA541 VA: 0x32DA440
	|-AsyncOperationBase<IList<AsyncOperationHandle>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<IList<IResourceLocation>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<List<IResourceLocator>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<List<string>>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<GameObject>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<IResourceLocator>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|-AsyncOperationBase<object>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|
	|-RVA: 0x32D5A90 Offset: 0x32D5B91 VA: 0x32D5A90
	|-AsyncOperationBase<bool>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|
	|-RVA: 0x32D7FD0 Offset: 0x32D80D1 VA: 0x32D7FD0
	|-AsyncOperationBase<long>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	|
	|-RVA: 0x32DC9B0 Offset: 0x32DCAB1 VA: 0x32DC9B0
	|-AsyncOperationBase<SceneInstance>.UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal virtual DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32DA490 Offset: 0x32DA591 VA: 0x32DA490
	|-AsyncOperationBase<IList<IResourceLocation>>.GetDownloadStatus
	|-AsyncOperationBase<List<IResourceLocator>>.GetDownloadStatus
	|-AsyncOperationBase<List<string>>.GetDownloadStatus
	|-AsyncOperationBase<IResourceLocator>.GetDownloadStatus
	|-AsyncOperationBase<object>.GetDownloadStatus
	|
	|-RVA: 0x32D5AE0 Offset: 0x32D5BE1 VA: 0x32D5AE0
	|-AsyncOperationBase<bool>.GetDownloadStatus
	|
	|-RVA: 0x32D8020 Offset: 0x32D8121 VA: 0x32D8020
	|-AsyncOperationBase<long>.GetDownloadStatus
	|
	|-RVA: 0x32DCA00 Offset: 0x32DCB01 VA: 0x32DCA00
	|-AsyncOperationBase<SceneInstance>.GetDownloadStatus
	*/

	[CompilerGeneratedAttribute] // RVA: 0x72FE0 Offset: 0x730E1 VA: 0x72FE0
	// RVA: -1 Offset: -1
	private void <.ctor>b__35_0(AsyncOperationHandle o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D5B80 Offset: 0x32D5C81 VA: 0x32D5B80
	|-AsyncOperationBase<bool>.<.ctor>b__35_0
	|
	|-RVA: 0x32D80C0 Offset: 0x32D81C1 VA: 0x32D80C0
	|-AsyncOperationBase<long>.<.ctor>b__35_0
	|
	|-RVA: 0x32DA530 Offset: 0x32DA631 VA: 0x32DA530
	|-AsyncOperationBase<object>.<.ctor>b__35_0
	|
	|-RVA: 0x32DCAA0 Offset: 0x32DCBA1 VA: 0x32DCAA0
	|-AsyncOperationBase<SceneInstance>.<.ctor>b__35_0
	*/
}

