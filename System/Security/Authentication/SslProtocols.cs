// Namespace: System.Security.Authentication
[FlagsAttribute] // RVA: 0x30530 Offset: 0x30631 VA: 0x30530
public enum SslProtocols // TypeDefIndex: 2339
{
	// Fields
	public int value__; // 0x0
	public const SslProtocols None = 0;
	public const SslProtocols Ssl2 = 12;
	public const SslProtocols Ssl3 = 48;
	public const SslProtocols Tls = 192;
	[MonoTODOAttribute] // RVA: 0x31590 Offset: 0x31691 VA: 0x31590
	public const SslProtocols Tls11 = 768;
	[MonoTODOAttribute] // RVA: 0x315D0 Offset: 0x316D1 VA: 0x315D0
	public const SslProtocols Tls12 = 3072;
	public const SslProtocols Default = 240;
}

