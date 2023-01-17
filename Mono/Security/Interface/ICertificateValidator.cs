// Namespace: Mono.Security.Interface
public interface ICertificateValidator // TypeDefIndex: 1555
{
	// Properties
	public abstract MonoTlsSettings Settings { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MonoTlsSettings get_Settings();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate);
}

