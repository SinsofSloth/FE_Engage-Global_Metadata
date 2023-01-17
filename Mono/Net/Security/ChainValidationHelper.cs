// Namespace: Mono.Net.Security
internal class ChainValidationHelper : ICertificateValidator2, ICertificateValidator // TypeDefIndex: 2191
{
	// Fields
	private readonly object sender; // 0x10
	private readonly MonoTlsSettings settings; // 0x18
	private readonly MonoTlsProvider provider; // 0x20
	private readonly ServerCertValidationCallback certValidationCallback; // 0x28
	private readonly LocalCertSelectionCallback certSelectionCallback; // 0x30
	private readonly ServerCertValidationCallbackWrapper callbackWrapper; // 0x38
	private readonly MonoTlsStream tlsStream; // 0x40
	private readonly HttpWebRequest request; // 0x48

	// Properties
	public MonoTlsSettings Settings { get; }

	// Methods

	// RVA: 0x1B48E30 Offset: 0x1B48F31 VA: 0x1B48E30
	internal static ICertificateValidator GetInternalValidator(MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x1B49230 Offset: 0x1B49331 VA: 0x1B49230
	internal static ChainValidationHelper Create(MonoTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0x1B48EE0 Offset: 0x1B48FE1 VA: 0x1B48EE0
	private void .ctor(MonoTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream, ServerCertValidationCallbackWrapper callbackWrapper) { }

	// RVA: 0x1B492D0 Offset: 0x1B493D1 VA: 0x1B492D0
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x1B49320 Offset: 0x1B49421 VA: 0x1B49320 Slot: 5
	public MonoTlsSettings get_Settings() { }

	// RVA: 0x1B49330 Offset: 0x1B49431 VA: 0x1B49330 Slot: 6
	public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate) { }

	// RVA: 0x1B49390 Offset: 0x1B49491 VA: 0x1B49390 Slot: 4
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x1B49480 Offset: 0x1B49581 VA: 0x1B49480
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0x1B49570 Offset: 0x1B49671 VA: 0x1B49570
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }
}

