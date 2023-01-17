// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x40150 Offset: 0x40251 VA: 0x40150
public class ParameterExpression : Expression // TypeDefIndex: 2865
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x40AD0 Offset: 0x40BD1 VA: 0x40AD0
	private readonly string <Name>k__BackingField; // 0x10

	// Properties
	public override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public string Name { get; }
	public bool IsByRef { get; }

	// Methods

	// RVA: 0x332C560 Offset: 0x332C661 VA: 0x332C560
	internal void .ctor(string name) { }

	// RVA: 0x332C5E0 Offset: 0x332C6E1 VA: 0x332C5E0
	internal static ParameterExpression Make(Type type, string name, bool isByRef) { }

	// RVA: 0x332CE20 Offset: 0x332CF21 VA: 0x332CE20 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x332CEA0 Offset: 0x332CFA1 VA: 0x332CEA0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0x41F10 Offset: 0x42011 VA: 0x41F10
	// RVA: 0x332CEB0 Offset: 0x332CFB1 VA: 0x332CEB0
	public string get_Name() { }

	// RVA: 0x332CEC0 Offset: 0x332CFC1 VA: 0x332CEC0
	public bool get_IsByRef() { }

	// RVA: 0x332CED0 Offset: 0x332CFD1 VA: 0x332CED0 Slot: 10
	internal virtual bool GetIsByRef() { }

	// RVA: 0x332CEE0 Offset: 0x332CFE1 VA: 0x332CEE0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
}

