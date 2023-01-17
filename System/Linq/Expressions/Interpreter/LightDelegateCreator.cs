// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LightDelegateCreator // TypeDefIndex: 3093
{
	// Fields
	private readonly LambdaExpression _lambda; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x40C70 Offset: 0x40D71 VA: 0x40C70
	private readonly Interpreter <Interpreter>k__BackingField; // 0x18

	// Properties
	internal Interpreter Interpreter { get; }

	// Methods

	// RVA: 0x3322710 Offset: 0x3322811 VA: 0x3322710
	internal void .ctor(Interpreter interpreter, LambdaExpression lambda) { }

	[CompilerGeneratedAttribute] // RVA: 0x421C0 Offset: 0x422C1 VA: 0x421C0
	// RVA: 0x3322760 Offset: 0x3322861 VA: 0x3322760
	internal Interpreter get_Interpreter() { }

	// RVA: 0x3322770 Offset: 0x3322871 VA: 0x3322770
	public Delegate CreateDelegate() { }

	// RVA: 0x3322780 Offset: 0x3322881 VA: 0x3322780
	internal Delegate CreateDelegate(IStrongBox[] closure) { }
}

