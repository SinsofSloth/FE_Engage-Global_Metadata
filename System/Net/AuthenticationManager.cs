// Namespace: System.Net
public class AuthenticationManager // TypeDefIndex: 2535
{
	// Fields
	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Methods

	// RVA: 0x1B3F0B0 Offset: 0x1B3F1B1 VA: 0x1B3F0B0
	private static void EnsureModules() { }

	// RVA: 0x1B3F370 Offset: 0x1B3F471 VA: 0x1B3F370
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x1B3F480 Offset: 0x1B3F581 VA: 0x1B3F480
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x1B3F910 Offset: 0x1B3FA11 VA: 0x1B3F910
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x1B3FDD0 Offset: 0x1B3FED1 VA: 0x1B3FDD0
	private static void .cctor() { }
}

