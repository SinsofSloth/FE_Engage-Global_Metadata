// Namespace: MoonSharp.Interpreter.Tree
internal class Token // TypeDefIndex: 5993
{
	// Fields
	public readonly int SourceId; // 0x10
	public readonly int FromCol; // 0x14
	public readonly int ToCol; // 0x18
	public readonly int FromLine; // 0x1C
	public readonly int ToLine; // 0x20
	public readonly int PrevCol; // 0x24
	public readonly int PrevLine; // 0x28
	public readonly TokenType Type; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0xE530 Offset: 0xE631 VA: 0xE530
	private string <Text>k__BackingField; // 0x30

	// Properties
	public string Text { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xFF60 Offset: 0x10061 VA: 0xFF60
	// RVA: 0x3348F80 Offset: 0x3349081 VA: 0x3348F80
	public string get_Text() { }

	[CompilerGeneratedAttribute] // RVA: 0xFF70 Offset: 0x10071 VA: 0xFF70
	// RVA: 0x3348F90 Offset: 0x3349091 VA: 0x3348F90
	public void set_Text(string value) { }

	// RVA: 0x3348FA0 Offset: 0x33490A1 VA: 0x3348FA0
	public void .ctor(TokenType type, int sourceId, int fromLine, int fromCol, int toLine, int toCol, int prevLine, int prevCol) { }

	// RVA: 0x3349020 Offset: 0x3349121 VA: 0x3349020 Slot: 3
	public override string ToString() { }

	// RVA: 0x3349300 Offset: 0x3349401 VA: 0x3349300
	public static Nullable<TokenType> GetReservedTokenType(string reservedWord) { }

	// RVA: 0x3349AC0 Offset: 0x3349BC1 VA: 0x3349AC0
	public double GetNumberValue() { }

	// RVA: 0x3349B60 Offset: 0x3349C61 VA: 0x3349B60
	public bool IsEndOfBlock() { }

	// RVA: 0x3349BA0 Offset: 0x3349CA1 VA: 0x3349BA0
	public bool IsUnaryOperator() { }

	// RVA: 0x3349BD0 Offset: 0x3349CD1 VA: 0x3349BD0
	public bool IsBinaryOperator() { }

	// RVA: 0x3349C10 Offset: 0x3349D11 VA: 0x3349C10
	internal SourceRef GetSourceRef(bool isStepStop = True) { }

	// RVA: 0x3349CB0 Offset: 0x3349DB1 VA: 0x3349CB0
	internal SourceRef GetSourceRef(Token to, bool isStepStop = True) { }

	// RVA: 0x3349D60 Offset: 0x3349E61 VA: 0x3349D60
	internal SourceRef GetSourceRefUpTo(Token to, bool isStepStop = True) { }
}

