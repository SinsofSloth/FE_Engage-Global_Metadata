// Namespace: UnityEngine.AddressableAssets.Initialization
internal class InitializationOperation : AsyncOperationBase<IResourceLocator> // TypeDefIndex: 7324
{
	// Fields
	private AsyncOperationHandle<ResourceManagerRuntimeData> m_rtdOp; // 0x88
	private AsyncOperationHandle<IResourceLocator> m_loadCatalogOp; // 0xA0
	private string m_ProviderSuffix; // 0xB8
	private AddressablesImpl m_Addressables; // 0xC0
	private ResourceManagerDiagnostics m_Diagnostics; // 0xC8
	private InitalizationObjectsOperation m_InitGroupOps; // 0xD0

	// Properties
	protected override float Progress { get; }
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x309A4E0 Offset: 0x309A5E1 VA: 0x309A4E0
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x309A6C0 Offset: 0x309A7C1 VA: 0x309A6C0 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x309A750 Offset: 0x309A851 VA: 0x309A750 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x308EC30 Offset: 0x308ED31 VA: 0x308EC30
	internal static AsyncOperationHandle<IResourceLocator> CreateInitializationOperation(AddressablesImpl aa, string playerSettingsLocation, string providerSuffix) { }

	// RVA: 0x309A7A0 Offset: 0x309A8A1 VA: 0x309A7A0 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x309A980 Offset: 0x309AA81 VA: 0x309A980 Slot: 28
	protected override void Execute() { }

	// RVA: 0x309CC80 Offset: 0x309CD81 VA: 0x309CC80
	private static void LoadProvider(AddressablesImpl addressables, ObjectInitializationData providerData, string providerSuffix) { }

	// RVA: 0x309D110 Offset: 0x309D211 VA: 0x309D110
	private static AsyncOperationHandle<IResourceLocator> OnCatalogDataLoaded(AddressablesImpl addressables, AsyncOperationHandle<ContentCatalogData> op, string providerSuffix, IResourceLocation remoteHashLocation) { }

	// RVA: 0x308F8A0 Offset: 0x308F9A1 VA: 0x308F8A0
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(AddressablesImpl addressables, IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation) { }

	// RVA: 0x309D6C0 Offset: 0x309D7C1 VA: 0x309D6C0
	public AsyncOperationHandle<IResourceLocator> LoadContentCatalog(IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation) { }

	// RVA: 0x309CA30 Offset: 0x309CB31 VA: 0x309CA30
	internal AsyncOperationHandle<IResourceLocator> LoadContentCatalogInternal(IList<IResourceLocation> catalogs, int index, ResourceLocationMap locMap, IResourceLocation remoteHashLocation) { }

	// RVA: 0x309D710 Offset: 0x309D811 VA: 0x309D710
	private void LoadOpComplete(AsyncOperationHandle<IResourceLocator> op, IList<IResourceLocation> catalogs, ResourceLocationMap locMap, int index, IResourceLocation remoteHashLocation) { }
}

