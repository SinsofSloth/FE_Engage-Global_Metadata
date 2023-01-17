// Namespace: System.Linq.Expressions
public sealed class ElementInit : IArgumentProvider // TypeDefIndex: 2813
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x408D0 Offset: 0x409D1 VA: 0x408D0
	private readonly MethodInfo <AddMethod>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x408E0 Offset: 0x409E1 VA: 0x408E0
	private readonly ReadOnlyCollection<Expression> <Arguments>k__BackingField; // 0x18

	// Properties
	public MethodInfo AddMethod { get; }
	public ReadOnlyCollection<Expression> Arguments { get; }
	public int ArgumentCount { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x41C90 Offset: 0x41D91 VA: 0x41C90
	// RVA: 0x2E57D60 Offset: 0x2E57E61 VA: 0x2E57D60
	public MethodInfo get_AddMethod() { }

	[CompilerGeneratedAttribute] // RVA: 0x41CA0 Offset: 0x41DA1 VA: 0x41CA0
	// RVA: 0x2E57D70 Offset: 0x2E57E71 VA: 0x2E57D70
	public ReadOnlyCollection<Expression> get_Arguments() { }

	// RVA: 0x2E57D80 Offset: 0x2E57E81 VA: 0x2E57D80 Slot: 4
	public Expression GetArgument(int index) { }

	// RVA: 0x2E57DE0 Offset: 0x2E57EE1 VA: 0x2E57DE0 Slot: 5
	public int get_ArgumentCount() { }
}

