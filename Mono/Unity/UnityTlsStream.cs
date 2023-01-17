// Namespace: Mono.Unity
internal class UnityTlsStream : MobileAuthenticatedStream // TypeDefIndex: 2159
{
	// Methods

	// RVA: 0x2D179B0 Offset: 0x2D17AB1 VA: 0x2D179B0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	// RVA: 0x2D18150 Offset: 0x2D18251 VA: 0x2D18150 Slot: 56
	protected override MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }
}

