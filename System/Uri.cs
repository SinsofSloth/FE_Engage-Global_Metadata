// Namespace: System
[TypeConverterAttribute] // RVA: 0x2FBC0 Offset: 0x2FCC1 VA: 0x2FBC0
[Serializable]
public class Uri : ISerializable // TypeDefIndex: 2220
{
	// Fields
	public static readonly string UriSchemeFile; // 0x0
	public static readonly string UriSchemeFtp; // 0x8
	public static readonly string UriSchemeGopher; // 0x10
	public static readonly string UriSchemeHttp; // 0x18
	public static readonly string UriSchemeHttps; // 0x20
	internal static readonly string UriSchemeWs; // 0x28
	internal static readonly string UriSchemeWss; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	public static readonly string UriSchemeNetTcp; // 0x50
	public static readonly string UriSchemeNetPipe; // 0x58
	public static readonly string SchemeDelimiter; // 0x60
	private const int c_Max16BitUtf8SequenceLength = 12;
	internal const int c_MaxUriBufferSize = 65520;
	private const int c_MaxUriSchemeName = 1024;
	private string m_String; // 0x10
	private string m_originalUnicodeString; // 0x18
	private UriParser m_Syntax; // 0x20
	private string m_DnsSafeHost; // 0x28
	private Uri.Flags m_Flags; // 0x30
	private Uri.UriInfo m_Info; // 0x38
	private bool m_iriParsing; // 0x40
	private static bool s_ConfigInitialized; // 0x68
	private static bool s_ConfigInitializing; // 0x69
	private static UriIdnScope s_IdnScope; // 0x6C
	private static bool s_IriParsing; // 0x70
	private static bool useDotNetRelativeOrAbsolute; // 0x71
	private const UriKind DotNetRelativeOrAbsolute = 300;
	internal static readonly bool IsWindowsFileSystem; // 0x72
	private static object s_initLock; // 0x78
	private const UriFormat V1ToStringUnescape = 32767;
	internal const char c_DummyChar = '\xffff';
	internal const char c_EOL = '\xfffe';
	internal static readonly char[] HexLowerChars; // 0x80
	private static readonly char[] _WSchars; // 0x88

	// Properties
	private bool IsImplicitFile { get; }
	private bool IsUncOrDosPath { get; }
	private bool IsDosPath { get; }
	private bool IsUncPath { get; }
	private Uri.Flags HostType { get; }
	private UriParser Syntax { get; }
	private bool IsNotAbsoluteUri { get; }
	private bool AllowIdn { get; }
	internal bool UserDrivenParsing { get; }
	private ushort SecuredPathIndex { get; }
	public string AbsolutePath { get; }
	private string PrivateAbsolutePath { get; }
	public string AbsoluteUri { get; }
	public string LocalPath { get; }
	public string Authority { get; }
	public UriHostNameType HostNameType { get; }
	public bool IsDefaultPort { get; }
	public bool IsFile { get; }
	public bool IsLoopback { get; }
	public string PathAndQuery { get; }
	public bool IsUnc { get; }
	public string Host { get; }
	private static object InitializeLock { get; }
	public int Port { get; }
	public string Query { get; }
	public string Fragment { get; }
	public string Scheme { get; }
	private bool OriginalStringSwitched { get; }
	public string OriginalString { get; }
	public string DnsSafeHost { get; }
	public bool IsAbsoluteUri { get; }
	public bool UserEscaped { get; }
	public string UserInfo { get; }
	internal bool HasAuthority { get; }

	// Methods

	// RVA: 0x2D18280 Offset: 0x2D18381 VA: 0x2D18280
	private bool get_IsImplicitFile() { }

	// RVA: 0x2D18290 Offset: 0x2D18391 VA: 0x2D18290
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x2D182A0 Offset: 0x2D183A1 VA: 0x2D182A0
	private bool get_IsDosPath() { }

	// RVA: 0x2D182B0 Offset: 0x2D183B1 VA: 0x2D182B0
	private bool get_IsUncPath() { }

	// RVA: 0x2D182C0 Offset: 0x2D183C1 VA: 0x2D182C0
	private Uri.Flags get_HostType() { }

	// RVA: 0x2D182D0 Offset: 0x2D183D1 VA: 0x2D182D0
	private UriParser get_Syntax() { }

	// RVA: 0x2D182E0 Offset: 0x2D183E1 VA: 0x2D182E0
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x2D182F0 Offset: 0x2D183F1 VA: 0x2D182F0
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x2D183B0 Offset: 0x2D184B1 VA: 0x2D183B0
	private bool get_AllowIdn() { }

	// RVA: 0x2D184B0 Offset: 0x2D185B1 VA: 0x2D184B0
	private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags) { }

	// RVA: 0x2D185D0 Offset: 0x2D186D1 VA: 0x2D185D0
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x2D185E0 Offset: 0x2D186E1 VA: 0x2D185E0
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x2D185F0 Offset: 0x2D186F1 VA: 0x2D185F0
	private void SetUserDrivenParsing() { }

	// RVA: 0x2D18610 Offset: 0x2D18711 VA: 0x2D18610
	private ushort get_SecuredPathIndex() { }

	// RVA: 0x2D184A0 Offset: 0x2D185A1 VA: 0x2D184A0
	private bool NotAny(Uri.Flags flags) { }

	// RVA: 0x2D18670 Offset: 0x2D18771 VA: 0x2D18670
	private bool InFact(Uri.Flags flags) { }

	// RVA: 0x2D185C0 Offset: 0x2D186C1 VA: 0x2D185C0
	private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x2D18680 Offset: 0x2D18781 VA: 0x2D18680
	private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x2D18690 Offset: 0x2D18791 VA: 0x2D18690
	private Uri.UriInfo EnsureUriInfo() { }

	// RVA: 0x2D18C50 Offset: 0x2D18D51 VA: 0x2D18C50
	private void EnsureParseRemaining() { }

	// RVA: 0x2D19A30 Offset: 0x2D19B31 VA: 0x2D19A30
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x2D07390 Offset: 0x2D07491 VA: 0x2D07390
	public void .ctor(string uriString) { }

	// RVA: 0x2D1A0A0 Offset: 0x2D1A1A1 VA: 0x2D1A0A0
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x2D1A130 Offset: 0x2D1A231 VA: 0x2D1A130
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x2D1A210 Offset: 0x2D1A311 VA: 0x2D1A210
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x2D1AAF0 Offset: 0x2D1ABF1 VA: 0x2D1AAF0
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x2D1AD20 Offset: 0x2D1AE21 VA: 0x2D1AD20
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	// RVA: 0x2D1BDB0 Offset: 0x2D1BEB1 VA: 0x2D1BDB0
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x2D1BF50 Offset: 0x2D1C051 VA: 0x2D1BF50
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2D1C070 Offset: 0x2D1C171 VA: 0x2D1C070 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2D1C080 Offset: 0x2D1C181 VA: 0x2D1C080
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2D1C1D0 Offset: 0x2D1C2D1 VA: 0x2D1C1D0
	public string get_AbsolutePath() { }

	// RVA: 0x2D1C290 Offset: 0x2D1C391 VA: 0x2D1C290
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x2D1C380 Offset: 0x2D1C481 VA: 0x2D1C380
	public string get_AbsoluteUri() { }

	// RVA: 0x2D1C4B0 Offset: 0x2D1C5B1 VA: 0x2D1C4B0
	public string get_LocalPath() { }

	// RVA: 0x2D07320 Offset: 0x2D07421 VA: 0x2D07320
	public string get_Authority() { }

	// RVA: 0x2D060F0 Offset: 0x2D061F1 VA: 0x2D060F0
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x2D1CBB0 Offset: 0x2D1CCB1 VA: 0x2D1CBB0
	public bool get_IsDefaultPort() { }

	// RVA: 0x2D1CC70 Offset: 0x2D1CD71 VA: 0x2D1CC70
	public bool get_IsFile() { }

	// RVA: 0x2D1CD40 Offset: 0x2D1CE41 VA: 0x2D1CD40
	public bool get_IsLoopback() { }

	// RVA: 0x2D1CDE0 Offset: 0x2D1CEE1 VA: 0x2D1CDE0
	public string get_PathAndQuery() { }

	// RVA: 0x2D1CEA0 Offset: 0x2D1CFA1 VA: 0x2D1CEA0
	public bool get_IsUnc() { }

	// RVA: 0x2D06080 Offset: 0x2D06181 VA: 0x2D06080
	public string get_Host() { }

	// RVA: 0x2D1CF10 Offset: 0x2D1D011 VA: 0x2D1CF10
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x2D1CF20 Offset: 0x2D1D021 VA: 0x2D1CF20
	private static object get_InitializeLock() { }

	// RVA: 0x2D1D020 Offset: 0x2D1D121 VA: 0x2D1D020
	private static void InitializeUriConfig() { }

	// RVA: 0x2D1C520 Offset: 0x2D1C621 VA: 0x2D1C520
	private string GetLocalPath() { }

	// RVA: 0x2D1D800 Offset: 0x2D1D901 VA: 0x2D1D800
	public int get_Port() { }

	// RVA: 0x2D1D8E0 Offset: 0x2D1D9E1 VA: 0x2D1D8E0
	public string get_Query() { }

	// RVA: 0x2D1DA10 Offset: 0x2D1DB11 VA: 0x2D1DA10
	public string get_Fragment() { }

	// RVA: 0x2D072B0 Offset: 0x2D073B1 VA: 0x2D072B0
	public string get_Scheme() { }

	// RVA: 0x2D1DB40 Offset: 0x2D1DC41 VA: 0x2D1DB40
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x2D1B0F0 Offset: 0x2D1B1F1 VA: 0x2D1B0F0
	public string get_OriginalString() { }

	// RVA: 0x2D1DBB0 Offset: 0x2D1DCB1 VA: 0x2D1DBB0
	public string get_DnsSafeHost() { }

	// RVA: 0x2D1A200 Offset: 0x2D1A301 VA: 0x2D1A200
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x2D1DE10 Offset: 0x2D1DF11 VA: 0x2D1DE10
	public bool get_UserEscaped() { }

	// RVA: 0x2D1DE20 Offset: 0x2D1DF21 VA: 0x2D1DE20
	public string get_UserInfo() { }

	// RVA: 0x2D1DE90 Offset: 0x2D1DF91 VA: 0x2D1DE90
	internal static bool IsGenDelim(char ch) { }

	// RVA: 0x2D1DEE0 Offset: 0x2D1DFE1 VA: 0x2D1DEE0
	public static bool CheckSchemeName(string schemeName) { }

	// RVA: 0x2D1E170 Offset: 0x2D1E271 VA: 0x2D1E170
	public static bool IsHexDigit(char character) { }

	// RVA: 0x2D1E1B0 Offset: 0x2D1E2B1 VA: 0x2D1E1B0
	public static int FromHex(char digit) { }

	// RVA: 0x2D1E260 Offset: 0x2D1E361 VA: 0x2D1E260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2D1E4E0 Offset: 0x2D1E5E1 VA: 0x2D1E4E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2D07270 Offset: 0x2D07371 VA: 0x2D07270
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x2D1A930 Offset: 0x2D1AA31 VA: 0x2D1A930
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x2D1E830 Offset: 0x2D1E931 VA: 0x2D1E830 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x2D1EF60 Offset: 0x2D1F061 VA: 0x2D1EF60
	public Uri MakeRelativeUri(Uri uri) { }

	// RVA: 0x2D1F580 Offset: 0x2D1F681 VA: 0x2D1F580
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x2D1F640 Offset: 0x2D1F741 VA: 0x2D1F640
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x2D1F730 Offset: 0x2D1F831 VA: 0x2D1F730
	private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x2D1FDF0 Offset: 0x2D1FEF1 VA: 0x2D1FDF0
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x2D1FE90 Offset: 0x2D1FF91 VA: 0x2D1FE90
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x2D21600 Offset: 0x2D21701 VA: 0x2D21600
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	// RVA: 0x2D186C0 Offset: 0x2D187C1 VA: 0x2D186C0
	private void CreateUriInfo(Uri.Flags cF) { }

	// RVA: 0x2D19A90 Offset: 0x2D19B91 VA: 0x2D19A90
	private void CreateHostString() { }

	// RVA: 0x2D21B30 Offset: 0x2D21C31 VA: 0x2D21B30
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId) { }

	// RVA: 0x2D21700 Offset: 0x2D21801 VA: 0x2D21700
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x2D1C1C0 Offset: 0x2D1C2C1 VA: 0x2D1C1C0
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x2D22330 Offset: 0x2D22431 VA: 0x2D22330
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x2D1D710 Offset: 0x2D1D811 VA: 0x2D1D710
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x2D22950 Offset: 0x2D22A51 VA: 0x2D22950
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	// RVA: 0x2D22430 Offset: 0x2D22531 VA: 0x2D22430
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x2D18C60 Offset: 0x2D18D61 VA: 0x2D18C60
	private void ParseRemaining() { }

	// RVA: 0x2D1F810 Offset: 0x2D1F911 VA: 0x2D1F810
	private static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x2D23E50 Offset: 0x2D23F51 VA: 0x2D23E50
	private static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) { }

	// RVA: 0x2D1AFA0 Offset: 0x2D1B0A1 VA: 0x2D1AFA0
	private static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) { }

	// RVA: 0x2D20580 Offset: 0x2D20681 VA: 0x2D20580
	private ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost) { }

	// RVA: 0x2D24420 Offset: 0x2D24521 VA: 0x2D24420
	private void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	// RVA: 0x2D247E0 Offset: 0x2D248E1 VA: 0x2D247E0
	private void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err) { }

	// RVA: 0x2D23D10 Offset: 0x2D23E11 VA: 0x2D23D10
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x2D24C80 Offset: 0x2D24D81 VA: 0x2D24C80
	private void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x2D21D40 Offset: 0x2D21E41 VA: 0x2D21D40
	private Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x2D23650 Offset: 0x2D23751 VA: 0x2D23650
	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) { }

	// RVA: 0x2D24D40 Offset: 0x2D24E41 VA: 0x2D24D40
	private static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

	// RVA: 0x2D1D210 Offset: 0x2D1D311 VA: 0x2D1D210
	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	// RVA: 0x2D1E400 Offset: 0x2D1E501 VA: 0x2D1E400
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x2D1B150 Offset: 0x2D1B251 VA: 0x2D1B150
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x2D1F230 Offset: 0x2D1F331 VA: 0x2D1F230
	private static string PathDifference(string path1, string path2, bool compareCase) { }

	// RVA: 0x2D24FB0 Offset: 0x2D250B1 VA: 0x2D24FB0
	internal bool get_HasAuthority() { }

	// RVA: 0x2D20530 Offset: 0x2D20631 VA: 0x2D20530
	private static bool IsLWS(char ch) { }

	// RVA: 0x2D1E0A0 Offset: 0x2D1E1A1 VA: 0x2D1E0A0
	private static bool IsAsciiLetter(char character) { }

	// RVA: 0x2D1E0D0 Offset: 0x2D1E1D1 VA: 0x2D1E0D0
	internal static bool IsAsciiLetterOrDigit(char character) { }

	// RVA: 0x2D24FC0 Offset: 0x2D250C1 VA: 0x2D24FC0
	internal static bool IsBidiControlCharacter(char ch) { }

	// RVA: 0x2D24AF0 Offset: 0x2D24BF1 VA: 0x2D24AF0
	internal static string StripBidiControlCharacter(char* strToClean, int start, int length) { }

	// RVA: 0x2D19ED0 Offset: 0x2D19FD1 VA: 0x2D19ED0
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x2D25010 Offset: 0x2D25111 VA: 0x2D25010
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0x2D256F0 Offset: 0x2D257F1 VA: 0x2D256F0
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x2D257A0 Offset: 0x2D258A1 VA: 0x2D257A0
	private bool CheckForUnicode(string data) { }

	// RVA: 0x2D258C0 Offset: 0x2D259C1 VA: 0x2D258C0
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x2D1EE70 Offset: 0x2D1EF71 VA: 0x2D1EE70
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0x2D22170 Offset: 0x2D22271 VA: 0x2D22170
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x2D25FB0 Offset: 0x2D260B1 VA: 0x2D25FB0
	public bool IsWellFormedOriginalString() { }

	// RVA: 0x2D26500 Offset: 0x2D26601 VA: 0x2D26500
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	// RVA: 0x2D26000 Offset: 0x2D26101 VA: 0x2D26000
	internal bool InternalIsWellFormedOriginalString() { }

	// RVA: 0x2D265E0 Offset: 0x2D266E1 VA: 0x2D265E0
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x2D23DF0 Offset: 0x2D23EF1 VA: 0x2D23DF0
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x2D267B0 Offset: 0x2D268B1 VA: 0x2D267B0
	private void .ctor(Uri.Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x2D25AD0 Offset: 0x2D25BD1 VA: 0x2D25AD0
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0x2D1A3B0 Offset: 0x2D1A4B1 VA: 0x2D1A3B0
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	// RVA: 0x2D25D80 Offset: 0x2D25E81 VA: 0x2D25D80
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x2D1E5C0 Offset: 0x2D1E6C1 VA: 0x2D1E5C0
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x2D1A980 Offset: 0x2D1AA81 VA: 0x2D1A980
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x2D26810 Offset: 0x2D26911 VA: 0x2D26810
	private static void .cctor() { }
}

