// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression2 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 2859
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x31B6940 Offset: 0x31B6A41 VA: 0x31B6940
	public void .ctor(MethodInfo method, Expression instance, Expression arg0, Expression arg1) { }

	// RVA: 0x31B69B0 Offset: 0x31B6AB1 VA: 0x31B69B0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x31B6A70 Offset: 0x31B6B71 VA: 0x31B6A70 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x31B6A80 Offset: 0x31B6B81 VA: 0x31B6A80 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

