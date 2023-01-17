// Namespace: System.Net
public class ServicePoint // TypeDefIndex: 2570
{
	// Fields
	private readonly Uri uri; // 0x10
	private DateTime lastDnsResolve; // 0x18
	private Version protocolVersion; // 0x20
	private IPHostEntry host; // 0x28
	private bool usesProxy; // 0x30
	private bool sendContinue; // 0x31
	private bool useConnect; // 0x32
	private object hostE; // 0x38
	private bool useNagle; // 0x40
	private BindIPEndPoint endPointCallback; // 0x48
	private bool tcp_keepalive; // 0x50
	private int tcp_keepalive_time; // 0x54
	private int tcp_keepalive_interval; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x31890 Offset: 0x31991 VA: 0x31890
	private readonly ServicePointScheduler <Scheduler>k__BackingField; // 0x60
	private object m_ServerCertificateOrBytes; // 0x68
	private object m_ClientCertificateOrBytes; // 0x70

	// Properties
	internal ServicePointScheduler Scheduler { get; }
	public Uri Address { get; }
	public int ConnectionLimit { get; }
	public virtual Version ProtocolVersion { get; }
	public bool Expect100Continue { set; }
	public bool UseNagleAlgorithm { get; set; }
	internal bool SendContinue { get; set; }
	internal bool UsesProxy { get; set; }
	internal bool UseConnect { get; set; }
	private bool HasTimedOut { get; }
	internal IPHostEntry HostEntry { get; }

	// Methods

	// RVA: 0x2D05370 Offset: 0x2D05471 VA: 0x2D05370
	internal void .ctor(Uri uri, int connectionLimit, int maxIdleTime) { }

	[CompilerGeneratedAttribute] // RVA: 0x32870 Offset: 0x32971 VA: 0x32870
	// RVA: 0x2D05690 Offset: 0x2D05791 VA: 0x2D05690
	internal ServicePointScheduler get_Scheduler() { }

	// RVA: 0x2D056A0 Offset: 0x2D057A1 VA: 0x2D056A0
	public Uri get_Address() { }

	// RVA: 0x2D056B0 Offset: 0x2D057B1 VA: 0x2D056B0
	public int get_ConnectionLimit() { }

	// RVA: 0x2D056C0 Offset: 0x2D057C1 VA: 0x2D056C0 Slot: 4
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x2D056D0 Offset: 0x2D057D1 VA: 0x2D056D0
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x2D056E0 Offset: 0x2D057E1 VA: 0x2D056E0
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0x2D056F0 Offset: 0x2D057F1 VA: 0x2D056F0
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x2D05700 Offset: 0x2D05801 VA: 0x2D05700
	internal bool get_SendContinue() { }

	// RVA: 0x2D05810 Offset: 0x2D05911 VA: 0x2D05810
	internal void set_SendContinue(bool value) { }

	// RVA: 0x2D05820 Offset: 0x2D05921 VA: 0x2D05820
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0x2D058E0 Offset: 0x2D059E1 VA: 0x2D058E0
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0x2D059A0 Offset: 0x2D05AA1 VA: 0x2D059A0
	private static void PutBytes(byte[] bytes, uint v, int offset) { }

	// RVA: 0x2D05B20 Offset: 0x2D05C21 VA: 0x2D05B20
	internal bool get_UsesProxy() { }

	// RVA: 0x2D05B30 Offset: 0x2D05C31 VA: 0x2D05B30
	internal void set_UsesProxy(bool value) { }

	// RVA: 0x2D05B40 Offset: 0x2D05C41 VA: 0x2D05B40
	internal bool get_UseConnect() { }

	// RVA: 0x2D05B50 Offset: 0x2D05C51 VA: 0x2D05B50
	internal void set_UseConnect(bool value) { }

	// RVA: 0x2D05B60 Offset: 0x2D05C61 VA: 0x2D05B60
	private bool get_HasTimedOut() { }

	// RVA: 0x2D05CF0 Offset: 0x2D05DF1 VA: 0x2D05CF0
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x2D06230 Offset: 0x2D06331 VA: 0x2D06230
	internal void SetVersion(Version version) { }

	// RVA: 0x2D06240 Offset: 0x2D06341 VA: 0x2D06240
	internal void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x2D06420 Offset: 0x2D06521 VA: 0x2D06420
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0x2D06480 Offset: 0x2D06581 VA: 0x2D06480
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0x2D064E0 Offset: 0x2D065E1 VA: 0x2D064E0
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }
}

