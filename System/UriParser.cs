// Namespace: System
public abstract class UriParser // TypeDefIndex: 2232
{
	// Fields
	private const UriSyntaxFlags SchemeOnlyFlags = 16;
	private static readonly Dictionary<string, UriParser> m_Table; // 0x0
	private static Dictionary<string, UriParser> m_TempTable; // 0x8
	private UriSyntaxFlags m_Flags; // 0x10
	private UriSyntaxFlags m_UpdatableFlags; // 0x14
	private bool m_UpdatableFlagsUsed; // 0x18
	private const UriSyntaxFlags c_UpdatableFlags = 33554432;
	private int m_Port; // 0x1C
	private string m_Scheme; // 0x20
	internal const int NoDefaultPort = -1;
	private const int c_InitialTableSize = 25;
	internal static UriParser HttpUri; // 0x10
	internal static UriParser HttpsUri; // 0x18
	internal static UriParser WsUri; // 0x20
	internal static UriParser WssUri; // 0x28
	internal static UriParser FtpUri; // 0x30
	internal static UriParser FileUri; // 0x38
	internal static UriParser GopherUri; // 0x40
	internal static UriParser NntpUri; // 0x48
	internal static UriParser NewsUri; // 0x50
	internal static UriParser MailToUri; // 0x58
	internal static UriParser UuidUri; // 0x60
	internal static UriParser TelnetUri; // 0x68
	internal static UriParser LdapUri; // 0x70
	internal static UriParser NetTcpUri; // 0x78
	internal static UriParser NetPipeUri; // 0x80
	internal static UriParser VsMacrosUri; // 0x88
	private static readonly UriParser.UriQuirksVersion s_QuirksVersion; // 0x90
	private const int c_MaxCapacity = 512;
	private const UriSyntaxFlags UnknownV1SyntaxFlags = 351342590;
	private static readonly UriSyntaxFlags HttpSyntaxFlags; // 0x94
	private const UriSyntaxFlags FtpSyntaxFlags = 367005533;
	private static readonly UriSyntaxFlags FileSyntaxFlags; // 0x98
	private const UriSyntaxFlags VsmacrosSyntaxFlags = 399519697;
	private const UriSyntaxFlags GopherSyntaxFlags = 337645405;
	private const UriSyntaxFlags NewsSyntaxFlags = 268435536;
	private const UriSyntaxFlags NntpSyntaxFlags = 337645405;
	private const UriSyntaxFlags TelnetSyntaxFlags = 337645405;
	private const UriSyntaxFlags LdapSyntaxFlags = 337645565;
	private const UriSyntaxFlags MailtoSyntaxFlags = 335564796;
	private const UriSyntaxFlags NetPipeSyntaxFlags = 400559729;
	private const UriSyntaxFlags NetTcpSyntaxFlags = 400559737;

	// Properties
	internal string SchemeName { get; }
	internal int DefaultPort { get; }
	internal static bool ShouldUseLegacyV2Quirks { get; }
	internal UriSyntaxFlags Flags { get; }
	internal bool IsSimple { get; }

	// Methods

	// RVA: 0x1944A90 Offset: 0x1944B91 VA: 0x1944A90
	internal string get_SchemeName() { }

	// RVA: 0x1944AA0 Offset: 0x1944BA1 VA: 0x1944AA0
	internal int get_DefaultPort() { }

	// RVA: 0x1944AB0 Offset: 0x1944BB1 VA: 0x1944AB0 Slot: 4
	protected virtual UriParser OnNewUri() { }

	// RVA: 0x1944AC0 Offset: 0x1944BC1 VA: 0x1944AC0 Slot: 5
	protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

	// RVA: 0x1944B00 Offset: 0x1944C01 VA: 0x1944B00 Slot: 6
	protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

	// RVA: 0x1944CE0 Offset: 0x1944DE1 VA: 0x1944CE0 Slot: 7
	protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	// RVA: 0x1944EF0 Offset: 0x1944FF1 VA: 0x1944EF0 Slot: 8
	protected virtual bool IsWellFormedOriginalString(Uri uri) { }

	// RVA: 0x19448B0 Offset: 0x19449B1 VA: 0x19448B0
	internal static bool get_ShouldUseLegacyV2Quirks() { }

	// RVA: 0x1944F00 Offset: 0x1945001 VA: 0x1944F00
	private static void .cctor() { }

	// RVA: 0x19457F0 Offset: 0x19458F1 VA: 0x19457F0
	internal UriSyntaxFlags get_Flags() { }

	// RVA: 0x1942860 Offset: 0x1942961 VA: 0x1942860
	internal bool NotAny(UriSyntaxFlags flags) { }

	// RVA: 0x1942800 Offset: 0x1942901 VA: 0x1942800
	internal bool InFact(UriSyntaxFlags flags) { }

	// RVA: 0x1945860 Offset: 0x1945961 VA: 0x1945860
	internal bool IsAllSet(UriSyntaxFlags flags) { }

	// RVA: 0x1945800 Offset: 0x1945901 VA: 0x1945800
	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	// RVA: 0x19458C0 Offset: 0x19459C1 VA: 0x19458C0
	internal void .ctor(UriSyntaxFlags flags) { }

	// RVA: 0x1945940 Offset: 0x1945A41 VA: 0x1945940
	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	// RVA: 0x1942710 Offset: 0x1942811 VA: 0x1942710
	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	// RVA: 0x1945C40 Offset: 0x1945D41 VA: 0x1945C40
	internal bool get_IsSimple() { }

	// RVA: 0x1945C50 Offset: 0x1945D51 VA: 0x1945C50
	internal UriParser InternalOnNewUri() { }

	// RVA: 0x1945CC0 Offset: 0x1945DC1 VA: 0x1945CC0
	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

	// RVA: 0x1945CD0 Offset: 0x1945DD1 VA: 0x1945CD0
	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

	// RVA: 0x1945CE0 Offset: 0x1945DE1 VA: 0x1945CE0
	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x1945CF0 Offset: 0x1945DF1 VA: 0x1945CF0
	internal bool InternalIsWellFormedOriginalString(Uri thisUri) { }
}

