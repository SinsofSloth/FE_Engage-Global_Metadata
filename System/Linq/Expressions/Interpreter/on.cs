// Namespace: System.Linq.Expressions.Interpreter
internal sealed class QuoteInstruction : Instruction // TypeDefIndex: 3259
{
	// Fields
	private readonly Expression _operand; // 0x10
	private readonly Dictionary<ParameterExpression, LocalVariable> _hoistedVariables; // 0x18

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x332D280 Offset: 0x332D381 VA: 0x332D280
	public void .ctor(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables) { }

	// RVA: 0x332D2D0 Offset: 0x332D3D1 VA: 0x332D2D0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x332D2E0 Offset: 0x332D3E1 VA: 0x332D2E0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332D330 Offset: 0x332D431 VA: 0x332D330 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

