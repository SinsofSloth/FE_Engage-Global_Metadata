// Namespace: System.Net
internal class CookieTokenizer // TypeDefIndex: 2510
{
	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x1B52C60 Offset: 0x1B52D61 VA: 0x1B52C60
	internal void .ctor(string tokenStream) { }

	// RVA: 0x1B52F80 Offset: 0x1B53081 VA: 0x1B52F80
	internal bool get_EndOfCookie() { }

	// RVA: 0x1B52F90 Offset: 0x1B53091 VA: 0x1B52F90
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x1B52F70 Offset: 0x1B53071 VA: 0x1B52F70
	internal bool get_Eof() { }

	// RVA: 0x1B52FA0 Offset: 0x1B530A1 VA: 0x1B52FA0
	internal string get_Name() { }

	// RVA: 0x1B52FB0 Offset: 0x1B530B1 VA: 0x1B52FB0
	internal void set_Name(string value) { }

	// RVA: 0x1B52FC0 Offset: 0x1B530C1 VA: 0x1B52FC0
	internal bool get_Quoted() { }

	// RVA: 0x1B52FD0 Offset: 0x1B530D1 VA: 0x1B52FD0
	internal void set_Quoted(bool value) { }

	// RVA: 0x1B52FE0 Offset: 0x1B530E1 VA: 0x1B52FE0
	internal CookieToken get_Token() { }

	// RVA: 0x1B52FF0 Offset: 0x1B530F1 VA: 0x1B52FF0
	internal void set_Token(CookieToken value) { }

	// RVA: 0x1B53000 Offset: 0x1B53101 VA: 0x1B53000
	internal string get_Value() { }

	// RVA: 0x1B53010 Offset: 0x1B53111 VA: 0x1B53010
	internal void set_Value(string value) { }

	// RVA: 0x1B53020 Offset: 0x1B53121 VA: 0x1B53020
	internal string Extract() { }

	// RVA: 0x1B530B0 Offset: 0x1B531B1 VA: 0x1B530B0
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1B52CA0 Offset: 0x1B52DA1 VA: 0x1B52CA0
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x1B533F0 Offset: 0x1B534F1 VA: 0x1B533F0
	internal void Reset() { }

	// RVA: 0x1B53480 Offset: 0x1B53581 VA: 0x1B53480
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1B53680 Offset: 0x1B53781 VA: 0x1B53680
	private static void .cctor() { }
}

