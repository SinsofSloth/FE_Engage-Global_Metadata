// Namespace: Mono.Net.Security
internal static class SystemCertificateValidator // TypeDefIndex: 2204
{
	// Fields
	private static bool is_macosx; // 0x0
	private static X509KeyUsageFlags s_flags; // 0x4

	// Methods

	// RVA: 0x2D136E0 Offset: 0x2D137E1 VA: 0x2D136E0
	private static void .cctor() { }

	// RVA: 0x2D13780 Offset: 0x2D13881 VA: 0x2D13780
	public static X509Chain CreateX509Chain(X509CertificateCollection certs) { }

	// RVA: 0x2D13870 Offset: 0x2D13971 VA: 0x2D13870
	internal static bool NeedsChain(MonoTlsSettings settings) { }
}

