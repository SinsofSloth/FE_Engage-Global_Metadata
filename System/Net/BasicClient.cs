// Namespace: System.Net
internal class BasicClient : IAuthenticationModule // TypeDefIndex: 2536
{
	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1B40050 Offset: 0x1B40151 VA: 0x1B40050 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1B40660 Offset: 0x1B40761 VA: 0x1B40660
	private static byte[] GetBytes(string str) { }

	// RVA: 0x1B40100 Offset: 0x1B40201 VA: 0x1B40100
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1B40720 Offset: 0x1B40821 VA: 0x1B40720 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1B40730 Offset: 0x1B40831 VA: 0x1B40730 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x1B3F360 Offset: 0x1B3F461 VA: 0x1B3F360
	public void .ctor() { }
}

