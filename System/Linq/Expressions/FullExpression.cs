// Namespace: System.Linq.Expressions
internal sealed class FullExpression<TDelegate> : ExpressionN<TDelegate> // TypeDefIndex: 2835
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x409B0 Offset: 0x40AB1 VA: 0x409B0
	private readonly string <NameCore>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x409C0 Offset: 0x40AC1 VA: 0x409C0
	private readonly bool <TailCallCore>k__BackingField; // 0x0

	// Properties
	internal override string NameCore { get; }
	internal override bool TailCallCore { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4CB60 Offset: 0x1E4CC61 VA: 0x1E4CB60
	|-FullExpression<object>..ctor
	*/

	[CompilerGeneratedAttribute] // RVA: 0x41DC0 Offset: 0x41EC1 VA: 0x41DC0
	// RVA: -1 Offset: -1 Slot: 14
	internal override string get_NameCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4CBC0 Offset: 0x1E4CCC1 VA: 0x1E4CBC0
	|-FullExpression<object>.get_NameCore
	*/

	[CompilerGeneratedAttribute] // RVA: 0x41DD0 Offset: 0x41ED1 VA: 0x41DD0
	// RVA: -1 Offset: -1 Slot: 15
	internal override bool get_TailCallCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4CBD0 Offset: 0x1E4CCD1 VA: 0x1E4CBD0
	|-FullExpression<object>.get_TailCallCore
	*/
}

