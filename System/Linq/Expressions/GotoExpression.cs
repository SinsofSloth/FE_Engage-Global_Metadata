// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x3FC10 Offset: 0x3FD11 VA: 0x3FC10
public sealed class GotoExpression : Expression // TypeDefIndex: 2819
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x408F0 Offset: 0x409F1 VA: 0x408F0
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x40900 Offset: 0x40A01 VA: 0x40900
	private readonly Expression <Value>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x40910 Offset: 0x40A11 VA: 0x40910
	private readonly LabelTarget <Target>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x40920 Offset: 0x40A21 VA: 0x40920
	private readonly GotoExpressionKind <Kind>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Value { get; }
	public LabelTarget Target { get; }
	public GotoExpressionKind Kind { get; }

	// Methods

	// RVA: 0x31B3D70 Offset: 0x31B3E71 VA: 0x31B3D70
	internal void .ctor(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	[CompilerGeneratedAttribute] // RVA: 0x41CB0 Offset: 0x41DB1 VA: 0x41CB0
	// RVA: 0x31B3E30 Offset: 0x31B3F31 VA: 0x31B3E30 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x31B3E40 Offset: 0x31B3F41 VA: 0x31B3E40 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0x41CC0 Offset: 0x41DC1 VA: 0x41CC0
	// RVA: 0x31B3E50 Offset: 0x31B3F51 VA: 0x31B3E50
	public Expression get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x41CD0 Offset: 0x41DD1 VA: 0x41CD0
	// RVA: 0x31B3E60 Offset: 0x31B3F61 VA: 0x31B3E60
	public LabelTarget get_Target() { }

	[CompilerGeneratedAttribute] // RVA: 0x41CE0 Offset: 0x41DE1 VA: 0x41CE0
	// RVA: 0x31B3E70 Offset: 0x31B3F71 VA: 0x31B3E70
	public GotoExpressionKind get_Kind() { }

	// RVA: 0x31B3E80 Offset: 0x31B3F81 VA: 0x31B3E80 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x31B2BB0 Offset: 0x31B2CB1 VA: 0x31B2BB0
	public GotoExpression Update(LabelTarget target, Expression value) { }
}

