// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x3FD60 Offset: 0x3FE61 VA: 0x3FD60
public sealed class LabelExpression : Expression // TypeDefIndex: 2825
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x40970 Offset: 0x40A71 VA: 0x40970
	private readonly LabelTarget <Target>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x40980 Offset: 0x40A81 VA: 0x40980
	private readonly Expression <DefaultValue>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public LabelTarget Target { get; }
	public Expression DefaultValue { get; }

	// Methods

	// RVA: 0x31BF070 Offset: 0x31BF171 VA: 0x31BF070
	internal void .ctor(LabelTarget label, Expression defaultValue) { }

	// RVA: 0x31BF110 Offset: 0x31BF211 VA: 0x31BF110 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x31BF120 Offset: 0x31BF221 VA: 0x31BF120 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0x41D50 Offset: 0x41E51 VA: 0x41D50
	// RVA: 0x31BF130 Offset: 0x31BF231 VA: 0x31BF130
	public LabelTarget get_Target() { }

	[CompilerGeneratedAttribute] // RVA: 0x41D60 Offset: 0x41E61 VA: 0x41D60
	// RVA: 0x31BF140 Offset: 0x31BF241 VA: 0x31BF140
	public Expression get_DefaultValue() { }

	// RVA: 0x31BF150 Offset: 0x31BF251 VA: 0x31BF150 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x31B2DF0 Offset: 0x31B2EF1 VA: 0x31B2DF0
	public LabelExpression Update(LabelTarget target, Expression defaultValue) { }
}

