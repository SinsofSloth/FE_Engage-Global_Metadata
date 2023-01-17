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

