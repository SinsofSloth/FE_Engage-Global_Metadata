// Namespace: System.Net
[Serializable]
public sealed class Cookie // TypeDefIndex: 2507
{
	// Fields
	internal static readonly char[] PortSplitDelimiters; // 0x0
	internal static readonly char[] Reserved2Name; // 0x8
	internal static readonly char[] Reserved2Value; // 0x10
	private static Comparer staticComparer; // 0x18
	private string m_comment; // 0x10
	private Uri m_commentUri; // 0x18
	private CookieVariant m_cookieVariant; // 0x20
	private bool m_discard; // 0x24
	private string m_domain; // 0x28
	private bool m_domain_implicit; // 0x30
	private DateTime m_expires; // 0x38
	private string m_name; // 0x40
	private string m_path; // 0x48
	private bool m_path_implicit; // 0x50
	private string m_port; // 0x58
	private bool m_port_implicit; // 0x60
	private int[] m_port_list; // 0x68
	private bool m_secure; // 0x70
	[OptionalFieldAttribute] // RVA: 0x31660 Offset: 0x31761 VA: 0x31660
	private bool m_httpOnly; // 0x71
	private DateTime m_timeStamp; // 0x78
	private string m_value; // 0x80
	private int m_version; // 0x88
	private string m_domainKey; // 0x90
	internal bool IsQuotedVersion; // 0x98
	internal bool IsQuotedDomain; // 0x99

	// Properties
	public string Comment { get; set; }
	public Uri CommentUri { set; }
	public bool HttpOnly { set; }
	public bool Discard { set; }
	public string Domain { get; set; }
	private string _Domain { get; }
	public bool Expired { get; }
	public DateTime Expires { set; }
	public string Name { get; }
	public string Path { get; set; }
	private string _Path { get; }
	internal bool Plain { get; }
	public string Port { set; }
	internal int[] PortList { get; }
	private string _Port { get; }
	public bool Secure { get; set; }
	public string Value { get; set; }
	internal CookieVariant Variant { get; }
	internal string DomainKey { get; }
	public int Version { get; set; }
	private string _Version { get; }

	// Methods

	// RVA: 0x1B4AC60 Offset: 0x1B4AD61 VA: 0x1B4AC60
	public void .ctor() { }

	// RVA: 0x1B4ADD0 Offset: 0x1B4AED1 VA: 0x1B4ADD0
	public string get_Comment() { }

	// RVA: 0x1B4ADE0 Offset: 0x1B4AEE1 VA: 0x1B4ADE0
	public void set_Comment(string value) { }

	// RVA: 0x1B4AE50 Offset: 0x1B4AF51 VA: 0x1B4AE50
	public void set_CommentUri(Uri value) { }

	// RVA: 0x1B4AE60 Offset: 0x1B4AF61 VA: 0x1B4AE60
	public void set_HttpOnly(bool value) { }

	// RVA: 0x1B4AE70 Offset: 0x1B4AF71 VA: 0x1B4AE70
	public void set_Discard(bool value) { }

	// RVA: 0x1B4AE80 Offset: 0x1B4AF81 VA: 0x1B4AE80
	public string get_Domain() { }

	// RVA: 0x1B4AE90 Offset: 0x1B4AF91 VA: 0x1B4AE90
	public void set_Domain(string value) { }

	// RVA: 0x1B4AF20 Offset: 0x1B4B021 VA: 0x1B4AF20
	private string get__Domain() { }

	// RVA: 0x1B4B000 Offset: 0x1B4B101 VA: 0x1B4B000
	public bool get_Expired() { }

	// RVA: 0x1B4B0E0 Offset: 0x1B4B1E1 VA: 0x1B4B0E0
	public void set_Expires(DateTime value) { }

	// RVA: 0x1B4B0F0 Offset: 0x1B4B1F1 VA: 0x1B4B0F0
	public string get_Name() { }

	// RVA: 0x1B4B100 Offset: 0x1B4B201 VA: 0x1B4B100
	internal bool InternalSetName(string value) { }

	// RVA: 0x1B4B230 Offset: 0x1B4B331 VA: 0x1B4B230
	public string get_Path() { }

	// RVA: 0x1B4B240 Offset: 0x1B4B341 VA: 0x1B4B240
	public void set_Path(string value) { }

	// RVA: 0x1B4B2C0 Offset: 0x1B4B3C1 VA: 0x1B4B2C0
	private string get__Path() { }

	// RVA: 0x1B4AFF0 Offset: 0x1B4B0F1 VA: 0x1B4AFF0
	internal bool get_Plain() { }

	// RVA: 0x1B4B360 Offset: 0x1B4B461 VA: 0x1B4B360
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x1B4B3C0 Offset: 0x1B4B4C1 VA: 0x1B4B3C0
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x1B4C090 Offset: 0x1B4C191 VA: 0x1B4C090
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x1B4C210 Offset: 0x1B4C311 VA: 0x1B4C210
	public void set_Port(string value) { }

	// RVA: 0x1B4C520 Offset: 0x1B4C621 VA: 0x1B4C520
	internal int[] get_PortList() { }

	// RVA: 0x1B4C530 Offset: 0x1B4C631 VA: 0x1B4C530
	private string get__Port() { }

	// RVA: 0x1B4C600 Offset: 0x1B4C701 VA: 0x1B4C600
	public bool get_Secure() { }

	// RVA: 0x1B4C610 Offset: 0x1B4C711 VA: 0x1B4C610
	public void set_Secure(bool value) { }

	// RVA: 0x1B4C620 Offset: 0x1B4C721 VA: 0x1B4C620
	public string get_Value() { }

	// RVA: 0x1B4C630 Offset: 0x1B4C731 VA: 0x1B4C630
	public void set_Value(string value) { }

	// RVA: 0x1B4C6A0 Offset: 0x1B4C7A1 VA: 0x1B4C6A0
	internal CookieVariant get_Variant() { }

	// RVA: 0x1B4C6B0 Offset: 0x1B4C7B1 VA: 0x1B4C6B0
	internal string get_DomainKey() { }

	// RVA: 0x1B4C6D0 Offset: 0x1B4C7D1 VA: 0x1B4C6D0
	public int get_Version() { }

	// RVA: 0x1B4C6E0 Offset: 0x1B4C7E1 VA: 0x1B4C6E0
	public void set_Version(int value) { }

	// RVA: 0x1B4C760 Offset: 0x1B4C861 VA: 0x1B4C760
	private string get__Version() { }

	// RVA: 0x1B4C870 Offset: 0x1B4C971 VA: 0x1B4C870
	internal static IComparer GetComparer() { }

	// RVA: 0x1B4C8E0 Offset: 0x1B4C9E1 VA: 0x1B4C8E0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1B4C9D0 Offset: 0x1B4CAD1 VA: 0x1B4C9D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B4CD00 Offset: 0x1B4CE01 VA: 0x1B4CD00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B4D210 Offset: 0x1B4D311 VA: 0x1B4D210
	private static void .cctor() { }
}

