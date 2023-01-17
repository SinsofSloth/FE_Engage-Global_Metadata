// Namespace: System.Net
public interface ICertificatePolicy // TypeDefIndex: 2458
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem);
}

