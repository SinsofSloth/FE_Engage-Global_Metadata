// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpressionN : MethodCallExpression, IArgumentProvider // TypeDefIndex: 2849
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x18

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x33277E0 Offset: 0x33278E1 VA: 0x33277E0
	public void .ctor(MethodInfo method, IReadOnlyList<Expression> args) { }

	// RVA: 0x3327880 Offset: 0x3327981 VA: 0x3327880 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x3327930 Offset: 0x3327A31 VA: 0x3327930 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x33279E0 Offset: 0x3327AE1 VA: 0x33279E0 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

