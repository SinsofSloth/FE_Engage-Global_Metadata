// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x3FEB0 Offset: 0x3FFB1 VA: 0x3FEB0
public sealed class LoopExpression : Expression // TypeDefIndex: 2837
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x409F0 Offset: 0x40AF1 VA: 0x409F0
	private readonly Expression <Body>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x40A00 Offset: 0x40B01 VA: 0x40A00
	private readonly LabelTarget <BreakLabel>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x40A10 Offset: 0x40B11 VA: 0x40A10
	private readonly LabelTarget <ContinueLabel>k__BackingField; // 0x20

	// Properties
	public Expression Body { get; }
	public LabelTarget BreakLabel { get; }
	public LabelTarget ContinueLabel { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x41E00 Offset: 0x41F01 VA: 0x41E00
	// RVA: 0x3325CB0 Offset: 0x3325DB1 VA: 0x3325CB0
	public Expression get_Body() { }

	[CompilerGeneratedAttribute] // RVA: 0x41E10 Offset: 0x41F11 VA: 0x41E10
	// RVA: 0x3325CC0 Offset: 0x3325DC1 VA: 0x3325CC0
	public LabelTarget get_BreakLabel() { }

	[CompilerGeneratedAttribute] // RVA: 0x41E20 Offset: 0x41F21 VA: 0x41E20
	// RVA: 0x3325CD0 Offset: 0x3325DD1 VA: 0x3325CD0
	public LabelTarget get_ContinueLabel() { }
}

