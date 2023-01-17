// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x3F9D0 Offset: 0x3FAD1 VA: 0x3F9D0
public sealed class CatchBlock // TypeDefIndex: 2802
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x40820 Offset: 0x40921 VA: 0x40820
	private readonly ParameterExpression <Variable>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x40830 Offset: 0x40931 VA: 0x40830
	private readonly Type <Test>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x40840 Offset: 0x40941 VA: 0x40840
	private readonly Expression <Body>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x40850 Offset: 0x40951 VA: 0x40850
	private readonly Expression <Filter>k__BackingField; // 0x28

	// Properties
	public ParameterExpression Variable { get; }
	public Type Test { get; }
	public Expression Body { get; }
	public Expression Filter { get; }

	// Methods

	// RVA: 0x2E551B0 Offset: 0x2E552B1 VA: 0x2E551B0
	internal void .ctor(Type test, ParameterExpression variable, Expression body, Expression filter) { }

	[CompilerGeneratedAttribute] // RVA: 0x41BD0 Offset: 0x41CD1 VA: 0x41BD0
	// RVA: 0x2E55230 Offset: 0x2E55331 VA: 0x2E55230
	public ParameterExpression get_Variable() { }

	[CompilerGeneratedAttribute] // RVA: 0x41BE0 Offset: 0x41CE1 VA: 0x41BE0
	// RVA: 0x2E55240 Offset: 0x2E55341 VA: 0x2E55240
	public Type get_Test() { }

	[CompilerGeneratedAttribute] // RVA: 0x41BF0 Offset: 0x41CF1 VA: 0x41BF0
	// RVA: 0x2E55250 Offset: 0x2E55351 VA: 0x2E55250
	public Expression get_Body() { }

	[CompilerGeneratedAttribute] // RVA: 0x41C00 Offset: 0x41D01 VA: 0x41C00
	// RVA: 0x2E55260 Offset: 0x2E55361 VA: 0x2E55260
	public Expression get_Filter() { }

	// RVA: 0x2E55270 Offset: 0x2E55371 VA: 0x2E55270 Slot: 3
	public override string ToString() { }

	// RVA: 0x2E55280 Offset: 0x2E55381 VA: 0x2E55280
	public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body) { }
}

