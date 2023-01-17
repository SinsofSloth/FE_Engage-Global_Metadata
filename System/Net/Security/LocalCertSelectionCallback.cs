// Namespace: System.Net.Security
internal sealed class LocalCertSelectionCallback : MulticastDelegate // TypeDefIndex: 2647
{
	// Methods

	// RVA: 0x1AC4630 Offset: 0x1AC4731 VA: 0x1AC4630
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1AC4650 Offset: 0x1AC4751 VA: 0x1AC4650 Slot: 13
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x1AC4A10 Offset: 0x1AC4B11 VA: 0x1AC4A10 Slot: 14
	public virtual IAsyncResult BeginInvoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	// RVA: 0x1AC4A50 Offset: 0x1AC4B51 VA: 0x1AC4A50 Slot: 15
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }
}

