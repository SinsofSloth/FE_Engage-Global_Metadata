// Namespace: System.Net
internal class DigestClient : IAuthenticationModule // TypeDefIndex: 2542
{
	// Fields
	private static readonly Hashtable cache; // 0x0

	// Properties
	private static Hashtable Cache { get; }
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1B57020 Offset: 0x1B57121 VA: 0x1B57020
	private static Hashtable get_Cache() { }

	// RVA: 0x1B571A0 Offset: 0x1B572A1 VA: 0x1B571A0
	private static void CheckExpired(int count) { }

	// RVA: 0x1B57900 Offset: 0x1B57A01 VA: 0x1B57900 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1B58420 Offset: 0x1B58521 VA: 0x1B58420 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1B585B0 Offset: 0x1B586B1 VA: 0x1B585B0 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x1B3F350 Offset: 0x1B3F451 VA: 0x1B3F350
	public void .ctor() { }

	// RVA: 0x1B58600 Offset: 0x1B58701 VA: 0x1B58600
	private static void .cctor() { }
}

