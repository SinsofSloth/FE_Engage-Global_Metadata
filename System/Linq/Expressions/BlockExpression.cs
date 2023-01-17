// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x3F910 Offset: 0x3FA11 VA: 0x3F910
public class BlockExpression : Expression // TypeDefIndex: 2790
{
	// Properties
	public ReadOnlyCollection<Expression> Expressions { get; }
	public ReadOnlyCollection<ParameterExpression> Variables { get; }
	public sealed override ExpressionType NodeType { get; }
	public override Type Type { get; }
	[ExcludeFromCodeCoverageAttribute] // RVA: 0x42500 Offset: 0x42601 VA: 0x42500
	internal virtual int ExpressionCount { get; }

	// Methods

	// RVA: 0x2E51750 Offset: 0x2E51851 VA: 0x2E51750
	public ReadOnlyCollection<Expression> get_Expressions() { }

	// RVA: 0x2E51760 Offset: 0x2E51861 VA: 0x2E51760
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }

	// RVA: 0x2E50B50 Offset: 0x2E50C51 VA: 0x2E50B50
	internal void .ctor() { }

	// RVA: 0x2E51770 Offset: 0x2E51871 VA: 0x2E51770 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x2E51790 Offset: 0x2E51891 VA: 0x2E51790 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x2E517A0 Offset: 0x2E518A1 VA: 0x2E517A0 Slot: 5
	public override Type get_Type() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41A70 Offset: 0x41B71 VA: 0x41A70
	// RVA: 0x2E517F0 Offset: 0x2E518F1 VA: 0x2E517F0 Slot: 10
	internal virtual Expression GetExpression(int index) { }

	// RVA: 0x2E51820 Offset: 0x2E51921 VA: 0x2E51820 Slot: 11
	internal virtual int get_ExpressionCount() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41A80 Offset: 0x41B81 VA: 0x41A80
	// RVA: 0x2E51850 Offset: 0x2E51951 VA: 0x2E51850 Slot: 12
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x2E51880 Offset: 0x2E51981 VA: 0x2E51880 Slot: 13
	internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41A90 Offset: 0x41B91 VA: 0x41A90
	// RVA: 0x2E518F0 Offset: 0x2E519F1 VA: 0x2E518F0 Slot: 14
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

	// RVA: 0x2E50D00 Offset: 0x2E50E01 VA: 0x2E50D00
	internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection) { }
}

