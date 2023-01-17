// Namespace: MoonSharp.Interpreter.Tree
internal class Lexer // TypeDefIndex: 5991
{
	// Fields
	private Token m_Current; // 0x10
	private string m_Code; // 0x18
	private int m_PrevLineTo; // 0x20
	private int m_PrevColTo; // 0x24
	private int m_Cursor; // 0x28
	private int m_Line; // 0x2C
	private int m_Col; // 0x30
	private int m_SourceId; // 0x34
	private bool m_AutoSkipComments; // 0x38

	// Properties
	public Token Current { get; }

	// Methods

	// RVA: 0x331C810 Offset: 0x331C911 VA: 0x331C810
	public void .ctor(int sourceID, string scriptContent, bool autoSkipComments) { }

	// RVA: 0x330BEC0 Offset: 0x330BFC1 VA: 0x330BEC0
	public Token get_Current() { }

	// RVA: 0x331D780 Offset: 0x331D881 VA: 0x331D780
	private Token FetchNewToken() { }

	// RVA: 0x330BE60 Offset: 0x330BF61 VA: 0x330BE60
	public void Next() { }

	// RVA: 0x331E420 Offset: 0x331E521 VA: 0x331E420
	public Token PeekNext() { }

	// RVA: 0x331E4F0 Offset: 0x331E5F1 VA: 0x331E4F0
	private void CursorNext() { }

	// RVA: 0x331E580 Offset: 0x331E681 VA: 0x331E580
	private char CursorChar() { }

	// RVA: 0x331E5B0 Offset: 0x331E6B1 VA: 0x331E5B0
	private char CursorCharNext() { }

	// RVA: 0x331E640 Offset: 0x331E741 VA: 0x331E640
	private bool CursorMatches(string pattern) { }

	// RVA: 0x331E560 Offset: 0x331E661 VA: 0x331E560
	private bool CursorNotEof() { }

	// RVA: 0x331E6E0 Offset: 0x331E7E1 VA: 0x331E6E0
	private bool IsWhiteSpace(char c) { }

	// RVA: 0x331E750 Offset: 0x331E851 VA: 0x331E750
	private void SkipWhiteSpace() { }

	// RVA: 0x331D7C0 Offset: 0x331D8C1 VA: 0x331D7C0
	private Token ReadToken() { }

	// RVA: 0x331FBD0 Offset: 0x331FCD1 VA: 0x331FBD0
	private string ReadLongString(int fromLine, int fromCol, string startpattern, string subtypeforerrors) { }

	// RVA: 0x331EC40 Offset: 0x331ED41 VA: 0x331EC40
	private Token ReadNumberToken(int fromLine, int fromCol, bool leadingDot) { }

	// RVA: 0x331F240 Offset: 0x331F341 VA: 0x331F240
	private Token CreateSingleCharToken(TokenType tokenType, int fromLine, int fromCol) { }

	// RVA: 0x331F890 Offset: 0x331F991 VA: 0x331F890
	private Token ReadHashBang(int fromLine, int fromCol) { }

	// RVA: 0x331F3D0 Offset: 0x331F4D1 VA: 0x331F3D0
	private Token ReadComment(int fromLine, int fromCol) { }

	// RVA: 0x3320290 Offset: 0x3320391 VA: 0x3320290
	private Token ReadSimpleStringToken(int fromLine, int fromCol) { }

	// RVA: 0x331E930 Offset: 0x331EA31 VA: 0x331E930
	private Token PotentiallyDoubleCharOperator(char expectedSecondChar, TokenType singleCharToken, TokenType doubleCharToken, int fromLine, int fromCol) { }

	// RVA: 0x3320B10 Offset: 0x3320C11 VA: 0x3320B10
	private Token CreateNameToken(string name, int fromLine, int fromCol) { }

	// RVA: 0x331E850 Offset: 0x331E951 VA: 0x331E850
	private Token CreateToken(TokenType tokenType, int fromLine, int fromCol, string text) { }

	// RVA: 0x3320970 Offset: 0x3320A71 VA: 0x3320970
	private string ReadNameToken() { }
}

