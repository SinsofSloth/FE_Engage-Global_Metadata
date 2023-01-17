// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x3FDD0 Offset: 0x3FED1 VA: 0x3FDD0
public abstract class LambdaExpression : Expression, IParameterProvider // TypeDefIndex: 2827
{
	// Fields
	private readonly Expression _body; // 0x10

	// Properties
	public sealed override Type Type { get; }
	internal abstract Type TypeCore { get; }
	internal abstract Type PublicType { get; }
	public sealed override ExpressionType NodeType { get; }
	public string Name { get; }
	internal virtual string NameCore { get; }
	public Expression Body { get; }
	public Type ReturnType { get; }
	public bool TailCall { get; }
	internal virtual bool TailCallCore { get; }
	[ExcludeFromCodeCoverageAttribute] // RVA: 0x42560 Offset: 0x42661 VA: 0x42560
	private int System.Linq.Expressions.IParameterProvider.ParameterCount { get; }
	[ExcludeFromCodeCoverageAttribute] // RVA: 0x42570 Offset: 0x42671 VA: 0x42570
	internal virtual int ParameterCount { get; }

	// Methods

	// RVA: 0x31C0120 Offset: 0x31C0221 VA: 0x31C0120
	internal void .ctor(Expression body) { }

	// RVA: 0x31C01A0 Offset: 0x31C02A1 VA: 0x31C01A0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Type get_TypeCore();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract Type get_PublicType();

	// RVA: 0x31C01B0 Offset: 0x31C02B1 VA: 0x31C01B0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x31C01C0 Offset: 0x31C02C1 VA: 0x31C01C0
	public string get_Name() { }

	// RVA: 0x31C01D0 Offset: 0x31C02D1 VA: 0x31C01D0 Slot: 14
	internal virtual string get_NameCore() { }

	// RVA: 0x31C01E0 Offset: 0x31C02E1 VA: 0x31C01E0
	public Expression get_Body() { }

	// RVA: 0x31C01F0 Offset: 0x31C02F1 VA: 0x31C01F0
	public Type get_ReturnType() { }

	// RVA: 0x31C0220 Offset: 0x31C0321 VA: 0x31C0220
	public bool get_TailCall() { }

	// RVA: 0x31C0230 Offset: 0x31C0331 VA: 0x31C0230 Slot: 15
	internal virtual bool get_TailCallCore() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41D90 Offset: 0x41E91 VA: 0x41D90
	// RVA: 0x31C0240 Offset: 0x31C0341 VA: 0x31C0240 Slot: 10
	private ParameterExpression System.Linq.Expressions.IParameterProvider.GetParameter(int index) { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41DA0 Offset: 0x41EA1 VA: 0x41DA0
	// RVA: 0x31C0250 Offset: 0x31C0351 VA: 0x31C0250 Slot: 16
	internal virtual ParameterExpression GetParameter(int index) { }

	// RVA: 0x31C0280 Offset: 0x31C0381 VA: 0x31C0280 Slot: 11
	private int System.Linq.Expressions.IParameterProvider.get_ParameterCount() { }

	// RVA: 0x31C0290 Offset: 0x31C0391 VA: 0x31C0290 Slot: 17
	internal virtual int get_ParameterCount() { }
}

