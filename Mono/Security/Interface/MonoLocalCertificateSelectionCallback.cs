// Namespace: Mono.Security.Interface
public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 1563
{
	// Methods

	// RVA: 0x1BCC080 Offset: 0x1BCC181 VA: 0x1BCC080
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BCC0A0 Offset: 0x1BCC1A1 VA: 0x1BCC0A0 Slot: 13
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x1BCC460 Offset: 0x1BCC561 VA: 0x1BCC460 Slot: 14
	public virtual IAsyncResult BeginInvoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	// RVA: 0x1BCC4A0 Offset: 0x1BCC5A1 VA: 0x1BCC4A0 Slot: 15
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }
}

