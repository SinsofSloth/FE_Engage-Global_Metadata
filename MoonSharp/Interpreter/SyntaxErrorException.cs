// Namespace: MoonSharp.Interpreter
[Serializable]
public class SyntaxErrorException : InterpreterException // TypeDefIndex: 5960
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE350 Offset: 0xE451 VA: 0xE350
	private Token <Token>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0xE360 Offset: 0xE461 VA: 0xE360
	private bool <IsPrematureStreamTermination>k__BackingField; // 0xB0

	// Properties
	internal Token Token { get; set; }
	public int ToLine { get; }
	public int FromLine { get; }
	public bool IsPrematureStreamTermination { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xFB10 Offset: 0xFC11 VA: 0xFB10
	// RVA: 0x3029D50 Offset: 0x3029E51 VA: 0x3029D50
	internal Token get_Token() { }

	[CompilerGeneratedAttribute] // RVA: 0xFB20 Offset: 0xFC21 VA: 0xFB20
	// RVA: 0x3029D60 Offset: 0x3029E61 VA: 0x3029D60
	private void set_Token(Token value) { }

	// RVA: 0x3029D70 Offset: 0x3029E71 VA: 0x3029D70
	public int get_ToLine() { }

	// RVA: 0x3029D80 Offset: 0x3029E81 VA: 0x3029D80
	public int get_FromLine() { }

	[CompilerGeneratedAttribute] // RVA: 0xFB30 Offset: 0xFC31 VA: 0xFB30
	// RVA: 0x3029D90 Offset: 0x3029E91 VA: 0x3029D90
	public bool get_IsPrematureStreamTermination() { }

	[CompilerGeneratedAttribute] // RVA: 0xFB40 Offset: 0xFC41 VA: 0xFB40
	// RVA: 0x3029DA0 Offset: 0x3029EA1 VA: 0x3029DA0
	public void set_IsPrematureStreamTermination(bool value) { }

	// RVA: 0x3029DB0 Offset: 0x3029EB1 VA: 0x3029DB0
	internal void .ctor(Token t, string format, object[] args) { }

	// RVA: 0x3029BD0 Offset: 0x3029CD1 VA: 0x3029BD0
	internal void .ctor(Token t, string message) { }

	// RVA: 0x3029DF0 Offset: 0x3029EF1 VA: 0x3029DF0
	internal void .ctor(Script script, SourceRef sref, string format, object[] args) { }

	// RVA: 0x3029E40 Offset: 0x3029F41 VA: 0x3029E40
	internal void .ctor(Script script, SourceRef sref, string message) { }

	// RVA: 0x3029E90 Offset: 0x3029F91 VA: 0x3029E90
	private void .ctor(SyntaxErrorException syntaxErrorException) { }

	// RVA: 0x3029EF0 Offset: 0x3029FF1 VA: 0x3029EF0
	internal void DecorateMessage(Script script) { }

	// RVA: 0x3029F50 Offset: 0x302A051 VA: 0x3029F50 Slot: 18
	public override void Rethrow() { }
}

