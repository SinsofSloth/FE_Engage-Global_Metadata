// Namespace: System.Net
internal class DigestSession // TypeDefIndex: 2541
{
	// Fields
	private static RandomNumberGenerator rng; // 0x0
	private DateTime lastUse; // 0x10
	private int _nc; // 0x18
	private HashAlgorithm hash; // 0x20
	private DigestHeaderParser parser; // 0x28
	private string _cnonce; // 0x30

	// Properties
	public string Algorithm { get; }
	public string Realm { get; }
	public string Nonce { get; }
	public string Opaque { get; }
	public string QOP { get; }
	public string CNonce { get; }
	public DateTime LastUse { get; }

	// Methods

	// RVA: 0x1B590E0 Offset: 0x1B591E1 VA: 0x1B590E0
	private static void .cctor() { }

	// RVA: 0x1B57C10 Offset: 0x1B57D11 VA: 0x1B57C10
	public void .ctor() { }

	// RVA: 0x1B59140 Offset: 0x1B59241 VA: 0x1B59140
	public string get_Algorithm() { }

	// RVA: 0x1B59180 Offset: 0x1B59281 VA: 0x1B59180
	public string get_Realm() { }

	// RVA: 0x1B57DB0 Offset: 0x1B57EB1 VA: 0x1B57DB0
	public string get_Nonce() { }

	// RVA: 0x1B591B0 Offset: 0x1B592B1 VA: 0x1B591B0
	public string get_Opaque() { }

	// RVA: 0x1B591F0 Offset: 0x1B592F1 VA: 0x1B591F0
	public string get_QOP() { }

	// RVA: 0x1B59230 Offset: 0x1B59331 VA: 0x1B59230
	public string get_CNonce() { }

	// RVA: 0x1B57CA0 Offset: 0x1B57DA1 VA: 0x1B57CA0
	public bool Parse(string challenge) { }

	// RVA: 0x1B59360 Offset: 0x1B59461 VA: 0x1B59360
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x1B594B0 Offset: 0x1B595B1 VA: 0x1B594B0
	private string HA1(string username, string password) { }

	// RVA: 0x1B595E0 Offset: 0x1B596E1 VA: 0x1B595E0
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x1B596C0 Offset: 0x1B597C1 VA: 0x1B596C0
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x1B57DF0 Offset: 0x1B57EF1 VA: 0x1B57DF0
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1B59830 Offset: 0x1B59931 VA: 0x1B59830
	public DateTime get_LastUse() { }
}

