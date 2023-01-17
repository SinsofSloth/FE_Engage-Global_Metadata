// Namespace: System.Net
public class NetworkCredential : ICredentials // TypeDefIndex: 2471
{
	// Fields
	private string m_domain; // 0x10
	private string m_userName; // 0x18
	private SecureString m_password; // 0x20

	// Properties
	public string UserName { get; set; }
	public string Password { get; set; }
	public string Domain { get; set; }

	// Methods

	// RVA: 0x1ACED70 Offset: 0x1ACEE71 VA: 0x1ACED70
	public void .ctor(string userName, string password) { }

	// RVA: 0x1ACEDF0 Offset: 0x1ACEEF1 VA: 0x1ACEDF0
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x1ACF050 Offset: 0x1ACF151 VA: 0x1ACF050
	public string get_UserName() { }

	// RVA: 0x1ACEEF0 Offset: 0x1ACEFF1 VA: 0x1ACEEF0
	public void set_UserName(string value) { }

	// RVA: 0x1ACF060 Offset: 0x1ACF161 VA: 0x1ACF060
	public string get_Password() { }

	// RVA: 0x1ACEF80 Offset: 0x1ACF081 VA: 0x1ACEF80
	public void set_Password(string value) { }

	// RVA: 0x1ACF080 Offset: 0x1ACF181 VA: 0x1ACF080
	public string get_Domain() { }

	// RVA: 0x1ACEFC0 Offset: 0x1ACF0C1 VA: 0x1ACEFC0
	public void set_Domain(string value) { }

	// RVA: 0x1ACF090 Offset: 0x1ACF191 VA: 0x1ACF090
	internal string InternalGetUserName() { }

	// RVA: 0x1ACF070 Offset: 0x1ACF171 VA: 0x1ACF070
	internal string InternalGetPassword() { }

	// RVA: 0x1ACF0A0 Offset: 0x1ACF1A1 VA: 0x1ACF0A0
	internal string InternalGetDomain() { }

	// RVA: 0x1ACF0B0 Offset: 0x1ACF1B1 VA: 0x1ACF0B0 Slot: 4
	public NetworkCredential GetCredential(Uri uri, string authType) { }
}

