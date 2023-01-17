// Namespace: UnityEngine.Networking
[NativeHeaderAttribute] // RVA: 0x6BD40 Offset: 0x6BE41 VA: 0x6BD40
public class UnityWebRequest : IDisposable // TypeDefIndex: 4444
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal DownloadHandler m_DownloadHandler; // 0x18
	internal UploadHandler m_UploadHandler; // 0x20
	internal CertificateHandler m_CertificateHandler; // 0x28
	internal Uri m_Uri; // 0x30
	public const string kHttpVerbGET = "GET";
	public const string kHttpVerbHEAD = "HEAD";
	public const string kHttpVerbPOST = "POST";
	public const string kHttpVerbPUT = "PUT";
	public const string kHttpVerbCREATE = "CREATE";
	public const string kHttpVerbDELETE = "DELETE";
	[DebuggerBrowsableAttribute] // RVA: 0x6BF00 Offset: 0x6C001 VA: 0x6BF00
	[CompilerGeneratedAttribute] // RVA: 0x6BF00 Offset: 0x6C001 VA: 0x6BF00
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	[DebuggerBrowsableAttribute] // RVA: 0x6BF40 Offset: 0x6C041 VA: 0x6BF40
	[CompilerGeneratedAttribute] // RVA: 0x6BF40 Offset: 0x6C041 VA: 0x6BF40
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	[CompilerGeneratedAttribute] // RVA: 0x6BF80 Offset: 0x6C081 VA: 0x6BF80
	[DebuggerBrowsableAttribute] // RVA: 0x6BF80 Offset: 0x6C081 VA: 0x6BF80
	private bool <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

	// Properties
	public bool disposeCertificateHandlerOnDispose { get; set; }
	public bool disposeDownloadHandlerOnDispose { get; set; }
	public bool disposeUploadHandlerOnDispose { get; set; }
	public string method { get; set; }
	public string error { get; }
	public string url { get; set; }
	public long responseCode { get; }
	public bool isModifiable { get; }
	public bool isDone { get; }
	public UnityWebRequest.Result result { get; }
	public float downloadProgress { get; }
	public ulong downloadedBytes { get; }
	public int redirectLimit { set; }
	[ObsoleteAttribute] // RVA: 0x6C3E0 Offset: 0x6C4E1 VA: 0x6C3E0
	public bool chunkedTransfer { set; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; set; }
	public int timeout { set; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x6C000 Offset: 0x6C101 VA: 0x6C000
	[NativeConditionalAttribute] // RVA: 0x6C000 Offset: 0x6C101 VA: 0x6C000
	// RVA: 0x1C48E20 Offset: 0x1C48F21 VA: 0x1C48E20
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6C060 Offset: 0x6C161 VA: 0x6C060
	// RVA: 0x1C48E70 Offset: 0x1C48F71 VA: 0x1C48E70
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6C070 Offset: 0x6C171 VA: 0x6C070
	// RVA: 0x1C48EC0 Offset: 0x1C48FC1 VA: 0x1C48EC0
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6C080 Offset: 0x6C181 VA: 0x6C080
	// RVA: 0x1C48ED0 Offset: 0x1C48FD1 VA: 0x1C48ED0
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6C090 Offset: 0x6C191 VA: 0x6C090
	// RVA: 0x1C48EE0 Offset: 0x1C48FE1 VA: 0x1C48EE0
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6C0A0 Offset: 0x6C1A1 VA: 0x6C0A0
	// RVA: 0x1C48EF0 Offset: 0x1C48FF1 VA: 0x1C48EF0
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6C0B0 Offset: 0x6C1B1 VA: 0x6C0B0
	// RVA: 0x1C48F00 Offset: 0x1C49001 VA: 0x1C48F00
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6C0C0 Offset: 0x6C1C1 VA: 0x6C0C0
	// RVA: 0x1C48F10 Offset: 0x1C49011 VA: 0x1C48F10
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	// RVA: 0x1C48F20 Offset: 0x1C49021 VA: 0x1C48F20
	internal static IntPtr Create() { }

	[NativeMethodAttribute] // RVA: 0x6C0D0 Offset: 0x6C1D1 VA: 0x6C0D0
	// RVA: 0x1C48F60 Offset: 0x1C49061 VA: 0x1C48F60
	private void Release() { }

	// RVA: 0x1C48FB0 Offset: 0x1C490B1 VA: 0x1C48FB0
	internal void InternalDestroy() { }

	// RVA: 0x1C490B0 Offset: 0x1C491B1 VA: 0x1C490B0
	private void InternalSetDefaults() { }

	// RVA: 0x1C490D0 Offset: 0x1C491D1 VA: 0x1C490D0
	public void .ctor(string url, string method) { }

	// RVA: 0x1C49420 Offset: 0x1C49521 VA: 0x1C49420
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x1C49780 Offset: 0x1C49881 VA: 0x1C49780 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1C499F0 Offset: 0x1C49AF1 VA: 0x1C499F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1C49870 Offset: 0x1C49971 VA: 0x1C49870
	private void DisposeHandlers() { }

	[NativeThrowsAttribute] // RVA: 0x6C110 Offset: 0x6C211 VA: 0x6C110
	// RVA: 0x1C49BA0 Offset: 0x1C49CA1 VA: 0x1C49BA0
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0x1C49BF0 Offset: 0x1C49CF1 VA: 0x1C49BF0
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethodAttribute] // RVA: 0x6C120 Offset: 0x6C221 VA: 0x6C120
	// RVA: 0x1C49060 Offset: 0x1C49161 VA: 0x1C49060
	public void Abort() { }

	// RVA: 0x1C49C70 Offset: 0x1C49D71 VA: 0x1C49C70
	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x1C49CC0 Offset: 0x1C49DC1 VA: 0x1C49CC0
	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x1C49E20 Offset: 0x1C49F21 VA: 0x1C49E20
	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x1C49E70 Offset: 0x1C49F71 VA: 0x1C49E70
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x1C49F80 Offset: 0x1C4A081 VA: 0x1C49F80
	internal UnityWebRequest.UnityWebRequestMethod GetMethod() { }

	// RVA: 0x1C49FD0 Offset: 0x1C4A0D1 VA: 0x1C49FD0
	internal string GetCustomMethod() { }

	// RVA: 0x1C4A020 Offset: 0x1C4A121 VA: 0x1C4A020
	public string get_method() { }

	// RVA: 0x1C49260 Offset: 0x1C49361 VA: 0x1C49260
	public void set_method(string value) { }

	// RVA: 0x1C4A180 Offset: 0x1C4A281 VA: 0x1C4A180
	private UnityWebRequest.UnityWebRequestError GetError() { }

	// RVA: 0x1C4A1D0 Offset: 0x1C4A2D1 VA: 0x1C4A1D0
	public string get_error() { }

	// RVA: 0x1C4A440 Offset: 0x1C4A541 VA: 0x1C4A440
	public string get_url() { }

	// RVA: 0x1C491C0 Offset: 0x1C492C1 VA: 0x1C491C0
	public void set_url(string value) { }

	// RVA: 0x1C4A490 Offset: 0x1C4A591 VA: 0x1C4A490
	private string GetUrl() { }

	// RVA: 0x1C4A9B0 Offset: 0x1C4AAB1 VA: 0x1C4A9B0
	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x1C4A8A0 Offset: 0x1C4A9A1 VA: 0x1C4A8A0
	private void InternalSetUrl(string url) { }

	// RVA: 0x1C4A3F0 Offset: 0x1C4A4F1 VA: 0x1C4A3F0
	public long get_responseCode() { }

	// RVA: 0x1C4AA00 Offset: 0x1C4AB01 VA: 0x1C4AA00
	private bool IsExecuting() { }

	[NativeMethodAttribute] // RVA: 0x6C160 Offset: 0x6C261 VA: 0x6C160
	// RVA: 0x1C49DD0 Offset: 0x1C49ED1 VA: 0x1C49DD0
	public bool get_isModifiable() { }

	// RVA: 0x1C4AA50 Offset: 0x1C4AB51 VA: 0x1C4AA50
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0x6C1A0 Offset: 0x6C2A1 VA: 0x6C1A0
	// RVA: 0x1C4A3A0 Offset: 0x1C4A4A1 VA: 0x1C4A3A0
	public UnityWebRequest.Result get_result() { }

	// RVA: 0x1C4AAA0 Offset: 0x1C4ABA1 VA: 0x1C4AAA0
	private float GetDownloadProgress() { }

	// RVA: 0x1C4AAF0 Offset: 0x1C4ABF1 VA: 0x1C4AAF0
	public float get_downloadProgress() { }

	// RVA: 0x1C4ABD0 Offset: 0x1C4ACD1 VA: 0x1C4ABD0
	public ulong get_downloadedBytes() { }

	[NativeThrowsAttribute] // RVA: 0x6C1E0 Offset: 0x6C2E1 VA: 0x6C1E0
	// RVA: 0x1C4AC20 Offset: 0x1C4AD21 VA: 0x1C4AC20
	private void SetRedirectLimitFromScripting(int limit) { }

	// RVA: 0x1C4AC70 Offset: 0x1C4AD71 VA: 0x1C4AC70
	public void set_redirectLimit(int value) { }

	// RVA: 0x1C4ACC0 Offset: 0x1C4ADC1 VA: 0x1C4ACC0
	private UnityWebRequest.UnityWebRequestError SetChunked(bool chunked) { }

	// RVA: 0x1C4AD10 Offset: 0x1C4AE11 VA: 0x1C4AD10
	public void set_chunkedTransfer(bool value) { }

	[NativeMethodAttribute] // RVA: 0x6C1F0 Offset: 0x6C2F1 VA: 0x6C1F0
	// RVA: 0x1C4AE20 Offset: 0x1C4AF21 VA: 0x1C4AE20
	internal UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x1C4AE80 Offset: 0x1C4AF81 VA: 0x1C4AE80
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x1C4B000 Offset: 0x1C4B101 VA: 0x1C4B000
	public string GetResponseHeader(string name) { }

	// RVA: 0x1C4B050 Offset: 0x1C4B151 VA: 0x1C4B050
	internal string[] GetResponseHeaderKeys() { }

	// RVA: 0x1C4B0A0 Offset: 0x1C4B1A1 VA: 0x1C4B0A0
	public Dictionary<string, string> GetResponseHeaders() { }

	// RVA: 0x1C4B2D0 Offset: 0x1C4B3D1 VA: 0x1C4B2D0
	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x1C49B00 Offset: 0x1C49C01 VA: 0x1C49B00
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x1C49660 Offset: 0x1C49761 VA: 0x1C49660
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x1C4B320 Offset: 0x1C4B421 VA: 0x1C4B320
	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x1C49AF0 Offset: 0x1C49BF1 VA: 0x1C49AF0
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x1C49540 Offset: 0x1C49641 VA: 0x1C49540
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x1C4B370 Offset: 0x1C4B471 VA: 0x1C4B370
	private UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	// RVA: 0x1C49B90 Offset: 0x1C49C91 VA: 0x1C49B90
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x1C4B3C0 Offset: 0x1C4B4C1 VA: 0x1C4B3C0
	public void set_certificateHandler(CertificateHandler value) { }

	// RVA: 0x1C4B4E0 Offset: 0x1C4B5E1 VA: 0x1C4B4E0
	private UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x1C4B530 Offset: 0x1C4B631 VA: 0x1C4B530
	public void set_timeout(int value) { }

	// RVA: 0x1C4B6B0 Offset: 0x1C4B7B1 VA: 0x1C4B6B0
	public static UnityWebRequest Get(string uri) { }

	// RVA: 0x1C4B790 Offset: 0x1C4B891 VA: 0x1C4B790
	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	// RVA: 0x1C4B830 Offset: 0x1C4B931 VA: 0x1C4B830
	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }
}

