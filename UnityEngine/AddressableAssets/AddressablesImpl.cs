// Namespace: UnityEngine.AddressableAssets
internal class AddressablesImpl : IEqualityComparer<IResourceLocation> // TypeDefIndex: 7282
{
	// Fields
	private ResourceManager m_ResourceManager; // 0x10
	private IInstanceProvider m_InstanceProvider; // 0x18
	private int m_CatalogRequestsTimeout; // 0x20
	internal const string kCacheDataFolder = "{UnityEngine.Application.persistentDataPath}/com.unity.addressables/";
	public ISceneProvider SceneProvider; // 0x28
	internal List<AddressablesImpl.ResourceLocatorInfo> m_ResourceLocators; // 0x30
	private AsyncOperationHandle<IResourceLocator> m_InitializationOperation; // 0x38
	private AsyncOperationHandle<List<string>> m_ActiveCheckUpdateOperation; // 0x50
	internal AsyncOperationHandle<List<IResourceLocator>> m_ActiveUpdateOperation; // 0x68
	private Action<AsyncOperationHandle> m_OnHandleCompleteAction; // 0x80
	private Action<AsyncOperationHandle> m_OnSceneHandleCompleteAction; // 0x88
	private Action<AsyncOperationHandle> m_OnHandleDestroyedAction; // 0x90
	private Dictionary<object, AsyncOperationHandle> m_resultToHandle; // 0x98
	internal HashSet<AsyncOperationHandle> m_SceneInstances; // 0xA0
	internal bool hasStartedInitialization; // 0xA8

	// Properties
	public IInstanceProvider InstanceProvider { get; set; }
	public ResourceManager ResourceManager { get; }
	public int CatalogRequestsTimeout { get; set; }
	internal int SceneOperationCount { get; }
	internal int TrackedHandleCount { get; }
	public Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	internal Action<UnityWebRequest> WebRequestOverride { get; set; }
	public AsyncOperationHandle ChainOperation { get; }
	internal bool ShouldChainRequest { get; }
	public string StreamingAssetsSubFolder { get; }
	public string BuildPath { get; }
	public string PlayerBuildDataPath { get; }
	public string RuntimePath { get; }
	public IEnumerable<IResourceLocator> ResourceLocators { get; }
	internal IEnumerable<string> CatalogsWithAvailableUpdates { get; }

	// Methods

	// RVA: 0x308CF80 Offset: 0x308D081 VA: 0x308CF80
	public IInstanceProvider get_InstanceProvider() { }

	// RVA: 0x308CF90 Offset: 0x308D091 VA: 0x308CF90
	public void set_InstanceProvider(IInstanceProvider value) { }

	// RVA: 0x3082A10 Offset: 0x3082B11 VA: 0x3082A10
	public ResourceManager get_ResourceManager() { }

	// RVA: 0x308D020 Offset: 0x308D121 VA: 0x308D020
	public int get_CatalogRequestsTimeout() { }

	// RVA: 0x308D030 Offset: 0x308D131 VA: 0x308D030
	public void set_CatalogRequestsTimeout(int value) { }

	// RVA: 0x308D040 Offset: 0x308D141 VA: 0x308D040
	internal int get_SceneOperationCount() { }

	// RVA: 0x308D090 Offset: 0x308D191 VA: 0x308D090
	internal int get_TrackedHandleCount() { }

	// RVA: 0x308CD70 Offset: 0x308CE71 VA: 0x308CD70
	public void .ctor(IAllocationStrategy alloc) { }

	// RVA: 0x308D0F0 Offset: 0x308D1F1 VA: 0x308D0F0
	internal void ReleaseSceneManagerOperation() { }

	// RVA: 0x3082EB0 Offset: 0x3082FB1 VA: 0x3082EB0
	public Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	// RVA: 0x3082FB0 Offset: 0x30830B1 VA: 0x3082FB0
	public void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x30830B0 Offset: 0x30831B1 VA: 0x30830B0
	internal Action<UnityWebRequest> get_WebRequestOverride() { }

	// RVA: 0x30831B0 Offset: 0x30832B1 VA: 0x30831B0
	internal void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	// RVA: 0x308D1C0 Offset: 0x308D2C1 VA: 0x308D1C0
	public AsyncOperationHandle get_ChainOperation() { }

	// RVA: 0x308D390 Offset: 0x308D491 VA: 0x308D390
	internal bool get_ShouldChainRequest() { }

	// RVA: 0x308D490 Offset: 0x308D591 VA: 0x308D490
	internal void OnSceneUnloaded(Scene scene) { }

	// RVA: 0x30832C0 Offset: 0x30833C1 VA: 0x30832C0
	public string get_StreamingAssetsSubFolder() { }

	// RVA: 0x30833D0 Offset: 0x30834D1 VA: 0x30833D0
	public string get_BuildPath() { }

	// RVA: 0x3083660 Offset: 0x3083761 VA: 0x3083660
	public string get_PlayerBuildDataPath() { }

	// RVA: 0x3083830 Offset: 0x3083931 VA: 0x3083830
	public string get_RuntimePath() { }

	// RVA: 0x3083D70 Offset: 0x3083E71 VA: 0x3083D70
	public void Log(string msg) { }

	// RVA: 0x30840E0 Offset: 0x30841E1 VA: 0x30840E0
	public void LogFormat(string format, object[] args) { }

	// RVA: 0x3083C90 Offset: 0x3083D91 VA: 0x3083C90
	public void LogWarning(string msg) { }

	// RVA: 0x3083FE0 Offset: 0x30840E1 VA: 0x3083FE0
	public void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x3083D00 Offset: 0x3083E01 VA: 0x3083D00
	public void LogError(string msg) { }

	// RVA: 0x3084800 Offset: 0x3084901 VA: 0x3084800
	public void LogException(AsyncOperationHandle op, Exception ex) { }

	// RVA: 0x3084060 Offset: 0x3084161 VA: 0x3084060
	public void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x3082D70 Offset: 0x3082E71 VA: 0x3082D70
	public string ResolveInternalId(string id) { }

	// RVA: 0x3083980 Offset: 0x3083A81 VA: 0x3083980
	public IEnumerable<IResourceLocator> get_ResourceLocators() { }

	// RVA: 0x308C870 Offset: 0x308C971 VA: 0x308C870
	public void AddResourceLocator(IResourceLocator loc, string localCatalogHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x308CA10 Offset: 0x308CB11 VA: 0x308CA10
	public void RemoveResourceLocator(IResourceLocator loc) { }

	// RVA: 0x308CC10 Offset: 0x308CD11 VA: 0x308CC10
	public void ClearResourceLocators() { }

	// RVA: 0x308DA50 Offset: 0x308DB51 VA: 0x308DA50
	internal bool GetResourceLocations(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x308E170 Offset: 0x308E271 VA: 0x308E170
	internal bool GetResourceLocations(IEnumerable keys, Type type, Addressables.MergeMode merge, out IList<IResourceLocation> locations) { }

	// RVA: 0x308E730 Offset: 0x308E831 VA: 0x308E730
	public AsyncOperationHandle<IResourceLocator> InitializeAsync(string runtimeDataPath, string providerSuffix, bool autoReleaseHandle = True) { }

	// RVA: 0x3084B40 Offset: 0x3084C41 VA: 0x3084B40
	public AsyncOperationHandle<IResourceLocator> InitializeAsync() { }

	// RVA: 0x308F250 Offset: 0x308F351 VA: 0x308F250
	internal ResourceLocationBase CreateCatalogLocationWithHashDependencies(string catalogPath, string hashFilePath) { }

	// RVA: 0x3084E50 Offset: 0x3084F51 VA: 0x3084E50
	public AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle = True, string providerSuffix) { }

	// RVA: 0x308FF20 Offset: 0x3090021 VA: 0x308FF20
	private AsyncOperationHandle<SceneInstance> TrackHandle(AsyncOperationHandle<SceneInstance> handle) { }

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<TObject> TrackHandle<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255DF10 Offset: 0x255E011 VA: 0x255DF10
	|-AddressablesImpl.TrackHandle<IList<IResourceLocation>>
	|-AddressablesImpl.TrackHandle<object>
	|
	|-RVA: 0x255DEC0 Offset: 0x255DFC1 VA: 0x255DEC0
	|-AddressablesImpl.TrackHandle<long>
	*/

	// RVA: 0x3090000 Offset: 0x3090101 VA: 0x3090000
	private AsyncOperationHandle TrackHandle(AsyncOperationHandle handle) { }

	// RVA: 0x3090040 Offset: 0x3090141 VA: 0x3090040
	internal void ClearTrackHandles() { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255CB30 Offset: 0x255CC31 VA: 0x255CB30
	|-AddressablesImpl.LoadAssetAsync<object>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(AsyncOperationHandle dep, object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255CBD0 Offset: 0x255CCD1 VA: 0x255CBD0
	|-AddressablesImpl.LoadAssetWithChain<object>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255C2D0 Offset: 0x255C3D1 VA: 0x255C2D0
	|-AddressablesImpl.LoadAssetAsync<object>
	*/

	// RVA: 0x30900A0 Offset: 0x30901A1 VA: 0x30900A0
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x30853E0 Offset: 0x30854E1 VA: 0x30853E0
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x3090300 Offset: 0x3090401 VA: 0x3090300
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, object key, Type type) { }

	// RVA: 0x3085860 Offset: 0x3085961 VA: 0x3085860
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255CD10 Offset: 0x255CE11 VA: 0x255CD10
	|-AddressablesImpl.LoadAssetsAsync<IAssetBundleResource>
	|-AddressablesImpl.LoadAssetsAsync<object>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255D3E0 Offset: 0x255D4E1 VA: 0x255D3E0
	|-AddressablesImpl.LoadAssetsWithChain<object>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255D020 Offset: 0x255D121 VA: 0x255D020
	|-AddressablesImpl.LoadAssetsAsync<object>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255D280 Offset: 0x255D381 VA: 0x255D280
	|-AddressablesImpl.LoadAssetsWithChain<object>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255CDD0 Offset: 0x255CED1 VA: 0x255CDD0
	|-AddressablesImpl.LoadAssetsAsync<object>
	*/

	// RVA: 0x3090550 Offset: 0x3090651 VA: 0x3090550
	private void OnHandleDestroyed(AsyncOperationHandle handle) { }

	// RVA: 0x30905E0 Offset: 0x30906E1 VA: 0x30905E0
	private void OnSceneHandleCompleted(AsyncOperationHandle handle) { }

	// RVA: 0x3090710 Offset: 0x3090811 VA: 0x3090710
	private void OnHandleCompleted(AsyncOperationHandle handle) { }

	// RVA: -1 Offset: -1
	public void Release<TObject>(TObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255D550 Offset: 0x255D651 VA: 0x255D550
	|-AddressablesImpl.Release<object>
	*/

	// RVA: -1 Offset: -1
	public void Release<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255D640 Offset: 0x255D741 VA: 0x255D640
	|-AddressablesImpl.Release<IList<AsyncOperationHandle>>
	|-AddressablesImpl.Release<IList<IAssetBundleResource>>
	|-AddressablesImpl.Release<List<string>>
	|-AddressablesImpl.Release<ContentCatalogData>
	|-AddressablesImpl.Release<GameObject>
	|-AddressablesImpl.Release<IResourceLocator>
	|-AddressablesImpl.Release<object>
	|-AddressablesImpl.Release<ResourceManagerRuntimeData>
	|
	|-RVA: 0x255DA70 Offset: 0x255DB71 VA: 0x255DA70
	|-AddressablesImpl.Release<SceneInstance>
	*/

	// RVA: 0x3085B10 Offset: 0x3085C11 VA: 0x3085B10
	public void Release(AsyncOperationHandle handle) { }

	// RVA: 0x3090810 Offset: 0x3090911 VA: 0x3090810
	private AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, object key) { }

	// RVA: 0x3090990 Offset: 0x3090A91 VA: 0x3090990
	private AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, IEnumerable keys) { }

	// RVA: 0x3086110 Offset: 0x3086211 VA: 0x3086110
	public AsyncOperationHandle<long> GetDownloadSizeAsync(object key) { }

	// RVA: 0x30863F0 Offset: 0x30864F1 VA: 0x30863F0
	public AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys) { }

	// RVA: 0x3090BB0 Offset: 0x3090CB1 VA: 0x3090BB0
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, object key, bool autoReleaseHandle) { }

	// RVA: 0x3090DF0 Offset: 0x3090EF1 VA: 0x3090DF0
	private static List<IResourceLocation> GatherDependenciesFromLocations(IList<IResourceLocation> locations) { }

	// RVA: 0x3087350 Offset: 0x3087451 VA: 0x3087350
	public AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = False) { }

	// RVA: 0x30915C0 Offset: 0x30916C1 VA: 0x30915C0
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	// RVA: 0x30877F0 Offset: 0x30878F1 VA: 0x30877F0
	public AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = False) { }

	// RVA: 0x3091800 Offset: 0x3091901 VA: 0x3091800
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle) { }

	// RVA: 0x3087AA0 Offset: 0x3087BA1 VA: 0x3087AA0
	public AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x3091A50 Offset: 0x3091B51 VA: 0x3091A50
	internal bool ClearDependencyCacheForKey(object key) { }

	// RVA: 0x3091A60 Offset: 0x3091B61 VA: 0x3091A60
	internal void AutoReleaseHandleOnCompletion(AsyncOperationHandle handle) { }

	// RVA: 0x3088040 Offset: 0x3088141 VA: 0x3088040
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle) { }

	// RVA: 0x30884C0 Offset: 0x30885C1 VA: 0x30884C0
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	// RVA: 0x3088B80 Offset: 0x3088C81 VA: 0x3088B80
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle) { }

	// RVA: 0x3091B40 Offset: 0x3091C41 VA: 0x3091B40
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x308A780 Offset: 0x308A881 VA: 0x308A780
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x308A820 Offset: 0x308A921 VA: 0x308A820
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x308A8C0 Offset: 0x308A9C1 VA: 0x308A8C0
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x3091BE0 Offset: 0x3091CE1 VA: 0x3091BE0
	private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x308A960 Offset: 0x308AA61 VA: 0x308A960
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x3091DB0 Offset: 0x3091EB1 VA: 0x3091DB0
	private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x308A640 Offset: 0x308A741 VA: 0x308A640
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x3085C20 Offset: 0x3085D21 VA: 0x3085C20
	public bool ReleaseInstance(GameObject instance) { }

	// RVA: 0x3091F80 Offset: 0x3092081 VA: 0x3091F80
	internal AsyncOperationHandle<SceneInstance> LoadSceneWithChain(AsyncOperationHandle dep, object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x308B200 Offset: 0x308B301 VA: 0x308B200
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100, bool trackHandle = True) { }

	// RVA: 0x308B530 Offset: 0x308B631 VA: 0x308B530
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100, bool trackHandle = True) { }

	// RVA: 0x308BBD0 Offset: 0x308BCD1 VA: 0x308BBD0
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle = True) { }

	// RVA: 0x308BE30 Offset: 0x308BF31 VA: 0x308BE30
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle = True) { }

	// RVA: 0x308BFF0 Offset: 0x308C0F1 VA: 0x308BFF0
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = True) { }

	// RVA: 0x3092140 Offset: 0x3092241 VA: 0x3092140
	internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle handle, bool autoReleaseHandle) { }

	// RVA: 0x30922A0 Offset: 0x30923A1 VA: 0x30922A0
	internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle) { }

	// RVA: 0x3092400 Offset: 0x3092501 VA: 0x3092400
	internal AsyncOperationHandle<SceneInstance> InternalUnloadScene(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle) { }

	// RVA: 0x308E090 Offset: 0x308E191 VA: 0x308E090
	private object EvaluateKey(object obj) { }

	// RVA: 0x308C1C0 Offset: 0x308C2C1 VA: 0x308C1C0
	internal AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = True) { }

	// RVA: 0x3092AC0 Offset: 0x3092BC1 VA: 0x3092AC0
	internal AddressablesImpl.ResourceLocatorInfo GetLocatorInfo(string c) { }

	// RVA: 0x3092C90 Offset: 0x3092D91 VA: 0x3092C90
	internal IEnumerable<string> get_CatalogsWithAvailableUpdates() { }

	// RVA: 0x308C4B0 Offset: 0x308C5B1 VA: 0x308C4B0
	internal AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogIds, bool autoReleaseHandle = True) { }

	// RVA: 0x3093540 Offset: 0x3093641 VA: 0x3093540 Slot: 4
	public bool Equals(IResourceLocation x, IResourceLocation y) { }

	// RVA: 0x3093810 Offset: 0x3093911 VA: 0x3093810 Slot: 5
	public int GetHashCode(IResourceLocation loc) { }

	[CompilerGeneratedAttribute] // RVA: 0x661A0 Offset: 0x662A1 VA: 0x661A0
	// RVA: 0x3093940 Offset: 0x3093A41 VA: 0x3093940
	private void <InitializeAsync>b__64_0(AsyncOperationHandle<IResourceLocator> x) { }

	[CompilerGeneratedAttribute] // RVA: 0x661B0 Offset: 0x662B1 VA: 0x661B0
	// RVA: 0x30939F0 Offset: 0x3093AF1 VA: 0x30939F0
	private void <TrackHandle>b__68_0(AsyncOperationHandle<SceneInstance> sceneHandle) { }

	[CompilerGeneratedAttribute] // RVA: 0x661C0 Offset: 0x662C1 VA: 0x661C0
	// RVA: 0x3093AC0 Offset: 0x3093BC1 VA: 0x3093AC0
	private void <DownloadDependenciesAsync>b__98_0(AsyncOperationHandle<IList<IAssetBundleResource>> op) { }

	[CompilerGeneratedAttribute] // RVA: 0x661D0 Offset: 0x662D1 VA: 0x661D0
	// RVA: 0x3093B40 Offset: 0x3093C41 VA: 0x3093B40
	private void <DownloadDependenciesAsync>b__98_1(AsyncOperationHandle<IList<IAssetBundleResource>> op) { }

	[CompilerGeneratedAttribute] // RVA: 0x661E0 Offset: 0x662E1 VA: 0x661E0
	// RVA: 0x3093BC0 Offset: 0x3093CC1 VA: 0x3093BC0
	private void <DownloadDependenciesAsync>b__100_0(AsyncOperationHandle<IList<IAssetBundleResource>> op) { }

	[CompilerGeneratedAttribute] // RVA: 0x661F0 Offset: 0x662F1 VA: 0x661F0
	// RVA: 0x3093C40 Offset: 0x3093D41 VA: 0x3093C40
	private void <DownloadDependenciesAsync>b__102_0(AsyncOperationHandle<IList<IAssetBundleResource>> op) { }

	[CompilerGeneratedAttribute] // RVA: 0x66200 Offset: 0x66301 VA: 0x66200
	// RVA: 0x3093CC0 Offset: 0x3093DC1 VA: 0x3093CC0
	private void <DownloadDependenciesAsync>b__102_1(AsyncOperationHandle<IList<IAssetBundleResource>> op) { }

	[CompilerGeneratedAttribute] // RVA: 0x66210 Offset: 0x66311 VA: 0x66210
	// RVA: 0x3093D40 Offset: 0x3093E41 VA: 0x3093D40
	private void <AutoReleaseHandleOnCompletion>b__104_0(AsyncOperationHandle op) { }

	[CompilerGeneratedAttribute] // RVA: 0x66220 Offset: 0x66321 VA: 0x66220
	// RVA: 0x3093D80 Offset: 0x3093E81 VA: 0x3093D80
	private void <InternalUnloadScene>b__125_0(AsyncOperationHandle<SceneInstance> op) { }

	[CompilerGeneratedAttribute] // RVA: 0x66230 Offset: 0x66331 VA: 0x66230
	// RVA: 0x3093E00 Offset: 0x3093F01 VA: 0x3093E00
	private void <CheckForCatalogUpdates>b__127_0(AsyncOperationHandle o) { }
}

