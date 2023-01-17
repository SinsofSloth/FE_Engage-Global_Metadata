// Namespace: System.Security.Util
internal sealed class Tokenizer // TypeDefIndex: 887
{
	// Fields
	public int LineNo; // 0x10
	private int _inProcessingTag; // 0x14
	private byte[] _inBytes; // 0x18
	private char[] _inChars; // 0x20
	private string _inString; // 0x28
	private int _inIndex; // 0x30
	private int _inSize; // 0x34
	private int _inSavedCharacter; // 0x38
	private Tokenizer.TokenSource _inTokenSource; // 0x3C
	private Tokenizer.ITokenReader _inTokenReader; // 0x40
	private Tokenizer.StringMaker _maker; // 0x48
	private string[] _searchStrings; // 0x50
	private string[] _replaceStrings; // 0x58
	private int _inNestedIndex; // 0x60
	private int _inNestedSize; // 0x64
	private string _inNestedString; // 0x68

	// Methods

	// RVA: 0x1B24970 Offset: 0x1B24A71 VA: 0x1B24970
	internal void BasicInitialization() { }

	// RVA: 0x1B24A00 Offset: 0x1B24B01 VA: 0x1B24A00
	public void Recycle() { }

	// RVA: 0x1B24A70 Offset: 0x1B24B71 VA: 0x1B24A70
	internal void .ctor(string input) { }

	// RVA: 0x1B24B30 Offset: 0x1B24C31 VA: 0x1B24B30
	internal void ChangeFormat(Encoding encoding) { }

	// RVA: 0x1B24D50 Offset: 0x1B24E51 VA: 0x1B24D50
	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	// RVA: 0x1B25660 Offset: 0x1B25761 VA: 0x1B25660
	private string GetStringToken() { }
}

