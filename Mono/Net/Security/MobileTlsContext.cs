// Namespace: Mono.Net.Security
internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 2199
{
	// Fields
	private MobileAuthenticatedStream parent; // 0x10
	private bool serverMode; // 0x18
	private string targetHost; // 0x20
	private string serverName; // 0x28
	private SslProtocols enabledProtocols; // 0x30
	private X509Certificate serverCertificate; // 0x38
	private X509CertificateCollection clientCertificates; // 0x40
	private bool askForClientCert; // 0x48
	private ICertificateValidator2 certificateValidator; // 0x50

	// Properties
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract bool IsAuthenticated { get; }
	public bool IsServer { get; }
	protected string TargetHost { get; }
	protected string ServerName { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; }
	internal abstract X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0x1AC87F0 Offset: 0x1AC88F1 VA: 0x1AC87F0
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x1AC8970 Offset: 0x1AC8A71 VA: 0x1AC8970
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0x1AC8980 Offset: 0x1AC8A81 VA: 0x1AC8980
	public MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAuthenticated();

	// RVA: 0x1AC8990 Offset: 0x1AC8A91 VA: 0x1AC8990
	public bool get_IsServer() { }

	// RVA: 0x1AC89A0 Offset: 0x1AC8AA1 VA: 0x1AC89A0
	protected string get_TargetHost() { }

	// RVA: 0x1AC89B0 Offset: 0x1AC8AB1 VA: 0x1AC89B0
	protected string get_ServerName() { }

	// RVA: 0x1AC89C0 Offset: 0x1AC8AC1 VA: 0x1AC89C0
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StartHandshake();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ProcessHandshake();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FinishHandshake();

	// RVA: 0x1AC89D0 Offset: 0x1AC8AD1 VA: 0x1AC89D0
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract X509Certificate get_LocalClientCertificate();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Shutdown();

	// RVA: 0x1AC89E0 Offset: 0x1AC8AE1 VA: 0x1AC89E0
	protected bool ValidateCertificate(X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x1AC8AE0 Offset: 0x1AC8BE1 VA: 0x1AC8AE0
	protected X509Certificate SelectClientCertificate(X509Certificate serverCertificate, string[] acceptableIssuers) { }

	// RVA: 0x1AC8390 Offset: 0x1AC8491 VA: 0x1AC8390 Slot: 4
	public void Dispose() { }

	// RVA: 0x1AC8C50 Offset: 0x1AC8D51 VA: 0x1AC8C50 Slot: 13
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1AC8C60 Offset: 0x1AC8D61 VA: 0x1AC8C60 Slot: 1
	protected override void Finalize() { }
}

