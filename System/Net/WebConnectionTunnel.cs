// Namespace: System.Net
internal class WebConnectionTunnel // TypeDefIndex: 2592
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x31940 Offset: 0x31A41 VA: 0x31940
	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x31950 Offset: 0x31A51 VA: 0x31950
	private readonly Uri <ConnectUri>k__BackingField; // 0x18
	private HttpWebRequest connectRequest; // 0x20
	private WebConnectionTunnel.NtlmAuthState ntlmAuthState; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x31960 Offset: 0x31A61 VA: 0x31960
	private bool <Success>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x31970 Offset: 0x31A71 VA: 0x31970
	private bool <CloseConnection>k__BackingField; // 0x2D
	[CompilerGeneratedAttribute] // RVA: 0x31980 Offset: 0x31A81 VA: 0x31980
	private int <StatusCode>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x31990 Offset: 0x31A91 VA: 0x31990
	private string <StatusDescription>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x319A0 Offset: 0x31AA1 VA: 0x319A0
	private string[] <Challenge>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x319B0 Offset: 0x31AB1 VA: 0x319B0
	private WebHeaderCollection <Headers>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x319C0 Offset: 0x31AC1 VA: 0x319C0
	private Version <ProxyVersion>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x319D0 Offset: 0x31AD1 VA: 0x319D0
	private byte[] <Data>k__BackingField; // 0x58

	// Properties
	public HttpWebRequest Request { get; }
	public Uri ConnectUri { get; }
	public bool Success { get; set; }
	public bool CloseConnection { get; set; }
	public int StatusCode { get; set; }
	private string StatusDescription { set; }
	public string[] Challenge { get; set; }
	public WebHeaderCollection Headers { get; set; }
	public Version ProxyVersion { get; set; }
	public byte[] Data { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x32C10 Offset: 0x32D11 VA: 0x32C10
	// RVA: 0x1949890 Offset: 0x1949991 VA: 0x1949890
	public HttpWebRequest get_Request() { }

	[CompilerGeneratedAttribute] // RVA: 0x32C20 Offset: 0x32D21 VA: 0x32C20
	// RVA: 0x19498A0 Offset: 0x19499A1 VA: 0x19498A0
	public Uri get_ConnectUri() { }

	// RVA: 0x19498B0 Offset: 0x19499B1 VA: 0x19498B0
	public void .ctor(HttpWebRequest request, Uri connectUri) { }

	[CompilerGeneratedAttribute] // RVA: 0x32C30 Offset: 0x32D31 VA: 0x32C30
	// RVA: 0x1949900 Offset: 0x1949A01 VA: 0x1949900
	public bool get_Success() { }

	[CompilerGeneratedAttribute] // RVA: 0x32C40 Offset: 0x32D41 VA: 0x32C40
	// RVA: 0x1949910 Offset: 0x1949A11 VA: 0x1949910
	private void set_Success(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x32C50 Offset: 0x32D51 VA: 0x32C50
	// RVA: 0x1949920 Offset: 0x1949A21 VA: 0x1949920
	public bool get_CloseConnection() { }

	[CompilerGeneratedAttribute] // RVA: 0x32C60 Offset: 0x32D61 VA: 0x32C60
	// RVA: 0x1949930 Offset: 0x1949A31 VA: 0x1949930
	private void set_CloseConnection(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x32C70 Offset: 0x32D71 VA: 0x32C70
	// RVA: 0x1949940 Offset: 0x1949A41 VA: 0x1949940
	public int get_StatusCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x32C80 Offset: 0x32D81 VA: 0x32C80
	// RVA: 0x1949950 Offset: 0x1949A51 VA: 0x1949950
	private void set_StatusCode(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x32C90 Offset: 0x32D91 VA: 0x32C90
	// RVA: 0x1949960 Offset: 0x1949A61 VA: 0x1949960
	private void set_StatusDescription(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x32CA0 Offset: 0x32DA1 VA: 0x32CA0
	// RVA: 0x1949970 Offset: 0x1949A71 VA: 0x1949970
	public string[] get_Challenge() { }

	[CompilerGeneratedAttribute] // RVA: 0x32CB0 Offset: 0x32DB1 VA: 0x32CB0
	// RVA: 0x1949980 Offset: 0x1949A81 VA: 0x1949980
	private void set_Challenge(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x32CC0 Offset: 0x32DC1 VA: 0x32CC0
	// RVA: 0x1949990 Offset: 0x1949A91 VA: 0x1949990
	public WebHeaderCollection get_Headers() { }

	[CompilerGeneratedAttribute] // RVA: 0x32CD0 Offset: 0x32DD1 VA: 0x32CD0
	// RVA: 0x19499A0 Offset: 0x1949AA1 VA: 0x19499A0
	private void set_Headers(WebHeaderCollection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x32CE0 Offset: 0x32DE1 VA: 0x32CE0
	// RVA: 0x19499B0 Offset: 0x1949AB1 VA: 0x19499B0
	public Version get_ProxyVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x32CF0 Offset: 0x32DF1 VA: 0x32CF0
	// RVA: 0x19499C0 Offset: 0x1949AC1 VA: 0x19499C0
	private void set_ProxyVersion(Version value) { }

	[CompilerGeneratedAttribute] // RVA: 0x32D00 Offset: 0x32E01 VA: 0x32D00
	// RVA: 0x19499D0 Offset: 0x1949AD1 VA: 0x19499D0
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x32D10 Offset: 0x32E11 VA: 0x32D10
	// RVA: 0x19499E0 Offset: 0x1949AE1 VA: 0x19499E0
	private void set_Data(byte[] value) { }

	[AsyncStateMachineAttribute] // RVA: 0x32D20 Offset: 0x32E21 VA: 0x32D20
	// RVA: 0x19499F0 Offset: 0x1949AF1 VA: 0x19499F0
	internal Task Initialize(Stream stream, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x32D90 Offset: 0x32E91 VA: 0x32D90
	// RVA: 0x1949B90 Offset: 0x1949C91 VA: 0x1949B90
	private Task<ValueTuple<WebHeaderCollection, byte[], int>> ReadHeaders(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1949D50 Offset: 0x1949E51 VA: 0x1949D50
	private void FlushContents(Stream stream, int contentLength) { }
}

