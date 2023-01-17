// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x3FAC0 Offset: 0x3FBC1 VA: 0x3FAC0
public class ConstantExpression : Expression // TypeDefIndex: 2809
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x40890 Offset: 0x40991 VA: 0x40890
	private readonly object <Value>k__BackingField; // 0x10

	// Properties
	public override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x2E56150 Offset: 0x2E56251 VA: 0x2E56150
	internal void .ctor(object value) { }

	// RVA: 0x2E561D0 Offset: 0x2E562D1 VA: 0x2E561D0 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x2E56270 Offset: 0x2E56371 VA: 0x2E56270 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0x41C50 Offset: 0x41D51 VA: 0x41C50
	// RVA: 0x2E56280 Offset: 0x2E56381 VA: 0x2E56280
	public object get_Value() { }

	// RVA: 0x2E56290 Offset: 0x2E56391 VA: 0x2E56290 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
}

