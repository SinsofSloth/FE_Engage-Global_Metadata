// Namespace: System.Net.Security
[FlagsAttribute] // RVA: 0x31270 Offset: 0x31371 VA: 0x31270
public enum SslPolicyErrors // TypeDefIndex: 2646
{
	// Fields
	public int value__; // 0x0
	public const SslPolicyErrors None = 0;
	public const SslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const SslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const SslPolicyErrors RemoteCertificateChainErrors = 4;
}

