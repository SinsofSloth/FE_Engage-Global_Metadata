// Namespace: System.Net
internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 2569
{
	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1AD1E00 Offset: 0x1AD1F01 VA: 0x1AD1E00
	public void .ctor() { }

	// RVA: 0x1AD1E80 Offset: 0x1AD1F81 VA: 0x1AD1E80 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1AD1F60 Offset: 0x1AD2061 VA: 0x1AD1F60 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1AD1F70 Offset: 0x1AD2071 VA: 0x1AD1F70 Slot: 6
	public string get_AuthenticationType() { }
}

