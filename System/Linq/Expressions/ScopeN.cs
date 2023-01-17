// Namespace: System.Linq.Expressions
internal class ScopeN : ScopeExpression // TypeDefIndex: 2798
{
	// Fields
	private IReadOnlyList<Expression> _body; // 0x18

	// Properties
	protected IReadOnlyList<Expression> Body { get; }
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x332E2F0 Offset: 0x332E3F1 VA: 0x332E2F0
	internal void .ctor(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body) { }

	// RVA: 0x332E340 Offset: 0x332E441 VA: 0x332E340
	protected IReadOnlyList<Expression> get_Body() { }

	// RVA: 0x332E350 Offset: 0x332E451 VA: 0x332E350 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x332E400 Offset: 0x332E501 VA: 0x332E400 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x332E4B0 Offset: 0x332E5B1 VA: 0x332E4B0 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x332E510 Offset: 0x332E611 VA: 0x332E510 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

