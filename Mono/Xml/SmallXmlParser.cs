// Namespace: Mono.Xml
internal class SmallXmlParser // TypeDefIndex: 26
{
	// Fields
	private SmallXmlParser.IContentHandler handler; // 0x10
	private TextReader reader; // 0x18
	private Stack elementNames; // 0x20
	private Stack xmlSpaces; // 0x28
	private string xmlSpace; // 0x30
	private StringBuilder buffer; // 0x38
	private char[] nameBuffer; // 0x40
	private bool isWhitespace; // 0x48
	private SmallXmlParser.AttrListImpl attributes; // 0x50
	private int line; // 0x58
	private int column; // 0x5C
	private bool resetColumn; // 0x60

	// Methods

	// RVA: 0x38264D0 Offset: 0x38265D1 VA: 0x38264D0
	public void .ctor() { }

	// RVA: 0x3826740 Offset: 0x3826841 VA: 0x3826740
	private Exception Error(string msg) { }

	// RVA: 0x38268C0 Offset: 0x38269C1 VA: 0x38268C0
	private Exception UnexpectedEndError() { }

	// RVA: 0x3826AF0 Offset: 0x3826BF1 VA: 0x3826AF0
	private bool IsNameChar(char c, bool start) { }

	// RVA: 0x3826C00 Offset: 0x3826D01 VA: 0x3826C00
	private bool IsWhitespace(int c) { }

	// RVA: 0x3826C30 Offset: 0x3826D31 VA: 0x3826C30
	public void SkipWhitespaces() { }

	// RVA: 0x3826DC0 Offset: 0x3826EC1 VA: 0x3826DC0
	private void HandleWhitespaces() { }

	// RVA: 0x3826CD0 Offset: 0x3826DD1 VA: 0x3826CD0
	public void SkipWhitespaces(bool expected) { }

	// RVA: 0x3826F30 Offset: 0x3827031 VA: 0x3826F30
	private int Peek() { }

	// RVA: 0x3826EB0 Offset: 0x3826FB1 VA: 0x3826EB0
	private int Read() { }

	// RVA: 0x3826F40 Offset: 0x3827041 VA: 0x3826F40
	public void Expect(int c) { }

	// RVA: 0x38270C0 Offset: 0x38271C1 VA: 0x38270C0
	private string ReadUntil(char until, bool handleReferences) { }

	// RVA: 0x3827550 Offset: 0x3827651 VA: 0x3827550
	public string ReadName() { }

	// RVA: 0x38278B0 Offset: 0x38279B1 VA: 0x38278B0
	public void Parse(TextReader input, SmallXmlParser.IContentHandler handler) { }

	// RVA: 0x3828600 Offset: 0x3828701 VA: 0x3828600
	private void Cleanup() { }

	// RVA: 0x3827B10 Offset: 0x3827C11 VA: 0x3827B10
	public void ReadContent() { }

	// RVA: 0x38284C0 Offset: 0x38285C1 VA: 0x38284C0
	private void HandleBufferedContent() { }

	// RVA: 0x3828E10 Offset: 0x3828F11 VA: 0x3828E10
	private void ReadCharacters() { }

	// RVA: 0x3827290 Offset: 0x3827391 VA: 0x3827290
	private void ReadReference() { }

	// RVA: 0x3828F20 Offset: 0x3829021 VA: 0x3828F20
	private int ReadCharacterReference() { }

	// RVA: 0x3828B50 Offset: 0x3828C51 VA: 0x3828B50
	private void ReadAttribute(SmallXmlParser.AttrListImpl a) { }

	// RVA: 0x3828700 Offset: 0x3828801 VA: 0x3828700
	private void ReadCDATASection() { }

	// RVA: 0x3828870 Offset: 0x3828971 VA: 0x3828870
	private void ReadComment() { }
}

