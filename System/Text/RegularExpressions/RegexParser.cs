// Namespace: System.Text.RegularExpressions
internal sealed class RegexParser // TypeDefIndex: 2271
{
	// Fields
	internal RegexNode _stack; // 0x10
	internal RegexNode _group; // 0x18
	internal RegexNode _alternation; // 0x20
	internal RegexNode _concatenation; // 0x28
	internal RegexNode _unit; // 0x30
	internal string _pattern; // 0x38
	internal int _currentPos; // 0x40
	internal CultureInfo _culture; // 0x48
	internal int _autocap; // 0x50
	internal int _capcount; // 0x54
	internal int _captop; // 0x58
	internal int _capsize; // 0x5C
	internal Hashtable _caps; // 0x60
	internal Hashtable _capnames; // 0x68
	internal int[] _capnumlist; // 0x70
	internal List<string> _capnamelist; // 0x78
	internal RegexOptions _options; // 0x80
	internal List<RegexOptions> _optionsStack; // 0x88
	internal bool _ignoreNextParen; // 0x90
	internal static readonly byte[] _category; // 0x0

	// Methods

	// RVA: 0x3BFF150 Offset: 0x3BFF251 VA: 0x3BFF150
	internal static RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x3C013E0 Offset: 0x3C014E1 VA: 0x3C013E0
	internal static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x3BFFF30 Offset: 0x3C00031 VA: 0x3BFFF30
	internal static string Escape(string input) { }

	// RVA: 0x3C113E0 Offset: 0x3C114E1 VA: 0x3C113E0
	private void .ctor(CultureInfo culture) { }

	// RVA: 0x3C114C0 Offset: 0x3C115C1 VA: 0x3C114C0
	internal void SetPattern(string Re) { }

	// RVA: 0x3C119B0 Offset: 0x3C11AB1 VA: 0x3C119B0
	internal void Reset(RegexOptions topopts) { }

	// RVA: 0x3C11A50 Offset: 0x3C11B51 VA: 0x3C11A50
	internal RegexNode ScanRegex() { }

	// RVA: 0x3C12750 Offset: 0x3C12851 VA: 0x3C12750
	internal RegexNode ScanReplacement() { }

	// RVA: 0x3C13580 Offset: 0x3C13681 VA: 0x3C13580
	internal RegexCharClass ScanCharClass(bool caseInsensitive) { }

	// RVA: 0x3C15870 Offset: 0x3C15971 VA: 0x3C15870
	internal RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x3C13680 Offset: 0x3C13781 VA: 0x3C13680
	internal RegexNode ScanGroupOpen() { }

	// RVA: 0x3C12A70 Offset: 0x3C12B71 VA: 0x3C12A70
	internal void ScanBlank() { }

	// RVA: 0x3C149E0 Offset: 0x3C14AE1 VA: 0x3C149E0
	internal RegexNode ScanBackslash() { }

	// RVA: 0x3C168D0 Offset: 0x3C169D1 VA: 0x3C168D0
	internal RegexNode ScanBasicBackslash() { }

	// RVA: 0x3C152A0 Offset: 0x3C153A1 VA: 0x3C152A0
	internal RegexNode ScanDollar() { }

	// RVA: 0x3C16390 Offset: 0x3C16491 VA: 0x3C16390
	internal string ScanCapname() { }

	// RVA: 0x3C17090 Offset: 0x3C17191 VA: 0x3C17090
	internal char ScanOctal() { }

	// RVA: 0x3C15160 Offset: 0x3C15261 VA: 0x3C15160
	internal int ScanDecimal() { }

	// RVA: 0x3C17160 Offset: 0x3C17261 VA: 0x3C17160
	internal char ScanHex(int c) { }

	// RVA: 0x3C172D0 Offset: 0x3C173D1 VA: 0x3C172D0
	internal static int HexDigit(char ch) { }

	// RVA: 0x3C17310 Offset: 0x3C17411 VA: 0x3C17310
	internal char ScanControl() { }

	// RVA: 0x3C173C0 Offset: 0x3C174C1 VA: 0x3C173C0
	internal bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x3C16600 Offset: 0x3C16701 VA: 0x3C16600
	internal void ScanOptions() { }

	// RVA: 0x3C16130 Offset: 0x3C16231 VA: 0x3C16130
	internal char ScanCharEscape() { }

	// RVA: 0x3C15FB0 Offset: 0x3C160B1 VA: 0x3C15FB0
	internal string ParseProperty() { }

	// RVA: 0x3C16830 Offset: 0x3C16931 VA: 0x3C16830
	internal int TypeFromCode(char ch) { }

	// RVA: 0x3C173F0 Offset: 0x3C174F1 VA: 0x3C173F0
	internal static RegexOptions OptionFromCode(char ch) { }

	// RVA: 0x3C11540 Offset: 0x3C11641 VA: 0x3C11540
	internal void CountCaptures() { }

	// RVA: 0x3C17450 Offset: 0x3C17551 VA: 0x3C17450
	internal void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x3C175A0 Offset: 0x3C176A1 VA: 0x3C175A0
	internal void NoteCaptureName(string name, int pos) { }

	// RVA: 0x3C12700 Offset: 0x3C12801 VA: 0x3C12700
	internal void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x3C17700 Offset: 0x3C17801 VA: 0x3C17700
	internal void AssignNameSlots() { }

	// RVA: 0x3C16560 Offset: 0x3C16661 VA: 0x3C16560
	internal int CaptureSlotFromName(string capname) { }

	// RVA: 0x3C164A0 Offset: 0x3C165A1 VA: 0x3C164A0
	internal bool IsCaptureSlot(int i) { }

	// RVA: 0x3C16540 Offset: 0x3C16641 VA: 0x3C16540
	internal bool IsCaptureName(string capname) { }

	// RVA: 0x3C16490 Offset: 0x3C16591 VA: 0x3C16490
	internal bool UseOptionN() { }

	// RVA: 0x3C13570 Offset: 0x3C13671 VA: 0x3C13570
	internal bool UseOptionI() { }

	// RVA: 0x3C14F70 Offset: 0x3C15071 VA: 0x3C14F70
	internal bool UseOptionM() { }

	// RVA: 0x3C15000 Offset: 0x3C15101 VA: 0x3C15000
	internal bool UseOptionS() { }

	// RVA: 0x3C12E10 Offset: 0x3C12F11 VA: 0x3C12E10
	internal bool UseOptionX() { }

	// RVA: 0x3C15FA0 Offset: 0x3C160A1 VA: 0x3C15FA0
	internal bool UseOptionE() { }

	// RVA: 0x3C130E0 Offset: 0x3C131E1 VA: 0x3C130E0
	internal static bool IsSpecial(char ch) { }

	// RVA: 0x3C12E70 Offset: 0x3C12F71 VA: 0x3C12E70
	internal static bool IsStopperX(char ch) { }

	// RVA: 0x3C13190 Offset: 0x3C13291 VA: 0x3C13190
	internal static bool IsQuantifier(char ch) { }

	// RVA: 0x3C12F20 Offset: 0x3C13021 VA: 0x3C12F20
	internal bool IsTrueQuantifier() { }

	// RVA: 0x3C16780 Offset: 0x3C16881 VA: 0x3C16780
	internal static bool IsSpace(char ch) { }

	// RVA: 0x3C128F0 Offset: 0x3C129F1 VA: 0x3C128F0
	internal static bool IsMetachar(char ch) { }

	// RVA: 0x3C13240 Offset: 0x3C13341 VA: 0x3C13240
	internal void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x3C14350 Offset: 0x3C14451 VA: 0x3C14350
	internal void PushGroup() { }

	// RVA: 0x3C14810 Offset: 0x3C14911 VA: 0x3C14810
	internal void PopGroup() { }

	// RVA: 0x3C144D0 Offset: 0x3C145D1 VA: 0x3C144D0
	internal bool EmptyStack() { }

	// RVA: 0x3C129A0 Offset: 0x3C12AA1 VA: 0x3C129A0
	internal void StartGroup(RegexNode openGroup) { }

	// RVA: 0x3C143A0 Offset: 0x3C144A1 VA: 0x3C143A0
	internal void AddAlternate() { }

	// RVA: 0x3C15100 Offset: 0x3C15201 VA: 0x3C15100
	internal void AddConcatenate() { }

	// RVA: 0x3C15250 Offset: 0x3C15351 VA: 0x3C15250
	internal void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x3C17DB0 Offset: 0x3C17EB1 VA: 0x3C17DB0
	internal RegexNode Unit() { }

	// RVA: 0x3C13490 Offset: 0x3C13591 VA: 0x3C13490
	internal void AddUnitOne(char ch) { }

	// RVA: 0x3C15010 Offset: 0x3C15111 VA: 0x3C15010
	internal void AddUnitNotone(char ch) { }

	// RVA: 0x3C13590 Offset: 0x3C13691 VA: 0x3C13590
	internal void AddUnitSet(string cc) { }

	// RVA: 0x3C17DC0 Offset: 0x3C17EC1 VA: 0x3C17DC0
	internal void AddUnitNode(RegexNode node) { }

	// RVA: 0x3C14F80 Offset: 0x3C15081 VA: 0x3C14F80
	internal void AddUnitType(int type) { }

	// RVA: 0x3C14620 Offset: 0x3C14721 VA: 0x3C14620
	internal void AddGroup() { }

	// RVA: 0x3C13620 Offset: 0x3C13721 VA: 0x3C13620
	internal void PushOptions() { }

	// RVA: 0x3C14940 Offset: 0x3C14A41 VA: 0x3C14940
	internal void PopOptions() { }

	// RVA: 0x3C17550 Offset: 0x3C17651 VA: 0x3C17550
	internal bool EmptyOptionsStack() { }

	// RVA: 0x3C142E0 Offset: 0x3C143E1 VA: 0x3C142E0
	internal void PopKeepOptions() { }

	// RVA: 0x3C144E0 Offset: 0x3C145E1 VA: 0x3C144E0
	internal ArgumentException MakeException(string message) { }

	// RVA: 0x3C17DD0 Offset: 0x3C17ED1 VA: 0x3C17DD0
	internal int Textpos() { }

	// RVA: 0x3C17DE0 Offset: 0x3C17EE1 VA: 0x3C17DE0
	internal void Textto(int pos) { }

	// RVA: 0x3C15140 Offset: 0x3C15241 VA: 0x3C15140
	internal char MoveRightGetChar() { }

	// RVA: 0x3C12E20 Offset: 0x3C12F21 VA: 0x3C12E20
	internal void MoveRight() { }

	// RVA: 0x3C16480 Offset: 0x3C16581 VA: 0x3C16480
	internal void MoveRight(int i) { }

	// RVA: 0x3C150F0 Offset: 0x3C151F1 VA: 0x3C150F0
	internal void MoveLeft() { }

	// RVA: 0x3C13480 Offset: 0x3C13581 VA: 0x3C13480
	internal char CharAt(int i) { }

	// RVA: 0x3C12E50 Offset: 0x3C12F51 VA: 0x3C12E50
	internal char RightChar() { }

	// RVA: 0x3C16460 Offset: 0x3C16561 VA: 0x3C16460
	internal char RightChar(int i) { }

	// RVA: 0x3C12E30 Offset: 0x3C12F31 VA: 0x3C12E30
	internal int CharsRight() { }

	// RVA: 0x3C17DF0 Offset: 0x3C17EF1 VA: 0x3C17DF0
	private static void .cctor() { }
}

