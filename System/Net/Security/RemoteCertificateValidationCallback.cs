// Namespace: System.Net.Security
public sealed class RemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 2645
{
	// Methods

	// RVA: 0x2D03620 Offset: 0x2D03721 VA: 0x2D03620
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D03640 Offset: 0x2D03741 VA: 0x2D03640 Slot: 13
	public virtual bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x2D03A00 Offset: 0x2D03B01 VA: 0x2D03A00 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	// RVA: 0x2D03AB0 Offset: 0x2D03BB1 VA: 0x2D03AB0 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

