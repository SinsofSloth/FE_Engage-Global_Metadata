// Namespace: System.Linq.Expressions
internal class SimpleBinaryExpression : BinaryExpression // TypeDefIndex: 2760
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x407F0 Offset: 0x408F1 VA: 0x407F0
	private readonly ExpressionType <NodeType>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x40800 Offset: 0x40901 VA: 0x40800
	private readonly Type <Type>k__BackingField; // 0x28

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x3326150 Offset: 0x3326251 VA: 0x3326150
	internal void .ctor(ExpressionType nodeType, Expression left, Expression right, Type type) { }

	[CompilerGeneratedAttribute] // RVA: 0x41A50 Offset: 0x41B51 VA: 0x41A50
	// RVA: 0x332F040 Offset: 0x332F141 VA: 0x332F040 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0x41A60 Offset: 0x41B61 VA: 0x41A60
	// RVA: 0x332F050 Offset: 0x332F151 VA: 0x332F050 Slot: 5
	public sealed override Type get_Type() { }
}

