// Namespace: Mono.Security.Interface
[FlagsAttribute] // RVA: 0x859A0 Offset: 0x85AA1 VA: 0x859A0
public enum MonoSslPolicyErrors // TypeDefIndex: 1561
{
	// Fields
	public int value__; // 0x0
	public const MonoSslPolicyErrors None = 0;
	public const MonoSslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const MonoSslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const MonoSslPolicyErrors RemoteCertificateChainErrors = 4;
}

