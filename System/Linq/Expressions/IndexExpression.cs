// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x3FC80 Offset: 0x3FD81 VA: 0x3FC80
public sealed class IndexExpression : Expression, IArgumentProvider // TypeDefIndex: 2822
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x40930 Offset: 0x40A31 VA: 0x40930
	private readonly Expression <Object>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x40940 Offset: 0x40A41 VA: 0x40940
	private readonly PropertyInfo <Indexer>k__BackingField; // 0x20

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }
	public Expression Object { get; }
	public PropertyInfo Indexer { get; }
	public int ArgumentCount { get; }

	// Methods

	// RVA: 0x31B5D70 Offset: 0x31B5E71 VA: 0x31B5D70
	internal void .ctor(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments) { }

	// RVA: 0x31B5E30 Offset: 0x31B5F31 VA: 0x31B5E30 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x31B5E40 Offset: 0x31B5F41 VA: 0x31B5E40 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x41CF0 Offset: 0x41DF1 VA: 0x41CF0
	// RVA: 0x31B5EB0 Offset: 0x31B5FB1 VA: 0x31B5EB0
	public Expression get_Object() { }

	[CompilerGeneratedAttribute] // RVA: 0x41D00 Offset: 0x41E01 VA: 0x41D00
	// RVA: 0x31B5EC0 Offset: 0x31B5FC1 VA: 0x31B5EC0
	public PropertyInfo get_Indexer() { }

	// RVA: 0x31B0FC0 Offset: 0x31B10C1 VA: 0x31B0FC0 Slot: 10
	public Expression GetArgument(int index) { }

	// RVA: 0x31B0F10 Offset: 0x31B1011 VA: 0x31B0F10 Slot: 11
	public int get_ArgumentCount() { }

	// RVA: 0x31B5ED0 Offset: 0x31B5FD1 VA: 0x31B5ED0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x31B2FD0 Offset: 0x31B30D1 VA: 0x31B2FD0
	internal Expression Rewrite(Expression instance, Expression[] arguments) { }
}

