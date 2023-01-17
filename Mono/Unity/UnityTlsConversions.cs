// Namespace: Mono.Unity
internal static class UnityTlsConversions // TypeDefIndex: 2157
{
	// Methods

	// RVA: 0x2D157F0 Offset: 0x2D158F1 VA: 0x2D157F0
	public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0x2D15920 Offset: 0x2D15A21 VA: 0x2D15920
	public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0x2D166A0 Offset: 0x2D167A1 VA: 0x2D166A0
	public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol) { }

	// RVA: 0x2D171C0 Offset: 0x2D172C1 VA: 0x2D171C0
	public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	// RVA: 0x2D17560 Offset: 0x2D17661 VA: 0x2D17560
	public static MonoSslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult) { }

	// RVA: 0x2D17620 Offset: 0x2D17721 VA: 0x2D17620
	public static X509ChainStatusFlags VerifyResultToChainStatus(UnityTls.unitytls_x509verify_result verifyResult) { }
}

