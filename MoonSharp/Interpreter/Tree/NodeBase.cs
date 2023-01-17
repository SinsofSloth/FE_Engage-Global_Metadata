// Namespace: MoonSharp.Interpreter.Tree
internal abstract class NodeBase // TypeDefIndex: 5997
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE540 Offset: 0xE641 VA: 0xE540
	private Script <Script>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xE550 Offset: 0xE651 VA: 0xE550
	private ScriptLoadingContext <LoadingContext>k__BackingField; // 0x18

	// Properties
	public Script Script { get; set; }
	protected ScriptLoadingContext LoadingContext { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xFF80 Offset: 0x10081 VA: 0xFF80
	// RVA: 0x2BC0130 Offset: 0x2BC0231 VA: 0x2BC0130
	public Script get_Script() { }

	[CompilerGeneratedAttribute] // RVA: 0xFF90 Offset: 0x10091 VA: 0xFF90
	// RVA: 0x2BC0140 Offset: 0x2BC0241 VA: 0x2BC0140
	private void set_Script(Script value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFFA0 Offset: 0x100A1 VA: 0xFFA0
	// RVA: 0x2BC0150 Offset: 0x2BC0251 VA: 0x2BC0150
	protected ScriptLoadingContext get_LoadingContext() { }

	[CompilerGeneratedAttribute] // RVA: 0xFFB0 Offset: 0x100B1 VA: 0xFFB0
	// RVA: 0x2BC0160 Offset: 0x2BC0261 VA: 0x2BC0160
	private void set_LoadingContext(ScriptLoadingContext value) { }

	// RVA: 0x2BC0170 Offset: 0x2BC0271 VA: 0x2BC0170
	public void .ctor(ScriptLoadingContext lcontext) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Compile(ByteCode bc);

	// RVA: 0x2BC01B0 Offset: 0x2BC02B1 VA: 0x2BC01B0
	protected static Token UnexpectedTokenType(Token t) { }

	// RVA: 0x2BC02A0 Offset: 0x2BC03A1 VA: 0x2BC02A0
	protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType) { }

	// RVA: 0x2BC0300 Offset: 0x2BC0401 VA: 0x2BC0300
	protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType1, TokenType tokenType2) { }

	// RVA: 0x2BC0370 Offset: 0x2BC0471 VA: 0x2BC0370
	protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType1, TokenType tokenType2, TokenType tokenType3) { }

	// RVA: 0x2BC03F0 Offset: 0x2BC04F1 VA: 0x2BC03F0
	protected static void CheckTokenTypeNotNext(ScriptLoadingContext lcontext, TokenType tokenType) { }

	// RVA: 0x2BC0430 Offset: 0x2BC0531 VA: 0x2BC0430
	protected static Token CheckMatch(ScriptLoadingContext lcontext, Token originalToken, TokenType expectedTokenType, string expectedTokenText) { }
}

