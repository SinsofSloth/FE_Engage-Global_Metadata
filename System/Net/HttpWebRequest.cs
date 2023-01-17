// Namespace: System.Net
[Serializable]
public class HttpWebRequest : WebRequest, ISerializable // TypeDefIndex: 2562
{
	// Fields
	private Uri requestUri; // 0x38
	private Uri actualUri; // 0x40
	private bool hostChanged; // 0x48
	private bool allowAutoRedirect; // 0x49
	private bool allowBuffering; // 0x4A
	private X509CertificateCollection certificates; // 0x50
	private string connectionGroup; // 0x58
	private bool haveContentLength; // 0x60
	private long contentLength; // 0x68
	private HttpContinueDelegate continueDelegate; // 0x70
	private CookieContainer cookieContainer; // 0x78
	private ICredentials credentials; // 0x80
	private bool haveResponse; // 0x88
	private bool requestSent; // 0x89
	private WebHeaderCollection webHeaders; // 0x90
	private bool keepAlive; // 0x98
	private int maxAutoRedirect; // 0x9C
	private string mediaType; // 0xA0
	private string method; // 0xA8
	private string initialMethod; // 0xB0
	private bool pipelined; // 0xB8
	private bool preAuthenticate; // 0xB9
	private bool usedPreAuth; // 0xBA
	private Version version; // 0xC0
	private bool force_version; // 0xC8
	private Version actualVersion; // 0xD0
	private IWebProxy proxy; // 0xD8
	private bool sendChunked; // 0xE0
	private ServicePoint servicePoint; // 0xE8
	private int timeout; // 0xF0
	private WebRequestStream writeStream; // 0xF8
	private HttpWebResponse webResponse; // 0x100
	private WebCompletionSource responseTask; // 0x108
	private WebOperation currentOperation; // 0x110
	private int aborted; // 0x118
	private bool gotRequestStream; // 0x11C
	private int redirects; // 0x120
	private bool expectContinue; // 0x124
	private bool getResponseCalled; // 0x125
	private object locker; // 0x128
	private bool finished_reading; // 0x130
	private DecompressionMethods auto_decomp; // 0x134
	private static int defaultMaxResponseHeadersLength; // 0x0
	private int readWriteTimeout; // 0x138
	private MonoTlsProvider tlsProvider; // 0x140
	private MonoTlsSettings tlsSettings; // 0x148
	private ServerCertValidationCallback certValidationCallback; // 0x150
	private HttpWebRequest.AuthorizationState auth_state; // 0x158
	private HttpWebRequest.AuthorizationState proxy_auth_state; // 0x168
	private string host; // 0x178
	internal Func<Stream, Task> ResendContentFactory; // 0x180
	[CompilerGeneratedAttribute] // RVA: 0x31680 Offset: 0x31781 VA: 0x31680
	private bool <ThrowOnError>k__BackingField; // 0x188
	private bool unsafe_auth_blah; // 0x189

	// Properties
	public Uri Address { get; set; }
	public virtual bool AllowWriteStreamBuffering { get; }
	public DecompressionMethods AutomaticDecompression { get; }
	internal bool InternalAllowBuffering { get; }
	private bool MethodWithBuffer { get; }
	internal MonoTlsProvider TlsProvider { get; }
	internal MonoTlsSettings TlsSettings { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public override long ContentLength { get; }
	internal long InternalContentLength { set; }
	internal bool ThrowOnError { get; set; }
	public override ICredentials Credentials { get; set; }
	public override WebHeaderCollection Headers { get; }
	public string Host { get; }
	public bool KeepAlive { get; }
	public int ReadWriteTimeout { get; }
	public override string Method { get; set; }
	public Version ProtocolVersion { get; }
	public override IWebProxy Proxy { get; set; }
	public override Uri RequestUri { get; }
	public bool SendChunked { get; }
	public ServicePoint ServicePoint { get; }
	internal ServicePoint ServicePointNoLock { get; }
	public override int Timeout { get; }
	public string TransferEncoding { get; }
	public override bool UseDefaultCredentials { get; }
	public bool UnsafeAuthenticatedConnectionSharing { get; }
	internal bool ExpectContinue { get; set; }
	internal Uri AuthUri { get; }
	internal bool ProxyQuery { get; }
	internal ServerCertValidationCallback ServerCertValidationCallback { get; }
	internal bool FinishedReading { set; }
	internal bool Aborted { get; }

	// Methods

	// RVA: 0x1AEC250 Offset: 0x1AEC351 VA: 0x1AEC250
	private static void .cctor() { }

	// RVA: 0x1AEBA10 Offset: 0x1AEBB11 VA: 0x1AEBA10
	public void .ctor(Uri uri) { }

	[ObsoleteAttribute] // RVA: 0x32480 Offset: 0x32581 VA: 0x32480
	// RVA: 0x1AEC320 Offset: 0x1AEC421 VA: 0x1AEC320
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1AEC2A0 Offset: 0x1AEC3A1 VA: 0x1AEC2A0
	private void ResetAuthorization() { }

	// RVA: 0x1AECB80 Offset: 0x1AECC81 VA: 0x1AECB80
	public Uri get_Address() { }

	// RVA: 0x1AECB90 Offset: 0x1AECC91 VA: 0x1AECB90
	internal void set_Address(Uri value) { }

	// RVA: 0x1AECBA0 Offset: 0x1AECCA1 VA: 0x1AECBA0 Slot: 27
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x1AECBB0 Offset: 0x1AECCB1 VA: 0x1AECBB0
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x1AECBC0 Offset: 0x1AECCC1 VA: 0x1AECBC0
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x1AECBE0 Offset: 0x1AECCE1 VA: 0x1AECBE0
	private bool get_MethodWithBuffer() { }

	// RVA: 0x1AECCF0 Offset: 0x1AECDF1 VA: 0x1AECCF0
	internal MonoTlsProvider get_TlsProvider() { }

	// RVA: 0x1AECD00 Offset: 0x1AECE01 VA: 0x1AECD00
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x1AECD10 Offset: 0x1AECE11 VA: 0x1AECD10
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1AECDA0 Offset: 0x1AECEA1 VA: 0x1AECDA0 Slot: 13
	public override long get_ContentLength() { }

	// RVA: 0x1AECDB0 Offset: 0x1AECEB1 VA: 0x1AECDB0
	internal void set_InternalContentLength(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x324C0 Offset: 0x325C1 VA: 0x324C0
	// RVA: 0x1AECDC0 Offset: 0x1AECEC1 VA: 0x1AECDC0
	internal bool get_ThrowOnError() { }

	[CompilerGeneratedAttribute] // RVA: 0x324D0 Offset: 0x325D1 VA: 0x324D0
	// RVA: 0x1AECDD0 Offset: 0x1AECED1 VA: 0x1AECDD0
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x1AECDE0 Offset: 0x1AECEE1 VA: 0x1AECDE0 Slot: 14
	public override ICredentials get_Credentials() { }

	// RVA: 0x1AECDF0 Offset: 0x1AECEF1 VA: 0x1AECDF0 Slot: 15
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1AECE00 Offset: 0x1AECF01 VA: 0x1AECE00 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1AECE10 Offset: 0x1AECF11 VA: 0x1AECE10
	public string get_Host() { }

	// RVA: 0x1AECE30 Offset: 0x1AECF31 VA: 0x1AECE30
	public bool get_KeepAlive() { }

	// RVA: 0x1AECE40 Offset: 0x1AECF41 VA: 0x1AECE40
	public int get_ReadWriteTimeout() { }

	// RVA: 0x1AECE50 Offset: 0x1AECF51 VA: 0x1AECE50 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1AECE60 Offset: 0x1AECF61 VA: 0x1AECE60 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x1AED090 Offset: 0x1AED191 VA: 0x1AED090
	public Version get_ProtocolVersion() { }

	// RVA: 0x1AED0A0 Offset: 0x1AED1A1 VA: 0x1AED0A0 Slot: 17
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1AED0B0 Offset: 0x1AED1B1 VA: 0x1AED0B0 Slot: 18
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1AED300 Offset: 0x1AED401 VA: 0x1AED300 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x1AED310 Offset: 0x1AED411 VA: 0x1AED310
	public bool get_SendChunked() { }

	// RVA: 0x1AED320 Offset: 0x1AED421 VA: 0x1AED320
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1AED330 Offset: 0x1AED431 VA: 0x1AED330
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x1AED340 Offset: 0x1AED441 VA: 0x1AED340 Slot: 19
	public override int get_Timeout() { }

	// RVA: 0x1AED350 Offset: 0x1AED451 VA: 0x1AED350
	public string get_TransferEncoding() { }

	// RVA: 0x1AED3B0 Offset: 0x1AED4B1 VA: 0x1AED3B0 Slot: 16
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1AED440 Offset: 0x1AED541 VA: 0x1AED440
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x1AED450 Offset: 0x1AED551 VA: 0x1AED450
	internal bool get_ExpectContinue() { }

	// RVA: 0x1AED460 Offset: 0x1AED561 VA: 0x1AED460
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x1AED470 Offset: 0x1AED571 VA: 0x1AED470
	internal Uri get_AuthUri() { }

	// RVA: 0x1AED480 Offset: 0x1AED581 VA: 0x1AED480
	internal bool get_ProxyQuery() { }

	// RVA: 0x1AED4B0 Offset: 0x1AED5B1 VA: 0x1AED4B0
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x1AED1B0 Offset: 0x1AED2B1 VA: 0x1AED1B0
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x1AED4C0 Offset: 0x1AED5C1 VA: 0x1AED4C0
	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x324E0 Offset: 0x325E1 VA: 0x324E0
	// RVA: 0x1AED700 Offset: 0x1AED801 VA: 0x1AED700
	private Task<Stream> MyGetRequestStreamAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1AED880 Offset: 0x1AED981 VA: 0x1AED880 Slot: 23
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x1AEDAC0 Offset: 0x1AEDBC1 VA: 0x1AEDAC0 Slot: 24
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	[AsyncStateMachineAttribute] // RVA: 0x32550 Offset: 0x32651 VA: 0x32550
	// RVA: -1 Offset: -1
	internal static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B80D0 Offset: 0x22B81D1 VA: 0x22B80D0
	|-HttpWebRequest.RunWithTimeout<ValueTuple<int, int>>
	|
	|-RVA: 0x22B8270 Offset: 0x22B8371 VA: 0x22B8270
	|-HttpWebRequest.RunWithTimeout<object>
	*/

	// RVA: -1 Offset: -1
	private Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B8000 Offset: 0x22B8101 VA: 0x22B8000
	|-HttpWebRequest.RunWithTimeout<HttpWebResponse>
	|-HttpWebRequest.RunWithTimeout<object>
	|-HttpWebRequest.RunWithTimeout<Stream>
	*/

	[AsyncStateMachineAttribute] // RVA: 0x325C0 Offset: 0x326C1 VA: 0x325C0
	// RVA: 0x1AEDCF0 Offset: 0x1AEDDF1 VA: 0x1AEDCF0
	private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x32630 Offset: 0x32731 VA: 0x32630
	// RVA: 0x1AEDE80 Offset: 0x1AEDF81 VA: 0x1AEDE80
	private Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1AEDC20 Offset: 0x1AEDD21 VA: 0x1AEDC20
	internal static Exception FlattenException(Exception e) { }

	// RVA: 0x1AEE020 Offset: 0x1AEE121 VA: 0x1AEE020
	private WebException GetWebException(Exception e) { }

	// RVA: 0x1AEDA00 Offset: 0x1AEDB01 VA: 0x1AEDA00
	internal static WebException CreateRequestAbortedException() { }

	// RVA: 0x1AEE2B0 Offset: 0x1AEE3B1 VA: 0x1AEE2B0 Slot: 21
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1AEE400 Offset: 0x1AEE501 VA: 0x1AEE400 Slot: 22
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1AEE560 Offset: 0x1AEE661 VA: 0x1AEE560 Slot: 20
	public override WebResponse GetResponse() { }

	// RVA: 0x1AEE690 Offset: 0x1AEE791 VA: 0x1AEE690
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x1AED9D0 Offset: 0x1AEDAD1 VA: 0x1AED9D0
	internal bool get_Aborted() { }

	// RVA: 0x1AEE6A0 Offset: 0x1AEE7A1 VA: 0x1AEE6A0 Slot: 26
	public override void Abort() { }

	// RVA: 0x1AEE7A0 Offset: 0x1AEE8A1 VA: 0x1AEE7A0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1AEE7B0 Offset: 0x1AEE8B1 VA: 0x1AEE7B0 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1AED140 Offset: 0x1AED241 VA: 0x1AED140
	private void CheckRequestStarted() { }

	// RVA: 0x1AEEC40 Offset: 0x1AEED41 VA: 0x1AEEC40
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x1AEEC50 Offset: 0x1AEED51 VA: 0x1AEEC50
	private void RewriteRedirectToGet() { }

	// RVA: 0x1AEECE0 Offset: 0x1AEEDE1 VA: 0x1AEECE0
	private bool Redirect(HttpStatusCode code, WebResponse response) { }

	// RVA: 0x1AEF280 Offset: 0x1AEF381 VA: 0x1AEF280
	private string GetHeaders() { }

	// RVA: 0x1AEF8D0 Offset: 0x1AEF9D1 VA: 0x1AEF8D0
	private void DoPreAuthenticate() { }

	// RVA: 0x1AEFAF0 Offset: 0x1AEFBF1 VA: 0x1AEFAF0
	internal byte[] GetRequestHeaders() { }

	// RVA: 0x1AEFE80 Offset: 0x1AEFF81 VA: 0x1AEFE80
	private ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x1AF0110 Offset: 0x1AF0211 VA: 0x1AF0110
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x1AF0130 Offset: 0x1AF0231 VA: 0x1AF0130
	private ValueTuple<Task<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	// RVA: 0x1AF0350 Offset: 0x1AF0451 VA: 0x1AF0350
	private ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response) { }

	[AsyncStateMachineAttribute] // RVA: 0x326A0 Offset: 0x327A1 VA: 0x326A0
	[CompilerGeneratedAttribute] // RVA: 0x326A0 Offset: 0x327A1 VA: 0x326A0
	// RVA: 0x1AF0830 Offset: 0x1AF0931 VA: 0x1AF0830
	private Task<BufferOffsetSize> <GetRewriteHandler>b__263_0() { }

	[EditorBrowsableAttribute] // RVA: 0x32720 Offset: 0x32821 VA: 0x32720
	[ObsoleteAttribute] // RVA: 0x32720 Offset: 0x32821 VA: 0x32720
	// RVA: 0x1AF0990 Offset: 0x1AF0A91 VA: 0x1AF0990
	public void .ctor() { }
}

