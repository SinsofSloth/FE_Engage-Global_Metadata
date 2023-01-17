// Namespace: UnityEngine.ResourceManagement.ResourceProviders
internal class AssetBundleResource : IAssetBundleResource // TypeDefIndex: 5578
{
	// Fields
	private AssetBundle m_AssetBundle; // 0x10
	private DownloadHandlerAssetBundle m_downloadHandler; // 0x18
	private AsyncOperation m_RequestOperation; // 0x20
	private WebRequestQueueOperation m_WebRequestQueueOperation; // 0x28
	internal ProvideHandle m_ProvideHandle; // 0x30
	internal AssetBundleRequestOptions m_Options; // 0x48
	private bool m_WebRequestCompletedCallbackCalled; // 0x50
	private int m_Retries; // 0x54
	private long m_BytesToDownload; // 0x58
	private long m_DownloadedBytes; // 0x60
	private bool m_Completed; // 0x68
	private const int k_WaitForWebRequestMainThreadSleep = 1;
	private string m_TransformedInternalId; // 0x70

	// Methods

	// RVA: 0x36241E0 Offset: 0x36242E1 VA: 0x36241E0
	internal UnityWebRequest CreateWebRequest(IResourceLocation loc) { }

	// RVA: 0x3624210 Offset: 0x3624311 VA: 0x3624210
	internal UnityWebRequest CreateWebRequest(string url) { }

	// RVA: 0x3624380 Offset: 0x3624481 VA: 0x3624380
	private float PercentComplete() { }

	// RVA: 0x36243A0 Offset: 0x36244A1 VA: 0x36243A0
	private DownloadStatus GetDownloadStatus() { }

	// RVA: 0x3624530 Offset: 0x3624631 VA: 0x3624530 Slot: 4
	public AssetBundle GetAssetBundle() { }

	// RVA: 0x36234F0 Offset: 0x36235F1 VA: 0x36234F0
	internal void Start(ProvideHandle provideHandle) { }

	// RVA: 0x3624EA0 Offset: 0x3624FA1 VA: 0x3624EA0
	private bool WaitForCompletionHandler() { }

	// RVA: 0x3625600 Offset: 0x3625701 VA: 0x3625600
	private void AddCallbackInvokeIfDone(AsyncOperation operation, Action<AsyncOperation> callback) { }

	// RVA: 0x3625690 Offset: 0x3625791 VA: 0x3625690
	internal static void GetLoadInfo(ProvideHandle handle, out AssetBundleResource.LoadType loadType, out string path) { }

	// RVA: 0x3624950 Offset: 0x3624A51 VA: 0x3624950
	private void BeginOperation() { }

	// RVA: 0x3626030 Offset: 0x3626131 VA: 0x3626030
	private void LocalRequestOperationCompleted(AsyncOperation op) { }

	// RVA: 0x3625AB0 Offset: 0x3625BB1 VA: 0x3625AB0
	private void CompleteBundleLoad(AssetBundle bundle) { }

	// RVA: 0x36250D0 Offset: 0x36251D1 VA: 0x36250D0
	private void WebRequestOperationCompleted(AsyncOperation op) { }

	// RVA: 0x3623C90 Offset: 0x3623D91 VA: 0x3623C90
	public void Unload() { }

	// RVA: 0x36234E0 Offset: 0x36235E1 VA: 0x36234E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x72EE0 Offset: 0x72FE1 VA: 0x72EE0
	// RVA: 0x3626220 Offset: 0x3626321 VA: 0x3626220
	private void <BeginOperation>b__23_0(UnityWebRequestAsyncOperation asyncOp) { }
}

