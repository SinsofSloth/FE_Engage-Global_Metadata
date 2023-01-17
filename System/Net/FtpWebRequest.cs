// Namespace: System.Net
public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 2551
{
	// Fields
	private Uri requestUri; // 0x38
	private string file_name; // 0x40
	private ServicePoint servicePoint; // 0x48
	private Stream origDataStream; // 0x50
	private Stream dataStream; // 0x58
	private Stream controlStream; // 0x60
	private StreamReader controlReader; // 0x68
	private NetworkCredential credentials; // 0x70
	private IPHostEntry hostEntry; // 0x78
	private IPEndPoint localEndPoint; // 0x80
	private IPEndPoint remoteEndPoint; // 0x88
	private IWebProxy proxy; // 0x90
	private int timeout; // 0x98
	private int rwTimeout; // 0x9C
	private long offset; // 0xA0
	private bool binary; // 0xA8
	private bool enableSsl; // 0xA9
	private bool usePassive; // 0xAA
	private bool keepAlive; // 0xAB
	private string method; // 0xB0
	private string renameTo; // 0xB8
	private object locker; // 0xC0
	private FtpWebRequest.RequestState requestState; // 0xC8
	private FtpAsyncResult asyncResult; // 0xD0
	private FtpWebResponse ftpResponse; // 0xD8
	private Stream requestStream; // 0xE0
	private string initial_path; // 0xE8
	private static readonly string[] supportedCommands; // 0x0
	private Encoding dataEncoding; // 0xF0

	// Properties
	public override long ContentLength { get; }
	public override ICredentials Credentials { get; set; }
	public bool EnableSsl { get; }
	[MonoTODOAttribute] // RVA: 0x34310 Offset: 0x34411 VA: 0x34310
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override IWebProxy Proxy { get; set; }
	public int ReadWriteTimeout { get; }
	public override Uri RequestUri { get; }
	public ServicePoint ServicePoint { get; }
	[MonoTODOAttribute] // RVA: 0x34320 Offset: 0x34421 VA: 0x34320
	public override bool UseDefaultCredentials { get; }
	public override int Timeout { get; }
	private string DataType { get; }
	private FtpWebRequest.RequestState State { get; set; }

	// Methods

	// RVA: 0x1AE1020 Offset: 0x1AE1121 VA: 0x1AE1020
	internal void .ctor(Uri uri) { }

	// RVA: 0x1AE12F0 Offset: 0x1AE13F1 VA: 0x1AE12F0
	private static Exception GetMustImplement() { }

	// RVA: 0x1AE1350 Offset: 0x1AE1451 VA: 0x1AE1350 Slot: 13
	public override long get_ContentLength() { }

	// RVA: 0x1AE1360 Offset: 0x1AE1461 VA: 0x1AE1360 Slot: 14
	public override ICredentials get_Credentials() { }

	// RVA: 0x1AE1370 Offset: 0x1AE1471 VA: 0x1AE1370 Slot: 15
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1AE1510 Offset: 0x1AE1611 VA: 0x1AE1510
	public bool get_EnableSsl() { }

	// RVA: 0x1AE1520 Offset: 0x1AE1621 VA: 0x1AE1520 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1AE1590 Offset: 0x1AE1691 VA: 0x1AE1590 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1AE15A0 Offset: 0x1AE16A1 VA: 0x1AE15A0 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x1AE1730 Offset: 0x1AE1831 VA: 0x1AE1730 Slot: 17
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1AE1740 Offset: 0x1AE1841 VA: 0x1AE1740 Slot: 18
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1AE17C0 Offset: 0x1AE18C1 VA: 0x1AE17C0
	public int get_ReadWriteTimeout() { }

	// RVA: 0x1AE17D0 Offset: 0x1AE18D1 VA: 0x1AE17D0 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x1AE17E0 Offset: 0x1AE18E1 VA: 0x1AE17E0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1AE1960 Offset: 0x1AE1A61 VA: 0x1AE1960 Slot: 16
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1AE19D0 Offset: 0x1AE1AD1 VA: 0x1AE19D0 Slot: 19
	public override int get_Timeout() { }

	// RVA: 0x1AE19E0 Offset: 0x1AE1AE1 VA: 0x1AE19E0
	private string get_DataType() { }

	// RVA: 0x1AE1A50 Offset: 0x1AE1B51 VA: 0x1AE1A50
	private FtpWebRequest.RequestState get_State() { }

	// RVA: 0x1AE1B20 Offset: 0x1AE1C21 VA: 0x1AE1B20
	private void set_State(FtpWebRequest.RequestState value) { }

	// RVA: 0x1AE1CE0 Offset: 0x1AE1DE1 VA: 0x1AE1CE0 Slot: 26
	public override void Abort() { }

	// RVA: 0x1AE22F0 Offset: 0x1AE23F1 VA: 0x1AE22F0 Slot: 21
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1AE25F0 Offset: 0x1AE26F1 VA: 0x1AE25F0 Slot: 22
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1AE27F0 Offset: 0x1AE28F1 VA: 0x1AE27F0 Slot: 20
	public override WebResponse GetResponse() { }

	// RVA: 0x1AE2840 Offset: 0x1AE2941 VA: 0x1AE2840 Slot: 23
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x1AE2B80 Offset: 0x1AE2C81 VA: 0x1AE2B80 Slot: 24
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x1AE18A0 Offset: 0x1AE19A1 VA: 0x1AE18A0
	private ServicePoint GetServicePoint() { }

	// RVA: 0x1AE2DC0 Offset: 0x1AE2EC1 VA: 0x1AE2DC0
	private void ResolveHost() { }

	// RVA: 0x1AE2FA0 Offset: 0x1AE30A1 VA: 0x1AE2FA0
	private void ProcessRequest() { }

	// RVA: 0x1AE3D70 Offset: 0x1AE3E71 VA: 0x1AE3D70
	private void SetType() { }

	// RVA: 0x1AE3FD0 Offset: 0x1AE40D1 VA: 0x1AE3FD0
	private string GetRemoteFolderPath(Uri uri) { }

	// RVA: 0x1AE41B0 Offset: 0x1AE42B1 VA: 0x1AE41B0
	private void CWDAndSetFileName(Uri uri) { }

	// RVA: 0x1AE3360 Offset: 0x1AE3461 VA: 0x1AE3360
	private void ProcessMethod() { }

	// RVA: 0x1AE5180 Offset: 0x1AE5281 VA: 0x1AE5180
	private void CloseControlConnection() { }

	// RVA: 0x1AE0040 Offset: 0x1AE0141 VA: 0x1AE0040
	internal void CloseDataConnection() { }

	// RVA: 0x1AE52C0 Offset: 0x1AE53C1 VA: 0x1AE52C0
	private void CloseConnection() { }

	// RVA: 0x1AE4B30 Offset: 0x1AE4C31 VA: 0x1AE4B30
	private void ProcessSimpleMethod() { }

	// RVA: 0x1AE4A80 Offset: 0x1AE4B81 VA: 0x1AE4A80
	private void UploadData() { }

	// RVA: 0x1AE49E0 Offset: 0x1AE4AE1 VA: 0x1AE49E0
	private void DownloadData() { }

	// RVA: 0x1AE14A0 Offset: 0x1AE15A1 VA: 0x1AE14A0
	private void CheckRequestStarted() { }

	// RVA: 0x1AE4370 Offset: 0x1AE4471 VA: 0x1AE4370
	private void OpenControlConnection() { }

	// RVA: 0x1AE5D60 Offset: 0x1AE5E61 VA: 0x1AE5D60
	private static string GetInitialPath(FtpStatus status) { }

	// RVA: 0x1AE5ED0 Offset: 0x1AE5FD1 VA: 0x1AE5ED0
	private Socket SetupPassiveConnection(string statusDescription, bool ipv6) { }

	// RVA: 0x1AE6090 Offset: 0x1AE6191 VA: 0x1AE6090
	private int GetPortV4(string responseString) { }

	// RVA: 0x1AE62F0 Offset: 0x1AE63F1 VA: 0x1AE62F0
	private int GetPortV6(string responseString) { }

	// RVA: 0x1AE64C0 Offset: 0x1AE65C1 VA: 0x1AE64C0
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1AE68D0 Offset: 0x1AE69D1 VA: 0x1AE68D0
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x1AE3EE0 Offset: 0x1AE3FE1 VA: 0x1AE3EE0
	private Exception CreateExceptionFromResponse(FtpStatus status) { }

	// RVA: 0x1AE0090 Offset: 0x1AE0191 VA: 0x1AE0090
	internal void SetTransferCompleted() { }

	// RVA: 0x1AE69F0 Offset: 0x1AE6AF1 VA: 0x1AE69F0
	internal void OperationCompleted() { }

	// RVA: 0x1AE3970 Offset: 0x1AE3A71 VA: 0x1AE3970
	private void SetCompleteWithError(Exception exc) { }

	// RVA: 0x1AE6A50 Offset: 0x1AE6B51 VA: 0x1AE6A50
	private Socket InitDataConnection() { }

	// RVA: 0x1AE5310 Offset: 0x1AE5411 VA: 0x1AE5310
	private void OpenDataConnection() { }

	// RVA: 0x1AE58B0 Offset: 0x1AE59B1 VA: 0x1AE58B0
	private void Authenticate() { }

	// RVA: 0x1AE3ED0 Offset: 0x1AE3FD1 VA: 0x1AE3ED0
	private FtpStatus SendCommand(string command, string[] parameters) { }

	// RVA: 0x1AE1F50 Offset: 0x1AE2051 VA: 0x1AE1F50
	private FtpStatus SendCommand(bool waitResponse, string command, string[] parameters) { }

	// RVA: 0x1AE71C0 Offset: 0x1AE72C1 VA: 0x1AE71C0
	internal static FtpStatus ServiceNotAvailable() { }

	// RVA: 0x1AE3A10 Offset: 0x1AE3B11 VA: 0x1AE3A10
	internal FtpStatus GetResponseStatus() { }

	// RVA: 0x1AE7080 Offset: 0x1AE7181 VA: 0x1AE7080
	private void InitiateSecureConnection(ref Stream stream) { }

	// RVA: 0x1AE6EA0 Offset: 0x1AE6FA1 VA: 0x1AE6EA0
	internal bool ChangeToSSLSocket(ref Stream stream) { }

	// RVA: 0x1AE2130 Offset: 0x1AE2231 VA: 0x1AE2130
	private bool InFinalState() { }

	// RVA: 0x1AE3990 Offset: 0x1AE3A91 VA: 0x1AE3990
	private bool InProgress() { }

	// RVA: 0x1ADFFD0 Offset: 0x1AE00D1 VA: 0x1ADFFD0
	internal void CheckIfAborted() { }

	// RVA: 0x1AE1C50 Offset: 0x1AE1D51 VA: 0x1AE1C50
	private void CheckFinalState() { }

	// RVA: 0x1AE7260 Offset: 0x1AE7361 VA: 0x1AE7260
	private static void .cctor() { }
}

