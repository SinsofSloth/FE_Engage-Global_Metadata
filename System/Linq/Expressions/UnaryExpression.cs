// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x40400 Offset: 0x40501 VA: 0x40400
public sealed class UnaryExpression : Expression // TypeDefIndex: 2878
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x40BE0 Offset: 0x40CE1 VA: 0x40BE0
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x40BF0 Offset: 0x40CF1 VA: 0x40BF0
	private readonly ExpressionType <NodeType>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x40C00 Offset: 0x40D01 VA: 0x40C00
	private readonly Expression <Operand>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x40C10 Offset: 0x40D11 VA: 0x40C10
	private readonly MethodInfo <Method>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Operand { get; }
	public MethodInfo Method { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	public override bool CanReduce { get; }
	private bool IsPrefix { get; }

	// Methods

	// RVA: 0x3337E20 Offset: 0x3337F21 VA: 0x3337E20
	internal void .ctor(ExpressionType nodeType, Expression expression, Type type, MethodInfo method) { }

	[CompilerGeneratedAttribute] // RVA: 0x42020 Offset: 0x42121 VA: 0x42020
	// RVA: 0x3337EE0 Offset: 0x3337FE1 VA: 0x3337EE0 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x42030 Offset: 0x42131 VA: 0x42030
	// RVA: 0x3337EF0 Offset: 0x3337FF1 VA: 0x3337EF0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0x42040 Offset: 0x42141 VA: 0x42040
	// RVA: 0x3337F00 Offset: 0x3338001 VA: 0x3337F00
	public Expression get_Operand() { }

	[CompilerGeneratedAttribute] // RVA: 0x42050 Offset: 0x42151 VA: 0x42050
	// RVA: 0x3337F10 Offset: 0x3338011 VA: 0x3337F10
	public MethodInfo get_Method() { }

	// RVA: 0x3337F20 Offset: 0x3338021 VA: 0x3337F20
	public bool get_IsLifted() { }

	// RVA: 0x33381A0 Offset: 0x33382A1 VA: 0x33381A0
	public bool get_IsLiftedToNull() { }

	// RVA: 0x33381F0 Offset: 0x33382F1 VA: 0x33381F0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x3338210 Offset: 0x3338311 VA: 0x3338210 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x3338240 Offset: 0x3338341 VA: 0x3338240 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x33391C0 Offset: 0x33392C1 VA: 0x33391C0
	private bool get_IsPrefix() { }

	// RVA: 0x3339220 Offset: 0x3339321 VA: 0x3339220
	private UnaryExpression FunctionalOp(Expression operand) { }

	// RVA: 0x3338EB0 Offset: 0x3338FB1 VA: 0x3338EB0
	private Expression ReduceVariable() { }

	// RVA: 0x3338950 Offset: 0x3338A51 VA: 0x3338950
	private Expression ReduceMember() { }

	// RVA: 0x33382C0 Offset: 0x33383C1 VA: 0x33382C0
	private Expression ReduceIndex() { }

	// RVA: 0x3339360 Offset: 0x3339461 VA: 0x3339360
	public UnaryExpression Update(Expression operand) { }
}

