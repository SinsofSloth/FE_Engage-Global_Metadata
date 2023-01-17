// Namespace: UnityEngine.ResourceManagement
public class ResourceManager : IDisposable // TypeDefIndex: 5545
{
	// Fields
	internal bool postProfilerEvents; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x72540 Offset: 0x72641 VA: 0x72540
	private static Action<AsyncOperationHandle, Exception> <ExceptionHandler>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x72550 Offset: 0x72651 VA: 0x72550
	private Func<IResourceLocation, string> <InternalIdTransformFunc>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x72560 Offset: 0x72661 VA: 0x72560
	private Action<UnityWebRequest> <WebRequestOverride>k__BackingField; // 0x20
	internal bool CallbackHooksEnabled; // 0x28
	private ListWithEvents<IResourceProvider> m_ResourceProviders; // 0x30
	private IAllocationStrategy m_allocator; // 0x38
	private ListWithEvents<IUpdateReceiver> m_UpdateReceivers; // 0x40
	private List<IUpdateReceiver> m_UpdateReceiversToRemove; // 0x48
	private bool m_UpdatingReceivers; // 0x50
	private bool m_InsideUpdateMethod; // 0x51
	internal Dictionary<int, IResourceProvider> m_providerMap; // 0x58
	private Dictionary<IOperationCacheKey, IAsyncOperation> m_AssetOperationCache; // 0x60
	private HashSet<ResourceManager.InstanceOperation> m_TrackedInstanceOperations; // 0x68
	private DelegateList<float> m_UpdateCallbacks; // 0x70
	private List<IAsyncOperation> m_DeferredCompleteCallbacks; // 0x78
	private Action<AsyncOperationHandle, ResourceManager.DiagnosticEventType, int, object> m_obsoleteDiagnosticsHandler; // 0x80
	private Action<ResourceManager.DiagnosticEventContext> m_diagnosticsHandler; // 0x88
	private Action<IAsyncOperation> m_ReleaseOpNonCached; // 0x90
	private Action<IAsyncOperation> m_ReleaseOpCached; // 0x98
	private Action<IAsyncOperation> m_ReleaseInstanceOp; // 0xA0
	private static int s_GroupOperationTypeHash; // 0x8
	private static int s_InstanceOperationTypeHash; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x72570 Offset: 0x72671 VA: 0x72570
	private CertificateHandler <CertificateHandlerInstance>k__BackingField; // 0xA8
	private bool m_RegisteredForCallbacks; // 0xB0
	private Dictionary<Type, Type> m_ProviderOperationTypeCache; // 0xB8

	// Properties
	public static Action<AsyncOperationHandle, Exception> ExceptionHandler { get; set; }
	public Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	internal Action<UnityWebRequest> WebRequestOverride { get; set; }
	internal int OperationCacheCount { get; }
	internal int InstanceOperationCount { get; }
	public IAllocationStrategy Allocator { get; set; }
	public IList<IResourceProvider> ResourceProviders { get; }
	public CertificateHandler CertificateHandlerInstance { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x72B50 Offset: 0x72C51 VA: 0x72B50
	// RVA: 0x36315D0 Offset: 0x36316D1 VA: 0x36315D0
	public static Action<AsyncOperationHandle, Exception> get_ExceptionHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x72B60 Offset: 0x72C61 VA: 0x72B60
	// RVA: 0x3631640 Offset: 0x3631741 VA: 0x3631640
	public static void set_ExceptionHandler(Action<AsyncOperationHandle, Exception> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x72B70 Offset: 0x72C71 VA: 0x72B70
	// RVA: 0x36316C0 Offset: 0x36317C1 VA: 0x36316C0
	public Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	[CompilerGeneratedAttribute] // RVA: 0x72B80 Offset: 0x72C81 VA: 0x72B80
	// RVA: 0x36316D0 Offset: 0x36317D1 VA: 0x36316D0
	public void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x3624020 Offset: 0x3624121 VA: 0x3624020
	public string TransformInternalId(IResourceLocation location) { }

	[CompilerGeneratedAttribute] // RVA: 0x72B90 Offset: 0x72C91 VA: 0x72B90
	// RVA: 0x36316E0 Offset: 0x36317E1 VA: 0x36316E0
	internal Action<UnityWebRequest> get_WebRequestOverride() { }

	[CompilerGeneratedAttribute] // RVA: 0x72BA0 Offset: 0x72CA1 VA: 0x72BA0
	// RVA: 0x36316F0 Offset: 0x36317F1 VA: 0x36316F0
	internal void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	// RVA: 0x3631700 Offset: 0x3631801 VA: 0x3631700
	internal int get_OperationCacheCount() { }

	// RVA: 0x3631760 Offset: 0x3631861 VA: 0x3631760
	internal int get_InstanceOperationCount() { }

	// RVA: 0x36317B0 Offset: 0x36318B1 VA: 0x36317B0
	public void AddUpdateReceiver(IUpdateReceiver receiver) { }

	// RVA: 0x3631820 Offset: 0x3631921 VA: 0x3631820
	public void RemoveUpdateReciever(IUpdateReceiver receiver) { }

	// RVA: 0x3631920 Offset: 0x3631A21 VA: 0x3631920
	public IAllocationStrategy get_Allocator() { }

	// RVA: 0x3631930 Offset: 0x3631A31 VA: 0x3631930
	public void set_Allocator(IAllocationStrategy value) { }

	// RVA: 0x3631940 Offset: 0x3631A41 VA: 0x3631940
	public IList<IResourceProvider> get_ResourceProviders() { }

	[CompilerGeneratedAttribute] // RVA: 0x72BB0 Offset: 0x72CB1 VA: 0x72BB0
	// RVA: 0x3631950 Offset: 0x3631A51 VA: 0x3631950
	public CertificateHandler get_CertificateHandlerInstance() { }

	[CompilerGeneratedAttribute] // RVA: 0x72BC0 Offset: 0x72CC1 VA: 0x72BC0
	// RVA: 0x3631960 Offset: 0x3631A61 VA: 0x3631960
	public void set_CertificateHandlerInstance(CertificateHandler value) { }

	// RVA: 0x3631970 Offset: 0x3631A71 VA: 0x3631970
	public void .ctor(IAllocationStrategy alloc) { }

	// RVA: 0x3631EA0 Offset: 0x3631FA1 VA: 0x3631EA0
	private void OnObjectAdded(object obj) { }

	// RVA: 0x3631F50 Offset: 0x3632051 VA: 0x3631F50
	private void OnObjectRemoved(object obj) { }

	// RVA: 0x3631FD0 Offset: 0x36320D1 VA: 0x3631FD0
	internal void RegisterForCallbacks() { }

	[ObsoleteAttribute] // RVA: 0x72BD0 Offset: 0x72CD1 VA: 0x72BD0
	// RVA: 0x3632110 Offset: 0x3632211 VA: 0x3632110
	public void ClearDiagnosticsCallback() { }

	// RVA: 0x3632150 Offset: 0x3632251 VA: 0x3632150
	public void ClearDiagnosticCallbacks() { }

	// RVA: 0x3632190 Offset: 0x3632291 VA: 0x3632190
	public void UnregisterDiagnosticCallback(Action<ResourceManager.DiagnosticEventContext> func) { }

	[ObsoleteAttribute] // RVA: 0x72C10 Offset: 0x72D11 VA: 0x72C10
	// RVA: 0x3632280 Offset: 0x3632381 VA: 0x3632280
	public void RegisterDiagnosticCallback(Action<AsyncOperationHandle, ResourceManager.DiagnosticEventType, int, object> func) { }

	// RVA: 0x3632290 Offset: 0x3632391 VA: 0x3632290
	public void RegisterDiagnosticCallback(Action<ResourceManager.DiagnosticEventContext> func) { }

	// RVA: 0x3632320 Offset: 0x3632421 VA: 0x3632320
	internal void PostDiagnosticEvent(ResourceManager.DiagnosticEventContext context) { }

	// RVA: 0x3632480 Offset: 0x3632581 VA: 0x3632480
	public IResourceProvider GetResourceProvider(Type t, IResourceLocation location) { }

	// RVA: 0x36328C0 Offset: 0x36329C1 VA: 0x36328C0
	private Type GetDefaultTypeForLocation(IResourceLocation loc) { }

	// RVA: 0x3632A20 Offset: 0x3632B21 VA: 0x3632A20
	private int CalculateLocationsHash(IList<IResourceLocation> locations, Type t) { }

	// RVA: 0x3632E40 Offset: 0x3632F41 VA: 0x3632E40
	private AsyncOperationHandle ProvideResource(IResourceLocation location, Type desiredType, bool releaseDependenciesOnFailure = True) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> ProvideResource<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20196B0 Offset: 0x20197B1 VA: 0x20196B0
	|-ResourceManager.ProvideResource<ContentCatalogData>
	|-ResourceManager.ProvideResource<GameObject>
	|-ResourceManager.ProvideResource<object>
	|-ResourceManager.ProvideResource<ResourceManagerRuntimeData>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> StartOperation<TObject>(AsyncOperationBase<TObject> operation, AsyncOperationHandle dependency) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2019C40 Offset: 0x2019D41 VA: 0x2019C40
	|-ResourceManager.StartOperation<IList<AsyncOperationHandle>>
	|-ResourceManager.StartOperation<IList<IResourceLocation>>
	|-ResourceManager.StartOperation<List<IResourceLocator>>
	|-ResourceManager.StartOperation<List<string>>
	|-ResourceManager.StartOperation<ContentCatalogData>
	|-ResourceManager.StartOperation<GameObject>
	|-ResourceManager.StartOperation<IResourceLocator>
	|-ResourceManager.StartOperation<object>
	|
	|-RVA: 0x2019B00 Offset: 0x2019C01 VA: 0x2019B00
	|-ResourceManager.StartOperation<bool>
	|
	|-RVA: 0x2019BA0 Offset: 0x2019CA1 VA: 0x2019BA0
	|-ResourceManager.StartOperation<long>
	|
	|-RVA: 0x2019CE0 Offset: 0x2019DE1 VA: 0x2019CE0
	|-ResourceManager.StartOperation<SceneInstance>
	*/

	// RVA: 0x3633EA0 Offset: 0x3633FA1 VA: 0x3633EA0
	internal AsyncOperationHandle StartOperation(IAsyncOperation operation, AsyncOperationHandle dependency) { }

	// RVA: 0x3634010 Offset: 0x3634111 VA: 0x3634010
	private void OnInstanceOperationDestroy(IAsyncOperation o) { }

	// RVA: 0x3634150 Offset: 0x3634251 VA: 0x3634150
	private void OnOperationDestroyNonCached(IAsyncOperation o) { }

	// RVA: 0x3634220 Offset: 0x3634321 VA: 0x3634220
	private void OnOperationDestroyCached(IAsyncOperation o) { }

	// RVA: -1 Offset: -1
	internal T CreateOperation<T>(Type actualType, int typeHash, IOperationCacheKey cacheKey, Action<IAsyncOperation> onDestroyAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2019480 Offset: 0x2019581 VA: 0x2019480
	|-ResourceManager.CreateOperation<ProviderOperation<ContentCatalogData>>
	|-ResourceManager.CreateOperation<GroupOperation>
	|-ResourceManager.CreateOperation<IAsyncOperation>
	|-ResourceManager.CreateOperation<object>
	|-ResourceManager.CreateOperation<ResourceManager.InstanceOperation>
	*/

	// RVA: 0x3634520 Offset: 0x3634621 VA: 0x3634520
	internal void AddOperationToCache(IOperationCacheKey key, IAsyncOperation operation) { }

	// RVA: 0x3634470 Offset: 0x3634571 VA: 0x3634470
	internal bool RemoveOperationFromCache(IOperationCacheKey key) { }

	// RVA: 0x36345E0 Offset: 0x36346E1 VA: 0x36345E0
	internal bool IsOperationCached(IOperationCacheKey key) { }

	// RVA: 0x3634640 Offset: 0x3634741 VA: 0x3634640
	internal int CachedOperationCount() { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateCompletedOperation<TObject>(TObject result, string errorMsg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2018280 Offset: 0x2018381 VA: 0x2018280
	|-ResourceManager.CreateCompletedOperation<IList<IAssetBundleResource>>
	|-ResourceManager.CreateCompletedOperation<List<IResourceLocator>>
	|-ResourceManager.CreateCompletedOperation<GameObject>
	|-ResourceManager.CreateCompletedOperation<IResourceLocator>
	|-ResourceManager.CreateCompletedOperation<object>
	|
	|-RVA: 0x20180C0 Offset: 0x20181C1 VA: 0x20180C0
	|-ResourceManager.CreateCompletedOperation<bool>
	|
	|-RVA: 0x20181A0 Offset: 0x20182A1 VA: 0x20181A0
	|-ResourceManager.CreateCompletedOperation<long>
	|
	|-RVA: 0x2018360 Offset: 0x2018461 VA: 0x2018360
	|-ResourceManager.CreateCompletedOperation<SceneInstance>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateCompletedOperationWithException<TObject>(TObject result, Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20189D0 Offset: 0x2018AD1 VA: 0x20189D0
	|-ResourceManager.CreateCompletedOperationWithException<object>
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> CreateCompletedOperationInternal<TObject>(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2018450 Offset: 0x2018551 VA: 0x2018450
	|-ResourceManager.CreateCompletedOperationInternal<bool>
	|
	|-RVA: 0x20185B0 Offset: 0x20186B1 VA: 0x20185B0
	|-ResourceManager.CreateCompletedOperationInternal<long>
	|
	|-RVA: 0x2018710 Offset: 0x2018811 VA: 0x2018710
	|-ResourceManager.CreateCompletedOperationInternal<object>
	|
	|-RVA: 0x2018870 Offset: 0x2018971 VA: 0x2018870
	|-ResourceManager.CreateCompletedOperationInternal<SceneInstance>
	*/

	// RVA: 0x362DE60 Offset: 0x362DF61 VA: 0x362DE60
	public void Release(AsyncOperationHandle handle) { }

	// RVA: 0x36346A0 Offset: 0x36347A1 VA: 0x36346A0
	public void Acquire(AsyncOperationHandle handle) { }

	// RVA: 0x3634750 Offset: 0x3634851 VA: 0x3634750
	private GroupOperation AcquireGroupOpFromCache(IOperationCacheKey key) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2018A30 Offset: 0x2018B31 VA: 0x2018A30
	|-ResourceManager.CreateGroupOperation<object>
	|-ResourceManager.CreateGroupOperation<string>
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations, bool allowFailedDependencies) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2018F50 Offset: 0x2019051 VA: 0x2018F50
	|-ResourceManager.CreateGroupOperation<object>
	|-ResourceManager.CreateGroupOperation<string>
	*/

	// RVA: 0x3634890 Offset: 0x3634991 VA: 0x3634890
	public AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGenericGroupOperation(List<AsyncOperationHandle> operations, bool releasedCachedOpOnComplete = False) { }

	// RVA: 0x3633710 Offset: 0x3633811 VA: 0x3633710
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> ProvideResourceGroupCached(IList<IResourceLocation> locations, int groupHash, Type desiredType, Action<AsyncOperationHandle> callback, bool releaseDependenciesOnFailure = True) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20197A0 Offset: 0x20198A1 VA: 0x20197A0
	|-ResourceManager.ProvideResources<object>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, bool releaseDependenciesOnFailure, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2019800 Offset: 0x2019901 VA: 0x2019800
	|-ResourceManager.ProvideResources<object>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2017A80 Offset: 0x2017B81 VA: 0x2017A80
	|-ResourceManager.CreateChainOperation<List<IResourceLocator>, List<string>>
	|-ResourceManager.CreateChainOperation<IResourceLocator, ContentCatalogData>
	|-ResourceManager.CreateChainOperation<object, object>
	|
	|-RVA: 0x2017C30 Offset: 0x2017D31 VA: 0x2017C30
	|-ResourceManager.CreateChainOperation<SceneInstance, SceneInstance>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2017860 Offset: 0x2017961 VA: 0x2017860
	|-ResourceManager.CreateChainOperation<IList<IAssetBundleResource>>
	|-ResourceManager.CreateChainOperation<IList<IResourceLocation>>
	|-ResourceManager.CreateChainOperation<GameObject>
	|-ResourceManager.CreateChainOperation<IResourceLocator>
	|-ResourceManager.CreateChainOperation<object>
	|
	|-RVA: 0x2017640 Offset: 0x2017741 VA: 0x2017640
	|-ResourceManager.CreateChainOperation<bool>
	|
	|-RVA: 0x2017750 Offset: 0x2017851 VA: 0x2017750
	|-ResourceManager.CreateChainOperation<long>
	|
	|-RVA: 0x2017970 Offset: 0x2017A71 VA: 0x2017970
	|-ResourceManager.CreateChainOperation<SceneInstance>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2017F00 Offset: 0x2018001 VA: 0x2017F00
	|-ResourceManager.CreateChainOperation<object, object>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2017DE0 Offset: 0x2017EE1 VA: 0x2017DE0
	|-ResourceManager.CreateChainOperation<object>
	*/

	// RVA: 0x3634B10 Offset: 0x3634C11 VA: 0x3634B10
	public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneMode loadMode, bool activateOnLoad, int priority) { }

	// RVA: 0x3634C60 Offset: 0x3634D61 VA: 0x3634C60
	public AsyncOperationHandle<SceneInstance> ReleaseScene(ISceneProvider sceneProvider, AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }

	// RVA: 0x3634DB0 Offset: 0x3634EB1 VA: 0x3634DB0
	public AsyncOperationHandle<GameObject> ProvideInstance(IInstanceProvider provider, IResourceLocation location, InstantiationParameters instantiateParameters) { }

	// RVA: 0x3635150 Offset: 0x3635251 VA: 0x3635150
	public void CleanupSceneInstances(Scene scene) { }

	// RVA: 0x36354C0 Offset: 0x36355C1 VA: 0x36354C0
	private void ExecuteDeferredCallbacks() { }

	// RVA: 0x3635680 Offset: 0x3635781 VA: 0x3635680
	internal void RegisterForDeferredCallback(IAsyncOperation op, bool incrementRefCount = True) { }

	// RVA: 0x362C0C0 Offset: 0x362C1C1 VA: 0x362C0C0
	internal void Update(float unscaledDeltaTime) { }

	// RVA: 0x3635760 Offset: 0x3635861 VA: 0x3635760 Slot: 4
	public void Dispose() { }

	// RVA: 0x36358B0 Offset: 0x36359B1 VA: 0x36358B0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x72C20 Offset: 0x72D21 VA: 0x72C20
	// RVA: 0x36359A0 Offset: 0x3635AA1 VA: 0x36359A0
	private void <.ctor>b__50_0(IUpdateReceiver x) { }
}

