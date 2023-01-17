// Namespace: System.Net
public class ServicePointManager // TypeDefIndex: 2572
{
	// Fields
	private static HybridDictionary servicePoints; // 0x0
	private static ICertificatePolicy policy; // 0x8
	private static int defaultConnectionLimit; // 0x10
	private static int maxServicePointIdleTime; // 0x14
	private static int maxServicePoints; // 0x18
	private static int dnsRefreshTimeout; // 0x1C
	private static bool _checkCRL; // 0x20
	private static SecurityProtocolType _securityProtocol; // 0x24
	private static bool expectContinue; // 0x28
	private static bool useNagle; // 0x29
	private static ServerCertValidationCallback server_cert_cb; // 0x30
	private static bool tcp_keepalive; // 0x38
	private static int tcp_keepalive_time; // 0x3C
	private static int tcp_keepalive_interval; // 0x40

	// Properties
	[MonoTODOAttribute] // RVA: 0x34330 Offset: 0x34431 VA: 0x34330
	public static bool CheckCertificateRevocationList { get; }
	public static int DnsRefreshTimeout { get; }
	public static SecurityProtocolType SecurityProtocol { get; }
	internal static ServerCertValidationCallback ServerCertValidationCallback { get; }

	// Methods

	// RVA: 0x2D068C0 Offset: 0x2D069C1 VA: 0x2D068C0
	private static void .cctor() { }

	// RVA: 0x2D069A0 Offset: 0x2D06AA1 VA: 0x2D069A0
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0x2D06A10 Offset: 0x2D06B11 VA: 0x2D06A10
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0x2D06A80 Offset: 0x2D06B81 VA: 0x2D06A80
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0x2D06AF0 Offset: 0x2D06BF1 VA: 0x2D06AF0
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0x2D06B60 Offset: 0x2D06C61 VA: 0x2D06B60
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x2D06BD0 Offset: 0x2D06CD1 VA: 0x2D06BD0
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }
}

