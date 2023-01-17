// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x3FA50 Offset: 0x3FB51 VA: 0x3FA50
public class ConditionalExpression : Expression // TypeDefIndex: 2806
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x40860 Offset: 0x40961 VA: 0x40860
	private readonly Expression <Test>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x40870 Offset: 0x40971 VA: 0x40870
	private readonly Expression <IfTrue>k__BackingField; // 0x18

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public override Type Type { get; }
	public Expression Test { get; }
	public Expression IfTrue { get; }
	public Expression IfFalse { get; }

	// Methods

	// RVA: 0x2E55840 Offset: 0x2E55941 VA: 0x2E55840
	internal void .ctor(Expression test, Expression ifTrue) { }

	// RVA: 0x2E558E0 Offset: 0x2E559E1 VA: 0x2E558E0
	internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x2E55B50 Offset: 0x2E55C51 VA: 0x2E55B50 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x2E55B60 Offset: 0x2E55C61 VA: 0x2E55B60 Slot: 5
	public override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x41C20 Offset: 0x41D21 VA: 0x41C20
	// RVA: 0x2E55B70 Offset: 0x2E55C71 VA: 0x2E55B70
	public Expression get_Test() { }

	[CompilerGeneratedAttribute] // RVA: 0x41C30 Offset: 0x41D31 VA: 0x41C30
	// RVA: 0x2E55B80 Offset: 0x2E55C81 VA: 0x2E55B80
	public Expression get_IfTrue() { }

	// RVA: 0x2E55B90 Offset: 0x2E55C91 VA: 0x2E55B90
	public Expression get_IfFalse() { }

	// RVA: 0x2E55BA0 Offset: 0x2E55CA1 VA: 0x2E55BA0 Slot: 10
	internal virtual Expression GetFalse() { }

	// RVA: 0x2E55C10 Offset: 0x2E55D11 VA: 0x2E55C10 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x2E55C30 Offset: 0x2E55D31 VA: 0x2E55C30
	public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse) { }
}

