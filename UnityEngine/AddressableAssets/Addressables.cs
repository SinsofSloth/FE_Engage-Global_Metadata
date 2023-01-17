// Namespace: UnityEngine.AddressableAssets
public static class Addressables // TypeDefIndex: 7254
{
	// Fields
	internal static bool reinitializeAddressables; // 0x0
	internal static AddressablesImpl m_AddressablesInstance; // 0x8
	public const string kAddressablesRuntimeDataPath = "AddressablesRuntimeDataPath";
	private const string k_AddressablesLogConditional = "ADDRESSABLES_LOG_ALL";
	public const string kAddressablesRuntimeBuildLogPath = "AddressablesRuntimeBuildLog";
	public static string LibraryPath; // 0x10

	// Properties
	private static AddressablesImpl m_Addressables { get; }
	public static ResourceManager ResourceManager { get; }
	internal static AddressablesImpl Instance { get; }
	public static IInstanceProvider InstanceProvider { get; }
	public static Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	internal static Action<UnityWebRequest> WebRequestOverride { get; set; }
	public static string StreamingAssetsSubFolder { get; }
	public static string BuildPath { get; }
	public static string PlayerBuildDataPath { get; }
	public static string RuntimePath { get; }
	public static IEnumerable<IResourceLocator> ResourceLocators { get; }
	[ObsoleteAttribute] // RVA: 0x66510 Offset: 0x66611 VA: 0x66510
	public static AsyncOperationHandle<IResourceLocator> InitializationOperation { get; }

	// Methods

	// RVA: 0x30828E0 Offset: 0x30829E1 VA: 0x30828E0
	private static AddressablesImpl get_m_Addressables() { }

	// RVA: 0x3082950 Offset: 0x3082A51 VA: 0x3082950
	public static ResourceManager get_ResourceManager() { }

	// RVA: 0x3082AD0 Offset: 0x3082BD1 VA: 0x3082AD0
	internal static AddressablesImpl get_Instance() { }

	// RVA: 0x3082B90 Offset: 0x3082C91 VA: 0x3082B90
	public static IInstanceProvider get_InstanceProvider() { }

	// RVA: 0x3082C60 Offset: 0x3082D61 VA: 0x3082C60
	public static string ResolveInternalId(string id) { }

	// RVA: 0x3082DE0 Offset: 0x3082EE1 VA: 0x3082DE0
	public static Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	// RVA: 0x3082ED0 Offset: 0x3082FD1 VA: 0x3082ED0
	public static void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x3082FE0 Offset: 0x30830E1 VA: 0x3082FE0
	internal static Action<UnityWebRequest> get_WebRequestOverride() { }

	// RVA: 0x30830D0 Offset: 0x30831D1 VA: 0x30830D0
	internal static void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	// RVA: 0x30831E0 Offset: 0x30832E1 VA: 0x30831E0
	public static string get_StreamingAssetsSubFolder() { }

	// RVA: 0x3083310 Offset: 0x3083411 VA: 0x3083310
	public static string get_BuildPath() { }

	// RVA: 0x3083520 Offset: 0x3083621 VA: 0x3083520
	public static string get_PlayerBuildDataPath() { }

	// RVA: 0x30836F0 Offset: 0x30837F1 VA: 0x30836F0
	public static string get_RuntimePath() { }

	// RVA: 0x30838C0 Offset: 0x30839C1 VA: 0x30838C0
	public static IEnumerable<IResourceLocator> get_ResourceLocators() { }

	[ConditionalAttribute] // RVA: 0x65ED0 Offset: 0x65FD1 VA: 0x65ED0
	// RVA: 0x3083AB0 Offset: 0x3083BB1 VA: 0x3083AB0
	internal static void InternalSafeSerializationLog(string msg, LogType logType = 3) { }

	[ConditionalAttribute] // RVA: 0x65F10 Offset: 0x66011 VA: 0x65F10
	// RVA: 0x3083DE0 Offset: 0x3083EE1 VA: 0x3083DE0
	internal static void InternalSafeSerializationLogFormat(string format, LogType logType = 3, object[] args) { }

	[ConditionalAttribute] // RVA: 0x65F50 Offset: 0x66051 VA: 0x65F50
	// RVA: 0x3084160 Offset: 0x3084261 VA: 0x3084160
	public static void Log(string msg) { }

	[ConditionalAttribute] // RVA: 0x65F90 Offset: 0x66091 VA: 0x65F90
	// RVA: 0x3084270 Offset: 0x3084371 VA: 0x3084270
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x3084380 Offset: 0x3084481 VA: 0x3084380
	public static void LogWarning(string msg) { }

	// RVA: 0x3084490 Offset: 0x3084591 VA: 0x3084490
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x30845A0 Offset: 0x30846A1 VA: 0x30845A0
	public static void LogError(string msg) { }

	// RVA: 0x30846B0 Offset: 0x30847B1 VA: 0x30846B0
	public static void LogException(AsyncOperationHandle op, Exception ex) { }

	// RVA: 0x30848B0 Offset: 0x30849B1 VA: 0x30848B0
	public static void LogErrorFormat(string format, object[] args) { }

	[ObsoleteAttribute] // RVA: 0x65FD0 Offset: 0x660D1 VA: 0x65FD0
	// RVA: 0x30849C0 Offset: 0x3084AC1 VA: 0x30849C0
	public static AsyncOperationHandle<IResourceLocator> Initialize() { }

	// RVA: 0x3084A50 Offset: 0x3084B51 VA: 0x3084A50
	public static AsyncOperationHandle<IResourceLocator> InitializeAsync() { }

	[ObsoleteAttribute] // RVA: 0x65FE0 Offset: 0x660E1 VA: 0x65FE0
	// RVA: 0x3084CA0 Offset: 0x3084DA1 VA: 0x3084CA0
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(string catalogPath, string providerSuffix) { }

	// RVA: 0x3084D40 Offset: 0x3084E41 VA: 0x3084D40
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix) { }

	// RVA: 0x3085100 Offset: 0x3085201 VA: 0x3085100
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix) { }

	// RVA: 0x3085210 Offset: 0x3085311 VA: 0x3085210
	public static AsyncOperationHandle<IResourceLocator> get_InitializationOperation() { }

	[ObsoleteAttribute] // RVA: 0x65FF0 Offset: 0x660F1 VA: 0x65FF0
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAsset<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255B290 Offset: 0x255B391 VA: 0x255B290
	|-Addressables.LoadAsset<object>
	*/

	[ObsoleteAttribute] // RVA: 0x66000 Offset: 0x66101 VA: 0x66000
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAsset<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255B1E0 Offset: 0x255B2E1 VA: 0x255B1E0
	|-Addressables.LoadAsset<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255B450 Offset: 0x255B551 VA: 0x255B450
	|-Addressables.LoadAssetAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255B340 Offset: 0x255B441 VA: 0x255B340
	|-Addressables.LoadAssetAsync<GameObject>
	|-Addressables.LoadAssetAsync<object>
	*/

	[ObsoleteAttribute] // RVA: 0x66010 Offset: 0x66111 VA: 0x66010
	// RVA: 0x3085220 Offset: 0x3085321 VA: 0x3085220
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(IList<object> keys, Addressables.MergeMode mode, Type type) { }

	[ObsoleteAttribute] // RVA: 0x66020 Offset: 0x66121 VA: 0x66020
	// RVA: 0x30852D0 Offset: 0x30853D1 VA: 0x30852D0
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IList<object> keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x30855A0 Offset: 0x30856A1 VA: 0x30855A0
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	[ObsoleteAttribute] // RVA: 0x66030 Offset: 0x66131 VA: 0x66030
	// RVA: 0x30856B0 Offset: 0x30857B1 VA: 0x30856B0
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(object key, Type type) { }

	// RVA: 0x3085750 Offset: 0x3085851 VA: 0x3085750
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type) { }

	[ObsoleteAttribute] // RVA: 0x66040 Offset: 0x66141 VA: 0x66040
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255B560 Offset: 0x255B661 VA: 0x255B560
	|-Addressables.LoadAssets<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255B780 Offset: 0x255B881 VA: 0x255B780
	|-Addressables.LoadAssetsAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255BAF0 Offset: 0x255BBF1 VA: 0x255BAF0
	|-Addressables.LoadAssetsAsync<object>
	*/

	[ObsoleteAttribute] // RVA: 0x66050 Offset: 0x66151 VA: 0x66050
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255B6C0 Offset: 0x255B7C1 VA: 0x255B6C0
	|-Addressables.LoadAssets<object>
	*/

	[ObsoleteAttribute] // RVA: 0x66060 Offset: 0x66161 VA: 0x66060
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255B9C0 Offset: 0x255BAC1 VA: 0x255B9C0
	|-Addressables.LoadAssetsAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255BC20 Offset: 0x255BD21 VA: 0x255BC20
	|-Addressables.LoadAssetsAsync<object>
	*/

	[ObsoleteAttribute] // RVA: 0x66070 Offset: 0x66171 VA: 0x66070
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255BE80 Offset: 0x255BF81 VA: 0x255BE80
	|-Addressables.LoadAssetsAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255BFB0 Offset: 0x255C0B1 VA: 0x255BFB0
	|-Addressables.LoadAssetsAsync<object>
	*/

	[ObsoleteAttribute] // RVA: 0x66080 Offset: 0x66181 VA: 0x66080
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(object key, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255B610 Offset: 0x255B711 VA: 0x255B610
	|-Addressables.LoadAssets<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255B8A0 Offset: 0x255B9A1 VA: 0x255B8A0
	|-Addressables.LoadAssetsAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255BD50 Offset: 0x255BE51 VA: 0x255BD50
	|-Addressables.LoadAssetsAsync<object>
	*/

	// RVA: -1 Offset: -1
	public static void Release<TObject>(TObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255C0E0 Offset: 0x255C1E1 VA: 0x255C0E0
	|-Addressables.Release<object>
	*/

	// RVA: -1 Offset: -1
	public static void Release<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255C1C0 Offset: 0x255C2C1 VA: 0x255C1C0
	|-Addressables.Release<object>
	*/

	// RVA: 0x3085A10 Offset: 0x3085B11 VA: 0x3085A10
	public static void Release(AsyncOperationHandle handle) { }

	// RVA: 0x3085B50 Offset: 0x3085C51 VA: 0x3085B50
	public static bool ReleaseInstance(GameObject instance) { }

	// RVA: 0x3085D70 Offset: 0x3085E71 VA: 0x3085D70
	public static bool ReleaseInstance(AsyncOperationHandle handle) { }

	// RVA: 0x3085E70 Offset: 0x3085F71 VA: 0x3085E70
	public static bool ReleaseInstance(AsyncOperationHandle<GameObject> handle) { }

	[ObsoleteAttribute] // RVA: 0x66090 Offset: 0x66191 VA: 0x66090
	// RVA: 0x3085F80 Offset: 0x3086081 VA: 0x3085F80
	public static AsyncOperationHandle<long> GetDownloadSize(object key) { }

	// RVA: 0x3086010 Offset: 0x3086111 VA: 0x3086010
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(object key) { }

	// RVA: 0x30861F0 Offset: 0x30862F1 VA: 0x30861F0
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(string key) { }

	[ObsoleteAttribute] // RVA: 0x660A0 Offset: 0x661A1 VA: 0x660A0
	// RVA: 0x30862F0 Offset: 0x30863F1 VA: 0x30862F0
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(IList<object> keys) { }

	// RVA: 0x30870B0 Offset: 0x30871B1 VA: 0x30870B0
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys) { }

	[ObsoleteAttribute] // RVA: 0x660B0 Offset: 0x661B1 VA: 0x660B0
	// RVA: 0x30871B0 Offset: 0x30872B1 VA: 0x30871B0
	public static AsyncOperationHandle DownloadDependencies(object key) { }

	// RVA: 0x3087240 Offset: 0x3087341 VA: 0x3087240
	public static AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = False) { }

	// RVA: 0x30876E0 Offset: 0x30877E1 VA: 0x30876E0
	public static AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = False) { }

	[ObsoleteAttribute] // RVA: 0x660C0 Offset: 0x661C1 VA: 0x660C0
	// RVA: 0x3087990 Offset: 0x3087A91 VA: 0x3087990
	public static AsyncOperationHandle DownloadDependenciesAsync(IList<object> keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x3087E40 Offset: 0x3087F41 VA: 0x3087E40
	public static AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x3087F50 Offset: 0x3088051 VA: 0x3087F50
	public static void ClearDependencyCacheAsync(object key) { }

	// RVA: 0x30883D0 Offset: 0x30884D1 VA: 0x30883D0
	public static void ClearDependencyCacheAsync(IList<IResourceLocation> locations) { }

	[ObsoleteAttribute] // RVA: 0x660D0 Offset: 0x661D1 VA: 0x660D0
	// RVA: 0x3088A90 Offset: 0x3088B91 VA: 0x3088A90
	public static void ClearDependencyCacheAsync(IList<object> keys) { }

	// RVA: 0x3089140 Offset: 0x3089241 VA: 0x3089140
	public static void ClearDependencyCacheAsync(IEnumerable keys) { }

	// RVA: 0x3089230 Offset: 0x3089331 VA: 0x3089230
	public static void ClearDependencyCacheAsync(string key) { }

	// RVA: 0x3089320 Offset: 0x3089421 VA: 0x3089320
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle) { }

	// RVA: 0x3089430 Offset: 0x3089531 VA: 0x3089430
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	[ObsoleteAttribute] // RVA: 0x660E0 Offset: 0x661E1 VA: 0x660E0
	// RVA: 0x3089540 Offset: 0x3089641 VA: 0x3089540
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<object> keys, bool autoReleaseHandle) { }

	// RVA: 0x3089650 Offset: 0x3089751 VA: 0x3089650
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle) { }

	// RVA: 0x3089760 Offset: 0x3089861 VA: 0x3089760
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(string key, bool autoReleaseHandle) { }

	[ObsoleteAttribute] // RVA: 0x660F0 Offset: 0x661F1 VA: 0x660F0
	// RVA: 0x3089870 Offset: 0x3089971 VA: 0x3089870
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x66100 Offset: 0x66201 VA: 0x66100
	// RVA: 0x3089A90 Offset: 0x3089B91 VA: 0x3089A90
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x66110 Offset: 0x66211 VA: 0x66110
	// RVA: 0x3089D30 Offset: 0x3089E31 VA: 0x3089D30
	public static AsyncOperationHandle<GameObject> Instantiate(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x66120 Offset: 0x66221 VA: 0x66120
	// RVA: 0x3089F50 Offset: 0x308A051 VA: 0x3089F50
	public static AsyncOperationHandle<GameObject> Instantiate(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x66130 Offset: 0x66231 VA: 0x66130
	// RVA: 0x308A1F0 Offset: 0x308A2F1 VA: 0x308A1F0
	public static AsyncOperationHandle<GameObject> Instantiate(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x66140 Offset: 0x66241 VA: 0x66140
	// RVA: 0x308A400 Offset: 0x308A501 VA: 0x308A400
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x308A4E0 Offset: 0x308A5E1 VA: 0x308A4E0
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x3089B90 Offset: 0x3089C91 VA: 0x3089B90
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x3089DF0 Offset: 0x3089EF1 VA: 0x3089DF0
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x308A050 Offset: 0x308A151 VA: 0x308A050
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x308A2D0 Offset: 0x308A3D1 VA: 0x308A2D0
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x3089960 Offset: 0x3089A61 VA: 0x3089960
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x66150 Offset: 0x66251 VA: 0x66150
	// RVA: 0x308AE00 Offset: 0x308AF01 VA: 0x308AE00
	public static AsyncOperationHandle<SceneInstance> LoadScene(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	[ObsoleteAttribute] // RVA: 0x66160 Offset: 0x66261 VA: 0x66160
	// RVA: 0x308AFE0 Offset: 0x308B0E1 VA: 0x308AFE0
	public static AsyncOperationHandle<SceneInstance> LoadScene(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x308AEC0 Offset: 0x308AFC1 VA: 0x308AEC0
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x308B0A0 Offset: 0x308B1A1 VA: 0x308B0A0
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	[ObsoleteAttribute] // RVA: 0x66170 Offset: 0x66271 VA: 0x66170
	// RVA: 0x308B600 Offset: 0x308B701 VA: 0x308B600
	public static AsyncOperationHandle<SceneInstance> UnloadScene(SceneInstance scene, bool autoReleaseHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x66180 Offset: 0x66281 VA: 0x66180
	// RVA: 0x308B7C0 Offset: 0x308B8C1 VA: 0x308B7C0
	public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle handle, bool autoReleaseHandle = True) { }

	[ObsoleteAttribute] // RVA: 0x66190 Offset: 0x66291 VA: 0x66190
	// RVA: 0x308B9A0 Offset: 0x308BAA1 VA: 0x308B9A0
	public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = True) { }

	// RVA: 0x308B6B0 Offset: 0x308B7B1 VA: 0x308B6B0
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle = True) { }

	// RVA: 0x308B880 Offset: 0x308B981 VA: 0x308B880
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle = True) { }

	// RVA: 0x308BA60 Offset: 0x308BB61 VA: 0x308BA60
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = True) { }

	// RVA: 0x308C0C0 Offset: 0x308C1C1 VA: 0x308C0C0
	public static AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = True) { }

	// RVA: 0x308C3A0 Offset: 0x308C4A1 VA: 0x308C3A0
	public static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogs, bool autoReleaseHandle = True) { }

	// RVA: 0x308C780 Offset: 0x308C881 VA: 0x308C780
	public static void AddResourceLocator(IResourceLocator locator, string localCatalogHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x308C940 Offset: 0x308CA41 VA: 0x308C940
	public static void RemoveResourceLocator(IResourceLocator locator) { }

	// RVA: 0x308CB10 Offset: 0x308CC11 VA: 0x308CB10
	public static void ClearResourceLocators() { }

	// RVA: 0x308CC70 Offset: 0x308CD71 VA: 0x308CC70
	private static void .cctor() { }
}

