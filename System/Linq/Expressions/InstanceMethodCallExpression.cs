// Namespace: System.Linq.Expressions
internal class InstanceMethodCallExpression : MethodCallExpression, IArgumentProvider // TypeDefIndex: 2848
{
	// Fields
	private readonly Expression _instance; // 0x18

	// Methods

	// RVA: 0x31B6570 Offset: 0x31B6671 VA: 0x31B6570
	public void .ctor(MethodInfo method, Expression instance) { }

	// RVA: 0x31B65B0 Offset: 0x31B66B1 VA: 0x31B65B0 Slot: 12
	internal override Expression GetInstance() { }
}

// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression1 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 2858
{
	// Fields
	private object _arg0; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x31B66F0 Offset: 0x31B67F1 VA: 0x31B66F0
	public void .ctor(MethodInfo method, Expression instance, Expression arg0) { }

	// RVA: 0x31B6740 Offset: 0x31B6841 VA: 0x31B6740 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x31B67F0 Offset: 0x31B68F1 VA: 0x31B67F0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x31B6800 Offset: 0x31B6901 VA: 0x31B6800 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression3 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 2860
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x31B6C40 Offset: 0x31B6D41 VA: 0x31B6C40
	public void .ctor(MethodInfo method, Expression instance, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x31B6CC0 Offset: 0x31B6DC1 VA: 0x31B6CC0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x31B6DA0 Offset: 0x31B6EA1 VA: 0x31B6DA0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x31B6DB0 Offset: 0x31B6EB1 VA: 0x31B6DB0 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

