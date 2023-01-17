// Namespace: 
public enum ContentCatalogProvider.DependencyHashIndex // TypeDefIndex: 7304
{
	// Fields
	public int value__; // 0x0
	public const ContentCatalogProvider.DependencyHashIndex Remote = 0;
	public const ContentCatalogProvider.DependencyHashIndex Cache = 1;
	public const ContentCatalogProvider.DependencyHashIndex Count = 2;
}

// Namespace: 
internal class ContentCatalogProvider.InternalOp.BundledCatalog // TypeDefIndex: 7305
{
	// Fields
	private readonly string m_BundlePath; // 0x10
	private bool m_OpInProgress; // 0x18
	private AssetBundleCreateRequest m_LoadBundleRequest; // 0x20
	internal AssetBundle m_CatalogAssetBundle; // 0x28
	private AssetBundleRequest m_LoadTextAssetRequest; // 0x30
	private ContentCatalogData m_CatalogData; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x656C0 Offset: 0x657C1 VA: 0x656C0
	private Action<ContentCatalogData> OnLoaded; // 0x40

	// Properties
	public bool OpInProgress { get; }
	public bool OpIsSuccess { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x66360 Offset: 0x66461 VA: 0x66360
	// RVA: 0x30A2C50 Offset: 0x30A2D51 VA: 0x30A2C50
	public void add_OnLoaded(Action<ContentCatalogData> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66370 Offset: 0x66471 VA: 0x66370
	// RVA: 0x30A3470 Offset: 0x30A3571 VA: 0x30A3470
	public void remove_OnLoaded(Action<ContentCatalogData> value) { }

	// RVA: 0x30A3520 Offset: 0x30A3621 VA: 0x30A3520
	public bool get_OpInProgress() { }

	// RVA: 0x30A3530 Offset: 0x30A3631 VA: 0x30A3530
	public bool get_OpIsSuccess() { }

	// RVA: 0x30A2B30 Offset: 0x30A2C31 VA: 0x30A2B30
	public void .ctor(string bundlePath) { }

	// RVA: 0x30A3550 Offset: 0x30A3651 VA: 0x30A3550 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x30A35E0 Offset: 0x30A36E1 VA: 0x30A35E0
	private void Unload() { }

	// RVA: 0x30A2D00 Offset: 0x30A2E01 VA: 0x30A2D00
	public void LoadCatalogFromBundleAsync() { }

	// RVA: 0x30A3620 Offset: 0x30A3721 VA: 0x30A3620
	private void LoadTextAssetRequestComplete(AsyncOperation op) { }

	// RVA: 0x30A2A30 Offset: 0x30A2B31 VA: 0x30A2A30
	public bool WaitForCompletion() { }

	[CompilerGeneratedAttribute] // RVA: 0x66380 Offset: 0x66481 VA: 0x66380
	// RVA: 0x30A3800 Offset: 0x30A3901 VA: 0x30A3800
	private void <LoadCatalogFromBundleAsync>b__16_0(AsyncOperation loadOp) { }
}

// Namespace: 
internal class ContentCatalogProvider.InternalOp // TypeDefIndex: 7306
{
	// Fields
	private string m_LocalDataPath; // 0x10
	private string m_RemoteHashValue; // 0x18
	internal string m_LocalHashValue; // 0x20
	private ProvideHandle m_ProviderInterface; // 0x28
	internal ContentCatalogData m_ContentCatalogData; // 0x40
	private AsyncOperationHandle<ContentCatalogData> m_ContentCatalogDataLoadOp; // 0x48
	private ContentCatalogProvider.InternalOp.BundledCatalog m_BundledCatalog; // 0x60

	// Methods

	// RVA: 0x3098320 Offset: 0x3098421 VA: 0x3098320
	public void Start(ProvideHandle providerInterface, bool disableCatalogUpdateOnStart, bool isLocalCatalogInBundle) { }

	// RVA: 0x30A2940 Offset: 0x30A2A41 VA: 0x30A2940
	private bool WaitForCompletionCallback() { }

	// RVA: 0x30981B0 Offset: 0x30982B1 VA: 0x30981B0
	public void Release() { }

	// RVA: 0x30A23F0 Offset: 0x30A24F1 VA: 0x30A23F0
	internal void LoadCatalog(string idToLoad, bool isLocalCatalogInBundle, bool isLocalCatalog) { }

	// RVA: 0x30A2E30 Offset: 0x30A2F31 VA: 0x30A2E30
	private void CatalogLoadOpCompleteCallback(AsyncOperationHandle<ContentCatalogData> op) { }

	// RVA: 0x30A2320 Offset: 0x30A2421 VA: 0x30A2320
	private string GetTransformedInternalId(IResourceLocation loc) { }

	// RVA: 0x30A1940 Offset: 0x30A1A41 VA: 0x30A1940
	internal string DetermineIdToLoad(IResourceLocation location, IList<object> dependencyObjects, bool disableCatalogUpdateOnStart = False) { }

	// RVA: 0x30A2F20 Offset: 0x30A3021 VA: 0x30A2F20
	private void OnCatalogLoaded(ContentCatalogData ccd) { }

	// RVA: 0x3098310 Offset: 0x3098411 VA: 0x3098310
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x66350 Offset: 0x66451 VA: 0x66350
	// RVA: 0x30A3120 Offset: 0x30A3221 VA: 0x30A3120
	private void <LoadCatalog>b__10_0(ContentCatalogData ccd) { }
}

