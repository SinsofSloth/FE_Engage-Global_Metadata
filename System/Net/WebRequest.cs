// Namespace: System.Net
[Serializable]
public abstract class WebRequest : MarshalByRefObject, ISerializable // TypeDefIndex: 2486
{
	// Fields
	private static ArrayList s_PrefixList; // 0x0
	private static object s_InternalSyncObject; // 0x8
	private static TimerThread.Queue s_DefaultTimerQueue; // 0x10
	private AuthenticationLevel m_AuthenticationLevel; // 0x18
	private TokenImpersonationLevel m_ImpersonationLevel; // 0x1C
	private RequestCachePolicy m_CachePolicy; // 0x20
	private RequestCacheProtocol m_CacheProtocol; // 0x28
	private RequestCacheBinding m_CacheBinding; // 0x30
	private static WebRequest.DesignerWebRequestCreate webRequestCreate; // 0x18
	private static IWebProxy s_DefaultWebProxy; // 0x20
	private static bool s_DefaultWebProxyInitialized; // 0x28

	// Properties
	private static object InternalSyncObject { get; }
	internal static ArrayList PrefixList { get; }
	public virtual RequestCachePolicy CachePolicy { set; }
	public virtual string Method { get; set; }
	public virtual Uri RequestUri { get; }
	public virtual WebHeaderCollection Headers { get; }
	public virtual long ContentLength { get; }
	public virtual ICredentials Credentials { get; set; }
	public virtual bool UseDefaultCredentials { get; }
	public virtual IWebProxy Proxy { get; set; }
	public virtual int Timeout { get; }
	internal RequestCacheProtocol CacheProtocol { get; set; }
	internal static IWebProxy InternalDefaultWebProxy { get; }
	public static IWebProxy DefaultWebProxy { get; }

	// Methods

	// RVA: 0x194FC60 Offset: 0x194FD61 VA: 0x194FC60
	private static object get_InternalSyncObject() { }

	// RVA: 0x194FD60 Offset: 0x194FE61 VA: 0x194FD60
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x19503E0 Offset: 0x19504E1 VA: 0x19503E0
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x19504D0 Offset: 0x19505D1 VA: 0x19504D0
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x194FFF0 Offset: 0x19500F1 VA: 0x194FFF0
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x19505D0 Offset: 0x19506D1 VA: 0x19505D0
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x19508C0 Offset: 0x19509C1 VA: 0x19508C0
	protected void .ctor() { }

	// RVA: 0x19508F0 Offset: 0x19509F1 VA: 0x19508F0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1950900 Offset: 0x1950A01 VA: 0x1950900 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1950910 Offset: 0x1950A11 VA: 0x1950910 Slot: 7
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1950920 Offset: 0x1950A21 VA: 0x1950920 Slot: 8
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x1950930 Offset: 0x1950A31 VA: 0x1950930
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x1950A00 Offset: 0x1950B01 VA: 0x1950A00 Slot: 9
	public virtual string get_Method() { }

	// RVA: 0x1950A30 Offset: 0x1950B31 VA: 0x1950A30 Slot: 10
	public virtual void set_Method(string value) { }

	// RVA: 0x1950A60 Offset: 0x1950B61 VA: 0x1950A60 Slot: 11
	public virtual Uri get_RequestUri() { }

	// RVA: 0x1950A90 Offset: 0x1950B91 VA: 0x1950A90 Slot: 12
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x1950AC0 Offset: 0x1950BC1 VA: 0x1950AC0 Slot: 13
	public virtual long get_ContentLength() { }

	// RVA: 0x1950AF0 Offset: 0x1950BF1 VA: 0x1950AF0 Slot: 14
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x1950B20 Offset: 0x1950C21 VA: 0x1950B20 Slot: 15
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x1950B50 Offset: 0x1950C51 VA: 0x1950B50 Slot: 16
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x1950B80 Offset: 0x1950C81 VA: 0x1950B80 Slot: 17
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x1950BB0 Offset: 0x1950CB1 VA: 0x1950BB0 Slot: 18
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x1950BE0 Offset: 0x1950CE1 VA: 0x1950BE0 Slot: 19
	public virtual int get_Timeout() { }

	// RVA: 0x1950C10 Offset: 0x1950D11 VA: 0x1950C10 Slot: 20
	public virtual WebResponse GetResponse() { }

	// RVA: 0x1950C40 Offset: 0x1950D41 VA: 0x1950C40 Slot: 21
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1950C70 Offset: 0x1950D71 VA: 0x1950C70 Slot: 22
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1950CA0 Offset: 0x1950DA1 VA: 0x1950CA0 Slot: 23
	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x1950CD0 Offset: 0x1950DD1 VA: 0x1950CD0 Slot: 24
	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x1950D00 Offset: 0x1950E01 VA: 0x1950D00 Slot: 25
	public virtual Task<WebResponse> GetResponseAsync() { }

	// RVA: 0x1951040 Offset: 0x1951141 VA: 0x1951040
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x19510B0 Offset: 0x19511B1 VA: 0x19510B0 Slot: 26
	public virtual void Abort() { }

	// RVA: 0x19510E0 Offset: 0x19511E1 VA: 0x19510E0
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x19510F0 Offset: 0x19511F1 VA: 0x19510F0
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x1951100 Offset: 0x1951201 VA: 0x1951100
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x1951320 Offset: 0x1951421 VA: 0x1951320
	public static IWebProxy get_DefaultWebProxy() { }

	// RVA: 0x1951390 Offset: 0x1951491 VA: 0x1951390
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x323B0 Offset: 0x324B1 VA: 0x323B0
	// RVA: 0x1951460 Offset: 0x1951561 VA: 0x1951460
	private Task<WebResponse> <GetResponseAsync>b__79_0() { }
}

