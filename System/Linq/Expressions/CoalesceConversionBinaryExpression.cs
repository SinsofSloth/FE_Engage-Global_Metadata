// Namespace: System.Linq.Expressions
internal sealed class CoalesceConversionBinaryExpression : BinaryExpression // TypeDefIndex: 2758
{
	// Fields
	private readonly LambdaExpression _conversion; // 0x20

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x2E555F0 Offset: 0x2E556F1 VA: 0x2E555F0
	internal void .ctor(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x2E556A0 Offset: 0x2E557A1 VA: 0x2E556A0 Slot: 11
	internal override LambdaExpression GetConversion() { }

	// RVA: 0x2E556B0 Offset: 0x2E557B1 VA: 0x2E556B0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x2E556C0 Offset: 0x2E557C1 VA: 0x2E556C0 Slot: 5
	public sealed override Type get_Type() { }
}

