// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal class ProviderOperation<TObject> : AsyncOperationBase<TObject>, IGenericProviderOperation, ICachable // TypeDefIndex: 5622
{
	// Fields
	private bool m_ReleaseDependenciesOnFailure; // 0x0
	private Action<int, object, bool, Exception> m_CompletionCallback; // 0x0
	private Action<int, IList<object>> m_GetDepCallback; // 0x0
	private Func<float> m_GetProgressCallback; // 0x0
	private Func<DownloadStatus> m_GetDownloadProgressCallback; // 0x0
	private Func<bool> m_WaitForCompletionCallback; // 0x0
	private DownloadStatus m_DownloadStatus; // 0x0
	private IResourceProvider m_Provider; // 0x0
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0x0
	private IResourceLocation m_Location; // 0x0
	private int m_ProvideHandleVersion; // 0x0
	private bool m_NeedsRelease; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x72B00 Offset: 0x72C01 VA: 0x72B00
	private IOperationCacheKey <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key>k__BackingField; // 0x0
	private ResourceManager m_ResourceManager; // 0x0
	private const float k_OperationWaitingToCompletePercentComplete = 0.99;
	internal const string kInvalidHandleMsg = "The ProvideHandle is invalid. After the handle has been completed, it can no longer be used";

	// Properties
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key { get; set; }
	public int ProvideHandleVersion { get; }
	public IResourceLocation Location { get; }
	protected override string DebugName { get; }
	public Type RequestedType { get; }
	public int DependencyCount { get; }
	protected override float Progress { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x73010 Offset: 0x73111 VA: 0x73010
	// RVA: -1 Offset: -1 Slot: 48
	private IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85BD0 Offset: 0x2A85CD1 VA: 0x2A85BD0
	|-ProviderOperation<object>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key
	*/

	[CompilerGeneratedAttribute] // RVA: 0x73020 Offset: 0x73121 VA: 0x73020
	// RVA: -1 Offset: -1 Slot: 49
	private void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key(IOperationCacheKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85BE0 Offset: 0x2A85CE1 VA: 0x2A85BE0
	|-ProviderOperation<object>.UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public int get_ProvideHandleVersion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85BF0 Offset: 0x2A85CF1 VA: 0x2A85BF0
	|-ProviderOperation<object>.get_ProvideHandleVersion
	*/

	// RVA: -1 Offset: -1 Slot: 39
	public IResourceLocation get_Location() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85C00 Offset: 0x2A85D01 VA: 0x2A85C00
	|-ProviderOperation<object>.get_Location
	*/

	// RVA: -1 Offset: -1 Slot: 46
	public void SetDownloadProgressCallback(Func<DownloadStatus> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85C10 Offset: 0x2A85D11 VA: 0x2A85C10
	|-ProviderOperation<object>.SetDownloadProgressCallback
	*/

	// RVA: -1 Offset: -1 Slot: 47
	public void SetWaitForCompletionCallback(Func<bool> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85CB0 Offset: 0x2A85DB1 VA: 0x2A85CB0
	|-ProviderOperation<object>.SetWaitForCompletionCallback
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85CC0 Offset: 0x2A85DC1 VA: 0x2A85CC0
	|-ProviderOperation<object>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal override DownloadStatus GetDownloadStatus(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85E10 Offset: 0x2A85F11 VA: 0x2A85E10
	|-ProviderOperation<object>.GetDownloadStatus
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85F80 Offset: 0x2A86081 VA: 0x2A85F80
	|-ProviderOperation<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected override void GetDependencies(List<AsyncOperationHandle> deps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85FA0 Offset: 0x2A860A1 VA: 0x2A85FA0
	|-ProviderOperation<object>.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal override void ReleaseDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A86080 Offset: 0x2A86181 VA: 0x2A86080
	|-ProviderOperation<object>.ReleaseDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A86110 Offset: 0x2A86211 VA: 0x2A86110
	|-ProviderOperation<object>.get_DebugName
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public void GetDependencies(IList<object> dstList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A86280 Offset: 0x2A86381 VA: 0x2A86280
	|-ProviderOperation<object>.GetDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 45
	public Type get_RequestedType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A86530 Offset: 0x2A86631 VA: 0x2A86530
	|-ProviderOperation<object>.get_RequestedType
	*/

	// RVA: -1 Offset: -1 Slot: 40
	public int get_DependencyCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A865B0 Offset: 0x2A866B1 VA: 0x2A865B0
	|-ProviderOperation<object>.get_DependencyCount
	*/

	// RVA: -1 Offset: -1 Slot: 42
	public TDepObject GetDependency<TDepObject>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2553E30 Offset: 0x2553F31 VA: 0x2553E30
	|-ProviderOperation<object>.GetDependency<object>
	*/

	// RVA: -1 Offset: -1 Slot: 43
	public void SetProgressCallback(Func<float> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A866C0 Offset: 0x2A867C1 VA: 0x2A866C0
	|-ProviderOperation<object>.SetProgressCallback
	*/

	// RVA: -1 Offset: -1 Slot: 44
	public void ProviderCompleted<T>(T result, bool status, Exception e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2554000 Offset: 0x2554101 VA: 0x2554000
	|-ProviderOperation<object>.ProviderCompleted<object>
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A866D0 Offset: 0x2A867D1 VA: 0x2A866D0
	|-ProviderOperation<object>.get_Progress
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A86B80 Offset: 0x2A86C81 VA: 0x2A86B80
	|-ProviderOperation<object>.Execute
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A86E80 Offset: 0x2A86F81 VA: 0x2A86E80
	|-ProviderOperation<object>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87000 Offset: 0x2A87101 VA: 0x2A87000
	|-ProviderOperation<ContentCatalogData>.Init
	|-ProviderOperation<object>.Init
	*/

	// RVA: -1 Offset: -1
	private bool WaitForCompletionHandler() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87180 Offset: 0x2A87281 VA: 0x2A87180
	|-ProviderOperation<object>.WaitForCompletionHandler
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87270 Offset: 0x2A87371 VA: 0x2A87270
	|-ProviderOperation<object>.Destroy
	*/
}

