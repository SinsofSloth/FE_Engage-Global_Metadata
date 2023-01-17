// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x40070 Offset: 0x40171 VA: 0x40070
public class NewArrayExpression : Expression // TypeDefIndex: 2861
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x40AA0 Offset: 0x40BA1 VA: 0x40AA0
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x40AB0 Offset: 0x40BB1 VA: 0x40AB0
	private readonly ReadOnlyCollection<Expression> <Expressions>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public ReadOnlyCollection<Expression> Expressions { get; }

	// Methods

	// RVA: 0x33294A0 Offset: 0x33295A1 VA: 0x33294A0
	internal void .ctor(Type type, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x3329730 Offset: 0x3329831 VA: 0x3329730
	internal static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions) { }

	[CompilerGeneratedAttribute] // RVA: 0x41EE0 Offset: 0x41FE1 VA: 0x41EE0
	// RVA: 0x3329910 Offset: 0x3329A11 VA: 0x3329910 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x41EF0 Offset: 0x41FF1 VA: 0x41EF0
	// RVA: 0x3329920 Offset: 0x3329A21 VA: 0x3329920
	public ReadOnlyCollection<Expression> get_Expressions() { }

	// RVA: 0x3329930 Offset: 0x3329A31 VA: 0x3329930 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x3329950 Offset: 0x3329A51 VA: 0x3329950
	public NewArrayExpression Update(IEnumerable<Expression> expressions) { }
}

