// Namespace: 
internal class TextDataProvider.InternalOp // TypeDefIndex: 5601
{
	// Fields
	private TextDataProvider m_Provider; // 0x10
	private UnityWebRequestAsyncOperation m_RequestOperation; // 0x18
	private WebRequestQueueOperation m_RequestQueueOperation; // 0x20
	private ProvideHandle m_PI; // 0x28
	private bool m_IgnoreFailures; // 0x40
	private bool m_Complete; // 0x41
	private int m_Timeout; // 0x44

	// Methods

	// RVA: 0x363B500 Offset: 0x363B601 VA: 0x363B500
	private float GetPercentComplete() { }

	// RVA: 0x3636D80 Offset: 0x3636E81 VA: 0x3636D80
	public void Start(ProvideHandle provideHandle, TextDataProvider rawProvider) { }

	// RVA: 0x363B6D0 Offset: 0x363B7D1 VA: 0x363B6D0
	private bool WaitForCompletionHandler() { }

	// RVA: 0x363B760 Offset: 0x363B861 VA: 0x363B760
	private void RequestOperation_completed(AsyncOperation op) { }

	// RVA: 0x363BB60 Offset: 0x363BC61 VA: 0x363BB60
	protected void CompleteOperation(string text, Exception exception) { }

	// RVA: 0x363B520 Offset: 0x363B621 VA: 0x363B520
	private object ConvertText(string text) { }

	// RVA: 0x363BC10 Offset: 0x363BD11 VA: 0x363BC10 Slot: 4
	protected virtual void SendWebRequest(string path) { }

	// RVA: 0x3636D70 Offset: 0x3636E71 VA: 0x3636D70
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x72F50 Offset: 0x73051 VA: 0x72F50
	// RVA: 0x363BEB0 Offset: 0x363BFB1 VA: 0x363BEB0
	private void <SendWebRequest>b__13_0(UnityWebRequestAsyncOperation asyncOperation) { }
}

