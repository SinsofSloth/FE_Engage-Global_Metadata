// Namespace: Mono.Security.Interface
public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 1562
{
	// Methods

	// RVA: 0x1BCC4B0 Offset: 0x1BCC5B1 VA: 0x1BCC4B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BCC4D0 Offset: 0x1BCC5D1 VA: 0x1BCC4D0 Slot: 13
	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x1BCC890 Offset: 0x1BCC991 VA: 0x1BCC890 Slot: 14
	public virtual IAsyncResult BeginInvoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	// RVA: 0x1BCC940 Offset: 0x1BCCA41 VA: 0x1BCC940 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

