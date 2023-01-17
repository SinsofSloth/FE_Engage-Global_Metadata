// Namespace: System.Linq.Expressions
internal sealed class Scope1 : ScopeExpression // TypeDefIndex: 2797
{
	// Fields
	private object _body; // 0x18

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x332DEA0 Offset: 0x332DFA1 VA: 0x332DEA0
	internal void .ctor(IReadOnlyList<ParameterExpression> variables, Expression body) { }

	// RVA: 0x332DEF0 Offset: 0x332DFF1 VA: 0x332DEF0
	private void .ctor(IReadOnlyList<ParameterExpression> variables, object body) { }

	// RVA: 0x332DF80 Offset: 0x332E081 VA: 0x332DF80 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x332E010 Offset: 0x332E111 VA: 0x332E010 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x332E020 Offset: 0x332E121 VA: 0x332E020 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x332E030 Offset: 0x332E131 VA: 0x332E030 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

