// Namespace: System.Linq.Expressions
internal sealed class Block4 : BlockExpression // TypeDefIndex: 2793
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20
	private readonly Expression _arg3; // 0x28

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x2E51200 Offset: 0x2E51301 VA: 0x2E51200
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x2E512D0 Offset: 0x2E513D1 VA: 0x2E512D0 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x2E513C0 Offset: 0x2E514C1 VA: 0x2E513C0 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x2E513D0 Offset: 0x2E514D1 VA: 0x2E513D0 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x2E513E0 Offset: 0x2E514E1 VA: 0x2E513E0 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

