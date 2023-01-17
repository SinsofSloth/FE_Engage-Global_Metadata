// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x3FCF0 Offset: 0x3FDF1 VA: 0x3FCF0
public class InvocationExpression : Expression, IArgumentProvider // TypeDefIndex: 2823
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x40950 Offset: 0x40A51 VA: 0x40950
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x40960 Offset: 0x40A61 VA: 0x40960
	private readonly Expression <Expression>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Expression { get; }
	[ExcludeFromCodeCoverageAttribute] // RVA: 0x42550 Offset: 0x42651 VA: 0x42550
	public virtual int ArgumentCount { get; }

	// Methods

	// RVA: 0x31BECB0 Offset: 0x31BEDB1 VA: 0x31BECB0
	internal void .ctor(Expression expression, Type returnType) { }

	[CompilerGeneratedAttribute] // RVA: 0x41D10 Offset: 0x41E11 VA: 0x41D10
	// RVA: 0x31BED50 Offset: 0x31BEE51 VA: 0x31BED50 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x31BED60 Offset: 0x31BEE61 VA: 0x31BED60 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0x41D20 Offset: 0x41E21 VA: 0x41D20
	// RVA: 0x31BED70 Offset: 0x31BEE71 VA: 0x31BED70
	public Expression get_Expression() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41D30 Offset: 0x41E31 VA: 0x41D30
	// RVA: 0x31BED80 Offset: 0x31BEE81 VA: 0x31BED80 Slot: 12
	public virtual Expression GetArgument(int index) { }

	// RVA: 0x31BEDB0 Offset: 0x31BEEB1 VA: 0x31BEDB0 Slot: 13
	public virtual int get_ArgumentCount() { }

	// RVA: 0x31BEDE0 Offset: 0x31BEEE1 VA: 0x31BEDE0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41D40 Offset: 0x41E41 VA: 0x41D40
	// RVA: 0x31BEE00 Offset: 0x31BEF01 VA: 0x31BEE00 Slot: 14
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

