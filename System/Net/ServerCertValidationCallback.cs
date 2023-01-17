// Namespace: System.Net
internal class ServerCertValidationCallback // TypeDefIndex: 2534
{
	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Methods

	// RVA: 0x2D04BF0 Offset: 0x2D04CF1 VA: 0x2D04BF0
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0x2D04C90 Offset: 0x2D04D91 VA: 0x2D04C90
	internal void Callback(object state) { }

	// RVA: 0x2D04D40 Offset: 0x2D04E41 VA: 0x2D04D40
	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}

