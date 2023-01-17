// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpressionN : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 2850
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x31B6FE0 Offset: 0x31B70E1 VA: 0x31B6FE0
	public void .ctor(MethodInfo method, Expression instance, IReadOnlyList<Expression> args) { }

	// RVA: 0x31B7030 Offset: 0x31B7131 VA: 0x31B7030 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x31B70E0 Offset: 0x31B71E1 VA: 0x31B70E0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x31B7190 Offset: 0x31B7291 VA: 0x31B7190 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

