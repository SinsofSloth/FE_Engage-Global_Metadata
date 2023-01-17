// Namespace: System.Linq.Expressions
internal class BlockN : BlockExpression // TypeDefIndex: 2795
{
	// Fields
	private IReadOnlyList<Expression> _expressions; // 0x10

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x2E51F70 Offset: 0x2E52071 VA: 0x2E51F70
	internal void .ctor(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x2E51FF0 Offset: 0x2E520F1 VA: 0x2E51FF0 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x2E520A0 Offset: 0x2E521A1 VA: 0x2E520A0 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x2E52150 Offset: 0x2E52251 VA: 0x2E52150 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x2E521B0 Offset: 0x2E522B1 VA: 0x2E521B0 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

