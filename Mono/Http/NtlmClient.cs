// Namespace: Mono.Http
internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 2210
{
	// Fields
	private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache; // 0x0

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1AD14D0 Offset: 0x1AD15D1 VA: 0x1AD14D0 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1AD1CF0 Offset: 0x1AD1DF1 VA: 0x1AD1CF0 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1AD1D00 Offset: 0x1AD1E01 VA: 0x1AD1D00 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x1AD1D50 Offset: 0x1AD1E51 VA: 0x1AD1D50
	public void .ctor() { }

	// RVA: 0x1AD1D60 Offset: 0x1AD1E61 VA: 0x1AD1D60
	private static void .cctor() { }
}

