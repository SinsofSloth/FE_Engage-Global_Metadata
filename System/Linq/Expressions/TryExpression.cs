// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x40320 Offset: 0x40421 VA: 0x40320
public sealed class TryExpression : Expression // TypeDefIndex: 2876
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x40B70 Offset: 0x40C71 VA: 0x40B70
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x40B80 Offset: 0x40C81 VA: 0x40B80
	private readonly Expression <Body>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x40B90 Offset: 0x40C91 VA: 0x40B90
	private readonly ReadOnlyCollection<CatchBlock> <Handlers>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x40BA0 Offset: 0x40CA1 VA: 0x40BA0
	private readonly Expression <Finally>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x40BB0 Offset: 0x40CB1 VA: 0x40BB0
	private readonly Expression <Fault>k__BackingField; // 0x30

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public ReadOnlyCollection<CatchBlock> Handlers { get; }
	public Expression Finally { get; }
	public Expression Fault { get; }

	// Methods

	// RVA: 0x33340E0 Offset: 0x33341E1 VA: 0x33340E0
	internal void .ctor(Type type, Expression body, Expression finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) { }

	[CompilerGeneratedAttribute] // RVA: 0x41FB0 Offset: 0x420B1 VA: 0x41FB0
	// RVA: 0x33341C0 Offset: 0x33342C1 VA: 0x33341C0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x33341D0 Offset: 0x33342D1 VA: 0x33341D0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0x41FC0 Offset: 0x420C1 VA: 0x41FC0
	// RVA: 0x33341E0 Offset: 0x33342E1 VA: 0x33341E0
	public Expression get_Body() { }

	[CompilerGeneratedAttribute] // RVA: 0x41FD0 Offset: 0x420D1 VA: 0x41FD0
	// RVA: 0x33341F0 Offset: 0x33342F1 VA: 0x33341F0
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	[CompilerGeneratedAttribute] // RVA: 0x41FE0 Offset: 0x420E1 VA: 0x41FE0
	// RVA: 0x3334200 Offset: 0x3334301 VA: 0x3334200
	public Expression get_Finally() { }

	[CompilerGeneratedAttribute] // RVA: 0x41FF0 Offset: 0x420F1 VA: 0x41FF0
	// RVA: 0x3334210 Offset: 0x3334311 VA: 0x3334210
	public Expression get_Fault() { }

	// RVA: 0x3334220 Offset: 0x3334321 VA: 0x3334220 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x3334240 Offset: 0x3334341 VA: 0x3334240
	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression finally, Expression fault) { }
}

