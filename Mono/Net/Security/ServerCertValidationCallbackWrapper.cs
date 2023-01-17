// Namespace: Mono.Net.Security
internal sealed class ServerCertValidationCallbackWrapper : MulticastDelegate // TypeDefIndex: 2190
{
	// Methods

	// RVA: 0x2D04EB0 Offset: 0x2D04FB1 VA: 0x2D04EB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D04ED0 Offset: 0x2D04FD1 VA: 0x2D04ED0 Slot: 13
	public virtual bool Invoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x2D05290 Offset: 0x2D05391 VA: 0x2D05290 Slot: 14
	public virtual IAsyncResult BeginInvoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback __callback, object object) { }

	// RVA: 0x2D05340 Offset: 0x2D05441 VA: 0x2D05340 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

