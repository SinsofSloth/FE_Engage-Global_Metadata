// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x3FF20 Offset: 0x40021 VA: 0x3FF20
public class MemberExpression : Expression // TypeDefIndex: 2841
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x40A40 Offset: 0x40B41 VA: 0x40A40
	private readonly Expression <Expression>k__BackingField; // 0x10

	// Properties
	public MemberInfo Member { get; }
	public Expression Expression { get; }
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x3325D10 Offset: 0x3325E11 VA: 0x3325D10
	public MemberInfo get_Member() { }

	[CompilerGeneratedAttribute] // RVA: 0x41E50 Offset: 0x41F51 VA: 0x41E50
	// RVA: 0x3325D20 Offset: 0x3325E21 VA: 0x3325D20
	public Expression get_Expression() { }

	// RVA: 0x3325D30 Offset: 0x3325E31 VA: 0x3325D30
	internal void .ctor(Expression expression) { }

	// RVA: 0x3325DB0 Offset: 0x3325EB1 VA: 0x3325DB0
	internal static PropertyExpression Make(Expression expression, PropertyInfo property) { }

	// RVA: 0x3325F30 Offset: 0x3326031 VA: 0x3325F30
	internal static FieldExpression Make(Expression expression, FieldInfo field) { }

	// RVA: 0x3325FA0 Offset: 0x33260A1 VA: 0x3325FA0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41E60 Offset: 0x41F61 VA: 0x41E60
	// RVA: 0x3325FB0 Offset: 0x33260B1 VA: 0x3325FB0 Slot: 10
	internal virtual MemberInfo GetMember() { }

	// RVA: 0x3325FE0 Offset: 0x33260E1 VA: 0x3325FE0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x3326000 Offset: 0x3326101 VA: 0x3326000
	public MemberExpression Update(Expression expression) { }
}

