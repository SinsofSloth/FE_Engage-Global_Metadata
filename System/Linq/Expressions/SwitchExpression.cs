// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x402B0 Offset: 0x403B1 VA: 0x402B0
public sealed class SwitchExpression : Expression // TypeDefIndex: 2874
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x40B20 Offset: 0x40C21 VA: 0x40B20
	private readonly Expression <SwitchValue>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x40B30 Offset: 0x40C31 VA: 0x40B30
	private readonly ReadOnlyCollection<SwitchCase> <Cases>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x40B40 Offset: 0x40C41 VA: 0x40B40
	private readonly Expression <DefaultBody>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x40B50 Offset: 0x40C51 VA: 0x40B50
	private readonly MethodInfo <Comparison>k__BackingField; // 0x28

	// Properties
	public Expression SwitchValue { get; }
	public ReadOnlyCollection<SwitchCase> Cases { get; }
	public Expression DefaultBody { get; }
	public MethodInfo Comparison { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x41F60 Offset: 0x42061 VA: 0x41F60
	// RVA: 0x3333550 Offset: 0x3333651 VA: 0x3333550
	public Expression get_SwitchValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x41F70 Offset: 0x42071 VA: 0x41F70
	// RVA: 0x3333560 Offset: 0x3333661 VA: 0x3333560
	public ReadOnlyCollection<SwitchCase> get_Cases() { }

	[CompilerGeneratedAttribute] // RVA: 0x41F80 Offset: 0x42081 VA: 0x41F80
	// RVA: 0x3333570 Offset: 0x3333671 VA: 0x3333570
	public Expression get_DefaultBody() { }

	[CompilerGeneratedAttribute] // RVA: 0x41F90 Offset: 0x42091 VA: 0x41F90
	// RVA: 0x3333580 Offset: 0x3333681 VA: 0x3333580
	public MethodInfo get_Comparison() { }
}

